using Anglr.Parser.Core;
using Anglr.Parser.SyntaxTree;
using Anglr.Parser.Walker;
using Asn.Declarations;
using Asn.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AsnLibrary
{
    public class AsnComparer : IComparer<(string, string)>
    {
        public int Compare ((string, string) x, (string, string) y)
        {
            return -string.Compare (x.Item1, y.Item1);
        }
    }

    public class AsnSymbolCollector : SyntaxTreeWalker
    {
        private uint maxsize = 3;
        public AsnSymbolCollector ()
        {
            ModuleDefinition_Event += AsnSymbolCollector_ModuleDefinition_Event;
            ModuleIdentifier_Event += AsnSymbolCollector_ModuleIdentifier_Event;
            ModuleBody_Event += AsnSymbolCollector_ModuleBody_Event;
            SymbolsFromModule_Event += AsnSymbolCollector_SymbolsFromModule_Event;
            //DefinitiveObjIdComponent_Event += AsnSymbolCollector_DefinitiveObjIdComponent_Event;

            TypeAssignment_Event += AsnSymbolCollector_TypeAssignment_Event;
            ValueAssignment_Event += AsnSymbolCollector_ValueAssignment_Event;
            XMLValueAssignment_Event += AsnSymbolCollector_XMLValueAssignment_Event;
            ValueSetTypeAssignment_Event += AsnSymbolCollector_ValueSetTypeAssignment_Event;
            ObjectClassAssignment_Event += AsnSymbolCollector_ObjectClassAssignment_Event;
            ObjectAssignment_Event += AsnSymbolCollector_ObjectAssignment_Event;
            ObjectSetAssignment_Event += AsnSymbolCollector_ObjectSetAssignment_Event;
            ParameterizedTypeAssignment_Event += AsnSymbolCollector_ParameterizedTypeAssignment_Event;
            ParameterizedValueAssignment_Event += AsnSymbolCollector_ParameterizedValueAssignment_Event;
            ParameterizedValueSetTypeAssignment_Event += AsnSymbolCollector_ParameterizedValueSetTypeAssignment_Event;
            ParameterizedObjectClassAssignment_Event += AsnSymbolCollector_ParameterizedObjectClassAssignment_Event;
            ParameterizedObjectAssignment_Event += AsnSymbolCollector_ParameterizedObjectAssignment_Event;
            ParameterizedObjectSetAssignment_Event += AsnSymbolCollector_ParameterizedObjectSetAssignment_Event;
            MacroAssignment_Event += AsnSymbolCollector_MacroAssignment_Event;
            MacroDefinition_Event += AsnSymbolCollector_MacroDefinition_Event;

            //Type_Event += AsnSymbolCollector_Type_Event;
            //AnyType_Event += AsnSymbolCollector_AnyType_Event;
            //BitStringType_Event += AsnSymbolCollector_BitStringType_Event;
            //BooleanType_Event += AsnSymbolCollector_BooleanType_Event;
            //CharacterStringType_Event += AsnSymbolCollector_CharacterStringType_Event;
            //ChoiceType_Event += AsnSymbolCollector_ChoiceType_Event;
            //DateType_Event += AsnSymbolCollector_DateType_Event;
            //DateTimeType_Event += AsnSymbolCollector_DateTimeType_Event;
            //DurationType_Event += AsnSymbolCollector_DurationType_Event;
            //EmbeddedPDVType_Event += AsnSymbolCollector_EmbeddedPDVType_Event;
            //EnumeratedType_Event += AsnSymbolCollector_EnumeratedType_Event;
            //ExternalType_Event += AsnSymbolCollector_ExternalType_Event;
            //InstanceOfType_Event += AsnSymbolCollector_InstanceOfType_Event;
            //IntegerType_Event += AsnSymbolCollector_IntegerType_Event;
            //IRIType_Event += AsnSymbolCollector_IRIType_Event;
            //NullType_Event += AsnSymbolCollector_NullType_Event;
            //ObjectClassFieldType_Event += AsnSymbolCollector_ObjectClassFieldType_Event;
            //ObjectIdentifierType_Event += AsnSymbolCollector_ObjectIdentifierType_Event;
            //OctetStringType_Event += AsnSymbolCollector_OctetStringType_Event;
            //RealType_Event += AsnSymbolCollector_RealType_Event;
            //RelativeIRIType_Event += AsnSymbolCollector_RelativeIRIType_Event;
            //RelativeOIDType_Event += AsnSymbolCollector_RelativeOIDType_Event;
            //SequenceType_Event += AsnSymbolCollector_SequenceType_Event;
            //SequenceOfType_Event += AsnSymbolCollector_SequenceOfType_Event;
            //SetType_Event += AsnSymbolCollector_SetType_Event;
            //SetOfType_Event += AsnSymbolCollector_SetOfType_Event;
            //PrefixedType_Event += AsnSymbolCollector_PrefixedType_Event;
            //TimeType_Event += AsnSymbolCollector_TimeType_Event;
            //TimeOfDayType_Event += AsnSymbolCollector_TimeOfDayType_Event;

            //DefinedType_Event += AsnSymbolCollector_DefinedType_Event;
            //ExternalTypeReference_Event += AsnSymbolCollector_ExternalTypeReference_Event;
            //ParameterizedType_Event += AsnSymbolCollector_ParameterizedType_Event;
            //ParameterizedValueSetType_Event += AsnSymbolCollector_ParameterizedValueSetType_Event;
            //UsefulType_Event += AsnSymbolCollector_UsefulType_Event;
            //SelectionType_Event += AsnSymbolCollector_SelectionType_Event;
            //TypeFromObject_Event += AsnSymbolCollector_TypeFromObject_Event;
            //ValueSetFromObjects_Event += AsnSymbolCollector_ValueSetFromObjects_Event;
            //ConstrainedType_Event += AsnSymbolCollector_ConstrainedType_Event;
            //typereference_token_Event += AsnSymbolCollector_typereference_token_Event;
            //identifier_token_Event += AsnSymbolCollector_identifier_token_Event;

            //TypeOrNamedType_Event += AsnSymbolCollector_TypeOrNamedType_Event;
            //ComponentType_Event += AsnSymbolCollector_ComponentType_Event;
            //ComponentTypeLists_Event += AsnSymbolCollector_ComponentTypeLists_Event;
            //NamedBit_Event += AsnSymbolCollector_NamedBit_Event;
            //AltTypeOrNamedType_Event += AsnSymbolCollector_AltTypeOrNamedType_Event;
            //EnumerationItem_Event += AsnSymbolCollector_EnumerationItem_Event;

            ObjectClassDefn_Event += AsnSymbolCollector_ObjectClassDefn_Event;
            TypeFieldSpec_Event += AsnSymbolCollector_TypeFieldSpec_Event;
            FixedTypeValueFieldSpec_Event += AsnSymbolCollector_FixedTypeValueFieldSpec_Event;
            VariableTypeValueFieldSpec_Event += AsnSymbolCollector_VariableTypeValueFieldSpec_Event;
            FixedTypeValueSetFieldSpec_Event += AsnSymbolCollector_FixedTypeValueSetFieldSpec_Event;
            VariableTypeValueSetFieldSpec_Event += AsnSymbolCollector_VariableTypeValueSetFieldSpec_Event;
            ObjectFieldSpec_Event += AsnSymbolCollector_ObjectFieldSpec_Event;
            ObjectSetFieldSpec_Event += AsnSymbolCollector_ObjectSetFieldSpec_Event;

            SyntaxList_Event += AsnSymbolCollector_SyntaxList_Event;
            RequiredToken_Event += AsnSymbolCollector_RequiredToken_Event;
            OptionalGroup_Event += AsnSymbolCollector_OptionalGroup_Event;

            ParameterList_Event += AsnSymbolCollector_ParameterList_Event;
            Parameter_Event += AsnSymbolCollector_Parameter_Event;
            ActualParameterList_Event += (SyntaxTreeCallbackReason reason, ActualParameterList.production_kind kind, ActualParameterList p_ActualParameterList) => { return false; };

            //ObjIdComponents_Event += AsnSymbolCollector_ObjIdComponents_Event;
        }

        List<(string, string)> syntaxList;

        private bool AsnSymbolCollector_SyntaxList_Event (SyntaxTreeCallbackReason reason, SyntaxList.production_kind kind, SyntaxList p_SyntaxList)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    syntaxList = new List<(string, string)> ();
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    //syntaxList.Sort (new AsnComparer());
                    classGovernor.Patterns = syntaxList;
                    syntaxList = null;
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_RequiredToken_Event (SyntaxTreeCallbackReason reason, RequiredToken.production_kind kind, RequiredToken p_RequiredToken)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    switch ((LiteralSet.production_kind) p_RequiredToken.m_LiteralSet.kind)
                    {
                        case LiteralSet.production_kind.g_LiteralSet_1:
                            syntaxList.Add (("", p_RequiredToken.m_PrimitiveFieldName.Emit (-1)));
                            break;
                        case LiteralSet.production_kind.g_LiteralSet_2:
                        case LiteralSet.production_kind.g_LiteralSet_3:
                            syntaxList.Add ((p_RequiredToken.m_LiteralSet.Emit (-1), p_RequiredToken.m_PrimitiveFieldName.Emit (-1)));
                            break;
                    }
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_OptionalGroup_Event (SyntaxTreeCallbackReason reason, OptionalGroup.production_kind kind, OptionalGroup p_OptionalGroup)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    switch ((LiteralSet.production_kind) p_OptionalGroup.m_LiteralSet.kind)
                    {
                        case LiteralSet.production_kind.g_LiteralSet_1:
                            syntaxList.Add (("", ""));
                            break;
                        case LiteralSet.production_kind.g_LiteralSet_2:
                        case LiteralSet.production_kind.g_LiteralSet_3:
                            syntaxList.Add ((p_OptionalGroup.m_LiteralSet.Emit (-1), ""));
                            break;
                    }
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        //private bool AsnSymbolCollector_ParameterizedValueSetType_Event (SyntaxTreeCallbackReason reason, ParameterizedValueSetType.production_kind kind, ParameterizedValueSetType p_ParameterizedValueSetType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            if (insideDefinedType)
        //            {
        //                string typeName = $"defined_parameterized_value_set_{DefinedParameterizedValueSetTypeGovernor.Counter}";
        //                AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_ParameterizedValueSetType);
        //                symbolTable.add (asnSymbol);
        //                contextSymbols.Push (asnSymbol);
        //                typeStack.Push (new DefinedParameterizedValueSetTypeGovernor (p_ParameterizedValueSetType, asnSymbol));
        //            }
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_ParameterizedType_Event (SyntaxTreeCallbackReason reason, ParameterizedType.production_kind kind, ParameterizedType p_ParameterizedType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            if (insideDefinedType)
        //            {
        //                string typeName = $"defined_parameterized_type_{DefinedParameterizedTypeGovernor.Counter}";
        //                AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_ParameterizedType);
        //                symbolTable.add (asnSymbol);
        //                contextSymbols.Push (asnSymbol);
        //                typeStack.Push (new DefinedParameterizedTypeGovernor (p_ParameterizedType, asnSymbol));
        //            }
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_ExternalTypeReference_Event (SyntaxTreeCallbackReason reason, ExternalTypeReference.production_kind kind, ExternalTypeReference p_ExternalTypeReference)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            if (insideDefinedType)
        //            {
        //                string typeName = $"defined_external_type_reference_{DefinedExternalTypeReferenceGovernor.Counter}";
        //                AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_ExternalTypeReference);
        //                symbolTable.add (asnSymbol);
        //                contextSymbols.Push (asnSymbol);
        //                typeStack.Push (new DefinedExternalTypeReferenceGovernor (p_ExternalTypeReference, asnSymbol));
        //            }
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_ValueSetFromObjects_Event (SyntaxTreeCallbackReason reason, ValueSetFromObjects.production_kind kind, ValueSetFromObjects p_ValueSetFromObjects)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"value_set_from_object_{ValueSetFromObjectGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_ValueSetFromObjects);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new ValueSetFromObjectGovernor (p_ValueSetFromObjects, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_TypeFromObject_Event (SyntaxTreeCallbackReason reason, TypeFromObject.production_kind kind, TypeFromObject p_TypeFromObject)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"type_from_object_{TypeFromObjectGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_TypeFromObject);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new TypeFromObjectGovernor (p_TypeFromObject, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_SelectionType_Event (SyntaxTreeCallbackReason reason, SelectionType.production_kind kind, SelectionType p_SelectionType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"selection_type_{SelectionTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_SelectionType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new SelectionTypeGovernor (p_SelectionType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_UsefulType_Event (SyntaxTreeCallbackReason reason, UsefulType.production_kind kind, UsefulType p_UsefulType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"useful_type_{UsefulTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_UsefulType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new UsefulTypeGovernor (p_UsefulType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool insideDefinedType = false;
        //private bool AsnSymbolCollector_DefinedType_Event (SyntaxTreeCallbackReason reason, DefinedType.production_kind kind, DefinedType p_DefinedType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            insideDefinedType = true;
        //            if (kind != DefinedType.production_kind.g_DefinedType_2)
        //                break;
        //            string typeName = $"defined_type_{DefinedTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_DefinedType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new DefinedTypeGovernor (p_DefinedType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            insideDefinedType = false;
        //            break;
        //    }
        //    return true;
        //}

        private bool AsnSymbolCollector_ParameterList_Event (SyntaxTreeCallbackReason reason, ParameterList.production_kind kind, ParameterList p_ParameterList)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    parameters = new ListOfParameters ();
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    p_ParameterList.appInfo = parameters;
                    parameters = null;
                }
                break;
            }
            return true;
        }

        private bool AsnSymbolCollector_Parameter_Event (SyntaxTreeCallbackReason reason, Parameter.production_kind kind, Parameter p_Parameter)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    string name = p_Parameter.m_DummyReference.Emit (-1);
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_Parameter.m_DummyReference);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != null)
                        Console.Error.WriteLine ($"redefinition of parameter; file: {currentFile}, parameter: {name}");
                    else
                    {
                        symbolTable.add (asnSymbol);
                        asnSymbol.Flags |= AsnSymbol.Defined;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.ParameterSpecie;
                        p_Parameter.appInfo = asnSymbol;
                        parameters.Add (p_Parameter);
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

        private bool AsnSymbolCollector_ObjectSetFieldSpec_Event (SyntaxTreeCallbackReason reason, ObjectSetFieldSpec.production_kind kind, ObjectSetFieldSpec p_ObjectSetFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    typereference_token typereference_Token = p_ObjectSetFieldSpec.m_objectsetfieldreference_token.m_typereference_token;
                    string name = '&' + typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ObjectSetFieldSpec);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != null)
                        Console.Error.WriteLine ($"redefinition of class object set field: file: {currentFile}, field: {contextSymbols.Peek ().Name}.&{name}");
                    else
                    {
                        FieldSpec fieldSpec = (FieldSpec) p_ObjectSetFieldSpec.parent;
                        fieldSpec.appInfo = new ObjectSetFieldSpecInspector (p_ObjectSetFieldSpec);
                        symbolTable.add (asnSymbol);
                        asnSymbol.Flags |= AsnSymbol.Defined;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.ObjectSetFieldSpecie;
                        classGovernor.FieldSpecs [asnSymbol.Name] = fieldSpec;
                        typereference_Token.m_typereference.appInfo = asnSymbol;
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

        private bool AsnSymbolCollector_ObjectFieldSpec_Event (SyntaxTreeCallbackReason reason, ObjectFieldSpec.production_kind kind, ObjectFieldSpec p_ObjectFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    identifier_token identifier_Token = p_ObjectFieldSpec.m_objectfieldreference_token.m_identifier_token;
                    string name = '&' + identifier_Token.m_identifier.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ObjectFieldSpec);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != null)
                        Console.Error.WriteLine ($"redefinition of class object field: file: {currentFile}, field: {contextSymbols.Peek ().Name}.&{name}");
                    else
                    {
                        FieldSpec fieldSpec = (FieldSpec) p_ObjectFieldSpec.parent;
                        fieldSpec.appInfo = new ObjectFieldSpecInspector (p_ObjectFieldSpec);
                        symbolTable.add (asnSymbol);
                        asnSymbol.Flags |= AsnSymbol.Defined;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.ObjectFieldSpecie;
                        classGovernor.FieldSpecs [asnSymbol.Name] = fieldSpec;
                        identifier_Token.m_identifier.appInfo = asnSymbol;
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

        private bool AsnSymbolCollector_VariableTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason reason, VariableTypeValueSetFieldSpec.production_kind kind, VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    typereference_token typereference_Token = p_VariableTypeValueSetFieldSpec.m_valuesetfieldreference_token.m_typereference_token;
                    string name = '&' + typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_VariableTypeValueSetFieldSpec);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != null)
                        Console.Error.WriteLine ($"redefinition of class variable type value set field: file: {currentFile}, field: {contextSymbols.Peek ().Name}.&{name}");
                    else
                    {
                        FieldSpec fieldSpec = (FieldSpec) p_VariableTypeValueSetFieldSpec.parent;
                        fieldSpec.appInfo = new VariableTypeValueSetFieldSpecInspector (p_VariableTypeValueSetFieldSpec);
                        symbolTable.add (asnSymbol);
                        asnSymbol.Flags |= AsnSymbol.Defined;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.VariableTypeValueSetFieldSpecie;
                        classGovernor.FieldSpecs [asnSymbol.Name] = fieldSpec;
                        typereference_Token.m_typereference.appInfo = asnSymbol;
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

        private bool AsnSymbolCollector_FixedTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason reason, FixedTypeValueSetFieldSpec.production_kind kind, FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    typereference_token typereference_Token = p_FixedTypeValueSetFieldSpec.m_valuesetfieldreference_token.m_typereference_token;
                    string name = '&' + typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_FixedTypeValueSetFieldSpec);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != null)
                        Console.Error.WriteLine ($"redefinition of class fixed type value set field: file: {currentFile}, field: {contextSymbols.Peek ().Name}.&{name}");
                    else
                    {
                        FieldSpec fieldSpec = (FieldSpec) p_FixedTypeValueSetFieldSpec.parent;
                        fieldSpec.appInfo = new FixedTypeValueSetFieldSpecInspector (p_FixedTypeValueSetFieldSpec);
                        symbolTable.add (asnSymbol);
                        asnSymbol.Flags |= AsnSymbol.Defined;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.FixedTypeValueSetFieldSpecie;
                        classGovernor.FieldSpecs [asnSymbol.Name] = fieldSpec;
                        typereference_Token.m_typereference.appInfo = asnSymbol;
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

        private bool AsnSymbolCollector_VariableTypeValueFieldSpec_Event (SyntaxTreeCallbackReason reason, VariableTypeValueFieldSpec.production_kind kind, VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    identifier_token identifier_Token = p_VariableTypeValueFieldSpec.m_valuefieldreference_token.m_identifier_token;
                    string name = '&' + identifier_Token.m_identifier.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_VariableTypeValueFieldSpec);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != null)
                        Console.Error.WriteLine ($"redefinition of class variable type value field: file: {currentFile}, field: {contextSymbols.Peek ().Name}.&{name}");
                    else
                    {
                        FieldSpec fieldSpec = (FieldSpec) p_VariableTypeValueFieldSpec.parent;
                        fieldSpec.appInfo = new VariableTypeValueFieldSpecInspector (p_VariableTypeValueFieldSpec);
                        symbolTable.add (asnSymbol);
                        asnSymbol.Flags |= AsnSymbol.Defined;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.VariableTypeValueFieldSpecie;
                        classGovernor.FieldSpecs [asnSymbol.Name] = fieldSpec;
                        identifier_Token.m_identifier.appInfo = asnSymbol;
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

        private bool AsnSymbolCollector_FixedTypeValueFieldSpec_Event (SyntaxTreeCallbackReason reason, FixedTypeValueFieldSpec.production_kind kind, FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    identifier_token identifier_Token = p_FixedTypeValueFieldSpec.m_valuefieldreference_token.m_identifier_token;
                    string name = '&' + identifier_Token.m_identifier.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_FixedTypeValueFieldSpec);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != null)
                        Console.Error.WriteLine ($"redefinition of class fixed type value field: file: {currentFile}, field: {contextSymbols.Peek ().Name}.&{name}");
                    else
                    {
                        FieldSpec fieldSpec = (FieldSpec) p_FixedTypeValueFieldSpec.parent;
                        fieldSpec.appInfo = new FixedTypeValueFieldSpecInspector (p_FixedTypeValueFieldSpec);
                        symbolTable.add (asnSymbol);
                        asnSymbol.Flags |= AsnSymbol.Defined;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.FixedTypeValueFieldSpecie;
                        classGovernor.FieldSpecs [asnSymbol.Name] = fieldSpec;
                        identifier_Token.m_identifier.appInfo = asnSymbol;
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

        private bool AsnSymbolCollector_TypeFieldSpec_Event (SyntaxTreeCallbackReason reason, TypeFieldSpec.production_kind kind, TypeFieldSpec p_TypeFieldSpec)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    typereference_token typereference_Token = p_TypeFieldSpec.m_typefieldreference_token.m_typereference_token;
                    string name = '&' + typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_TypeFieldSpec);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != null)
                        Console.Error.WriteLine ($"redefinition of class type field: file: {currentFile}, field: {contextSymbols.Peek ().Name}.&{name}");
                    else
                    {
                        FieldSpec fieldSpec = (FieldSpec) p_TypeFieldSpec.parent;
                        fieldSpec.appInfo = new TypeFieldSpecInspector (p_TypeFieldSpec);
                        symbolTable.add (asnSymbol);
                        asnSymbol.Flags |= AsnSymbol.Defined;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.TypeFieldSpecie;
                        classGovernor.FieldSpecs [asnSymbol.Name] = fieldSpec;
                        typereference_Token.m_typereference.appInfo = asnSymbol;
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

        private bool AsnSymbolCollector_ObjectClassDefn_Event (SyntaxTreeCallbackReason reason, ObjectClassDefn.production_kind kind, ObjectClassDefn p_ObjectClassDefn)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    //string name = $"class_{classIndex++}";
                    //AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ObjectClassDefn);
                    //symbolTable.add (asnSymbol);
                    //asnSymbol.Specie = AsnSymbol.ClassSpecie;
                    classGovernor = new ObjectClassDefnInspector (p_ObjectClassDefn);
                    //contextSymbols.Push (asnSymbol);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    p_ObjectClassDefn.appInfo = classGovernor;
                    if (classGovernor.Patterns == null)
                        Console.Error.WriteLine ($"");
                    classGovernor = null;
                    //contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        //private bool AsnSymbolCollector_EnumerationItem_Event (SyntaxTreeCallbackReason reason, EnumerationItem.production_kind kind, EnumerationItem p_EnumerationItem)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            identifier_token identifier_Token = (kind == EnumerationItem.production_kind.g_EnumerationItem_1) ?
        //                p_EnumerationItem.m_identifier_token :
        //                p_EnumerationItem.m_NamedNumber.m_identifier_token;
        //            string name = identifier_Token.m_identifier.text;
        //            AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_EnumerationItem);
        //            AsnSymbol symbol = symbolTable.find (asnSymbol);
        //            if (symbol != null)
        //                Console.Error.WriteLine ($"redefined enumerated item: file: {currentFile}, item: {name}");
        //            else
        //            {
        //                identifier_Token.appInfo = asnSymbol;
        //                ListOfEnumerationItems enumerationItems = enumerationStack.Peek ();
        //                enumerationItems.Add (p_EnumerationItem);
        //                symbolTable.add (asnSymbol);
        //                asnSymbol.Flags |= AsnSymbol.Defined;
        //                identifier_Token.m_identifier.appInfo = asnSymbol;
        //            }
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_NamedBit_Event (SyntaxTreeCallbackReason reason, NamedBit.production_kind kind, NamedBit p_NamedBit)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //        {
        //            identifier_token identifier_Token = p_NamedBit.m_identifier_token;
        //            string name = identifier_Token.m_identifier.text;
        //            AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_NamedBit);
        //            AsnSymbol symbol = symbolTable.find (asnSymbol);
        //            if (symbol != null)
        //                Console.Error.WriteLine ($"redefined bit name: file: {currentFile}, name: {name}");
        //            else
        //            {
        //                identifier_Token.appInfo = asnSymbol;
        //                symbolTable.add (asnSymbol);
        //                asnSymbol.Flags |= AsnSymbol.Defined;
        //                bitListStack.Peek ().Add (p_NamedBit);
        //                identifier_Token.m_identifier.appInfo = asnSymbol;
        //            }
        //        }
        //        break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_ComponentType_Event (SyntaxTreeCallbackReason reason, ComponentType.production_kind kind, ComponentType p_ComponentType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            ListOfComponentTypes componentTypes = componentsStack.Peek ();
        //            componentTypes.Add (p_ComponentType);
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_ComponentTypeLists_Event (SyntaxTreeCallbackReason reason, ComponentTypeLists.production_kind kind, ComponentTypeLists p_ComponentTypeLists)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_TypeOrNamedType_Event (SyntaxTreeCallbackReason reason, TypeOrNamedType.production_kind kind, TypeOrNamedType p_TypeOrNamedType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //        {
        //            switch (kind)
        //            {
        //                case TypeOrNamedType.production_kind.g_TypeOrNamedType_1:
        //                {
        //                    p_TypeOrNamedType.appInfo = null;
        //                }
        //                break;
        //                case TypeOrNamedType.production_kind.g_TypeOrNamedType_2:
        //                {
        //                    identifier_token identifier_Token = p_TypeOrNamedType.m_NamedType.m_identifier_token;
        //                    string name = identifier_Token.m_identifier.text;
        //                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_TypeOrNamedType);
        //                    AsnSymbol symbol = symbolTable.find (asnSymbol);
        //                    if (symbol != null)
        //                        Console.Error.WriteLine ($"redefinition of component: file: {currentFile}, name: {name}");
        //                    else
        //                    {
        //                        identifier_Token.appInfo = asnSymbol;
        //                        symbolTable.add (symbol = asnSymbol);
        //                        symbol.Flags |= AsnSymbol.Defined;
        //                        identifier_Token.m_identifier.appInfo = asnSymbol;
        //                    }
        //                }
        //                break;
        //            }
        //        }
        //        break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_ObjIdComponents_Event (SyntaxTreeCallbackReason reason, ObjIdComponents.production_kind kind, ObjIdComponents p_ObjIdComponents)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string name = p_ObjIdComponents.getName ();
        //            if (name == null)
        //                break;
        //            AsnSymbol asnSymbol = new AsnSymbol (name, null, p_ObjIdComponents);
        //            AsnSymbol symbol = symbolTable.find (asnSymbol);
        //            if (symbol == null)
        //            {
        //                symbolTable.add (symbol = asnSymbol);
        //                asnSymbol.Flags |= AsnSymbol.Defined;
        //            }
        //            infoSetter.SetInfo (p_ObjIdComponents, symbol);
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_DefinitiveObjIdComponent_Event (SyntaxTreeCallbackReason reason, DefinitiveObjIdComponent.production_kind kind, DefinitiveObjIdComponent p_DefinitiveObjIdComponent)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string name = p_DefinitiveObjIdComponent.getName ();
        //            if (name == null)
        //                break;
        //            AsnSymbol asnSymbol = new AsnSymbol (name, null, p_DefinitiveObjIdComponent);
        //            AsnSymbol symbol = symbolTable.find (asnSymbol);
        //            if (symbol == null)
        //            {
        //                symbolTable.add (symbol = asnSymbol);
        //                asnSymbol.Flags |= AsnSymbol.Defined;
        //            }
        //            infoSetter.SetInfo (p_DefinitiveObjIdComponent, symbol);
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //public void AddFeature (asn_features asn_Features, string fileName) => asnFeatures.Add ((asn_Features, fileName));

        public void CollectModuleSymbols ()
        {
            contextSymbols.Push (null);
            foreach ((asn_features asn_Features, string fileName) asnFeature in asnFeatures)
            {
                currentFile = asnFeature.fileName;
                Traverse (asnFeature.asn_Features);
            }
            contextSymbols.Pop ();
        }

        //public void CollectGeneratedSymbols (AssignmentList assignmentList, string currentFile, AsnSymbol currentModule)
        //{
        //    this.currentFile = currentFile;
        //    this.currentModule = currentModule;
        //    contextSymbols.Push (currentModule);
        //    Traverse (assignmentList);
        //    contextSymbols.Pop ();
        //}

        private bool AsnSymbolCollector_ModuleDefinition_Event (SyntaxTreeCallbackReason reason, ModuleDefinition.production_kind kind, ModuleDefinition p_ModuleDefinition)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    currentModuleDefinition = p_ModuleDefinition;
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_ModuleIdentifier_Event (SyntaxTreeCallbackReason reason, ModuleIdentifier.production_kind kind, ModuleIdentifier p_ModuleIdentifier)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    typereference_token typereference_Token = p_ModuleIdentifier.m_modulereference_token.m_typereference_token;
                    string moduleName = p_ModuleIdentifier.m_modulereference_token.m_typereference_token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (moduleName, null, p_ModuleIdentifier);
                    AsnSymbol symbol;
                    if ((symbol = symbolTable.find (asnSymbol)) != null)
                    {
                        currentModule = symbol;
                        typereference_Token.m_typereference.appInfo = symbol;
                        //Console.Error.WriteLine ($"module redefinition: file: {currentFile}, module: {moduleName}");
                    }
                    else
                    {
                        typereference_Token.appInfo = asnSymbol;
                        asnSymbol.Flags |= AsnSymbol.Defined;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.ModuleSpecie;
                        currentModule = asnSymbol;
                        symbolTable.add (asnSymbol);
                        typereference_Token.m_typereference.appInfo = asnSymbol;
                    }
                    if (!moduleDefinitions.Keys.Contains (moduleName))
                        moduleDefinitions [moduleName] = new List<ModuleDescriptor> ();
                    moduleDefinitions [moduleName].Add (new ModuleDescriptor (currentModuleDefinition, currentModule, currentFile));
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_ModuleBody_Event (SyntaxTreeCallbackReason reason, ModuleBody.production_kind kind, ModuleBody p_ModuleBody)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    contextSymbols.Push (currentModule);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_SymbolsFromModule_Event (SyntaxTreeCallbackReason reason, SymbolsFromModule.production_kind kind, SymbolsFromModule p_SymbolsFromModule)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    for (SymbolList symbolList = p_SymbolsFromModule.m_SymbolList; symbolList != null; symbolList = symbolList.m_SymbolList)
                    {
                        Symbol symbol = symbolList.m_Symbol;
                        string name = symbol.getName ();
                        AsnSymbol importingSymbol = new AsnSymbol (name, contextSymbols.Peek (), symbol);
                        if (symbolTable.find (importingSymbol) != null)
                        {
                            if (ReportRedefinedReferences)
                                Console.Error.WriteLine ($"redeclaration of imported symbol: file: {currentFile}, symbol: {name}");
                            continue;
                        }
                        //symbol.appInfo = importingSymbol;
                        symbolTable.add (importingSymbol);
                        importingSymbol.Flags |= AsnSymbol.Defined | AsnSymbol.Imported;
                        importingSymbol.Specie = AsnSymbol.SymbolSpecie.ReferenceSpecie;
                        infoSetter.SetInfo (symbol, importingSymbol);
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

        private bool AsnSymbolCollector_TypeAssignment_Event (SyntaxTreeCallbackReason reason, TypeAssignment.production_kind kind, TypeAssignment p_TypeAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    typereference_token typereference_Token = p_TypeAssignment.m_typereference_token;
                    string name = typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_TypeAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        typereference_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.TypeSpecie;
                        symbolTable.add (asnSymbol);
                        typereference_Token.m_typereference.appInfo = asnSymbol;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_ValueAssignment_Event (SyntaxTreeCallbackReason reason, ValueAssignment.production_kind kind, ValueAssignment p_ValueAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    identifier_token identifier_Token = p_ValueAssignment.m_valuereference_token.m_identifier_token;
                    string name = identifier_Token.m_identifier.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ValueAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        identifier_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.ValueSpecie;
                        symbolTable.add (asnSymbol);
                        identifier_Token.m_identifier.appInfo = asnSymbol;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_XMLValueAssignment_Event (SyntaxTreeCallbackReason reason, XMLValueAssignment.production_kind kind, XMLValueAssignment p_XMLValueAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    identifier_token identifier_Token = p_XMLValueAssignment.m_valuereference_token.m_identifier_token;
                    string name = identifier_Token.m_identifier.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_XMLValueAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        identifier_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.XMLValueSpecie;
                        symbolTable.add (asnSymbol);
                        identifier_Token.m_identifier.appInfo = asnSymbol;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_ValueSetTypeAssignment_Event (SyntaxTreeCallbackReason reason, ValueSetTypeAssignment.production_kind kind, ValueSetTypeAssignment p_ValueSetTypeAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    typereference_token typereference_Token = p_ValueSetTypeAssignment.m_typereference_token;
                    string name = typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ValueSetTypeAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        typereference_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.ValueSetTypeSpecie;
                        symbolTable.add (asnSymbol);
                        typereference_Token.m_typereference.appInfo = asnSymbol;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_ObjectClassAssignment_Event (SyntaxTreeCallbackReason reason, ObjectClassAssignment.production_kind kind, ObjectClassAssignment p_ObjectClassAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    typereference_token typereference_Token = p_ObjectClassAssignment.m_objectclassreference_token.m_typereference_token;
                    string name = typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ObjectClassAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        typereference_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.ObjectClassSpecie;
                        symbolTable.add (asnSymbol);
                        typereference_Token.m_typereference.appInfo = asnSymbol;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_ObjectAssignment_Event (SyntaxTreeCallbackReason reason, ObjectAssignment.production_kind kind, ObjectAssignment p_ObjectAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    identifier_token identifier_Token = p_ObjectAssignment.m_objectreference_token.m_identifier_token;
                    string name = identifier_Token.m_identifier.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ObjectAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        identifier_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.ObjectSpecie;
                        symbolTable.add (asnSymbol);
                        identifier_Token.m_identifier.appInfo = asnSymbol;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_ObjectSetAssignment_Event (SyntaxTreeCallbackReason reason, ObjectSetAssignment.production_kind kind, ObjectSetAssignment p_ObjectSetAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    typereference_token typereference_Token = p_ObjectSetAssignment.m_objectsetreference_token.m_typereference_token;
                    string name = typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ObjectSetAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        typereference_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.ObjectSetSpecie;
                        symbolTable.add (asnSymbol);
                        typereference_Token.m_typereference.appInfo = asnSymbol;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_ParameterizedTypeAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedTypeAssignment.production_kind kind, ParameterizedTypeAssignment p_ParameterizedTypeAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    typereference_token typereference_Token = p_ParameterizedTypeAssignment.m_typereference_token;
                    string name = typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ParameterizedTypeAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        typereference_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.ParameterizedTypeSpecie;
                        symbolTable.add (asnSymbol);
                        typereference_Token.m_typereference.appInfo = asnSymbol;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.ParameterizedTypeSpecie;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                    ParameterCollection [symbol] = new ParameterizedTypeGovernor (p_ParameterizedTypeAssignment, symbol, "parameterized type");
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_ParameterizedValueAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedValueAssignment.production_kind kind, ParameterizedValueAssignment p_ParameterizedValueAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    identifier_token identifier_Token = p_ParameterizedValueAssignment.m_valuereference_token.m_identifier_token;
                    string name = identifier_Token.m_identifier.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ParameterizedValueAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        identifier_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.ParameterizedValueSpecie;
                        symbolTable.add (asnSymbol);
                        identifier_Token.m_identifier.appInfo = asnSymbol;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.ParameterizedValueSpecie;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                    ParameterCollection [symbol] = new ParameterizedValueGovernor (p_ParameterizedValueAssignment, symbol, "parameterized value");
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_ParameterizedValueSetTypeAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedValueSetTypeAssignment.production_kind kind, ParameterizedValueSetTypeAssignment p_ParameterizedValueSetTypeAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    typereference_token typereference_Token = p_ParameterizedValueSetTypeAssignment.m_typereference_token;
                    string name = typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ParameterizedValueSetTypeAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        typereference_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.ParameterizedValueSetTypeSpecie;
                        symbolTable.add (asnSymbol);
                        typereference_Token.m_typereference.appInfo = asnSymbol;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.ParameterizedValueSetTypeSpecie;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                    ParameterCollection [symbol] = new ParameterizedValueSetTypeGovernor (p_ParameterizedValueSetTypeAssignment, symbol, "parameterized value set type");
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_ParameterizedObjectClassAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedObjectClassAssignment.production_kind kind, ParameterizedObjectClassAssignment p_ParameterizedObjectClassAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    typereference_token typereference_Token = p_ParameterizedObjectClassAssignment.m_objectclassreference_token.m_typereference_token;
                    string name = typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ParameterizedObjectClassAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        typereference_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.ParameterizedObjectClassSpecie;
                        symbolTable.add (asnSymbol);
                        typereference_Token.m_typereference.appInfo = asnSymbol;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.ParameterizedObjectClassSpecie;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                    ParameterCollection [symbol] = new ParameterizedObjectClassGovernor (p_ParameterizedObjectClassAssignment, symbol, "parameterized object class");
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_ParameterizedObjectAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedObjectAssignment.production_kind kind, ParameterizedObjectAssignment p_ParameterizedObjectAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    identifier_token identifier_Token = p_ParameterizedObjectAssignment.m_objectreference_token.m_identifier_token;
                    string name = identifier_Token.m_identifier.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ParameterizedObjectAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        identifier_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.ParameterizedObjectSpecie;
                        symbolTable.add (asnSymbol);
                        identifier_Token.m_identifier.appInfo = asnSymbol;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.ParameterizedObjectSpecie;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                    ParameterCollection [symbol] = new ParameterizedObjectGovernor (p_ParameterizedObjectAssignment, symbol, "parameterized object");
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_ParameterizedObjectSetAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedObjectSetAssignment.production_kind kind, ParameterizedObjectSetAssignment p_ParameterizedObjectSetAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    typereference_token typereference_Token = p_ParameterizedObjectSetAssignment.m_objectsetreference_token.m_typereference_token;
                    string name = typereference_Token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_ParameterizedObjectSetAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        typereference_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.ParameterizedObjectSetSpecie;
                        symbolTable.add (asnSymbol);
                        typereference_Token.m_typereference.appInfo = asnSymbol;
                        asnSymbol.Specie = AsnSymbol.SymbolSpecie.ParameterizedObjectSetSpecie;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                    ParameterCollection [symbol] = new ParameterizedObjectSetGovernor (p_ParameterizedObjectSetAssignment, symbol, "parameterized object set");
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_MacroAssignment_Event (SyntaxTreeCallbackReason reason, MacroAssignment.production_kind kind, MacroAssignment p_MacroAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    identifier_token identifier_Token = p_MacroAssignment.m_valuereference_token.m_identifier_token;
                    string name = identifier_Token.m_identifier.text;
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_MacroAssignment);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        identifier_Token.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.MacroVarSpecie;
                        symbolTable.add (asnSymbol);
                        identifier_Token.m_identifier.appInfo = asnSymbol;
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        private bool AsnSymbolCollector_MacroDefinition_Event (SyntaxTreeCallbackReason reason, MacroDefinition.production_kind kind, MacroDefinition p_MacroDefinition)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    MacroIdentifier macroIdentifier = p_MacroDefinition.m_MacroIdentifier;
                    string name = macroIdentifier.Emit (-1);
                    AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), p_MacroDefinition);
                    AsnSymbol symbol = symbolTable.find (asnSymbol);
                    if (symbol != asnSymbol)
                    {
                        macroIdentifier.appInfo = asnSymbol;
                        (symbol = asnSymbol).Flags |= AsnSymbol.Defined;
                        //asnSymbol.Specie = AsnSymbol.MacroSpecie;
                        symbolTable.add (asnSymbol);
                    }
                    else
                        Console.Error.WriteLine ($"redefinition of symbol: file: {currentFile}, symbol: {name}");
                    contextSymbols.Push (symbol);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    contextSymbols.Pop ();
                    break;
            }
            return true;
        }

        //private bool AsnSymbolCollector_Type_Event (SyntaxTreeCallbackReason reason, Asn.Parser.Type.production_kind kind, Asn.Parser.Type p_Type)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            // typeStack.push is invoked in event handlers for specific types
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //        {
        //            p_Type.appInfo = typeStack.Peek ();
        //            typeStack.Pop ();
        //            contextSymbols.Pop ();
        //        }
        //        break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_ConstrainedType_Event (SyntaxTreeCallbackReason reason, ConstrainedType.production_kind kind, ConstrainedType p_ConstrainedType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"constrained_type_{ConstrainedTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_ConstrainedType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new ConstrainedTypeGovernor (p_ConstrainedType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_TimeOfDayType_Event (SyntaxTreeCallbackReason reason, TimeOfDayType.production_kind kind, TimeOfDayType p_TimeOfDayType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"time_of_day_type_{TimeOfDayTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_TimeOfDayType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new TimeOfDayTypeGovernor (p_TimeOfDayType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_TimeType_Event (SyntaxTreeCallbackReason reason, TimeType.production_kind kind, TimeType p_TimeType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"time_type_{TimeTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_TimeType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new TimeTypeGovernor (p_TimeType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_PrefixedType_Event (SyntaxTreeCallbackReason reason, PrefixedType.production_kind kind, PrefixedType p_PrefixedType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"prefixed_type_{PrefixedTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_PrefixedType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new PrefixedTypeGovernor (p_PrefixedType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_SetOfType_Event (SyntaxTreeCallbackReason reason, SetOfType.production_kind kind, SetOfType p_SetOfType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"set_of_type_{SetOfTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_SetOfType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new SetOfTypeGovernor (p_SetOfType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_SetType_Event (SyntaxTreeCallbackReason reason, SetType.production_kind kind, SetType p_SetType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"set_type_{SetTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_SetType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            SetTypeGovernor setTypeGovernor = new SetTypeGovernor (p_SetType, asnSymbol);
        //            typeStack.Push (setTypeGovernor);
        //            componentsStack.Push (setTypeGovernor.ComponentTypes);
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            componentsStack.Pop ();
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_SequenceOfType_Event (SyntaxTreeCallbackReason reason, SequenceOfType.production_kind kind, SequenceOfType p_SequenceOfType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"sequence_of_type_{SequenceOfTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_SequenceOfType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new SequenceOfTypeGovernor (p_SequenceOfType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_SequenceType_Event (SyntaxTreeCallbackReason reason, SequenceType.production_kind kind, SequenceType p_SequenceType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"sequence_type_{SequenceTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_SequenceType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            SequenceTypeGovernor sequenceTypeGovernor = new SequenceTypeGovernor (p_SequenceType, asnSymbol);
        //            typeStack.Push (sequenceTypeGovernor);
        //            componentsStack.Push (sequenceTypeGovernor.ComponentTypes);
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            componentsStack.Pop ();
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_RelativeOIDType_Event (SyntaxTreeCallbackReason reason, RelativeOIDType.production_kind kind, RelativeOIDType p_RelativeOIDType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"relative_oid_type_{RelativeOIDTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_RelativeOIDType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new RelativeOIDTypeGovernor (p_RelativeOIDType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_RelativeIRIType_Event (SyntaxTreeCallbackReason reason, RelativeIRIType.production_kind kind, RelativeIRIType p_RelativeIRIType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"relative_iri_type_{RelativeIRITypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_RelativeIRIType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new RelativeIRITypeGovernor (p_RelativeIRIType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_RealType_Event (SyntaxTreeCallbackReason reason, RealType.production_kind kind, RealType p_RealType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"real_type_{RealTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_RealType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new RealTypeGovernor (p_RealType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_OctetStringType_Event (SyntaxTreeCallbackReason reason, OctetStringType.production_kind kind, OctetStringType p_OctetStringType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"octet_string_type_{OctetStringTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_OctetStringType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new OctetStringTypeGovernor (p_OctetStringType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_ObjectIdentifierType_Event (SyntaxTreeCallbackReason reason, ObjectIdentifierType.production_kind kind, ObjectIdentifierType p_ObjectIdentifierType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"object_identifier_type_{ObjectIdentifierTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_ObjectIdentifierType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new ObjectIdentifierTypeGovernor (p_ObjectIdentifierType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_ObjectClassFieldType_Event (SyntaxTreeCallbackReason reason, ObjectClassFieldType.production_kind kind, ObjectClassFieldType p_ObjectClassFieldType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"object_class_field_type_{ObjectClassFieldTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_ObjectClassFieldType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new ObjectClassFieldTypeGovernor (p_ObjectClassFieldType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_NullType_Event (SyntaxTreeCallbackReason reason, NullType.production_kind kind, NullType p_NullType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"null_type_{NullTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_NullType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new NullTypeGovernor (p_NullType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_IRIType_Event (SyntaxTreeCallbackReason reason, IRIType.production_kind kind, IRIType p_IRIType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"iri_type_{IRITypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_IRIType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new IRITypeGovernor (p_IRIType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_IntegerType_Event (SyntaxTreeCallbackReason reason, IntegerType.production_kind kind, IntegerType p_IntegerType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"integer_type_{IntegerTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_IntegerType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new IntegerTypeGovernor (p_IntegerType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //        {
        //            if (kind != IntegerType.production_kind.g_IntegerType_2)
        //                break;
        //            IntegerTypeGovernor integerTypeGovernor = (IntegerTypeGovernor) typeStack.Peek ();
        //            NamedNumberList namedNumberList = p_IntegerType.m_NamedNumberList;
        //            NamedNumberList numberList;
        //            for (numberList = namedNumberList; namedNumberList != null; namedNumberList = namedNumberList.m_NamedNumberList)
        //                numberList = namedNumberList;
        //            for (SyntaxTreeBase node = numberList; node is NamedNumberList; node = node.parent)
        //            {
        //                NamedNumber namedNumber = ((NamedNumberList) node).m_NamedNumber;
        //                identifier_token identifier_Token = namedNumber.m_identifier_token;
        //                string name = identifier_Token.m_identifier.text;
        //                AsnSymbol asnSymbol = new AsnSymbol (name, contextSymbols.Peek (), namedNumber);
        //                AsnSymbol symbol = symbolTable.find (asnSymbol);
        //                if (symbol != null)
        //                    Console.Error.WriteLine ($"redefinition of integer symbol: file: {currentFile}, name: {name}");
        //                else
        //                {
        //                    identifier_Token.appInfo = asnSymbol;
        //                    symbolTable.add (asnSymbol);
        //                    asnSymbol.Flags |= AsnSymbol.Defined;
        //                    integerTypeGovernor.NamedNumbers.Add (namedNumber);
        //                    identifier_Token.m_identifier.appInfo = asnSymbol;
        //                }
        //            }
        //            integerTypeGovernor = null;
        //        }
        //        // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //        break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_InstanceOfType_Event (SyntaxTreeCallbackReason reason, InstanceOfType.production_kind kind, InstanceOfType p_InstanceOfType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"instance_of_type_{InstanceOfTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_InstanceOfType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new InstanceOfTypeGovernor (p_InstanceOfType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_ExternalType_Event (SyntaxTreeCallbackReason reason, ExternalType.production_kind kind, ExternalType p_ExternalType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"external_type_{ExternalTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_ExternalType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new ExternalTypeGovernor (p_ExternalType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_EnumeratedType_Event (SyntaxTreeCallbackReason reason, EnumeratedType.production_kind kind, EnumeratedType p_EnumeratedType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"enumerated_type_{EnumeratedTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_EnumeratedType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            EnumeratedTypeGovernor enumeratedTypeGovernor = new EnumeratedTypeGovernor (p_EnumeratedType, asnSymbol);
        //            typeStack.Push (enumeratedTypeGovernor);
        //            enumerationStack.Push (enumeratedTypeGovernor.EnumerationItems);
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            enumerationStack.Pop ();
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_EmbeddedPDVType_Event (SyntaxTreeCallbackReason reason, EmbeddedPDVType.production_kind kind, EmbeddedPDVType p_EmbeddedPDVType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"embedded_pdv_type_{EmbeddedPDVTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_EmbeddedPDVType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new EmbeddedPDVTypeGovernor (p_EmbeddedPDVType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_DurationType_Event (SyntaxTreeCallbackReason reason, DurationType.production_kind kind, DurationType p_DurationType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"duration_type_{DurationTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_DurationType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new DurationTypeGovernor (p_DurationType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_DateTimeType_Event (SyntaxTreeCallbackReason reason, DateTimeType.production_kind kind, DateTimeType p_DateTimeType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"date_and_time_type_{DateTimeTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_DateTimeType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new DateTimeTypeGovernor (p_DateTimeType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_DateType_Event (SyntaxTreeCallbackReason reason, DateType.production_kind kind, DateType p_DateType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"date_type_{DateTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_DateType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new DateTypeGovernor (p_DateType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_ChoiceType_Event (SyntaxTreeCallbackReason reason, ChoiceType.production_kind kind, ChoiceType p_ChoiceType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"choice_type_{ChoiceTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_ChoiceType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            ChoiceTypeGovernor choiceTypeGovernor = new ChoiceTypeGovernor (p_ChoiceType, asnSymbol);
        //            typeStack.Push (choiceTypeGovernor);
        //            alternativesStack.Push (choiceTypeGovernor.TypeOrNamedTypes);
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            alternativesStack.Pop ();
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_CharacterStringType_Event (SyntaxTreeCallbackReason reason, CharacterStringType.production_kind kind, CharacterStringType p_CharacterStringType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"character_string_type_{CharacterStringTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_CharacterStringType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new CharacterStringTypeGovernor (p_CharacterStringType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_BooleanType_Event (SyntaxTreeCallbackReason reason, BooleanType.production_kind kind, BooleanType p_BooleanType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"boolean_type_{BooleanTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_BooleanType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new BooleanTypeGovernor (p_BooleanType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_BitStringType_Event (SyntaxTreeCallbackReason reason, BitStringType.production_kind kind, BitStringType p_BitStringType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"bit_string_type_{BitStringTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_BitStringType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            BitStringTypeGovernor bitStringTypeGovernor = new BitStringTypeGovernor (p_BitStringType, asnSymbol);
        //            typeStack.Push (bitStringTypeGovernor);
        //            bitListStack.Push (bitStringTypeGovernor.NamedBits);
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            bitListStack.Pop ();
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_AnyType_Event (SyntaxTreeCallbackReason reason, AnyType.production_kind kind, AnyType p_AnyType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string typeName = $"any_type_{AnyTypeGovernor.Counter}";
        //            AsnSymbol asnSymbol = new AsnSymbol (typeName, contextSymbols.Peek (), p_AnyType);
        //            symbolTable.add (asnSymbol);
        //            contextSymbols.Push (asnSymbol);
        //            typeStack.Push (new AnyTypeGovernor (p_AnyType, asnSymbol));
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            // typeStack.Pop is invoked in AsnSymbolCollector_Type_Event
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_typereference_token_Event (SyntaxTreeCallbackReason reason, typereference_token.production_kind kind, typereference_token p_typereference_token)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            SyntaxTreeBase parent;
        //            for (parent = p_typereference_token.parent; (parent != null) && !(parent is Asn.Parser.Type); parent = parent.parent)
        //                ;
        //            if (parent == null)
        //                break;
        //            Console.Error.WriteLine ($"typereference: file: {currentFile}, symbol: {p_typereference_token.m_typereference.text}");
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnSymbolCollector_identifier_token_Event (SyntaxTreeCallbackReason reason, identifier_token.production_kind kind, identifier_token p_identifier_token)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            SyntaxTreeBase parent;
        //            for (parent = p_identifier_token.parent; (parent != null) && !(parent is Asn.Parser.Type); parent = parent.parent)
        //                ;
        //            if (parent == null)
        //                break;
        //            Console.Error.WriteLine ($"identifier: file: {currentFile}, symbol: {p_identifier_token.m_identifier.text}");
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        public void UniteModules ()
        {
            foreach (List<ModuleDescriptor> moduleDescriptors in AsnDataBase.accumulatedModuleDefinitions.Values)
            {
                ModuleDefinition moduleDefinition = UniteModules (moduleDescriptors);
            }
        }

        private ModuleDefinition UniteModules (List <ModuleDescriptor> moduleDescriptors)
        {
            string moduleName = null;
            string definitiveId = null;
            string encodingRef = null;
            string tagDef = null;
            string extensionDef = null;
            string encCtrl = null;
            string expStr = null;
            string impStr = null;
            string assignmentStr = null;
            string modStr = null;
            foreach (ModuleDescriptor moduleDescriptor in moduleDescriptors)
            {
                ModuleDefinition moduleDefinition = moduleDescriptor.moduleDefinition;
                ModuleIdentifier moduleIdentifier = moduleDefinition.m_ModuleIdentifier;
                modulereference_token modulereference_Token = moduleIdentifier.m_modulereference_token;
                DefinitiveIdentification definitiveIdentification = moduleIdentifier.m_DefinitiveIdentification;
                EncodingReferenceDefault encodingReferenceDefault = moduleDefinition.m_EncodingReferenceDefault;
                TagDefault tagDefault = moduleDefinition.m_TagDefault;
                ExtensionDefault extensionDefault = moduleDefinition.m_ExtensionDefault;
                EncodingControlSections encodingControlSections = moduleDefinition.m_EncodingControlSections;
                ModuleBody moduleBody= moduleDefinition.m_ModuleBody;
                Exports exports = moduleBody.m_Exports;
                Imports imports = moduleBody.m_Imports;
                AssignmentList assignmentList = moduleBody.m_AssignmentList;

                if (moduleName != null)
                {
                    if (moduleName != modulereference_Token.m_typereference_token.m_typereference.text)
                        continue;
                }
                else
                    moduleName = modulereference_Token.m_typereference_token.m_typereference.text;
                if ((DefinitiveIdentification.production_kind) definitiveIdentification.kind != DefinitiveIdentification.production_kind.g_DefinitiveIdentification_3)
                {
                    string definitiveIdString = definitiveIdentification.Emit (-1);
                    if (definitiveId != null)
                    {
                        if (definitiveId != definitiveIdString)
                            Console.Error.WriteLine ($"ERROR: united modules named {moduleName} have different identifications {definitiveId} and {definitiveIdString}");
                    }
                    else
                        definitiveId = definitiveIdString;
                }
                if ((EncodingReferenceDefault.production_kind) encodingReferenceDefault.kind != EncodingReferenceDefault.production_kind.g_EncodingReferenceDefault_2)
                {
                    string encodingRefString = encodingReferenceDefault.Emit (-1);
                    if (encodingRef != null)
                    {
                        if (encodingRef != encodingRefString)
                            Console.Error.WriteLine ($"ERROR: united modules named {moduleName} have different encoding references {encodingRef} and {encodingRefString}");
                    }
                    else
                        encodingRef = encodingRefString;
                }
                if ((TagDefault.production_kind) tagDefault.kind != TagDefault.production_kind.g_TagDefault_4)
                {
                    string tagDefString = tagDefault.Emit (-1);
                    if (tagDef != null)
                    {
                        if (tagDef != tagDefString)
                            Console.Error.WriteLine ($"ERROR: united modules named {moduleName} have different teg defaults {tagDef} and {tagDefString}");
                    }
                    else
                        tagDef = tagDefString;
                }
                if ((ExtensionDefault.production_kind) extensionDefault.kind != ExtensionDefault.production_kind.g_ExtensionDefault_2)
                {
                    extensionDef = extensionDefault.Emit (-1);
                }
                if ((EncodingControlSections.production_kind) encodingControlSections.kind != EncodingControlSections.production_kind.g_EncodingControlSections_1)
                {
                    if (encCtrl != null)
                        encCtrl += $" {encodingControlSections.Emit (-1)}";
                    else
                        encCtrl = encodingControlSections.Emit (-1);
                }
                if ((Exports.production_kind) exports.kind != Exports.production_kind.g_Exports_3)
                {
                    if (expStr != null)
                        expStr += $" {exports.m_SymbolsExported.Emit (-1)}";
                    else
                        expStr = exports.m_SymbolsExported.Emit (-1);
                }
                if ((Imports.production_kind) imports.kind != Imports.production_kind.g_Imports_2)
                {
                    if (impStr != null)
                        impStr += $" {imports.m_SymbolsImported.Emit (-1)}";
                    else
                        impStr = imports.m_SymbolsImported.Emit (-1);
                }
                if (assignmentStr != null)
                    assignmentStr += $" {assignmentList.Emit (-1)}";
                else
                    assignmentStr = assignmentList.Emit (-1);
            }

            if (moduleName == null)
                return null;
            modStr = moduleName;
            if (definitiveId != null)
                modStr += $" {definitiveId}";
            modStr += " DEFINITIONS";
            if (encodingRef != null)
                modStr += $" {encodingRef}";
            if (tagDef != null)
                modStr += $" {tagDef}";
            if (extensionDef != null)
                modStr += $" {extensionDef}";
            modStr += " ::= BEGIN";
            if (expStr != null)
                modStr += $" EXPORTS {expStr};";
            if (impStr != null)
                modStr += $" IMPORTS {impStr};";
            if (assignmentStr != null)
                modStr += $" {assignmentStr}";
            if (encCtrl != null)
                modStr += $" {encCtrl}";
            modStr += " END";

            Console.WriteLine ("FORMTED MODULES:");
            AsnModuleFormatter asnModuleFormatter = new AsnModuleFormatter (Console.Out);
            AsnCompiler asnCompiler = new AsnCompiler();
            asnCompiler.Error_Event += (lineno, column, token, tokenString)=> { return false; };
            if (asnCompiler.ParseString (modStr, new int [] { (int) AsnDeclarations.tokens.ModuleDefinitions_token}) == 0)
            {
                foreach (SyntaxTreeBase node in asnCompiler.parseList)
                {
                    //node.reparent (null);
                    asnModuleFormatter.Format (((asn_features) node).m_ModuleDefinitions.m_ModuleDefinition);
                    return ((asn_features) node).m_ModuleDefinitions.m_ModuleDefinition;
                }
            }
            return null;
        }

        private bool AsnCompiler_Error_Event (int lineno, int column, int token, string tokenString)
        {
            throw new NotImplementedException ();
        }

        private AsnAppInfoSetter infoSetter = new AsnAppInfoSetter ();

        private List<(asn_features, string)> asnFeatures = AsnDataBase.asnFeatures;
        private ModuleCollection moduleDefinitions = AsnDataBase.moduleDefinitions;
        private SymbolTable symbolTable = AsnDataBase.symbolTable;
        private ReferenceCollection referenceCollection = AsnDataBase.referenceCollection;
        private ParameterDictionary ParameterCollection = AsnDataBase.ParameterCollection;

        private string currentFile;
        private Stack<AsnSymbol> contextSymbols = new Stack<AsnSymbol> ();
        private AsnSymbol currentModule = null;
        private ModuleDefinition currentModuleDefinition = null;
        private ObjectClassDefnInspector classGovernor = null;
        private ListOfParameters parameters = null;

        private uint classIndex = 0;
        public static bool ReportRedefinedReferences { get; set; } = true;
    }
}
