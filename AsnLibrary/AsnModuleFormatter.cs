using Anglr.Parser.Core;
using Anglr.Parser.SyntaxTree;
using Anglr.Parser.Walker;
using Asn.Parser;

using Asn.Declarations;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Asn.Parser.ModuleDefinition;
using System.Data;

namespace AsnLibrary
{
    public class AsnModuleFormatter : SyntaxTreeWalker
    {
        public TextWriter writer { get; private set; }
        private string indent = "";

        public AsnModuleFormatter (TextWriter writer)
        {
            this.writer = writer;

            ModuleDefinition_Event += AsnModuleFormatter_ModuleDefinition_Event;
            ModuleIdentifier_Event += AsnModuleFormatter_ModuleIdentifier_Event;
            DefinitionsDefault_Event += AsnModuleFormatter_DefinitionsDefault_Event;
            EncodingReferenceDefault_Event += AsnModuleFormatter_EncodingReferenceDefault_Event;
            TagDefault_Event += AsnModuleFormatter_TagDefault_Event;
            ExtensionDefault_Event += AsnModuleFormatter_ExtensionDefault_Event;
            EncodingControlSections_Event += AsnModuleFormatter_EncodingControlSections_Event;
            Exports_Event += AsnModuleFormatter_Exports_Event;
            SymbolsExported_Event += AsnModuleFormatter_SymbolsExported_Event;
            SymbolList_Event += AsnModuleFormatter_SymbolList_Event;
            Imports_Event += AsnModuleFormatter_Imports_Event;
            SymbolsImported_Event += AsnModuleFormatter_SymbolsImported_Event;
            SymbolsFromModule_Event += AsnModuleFormatter_SymbolsFromModule_Event;
            ModuleBody_Event += AsnModuleFormatter_ModuleBody_Event;

            TypeAssignment_Event += AsnModuleFormatter_TypeAssignment_Event;
            ValueAssignment_Event += AsnModuleFormatter_ValueAssignment_Event;
            XMLValueAssignment_Event += AsnModuleFormatter_XMLValueAssignment_Event;
            ValueSetTypeAssignment_Event += AsnModuleFormatter_ValueSetTypeAssignment_Event;
            ObjectClassAssignment_Event += AsnModuleFormatter_ObjectClassAssignment_Event;
            ObjectAssignment_Event += AsnModuleFormatter_ObjectAssignment_Event;
            ObjectSetAssignment_Event += AsnModuleFormatter_ObjectSetAssignment_Event;
            ParameterizedAssignment_Event += AsnModuleFormatter_ParameterizedAssignment_Event;
            MacroAssignment_Event += AsnModuleFormatter_MacroAssignment_Event;
            MacroDefinition_Event += AsnModuleFormatter_MacroDefinition_Event;

            AnyType_Event += AsnModuleFormatter_AnyType_Event;
            BitStringType_Event += AsnModuleFormatter_BitStringType_Event;
            BooleanType_Event += AsnModuleFormatter_BooleanType_Event;
            CharacterStringType_Event += AsnModuleFormatter_CharacterStringType_Event;
            ChoiceType_Event += AsnModuleFormatter_ChoiceType_Event;
            DateType_Event += AsnModuleFormatter_DateType_Event;
            DateTimeType_Event += AsnModuleFormatter_DateTimeType_Event;
            DurationType_Event += AsnModuleFormatter_DurationType_Event;
            EmbeddedPDVType_Event += AsnModuleFormatter_EmbeddedPDVType_Event;
            EnumeratedType_Event += AsnModuleFormatter_EnumeratedType_Event;
            ExternalType_Event += AsnModuleFormatter_ExternalType_Event;
            InstanceOfType_Event += AsnModuleFormatter_InstanceOfType_Event;
            IntegerType_Event += AsnModuleFormatter_IntegerType_Event;
            IRIType_Event += AsnModuleFormatter_IRIType_Event;
            NullType_Event += AsnModuleFormatter_NullType_Event;
            ObjectClassFieldType_Event += AsnModuleFormatter_ObjectClassFieldType_Event;
            ObjectIdentifierType_Event += AsnModuleFormatter_ObjectIdentifierType_Event;
            OctetStringType_Event += AsnModuleFormatter_OctetStringType_Event;
            RealType_Event += AsnModuleFormatter_RealType_Event;
            RelativeIRIType_Event += AsnModuleFormatter_RelativeIRIType_Event;
            RelativeOIDType_Event += AsnModuleFormatter_RelativeOIDType_Event;
            SequenceType_Event += AsnModuleFormatter_SequenceType_Event;
            SequenceOfType_Event += AsnModuleFormatter_SequenceOfType_Event;
            SetType_Event += AsnModuleFormatter_SetType_Event;
            SetOfType_Event += AsnModuleFormatter_SetOfType_Event;
            PrefixedType_Event += AsnModuleFormatter_PrefixedType_Event;
            TimeType_Event += AsnModuleFormatter_TimeType_Event;
            TimeOfDayType_Event += AsnModuleFormatter_TimeOfDayType_Event;

            ComponentTypeLists_Event += AsnModuleFormatter_ComponentTypeLists_Event;
            ComponentTypeList_Event += AsnModuleFormatter_ComponentTypeList_Event;
            ComponentType_Event += AsnModuleFormatter_ComponentType_Event;

            NamedType_Event += AsnModuleFormatter_NamedType_Event;

            ReferencedType_Event += AsnModuleFormatter_ReferencedType_Event;
            ConstrainedType_Event += AsnModuleFormatter_ConstrainedType_Event;
            TypeWithConstraint_Event += AsnModuleFormatter_TypeWithConstraint_Event;
            Constraint_Event += AsnModuleFormatter_Constraint_Event;
            SizeConstraint_Event += AsnModuleFormatter_SizeConstraint_Event;
        }

