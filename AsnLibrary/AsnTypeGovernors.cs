using Anglr.Parser.Core;
using Anglr.Parser.SyntaxTree;
using Anglr.Parser.Walker;
using Asn.Parser;

using Asn.Declarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AsnLibrary
{
    public class NamedBitsDictionary : Dictionary<string, NamedBit> { }
    public class ComponentTypesDictionary : Dictionary<string, ComponentType> { }
    public class EnumeratedComponentTypesDictionary : Dictionary<uint, ComponentType> { }
    public class AlternativeTypesDictionary : Dictionary<string, TypeOrNamedType> { }
    public class EnumeratedAlternativeTypesDictionary : Dictionary<uint, TypeOrNamedType> { }
    public class ListOfAltTypeOrNamedTypes : List<TypeOrNamedType> { }
    public class EnumerationItemsDictionary : Dictionary<string, EnumerationItem> { }
    public class NamedNumberItemsDictionary : Dictionary<string, NamedNumberItem> { }
    public class FieldSpecsDictionary : Dictionary<string, FieldSpec> { }
    public class SettingsDitionary : Dictionary<string, Setting> { }
    public class ListOfSettings : List<Setting> { }
    public class ListOfParameters : List<Parameter> { }
    public class ParameterDictionary : Dictionary<AsnSymbol, ParameterGovernor> { }
    public class SetOfObjects : HashSet<Asn.Parser.Object>
    {
        public SetOfObjects () : base (new ObjectComparer ()) { }
        public bool isObject { get; set; } = true;
    }

    public class ObjectComparer : IEqualityComparer<Asn.Parser.Object>
    {
        public bool Equals (Asn.Parser.Object x, Asn.Parser.Object y) => true;  // method Equals() is invoked when more objects have the
                                                                                // same hash code. But since ObjectInspectors's method
                                                                                // ComputeHashCode() computes object's hash code in such
                                                                                // way that two objects are equal if and only if their
                                                                                // hash codes are equal, it means that every hash table
                                                                                // cell can contain only one element. This means that
                                                                                // method Equals() must always return true. If more
                                                                                // objects are destined to the same hash table cell, they
                                                                                // are equal (in ASN.1 sense) and only one copy need to
                                                                                // be saved. See also the definition of method GetHashCode()
        public int GetHashCode (Asn.Parser.Object obj)
        {
            var inspector = ((obj?.appInfo as NodeInspector)?.GetObjectInspector () as ObjectInspector);
            return (inspector != null) ? inspector.hashCode : -1;
        }
    }
    public class InfoFromObjectDescriptor
    {
        public InfoFromObjectDescriptor (SetOfObjects inputSet, SetOfObjects resultSet, ListOfSettings settings, SyntaxTreeBase node, ObjectClassDefnInspector defnInspector, NodeInspector settingInspector)
        {
            this.inputSet = inputSet;
            this.resultSet = resultSet;
            this.settings = settings;
            this.node = node;
            this.defnInspector = defnInspector;
            this.settingInspector = settingInspector;
            if (resultSet.Count > maxResultSetSize)
                maxResultSetSize = resultSet.Count;
        }
        public SetOfObjects inputSet { get; private set; }
        public SetOfObjects resultSet { get; private set; }
        public ListOfSettings settings { get; private set; }
        public SyntaxTreeBase node { get; private set; }
        public ObjectClassDefnInspector defnInspector { get; private set; }
        public NodeInspector settingInspector { get; private set; }
        public static int maxResultSetSize { get; private set; } = 0;
    }

    public enum NodeType
    {
        Undefined,
        TypeNode,
        ClassNode
    };

    public class AsnParameterResolver : SyntaxTreeWalker
    {
        private int level = 0;
        public bool containsTableConstraint { get; private set; } = false;
        public AsnParameterResolver (ParameterTable parameters)
        {
            Parameters = parameters;
            Common_Event += Invoke_Common_Resolver;

            ChoiceType_Event += AsnParameterResolver_ChoiceType_Event;
            SequenceType_Event += AsnParameterResolver_SequenceType_Event;
            SequenceOfType_Event += AsnParameterResolver_SequenceOfType_Event;
            SetType_Event += AsnParameterResolver_SetType_Event;
            SetOfType_Event += AsnParameterResolver_SetOfType_Event;

            TableConstraint_Event += AsnParameterResolver_TableConstraint_Event;
        }

        private bool AsnParameterResolver_ChoiceType_Event (SyntaxTreeCallbackReason reason, ChoiceType.production_kind kind, ChoiceType p_ChoiceType)
        {
            switch (reason)
            {
            case SyntaxTreeCallbackReason.BuilderCallbackReason:
                break;
            case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                ++level;
                break;
            case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                break;
            case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                --level;
                break;
            }
            return true;
        }

        private bool AsnParameterResolver_SequenceType_Event (SyntaxTreeCallbackReason reason, SequenceType.production_kind kind, SequenceType p_SequenceType)
        {
            switch (reason)
            {
            case SyntaxTreeCallbackReason.BuilderCallbackReason:
                break;
            case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                ++level;
                break;
            case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                break;
            case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                --level;
                break;
            }
            return true;
        }

        private bool AsnParameterResolver_SequenceOfType_Event (SyntaxTreeCallbackReason reason, SequenceOfType.production_kind kind, SequenceOfType p_SequenceOfType)
        {
            switch (reason)
            {
            case SyntaxTreeCallbackReason.BuilderCallbackReason:
                break;
            case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                ++level;
                break;
            case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                break;
            case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                --level;
                break;
            }
            return true;
        }

        private bool AsnParameterResolver_SetType_Event (SyntaxTreeCallbackReason reason, SetType.production_kind kind, SetType p_SetType)
        {
            switch (reason)
            {
            case SyntaxTreeCallbackReason.BuilderCallbackReason:
                break;
            case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                ++level;
                break;
            case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                break;
            case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                --level;
                break;
            }
            return true;
        }

        private bool AsnParameterResolver_SetOfType_Event (SyntaxTreeCallbackReason reason, SetOfType.production_kind kind, SetOfType p_SetOfType)
        {
            switch (reason)
            {
            case SyntaxTreeCallbackReason.BuilderCallbackReason:
                break;
            case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                ++level;
                break;
            case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                break;
            case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                --level;
                break;
            }
            return true;
        }

        private bool AsnParameterResolver_TableConstraint_Event (SyntaxTreeCallbackReason reason, TableConstraint.production_kind kind, TableConstraint p_TableConstraint)
        {
            containsTableConstraint = (level <= 0);
            return false;
        }

        private bool Invoke_Common_Resolver (SyntaxTreeCallbackReason reason, int kind, SyntaxTreeBase p_node)
        {
            switch (reason)
            {
            case SyntaxTreeCallbackReason.BuilderCallbackReason:
                break;
            case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
            {
                if (!(p_node is SyntaxTreeToken))
                    break;
                SyntaxTreeBase parent = p_node.parent.parent;
                if ((parent != null) &&
                    !((parent.id != (uint) ProductionID._typefieldreference_token_ID) &&
                    (parent.id != (uint) ProductionID._valuefieldreference_token_ID) &&
                    (parent.id != (uint) ProductionID._valuesetfieldreference_token_ID) &&
                    (parent.id != (uint) ProductionID._objectfieldreference_token_ID) &&
                    (parent.id != (uint) ProductionID._objectsetfieldreference_token_ID)))
                    break;
                SyntaxTreeToken syntaxTreeToken = (SyntaxTreeToken) p_node;
                foreach (ParameterDescriptor parameter in Parameters)
                {
                    string refName = parameter.reference.Emit (-1);
                    if (syntaxTreeToken.text != refName)
                        continue;
                    syntaxTreeToken.text = parameter.parName;
                    break;
                }
            }
            break;
            case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                break;
            case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                break;
            }
            return true;
        }

        public ParameterTable Parameters { get; private set; } = null;
    }

    public abstract class ParameterGovernor
    {
        public ParameterGovernor (SyntaxTreeBase node, AsnSymbol symbol, string name)
        {
            Node = node;
            Symbol = symbol;
            Name = name;
        }

        public abstract bool Resolve (SyntaxTreeBase node, AsnSymbol symbol, AsnSymbol module, ParameterTable parameterTable);
        public SyntaxTreeBase Node { get; private set; }
        public AsnSymbol Symbol { get; private set; }
        public string Name { get; private set; }
        public abstract ListOfParameters Parameters { get; }
        public abstract SyntaxTreeBase GoverningNode { get; }
        public string ExtModuleContent { get; protected set; }
        public string SrcModuleContent { get; protected set; }
        public string CategoryText { get; protected set; }
        public List<string> Assignments { get; protected set; } = new List<string> ();
        public static bool CheckNode { get; set; } = false;
    }

    public class ParameterizedTypeGovernor : ParameterGovernor
    {
        public ParameterizedTypeGovernor (SyntaxTreeBase node, AsnSymbol symbol, string name) : base (node, symbol, name)
        {
        }

        public override bool Resolve (SyntaxTreeBase node, AsnSymbol symbol, AsnSymbol module, ParameterTable parameterTable)
        {
            // this test checks implementation errors
            if (CheckNode && !(node is ParameterizedType))
            {
                string nodeText = node.Emit (-1);
                AsnCompiler cmp = new AsnCompiler ();
                if (cmp.ParseString (nodeText, new int [] { (int) AsnDeclarations.tokens.ParameterizedTypeAssignment_token }) != 0)
                    Console.Error.WriteLine ($"RESOLVE ERROR: implementation error: node is not parameterized type: {node.Emit (-1)}");
            }

            // use governing node to change parameters with their actual values inside current node
            Asn.Parser.Type type = (Asn.Parser.Type) GoverningNode;
            Asn.Parser.Type typeCopy = new Asn.Parser.Type (type);
            AsnParameterResolver resolver = new AsnParameterResolver (parameterTable);
            resolver.TraverseCommon (typeCopy);
            {
                AsnSymbol asnSymbol = this.Symbol.DefiningReference.Context;
                //Console.WriteLine ($"CONTEXT: {asnSymbol.Name}, TEXT: {typeCopy.Emit (-1)}");
            }

            if (false)
            {
                resolver.Traverse (typeCopy);
                if (resolver.containsTableConstraint)
                    resolver.Traverse (typeCopy);
            }

            // create assignment statements for actual paramters and for expanded node
            string text = typeCopy.Emit (-1);
            string categoryName = $"{symbol.Name}_TY_{Counter}";
            string categoryText = $"{categoryName} ::= {text}";

            AsnSymbol externalModule = Symbol.DefiningReference.Context;
            {
                if (externalModule != module)
                {
                    int count = 0;
                    string extModuleContent = "";
                    extModuleContent += ($"{externalModule.Name}\n");
                    extModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                    {
                        if (count == 0)
                            extModuleContent += ($"IMPORTS\n");
                        if (count++ > 0)
                            extModuleContent += ", ";
                        extModuleContent += ($"{parameter.parName}\n");
                    }
                    if (count > 0)
                        extModuleContent += ($"FROM {module.Name};\n");
                    extModuleContent += ($"{categoryText}\n");
                    extModuleContent += ($"END\n");

                    string srcModuleContent = "";
                    srcModuleContent += ($"{module.Name}\n");
                    srcModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    srcModuleContent += ($"IMPORTS\n");
                    srcModuleContent += ($"{categoryName}\n");
                    srcModuleContent += ($"FROM {externalModule.Name};\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                        srcModuleContent += ($"{parameter.parValue}\n");
                    srcModuleContent += ($"END\n");

                    ExtModuleContent = extModuleContent;
                    SrcModuleContent = srcModuleContent;
                    //AsnDataBase.GeneratedModules.Add (ExtModuleContent = extModuleContent);
                    //AsnDataBase.GeneratedModules.Add (SrcModuleContent = srcModuleContent);
                    //Console.WriteLine ($"{extModuleContent}");
                    //Console.WriteLine ($"{srcModuleContent}");
                }
                else
                {
                    string srcModuleContent = "";
                    srcModuleContent += ($"{module.Name}\n");
                    srcModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                        srcModuleContent += ($"{parameter.parValue}\n");
                    srcModuleContent += ($"{categoryText}\n");
                    srcModuleContent += ($"END\n");

                    SrcModuleContent = srcModuleContent;
                    //AsnDataBase.GeneratedModules.Add (SrcModuleContent = srcModuleContent);
                    //Console.WriteLine ($"{srcModuleContent}");
                }
            }

            // create external reference representing original parameterized expression
            CategoryText = externalModule.Name + "." + categoryName;

            return true;
        }

        public override ListOfParameters Parameters
        {
            get
            {
                try
                {
                    return (ListOfParameters) ((ParameterizedTypeAssignment) Node).m_ParameterList.appInfo;
                }
                catch (Exception) { return null; }
            }
        }

        public override SyntaxTreeBase GoverningNode => ((ParameterizedTypeAssignment) Node).m_Type;

        public static uint Counter { get => ++counter; }

        private static uint counter = 0;
    }

    public class ParameterizedValueGovernor : ParameterGovernor
    {
        public ParameterizedValueGovernor (SyntaxTreeBase node, AsnSymbol symbol, string name) : base (node, symbol, name)
        {
        }

        public override bool Resolve (SyntaxTreeBase node, AsnSymbol symbol, AsnSymbol module, ParameterTable parameterTable)
        {
            // this test checks implementation errors
            if (CheckNode && !(node is ParameterizedValue))
            {
                string nodeText = node.Emit (-1);
                AsnCompiler cmp = new AsnCompiler ();
                if (cmp.ParseString (nodeText, new int [] { (int) AsnDeclarations.tokens.ParameterizedValueAssignment_token }) != 0)
                    Console.Error.WriteLine ($"RESOLVE ERROR: implementation error: node is not parameterized value: {node.Emit (-1)}");
            }

            // use governing node to change parameters with their actual values inside current node
            Value value = (Value) GoverningNode;
            Value valueCopy = new Value (value);
            AsnParameterResolver resolver = new AsnParameterResolver (parameterTable);
            resolver.TraverseCommon (valueCopy);
            {
                AsnSymbol asnSymbol = this.Symbol.DefiningReference.Context;
                //Console.WriteLine ($"CONTEXT: {asnSymbol.Name}, TEXT: {valueCopy.Emit (-1)}");
            }

            if (false)
            {
                resolver.Traverse (valueCopy);
                if (resolver.containsTableConstraint)
                    resolver.Traverse (valueCopy);
            }

            // create assignment statements for actual paramters and for expanded node
            string text = valueCopy.Emit (-1);
            string categoryName = $"{symbol.Name}_VL_{Counter}";
            string categoryText = $"{categoryName} {((ParameterizedValueAssignment) Node).m_Type.Emit (-1)} ::= {text}";

            AsnSymbol externalModule = Symbol.DefiningReference.Context;
            {
                if (externalModule != module)
                {
                    int count = 0;
                    string extModuleContent = "";
                    extModuleContent += ($"{externalModule.Name}\n");
                    extModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                    {
                        if (count == 0)
                            extModuleContent += ($"IMPORTS\n");
                        if (count++ > 0)
                            extModuleContent += ", ";
                        extModuleContent += ($"{parameter.parName}\n");
                    }
                    if (count > 0)
                        extModuleContent += ($"FROM {module.Name};\n");
                    extModuleContent += ($"{categoryText}\n");
                    extModuleContent += ($"END\n");

                    string srcModuleContent = "";
                    srcModuleContent += ($"{module.Name}\n");
                    srcModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    srcModuleContent += ($"IMPORTS\n");
                    srcModuleContent += ($"{categoryName}\n");
                    srcModuleContent += ($"FROM {externalModule.Name};\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                        srcModuleContent += ($"{parameter.parValue}\n");
                    srcModuleContent += ($"END\n");

                    ExtModuleContent = extModuleContent;
                    SrcModuleContent = srcModuleContent;
                    //AsnDataBase.GeneratedModules.Add (ExtModuleContent = extModuleContent);
                    //AsnDataBase.GeneratedModules.Add (SrcModuleContent = srcModuleContent);
                    //Console.WriteLine ($"{extModuleContent}");
                    //Console.WriteLine ($"{srcModuleContent}");
                }
                else
                {
                    string srcModuleContent = "";
                    srcModuleContent += ($"{module.Name}\n");
                    srcModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                        srcModuleContent += ($"{parameter.parValue}\n");
                    srcModuleContent += ($"{categoryText}\n");
                    srcModuleContent += ($"END\n");

                    SrcModuleContent = srcModuleContent;
                    //AsnDataBase.GeneratedModules.Add (SrcModuleContent = srcModuleContent);
                    //Console.WriteLine ($"{srcModuleContent}");
                }
            }

            // create external reference representing original parameterized expression
            CategoryText = externalModule.Name + "." + categoryName;

            return true;
        }

        public override ListOfParameters Parameters
        {
            get
            {
                try
                {
                    return (ListOfParameters) ((ParameterizedValueAssignment) Node).m_ParameterList.appInfo;
                }
                catch (Exception) { return null; }
            }
        }
        public override SyntaxTreeBase GoverningNode => ((ParameterizedValueAssignment) Node).m_Value;

        public static uint Counter { get => ++counter; }

        private static uint counter = 0;
    }

    public class ParameterizedValueSetTypeGovernor : ParameterGovernor
    {
        public ParameterizedValueSetTypeGovernor (SyntaxTreeBase node, AsnSymbol symbol, string name) : base (node, symbol, name)
        {
        }

        public override bool Resolve (SyntaxTreeBase node, AsnSymbol symbol, AsnSymbol module, ParameterTable parameterTable)
        {
            // this test checks implementation errors
            if (CheckNode && !(node is ParameterizedValueSetType))
            {
                string nodeText = node.Emit (-1);
                AsnCompiler cmp = new AsnCompiler ();
                if (cmp.ParseString (nodeText, new int [] { (int) AsnDeclarations.tokens.ParameterizedValueSetTypeAssignment_token }) != 0)
                    Console.Error.WriteLine ($"RESOLVE ERROR: implementation error: node is not parameterized value set type: {node.Emit (-1)}");
            }

            // use governing node to change parameters with their actual values inside current node
            ValueSet valueSet = (ValueSet) GoverningNode;
            ValueSet valueSetCopy = new ValueSet (valueSet);
            AsnParameterResolver resolver = new AsnParameterResolver (parameterTable);
            resolver.TraverseCommon (valueSetCopy);
            {
                AsnSymbol asnSymbol = this.Symbol.DefiningReference.Context;
                //Console.WriteLine ($"CONTEXT: {asnSymbol.Name}, TEXT: {valueSetCopy.Emit (-1)}");
            }

            if (false)
            {
                resolver.Traverse (valueSetCopy);
                if (resolver.containsTableConstraint)
                    resolver.Traverse (valueSetCopy);
            }

            // create assignment statements for actual paramters and for expanded node
            string text = valueSetCopy.Emit (-1);
            string categoryName = $"{symbol.Name}_VS_{Counter}";
            string categoryText = $"{categoryName} {((ParameterizedValueSetTypeAssignment) Node).m_Type.Emit (-1)} ::= {text}";

            AsnSymbol externalModule = Symbol.DefiningReference.Context;
            {
                if (externalModule != module)
                {
                    int count = 0;
                    string extModuleContent = "";
                    extModuleContent += ($"{externalModule.Name}\n");
                    extModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                    {
                        if (count == 0)
                            extModuleContent += ($"IMPORTS\n");
                        if (count++ > 0)
                            extModuleContent += ", ";
                        extModuleContent += ($"{parameter.parName}\n");
                    }
                    if (count > 0)
                        extModuleContent += ($"FROM {module.Name};\n");
                    extModuleContent += ($"{categoryText}\n");
                    extModuleContent += ($"END\n");

                    string srcModuleContent = "";
                    srcModuleContent += ($"{module.Name}\n");
                    srcModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    srcModuleContent += ($"IMPORTS\n");
                    srcModuleContent += ($"{categoryName}\n");
                    srcModuleContent += ($"FROM {externalModule.Name};\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                        srcModuleContent += ($"{parameter.parValue}\n");
                    srcModuleContent += ($"END\n");

                    ExtModuleContent = extModuleContent;
                    SrcModuleContent = srcModuleContent;
                    //AsnDataBase.GeneratedModules.Add (ExtModuleContent = extModuleContent);
                    //AsnDataBase.GeneratedModules.Add (SrcModuleContent = srcModuleContent);
                    //Console.WriteLine ($"{extModuleContent}");
                    //Console.WriteLine ($"{srcModuleContent}");
                }
                else
                {
                    string srcModuleContent = "";
                    srcModuleContent += ($"{module.Name}\n");
                    srcModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                        srcModuleContent += ($"{parameter.parValue}\n");
                    srcModuleContent += ($"{categoryText}\n");
                    srcModuleContent += ($"END\n");

                    SrcModuleContent = srcModuleContent;
                    //AsnDataBase.GeneratedModules.Add (SrcModuleContent = srcModuleContent);
                    //Console.WriteLine ($"{srcModuleContent}");
                }
            }

            // create external reference representing original parameterized expression
            CategoryText = externalModule.Name + "." + categoryName;

            return true;
        }

        public override ListOfParameters Parameters
        {
            get
            {
                try
                {
                    return (ListOfParameters) ((ParameterizedValueSetTypeAssignment) Node).m_ParameterList.appInfo;
                }
                catch (Exception) { return null; }
            }
        }
        public override SyntaxTreeBase GoverningNode => ((ParameterizedValueSetTypeAssignment) Node).m_ValueSet;

        public static uint Counter { get => ++counter; }

        private static uint counter = 0;
    }

    public class ParameterizedObjectClassGovernor : ParameterGovernor
    {
        public ParameterizedObjectClassGovernor (SyntaxTreeBase node, AsnSymbol symbol, string name) : base (node, symbol, name)
        {
        }

        public override bool Resolve (SyntaxTreeBase node, AsnSymbol symbol, AsnSymbol module, ParameterTable parameterTable)
        {
            // this test checks implementation errors
            if (CheckNode && !(node is ParameterizedObjectClass))
            {
                string nodeText = node.Emit (-1);
                AsnCompiler cmp = new AsnCompiler ();
                if (cmp.ParseString (nodeText, new int [] { (int) AsnDeclarations.tokens.ParameterizedObjectClassAssignment_token }) != 0)
                    Console.Error.WriteLine ($"RESOLVE ERROR: implementation error: node is not parameterized object class: {node.Emit (-1)}");
            }

            // use governing node to change parameters with their actual values inside current node
            ObjectClass objectClass = (ObjectClass) GoverningNode;
            ObjectClass objectClassCopy = new ObjectClass (objectClass);
            AsnParameterResolver resolver = new AsnParameterResolver (parameterTable);
            resolver.TraverseCommon (objectClassCopy);
            {
                AsnSymbol asnSymbol = this.Symbol.DefiningReference.Context;
                //Console.WriteLine ($"CONTEXT: {asnSymbol.Name}, TEXT: {objectClassCopy.Emit (-1)}");
            }

            if (false)
            {
                resolver.Traverse (objectClassCopy);
                if (resolver.containsTableConstraint)
                    resolver.Traverse (objectClassCopy);
            }

            // create assignment statements for actual paramters and for expanded node
            string text = objectClassCopy.Emit (-1);
            string categoryName = $"{symbol.Name}_DO_{Counter}";
            string categoryText = $"{categoryName} ::= {text}";

            AsnSymbol externalModule = Symbol.DefiningReference.Context;
            {
                if (externalModule != module)
                {
                    int count = 0;
                    string extModuleContent = "";
                    extModuleContent += ($"{externalModule.Name}\n");
                    extModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                    {
                        if (count == 0)
                            extModuleContent += ($"IMPORTS\n");
                        if (count++ > 0)
                            extModuleContent += ", ";
                        extModuleContent += ($"{parameter.parName}\n");
                    }
                    if (count > 0)
                        extModuleContent += ($"FROM {module.Name};\n");
                    extModuleContent += ($"{categoryText}\n");
                    extModuleContent += ($"END\n");

                    string srcModuleContent = "";
                    srcModuleContent += ($"{module.Name}\n");
                    srcModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    srcModuleContent += ($"IMPORTS\n");
                    srcModuleContent += ($"{categoryName}\n");
                    srcModuleContent += ($"FROM {externalModule.Name};\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                        srcModuleContent += ($"{parameter.parValue}\n");
                    srcModuleContent += ($"END\n");

                    ExtModuleContent = extModuleContent;
                    SrcModuleContent = srcModuleContent;
                    //AsnDataBase.GeneratedModules.Add (ExtModuleContent = extModuleContent);
                    //AsnDataBase.GeneratedModules.Add (SrcModuleContent = srcModuleContent);
                    //Console.WriteLine ($"{extModuleContent}");
                    //Console.WriteLine ($"{srcModuleContent}");
                }
                else
                {
                    string srcModuleContent = "";
                    srcModuleContent += ($"{module.Name}\n");
                    srcModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                        srcModuleContent += ($"{parameter.parValue}\n");
                    srcModuleContent += ($"{categoryText}\n");
                    srcModuleContent += ($"END\n");

                    SrcModuleContent = srcModuleContent;
                    //AsnDataBase.GeneratedModules.Add (SrcModuleContent = srcModuleContent);
                    //Console.WriteLine ($"{srcModuleContent}");
                }
            }

            // create external reference representing original parameterized expression
            CategoryText = externalModule.Name + "." + categoryName;

            return true;
        }

        public override ListOfParameters Parameters
        {
            get
            {
                try
                {
                    return (ListOfParameters) ((ParameterizedObjectClassAssignment) Node).m_ParameterList.appInfo;
                }
                catch (Exception) { return null; }
            }
        }
        public override SyntaxTreeBase GoverningNode => ((ParameterizedObjectClassAssignment) Node).m_ObjectClass;

        public static uint Counter { get => ++counter; }

        private static uint counter = 0;
    }

    public class ParameterizedObjectGovernor : ParameterGovernor
    {
        public ParameterizedObjectGovernor (SyntaxTreeBase node, AsnSymbol symbol, string name) : base (node, symbol, name)
        {
        }

        public override bool Resolve (SyntaxTreeBase node, AsnSymbol symbol, AsnSymbol module, ParameterTable parameterTable)
        {
            // this test checks implementation errors
            if (CheckNode && !(node is ParameterizedObject))
            {
                string nodeText = node.Emit (-1);
                AsnCompiler cmp = new AsnCompiler ();
                if (cmp.ParseString (nodeText, new int [] { (int) AsnDeclarations.tokens.ParameterizedObjectAssignment_token }) != 0)
                    Console.Error.WriteLine ($"RESOLVE ERROR: implementation error: node is not parameterized object: {node.Emit (-1)}");
            }

            // use governing node to change parameters with their actual values inside current node
            Asn.Parser.Object @object = (Asn.Parser.Object) GoverningNode;
            Asn.Parser.Object objectCopy = new Asn.Parser.Object (@object);
            AsnParameterResolver resolver = new AsnParameterResolver (parameterTable);
            resolver.TraverseCommon (objectCopy);
            {
                AsnSymbol asnSymbol = this.Symbol.DefiningReference.Context;
                //Console.WriteLine ($"CONTEXT: {asnSymbol.Name}, TEXT: {objectCopy.Emit (-1)}");
            }

            if (false)
            {
                resolver.Traverse (objectCopy);
                if (resolver.containsTableConstraint)
                    resolver.Traverse (objectCopy);
            }

            // create assignment statements for actual paramters and for expanded node
            string text = objectCopy.Emit (-1);
            string categoryName = $"{symbol.Name}_OB_{Counter}";
            string categoryText = $"{categoryName} {((ParameterizedObjectAssignment) Node).m_DefinedObjectClass.Emit (-1)} ::= {text}";

            AsnSymbol externalModule = Symbol.DefiningReference.Context;
            {
                if (externalModule != module)
                {
                    int count = 0;
                    string extModuleContent = "";
                    extModuleContent += ($"{externalModule.Name}\n");
                    extModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                    {
                        if (count == 0)
                            extModuleContent += ($"IMPORTS\n");
                        if (count++ > 0)
                            extModuleContent += ", ";
                        extModuleContent += ($"{parameter.parName}\n");
                    }
                    if (count > 0)
                        extModuleContent += ($"FROM {module.Name};\n");
                    extModuleContent += ($"{categoryText}\n");
                    extModuleContent += ($"END\n");

                    string srcModuleContent = "";
                    srcModuleContent += ($"{module.Name}\n");
                    srcModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    srcModuleContent += ($"IMPORTS\n");
                    srcModuleContent += ($"{categoryName}\n");
                    srcModuleContent += ($"FROM {externalModule.Name};\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                        srcModuleContent += ($"{parameter.parValue}\n");
                    srcModuleContent += ($"END\n");

                    ExtModuleContent = extModuleContent;
                    SrcModuleContent = srcModuleContent;
                    //AsnDataBase.GeneratedModules.Add (ExtModuleContent = extModuleContent);
                    //AsnDataBase.GeneratedModules.Add (SrcModuleContent = srcModuleContent);
                    //Console.WriteLine ($"{extModuleContent}");
                    //Console.WriteLine ($"{srcModuleContent}");
                }
                else
                {
                    string srcModuleContent = "";
                    srcModuleContent += ($"{module.Name}\n");
                    srcModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                        srcModuleContent += ($"{parameter.parValue}\n");
                    srcModuleContent += ($"{categoryText}\n");
                    srcModuleContent += ($"END\n");

                    SrcModuleContent = srcModuleContent;
                    //AsnDataBase.GeneratedModules.Add (SrcModuleContent = srcModuleContent);
                    //Console.WriteLine ($"{srcModuleContent}");
                }
            }

            // create external reference representing original parameterized expression
            CategoryText = externalModule.Name + "." + categoryName;

            return true;
        }

        public override ListOfParameters Parameters
        {
            get
            {
                try
                {
                    return (ListOfParameters) ((ParameterizedObjectAssignment) Node).m_ParameterList.appInfo;
                }
                catch (Exception) { return null; }
            }
        }
        public override SyntaxTreeBase GoverningNode => ((ParameterizedObjectAssignment) Node).m_Object;

        public static uint Counter { get => ++counter; }

        private static uint counter = 0;
    }

    public class ParameterizedObjectSetGovernor : ParameterGovernor
    {
        public ParameterizedObjectSetGovernor (SyntaxTreeBase node, AsnSymbol symbol, string name) : base (node, symbol, name)
        {
        }

        public override bool Resolve (SyntaxTreeBase node, AsnSymbol symbol, AsnSymbol module, ParameterTable parameterTable)
        {
            // this test checks implementation errors
            if (CheckNode && !(node is ParameterizedObjectSet))
            {
                string nodeText = node.Emit (-1);
                AsnCompiler cmp = new AsnCompiler ();
                if (cmp.ParseString (nodeText, new int [] { (int) AsnDeclarations.tokens.ParameterizedObjectSetAssignment_token }) != 0)
                    Console.Error.WriteLine ($"RESOLVE ERROR: implementation error: node is not parameterized object set: {node.Emit (-1)}");
            }

            // use governing node to change parameters with their actual values inside current node
            ObjectSet objectSet = (ObjectSet) GoverningNode;
            ObjectSet objectSetCopy = new ObjectSet (objectSet);
            AsnParameterResolver resolver = new AsnParameterResolver (parameterTable);
            resolver.TraverseCommon (objectSetCopy);
            {
                AsnSymbol asnSymbol = this.Symbol.DefiningReference.Context;
                //Console.WriteLine ($"CONTEXT: {asnSymbol.Name}, TEXT: {objectSetCopy.Emit (-1)}");
            }

            if (false)
            {
                resolver.Traverse (objectSetCopy);
                if (resolver.containsTableConstraint)
                    resolver.Traverse (objectSetCopy);
            }

            // create assignment statements for actual paramters and for expanded node
            string text = objectSetCopy.Emit (-1);
            string categoryName = $"{symbol.Name}_OS_{Counter}";
            string categoryText = $"{categoryName} {((ParameterizedObjectSetAssignment) Node).m_DefinedObjectClass.Emit (-1)} ::= {text}";

            AsnSymbol externalModule = Symbol.DefiningReference.Context;
            {
                if (externalModule != module)
                {
                    int count = 0;
                    string extModuleContent = "";
                    extModuleContent += ($"{externalModule.Name}\n");
                    extModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                    {
                        if (count == 0)
                            extModuleContent += ($"IMPORTS\n");
                        if (count++ > 0)
                            extModuleContent += ", ";
                        extModuleContent += ($"{parameter.parName}\n");
                    }
                    if (count > 0)
                        extModuleContent += ($"FROM {module.Name};\n");
                    extModuleContent += ($"{categoryText}\n");
                    extModuleContent += ($"END\n");

                    string srcModuleContent = "";
                    srcModuleContent += ($"{module.Name}\n");
                    srcModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    srcModuleContent += ($"IMPORTS\n");
                    srcModuleContent += ($"{categoryName}\n");
                    srcModuleContent += ($"FROM {externalModule.Name};\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                        srcModuleContent += ($"{parameter.parValue}\n");
                    srcModuleContent += ($"END\n");

                    ExtModuleContent = extModuleContent;
                    SrcModuleContent = srcModuleContent;
                    //AsnDataBase.GeneratedModules.Add (ExtModuleContent = extModuleContent);
                    //AsnDataBase.GeneratedModules.Add (SrcModuleContent = srcModuleContent);
                    //Console.WriteLine ($"{extModuleContent}");
                    //Console.WriteLine ($"{srcModuleContent}");
                }
                else
                {
                    string srcModuleContent = "";
                    srcModuleContent += ($"{module.Name}\n");
                    srcModuleContent += ($"DEFINITIONS ::=\nBEGIN\n");
                    foreach (ParameterDescriptor parameter in parameterTable)
                        srcModuleContent += ($"{parameter.parValue}\n");
                    srcModuleContent += ($"{categoryText}\n");
                    srcModuleContent += ($"END\n");

                    SrcModuleContent = srcModuleContent;
                    //AsnDataBase.GeneratedModules.Add (SrcModuleContent = srcModuleContent);
                    //Console.WriteLine ($"{srcModuleContent}");
                }
            }

            // create external reference representing original parameterized expression
            CategoryText = externalModule.Name + "." + categoryName;

            return true;
        }

        public override ListOfParameters Parameters
        {
            get
            {
                try
                {
                    return (ListOfParameters) ((ParameterizedObjectSetAssignment) Node).m_ParameterList.appInfo;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public override SyntaxTreeBase GoverningNode => ((ParameterizedObjectSetAssignment) Node).m_ObjectSet;

        public static uint Counter { get => ++counter; }

        private static uint counter = 0;
    }
}
