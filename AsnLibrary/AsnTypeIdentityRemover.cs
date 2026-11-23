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
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.SymbolStore;
using static Asn.Declarations.AsnDeclarations;

namespace AsnLibrary
{
    public class AsnTypeIdentityRemover : SyntaxTreeWalker
    {
        private SymbolTable symbolTable = AsnDataBase.symbolTable;
        private AsnSymbol moduleContext = null;
        public uint typeCount { get; private set; } = 0;
        public uint typeIdentities { get; private set; } = 0;
        public uint refIdentities { get; private set; } = 0;
        public uint valueCount { get; private set; } = 0;
        public uint valueIdentities { get; private set; } = 0;
        public uint valueSetCount { get; private set; } = 0;
        public uint valueSetIdentities { get; private set; } = 0;
        public uint objectClassCount { get; private set; } = 0;
        public uint objectClassIdentities { get; private set; } = 0;
        public uint objectCount { get; private set; } = 0;
        public uint objectIdentities { get; private set; } = 0;
        public uint objectSetCount { get; private set; } = 0;
        public uint objectSetIdentities { get; private set; } = 0;

        public AsnTypeIdentityRemover ()
        {
            TypeAssignment_Event += AsnTypeIdentityRemover_TypeAssignment_Event;
            ValueAssignment_Event += AsnTypeIdentityRemover_ValueAssignment_Event;
            XMLValueAssignment_Event += AsnTypeIdentityRemover_XMLValueAssignment_Event;
            ValueSetTypeAssignment_Event += AsnTypeIdentityRemover_ValueSetTypeAssignment_Event;
            ObjectClassAssignment_Event += AsnTypeIdentityRemover_ObjectClassAssignment_Event;
            ObjectAssignment_Event += AsnTypeIdentityRemover_ObjectAssignment_Event;
            ObjectSetAssignment_Event += AsnTypeIdentityRemover_ObjectSetAssignment_Event;
            ParameterizedAssignment_Event += AsnTypeIdentityRemover_ParameterizedAssignment_Event;
            MacroAssignment_Event += AsnTypeIdentityRemover_MacroAssignment_Event;
            MacroDefinition_Event += AsnTypeIdentityRemover_MacroDefinition_Event;
        }

        private bool AsnTypeIdentityRemover_TypeAssignment_Event (SyntaxTreeCallbackReason reason, TypeAssignment.production_kind kind, TypeAssignment p_TypeAssignment)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            ++typeCount;
            Asn.Parser.Type type = p_TypeAssignment.m_Type;
            if ((Asn.Parser.Type.production_kind) type.kind != Asn.Parser.Type.production_kind.g_Type_2)
                return true;
            ReferencedType referencedType = type.m_ReferencedType;
            if ((ReferencedType.production_kind) referencedType.kind != ReferencedType.production_kind.g_ReferencedType_1)
                return true;
            DefinedType definedType = referencedType.m_DefinedType;
            switch ((DefinedType.production_kind) definedType.kind)
            {
                case DefinedType.production_kind.g_DefinedType_1:
                {
                    ExternalTypeReference externalTypeReference = definedType.m_ExternalTypeReference;
                    string moduleName = externalTypeReference.m_modulereference_token.m_typereference_token.m_typereference.text;
                    AsnSymbol moduleRef = symbolTable.find (new AsnSymbol (moduleName, null, null));
                    if (moduleRef == null)
                        return true;
                    string typeName = externalTypeReference.m_typereference_token.m_typereference.text;
                    AsnSymbol typeRef = symbolTable.find (new AsnSymbol (typeName, moduleRef, null));
                    if (typeRef == null)
                        return true;
                    Console.WriteLine ($"TYPE IDENTITY: {p_TypeAssignment.m_typereference_token.m_typereference.text} ::= {moduleName}.{typeName}");
                    ((AsnSymbol) p_TypeAssignment.m_typereference_token.m_typereference.appInfo).Identity = typeRef;
                    switch (typeRef.Specie)
                    {
                        case AsnSymbol.SymbolSpecie.TypeSpecie:
                            ++typeIdentities;
                            break;
                        case AsnSymbol.SymbolSpecie.ReferenceSpecie:
                            ++refIdentities;
                            break;
                        default:
                            break;
                    }
                }
                break;
                case DefinedType.production_kind.g_DefinedType_2:
                {
                    string typeName = definedType.m_typereference_token.m_typereference.text;
                    AsnSymbol typeRef = symbolTable.find (new AsnSymbol (typeName, moduleContext, null));
                    if (typeRef == null)
                        return true;
                    Console.WriteLine ($"TYPE IDENTITY: {p_TypeAssignment.m_typereference_token.m_typereference.text} ::= {typeName}");
                    ((AsnSymbol) p_TypeAssignment.m_typereference_token.appInfo).Identity = typeRef;
                    switch (typeRef.Specie)
                    {
                        case AsnSymbol.SymbolSpecie.TypeSpecie:
                            ++typeIdentities;
                            break;
                        case AsnSymbol.SymbolSpecie.ReferenceSpecie:
                            ++refIdentities;
                            break;
                        default:
                            break;
                    }
                }
                break;
                case DefinedType.production_kind.g_DefinedType_3:
                    return true;
                case DefinedType.production_kind.g_DefinedType_4:
                    return true;
            }
            return true;
        }