        private bool AsnModuleFormatter_ModuleDefinition_Event (SyntaxTreeCallbackReason reason, ModuleDefinition.production_kind kind, ModuleDefinition p_ModuleDefinition)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    writer.WriteLine ();
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch (p_ModuleDefinition.turn)
                    {
                        case (uint) ModuleDefinition.__p1_markers.m1:
                            writer.WriteLine ($" ::=");
                            writer.WriteLine ($"BEGIN");
                            break;
                        case (uint) ModuleDefinition.__p1_markers.m2:
                            writer.WriteLine ($"END");
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnModuleFormatter_ModuleIdentifier_Event (SyntaxTreeCallbackReason reason, ModuleIdentifier.production_kind kind, ModuleIdentifier p_ModuleIdentifier)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            writer.Write ($"{p_ModuleIdentifier.Emit (-1)}");
            return true;
        }

        private bool AsnModuleFormatter_DefinitionsDefault_Event (SyntaxTreeCallbackReason reason, DefinitionsDefault.production_kind kind, DefinitionsDefault p_DefinitionsDefault)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            if (kind == DefinitionsDefault.production_kind.g_DefinitionsDefault_2)
                return true;
            writer.Write ($" {p_DefinitionsDefault.Emit (-1)}");
            return true;
        }

