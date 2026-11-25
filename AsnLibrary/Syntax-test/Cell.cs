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
	// class associated with syntax rule Cell
	//

	[DataContract]
	public class	Cell : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Cell
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Cell
		{
			g_Cell_1 = 1,	// number

		};
		#endregion
		#region production markers associated with the syntax rule Cell

		// markers associated with production: Cell -> number

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Cell

		// Constructor declaration(s) associated with production(s) of syntax rule Cell

		//
		// Constructor associated with the following production(s)
		// Cell -> number

		//

		public Cell (SyntaxTreeToken p_token) : base ((uint) ProductionID._Cell_ID, (uint) production_kind.g_Cell_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_number = p_token;
		}

		public Cell () { }

		// Copy constructor

		public Cell (Cell p_Cell) : base (p_Cell.id, p_Cell.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Cell.appInfo;
			switch ((production_kind) p_Cell.kind)
			{
				case production_kind.g_Cell_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_number = (p_Cell.m_number != null) ? new SyntaxTreeToken (p_Cell.m_number) : null) != null) m_number.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Cell" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Cell (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_number?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Cell

		// Content changing function(s) associated with production(s) of syntax rule Cell

		//
		// Content changing function associated with following production(s)
		// Cell -> number

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Cell_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_number = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Cell
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Cell

		//
		// emit production tree node associated with any production of syntax rule Cell
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Cell_1:
					// emit syntax tree node associated with production
					// Cell: number

					s += m_number.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Cell
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Cell (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Cell_1:
					// emit syntax tree node associated with production
					// Cell: number

					s += "number";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Cell

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Cell with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Cell.production_kind kind = (Cell.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Cell.production_kind.g_Cell_1:
					// traverse syntax tree node associated with production
					// Cell: number

						m_number.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_number?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Cell
		//

		public void _init ()
		{
			m_number = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Cell

		// counter of all nodes associated with syntax rule Cell
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Cell
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Cell

		// delegate function (callback) prototype associated with syntax rule Cell
		public delegate bool Cell_Callback (SyntaxTreeCallbackReason reason, Cell.production_kind kind, Cell p_Cell);

		// event associated with syntax rule Cell
		public event Cell_Callback Cell_Event;

		// event trigger associated with syntax rule Cell
		public bool Raise_Cell_Event (SyntaxTreeCallbackReason reason, Cell.production_kind kind, Cell p_Cell)
		{
			bool? status = Cell_Event?.Invoke (reason, kind, p_Cell);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Cell
		//
		// traverse syntax tree node associated with any production of syntax rule Cell
		//

		public void Traverse (Cell p_Cell)
		{
			if (p_Cell.isLocked())
				return;
			p_Cell.dolock();
			Cell.production_kind kind = (Cell.production_kind) p_Cell.kind;
			p_Cell.turn_reset ();
			if (Raise_Cell_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Cell))
			switch (kind)
			{
				case Cell.production_kind.g_Cell_1:
					// traverse syntax tree node associated with production
					// Cell: number

				break;
			}
			Raise_Cell_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Cell);
			p_Cell.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Cell
		//

		public void TraverseCommon (Cell p_Cell)
		{
			Cell.production_kind kind = (Cell.production_kind) p_Cell.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Cell))
			switch (kind)
			{
				case Cell.production_kind.g_Cell_1:
					// traverse syntax tree node associated with production
					// Cell: number

						TraverseCommon (p_Cell.m_number);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Cell);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Cell

		//
		// create syntax tree node associated with production
		// Cell: number

		//

		public Cell Cell_1 (SyntaxTreeToken p_token)
		{
			Cell p_Cell_ref = new Cell(p_token);
			p_token.parent = p_Cell_ref;
			Raise_Cell_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Cell.production_kind.g_Cell_1, p_Cell_ref);
			return p_Cell_ref;
		}
		#endregion
	};
}
