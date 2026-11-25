using Anglr.Compiler;
using Anglr.Declarations;
using Anglr.Parser;
using Anglr.Parser.Core;
using Anglr.Parser.SyntaxTree;
using Anglr.Parser.Walker;
using AnglrBreakPointDBLibrary;
using AnglrLibrary;
using AnglrLogLibrary;
using Asn.Declarations;
using Asn.Lexer;
using Asn.Parser;
using Asn.Scanner;
using AsnLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Collections;

namespace AsnParserExample
{
    internal class Program
    {
        static void Main (string [] args) => (new AsnParserExample ()).MainTask (args);
    }

    public class AsnRhsConfiguration : IEnumerable<RhsNode>, IEnumerator<RhsNode>
    {
        public RhsProduction RhsProduction { get; }
        private rhslist RhsNodes { get; }
        private int Size { get; }
        public int Position { get; private set; }
        public int DotPosition { get; }
        public bool AtEnd => DotPosition >= Size;
        public RhsNode DotNode => AtEnd ? null : RhsNodes [DotPosition];

        public RhsNode Current => (Position < Size) ? RhsNodes [Position] : null;

        object IEnumerator.Current => Current;

        public AsnRhsConfiguration (RhsProduction rhsProduction, int dotPosition)
        {
            RhsProduction = rhsProduction;
            RhsNodes = RhsProduction.rhsNodes;
            Size = RhsProduction.rhsNodes.Count;
            DotPosition = Math.Max (0, Math.Min (Size, dotPosition));
            Position = -1;
        }

        public AsnRhsConfiguration Next () => new AsnRhsConfiguration (RhsProduction, DotPosition + 1);
        public AsnRhsConfiguration Previous () => new AsnRhsConfiguration (RhsProduction, DotPosition - 1);

        public IEnumerator<RhsNode> GetEnumerator ()
        {
            Reset ();
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator ()
        {
            return GetEnumerator ();
        }

        public bool MoveNext () => ++Position < Size;

        public void Reset () => Position = -1;

        public void Dispose ()
        {
        }
    }

    public class AsnRhsConfigurationComparer : IComparer<AsnRhsConfiguration>
    {
        public int Compare (AsnRhsConfiguration? x, AsnRhsConfiguration? y) =>
            (x == null) ? ((y == null) ? 0 : -1) : ((y == null) ? 1 :
            (x.RhsProduction.productionNumber != y.RhsProduction.productionNumber) ?
                (x.RhsProduction.productionNumber - y.RhsProduction.productionNumber) :
                x.AtEnd ? (y.AtEnd ? 0 : -1) : (y.AtEnd ? 1 : x.DotPosition - y.DotPosition));
    }

    public class AsnRhsConfigSet : SortedSet<AsnRhsConfiguration>
    {
        public AsnRhsConfigSet () : base (new AsnRhsConfigurationComparer ()) { }
    }

    public class AsnLogger : AnglrLoggerBase
    {
        protected override void Write (AnglrLogLevel level, string message, uint flags = 0)
        {
            try
            {
                if ((flags & WriteOnlyMsg) != 0)
                    System.Diagnostics.Debug.WriteLine ($"{message}");
                else
                    System.Diagnostics.Debug.WriteLine ($"{DateTime.Now.ToString ("yyyy-MM-dd HH:mm:ss.fff")} - {level} - {message}");
            }
            catch (Exception e)
            {
            }
        }

        protected override void WriteLine (AnglrLogLevel level, string message, uint flags = 0) => Write (level, message, flags);
    }

    internal class AsnParserExample
    {
        public IAnglrLogger Logger { get; private set; }
        [AllowNull] public AsnParser Parser { get; private set; }
        [AllowNull] public AsnLexer Lexer { get; private set; }
        [AllowNull] public anglrCompiler AnglrCompiler { get; private set; }
        [AllowNull] public string GrammarFileName { get; private set; }
        [AllowNull] public SyntaxTreeBase GrammarSyntaxTree { get; private set; }
        [AllowNull] public AnglrParserStatesGenerator GrammarStatesGenerator { get; private set; }
        private bool reduceBP = false;

