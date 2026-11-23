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
	// class associated with syntax rule AC-Cells
	//

	[DataContract]
	public class	AC_Cells : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-Cells
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-Cells
		{
			g_AC_Cells_1 = 1,	// AC-Cell

			g_AC_Cells_2 = 2,	// AC-Cells "," AC-Cell

		};
		#endregion
		#region production markers associated with the syntax rule AC-Cells

		// markers associated with production: AC-Cells -> AC-Cell

		public enum production_marker_1 : ushort
		{
			m_AC_Cell,
			final
		};

		// markers associated with production: AC-Cells -> AC-Cells "," AC-Cell

		public enum production_marker_2 : ushort
		{
			m_AC_Cells,
			m_AC_Cell,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-Cells

		// Constructor declaration(s) associated with production(s) of syntax rule AC-Cells

		//
		// Constructor associated with the following production(s)
		// AC-Cells -> AC-Cell

		//

		public AC_Cells (AC_Cell p_AC_Cell) : base ((uint) ProductionID._AC_Cells_ID, (uint) production_kind.g_AC_Cells_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AC_Cell = p_AC_Cell;
		}

		//
		// Constructor associated with the following production(s)
		// AC-Cells -> AC-Cells "," AC-Cell

		//

		public AC_Cells (AC_Cells p_AC_Cells, SyntaxTreeToken p_token, AC_Cell p_AC_Cell) : base ((uint) ProductionID._AC_Cells_ID, (uint) production_kind.g_AC_Cells_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_AC_Cells = p_AC_Cells;
			children[1] = m_comma = p_token;
			children[2] = m_AC_Cell = p_AC_Cell;
		}

		public AC_Cells () { }

		// Copy constructor

		public AC_Cells (AC_Cells p_AC_Cells) : base (p_AC_Cells.id, p_AC_Cells.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_Cells.appInfo;
			switch ((production_kind) p_AC_Cells.kind)
			{
				case production_kind.g_AC_Cells_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AC_Cell = (p_AC_Cells.m_AC_Cell != null) ? new AC_Cell (p_AC_Cells.m_AC_Cell) : null) != null) m_AC_Cell.parent = this;
					break;
				case production_kind.g_AC_Cells_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_AC_Cells = (p_AC_Cells.m_AC_Cells != null) ? new AC_Cells (p_AC_Cells.m_AC_Cells) : null) != null) m_AC_Cells.parent = this;
					if ((children [1] = m_comma = (p_AC_Cells.m_comma != null) ? new SyntaxTreeToken (p_AC_Cells.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_AC_Cell = (p_AC_Cells.m_AC_Cell != null) ? new AC_Cell (p_AC_Cells.m_AC_Cell) : null) != null) m_AC_Cell.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_Cells" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_Cells (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_AC_Cell?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-Cells

		// Content changing function(s) associated with production(s) of syntax rule AC-Cells

		//
		// Content changing function associated with following production(s)
		// AC-Cells -> AC-Cell

		//

		public void change(AC_Cell p_AC_Cell)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Cells_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AC_Cell = p_AC_Cell;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-Cells -> AC-Cells "," AC-Cell

		//

		public void change(AC_Cells p_AC_Cells, SyntaxTreeToken p_token, AC_Cell p_AC_Cell)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Cells_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_AC_Cells = p_AC_Cells;
			children [1] = m_comma = p_token;
			children [2] = m_AC_Cell = p_AC_Cell;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-Cells
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_AC_Cell != null) && node.m_AC_Cell.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-Cells

		//
		// emit production tree node associated with any production of syntax rule AC-Cells
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AC_Cells_1:
						// emit syntax tree node associated with production
						// AC-Cells: AC-Cell

						s += " " + node.m_AC_Cell.Emit (depth - 1);
						break;
					case production_kind.g_AC_Cells_2:
						// emit syntax tree node associated with production
						// AC-Cells: AC-Cells "," AC-Cell

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_AC_Cell.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-Cells
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "AC_Cells (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AC_Cells_1:
						// emit syntax tree node associated with production
						// AC-Cells: AC-Cell

						str += node.m_AC_Cell.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_AC_Cells_2:
						// emit syntax tree node associated with production
						// AC-Cells: AC-Cells "," AC-Cell

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_AC_Cell.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-Cells

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Cells with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					AC_Cells.production_kind kind = (AC_Cells.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case AC_Cells.production_kind.g_AC_Cells_1:
							// traverse syntax tree node associated with production
							// AC-Cells: AC-Cell

							node.m_AC_Cell.Visit (visitor, appData);
							break;
						case AC_Cells.production_kind.g_AC_Cells_2:
							// traverse syntax tree node associated with production
							// AC-Cells: AC-Cells "," AC-Cell

							node.m_comma.Visit (visitor, appData);
							node.m_AC_Cell.Visit (visitor, appData);
							break;
						}
					visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node, appData);
					return null;
				});
			visitor (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) this.kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			for (AC_Cells node = this; node != null; node = node.m_AC_Cells)
			{
				node.parent = parent;
				node.m_AC_Cell?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule AC-Cells
		//

		public void _init ()
		{
			m_AC_Cell = null;
			m_AC_Cells = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (AC_Cells p_AC_Cells, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<AC_Cells> stack = new Stack<AC_Cells> ();
			AC_Cells p_AC_Cells;
			for (p_AC_Cells = this; p_AC_Cells != null; p_AC_Cells = p_AC_Cells.m_AC_Cells)
				stack.Push (p_AC_Cells);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-Cells

		// counter of all nodes associated with syntax rule AC-Cells
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-Cells
		[DataMember (Name = "m_AC_Cell")] public AC_Cell m_AC_Cell { get; private set; }
		[DataMember (Name = "m_AC_Cells")] public AC_Cells m_AC_Cells { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-Cells

		// delegate function (callback) prototype associated with syntax rule AC-Cells
		public delegate bool AC_Cells_Callback (SyntaxTreeCallbackReason reason, AC_Cells.production_kind kind, AC_Cells p_AC_Cells);

		// event associated with syntax rule AC-Cells
		public event AC_Cells_Callback AC_Cells_Event;

		// event trigger associated with syntax rule AC-Cells
		public bool Raise_AC_Cells_Event (SyntaxTreeCallbackReason reason, AC_Cells.production_kind kind, AC_Cells p_AC_Cells)
		{
			bool? status = AC_Cells_Event?.Invoke (reason, kind, p_AC_Cells);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-Cells
		//
		// traverse syntax tree node associated with any production of syntax rule AC-Cells
		//

		public void Traverse (AC_Cells p_AC_Cells)
		{
			if (p_AC_Cells.isLocked())
				return;
			if (Raise_AC_Cells_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (AC_Cells.production_kind) p_AC_Cells.kind, p_AC_Cells))
				p_AC_Cells.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					AC_Cells.production_kind kind = (AC_Cells.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_AC_Cells_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case AC_Cells.production_kind.g_AC_Cells_1:
								// traverse syntax tree node associated with production
								// AC-Cells: AC-Cell

								if (Raise_AC_Cells_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AC_Cell);
								node.turn_inc ();
								Raise_AC_Cells_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case AC_Cells.production_kind.g_AC_Cells_2:
								// traverse syntax tree node associated with production
								// AC-Cells: AC-Cells "," AC-Cell

								if (Raise_AC_Cells_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_AC_Cells_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AC_Cell);
								node.turn_inc ();
								Raise_AC_Cells_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_AC_Cells_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_AC_Cells_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (AC_Cells.production_kind) p_AC_Cells.kind, p_AC_Cells);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Cells
		//

		public void TraverseCommon (AC_Cells p_AC_Cells)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_AC_Cells.kind, p_AC_Cells))
				p_AC_Cells.Iterate (null, (node, appData) =>
				{
					AC_Cells.production_kind kind = (AC_Cells.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case AC_Cells.production_kind.g_AC_Cells_1:
							// traverse syntax tree node associated with production
							// AC-Cells: AC-Cell

							TraverseCommon (node.m_AC_Cell);
							break;
						case AC_Cells.production_kind.g_AC_Cells_2:
							// traverse syntax tree node associated with production
							// AC-Cells: AC-Cells "," AC-Cell

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_AC_Cell);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_AC_Cells.kind, p_AC_Cells);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-Cells

		//
		// create syntax tree node associated with production
		// AC-Cells: AC-Cell

		//

		public AC_Cells AC_Cells_1 (AC_Cell p_AC_Cell)
		{
			AC_Cells p_AC_Cells_ref = new AC_Cells(p_AC_Cell);
			p_AC_Cell.parent = p_AC_Cells_ref;
			Raise_AC_Cells_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Cells.production_kind.g_AC_Cells_1, p_AC_Cells_ref);
			return p_AC_Cells_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-Cells: AC-Cells "," AC-Cell

		//

		public AC_Cells AC_Cells_2 (AC_Cells p_AC_Cells, SyntaxTreeToken p_token, AC_Cell p_AC_Cell)
		{
			AC_Cells p_AC_Cells_ref = new AC_Cells(p_AC_Cells, p_token, p_AC_Cell);
			p_AC_Cells.parent = p_AC_Cells_ref;
			p_token.parent = p_AC_Cells_ref;
			p_AC_Cell.parent = p_AC_Cells_ref;
			Raise_AC_Cells_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Cells.production_kind.g_AC_Cells_2, p_AC_Cells_ref);
			return p_AC_Cells_ref;
		}
		#endregion
	};
}
