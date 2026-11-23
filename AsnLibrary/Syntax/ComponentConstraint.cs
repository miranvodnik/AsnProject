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
	// class associated with syntax rule ComponentConstraint
	//

	[DataContract]
	public class	ComponentConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ComponentConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ComponentConstraint
		{
			g_ComponentConstraint_1 = 1,	// ValueConstraint PresenceConstraint

		};
		#endregion
		#region production markers associated with the syntax rule ComponentConstraint

		// markers associated with production: ComponentConstraint -> ValueConstraint PresenceConstraint

		public enum production_marker_1 : ushort
		{
			m_ValueConstraint,
			m_PresenceConstraint,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ComponentConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule ComponentConstraint

		//
		// Constructor associated with the following production(s)
		// ComponentConstraint -> ValueConstraint PresenceConstraint

		//

		public ComponentConstraint (ValueConstraint p_ValueConstraint, PresenceConstraint p_PresenceConstraint) : base ((uint) ProductionID._ComponentConstraint_ID, (uint) production_kind.g_ComponentConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ValueConstraint = p_ValueConstraint;
			children[1] = m_PresenceConstraint = p_PresenceConstraint;
		}

		public ComponentConstraint () { }

		// Copy constructor

		public ComponentConstraint (ComponentConstraint p_ComponentConstraint) : base (p_ComponentConstraint.id, p_ComponentConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ComponentConstraint.appInfo;
			switch ((production_kind) p_ComponentConstraint.kind)
			{
				case production_kind.g_ComponentConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ValueConstraint = (p_ComponentConstraint.m_ValueConstraint != null) ? new ValueConstraint (p_ComponentConstraint.m_ValueConstraint) : null) != null) m_ValueConstraint.parent = this;
					if ((children [1] = m_PresenceConstraint = (p_ComponentConstraint.m_PresenceConstraint != null) ? new PresenceConstraint (p_ComponentConstraint.m_PresenceConstraint) : null) != null) m_PresenceConstraint.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ComponentConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ComponentConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ValueConstraint?.Dispose ();
			m_PresenceConstraint?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ComponentConstraint

		// Content changing function(s) associated with production(s) of syntax rule ComponentConstraint

		//
		// Content changing function associated with following production(s)
		// ComponentConstraint -> ValueConstraint PresenceConstraint

		//

		public void change(ValueConstraint p_ValueConstraint, PresenceConstraint p_PresenceConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ValueConstraint = p_ValueConstraint;
			children [1] = m_PresenceConstraint = p_PresenceConstraint;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ComponentConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ValueConstraint != null) && m_ValueConstraint.checkInclusion (element) ||
				(m_PresenceConstraint != null) && m_PresenceConstraint.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ComponentConstraint

		//
		// emit production tree node associated with any production of syntax rule ComponentConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ComponentConstraint_1:
					// emit syntax tree node associated with production
					// ComponentConstraint: ValueConstraint PresenceConstraint

					s += m_ValueConstraint.Emit (depth - 1);
					s += " ";
					s += m_PresenceConstraint.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ComponentConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ComponentConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ComponentConstraint_1:
					// emit syntax tree node associated with production
					// ComponentConstraint: ValueConstraint PresenceConstraint

					s += m_ValueConstraint.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_PresenceConstraint.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ComponentConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ComponentConstraint.production_kind kind = (ComponentConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ComponentConstraint.production_kind.g_ComponentConstraint_1:
					// traverse syntax tree node associated with production
					// ComponentConstraint: ValueConstraint PresenceConstraint

						m_ValueConstraint.Visit (visitor, appData);
						m_PresenceConstraint.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ValueConstraint?.reparent (this);
			m_PresenceConstraint?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ComponentConstraint
		//

		public void _init ()
		{
			m_ValueConstraint = null;
			m_PresenceConstraint = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ComponentConstraint

		// counter of all nodes associated with syntax rule ComponentConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ComponentConstraint
		[DataMember (Name = "m_ValueConstraint")] public ValueConstraint m_ValueConstraint { get; private set; }
		[DataMember (Name = "m_PresenceConstraint")] public PresenceConstraint m_PresenceConstraint { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ComponentConstraint

		// delegate function (callback) prototype associated with syntax rule ComponentConstraint
		public delegate bool ComponentConstraint_Callback (SyntaxTreeCallbackReason reason, ComponentConstraint.production_kind kind, ComponentConstraint p_ComponentConstraint);

		// event associated with syntax rule ComponentConstraint
		public event ComponentConstraint_Callback ComponentConstraint_Event;

		// event trigger associated with syntax rule ComponentConstraint
		public bool Raise_ComponentConstraint_Event (SyntaxTreeCallbackReason reason, ComponentConstraint.production_kind kind, ComponentConstraint p_ComponentConstraint)
		{
			bool? status = ComponentConstraint_Event?.Invoke (reason, kind, p_ComponentConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ComponentConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule ComponentConstraint
		//

		public void Traverse (ComponentConstraint p_ComponentConstraint)
		{
			if (p_ComponentConstraint.isLocked())
				return;
			p_ComponentConstraint.dolock();
			ComponentConstraint.production_kind kind = (ComponentConstraint.production_kind) p_ComponentConstraint.kind;
			p_ComponentConstraint.turn_reset ();
			if (Raise_ComponentConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ComponentConstraint))
			switch (kind)
			{
				case ComponentConstraint.production_kind.g_ComponentConstraint_1:
					// traverse syntax tree node associated with production
					// ComponentConstraint: ValueConstraint PresenceConstraint

					if (Raise_ComponentConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentConstraint))
						Traverse (p_ComponentConstraint.m_ValueConstraint);
					p_ComponentConstraint.turn_inc ();
					if (Raise_ComponentConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentConstraint))
						Traverse (p_ComponentConstraint.m_PresenceConstraint);
					p_ComponentConstraint.turn_inc ();
					Raise_ComponentConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentConstraint);
				break;
			}
			Raise_ComponentConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ComponentConstraint);
			p_ComponentConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentConstraint
		//

		public void TraverseCommon (ComponentConstraint p_ComponentConstraint)
		{
			ComponentConstraint.production_kind kind = (ComponentConstraint.production_kind) p_ComponentConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ComponentConstraint))
			switch (kind)
			{
				case ComponentConstraint.production_kind.g_ComponentConstraint_1:
					// traverse syntax tree node associated with production
					// ComponentConstraint: ValueConstraint PresenceConstraint

						TraverseCommon (p_ComponentConstraint.m_ValueConstraint);
						TraverseCommon (p_ComponentConstraint.m_PresenceConstraint);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ComponentConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ComponentConstraint

		//
		// create syntax tree node associated with production
		// ComponentConstraint: ValueConstraint PresenceConstraint

		//

		public ComponentConstraint ComponentConstraint_1 (ValueConstraint p_ValueConstraint, PresenceConstraint p_PresenceConstraint)
		{
			ComponentConstraint p_ComponentConstraint_ref = new ComponentConstraint(p_ValueConstraint, p_PresenceConstraint);
			p_ValueConstraint.parent = p_ComponentConstraint_ref;
			p_PresenceConstraint.parent = p_ComponentConstraint_ref;
			Raise_ComponentConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentConstraint.production_kind.g_ComponentConstraint_1, p_ComponentConstraint_ref);
			return p_ComponentConstraint_ref;
		}
		#endregion
	};
}
