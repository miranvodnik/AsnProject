using Anglr.Parser.Core;
using Anglr.Parser.SyntaxTree;
using Anglr.Parser.Walker;
using Asn.Parser;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsnLibrary
{

    public class AsnModuleDereferencer : SyntaxTreeWalker
    {
        public void AddEventHandlers ()
        {
            ModuleIdentifier_Event += Invoke_ModuleIdentifier_ModuleDereferencer;
            ModuleBody_Event += Invoke_ModuleBody_ModuleDereferencer;
            SymbolsFromModule_Event += Invoke_SymbolsFromModule_ModuleDereferencer;
            Exports_Event += Invoke_Exports_ModuleDereferencer;
            GlobalModuleReference_Event += Invoke_GlobalModuleReference_ModuleDereferencer;
        }

        public void ResolveGlobalModuleReferences ()
        {
            ModuleIdentifier_Event += Invoke_ModuleIdentifier_ModuleDereferencer;
            ModuleBody_Event += Invoke_ModuleBody_ModuleDereferencer;
            SymbolsFromModule_Event += Invoke_SymbolsFromModule_ModuleDereferencer;
            Exports_Event += Invoke_Exports_ModuleDereferencer;
            GlobalModuleReference_Event += Invoke_GlobalModuleReference_ModuleDereferencer;

            //DefinedType_Event += Invoke_DefinedType_ModuleDereferencer;
            //DefinedObjectClass_Event += Invoke_DefinedObjectClass_ModuleDereferencer;
            //DefinedObjectSet_Event += Invoke_DefinedObjectSet_ModuleDereferencer;

            //DefinedSyntax_Event += Invoke_DefinedSyntax_ModuleDereferencer;
            //ParameterizedAssignment_Event += Invoke_ParameterizedAssignment_ModuleDereferencer;
            //SyntaxList_Event += Invoke_SyntaxList_ModuleDereferencer;
            //DefaultSyntax_Event += Invoke_DefaultSyntax_ModuleDereferencer;
            //ActualParameterList_Event += Invoke_ActualParameterList_ModuleDereferencer;

            //Type_Event += Invoke_Type_ModuleDereferencer;
            //Object_Event += Invoke_Object_ModuleDereferencer;
            //typereference_token_Event += Invoke_typereference_token_ModuleDereferencer;
            //identifier_token_Event += Invoke_identifier_token_ModuleDereferencer;

            globalModuleSymbol = symbolTable.find (new AsnSymbol ("GLOBAL-MODULE", null, null));
            if (globalModuleSymbol != null)
            {
                typeIdentifierSymbol = symbolTable.find (new AsnSymbol ("TYPE-IDENTIFIER", globalModuleSymbol, null));
                abstractSyntaxSymbol = symbolTable.find (new AsnSymbol ("ABSTRACT-SYNTAX", globalModuleSymbol, null));
            }

            contextSymbols.Push (null);
            foreach (List<ModuleDescriptor> moduleList in moduleCollection.Values)
                foreach (ModuleDescriptor module in moduleList)
                {
                    AsnSymbol tisym = new AsnSymbol ("TYPE-IDENTIFIER", module.moduleSymbol, null);
                    if (symbolTable.find (tisym) != tisym)
                    {
                        symbolTable.add (tisym);
                        tisym.Reference = typeIdentifierSymbol;
                    }

                    AsnSymbol assym = new AsnSymbol ("ABSTRACT-SYNTAX", module.moduleSymbol, null);
                    if (symbolTable.find (assym) != assym)
                    {
                        symbolTable.add (assym);
                        assym.Reference = abstractSyntaxSymbol;
                    }

                    currentFile = module.fileName;
                    Traverse (module.moduleDefinition);
                }
            contextSymbols.Pop ();

            ModuleIdentifier_Event -= Invoke_ModuleIdentifier_ModuleDereferencer;
            ModuleBody_Event -= Invoke_ModuleBody_ModuleDereferencer;
            SymbolsFromModule_Event -= Invoke_SymbolsFromModule_ModuleDereferencer;
            Exports_Event -= Invoke_Exports_ModuleDereferencer;
            GlobalModuleReference_Event -= Invoke_GlobalModuleReference_ModuleDereferencer;

            //DefinedType_Event -= Invoke_DefinedType_ModuleDereferencer;
            //DefinedObjectClass_Event -= Invoke_DefinedObjectClass_ModuleDereferencer;

            //DefinedSyntax_Event -= Invoke_DefinedSyntax_ModuleDereferencer;
            //ParameterizedAssignment_Event -= Invoke_ParameterizedAssignment_ModuleDereferencer;
            //SyntaxList_Event -= Invoke_SyntaxList_ModuleDereferencer;
            //DefaultSyntax_Event -= Invoke_DefaultSyntax_ModuleDereferencer;
            //ActualParameterList_Event -= Invoke_ActualParameterList_ModuleDereferencer;

            //Type_Event -= Invoke_Type_ModuleDereferencer;
            //Object_Event -= Invoke_Object_ModuleDereferencer;
            //typereference_token_Event -= Invoke_typereference_token_ModuleDereferencer;
            //identifier_token_Event -= Invoke_identifier_token_ModuleDereferencer;
        }

        //private bool Invoke_ActualParameterList_ModuleDereferencer (SyntaxTreeCallbackReason reason, ActualParameterList.production_kind kind, ActualParameterList p_ActualParameterList)
        //{
        //    return false;
        //}

        //private bool Invoke_Type_ModuleDereferencer (SyntaxTreeCallbackReason reason, Asn.Parser.Type.production_kind kind, Asn.Parser.Type p_Type)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            if (p_Type.appInfo == null)
        //                break;
        //            if (!(p_Type.appInfo is NodeGovernor))
        //                break;
        //            NodeGovernor typeGovernor = (NodeGovernor) p_Type.appInfo;
        //            if (typeGovernor is DefinedTypeGovernor)
        //                Console.WriteLine ($"DEFINING REFERENCE FOR TYPE: {p_Type.Emit (-1)} IS {typeGovernor.Symbol.DefiningReference.Path}");
        //            else if (typeGovernor is DefinedExternalTypeReferenceGovernor)
        //                Console.WriteLine ($"DEFINING REFERENCE FOR TYPE: {p_Type.Emit (-1)} IS {typeGovernor.Symbol.DefiningReference.Path}");
        //            else if (typeGovernor is DefinedParameterizedTypeGovernor)
        //                Console.WriteLine ($"DEFINING REFERENCE FOR TYPE: {p_Type.Emit (-1)} IS {typeGovernor.Symbol.DefiningReference.Path}");
        //            else if (typeGovernor is DefinedParameterizedValueSetTypeGovernor)
        //                Console.WriteLine ($"DEFINING REFERENCE FOR TYPE: {p_Type.Emit (-1)} IS {typeGovernor.Symbol.DefiningReference.Path}");
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_Object_ModuleDereferencer (SyntaxTreeCallbackReason reason, Asn.Parser.Object.production_kind kind, Asn.Parser.Object p_Object)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string objectContent = p_Object.Emit (-1);
        //            AsnCompiler asnCompiler = new AsnCompiler ();
        //            asnCompiler.Error_Event += (int lineno, int column, int token, string tokenString) =>
        //            {
        //                return true;
        //            };
        //            if (asnCompiler.ParseString (objectContent, new int [] { (int) TerminalCodes.token_BuiltinValue_token }) != 0)
        //                Console.Error.WriteLine ($"object is not value: {objectContent}");
        //            else
        //                Console.Error.WriteLine ($"object might be value: {objectContent}");
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool AsnCompiler_Error_Event (int lineno, int column, int token, string tokenString)
        //{
        //    throw new NotImplementedException ();
        //}

        //private uint objectDepth = 0;
        //private uint maxObjectDepth = 1;
        //private bool Invoke_DefinedSyntax_ModuleDereferencer (SyntaxTreeCallbackReason reason, DefinedSyntax.production_kind kind, DefinedSyntax p_DefinedSyntax)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            SyntaxTreeBase node = p_DefinedSyntax;
        //            for (node = p_DefinedSyntax.parent; (node != null) && !(node is Assignment); node = node.parent)
        //                ;
        //            if ((node != null) && (node.kind != (int) Assignment.production_kind.g_Assignment_6))
        //                Console.Error.WriteLine ($"OBJECT");
        //            if (objectDepth > maxObjectDepth)
        //                Console.Error.WriteLine ($"");
        //            ++objectDepth;
        //            Console.Error.WriteLine ($"DEFINED SYNTAX: {p_DefinedSyntax.Emit (-1)}");
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            --objectDepth;
        //            break;
        //    }
        //    return false;
        //}

        //private bool Invoke_DefaultSyntax_ModuleDereferencer (SyntaxTreeCallbackReason reason, DefaultSyntax.production_kind kind, DefaultSyntax p_DefaultSyntax)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            if (objectDepth > maxObjectDepth)
        //                Console.Error.WriteLine ($"");
        //            ++objectDepth;
        //            Console.Error.WriteLine ($"DEFAULT SYNTAX: {p_DefaultSyntax.Emit (-1)}");
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            --objectDepth;
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_SyntaxList_ModuleDereferencer (SyntaxTreeCallbackReason reason, SyntaxList.production_kind kind, SyntaxList p_SyntaxList)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            Console.Error.WriteLine ($"SYNTAX LIST: {p_SyntaxList.Emit (-1)}");
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return false;
        //}

        //private bool Invoke_ParameterizedAssignment_ModuleDereferencer (SyntaxTreeCallbackReason reason, ParameterizedAssignment.production_kind kind, ParameterizedAssignment p_ParameterizedAssignment)
        //{
        //    return false;
        //}

        //private bool Invoke_DefinedObjectSet_ModuleDereferencer (SyntaxTreeCallbackReason reason, DefinedObjectSet.production_kind kind, DefinedObjectSet p_DefinedObjectSet)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            switch (kind)
        //            {
        //                case DefinedObjectSet.production_kind.g_DefinedObjectSet_1:
        //                {
        //                    ExternalObjectSetReference externalObjectSetReference = p_DefinedObjectSet.m_ExternalObjectSetReference;
        //                    SyntaxTreeToken moduleToken = externalObjectSetReference.m_modulereference_token.m_typereference_token.m_typereference;
        //                    string moduleName = moduleToken.text;
        //                    AsnSymbol moduleSymbol = symbolTable.find (new AsnSymbol (moduleName, null, null));
        //                    if (moduleSymbol == null)
        //                    {
        //                        Console.Error.WriteLine ($"undefined module reference: {moduleName}");
        //                        break;
        //                    }
        //                    moduleToken.appInfo = moduleSymbol;
        //                    SyntaxTreeToken referenceToken = externalObjectSetReference.m_objectsetreference_token.m_typereference_token.m_typereference;
        //                    string referenceName = referenceToken.text;
        //                    AsnSymbol referenceSymbol = symbolTable.find (new AsnSymbol (referenceName, moduleSymbol, null));
        //                    if (referenceSymbol == null)
        //                    {
        //                        Console.Error.WriteLine ($"undefined module reference: {moduleName}.{referenceName}");
        //                        break;
        //                    }
        //                    referenceToken.appInfo = referenceSymbol;
        //                }
        //                break;
        //                case DefinedObjectSet.production_kind.g_DefinedObjectSet_2:
        //                {
        //                    objectsetreference_token objectsetreference_Token = p_DefinedObjectSet.m_objectsetreference_token;
        //                    SyntaxTreeToken referenceToken = objectsetreference_Token.m_typereference_token.m_typereference;
        //                    string referenceName = referenceToken.text;
        //                    AsnSymbol referenceSymbol = symbolTable.find (new AsnSymbol (referenceName, currentModule, null));
        //                    if (referenceSymbol == null)
        //                    {
        //                        Console.Error.WriteLine ($"undefined module reference: {referenceName}");
        //                        break;
        //                    }
        //                    referenceToken.appInfo = referenceSymbol;
        //                }
        //                break;
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

        //private bool Invoke_DefinedObjectClass_ModuleDereferencer (SyntaxTreeCallbackReason reason, DefinedObjectClass.production_kind kind, DefinedObjectClass p_DefinedObjectClass)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            switch (kind)
        //            {
        //                case DefinedObjectClass.production_kind.g_DefinedObjectClass_1:
        //                {
        //                    ExternalObjectClassReference externalObjectClassReference = p_DefinedObjectClass.m_ExternalObjectClassReference;
        //                    SyntaxTreeToken moduleToken = externalObjectClassReference.m_modulereference_token.m_typereference_token.m_typereference;
        //                    string moduleName = moduleToken.text;
        //                    AsnSymbol moduleSymbol = symbolTable.find (new AsnSymbol (moduleName, null, null));
        //                    if (moduleSymbol == null)
        //                    {
        //                        Console.Error.WriteLine ($"undefined module reference: {moduleName}");
        //                        break;
        //                    }
        //                    moduleToken.appInfo = moduleSymbol;
        //                    SyntaxTreeToken referenceToken = externalObjectClassReference.m_objectclassreference_token.m_typereference_token.m_typereference;
        //                    string referenceName = referenceToken.text;
        //                    AsnSymbol referenceSymbol = symbolTable.find (new AsnSymbol (referenceName, moduleSymbol, null));
        //                    if (referenceSymbol == null)
        //                    {
        //                        Console.Error.WriteLine ($"undefined module reference: {moduleName}.{referenceName}");
        //                        break;
        //                    }
        //                    referenceToken.appInfo = referenceSymbol;
        //                }
        //                break;
        //                case DefinedObjectClass.production_kind.g_DefinedObjectClass_2:
        //                {
        //                    SyntaxTreeToken referenceToken = p_DefinedObjectClass.m_objectclassreference_token.m_typereference_token.m_typereference;
        //                    string referenceName = referenceToken.text;
        //                    AsnSymbol referenceSymbol = symbolTable.find (new AsnSymbol (referenceName, currentModule, null));
        //                    if (referenceSymbol == null)
        //                    {
        //                        Console.Error.WriteLine ($"undefined module reference: {referenceName}");
        //                        break;
        //                    }
        //                    referenceToken.appInfo = referenceSymbol;
        //                }
        //                break;
        //                case DefinedObjectClass.production_kind.g_DefinedObjectClass_3:
        //                {
        //                    string moduleName = "GLOBAL-MODULE";
        //                    AsnSymbol moduleSymbol = symbolTable.find (new AsnSymbol (moduleName, null, null));
        //                    if (moduleSymbol == null)
        //                    {
        //                        Console.Error.WriteLine ($"undefined global module: file: {currentFile}, module: {moduleName}");
        //                        break;
        //                    }
        //                    string className = p_DefinedObjectClass.m_UsefulObjectClassReference.Emit (-1);
        //                    AsnSymbol classSymbol = symbolTable.find (new AsnSymbol (className, moduleSymbol, null));
        //                    if (classSymbol == null)
        //                    {
        //                        Console.Error.WriteLine ($"undefined useful class: file: {currentFile}, module: {moduleName}.{className}");
        //                        break;
        //                    }
        //                    infoSetter.SetInfo (p_DefinedObjectClass, classSymbol);
        //                }
        //                break;
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

        //private bool Invoke_DefinedType_ModuleDereferencer (SyntaxTreeCallbackReason reason, DefinedType.production_kind kind, DefinedType p_DefinedType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            SimpleDefinedType simpleDefinedType = null;
        //            ExternalTypeReference externalTypeReference = null;
        //            SyntaxTreeToken referenceToken = null;
        //            switch (kind)
        //            {
        //                case DefinedType.production_kind.g_DefinedType_1:
        //                    externalTypeReference = p_DefinedType.m_ExternalTypeReference;
        //                    break;
        //                case DefinedType.production_kind.g_DefinedType_2:
        //                    referenceToken = p_DefinedType.m_typereference_token.m_typereference;
        //                    break;
        //                case DefinedType.production_kind.g_DefinedType_3:
        //                    simpleDefinedType = p_DefinedType.m_ParameterizedType.m_SimpleDefinedType;
        //                    break;
        //                case DefinedType.production_kind.g_DefinedType_4:
        //                    simpleDefinedType = p_DefinedType.m_ParameterizedValueSetType.m_SimpleDefinedType;
        //                    break;
        //            }
        //            if (simpleDefinedType != null)
        //            {
        //                switch ((SimpleDefinedType.production_kind) simpleDefinedType.kind)
        //                {
        //                    case SimpleDefinedType.production_kind.g_SimpleDefinedType_1:
        //                        externalTypeReference = simpleDefinedType.m_ExternalTypeReference;
        //                        break;
        //                    case SimpleDefinedType.production_kind.g_SimpleDefinedType_2:
        //                        referenceToken = simpleDefinedType.m_typereference_token.m_typereference;
        //                        break;
        //                }
        //            }
        //            if (externalTypeReference != null)
        //            {
        //                SyntaxTreeToken moduleToken = externalTypeReference.m_modulereference_token.m_typereference_token.m_typereference;
        //                string moduleName = moduleToken.text;
        //                AsnSymbol moduleSymbol = symbolTable.find (new AsnSymbol (moduleName, null, null));
        //                if (moduleSymbol == null)
        //                {
        //                    Console.Error.WriteLine ($"undefined module reference: {moduleName}");
        //                    break;
        //                }
        //                moduleToken.appInfo = moduleSymbol;
        //                referenceToken = externalTypeReference.m_typereference_token.m_typereference;
        //                string referenceName = referenceToken.text;
        //                AsnSymbol referenceSymbol = symbolTable.find (new AsnSymbol (referenceName, moduleSymbol, null));
        //                if (referenceSymbol == null)
        //                {
        //                    Console.Error.WriteLine ($"undefined module reference: {moduleName}.{referenceName}");
        //                    break;
        //                }
        //                referenceToken.appInfo = referenceSymbol;
        //            }
        //            else if (referenceToken != null)
        //            {
        //                string referenceName = referenceToken.text;
        //                AsnSymbol referenceSymbol = symbolTable.find (new AsnSymbol (referenceName, currentModule, null));
        //                if (referenceSymbol == null)
        //                {
        //                    Console.Error.WriteLine ($"undefined module reference: {referenceName}");
        //                    break;
        //                }
        //                referenceToken.appInfo = referenceSymbol;
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

        //private bool Invoke_identifier_token_ModuleDereferencer (SyntaxTreeCallbackReason reason, identifier_token.production_kind kind, identifier_token p_identifier_token)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            AsnSymbol asnSymbol = (AsnSymbol) p_identifier_token.m_identifier.appInfo;
        //            if (asnSymbol == null)
        //                break;
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_typereference_token_ModuleDereferencer (SyntaxTreeCallbackReason reason, typereference_token.production_kind kind, typereference_token p_typereference_token)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            AsnSymbol asnSymbol = (AsnSymbol) p_typereference_token.m_typereference.appInfo;
        //            if (asnSymbol == null)
        //                break;
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        private bool Invoke_ModuleBody_ModuleDereferencer (SyntaxTreeCallbackReason reason, ModuleBody.production_kind kind, ModuleBody p_ModuleBody)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    if (p_ModuleBody.m_Imports != null)
                        Traverse (p_ModuleBody.m_Imports);
                    if (p_ModuleBody.m_Exports != null)
                        Traverse (p_ModuleBody.m_Exports);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return false;
        }

        private bool Invoke_GlobalModuleReference_ModuleDereferencer (SyntaxTreeCallbackReason reason, GlobalModuleReference.production_kind kind, GlobalModuleReference p_GlobalModuleReference)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    SyntaxTreeToken token = p_GlobalModuleReference.m_modulereference_token.m_typereference_token.m_typereference;
                    string moduleName = token.text;
                    AsnSymbol asnSymbol = new AsnSymbol (moduleName, null, p_GlobalModuleReference);
                    AsnSymbol symbol;
                    if ((symbol = symbolTable.find (asnSymbol)) == null)
                        Console.Error.WriteLine ($"undefined module reference: {moduleName}");
                    else
                        token.appInfo = symbol;
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool Invoke_ModuleIdentifier_ModuleDereferencer (SyntaxTreeCallbackReason reason, ModuleIdentifier.production_kind kind, ModuleIdentifier p_ModuleIdentifier)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    string moduleName = p_ModuleIdentifier.m_modulereference_token.m_typereference_token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (moduleName, null, null);
                    currentModule = symbolTable.find (asnSymbol);
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool Invoke_Exports_ModuleDereferencer (SyntaxTreeCallbackReason reason, Exports.production_kind kind, Exports p_Exports)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    switch (kind)
                    {
                        case Exports.production_kind.g_Exports_1:   // EXPORTS SymbolsExported ;
                        {
                            for (SymbolList symbolList = p_Exports.m_SymbolsExported.m_SymbolList; symbolList != null; symbolList = symbolList.m_SymbolList)
                            {
                                Symbol symbol = symbolList.m_Symbol;
                                AsnSymbol asnSymbol = new AsnSymbol (symbol.getName (), currentModule, null);
                                AsnSymbol exportSymbol = symbolTable.find (asnSymbol);
                                if (exportSymbol != null)
                                {
                                    exportSymbol.Flags |= AsnSymbol.Exported;
                                    infoSetter.SetInfo (symbol, exportSymbol);
                                }
                                else
                                    Console.Error.WriteLine ($"undefined exported symbol: file: {currentFile}, symbol: {asnSymbol.Name}");
                            }
                        }
                        break;
                        case Exports.production_kind.g_Exports_2:   // EXPORTS ALL ;
                            currentModule.Flags |= AsnSymbol.Exported;
                            break;
                        case Exports.production_kind.g_Exports_3:   // %empty
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

        private bool Invoke_SymbolsFromModule_ModuleDereferencer (SyntaxTreeCallbackReason reason, SymbolsFromModule.production_kind kind, SymbolsFromModule p_SymbolsFromModule)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    GlobalModuleReference globalModuleReference = p_SymbolsFromModule.m_GlobalModuleReference;
                    string moduleName = globalModuleReference.m_modulereference_token.m_typereference_token.m_typereference.text;
                    AsnSymbol asnSymbol = new AsnSymbol (moduleName, null, null);
                    AsnSymbol moduleSymbol;
                    if ((moduleSymbol = symbolTable.find (asnSymbol)) == null)
                        Console.Error.WriteLine ($"undefined module reference: {moduleName}");
                    for (SymbolList symbolList = p_SymbolsFromModule.m_SymbolList; symbolList != null; symbolList = symbolList.m_SymbolList)
                    {
                        Symbol symbol = symbolList.m_Symbol;
                        string name = symbol.getName ();
                        AsnSymbol importingSymbol = symbolTable.find (new AsnSymbol (name, currentModule, null));
                        AsnSymbol importedSymbol = new AsnSymbol (name, moduleSymbol, null);
                        if ((importingSymbol.Reference = symbolTable.find (importedSymbol)) == null)
                            Console.Error.WriteLine ($"undefined imported symbol: file: {currentFile}, symbol: {name}");
                        else
                            infoSetter.SetInfo (symbol, importingSymbol.Reference);
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

        //ParameterTable CreateParameterTable (ActualParameter_set actualParameters, ListOfParameters parameters)
        //{
        //    ParameterTable parTable = new ParameterTable ();
        //    SyntaxTreeBase parLink;
        //    for (parLink = actualParameters; actualParameters != null; actualParameters = actualParameters.m_ActualParameter_set)
        //        parLink = actualParameters;
        //    foreach (Parameter parameter in parameters)
        //    {
        //        if ((parLink == null) || !(parLink is ActualParameter_set))
        //        {
        //            Console.Error.WriteLine ($"number of actual parameters is lesser than number of declared parameters");
        //            break;
        //        }
        //        string parText = "";
        //        actualParameters = (ActualParameter_set) parLink;
        //        ActualParameter actualParameter = actualParameters.m_ActualParameter;
        //        ParamGovernor paramGovernor = parameter.m_ParamGovernor;
        //        string parName = parameter.m_DummyReference.Emit (-1);
        //        switch ((ActualParameter.production_kind) actualParameter.kind)
        //        {
        //            case ActualParameter.production_kind.g_ActualParameter_1:
        //            {
        //                Asn.Parser.Type type = actualParameter.m_Type;
        //                parName += $"_TY_{ParameterizedTypeGovernor.Counter}";
        //                parText = $"{parName} ::= {type.Emit (-1)}";
        //            }
        //            break;
        //            case ActualParameter.production_kind.g_ActualParameter_2:
        //            {
        //                Value value = actualParameter.m_Value;
        //                parName += $"_VL_{ParameterizedValueGovernor.Counter}";
        //                if (paramGovernor != null)
        //                    parText = $"{parName} {paramGovernor.Emit (-1)} ::= {value.Emit (-1)}";
        //                else
        //                    Console.Error.WriteLine ($"cannot generate parameter value");
        //            }
        //            break;
        //            case ActualParameter.production_kind.g_ActualParameter_3:
        //            {
        //                ValueSet valueSet = actualParameter.m_ValueSet;
        //                parName += $"_VS_{ParameterizedValueSetTypeGovernor.Counter}";
        //                if (paramGovernor != null)
        //                    parText = $"{parName} {paramGovernor.Emit (-1)} ::= {valueSet.Emit (-1)}";
        //                else
        //                    Console.Error.WriteLine ($"cannot generate parameter value set");
        //            }
        //            break;
        //            case ActualParameter.production_kind.g_ActualParameter_4:
        //            {
        //                DefinedObjectClass definedObjectClass = actualParameter.m_DefinedObjectClass;
        //                parName += $"_DO_{ParameterizedObjectClassGovernor.Counter}";
        //                parText = $"{parName} ::= {definedObjectClass.Emit (-1)}";
        //            }
        //            break;
        //            case ActualParameter.production_kind.g_ActualParameter_5:
        //            {
        //                Asn.Parser.Object @object = actualParameter.m_Object;
        //                parName += $"_OB_{ParameterizedObjectGovernor.Counter}";
        //                if (paramGovernor != null)
        //                    parText = $"{parName} {paramGovernor.Emit (-1)} ::= {@object.Emit (-1)}";
        //                else
        //                    Console.Error.WriteLine ($"cannot generate parameter object");
        //                if (parText.Contains (" : "))
        //                    break;
        //            }
        //            break;
        //            case ActualParameter.production_kind.g_ActualParameter_6:
        //            {
        //                ObjectSet objectSet = actualParameter.m_ObjectSet;
        //                parName += $"_OS_{ParameterizedObjectSetGovernor.Counter}";
        //                if (paramGovernor != null)
        //                    parText = $"{parName} {paramGovernor.Emit (-1)} ::= {objectSet.Emit (-1)}";
        //                else
        //                    Console.Error.WriteLine ($"cannot generate parameter object set");
        //            }
        //            break;
        //            default:
        //                parText = actualParameter.Emit (-1);
        //                break;
        //        }
        //        parTable.Add (new ParameterDescriptor (parameter.m_ParamGovernor, parameter.m_DummyReference, parName, parText));
        //        parLink = parLink.parent;
        //        actualParameters = null;
        //    }
        //    if (actualParameters != null)
        //        Console.Error.WriteLine ($"number of actual parameters is greater than number of declared parameters");
        //    uint index = 0;
        //    if (AsnCompiler.Debug)
        //        foreach (ParameterDescriptor par in parTable)
        //        {
        //            string governorName = (par.governor != null) ? par.governor.Emit (-1) : "null";
        //            Console.WriteLine ($"parameter {index++}:");
        //            Console.WriteLine ($"\tgovernor: {governorName}");
        //            Console.WriteLine ($"\tname:     {par.reference.Emit (-1)}");
        //            Console.WriteLine ($"\tvalue:    {par.parValue}");
        //        }
        //    return parTable;

        //}

        //public void ResolveParameters ()
        //{
        //    ParameterizedType_Event += Invoke_ParameterizedType_ParResolver;
        //    ParameterizedValue_Event += Invoke_ParameterizedValue_ParResolver;
        //    ParameterizedValueSetType_Event += Invoke_ParameterizedValueSetType_ParResolver;
        //    ParameterizedObjectClass_Event += Invoke_ParameterizedObjectClass_ParResolver;
        //    ParameterizedObjectSet_Event += Invoke_ParameterizedObjectSet_ParResolver;
        //    ParameterizedObject_Event += Invoke_ParameterizedObject_ParResolver;
        //    ActualParameterList_Event += Invoke_ActualParameterList_ParResolver;
        //    ActualParameter_Event += Invoke_ActualParameter_ParResolver;
        //    SimpleDefinedType_Event += Invoke_SimpleDefinedType_ParResolver;
        //    SimpleDefinedValue_Event += Invoke_SimpleDefinedValue_ParResolver;
        //    DefinedObjectClass_Event += Invoke_DefinedObjectClass_ParResolver;
        //    DefinedObjectSet_Event += Invoke_DefinedObjectSet_ParResolver;
        //    DefinedObject_Event += Invoke_DefinedObject_ParResolver;
        //    ExternalTypeReference_Event += Invoke_ExternalTypeReference_ParResolver;
        //    ExternalValueReference_Event += Invoke_ExternalValueReference_ParResolver;
        //    ExternalObjectClassReference_Event += Invoke_ExternalObjectClassReference_ParResolver;
        //    ExternalObjectSetReference_Event += Invoke_ExternalObjectSetReference_ParResolver;
        //    ExternalObjectReference_Event += Invoke_ExternalObjectReference_ParResolver;
        //    ParameterizedAssignment_Event += Invoke_ParameterizedAssignment_ParResolver;
        //    foreach (List<ModuleDescriptor> moduleList in moduleCollection.Values)
        //        foreach (ModuleDescriptor module in moduleList)
        //        {
        //            currentFile = module.fileName;
        //            currentModule = module.moduleSymbol;
        //            Traverse (module.moduleDefinition);
        //        }

        //    if (AsnDataBase.GeneratedModules.Count > 0)
        //    {
        //        string [] moduleSrc = AsnDataBase.GeneratedModules.ToArray ();
        //        AsnCompiler compiler = new AsnCompiler ();
        //        if (compiler.ParseStringList (moduleSrc, new int [] { (int) TerminalCodes.token_ModuleDefinitions_token }) != 0)
        //            Console.Error.WriteLine ($"IMPLEMENTATION ERROR: errors in generated code");
        //        else
        //        {
        //            parselist p_synlist = compiler.parseList;
        //            foreach (SyntaxTreeBase node in compiler.parseList)
        //            {
        //                if (node == null)
        //                    continue;
        //                node.reparent (null);
        //                AsnDataBase.asnFeatures.Add (((asn_features) node, "generated"));
        //            }
        //        }
        //    }

        //    ParameterizedType_Event -= Invoke_ParameterizedType_ParResolver;
        //    ParameterizedValue_Event -= Invoke_ParameterizedValue_ParResolver;
        //    ParameterizedValueSetType_Event -= Invoke_ParameterizedValueSetType_ParResolver;
        //    ParameterizedObjectClass_Event -= Invoke_ParameterizedObjectClass_ParResolver;
        //    ParameterizedObjectSet_Event -= Invoke_ParameterizedObjectSet_ParResolver;
        //    ParameterizedObject_Event -= Invoke_ParameterizedObject_ParResolver;
        //    ActualParameterList_Event -= Invoke_ActualParameterList_ParResolver;
        //    ActualParameter_Event -= Invoke_ActualParameter_ParResolver;
        //    SimpleDefinedType_Event -= Invoke_SimpleDefinedType_ParResolver;
        //    SimpleDefinedValue_Event -= Invoke_SimpleDefinedValue_ParResolver;
        //    DefinedObjectClass_Event -= Invoke_DefinedObjectClass_ParResolver;
        //    DefinedObjectSet_Event -= Invoke_DefinedObjectSet_ParResolver;
        //    DefinedObject_Event -= Invoke_DefinedObject_ParResolver;
        //    ExternalTypeReference_Event -= Invoke_ExternalTypeReference_ParResolver;
        //    ExternalValueReference_Event -= Invoke_ExternalValueReference_ParResolver;
        //    ExternalObjectClassReference_Event -= Invoke_ExternalObjectClassReference_ParResolver;
        //    ExternalObjectSetReference_Event -= Invoke_ExternalObjectSetReference_ParResolver;
        //    ExternalObjectReference_Event -= Invoke_ExternalObjectReference_ParResolver;
        //    ParameterizedAssignment_Event -= Invoke_ParameterizedAssignment_ParResolver;
        //}

        //private bool Invoke_ParameterizedAssignment_ParResolver (SyntaxTreeCallbackReason reason, ParameterizedAssignment.production_kind kind, ParameterizedAssignment p_ParameterizedAssignment)
        //{
        //    return false;
        //}

        //private bool Invoke_ExternalObjectReference_ParResolver (SyntaxTreeCallbackReason reason, ExternalObjectReference.production_kind kind, ExternalObjectReference p_ExternalObjectReference)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string moduleName = p_ExternalObjectReference.m_modulereference_token.m_typereference_token.m_typereference.text;
        //            AsnSymbol moduleSymbol = new AsnSymbol (moduleName, null, null);
        //            AsnSymbol symbol = symbolTable.find (moduleSymbol);
        //            if (symbol == null)
        //            {
        //                Console.Error.WriteLine ($"undefined module reference: {moduleName}");
        //                break;
        //            }
        //            string objectName = p_ExternalObjectReference.m_objectreference_token.m_identifier_token.m_identifier.text;
        //            AsnSymbol objectSymbol = new AsnSymbol (objectName, symbol, null);
        //            symbol = symbolTable.find (objectSymbol);
        //            if (symbol == null)
        //            {
        //                // since we are just looking for external references within parameter lists, we cannot be sure that this is an error
        //                // actual error will be reported when dealing with parameterized objects when it will be checked appInfo for this node
        //                //Console.Error.WriteLine ($"undefined parameterized object reference: file: {currentFile}, object reference: {moduleName}.{objectName}");
        //                break;
        //            }
        //            p_ExternalObjectReference.appInfo = symbol;
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_ExternalObjectSetReference_ParResolver (SyntaxTreeCallbackReason reason, ExternalObjectSetReference.production_kind kind, ExternalObjectSetReference p_ExternalObjectSetReference)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string moduleName = p_ExternalObjectSetReference.m_modulereference_token.m_typereference_token.m_typereference.text;
        //            AsnSymbol moduleSymbol = new AsnSymbol (moduleName, null, null);
        //            AsnSymbol symbol = symbolTable.find (moduleSymbol);
        //            if (symbol == null)
        //            {
        //                Console.Error.WriteLine ($"undefined module reference: {moduleName}");
        //                break;
        //            }
        //            string objectSetName = p_ExternalObjectSetReference.m_objectsetreference_token.m_typereference_token.m_typereference.text;
        //            AsnSymbol objectSetSymbol = new AsnSymbol (objectSetName, symbol, null);
        //            symbol = symbolTable.find (objectSetSymbol);
        //            if (symbol == null)
        //            {
        //                // since we are just looking for external references within parameter lists, we cannot be sure that this is an error
        //                // actual error will be reported when dealing with parameterized objects when it will be checked appInfo for this node
        //                //Console.Error.WriteLine ($"undefined parameterized object set reference: file: {currentFile}, object set reference: {moduleName}.{objectSetName}");
        //                break;
        //            }
        //            p_ExternalObjectSetReference.appInfo = symbol;
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_ExternalObjectClassReference_ParResolver (SyntaxTreeCallbackReason reason, ExternalObjectClassReference.production_kind kind, ExternalObjectClassReference p_ExternalObjectClassReference)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string moduleName = p_ExternalObjectClassReference.m_modulereference_token.m_typereference_token.m_typereference.text;
        //            AsnSymbol moduleSymbol = new AsnSymbol (moduleName, null, null);
        //            AsnSymbol symbol = symbolTable.find (moduleSymbol);
        //            if (symbol == null)
        //            {
        //                Console.Error.WriteLine ($"undefined module reference: {moduleName}");
        //                break;
        //            }
        //            string objectClassName = p_ExternalObjectClassReference.m_objectclassreference_token.m_typereference_token.m_typereference.text;
        //            AsnSymbol objectClassSymbol = new AsnSymbol (objectClassName, symbol, null);
        //            symbol = symbolTable.find (objectClassSymbol);
        //            if (symbol == null)
        //            {
        //                // since we are just looking for external references within parameter lists, we cannot be sure that this is an error
        //                // actual error will be reported when dealing with parameterized objects when it will be checked appInfo for this node
        //                //Console.Error.WriteLine ($"undefined parameterized object class reference: file: {currentFile}, object class reference: {moduleName}.{objectClassName}");
        //                break;
        //            }
        //            p_ExternalObjectClassReference.appInfo = symbol;
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_ExternalValueReference_ParResolver (SyntaxTreeCallbackReason reason, ExternalValueReference.production_kind kind, ExternalValueReference p_ExternalValueReference)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string moduleName = p_ExternalValueReference.m_modulereference_token.m_typereference_token.m_typereference.text;
        //            AsnSymbol moduleSymbol = new AsnSymbol (moduleName, null, null);
        //            AsnSymbol symbol = symbolTable.find (moduleSymbol);
        //            if (symbol == null)
        //            {
        //                Console.Error.WriteLine ($"undefined module reference: {moduleName}");
        //                break;
        //            }
        //            string valueName = p_ExternalValueReference.m_valuereference_token.m_identifier_token.m_identifier.text;
        //            AsnSymbol valueSymbol = new AsnSymbol (valueName, symbol, null);
        //            symbol = symbolTable.find (valueSymbol);
        //            if (symbol == null)
        //            {
        //                // since we are just looking for external references within parameter lists, we cannot be sure that this is an error
        //                // actual error will be reported when dealing with parameterized objects when it will be checked appInfo for this node
        //                //Console.Error.WriteLine ($"undefined parameterized value reference: file: {currentFile}, value reference: {moduleName}.{valueName}");
        //                break;
        //            }
        //            p_ExternalValueReference.appInfo = symbol;
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_ExternalTypeReference_ParResolver (SyntaxTreeCallbackReason reason, ExternalTypeReference.production_kind kind, ExternalTypeReference p_ExternalTypeReference)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            string moduleName = p_ExternalTypeReference.m_modulereference_token.m_typereference_token.m_typereference.text;
        //            AsnSymbol moduleSymbol = new AsnSymbol (moduleName, null, null);
        //            AsnSymbol symbol = symbolTable.find (moduleSymbol);
        //            if (symbol == null)
        //            {
        //                Console.Error.WriteLine ($"undefined module reference: {moduleName}");
        //                break;
        //            }
        //            string typeName = p_ExternalTypeReference.m_typereference_token.m_typereference.text;
        //            AsnSymbol typeSymbol = new AsnSymbol (typeName, symbol, null);
        //            symbol = symbolTable.find (typeSymbol);
        //            if (symbol == null)
        //            {
        //                // since we are just looking for external references within parameter lists, we cannot be sure that this is an error
        //                // actual error will be reported when dealing with parameterized objects when it will be checked appInfo for this node
        //                //Console.Error.WriteLine ($"undefined parameterized type reference: file: {currentFile}, type reference: {moduleName}.{typeName}");
        //                break;
        //            }
        //            p_ExternalTypeReference.appInfo = symbol;
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_DefinedObject_ParResolver (SyntaxTreeCallbackReason reason, DefinedObject.production_kind kind, DefinedObject p_DefinedObject)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            AsnSymbol objectSymbol = null;
        //            switch (kind)
        //            {
        //                case DefinedObject.production_kind.g_DefinedObject_1:
        //                    objectSymbol = (AsnSymbol) p_DefinedObject.m_ExternalObjectReference.appInfo;
        //                    break;
        //                case DefinedObject.production_kind.g_DefinedObject_2:
        //                {
        //                    string objectName = p_DefinedObject.m_objectreference_token.m_identifier_token.m_identifier.text;
        //                    AsnSymbol asnSymbol = new AsnSymbol (objectName, currentModule, null);
        //                    if ((objectSymbol = symbolTable.find (asnSymbol)) == null)
        //                    {
        //                        // since we are just looking for external references within parameter lists, we cannot be sure that this is an error
        //                        // actual error will be reported when dealing with parameterized objects when it will be checked appInfo for this node
        //                        //Console.Error.WriteLine ($"undefined parameterized object reference: file: {currentFile}, object reference: {currentModule.Name}.{objectName}");
        //                        break;
        //                    }
        //                }
        //                break;
        //            }
        //            p_DefinedObject.appInfo = objectSymbol;
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_DefinedObjectSet_ParResolver (SyntaxTreeCallbackReason reason, DefinedObjectSet.production_kind kind, DefinedObjectSet p_DefinedObjectSet)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            AsnSymbol objectSetSymbol = null;
        //            switch (kind)
        //            {
        //                case DefinedObjectSet.production_kind.g_DefinedObjectSet_1:
        //                    objectSetSymbol = (AsnSymbol) p_DefinedObjectSet.m_ExternalObjectSetReference.appInfo;
        //                    break;
        //                case DefinedObjectSet.production_kind.g_DefinedObjectSet_2:
        //                {
        //                    string objectSetName = p_DefinedObjectSet.m_objectsetreference_token.m_typereference_token.m_typereference.text;
        //                    AsnSymbol asnSymbol = new AsnSymbol (objectSetName, currentModule, null);
        //                    if ((objectSetSymbol = symbolTable.find (asnSymbol)) == null)
        //                    {
        //                        // since we are just looking for external references within parameter lists, we cannot be sure that this is an error
        //                        // actual error will be reported when dealing with parameterized objects when it will be checked appInfo for this node
        //                        //Console.Error.WriteLine ($"undefined parameterized object set reference: file: {currentFile}, object set reference: {currentModule.Name}.{objectSetName}");
        //                        break;
        //                    }
        //                }
        //                break;
        //            }
        //            p_DefinedObjectSet.appInfo = objectSetSymbol;
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_DefinedObjectClass_ParResolver (SyntaxTreeCallbackReason reason, DefinedObjectClass.production_kind kind, DefinedObjectClass p_DefinedObjectClass)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            AsnSymbol objectClassSymbol = null;
        //            switch (kind)
        //            {
        //                case DefinedObjectClass.production_kind.g_DefinedObjectClass_1:
        //                    objectClassSymbol = (AsnSymbol) p_DefinedObjectClass.m_ExternalObjectClassReference.appInfo;
        //                    break;
        //                case DefinedObjectClass.production_kind.g_DefinedObjectClass_2:
        //                {
        //                    string objectClassName = p_DefinedObjectClass.m_objectclassreference_token.m_typereference_token.m_typereference.text;
        //                    AsnSymbol asnSymbol = new AsnSymbol (objectClassName, currentModule, null);
        //                    if ((objectClassSymbol = symbolTable.find (asnSymbol)) == null)
        //                    {
        //                        // since we are just looking for external references within parameter lists, we cannot be sure that this is an error
        //                        // actual error will be reported when dealing with parameterized objects when it will be checked appInfo for this node
        //                        //Console.Error.WriteLine ($"undefined parameterized object class reference: file: {currentFile}, object class reference: {currentModule.Name}.{objectClassName}");
        //                        break;
        //                    }
        //                }
        //                break;
        //                case DefinedObjectClass.production_kind.g_DefinedObjectClass_3:
        //                    break;
        //            }
        //            p_DefinedObjectClass.appInfo = objectClassSymbol;
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_SimpleDefinedValue_ParResolver (SyntaxTreeCallbackReason reason, SimpleDefinedValue.production_kind kind, SimpleDefinedValue p_SimpleDefinedValue)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            AsnSymbol valueSymbol = null;
        //            switch (kind)
        //            {
        //                case SimpleDefinedValue.production_kind.g_SimpleDefinedValue_1:
        //                    valueSymbol = (AsnSymbol) p_SimpleDefinedValue.m_ExternalValueReference.appInfo;
        //                    break;
        //                case SimpleDefinedValue.production_kind.g_SimpleDefinedValue_2:
        //                {
        //                    string valueName = p_SimpleDefinedValue.m_valuereference_token.m_identifier_token.m_identifier.text;
        //                    AsnSymbol asnSymbol = new AsnSymbol (valueName, currentModule, null);
        //                    if ((valueSymbol = symbolTable.find (asnSymbol)) == null)
        //                    {
        //                        // since we are just looking for external references within parameter lists, we cannot be sure that this is an error
        //                        // actual error will be reported when dealing with parameterized objects when it will be checked appInfo for this node
        //                        //Console.Error.WriteLine ($"undefined parameterized value reference: file: {currentFile}, value reference: {currentModule.Name}.{valueName}");
        //                        break;
        //                    }
        //                }
        //                break;
        //            }
        //            p_SimpleDefinedValue.appInfo = valueSymbol;
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_SimpleDefinedType_ParResolver (SyntaxTreeCallbackReason reason, SimpleDefinedType.production_kind kind, SimpleDefinedType p_SimpleDefinedType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            AsnSymbol typeSymbol = null;
        //            switch (kind)
        //            {
        //                case SimpleDefinedType.production_kind.g_SimpleDefinedType_1:
        //                    typeSymbol = (AsnSymbol) p_SimpleDefinedType.m_ExternalTypeReference.appInfo;
        //                    break;
        //                case SimpleDefinedType.production_kind.g_SimpleDefinedType_2:
        //                {
        //                    string typeName = p_SimpleDefinedType.m_typereference_token.m_typereference.text;
        //                    AsnSymbol asnSymbol = new AsnSymbol (typeName, currentModule, null);
        //                    if ((typeSymbol = symbolTable.find (asnSymbol)) == null)
        //                    {
        //                        // since we are just looking for external references within parameter lists, we cannot be sure that this is an error
        //                        // actual error will be reported when dealing with parameterized objects when it will be checked appInfo for this node
        //                        //Console.Error.WriteLine ($"undefined parameterized type reference: file: {currentFile}, type reference: {currentModule.Name}.{typeName}");
        //                        break;
        //                    }
        //                }
        //                break;
        //            }
        //            p_SimpleDefinedType.appInfo = typeSymbol;
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_ActualParameter_ParResolver (SyntaxTreeCallbackReason reason, ActualParameter.production_kind kind, ActualParameter p_ActualParameter)
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

        //private bool Invoke_ActualParameterList_ParResolver (SyntaxTreeCallbackReason reason, ActualParameterList.production_kind kind, ActualParameterList p_ActualParameterList)
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

        //private bool Invoke_ParameterizedObject_ParResolver (SyntaxTreeCallbackReason reason, ParameterizedObject.production_kind kind, ParameterizedObject p_ParameterizedObject)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            ++parstack;
        //            if (kind != ParameterizedObject.production_kind.g_ParameterizedObject_1)
        //                return false;
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //        {
        //            //if (parstack > maxparstack)
        //            //    Console.Error.WriteLine ($"par stack = {parstack}");
        //            --parstack;
        //            if (kind != ParameterizedObject.production_kind.g_ParameterizedObject_1)
        //                return false;
        //            DefinedObject definedObject = p_ParameterizedObject.m_DefinedObject;
        //            AsnSymbol objectSymbol = (AsnSymbol) definedObject.appInfo;
        //            if (objectSymbol == null)
        //            {
        //                Console.Error.WriteLine ($"undefined parameterized object reference: file: {currentFile}, object reference: {definedObject.Emit (-1)}");
        //                break;
        //            }
        //            ParameterGovernor parameterGovernor;
        //            try
        //            {
        //                parameterGovernor = ParameterCollection [objectSymbol.DefiningReference];
        //                if (parameterGovernor == null)
        //                {
        //                    Console.Error.WriteLine ($"undefined parameterized object governor: file: {currentFile}, object reference: {currentModule.Name}.{objectSymbol.Name}");
        //                    break;
        //                }
        //            }
        //            catch (Exception e)
        //            {
        //                Console.Error.WriteLine ($"object reference is defined but it is not parameterized: file: {currentFile}, object reference: {currentModule.Name}.{objectSymbol.Name}, exception: {e.Message}");
        //                break;
        //            }
        //            ParameterTable parameterTable = CreateParameterTable (p_ParameterizedObject.m_ActualParameterList.m_ActualParameter_set, parameterGovernor.Parameters);
        //            (ResolvedCategory category, bool success) result = parameterGovernor.Resolve (p_ParameterizedObject, objectSymbol, currentModule, parameterTable);
        //            if (!result.success)
        //                break;
        //            Console.WriteLine ($"BEFORE PARAMETERIZATION: {p_ParameterizedObject.Emit (-1)}");
        //            p_ParameterizedObject.m_DefinedObject.Dispose ();
        //            p_ParameterizedObject.m_ActualParameterList.Dispose ();
        //            p_ParameterizedObject.change (result.category);
        //            Console.WriteLine ($"AFTER  PARAMETERIZATION: {p_ParameterizedObject.Emit (-1)}");
        //        }
        //        break;
        //    }
        //    return true;

        //}

        //private bool Invoke_ParameterizedObjectSet_ParResolver (SyntaxTreeCallbackReason reason, ParameterizedObjectSet.production_kind kind, ParameterizedObjectSet p_ParameterizedObjectSet)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            ++parstack;
        //            if (kind != ParameterizedObjectSet.production_kind.g_ParameterizedObjectSet_1)
        //                return false;
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //        {
        //            //if (parstack > maxparstack)
        //            //    Console.Error.WriteLine ($"par stack = {parstack}");
        //            --parstack;
        //            if (kind != ParameterizedObjectSet.production_kind.g_ParameterizedObjectSet_1)
        //                return false;
        //            DefinedObjectSet definedObjectSet = p_ParameterizedObjectSet.m_DefinedObjectSet;
        //            AsnSymbol objectSetSymbol = (AsnSymbol) definedObjectSet.appInfo;
        //            if (objectSetSymbol == null)
        //            {
        //                Console.Error.WriteLine ($"undefined parameterized object set reference: file: {currentFile}, object set reference: {definedObjectSet.Emit (-1)}");
        //                break;
        //            }
        //            ParameterGovernor parameterGovernor;
        //            try
        //            {
        //                parameterGovernor = ParameterCollection [objectSetSymbol.DefiningReference];
        //                if (parameterGovernor == null)
        //                {
        //                    Console.Error.WriteLine ($"undefined parameterized object set governor: file: {currentFile}, object set reference: {currentModule.Name}.{objectSetSymbol.Name}");
        //                    break;
        //                }
        //            }
        //            catch (Exception e)
        //            {
        //                Console.Error.WriteLine ($"object set reference is defined but it is not parameterized: file: {currentFile}, object set reference: {currentModule.Name}.{objectSetSymbol.Name}, exception: {e.Message}");
        //                break;
        //            }
        //            ParameterTable parameterTable = CreateParameterTable (p_ParameterizedObjectSet.m_ActualParameterList.m_ActualParameter_set, parameterGovernor.Parameters);
        //            (ResolvedCategory category, bool success) result = parameterGovernor.Resolve (p_ParameterizedObjectSet, objectSetSymbol, currentModule, parameterTable);
        //            if (!result.success)
        //                break;
        //            Console.WriteLine ($"BEFORE PARAMETERIZATION: {p_ParameterizedObjectSet.Emit (-1)}");
        //            p_ParameterizedObjectSet.m_DefinedObjectSet.Dispose ();
        //            p_ParameterizedObjectSet.m_ActualParameterList.Dispose ();
        //            p_ParameterizedObjectSet.change (result.category);
        //            Console.WriteLine ($"AFTER  PARAMETERIZATION: {p_ParameterizedObjectSet.Emit (-1)}");
        //        }
        //        break;
        //    }
        //    return true;

        //}

        //private bool Invoke_ParameterizedObjectClass_ParResolver (SyntaxTreeCallbackReason reason, ParameterizedObjectClass.production_kind kind, ParameterizedObjectClass p_ParameterizedObjectClass)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            ++parstack;
        //            if (kind != ParameterizedObjectClass.production_kind.g_ParameterizedObjectClass_1)
        //                return false;
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //        {
        //            //if (parstack > maxparstack)
        //            //    Console.Error.WriteLine ($"par stack = {parstack}");
        //            --parstack;
        //            if (kind != ParameterizedObjectClass.production_kind.g_ParameterizedObjectClass_1)
        //                return false;
        //            DefinedObjectClass definedObjectClass = p_ParameterizedObjectClass.m_DefinedObjectClass;
        //            AsnSymbol objectClassSymbol = (AsnSymbol) definedObjectClass.appInfo;
        //            if (objectClassSymbol == null)
        //            {
        //                Console.Error.WriteLine ($"undefined parameterized object class reference: file: {currentFile}, object class reference: {definedObjectClass.Emit (-1)}");
        //                break;
        //            }
        //            ParameterGovernor parameterGovernor;
        //            try
        //            {
        //                parameterGovernor = ParameterCollection [objectClassSymbol.DefiningReference];
        //                if (parameterGovernor == null)
        //                {
        //                    Console.Error.WriteLine ($"undefined parameterized object class governor: file: {currentFile}, object class reference: {currentModule.Name}.{objectClassSymbol.Name}");
        //                    break;
        //                }
        //            }
        //            catch (Exception e)
        //            {
        //                Console.Error.WriteLine ($"object class reference is defined but it is not parameterized: file: {currentFile}, object class reference: {currentModule.Name}.{objectClassSymbol.Name}, exception: {e.Message}");
        //                break;
        //            }
        //            ParameterTable parameterTable = CreateParameterTable (p_ParameterizedObjectClass.m_ActualParameterList.m_ActualParameter_set, parameterGovernor.Parameters);
        //            (ResolvedCategory category, bool success) result = parameterGovernor.Resolve (p_ParameterizedObjectClass, objectClassSymbol, currentModule, parameterTable);
        //            if (!result.success)
        //                break;
        //            Console.WriteLine ($"BEFORE PARAMETERIZATION: {p_ParameterizedObjectClass.Emit (-1)}");
        //            p_ParameterizedObjectClass.m_DefinedObjectClass.Dispose ();
        //            p_ParameterizedObjectClass.m_ActualParameterList.Dispose ();
        //            p_ParameterizedObjectClass.change (result.category);
        //            Console.WriteLine ($"AFTER  PARAMETERIZATION: {p_ParameterizedObjectClass.Emit (-1)}");
        //        }
        //        break;
        //    }
        //    return true;

        //}

        //private bool Invoke_ParameterizedValueSetType_ParResolver (SyntaxTreeCallbackReason reason, ParameterizedValueSetType.production_kind kind, ParameterizedValueSetType p_ParameterizedValueSetType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            ++parstack;
        //            if (kind != ParameterizedValueSetType.production_kind.g_ParameterizedValueSetType_1)
        //                return false;
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //        {
        //            //if (parstack > maxparstack)
        //            //    Console.Error.WriteLine ($"par stack = {parstack}");
        //            --parstack;
        //            if (kind != ParameterizedValueSetType.production_kind.g_ParameterizedValueSetType_1)
        //                return false;
        //            SimpleDefinedType simpleDefinedType = p_ParameterizedValueSetType.m_SimpleDefinedType;
        //            AsnSymbol valueSetTypeSymbol = (AsnSymbol) simpleDefinedType.appInfo;
        //            if (valueSetTypeSymbol == null)
        //            {
        //                Console.Error.WriteLine ($"undefined parameterized value set reference: file: {currentFile}, value set reference: {simpleDefinedType.Emit (-1)}");
        //                break;
        //            }
        //            ParameterGovernor parameterGovernor;
        //            try
        //            {
        //                parameterGovernor = ParameterCollection [valueSetTypeSymbol.DefiningReference];
        //                if (parameterGovernor == null)
        //                {
        //                    Console.Error.WriteLine ($"undefined parameterized type governor: file: {currentFile}, type reference: {currentModule.Name}.{valueSetTypeSymbol.Name}");
        //                    break;
        //                }
        //            }
        //            catch (Exception e)
        //            {
        //                Console.Error.WriteLine ($"value set reference is defined but it is not parameterized: file: {currentFile}, type reference: {currentModule.Name}.{valueSetTypeSymbol.Name}, exception: {e.Message}");
        //                break;
        //            }
        //            ParameterTable parameterTable = CreateParameterTable (p_ParameterizedValueSetType.m_ActualParameterList.m_ActualParameter_set, parameterGovernor.Parameters);
        //            (ResolvedCategory category, bool success) result = parameterGovernor.Resolve (p_ParameterizedValueSetType, valueSetTypeSymbol, currentModule, parameterTable);
        //            if (!result.success)
        //                break;
        //            Console.WriteLine ($"BEFORE PARAMETERIZATION: {p_ParameterizedValueSetType.Emit (-1)}");
        //            p_ParameterizedValueSetType.m_SimpleDefinedType.Dispose ();
        //            p_ParameterizedValueSetType.m_ActualParameterList.Dispose ();
        //            p_ParameterizedValueSetType.change (result.category);
        //            Console.WriteLine ($"AFTER  PARAMETERIZATION: {p_ParameterizedValueSetType.Emit (-1)}");
        //        }
        //        break;
        //    }
        //    return true;

        //}

        //private bool Invoke_ParameterizedValue_ParResolver (SyntaxTreeCallbackReason reason, ParameterizedValue.production_kind kind, ParameterizedValue p_ParameterizedValue)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            ++parstack;
        //            if (kind != ParameterizedValue.production_kind.g_ParameterizedValue_1)
        //                return false;
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //        {
        //            //if (parstack > maxparstack)
        //            //    Console.Error.WriteLine ($"par stack = {parstack}");
        //            --parstack;
        //            if (kind != ParameterizedValue.production_kind.g_ParameterizedValue_1)
        //                return false;
        //            SimpleDefinedValue simpleDefinedValue = p_ParameterizedValue.m_SimpleDefinedValue;
        //            AsnSymbol valueSymbol = (AsnSymbol) simpleDefinedValue.appInfo;
        //            if (valueSymbol == null)
        //            {
        //                Console.Error.WriteLine ($"undefined parameterized value reference: file: {currentFile}, value reference: {simpleDefinedValue.Emit (-1)}");
        //                break;
        //            }
        //            ParameterGovernor parameterGovernor;
        //            try
        //            {
        //                parameterGovernor = ParameterCollection [valueSymbol.DefiningReference];
        //                if (parameterGovernor == null)
        //                {
        //                    Console.Error.WriteLine ($"undefined parameterized value governor: file: {currentFile}, value reference: {currentModule.Name}.{valueSymbol.Name}");
        //                    break;
        //                }
        //            }
        //            catch (Exception e)
        //            {
        //                Console.Error.WriteLine ($"value reference is defined but it is nt parameterized: file: {currentFile}, value reference: {currentModule.Name}.{valueSymbol.Name}, exception: {e.Message}");
        //                break;
        //            }
        //            ParameterTable parameterTable = CreateParameterTable (p_ParameterizedValue.m_ActualParameterList.m_ActualParameter_set, parameterGovernor.Parameters);
        //            (ResolvedCategory category, bool success) result = parameterGovernor.Resolve (p_ParameterizedValue, valueSymbol, currentModule, parameterTable);
        //            if (!result.success)
        //                break;
        //            Console.WriteLine ($"BEFORE PARAMETERIZATION: {p_ParameterizedValue.Emit (-1)}");
        //            p_ParameterizedValue.m_SimpleDefinedValue.Dispose ();
        //            p_ParameterizedValue.m_ActualParameterList.Dispose ();
        //            p_ParameterizedValue.change (result.category);
        //            Console.WriteLine ($"AFTER  PARAMETERIZATION: {p_ParameterizedValue.Emit (-1)}");
        //        }
        //        break;
        //    }
        //    return true;

        //}

        //private bool Invoke_ParameterizedType_ParResolver (SyntaxTreeCallbackReason reason, ParameterizedType.production_kind kind, ParameterizedType p_ParameterizedType)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            ++parstack;
        //            if (kind != ParameterizedType.production_kind.g_ParameterizedType_1)
        //                return false;
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //        {
        //            //if (parstack > maxparstack)
        //            //    Console.Error.WriteLine ($"par stack = {parstack}");
        //            --parstack;
        //            if (kind != ParameterizedType.production_kind.g_ParameterizedType_1)
        //                return false;
        //            SimpleDefinedType simpleDefinedType = p_ParameterizedType.m_SimpleDefinedType;
        //            AsnSymbol typeSymbol = (AsnSymbol) simpleDefinedType.appInfo;
        //            if (typeSymbol == null)
        //            {
        //                Console.Error.WriteLine ($"undefined parameterized type reference: file: {currentFile}, type reference: {simpleDefinedType.Emit (-1)}");
        //                break;
        //            }
        //            ParameterGovernor parameterGovernor;
        //            try
        //            {
        //                parameterGovernor = ParameterCollection [typeSymbol.DefiningReference];
        //                if (parameterGovernor == null)
        //                {
        //                    Console.Error.WriteLine ($"undefined parameterized type governor: file: {currentFile}, type reference: {currentModule.Name}.{typeSymbol.Name}");
        //                    break;
        //                }
        //            }
        //            catch (Exception e)
        //            {
        //                Console.Error.WriteLine ($"type reference is defined but it is not parameterized: file: {currentFile}, type reference: {currentModule.Name}.{typeSymbol.Name}, exception: {e.Message}");
        //                break;
        //            }
        //            ParameterTable parameterTable = CreateParameterTable (p_ParameterizedType.m_ActualParameterList.m_ActualParameter_set, parameterGovernor.Parameters);
        //            (ResolvedCategory category, bool success) result = parameterGovernor.Resolve (p_ParameterizedType, typeSymbol, currentModule, parameterTable);
        //            if (!result.success)
        //                break;
        //            Console.WriteLine ($"BEFORE PARAMETERIZATION: {p_ParameterizedType.Emit (-1)}");
        //            p_ParameterizedType.m_SimpleDefinedType.Dispose ();
        //            p_ParameterizedType.m_ActualParameterList.Dispose ();
        //            p_ParameterizedType.change (result.category);
        //            Console.WriteLine ($"AFTER  PARAMETERIZATION: {p_ParameterizedType.Emit (-1)}");
        //        }
        //        break;
        //    }
        //    return true;

        //}

        //public void ResolveValues ()
        //{
        //    Assignment_Event += Invoke_Assignment_Dereferencer;
        //    DefinedSyntax_Event += Invoke_DefinedSyntax_Dereferencer;
        //    DefaultSyntax_Event += Invoke_DefaultSyntax_Dereferencer;
        //    ResolvedCategory_Event += Invoke_ResolvedCategory_Dereferencer;
        //    Type_Event += Invoke_Type_Dereferencer;
        //    ParameterizedAssignment_Event += Invoke_ParameterizedAssignment_Dereferencer;
        //    Value_Event += Invoke_Value_Dereferencer;
        //    foreach (List<ModuleDescriptor> moduleList in AsnDataBase.accumulatedModuleDefinitions.Values)
        //        foreach (ModuleDescriptor module in moduleList)
        //        {
        //            currentFile = module.fileName;
        //            currentModule = module.moduleSymbol;
        //            Traverse (module.moduleDefinition);
        //        }
        //    Assignment_Event -= Invoke_Assignment_Dereferencer;
        //    DefinedSyntax_Event -= Invoke_DefinedSyntax_Dereferencer;
        //    DefaultSyntax_Event -= Invoke_DefaultSyntax_Dereferencer;
        //    ResolvedCategory_Event -= Invoke_ResolvedCategory_Dereferencer;
        //    Type_Event -= Invoke_Type_Dereferencer;
        //    Value_Event -= Invoke_Value_Dereferencer;
        //    ParameterizedAssignment_Event -= Invoke_ParameterizedAssignment_Dereferencer;
        //}

        //private bool Invoke_Value_Dereferencer (SyntaxTreeCallbackReason reason, Value.production_kind kind, Value p_Value)
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

        //private bool Invoke_ParameterizedAssignment_Dereferencer (SyntaxTreeCallbackReason reason, ParameterizedAssignment.production_kind kind, ParameterizedAssignment p_ParameterizedAssignment)
        //{
        //    return false;
        //}

        //private bool Invoke_Type_Dereferencer (SyntaxTreeCallbackReason reason, Asn.Parser.Type.production_kind kind, Asn.Parser.Type p_Type)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            NodeGovernor typeGovernor = (NodeGovernor) p_Type.appInfo;
        //            if (typeGovernor == null)
        //                Console.Error.WriteLine ($"undefined type governor");
        //            typeGovernor.Govern (null);
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_ResolvedCategory_Dereferencer (SyntaxTreeCallbackReason reason, ResolvedCategory.production_kind kind, ResolvedCategory p_ResolvedCategory)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            switch (kind)
        //            {
        //                case ResolvedCategory.production_kind.g_ResolvedCategory_1:
        //                    break;
        //                case ResolvedCategory.production_kind.g_ResolvedCategory_2:
        //                    break;
        //                case ResolvedCategory.production_kind.g_ResolvedCategory_3:
        //                    break;
        //                case ResolvedCategory.production_kind.g_ResolvedCategory_4:
        //                    break;
        //                case ResolvedCategory.production_kind.g_ResolvedCategory_5:
        //                    break;
        //                case ResolvedCategory.production_kind.g_ResolvedCategory_6:
        //                    break;
        //            }
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_DefaultSyntax_Dereferencer (SyntaxTreeCallbackReason reason, DefaultSyntax.production_kind kind, DefaultSyntax p_DefaultSyntax)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            //Console.Error.WriteLine ($"DEFAULT SYNTAX = {p_DefaultSyntax.Emit(-1)}");
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        //private bool Invoke_DefinedSyntax_Dereferencer (SyntaxTreeCallbackReason reason, DefinedSyntax.production_kind kind, DefinedSyntax p_DefinedSyntax)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //            //Console.Error.WriteLine ($"DEFINED SYNTAX = {p_DefinedSyntax.Emit (-1)}");
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return false;
        //}

        //private bool Invoke_Assignment_Dereferencer (SyntaxTreeCallbackReason reason, Assignment.production_kind kind, Assignment p_Assignment)
        //{
        //    switch (reason)
        //    {
        //        case SyntaxTreeCallbackReason.BuilderCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
        //        {
        //            if (false)
        //                switch (kind)
        //                {
        //                    case Assignment.production_kind.g_Assignment_1:
        //                    {
        //                        Asn.Parser.Type type = p_Assignment.m_TypeAssignment.m_Type;
        //                        NodeGovernor typeGovernor = (NodeGovernor) type.appInfo;
        //                        if (typeGovernor == null)
        //                            Console.Error.WriteLine ($"undefined type governor");
        //                        typeGovernor.Govern (null);
        //                    }
        //                    break;
        //                    case Assignment.production_kind.g_Assignment_2:
        //                    {
        //                        ValueAssignment valueAssignment = p_Assignment.m_ValueAssignment;
        //                        Asn.Parser.Type type = valueAssignment.m_Type;
        //                        Value value = valueAssignment.m_Value;
        //                        NodeGovernor typeGovernor = (NodeGovernor) type.appInfo;
        //                        if (typeGovernor == null)
        //                            Console.Error.WriteLine ($"undefined type governor");
        //                        typeGovernor.Govern (value);
        //                    }
        //                    break;
        //                }
        //            break;
        //        }
        //        break;
        //        case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
        //            break;
        //        case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
        //            break;
        //    }
        //    return true;
        //}

        private AsnAppInfoSetter infoSetter = new AsnAppInfoSetter ();

        private ModuleCollection moduleCollection = AsnDataBase.moduleDefinitions;
        private SymbolTable symbolTable = AsnDataBase.symbolTable;
        private ParameterDictionary ParameterCollection = AsnDataBase.ParameterCollection;

        private AsnSymbol globalModuleSymbol = null;
        private AsnSymbol typeIdentifierSymbol = null;
        private AsnSymbol abstractSyntaxSymbol = null;

        private string currentFile;
        private Stack<AsnSymbol> contextSymbols = new Stack<AsnSymbol> ();
        private AsnSymbol currentModule = null;

        private uint parstack = 0;
        private uint maxparstack = 1;
    }
}
