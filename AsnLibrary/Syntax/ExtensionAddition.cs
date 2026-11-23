//
//	This file was generated with ANGLR compiler
//
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

using Anglr.Parser.Core;
using Anglr.Parser.SyntaxTree;
using Anglr.Parser.Walker;
namespace Asn.Parser
{
	//
	// class associated with syntax rule ExtensionAddition
	//

	[DataContract]
	public class	ExtensionAddition : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExtensionAddition
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExtensionAddition
		{
			g_ExtensionAddition_1 = 1,	// ComponentType

			g_ExtensionAddition_2 = 2,	// ExtensionAdditionGroup

		};
		#endregion
		#region production markers associated with the syntax rule ExtensionAddition

		// markers associated with production: ExtensionAddition -> ComponentType

		public enum production_marker_1 : ushort
		{
			m_ComponentType,
			final
		};

		// markers associated with production: ExtensionAddition -> ExtensionAdditionGroup

		public enum production_marker_2 : ushort
		{
			m_ExtensionAdditionGroup,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExtensionAddition

		// Constructor declaration(s) associated with production(s) of syntax rule ExtensionAddition

		//
		// Constructor associated with the following production(s)
		// ExtensionAddition -> ComponentType

		//

		public ExtensionAddition (ComponentType p_ComponentType) : base ((uint) ProductionID._ExtensionAddition_ID, (uint) production_kind.g_ExtensionAddition_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ComponentType = p_ComponentType;
		}

		//
		// Constructor associated with the following production(s)
		// ExtensionAddition -> ExtensionAdditionGroup

		//

		public ExtensionAddition (ExtensionAdditionGroup p_ExtensionAdditionGroup) : base ((uint) ProductionID._ExtensionAddition_ID, (uint) production_kind.g_ExtensionAddition_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExtensionAdditionGroup = p_ExtensionAdditionGroup;
		}

		public ExtensionAddition () { }

		// Copy constructor

