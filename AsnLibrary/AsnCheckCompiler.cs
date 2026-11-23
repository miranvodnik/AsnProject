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
    public class AsnCheckCompiler : SyntaxTreeWalker
    {
        public AsnCheckCompiler ()
        {
            Object_Event += AsnCheckCompiler_Object_Event;
            DefinedSyntax_Event += AsnCheckCompiler_DefinedSyntax_Event;
            ParameterizedAssignment_Event += AsnCheckCompiler_ParameterizedAssignment_Event;
            DefinedType_Event += AsnCheckCompiler_DefinedType_Event;
            DefinedObjectClass_Event += AsnCheckCompiler_DefinedObjectClass_Event;
            DefinedObject_Event += AsnCheckCompiler_DefinedObject_Event;
            DefinedObjectSet_Event += AsnCheckCompiler_DefinedObjectSet_Event;
            DefinedValue_Event += AsnCheckCompiler_DefinedValue_Event;
            ActualParameterList_Event += AsnCheckCompiler_ActualParameterList_Event;
        }

        private bool AsnCheckCompiler_Object_Event (SyntaxTreeCallbackReason reason, Asn.Parser.Object.production_kind kind, Asn.Parser.Object p_Object)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    int? count = ((NodeInspector) p_Object.appInfo)?.GetComponentCount ();
                    if ((count == null) || count.Value == 0)
                        ;
                }
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return false;
        }

        private bool AsnCheckCompiler_DefinedSyntax_Event (SyntaxTreeCallbackReason reason, DefinedSyntax.production_kind kind, DefinedSyntax p_DefinedSyntax)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    Console.Error.WriteLine ($"UNRESOLVED OBJECT DEFINED SYNTAX: {p_DefinedSyntax.Emit (-1)}");
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return false;
        }

        private bool AsnCheckCompiler_ParameterizedAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedAssignment.production_kind kind, ParameterizedAssignment p_ParameterizedAssignment)
        {
            return false;
        }

        private bool AsnCheckCompiler_DefinedType_Event (SyntaxTreeCallbackReason reason, DefinedType.production_kind kind, DefinedType p_DefinedType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    DefinedTypeInspector definedTypeInspector = p_DefinedType.appInfo as DefinedTypeInspector;
                    if (definedTypeInspector == null)
                        ;
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return false;
        }

        private bool AsnCheckCompiler_DefinedObjectClass_Event (SyntaxTreeCallbackReason reason, DefinedObjectClass.production_kind kind, DefinedObjectClass p_DefinedObjectClass)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    DefinedObjectClassInspector definedObjectClassInspector = p_DefinedObjectClass.appInfo as DefinedObjectClassInspector;
                    if (definedObjectClassInspector == null)
                        ;
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return false;
        }

        private bool AsnCheckCompiler_DefinedObject_Event (SyntaxTreeCallbackReason reason, DefinedObject.production_kind kind, DefinedObject p_DefinedObject)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    DefinedObjectInspector definedObjectInspector = p_DefinedObject.appInfo as DefinedObjectInspector;
                    if (definedObjectInspector == null)
                        ;
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return false;
        }

        private bool AsnCheckCompiler_DefinedObjectSet_Event (SyntaxTreeCallbackReason reason, DefinedObjectSet.production_kind kind, DefinedObjectSet p_DefinedObjectSet)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    DefinedObjectSetInspector definedObjectSetInspector = p_DefinedObjectSet.appInfo as DefinedObjectSetInspector;
                    if (definedObjectSetInspector == null)
                        ;
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return false;
        }

        private bool AsnCheckCompiler_DefinedValue_Event (SyntaxTreeCallbackReason reason, DefinedValue.production_kind kind, DefinedValue p_DefinedValue)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    DefinedValueInspector definedValueInspector = p_DefinedValue.appInfo as DefinedValueInspector;
                    if (definedValueInspector == null)
                        ;
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return false;
        }

        private bool AsnCheckCompiler_ActualParameterList_Event (SyntaxTreeCallbackReason reason, ActualParameterList.production_kind kind, ActualParameterList p_ActualParameterList)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    Console.Error.WriteLine ($"UNRESOLVED PARAMETERIZED ENTITY: {p_ActualParameterList.parent.Emit (-1)}");
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return false;
        }

        public void Invoke ()
        {
            foreach (List<ModuleDescriptor> moduleList in AsnDataBase.accumulatedModuleDefinitions.Values)
                foreach (ModuleDescriptor module in moduleList)
                    Traverse (module.moduleDefinition);
        }
    }
}