        public AsnParserExample ()
        {
            Logger = new AsnLogger ();
            AnglrCompiler = null;
            GrammarFileName = null;
            GrammarSyntaxTree = null;
        }

        internal void MainTask (string [] args)
        {
            // global flags should be set before AsnParser object creation
            AsnParser.createParseTree = true;
            AsnParser.loopDetection = true;

            // starting token. Starting syntax rule for ASN.1 is asn-features.
            // This syntax rule is actually a swith statement of syntax rules
            // describing different ASN.1 features. These syntax rules support
            // compilation of ASN.1 file parts. The 'highest' part is syntax
            // rule named ModuleDefinitions. This syntax rule supports compilaton
            // of any number of ASN.1 module definitions. To distinguish these
            // syntax rules every one of them is preceeded with dedicated artifical
            // terminal symbol. These terminal symbols have no textual representations
            // and should be generated by environment invoking parser and lexical
            // analyzes. Special lexer event scannerEnterEvent is reserved for this
            // purpose. If this event returns positive value it is recognised by
            // lexer as normal terminal symbol without textual representation and
            // its value is reported to the parser. This terminal symbol must be
            // reported at the very beginning of parsing process, at the first
            // invocation of scannerEnterEvent and then never again.
            int startToken = AsnDeclarations.tokens.ModuleDefinitions_token;

            bool grammarFlag = false;
            // parse every source file named in command line
            foreach (string arg in args)
            {
                if (arg == "-grammar")
                {
                    grammarFlag = true;
                    continue;
                }
                if (grammarFlag)
                {
                    grammarFlag = false;
                    GrammarFileName = arg;
                    InvokeAnglrCompiler ();
                    continue;
                }

                Parser = new AsnParser ();
                Lexer = new AsnLexer (new StreamReader (arg));

                // registration of scannerEnterEvent. It should be unregistered if it
                // will not be used any more
                Lexer.scannerEnterEvent += () =>
                {
                    try
                    {
                        // insert start token (ModuleDefinitions_token in this case)
                        return startToken;
                    }
                    finally
                    {
                        // don't insert it again
                        startToken = -1;
                    }
                };

                // register method reporting syntax errors
                Parser.Error_Event += (int lineno, int column, int token, string tokenString) =>
                {
                    Console.Error.WriteLine ($"Syntax error: file ({arg}), line ({lineno}), column ({column}), token ({token} - {tokenString}");
                    return true;    // continue parsing
                };

                // implement all CstringRegex's events otherwise they will throw exceptions
                // or they will mimic 'skip' scanner operation if you delete them
                {
                    Asn.RegexLib.CstringRegex scanner = Lexer.CstringRegex;
                    scanner._end_of_string__Event += (r, s) =>
                    {
                        s.popScanner ("");
                        if (s.regexIndex != AsnLexer.asnScanner)
                            return 0;
                        return AsnDeclarations.tokens.cstring;
                    };
                }
                // implement all MacroRegex's events otherwise they will throw exceptions
                // or they will mimic 'skip' scanner operation if you delete them
                {
                    Asn.RegexLib.MacroRegex scanner = Lexer.MacroRegex;
                    scanner._type_reference__Event += (r, s) =>
                    {
                        if (AsnKeywordDB.FindKeyword (r.text) != AsnDeclarations.tokens.END)
                            return 0;
                        s.popScanner ("");
                        return AsnDeclarations.tokens.END;
                    };
                }
                // implement all AsnRegex's events otherwise they will throw exceptions
                // or they will mimic 'skip' scanner operation if you delete them
                {
                    Asn.RegexLib.AsnRegex scanner = Lexer.AsnRegex;
                    scanner._type_reference__Event += (r, s) =>
                    {
                        int t;
                        if ((t = AsnKeywordDB.FindKeyword (r.text)) < 0)
                            return AsnDeclarations.tokens.typereference;
                        return t;
                    };
                    scanner._identifier__Event += (r, s) =>
                    {
                        int t;
                        if ((t = AsnKeywordDB.FindKeyword (r.text)) < 0)
                            return AsnDeclarations.tokens.identifier;
                        return t;
                    };
                }

                if (AnglrCompiler != null)
                {
                    int magicNr = Parser.magicNumber ();
                    if (GrammarStatesGenerator.magicNr != magicNr)
                        ;
                    Parser.StartParserEvent += Parser_StartParserEvent;
                    Parser.SyntaxErrorEvent += Parser_SyntaxErrorEvent;
                    Parser.ShiftStepEvent += Parser_ShiftStepEvent;
                    Parser.ReduceStepEvent += Parser_ReduceStepEvent;
                    Parser.SplitStepEvent += Parser_SplitStepEvent;
                    Parser.LoopStepEvent += Parser_LoopStepEvent;
                    Parser.JoinEvent += Parser_JoinEvent;
                    Parser.FinalStepEvent += Parser_FinalStepEvent;
                    Parser.StopParserEvent += Parser_StopParserEvent;
                }

                Parser.Assignment_Event += (SyntaxTreeCallbackReason reason, Assignment.production_kind kind, Assignment p_Assignment) =>
                {
                    if (reason == SyntaxTreeCallbackReason.BuilderCallbackReason)
                        reduceBP = true;
                    return true;
                };

                // invoke parser
                if (Parser.parse (Lexer) != 0)
                    continue;   // errors, skip current file

                // visit every node of every syntax tree generated for current source file
                foreach (var syntaxTree in Parser.parseList)
                {
                    // establish clear parent-child relationships
                    syntaxTree.reparent (null);
                    // create walker object
                    AsnSyntaxTreeVisitor asnSyntaxTreeVisitor = new AsnSyntaxTreeVisitor ();
                    // visit all nodes of syntax tree
                    asnSyntaxTreeVisitor.Traverse (syntaxTree as asn_features);
                }
            }
        }