		public ExtensionAddition (ExtensionAddition p_ExtensionAddition) : base (p_ExtensionAddition.id, p_ExtensionAddition.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExtensionAddition.appInfo;
			switch ((production_kind) p_ExtensionAddition.kind)
			{
				case production_kind.g_ExtensionAddition_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ComponentType = (p_ExtensionAddition.m_ComponentType != null) ? new ComponentType (p_ExtensionAddition.m_ComponentType) : null) != null) m_ComponentType.parent = this;
					break;
				case production_kind.g_ExtensionAddition_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExtensionAdditionGroup = (p_ExtensionAddition.m_ExtensionAdditionGroup != null) ? new ExtensionAdditionGroup (p_ExtensionAddition.m_ExtensionAdditionGroup) : null) != null) m_ExtensionAdditionGroup.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExtensionAddition" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExtensionAddition (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ComponentType?.Dispose ();
			m_ExtensionAdditionGroup?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExtensionAddition

		// Content changing function(s) associated with production(s) of syntax rule ExtensionAddition

		//
		// Content changing function associated with following production(s)
		// ExtensionAddition -> ComponentType

		//

		public void change(ComponentType p_ComponentType)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAddition_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ComponentType = p_ComponentType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ExtensionAddition -> ExtensionAdditionGroup

		//

		public void change(ExtensionAdditionGroup p_ExtensionAdditionGroup)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAddition_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExtensionAdditionGroup = p_ExtensionAdditionGroup;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExtensionAddition
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ComponentType != null) && m_ComponentType.checkInclusion (element) ||
				(m_ExtensionAdditionGroup != null) && m_ExtensionAdditionGroup.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExtensionAddition

		//
		// emit production tree node associated with any production of syntax rule ExtensionAddition
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExtensionAddition_1:
					// emit syntax tree node associated with production
					// ExtensionAddition: ComponentType

					s += m_ComponentType.Emit (depth - 1);
				break;
				case production_kind.g_ExtensionAddition_2:
					// emit syntax tree node associated with production
					// ExtensionAddition: ExtensionAdditionGroup

					s += m_ExtensionAdditionGroup.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExtensionAddition
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExtensionAddition (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExtensionAddition_1:
					// emit syntax tree node associated with production
					// ExtensionAddition: ComponentType

					s += m_ComponentType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ExtensionAddition_2:
					// emit syntax tree node associated with production
					// ExtensionAddition: ExtensionAdditionGroup

					s += m_ExtensionAdditionGroup.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExtensionAddition

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAddition with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExtensionAddition.production_kind kind = (ExtensionAddition.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExtensionAddition.production_kind.g_ExtensionAddition_1:
					// traverse syntax tree node associated with production
					// ExtensionAddition: ComponentType

						m_ComponentType.Visit (visitor, appData);
				break;
				case ExtensionAddition.production_kind.g_ExtensionAddition_2:
					// traverse syntax tree node associated with production
					// ExtensionAddition: ExtensionAdditionGroup

						m_ExtensionAdditionGroup.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ComponentType?.reparent (this);
			m_ExtensionAdditionGroup?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExtensionAddition
		//

		public void _init ()
		{
			m_ComponentType = null;
			m_ExtensionAdditionGroup = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExtensionAddition

		// counter of all nodes associated with syntax rule ExtensionAddition
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExtensionAddition
		[DataMember (Name = "m_ComponentType")] public ComponentType m_ComponentType { get; private set; }
		[DataMember (Name = "m_ExtensionAdditionGroup")] public ExtensionAdditionGroup m_ExtensionAdditionGroup { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExtensionAddition

		// delegate function (callback) prototype associated with syntax rule ExtensionAddition
		public delegate bool ExtensionAddition_Callback (SyntaxTreeCallbackReason reason, ExtensionAddition.production_kind kind, ExtensionAddition p_ExtensionAddition);

		// event associated with syntax rule ExtensionAddition
		public event ExtensionAddition_Callback ExtensionAddition_Event;

		// event trigger associated with syntax rule ExtensionAddition
		public bool Raise_ExtensionAddition_Event (SyntaxTreeCallbackReason reason, ExtensionAddition.production_kind kind, ExtensionAddition p_ExtensionAddition)
		{
			bool? status = ExtensionAddition_Event?.Invoke (reason, kind, p_ExtensionAddition);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExtensionAddition
		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAddition
		//

		public void Traverse (ExtensionAddition p_ExtensionAddition)
		{
			if (p_ExtensionAddition.isLocked())
				return;
			p_ExtensionAddition.dolock();
			ExtensionAddition.production_kind kind = (ExtensionAddition.production_kind) p_ExtensionAddition.kind;
			p_ExtensionAddition.turn_reset ();
			if (Raise_ExtensionAddition_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExtensionAddition))
			switch (kind)
			{
				case ExtensionAddition.production_kind.g_ExtensionAddition_1:
					// traverse syntax tree node associated with production
					// ExtensionAddition: ComponentType

					if (Raise_ExtensionAddition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAddition))
						Traverse (p_ExtensionAddition.m_ComponentType);
					p_ExtensionAddition.turn_inc ();
					Raise_ExtensionAddition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAddition);
				break;
				case ExtensionAddition.production_kind.g_ExtensionAddition_2:
					// traverse syntax tree node associated with production
					// ExtensionAddition: ExtensionAdditionGroup

					if (Raise_ExtensionAddition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAddition))
						Traverse (p_ExtensionAddition.m_ExtensionAdditionGroup);
					p_ExtensionAddition.turn_inc ();
					Raise_ExtensionAddition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAddition);
				break;
			}
			Raise_ExtensionAddition_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExtensionAddition);
			p_ExtensionAddition.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAddition
		//

		public void TraverseCommon (ExtensionAddition p_ExtensionAddition)
		{
			ExtensionAddition.production_kind kind = (ExtensionAddition.production_kind) p_ExtensionAddition.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExtensionAddition))
			switch (kind)
			{
				case ExtensionAddition.production_kind.g_ExtensionAddition_1:
					// traverse syntax tree node associated with production
					// ExtensionAddition: ComponentType

						TraverseCommon (p_ExtensionAddition.m_ComponentType);
				break;
				case ExtensionAddition.production_kind.g_ExtensionAddition_2:
					// traverse syntax tree node associated with production
					// ExtensionAddition: ExtensionAdditionGroup

						TraverseCommon (p_ExtensionAddition.m_ExtensionAdditionGroup);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExtensionAddition);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExtensionAddition

		//
		// create syntax tree node associated with production
		// ExtensionAddition: ComponentType

		//

		public ExtensionAddition ExtensionAddition_1 (ComponentType p_ComponentType)
		{
			ExtensionAddition p_ExtensionAddition_ref = new ExtensionAddition(p_ComponentType);
			p_ComponentType.parent = p_ExtensionAddition_ref;
			Raise_ExtensionAddition_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAddition.production_kind.g_ExtensionAddition_1, p_ExtensionAddition_ref);
			return p_ExtensionAddition_ref;
		}

		//
		// create syntax tree node associated with production
		// ExtensionAddition: ExtensionAdditionGroup

		//

		public ExtensionAddition ExtensionAddition_2 (ExtensionAdditionGroup p_ExtensionAdditionGroup)
		{
			ExtensionAddition p_ExtensionAddition_ref = new ExtensionAddition(p_ExtensionAdditionGroup);
			p_ExtensionAdditionGroup.parent = p_ExtensionAddition_ref;
			Raise_ExtensionAddition_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAddition.production_kind.g_ExtensionAddition_2, p_ExtensionAddition_ref);
			return p_ExtensionAddition_ref;
		}
		#endregion
	};
}
