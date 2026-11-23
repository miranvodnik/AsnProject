using Anglr.Parser.Core;
using Anglr.Parser.SyntaxTree;
using Anglr.Parser.Walker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asn.Parser;
using Asn.Declarations;
using System.IO;
using AsnLibrary;

namespace Asn.Compiler
{
    class Program
    {
        static bool g_error = true;
        static int g_errorCount = 0;
        //static SymbolTable symTab = new SymbolTable ();

        static void Main (string [] args)
        {
            string fname = "";
            int res = -1;

            AsnCompiler.loopDetection = true;
            AsnCompiler.createParseTree = true;
            foreach (string arg in args)
            {
                if (arg == "-d")
                {
                    AsnCompiler.debug = true;
                    continue;
                }
                if (arg == "-e")
                {
                    g_error = false;
                    continue;
                }
                fname = arg;
                try
                {
                    FileAttributes attributes = File.GetAttributes (fname);
                    if ((attributes & FileAttributes.Directory) != FileAttributes.Directory)
                    {
                        if (Path.GetExtension (fname) != ".asn")
                        {
                            Console.Error.WriteLine ($"ERROR: Incorrect file name suffix: {fname}");
                            continue;
                        }
                        g_errorCount = 0;
                        AsnCompiler parser = new AsnCompiler ();
                        parser.Error_Event += Invoke_Error_Callback;
                        Console.WriteLine ($"Parse grammar file '{fname}'");
                        res = parser.Parse (fname, new int [] { (int) AsnDeclarations.tokens.ModuleDefinitions_token });
                        if (res == 0)
                        {
                            parselist p_synlist = parser.parseList;
                            foreach (SyntaxTreeBase node in parser.parseList)
                            {
                                if (node == null)
                                    continue;
                                parser.Traverse ((asn_features) node);
                            }
                        }
                        if (g_errorCount > 0)
                            Console.Error.WriteLine ($"ERROR: errors in {fname}");
                    }
                    else
                    {
                        AsnCompiler parser = new AsnCompiler ();
                        parser.Error_Event += Invoke_Error_Callback;
                        foreach (FileInfo fileInfo in (new DirectoryInfo (fname)).GetFiles ())
                        {
                            fname = fileInfo.FullName;
                            if (Path.GetExtension (fname) != ".asn")
                            {
                                Console.Error.WriteLine ($"ERROR: Incorrect file name suffix: {fname}");
                                continue;
                            }
                            g_errorCount = 0;
                            Console.WriteLine ($"Parse grammar file '{fname}'");
                            res = parser.Parse (fname, new int [] { (int) AsnDeclarations.tokens.ModuleDefinitions_token });
                            if (res == 0)
                            {
                                parselist p_synlist = parser.parseList;
                                foreach (SyntaxTreeBase node in parser.parseList)
                                {
                                    if (node == null)
                                        continue;
                                    node.reparent (null);
                                    AsnDataBase.asnFeatures.Add (((asn_features) node, fname));
                                }
                            }
                            if (g_errorCount > 0)
                                Console.Error.WriteLine ($"ERROR: errors in {fname}");
                            parser.reset ();
                        }

                        res = parser.ParseStringList (AsnDataBase.GlobalModule, new int [] { (int) AsnDeclarations.tokens.ModuleDefinitions_token });
                        if (res == 0)
                        {
                            parselist p_synlist = parser.parseList;
                            foreach (SyntaxTreeBase node in parser.parseList)
                            {
                                if (node == null)
                                    continue;
                                node.reparent (null);
                                AsnDataBase.asnFeatures.Add (((asn_features) node, fname));
                            }
                        }
                        if (g_errorCount > 0)
                            Console.Error.WriteLine ($"IMPLEMENTATION ERROR: errors in GLOBAL-MODULE");
                        parser.reset ();

                        AsnSymbolCollector asnSymbolCollector = new AsnSymbolCollector ();
                        AsnModuleDereferencer asnModuleDereferencer = new AsnModuleDereferencer ();
                        AsnNodeInspector asnNodeInspector = new AsnNodeInspector ();
                        AsnTypeIdentityRemover asnTypeIdentityRemover = new AsnTypeIdentityRemover ();
                        //AsnSymbolClassifier asnSymbolClassifier = new AsnSymbolClassifier ();
                        //AsnReferencesResolver asnReferencesResolver = new AsnReferencesResolver ();
                        //AsnNodeGovernor asnNodeGovernor = new AsnNodeGovernor ();
                        //AsnParameterCollector asnParameterCollector = new AsnParameterCollector ();
                        //AsnSemanticChecker asnSemanticChecker = new AsnSemanticChecker ();
                        //AsnCompilerChecker asnCompilerChecker = new AsnCompilerChecker ();

                        do
                        {
                            asnSymbolCollector.CollectModuleSymbols ();
                            AsnSymbolCollector.ReportRedefinedReferences = false;
                            AsnDataBase.SaveFeatures ();
                            asnModuleDereferencer.ResolveGlobalModuleReferences ();
                            AsnDataBase.SaveModules ();
                            if (true)
                                asnNodeInspector.Invoke ();
                            //asnReferencesResolver.Invoke ();
                            //else
                            //    asnNodeGovernor.Invoke ();
                            //asnParameterCollector.Invoke ();
                            //asnSemanticChecker.Invoke ();
                            //asnModuleDereferencer.ResolveParameters ();
                            //asnCompilerChecker.Invoke ();
                            //asnSymbolClassifier.Classify ();
                            AsnDataBase.SaveModules ();
                        }
                        while (AsnDataBase.NextIteration ());
                        //asnSymbolCollector.UniteModules ();
                        //asnModuleDereferencer.ResolveValues ();
                        AsnDataBase.symbolTable.display ();
                        Console.WriteLine ($"MODULE DEFINITIONS:");
                        AsnModuleFormatter asnModuleFormatter = new AsnModuleFormatter (Console.Out);
                        foreach (List<ModuleDescriptor> moduleList in AsnDataBase.accumulatedModuleDefinitions.Values)
                        {
                            Console.WriteLine ($"MODULE LIST - COUNT = {moduleList.Count}");
                            foreach (ModuleDescriptor module in moduleList)
                            {
                                Console.WriteLine ($"MODULE: {module.timeSpan.TotalMilliseconds} {module.fileName}");
                                asnModuleFormatter.Format (module.moduleDefinition);
                            }
                        }
                        AsnCheckCompiler asnCheckCompiler = new AsnCheckCompiler ();
                        asnCheckCompiler.Invoke ();
                        asnTypeIdentityRemover.Invoke ();
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine ($"ERROR: {e.Message}\n\t{e.StackTrace}");
                }
            }
        }

        static private bool Invoke_Error_Callback (int lineno, int column, int token, string tokenString)
        {
            ++g_errorCount;
            if (g_error)
                Console.Error.WriteLine ($"SYNTAX ERROR: line = {lineno}, column = {column}, token = {token}, text = '{tokenString}'");
            return false;
        }
    }
}
