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
using System.ComponentModel;
using System.Xml.Linq;

namespace AsnLibrary
{
    internal class AsnTableConstraintResolver : SyntaxTreeWalker
    {
        private int numberOfConstraints = 0;
        private ComponentCounterInspector outerComponentCounterInspector = null;
        private ComponentCounterInspector currentComponentCounterInspector = null;

        private Stack<ComponentCounterInspector> componentCounterInspectors = new Stack<ComponentCounterInspector> ();

        public AsnTableConstraintResolver ()
        {
            componentCounterInspectors.Push (currentComponentCounterInspector);

            ChoiceType_Event += AsnTableConstraintResolver_ChoiceType_Event;
            SequenceType_Event += AsnTableConstraintResolver_SequenceType_Event;
            SequenceOfType_Event += AsnTableConstraintResolver_SequenceOfType_Event;
            SetType_Event += AsnTableConstraintResolver_SetType_Event;
            SetOfType_Event += AsnTableConstraintResolver_SetOfType_Event;

            TableConstraint_Event += AsnTableConstraintResolver_TableConstraint_Event;
            SimpleTableConstraint_Event += AsnTableConstraintResolver_SimpleTableConstraint_Event;
            ComponentRelationConstraint_Event += AsnTableConstraintResolver_ComponentRelationConstraint_Event;
            AtNotation_Event += AsnTableConstraintResolver_AtNotation_Event;
            Level_Event += AsnTableConstraintResolver_Level_Event;
            ComponentIdList_Event += AsnTableConstraintResolver_ComponentIdList_Event;
        }

        private bool AsnTableConstraintResolver_ChoiceType_Event (SyntaxTreeCallbackReason reason, ChoiceType.production_kind kind, ChoiceType p_ChoiceType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    componentCounterInspectors.Push (currentComponentCounterInspector = p_ChoiceType.appInfo as ComponentCounterInspector);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    componentCounterInspectors.Pop ();
                    currentComponentCounterInspector = componentCounterInspectors.Peek ();
                    break;
            }
            return true;
        }

        private bool AsnTableConstraintResolver_SequenceType_Event (SyntaxTreeCallbackReason reason, SequenceType.production_kind kind, SequenceType p_SequenceType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    componentCounterInspectors.Push (currentComponentCounterInspector = p_SequenceType.appInfo as ComponentCounterInspector);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    componentCounterInspectors.Pop ();
                    currentComponentCounterInspector = componentCounterInspectors.Peek ();
                    break;
            }
            return true;
        }

        private bool AsnTableConstraintResolver_SequenceOfType_Event (SyntaxTreeCallbackReason reason, SequenceOfType.production_kind kind, SequenceOfType p_SequenceOfType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    componentCounterInspectors.Push (currentComponentCounterInspector = p_SequenceOfType.appInfo as ComponentCounterInspector);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    componentCounterInspectors.Pop ();
                    currentComponentCounterInspector = componentCounterInspectors.Peek ();
                    break;
            }
            return true;
        }

        private bool AsnTableConstraintResolver_SetType_Event (SyntaxTreeCallbackReason reason, SetType.production_kind kind, SetType p_SetType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    componentCounterInspectors.Push (currentComponentCounterInspector = p_SetType.appInfo as ComponentCounterInspector);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    componentCounterInspectors.Pop ();
                    currentComponentCounterInspector = componentCounterInspectors.Peek ();
                    break;
            }
            return true;
        }

        private bool AsnTableConstraintResolver_SetOfType_Event (SyntaxTreeCallbackReason reason, SetOfType.production_kind kind, SetOfType p_SetOfType)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    componentCounterInspectors.Push (currentComponentCounterInspector = p_SetOfType.appInfo as ComponentCounterInspector);
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    componentCounterInspectors.Pop ();
                    currentComponentCounterInspector = componentCounterInspectors.Peek ();
                    break;
            }
            return true;
        }

        private bool AsnTableConstraintResolver_TableConstraint_Event (SyntaxTreeCallbackReason reason, TableConstraint.production_kind kind, TableConstraint p_TableConstraint)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                    ++numberOfConstraints;
                    break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnTableConstraintResolver_SimpleTableConstraint_Event (SyntaxTreeCallbackReason reason, SimpleTableConstraint.production_kind kind, SimpleTableConstraint p_SimpleTableConstraint)
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

        private bool AsnTableConstraintResolver_ComponentRelationConstraint_Event (SyntaxTreeCallbackReason reason, ComponentRelationConstraint.production_kind kind, ComponentRelationConstraint p_ComponentRelationConstraint)
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

        private bool AsnTableConstraintResolver_AtNotation_Event (SyntaxTreeCallbackReason reason, AtNotation.production_kind kind, AtNotation p_AtNotation)
        {
            switch (reason)
            {
                case SyntaxTreeCallbackReason.BuilderCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalPrologueCallbackReason:
                {
                    ComponentCounterInspector componentCounterInspector = null;
                    switch (kind)
                    {
                        case AtNotation.production_kind.g_AtNotation_1:
                            componentCounterInspector = outerComponentCounterInspector;
                            break;
                        case AtNotation.production_kind.g_AtNotation_2:
                        {
                            int level = (int) p_AtNotation.m_Level.Iterate (0, (node, counter) => (int) counter + 1);
                            for (componentCounterInspector = currentComponentCounterInspector; level-- > 1; componentCounterInspector = componentCounterInspector.tableConstraintLink as ComponentCounterInspector)
                                ;
                        }
                        break;
                    }
                    if (p_AtNotation.m_ComponentIdList.Iterate (componentCounterInspector, (node, appData) => (appData as NodeInspector)?.GetComponentInspector (node.m_identifier_token.m_identifier.text)) as NodeInspector == null)
                        ;
                }
                break;
                case SyntaxTreeCallbackReason.TraversalMidTermCallbackReason:
                    break;
                case SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason:
                    break;
            }
            return true;
        }

        private bool AsnTableConstraintResolver_Level_Event (SyntaxTreeCallbackReason reason, Level.production_kind kind, Level p_Level)
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

        private bool AsnTableConstraintResolver_ComponentIdList_Event (SyntaxTreeCallbackReason reason, ComponentIdList.production_kind kind, ComponentIdList p_ComponentIdList)
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
            return false;
        }

        public void Invoke (SyntaxTreeBase node)
        {
            outerComponentCounterInspector = node.appInfo as ComponentCounterInspector;
            if (outerComponentCounterInspector == null)
                return;
            node.unlock ();
            node.InvokeTraverse (this);
            if (numberOfConstraints > 0)
            {
                Console.WriteLine ($"TC-TYPE: {node.Emit (-1)}");
            }
        }
    }
}