        private void DisplayParserPDAStacks (string ruleName, int fallingState, int bottomState, int risingState)
        {
            return;
            Logger?.InfoLine ($"reduce break-point: rule '{ruleName}', transition {fallingState} -> {bottomState} -> {risingState}");
            foreach (var stack in Parser.stackSet)
            {
                Logger?.InfoLine ($"stack: {stack.stackCounter}");
                int [] stateStack = stack.stateStack.ToArray ();
                int stackDepth = stack.stateStack.stackDepth;
                for (int i = 0; i < stackDepth; ++i)
                    Logger?.InfoLine ($"\t{stateStack [i]}");
            }
        }

        private void AnalyzeParserPDAStacks ()
        {
            int stackCount = Parser.stackSet.Count;
            int stackCounter = 0;
            foreach (var stack in Parser.stackSet)
            {
                List<AsnRhsConfigSet> configSets = new List<AsnRhsConfigSet> ();
                ++stackCounter;
                Logger?.InfoLine ($"stack {stack.stackCounter} ({stackCounter}/{stackCount})", AnglrLoggerBase.WriteOnlyMsg);

                int [] stateStack = stack.stateStack.ToArray ();
                int stackDepth = stack.stateStack.stackDepth;

                List<RhsState> rhsStates = new List<RhsState> ();
                for (int i = 0; i < stackDepth; ++i)
                {
                    rhsStates.Add (GrammarStatesGenerator.GetRhsState (stateStack [i]));
                }
                rhsStates.Add (null);

                // *** COLLECT ***
                for (int i = 0; i < stackDepth; ++i)
                {
                    int stateNr = stateStack [i];
                    AsnRhsConfigSet transitions = new AsnRhsConfigSet ();
                    configSets.Add (transitions);
                    RhsState rhsState = GrammarStatesGenerator.GetRhsState (stateNr);
                    rhscfgset core = rhsState.m_core;
                    closurelist closure = rhsState.m_closure;
                    Logger?.InfoLine ($"\tState {stateNr}, {rhsState.m_SymbolToken.name}", AnglrLoggerBase.WriteOnlyMsg);

                    RhsState refState = rhsStates [i + 1];
                    SymbolToken refSymbol = null;
                    if ((refState == null) || ((refSymbol = refState.m_SymbolToken) == null))
                        continue;

                    Queue<SymbolToken> queue = new Queue<SymbolToken> ();
                    queue.Enqueue (refSymbol);
                    while (queue.Count > 0)
                    {
                        refSymbol = queue.Dequeue ();
                        foreach (var element in core.Values)
                        {
                            RhsProduction production = element.rhsProduction;
                            AsnRhsConfiguration configuration = new AsnRhsConfiguration (production, element.rhsIterator.position);
                            if (!configuration.AtEnd && (configuration.DotNode.symbolToken.id != refSymbol.id))
                                continue;
                            if (transitions.TryGetValue (configuration, out _))
                                continue;
                            transitions.Add (configuration);
                            DisplayTransition (configuration);
                        }
                        foreach (var element in closure.Values)
                        {
                            RhsProductionNode productionNode = element.rhsProductionNode;
                            foreach (var production in productionNode.Productions)
                            {
                                if (production.rhsNodes.Count == 0)
                                    continue;
                                RhsNode rhsNode = production.rhsNodes [0];
                                if (rhsNode.symbolToken.id != refSymbol.id)
                                    continue;
                                AsnRhsConfiguration configuration = new AsnRhsConfiguration (production, 0);
                                if (transitions.TryGetValue (configuration, out _))
                                    continue;
                                queue.Enqueue (production.symbolToken);
                                transitions.Add (configuration);
                                DisplayTransition (configuration);
                            }
                        }
                    }
                }

                // *** OPTIMIZE ***
                for (int i = 0; i < stackDepth; ++i)
                {
                    int stateNr = stateStack [i];

                    RhsState refState = rhsStates [i + 1];
                    SymbolToken refSymbol = null;
                    if ((refState == null) || ((refSymbol = refState.m_SymbolToken) == null))
                        continue;

                    AsnRhsConfigSet transitions = new AsnRhsConfigSet ();
                    AsnRhsConfigSet oldTransitions = configSets [i];
                    AsnRhsConfigSet refTransitions = configSets [i + 1];

                    foreach (var transition in oldTransitions)
                    {
                        if (transition.AtEnd || (transition.DotNode.symbolToken.id != refSymbol.id))
                        {
                            transitions.Add (transition);
                            continue;
                        }
                        if (refTransitions.TryGetValue (transition.Next (), out _))
                            transitions.Add (transition);
                    }
                    configSets [i] = transitions;
                }

                // *** DISPLAY ***
                for (int i = 0; i < stackDepth; ++i)
                {
                    int stateNr = stateStack [i];
                    RhsState rhsState = GrammarStatesGenerator.GetRhsState (stateNr);
                    Logger?.InfoLine ($"\tState {stateNr}, {rhsState.m_SymbolToken.name}", AnglrLoggerBase.WriteOnlyMsg);

                    AsnRhsConfigSet transitions = configSets [i];

                    foreach (var transition in transitions)
                    {
                        DisplayTransition (transition);
                    }
                }
            }
        }