        private bool AsnTypeIdentityRemover_ValueAssignment_Event (SyntaxTreeCallbackReason reason, ValueAssignment.production_kind kind, ValueAssignment p_ValueAssignment)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            ++valueCount;
            Value value = p_ValueAssignment.m_Value;
            if ((Value.production_kind) value.kind != Value.production_kind.g_Value_2)
                return true;
            ReferencedValue referencedValue = value.m_ReferencedValue;
            if ((ReferencedValue.production_kind) referencedValue.kind != ReferencedValue.production_kind.g_ReferencedValue_1)
                return true;
            DefinedValue definedValue = referencedValue.m_DefinedValue;
            switch ((DefinedValue.production_kind) definedValue.kind)
            {
                case DefinedValue.production_kind.g_DefinedValue_1:
                {
                    ExternalValueReference valueReference = definedValue.m_ExternalValueReference;
                    string moduleName = valueReference.m_modulereference_token.m_typereference_token.m_typereference.text;
                    AsnSymbol moduleRef = symbolTable.find (new AsnSymbol (moduleName, null, null));
                    if (moduleRef == null)
                        return true;
                    string valueName = valueReference.m_valuereference_token.m_identifier_token.m_identifier.text;
                    AsnSymbol valueRef = symbolTable.find (new AsnSymbol (valueName, moduleRef, null));
                    if (valueRef == null)
                        return true;
                    Console.WriteLine ($"VALUE IDENTITY: {p_ValueAssignment.m_valuereference_token.m_identifier_token.m_identifier.text} ::= {moduleName}.{valueName}");
                    ((AsnSymbol) p_ValueAssignment.m_valuereference_token.m_identifier_token.appInfo).Identity = valueRef;
                    ++valueIdentities;
                }
                break;
                case DefinedValue.production_kind.g_DefinedValue_2:
                {
                    string valueName = definedValue.m_valuereference_token.m_identifier_token.m_identifier.text;
                    AsnSymbol valueRef = symbolTable.find (new AsnSymbol (valueName, moduleContext, null));
                    if (valueRef == null)
                        return true;
                    Console.WriteLine ($"VALUE IDENTITY: {p_ValueAssignment.m_valuereference_token.m_identifier_token.m_identifier.text} ::= {valueName}");
                    ((AsnSymbol) p_ValueAssignment.m_valuereference_token.m_identifier_token.m_identifier.appInfo).Identity = valueRef;
                    ++valueIdentities;
                }
                break;
                case DefinedValue.production_kind.g_DefinedValue_3:
                    return true;
            }
            return true;
        }

        private bool AsnTypeIdentityRemover_XMLValueAssignment_Event (SyntaxTreeCallbackReason reason, XMLValueAssignment.production_kind kind, XMLValueAssignment p_XMLValueAssignment)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            return true;
        }

        private bool AsnTypeIdentityRemover_ValueSetTypeAssignment_Event (SyntaxTreeCallbackReason reason, ValueSetTypeAssignment.production_kind kind, ValueSetTypeAssignment p_ValueSetTypeAssignment)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            ++valueSetCount;
            ValueSet valueSet = p_ValueSetTypeAssignment.m_ValueSet;
            VSElementSetSpecs vSElement = valueSet.m_VSElementSetSpecs;
            ElementSetSpecsInspector inspector = vSElement.appInfo as ElementSetSpecsInspector;
            if (inspector == null)
                return true;
            if (inspector.elements.Count != 1)
                return true;
            Console.WriteLine ($"VALUE SET IDENTITY: {p_ValueSetTypeAssignment.m_typereference_token.m_typereference.text} ::= {inspector.elements [0].Emit (-1)}");
            ++valueSetIdentities;
            return true;
        }

        private bool AsnTypeIdentityRemover_ObjectClassAssignment_Event (SyntaxTreeCallbackReason reason, ObjectClassAssignment.production_kind kind, ObjectClassAssignment p_ObjectClassAssignment)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            ++objectClassCount;
            ObjectClass objectClass = p_ObjectClassAssignment.m_ObjectClass;
            if ((ObjectClass.production_kind) objectClass.kind != ObjectClass.production_kind.g_ObjectClass_1)
                return true;
            DefinedObjectClass definedObjectClass = objectClass.m_DefinedObjectClass;
            switch ((DefinedObjectClass.production_kind) definedObjectClass.kind)
            {
                case DefinedObjectClass.production_kind.g_DefinedObjectClass_1:
                {
                    ExternalObjectClassReference externalObjectClassReference = definedObjectClass.m_ExternalObjectClassReference;
                    string moduleName = externalObjectClassReference.m_modulereference_token.m_typereference_token.m_typereference.text;
                    AsnSymbol moduleRef = symbolTable.find (new AsnSymbol (moduleName, null, null));
                    if (moduleRef == null)
                        return true;
                    string className = externalObjectClassReference.m_objectclassreference_token.m_typereference_token.m_typereference.text;
                    AsnSymbol classRef = symbolTable.find (new AsnSymbol (className, moduleRef, null));
                    if (classRef == null)
                        return true;
                    Console.WriteLine ($"CLASS IDENTITY: {p_ObjectClassAssignment.m_objectclassreference_token.m_typereference_token.m_typereference.text} ::= {moduleName}.{className}");
                    ((AsnSymbol) p_ObjectClassAssignment.m_objectclassreference_token.m_typereference_token.m_typereference.appInfo).Identity = classRef;
                    ++objectClassIdentities;
                }
                    break;
                case DefinedObjectClass.production_kind.g_DefinedObjectClass_2:
                {
                    string className = definedObjectClass.m_objectclassreference_token.m_typereference_token.m_typereference.text;
                    AsnSymbol classRef = symbolTable.find (new AsnSymbol (className, moduleContext, null));
                    if (classRef == null)
                        return true;
                    Console.WriteLine ($"CLASS IDENTITY: {p_ObjectClassAssignment.m_objectclassreference_token.m_typereference_token.m_typereference.text} ::= {className}");
                    ((AsnSymbol) p_ObjectClassAssignment.m_objectclassreference_token.m_typereference_token.m_typereference.appInfo).Identity = classRef;
                    ++objectClassIdentities;
                }
                break;
                case DefinedObjectClass.production_kind.g_DefinedObjectClass_3:
                    break;
            }
            return true;
        }

        private bool AsnTypeIdentityRemover_ObjectAssignment_Event (SyntaxTreeCallbackReason reason, ObjectAssignment.production_kind kind, ObjectAssignment p_ObjectAssignment)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            ++objectCount;
            Asn.Parser.Object @object = p_ObjectAssignment.m_Object;
            if ((Asn.Parser.Object.production_kind) @object.kind != Asn.Parser.Object.production_kind.g_Object_1)
                return true;
            DefinedObject definedObject = @object.m_DefinedObject;
            switch ((DefinedObject.production_kind) definedObject.kind)
            {
                case DefinedObject.production_kind.g_DefinedObject_1:
                {
                    ExternalObjectReference externalObjectReference = definedObject.m_ExternalObjectReference;
                    string moduleName = externalObjectReference.m_modulereference_token.m_typereference_token.m_typereference.text;
                    AsnSymbol moduleRef = symbolTable.find (new AsnSymbol (moduleName, null, null));
                    if (moduleRef == null)
                        return true;
                    string objectName = externalObjectReference.m_objectreference_token.m_identifier_token.m_identifier.text;
                    AsnSymbol objectRef = symbolTable.find (new AsnSymbol (objectName, moduleRef, null));
                    if(objectRef==null)
                        return true;
                    Console.WriteLine ($"OBJECT IDENTITY: {p_ObjectAssignment.m_objectreference_token.m_identifier_token.m_identifier.text} ::= {moduleName}.{objectName}");
                    ((AsnSymbol) p_ObjectAssignment.m_objectreference_token.m_identifier_token.appInfo).Identity = objectRef;
                    ++objectIdentities;
                }
                    break;
                case DefinedObject.production_kind.g_DefinedObject_2:
                {
                    string objectName = definedObject.m_objectreference_token.m_identifier_token.m_identifier.text;
                    AsnSymbol objectRef = symbolTable.find (new AsnSymbol (objectName, moduleContext, null));
                    if (objectRef == null)
                        return true;
                    Console.WriteLine ($"OBJECT IDENTITY: {p_ObjectAssignment.m_objectreference_token.m_identifier_token.m_identifier.text} ::= {objectName}");
                    ((AsnSymbol) p_ObjectAssignment.m_objectreference_token.m_identifier_token.appInfo).Identity = objectRef;
                    ++objectIdentities;
                }
                break;
            }
            return true;
        }

        private bool AsnTypeIdentityRemover_ObjectSetAssignment_Event (SyntaxTreeCallbackReason reason, ObjectSetAssignment.production_kind kind, ObjectSetAssignment p_ObjectSetAssignment)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            ++objectSetCount;
            ObjectSet objectSet = p_ObjectSetAssignment.m_ObjectSet;
            ObjectSetSpec objectSetSpec = objectSet.m_ObjectSetSpec;
            ObjectSetSpecInspector inspector = objectSetSpec.appInfo as ObjectSetSpecInspector;
            if (inspector == null)
                return true;
            if (inspector.elements.Count != 1)
                return true;
            Console.WriteLine ($"OBJECT SET IDENTITY: {p_ObjectSetAssignment.m_objectsetreference_token.m_typereference_token.m_typereference.text} ::= {inspector.elements [0].Emit (-1)}");
            ++objectSetIdentities;
            return true;
        }

        private bool AsnTypeIdentityRemover_ParameterizedAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedAssignment.production_kind kind, ParameterizedAssignment p_ParameterizedAssignment)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            return true;
        }

        private bool AsnTypeIdentityRemover_MacroAssignment_Event (SyntaxTreeCallbackReason reason, MacroAssignment.production_kind kind, MacroAssignment p_MacroAssignment)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            return true;
        }

        private bool AsnTypeIdentityRemover_MacroDefinition_Event (SyntaxTreeCallbackReason reason, MacroDefinition.production_kind kind, MacroDefinition p_MacroDefinition)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            return true;
        }

        public void Invoke ()
        {
            foreach (List<ModuleDescriptor> moduleList in AsnDataBase.accumulatedModuleDefinitions.Values)
                foreach (ModuleDescriptor module in moduleList)
                {
                    moduleContext = module.moduleSymbol;
                    Traverse (module.moduleDefinition);
                }
        }
    }
}