        private bool AsnModuleFormatter_EncodingReferenceDefault_Event (SyntaxTreeCallbackReason reason, EncodingReferenceDefault.production_kind kind, EncodingReferenceDefault p_EncodingReferenceDefault)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            if (kind == EncodingReferenceDefault.production_kind.g_EncodingReferenceDefault_2)
                return true;
            writer.Write ($" {p_EncodingReferenceDefault.Emit (-1)}");
            return true;
        }

        private bool AsnModuleFormatter_TagDefault_Event (SyntaxTreeCallbackReason reason, TagDefault.production_kind kind, TagDefault p_TagDefault)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            if (kind == TagDefault.production_kind.g_TagDefault_4)
                return true;
            writer.Write ($" {p_TagDefault.Emit (-1)}");
            return true;
        }

        private bool AsnModuleFormatter_ExtensionDefault_Event (SyntaxTreeCallbackReason reason, ExtensionDefault.production_kind kind, ExtensionDefault p_ExtensionDefault)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            if (kind == ExtensionDefault.production_kind.g_ExtensionDefault_2)
                return true;
            writer.Write ($" {p_ExtensionDefault.Emit (-1)}");
            return true;
        }

        private bool AsnModuleFormatter_EncodingControlSections_Event (SyntaxTreeCallbackReason reason, EncodingControlSections.production_kind kind, EncodingControlSections p_EncodingControlSections)
        {
            if (reason != SyntaxTreeCallbackReason.TraversalPrologueCallbackReason)
                return true;
            if (kind == EncodingControlSections.production_kind.g_EncodingControlSections_1)
                return true;
            writer.WriteLine ($" {p_EncodingControlSections.Emit (-1)}");
            return true;
        }

        private bool AsnModuleFormatter_Exports_Event (SyntaxTreeCallbackReason reason, Exports.production_kind kind, Exports p_Exports)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    switch (kind)
                    {
                        case Exports.production_kind.g_Exports_1:
                            writer.Write ($"\tEXPORTS");
                            break;
                        case Exports.production_kind.g_Exports_2:
                            writer.WriteLine ($"\tEXPORTS ALL;");
                            break;
                        case Exports.production_kind.g_Exports_3:
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    switch (kind)
                    {
                        case Exports.production_kind.g_Exports_1:
                            writer.WriteLine ($";");
                            break;
                        case Exports.production_kind.g_Exports_2:
                            break;
                        case Exports.production_kind.g_Exports_3:
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.IterationEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnModuleFormatter_SymbolsExported_Event (SyntaxTreeCallbackReason reason, SymbolsExported.production_kind kind, SymbolsExported p_SymbolsExported)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    switch (kind)
                    {
                        case SymbolsExported.production_kind.g_SymbolsExported_1:
                            break;
                        case SymbolsExported.production_kind.g_SymbolsExported_2:
                            writer.Write ($" ");
                            break;
                    }
                }
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

        private bool AsnModuleFormatter_SymbolList_Event (SyntaxTreeCallbackReason reason, SymbolList.production_kind kind, SymbolList p_SymbolList)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    switch (kind)
                    {
                        case SymbolList.production_kind.g_SymbolList_1:
                            writer.WriteLine ();
                            break;
                        case SymbolList.production_kind.g_SymbolList_2:
                            writer.WriteLine ($",");
                            break;
                    }
                    writer.Write ($"\t\t{p_SymbolList.m_Symbol.Emit (-1)}");
                }
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

        private bool AsnModuleFormatter_Imports_Event (SyntaxTreeCallbackReason reason, Imports.production_kind kind, Imports p_Imports)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    switch (kind)
                    {
                        case Imports.production_kind.g_Imports_1:
                            writer.Write ($"\tIMPORTS");
                            break;
                        case Imports.production_kind.g_Imports_2:
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    switch (kind)
                    {
                        case Imports.production_kind.g_Imports_1:
                            writer.WriteLine ($";");
                            break;
                        case Imports.production_kind.g_Imports_2:
                            break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.IterationEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnModuleFormatter_SymbolsImported_Event (SyntaxTreeCallbackReason reason, SymbolsImported.production_kind kind, SymbolsImported p_SymbolsImported)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    switch (kind)
                    {
                        case SymbolsImported.production_kind.g_SymbolsImported_1:
                            break;
                        case SymbolsImported.production_kind.g_SymbolsImported_2:
                            writer.Write ($" ");
                            break;
                    }
                }
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

        private bool AsnModuleFormatter_SymbolsFromModule_Event (SyntaxTreeCallbackReason reason, SymbolsFromModule.production_kind kind, SymbolsFromModule p_SymbolsFromModule)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch (p_SymbolsFromModule.turn)
                    {
                        case (uint) SymbolsFromModule.__p1_markers.m1:
                        {
                            string globalModuleReference = p_SymbolsFromModule.m_GlobalModuleReference.Emit (-1);
                            string identifier = p_SymbolsFromModule.m_identifier_token_optional.Emit (-1);
                            string selectionOption = p_SymbolsFromModule.m_SelectionOption.Emit (-1);
                            writer.WriteLine ();
                            writer.Write ($"\tFROM");
                            if (globalModuleReference.Length > 0)
                                writer.Write ($" {globalModuleReference}");
                            if (identifier.Length > 0)
                                writer.Write ($"{identifier}");
                            if (selectionOption.Length > 0)
                                writer.Write ($"{selectionOption}");
                        }
                        break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnModuleFormatter_ModuleBody_Event (SyntaxTreeCallbackReason reason, ModuleBody.production_kind kind, ModuleBody p_ModuleBody)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    indent += '\t';
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    indent = indent.Remove (indent.Length - 1);
                    break;
                case SyntaxTreeCallbackReason.IterationEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnModuleFormatter_TypeAssignment_Event (SyntaxTreeCallbackReason reason, TypeAssignment.production_kind kind, TypeAssignment p_TypeAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"\t{p_TypeAssignment.m_typereference_token.Emit (-1)} ::= ");
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    writer.WriteLine ();
                }
                break;
                case SyntaxTreeCallbackReason.IterationEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnModuleFormatter_ValueAssignment_Event (SyntaxTreeCallbackReason reason, ValueAssignment.production_kind kind, ValueAssignment p_ValueAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.WriteLine ($"\t{p_ValueAssignment.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_XMLValueAssignment_Event (SyntaxTreeCallbackReason reason, XMLValueAssignment.production_kind kind, XMLValueAssignment p_XMLValueAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.WriteLine ($"\t{p_XMLValueAssignment.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_ValueSetTypeAssignment_Event (SyntaxTreeCallbackReason reason, ValueSetTypeAssignment.production_kind kind, ValueSetTypeAssignment p_ValueSetTypeAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.WriteLine ($"\t{p_ValueSetTypeAssignment.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_ObjectClassAssignment_Event (SyntaxTreeCallbackReason reason, ObjectClassAssignment.production_kind kind, ObjectClassAssignment p_ObjectClassAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.WriteLine ($"\t{p_ObjectClassAssignment.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_ObjectAssignment_Event (SyntaxTreeCallbackReason reason, ObjectAssignment.production_kind kind, ObjectAssignment p_ObjectAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.WriteLine ($"\t{p_ObjectAssignment.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_ObjectSetAssignment_Event (SyntaxTreeCallbackReason reason, ObjectSetAssignment.production_kind kind, ObjectSetAssignment p_ObjectSetAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.WriteLine ($"\t{p_ObjectSetAssignment.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_ParameterizedAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedAssignment.production_kind kind, ParameterizedAssignment p_ParameterizedAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.WriteLine ($"\t{p_ParameterizedAssignment.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_MacroAssignment_Event (SyntaxTreeCallbackReason reason, MacroAssignment.production_kind kind, MacroAssignment p_MacroAssignment)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.WriteLine ($"\t{p_MacroAssignment.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_MacroDefinition_Event (SyntaxTreeCallbackReason reason, MacroDefinition.production_kind kind, MacroDefinition p_MacroDefinition)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.WriteLine ($"\t{p_MacroDefinition.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_AnyType_Event (SyntaxTreeCallbackReason reason, AnyType.production_kind kind, AnyType p_AnyType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_AnyType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_BitStringType_Event (SyntaxTreeCallbackReason reason, BitStringType.production_kind kind, BitStringType p_BitStringType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_BitStringType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_BooleanType_Event (SyntaxTreeCallbackReason reason, BooleanType.production_kind kind, BooleanType p_BooleanType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_BooleanType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_CharacterStringType_Event (SyntaxTreeCallbackReason reason, CharacterStringType.production_kind kind, CharacterStringType p_CharacterStringType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_CharacterStringType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_ChoiceType_Event (SyntaxTreeCallbackReason reason, ChoiceType.production_kind kind, ChoiceType p_ChoiceType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_ChoiceType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_DateType_Event (SyntaxTreeCallbackReason reason, DateType.production_kind kind, DateType p_DateType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_DateType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_DateTimeType_Event (SyntaxTreeCallbackReason reason, DateTimeType.production_kind kind, DateTimeType p_DateTimeType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_DateTimeType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_DurationType_Event (SyntaxTreeCallbackReason reason, DurationType.production_kind kind, DurationType p_DurationType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_DurationType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_EmbeddedPDVType_Event (SyntaxTreeCallbackReason reason, EmbeddedPDVType.production_kind kind, EmbeddedPDVType p_EmbeddedPDVType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_EmbeddedPDVType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_EnumeratedType_Event (SyntaxTreeCallbackReason reason, EnumeratedType.production_kind kind, EnumeratedType p_EnumeratedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_EnumeratedType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_ExternalType_Event (SyntaxTreeCallbackReason reason, ExternalType.production_kind kind, ExternalType p_ExternalType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_ExternalType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_InstanceOfType_Event (SyntaxTreeCallbackReason reason, InstanceOfType.production_kind kind, InstanceOfType p_InstanceOfType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_InstanceOfType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_IntegerType_Event (SyntaxTreeCallbackReason reason, IntegerType.production_kind kind, IntegerType p_IntegerType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_IntegerType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_IRIType_Event (SyntaxTreeCallbackReason reason, IRIType.production_kind kind, IRIType p_IRIType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_IRIType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_NullType_Event (SyntaxTreeCallbackReason reason, NullType.production_kind kind, NullType p_NullType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_NullType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_ObjectClassFieldType_Event (SyntaxTreeCallbackReason reason, ObjectClassFieldType.production_kind kind, ObjectClassFieldType p_ObjectClassFieldType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_ObjectClassFieldType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_ObjectIdentifierType_Event (SyntaxTreeCallbackReason reason, ObjectIdentifierType.production_kind kind, ObjectIdentifierType p_ObjectIdentifierType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_ObjectIdentifierType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_OctetStringType_Event (SyntaxTreeCallbackReason reason, OctetStringType.production_kind kind, OctetStringType p_OctetStringType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_OctetStringType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_RealType_Event (SyntaxTreeCallbackReason reason, RealType.production_kind kind, RealType p_RealType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_RealType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_RelativeIRIType_Event (SyntaxTreeCallbackReason reason, RelativeIRIType.production_kind kind, RelativeIRIType p_RelativeIRIType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_RelativeIRIType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_RelativeOIDType_Event (SyntaxTreeCallbackReason reason, RelativeOIDType.production_kind kind, RelativeOIDType p_RelativeOIDType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_RelativeOIDType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_SequenceType_Event (SyntaxTreeCallbackReason reason, SequenceType.production_kind kind, SequenceType p_SequenceType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.WriteLine ($"SEQUENCE");
                    writer.WriteLine ($"{indent}{{");
                    indent += '\t';
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    indent = indent.Remove (indent.Length - 1);
                    writer.WriteLine ();
                    writer.Write ($"{indent}}}");
                }
                break;
                case SyntaxTreeCallbackReason.IterationEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnModuleFormatter_SequenceOfType_Event (SyntaxTreeCallbackReason reason, SequenceOfType.production_kind kind, SequenceOfType p_SequenceOfType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_SequenceOfType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_SetType_Event (SyntaxTreeCallbackReason reason, SetType.production_kind kind, SetType p_SetType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.WriteLine ($"SET");
                    writer.WriteLine ($"{indent}{{");
                    indent += '\t';
                    writer.WriteLine ($"{indent}{p_SetType.m_ComponentTypeLists_optional.Emit (-1)}");
                    return false;
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                {
                    indent = indent.Remove (indent.Length - 1);
                    writer.Write ($"{indent}}}");
                    return false;
                }
                break;
                case SyntaxTreeCallbackReason.IterationEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnModuleFormatter_SetOfType_Event (SyntaxTreeCallbackReason reason, SetOfType.production_kind kind, SetOfType p_SetOfType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_SetOfType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_PrefixedType_Event (SyntaxTreeCallbackReason reason, PrefixedType.production_kind kind, PrefixedType p_PrefixedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_PrefixedType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_TimeType_Event (SyntaxTreeCallbackReason reason, TimeType.production_kind kind, TimeType p_TimeType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_TimeType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_TimeOfDayType_Event (SyntaxTreeCallbackReason reason, TimeOfDayType.production_kind kind, TimeOfDayType p_TimeOfDayType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_TimeOfDayType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_ComponentTypeLists_Event (SyntaxTreeCallbackReason reason, ComponentTypeLists.production_kind kind, ComponentTypeLists p_ComponentTypeLists)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    switch (kind)
                    {
                        case ComponentTypeLists.production_kind.g_ComponentTypeLists_1:
                            break;
                        case ComponentTypeLists.production_kind.g_ComponentTypeLists_2:
                            break;
                        case ComponentTypeLists.production_kind.g_ComponentTypeLists_3:
                            break;
                        case ComponentTypeLists.production_kind.g_ComponentTypeLists_4:
                            break;
                        case ComponentTypeLists.production_kind.g_ComponentTypeLists_5:
                            break;
                        case ComponentTypeLists.production_kind.g_ComponentTypeLists_6:
                            break;
                    }
                }
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

        private bool AsnModuleFormatter_ComponentTypeList_Event (SyntaxTreeCallbackReason reason, ComponentTypeList.production_kind kind, ComponentTypeList p_ComponentTypeList)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    switch (kind)
                    {
                        case ComponentTypeList.production_kind.g_ComponentTypeList_1:
                            break;
                        case ComponentTypeList.production_kind.g_ComponentTypeList_2:
                            writer.WriteLine ($",");
                            break;
                    }
                }
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

        private bool AsnModuleFormatter_ComponentType_Event (SyntaxTreeCallbackReason reason, ComponentType.production_kind kind, ComponentType p_ComponentType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{indent}{p_ComponentType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_NamedType_Event (SyntaxTreeCallbackReason reason, NamedType.production_kind kind, NamedType p_NamedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
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

        private bool AsnModuleFormatter_ReferencedType_Event (SyntaxTreeCallbackReason reason, ReferencedType.production_kind kind, ReferencedType p_ReferencedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_ReferencedType.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_ConstrainedType_Event (SyntaxTreeCallbackReason reason, ConstrainedType.production_kind kind, ConstrainedType p_ConstrainedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
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

        private bool AsnModuleFormatter_TypeWithConstraint_Event (SyntaxTreeCallbackReason reason, TypeWithConstraint.production_kind kind, TypeWithConstraint p_TypeWithConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                {
                    switch (kind)
                    {
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_1:
                        {
                            switch ((TypeWithConstraint.__p1_markers) p_TypeWithConstraint.turn)
                            {
                                case TypeWithConstraint.__p1_markers.m1:
                                {
                                    writer.WriteLine ($"{indent}SET");
                                    indent += '\t';
                                }
                                break;
                                case TypeWithConstraint.__p1_markers.m2:
                                {
                                    indent = indent.Remove (indent.Length - 1);
                                    writer.WriteLine ($"{indent}OF");
                                }
                                break;
                            }
                        }
                        break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_2:
                        {
                            switch ((TypeWithConstraint.__p2_markers) p_TypeWithConstraint.turn)
                            {
                                case TypeWithConstraint.__p2_markers.m1:
                                {
                                    writer.WriteLine ($"{indent}SET");
                                    indent += '\t';
                                }
                                break;
                                case TypeWithConstraint.__p2_markers.m2:
                                {
                                    indent = indent.Remove (indent.Length - 1);
                                    writer.WriteLine ($"{indent}OF");
                                }
                                break;
                            }
                        }
                        break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_3:
                        {
                            switch ((TypeWithConstraint.__p3_markers) p_TypeWithConstraint.turn)
                            {
                                case TypeWithConstraint.__p3_markers.m1:
                                {
                                    writer.WriteLine ($"{indent}SEQUENCE");
                                    indent += '\t';
                                }
                                break;
                                case TypeWithConstraint.__p3_markers.m2:
                                {
                                    indent = indent.Remove (indent.Length - 1);
                                    writer.WriteLine ($"{indent}OF");
                                }
                                break;
                            }
                        }
                        break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_4:
                        {
                            switch ((TypeWithConstraint.__p4_markers) p_TypeWithConstraint.turn)
                            {
                                case TypeWithConstraint.__p4_markers.m1:
                                {
                                    writer.WriteLine ($"{indent}SEQUENCE");
                                    indent += '\t';
                                }
                                break;
                                case TypeWithConstraint.__p4_markers.m2:
                                {
                                    indent = indent.Remove (indent.Length - 1);
                                    writer.WriteLine ($"{indent}OF");
                                }
                                break;
                            }
                        }
                        break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_5:
                        {
                            switch ((TypeWithConstraint.__p5_markers) p_TypeWithConstraint.turn)
                            {
                                case TypeWithConstraint.__p5_markers.m1:
                                {
                                    writer.WriteLine ($"{indent}SET");
                                    indent += '\t';
                                }
                                break;
                                case TypeWithConstraint.__p5_markers.m2:
                                {
                                    indent = indent.Remove (indent.Length - 1);
                                    writer.WriteLine ($"{indent}OF");
                                }
                                break;
                            }
                        }
                        break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_6:
                        {
                            switch ((TypeWithConstraint.__p6_markers) p_TypeWithConstraint.turn)
                            {
                                case TypeWithConstraint.__p6_markers.m1:
                                {
                                    writer.WriteLine ($"{indent}SET");
                                    indent += '\t';
                                }
                                break;
                                case TypeWithConstraint.__p6_markers.m2:
                                {
                                    indent = indent.Remove (indent.Length - 1);
                                    writer.WriteLine ($"{indent}OF");
                                }
                                break;
                            }
                        }
                        break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_7:
                        {
                            switch ((TypeWithConstraint.__p7_markers) p_TypeWithConstraint.turn)
                            {
                                case TypeWithConstraint.__p7_markers.m1:
                                {
                                    writer.WriteLine ($"{indent}SEQUENCE");
                                    indent += '\t';
                                }
                                break;
                                case TypeWithConstraint.__p7_markers.m2:
                                {
                                    indent = indent.Remove (indent.Length - 1);
                                    writer.WriteLine ($"{indent}OF");
                                }
                                break;
                            }
                        }
                        break;
                        case TypeWithConstraint.production_kind.g_TypeWithConstraint_8:
                        {
                            switch ((TypeWithConstraint.__p8_markers) p_TypeWithConstraint.turn)
                            {
                                case TypeWithConstraint.__p8_markers.m1:
                                {
                                    writer.WriteLine ($"{indent}SEQUENCE");
                                    indent += '\t';
                                }
                                break;
                                case TypeWithConstraint.__p8_markers.m2:
                                {
                                    indent = indent.Remove (indent.Length - 1);
                                    writer.WriteLine ($"{indent}OF");
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
                break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnModuleFormatter_Constraint_Event (SyntaxTreeCallbackReason reason, Asn.Parser.Constraint.production_kind kind, Asn.Parser.Constraint p_Constraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_Constraint.Emit (-1)}");
                    return false;
                }
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

        private bool AsnModuleFormatter_SizeConstraint_Event (SyntaxTreeCallbackReason reason, SizeConstraint.production_kind kind, SizeConstraint p_SizeConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.IterationPrologueCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    writer.Write ($"{p_SizeConstraint.Emit (-1)}");
                    return false;
                }
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

        public void Format (ModuleDefinition module)
        {
            Traverse (module);
        }
    }
}
