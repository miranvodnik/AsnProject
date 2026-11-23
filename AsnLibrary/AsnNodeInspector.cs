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
using System.Diagnostics.SymbolStore;
using System.Data;
using System.Dynamic;
using static System.Net.Mime.MediaTypeNames;

namespace AsnLibrary
{
    public class AsnPatternComparer : IComparer<(int position, int length, int index)>
    {
        public int Compare ((int position, int length, int index) x, (int position, int length, int index) y)
        {
            if (x.position + x.length < y.position)
                return -1;
            if (y.position + y.length < x.position)
                return 1;
            return 0;
        }
    }

    public class AsnPatternSet : SortedSet<(int position, int length, int index)>
    {
        public AsnPatternSet () : base (new AsnPatternComparer ())
        {

        }
    }

    public class AsnNodeInspector : NodeInspectorProvider
    {
        public AsnNodeInspector ()
        {
            TypeAssignment_Event += AsnNodeInspector_TypeAssignment_Event;
            ValueAssignment_Event += AsnNodeInspector_ValueAssignment_Event;
            XMLValueAssignment_Event += AsnNodeInspector_XMLValueAssignment_Event;
            ValueSetTypeAssignment_Event += AsnNodeInspector_ValueSetTypeAssignment_Event;
            ObjectClassAssignment_Event += AsnNodeInspector_ObjectClassAssignment_Event;
            ObjectAssignment_Event += AsnNodeInspector_ObjectAssignment_Event;
            ObjectSetAssignment_Event += AsnNodeInspector_ObjectSetAssignment_Event;
            ParameterizedAssignment_Event += AsnNodeInspector_ParameterizedAssignment_Event;
            ParameterizedTypeAssignment_Event += (reason, kind, node) => { return false; };
            ParameterizedValueAssignment_Event += (reason, kind, node) => { return false; };
            ParameterizedValueSetTypeAssignment_Event += (reason, kind, node) => { return false; };
            ParameterizedObjectClassAssignment_Event += (reason, kind, node) => { return false; };
            ParameterizedObjectAssignment_Event += (reason, kind, node) => { return false; };
            ParameterizedObjectSetAssignment_Event += (reason, kind, node) => { return false; };
            MacroAssignment_Event += AsnNodeInspector_MacroAssignment_Event;
            MacroDefinition_Event += AsnNodeInspector_MacroDefinition_Event;

            ValueSet_Event += AsnNodeInspector_ValueSet_Event;
            Type_Event += AsnNodeInspector_Type_Event;

            BuiltinType_Event += AsnNodeInspector_BuiltinType_Event;
            ReferencedType_Event += AsnNodeInspector_ReferencedType_Event;

            ConstrainedType_Event += AsnNodeInspector_ConstrainedType_Event;
            TypeWithConstraint_Event += AsnNodeInspector_TypeWithConstraint_Event;
            Constraint_Event += AsnNodeInspector_Constraint_Event;
            ConstraintSpec_Event += AsnNodeInspector_ConstraintSpec_Event;
            SubtypeConstraint_Event += AsnNodeInspector_SubtypeConstraint_Event;
            ElementSetSpecs_Event += AsnNodeInspector_ElementSetSpecs_Event;
            Elements_Event += AsnNodeInspector_Elements_Event;
            SubtypeElements_Event += AsnNodeInspector_SubtypeElements_Event;
            ValueRange_Event += AsnNodeInspector_ValueRange_Event;
            LowerEndValue_Event += AsnNodeInspector_LowerEndValue_Event;
            UpperEndValue_Event += AsnNodeInspector_UpperEndValue_Event;
            SingleValue_Event += AsnNodeInspector_SingleValue_Event;
            ContainedSubtype_Event += AsnNodeInspector_ContainedSubtype_Event;
            SEValueRange_Event += AsnNodeInspector_SEValueRange_Event;
            PermittedAlphabet_Event += AsnNodeInspector_PermittedAlphabet_Event;
            SESizeConstraint_Event += AsnNodeInspector_SESizeConstraint_Event;
            TypeConstraint_Event += AsnNodeInspector_TypeConstraint_Event;
            InnerTypeConstraints_Event += AsnNodeInspector_InnerTypeConstraints_Event;
            PatternConstraint_Event += AsnNodeInspector_PatternConstraint_Event;
            PropertySettings_Event += AsnNodeInspector_PropertySettings_Event;
            DurationRange_Event += AsnNodeInspector_DurationRange_Event;
            TimePointRange_Event += AsnNodeInspector_TimePointRange_Event;
            RecurrenceRange_Event += AsnNodeInspector_RecurrenceRange_Event;
            UserDefinedConstraint_Event += AsnNodeInspector_UserDefinedConstraint_Event;
            UserDefinedConstraintParameter_Event += AsnNodeInspector_UserDefinedConstraintParameter_Event;
            TableConstraint_Event += AsnNodeInspector_TableConstraint_Event;
            ContentsConstraint_Event += AsnNodeInspector_ContentsConstraint_Event;

            AnyType_Event += AsnNodeInspector_AnyType_Event;
            BitStringType_Event += AsnNodeInspector_BitStringType_Event;
            BooleanType_Event += AsnNodeInspector_BooleanType_Event;
            CharacterStringType_Event += AsnNodeInspector_CharacterStringType_Event;
            ChoiceType_Event += AsnNodeInspector_ChoiceType_Event;
            DateType_Event += AsnNodeInspector_DateType_Event;
            DateTimeType_Event += AsnNodeInspector_DateTimeType_Event;
            DurationType_Event += AsnNodeInspector_DurationType_Event;
            EmbeddedPDVType_Event += AsnNodeInspector_EmbeddedPDVType_Event;
            EnumeratedType_Event += AsnNodeInspector_EnumeratedType_Event;
            ExternalType_Event += AsnNodeInspector_ExternalType_Event;
            InstanceOfType_Event += AsnNodeInspector_InstanceOfType_Event;
            IntegerType_Event += AsnNodeInspector_IntegerType_Event;
            IRIType_Event += AsnNodeInspector_IRIType_Event;
            NullType_Event += AsnNodeInspector_NullType_Event;
            ObjectClassFieldType_Event += AsnNodeInspector_ObjectClassFieldType_Event;
            ObjectIdentifierType_Event += AsnNodeInspector_ObjectIdentifierType_Event;
            OctetStringType_Event += AsnNodeInspector_OctetStringType_Event;
            RealType_Event += AsnNodeInspector_RealType_Event;
            RelativeIRIType_Event += AsnNodeInspector_RelativeIRIType_Event;
            RelativeOIDType_Event += AsnNodeInspector_RelativeOIDType_Event;
            SequenceType_Event += AsnNodeInspector_SequenceType_Event;
            SequenceOfType_Event += AsnNodeInspector_SequenceOfType_Event;
            SetType_Event += AsnNodeInspector_SetType_Event;
            SetOfType_Event += AsnNodeInspector_SetOfType_Event;
            PrefixedType_Event += AsnNodeInspector_PrefixedType_Event;
            TaggedType_Event += AsnNodeInspector_TaggedType_Event;
            EncodingPrefixedType_Event += AsnNodeInspector_EncodingPrefixedType_Event;
            TimeType_Event += AsnNodeInspector_TimeType_Event;
            TimeOfDayType_Event += AsnNodeInspector_TimeOfDayType_Event;

            NamedBit_Event += AsnNodeInspector_NamedBit_Event;

            EnumerationItem_Event += AsnNodeInspector_EnumerationItem_Event;
            NamedNumberItem_Event += AsnNodeInspector_NamedNumberItem_Event;

            NamedType_Event += AsnNodeInspector_NamedType_Event;
            TypeOrNamedType_Event += AsnNodeInspector_TypeOrNamedType_Event;
            AltTypeOrNamedType_Event += AsnNodeInspector_AltTypeOrNamedType_Event;

            ComponentType_Event += AsnNodeInspector_ComponentType_Event;
            ExceptionIdentification_Event += AsnNodeInspector_ExceptionIdentification_Event;
            SizeConstraint_Event += AsnNodeInspector_SizeConstraint_Event;

            DefinedType_Event += AsnNodeInspector_DefinedType_Event;
            UsefulType_Event += AsnNodeInspector_UsefulType_Event;
            SelectionType_Event += AsnNodeInspector_SelectionType_Event;

            ObjectClass_Event += AsnNodeInspector_ObjectClass_Event;
            DefinedObjectClass_Event += AsnNodeInspector_DefinedObjectClass_Event;
            DefinedObject_Event += AsnNodeInspector_DefinedObject_Event;
            DefinedObjectSet_Event += AsnNodeInspector_DefinedObjectSet_Event;
            ObjectClassDefn_Event += AsnNodeInspector_ObjectClassDefn_Event;
            TypeFieldSpec_Event += AsnNodeInspector_TypeFieldSpec_Event;
            FixedTypeValueFieldSpec_Event += AsnNodeInspector_FixedTypeValueFieldSpec_Event;
            VariableTypeValueFieldSpec_Event += AsnNodeInspector_VariableTypeValueFieldSpec_Event;
            FixedTypeValueSetFieldSpec_Event += AsnNodeInspector_FixedTypeValueSetFieldSpec_Event;
            VariableTypeValueSetFieldSpec_Event += AsnNodeInspector_VariableTypeValueSetFieldSpec_Event;
            ObjectFieldSpec_Event += AsnNodeInspector_ObjectFieldSpec_Event;
            ObjectSetFieldSpec_Event += AsnNodeInspector_ObjectSetFieldSpec_Event;
            FieldName_Event += AsnNodeInspector_FieldName_Event;
            DefinedSyntax_Event += AsnNodeInspector_DefinedSyntax_Event;
            FieldSetting_Event += AsnNodeInspector_FieldSetting_Event;
            ObjectDefn_Event += AsnNodeInspector_ObjectDefn_Event;

            Object_Event += AsnNodeInspector_Object_Event;
            ObjectSet_Event += AsnNodeInspector_ObjectSet_Event;
            ObjectSetSpec_Event += AsnNodeInspector_ObjectSetSpec_Event;

            ParameterizedType_Event += AsnNodeInspector_ParameterizedType_Event;
            ParameterizedValue_Event += AsnNodeInspector_ParameterizedValue_Event;
            ParameterizedValueSetType_Event += AsnNodeInspector_ParameterizedValueSetType_Event;
            ParameterizedObjectClass_Event += AsnNodeInspector_ParameterizedObjectClass_Event;
            ParameterizedObjectSet_Event += AsnNodeInspector_ParameterizedObjectSet_Event;
            ParameterizedObject_Event += AsnNodeInspector_ParameterizedObject_Event;

            ReferencedObjects_Event += AsnNodeInspector_ReferencedObjects_Event;
            ValueFromObject_Event += AsnNodeInspector_ValueFromObject_Event;
            ValueSetFromObjects_Event += AsnNodeInspector_ValueSetFromObjects_Event;
            TypeFromObject_Event += AsnNodeInspector_TypeFromObject_Event;
            ObjectFromObject_Event += AsnNodeInspector_ObjectFromObject_Event;
            ObjectSetFromObjects_Event += AsnNodeInspector_ObjectSetFromObjects_Event;

            ActualParameterList_Event += (reason, kind, node) => { return false; };
            WithSyntaxSpec_Event += (reason, kind, node) => { return false; };

            Value_Event += AsnNodeInspector_Value_Event;

            BuiltinValue_Event += AsnNodeInspector_BuiltinValue_Event;
            ReferencedValue_Event += AsnNodeInspector_ReferencedValue_Event;
            OpenTypeFieldVal_Event += AsnNodeInspector_OpenTypeFieldVal_Event;

            BitStringValue_Event += AsnNodeInspector_BitStringValue_Event;
            BooleanValue_Event += AsnNodeInspector_BooleanValue_Event;
            CharacterStringValue_Event += AsnNodeInspector_CharacterStringValue_Event;
            ChoiceValue_Event += AsnNodeInspector_ChoiceValue_Event;
            EmbeddedPDVValue_Event += AsnNodeInspector_EmbeddedPDVValue_Event;
            EnumeratedValue_Event += AsnNodeInspector_EnumeratedValue_Event;
            ExternalValue_Event += AsnNodeInspector_ExternalValue_Event;
            IntegerValue_Event += AsnNodeInspector_IntegerValue_Event;
            IRIValue_Event += AsnNodeInspector_IRIValue_Event;
            NullValue_Event += AsnNodeInspector_NullValue_Event;
            ObjectIdentifierValue_Event += AsnNodeInspector_ObjectIdentifierValue_Event;
            OctetStringValue_Event += AsnNodeInspector_OctetStringValue_Event;
            RealValue_Event += AsnNodeInspector_RealValue_Event;
            RelativeIRIValue_Event += AsnNodeInspector_RelativeIRIValue_Event;
            RelativeOIDValue_Event += AsnNodeInspector_RelativeOIDValue_Event;
            SequenceValue_Event += AsnNodeInspector_SequenceValue_Event;
            SequenceOfValue_Event += AsnNodeInspector_SequenceOfValue_Event;
            SetValue_Event += AsnNodeInspector_SetValue_Event;
            SetOfValue_Event += AsnNodeInspector_SetOfValue_Event;
            TimeValue_Event += AsnNodeInspector_TimeValue_Event;

            ComponentValueList_Event += AsnNodeInspector_ComponentValueList_Event;
            NamedValueList_Event += AsnNodeInspector_NamedValueList_Event;

            DefinedValue_Event += AsnNodeInspector_DefinedValue_Event;
            NamedValue_Event += AsnNodeInspector_NamedValue_Event;

            RestrictedCharacterStringValue_Event += AsnNodeInspector_RestrictedCharacterStringValue_Event;
            UnrestrictedCharacterStringValue_Event += AsnNodeInspector_UnrestrictedCharacterStringValue_Event;

            NumericRealValue_Event += AsnNodeInspector_NumericRealValue_Event;
            SpecialRealValue_Event += AsnNodeInspector_SpecialRealValue_Event;

            NamedConstraint_Event += AsnNodeInspector_NamedConstraint_Event;

            GeneralConstraint_Event += AsnNodeInspector_GeneralConstraint_Event;
            asnModuleDereferencer.AddEventHandlers ();
        }