        private void DisplayTransition (AsnRhsConfiguration transition)
        {
            int rhsPosition = transition.DotPosition;
            Logger?.InfoLine
            (
                (t) =>
                {
                    StringBuilder sb = new StringBuilder ();
                    RhsProduction production = t.RhsProduction;
                    sb.Append ($"\t\t{production.symbolToken.name}:");
                    bool reduction = true;
                    foreach (var node in transition)
                    {
                        if (rhsPosition == transition.Position)
                        {
                            sb.Append ($" .");
                            reduction = false;
                        }
                        sb.Append ($" {node.symbolToken.name}");
                    }
                    if (reduction)
                    {
                        sb.Append ($" .");
                        reduction = false;
                    }
                    return sb.ToString ();
                },
                transition,
                AnglrLoggerBase.WriteOnlyMsg
            );
        }

        private void Parser_StartParserEvent (int stackNr, object [] info = null)
        {
        }

        private void Parser_SyntaxErrorEvent (int stackNr, int state)
        {
        }

        private void Parser_ShiftStepEvent (int stackNr, int state, int tokenValue, string tokenName, string tokenText, bool conflict)
        {
        }

        private void Parser_ReduceStepEvent (int stackNr, int prodNr, int ruleNr, string ruleName, int prodLen, int fallingState, int bottomState, int risingState, SyntaxTreeBase currentValue, bool conflict)
        {
            if (reduceBP)
            {
                DisplayParserPDAStacks (ruleName, fallingState, bottomState, risingState);
                AnalyzeParserPDAStacks ();
                reduceBP = false;
            }
        }

