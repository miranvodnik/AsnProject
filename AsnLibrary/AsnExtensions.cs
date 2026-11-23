using Anglr.Parser.Core;
using Anglr.Parser.SyntaxTree;
using Anglr.Parser.Walker;
using Asn.Parser;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsnLibrary
{
    public static class AsnExtensions
    {
        #region Name Getters

        public static string getName (this Symbol symbol)
        {
            switch ((Symbol.production_kind) symbol.kind)
            {
                case Symbol.production_kind.g_Symbol_1:
                    return symbol.m_Reference.Emit (-1);
                case Symbol.production_kind.g_Symbol_2:
                    return symbol.m_ParameterizedReference.m_Reference.Emit (-1);
                case Symbol.production_kind.g_Symbol_3:
                    return symbol.m_MacroName.Emit (-1);
            }
            return "";
        }

        public static string getName (this ObjIdComponents components)
        {
            switch ((ObjIdComponents.production_kind) components.kind)
            {
                case ObjIdComponents.production_kind.g_ObjIdComponents_1:
                    return components.m_NameForm.m_identifier_token.m_identifier.text;
                    break;
                case ObjIdComponents.production_kind.g_ObjIdComponents_2:
                    return null;
                    break;
                case ObjIdComponents.production_kind.g_ObjIdComponents_3:
                    return components.m_NameAndNumberForm.m_identifier_token.m_identifier.text;
                    break;
            }
            return null;
        }

        public static string getName (this DefinitiveObjIdComponent component)
        {
            switch ((DefinitiveObjIdComponent.production_kind) component.kind)
            {
                case DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_1:
                    return component.m_NameForm.m_identifier_token.m_identifier.text;
                    break;
                case DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_2:
                    return null;
                    break;
                case DefinitiveObjIdComponent.production_kind.g_DefinitiveObjIdComponent_3:
                    return component.m_DefinitiveNameAndNumberForm.m_identifier_token.m_identifier.text;
                    break;
            }
            return null;
        }

        #endregion

        #region Different References
        public static AsnSymbol findReference (this DefinedType definedType, AsnSymbol contextSymbol)
        {
            AsnSymbol referenceSymbol = null;
            SimpleDefinedType simpleDefinedType = null;
            ExternalTypeReference externalTypeReference = null;
            SyntaxTreeToken referenceToken = null;
            switch ((DefinedType.production_kind) definedType.kind)
            {
                case DefinedType.production_kind.g_DefinedType_1:
                    externalTypeReference = definedType.m_ExternalTypeReference;
                    break;
                case DefinedType.production_kind.g_DefinedType_2:
                    referenceToken = definedType.m_typereference_token.m_typereference;
                    break;
                case DefinedType.production_kind.g_DefinedType_3:
                    simpleDefinedType = definedType.m_ParameterizedType.m_SimpleDefinedType;
                    break;
                case DefinedType.production_kind.g_DefinedType_4:
                    simpleDefinedType = definedType.m_ParameterizedValueSetType.m_SimpleDefinedType;
                    break;
            }
            if (simpleDefinedType != null)
            {
                switch ((SimpleDefinedType.production_kind) simpleDefinedType.kind)
                {
                    case SimpleDefinedType.production_kind.g_SimpleDefinedType_1:
                        externalTypeReference = simpleDefinedType.m_ExternalTypeReference;
                        break;
                    case SimpleDefinedType.production_kind.g_SimpleDefinedType_2:
                        referenceToken = simpleDefinedType.m_typereference_token.m_typereference;
                        break;
                }
            }
            if (externalTypeReference != null)
            {
                SyntaxTreeToken moduleToken = externalTypeReference.m_modulereference_token.m_typereference_token.m_typereference;
                string moduleName = moduleToken.text;
                AsnSymbol moduleSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (moduleName, null, null));
                if (moduleSymbol == null)
                    return null;
                referenceToken = externalTypeReference.m_typereference_token.m_typereference;
                string referenceName = referenceToken.text;
                referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, moduleSymbol, null));
                if (referenceSymbol == null)
                    return null;
            }
            else if (referenceToken != null)
            {
                string referenceName = referenceToken.text;
                referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, contextSymbol, null));
                if (referenceSymbol == null)
                    return null;
            }
            return referenceSymbol;
        }

        public static AsnSymbol findReference (this DefinedValue definedValue, AsnSymbol contextSymbol)
        {
            AsnSymbol referenceSymbol = null;
            SimpleDefinedValue simpleDefinedValue = null;
            ExternalValueReference externalValueReference = null;
            SyntaxTreeToken referenceToken = null;
            switch ((DefinedValue.production_kind) definedValue.kind)
            {
                case DefinedValue.production_kind.g_DefinedValue_1:
                    externalValueReference = definedValue.m_ExternalValueReference;
                    break;
                case DefinedValue.production_kind.g_DefinedValue_2:
                    referenceToken = definedValue.m_valuereference_token.m_identifier_token.m_identifier;
                    break;
                case DefinedValue.production_kind.g_DefinedValue_3:
                    simpleDefinedValue = definedValue.m_ParameterizedValue.m_SimpleDefinedValue;
                    break;
            }
            if (simpleDefinedValue != null)
            {
                switch ((SimpleDefinedValue.production_kind) simpleDefinedValue.kind)
                {
                    case SimpleDefinedValue.production_kind.g_SimpleDefinedValue_1:
                        externalValueReference = simpleDefinedValue.m_ExternalValueReference;
                        break;
                    case SimpleDefinedValue.production_kind.g_SimpleDefinedValue_2:
                        referenceToken = simpleDefinedValue.m_valuereference_token.m_identifier_token.m_identifier;
                        break;
                }
            }
            if (externalValueReference != null)
            {
                SyntaxTreeToken moduleToken = externalValueReference.m_modulereference_token.m_typereference_token.m_typereference;
                string moduleName = moduleToken.text;
                AsnSymbol moduleSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (moduleName, null, null));
                if (moduleSymbol == null)
                    return null;
                referenceToken = externalValueReference.m_valuereference_token.m_identifier_token.m_identifier;
                string referenceName = referenceToken.text;
                referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, moduleSymbol, null));
                if (referenceSymbol == null)
                    return null;
            }
            else if (referenceToken != null)
            {
                string referenceName = referenceToken.text;
                referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, contextSymbol, null));
                if (referenceSymbol == null)
                    return null;
            }

            return referenceSymbol;
        }

        public static AsnSymbol findReference (this DefinedObjectClass definedObjectClass, AsnSymbol contextSymbol)
        {
            AsnSymbol referenceSymbol = null;
            ExternalObjectClassReference externalObjectClassReference = null;
            objectclassreference_token objectclassreference_Token = null;
            SyntaxTreeToken referenceToken = null;
            switch ((DefinedObjectClass.production_kind) definedObjectClass.kind)
            {
                case DefinedObjectClass.production_kind.g_DefinedObjectClass_1:
                    externalObjectClassReference = definedObjectClass.m_ExternalObjectClassReference;
                    break;
                case DefinedObjectClass.production_kind.g_DefinedObjectClass_2:
                    objectclassreference_Token = definedObjectClass.m_objectclassreference_token;
                    break;
                case DefinedObjectClass.production_kind.g_DefinedObjectClass_3:
                    break;
            }
            if (externalObjectClassReference != null)
            {
                SyntaxTreeToken moduleToken = externalObjectClassReference.m_modulereference_token.m_typereference_token.m_typereference;
                string moduleName = moduleToken.text;
                AsnSymbol moduleSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (moduleName, null, null));
                if (moduleSymbol == null)
                    return null;
                referenceToken = externalObjectClassReference.m_objectclassreference_token.m_typereference_token.m_typereference;
                string referenceName = referenceToken.text;
                referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, moduleSymbol, null));
                if (referenceSymbol == null)
                    return null;
            }
            else if (objectclassreference_Token != null)
            {
                referenceToken = objectclassreference_Token.m_typereference_token.m_typereference;
                string referenceName = referenceToken.text;
                referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, contextSymbol, null));
                if (referenceSymbol == null)
                    return null;
            }
            if (referenceSymbol != null)
                return referenceSymbol;
            return null;
        }

        public static AsnSymbol findReference (this ReferencedObjects referencedObjects, AsnSymbol contextSymbol)
        {
            switch ((ReferencedObjects.production_kind) referencedObjects.kind)
            {
                case ReferencedObjects.production_kind.g_ReferencedObjects_1:
                {
                    DefinedObject definedObject = referencedObjects.m_DefinedObject;
                    switch ((DefinedObject.production_kind) definedObject.kind)
                    {
                        case DefinedObject.production_kind.g_DefinedObject_1:
                        {
                            ExternalObjectReference externalObjectReference = definedObject.m_ExternalObjectReference;
                            string moduleName = externalObjectReference.m_modulereference_token.m_typereference_token.m_typereference.text;
                            AsnSymbol moduleReference = AsnDataBase.symbolTable.find (new AsnSymbol (moduleName, null, null));
                            if (moduleReference == null)
                                return null;
                            string referenceName = externalObjectReference.m_objectreference_token.m_identifier_token.m_identifier.text;
                            AsnSymbol referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, moduleReference, null));
                            if (referenceSymbol == null)
                                return null;
                            return referenceSymbol;
                        }
                        case DefinedObject.production_kind.g_DefinedObject_2:
                        {
                            string referenceName = definedObject.m_objectreference_token.m_identifier_token.m_identifier.text;
                            AsnSymbol referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, contextSymbol, null));
                            if (referenceSymbol == null)
                                return null;
                            return referenceSymbol;
                        }
                    }
                }
                break;
                case ReferencedObjects.production_kind.g_ReferencedObjects_2:
                {
                    DefinedObject definedObject = referencedObjects.m_ParameterizedObject.m_DefinedObject;
                    switch ((DefinedObject.production_kind) definedObject.kind)
                    {
                        case DefinedObject.production_kind.g_DefinedObject_1:
                        {
                            ExternalObjectReference externalObjectReference = definedObject.m_ExternalObjectReference;
                            string moduleName = externalObjectReference.m_modulereference_token.m_typereference_token.m_typereference.text;
                            AsnSymbol moduleReference = AsnDataBase.symbolTable.find (new AsnSymbol (moduleName, null, null));
                            if (moduleReference == null)
                                return null;
                            string referenceName = externalObjectReference.m_objectreference_token.m_identifier_token.m_identifier.text;
                            AsnSymbol referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, moduleReference, null));
                            if (referenceSymbol == null)
                                return null;
                            return referenceSymbol;
                        }
                        case DefinedObject.production_kind.g_DefinedObject_2:
                        {
                            string referenceName = definedObject.m_objectreference_token.m_identifier_token.m_identifier.text;
                            AsnSymbol referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, contextSymbol, null));
                            if (referenceSymbol == null)
                                return null;
                            return referenceSymbol;
                        }
                    }
                }
                break;
                case ReferencedObjects.production_kind.g_ReferencedObjects_3:
                {
                    DefinedObjectSet definedObjectSet = referencedObjects.m_DefinedObjectSet;
                    switch ((DefinedObjectSet.production_kind) definedObjectSet.kind)
                    {
                        case DefinedObjectSet.production_kind.g_DefinedObjectSet_1:
                        {
                            ExternalObjectSetReference externalObjectSetReference = definedObjectSet.m_ExternalObjectSetReference;
                            string moduleName = externalObjectSetReference.m_modulereference_token.m_typereference_token.m_typereference.text;
                            AsnSymbol moduleReference = AsnDataBase.symbolTable.find (new AsnSymbol (moduleName, null, null));
                            if (moduleReference == null)
                                return null;
                            string referenceName = externalObjectSetReference.m_objectsetreference_token.m_typereference_token.m_typereference.text;
                            AsnSymbol referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, moduleReference, null));
                            if (referenceSymbol == null)
                                return null;
                            return referenceSymbol;
                        }
                        case DefinedObjectSet.production_kind.g_DefinedObjectSet_2:
                        {
                            string referenceName = definedObjectSet.m_objectsetreference_token.m_typereference_token.m_typereference.text;
                            AsnSymbol referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, contextSymbol, null));
                            if (referenceSymbol == null)
                                return null;
                            return referenceSymbol;
                        }
                    }
                }
                break;
                case ReferencedObjects.production_kind.g_ReferencedObjects_4:
                {
                    DefinedObjectSet definedObjectSet = referencedObjects.m_ParameterizedObjectSet.m_DefinedObjectSet;
                    switch ((DefinedObjectSet.production_kind) definedObjectSet.kind)
                    {
                        case DefinedObjectSet.production_kind.g_DefinedObjectSet_1:
                        {
                            ExternalObjectSetReference externalObjectSetReference = definedObjectSet.m_ExternalObjectSetReference;
                            string moduleName = externalObjectSetReference.m_modulereference_token.m_typereference_token.m_typereference.text;
                            AsnSymbol moduleReference = AsnDataBase.symbolTable.find (new AsnSymbol (moduleName, null, null));
                            if (moduleReference == null)
                                return null;
                            string referenceName = externalObjectSetReference.m_objectsetreference_token.m_typereference_token.m_typereference.text;
                            AsnSymbol referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, moduleReference, null));
                            if (referenceSymbol == null)
                                return null;
                            return referenceSymbol;
                        }
                        case DefinedObjectSet.production_kind.g_DefinedObjectSet_2:
                        {
                            string referenceName = definedObjectSet.m_objectsetreference_token.m_typereference_token.m_typereference.text;
                            AsnSymbol referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, contextSymbol, null));
                            if (referenceSymbol == null)
                                return null;
                            return referenceSymbol;
                        }
                    }
                }
                break;
            }
            return null;
        }

        public static AsnSymbol findReference (this DefinedObject definedObject, AsnSymbol contextSymbol)
        {
            switch ((DefinedObject.production_kind) definedObject.kind)
            {
                case DefinedObject.production_kind.g_DefinedObject_1:
                {
                    ExternalObjectReference externalObjectReference = definedObject.m_ExternalObjectReference;
                    string moduleName = externalObjectReference.m_modulereference_token.m_typereference_token.m_typereference.text;
                    AsnSymbol moduleReference = AsnDataBase.symbolTable.find (new AsnSymbol (moduleName, null, null));
                    if (moduleReference == null)
                        return null;
                    AsnSymbol objectReference = AsnDataBase.symbolTable.find (new AsnSymbol (externalObjectReference.m_objectreference_token.m_identifier_token.m_identifier.text, moduleReference, null));
                    if (objectReference == null)
                        return null;
                    return objectReference;
                }
                case DefinedObject.production_kind.g_DefinedObject_2:
                {
                    AsnSymbol objectReference = AsnDataBase.symbolTable.find (new AsnSymbol (definedObject.m_objectreference_token.m_identifier_token.m_identifier.text, contextSymbol, null));
                    if (objectReference == null)
                        return null;
                    return objectReference;
                }
            }
            return null;
        }

        public static AsnSymbol findReference (this DefinedObjectSet definedObjectSet, AsnSymbol contextSymbol)
        {
            switch ((DefinedObjectSet.production_kind) definedObjectSet.kind)
            {
                case DefinedObjectSet.production_kind.g_DefinedObjectSet_1:
                {
                    ExternalObjectSetReference externalObjectSetReference = definedObjectSet.m_ExternalObjectSetReference;
                    string moduleName = externalObjectSetReference.m_modulereference_token.m_typereference_token.m_typereference.text;
                    AsnSymbol moduleReference = AsnDataBase.symbolTable.find (new AsnSymbol (moduleName, null, null));
                    if (moduleReference == null)
                        return null;
                    AsnSymbol objectSetReference = AsnDataBase.symbolTable.find (new AsnSymbol (externalObjectSetReference.m_objectsetreference_token.m_typereference_token.m_typereference.text, moduleReference, null));
                    if (objectSetReference == null)
                        return null;
                    return objectSetReference;
                }
                case DefinedObjectSet.production_kind.g_DefinedObjectSet_2:
                {
                    AsnSymbol objectSetReference = AsnDataBase.symbolTable.find (new AsnSymbol (definedObjectSet.m_objectsetreference_token.m_typereference_token.m_typereference.text, contextSymbol, null));
                    if (objectSetReference == null)
                        return null;
                    return objectSetReference;
                }
            }
            return null;
        }

        public static AsnSymbol findReference (this SimpleDefinedType simpleDefinedType, AsnSymbol contextSymbol)
        {
            AsnSymbol referenceSymbol = null;
            ExternalTypeReference externalTypeReference = null;
            SyntaxTreeToken referenceToken = null;

            switch ((SimpleDefinedType.production_kind) simpleDefinedType.kind)
            {
                case SimpleDefinedType.production_kind.g_SimpleDefinedType_1:
                    externalTypeReference = simpleDefinedType.m_ExternalTypeReference;
                    break;
                case SimpleDefinedType.production_kind.g_SimpleDefinedType_2:
                    referenceToken = simpleDefinedType.m_typereference_token.m_typereference;
                    break;
            }
            if (externalTypeReference != null)
            {
                SyntaxTreeToken moduleToken = externalTypeReference.m_modulereference_token.m_typereference_token.m_typereference;
                string moduleName = moduleToken.text;
                AsnSymbol moduleSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (moduleName, null, null));
                if (moduleSymbol == null)
                    return null;
                referenceToken = externalTypeReference.m_typereference_token.m_typereference;
                string referenceName = referenceToken.text;
                referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, moduleSymbol, null));
                if (referenceSymbol == null)
                    return null;
            }
            else if (referenceToken != null)
            {
                string referenceName = referenceToken.text;
                referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, contextSymbol, null));
                if (referenceSymbol == null)
                    return null;
            }
            return referenceSymbol;
        }

        public static AsnSymbol findReference (this SimpleDefinedValue simpleDefinedValue, AsnSymbol contextSymbol)
        {
            AsnSymbol referenceSymbol = null;
            ExternalValueReference externalValueReference = null;
            SyntaxTreeToken referenceToken = null;

            switch ((SimpleDefinedValue.production_kind) simpleDefinedValue.kind)
            {
                case SimpleDefinedValue.production_kind.g_SimpleDefinedValue_1:
                    externalValueReference = simpleDefinedValue.m_ExternalValueReference;
                    break;
                case SimpleDefinedValue.production_kind.g_SimpleDefinedValue_2:
                    referenceToken = simpleDefinedValue.m_valuereference_token.m_identifier_token.m_identifier;
                    break;
            }
            if (externalValueReference != null)
            {
                SyntaxTreeToken moduleToken = externalValueReference.m_modulereference_token.m_typereference_token.m_typereference;
                string moduleName = moduleToken.text;
                AsnSymbol moduleSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (moduleName, null, null));
                if (moduleSymbol == null)
                    return null;
                referenceToken = externalValueReference.m_valuereference_token.m_identifier_token.m_identifier;
                string referenceName = referenceToken.text;
                referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, moduleSymbol, null));
                if (referenceSymbol == null)
                    return null;
            }
            else if (referenceToken != null)
            {
                string referenceName = referenceToken.text;
                referenceSymbol = AsnDataBase.symbolTable.find (new AsnSymbol (referenceName, contextSymbol, null));
                if (referenceSymbol == null)
                    return null;
            }
            return referenceSymbol;
        }

        #endregion

        #region Class Field Inspectors

        public static bool useInspectorMethod = false;

        public static NodeInspector GetNodeInspector (this FieldSpec fieldSpec)
        {
            switch ((FieldSpec.production_kind) fieldSpec.kind)
            {
                case FieldSpec.production_kind.g_FieldSpec_1:
                    return useInspectorMethod ?
                        fieldSpec.m_TypeFieldSpec.GetNodeInspector () :
                        fieldSpec.m_TypeFieldSpec.appInfo as NodeInspector;
                case FieldSpec.production_kind.g_FieldSpec_2:
                    return useInspectorMethod ? 
                        fieldSpec.m_FixedTypeValueFieldSpec.GetNodeInspector () :
                        (fieldSpec.m_FixedTypeValueFieldSpec.m_Type.appInfo as NodeInspector)?.actualNodeInspector;
                case FieldSpec.production_kind.g_FieldSpec_3:
                    return useInspectorMethod ?
                        fieldSpec.m_VariableTypeValueFieldSpec.GetNodeInspector () :
                        fieldSpec.m_VariableTypeValueFieldSpec.appInfo as NodeInspector;
                case FieldSpec.production_kind.g_FieldSpec_4:
                    return useInspectorMethod ?
                        fieldSpec.m_FixedTypeValueSetFieldSpec.GetNodeInspector () :
                        (fieldSpec.m_FixedTypeValueSetFieldSpec.m_Type.appInfo as NodeInspector)?.actualNodeInspector;
                case FieldSpec.production_kind.g_FieldSpec_5:
                    return useInspectorMethod ? 
                        fieldSpec.m_VariableTypeValueSetFieldSpec.GetNodeInspector () :
                        fieldSpec.m_VariableTypeValueSetFieldSpec.appInfo as NodeInspector;
                case FieldSpec.production_kind.g_FieldSpec_6:
                    return useInspectorMethod ?
                        fieldSpec.m_ObjectFieldSpec.GetNodeInspector () :
                        (((fieldSpec.m_ObjectFieldSpec.appInfo as NodeInspector)?.actualNodeInspector)?.Node.appInfo as NodeInspector)?.actualNodeInspector;
                case FieldSpec.production_kind.g_FieldSpec_7:
                    return useInspectorMethod ?
                        fieldSpec.m_ObjectSetFieldSpec.GetNodeInspector () :
                        (((fieldSpec.m_ObjectSetFieldSpec.appInfo as NodeInspector)?.actualNodeInspector)?.Node.appInfo as NodeInspector)?.actualNodeInspector;
            }
            return null;
        }

        public static NodeInspector GetNodeInspector (this TypeFieldSpec typeFieldSpec)
            => typeFieldSpec.appInfo as NodeInspector;

        public static NodeInspector GetNodeInspector (this FixedTypeValueFieldSpec fixedTypeValueFieldSpec)
            => (fixedTypeValueFieldSpec.m_Type.appInfo as NodeInspector)?.actualNodeInspector;

        public static NodeInspector GetNodeInspector (this VariableTypeValueFieldSpec variableTypeValueFieldSpec)
            => variableTypeValueFieldSpec.appInfo as NodeInspector;

        public static NodeInspector GetNodeInspector (this FixedTypeValueSetFieldSpec fixedTypeValueSetFieldSpec)
            => (fixedTypeValueSetFieldSpec.m_Type.appInfo as NodeInspector)?.actualNodeInspector;

        public static NodeInspector GetNodeInspector (this VariableTypeValueSetFieldSpec variableTypeValueSetFieldSpec)
            => variableTypeValueSetFieldSpec.appInfo as NodeInspector;

        public static NodeInspector GetNodeInspector (this ObjectFieldSpec objectFieldSpec)
            => (((objectFieldSpec.appInfo as NodeInspector)?.actualNodeInspector)?.Node.appInfo as NodeInspector)?.actualNodeInspector;

        public static NodeInspector GetNodeInspector (this ObjectSetFieldSpec objectSetFieldSpec)
            => (((objectSetFieldSpec.appInfo as NodeInspector)?.actualNodeInspector)?.Node.appInfo as NodeInspector)?.actualNodeInspector;

        #endregion

        #region Class Fields Validators

        public static bool Validate (this FieldSpec fieldSpec)
        {
            switch ((FieldSpec.production_kind) fieldSpec.kind)
            {
                case FieldSpec.production_kind.g_FieldSpec_1:
                    return fieldSpec.m_TypeFieldSpec.Validate ();
                case FieldSpec.production_kind.g_FieldSpec_2:
                    return fieldSpec.m_FixedTypeValueFieldSpec.Validate ();
                case FieldSpec.production_kind.g_FieldSpec_3:
                    return fieldSpec.m_VariableTypeValueFieldSpec.Validate ();
                case FieldSpec.production_kind.g_FieldSpec_4:
                    return fieldSpec.m_FixedTypeValueSetFieldSpec.Validate ();
                case FieldSpec.production_kind.g_FieldSpec_5:
                    return fieldSpec.m_VariableTypeValueSetFieldSpec.Validate ();
                case FieldSpec.production_kind.g_FieldSpec_6:
                    return fieldSpec.m_ObjectFieldSpec.Validate ();
                case FieldSpec.production_kind.g_FieldSpec_7:
                    return fieldSpec.m_ObjectSetFieldSpec.Validate ();
            }
            return false;
        }

        public static bool Validate (this TypeFieldSpec typeFieldSpec)
        {
            return false;
        }

        public static bool Validate (this FixedTypeValueFieldSpec fixedTypeValueFieldSpec)
        {
            return false;
        }

        public static bool Validate (this VariableTypeValueFieldSpec variableTypeValueFieldSpec)
        {
            return false;
        }

        public static bool Validate (this FixedTypeValueSetFieldSpec fixedTypeValueSetFieldSpec)
        {
            return false;
        }

        public static bool Validate (this VariableTypeValueSetFieldSpec variableTypeValueSetFieldSpec)
        {
            return false;
        }

        public static bool Validate (this ObjectFieldSpec objectFieldSpec)
        {
            return false;
        }

        public static bool Validate (this ObjectSetFieldSpec objectSetFieldSpec)
        {
            return false;
        }

        #endregion
    }
}