        private bool AsnNodeInspector_TypeAssignment_Event (SyntaxTreeCallbackReason reason, TypeAssignment.production_kind kind, TypeAssignment p_TypeAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    contextStack.Push ((AsnSymbol) p_TypeAssignment.m_typereference_token.appInfo);
                    if (p_TypeAssignment.appInfo != null)
                        return false;
                    p_TypeAssignment.appInfo = new TypeAssignmentInspector (p_TypeAssignment);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    contextStack.Pop ();
                    NodeInspector nodeInfo = null;
                    nodeInfo = (NodeInspector) p_TypeAssignment.m_Type.appInfo;
                    if (nodeInfo == null)
                    {
                        Console.Error.WriteLine ($"ERROR: UNDEFINED GOVERNING NODE FOR TYPE ASSIGNMENT:");
                        Console.Error.WriteLine ($"\t{p_TypeAssignment.Emit (-1)}");
                        break;
                    }
                    if (nodeInfo.NodeType != NodeType.TypeNode)
                    {
                        if (Debug)
                        {
                            Console.Error.WriteLine ($"ERROR: ASSIGNMENT IS NOT TYPE ASSIGNMENT:");
                            Console.Error.WriteLine ($"\t{p_TypeAssignment.Emit (-1)}");
                            Console.Error.WriteLine ($"GOVERNOR:");
                            Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                        }

                        string text = p_TypeAssignment.Emit (-1);
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT CONVERT TYPE ASSIGNMENT TO CLASS ASSIGNMENT:");
                            Console.Error.WriteLine ($"\t{p_TypeAssignment.Emit (-1)}");
                            Console.Error.WriteLine ($"GOVERNOR:");
                            Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                            return true;
                        };
                        if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.ObjectClassAssignment_token }) == 0)
                        {
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                node.reparent (null);
                                ((AsnSymbol) (((asn_features) node).m_ObjectClassAssignment.m_objectclassreference_token.m_typereference_token.m_typereference.appInfo =
                                    p_TypeAssignment.m_typereference_token.m_typereference.appInfo)).Node = ((asn_features) node).m_ObjectClassAssignment;
                                assignmentStack.Push (node);
                                Traverse (((asn_features) node).m_ObjectClassAssignment);
                                assignmentStack.Pop ();
                                ((Assignment) p_TypeAssignment.parent).change (((asn_features) node).m_ObjectClassAssignment);
                            }
                        }
                        return false;
                    }
                    if (Debug)
                    {
                        Console.Error.WriteLine ($"ASSIGNMENT IS ACTUALLY TYPE ASSIGNMENT:");
                        Console.Error.WriteLine ($"\t{p_TypeAssignment.Emit (-1)}");
                        Console.Error.WriteLine ($"GOVERNOR:");
                        Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                    }
                    AsnSymbol asnSymbol = (AsnSymbol) p_TypeAssignment.m_typereference_token.m_typereference.appInfo;
                    if (asnSymbol == null)
                        break;
                    asnSymbol.Specie = AsnSymbol.SymbolSpecie.TypeSpecie;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ValueAssignment_Event (SyntaxTreeCallbackReason reason, ValueAssignment.production_kind kind, ValueAssignment p_ValueAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_ValueAssignment.appInfo != null)
                        return false;
                    p_ValueAssignment.appInfo = new ValueAssignmentInspector (p_ValueAssignment);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((ValueAssignment.__p1_markers) p_ValueAssignment.turn)
                    {
                        case ValueAssignment.__p1_markers.m1:
                            return false;   // postpone traversial of the m_Value until it
                                            // is clear what type of production is p_ValueAssignment.
                                            // If it is actually ValueAssignment then traverse it
                                            // otherwise transform it into ObjectAssignment.
                        case ValueAssignment.__p1_markers.m2:
                            return true;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector nodeInfo = null;
                    nodeInfo = (NodeInspector) p_ValueAssignment.m_Type.appInfo;
                    if (nodeInfo == null)
                    {
                        Console.Error.WriteLine ($"ERROR: UNDEFINED GOVERNING NODE FOR VALUE ASSIGNMENT:");
                        Console.Error.WriteLine ($"\t{p_ValueAssignment.Emit (-1)}");
                        break;
                    }
                    if (nodeInfo.NodeType != NodeType.TypeNode)
                    {
                        if (Debug)
                        {
                            Console.Error.WriteLine ($"ERROR: ASSIGNMENT IS NOT VALUE ASSIGNMENT:");
                            Console.Error.WriteLine ($"\t{p_ValueAssignment.Emit (-1)}");
                            Console.Error.WriteLine ($"GOVERNOR:");
                            Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                        }

                        string text = p_ValueAssignment.Emit (-1);
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT CONVERT VALUE ASSIGNMENT TO OBJECT ASSIGNMENT:");
                            Console.Error.WriteLine ($"\t{p_ValueAssignment.Emit (-1)}");
                            Console.Error.WriteLine ($"GOVERNOR:");
                            Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                            return true;
                        };
                        if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.ObjectAssignment_token }) == 0)
                        {
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                node.reparent (null);
                                ((AsnSymbol) (((asn_features) node).m_ObjectAssignment.m_objectreference_token.m_identifier_token.m_identifier.appInfo =
                                    p_ValueAssignment.m_valuereference_token.m_identifier_token.m_identifier.appInfo)).Node = ((asn_features) node).m_ObjectAssignment;
                                assignmentStack.Push (node);
                                Traverse (((asn_features) node).m_ObjectAssignment);
                                assignmentStack.Pop ();
                                ((Assignment) p_ValueAssignment.parent).change (((asn_features) node).m_ObjectAssignment);
                            }
                        }
                        return false;   // p_ValueAssignment is actually ObjectAssignment: don't traverse m_Value
                    }
                    {
                        // p_ValueAssignment is actually ValueAssignment: traverse m_Value
                        nodeInspectors.Push ((NodeInspector) p_ValueAssignment.m_Type.appInfo);
                        Traverse (p_ValueAssignment.m_Value);
                        nodeInspectors.Pop ();
                    }
                    if (Debug)
                    {
                        Console.Error.WriteLine ($"ASSIGNMENT IS ACTUALLY VALUE ASSIGNMENT:");
                        Console.Error.WriteLine ($"\t{p_ValueAssignment.Emit (-1)}");
                        Console.Error.WriteLine ($"GOVERNOR:");
                        Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                    }
                    AsnSymbol asnSymbol = (AsnSymbol) p_ValueAssignment.m_valuereference_token.m_identifier_token.m_identifier.appInfo;
                    if (asnSymbol == null)
                        break;
                    asnSymbol.Specie = AsnSymbol.SymbolSpecie.ValueSpecie;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_XMLValueAssignment_Event (SyntaxTreeCallbackReason reason, XMLValueAssignment.production_kind kind, XMLValueAssignment p_XMLValueAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_XMLValueAssignment.appInfo = new XMLValueAssignmentInspector (p_XMLValueAssignment)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_XMLValueAssignment.parent.appInfo = p_XMLValueAssignment.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ValueSetTypeAssignment_Event (SyntaxTreeCallbackReason reason, ValueSetTypeAssignment.production_kind kind, ValueSetTypeAssignment p_ValueSetTypeAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_ValueSetTypeAssignment.appInfo != null)
                        return false;
                    p_ValueSetTypeAssignment.appInfo = new ValueSetTypeAssignmentInspector (p_ValueSetTypeAssignment);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((ValueSetTypeAssignment.__p1_markers) p_ValueSetTypeAssignment.turn)
                    {
                        case ValueSetTypeAssignment.__p1_markers.m1:
                            return false;   // postpone traversial of the m_ValueSet until it
                                            // is clear what type of production is p_ValueSetTypeAssignment.
                                            // If it is actually ValueSetTypeAssignmentthen traverse it
                                            // otherwise transform it into ObjectSetAssignment.
                        case ValueSetTypeAssignment.__p1_markers.m2:
                            return true;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector nodeInfo = null;
                    nodeInfo = (NodeInspector) p_ValueSetTypeAssignment.m_Type.appInfo;
                    if (nodeInfo == null)
                    {
                        Console.Error.WriteLine ($"ERROR: UNDEFINED GOVERNING NODE FOR VALUE SET TYPE ASSIGNMENT:");
                        Console.Error.WriteLine ($"\t{p_ValueSetTypeAssignment.Emit (-1)}");
                        break;
                    }
                    if (nodeInfo.NodeType != NodeType.TypeNode)
                    {
                        if (Debug)
                        {
                            Console.Error.WriteLine ($"ERROR: ASSIGNMENT IS NOT VALUE SET TYPE ASSIGNMENT:");
                            Console.Error.WriteLine ($"\t{p_ValueSetTypeAssignment.Emit (-1)}");
                            Console.Error.WriteLine ($"GOVERNOR:");
                            Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                        }

                        string text = p_ValueSetTypeAssignment.Emit (-1);
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT CONVERT VALUE SET TYPE ASSIGNMENT TO OBJECT SET ASSIGNMENT:");
                            Console.Error.WriteLine ($"\t{p_ValueSetTypeAssignment.Emit (-1)}");
                            Console.Error.WriteLine ($"GOVERNOR:");
                            Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                            return true;
                        };
                        if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.ObjectSetAssignment_token }) == 0)
                        {
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                node.reparent (null);
                                ((AsnSymbol) (((asn_features) node).m_ObjectSetAssignment.m_objectsetreference_token.m_typereference_token.m_typereference.appInfo =
                                    p_ValueSetTypeAssignment.m_typereference_token.m_typereference.appInfo)).Node = ((asn_features) node).m_ObjectSetAssignment;
                                assignmentStack.Push (node);
                                Traverse (((asn_features) node).m_ObjectSetAssignment);
                                assignmentStack.Pop ();
                                ((Assignment) p_ValueSetTypeAssignment.parent).change (((asn_features) node).m_ObjectSetAssignment);
                            }
                        }
                        return false;   // p_ValueSetTypeAssignment is actually ObjectSetAssignment
                    }
                    {
                        // p_ValueSetTypeAssignment is actually ValueSetTypeAssignment: traverse m_ValueSet
                        nodeInspectors.Push ((NodeInspector) p_ValueSetTypeAssignment.m_Type.appInfo);
                        Traverse (p_ValueSetTypeAssignment.m_ValueSet);
                        nodeInspectors.Pop ();

                    }
                    if (Debug)
                    {
                        Console.Error.WriteLine ($"ASSIGNMENT IS ACTUALLY VALUE SET TYPE ASSIGNMENT:");
                        Console.Error.WriteLine ($"\t{p_ValueSetTypeAssignment.Emit (-1)}");
                        Console.Error.WriteLine ($"GOVERNOR:");
                        Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                    }
                    AsnSymbol asnSymbol = (AsnSymbol) p_ValueSetTypeAssignment.m_typereference_token.m_typereference.appInfo;
                    if (asnSymbol == null)
                        break;
                    asnSymbol.Specie = AsnSymbol.SymbolSpecie.ValueSetTypeSpecie;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectClassAssignment_Event (SyntaxTreeCallbackReason reason, ObjectClassAssignment.production_kind kind, ObjectClassAssignment p_ObjectClassAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_ObjectClassAssignment.appInfo != null)
                        return false;
                    p_ObjectClassAssignment.appInfo = new ObjectClassDefnInspector (p_ObjectClassAssignment.m_ObjectClass.m_ObjectClassDefn);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector nodeInfo = null;
                    nodeInfo = p_ObjectClassAssignment.m_ObjectClass.appInfo as NodeInspector;
                    if (nodeInfo == null)
                    {
                        Console.Error.WriteLine ($"ERROR: UNDEFINED GOVERNING NODE FOR CLASS ASSIGNMENT:");
                        Console.Error.WriteLine ($"\t{p_ObjectClassAssignment.Emit (-1)}");
                        break;
                    }
                    if (nodeInfo.NodeType != NodeType.ClassNode)
                    {
                        if (Debug)
                        {
                            Console.Error.WriteLine ($"ERROR: ASSIGNMENT IS NOT CLASS ASSIGNMENT:");
                            Console.Error.WriteLine ($"\t{p_ObjectClassAssignment.Emit (-1)}");
                            Console.Error.WriteLine ($"GOVERNOR:");
                            Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                        }

                        string text = p_ObjectClassAssignment.Emit (-1);
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT CONVERT CLASS ASSIGNMENT TO TYPE ASSIGNMENT:");
                            Console.Error.WriteLine ($"\t{p_ObjectClassAssignment.Emit (-1)}");
                            Console.Error.WriteLine ($"GOVERNOR:");
                            Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                            return true;
                        };
                        if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.TypeAssignment_token }) == 0)
                        {
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                node.reparent (null);
                                ((AsnSymbol) (((asn_features) node).m_TypeAssignment.m_typereference_token.m_typereference.appInfo =
                                    p_ObjectClassAssignment.m_objectclassreference_token.m_typereference_token.m_typereference.appInfo)).Node = ((asn_features) node).m_TypeAssignment;
                                assignmentStack.Push (node);
                                Traverse (((asn_features) node).m_TypeAssignment);
                                assignmentStack.Pop ();
                                ((Assignment) p_ObjectClassAssignment.parent).change (((asn_features) node).m_TypeAssignment);
                            }
                        }
                        return false;
                    }
                    if (Debug)
                    {
                        Console.Error.WriteLine ($"ASSIGNMENT IS ACTUALLY CLASS ASSIGNMENT:");
                        Console.Error.WriteLine ($"\t{p_ObjectClassAssignment.Emit (-1)}");
                        Console.Error.WriteLine ($"GOVERNOR:");
                        Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                    }
                    AsnSymbol asnSymbol = (AsnSymbol) p_ObjectClassAssignment.m_objectclassreference_token.m_typereference_token.m_typereference.appInfo;
                    if (asnSymbol == null)
                        break;
                    asnSymbol.Specie = AsnSymbol.SymbolSpecie.ObjectClassSpecie;
                    switch ((ObjectClass.production_kind) p_ObjectClassAssignment.m_ObjectClass.kind)
                    {
                        case ObjectClass.production_kind.g_ObjectClass_1:
                            p_ObjectClassAssignment.appInfo = ((NodeInspector) p_ObjectClassAssignment.appInfo).actualNodeInspector;
                            break;
                        case ObjectClass.production_kind.g_ObjectClass_2:
                            break;
                        case ObjectClass.production_kind.g_ObjectClass_3:
                            break;
                    }
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectAssignment_Event (SyntaxTreeCallbackReason reason, ObjectAssignment.production_kind kind, ObjectAssignment p_ObjectAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_ObjectAssignment.appInfo != null)
                        return false;
                    p_ObjectAssignment.appInfo = new ObjectAssignmentInspector (p_ObjectAssignment);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((ObjectAssignment.__object_markers) p_ObjectAssignment.turn)
                    {
                        case ObjectAssignment.__object_markers.push_governor:
                            return false;   // postpone traversial of the m_Object until it
                                            // is clear what type of production is p_ObjectAssignment.
                                            // If it is actually ObjectAssignment then traverse it
                                            // otherwise transform it into ValueAssignment.
                        case ObjectAssignment.__object_markers.pop_governor:
                            return true;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector nodeInfo = null;
                    nodeInfo = (NodeInspector) p_ObjectAssignment.m_DefinedObjectClass.appInfo;
                    if (nodeInfo == null)
                    {
                        Console.Error.WriteLine ($"ERROR: UNDEFINED GOVERNING NODE FOR OBJECT ASSIGNMENT:");
                        Console.Error.WriteLine ($"\t{p_ObjectAssignment.Emit (-1)}");
                        break;
                    }
                    if (nodeInfo.NodeType != NodeType.ClassNode)
                    {
                        if (Debug)
                        {
                            Console.Error.WriteLine ($"ERROR: ASSIGNMENT IS NOT OBJECT ASSIGNMENT:");
                            Console.Error.WriteLine ($"\t{p_ObjectAssignment.Emit (-1)}");
                            Console.Error.WriteLine ($"GOVERNOR:");
                            Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                        }

                        string text = p_ObjectAssignment.Emit (-1);
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT CONVERT OBJECT ASSIGNMENT TO VALUE ASSIGNMENT:");
                            Console.Error.WriteLine ($"\t{p_ObjectAssignment.Emit (-1)}");
                            Console.Error.WriteLine ($"GOVERNOR:");
                            Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                            return true;
                        };
                        if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.ValueAssignment_token }) == 0)
                        {
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                node.reparent (null);
                                ((AsnSymbol) (((asn_features) node).m_ValueAssignment.m_valuereference_token.m_identifier_token.m_identifier.appInfo =
                                    p_ObjectAssignment.m_objectreference_token.m_identifier_token.m_identifier.appInfo)).Node = ((asn_features) node).m_ValueAssignment;
                                assignmentStack.Push (node);
                                Traverse (((asn_features) node).m_ValueAssignment);
                                assignmentStack.Pop ();
                                ((Assignment) p_ObjectAssignment.parent).change (((asn_features) node).m_ValueAssignment);
                            }
                        }
                        return false;   // p_ObjectAssignment is actually ValueAssignment
                    }
                    {
                        // p_ObjectAssignment is actually ObjectAssignment: traverse m_Object
                        contextStack.Push ((AsnSymbol) p_ObjectAssignment.m_objectreference_token.m_identifier_token.m_identifier.appInfo);
                        nodeInspectors.Push ((NodeInspector) p_ObjectAssignment.appInfo);
                        Traverse (p_ObjectAssignment.m_Object);
                        nodeInspectors.Pop ();
                        contextStack.Pop ();
                    }
                    if (Debug)
                    {
                        Console.Error.WriteLine ($"ASSIGNMENT IS ACTUALLY OBJECT ASSIGNMENT:");
                        Console.Error.WriteLine ($"\t{p_ObjectAssignment.Emit (-1)}");
                        Console.Error.WriteLine ($"GOVERNOR:");
                        Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                    }
                    AsnSymbol asnSymbol = (AsnSymbol) p_ObjectAssignment.m_objectreference_token.m_identifier_token.m_identifier.appInfo;
                    if (asnSymbol == null)
                        break;
                    asnSymbol.Specie = AsnSymbol.SymbolSpecie.ObjectSpecie;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectSetAssignment_Event (SyntaxTreeCallbackReason reason, ObjectSetAssignment.production_kind kind, ObjectSetAssignment p_ObjectSetAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_ObjectSetAssignment.appInfo != null)
                        return false;
                    p_ObjectSetAssignment.appInfo = new ObjectSetAssignmentInspector (p_ObjectSetAssignment);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((ObjectSetAssignment.__object_set_markers) p_ObjectSetAssignment.turn)
                    {
                        case ObjectSetAssignment.__object_set_markers.push_governor:
                            return false;   // postpone traversial of the m_ObjectSet until it
                                            // is clear what type of production is p_ObjectSetAssignment.
                                            // If it is actually ObjectSetAssignment then traverse it
                                            // otherwise transform it into ValueSetTypeAssignment.
                        case ObjectSetAssignment.__object_set_markers.pop_governor:
                            return true;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector nodeInfo = null;
                    nodeInfo = (NodeInspector) p_ObjectSetAssignment.m_DefinedObjectClass.appInfo;
                    if (nodeInfo == null)
                    {
                        Console.Error.WriteLine ($"ERROR: UNDEFINED GOVERNING NODE FOR OBJECT SET ASSIGNMENT:");
                        Console.Error.WriteLine ($"\t{p_ObjectSetAssignment.Emit (-1)}");
                        break;
                    }
                    if (nodeInfo.NodeType != NodeType.ClassNode)
                    {
                        if (Debug)
                        {
                            Console.Error.WriteLine ($"ERROR: ASSIGNMENT IS NOT OBJECT SET ASSIGNMENT:");
                            Console.Error.WriteLine ($"\t{p_ObjectSetAssignment.Emit (-1)}");
                            Console.Error.WriteLine ($"GOVERNOR:");
                            Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                        }

                        string text = p_ObjectSetAssignment.Emit (-1);
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT CONVERT OBJECT SET ASSIGNMENT TO VALUE SET TYPE ASSIGNMENT:");
                            Console.Error.WriteLine ($"\t{p_ObjectSetAssignment.Emit (-1)}");
                            Console.Error.WriteLine ($"GOVERNOR:");
                            Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                            return true;
                        };
                        if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.ValueSetTypeAssignment_token }) == 0)
                        {
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                node.reparent (null);
                                ((AsnSymbol) (((asn_features) node).m_ValueSetTypeAssignment.m_typereference_token.m_typereference.appInfo =
                                    p_ObjectSetAssignment.m_objectsetreference_token.m_typereference_token.m_typereference.appInfo)).Node = ((asn_features) node).m_ValueSetTypeAssignment;
                                assignmentStack.Push (node);
                                Traverse (((asn_features) node).m_ValueSetTypeAssignment);
                                assignmentStack.Pop ();
                                ((Assignment) p_ObjectSetAssignment.parent).change (((asn_features) node).m_ValueSetTypeAssignment);
                            }
                        }
                        return false;   // p_ObjectSetAssignment is actually ValueSetTypeAssignment
                    }
                    {
                        // p_ObjectSetAssignment is actually ObjectSetAssignment: traverse m_ObjectSet
                        nodeInspectors.Push ((NodeInspector) p_ObjectSetAssignment.appInfo);
                        Traverse (p_ObjectSetAssignment.m_ObjectSet);
                        nodeInspectors.Pop ();
                    }
                    if (Debug)
                    {
                        Console.Error.WriteLine ($"ASSIGNMENT IS ACTUALLY OBJECT SET ASSIGNMENT:");
                        Console.Error.WriteLine ($"\t{p_ObjectSetAssignment.Emit (-1)}");
                        Console.Error.WriteLine ($"GOVERNOR:");
                        Console.Error.WriteLine ($"\t{nodeInfo.Node.Emit (-1)}");
                    }
                    AsnSymbol asnSymbol = (AsnSymbol) p_ObjectSetAssignment.m_objectsetreference_token.m_typereference_token.m_typereference.appInfo;
                    if (asnSymbol == null)
                        break;
                    asnSymbol.Specie = AsnSymbol.SymbolSpecie.ObjectSetSpecie;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ParameterizedAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedAssignment.production_kind kind, ParameterizedAssignment p_ParameterizedAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    //p_ParameterizedAssignment.appInfo = new ParameterizedAssignmentInspector (p_ParameterizedAssignment);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    if ((p_ParameterizedAssignment.parent.appInfo = p_ParameterizedAssignment.appInfo) != null)
                        Console.Error.WriteLine ($"ERROR: NOT NULL CLASS GOVERNOR: {p_ParameterizedAssignment.Emit (-1)}");
                    break;
            }
            return false;
        }

        private bool AsnNodeInspector_MacroAssignment_Event (SyntaxTreeCallbackReason reason, MacroAssignment.production_kind kind, MacroAssignment p_MacroAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    p_MacroAssignment.appInfo = new MacroAssignmentInspector (p_MacroAssignment);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_MacroDefinition_Event (SyntaxTreeCallbackReason reason, MacroDefinition.production_kind kind, MacroDefinition p_MacroDefinition)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    p_MacroDefinition.appInfo = new MacroDefinitionInspector (p_MacroDefinition);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ValueSet_Event (SyntaxTreeCallbackReason reason, ValueSet.production_kind kind, ValueSet p_ValueSet)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    try
                    {
                        NodeInspector nodeInspector = nodeInspectors.Peek ();
                        nodeInspector.Inspect (p_ValueSet, this);
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine ($"ERROR: {e.Message}");
                    }
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_Type_Event (SyntaxTreeCallbackReason reason, Asn.Parser.Type.production_kind kind, Asn.Parser.Type p_Type)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    if (p_Type.appInfo != null)
                        return false;
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    if (p_Type.appInfo != null)
                        break;
                    Console.Error.WriteLine ($"ERROR: UNKNOWN NODE INSPECTOR FOR TYPE: {p_Type.Emit (-1)}");
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_BuiltinType_Event (SyntaxTreeCallbackReason reason, BuiltinType.production_kind kind, BuiltinType p_BuiltinType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_BuiltinType.parent.appInfo = p_BuiltinType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ReferencedType_Event (SyntaxTreeCallbackReason reason, ReferencedType.production_kind kind, ReferencedType p_ReferencedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_ReferencedType.parent.appInfo = p_ReferencedType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ConstrainedType_Event (SyntaxTreeCallbackReason reason, ConstrainedType.production_kind kind, ConstrainedType p_ConstrainedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    if (kind != ConstrainedType.production_kind.g_ConstrainedType_1)
                        break;
                    nodeInspectors.Push ((NodeInspector) (p_ConstrainedType.appInfo = new ConstrainedTypeInspector (p_ConstrainedType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    if ((ConstrainedType.production_kind) kind != ConstrainedType.production_kind.g_ConstrainedType_1)
                        break;
                    switch ((ConstrainedType.__p1_markers) p_ConstrainedType.turn)
                    {
                        case ConstrainedType.__p1_markers.m1:
                            nodeInspectors.Push ((NodeInspector) p_ConstrainedType.m_Type.appInfo);
                            break;
                        case ConstrainedType.__p1_markers.m2:
                            nodeInspectors.Pop ();
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_ConstrainedType.parent.appInfo = p_ConstrainedType.appInfo;
                    if (kind != ConstrainedType.production_kind.g_ConstrainedType_1)
                        break;
                    nodeInspectors.Pop ();
                    switch (kind)
                    {
                        case ConstrainedType.production_kind.g_ConstrainedType_1:
                            p_ConstrainedType.appInfo = p_ConstrainedType.m_Type.appInfo;
                            break;
                        case ConstrainedType.production_kind.g_ConstrainedType_2:
                            p_ConstrainedType.appInfo = p_ConstrainedType.m_TypeWithConstraint.appInfo;
                            break;
                    }
                    p_ConstrainedType.parent.appInfo = p_ConstrainedType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_TypeWithConstraint_Event (SyntaxTreeCallbackReason reason, TypeWithConstraint.production_kind kind, TypeWithConstraint p_TypeWithConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    switch (kind)
                    {
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_1:
                            nodeInspectors.Push ((NodeInspector) (p_TypeWithConstraint.appInfo = new SetConstraintOfTypeInspector (p_TypeWithConstraint)));
                            break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_2:
                            nodeInspectors.Push ((NodeInspector) (p_TypeWithConstraint.appInfo = new SetSizeConstraintOfTypeInspector (p_TypeWithConstraint)));
                            break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_3:
                            nodeInspectors.Push ((NodeInspector) (p_TypeWithConstraint.appInfo = new SequenceConstraintOfTypeInspector (p_TypeWithConstraint)));
                            break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_4:
                            nodeInspectors.Push ((NodeInspector) (p_TypeWithConstraint.appInfo = new SequenceSizeConstraintOfTypeInspector (p_TypeWithConstraint)));
                            break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_5:
                            nodeInspectors.Push ((NodeInspector) (p_TypeWithConstraint.appInfo = new SetConstraintOfNamedTypeInspector (p_TypeWithConstraint)));
                            break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_6:
                            nodeInspectors.Push ((NodeInspector) (p_TypeWithConstraint.appInfo = new SetSizeConstraintOfNamedTypeInspector (p_TypeWithConstraint)));
                            break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_7:
                            nodeInspectors.Push ((NodeInspector) (p_TypeWithConstraint.appInfo = new SequenceConstraintOfNamedTypeInspector (p_TypeWithConstraint)));
                            break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_8:
                            nodeInspectors.Push ((NodeInspector) (p_TypeWithConstraint.appInfo = new SequenceSizeConstraintOfNamedTypeInspector (p_TypeWithConstraint)));
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_TypeWithConstraint.parent.appInfo = p_TypeWithConstraint.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_Constraint_Event (SyntaxTreeCallbackReason reason, Asn.Parser.Constraint.production_kind kind, Asn.Parser.Constraint p_Constraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    //nodeInspectors.Push ((NodeInspector) (p_Constraint.appInfo = new ConstraintInspector (p_Constraint)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    //ConstraintInspector inspector = nodeInspectors.Pop () as ConstraintInspector;
                    //inspector.ConstraintSpec = (NodeInspector) p_Constraint.m_ConstraintSpec.appInfo;
                    //inspector.ExceptionSpec = (NodeInspector) p_Constraint.m_ExceptionSpec.appInfo;
                    //inspector.ConstraintSpec?.Inspect (p_Constraint.m_ConstraintSpec, this);
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ConstraintSpec_Event (SyntaxTreeCallbackReason reason, ConstraintSpec.production_kind kind, ConstraintSpec p_ConstraintSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SubtypeConstraint_Event (SyntaxTreeCallbackReason reason, SubtypeConstraint.production_kind kind, SubtypeConstraint p_SubtypeConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_SubtypeConstraint.parent.appInfo = p_SubtypeConstraint.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ElementSetSpecs_Event (SyntaxTreeCallbackReason reason, ElementSetSpecs.production_kind kind, ElementSetSpecs p_ElementSetSpecs)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    objSetConstraintStack.Push ((p_ElementSetSpecs.appInfo = new ElementSetSpecsInspector (p_ElementSetSpecs)) as ElementSetInspector);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    ElementSetInspector inspector = objSetConstraintStack.Pop ();
                    inspector.Inspect (p_ElementSetSpecs, this);
                    p_ElementSetSpecs.parent.appInfo = p_ElementSetSpecs.appInfo;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_Elements_Event (SyntaxTreeCallbackReason reason, Elements.production_kind kind, Elements p_Elements)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (objSetConstraintStack.Peek () is ElementSetSpecsInspector)
                    {
                        if (kind == Elements.production_kind.g_Elements_2)
                        {
                            string text = p_Elements.Emit (-1);
                            AsnCompiler asnCompiler = new AsnCompiler ();
                            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                            {
                                Console.Error.WriteLine ($"ERROR: CANNOT PARSE SUBTYPE ELEMENT:");
                                Console.Error.WriteLine ($"\t{text}");
                                return true;
                            };
                            if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.SubtypeElements_token }) == 0)
                            {
                                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                                {
                                    node.reparent (null);
                                    p_Elements.change (((asn_features) node).m_SubtypeElements);
                                    Traverse (p_Elements.m_SubtypeElements);
                                }
                            }
                            return false;
                        }
                    }
                    else if (objSetConstraintStack.Peek () is ObjectSetSpecInspector)
                    {
                        if (kind == Elements.production_kind.g_Elements_1)
                        {
                            string text = p_Elements.Emit (-1);
                            AsnCompiler asnCompiler = new AsnCompiler ();
                            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                            {
                                Console.Error.WriteLine ($"ERROR: CANNOT PARSE SUBTYPE ELEMENT:");
                                Console.Error.WriteLine ($"\t{text}");
                                return true;
                            };
                            if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.ObjectSetElements_token }) == 0)
                            {
                                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                                {
                                    node.reparent (null);
                                    p_Elements.change (((asn_features) node).m_ObjectSetElements);
                                    Traverse (p_Elements.m_ObjectSetElements);
                                }
                            }
                            return false;
                        }
                    }
                    else
                        ;
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    ElementSetInspector inspector = objSetConstraintStack.Peek ();
                    inspector.elements.Add (p_Elements);
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_SubtypeElements_Event (SyntaxTreeCallbackReason reason, SubtypeElements.production_kind kind, SubtypeElements p_SubtypeElements)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ValueRange_Event (SyntaxTreeCallbackReason reason, ValueRange.production_kind kind, ValueRange p_ValueRange)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_ValueRange.appInfo = new ValueRangeInspector (p_ValueRange)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_ValueRange.parent.appInfo = p_ValueRange.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_UpperEndValue_Event (SyntaxTreeCallbackReason reason, UpperEndValue.production_kind kind, UpperEndValue p_UpperEndValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push (integerTypeInspector);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_LowerEndValue_Event (SyntaxTreeCallbackReason reason, LowerEndValue.production_kind kind, LowerEndValue p_LowerEndValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push (integerTypeInspector);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SingleValue_Event (SyntaxTreeCallbackReason reason, SingleValue.production_kind kind, SingleValue p_SingleValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    p_SingleValue.appInfo = new SingleValueInspector (p_SingleValue);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_SingleValue.parent.appInfo = p_SingleValue.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ContainedSubtype_Event (SyntaxTreeCallbackReason reason, ContainedSubtype.production_kind kind, ContainedSubtype p_ContainedSubtype)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    p_ContainedSubtype.appInfo = new ContainedSubtypeInspector (p_ContainedSubtype);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_ContainedSubtype.parent.appInfo = p_ContainedSubtype.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SEValueRange_Event (SyntaxTreeCallbackReason reason, SEValueRange.production_kind kind, SEValueRange p_SEValueRange)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_SEValueRange.parent.appInfo = p_SEValueRange.appInfo = p_SEValueRange.m_ValueRange.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_PermittedAlphabet_Event (SyntaxTreeCallbackReason reason, PermittedAlphabet.production_kind kind, PermittedAlphabet p_PermittedAlphabet)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    p_PermittedAlphabet.appInfo = new PermittedAlphabetInspector (p_PermittedAlphabet);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_PermittedAlphabet.parent.appInfo = p_PermittedAlphabet.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SESizeConstraint_Event (SyntaxTreeCallbackReason reason, SESizeConstraint.production_kind kind, SESizeConstraint p_SESizeConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_SESizeConstraint.parent.appInfo = p_SESizeConstraint.appInfo = p_SESizeConstraint.m_SizeConstraint.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_TypeConstraint_Event (SyntaxTreeCallbackReason reason, TypeConstraint.production_kind kind, TypeConstraint p_TypeConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    p_TypeConstraint.appInfo = new TypeConstraintInspector (p_TypeConstraint);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_TypeConstraint.parent.appInfo = p_TypeConstraint.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_InnerTypeConstraints_Event (SyntaxTreeCallbackReason reason, InnerTypeConstraints.production_kind kind, InnerTypeConstraints p_InnerTypeConstraints)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    p_InnerTypeConstraints.appInfo = new InnerTypeConstraintsInspector (p_InnerTypeConstraints);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_InnerTypeConstraints.parent.appInfo = p_InnerTypeConstraints.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_PatternConstraint_Event (SyntaxTreeCallbackReason reason, PatternConstraint.production_kind kind, PatternConstraint p_PatternConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    p_PatternConstraint.parent.appInfo = new PatternConstraintInspector (p_PatternConstraint);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_PatternConstraint.parent.appInfo = p_PatternConstraint.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_PropertySettings_Event (SyntaxTreeCallbackReason reason, PropertySettings.production_kind kind, PropertySettings p_PropertySettings)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    p_PropertySettings.appInfo = new PropertySettingsInspector (p_PropertySettings);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_PropertySettings.parent.appInfo = p_PropertySettings.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_DurationRange_Event (SyntaxTreeCallbackReason reason, DurationRange.production_kind kind, DurationRange p_DurationRange)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    p_DurationRange.appInfo = new DurationRangeInspector (p_DurationRange);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_DurationRange.parent.appInfo = p_DurationRange.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_TimePointRange_Event (SyntaxTreeCallbackReason reason, TimePointRange.production_kind kind, TimePointRange p_TimePointRange)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    p_TimePointRange.appInfo = new TimePointRangeInspector (p_TimePointRange);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_TimePointRange.parent.appInfo = p_TimePointRange.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_RecurrenceRange_Event (SyntaxTreeCallbackReason reason, RecurrenceRange.production_kind kind, RecurrenceRange p_RecurrenceRange)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    p_RecurrenceRange.appInfo = new RecurrenceRangeInspector (p_RecurrenceRange);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_RecurrenceRange.parent.appInfo = p_RecurrenceRange.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_UserDefinedConstraint_Event (SyntaxTreeCallbackReason reason, UserDefinedConstraint.production_kind kind, UserDefinedConstraint p_UserDefinedConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_UserDefinedConstraint.appInfo = new UserDefinedConstraintInspector (p_UserDefinedConstraint)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_UserDefinedConstraint.parent.appInfo = p_UserDefinedConstraint.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_UserDefinedConstraintParameter_Event (SyntaxTreeCallbackReason reason, UserDefinedConstraintParameter.production_kind kind, UserDefinedConstraintParameter p_UserDefinedConstraintParameter)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    switch (kind)
                    {
                        case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_1:
                            break;
                        case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_2:
                            break;
                        case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_3:
                            break;
                        case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_4:
                            break;
                        case UserDefinedConstraintParameter.production_kind.g_UserDefinedConstraintParameter_5:
                            break;
                    }

                    UserDefinedConstraintInspector inspector = nodeInspectors.Peek () as UserDefinedConstraintInspector;
                    if (inspector == null)
                        break;
                    inspector.parameters.Add (p_UserDefinedConstraintParameter);
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_TableConstraint_Event (SyntaxTreeCallbackReason reason, TableConstraint.production_kind kind, TableConstraint p_TableConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    if (tableConstraintLink == null)
                    {
                        Console.Error.WriteLine ($"ERROR: Table constraint should be used only inside ASN.1 structured type (Sequence, Choice, Set).");
                        Console.Error.WriteLine ($"\tCONSTRAINT: {p_TableConstraint.Emit(-1)}");
                        break;
                    }
                    SyntaxTreeBase node;
                    for (node=p_TableConstraint; (node != null) && (node != tableConstraintLink.Node); node = node.parent)
                        ;
                    if (node == null)
                    {
                        Console.Error.WriteLine ($"ERROR: Table constraint should be used only inside ASN.1 structured type (Sequence, Choice, Set).");
                        Console.Error.WriteLine ($"\tCONSTRAINT: {p_TableConstraint.Emit (-1)}");
                        break;
                    }
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ContentsConstraint_Event (SyntaxTreeCallbackReason reason, ContentsConstraint.production_kind kind, ContentsConstraint p_ContentsConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_AnyType_Event (SyntaxTreeCallbackReason reason, AnyType.production_kind kind, AnyType p_AnyType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_AnyType.appInfo = new AnyTypeInspector (p_AnyType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_AnyType.parent.appInfo = p_AnyType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_BitStringType_Event (SyntaxTreeCallbackReason reason, BitStringType.production_kind kind, BitStringType p_BitStringType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_BitStringType.appInfo = new BitStringTypeInspector (p_BitStringType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_BitStringType.parent.appInfo = p_BitStringType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_NamedBit_Event (SyntaxTreeCallbackReason reason, NamedBit.production_kind kind, NamedBit p_NamedBit)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    string namedBit = p_NamedBit.m_identifier_token.m_identifier.text;
                    AsnSymbol symbol = new AsnSymbol (namedBit, contextStack.Peek (), p_NamedBit);
                    AsnSymbol symbolRef = symbolTable.find (symbol);
                    if (symbolRef != null)
                        Console.Error.WriteLine ($"ERROR: REDEFINED NAMED BIT ITEM {namedBit}");
                    else
                    {
                        symbolRef = symbol;
                        symbolRef.Specie = AsnSymbol.SymbolSpecie.NamedBitSpecie;
                        symbolTable.add (symbolRef);
                        BitStringTypeInspector bitStringTypeInspector = (BitStringTypeInspector) nodeInspectors.Peek ();
                        bitStringTypeInspector.namedBits [namedBit] = p_NamedBit;
                        p_NamedBit.m_identifier_token.appInfo = symbolRef;
                    }
                    if (kind != NamedBit.production_kind.g_NamedBit_2)
                        break;
                    DefinedValue definedValue = p_NamedBit.m_DefinedValue;
                    DefinedValueInspector inspector = definedValue.appInfo as DefinedValueInspector;
                    if (inspector == null)
                        break;
                    inspector.Inspect (p_NamedBit, this);
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_BooleanType_Event (SyntaxTreeCallbackReason reason, BooleanType.production_kind kind, BooleanType p_BooleanType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_BooleanType.appInfo = new BooleanTypeInspector (p_BooleanType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_BooleanType.parent.appInfo = p_BooleanType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_CharacterStringType_Event (SyntaxTreeCallbackReason reason, CharacterStringType.production_kind kind, CharacterStringType p_CharacterStringType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_CharacterStringType.appInfo = new CharacterStringTypeInspector (p_CharacterStringType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_CharacterStringType.parent.appInfo = p_CharacterStringType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_NamedType_Event (SyntaxTreeCallbackReason reason, NamedType.production_kind kind, NamedType p_NamedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_NamedType.appInfo = p_NamedType.m_Type.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_TypeOrNamedType_Event (SyntaxTreeCallbackReason reason, TypeOrNamedType.production_kind kind, TypeOrNamedType p_TypeOrNamedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    ComponentCounterInspector inspector = nodeInspectors.Peek () as ComponentCounterInspector;
                    if (inspector == null)
                        break;
                    string componentName = "";
                    switch (kind)
                    {
                        case TypeOrNamedType.production_kind.g_TypeOrNamedType_1:
                            componentName = $"$$component_{inspector.ComponentCount + 1}";
                            break;
                        case TypeOrNamedType.production_kind.g_TypeOrNamedType_2:
                            componentName = p_TypeOrNamedType.m_NamedType.m_identifier_token.m_identifier.text;
                            break;
                    }
                    AsnSymbol symbol = new AsnSymbol (componentName, contextStack.Peek (), p_TypeOrNamedType);
                    AsnSymbol symbolRef = symbolTable.find (symbol);
                    if (symbolRef == null)
                        symbolTable.add (symbolRef = symbol);
                    else
                        symbolTable.add (symbolRef);
                    symbolRef.Specie = AsnSymbol.SymbolSpecie.ComponentSpecie;
                    contextStack.Push (symbolRef);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    switch (kind)
                    {
                        case TypeOrNamedType.production_kind.g_TypeOrNamedType_1:
                            p_TypeOrNamedType.appInfo = p_TypeOrNamedType.m_Type.appInfo;
                            break;
                        case TypeOrNamedType.production_kind.g_TypeOrNamedType_2:
                            p_TypeOrNamedType.appInfo = p_TypeOrNamedType.m_NamedType.appInfo;
                            break;
                    }
                    ComponentCounterInspector inspector = nodeInspectors.Peek () as ComponentCounterInspector;
                    if (inspector == null)
                        break;
                    contextStack.Pop ();
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_AltTypeOrNamedType_Event (SyntaxTreeCallbackReason reason, AltTypeOrNamedType.production_kind kind, AltTypeOrNamedType p_AltTypeOrNamedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    AlternativeTypeListInspector alternativeTypeListInspector = nodeInspectors.Peek () as AlternativeTypeListInspector;
                    AlternativeTypesDictionary alternativeTypes = alternativeTypeListInspector.AlternativeTypes;
                    NamedType namedType = p_AltTypeOrNamedType.m_TypeOrNamedType.m_NamedType;
                    if (namedType != null)
                    {
                        string name = namedType.m_identifier_token.m_identifier.text;
                        if (alternativeTypes.TryGetValue (name, out _))
                            Console.Error.WriteLine ($"ERROR: component {name} is already present");
                        else
                            alternativeTypes [name] = p_AltTypeOrNamedType.m_TypeOrNamedType;
                    }
                    alternativeTypeListInspector.EnumeratedAlternativeTypes [alternativeTypeListInspector.ComponentCounter] = p_AltTypeOrNamedType.m_TypeOrNamedType;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ChoiceType_Event (SyntaxTreeCallbackReason reason, ChoiceType.production_kind kind, ChoiceType p_ChoiceType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_ChoiceType.appInfo = tableConstraintLink = new ChoiceTypeInspector (p_ChoiceType, tableConstraintLink)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    tableConstraintLink = nodeInspectors.Pop ().tableConstraintLink;
                    (p_ChoiceType.appInfo as ComponentCounterInspector).ComputeLevel ();
                    if ((p_ChoiceType.appInfo as ComponentCounterInspector).level > 0)
                        Console.WriteLine ($"INNERMOST: {p_ChoiceType.Emit (-1)}");
                    else
                    {
                        Console.WriteLine ($"OUTERMOST: {p_ChoiceType.Emit (-1)}");
                        AsnTableConstraintResolver tableConstraintResolver = new AsnTableConstraintResolver ();
                        tableConstraintResolver.Invoke (p_ChoiceType);
                    }
                    p_ChoiceType.parent.appInfo = p_ChoiceType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_DateType_Event (SyntaxTreeCallbackReason reason, DateType.production_kind kind, DateType p_DateType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_DateType.appInfo = new DateTypeInspector (p_DateType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_DateType.parent.appInfo = p_DateType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_DateTimeType_Event (SyntaxTreeCallbackReason reason, DateTimeType.production_kind kind, DateTimeType p_DateTimeType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_DateTimeType.appInfo = new DateTimeTypeInspector (p_DateTimeType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_DateTimeType.parent.appInfo = p_DateTimeType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_DurationType_Event (SyntaxTreeCallbackReason reason, DurationType.production_kind kind, DurationType p_DurationType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_DurationType.appInfo = new DurationTypeInspector (p_DurationType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_DurationType.parent.appInfo = p_DurationType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_EmbeddedPDVType_Event (SyntaxTreeCallbackReason reason, EmbeddedPDVType.production_kind kind, EmbeddedPDVType p_EmbeddedPDVType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (embeddedPDVTypeInspector != null)
                        nodeInspectors.Push ((NodeInspector) (p_EmbeddedPDVType.appInfo = embeddedPDVTypeInspector));
                    else
                        nodeInspectors.Push ((NodeInspector) (p_EmbeddedPDVType.appInfo = new EmbeddedPDVTypeInspector (p_EmbeddedPDVType)));
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_EmbeddedPDVType.parent.appInfo = p_EmbeddedPDVType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_EnumeratedType_Event (SyntaxTreeCallbackReason reason, EnumeratedType.production_kind kind, EnumeratedType p_EnumeratedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_EnumeratedType.appInfo = new EnumeratedTypeInspector (p_EnumeratedType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_EnumeratedType.parent.appInfo = p_EnumeratedType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_EnumerationItem_Event (SyntaxTreeCallbackReason reason, EnumerationItem.production_kind kind, EnumerationItem p_EnumerationItem)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    string enumItem = "";
                    switch ((EnumerationItem.production_kind) p_EnumerationItem.kind)
                    {
                        case EnumerationItem.production_kind.g_EnumerationItem_1:
                            enumItem = p_EnumerationItem.m_identifier_token.m_identifier.text;
                            break;
                        case EnumerationItem.production_kind.g_EnumerationItem_2:
                            enumItem = p_EnumerationItem.m_NamedNumber.m_identifier_token.m_identifier.text;
                            break;
                    }
                    AsnSymbol symbol = new AsnSymbol (enumItem, contextStack.Peek (), p_EnumerationItem);
                    AsnSymbol symbolRef = symbolTable.find (symbol);
                    if (symbolRef != null)
                        Console.Error.WriteLine ($"ERROR: REDEFINED ENUMERATION ITEM {enumItem}");
                    else
                    {
                        symbolRef = symbol;
                        symbolRef.Specie = AsnSymbol.SymbolSpecie.EnumerationItemSpecie;
                        symbolTable.add (symbolRef);
                        EnumeratedTypeInspector enumeratedTypeInspector = (EnumeratedTypeInspector) nodeInspectors.Peek ();
                        enumeratedTypeInspector.enumerationItems [enumItem] = p_EnumerationItem;
                    }
                    switch ((EnumerationItem.production_kind) p_EnumerationItem.kind)
                    {
                        case EnumerationItem.production_kind.g_EnumerationItem_1:
                            p_EnumerationItem.m_identifier_token.appInfo = symbolRef;
                            break;
                        case EnumerationItem.production_kind.g_EnumerationItem_2:
                            p_EnumerationItem.m_NamedNumber.m_identifier_token.appInfo = symbolRef;
                            break;
                    }
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ExternalType_Event (SyntaxTreeCallbackReason reason, ExternalType.production_kind kind, ExternalType p_ExternalType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    if (externalTypeInspector != null)
                        nodeInspectors.Push ((NodeInspector) (p_ExternalType.appInfo = externalTypeInspector));
                    else
                        nodeInspectors.Push ((NodeInspector) (p_ExternalType.appInfo = new ExternalTypeInspector (p_ExternalType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_ExternalType.parent.appInfo = p_ExternalType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_InstanceOfType_Event (SyntaxTreeCallbackReason reason, InstanceOfType.production_kind kind, InstanceOfType p_InstanceOfType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_InstanceOfType.appInfo = new InstanceOfTypeInspector (p_InstanceOfType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector nodeInspector = nodeInspectors.Peek ();
                    nodeInspector.actualNodeInspector = (NodeInspector) p_InstanceOfType.appInfo;
                    nodeInspectors.Pop ();
                    p_InstanceOfType.parent.appInfo = nodeInspector;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_IntegerType_Event (SyntaxTreeCallbackReason reason, IntegerType.production_kind kind, IntegerType p_IntegerType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_IntegerType.appInfo = new IntegerTypeInspector (p_IntegerType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_IntegerType.parent.appInfo = p_IntegerType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_NamedNumberItem_Event (SyntaxTreeCallbackReason reason, NamedNumberItem.production_kind kind, NamedNumberItem p_NamedNumberItem)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    string itemText = p_NamedNumberItem.m_identifier_token.m_identifier.text;
                    AsnSymbol symbol = new AsnSymbol (itemText, contextStack.Peek (), p_NamedNumberItem);
                    AsnSymbol symbolRef = symbolTable.find (symbol);
                    if (symbolRef != null)
                        Console.Error.WriteLine ($"ERROR: REDEFINED NAMED NUMBER ITEM {itemText}");
                    else
                    {
                        symbolRef = symbol;
                        symbolRef.Specie = AsnSymbol.SymbolSpecie.NamedNumberItemSpecie;
                        symbolTable.add (symbolRef);
                        IntegerTypeInspector integerTypeInspector = (IntegerTypeInspector) nodeInspectors.Peek ();
                        integerTypeInspector.namedNumberItems [itemText] = p_NamedNumberItem;
                    }
                    p_NamedNumberItem.m_identifier_token.appInfo = symbolRef;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_IRIType_Event (SyntaxTreeCallbackReason reason, IRIType.production_kind kind, IRIType p_IRIType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_IRIType.appInfo = new IRITypeInspector (p_IRIType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_IRIType.parent.appInfo = p_IRIType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_NullType_Event (SyntaxTreeCallbackReason reason, NullType.production_kind kind, NullType p_NullType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_NullType.appInfo = new NullTypeInspector (p_NullType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_NullType.parent.appInfo = p_NullType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectClassFieldType_Event (SyntaxTreeCallbackReason reason, ObjectClassFieldType.production_kind kind, ObjectClassFieldType p_ObjectClassFieldType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    if (p_ObjectClassFieldType.appInfo != null)
                        return false;
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((ObjectClassFieldType.__p1_markers) p_ObjectClassFieldType.turn)
                    {
                        case ObjectClassFieldType.__p1_markers.m1:
                        {
                            DefinedObjectClass definedObjectClass = p_ObjectClassFieldType.m_DefinedObjectClass;
                            DefinedObjectClassInspector inspector = (DefinedObjectClassInspector) definedObjectClass.appInfo;
                            ObjectClassDefnInspector defnInspector = (ObjectClassDefnInspector) ((ObjectClassDefnInspector) inspector.actualNodeInspector).Node.appInfo;
                            nodeInspectors.Push (defnInspector);
                        }
                        break;
                        case ObjectClassFieldType.__p1_markers.m2:
                            nodeInspectors.Pop ();
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector fieldInspector = p_ObjectClassFieldType.m_FieldName.appInfo as NodeInspector;
                    if (fieldInspector != null)
                    {
                        Console.WriteLine ($"OBJECT CLASS FIELD TYPE IS: {fieldInspector.GetType ().Name}");
                        Console.WriteLine ($"                     FIELD: {p_ObjectClassFieldType.Emit (-1)}");
                        Console.WriteLine ($"                      TYPE: {fieldInspector.Node.Emit (-1)}");
                    }
                    p_ObjectClassFieldType.parent.appInfo = p_ObjectClassFieldType.appInfo = fieldInspector;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectIdentifierType_Event (SyntaxTreeCallbackReason reason, ObjectIdentifierType.production_kind kind, ObjectIdentifierType p_ObjectIdentifierType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_ObjectIdentifierType.appInfo = new ObjectIdentifierTypeInspector (p_ObjectIdentifierType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_ObjectIdentifierType.parent.appInfo = p_ObjectIdentifierType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_OctetStringType_Event (SyntaxTreeCallbackReason reason, OctetStringType.production_kind kind, OctetStringType p_OctetStringType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_OctetStringType.appInfo = new OctetStringTypeInspector (p_OctetStringType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_OctetStringType.parent.appInfo = p_OctetStringType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_RealType_Event (SyntaxTreeCallbackReason reason, RealType.production_kind kind, RealType p_RealType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_RealType.appInfo = new RealTypeInspector (p_RealType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_RealType.parent.appInfo = p_RealType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_RelativeIRIType_Event (SyntaxTreeCallbackReason reason, RelativeIRIType.production_kind kind, RelativeIRIType p_RelativeIRIType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_RelativeIRIType.appInfo = new RelativeIRITypeInspector (p_RelativeIRIType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_RelativeIRIType.parent.appInfo = p_RelativeIRIType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_RelativeOIDType_Event (SyntaxTreeCallbackReason reason, RelativeOIDType.production_kind kind, RelativeOIDType p_RelativeOIDType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_RelativeOIDType.appInfo = new RelativeOIDTypeInspector (p_RelativeOIDType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_RelativeOIDType.parent.appInfo = p_RelativeOIDType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SequenceType_Event (SyntaxTreeCallbackReason reason, SequenceType.production_kind kind, SequenceType p_SequenceType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_SequenceType.appInfo = tableConstraintLink = new SequenceTypeInspector (p_SequenceType, tableConstraintLink)));
                    if (p_SequenceType.parent.parent.parent is TypeAssignment)
                        break;
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    tableConstraintLink = nodeInspectors.Pop ().tableConstraintLink;
                    (p_SequenceType.appInfo as ComponentCounterInspector).ComputeLevel ();
                    if ((p_SequenceType.appInfo as ComponentCounterInspector).level > 0)
                        Console.WriteLine ($"INNERMOST: {p_SequenceType.Emit (-1)}");
                    else
                    {
                        Console.WriteLine ($"OUTERMOST: {p_SequenceType.Emit (-1)}");
                        AsnTableConstraintResolver tableConstraintResolver = new AsnTableConstraintResolver ();
                        tableConstraintResolver.Invoke (p_SequenceType);
                    }
                    p_SequenceType.parent.appInfo = p_SequenceType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SequenceOfType_Event (SyntaxTreeCallbackReason reason, SequenceOfType.production_kind kind, SequenceOfType p_SequenceOfType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_SequenceOfType.appInfo = tableConstraintLink = new SequenceOfTypeInspector (p_SequenceOfType, tableConstraintLink)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    tableConstraintLink = nodeInspectors.Pop ().tableConstraintLink;
                    (p_SequenceOfType.appInfo as ComponentCounterInspector).ComputeLevel ();
                    if ((p_SequenceOfType.appInfo as ComponentCounterInspector).level > 0)
                        Console.WriteLine ($"INNERMOST: {p_SequenceOfType.Emit (-1)}");
                    else
                    {
                        Console.WriteLine ($"OUTERMOST: {p_SequenceOfType.Emit (-1)}");
                        AsnTableConstraintResolver tableConstraintResolver = new AsnTableConstraintResolver ();
                        tableConstraintResolver.Invoke (p_SequenceOfType);
                    }
                    p_SequenceOfType.parent.appInfo = p_SequenceOfType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SetType_Event (SyntaxTreeCallbackReason reason, SetType.production_kind kind, SetType p_SetType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_SetType.appInfo = tableConstraintLink = new SetTypeInspector (p_SetType, tableConstraintLink)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    tableConstraintLink = nodeInspectors.Pop ().tableConstraintLink;
                    (p_SetType.appInfo as ComponentCounterInspector).ComputeLevel ();
                    if ((p_SetType.appInfo as ComponentCounterInspector).level > 0)
                        Console.WriteLine ($"INNERMOST: {p_SetType.Emit (-1)}");
                    else
                    {
                        Console.WriteLine ($"OUTERMOST: {p_SetType.Emit (-1)}");
                        AsnTableConstraintResolver tableConstraintResolver = new AsnTableConstraintResolver ();
                        tableConstraintResolver.Invoke (p_SetType);
                    }
                    p_SetType.parent.appInfo = p_SetType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SetOfType_Event (SyntaxTreeCallbackReason reason, SetOfType.production_kind kind, SetOfType p_SetOfType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_SetOfType.appInfo = tableConstraintLink = new SetOfTypeInspector (p_SetOfType, tableConstraintLink)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    tableConstraintLink = nodeInspectors.Pop ().tableConstraintLink;
                    (p_SetOfType.appInfo as ComponentCounterInspector).ComputeLevel ();
                    if ((p_SetOfType.appInfo as ComponentCounterInspector).level > 0)
                        Console.WriteLine ($"INNERMOST: {p_SetOfType.Emit (-1)}");
                    else
                    {
                        Console.WriteLine ($"OUTERMOST: {p_SetOfType.Emit (-1)}");
                        AsnTableConstraintResolver tableConstraintResolver = new AsnTableConstraintResolver ();
                        tableConstraintResolver.Invoke (p_SetOfType);
                    }
                    p_SetOfType.parent.appInfo = p_SetOfType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_PrefixedType_Event (SyntaxTreeCallbackReason reason, PrefixedType.production_kind kind, PrefixedType p_PrefixedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_PrefixedType.parent.appInfo = p_PrefixedType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_TaggedType_Event (SyntaxTreeCallbackReason reason, TaggedType.production_kind kind, TaggedType p_TaggedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_TaggedType.appInfo = new TaggedTypeInspector (p_TaggedType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_TaggedType.parent.appInfo = p_TaggedType.appInfo;
                    TaggedTypeInspector inspector = p_TaggedType.appInfo as TaggedTypeInspector;
                    if (inspector == null)
                        break;
                    inspector.ComputeTagInfo ();
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_EncodingPrefixedType_Event (SyntaxTreeCallbackReason reason, EncodingPrefixedType.production_kind kind, EncodingPrefixedType p_EncodingPrefixedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_EncodingPrefixedType.appInfo = new EncodingPrefixedTypeInspector (p_EncodingPrefixedType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_EncodingPrefixedType.parent.appInfo = p_EncodingPrefixedType.appInfo;
                    EncodingPrefixedTypeInspector inspector = p_EncodingPrefixedType.appInfo as EncodingPrefixedTypeInspector;
                    if (inspector == null)
                        break;
                    inspector.ComputeEncodingInfo ();
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_TimeType_Event (SyntaxTreeCallbackReason reason, TimeType.production_kind kind, TimeType p_TimeType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_TimeType.appInfo = new TimeTypeInspector (p_TimeType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_TimeType.parent.appInfo = p_TimeType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_TimeOfDayType_Event (SyntaxTreeCallbackReason reason, TimeOfDayType.production_kind kind, TimeOfDayType p_TimeOfDayType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_TimeOfDayType.appInfo = new TimeOfDayTypeInspector (p_TimeOfDayType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_TimeOfDayType.parent.appInfo = p_TimeOfDayType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ComponentType_Event (SyntaxTreeCallbackReason reason, ComponentType.production_kind kind, ComponentType p_ComponentType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    if (kind != ComponentType.production_kind.g_ComponentType_3)
                        break;
                    switch ((ComponentType.__p3_markers) p_ComponentType.turn)
                    {
                        case ComponentType.__p3_markers.m1:
                        {
                            TypeOrNamedType typeOrNamedType = p_ComponentType.m_TypeOrNamedType;
                            switch ((TypeOrNamedType.production_kind) typeOrNamedType.kind)
                            {
                                case TypeOrNamedType.production_kind.g_TypeOrNamedType_1:
                                    nodeInspectors.Push ((NodeInspector) typeOrNamedType.m_Type.appInfo);
                                    break;
                                case TypeOrNamedType.production_kind.g_TypeOrNamedType_2:
                                    nodeInspectors.Push ((NodeInspector) typeOrNamedType.m_NamedType.m_Type.appInfo);
                                    break;
                            }
                        }
                        break;
                        case ComponentType.__p3_markers.m2:
                            nodeInspectors.Pop ();
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    ComponentTypeListInspector componentTypeListInspector = (ComponentTypeListInspector) nodeInspectors.Peek ();
                    ComponentTypesDictionary componentTypes = componentTypeListInspector.ComponentTypes;
                    NamedType namedType = (kind != ComponentType.production_kind.g_ComponentType_4) ? p_ComponentType.m_TypeOrNamedType.m_NamedType : null;
                    if (namedType != null)
                    {
                        string name = namedType.m_identifier_token.m_identifier.text;
                        if (componentTypes.TryGetValue (name, out _))
                            Console.Error.WriteLine ($"ERROR: component {name} is already present");
                        else
                            componentTypes [name] = p_ComponentType;
                    }
                    componentTypeListInspector.EnumeratedComponentTypes [componentTypeListInspector.ComponentCounter] = p_ComponentType;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ExceptionIdentification_Event (SyntaxTreeCallbackReason reason, ExceptionIdentification.production_kind kind, ExceptionIdentification p_ExceptionIdentification)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    if (kind != ExceptionIdentification.production_kind.g_ExceptionIdentification_3)
                        break;
                    switch ((ExceptionIdentification.__p3_markers) p_ExceptionIdentification.turn)
                    {
                        case ExceptionIdentification.__p3_markers.m1:
                            nodeInspectors.Push ((NodeInspector) p_ExceptionIdentification.m_Type.appInfo);
                            break;
                        case ExceptionIdentification.__p3_markers.m2:
                            nodeInspectors.Pop ();
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SizeConstraint_Event (SyntaxTreeCallbackReason reason, SizeConstraint.production_kind kind, SizeConstraint p_SizeConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((SizeConstraint.__size_markers) p_SizeConstraint.turn)
                    {
                        case SizeConstraint.__size_markers.push_governor:
                            nodeInspectors.Push (new SizeConstraintInspector (p_SizeConstraint));
                            break;
                        case SizeConstraint.__size_markers.pop_governor:
                            nodeInspectors.Pop ();
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_DefinedType_Event (SyntaxTreeCallbackReason reason, DefinedType.production_kind kind, DefinedType p_DefinedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_DefinedType.appInfo != null)
                    {
                        nodeInspectors.Push ((NodeInspector) p_DefinedType.appInfo);
                        break;
                    }
                    AsnSymbol typeReference = null;
                    foreach (AsnSymbol contextSymbol in moduleStack)
                    {
                        if ((typeReference = p_DefinedType.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (typeReference == null)
                    {
                        nodeInspectors.Push ((NodeInspector) (p_DefinedType.appInfo = new DefinedTypeInspector (p_DefinedType, null)));
                        Console.Error.WriteLine ($"ERROR: UNDEFINED TYPE REFERENCE: {p_DefinedType.Emit (-1)}");
                        break;
                    }
                    typeReference = typeReference.DefiningReference;
                    if (!(typeReference.Node.parent is ParameterizedAssignment) && (typeReference.Specie != AsnSymbol.SymbolSpecie.ReferenceSpecie))
                    {
                        try
                        {
                            contextStack.Push (typeReference.Context);
                            moduleStack.Push (currentModule = typeReference.Context);
                            if (typeReference.Node.appInfo == null)
                            {
                                typeReference.Node.InvokeTraverse (this);
                                NodeInspector nodeInspector = ((NodeInspector) typeReference.Node.appInfo).actualNodeInspector;
                                if (!(nodeInspector is TypeAssignmentInspector))
                                {
                                    if (Debug)
                                    {
                                        Console.Error.WriteLine ($"ERROR-N: DEFINED TYPE NODE INSPECTOR IS NOT CORRECT: {nodeInspector.GetType ().ToString ()}");
                                        Console.Error.WriteLine ($"                            INSPECTOR TYPE: {nodeInspector.GetType ().ToString ()}");
                                        Console.Error.WriteLine ($"                            INSPECTOR NODE: {nodeInspector.Node.Emit (-1)}");
                                        Console.Error.WriteLine ($"                                    MODULE: {currentModule.Path}");
                                        Console.Error.WriteLine ($"                                 TYPE NODE: {typeReference.Node.Emit (-1)}");
                                    }
                                    PrintStackTrace ();
                                }
                            }
                            moduleStack.Pop ();
                            currentModule = moduleStack.Peek ();
                            contextStack.Pop ();
                        }
                        catch (Exception e)
                        {
                            Console.Error.WriteLine ($"ERROR: {e.Message}");
                        }
                        if (typeReference.Node.appInfo == null)
                        {
                            Console.Error.WriteLine ($"ERROR: UNDEFINED TYPE INSPECTOR: {p_DefinedType.Emit (-1)}");
                        }
                    }
                    nodeInspectors.Push ((NodeInspector) (p_DefinedType.appInfo = new DefinedTypeInspector (p_DefinedType, (NodeInspector) typeReference.Node.appInfo)));
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_DefinedType.parent.appInfo = p_DefinedType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_UsefulType_Event (SyntaxTreeCallbackReason reason, UsefulType.production_kind kind, UsefulType p_UsefulType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_UsefulType.appInfo = new UsefulTypeInspector (p_UsefulType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_UsefulType.parent.appInfo = p_UsefulType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SelectionType_Event (SyntaxTreeCallbackReason reason, SelectionType.production_kind kind, SelectionType p_SelectionType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) (p_SelectionType.appInfo = new SelectionTypeInspector (p_SelectionType)));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_SelectionType.parent.appInfo = p_SelectionType.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectClass_Event (SyntaxTreeCallbackReason reason, ObjectClass.production_kind kind, ObjectClass p_ObjectClass)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    //if (kind == ObjectClass.production_kind.g_ObjectClass_1)
                    //    inspectorStack.Pop ();
                    switch ((ObjectClass.production_kind) p_ObjectClass.kind)
                    {
                        case ObjectClass.production_kind.g_ObjectClass_1:
                        {
                            DefinedObjectClass definedObjectClass = p_ObjectClass.m_DefinedObjectClass;
                            p_ObjectClass.appInfo = definedObjectClass.appInfo;
                        }
                        break;
                        case ObjectClass.production_kind.g_ObjectClass_2:
                        {
                            ObjectClassDefn objectClassDefn = p_ObjectClass.m_ObjectClassDefn;
                            p_ObjectClass.appInfo = objectClassDefn.appInfo;
                        }
                        break;
                        case ObjectClass.production_kind.g_ObjectClass_3:
                        {
                            DefinedObjectClass definedObjectClass = p_ObjectClass.m_ParameterizedObjectClass.m_DefinedObjectClass;
                            p_ObjectClass.appInfo = definedObjectClass.appInfo;
                        }
                        break;
                    }
                    p_ObjectClass.parent.appInfo = p_ObjectClass.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_DefinedObjectClass_Event (SyntaxTreeCallbackReason reason, DefinedObjectClass.production_kind kind, DefinedObjectClass p_DefinedObjectClass)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_DefinedObjectClass.appInfo != null)
                    {
                        nodeInspectors.Push ((NodeInspector) p_DefinedObjectClass.appInfo);
                        break;
                    }
                    AsnSymbol classReference = null;
                    foreach (AsnSymbol contextSymbol in moduleStack)
                    {
                        if ((classReference = p_DefinedObjectClass.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (classReference == null)
                    {
                        nodeInspectors.Push ((NodeInspector) (p_DefinedObjectClass.appInfo = new DefinedObjectClassInspector (p_DefinedObjectClass, null)));
                        Console.Error.WriteLine ($"ERROR: UNDEFINED CLASS REFERENCE: {p_DefinedObjectClass.Emit (-1)}");
                        break;
                    }
                    classReference = classReference.DefiningReference;
                    if (!(classReference.Node.parent is ParameterizedAssignment) && (classReference.Specie != AsnSymbol.SymbolSpecie.ReferenceSpecie))
                    {
                        if (classReference.Node.appInfo == null)
                        {
                            contextStack.Push (classReference.Context);
                            moduleStack.Push (currentModule = classReference.Context);
                            classReference.Node.InvokeTraverse (this);
                            NodeInspector nodeInspector = ((NodeInspector) classReference.Node.appInfo).actualNodeInspector;
                            if (!(nodeInspector is ObjectClassDefnInspector))
                            {
                                if (Debug)
                                {
                                    Console.Error.WriteLine ($"ERROR-N: DEFINED CLASS NODE INSPECTOR IS NOT CORRECT: {nodeInspector.GetType ().ToString ()}");
                                    Console.Error.WriteLine ($"                             INSPECTOR TYPE: {nodeInspector.GetType ().ToString ()}");
                                    Console.Error.WriteLine ($"                             INSPECTOR NODE: {nodeInspector.Node.Emit (-1)}");
                                    Console.Error.WriteLine ($"                                     MODULE: {currentModule.Path}");
                                    Console.Error.WriteLine ($"                                 CLASS NODE: {classReference.Node.Emit (-1)}");
                                }
                                PrintStackTrace ();
                            }
                            moduleStack.Pop ();
                            currentModule = moduleStack.Peek ();
                            contextStack.Pop ();
                        }
                        if (classReference.Node.appInfo == null)
                        {
                            Console.Error.WriteLine ($"ERROR: UNDEFINED CLASS REFERENCE: {p_DefinedObjectClass.Emit (-1)}");
                        }
                    }
                    nodeInspectors.Push ((NodeInspector) (p_DefinedObjectClass.appInfo = new DefinedObjectClassInspector (p_DefinedObjectClass, classReference)));
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_DefinedObjectClass.parent.appInfo = p_DefinedObjectClass.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_DefinedObject_Event (SyntaxTreeCallbackReason reason, DefinedObject.production_kind kind, DefinedObject p_DefinedObject)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_DefinedObject.appInfo != null)
                    {
                        nodeInspectors.Push ((NodeInspector) (p_DefinedObject.appInfo));
                        break;
                    }
                    AsnSymbol objectReference = null;
                    foreach (AsnSymbol contextSymbol in moduleStack)
                    {
                        if ((objectReference = p_DefinedObject.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (objectReference == null)
                    {
                        nodeInspectors.Push ((NodeInspector) (p_DefinedObject.appInfo = new DefinedObjectInspector (p_DefinedObject, null)));
                        Console.Error.WriteLine ($"ERROR: UNDEFINED OBJECT REFERENCE: {p_DefinedObject.Emit (-1)}");
                        break;
                    }
                    objectReference = objectReference.DefiningReference;
                    if (!(objectReference.Node.parent is ParameterizedAssignment) /*&& (objectReference.Specie != AsnSymbol.SymbolSpecie.ReferenceSpecie)*/)
                    {
                        try
                        {
                            contextStack.Push (objectReference.Context);
                            moduleStack.Push (currentModule = objectReference.Context);
                            if (objectReference.Node.appInfo == null)
                            {
                                objectReference.Node.InvokeTraverse (this);
                                if (objectReference.Node.appInfo != null)
                                {
                                    NodeInspector nodeInspector = ((NodeInspector) objectReference.Node.appInfo).actualNodeInspector;
                                    if (!(nodeInspector is ObjectClassDefnInspector))
                                    {
                                        if (Debug)
                                        {
                                            Console.Error.WriteLine ($"ERROR-N: DEFINED OBJECT NODE INSPECTOR IS NOT CORRECT: {nodeInspector.GetType ().ToString ()}");
                                            Console.Error.WriteLine ($"                              INSPECTOR TYPE: {nodeInspector.GetType ().ToString ()}");
                                            Console.Error.WriteLine ($"                              INSPECTOR NODE: {nodeInspector.Node.Emit (-1)}");
                                            Console.Error.WriteLine ($"                                      MODULE: {currentModule.Path}");
                                            Console.Error.WriteLine ($"                                 OBJECT NODE: {objectReference.Node.Emit (-1)}");
                                        }
                                        PrintStackTrace ();
                                    }
                                }
                            }
                            moduleStack.Pop ();
                            currentModule = moduleStack.Peek ();
                            contextStack.Pop ();
                        }
                        catch (Exception e)
                        {
                            Console.Error.WriteLine ($"ERROR: UNDEFINED OBJECT REFERENCE: {objectReference.Path}");
                            Console.Error.WriteLine ($"    EXCEPTION: {e.Message}");
                        }
                        if (objectReference.Node.appInfo == null)
                        {
                            Console.Error.WriteLine ($"ERROR: UNDEFINED OBJECT REFERENCE: {objectReference.Path}");
                        }
                    }
                    nodeInspectors.Push ((NodeInspector) (p_DefinedObject.appInfo = new DefinedObjectInspector (p_DefinedObject, objectReference)));
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_DefinedObject.parent.appInfo = p_DefinedObject.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_DefinedObjectSet_Event (SyntaxTreeCallbackReason reason, DefinedObjectSet.production_kind kind, DefinedObjectSet p_DefinedObjectSet)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_DefinedObjectSet.appInfo != null)
                    {
                        nodeInspectors.Push ((NodeInspector) p_DefinedObjectSet.appInfo);
                        break;
                    }
                    AsnSymbol objectSetReference = null;
                    foreach (AsnSymbol contextSymbol in moduleStack)
                    {
                        if ((objectSetReference = p_DefinedObjectSet.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (objectSetReference == null)
                    {
                        nodeInspectors.Push ((NodeInspector) (p_DefinedObjectSet.appInfo = new DefinedObjectSetInspector (p_DefinedObjectSet, null)));
                        Console.Error.WriteLine ($"ERROR: UNDEFINED OBJECT SET REFERENCE: {p_DefinedObjectSet.Emit (-1)}");
                        break;
                    }
                    objectSetReference = objectSetReference.DefiningReference;
                    if (!(objectSetReference.Node.parent is ParameterizedAssignment) && (objectSetReference.Specie != AsnSymbol.SymbolSpecie.ReferenceSpecie))
                    {
                        {
                            contextStack.Push (objectSetReference.Context);
                            moduleStack.Push (currentModule = objectSetReference.Context);
                            if (objectSetReference.Node.appInfo == null)
                            {
                                objectSetReference.Node.InvokeTraverse (this);
                                NodeInspector nodeInspector = ((NodeInspector) objectSetReference.Node.appInfo).actualNodeInspector;
                                if (!(nodeInspector is ObjectSetAssignmentInspector))
                                {
                                    if (Debug)
                                    {
                                        Console.Error.WriteLine ($"ERROR-N: DEFINED OBJECT SET NODE INSPECTOR IS NOT CORRECT: {nodeInspector.GetType ().ToString ()}");
                                        Console.Error.WriteLine ($"                            INSPECTOR TYPE: {nodeInspector.GetType ().ToString ()}");
                                        Console.Error.WriteLine ($"                            INSPECTOR NODE: {nodeInspector.Node.Emit (-1)}");
                                        Console.Error.WriteLine ($"                                    MODULE: {currentModule.Path}");
                                        Console.Error.WriteLine ($"                           OBJECT SET NODE: {objectSetReference.Node.Emit (-1)}");
                                    }
                                    PrintStackTrace ();
                                }
                            }
                            moduleStack.Pop ();
                            currentModule = moduleStack.Peek ();
                            contextStack.Pop ();
                        }
                        if (objectSetReference.Node.appInfo == null)
                        {
                            Console.Error.WriteLine ($"ERROR: UNDEFINED OBJECT SET INSPECTOR: {p_DefinedObjectSet.Emit (-1)}");
                        }
                    }
                    nodeInspectors.Push ((NodeInspector) (p_DefinedObjectSet.appInfo = new DefinedObjectSetInspector (p_DefinedObjectSet, objectSetReference)));
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_DefinedObjectSet.parent.appInfo = p_DefinedObjectSet.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectClassDefn_Event (SyntaxTreeCallbackReason reason, ObjectClassDefn.production_kind kind, ObjectClassDefn p_ObjectClassDefn)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push ((NodeInspector) p_ObjectClassDefn.appInfo);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_ObjectClassDefn.parent.appInfo = p_ObjectClassDefn.appInfo;
                    nodeInspectors.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_TypeFieldSpec_Event (SyntaxTreeCallbackReason reason, TypeFieldSpec.production_kind kind, TypeFieldSpec p_TypeFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_TypeFieldSpec.appInfo != null)
                        return false;
                    p_TypeFieldSpec.parent.appInfo = p_TypeFieldSpec.appInfo = new TypeFieldSpecInspector (p_TypeFieldSpec);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector nodeInspector = nodeInspectors.Peek ();
                    if (!(nodeInspector is ObjectClassDefnInspector))
                        break;
                    ObjectClassDefnInspector objectClassDefnInspector = (ObjectClassDefnInspector) nodeInspector;
                    ObjectClassAssignment objectClassAssignment = (ObjectClassAssignment) objectClassDefnInspector.Node.parent.parent;
                    AsnSymbol classSymbol = (AsnSymbol) objectClassAssignment.m_objectclassreference_token.m_typereference_token.appInfo;
                    typereference_token typereference_Token = p_TypeFieldSpec.m_typefieldreference_token.m_typereference_token;
                    string name = '&' + typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, classSymbol, p_TypeFieldSpec);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol == null)
                        Console.Error.WriteLine ($"ERROR: UNDEFINED CLASS TYPE FIELD: file: {currentFile}, field: {classSymbol.Name}.&{name}");
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_FixedTypeValueFieldSpec_Event (SyntaxTreeCallbackReason reason, FixedTypeValueFieldSpec.production_kind kind, FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_FixedTypeValueFieldSpec.appInfo != null)
                        return false;
                    p_FixedTypeValueFieldSpec.parent.appInfo = p_FixedTypeValueFieldSpec.appInfo = new FixedTypeValueFieldSpecInspector (p_FixedTypeValueFieldSpec);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((FixedTypeValueFieldSpec.__field_markers) p_FixedTypeValueFieldSpec.turn)
                    {
                        case FixedTypeValueFieldSpec.__field_markers.push_governor:
                            return false;
                        case FixedTypeValueFieldSpec.__field_markers.pop_governor:
                            return true;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector nodeInspector = (NodeInspector) p_FixedTypeValueFieldSpec.m_Type.appInfo;
                    if (nodeInspector is ObjectClassDefnInspector)
                        nodeInspector = ((ObjectClassDefnInspector) nodeInspector).Node.appInfo as NodeInspector;
                    if (nodeInspector == null)
                        return false;
                    NodeInspector actualInspector = nodeInspector.actualNodeInspector;
                    string text = p_FixedTypeValueFieldSpec.Emit (-1);
                    if (actualInspector is ObjectClassDefnInspector)
                    {
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE FIXED TYPE VALUE FIELD AS OBJECT FIELD:");
                            Console.Error.WriteLine ($"\t{text}");
                            return true;
                        };
                        if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.ObjectFieldSpec_token }) == 0)
                        {
                            if (actualInspector is ObjectClassDefnInspector)
                            {
                                if (Debug)
                                {
                                    Console.Error.WriteLine ($"FIXED TYPE VALUE FIELD SHOULD BE CONVERTED TO OBJECT FIELD: {text}");
                                    Console.Error.WriteLine ($"                                       NODE INSPECTOR TYPE: {nodeInspector.actualNodeInspector.GetType ()}");
                                    if (nodeInspector.actualNodeInspector != null)
                                        Console.Error.WriteLine ($"\tACTUAL INSPECTOR NODE: {nodeInspector.actualNodeInspector.Node.Emit (-1)}");
                                    else
                                        Console.Error.WriteLine ($"\t       INSPECTOR NODE: {nodeInspector.Node.Emit (-1)}");

                                }
                                parselist p_synlist = asnCompiler.parseList;
                                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                                {
                                    if (node == null)
                                        continue;
                                    {
                                        string fieldName = '&' + p_FixedTypeValueFieldSpec.m_valuefieldreference_token.m_identifier_token.m_identifier.text;
                                        ObjectClassDefnInspector objectClassInspector = (ObjectClassDefnInspector) nodeInspectors.Peek ();
                                        if (objectClassInspector.FieldSpecs.TryGetValue (fieldName, out _))
                                        {
                                            FieldSpec fieldSpec = (FieldSpec) p_FixedTypeValueFieldSpec.parent;
                                            ObjectFieldSpec objectFieldSpec = ((asn_features) node).m_ObjectFieldSpec;
                                            fieldSpec.change (objectFieldSpec);
                                            fieldSpec.appInfo = null;
                                            fieldStack.Push (fieldSpec);
                                            Traverse (objectFieldSpec);
                                            fieldStack.Pop ();
                                            fieldSpec.appInfo = new ObjectFieldSpecInspector (objectFieldSpec);
                                            objectClassInspector.FieldSpecs [fieldName] = fieldSpec;
                                            AsnSymbol symbolRef = (AsnSymbol) (objectFieldSpec.m_objectfieldreference_token.m_identifier_token.m_identifier.appInfo = p_FixedTypeValueFieldSpec.m_valuefieldreference_token.m_identifier_token.m_identifier.appInfo);
                                            if (symbolRef != null)
                                                symbolRef.Specie = AsnSymbol.SymbolSpecie.ObjectFieldSpecie;
                                        }
                                    }
                                }
                            }
                        }
                        return false;
                    }
                    else if (actualInspector.NodeType != NodeType.TypeNode)
                    {
                        Console.Error.WriteLine ($"ERROR: CANNOT CHECK VALUE FIELD");
                    }
                    {
                        nodeInspectors.Push ((NodeInspector) p_FixedTypeValueFieldSpec.m_Type.appInfo);
                        Traverse (p_FixedTypeValueFieldSpec.m_ValueOptionalitySpec_optional);
                        nodeInspectors.Pop ();
                    }
                    ObjectClassDefnInspector objectClassDefnInspector = nodeInspectors.Peek () as ObjectClassDefnInspector;
                    if (objectClassDefnInspector == null)
                        break;
                    ObjectClassAssignment objectClassAssignment = (ObjectClassAssignment) objectClassDefnInspector.Node.parent.parent;
                    AsnSymbol classSymbol = (AsnSymbol) objectClassAssignment.m_objectclassreference_token.m_typereference_token.appInfo;
                    identifier_token identifier_Token = p_FixedTypeValueFieldSpec.m_valuefieldreference_token.m_identifier_token;
                    string name = '&' + identifier_Token.m_identifier.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, classSymbol, p_FixedTypeValueFieldSpec);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol == null)
                        Console.Error.WriteLine ($"ERROR: UNDEFINED CLASS FIXED TYPE VALUE FIELD: file: {currentFile}, field: {classSymbol.Name}.&{name}");
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_VariableTypeValueFieldSpec_Event (SyntaxTreeCallbackReason reason, VariableTypeValueFieldSpec.production_kind kind, VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_VariableTypeValueFieldSpec.appInfo != null)
                        return false;
                    p_VariableTypeValueFieldSpec.parent.appInfo = p_VariableTypeValueFieldSpec.appInfo = new VariableTypeValueFieldSpecInspector (p_VariableTypeValueFieldSpec);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((VariableTypeValueFieldSpec.__p1_markers) p_VariableTypeValueFieldSpec.turn)
                    {
                        case VariableTypeValueFieldSpec.__p1_markers.m1:
                            break;
                        case VariableTypeValueFieldSpec.__p1_markers.m2:
                            return false;
                        case VariableTypeValueFieldSpec.__p1_markers.m3:
                            return true;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector actualNodeInspector =
                        ((NodeInspector) p_VariableTypeValueFieldSpec.appInfo).actualNodeInspector =
                        (NodeInspector) p_VariableTypeValueFieldSpec.m_FieldName.appInfo;
                    nodeInspectors.Push (actualNodeInspector);
                    Traverse (p_VariableTypeValueFieldSpec.m_ValueOptionalitySpec_optional);
                    nodeInspectors.Pop ();
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_FixedTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason reason, FixedTypeValueSetFieldSpec.production_kind kind, FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_FixedTypeValueSetFieldSpec.appInfo != null)
                        return false;
                    p_FixedTypeValueSetFieldSpec.parent.appInfo = p_FixedTypeValueSetFieldSpec.appInfo = new FixedTypeValueSetFieldSpecInspector (p_FixedTypeValueSetFieldSpec);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((FixedTypeValueSetFieldSpec.__field_markers) p_FixedTypeValueSetFieldSpec.turn)
                    {
                        case FixedTypeValueSetFieldSpec.__field_markers.push_governor:
                            return false;
                        case FixedTypeValueSetFieldSpec.__field_markers.pop_governor:
                            return true;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector nodeInspector = (NodeInspector) p_FixedTypeValueSetFieldSpec.m_Type.appInfo;
                    NodeInspector actualInspector = nodeInspector.actualNodeInspector;
                    string text = p_FixedTypeValueSetFieldSpec.Emit (-1);
                    if (actualInspector is ObjectClassDefnInspector)
                    {
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE FIXED TYPE VALUE SET FIELD AS OBJECT SET FIELD:");
                            Console.Error.WriteLine ($"\t{text}");
                            return true;
                        };
                        if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.ObjectSetFieldSpec_token }) == 0)
                        {
                            if (actualInspector is ObjectClassDefnInspector)
                            {
                                if (Debug)
                                {
                                    Console.Error.WriteLine ($"FIXED TYPE VALUE SET FIELD SHOULD BE CONVERTED TO OBJECT SET FIELD: {text}");
                                    Console.Error.WriteLine ($"                                               NODE INSPECTOR TYPE: {nodeInspector.actualNodeInspector.GetType ()}");
                                    if (nodeInspector.actualNodeInspector != null)
                                        Console.Error.WriteLine ($"\tACTUAL INSPECTOR NODE: {nodeInspector.actualNodeInspector.Node.Emit (-1)}");
                                    else
                                        Console.Error.WriteLine ($"\t       INSPECTOR NODE: {nodeInspector.Node.Emit (-1)}");

                                }
                                parselist p_synlist = asnCompiler.parseList;
                                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                                {
                                    if (node == null)
                                        continue;
                                    {
                                        string fieldName = '&' + p_FixedTypeValueSetFieldSpec.m_valuesetfieldreference_token.m_typereference_token.m_typereference.text;
                                        ObjectClassDefnInspector objectClassInspector = (ObjectClassDefnInspector) nodeInspectors.Peek ();
                                        if (objectClassInspector.FieldSpecs.TryGetValue (fieldName, out _))
                                        {
                                            FieldSpec fieldSpec = (FieldSpec) p_FixedTypeValueSetFieldSpec.parent;
                                            ObjectSetFieldSpec objectSetFieldSpec = ((asn_features) node).m_ObjectSetFieldSpec;
                                            fieldSpec.change (objectSetFieldSpec);
                                            fieldSpec.appInfo = null;
                                            fieldStack.Push (fieldSpec);
                                            Traverse (objectSetFieldSpec);
                                            fieldStack.Pop ();
                                            fieldSpec.appInfo = new ObjectSetFieldSpecInspector (objectSetFieldSpec);
                                            objectClassInspector.FieldSpecs [fieldName] = fieldSpec;
                                            AsnSymbol symbolRef = (AsnSymbol) (objectSetFieldSpec.m_objectsetfieldreference_token.m_typereference_token.m_typereference.appInfo = p_FixedTypeValueSetFieldSpec.m_valuesetfieldreference_token.m_typereference_token.m_typereference.appInfo);
                                            if (symbolRef != null)
                                                symbolRef.Specie = AsnSymbol.SymbolSpecie.ObjectSetFieldSpecie;
                                        }
                                    }
                                }
                            }
                        }
                        return false;
                    }
                    else if (actualInspector.NodeType != NodeType.TypeNode)
                    {
                        Console.Error.WriteLine ($"ERROR: CANNOT CHECK VALUE SET FIELD");
                    }
                    {
                        nodeInspectors.Push ((NodeInspector) p_FixedTypeValueSetFieldSpec.m_Type.appInfo);
                        Traverse (p_FixedTypeValueSetFieldSpec.m_ValueSetOptionalitySpec_optional);
                        nodeInspectors.Pop ();
                    }
                    nodeInspector = nodeInspectors.Peek ();
                    if (!(nodeInspector is ObjectClassDefnInspector))
                        break;
                    ObjectClassDefnInspector objectClassDefnInspector = (ObjectClassDefnInspector) nodeInspector;
                    ObjectClassAssignment objectClassAssignment = (ObjectClassAssignment) objectClassDefnInspector.Node.parent.parent;
                    AsnSymbol classSymbol = (AsnSymbol) objectClassAssignment.m_objectclassreference_token.m_typereference_token.appInfo;
                    typereference_token typereference_Token = p_FixedTypeValueSetFieldSpec.m_valuesetfieldreference_token.m_typereference_token;
                    string name = '&' + typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, classSymbol, p_FixedTypeValueSetFieldSpec);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol == null)
                        Console.Error.WriteLine ($"ERROR: UNDEFINED CLASS FIXED TYPE VALUE SET FIELD: file: {currentFile}, field: {classSymbol.Name}.&{name}");
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_VariableTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason reason, VariableTypeValueSetFieldSpec.production_kind kind, VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_VariableTypeValueSetFieldSpec.appInfo != null)
                        return false;
                    p_VariableTypeValueSetFieldSpec.parent.appInfo = p_VariableTypeValueSetFieldSpec.appInfo = new VariableTypeValueSetFieldSpecInspector (p_VariableTypeValueSetFieldSpec);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((VariableTypeValueSetFieldSpec.__p1_markers) p_VariableTypeValueSetFieldSpec.turn)
                    {
                        case VariableTypeValueSetFieldSpec.__p1_markers.m1:
                            break;
                        case VariableTypeValueSetFieldSpec.__p1_markers.m2:
                            return false;
                        case VariableTypeValueSetFieldSpec.__p1_markers.m3:
                            return true;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector actualNodeInspector =
                        ((NodeInspector) p_VariableTypeValueSetFieldSpec.appInfo).actualNodeInspector =
                        (NodeInspector) p_VariableTypeValueSetFieldSpec.m_FieldName.appInfo;
                    nodeInspectors.Push (actualNodeInspector);
                    Traverse (p_VariableTypeValueSetFieldSpec.m_ValueSetOptionalitySpec_optional);
                    nodeInspectors.Pop ();
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectFieldSpec_Event (SyntaxTreeCallbackReason reason, ObjectFieldSpec.production_kind kind, ObjectFieldSpec p_ObjectFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_ObjectFieldSpec.appInfo != null)
                        return false;
                    p_ObjectFieldSpec.parent.appInfo = p_ObjectFieldSpec.appInfo = new ObjectFieldSpecInspector (p_ObjectFieldSpec);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((ObjectFieldSpec.__field_markers) p_ObjectFieldSpec.turn)
                    {
                        case ObjectFieldSpec.__field_markers.push_governor:
                            return false;
                        case ObjectFieldSpec.__field_markers.pop_governor:
                            return true;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector nodeInspector = (NodeInspector) p_ObjectFieldSpec.m_DefinedObjectClass.appInfo;
                    NodeInspector actualInspector = nodeInspector.actualNodeInspector;
                    string text = p_ObjectFieldSpec.Emit (-1);
                    if (actualInspector is TypeAssignmentInspector)
                    {
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"CANNOT PARSE OBJECT FIELD AS FIXED TYPE VALUE FIELD:");
                            Console.Error.WriteLine ($"\t{text}");
                            return true;
                        };
                        if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.FixedTypeValueFieldSpec_token }) == 0)
                        {
                            if (Debug)
                            {
                                Console.Error.WriteLine ($"OBJECT FIELD SHOULD BE CONVERTED TO FIXED TYPE VALUE FIELD: {text}");
                                Console.Error.WriteLine ($"                                       NODE INSPECTOR TYPE: {nodeInspector.actualNodeInspector.GetType ()}");
                                if (nodeInspector.actualNodeInspector != null)
                                    Console.Error.WriteLine ($"\tACTUAL INSPECTOR NODE: {nodeInspector.actualNodeInspector.Node.Emit (-1)}");
                                else
                                    Console.Error.WriteLine ($"\t       INSPECTOR NODE: {nodeInspector.Node.Emit (-1)}");

                            }
                            parselist p_synlist = asnCompiler.parseList;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                if (node == null)
                                    continue;
                                {
                                    string fieldName = '&' + p_ObjectFieldSpec.m_objectfieldreference_token.m_identifier_token.m_identifier.text;
                                    ObjectClassDefnInspector objectClassInspector = (ObjectClassDefnInspector) nodeInspectors.Peek ();
                                    if (objectClassInspector.FieldSpecs.TryGetValue (fieldName, out _))
                                    {
                                        FieldSpec fieldSpec = (FieldSpec) p_ObjectFieldSpec.parent;
                                        FixedTypeValueFieldSpec fixedTypeValueFieldSpec = ((asn_features) node).m_FixedTypeValueFieldSpec;
                                        fieldSpec.change (fixedTypeValueFieldSpec);
                                        fieldSpec.appInfo = null;
                                        fieldStack.Push (fieldSpec);
                                        Traverse (fixedTypeValueFieldSpec);
                                        fieldStack.Pop ();
                                        fieldSpec.appInfo = new FixedTypeValueFieldSpecInspector (fixedTypeValueFieldSpec);
                                        objectClassInspector.FieldSpecs [fieldName] = fieldSpec;
                                        AsnSymbol symbolRef = (AsnSymbol) (fixedTypeValueFieldSpec.m_valuefieldreference_token.m_identifier_token.m_identifier.appInfo = p_ObjectFieldSpec.m_objectfieldreference_token.m_identifier_token.m_identifier.appInfo);
                                        if (symbolRef != null)
                                            symbolRef.Specie = AsnSymbol.SymbolSpecie.FixedTypeValueFieldSpecie;
                                    }
                                }
                            }
                        }
                        return false;
                    }
                    else if (!(actualInspector is ObjectClassDefnInspector))
                    {
                        Console.Error.WriteLine ($"ERROR: CANNOT CHECK OBJECT FIELD");
                    }
                    {
                        nodeInspectors.Push ((NodeInspector) p_ObjectFieldSpec.appInfo);
                        Traverse (p_ObjectFieldSpec.m_ObjectOptionalitySpec_optional);
                        nodeInspectors.Pop ();
                    }
                    nodeInspector = nodeInspectors.Peek ();
                    if (!(nodeInspector is ObjectClassDefnInspector))
                        break;
                    ObjectClassDefnInspector objectClassDefnInspector = (ObjectClassDefnInspector) nodeInspector;
                    ObjectClassAssignment objectClassAssignment = (ObjectClassAssignment) objectClassDefnInspector.Node.parent.parent;
                    AsnSymbol classSymbol = (AsnSymbol) objectClassAssignment.m_objectclassreference_token.m_typereference_token.appInfo;
                    identifier_token identifier_Token = p_ObjectFieldSpec.m_objectfieldreference_token.m_identifier_token;
                    string name = '&' + identifier_Token.m_identifier.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, classSymbol, p_ObjectFieldSpec);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol == null)
                        Console.Error.WriteLine ($"ERROR: UNDEFINED CLASS OBJECT FIELD: file: {currentFile}, field: {classSymbol.Name}.&{name}");
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectSetFieldSpec_Event (SyntaxTreeCallbackReason reason, ObjectSetFieldSpec.production_kind kind, ObjectSetFieldSpec p_ObjectSetFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_ObjectSetFieldSpec.appInfo != null)
                        return false;
                    p_ObjectSetFieldSpec.parent.appInfo = p_ObjectSetFieldSpec.appInfo = new ObjectSetFieldSpecInspector (p_ObjectSetFieldSpec);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((ObjectSetFieldSpec.__field_markers) p_ObjectSetFieldSpec.turn)
                    {
                        case ObjectSetFieldSpec.__field_markers.push_governor:
                            return false;
                        case ObjectSetFieldSpec.__field_markers.pop_governor:
                            return true;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector nodeInspector = (NodeInspector) p_ObjectSetFieldSpec.m_DefinedObjectClass.appInfo;
                    NodeInspector actualInspector = nodeInspector.actualNodeInspector;
                    if (actualInspector is TypeAssignmentInspector)
                    {
                        string text = p_ObjectSetFieldSpec.Emit (-1);
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE OBJECT SET FIELD AS FIXED TYPE VALUE SET FIELD:");
                            Console.Error.WriteLine ($"\t{text}");
                            return true;
                        };
                        if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.FixedTypeValueSetFieldSpec_token }) == 0)
                        {
                            if (actualInspector is TypeAssignmentInspector)
                            {
                                if (Debug)
                                {
                                    Console.Error.WriteLine ($"OBJECT SET FIELD SHOULD BE CONVERTED TO FIXED TYPE VALUE SET FIELD: {text}");
                                    Console.Error.WriteLine ($"                                               NODE INSPECTOR TYPE: {nodeInspector.actualNodeInspector.GetType ()}");
                                    if (nodeInspector.actualNodeInspector != null)
                                        Console.Error.WriteLine ($"\tACTUAL INSPECTOR NODE: {nodeInspector.actualNodeInspector.Node.Emit (-1)}");
                                    else
                                        Console.Error.WriteLine ($"\t       INSPECTOR NODE: {nodeInspector.Node.Emit (-1)}");

                                }
                                parselist p_synlist = asnCompiler.parseList;
                                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                                {
                                    if (node == null)
                                        continue;
                                    {
                                        string fieldName = '&' + p_ObjectSetFieldSpec.m_objectsetfieldreference_token.m_typereference_token.m_typereference.text;
                                        ObjectClassDefnInspector objectClassInspector = (ObjectClassDefnInspector) nodeInspectors.Peek ();
                                        if (objectClassInspector.FieldSpecs.TryGetValue (fieldName, out _))
                                        {
                                            FieldSpec fieldSpec = (FieldSpec) p_ObjectSetFieldSpec.parent;
                                            FixedTypeValueSetFieldSpec fixedTypeValueSetFieldSpec = ((asn_features) node).m_FixedTypeValueSetFieldSpec;
                                            fieldSpec.change (fixedTypeValueSetFieldSpec);
                                            fieldSpec.appInfo = null;
                                            fieldStack.Push (fieldSpec);
                                            Traverse (fixedTypeValueSetFieldSpec);
                                            fieldStack.Pop ();
                                            fieldSpec.appInfo = new FixedTypeValueSetFieldSpecInspector (fixedTypeValueSetFieldSpec);
                                            objectClassInspector.FieldSpecs [fieldName] = fieldSpec;
                                            AsnSymbol symbolRef = (AsnSymbol) (fixedTypeValueSetFieldSpec.m_valuesetfieldreference_token.m_typereference_token.m_typereference.appInfo = p_ObjectSetFieldSpec.m_objectsetfieldreference_token.m_typereference_token.m_typereference.appInfo);
                                            if (symbolRef != null)
                                                symbolRef.Specie = AsnSymbol.SymbolSpecie.FixedTypeValueSetFieldSpecie;
                                        }
                                    }
                                }
                            }
                        }
                        return false;
                    }
                    else if (!(actualInspector is ObjectClassDefnInspector))
                    {
                        Console.Error.WriteLine ($"ERROR: CANNOT CHECK OBJECT SET FIELD");
                    }
                    {
                        nodeInspectors.Push ((NodeInspector) p_ObjectSetFieldSpec.appInfo);
                        Traverse (p_ObjectSetFieldSpec.m_ObjectSetOptionalitySpec_optional);
                        nodeInspectors.Pop ();
                    }
                    nodeInspector = nodeInspectors.Peek ();
                    if (!(nodeInspector is ObjectClassDefnInspector))
                        break;
                    ObjectClassDefnInspector objectClassDefnInspector = (ObjectClassDefnInspector) nodeInspector;
                    ObjectClassAssignment objectClassAssignment = (ObjectClassAssignment) objectClassDefnInspector.Node.parent.parent;
                    AsnSymbol classSymbol = (AsnSymbol) objectClassAssignment.m_objectclassreference_token.m_typereference_token.appInfo;
                    typereference_token typereference_Token = p_ObjectSetFieldSpec.m_objectsetfieldreference_token.m_typereference_token;
                    string name = '&' + typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, classSymbol, p_ObjectSetFieldSpec);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol == null)
                        Console.Error.WriteLine ($"ERROR: UNDEFINED CLASS OBJECT SET FIELD: file: {currentFile}, field: {classSymbol.Name}.&{name}");
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_FieldName_Event (SyntaxTreeCallbackReason reason, FieldName.production_kind kind, FieldName p_FieldName)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    p_FieldName.Iterate (nodeInspectors.Peek (), GetFieldNodeInspector);
                    return false;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_DefinedSyntax_Event (SyntaxTreeCallbackReason reason, DefinedSyntax.production_kind kind, DefinedSyntax p_DefinedSyntax)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    ObjectClassDefnInspector objectClassDefnInspector = null;
                    NodeInspector nodeInspector = nodeInspectors.Peek ();
                    if (nodeInspector == null)
                    {
                        Console.Error.WriteLine ($"NULL NODE INSPECTOR FOR DEFINED SYNTAX: {p_DefinedSyntax.Emit (-1)}");
                        break;
                    }
                    nodeInspector = nodeInspector.actualNodeInspector;
                    if ((nodeInspector is ObjectSetFieldSpecInspector) || (nodeInspector is ObjectFieldSpecInspector))
                        nodeInspector = ((NodeInspector) nodeInspector.Node.appInfo).actualNodeInspector;
                    if (!(nodeInspector is ObjectClassDefnInspector))
                    {
                        Console.Error.WriteLine ($"ILLEGAL DEFINED SYNTAX NODE INSPECTOR:");
                        Console.Error.WriteLine ($"                                 NODE: {p_DefinedSyntax.Emit (-1)}");
                        Console.Error.WriteLine ($"                            INSPECTOR: {nodeInspector.GetType ().FullName}");
                        break;
                    }

                    objectClassDefnInspector = (ObjectClassDefnInspector) nodeInspector;

                    Asn.Parser.Object @object = (Asn.Parser.Object) p_DefinedSyntax.parent.parent;

                    nodeInspectors.Push (objectClassDefnInspector);
                    string text = (p_DefinedSyntax.m_DefinedSyntaxToken_set != null) ? p_DefinedSyntax.m_DefinedSyntaxToken_set.Emit (-1) : "";
                    string form = $"{{{DefinedToDefaultSyntax (objectClassDefnInspector, $" {text} ")}}}";
                    uint step = ++objStep;
                    Console.WriteLine ($"BEFORE OBJECT EXPANSION {step}");
                    Console.WriteLine ($"OBJECT DEFINED SYNTAX = {p_DefinedSyntax.parent.parent.parent.Emit (-1)}");
                    Console.WriteLine ($"OBJECT DEFAULT SYNTAX = {form}");
                    AsnCompiler asnCompiler = new AsnCompiler ();
                    asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                    {
                        Console.Error.WriteLine ($"ERROR: CANNOT PARSE OBJECT DEFAULT SYNTAX:");
                        Console.Error.WriteLine ($"\t{form}");
                        return true;
                    };
                    if (asnCompiler.ParseString (form, new int [] { (int) AsnDeclarations.tokens.DefaultSyntax_token }) == 0)
                    {
                        parselist p_synlist = asnCompiler.parseList;
                        foreach (SyntaxTreeBase node in asnCompiler.parseList)
                        {
                            if (node == null)
                                continue;
                            node.reparent (null);
                            @object.m_ObjectDefn.change (((asn_features) node).m_DefaultSyntax);
                            Traverse (@object.m_ObjectDefn.m_DefaultSyntax);
                            //objectClassDefnInspector.Inspect (@object, this);
                            FieldSpecsDictionary fieldSpecs = objectClassDefnInspector.FieldSpecs;
                            SettingsDitionary fieldSettings = new SettingsDitionary ();
                            @object.m_ObjectDefn.m_DefaultSyntax.m_FieldSetting_set.Iterate (null, (fieldSet, appData) =>
                            {
                                FieldSetting setting = fieldSet.m_FieldSetting;
                                string fieldNme = '&' + setting.m_PrimitiveFieldName.Emit (-1).Substring (2);
                                if (!fieldSpecs.TryGetValue (fieldNme, out var fieldSpec))
                                    return null;    // unknown field name
                                if (fieldSettings.TryGetValue (fieldNme, out var settings))
                                    return null;    // multiplicated field name
                                fieldSettings [fieldNme] = setting.m_Setting;
                                return null;
                            });
                            if (fieldSettings.Count != fieldSpecs.Count)
                                ;
                            for (FieldSpecsDictionary.Enumerator enumerator = fieldSpecs.GetEnumerator (); enumerator.MoveNext ();)
                            {
                                string fieldName = enumerator.Current.Key;
                                if (fieldSettings.TryGetValue (fieldName, out var settings))
                                    continue;
                                FieldSpec fieldSpec = enumerator.Current.Value;
                                FieldSpecInspector fieldSpecInspector = fieldSpec.appInfo as FieldSpecInspector;
                                if (fieldSpecInspector == null)
                                    continue;
                                bool isOptional = fieldSpecInspector.isOptional ();
                                SyntaxTreeBase defaultNode = fieldSpecInspector.defaultNode ();
                                if (isOptional)
                                    fieldSettings [fieldName] = null;
                                else
                                    fieldSettings [fieldName] = fieldSpecInspector.CreateSetting (defaultNode);
                            }
                            if (fieldSettings.Count != fieldSpecs.Count)
                                ;
                        }
                    }
                    Console.WriteLine ($"AFTER OBJECT EXPANSION {step}");
                    Console.WriteLine ($"              OBJECT = {@object.Emit (-1)}");
                    nodeInspectors.Pop ();
                }
                break;
            }
            return false;
        }

        private bool AsnNodeInspector_FieldSetting_Event (SyntaxTreeCallbackReason reason, FieldSetting.production_kind kind, FieldSetting p_FieldSetting)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_FieldSetting.appInfo != null)
                        return false;
                    ObjectClassDefnInspector objectClassDefnInspector = (ObjectClassDefnInspector) nodeInspectors.Peek ();
                    FieldSpec fieldSpec = null;
                    if (!objectClassDefnInspector.FieldSpecs.TryGetValue ('&' + p_FieldSetting.m_PrimitiveFieldName.Emit (-1).Substring (2), out fieldSpec))
                    {
                        Console.Error.WriteLine ($"ERROR: CANNOT RETRIEVE FIELD SPECIFICATION FOR: {p_FieldSetting.Emit (-1)}");
                        return false;
                    }
                    p_FieldSetting.appInfo = new FieldSettingInspector (p_FieldSetting, fieldSpec);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((FieldSetting.__field_markers) p_FieldSetting.turn)
                    {
                        case FieldSetting.__field_markers.push_governor:
                        {
                            FieldSettingInspector inspector = p_FieldSetting.appInfo as FieldSettingInspector;
                            NodeInspector nodeInspector = (NodeInspector) inspector.fieldSpec.appInfo;
                            Setting setting = p_FieldSetting.m_Setting;
                            string settingText = setting.Emit (-1);

                            AsnCompiler asnCompiler = new AsnCompiler ();
                            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                            {
                                Console.Error.WriteLine ($"ERROR: CANNOT PARSE FIELD SETTING:");
                                Console.Error.WriteLine ($"\t{settingText}");
                                return true;
                            };

                            int result = -100;
                            if (nodeInspector is TypeFieldSpecInspector)
                            {
                                if ((Setting.production_kind) setting.kind != Setting.production_kind.g_Setting_1)
                                    result = asnCompiler.ParseString (settingText, new int [] { (int) AsnDeclarations.tokens.Type_token });
                            }
                            else if (nodeInspector is FixedTypeValueFieldSpecInspector)
                            {
                                if ((Setting.production_kind) setting.kind != Setting.production_kind.g_Setting_2)
                                    result = asnCompiler.ParseString (settingText, new int [] { (int) AsnDeclarations.tokens.Value_token });
                            }
                            else if (nodeInspector is VariableTypeValueFieldSpecInspector)
                            {
                                if ((Setting.production_kind) setting.kind != Setting.production_kind.g_Setting_2)
                                    result = asnCompiler.ParseString (settingText, new int [] { (int) AsnDeclarations.tokens.Value_token });
                            }
                            else if (nodeInspector is FixedTypeValueSetFieldSpecInspector)
                            {
                                if ((Setting.production_kind) setting.kind != Setting.production_kind.g_Setting_3)
                                    result = asnCompiler.ParseString (settingText, new int [] { (int) AsnDeclarations.tokens.ValueSet_token });
                            }
                            else if (nodeInspector is VariableTypeValueSetFieldSpecInspector)
                            {
                                if ((Setting.production_kind) setting.kind != Setting.production_kind.g_Setting_3)
                                    result = asnCompiler.ParseString (settingText, new int [] { (int) AsnDeclarations.tokens.ValueSet_token });
                            }
                            else if (nodeInspector is ObjectFieldSpecInspector)
                            {
                                if ((Setting.production_kind) setting.kind != Setting.production_kind.g_Setting_4)
                                    result = asnCompiler.ParseString (settingText, new int [] { (int) AsnDeclarations.tokens.Object_token });
                            }
                            else if (nodeInspector is ObjectSetFieldSpecInspector)
                            {
                                if ((Setting.production_kind) setting.kind != Setting.production_kind.g_Setting_5)
                                    result = asnCompiler.ParseString (settingText, new int [] { (int) AsnDeclarations.tokens.ObjectSet_token });
                            }
                            if (result == -100)
                            {
                                nodeInspectors.Push (nodeInspector);
                                Traverse (setting);
                                nodeInspectors.Pop ();
                                return false;
                            }

                            if (result == 0)
                            {
                                nodeInspectors.Push (nodeInspector);
                                parselist p_synlist = asnCompiler.parseList;
                                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                                {
                                    if (node == null)
                                        continue;
                                    node.reparent (null);
                                    if (nodeInspector is TypeFieldSpecInspector)
                                    {
                                        setting.change (((asn_features) node).m_Type as Asn.Parser.Type);
                                    }
                                    else if (nodeInspector is FixedTypeValueFieldSpecInspector)
                                    {
                                        setting.change (((asn_features) node).m_Value as Asn.Parser.Value);
                                    }
                                    else if (nodeInspector is VariableTypeValueFieldSpecInspector)
                                    {
                                        setting.change (((asn_features) node).m_Value as Asn.Parser.Value);
                                    }
                                    else if (nodeInspector is FixedTypeValueSetFieldSpecInspector)
                                    {
                                        setting.change (((asn_features) node).m_ValueSet as Asn.Parser.ValueSet);
                                    }
                                    else if (nodeInspector is VariableTypeValueSetFieldSpecInspector)
                                    {
                                        setting.change (((asn_features) node).m_ValueSet as Asn.Parser.ValueSet);
                                    }
                                    else if (nodeInspector is ObjectFieldSpecInspector)
                                    {
                                        setting.change (((asn_features) node).m_Object as Asn.Parser.Object);
                                    }
                                    else if (nodeInspector is ObjectSetFieldSpecInspector)
                                    {
                                        setting.change (((asn_features) node).m_ObjectSet as Asn.Parser.ObjectSet);
                                    }
                                    Traverse (setting);
                                }
                                nodeInspectors.Pop ();
                            }
                        }
                        return false;
                        case FieldSetting.__field_markers.pop_governor:
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectDefn_Event (SyntaxTreeCallbackReason reason, ObjectDefn.production_kind kind, ObjectDefn p_ObjectDefn)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    ObjectInspector objectInspector = p_ObjectDefn.parent.appInfo as ObjectInspector;
                    int? settingCount = objectInspector?.Settings?.Count;
                    NodeInspector inspector = nodeInspectors.Peek ();
                    if (p_ObjectDefn.parent.parent is ObjectAssignment)
                        inspector.Inspect (p_ObjectDefn.parent, this);
                    else
                        inspector.Inspect (p_ObjectDefn.parent, this);
                    if (settingCount != null)
                    {
                        if (settingCount.Value == objectInspector.Settings.Count)
                            ;
                    }
                    else
                        ;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_Object_Event (SyntaxTreeCallbackReason reason, Asn.Parser.Object.production_kind kind, Asn.Parser.Object p_Object)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    p_Object.appInfo = new ObjectInspector (p_Object, nodeInspectors.Peek ());
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    switch (kind)
                    {
                        case Asn.Parser.Object.production_kind.g_Object_1:
                            break;
                        case Asn.Parser.Object.production_kind.g_Object_2:
                            break;
                        case Asn.Parser.Object.production_kind.g_Object_3:
                            break;
                        case Asn.Parser.Object.production_kind.g_Object_4:
                            break;
                    }
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectSet_Event (SyntaxTreeCallbackReason reason, ObjectSet.production_kind kind, ObjectSet p_ObjectSet)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectSetSpec_Event (SyntaxTreeCallbackReason reason, ObjectSetSpec.production_kind kind, ObjectSetSpec p_ObjectSetSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    objSetConstraintStack.Push ((p_ObjectSetSpec.appInfo = new ObjectSetSpecInspector (p_ObjectSetSpec)) as ElementSetInspector);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    ElementSetInspector inspector = objSetConstraintStack.Pop ();
                    inspector.Inspect (p_ObjectSetSpec, this);
                    p_ObjectSetSpec.parent.appInfo = p_ObjectSetSpec.appInfo;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ParameterizedType_Event (SyntaxTreeCallbackReason reason, ParameterizedType.production_kind kind, ParameterizedType p_ParameterizedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    if (p_ParameterizedType.appInfo != null)
                        return false;
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    SimpleDefinedType simpleDefinedType = p_ParameterizedType.m_SimpleDefinedType;
                    AsnSymbol typeSymbol = null;
                    foreach (AsnSymbol contextSymbol in moduleStack)
                    {
                        if ((typeSymbol = (AsnSymbol) simpleDefinedType.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (typeSymbol == null)
                    {
                        Console.Error.WriteLine ($"ERROR: UNDEFINED PARAMETERIZED TYPE REFERENCE: file: {currentFile}, type reference: {simpleDefinedType.Emit (-1)}");
                        break;
                    }
                    ParameterGovernor parameterGovernor;
                    try
                    {
                        parameterGovernor = ParameterCollection [typeSymbol.DefiningReference];
                        if (parameterGovernor == null)
                        {
                            Console.Error.WriteLine ($"ERROR: UNDEFINED PARAMETERIZED TYPE GOVERNOR: file: {currentFile}, type reference: {currentModule.Name}.{typeSymbol.Name}");
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine ($"ERROR: TYPE REFERENCE IS DEFINED BUT IT IS NOT PARAMETERIZED: file: {currentFile}, type reference: {currentModule.Name}.{typeSymbol.Name}, exception: {e.Message}");
                        break;
                    }
                    ParameterTable parameterTable = CreateParameterTable (p_ParameterizedType.m_ActualParameterList.m_ActualParameter_set, parameterGovernor.Parameters);
                    if (!parameterGovernor.Resolve (p_ParameterizedType, typeSymbol, currentModule, parameterTable))
                        break;
                    uint step = ++parStep;
                    Console.WriteLine ($"BEFORE PARAMETERIZATION {step}: {p_ParameterizedType.Emit (-1)}");
                    if (parameterGovernor.ExtModuleContent != null)
                        Console.WriteLine ($"{parameterGovernor.ExtModuleContent}");
                    if (parameterGovernor.SrcModuleContent != null)
                        Console.WriteLine ($"{parameterGovernor.SrcModuleContent}");
                    Console.WriteLine ($"AFTER  PARAMETERIZATION {step}: {parameterGovernor.CategoryText}");
                    string [] moduleNames = new string [] { parameterGovernor.ExtModuleContent, parameterGovernor.SrcModuleContent };
                    List<SyntaxTreeBase> nodeList = new List<SyntaxTreeBase> ();
                    foreach (string moduleText in moduleNames)
                    {
                        if (moduleText == null)
                            continue;
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE PARAMETERIZED TYPE:");
                            Console.Error.WriteLine ($"\t{moduleText}");
                            return true;
                        };
                        if (asnCompiler.ParseString (moduleText, new int [] { (int) AsnDeclarations.tokens.ModuleDefinitions_token }) == 0)
                        {
                            parselist p_synlist = asnCompiler.parseList;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                if (node == null)
                                    continue;
                                node.reparent (null);
                                node.InvokeTraverse (asnSymbolCollector);
                                nodeList.Add (node);
                            }
                        }
                    }
                    foreach (SyntaxTreeBase node in nodeList)
                        node.InvokeTraverse (asnModuleDereferencer);
                    contextStack.Push (typeSymbol.DefiningReference.Context);
                    moduleStack.Push (currentModule = typeSymbol.DefiningReference.Context);
                    foreach (SyntaxTreeBase node in nodeList)
                        node.InvokeTraverse (this);
                    currentModule = moduleStack.Pop ();
                    contextStack.Pop ();
                    do
                    {
                        if (!(p_ParameterizedType.parent is DefinedType))
                        {
                            Console.Error.WriteLine ($"ERROR: INCORRECT PARENT TYPE FOR: {p_ParameterizedType.Emit (-1)}");
                            break;
                        }
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE DEFINED TYPE CATEGORY:");
                            Console.Error.WriteLine ($"\t{parameterGovernor.CategoryText}");
                            return true;
                        };
                        if (asnCompiler.ParseString (parameterGovernor.CategoryText, new int [] { (int) AsnDeclarations.tokens.DefinedType_token }) == 0)
                        {
                            parselist p_synlist = asnCompiler.parseList;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                if (node == null)
                                    continue;
                                node.reparent (null);
                                node.InvokeTraverse (asnSymbolCollector);
                                node.InvokeTraverse (asnModuleDereferencer);
                                parameterizedStack.Push (node);
                                node.InvokeTraverse (this);
                                parameterizedStack.Pop ();
                                string bpar = ((DefinedType) p_ParameterizedType.parent).Emit (-1);
                                ((DefinedType) p_ParameterizedType.parent).change (((asn_features) node).m_DefinedType.m_ExternalTypeReference);
                                string apar = ((DefinedType) p_ParameterizedType.parent).Emit (-1);
                                ((DefinedType) p_ParameterizedType.parent).appInfo = ((asn_features) node).m_DefinedType.appInfo;
                                Console.WriteLine ($"RESULT PARAMETERIZATION OF TYPE");
                                if (node.appInfo != null)
                                    Console.WriteLine ($"   TYPE {step}: {((NodeInspector) (node.appInfo)).NodeType}");
                                Console.WriteLine ($"   NODE {step}: {node.Emit (-1)}");
                                Console.WriteLine ($" BEFORE {step}: {bpar}");
                                Console.WriteLine ($"  AFTER {step}: {apar}");
                            }
                            return false;
                        }
                    }
                    while (false);
                }
                break;
            }
            return true;

        }

        private bool AsnNodeInspector_ParameterizedValue_Event (SyntaxTreeCallbackReason reason, ParameterizedValue.production_kind kind, ParameterizedValue p_ParameterizedValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    SimpleDefinedValue simpleDefinedValue = p_ParameterizedValue.m_SimpleDefinedValue;
                    AsnSymbol valueSymbol = null;
                    foreach (AsnSymbol contextSymbol in moduleStack)
                    {
                        if ((valueSymbol = (AsnSymbol) simpleDefinedValue.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (valueSymbol == null)
                    {
                        Console.Error.WriteLine ($"ERROR: UNDEFINED PARAMETERIZED VALUE REFERENCE: file: {currentFile}, value reference: {simpleDefinedValue.Emit (-1)}");
                        break;
                    }
                    ParameterGovernor parameterGovernor;
                    try
                    {
                        parameterGovernor = ParameterCollection [valueSymbol.DefiningReference];
                        if (parameterGovernor == null)
                        {
                            Console.Error.WriteLine ($"ERROR: UNDEFINED PARAMETERIZED VALUE GOVERNOR: file: {currentFile}, value reference: {currentModule.Name}.{valueSymbol.Name}");
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine ($"ERROR: VALUE REFERENCE IS DEFINED BUT IT IS NOT PARAMETERIZED: file: {currentFile}, value reference: {currentModule.Name}.{valueSymbol.Name}, exception: {e.Message}");
                        break;
                    }
                    ParameterTable parameterTable = CreateParameterTable (p_ParameterizedValue.m_ActualParameterList.m_ActualParameter_set, parameterGovernor.Parameters);
                    if (!parameterGovernor.Resolve (p_ParameterizedValue, valueSymbol, currentModule, parameterTable))
                        break;
                    uint step = ++parStep;
                    Console.WriteLine ($"BEFORE PARAMETERIZATION {step}: {p_ParameterizedValue.Emit (-1)}");
                    if (parameterGovernor.ExtModuleContent != null)
                        Console.WriteLine ($"{parameterGovernor.ExtModuleContent}");
                    if (parameterGovernor.SrcModuleContent != null)
                        Console.WriteLine ($"{parameterGovernor.SrcModuleContent}");
                    Console.WriteLine ($"AFTER  PARAMETERIZATION {step}: {parameterGovernor.CategoryText}");
                    string [] moduleNames = new string [] { parameterGovernor.ExtModuleContent, parameterGovernor.SrcModuleContent };
                    List<SyntaxTreeBase> nodeList = new List<SyntaxTreeBase> ();
                    foreach (string moduleText in moduleNames)
                    {
                        if (moduleText == null)
                            continue;
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE PARAMETERIZED VALUE:");
                            Console.Error.WriteLine ($"\t{moduleText}");
                            return true;
                        };
                        if (asnCompiler.ParseString (moduleText, new int [] { (int) AsnDeclarations.tokens.ModuleDefinitions_token }) == 0)
                        {
                            parselist p_synlist = asnCompiler.parseList;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                if (node == null)
                                    continue;
                                node.reparent (null);
                                node.InvokeTraverse (asnSymbolCollector);
                                nodeList.Add (node);
                            }
                        }
                    }
                    foreach (SyntaxTreeBase node in nodeList)
                        node.InvokeTraverse (asnModuleDereferencer);
                    contextStack.Push (valueSymbol.DefiningReference.Context);
                    moduleStack.Push (currentModule = valueSymbol.DefiningReference.Context);
                    foreach (SyntaxTreeBase node in nodeList)
                        node.InvokeTraverse (this);
                    currentModule = moduleStack.Pop ();
                    contextStack.Pop ();
                    do
                    {
                        if (!(p_ParameterizedValue.parent is DefinedValue))
                        {
                            Console.Error.WriteLine ($"ERROR: INCORRECT PARENT TYPE FOR: {p_ParameterizedValue.Emit (-1)}");
                            break;
                        }
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE DEFINED VALUE CATEGORY:");
                            Console.Error.WriteLine ($"\t{parameterGovernor.CategoryText}");
                            return true;
                        };
                        if (asnCompiler.ParseString (parameterGovernor.CategoryText, new int [] { (int) AsnDeclarations.tokens.DefinedValue_token }) == 0)
                        {
                            parselist p_synlist = asnCompiler.parseList;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                if (node == null)
                                    continue;
                                node.reparent (null);
                                node.InvokeTraverse (asnSymbolCollector);
                                node.InvokeTraverse (asnModuleDereferencer);
                                parameterizedStack.Push (node);
                                node.InvokeTraverse (this);
                                parameterizedStack.Pop ();
                                string bpar = ((DefinedValue) p_ParameterizedValue.parent).Emit (-1);
                                ((DefinedValue) p_ParameterizedValue.parent).change (((asn_features) node).m_DefinedValue.m_ExternalValueReference);
                                string apar = ((DefinedValue) p_ParameterizedValue.parent).Emit (-1);
                                ((DefinedValue) p_ParameterizedValue.parent).appInfo = ((asn_features) node).m_DefinedValue.appInfo;
                                Console.WriteLine ($"RESULT PARAMETERIZATION OF VALUE");
                                if (node.appInfo != null)
                                    Console.WriteLine ($"   TYPE {step}: {((NodeInspector) (node.appInfo)).NodeType}");
                                Console.WriteLine ($"   NODE {step}: {node.Emit (-1)}");
                                Console.WriteLine ($" BEFORE {step}: {bpar}");
                                Console.WriteLine ($"  AFTER {step}: {apar}");
                            }
                            return false;
                        }
                    }
                    while (false);
                }
                break;
            }
            return true;

        }

        private bool AsnNodeInspector_ParameterizedValueSetType_Event (SyntaxTreeCallbackReason reason, ParameterizedValueSetType.production_kind kind, ParameterizedValueSetType p_ParameterizedValueSetType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    SimpleDefinedType simpleDefinedType = p_ParameterizedValueSetType.m_SimpleDefinedType;
                    AsnSymbol valueSetTypeSymbol = null;
                    foreach (AsnSymbol contextSymbol in moduleStack)
                    {
                        if ((valueSetTypeSymbol = (AsnSymbol) simpleDefinedType.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (valueSetTypeSymbol == null)
                    {
                        Console.Error.WriteLine ($"ERROR: UNDEFINED PARAMETERIZED VALUE SET REFERENCE: file: {currentFile}, value set reference: {simpleDefinedType.Emit (-1)}");
                        break;
                    }
                    ParameterGovernor parameterGovernor;
                    try
                    {
                        parameterGovernor = ParameterCollection [valueSetTypeSymbol.DefiningReference];
                        if (parameterGovernor == null)
                        {
                            Console.Error.WriteLine ($"ERROR: UNDEFINED PARAMETERIZED TYPE GOVERNOR: file: {currentFile}, type reference: {currentModule.Name}.{valueSetTypeSymbol.Name}");
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine ($"ERROR: VALUE SET REFERENCE IS DEFINED BUT IT IS NOT PARAMETERIZED: file: {currentFile}, type reference: {currentModule.Name}.{valueSetTypeSymbol.Name}, exception: {e.Message}");
                        break;
                    }
                    ParameterTable parameterTable = CreateParameterTable (p_ParameterizedValueSetType.m_ActualParameterList.m_ActualParameter_set, parameterGovernor.Parameters);
                    if (!parameterGovernor.Resolve (p_ParameterizedValueSetType, valueSetTypeSymbol, currentModule, parameterTable))
                        break;
                    uint step = ++parStep;
                    Console.WriteLine ($"BEFORE PARAMETERIZATION {step}: {p_ParameterizedValueSetType.Emit (-1)}");
                    if (parameterGovernor.ExtModuleContent != null)
                        Console.WriteLine ($"{parameterGovernor.ExtModuleContent}");
                    if (parameterGovernor.SrcModuleContent != null)
                        Console.WriteLine ($"{parameterGovernor.SrcModuleContent}");
                    Console.WriteLine ($"AFTER  PARAMETERIZATION {step}: {parameterGovernor.CategoryText}");
                    string [] moduleNames = new string [] { parameterGovernor.ExtModuleContent, parameterGovernor.SrcModuleContent };
                    List<SyntaxTreeBase> nodeList = new List<SyntaxTreeBase> ();
                    foreach (string moduleText in moduleNames)
                    {
                        if (moduleText == null)
                            continue;
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE PARAMETERIZED VALUE SET:");
                            Console.Error.WriteLine ($"\t{moduleText}");
                            return true;
                        };
                        if (asnCompiler.ParseString (moduleText, new int [] { (int) AsnDeclarations.tokens.ModuleDefinitions_token }) == 0)
                        {
                            parselist p_synlist = asnCompiler.parseList;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                if (node == null)
                                    continue;
                                node.reparent (null);
                                node.InvokeTraverse (asnSymbolCollector);
                                nodeList.Add (node);
                            }
                        }
                    }
                    foreach (SyntaxTreeBase node in nodeList)
                        node.InvokeTraverse (asnModuleDereferencer);
                    contextStack.Push (valueSetTypeSymbol.DefiningReference.Context);
                    moduleStack.Push (currentModule = valueSetTypeSymbol.DefiningReference.Context);
                    foreach (SyntaxTreeBase node in nodeList)
                        node.InvokeTraverse (this);
                    currentModule = moduleStack.Pop ();
                    contextStack.Pop ();
                    do
                    {
                        if (!(p_ParameterizedValueSetType.parent is DefinedType))
                        {
                            Console.Error.WriteLine ($"ERROR: INCORRECT PARENT TYPE FOR: {p_ParameterizedValueSetType.Emit (-1)}");
                            break;
                        }
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE DEFINED TYPE CATEGORY:");
                            Console.Error.WriteLine ($"\t{parameterGovernor.CategoryText}");
                            return true;
                        };
                        if (asnCompiler.ParseString (parameterGovernor.CategoryText, new int [] { (int) AsnDeclarations.tokens.DefinedType_token }) == 0)
                        {
                            parselist p_synlist = asnCompiler.parseList;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                if (node == null)
                                    continue;
                                node.reparent (null);
                                node.InvokeTraverse (asnSymbolCollector);
                                node.InvokeTraverse (asnModuleDereferencer);
                                parameterizedStack.Push (node);
                                node.InvokeTraverse (this);
                                parameterizedStack.Pop ();
                                string bpar = ((DefinedType) p_ParameterizedValueSetType.parent).Emit (-1);
                                ((DefinedType) p_ParameterizedValueSetType.parent).change (((asn_features) node).m_DefinedType.m_ExternalTypeReference);
                                string apar = ((DefinedType) p_ParameterizedValueSetType.parent).Emit (-1);
                                ((DefinedType) p_ParameterizedValueSetType.parent).appInfo = ((asn_features) node).m_DefinedType.appInfo;
                                Console.WriteLine ($"RESULT PARAMETERIZATION OF VALUE SET TYPE");
                                if (node.appInfo != null)
                                    Console.WriteLine ($"   TYPE {step}: {((NodeInspector) (node.appInfo)).NodeType}");
                                Console.WriteLine ($"   NODE {step}: {node.Emit (-1)}");
                                Console.WriteLine ($" BEFORE {step}: {bpar}");
                                Console.WriteLine ($"  AFTER {step}: {apar}");
                            }
                            return false;
                        }
                    }
                    while (false);
                }
                break;
            }
            return true;

        }

        private bool AsnNodeInspector_ParameterizedObjectClass_Event (SyntaxTreeCallbackReason reason, ParameterizedObjectClass.production_kind kind, ParameterizedObjectClass p_ParameterizedObjectClass)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    DefinedObjectClass definedObjectClass = p_ParameterizedObjectClass.m_DefinedObjectClass;
                    AsnSymbol objectClassSymbol = null;
                    foreach (AsnSymbol contextSymbol in moduleStack)
                    {
                        if ((objectClassSymbol = (AsnSymbol) definedObjectClass.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (objectClassSymbol == null)
                    {
                        Console.Error.WriteLine ($"ERROR: UNDEFINED PARAMETERIZED OBJECT CLASS REFERENCE: file: {currentFile}, object class reference: {definedObjectClass.Emit (-1)}");
                        break;
                    }
                    ParameterGovernor parameterGovernor;
                    try
                    {
                        parameterGovernor = ParameterCollection [objectClassSymbol.DefiningReference];
                        if (parameterGovernor == null)
                        {
                            Console.Error.WriteLine ($"ERROR: UNDEFINED PARAMETERIZED OBJECT CLASS GOVERNOR: file: {currentFile}, object class reference: {currentModule.Name}.{objectClassSymbol.Name}");
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine ($"ERROR: OBJECT CLASS REFERENCE IS DEFINED BUT IT IS NOT PARAMETERIZED: file: {currentFile}, object class reference: {currentModule.Name}.{objectClassSymbol.Name}, exception: {e.Message}");
                        break;
                    }
                    ParameterTable parameterTable = CreateParameterTable (p_ParameterizedObjectClass.m_ActualParameterList.m_ActualParameter_set, parameterGovernor.Parameters);
                    if (!parameterGovernor.Resolve (p_ParameterizedObjectClass, objectClassSymbol, currentModule, parameterTable))
                        break;
                    uint step = ++parStep;
                    Console.WriteLine ($"BEFORE PARAMETERIZATION {step}: {p_ParameterizedObjectClass.Emit (-1)}");
                    if (parameterGovernor.ExtModuleContent != null)
                        Console.WriteLine ($"{parameterGovernor.ExtModuleContent}");
                    if (parameterGovernor.SrcModuleContent != null)
                        Console.WriteLine ($"{parameterGovernor.SrcModuleContent}");
                    Console.WriteLine ($"AFTER  PARAMETERIZATION {step}: {parameterGovernor.CategoryText}");
                    string [] moduleNames = new string [] { parameterGovernor.ExtModuleContent, parameterGovernor.SrcModuleContent };
                    List<SyntaxTreeBase> nodeList = new List<SyntaxTreeBase> ();
                    foreach (string moduleText in moduleNames)
                    {
                        if (moduleText == null)
                            continue;
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE PARAMETERIZED OBJECT CLASS:");
                            Console.Error.WriteLine ($"\t{moduleText}");
                            return true;
                        };
                        if (asnCompiler.ParseString (moduleText, new int [] { (int) AsnDeclarations.tokens.ModuleDefinitions_token }) == 0)
                        {
                            parselist p_synlist = asnCompiler.parseList;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                if (node == null)
                                    continue;
                                node.reparent (null);
                                node.InvokeTraverse (asnSymbolCollector);
                                nodeList.Add (node);
                            }
                        }
                    }
                    foreach (SyntaxTreeBase node in nodeList)
                        node.InvokeTraverse (asnModuleDereferencer);
                    contextStack.Push (objectClassSymbol.DefiningReference.Context);
                    moduleStack.Push (currentModule = objectClassSymbol.DefiningReference.Context);
                    foreach (SyntaxTreeBase node in nodeList)
                        node.InvokeTraverse (this);
                    currentModule = moduleStack.Pop ();
                    contextStack.Pop ();
                    do
                    {
                        if (!(p_ParameterizedObjectClass.parent is ObjectClass))
                        {
                            Console.Error.WriteLine ($"ERROR: INCORRECT PARENT TYPE FOR: {p_ParameterizedObjectClass.Emit (-1)}");
                            break;
                        }
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE OBJECT CLASS CATEGORY:");
                            Console.Error.WriteLine ($"\t{parameterGovernor.CategoryText}");
                            return true;
                        };
                        if (asnCompiler.ParseString (parameterGovernor.CategoryText, new int [] { (int) AsnDeclarations.tokens.ObjectClass_token }) == 0)
                        {
                            parselist p_synlist = asnCompiler.parseList;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                if (node == null)
                                    continue;
                                node.reparent (null);
                                node.InvokeTraverse (asnSymbolCollector);
                                node.InvokeTraverse (asnModuleDereferencer);
                                parameterizedStack.Push (node);
                                node.InvokeTraverse (this);
                                parameterizedStack.Pop ();
                                string bpar = ((ObjectClass) p_ParameterizedObjectClass.parent).Emit (-1);
                                ((ObjectClass) p_ParameterizedObjectClass.parent).change (((asn_features) node).m_ObjectClass.m_DefinedObjectClass);
                                string apar = ((ObjectClass) p_ParameterizedObjectClass.parent).Emit (-1);
                                ((ObjectClass) p_ParameterizedObjectClass.parent).appInfo = ((asn_features) node).m_ObjectClass.appInfo;
                                Console.WriteLine ($"RESULT PARAMETERIZATION OF OBJECT CLASS");
                                if (node.appInfo != null)
                                    Console.WriteLine ($"   TYPE {step}: {((NodeInspector) (node.appInfo)).NodeType}");
                                Console.WriteLine ($"   NODE {step}: {node.Emit (-1)}");
                                Console.WriteLine ($" BEFORE {step}: {bpar}");
                                Console.WriteLine ($"  AFTER {step}: {apar}");
                            }
                            return false;
                        }
                    }
                    while (false);
                }
                break;
            }
            return true;

        }

        private bool AsnNodeInspector_ParameterizedObjectSet_Event (SyntaxTreeCallbackReason reason, ParameterizedObjectSet.production_kind kind, ParameterizedObjectSet p_ParameterizedObjectSet)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    DefinedObjectSet definedObjectSet = p_ParameterizedObjectSet.m_DefinedObjectSet;
                    AsnSymbol objectSetSymbol = null;
                    foreach (AsnSymbol contextSymbol in moduleStack)
                    {
                        if ((objectSetSymbol = (AsnSymbol) definedObjectSet.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (objectSetSymbol == null)
                    {
                        Console.Error.WriteLine ($"ERROR: UNDEFINED PARAMETERIZED OBJECT SET REFERENCE: file: {currentFile}, object set reference: {definedObjectSet.Emit (-1)}");
                        break;
                    }
                    ParameterGovernor parameterGovernor;
                    try
                    {
                        parameterGovernor = ParameterCollection [objectSetSymbol.DefiningReference];
                        if (parameterGovernor == null)
                        {
                            Console.Error.WriteLine ($"ERROR: UNDEFINED PARAMETERIZED OBJECT SET GOVERNOR: file: {currentFile}, object set reference: {currentModule.Name}.{objectSetSymbol.Name}");
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine ($"ERROR: OBJECT SET REFERENCE IS DEFINED BUT IT IS NOT PARAMETERIZED: file: {currentFile}, object set reference: {currentModule.Name}.{objectSetSymbol.Name}, exception: {e.Message}");
                        break;
                    }
                    ParameterTable parameterTable = CreateParameterTable (p_ParameterizedObjectSet.m_ActualParameterList.m_ActualParameter_set, parameterGovernor.Parameters);
                    if (!parameterGovernor.Resolve (p_ParameterizedObjectSet, objectSetSymbol, currentModule, parameterTable))
                        break;
                    uint step = ++parStep;
                    Console.WriteLine ($"BEFORE PARAMETERIZATION {step}: {p_ParameterizedObjectSet.Emit (-1)}");
                    if (parameterGovernor.ExtModuleContent != null)
                        Console.WriteLine ($"{parameterGovernor.ExtModuleContent}");
                    if (parameterGovernor.SrcModuleContent != null)
                        Console.WriteLine ($"{parameterGovernor.SrcModuleContent}");
                    Console.WriteLine ($"AFTER  PARAMETERIZATION {step}: {parameterGovernor.CategoryText}");
                    string [] moduleNames = new string [] { parameterGovernor.ExtModuleContent, parameterGovernor.SrcModuleContent };
                    List<SyntaxTreeBase> nodeList = new List<SyntaxTreeBase> ();
                    foreach (string moduleText in moduleNames)
                    {
                        if (moduleText == null)
                            continue;
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE PARAMETERIZED OBJECT SET:");
                            Console.Error.WriteLine ($"\t{moduleText}");
                            return true;
                        };
                        if (asnCompiler.ParseString (moduleText, new int [] { (int) AsnDeclarations.tokens.ModuleDefinitions_token }) == 0)
                        {
                            parselist p_synlist = asnCompiler.parseList;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                if (node == null)
                                    continue;
                                node.reparent (null);
                                node.InvokeTraverse (asnSymbolCollector);
                                nodeList.Add (node);
                            }
                        }
                    }
                    foreach (SyntaxTreeBase node in nodeList)
                        node.InvokeTraverse (asnModuleDereferencer);
                    contextStack.Push (objectSetSymbol.DefiningReference.Context);
                    moduleStack.Push (currentModule = objectSetSymbol.DefiningReference.Context);
                    foreach (SyntaxTreeBase node in nodeList)
                        node.InvokeTraverse (this);
                    currentModule = moduleStack.Pop ();
                    contextStack.Pop ();
                    do
                    {
                        if (!(p_ParameterizedObjectSet.parent is ObjectSetElements))
                        {
                            Console.Error.WriteLine ($"ERROR: INCORRECT PARENT TYPE FOR: {p_ParameterizedObjectSet.Emit (-1)}");
                            break;
                        }
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE OBJECT SET ELEMENTS CATEGORY:");
                            Console.Error.WriteLine ($"\t{parameterGovernor.CategoryText}");
                            return true;
                        };
                        if (asnCompiler.ParseString (parameterGovernor.CategoryText, new int [] { (int) AsnDeclarations.tokens.ObjectSetElements_token }) == 0)
                        {
                            parselist p_synlist = asnCompiler.parseList;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                if (node == null)
                                    continue;
                                node.reparent (null);
                                node.InvokeTraverse (asnSymbolCollector);
                                node.InvokeTraverse (asnModuleDereferencer);
                                parameterizedStack.Push (node);
                                node.InvokeTraverse (this);
                                parameterizedStack.Pop ();
                                string bpar = ((ObjectSetElements) p_ParameterizedObjectSet.parent).Emit (-1);
                                ((ObjectSetElements) p_ParameterizedObjectSet.parent).change (((asn_features) node).m_ObjectSetElements.m_DefinedObjectSet);
                                string apar = ((ObjectSetElements) p_ParameterizedObjectSet.parent).Emit (-1);
                                ((ObjectSetElements) p_ParameterizedObjectSet.parent).appInfo = ((asn_features) node).m_ObjectSetElements.appInfo;
                                Console.WriteLine ($"RESULT PARAMETERIZATION OF OBJECT SET");
                                if (node.appInfo != null)
                                    Console.WriteLine ($"   TYPE {step}: {((NodeInspector) (node.appInfo)).NodeType}");
                                Console.WriteLine ($"   NODE {step}: {node.Emit (-1)}");
                                Console.WriteLine ($" BEFORE {step}: {bpar}");
                                Console.WriteLine ($"  AFTER {step}: {apar}");
                            }
                            return false;
                        }
                    }
                    while (false);
                }
                break;
            }
            return true;

        }

        private bool AsnNodeInspector_ParameterizedObject_Event (SyntaxTreeCallbackReason reason, ParameterizedObject.production_kind kind, ParameterizedObject p_ParameterizedObject)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    DefinedObject definedObject = p_ParameterizedObject.m_DefinedObject;
                    AsnSymbol objectSymbol = null;
                    foreach (AsnSymbol contextSymbol in moduleStack)
                    {
                        if ((objectSymbol = (AsnSymbol) definedObject.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (objectSymbol == null)
                    {
                        Console.Error.WriteLine ($"ERROR: UNDEFINED PARAMETERIZED OBJECT REFERENCE: file: {currentFile}, object reference: {definedObject.Emit (-1)}");
                        break;
                    }
                    ParameterGovernor parameterGovernor;
                    try
                    {
                        parameterGovernor = ParameterCollection [objectSymbol.DefiningReference];
                        if (parameterGovernor == null)
                        {
                            Console.Error.WriteLine ($"ERROR: UNDEFINED PARAMETERIZED OBJECT GOVERNOR: file: {currentFile}, object reference: {currentModule.Name}.{objectSymbol.Name}");
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine ($"ERROR: OBJECT REFERENCE IS DEFINED BUT IT IS NOT PARAMETERIZED: file: {currentFile}, object reference: {currentModule.Name}.{objectSymbol.Name}, exception: {e.Message}");
                        break;
                    }
                    ParameterTable parameterTable = CreateParameterTable (p_ParameterizedObject.m_ActualParameterList.m_ActualParameter_set, parameterGovernor.Parameters);
                    if (!parameterGovernor.Resolve (p_ParameterizedObject, objectSymbol, currentModule, parameterTable))
                        break;
                    uint step = ++parStep;
                    Console.WriteLine ($"BEFORE PARAMETERIZATION {step}: {p_ParameterizedObject.Emit (-1)}");
                    if (parameterGovernor.ExtModuleContent != null)
                        Console.WriteLine ($"{parameterGovernor.ExtModuleContent}");
                    if (parameterGovernor.SrcModuleContent != null)
                        Console.WriteLine ($"{parameterGovernor.SrcModuleContent}");
                    Console.WriteLine ($"AFTER  PARAMETERIZATION {step}: {parameterGovernor.CategoryText}");
                    string [] moduleNames = new string [] { parameterGovernor.ExtModuleContent, parameterGovernor.SrcModuleContent };
                    List<SyntaxTreeBase> nodeList = new List<SyntaxTreeBase> ();
                    foreach (string moduleText in moduleNames)
                    {
                        if (moduleText == null)
                            continue;
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE PARAMETERIZED OBJECT:");
                            Console.Error.WriteLine ($"\t{moduleText}");
                            return true;
                        };
                        if (asnCompiler.ParseString (moduleText, new int [] { (int) AsnDeclarations.tokens.ModuleDefinitions_token }) == 0)
                        {
                            parselist p_synlist = asnCompiler.parseList;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                if (node == null)
                                    continue;
                                node.reparent (null);
                                node.InvokeTraverse (asnSymbolCollector);
                                nodeList.Add (node);
                            }
                        }
                    }
                    foreach (SyntaxTreeBase node in nodeList)
                        node.InvokeTraverse (asnModuleDereferencer);
                    contextStack.Push (objectSymbol.DefiningReference.Context);
                    moduleStack.Push (currentModule = objectSymbol.DefiningReference.Context);
                    foreach (SyntaxTreeBase node in nodeList)
                        node.InvokeTraverse (this);
                    currentModule = moduleStack.Pop ();
                    contextStack.Pop ();
                    do
                    {
                        if (!(p_ParameterizedObject.parent is Asn.Parser.Object))
                        {
                            Console.Error.WriteLine ($"ERROR: INCORRECT PARENT TYPE FOR: {p_ParameterizedObject.Emit (-1)}");
                            break;
                        }
                        AsnCompiler asnCompiler = new AsnCompiler ();
                        asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
                        {
                            Console.Error.WriteLine ($"ERROR: CANNOT PARSE OBJECT CATEGORY:");
                            Console.Error.WriteLine ($"\t{parameterGovernor.CategoryText}");
                            return true;
                        };
                        if (asnCompiler.ParseString (parameterGovernor.CategoryText, new int [] { (int) AsnDeclarations.tokens.Object_token }) == 0)
                        {
                            parselist p_synlist = asnCompiler.parseList;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                if (node == null)
                                    continue;
                                node.reparent (null);
                                node.InvokeTraverse (asnSymbolCollector);
                                node.InvokeTraverse (asnModuleDereferencer);
                                parameterizedStack.Push (node);
                                node.InvokeTraverse (this);
                                parameterizedStack.Pop ();
                                string bpar = ((Asn.Parser.Object) p_ParameterizedObject.parent).Emit (-1);
                                ((Asn.Parser.Object) p_ParameterizedObject.parent).change (((asn_features) node).m_Object.m_DefinedObject);
                                string apar = ((Asn.Parser.Object) p_ParameterizedObject.parent).Emit (-1);
                                ((Asn.Parser.Object) p_ParameterizedObject.parent).appInfo = ((asn_features) node).m_Object.appInfo;
                                Console.WriteLine ($"RESULT PARAMETERIZATION OF OBJECT");
                                if (node.appInfo != null)
                                    Console.WriteLine ($"   TYPE {step}: {((NodeInspector) (node.appInfo)).NodeType}");
                                Console.WriteLine ($"   NODE {step}: {node.Emit (-1)}");
                                Console.WriteLine ($" BEFORE {step}: {bpar}");
                                Console.WriteLine ($"  AFTER {step}: {apar}");
                            }
                            return false;
                        }
                    }
                    while (false);
                }
                break;
            }
            return true;

        }

        private bool AsnNodeInspector_ReferencedObjects_Event (SyntaxTreeCallbackReason reason, ReferencedObjects.production_kind kind, ReferencedObjects p_ReferencedObjects)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    NodeInspector nodeInspector = null;
                    switch (kind)
                    {
                        case ReferencedObjects.production_kind.g_ReferencedObjects_1:
                        {
                            DefinedObject definedObject = p_ReferencedObjects.m_DefinedObject;
                            nodeInspector = definedObject.appInfo as NodeInspector;
                        }
                        break;
                        case ReferencedObjects.production_kind.g_ReferencedObjects_2:
                            break;
                        case ReferencedObjects.production_kind.g_ReferencedObjects_3:
                        {
                            DefinedObjectSet definedObjectSet = p_ReferencedObjects.m_DefinedObjectSet;
                            nodeInspector = definedObjectSet.appInfo as NodeInspector;
                        }
                        break;
                        case ReferencedObjects.production_kind.g_ReferencedObjects_4:
                            break;
                    }
                    if (nodeInspector == null)
                        break;
                    ObjectClassDefnInspector objectClassDefnInspector = nodeInspector.actualNodeInspector as ObjectClassDefnInspector;
                    if (objectClassDefnInspector == null)
                    {
                        Console.Error.WriteLine ($"ERROR: NODE INSPECTOR IS NOT ObjectClassDefnInspector, REFERENCED OBJECT {p_ReferencedObjects.Emit (-1)}");
                        break;
                    }
                    p_ReferencedObjects.appInfo = objectClassDefnInspector;
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ValueFromObject_Event (SyntaxTreeCallbackReason reason, ValueFromObject.production_kind kind, ValueFromObject p_ValueFromObject)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_ValueFromObject.appInfo != null)
                        return false;
                    p_ValueFromObject.appInfo = new ValueFromObjectInspector (p_ValueFromObject);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((ValueFromObject.__p1_markers) p_ValueFromObject.turn)
                    {
                        case ValueFromObject.__p1_markers.m1:
                        {
                            ObjectClassDefnInspector inspector = (ObjectClassDefnInspector) p_ValueFromObject.m_ReferencedObjects.appInfo;
                            nodeInspectors.Push (inspector);
                        }
                        break;
                        case ValueFromObject.__p1_markers.m2:
                            nodeInspectors.Pop ();
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    FieldName fieldName = p_ValueFromObject.m_FieldName;
                    NodeInspector inspector = fieldName.appInfo as NodeInspector;
                    switch (inspector.NodeType)
                    {
                        case NodeType.Undefined:
                            break;
                        case NodeType.TypeNode:
                            break;
                        case NodeType.ClassNode:
                            break;
                    }

                    ((p_ValueFromObject.parent.appInfo = p_ValueFromObject.appInfo) as ObjectNodeInspector).objectNode =
                        GenerateInformationFromObjects (p_ValueFromObject.m_ReferencedObjects, p_ValueFromObject.m_FieldName);

                    AsnSymbol objectReference = null;
                    foreach (AsnSymbol contextSymbol in contextStack)
                    {
                        if ((objectReference = p_ValueFromObject.m_ReferencedObjects.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (objectReference == null)
                    {
                        Console.Error.WriteLine ($"ERROR: UNDEFINED OBJECT REFERENCE {p_ValueFromObject.m_ReferencedObjects.Emit (-1)}");
                        break;
                    }
                    objectReference = objectReference.DefiningReference;
                    if (!(objectReference.Node is ObjectAssignment))
                        break;
                    NodeInspector nodeInspector = ((NodeInspector) objectReference.Node.appInfo).actualNodeInspector;
                    if (nodeInspector != p_ValueFromObject.m_ReferencedObjects.appInfo as NodeInspector)
                        break;
                    if (!(nodeInspector is ObjectClassDefnInspector))
                        break;
                    if ((((NodeInspector) p_ValueFromObject.appInfo).actualNodeInspector =
                        nodeInspector =
                        (NodeInspector) p_ValueFromObject.m_FieldName.appInfo) == null)
                        break;
                    Console.WriteLine ($"VALUE FROM OBJECT: {p_ValueFromObject.Emit (-1)}");
                    Console.WriteLine ($"   NODE INSPECTOR: {nodeInspector.Node.Emit (-1)}");
                    Console.WriteLine ($"1  INSPECTOR TYPE: {nodeInspector.Node.GetType ()}");
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ValueSetFromObjects_Event (SyntaxTreeCallbackReason reason, ValueSetFromObjects.production_kind kind, ValueSetFromObjects p_ValueSetFromObjects)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_ValueSetFromObjects.appInfo != null)
                        return false;
                    p_ValueSetFromObjects.appInfo = new ValueSetFromObjectsInspector (p_ValueSetFromObjects);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((ValueSetFromObjects.__p1_markers) p_ValueSetFromObjects.turn)
                    {
                        case ValueSetFromObjects.__p1_markers.m1:
                        {
                            ObjectClassDefnInspector inspector = (ObjectClassDefnInspector) p_ValueSetFromObjects.m_ReferencedObjects.appInfo;
                            nodeInspectors.Push (inspector);
                        }
                        break;
                        case ValueSetFromObjects.__p1_markers.m2:
                            nodeInspectors.Pop ();
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    FieldName fieldName = p_ValueSetFromObjects.m_FieldName;
                    NodeInspector inspector = fieldName.appInfo as NodeInspector;
                    switch (inspector.NodeType)
                    {
                        case NodeType.Undefined:
                            break;
                        case NodeType.TypeNode:
                            break;
                        case NodeType.ClassNode:
                            break;
                    }

                    ((p_ValueSetFromObjects.parent.appInfo = p_ValueSetFromObjects.appInfo) as ObjectNodeInspector).objectNode =
                        GenerateInformationFromObjects (p_ValueSetFromObjects.m_ReferencedObjects, p_ValueSetFromObjects.m_FieldName);

                    AsnSymbol objectReference = null;
                    foreach (AsnSymbol contextSymbol in contextStack)
                    {
                        if ((objectReference = p_ValueSetFromObjects.m_ReferencedObjects.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (objectReference == null)
                        break;
                    objectReference = objectReference.DefiningReference;
                    if (!(objectReference.Node is ObjectAssignment))
                        break;
                    NodeInspector nodeInspector = ((NodeInspector) objectReference.Node.appInfo).actualNodeInspector;
                    if (nodeInspector != p_ValueSetFromObjects.m_ReferencedObjects.appInfo as NodeInspector)
                        break;
                    if (!(nodeInspector is ObjectClassDefnInspector))
                        break;
                    if ((((NodeInspector) p_ValueSetFromObjects.appInfo).actualNodeInspector =
                        nodeInspector =
                        (NodeInspector) p_ValueSetFromObjects.m_FieldName.appInfo) == null)
                        break;
                    Console.WriteLine ($"VALUE SET FROM OBJECT: {p_ValueSetFromObjects.Emit (-1)}");
                    Console.WriteLine ($"       NODE INSPECTOR: {nodeInspector.Node.Emit (-1)}");
                    Console.WriteLine ($"2      INSPECTOR TYPE: {nodeInspector.Node.GetType ()}");
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_TypeFromObject_Event (SyntaxTreeCallbackReason reason, TypeFromObject.production_kind kind, TypeFromObject p_TypeFromObject)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_TypeFromObject.appInfo != null)
                        return false;
                    p_TypeFromObject.appInfo = new TypeFromObjectInspector (p_TypeFromObject);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((TypeFromObject.__p1_markers) p_TypeFromObject.turn)
                    {
                        case TypeFromObject.__p1_markers.m1:
                        {
                            ObjectClassDefnInspector inspector = (ObjectClassDefnInspector) p_TypeFromObject.m_ReferencedObjects.appInfo;
                            nodeInspectors.Push (inspector);
                        }
                        break;
                        case TypeFromObject.__p1_markers.m2:
                            nodeInspectors.Pop ();
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    FieldName fieldName = p_TypeFromObject.m_FieldName;
                    NodeInspector inspector = fieldName.appInfo as NodeInspector;
                    switch (inspector.NodeType)
                    {
                        case NodeType.Undefined:
                            break;
                        case NodeType.TypeNode:
                            break;
                        case NodeType.ClassNode:
                            break;
                    }

                    ((p_TypeFromObject.parent.appInfo = p_TypeFromObject.appInfo) as ObjectNodeInspector).objectNode =
                        GenerateInformationFromObjects (p_TypeFromObject.m_ReferencedObjects, p_TypeFromObject.m_FieldName);

                    AsnSymbol objectReference = null;
                    foreach (AsnSymbol contextSymbol in contextStack)
                    {
                        if ((objectReference = p_TypeFromObject.m_ReferencedObjects.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (objectReference == null)
                        break;
                    objectReference = objectReference.DefiningReference;
                    if (!(objectReference.Node is ObjectAssignment))
                        break;
                    NodeInspector nodeInspector = ((NodeInspector) objectReference.Node.appInfo).actualNodeInspector;
                    if (nodeInspector != p_TypeFromObject.m_ReferencedObjects.appInfo as NodeInspector)
                        break;
                    if (!(nodeInspector is ObjectClassDefnInspector))
                        break;
                    if ((((NodeInspector) p_TypeFromObject.appInfo).actualNodeInspector =
                        nodeInspector =
                        (NodeInspector) p_TypeFromObject.m_FieldName.appInfo) == null)
                        break;
                    Console.WriteLine ($"TYPE FROM OBJECT: {p_TypeFromObject.Emit (-1)}");
                    Console.WriteLine ($"  NODE INSPECTOR: {nodeInspector.Node.Emit (-1)}");
                    Console.WriteLine ($"3 INSPECTOR TYPE: {nodeInspector.Node.GetType ()}");
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectFromObject_Event (SyntaxTreeCallbackReason reason, ObjectFromObject.production_kind kind, ObjectFromObject p_ObjectFromObject)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_ObjectFromObject.appInfo != null)
                        return false;
                    p_ObjectFromObject.appInfo = new ObjectFromObjectInspector (p_ObjectFromObject);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((ObjectFromObject.__p1_markers) p_ObjectFromObject.turn)
                    {
                        case ObjectFromObject.__p1_markers.m1:
                        {
                            ObjectClassDefnInspector inspector = (ObjectClassDefnInspector) p_ObjectFromObject.m_ReferencedObjects.appInfo;
                            nodeInspectors.Push (inspector);
                        }
                        break;
                        case ObjectFromObject.__p1_markers.m2:
                            nodeInspectors.Pop ();
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    FieldName fieldName = p_ObjectFromObject.m_FieldName;
                    NodeInspector inspector = fieldName.appInfo as NodeInspector;
                    switch (inspector.NodeType)
                    {
                        case NodeType.Undefined:
                            break;
                        case NodeType.TypeNode:
                            break;
                        case NodeType.ClassNode:
                            break;
                    }

                    ((p_ObjectFromObject.parent.appInfo = p_ObjectFromObject.appInfo) as ObjectNodeInspector).objectNode =
                        GenerateInformationFromObjects (p_ObjectFromObject.m_ReferencedObjects, p_ObjectFromObject.m_FieldName);

                    AsnSymbol objectReference = null;
                    foreach (AsnSymbol contextSymbol in contextStack)
                    {
                        if ((objectReference = p_ObjectFromObject.m_ReferencedObjects.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (objectReference == null)
                        break;
                    objectReference = objectReference.DefiningReference;
                    if (!(objectReference.Node is ObjectAssignment))
                        break;
                    NodeInspector nodeInspector = ((NodeInspector) objectReference.Node.appInfo).actualNodeInspector;
                    if (nodeInspector != p_ObjectFromObject.m_ReferencedObjects.appInfo as NodeInspector)
                        break;
                    if (!(nodeInspector is ObjectClassDefnInspector))
                        break;
                    if ((((NodeInspector) p_ObjectFromObject.appInfo).actualNodeInspector =
                        nodeInspector =
                        (NodeInspector) p_ObjectFromObject.m_FieldName.appInfo) == null)
                        break;
                    Console.WriteLine ($"OBJECT FROM OBJECT: {p_ObjectFromObject.Emit (-1)}");
                    Console.WriteLine ($"    NODE INSPECTOR: {nodeInspector.Node.Emit (-1)}");
                    Console.WriteLine ($"4   INSPECTOR TYPE: {nodeInspector.Node.GetType ()}");
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectSetFromObjects_Event (SyntaxTreeCallbackReason reason, ObjectSetFromObjects.production_kind kind, ObjectSetFromObjects p_ObjectSetFromObjects)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_ObjectSetFromObjects.appInfo != null)
                        return false;
                    p_ObjectSetFromObjects.appInfo = new ObjectSetFromObjectsInspector (p_ObjectSetFromObjects);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((ObjectSetFromObjects.__p1_markers) p_ObjectSetFromObjects.turn)
                    {
                        case ObjectSetFromObjects.__p1_markers.m1:
                        {
                            ObjectClassDefnInspector inspector = (ObjectClassDefnInspector) p_ObjectSetFromObjects.m_ReferencedObjects.appInfo;
                            nodeInspectors.Push (inspector);
                        }
                        break;
                        case ObjectSetFromObjects.__p1_markers.m2:
                            nodeInspectors.Pop ();
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    FieldName fieldName = p_ObjectSetFromObjects.m_FieldName;
                    NodeInspector inspector = fieldName.appInfo as NodeInspector;
                    switch (inspector.NodeType)
                    {
                        case NodeType.Undefined:
                            break;
                        case NodeType.TypeNode:
                            break;
                        case NodeType.ClassNode:
                            break;
                    }

                    ((p_ObjectSetFromObjects.parent.appInfo = p_ObjectSetFromObjects.appInfo) as ObjectNodeInspector).objectNode =
                        GenerateInformationFromObjects (p_ObjectSetFromObjects.m_ReferencedObjects, p_ObjectSetFromObjects.m_FieldName);

                    AsnSymbol objectReference = null;
                    foreach (AsnSymbol contextSymbol in contextStack)
                    {
                        if ((objectReference = p_ObjectSetFromObjects.m_ReferencedObjects.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (objectReference == null)
                        break;
                    objectReference = objectReference.DefiningReference;
                    if (!(objectReference.Node is ObjectAssignment) && !(objectReference.Node is ObjectSetAssignment))
                        break;
                    NodeInspector nodeInspector = ((NodeInspector) objectReference.Node.appInfo).actualNodeInspector;
                    if (nodeInspector != p_ObjectSetFromObjects.m_ReferencedObjects.appInfo as NodeInspector)
                        break;
                    if (!(nodeInspector is ObjectClassDefnInspector))
                        break;
                    if ((((NodeInspector) p_ObjectSetFromObjects.appInfo).actualNodeInspector =
                        nodeInspector =
                        (NodeInspector) p_ObjectSetFromObjects.m_FieldName.appInfo) == null)
                        break;
                    Console.WriteLine ($"OBJECT SET FROM OBJECT: {p_ObjectSetFromObjects.Emit (-1)}");
                    Console.WriteLine ($"        NODE INSPECTOR: {nodeInspector.Node.Emit (-1)}");
                    Console.WriteLine ($"5       INSPECTOR TYPE: {nodeInspector.Node.GetType ()}");
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_Value_Event (SyntaxTreeCallbackReason reason, Value.production_kind kind, Value p_Value)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    switch (kind)
                    {
                        case Value.production_kind.g_Value_1:
                        {
                            p_Value.appInfo = p_Value.m_BuiltinValue.appInfo;
                            string valstr = p_Value.Emit (-1);
                            AsnSymbol asnSymbol = new AsnSymbol (valstr, currentModule, p_Value);
                            AsnSymbol symbolRef = symbolTable.find (asnSymbol);
                            if (symbolRef == null)
                                break;
                            AsnCompiler asnCompiler = new AsnCompiler ();
                            if (asnCompiler.ParseString (valstr, new int [] { (int) AsnDeclarations.tokens.ReferencedValue_token }) != 0)
                                break;
                            foreach (SyntaxTreeBase node in asnCompiler.parseList)
                            {
                                node.InvokeTraverse (this);
                                p_Value.change (((asn_features) node).m_ReferencedValue);
                                kind = (Value.production_kind) p_Value.kind;
                                try
                                {
                                    NodeInspector nodeInspector = ((asn_features) node).m_ReferencedValue.appInfo as NodeInspector;
                                    nodeInspector.Inspect (p_Value, this);
                                }
                                catch (Exception e)
                                {
                                    Console.Error.WriteLine ($"ERROR: {e.Message}");
                                }
                                return true;
                            }
                        }
                        break;
                        case Value.production_kind.g_Value_2:
                            p_Value.appInfo = p_Value.m_ReferencedValue.appInfo;
                            break;
                        case Value.production_kind.g_Value_3:
                            p_Value.appInfo = p_Value.m_OpenTypeFieldVal;
                            break;
                    }
                    try
                    {
                        NodeInspector nodeInspector = nodeInspectors.Peek ();
                        if (nodeInspector == null)
                            break;
                        switch (kind)
                        {
                            case Value.production_kind.g_Value_1:
                            {
                                bool? compatible = nodeInspector.IsCompatibleValue (p_Value.appInfo as SyntaxTreeBase);
                                if ((compatible == null) || !compatible.Value)
                                {
                                    SyntaxTreeBase newValue = nodeInspector.GenerateCompatibleValue (p_Value, this);
                                    if (newValue != null)
                                        nodeInspector.Inspect (p_Value, this);
                                    else
                                        ;
                                }
                                else
                                {
                                    ((SyntaxTreeBase) p_Value.appInfo).InvokeTraverse (this);
                                }
                            }
                            break;
                            case Value.production_kind.g_Value_2:
                            {
                                NodeInspector inspector = p_Value.m_ReferencedValue.appInfo as NodeInspector;
                                if (inspector is DefinedValueInspector)
                                    ;
                                else if (inspector is ValueFromObjectInspector)
                                    ;
                                else
                                    ;
                            }
                            break;
                            case Value.production_kind.g_Value_3:
                                break;
                        }
                        nodeInspector.Inspect (p_Value, this);
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine ($"ERROR: {e.Message}");
                    }
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_BuiltinValue_Event (SyntaxTreeCallbackReason reason, BuiltinValue.production_kind kind, BuiltinValue p_BuiltinValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    return false;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    switch (kind)
                    {
                        case BuiltinValue.production_kind.g_BuiltinValue_1:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_BitStringValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_2:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_BooleanValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_3:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_CharacterStringValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_4:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_ChoiceValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_5:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_EmbeddedPDVValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_6:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_EnumeratedValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_7:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_ExternalValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_8:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_IntegerValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_9:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_IRIValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_10:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_NullValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_11:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_ObjectIdentifierValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_12:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_OctetStringValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_13:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_RealValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_14:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_RelativeIRIValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_15:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_RelativeOIDValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_16:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_SequenceValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_17:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_SequenceOfValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_18:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_SetValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_19:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_SetOfValue;
                            break;
                        case BuiltinValue.production_kind.g_BuiltinValue_20:
                            p_BuiltinValue.appInfo = p_BuiltinValue.m_TimeValue;
                            break;
                    }
                }
                break;
            }
            return true;
        }

        private bool AsnNodeInspector_ReferencedValue_Event (SyntaxTreeCallbackReason reason, ReferencedValue.production_kind kind, ReferencedValue p_ReferencedValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_OpenTypeFieldVal_Event (SyntaxTreeCallbackReason reason, OpenTypeFieldVal.production_kind kind, OpenTypeFieldVal p_OpenTypeFieldVal)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch ((OpenTypeFieldVal.__p1_markers) p_OpenTypeFieldVal.turn)
                    {
                        case OpenTypeFieldVal.__p1_markers.m1:
                            nodeInspectors.Push ((NodeInspector) p_OpenTypeFieldVal.m_Type.appInfo);
                            break;
                        case OpenTypeFieldVal.__p1_markers.m2:
                            nodeInspectors.Pop ();
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_BitStringValue_Event (SyntaxTreeCallbackReason reason, BitStringValue.production_kind kind, BitStringValue p_BitStringValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_BooleanValue_Event (SyntaxTreeCallbackReason reason, BooleanValue.production_kind kind, BooleanValue p_BooleanValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_CharacterStringValue_Event (SyntaxTreeCallbackReason reason, CharacterStringValue.production_kind kind, CharacterStringValue p_CharacterStringValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ChoiceValue_Event (SyntaxTreeCallbackReason reason, ChoiceValue.production_kind kind, ChoiceValue p_ChoiceValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    NodeInspector inspector = nodeInspectors.Peek ();
                    NodeInspector choiceInspector = inspector.GetComponentInspector (p_ChoiceValue.m_identifier_token.m_identifier.text);
                    if (choiceInspector == null)
                        choiceInspector = inspector.GetComponentInspector (p_ChoiceValue.m_identifier_token.m_identifier.text);
                    nodeInspectors.Push (choiceInspector);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_EmbeddedPDVValue_Event (SyntaxTreeCallbackReason reason, EmbeddedPDVValue.production_kind kind, EmbeddedPDVValue p_EmbeddedPDVValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_EnumeratedValue_Event (SyntaxTreeCallbackReason reason, EnumeratedValue.production_kind kind, EnumeratedValue p_EnumeratedValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ExternalValue_Event (SyntaxTreeCallbackReason reason, ExternalValue.production_kind kind, ExternalValue p_ExternalValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_IntegerValue_Event (SyntaxTreeCallbackReason reason, IntegerValue.production_kind kind, IntegerValue p_IntegerValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_IRIValue_Event (SyntaxTreeCallbackReason reason, IRIValue.production_kind kind, IRIValue p_IRIValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_NullValue_Event (SyntaxTreeCallbackReason reason, NullValue.production_kind kind, NullValue p_NullValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_ObjectIdentifierValue_Event (SyntaxTreeCallbackReason reason, ObjectIdentifierValue.production_kind kind, ObjectIdentifierValue p_ObjectIdentifierValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_OctetStringValue_Event (SyntaxTreeCallbackReason reason, OctetStringValue.production_kind kind, OctetStringValue p_OctetStringValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_RealValue_Event (SyntaxTreeCallbackReason reason, RealValue.production_kind kind, RealValue p_RealValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_RelativeIRIValue_Event (SyntaxTreeCallbackReason reason, RelativeIRIValue.production_kind kind, RelativeIRIValue p_RelativeIRIValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_RelativeOIDValue_Event (SyntaxTreeCallbackReason reason, RelativeOIDValue.production_kind kind, RelativeOIDValue p_RelativeOIDValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SequenceValue_Event (SyntaxTreeCallbackReason reason, SequenceValue.production_kind kind, SequenceValue p_SequenceValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SequenceOfValue_Event (SyntaxTreeCallbackReason reason, SequenceOfValue.production_kind kind, SequenceOfValue p_SequenceOfValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SetValue_Event (SyntaxTreeCallbackReason reason, SetValue.production_kind kind, SetValue p_SetValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SetOfValue_Event (SyntaxTreeCallbackReason reason, SetOfValue.production_kind kind, SetOfValue p_SetOfValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    NodeInspector inspector = nodeInspectors.Peek ();
                    SetOfTypeInspector setInspector = inspector.GetInspectorByType (typeof (SetOfTypeInspector)) as SetOfTypeInspector;
                    if (setInspector == null)
                    {
                        nodeInspectors.Push (null);
                        return false;
                    }
                    SetOfType setOfType = setInspector.Node as SetOfType;
                    switch ((SetOfType.production_kind) setOfType.kind)
                    {
                        case SetOfType.production_kind.g_SetOfType_1:
                            nodeInspectors.Push ((NodeInspector) setOfType.m_Type.appInfo);
                            break;
                        case SetOfType.production_kind.g_SetOfType_2:
                            nodeInspectors.Push ((NodeInspector) setOfType.m_NamedType.appInfo);
                            break;
                        default:
                            nodeInspectors.Push (null);
                            return false;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_TimeValue_Event (SyntaxTreeCallbackReason reason, TimeValue.production_kind kind, TimeValue p_TimeValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }


        private bool AsnNodeInspector_ComponentValueList_Event (SyntaxTreeCallbackReason reason, ComponentValueList.production_kind kind, ComponentValueList p_ComponentValueList)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push (nodeInspectors.Peek ().GetComponentInspector (p_ComponentValueList.m_NamedValue.m_identifier_token.m_identifier.text));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_NamedValueList_Event (SyntaxTreeCallbackReason reason, NamedValueList.production_kind kind, NamedValueList p_NamedValueList)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push (nodeInspectors.Peek ().GetComponentInspector (p_NamedValueList.m_NamedValue.m_identifier_token.m_identifier.text));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_DefinedValue_Event (SyntaxTreeCallbackReason reason, DefinedValue.production_kind kind, DefinedValue p_DefinedValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_DefinedValue.appInfo != null)
                    {
                        nodeInspectors.Push ((NodeInspector) p_DefinedValue.appInfo);
                        break;
                    }
                    AsnSymbol valueReference = null;
                    foreach (AsnSymbol contextSymbol in moduleStack)
                    {
                        if ((valueReference = p_DefinedValue.findReference (contextSymbol)) != null)
                            break;
                    }
                    if (valueReference == null)
                    {
                        nodeInspectors.Push ((NodeInspector) (p_DefinedValue.appInfo = new DefinedValueInspector (p_DefinedValue, null)));
                        Console.Error.WriteLine ($"ERROR: UNDEFINED VALUE REFERENCE: {p_DefinedValue.Emit (-1)}");
                        break;
                    }
                    valueReference = valueReference.DefiningReference;
                    if (!(valueReference.Node.parent is ParameterizedAssignment) && (valueReference.Specie != AsnSymbol.SymbolSpecie.ReferenceSpecie))
                    {
                        {
                            contextStack.Push (valueReference.Context);
                            moduleStack.Push (currentModule = valueReference.Context);
                            if (valueReference.Node.appInfo == null)
                            {
                                valueReference.Node.InvokeTraverse (this);
                                NodeInspector nodeInspector = ((NodeInspector) valueReference.Node.appInfo).actualNodeInspector;
                                if (!(nodeInspector is ValueAssignmentInspector))
                                {
                                    if (Debug)
                                    {
                                        Console.Error.WriteLine ($"ERROR-N: DEFINED VALUE NODE INSPECTOR IS NOT CORRECT: {nodeInspector.GetType ().ToString ()}");
                                        Console.Error.WriteLine ($"                            INSPECTOR TYPE: {nodeInspector.GetType ().ToString ()}");
                                        Console.Error.WriteLine ($"                            INSPECTOR NODE: {nodeInspector.Node.Emit (-1)}");
                                        Console.Error.WriteLine ($"                                    MODULE: {currentModule.Path}");
                                        Console.Error.WriteLine ($"                                VALUE NODE: {valueReference.Node.Emit (-1)}");
                                    }
                                    PrintStackTrace ();
                                }
                            }
                            moduleStack.Pop ();
                            currentModule = moduleStack.Peek ();
                            contextStack.Pop ();
                        }
                        if (valueReference.Node.appInfo == null)
                        {
                            Console.Error.WriteLine ($"ERROR: UNDEFINED VALUE INSPECTOR: {p_DefinedValue.Emit (-1)}");
                        }
                    }
                    nodeInspectors.Push ((NodeInspector) (p_DefinedValue.appInfo = new DefinedValueInspector (p_DefinedValue, (NodeInspector) valueReference.Node.appInfo)));
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    p_DefinedValue.parent.appInfo = p_DefinedValue.appInfo;
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_NamedValue_Event (SyntaxTreeCallbackReason reason, NamedValue.production_kind kind, NamedValue p_NamedValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason reason, RestrictedCharacterStringValue.production_kind kind, RestrictedCharacterStringValue p_RestrictedCharacterStringValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_UnrestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason reason, UnrestrictedCharacterStringValue.production_kind kind, UnrestrictedCharacterStringValue p_UnrestrictedCharacterStringValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_NumericRealValue_Event (SyntaxTreeCallbackReason reason, NumericRealValue.production_kind kind, NumericRealValue p_NumericRealValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_SpecialRealValue_Event (SyntaxTreeCallbackReason reason, SpecialRealValue.production_kind kind, SpecialRealValue p_SpecialRealValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_NamedConstraint_Event (SyntaxTreeCallbackReason reason, NamedConstraint.production_kind kind, NamedConstraint p_NamedConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    nodeInspectors.Push (nodeInspectors.Peek ().GetComponentInspector (p_NamedConstraint.m_identifier_token.m_identifier.text));
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    nodeInspectors.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnNodeInspector_GeneralConstraint_Event (SyntaxTreeCallbackReason reason, GeneralConstraint.production_kind kind, GeneralConstraint p_GeneralConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private InfoFromObjectDescriptor GenerateInformationFromObjects (ReferencedObjects referencedObjects, FieldName fieldName)
        {
            ObjectClassDefnInspector defnInspector = referencedObjects.appInfo as ObjectClassDefnInspector;
            NodeInspector settingInspector = null;

            SetOfObjects inputSet = new SetOfObjects ();
            ListOfSettings settings = new ListOfSettings ();
            SyntaxTreeBase refObj = null;
            switch ((ReferencedObjects.production_kind) referencedObjects.kind)
            {
                case ReferencedObjects.production_kind.g_ReferencedObjects_1:
                    refObj = ((referencedObjects.m_DefinedObject.appInfo as NodeInspector)?.GetObjectInspector () as ObjectInspector)?.Node;
                    inputSet.Add (refObj as Asn.Parser.Object);
                    break;
                case ReferencedObjects.production_kind.g_ReferencedObjects_3:
                    refObj = ((referencedObjects.m_DefinedObjectSet.appInfo as NodeInspector)?.GetObjectInspector () as ObjectSetSpecInspector)?.Node;
                    foreach (Asn.Parser.Object obj in ExtractObjectSet (refObj))
                        inputSet.Add (obj);
                    inputSet.isObject = false;
                    break;
                default:
                    break;
            }

            SetOfObjects resultSet = fieldName.Iterate (inputSet, (node, appData) =>
            {
                SetOfObjects objSet = appData as SetOfObjects;
                SetOfObjects objList = new SetOfObjects ();
                objList.isObject = objSet.isObject;
                if (defnInspector == null)
                    return objList;

                PrimitiveFieldName primitiveFieldName = node.m_PrimitiveFieldName;
                string name = '&' + primitiveFieldName.Emit (-1).Substring (2);
                FieldSpec fieldSpec = null;
                defnInspector.FieldSpecs.TryGetValue (name, out fieldSpec);
                if (fieldSpec == null)
                    return objList;

                FieldSpecInspector fieldSpecInspector = fieldSpec.appInfo as FieldSpecInspector;
                if (fieldSpecInspector == null)
                    return objList;

                defnInspector = fieldSpecInspector.GetClassDefnInspector ();
                settingInspector = fieldSpecInspector.GetSettingInspector ();

                foreach (Asn.Parser.Object @object in objSet)
                {
                    ObjectInspector objectInspector = (@object.appInfo as NodeInspector)?.GetObjectInspector () as ObjectInspector;
                    if (objectInspector == null)
                        continue;

                    Setting setting = null;
                    if (!objectInspector.Settings.TryGetValue (name, out setting))
                        continue;

                    if (setting == null)
                        continue;

                    switch ((Setting.production_kind) setting.kind)
                    {
                        case Setting.production_kind.g_Setting_1:
                            refObj = setting.m_Type;
                            settings.Add (setting);
                            settingInspector = refObj.appInfo as NodeInspector;
                            break;
                        case Setting.production_kind.g_Setting_2:
                            refObj = setting.m_Value;
                            settings.Add (setting);
                            break;
                        case Setting.production_kind.g_Setting_3:
                            refObj = setting.m_ValueSet;
                            settings.Add (setting);
                            break;
                        case Setting.production_kind.g_Setting_4:
                            refObj = setting.m_Object;
                            objList.Add (setting.m_Object);
                            break;
                        case Setting.production_kind.g_Setting_5:
                            refObj = setting.m_ObjectSet;
                            foreach (Asn.Parser.Object obj in ExtractObjectSet (setting.m_ObjectSet))
                                objList.Add (obj);
                            objList.isObject = false;
                            break;
                    }
                }
                return objList;
            }) as SetOfObjects;

            if (true)
            {
                Console.WriteLine ($"INFO FROM OBJECTS: {referencedObjects.Emit (-1)}.{fieldName.Emit (-1)}");
                Console.WriteLine ($"INPUT:");
                foreach (Asn.Parser.Object @object in inputSet)
                {
                    ObjectInspector objectInspector = (@object?.appInfo as NodeInspector)?.GetObjectInspector () as ObjectInspector;
                    if (objectInspector == null)
                        continue;
                    bool ind = false;
                    Console.Write ($"\t(");
                    foreach (string name in objectInspector.Settings.Keys)
                    {
                        if (ind)
                            Console.Write ($", ");
                        Setting setting = objectInspector.Settings [name];
                        if (setting != null)
                            Console.Write ($"{name} = {objectInspector.Settings [name]?.Emit (-1)}");
                        else
                            Console.Write ($"{name} = null");
                        ind = true;
                    }
                    Console.WriteLine ($")");
                }
                if (resultSet.Count > 0)
                {
                    if (resultSet.isObject)
                        Console.WriteLine ($"RESULT (OBJECT):");
                    else
                        Console.WriteLine ($"RESULT (OBJECT SET):");
                    foreach (Asn.Parser.Object @object in resultSet)
                    {
                        ObjectInspector objectInspector = (@object?.appInfo as NodeInspector)?.GetObjectInspector () as ObjectInspector;
                        if (objectInspector == null)
                            continue;
                        bool ind = false;
                        Console.Write ($"\t(");
                        foreach (string name in objectInspector.Settings.Keys)
                        {
                            if (ind)
                                Console.Write ($", ");
                            Setting setting = objectInspector.Settings [name];
                            if (setting != null)
                                Console.Write ($"{name} = {objectInspector.Settings [name]?.Emit (-1)} ");
                            else
                                Console.Write ($"{name} = null ");
                            ind = true;
                        }
                        Console.WriteLine ($")");
                    }
                }
                if (settings.Count > 0)
                {
                    Console.WriteLine ($"SETTINGS:");
                    foreach (Setting setting in settings)
                    {
                        Console.WriteLine ($"\t{setting.Emit (-1)}");
                    }
                }
            }

            if (((ProductionID) refObj.id == ProductionID._Object_ID) || ((ProductionID) refObj.id == ProductionID._ObjectSet_ID))
                refObj = ((refObj?.appInfo as NodeInspector)?.GetObjectInspector ())?.Node;

            return new InfoFromObjectDescriptor (inputSet, resultSet, settings, refObj, defnInspector, settingInspector);
        }

        private SetOfObjects ExtractObjectSet (SyntaxTreeBase node)
        {
            SetOfObjects objList = new SetOfObjects ();
            objList.isObject = false;
            NodeInspector inspector = node.appInfo as NodeInspector;
            if (inspector == null)
                return objList;
            ObjectSetSpecInspector objectSetSpecInspector = inspector.GetObjectInspector () as ObjectSetSpecInspector;
            if (objectSetSpecInspector == null)
                return objList;
            foreach (Elements elements in objectSetSpecInspector.elements)
            {
                switch ((Elements.production_kind) elements.kind)
                {
                    case Elements.production_kind.g_Elements_1:
                        return objList;
                    case Elements.production_kind.g_Elements_2:
                    {
                        ObjectSetElements objectSetElements = elements.m_ObjectSetElements;
                        switch ((ObjectSetElements.production_kind) objectSetElements.kind)
                        {
                            case ObjectSetElements.production_kind.g_ObjectSetElements_1:
                                objList.Add (objectSetElements.m_Object);
                                break;
                            case ObjectSetElements.production_kind.g_ObjectSetElements_2:
                            {
                                SetOfObjects objects = ExtractObjectSet (objectSetElements.m_DefinedObjectSet);
                                foreach (Asn.Parser.Object obj in objects)
                                    objList.Add (obj);
                            }
                            break;
                            case ObjectSetElements.production_kind.g_ObjectSetElements_3:
                            {
                                ObjectNodeInspector objectsInspector = objectSetElements.m_ObjectSetFromObjects.appInfo as ObjectNodeInspector;
                                foreach (Asn.Parser.Object obj in objectsInspector.objectNode.resultSet)
                                    objList.Add (obj);
                            }
                            break;
                            case ObjectSetElements.production_kind.g_ObjectSetElements_4:
                                break;
                        }
                    }
                    break;
                    case Elements.production_kind.g_Elements_3:
                        break;
                }
            }
            return objList;
        }

        private object GetFieldNodeInspector (SyntaxTreeBase node, object appData)
        {
            ObjectClassDefnInspector objectClassDefnInspector = appData as ObjectClassDefnInspector;
            if (objectClassDefnInspector == null)
                return null;
            PrimitiveFieldName fieldName = (node as FieldName)?.m_PrimitiveFieldName;
            if (fieldName == null)
                return null;

            string name = '&' + fieldName.Emit (-1).Substring (2);
            try
            {
                FieldSpec fieldSpec = objectClassDefnInspector.FieldSpecs [name];
                if ((appData = fieldSpec.GetNodeInspector ()) == null)
                {
                    fieldSpec.InvokeTraverse (this);
                    appData = fieldSpec.GetNodeInspector ();
                }
                if (appData == null)
                {
                    Console.Error.WriteLine ($"ERROR: NULL NODE INSPECTOR FOR FIELD: {fieldName.Emit (-1)} IN CLASS: {objectClassDefnInspector.Node.Emit (-1)}");
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine ($"ERROR: {e.Message} FIELD = {((ObjectClassAssignment) objectClassDefnInspector.Node.parent.parent).m_objectclassreference_token.Emit (-1)}.{name}");
            }
            return node.appInfo = appData;
        }

        ParameterTable CreateParameterTable (ActualParameter_set actualParameters, ListOfParameters parameters)
        {
            ParameterTable parTable = new ParameterTable ();
            SyntaxTreeBase parLink;
            for (parLink = actualParameters; actualParameters != null; actualParameters = actualParameters.m_ActualParameter_set)
                parLink = actualParameters;
            foreach (Parameter parameter in parameters)
            {
                if ((parLink == null) || !(parLink is ActualParameter_set))
                {
                    Console.Error.WriteLine ($"ERROR: NUMBER OF ACTUAL PARAMETERS IS LESSER THAN NUMBER OF DECLARED PARAMETERS");
                    break;
                }
                string parText = "";
                actualParameters = (ActualParameter_set) parLink;
                ActualParameter actualParameter = actualParameters.m_ActualParameter;
                ParamGovernor paramGovernor = parameter.m_ParamGovernor;
                string parName = parameter.m_DummyReference.Emit (-1);
                switch ((ActualParameter.production_kind) actualParameter.kind)
                {
                    case ActualParameter.production_kind.g_ActualParameter_1:
                    {
                        Asn.Parser.Type type = actualParameter.m_Type;
                        parName += $"_TY_{ParameterizedTypeGovernor.Counter}";
                        parText = $"{parName} ::= {type.Emit (-1)}";
                    }
                    break;
                    case ActualParameter.production_kind.g_ActualParameter_2:
                    {
                        Value value = actualParameter.m_Value;
                        parName += $"_VL_{ParameterizedValueGovernor.Counter}";
                        if (paramGovernor != null)
                            parText = $"{parName} {paramGovernor.Emit (-1)} ::= {value.Emit (-1)}";
                        else
                            Console.Error.WriteLine ($"ERROR: CANNOT GENERATE PARAMETER VALUE");
                    }
                    break;
                    case ActualParameter.production_kind.g_ActualParameter_3:
                    {
                        ValueSet valueSet = actualParameter.m_ValueSet;
                        parName += $"_VS_{ParameterizedValueSetTypeGovernor.Counter}";
                        if (paramGovernor != null)
                            parText = $"{parName} {paramGovernor.Emit (-1)} ::= {valueSet.Emit (-1)}";
                        else
                            Console.Error.WriteLine ($"ERROR: CANNOT GENERATE PARAMETER VALUE SET");
                    }
                    break;
                    case ActualParameter.production_kind.g_ActualParameter_4:
                    {
                        DefinedObjectClass definedObjectClass = actualParameter.m_DefinedObjectClass;
                        parName += $"_DO_{ParameterizedObjectClassGovernor.Counter}";
                        parText = $"{parName} ::= {definedObjectClass.Emit (-1)}";
                    }
                    break;
                    case ActualParameter.production_kind.g_ActualParameter_5:
                    {
                        Asn.Parser.Object @object = actualParameter.m_Object;
                        parName += $"_OB_{ParameterizedObjectGovernor.Counter}";
                        if (paramGovernor != null)
                            parText = $"{parName} {paramGovernor.Emit (-1)} ::= {@object.Emit (-1)}";
                        else
                            Console.Error.WriteLine ($"ERROR: CANNOT GENERATE PARAMETER OBJECT");
                    }
                    break;
                    case ActualParameter.production_kind.g_ActualParameter_6:
                    {
                        ObjectSet objectSet = actualParameter.m_ObjectSet;
                        parName += $"_OS_{ParameterizedObjectSetGovernor.Counter}";
                        if (paramGovernor != null)
                            parText = $"{parName} {paramGovernor.Emit (-1)} ::= {objectSet.Emit (-1)}";
                        else
                            Console.Error.WriteLine ($"ERROR: CANNOT GENERATE PARAMETER OBJECT SET");
                    }
                    break;
                    default:
                        parText = actualParameter.Emit (-1);
                        break;
                }
                parTable.Add (new ParameterDescriptor (parameter.m_ParamGovernor, parameter.m_DummyReference, parName, parText));
                parLink = parLink.parent;
                actualParameters = null;
            }
            if (actualParameters != null)
                Console.Error.WriteLine ($"ERROR: NUMBER OF ACTUAL PARAMETERS IS GREATER THAN NUMBER OF DECLARED PARAMETERS");
            uint index = 0;
            if (AsnCompiler.Debug)
                foreach (ParameterDescriptor par in parTable)
                {
                    string governorName = (par.governor != null) ? par.governor.Emit (-1) : "null";
                    Console.WriteLine ($"parameter {index++}:");
                    Console.WriteLine ($"\tgovernor: {governorName}");
                    Console.WriteLine ($"\tname:     {par.reference.Emit (-1)}");
                    Console.WriteLine ($"\tvalue:    {par.parValue}");
                }
            return parTable;

        }

        private int excludeStringToken (int position, string text, char delimiter)
        {
            bool ind = false;
            text = text.Substring (position + 1);
            foreach (char c in text)
            {
                ++position;
                if (ind)
                {
                    if (c != delimiter)
                    {
                        --position;
                        break;
                    }
                    ind = false;
                }
                else
                {
                    if (c != delimiter)
                        continue;
                    ind = true;
                }
            }
            return position;
        }

        private string excludeBalancedBraces (ref string text, string replacement)
        {
            Stack<char> bbs = new Stack<char> ();
            string part = null;
            int position = 0;
            int stringPosition = 0;
            int start = 0;
            bool skipString = false;
            foreach (char c in text)
            {
                if (skipString)
                {
                    if (++stringPosition >= position)
                    {
                        skipString = false;
                        ++position;
                    }
                    continue;
                }

                switch (c)
                {
                    case '{':
                    case '(':
                    case '[':
                        if (bbs.Count == 0)
                            start = position;
                        bbs.Push (c);
                        ++position;
                        continue;
                    case '}':
                        if (bbs.Count == 0)
                            continue;
                        if (bbs.Peek () != '{')
                            return part;
                        break;
                    case ')':
                        if (bbs.Count == 0)
                            continue;
                        if (bbs.Peek () != '(')
                            return part;
                        break;
                    case ']':
                        if (bbs.Count == 0)
                            continue;
                        if (bbs.Peek () != '[')
                            return part;
                        break;
                    case '"':
                    case '\'':
                        if (bbs.Count == 0)
                            start = position;
                        bbs.Push (c);
                        skipString = true;
                        stringPosition = position;
                        position = excludeStringToken (position, text, c);
                        break;
                    default:
                        ++position;
                        continue;
                }
                ++position;
                bbs.Pop ();
                if (bbs.Count != 0)
                    continue;
                part = text.Substring (start, position - start);
                text = text.Remove (start, position - start);
                text = text.Insert (start, replacement);
                return part;
            }
            return part;
        }

        private string DefinedToDefaultSyntax (ObjectClassDefnInspector governor, string text)
        {
            //
            // using defined syntax of object, invoke following 5 steps to produce default syntax of object
            //

            int index = 0;
            string part;
            List<string> parts = new List<string> ();

            //
            // step 1: exclude and save all parts of text which contain balanced braces
            //
            while ((part = excludeBalancedBraces (ref text, $"${index++}")) != null)
            {
                parts.Add (part);
            }

            //
            // step 2: locate all literal strings valid for given object
            //
            index = 0;
            AsnPatternSet asnPatternSet = new AsnPatternSet ();
            foreach ((string pattern, string fieldName) pattern in governor.Patterns)
            {
                ++index;
                if (pattern.pattern.Length == 0)
                    continue;
                string str = $" {pattern.pattern} ";
                int length = str.Length;
                int position = 0;
                while (true)
                {
                    if ((position = text.IndexOf (str, position)) < 0)
                        break;
                    (int position, int length, int index) actualInfo = (position + 1, length - 2, index - 1);
                    position += length;
                    var view = asnPatternSet.GetViewBetween (actualInfo, actualInfo);
                    if ((view != null) && (view.Count > 0))
                    {
                        (int position, int length, int index) patternInfo = view.Min;
                        if ((patternInfo.position <= actualInfo.position) && (patternInfo.position + patternInfo.length >= actualInfo.position + actualInfo.length))
                            continue;
                        //
                        // literal string is not valid because it is part of other one
                        //
                        asnPatternSet.Remove (patternInfo);
                    }
                    asnPatternSet.Add (actualInfo);
                }
            }

            //
            // step 3: change all actual occurances of valid literal strings with associated class field names
            //
            index = asnPatternSet.Count;
            foreach ((int position, int length, int index) patternInfo in asnPatternSet.Reverse ())
            {
                (string pattern, string fieldName) pattern = governor.Patterns [patternInfo.index];
                if (index > 1)
                    text = text.Substring (0, patternInfo.position) + ", " + pattern.fieldName + text.Substring (patternInfo.position + patternInfo.length);
                else
                    text = text.Substring (0, patternInfo.position) + pattern.fieldName + text.Substring (patternInfo.position + patternInfo.length);
                --index;
            }

            //
            // step 4: add class field name with no valid literal string if there is one
            //
            foreach ((string pattern, string fieldName) pattern in governor.Patterns)
            {
                if (pattern.pattern.Length > 0)
                    break;
                if (pattern.fieldName.Length == 0)
                    continue;
                text = pattern.fieldName + " " + text;
                break;
            }

            //
            // step 5: restore all parts of text with ballanced braces
            //
            index = 0;
            foreach (string str in parts)
            {
                text = text.Replace ($"${index++}", str);
            }

            //
            // resulting text should be default syntax of object
            //
            return text;
        }

        public void Invoke ()
        {
            if (!inited)
            {
                inited = true;

                AsnSymbol globalModuleSymbol = new AsnSymbol ("GLOBAL-MODULE", null, null);
                AsnSymbol globalModuleReference = symbolTable.find (globalModuleSymbol);
                if (globalModuleReference != null)
                {
                    AsnSymbol embeddedTypeSymbol = new AsnSymbol ("EmbeddedPDVType", globalModuleReference, null);
                    AsnSymbol embeddedTypeReference = symbolTable.find (embeddedTypeSymbol);
                    if (embeddedTypeReference != null)
                    {
                        SyntaxTreeBase node = embeddedTypeReference.DefiningReference.Node;
                        if (node.appInfo == null)
                            node.InvokeTraverse (this);
                        embeddedPDVTypeInspector = (NodeInspector) node.appInfo;
                    }

                    AsnSymbol externalTypeSymbol = new AsnSymbol ("ExternalType", globalModuleReference, null);
                    AsnSymbol externalTypeReference = symbolTable.find (externalTypeSymbol);
                    if (externalTypeReference != null)
                    {
                        SyntaxTreeBase node = externalTypeReference.DefiningReference.Node;
                        if (node.appInfo == null)
                            node.InvokeTraverse (this);
                        externalTypeInspector = (NodeInspector) node.appInfo;
                    }

                    AsnSymbol globalIntegerSymbol = new AsnSymbol ("GLOBAL-INTEGER", globalModuleReference, null);
                    AsnSymbol globalIntegerReference = symbolTable.find (globalIntegerSymbol);
                    if (globalIntegerReference != null)
                    {
                        SyntaxTreeBase node = globalIntegerReference.DefiningReference.Node;
                        if (node.appInfo == null)
                            node.InvokeTraverse (this);
                        integerTypeInspector = (NodeInspector) node.appInfo;
                    }
                }
            }

            foreach (List<ModuleDescriptor> moduleList in AsnDataBase.accumulatedModuleDefinitions.Values)
                foreach (ModuleDescriptor module in moduleList)
                {
                    ModuleDescriptor descriptor = module;
                    currentModuleDescriptor = module;
                    moduleStack.Push (currentModule = currentModuleDescriptor.moduleSymbol);
                    currentFile = module.fileName;
                    contextStack.Push (module.moduleSymbol);
                    SyntaxTreeBase.enableLocking = false;
                    Traverse (module.moduleDefinition);
                    SyntaxTreeBase.enableLocking = true;
                    moduleStack.Pop ();
                    contextStack.Pop ();
                }
        }

        private void PrintStackTrace ()
        {
            if (!Debug)
                return;
            System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace ();
            string trace = stackTrace.ToString ();
            System.Diagnostics.StackFrame [] stackFrames = stackTrace.GetFrames ();
            foreach (System.Diagnostics.StackFrame stackFrame in stackFrames)
            {
                System.Reflection.MethodBase methodBase = stackFrame.GetMethod ();
                System.Reflection.ParameterInfo [] parameterInfos = methodBase.GetParameters ();
                foreach (System.Reflection.ParameterInfo parameterInfo in parameterInfos)
                {
                    System.Type type = parameterInfo.ParameterType;
                    string name = parameterInfo.Name;
                }
            }
            Console.Error.WriteLine ($"STACK TRACE: {trace}");
        }

        public override AsnSymbol ResolveSymbol (string name)
        {
            AsnSymbol symbol = new AsnSymbol (name, currentModule, null);
            return symbolTable.find (symbol);
        }

        public override SyntaxTreeBase GenerateSequenceOfValue (Value p_Value)
        {
            string text = p_Value.Emit (-1);
            AsnCompiler asnCompiler = new AsnCompiler ();
            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
            {
                Console.Error.WriteLine ($"ERROR: CANNOT CONVERT INTO SEQUENCE OF VALUE:");
                Console.Error.WriteLine ($"\tVALUE: {p_Value.Emit (-1)}");
                return true;
            };
            if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.SequenceOfValue_token }) == 0)
            {
                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                {
                    node.reparent (null);
                    Traverse (((asn_features) node).m_SequenceOfValue);
                    p_Value.m_BuiltinValue.change (((asn_features) node).m_SequenceOfValue);
                    p_Value.appInfo = ((asn_features) node).m_SequenceOfValue;
                    return node;
                }
            }
            return null;
        }

        public override SyntaxTreeBase GenerateIntegerValue (Value p_Value)
        {
            string text = p_Value.Emit (-1);
            AsnCompiler asnCompiler = new AsnCompiler ();
            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
            {
                Console.Error.WriteLine ($"ERROR: CANNOT CONVERT INTO INTEGER VALUE:");
                Console.Error.WriteLine ($"\tVALUE: {p_Value.Emit (-1)}");
                return true;
            };
            if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.IntegerValue_token }) == 0)
            {
                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                {
                    node.reparent (null);
                    Traverse (((asn_features) node).m_IntegerValue);
                    p_Value.m_BuiltinValue.change (((asn_features) node).m_IntegerValue);
                    p_Value.appInfo = ((asn_features) node).m_IntegerValue;
                    return node;
                }
            }
            return null;
        }

        public override SyntaxTreeBase GenerateSequenceValue (Value p_Value)
        {
            string text = p_Value.Emit (-1);
            AsnCompiler asnCompiler = new AsnCompiler ();
            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
            {
                Console.Error.WriteLine ($"ERROR: CANNOT CONVERT INTO SEQUENCE VALUE:");
                Console.Error.WriteLine ($"\tVALUE: {p_Value.Emit (-1)}");
                return true;
            };
            if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.SequenceValue_token }) == 0)
            {
                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                {
                    node.reparent (null);
                    Traverse (((asn_features) node).m_SequenceValue);
                    p_Value.m_BuiltinValue.change (((asn_features) node).m_SequenceValue);
                    p_Value.appInfo = ((asn_features) node).m_SequenceValue;
                    return node;
                }
            }
            return null;
        }

        public override SyntaxTreeBase GenerateSetValue (Value p_Value)
        {
            string text = p_Value.Emit (-1);
            AsnCompiler asnCompiler = new AsnCompiler ();
            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
            {
                Console.Error.WriteLine ($"ERROR: CANNOT CONVERT INTO SET VALUE:");
                Console.Error.WriteLine ($"\tVALUE: {p_Value.Emit (-1)}");
                return true;
            };
            if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.SetValue_token }) == 0)
            {
                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                {
                    node.reparent (null);
                    Traverse (((asn_features) node).m_SetValue);
                    p_Value.m_BuiltinValue.change (((asn_features) node).m_SetValue);
                    p_Value.appInfo = ((asn_features) node).m_SetValue;
                    return node;
                }
            }
            return null;
        }

        public override SyntaxTreeBase GenerateChoiceValue (Value p_Value)
        {
            string text = p_Value.Emit (-1);
            AsnCompiler asnCompiler = new AsnCompiler ();
            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
            {
                Console.Error.WriteLine ($"ERROR: CANNOT CONVERT INTO CHOICE VALUE:");
                Console.Error.WriteLine ($"\tVALUE: {p_Value.Emit (-1)}");
                return true;
            };
            if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.ChoiceValue_token }) == 0)
            {
                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                {
                    node.reparent (null);
                    Traverse (((asn_features) node).m_ChoiceValue);
                    p_Value.m_BuiltinValue.change (((asn_features) node).m_ChoiceValue);
                    p_Value.appInfo = ((asn_features) node).m_ChoiceValue;
                    return node;
                }
            }
            return null;
        }

        public override SyntaxTreeBase GenerateSetOfValue (Value p_Value)
        {
            string text = p_Value.Emit (-1);
            AsnCompiler asnCompiler = new AsnCompiler ();
            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
            {
                Console.Error.WriteLine ($"ERROR: CANNOT CONVERT INTO SET OF VALUE:");
                Console.Error.WriteLine ($"\tVALUE: {p_Value.Emit (-1)}");
                return true;
            };
            if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.SetOfValue_token }) == 0)
            {
                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                {
                    node.reparent (null);
                    Traverse (((asn_features) node).m_SetOfValue);
                    p_Value.m_BuiltinValue.change (((asn_features) node).m_SetOfValue);
                    p_Value.appInfo = ((asn_features) node).m_SetOfValue;
                    return node;
                }
            }
            return null;
        }

        public override SyntaxTreeBase GenerateOctetStringValue (Value p_Value)
        {
            string text = p_Value.Emit (-1);
            AsnCompiler asnCompiler = new AsnCompiler ();
            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
            {
                Console.Error.WriteLine ($"ERROR: CANNOT CONVERT INTO OCTET STRING VALUE:");
                Console.Error.WriteLine ($"\tVALUE: {p_Value.Emit (-1)}");
                return true;
            };
            if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.OctetStringValue_token }) == 0)
            {
                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                {
                    node.reparent (null);
                    Traverse (((asn_features) node).m_OctetStringValue);
                    p_Value.m_BuiltinValue.change (((asn_features) node).m_OctetStringValue);
                    p_Value.appInfo = ((asn_features) node).m_OctetStringValue;
                    return node;
                }
            }
            return null;
        }

        public override SyntaxTreeBase GenerateEnumeratedValue (Value p_Value)
        {
            string text = p_Value.Emit (-1);
            AsnCompiler asnCompiler = new AsnCompiler ();
            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
            {
                Console.Error.WriteLine ($"ERROR: CANNOT CONVERT INTO ENUMERATED VALUE:");
                Console.Error.WriteLine ($"\tVALUE: {p_Value.Emit (-1)}");
                return true;
            };
            if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.EnumeratedValue_token }) == 0)
            {
                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                {
                    node.reparent (null);
                    Traverse (((asn_features) node).m_EnumeratedValue);
                    p_Value.m_BuiltinValue.change (((asn_features) node).m_EnumeratedValue);
                    p_Value.appInfo = ((asn_features) node).m_EnumeratedValue;
                    return node;
                }
            }
            return null;
        }

        public override SyntaxTreeBase GenerateBitStringValue (Value p_Value)
        {
            string text = p_Value.Emit (-1);
            AsnCompiler asnCompiler = new AsnCompiler ();
            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
            {
                Console.Error.WriteLine ($"ERROR: CANNOT CONVERT INTO BIT STRING VALUE:");
                Console.Error.WriteLine ($"\tVALUE: {p_Value.Emit (-1)}");
                return true;
            };
            if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.BitStringValue_token }) == 0)
            {
                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                {
                    node.reparent (null);
                    Traverse (((asn_features) node).m_BitStringValue);
                    p_Value.m_BuiltinValue.change (((asn_features) node).m_BitStringValue);
                    p_Value.appInfo = ((asn_features) node).m_BitStringValue;
                    return node;
                }
            }
            return null;
        }

        public override SyntaxTreeBase GenerateRelativeOIDValue (Value p_Value)
        {
            string text = p_Value.Emit (-1);
            AsnCompiler asnCompiler = new AsnCompiler ();
            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
            {
                Console.Error.WriteLine ($"ERROR: CANNOT CONVERT INTO RELATIVE OID VALUE:");
                Console.Error.WriteLine ($"\tVALUE: {p_Value.Emit (-1)}");
                return true;
            };
            if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.RelativeOIDValue_token }) == 0)
            {
                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                {
                    node.reparent (null);
                    Traverse (((asn_features) node).m_RelativeOIDValue);
                    p_Value.m_BuiltinValue.change (((asn_features) node).m_RelativeOIDValue);
                    p_Value.appInfo = ((asn_features) node).m_RelativeOIDValue;
                    return node;
                }
            }
            return null;
        }

        public override SyntaxTreeBase GenerateObjectIdentifierValue (Value p_Value)
        {
            string text = p_Value.Emit (-1);
            AsnCompiler asnCompiler = new AsnCompiler ();
            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
            {
                Console.Error.WriteLine ($"ERROR: CANNOT CONVERT INTO OBJECT IDENTIFIER VALUE:");
                Console.Error.WriteLine ($"\tVALUE: {p_Value.Emit (-1)}");
                return true;
            };
            if (asnCompiler.ParseString (text, new int [] { (int) AsnDeclarations.tokens.ObjectIdentifierValue_token }) == 0)
            {
                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                {
                    node.reparent (null);
                    Traverse (((asn_features) node).m_ObjectIdentifierValue);
                    p_Value.m_BuiltinValue.change (((asn_features) node).m_ObjectIdentifierValue);
                    p_Value.appInfo = ((asn_features) node).m_ObjectIdentifierValue;
                    return node;
                }
            }
            return null;
        }

        private static bool inited = false;
        private SymbolTable symbolTable = AsnDataBase.symbolTable;
        private AsnInspectorStack<NodeInspector> nodeInspectors = new AsnInspectorStack<NodeInspector> ();
        private AsnParserStack<AsnSymbol> contextStack = new AsnParserStack<AsnSymbol> ();
        private string currentFile;
        private ModuleDescriptor currentModuleDescriptor;
        private AsnSymbol currentModule = null;
        private AsnParserStack<AsnSymbol> moduleStack = new AsnParserStack<AsnSymbol> ();
        private AsnParserStack<ElementSetInspector> objSetConstraintStack = new AsnParserStack<ElementSetInspector> ();

        private ParameterDictionary ParameterCollection = AsnDataBase.ParameterCollection;

        private AsnSymbolCollector asnSymbolCollector = new AsnSymbolCollector ();
        private AsnModuleDereferencer asnModuleDereferencer = new AsnModuleDereferencer ();
        private NodeInspector embeddedPDVTypeInspector = null;
        private NodeInspector externalTypeInspector = null;
        private NodeInspector integerTypeInspector = null;

        private AssignmentDebugStack<SyntaxTreeBase> assignmentStack = new AssignmentDebugStack<SyntaxTreeBase> ();
        private FieldDebugStack<SyntaxTreeBase> fieldStack = new FieldDebugStack<SyntaxTreeBase> ();
        private ParameterizedDebugStack<SyntaxTreeBase> parameterizedStack = new ParameterizedDebugStack<SyntaxTreeBase> ();

        private NodeInspector tableConstraintLink = null;

        public bool Debug { get; set; } = false;

        private uint parStep = 0;
        private uint objStep = 0;
    }
}