        private void Parser_SplitStepEvent (int stackNr, int state, bool begin)
        {
        }

        private void Parser_LoopStepEvent (int stackNr, int state)
        {
        }

        private void Parser_JoinEvent (int stackNr, int joinNr)
        {
        }

        private void Parser_FinalStepEvent (int stackNr)
        {
        }

        private void Parser_StopParserEvent ()
        {
        }

        private void InvokeAnglrCompiler ()
        {
            if (GrammarFileName != null)
            {
                AnglrParser.createParseTree = true;
                AnglrParser.loopDetection = true;
                anglrCompiler.createPrecedenceGrammar = false;
                anglrCompiler.createIterators = true;

                AnglrCompiler = new anglrCompiler (null, Logger);
                AnglrCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                {
                    return true;
                };

                int res = AnglrCompiler.Parse (GrammarFileName, AnglrDeclarations.tokens._anglr_file_terminal_, new object [] { Path.GetFileNameWithoutExtension (GrammarFileName), "File Name", GrammarFileName });
                if (res != 0)
                    return;
                GrammarSyntaxTree = null;
                foreach (SyntaxTreeBase node in AnglrCompiler.parseList)
                {
                    if (node == null)
                        continue;
                    GrammarSyntaxTree = node;
                }
                if (GrammarSyntaxTree == null)
                    return;
                GrammarStatesGenerator = new AnglrParserStatesGenerator (AnglrCompiler);
                GrammarStatesGenerator?.GenerateParserStates ();
            }
        }
    }

    internal class AsnSyntaxTreeVisitor : Asn.Parser.SyntaxTreeWalker
    {
        internal AsnSyntaxTreeVisitor ()
        {
            // visitor of Assignment nodes
            Assignment_Event += AsnSyntaxTreeVisitor_Assignment_Event;
            // add visitors for any node type you like
        }

        // visitor of Assignment nodes
        private bool AsnSyntaxTreeVisitor_Assignment_Event (SyntaxTreeCallbackReason reason, Assignment.production_kind kind, Assignment p_Assignment)
        {
            switch (reason)
            {
            case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                // display assignment type of Assignment node
                // this is done after visiting node
                // since 'reason == TraversalEpilogueCallbackReason'
                switch (kind)
                {
                case Assignment.production_kind.g_Assignment_1:
                    Console.WriteLine ("*** TypeAssignment ***");
                    break;
                case Assignment.production_kind.g_Assignment_2:
                    Console.WriteLine ("*** ValueAssignment ***");
                    break;
                case Assignment.production_kind.g_Assignment_3:
                    Console.WriteLine ("*** XMLValueAssignment ***");
                    break;
                case Assignment.production_kind.g_Assignment_4:
                    Console.WriteLine ("*** ValueSetTypeAssignment ***");
                    break;
                case Assignment.production_kind.g_Assignment_5:
                    Console.WriteLine ("*** ObjectClassAssignment ***");
                    break;
                case Assignment.production_kind.g_Assignment_6:
                    Console.WriteLine ("*** ObjectAssignment ***");
                    break;
                case Assignment.production_kind.g_Assignment_7:
                    Console.WriteLine ("*** ObjectSetAssignment ***");
                    break;
                case Assignment.production_kind.g_Assignment_8:
                    Console.WriteLine ("*** ParameterizedAssignment ***");
                    break;
                case Assignment.production_kind.g_Assignment_9:
                    Console.WriteLine ("*** MacroAssignment ***");
                    break;
                case Assignment.production_kind.g_Assignment_10:
                    Console.WriteLine ("*** MacroDefinition ***");
                    break;
                }
                break;
            default:
                break;
            }
            Console.WriteLine ($"{p_Assignment.Emit (-1)}");
            return true;
        }
    }
}
