using Anglr.Parser.Core;
using Anglr.Parser.SyntaxTree;
using Anglr.Parser.Walker;
using Asn.Declarations;
using Asn.Parser;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AsnLibrary
{
    public abstract class NodeInspectorProvider : SyntaxTreeWalker
    {
        public abstract AsnSymbol ResolveSymbol (string name);
        public abstract SyntaxTreeBase GenerateSequenceOfValue (Value p_Value);
        public abstract SyntaxTreeBase GenerateIntegerValue (Value p_Value);
        public abstract SyntaxTreeBase GenerateSequenceValue (Value p_Value);
        public abstract SyntaxTreeBase GenerateSetValue (Value p_Value);
        public abstract SyntaxTreeBase GenerateChoiceValue (Value p_Value);
        public abstract SyntaxTreeBase GenerateSetOfValue (Value p_Value);
        public abstract SyntaxTreeBase GenerateOctetStringValue (Value p_Value);
        public abstract SyntaxTreeBase GenerateEnumeratedValue (Value p_Value);
        public abstract SyntaxTreeBase GenerateBitStringValue (Value p_Value);
        public abstract SyntaxTreeBase GenerateRelativeOIDValue (Value p_Value);
        public abstract SyntaxTreeBase GenerateObjectIdentifierValue (Value p_Value);
    }

    public abstract class NodeInspector
    {
        public NodeInspector (SyntaxTreeBase node)
        {
            Node = node;
        }

        public SyntaxTreeBase Node { get; private set; }
        public NodeType NodeType { get; protected set; } = NodeType.Undefined;
        public NodeInspector actualNodeInspector
        {
            get => (internalNodeInspector != null) ? internalNodeInspector.actualNodeInspector : this;
            set => internalNodeInspector = value;
        }
        public bool isActual { get { return internalNodeInspector == null; } }

        private NodeInspector internalNodeInspector = null;
        public NodeInspector tableConstraintLink { get; protected set; }
        public abstract void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider);
        public virtual bool? IsCompatibleValue (SyntaxTreeBase node) => true;
        public virtual SyntaxTreeBase GenerateCompatibleValue (Asn.Parser.Value value, NodeInspectorProvider provider) => null;
        public virtual NodeInspector GetComponentInspector (string name) => null;
        public virtual NodeInspector GetInspectorByType (System.Type type) => null;
        public virtual NodeInspector GetObjectInspector () => null;
        public virtual int? GetComponentCount () => 0;
    }

    public class BuiltinTypeInspector : NodeInspector
    {
        public BuiltinTypeInspector (BuiltinType node) : base (node) { }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class TypeInspector : NodeInspector
    {
        public TypeInspector (Asn.Parser.Type node) : base (node) { }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ReferencedTypeInspector : NodeInspector
    {
        public ReferencedTypeInspector (ReferencedType node) : base (node) { }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class TypeAssignmentInspector : NodeInspector
    {
        public TypeAssignmentInspector (TypeAssignment node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) => ((Node as TypeAssignment)?.m_Type.appInfo as NodeInspector)?.Inspect (node, provider);
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => ((Node as TypeAssignment)?.m_Type.appInfo as NodeInspector)?.IsCompatibleValue (node);

        public override SyntaxTreeBase GenerateCompatibleValue (Value value, NodeInspectorProvider provider) => ((Node as TypeAssignment)?.m_Type.appInfo as NodeInspector)?.GenerateCompatibleValue (value, provider);
        public override NodeInspector GetComponentInspector (string name) => ((Node as TypeAssignment)?.m_Type.appInfo as NodeInspector)?.GetComponentInspector (name);
        public override NodeInspector GetInspectorByType (System.Type type) => ((Node as TypeAssignment)?.m_Type.appInfo as NodeInspector)?.GetInspectorByType (type);
        private NodeInspector m_NodeInspector = null;
    }

    public class ValueAssignmentInspector : NodeInspector
    {
        public ValueAssignmentInspector (ValueAssignment node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) => ((Node as ValueAssignment)?.m_Type.appInfo as NodeInspector)?.Inspect ((Node as ValueAssignment).m_Value, provider);
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => ((Node as ValueAssignment)?.m_Type.appInfo as NodeInspector)?.IsCompatibleValue (node);
    }

    public class XMLValueAssignmentInspector : NodeInspector
    {
        public XMLValueAssignmentInspector (XMLValueAssignment node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ValueSetTypeAssignmentInspector : NodeInspector
    {
        public ValueSetTypeAssignmentInspector (ValueSetTypeAssignment node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ObjectAssignmentInspector : NodeInspector
    {
        public ObjectAssignmentInspector (ObjectAssignment node) : base (node)
        {
            NodeType = NodeType.ClassNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ObjectSetAssignmentInspector : NodeInspector
    {
        public ObjectSetAssignmentInspector (ObjectSetAssignment node) : base (node)
        {
            NodeType = NodeType.ClassNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ParameterizedAssignmentInspector : NodeInspector
    {
        public ParameterizedAssignmentInspector (ParameterizedAssignment node) : base (node) { }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ParameterizedTypeAssignmentInspector : NodeInspector
    {
        public ParameterizedTypeAssignmentInspector (ParameterizedTypeAssignment node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ParameterizedValueAssignmentInspector : NodeInspector
    {
        public ParameterizedValueAssignmentInspector (ParameterizedValueAssignment node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ParameterizedValueSetTypeAssignmentInspector : NodeInspector
    {
        public ParameterizedValueSetTypeAssignmentInspector (ParameterizedValueSetTypeAssignment node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ParameterizedObjectClassAssignmentInspector : NodeInspector
    {
        public ParameterizedObjectClassAssignmentInspector (ParameterizedObjectClassAssignment node) : base (node)
        {
            NodeType = NodeType.ClassNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ParameterizedObjectAssignmentInspector : NodeInspector
    {
        public ParameterizedObjectAssignmentInspector (ParameterizedObjectAssignment node) : base (node)
        {
            NodeType = NodeType.ClassNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ParameterizedObjectSetAssignmentInspector : NodeInspector
    {
        public ParameterizedObjectSetAssignmentInspector (ParameterizedObjectSetAssignment node) : base (node)
        {
            NodeType = NodeType.ClassNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ParameterizedTypeInspector : NodeInspector
    {
        public ParameterizedTypeInspector (ParameterizedType node) : base (node) { }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ParameterizedValueInpector : NodeInspector
    {
        public ParameterizedValueInpector (ParameterizedValue node) : base (node) { }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ParameterizedValueSetTypeInspector : NodeInspector
    {
        public ParameterizedValueSetTypeInspector (ParameterizedValueSetType node) : base (node) { }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ParameterizedObjectClassInspector : NodeInspector
    {
        public ParameterizedObjectClassInspector (ParameterizedObjectClass node) : base (node) { }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ParameterizedObjectSetInspector : NodeInspector
    {
        public ParameterizedObjectSetInspector (ParameterizedObjectSet node) : base (node) { }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ParameterizedObjectInspector : NodeInspector
    {
        public ParameterizedObjectInspector (ParameterizedObject node) : base (node) { }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class MacroAssignmentInspector : NodeInspector
    {
        public MacroAssignmentInspector (MacroAssignment node) : base (node) { }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class MacroDefinitionInspector : NodeInspector
    {
        public MacroDefinitionInspector (MacroDefinition node) : base (node) { }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class AnyTypeInspector : NodeInspector
    {
        public AnyTypeInspector (AnyType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class BitStringTypeInspector : NodeInspector
    {
        public BitStringTypeInspector (BitStringType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
            BitStringValue bitStringValue = (node as Value)?.m_BuiltinValue?.m_BitStringValue;
            if (bitStringValue == null)
                return;
            switch ((BitStringValue.production_kind) bitStringValue.kind)
            {
                case BitStringValue.production_kind.g_BitStringValue_1:
                    break;
                case BitStringValue.production_kind.g_BitStringValue_2:
                    break;
                case BitStringValue.production_kind.g_BitStringValue_3:
                {
                    bitStringValue.m_IdentifierList.Iterate (null, (bitNode, appData) =>
                    {
                        if (!namedBits.TryGetValue (bitNode.m_identifier_token.m_identifier.text, out var named))
                            ;
                        return null;
                    });
                }
                break;
                case BitStringValue.production_kind.g_BitStringValue_4:
                    break;
                case BitStringValue.production_kind.g_BitStringValue_5:
                    break;
            }
        }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is BitStringValue;
        public override SyntaxTreeBase GenerateCompatibleValue (Asn.Parser.Value value, NodeInspectorProvider provider) => provider.GenerateBitStringValue (value);

        public NamedBitsDictionary namedBits { get; private set; } = new NamedBitsDictionary ();
    }

    public class BooleanTypeInspector : NodeInspector
    {
        public BooleanTypeInspector (BooleanType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
            switch (node.Emit (-1))
            {
                case "FALSE":
                    break;
                case "TRUE":
                    break;
                default:
                    break;
            }
        }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is BooleanValue;
    }

    public class CharacterStringTypeInspector : NodeInspector
    {
        public CharacterStringTypeInspector (CharacterStringType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is CharacterStringValue;
    }

    public class AlternativeTypeListInspector : ComponentCounterInspector
    {
        public AlternativeTypeListInspector (SyntaxTreeBase node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public AlternativeTypesDictionary AlternativeTypes { get; private set; } = new AlternativeTypesDictionary ();
        public EnumeratedAlternativeTypesDictionary EnumeratedAlternativeTypes { get; private set; } = new EnumeratedAlternativeTypesDictionary ();
    }

    public class ChoiceTypeInspector : AlternativeTypeListInspector
    {
        public ChoiceTypeInspector (ChoiceType node, NodeInspector tableConstraintLink) : base (node)
        {
            NodeType = NodeType.TypeNode;
            base.tableConstraintLink = tableConstraintLink;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is ChoiceValue;

        public override SyntaxTreeBase GenerateCompatibleValue (Value value, NodeInspectorProvider provider) => provider.GenerateChoiceValue (value);
        public override NodeInspector GetComponentInspector (string name)
        {
            TypeOrNamedType namedType = null;
            AlternativeTypes.TryGetValue (name, out namedType);
            if (namedType == null)
                return null;
            return (NodeInspector) namedType.appInfo;
        }
    }

    public class DateTypeInspector : NodeInspector
    {
        public DateTypeInspector (DateType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is TimeValue;
    }

    public class DateTimeTypeInspector : NodeInspector
    {
        public DateTimeTypeInspector (DateTimeType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is TimeValue;
    }

    public class DurationTypeInspector : NodeInspector
    {
        public DurationTypeInspector (DurationType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is DurationType;
    }

    public class EmbeddedPDVTypeInspector : NodeInspector
    {
        public EmbeddedPDVTypeInspector (EmbeddedPDVType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is EmbeddedPDVValue;
    }

    public class EnumeratedTypeInspector : NodeInspector
    {
        public EnumeratedTypeInspector (EnumeratedType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
            string text = node.Emit (-1);
            if (enumerationItems.TryGetValue (text, out _))
                ;
            else
                ;
        }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is EnumeratedValue;
        public override SyntaxTreeBase GenerateCompatibleValue (Asn.Parser.Value value, NodeInspectorProvider provider) => provider.GenerateEnumeratedValue (value);

        public EnumerationItemsDictionary enumerationItems { get; private set; } = new EnumerationItemsDictionary ();
    }

    public class ExternalTypeInspector : NodeInspector
    {
        public ExternalTypeInspector (ExternalType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is ExternalValue;
    }

    public class InstanceOfTypeInspector : NodeInspector
    {
        public InstanceOfTypeInspector (InstanceOfType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is Value;
        //public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is InstanceOfValue;
    }

    public class IntegerTypeInspector : NodeInspector
    {
        public IntegerTypeInspector (IntegerType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
            IntegerType integerType = Node as IntegerType;
            if (integerType != null)
            {
                switch ((IntegerType.production_kind) integerType.kind)
                {
                    case IntegerType.production_kind.g_IntegerType_1:
                    {
                        string intstr = node.Emit (-1);
                        int intval = 0;
                        if (!int.TryParse (intstr, out intval))
                        {
                            AsnSymbol asnSymbol = provider.ResolveSymbol (intstr);
                            if (asnSymbol == null)
                                ;
                        }
                    }
                    break;
                    case IntegerType.production_kind.g_IntegerType_2:
                    {
                        string text = node.Emit (-1);
                        if (namedNumberItems.TryGetValue (text, out _))
                            ;
                        else
                            ;
                    }
                    break;
                }
            }
            else
                ;
        }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is IntegerValue;

        public override SyntaxTreeBase GenerateCompatibleValue (Value value, NodeInspectorProvider provider) => provider.GenerateIntegerValue (value);

        public NamedNumberItemsDictionary namedNumberItems { get; private set; } = new NamedNumberItemsDictionary ();
    }

    public class IRITypeInspector : NodeInspector
    {
        public IRITypeInspector (IRIType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is IRIValue;
    }

    public class NullTypeInspector : NodeInspector
    {
        public NullTypeInspector (NullType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is NullValue;
    }

    public class ObjectClassFieldTypeInspector : NodeInspector
    {
        public ObjectClassFieldTypeInspector (ObjectClassFieldType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ObjectIdentifierTypeInspector : NodeInspector
    {
        public ObjectIdentifierTypeInspector (ObjectIdentifierType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
            string title = null;
            string errorString = "";
            AsnCompiler asnCompiler = new AsnCompiler ();
            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
            {
                errorString += $"ERROR: {title}:\n";
                errorString += $"\tVALUE:    {node.Emit (-1)}\n";
                errorString += $"\tGOVERNOR: {Node.Emit (-1)}\n";
                return true;
            };
            title = "CANNOT PARSE OBJECT IDENTIFIER VALUE";
            if (asnCompiler.ParseString (node.Emit (-1), new int [] { (int) AsnDeclarations.tokens.ObjectIdentifierValue_token }) == 0)
            {
                ;
            }
            else
            {
                asnCompiler.reset ();
                title = "CANNOT PARSE OBJECT IDENTIFIER REFERENCE";
                errorString = "";
                if (asnCompiler.ParseString (node.Emit (-1), new int [] { (int) AsnDeclarations.tokens.ReferencedValue_token }) == 0)
                {
                    ;
                }
                else
                {
                    asnCompiler.reset ();
                    title = "CANNOT PARSE OBJECT IDENTIFIER OBJECT SET";
                    errorString = "";
                    if (asnCompiler.ParseString (node.Emit (-1), new int [] { (int) AsnDeclarations.tokens.ObjectSet_token }) == 0)
                    {
                        ;
                    }
                    else
                    {
                        Console.Error.WriteLine (errorString);
                    }
                }
            }
            return;
        }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is ObjectIdentifierValue;
        public override SyntaxTreeBase GenerateCompatibleValue (Asn.Parser.Value value, NodeInspectorProvider provider) => provider.GenerateObjectIdentifierValue (value);
    }

    public class OctetStringTypeInspector : NodeInspector
    {
        public OctetStringTypeInspector (OctetStringType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is OctetStringValue;
        public override SyntaxTreeBase GenerateCompatibleValue (Value value, NodeInspectorProvider provider) => provider.GenerateOctetStringValue (value);
    }

    public class RealTypeInspector : NodeInspector
    {
        public RealTypeInspector (RealType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is RealValue;
    }

    public class RelativeIRITypeInspector : NodeInspector
    {
        public RelativeIRITypeInspector (RelativeIRIType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is RelativeIRIValue;
    }

    public class RelativeOIDTypeInspector : NodeInspector
    {
        public RelativeOIDTypeInspector (RelativeOIDType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is RelativeOIDValue;
        public override SyntaxTreeBase GenerateCompatibleValue (Asn.Parser.Value value, NodeInspectorProvider provider) => provider.GenerateRelativeOIDValue (value);
    }

    public class ComponentCounterInspector : NodeInspector
    {
        public ComponentCounterInspector (SyntaxTreeBase node) : base (node)
        {
        }

        public void ComputeLevel () => level = _ComputeLevel (Node);

        private int _ComputeLevel (SyntaxTreeBase node)
        {
            NodeInspector tableConstraintInspector = node.appInfo as NodeInspector;
            SyntaxTreeBase dependantNode = tableConstraintInspector?.Node;
            NodeInspector inspector = tableConstraintInspector?.tableConstraintLink;
            SyntaxTreeBase inspectorNode = inspector?.Node;
            if (inspectorNode == null)
                return 0;   // if any of above assignments provides null result,
                            // then node is not hierarchically related ASN.1
                            // data type (Sequence, Choice, Set) or is the outermost
                            // ASN.1 hierarchical data type
            for (; (dependantNode != null) && (dependantNode != inspectorNode); dependantNode = dependantNode.parent)
                ;
            if (dependantNode == null)
                return 0;   // nodes dependantNode and inspectorNode are not
                            // hierarchically related ASN.1 data types because
                            // they are not on the same path of the syntax tree
                            // generated by Anglr compiler although they are on
                            // the same hierarchical link of nodes connected
                            // with NodeInspector.tableConstraintLink. Node
                            // is outermost ASN.1 hierarchical data type

            // node is inner ASN.1 hierarchical data type. Search for
            // the outermost ASN.1 hierarchical data type at the next level
            return _ComputeLevel (inspectorNode) + 1;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public uint ComponentCounter { get { return ++componentCounter; } }
        public uint ComponentCount { get { return componentCounter; } }

        private uint componentCounter = 0;
        public int level { get; private set; } = -1;
    }

    public class ComponentTypeListInspector : ComponentCounterInspector
    {
        public ComponentTypeListInspector (SyntaxTreeBase node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public ComponentTypesDictionary ComponentTypes { get; private set; } = new ComponentTypesDictionary ();
        public EnumeratedComponentTypesDictionary EnumeratedComponentTypes { get; private set; } = new EnumeratedComponentTypesDictionary ();

        public override NodeInspector GetComponentInspector (string name)
        {
            ComponentType componentType = null;
            ComponentTypes.TryGetValue (name, out componentType);
            if (componentType == null)
                return null;
            switch ((ComponentType.production_kind) componentType.kind)
            {
                case ComponentType.production_kind.g_ComponentType_1:
                case ComponentType.production_kind.g_ComponentType_2:
                case ComponentType.production_kind.g_ComponentType_3:
                    return (NodeInspector) componentType.m_TypeOrNamedType.appInfo;
                case ComponentType.production_kind.g_ComponentType_4:
                    return (NodeInspector) componentType.m_Type.appInfo;
            }
            return null;
        }
    }

    public class SequenceTypeInspector : ComponentTypeListInspector
    {
        public SequenceTypeInspector (SequenceType node, NodeInspector tableConstraintLink) : base (node)
        {
            base.tableConstraintLink = tableConstraintLink;
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is SequenceValue;

        public override SyntaxTreeBase GenerateCompatibleValue (Value value, NodeInspectorProvider provider) => provider.GenerateSequenceValue (value);
    }

    public class SequenceOfTypeInspector : ComponentTypeListInspector
    {
        public SequenceOfTypeInspector (SequenceOfType node, NodeInspector tableConstraintLink) : base (node)
        {
            base.tableConstraintLink = tableConstraintLink;
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is SequenceOfValue;

        public override SyntaxTreeBase GenerateCompatibleValue (Value value, NodeInspectorProvider provider) => provider.GenerateSequenceOfValue (value);
    }

    public class SetTypeInspector : ComponentTypeListInspector
    {
        public SetTypeInspector (SetType node, NodeInspector tableConstraintLink) : base (node)
        {
            base.tableConstraintLink = tableConstraintLink;
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is SetValue;

        public override SyntaxTreeBase GenerateCompatibleValue (Value value, NodeInspectorProvider provider) => provider.GenerateSetValue (value);
    }

    public class SetOfTypeInspector : ComponentTypeListInspector
    {
        public SetOfTypeInspector (SetOfType node, NodeInspector tableConstraintLink) : base (node)
        {
            base.tableConstraintLink = tableConstraintLink;
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is SetOfValue;

        public override SyntaxTreeBase GenerateCompatibleValue (Value value, NodeInspectorProvider provider) => provider.GenerateSetOfValue (value);
        public override NodeInspector GetInspectorByType (System.Type type) => (type == typeof (SetOfTypeInspector)) ? this : null;
    }

    public class TaggedTypeInspector : NodeInspector
    {
        public TaggedTypeInspector (TaggedType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public string encodingReference { get; private set; } = "";
        public Class.production_kind kind { get; private set; } = Class.production_kind.g_Class_1;
        public uint classNumber { get; private set; } = 0;

        public void ComputeTagInfo ()
        {
            Tag tag = (Node as TaggedType).m_Tag;
            EncodingReference encodingReference = tag.m_EncodingReference;
            Class @class = tag.m_Class;
            ClassNumber classNumber = tag.m_ClassNumber;

            if ((EncodingReference.production_kind) encodingReference.kind != EncodingReference.production_kind.g_EncodingReference_2)
                this.encodingReference = encodingReference.m_encodingreference_token.m_typereference_token.m_typereference.text;

            if ((Class.production_kind) @class.kind != Class.production_kind.g_Class_4)
                kind = (Class.production_kind) @class.kind;

            switch ((ClassNumber.production_kind) classNumber.kind)
            {
                case ClassNumber.production_kind.g_ClassNumber_1:
                    this.classNumber = uint.Parse (classNumber.m_number.text);
                    break;
                case ClassNumber.production_kind.g_ClassNumber_2:
                {
                    NodeInspector inspector = classNumber.m_DefinedValue.appInfo as NodeInspector;
                    if (inspector != null)
                        break;
                }
                break;
            }
        }
        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) => ((Node as TaggedType)?.m_Type.appInfo as NodeInspector)?.Inspect (node, provider);
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => ((Node as TaggedType)?.m_Type.appInfo as NodeInspector)?.IsCompatibleValue (node);

        public override SyntaxTreeBase GenerateCompatibleValue (Value value, NodeInspectorProvider provider) => ((Node as TaggedType)?.m_Type.appInfo as NodeInspector)?.GenerateCompatibleValue (value, provider);
        public override NodeInspector GetComponentInspector (string name) => ((Node as TaggedType)?.m_Type.appInfo as NodeInspector)?.GetComponentInspector (name);
        public override NodeInspector GetInspectorByType (System.Type type) => ((Node as TaggedType)?.m_Type.appInfo as NodeInspector)?.GetInspectorByType (type);
    }

    public class EncodingPrefixedTypeInspector : NodeInspector
    {
        public EncodingPrefixedTypeInspector (EncodingPrefixedType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public string encodingReference { get; private set; } = "";
        public void ComputeEncodingInfo ()
        {
            EncodingPrefix encodingPrefix = (Node as EncodingPrefixedType).m_EncodingPrefix;
            EncodingReference encodingReference = encodingPrefix.m_EncodingReference;

            if ((EncodingReference.production_kind) encodingReference.kind != EncodingReference.production_kind.g_EncodingReference_2)
                this.encodingReference = encodingReference.m_encodingreference_token.m_typereference_token.m_typereference.text;
        }
        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) => ((Node as EncodingPrefixedType)?.m_Type.appInfo as NodeInspector)?.Inspect (node, provider);
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => ((Node as EncodingPrefixedType)?.m_Type.appInfo as NodeInspector)?.IsCompatibleValue (node);

        public override SyntaxTreeBase GenerateCompatibleValue (Value value, NodeInspectorProvider provider) => ((Node as EncodingPrefixedType)?.m_Type.appInfo as NodeInspector)?.GenerateCompatibleValue (value, provider);
        public override NodeInspector GetComponentInspector (string name) => ((Node as EncodingPrefixedType)?.m_Type.appInfo as NodeInspector)?.GetComponentInspector (name);
        public override NodeInspector GetInspectorByType (System.Type type) => ((Node as EncodingPrefixedType)?.m_Type.appInfo as NodeInspector)?.GetInspectorByType (type);
    }

    public class TimeTypeInspector : NodeInspector
    {
        public TimeTypeInspector (TimeType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is TimeValue;
    }

    public class TimeOfDayTypeInspector : NodeInspector
    {
        public TimeOfDayTypeInspector (TimeOfDayType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => node is TimeValue;
    }

    public class DefinedTypeInspector : NodeInspector
    {
        public DefinedTypeInspector (DefinedType node, NodeInspector nodeInspector) : base (node)
        {
            actualNodeInspector = nodeInspector;
            NodeType = (nodeInspector != null) ? nodeInspector.NodeType : NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
            if (!isActual)
                actualNodeInspector.Inspect (node, provider);
            else
                (Node.appInfo as NodeInspector).Inspect (node, provider);
        }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => isActual ? (Node.appInfo as NodeInspector)?.IsCompatibleValue (node) : actualNodeInspector?.IsCompatibleValue (node);

        public override SyntaxTreeBase GenerateCompatibleValue (Value value, NodeInspectorProvider provider) => isActual ? (Node.appInfo as NodeInspector)?.GenerateCompatibleValue (value, provider) : actualNodeInspector?.GenerateCompatibleValue (value, provider);
        public override NodeInspector GetComponentInspector (string name) => isActual ? null : actualNodeInspector.GetComponentInspector (name);
        public override NodeInspector GetInspectorByType (System.Type type) => isActual ? (Node.appInfo as NodeInspector)?.GetInspectorByType (type) : actualNodeInspector?.GetInspectorByType (type);
    }

    public class DefinedValueInspector : NodeInspector
    {
        public DefinedValueInspector (DefinedValue node, NodeInspector nodeInspector) : base (node)
        {
            actualNodeInspector = nodeInspector;
            NodeType = (nodeInspector != null) ? nodeInspector.NodeType : NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
            if (!isActual)
                actualNodeInspector.Inspect (node, provider);
            else
                (Node.appInfo as NodeInspector).Inspect (node, provider);
        }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => isActual ? (Node.appInfo as NodeInspector)?.IsCompatibleValue (node) : actualNodeInspector?.IsCompatibleValue (node);
    }

    public class DefinedObjectSetInspector : NodeInspector
    {
        public DefinedObjectSetInspector (DefinedObjectSet node, AsnSymbol objectSetReference) : base (node)
        {
            this.objectSetReference = objectSetReference;
            objectSetDefinition = objectSetReference?.Node;
            actualNodeInspector = objectSetDefinition?.appInfo as NodeInspector;
            NodeType = (actualNodeInspector != null) ? actualNodeInspector.NodeType : NodeType.TypeNode;
        }

        public AsnSymbol objectSetReference { get; private set; }
        public SyntaxTreeBase objectSetDefinition { get; private set; }
        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
            if (!isActual)
                actualNodeInspector.Inspect (node, provider);
            else
                (Node.appInfo as NodeInspector).Inspect (node, provider);
        }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => isActual ? (Node.appInfo as NodeInspector)?.IsCompatibleValue (node) : actualNodeInspector?.IsCompatibleValue (node);
        public override NodeInspector GetObjectInspector () => ((objectSetDefinition as ObjectSetAssignment)?.m_ObjectSet.appInfo as NodeInspector)?.GetObjectInspector ();
    }

    public class UsefulTypeInspector : NodeInspector
    {
        public UsefulTypeInspector (UsefulType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class SelectionTypeInspector : NodeInspector
    {
        public SelectionTypeInspector (SelectionType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ObjectNodeInspector : NodeInspector
    {
        public ObjectNodeInspector (SyntaxTreeBase node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public InfoFromObjectDescriptor objectNode { get; set; } = null;
        public override NodeInspector GetObjectInspector () => objectNode.node.appInfo as NodeInspector;
    }

    public class ValueFromObjectInspector : ObjectNodeInspector
    {
        public ValueFromObjectInspector (ValueFromObject node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        //public override NodeInspector GetObjectInspector () => objectNode.appInfo as NodeInspector;
    }

    public class ValueSetFromObjectsInspector : ObjectNodeInspector
    {
        public ValueSetFromObjectsInspector (ValueSetFromObjects node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        //public override NodeInspector GetObjectInspector () => objectNode.appInfo as NodeInspector;
    }

    public class TypeFromObjectInspector : ObjectNodeInspector
    {
        public TypeFromObjectInspector (TypeFromObject node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        //public override NodeInspector GetObjectInspector () => objectNode.appInfo as NodeInspector;
    }

    public class ObjectFromObjectInspector : ObjectNodeInspector
    {
        public ObjectFromObjectInspector (ObjectFromObject node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        //public override NodeInspector GetObjectInspector () => objectNode.appInfo as NodeInspector;
    }

    public class ObjectSetFromObjectsInspector : ObjectNodeInspector
    {
        public ObjectSetFromObjectsInspector (ObjectSetFromObjects node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        //public override NodeInspector GetObjectInspector () => objectNode.appInfo as NodeInspector;
    }

    public class ConstrainedTypeInspector : NodeInspector
    {
        public ConstrainedTypeInspector (ConstrainedType node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) => ((Node as ConstrainedType)?.m_Type.appInfo as NodeInspector)?.Inspect (node, provider);
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => ((Node as ConstrainedType)?.m_Type.appInfo as NodeInspector)?.IsCompatibleValue (node);
    }

    public class TypeWithConstraintInspector : NodeInspector
    {
        public TypeWithConstraintInspector (TypeWithConstraint node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class SetConstraintOfTypeInspector : NodeInspector
    {
        public SetConstraintOfTypeInspector (TypeWithConstraint node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class SetSizeConstraintOfTypeInspector : NodeInspector
    {
        public SetSizeConstraintOfTypeInspector (TypeWithConstraint node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class SequenceConstraintOfTypeInspector : NodeInspector
    {
        public SequenceConstraintOfTypeInspector (TypeWithConstraint node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class SequenceSizeConstraintOfTypeInspector : NodeInspector
    {
        public SequenceSizeConstraintOfTypeInspector (TypeWithConstraint node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class SetConstraintOfNamedTypeInspector : NodeInspector
    {
        public SetConstraintOfNamedTypeInspector (TypeWithConstraint node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class SetSizeConstraintOfNamedTypeInspector : NodeInspector
    {
        public SetSizeConstraintOfNamedTypeInspector (TypeWithConstraint node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class SequenceConstraintOfNamedTypeInspector : NodeInspector
    {
        public SequenceConstraintOfNamedTypeInspector (TypeWithConstraint node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class SequenceSizeConstraintOfNamedTypeInspector : NodeInspector
    {
        public SequenceSizeConstraintOfNamedTypeInspector (TypeWithConstraint node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ConstraintInspector : NodeInspector
    {
        public ConstraintInspector (Constraint node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public NodeInspector ConstraintSpec { get; set; }
        public NodeInspector ExceptionSpec { get; set; }
    }

    public class ElementSetInspector : NodeInspector
    {
        public ElementSetInspector (SyntaxTreeBase node) : base (node)
        {
        }
        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
            foreach (Elements element in elements)
            {
                switch ((Elements.production_kind) element.kind)
                {
                    case Elements.production_kind.g_Elements_1:
                        ((NodeInspector) element.m_SubtypeElements.appInfo)?.Inspect (element.m_SubtypeElements, provider);
                        break;
                    case Elements.production_kind.g_Elements_2:
                        ((NodeInspector) element.m_ObjectSetElements.appInfo)?.Inspect (element.m_ObjectSetElements, provider);
                        break;
                    case Elements.production_kind.g_Elements_3:
                        ((NodeInspector) element.m_ElementSetSpec.appInfo)?.Inspect (element.m_ElementSetSpec, provider);
                        break;
                }
            }
            return;
        }
        public List<Elements> elements { get; private set; } = new List<Elements> ();
    }

    public class ElementSetSpecsInspector : ElementSetInspector
    {
        public ElementSetSpecsInspector (ElementSetSpecs node) : base (node) { }
    }

    public class ObjectSetSpecInspector : ElementSetInspector
    {
        public ObjectSetSpecInspector (ObjectSetSpec node) : base (node) { }
        public override NodeInspector GetObjectInspector () => this;
    }

    public class ValueRangeInspector : NodeInspector
    {
        public ValueRangeInspector (ValueRange node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
            ValueRange valueRange = Node as ValueRange;
            LowerEndpoint lowerEndpoint = valueRange.m_LowerEndpoint;
            UpperEndpoint upperEndpoint = valueRange.m_UpperEndpoint;
            LowerEndValue lowerEndValue = lowerEndpoint.m_LowerEndValue;
            UpperEndValue upperEndValue = upperEndpoint.m_UpperEndValue;

            switch ((LowerEndValue.production_kind) lowerEndValue.kind)
            {
                case LowerEndValue.production_kind.g_LowerEndValue_1:
                    break;
                case LowerEndValue.production_kind.g_LowerEndValue_2:
                    break;
            }

            switch ((UpperEndValue.production_kind) upperEndValue.kind)
            {
                case UpperEndValue.production_kind.g_UpperEndValue_1:
                    break;
                case UpperEndValue.production_kind.g_UpperEndValue_2:
                    break;
            }
        }
    }

    public class SingleValueInspector : NodeInspector
    {
        public SingleValueInspector (SingleValue node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class ContainedSubtypeInspector : NodeInspector
    {
        public ContainedSubtypeInspector (ContainedSubtype node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class PermittedAlphabetInspector : NodeInspector
    {
        public PermittedAlphabetInspector (PermittedAlphabet node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class TypeConstraintInspector : NodeInspector
    {
        public TypeConstraintInspector (TypeConstraint node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class InnerTypeConstraintsInspector : NodeInspector
    {
        public InnerTypeConstraintsInspector (InnerTypeConstraints node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class PatternConstraintInspector : NodeInspector
    {
        public PatternConstraintInspector (PatternConstraint node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class PropertySettingsInspector : NodeInspector
    {
        public PropertySettingsInspector (PropertySettings node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class DurationRangeInspector : NodeInspector
    {
        public DurationRangeInspector (DurationRange node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class TimePointRangeInspector : NodeInspector
    {
        public TimePointRangeInspector (TimePointRange node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class RecurrenceRangeInspector : NodeInspector
    {
        public RecurrenceRangeInspector (RecurrenceRange node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class UserDefinedConstraintInspector : NodeInspector
    {
        public UserDefinedConstraintInspector (UserDefinedConstraint node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }

        public List<UserDefinedConstraintParameter> parameters { get; private set; } = new List<UserDefinedConstraintParameter> ();
    }

    public class ComponentRelationConstraintInspector : NodeInspector
    {
        public ComponentRelationConstraintInspector (ComponentRelationConstraint node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }

        public DefinedObjectSet objectSet { get; set; } = null;
        public List<AtNotation> notations { get; private set; } = new List<AtNotation> ();
    }

    public class ObjectClassInspector : NodeInspector
    {
        public ObjectClassInspector (ObjectClass node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class DefinedObjectInspector : NodeInspector
    {
        public DefinedObjectInspector (DefinedObject node, AsnSymbol objectReference) : base (node)
        {
            this.objectReference = objectReference;
            objectDefinition = objectReference?.Node;
            actualNodeInspector = objectDefinition?.appInfo as NodeInspector;
            NodeType = (actualNodeInspector != null) ? actualNodeInspector.NodeType : NodeType.ClassNode;
        }

        public AsnSymbol objectReference { get; private set; }
        public SyntaxTreeBase objectDefinition { get; private set; }
        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) => actualNodeInspector?.Inspect (node, provider);
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => actualNodeInspector?.IsCompatibleValue (node);
        public override int? GetComponentCount () => ((objectDefinition as ObjectAssignment)?.m_Object.appInfo as NodeInspector)?.GetComponentCount ();
        public override NodeInspector GetObjectInspector () => ((NodeInspector) ((objectDefinition as ObjectAssignment)?.m_Object.appInfo))?.GetObjectInspector ();
    }

    public class DefinedObjectClassInspector : NodeInspector
    {
        public DefinedObjectClassInspector (DefinedObjectClass node, AsnSymbol classReference) : base (node)
        {
            this.classReference = classReference;
            classDefinition = this.classReference?.Node;
            actualNodeInspector = (NodeInspector) classDefinition?.appInfo;
            NodeType = (actualNodeInspector != null) ? actualNodeInspector.NodeType : NodeType.ClassNode;
        }

        public AsnSymbol classReference { get; private set; }
        public SyntaxTreeBase classDefinition { get; private set; }
        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
            if (!isActual)
                actualNodeInspector?.Inspect (node, provider);
            else
                (Node.appInfo as NodeInspector)?.Inspect (node, provider);
        }
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => isActual ? (Node.appInfo as NodeInspector)?.IsCompatibleValue (node) : actualNodeInspector?.IsCompatibleValue (node);
    }

    public class ObjectClassDefnInspector : NodeInspector
    {
        public ObjectClassDefnInspector (ObjectClassDefn node) : base (node)
        {
            NodeType = NodeType.ClassNode;
        }
        public FieldSpecsDictionary FieldSpecs { get; private set; } = new FieldSpecsDictionary ();
        public List<(string pattern, string fieldName)> Patterns { get; set; } = null;

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
            Asn.Parser.Object @object = node as Asn.Parser.Object;
            if (@object == null)
            {
                if (node is ObjectSet)
                    ;
                else if (node is Value)
                    ;
                else if (node is ObjectSetElements)
                    ;
                else
                    ;
                return;
            }
            if ((Asn.Parser.Object.production_kind) @object.kind != Asn.Parser.Object.production_kind.g_Object_2)
                return;
            ObjectDefn defn = @object.m_ObjectDefn;
            DefaultSyntax syntax = defn.m_DefaultSyntax;
            if (syntax == null)
                return;
            FieldSetting_set fieldSettingSet = syntax.m_FieldSetting_set;
            if (fieldSettingSet == null)
                return;
            ObjectInspector inspector = @object.appInfo as ObjectInspector;
            @object.m_ObjectDefn.m_DefaultSyntax.m_FieldSetting_set.Iterate (null, (fsSet, appData) =>
            {
                FieldSetting setting = fsSet.m_FieldSetting;
                string fieldNme = '&' + setting.m_PrimitiveFieldName.Emit (-1).Substring (2);
                if (!FieldSpecs.TryGetValue (fieldNme, out var fieldSpec))
                    return null;    // unknown field name
                if (inspector.Settings.TryGetValue (fieldNme, out var settings))
                    return null;    // multiplicated field name
                inspector.Settings [fieldNme] = setting.m_Setting;
                return null;
            });
            for (FieldSpecsDictionary.Enumerator enumerator = FieldSpecs.GetEnumerator (); enumerator.MoveNext ();)
            {
                string fieldName = enumerator.Current.Key;
                if (inspector.Settings.TryGetValue (fieldName, out var settings))
                    continue;
                FieldSpec fieldSpec = enumerator.Current.Value;
                FieldSpecInspector fieldSpecInspector = fieldSpec.appInfo as FieldSpecInspector;
                if (fieldSpecInspector == null)
                    continue;
                bool isOptional = fieldSpecInspector.isOptional ();
                SyntaxTreeBase defaultNode = fieldSpecInspector.defaultNode ();
                if (isOptional)
                    inspector.Settings [fieldName] = null;
                else
                    inspector.Settings [fieldName] = fieldSpecInspector.CreateSetting (defaultNode);
            }
            inspector.ComputeHashCode ();
            ++objectCounter;
            return;
        }
        static public uint objectCounter { get; private set; } = 0;
    }

    public class ObjectInspector : NodeInspector
    {
        public ObjectInspector (Asn.Parser.Object node, NodeInspector governor) : base (node)
        {
            this.governor = governor;
            hashCode = 0;
        }
        public NodeInspector governor { get; private set; }
        public SettingsDitionary Settings { get; private set; } = new SettingsDitionary ();
        public int hashCode { get; private set; }

        public void ComputeHashCode ()
        {
            foreach (Setting setting in this.Settings.Values)
            {
                if (setting == null)
                    continue;
                hashCode += setting.Emit (-1).GetHashCode ();
            }
        }
        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
        }
        public override int? GetComponentCount () => Settings.Count;
        public override NodeInspector GetObjectInspector () => this;
    }

    public class FieldSpecInspector : NodeInspector
    {
        public FieldSpecInspector (SyntaxTreeBase node) : base (node)
        {
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider)
        {
        }
        public virtual bool isOptional () => false;
        public virtual SyntaxTreeBase defaultNode () => null;
        public virtual Setting CreateSetting (SyntaxTreeBase node) => null;
        public virtual ObjectClassDefnInspector GetClassDefnInspector () => null;
        public virtual NodeInspector GetSettingInspector () => null;
    }
    public class TypeFieldSpecInspector : FieldSpecInspector
    {
        public TypeFieldSpecInspector (TypeFieldSpec node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool isOptional () => ((TypeFieldSpec) Node).m_TypeOptionalitySpec_optional.m_TypeOptionalitySpec?.m_OPTIONAL != null;
        public override SyntaxTreeBase defaultNode () => ((TypeFieldSpec) Node).m_TypeOptionalitySpec_optional.m_TypeOptionalitySpec?.m_Type;
        public override Setting CreateSetting (SyntaxTreeBase node) => (node is Asn.Parser.Type) ? new Setting (node as Asn.Parser.Type) : null;
    }

    public class FixedTypeValueFieldSpecInspector : FieldSpecInspector
    {
        public FixedTypeValueFieldSpecInspector (FixedTypeValueFieldSpec node) : base (node)
        {
            NodeType = NodeType.ClassNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) => ((Node as FixedTypeValueFieldSpec)?.m_Type.appInfo as NodeInspector)?.Inspect (node, provider);
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => ((Node as FixedTypeValueFieldSpec)?.m_Type.appInfo as NodeInspector)?.IsCompatibleValue (node);

        public override SyntaxTreeBase GenerateCompatibleValue (Value value, NodeInspectorProvider provider) => isActual ? ((Node as FixedTypeValueFieldSpec)?.m_Type.appInfo as NodeInspector)?.GenerateCompatibleValue (value, provider) : actualNodeInspector.GenerateCompatibleValue (value, provider);
        public override NodeInspector GetComponentInspector (string name) => isActual ? ((Node as FixedTypeValueFieldSpec)?.m_Type.appInfo as NodeInspector)?.GetComponentInspector (name) : actualNodeInspector.GetComponentInspector (name);
        public override bool isOptional () => ((FixedTypeValueFieldSpec) Node).m_ValueOptionalitySpec_optional.m_ValueOptionalitySpec?.m_OPTIONAL != null;
        public override SyntaxTreeBase defaultNode () => ((FixedTypeValueFieldSpec) Node).m_ValueOptionalitySpec_optional.m_ValueOptionalitySpec?.m_Value;
        public override Setting CreateSetting (SyntaxTreeBase node) => (node is Value) ? new Setting (node as Value) : null;
        public override NodeInspector GetSettingInspector () => (Node as FixedTypeValueFieldSpec)?.m_Type?.appInfo as NodeInspector;
    }

    public class VariableTypeValueFieldSpecInspector : FieldSpecInspector
    {
        public VariableTypeValueFieldSpecInspector (VariableTypeValueFieldSpec node) : base (node)
        {
            NodeType = NodeType.ClassNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool isOptional () => ((VariableTypeValueFieldSpec) Node).m_ValueOptionalitySpec_optional.m_ValueOptionalitySpec?.m_OPTIONAL != null;
        public override SyntaxTreeBase defaultNode () => ((VariableTypeValueFieldSpec) Node).m_ValueOptionalitySpec_optional.m_ValueOptionalitySpec?.m_Value;
        public override Setting CreateSetting (SyntaxTreeBase node) => (node is Value) ? new Setting (node as Value) : null;
    }

    public class FixedTypeValueSetFieldSpecInspector : FieldSpecInspector
    {
        public FixedTypeValueSetFieldSpecInspector (FixedTypeValueSetFieldSpec node) : base (node)
        {
            NodeType = NodeType.ClassNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool isOptional () => ((FixedTypeValueSetFieldSpec) Node).m_ValueSetOptionalitySpec_optional?.m_ValueSetOptionalitySpec?.m_OPTIONAL != null;
        public override SyntaxTreeBase defaultNode () => ((FixedTypeValueSetFieldSpec) Node).m_ValueSetOptionalitySpec_optional?.m_ValueSetOptionalitySpec?.m_ValueSet;
        public override Setting CreateSetting (SyntaxTreeBase node) => (node is ValueSet) ? new Setting (node as ValueSet) : null;
        public override NodeInspector GetSettingInspector () => (Node as FixedTypeValueSetFieldSpec)?.m_Type?.appInfo as NodeInspector;
    }

    public class VariableTypeValueSetFieldSpecInspector : FieldSpecInspector
    {
        public VariableTypeValueSetFieldSpecInspector (VariableTypeValueSetFieldSpec node) : base (node)
        {
            NodeType = NodeType.ClassNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
        public override bool isOptional () => ((VariableTypeValueSetFieldSpec) Node).m_ValueSetOptionalitySpec_optional?.m_ValueSetOptionalitySpec?.m_OPTIONAL != null;
        public override SyntaxTreeBase defaultNode () => ((VariableTypeValueSetFieldSpec) Node).m_ValueSetOptionalitySpec_optional?.m_ValueSetOptionalitySpec?.m_ValueSet;
        public override Setting CreateSetting (SyntaxTreeBase node) => (node is ValueSet) ? new Setting (node as ValueSet) : null;
    }

    public class ObjectFieldSpecInspector : FieldSpecInspector
    {
        public ObjectFieldSpecInspector (ObjectFieldSpec node) : base (node)
        {
            NodeType = NodeType.ClassNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) => (Node.appInfo as NodeInspector)?.actualNodeInspector?.Inspect (node, provider);
        public override bool isOptional () => ((ObjectFieldSpec) Node).m_ObjectOptionalitySpec_optional?.m_ObjectOptionalitySpec?.m_OPTIONAL != null;
        public override SyntaxTreeBase defaultNode () => ((ObjectFieldSpec) Node).m_ObjectOptionalitySpec_optional?.m_ObjectOptionalitySpec?.m_Object;
        public override Setting CreateSetting (SyntaxTreeBase node) => (node is Asn.Parser.Object) ? new Setting (node as Asn.Parser.Object) : null;
        public override ObjectClassDefnInspector GetClassDefnInspector () => ((Node.appInfo as DefinedObjectClassInspector)?.classDefinition)?.appInfo as ObjectClassDefnInspector;
    }

    public class ObjectSetFieldSpecInspector : FieldSpecInspector
    {
        public ObjectSetFieldSpecInspector (ObjectSetFieldSpec node) : base (node)
        {
            NodeType = NodeType.ClassNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) => (Node.appInfo as NodeInspector)?.actualNodeInspector?.Inspect (node, provider);
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => (Node.appInfo as NodeInspector)?.actualNodeInspector?.IsCompatibleValue (node);
        public override SyntaxTreeBase GenerateCompatibleValue (Asn.Parser.Value value, NodeInspectorProvider provider) => (Node.appInfo as NodeInspector)?.actualNodeInspector?.GenerateCompatibleValue (value, provider);
        public override bool isOptional () => ((ObjectSetFieldSpec) Node).m_ObjectSetOptionalitySpec_optional?.m_ObjectSetOptionalitySpec?.m_OPTIONAL != null;
        public override SyntaxTreeBase defaultNode () => ((ObjectSetFieldSpec) Node).m_ObjectSetOptionalitySpec_optional?.m_ObjectSetOptionalitySpec?.m_ObjectSet;
        public override Setting CreateSetting (SyntaxTreeBase node) => (node is ObjectSet) ? new Setting (node as ObjectSet) : null;
        public override ObjectClassDefnInspector GetClassDefnInspector () => ((Node.appInfo as DefinedObjectClassInspector)?.classDefinition)?.appInfo as ObjectClassDefnInspector;
    }

    public class FieldSettingInspector : NodeInspector
    {
        public FieldSettingInspector (FieldSetting node, FieldSpec fieldSpec) : base (node)
        {
            NodeType = NodeType.ClassNode;
            this.fieldSpec = fieldSpec;
            actualNodeInspector = (NodeInspector) fieldSpec.appInfo;
        }

        public FieldSpec fieldSpec { get; private set; } = null;
        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) => actualNodeInspector?.Inspect (node, provider);
        public override bool? IsCompatibleValue (SyntaxTreeBase node) => actualNodeInspector?.IsCompatibleValue (node);
        public bool? isOptional () => isActual ? null : (actualNodeInspector as FieldSpecInspector)?.isOptional ();
        public SyntaxTreeBase defaultNode () => isActual ? null : (actualNodeInspector as FieldSpecInspector)?.defaultNode ();
    }

    public class SizeConstraintInspector : NodeInspector
    {
        public SizeConstraintInspector (SyntaxTreeBase node) : base (node)
        {
            NodeType = NodeType.TypeNode;
        }

        public override void Inspect (SyntaxTreeBase node, NodeInspectorProvider provider) { }
    }

    public class AsnInspectorStack<T> : Stack<T>
    {
        private int depth = 0;
        private int maxDepth = 0;
        public new T Peek () { return base.Peek (); }
        public new T Pop () { --depth; return base.Pop (); }
        public new void Push (T item)
        {
            if (++depth > maxDepth)
            {
                maxDepth = depth;
            }
            if (Activity)
            {
                if (item == null)
                    ;
                base.Push (item);
            }
        }
        public static bool Activity { get; set; } = true;
    }

    public class AsnParserStack<T> : Stack<T>
    {
        private int depth = 0;
        private int maxDepth = 0;
        public new T Peek () { return base.Peek (); }
        public new T Pop () { --depth; return base.Pop (); }
        public new void Push (T item)
        {
            if (++depth > maxDepth)
            {
                maxDepth = depth;
            }
            if (Activity)
            {
                if (item == null)
                    ;
                base.Push (item);
            }
        }
        public static bool Activity { get; set; } = true;
    }

    public class AsnDebugStack<T> : Stack<T>
    {
        public new T Peek () { return base.Peek (); }
        public new T Pop () { return base.Pop (); }
        public new void Push (T item)
        {
            SyntaxTreeBase node = null;
            try
            {
                node = item as SyntaxTreeBase;
            }
            catch (Exception e)
            {

            }
            if (Activity)
            {
                if (item == null)
                    ;
                base.Push (item);
            }
        }
        public static bool Activity { get; set; } = true;
    }

    public class AssignmentDebugStack<T> : Stack<T>
    {
        public new T Peek () { return base.Peek (); }
        public new T Pop () { return base.Pop (); }
        public new void Push (T item)
        {
            SyntaxTreeBase node = null;
            try
            {
                node = item as SyntaxTreeBase;
            }
            catch (Exception e)
            {

            }
            if (Activity)
            {
                if (item == null)
                    ;
                base.Push (item);
            }
        }
        public static bool Activity { get; set; } = true;
    }

    public class FieldDebugStack<T> : Stack<T>
    {
        public new T Peek () { return base.Peek (); }
        public new T Pop () { return base.Pop (); }
        public new void Push (T item)
        {
            SyntaxTreeBase node = null;
            try
            {
                node = item as SyntaxTreeBase;
            }
            catch (Exception e)
            {

            }
            if (Activity)
            {
                if (item == null)
                    ;
                base.Push (item);
            }
        }
        public static bool Activity { get; set; } = true;
    }

    public class ObjectDebugStack<T> : Stack<T>
    {
        public new T Peek () { return base.Peek (); }
        public new T Pop () { return base.Pop (); }
        public new void Push (T item)
        {
            SyntaxTreeBase node = null;
            try
            {
                node = item as SyntaxTreeBase;
            }
            catch (Exception e)
            {

            }
            if (Activity)
            {
                if (item == null)
                    ;
                base.Push (item);
            }
        }
        public static bool Activity { get; set; } = true;
    }

    public class ParameterizedDebugStack<T> : Stack<T>
    {
        public new T Peek () { return base.Peek (); }
        public new T Pop () { return base.Pop (); }
        public new void Push (T item)
        {
            SyntaxTreeBase node = null;
            try
            {
                node = item as SyntaxTreeBase;
            }
            catch (Exception e)
            {

            }
            if (Activity)
            {
                if (item == null)
                    ;
                base.Push (item);
            }
        }
        public static bool Activity { get; set; } = true;
    }
}
