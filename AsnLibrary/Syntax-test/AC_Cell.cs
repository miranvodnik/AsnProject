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
	// class associated with syntax rule AC-Cell
	//

	[DataContract]
	public class	AC_Cell : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-Cell
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-Cell
		{
			g_AC_Cell_1 = 1,	// Value

		};
		#endregion
		#region production markers associated with the syntax rule AC-Cell

		// markers associated with production: AC-Cell -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-Cell

		// Constructor declaration(s) associated with production(s) of syntax rule AC-Cell

		//
		// Constructor associated with the following production(s)
		// AC-Cell -> Value

		//

		public AC_Cell (Value p_Value) : base ((uint) ProductionID._AC_Cell_ID, (uint) production_kind.g_AC_Cell_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		public AC_Cell () { }

		// Copy constructor

		public AC_Cell (AC_Cell p_AC_Cell) : base (p_AC_Cell.id, p_AC_Cell.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_Cell.appInfo;
			switch ((production_kind) p_AC_Cell.kind)
			{
				case production_kind.g_AC_Cell_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_AC_Cell.m_Value != null) ? new Value (p_AC_Cell.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_Cell" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_Cell (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-Cell

		// Content changing function(s) associated with production(s) of syntax rule AC-Cell

		//
		// Content changing function associated with following production(s)
		// AC-Cell -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Cell_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-Cell
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-Cell

		//
		// emit production tree node associated with any production of syntax rule AC-Cell
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_Cell_1:
					// emit syntax tree node associated with production
					// AC-Cell: Value

					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-Cell
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_Cell (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_Cell_1:
					// emit syntax tree node associated with production
					// AC-Cell: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-Cell

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Cell with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_Cell.production_kind kind = (AC_Cell.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_Cell.production_kind.g_AC_Cell_1:
					// traverse syntax tree node associated with production
					// AC-Cell: Value

						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-Cell
		//

		public void _init ()
		{
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-Cell

		// counter of all nodes associated with syntax rule AC-Cell
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-Cell
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-Cell

		// delegate function (callback) prototype associated with syntax rule AC-Cell
		public delegate bool AC_Cell_Callback (SyntaxTreeCallbackReason reason, AC_Cell.production_kind kind, AC_Cell p_AC_Cell);

		// event associated with syntax rule AC-Cell
		public event AC_Cell_Callback AC_Cell_Event;

		// event trigger associated with syntax rule AC-Cell
		public bool Raise_AC_Cell_Event (SyntaxTreeCallbackReason reason, AC_Cell.production_kind kind, AC_Cell p_AC_Cell)
		{
			bool? status = AC_Cell_Event?.Invoke (reason, kind, p_AC_Cell);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-Cell
		//
		// traverse syntax tree node associated with any production of syntax rule AC-Cell
		//

		public void Traverse (AC_Cell p_AC_Cell)
		{
			if (p_AC_Cell.isLocked())
				return;
			p_AC_Cell.dolock();
			AC_Cell.production_kind kind = (AC_Cell.production_kind) p_AC_Cell.kind;
			p_AC_Cell.turn_reset ();
			if (Raise_AC_Cell_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_Cell))
			switch (kind)
			{
				case AC_Cell.production_kind.g_AC_Cell_1:
					// traverse syntax tree node associated with production
					// AC-Cell: Value

					if (Raise_AC_Cell_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Cell))
						Traverse (p_AC_Cell.m_Value);
					p_AC_Cell.turn_inc ();
					Raise_AC_Cell_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Cell);
				break;
			}
			Raise_AC_Cell_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_Cell);
			p_AC_Cell.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Cell
		//

		public void TraverseCommon (AC_Cell p_AC_Cell)
		{
			AC_Cell.production_kind kind = (AC_Cell.production_kind) p_AC_Cell.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_Cell))
			switch (kind)
			{
				case AC_Cell.production_kind.g_AC_Cell_1:
					// traverse syntax tree node associated with production
					// AC-Cell: Value

						TraverseCommon (p_AC_Cell.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_Cell);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-Cell

		//
		// create syntax tree node associated with production
		// AC-Cell: Value

		//

		public AC_Cell AC_Cell_1 (Value p_Value)
		{
			AC_Cell p_AC_Cell_ref = new AC_Cell(p_Value);
			p_Value.parent = p_AC_Cell_ref;
			Raise_AC_Cell_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Cell.production_kind.g_AC_Cell_1, p_AC_Cell_ref);
			return p_AC_Cell_ref;
		}
		#endregion
	};
}
