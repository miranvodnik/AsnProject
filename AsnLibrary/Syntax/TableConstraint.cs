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
	// class associated with syntax rule TableConstraint
	//

	[DataContract]
	public class	TableConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TableConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TableConstraint
		{
			g_TableConstraint_1 = 1,	// SimpleTableConstraint

			g_TableConstraint_2 = 2,	// ComponentRelationConstraint

		};
		#endregion
		#region production markers associated with the syntax rule TableConstraint

		// markers associated with production: TableConstraint -> SimpleTableConstraint

		public enum production_marker_1 : ushort
		{
			m_SimpleTableConstraint,
			final
		};

		// markers associated with production: TableConstraint -> ComponentRelationConstraint

		public enum production_marker_2 : ushort
		{
			m_ComponentRelationConstraint,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TableConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule TableConstraint

		//
		// Constructor associated with the following production(s)
		// TableConstraint -> SimpleTableConstraint

		//

		public TableConstraint (SimpleTableConstraint p_SimpleTableConstraint) : base ((uint) ProductionID._TableConstraint_ID, (uint) production_kind.g_TableConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SimpleTableConstraint = p_SimpleTableConstraint;
		}

		//
		// Constructor associated with the following production(s)
		// TableConstraint -> ComponentRelationConstraint

		//

		public TableConstraint (ComponentRelationConstraint p_ComponentRelationConstraint) : base ((uint) ProductionID._TableConstraint_ID, (uint) production_kind.g_TableConstraint_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ComponentRelationConstraint = p_ComponentRelationConstraint;
		}

		public TableConstraint () { }

		// Copy constructor

		public TableConstraint (TableConstraint p_TableConstraint) : base (p_TableConstraint.id, p_TableConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TableConstraint.appInfo;
			switch ((production_kind) p_TableConstraint.kind)
			{
				case production_kind.g_TableConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SimpleTableConstraint = (p_TableConstraint.m_SimpleTableConstraint != null) ? new SimpleTableConstraint (p_TableConstraint.m_SimpleTableConstraint) : null) != null) m_SimpleTableConstraint.parent = this;
					break;
				case production_kind.g_TableConstraint_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ComponentRelationConstraint = (p_TableConstraint.m_ComponentRelationConstraint != null) ? new ComponentRelationConstraint (p_TableConstraint.m_ComponentRelationConstraint) : null) != null) m_ComponentRelationConstraint.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TableConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TableConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SimpleTableConstraint?.Dispose ();
			m_ComponentRelationConstraint?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TableConstraint

		// Content changing function(s) associated with production(s) of syntax rule TableConstraint

		//
		// Content changing function associated with following production(s)
		// TableConstraint -> SimpleTableConstraint

		//

		public void change(SimpleTableConstraint p_SimpleTableConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_TableConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SimpleTableConstraint = p_SimpleTableConstraint;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TableConstraint -> ComponentRelationConstraint

		//

		public void change(ComponentRelationConstraint p_ComponentRelationConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_TableConstraint_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ComponentRelationConstraint = p_ComponentRelationConstraint;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TableConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SimpleTableConstraint != null) && m_SimpleTableConstraint.checkInclusion (element) ||
				(m_ComponentRelationConstraint != null) && m_ComponentRelationConstraint.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TableConstraint

		//
		// emit production tree node associated with any production of syntax rule TableConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TableConstraint_1:
					// emit syntax tree node associated with production
					// TableConstraint: SimpleTableConstraint

					s += m_SimpleTableConstraint.Emit (depth - 1);
				break;
				case production_kind.g_TableConstraint_2:
					// emit syntax tree node associated with production
					// TableConstraint: ComponentRelationConstraint

					s += m_ComponentRelationConstraint.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TableConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TableConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TableConstraint_1:
					// emit syntax tree node associated with production
					// TableConstraint: SimpleTableConstraint

					s += m_SimpleTableConstraint.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TableConstraint_2:
					// emit syntax tree node associated with production
					// TableConstraint: ComponentRelationConstraint

					s += m_ComponentRelationConstraint.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TableConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TableConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TableConstraint.production_kind kind = (TableConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TableConstraint.production_kind.g_TableConstraint_1:
					// traverse syntax tree node associated with production
					// TableConstraint: SimpleTableConstraint

						m_SimpleTableConstraint.Visit (visitor, appData);
				break;
				case TableConstraint.production_kind.g_TableConstraint_2:
					// traverse syntax tree node associated with production
					// TableConstraint: ComponentRelationConstraint

						m_ComponentRelationConstraint.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SimpleTableConstraint?.reparent (this);
			m_ComponentRelationConstraint?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TableConstraint
		//

		public void _init ()
		{
			m_SimpleTableConstraint = null;
			m_ComponentRelationConstraint = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TableConstraint

		// counter of all nodes associated with syntax rule TableConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TableConstraint
		[DataMember (Name = "m_SimpleTableConstraint")] public SimpleTableConstraint m_SimpleTableConstraint { get; private set; }
		[DataMember (Name = "m_ComponentRelationConstraint")] public ComponentRelationConstraint m_ComponentRelationConstraint { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TableConstraint

		// delegate function (callback) prototype associated with syntax rule TableConstraint
		public delegate bool TableConstraint_Callback (SyntaxTreeCallbackReason reason, TableConstraint.production_kind kind, TableConstraint p_TableConstraint);

		// event associated with syntax rule TableConstraint
		public event TableConstraint_Callback TableConstraint_Event;

		// event trigger associated with syntax rule TableConstraint
		public bool Raise_TableConstraint_Event (SyntaxTreeCallbackReason reason, TableConstraint.production_kind kind, TableConstraint p_TableConstraint)
		{
			bool? status = TableConstraint_Event?.Invoke (reason, kind, p_TableConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TableConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule TableConstraint
		//

		public void Traverse (TableConstraint p_TableConstraint)
		{
			if (p_TableConstraint.isLocked())
				return;
			p_TableConstraint.dolock();
			TableConstraint.production_kind kind = (TableConstraint.production_kind) p_TableConstraint.kind;
			p_TableConstraint.turn_reset ();
			if (Raise_TableConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TableConstraint))
			switch (kind)
			{
				case TableConstraint.production_kind.g_TableConstraint_1:
					// traverse syntax tree node associated with production
					// TableConstraint: SimpleTableConstraint

					if (Raise_TableConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TableConstraint))
						Traverse (p_TableConstraint.m_SimpleTableConstraint);
					p_TableConstraint.turn_inc ();
					Raise_TableConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TableConstraint);
				break;
				case TableConstraint.production_kind.g_TableConstraint_2:
					// traverse syntax tree node associated with production
					// TableConstraint: ComponentRelationConstraint

					if (Raise_TableConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TableConstraint))
						Traverse (p_TableConstraint.m_ComponentRelationConstraint);
					p_TableConstraint.turn_inc ();
					Raise_TableConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TableConstraint);
				break;
			}
			Raise_TableConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TableConstraint);
			p_TableConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TableConstraint
		//

		public void TraverseCommon (TableConstraint p_TableConstraint)
		{
			TableConstraint.production_kind kind = (TableConstraint.production_kind) p_TableConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TableConstraint))
			switch (kind)
			{
				case TableConstraint.production_kind.g_TableConstraint_1:
					// traverse syntax tree node associated with production
					// TableConstraint: SimpleTableConstraint

						TraverseCommon (p_TableConstraint.m_SimpleTableConstraint);
				break;
				case TableConstraint.production_kind.g_TableConstraint_2:
					// traverse syntax tree node associated with production
					// TableConstraint: ComponentRelationConstraint

						TraverseCommon (p_TableConstraint.m_ComponentRelationConstraint);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TableConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TableConstraint

		//
		// create syntax tree node associated with production
		// TableConstraint: SimpleTableConstraint

		//

		public TableConstraint TableConstraint_1 (SimpleTableConstraint p_SimpleTableConstraint)
		{
			TableConstraint p_TableConstraint_ref = new TableConstraint(p_SimpleTableConstraint);
			p_SimpleTableConstraint.parent = p_TableConstraint_ref;
			Raise_TableConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TableConstraint.production_kind.g_TableConstraint_1, p_TableConstraint_ref);
			return p_TableConstraint_ref;
		}

		//
		// create syntax tree node associated with production
		// TableConstraint: ComponentRelationConstraint

		//

		public TableConstraint TableConstraint_2 (ComponentRelationConstraint p_ComponentRelationConstraint)
		{
			TableConstraint p_TableConstraint_ref = new TableConstraint(p_ComponentRelationConstraint);
			p_ComponentRelationConstraint.parent = p_TableConstraint_ref;
			Raise_TableConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TableConstraint.production_kind.g_TableConstraint_2, p_TableConstraint_ref);
			return p_TableConstraint_ref;
		}
		#endregion
	};
}
