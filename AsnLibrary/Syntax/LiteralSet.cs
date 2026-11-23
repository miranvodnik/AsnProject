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
	// class associated with syntax rule LiteralSet
	//

	[DataContract]
	public class	LiteralSet : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule LiteralSet
		public enum production_kind : ushort	// enumerated production(s) of syntax rule LiteralSet
		{
			g_LiteralSet_1 = 1,	// %empty

			g_LiteralSet_2 = 2,	// Literal

			g_LiteralSet_3 = 3,	// LiteralSet Literal

		};
		#endregion
		#region production markers associated with the syntax rule LiteralSet

		// markers associated with production: LiteralSet -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: LiteralSet -> Literal

		public enum production_marker_2 : ushort
		{
			m_Literal,
			final
		};

		// markers associated with production: LiteralSet -> LiteralSet Literal

		public enum production_marker_3 : ushort
		{
			m_LiteralSet,
			m_Literal,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule LiteralSet

		// Constructor declaration(s) associated with production(s) of syntax rule LiteralSet

		//
		// Constructor associated with the following production(s)
		// LiteralSet -> %empty

		//

		public LiteralSet () : base ((uint) ProductionID._LiteralSet_ID, (uint) production_kind.g_LiteralSet_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// LiteralSet -> Literal

		//

		public LiteralSet (Literal p_Literal) : base ((uint) ProductionID._LiteralSet_ID, (uint) production_kind.g_LiteralSet_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Literal = p_Literal;
		}

		//
		// Constructor associated with the following production(s)
		// LiteralSet -> LiteralSet Literal

		//

		public LiteralSet (LiteralSet p_LiteralSet, Literal p_Literal) : base ((uint) ProductionID._LiteralSet_ID, (uint) production_kind.g_LiteralSet_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_LiteralSet = p_LiteralSet;
			children[1] = m_Literal = p_Literal;
		}

		// Copy constructor

		public LiteralSet (LiteralSet p_LiteralSet) : base (p_LiteralSet.id, p_LiteralSet.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_LiteralSet.appInfo;
			switch ((production_kind) p_LiteralSet.kind)
			{
				case production_kind.g_LiteralSet_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_LiteralSet_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Literal = (p_LiteralSet.m_Literal != null) ? new Literal (p_LiteralSet.m_Literal) : null) != null) m_Literal.parent = this;
					break;
				case production_kind.g_LiteralSet_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_LiteralSet = (p_LiteralSet.m_LiteralSet != null) ? new LiteralSet (p_LiteralSet.m_LiteralSet) : null) != null) m_LiteralSet.parent = this;
					if ((children [1] = m_Literal = (p_LiteralSet.m_Literal != null) ? new Literal (p_LiteralSet.m_Literal) : null) != null) m_Literal.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "LiteralSet" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new LiteralSet (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_Literal?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule LiteralSet

		// Content changing function(s) associated with production(s) of syntax rule LiteralSet

		//
		// Content changing function associated with following production(s)
		// LiteralSet -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_LiteralSet_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// LiteralSet -> Literal

		//

		public void change(Literal p_Literal)
		{
			_init ();
			this.kind = (uint) production_kind.g_LiteralSet_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Literal = p_Literal;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// LiteralSet -> LiteralSet Literal

		//

		public void change(LiteralSet p_LiteralSet, Literal p_Literal)
		{
			_init ();
			this.kind = (uint) production_kind.g_LiteralSet_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_LiteralSet = p_LiteralSet;
			children [1] = m_Literal = p_Literal;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule LiteralSet
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_Literal != null) && node.m_Literal.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule LiteralSet

		//
		// emit production tree node associated with any production of syntax rule LiteralSet
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_LiteralSet_1:
						// emit syntax tree node associated with production
						// LiteralSet: %empty

						break;
					case production_kind.g_LiteralSet_2:
						// emit syntax tree node associated with production
						// LiteralSet: Literal

						s += " " + node.m_Literal.Emit (depth - 1);
						break;
					case production_kind.g_LiteralSet_3:
						// emit syntax tree node associated with production
						// LiteralSet: LiteralSet Literal

						s += " " + node.m_Literal.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule LiteralSet
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "LiteralSet (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_LiteralSet_1:
						// emit syntax tree node associated with production
						// LiteralSet: %empty

						break;
					case production_kind.g_LiteralSet_2:
						// emit syntax tree node associated with production
						// LiteralSet: Literal

						str += node.m_Literal.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_LiteralSet_3:
						// emit syntax tree node associated with production
						// LiteralSet: LiteralSet Literal

						str += ' ';
						str += node.m_Literal.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule LiteralSet

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule LiteralSet with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					LiteralSet.production_kind kind = (LiteralSet.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case LiteralSet.production_kind.g_LiteralSet_1:
							// traverse syntax tree node associated with production
							// LiteralSet: %empty

							break;
						case LiteralSet.production_kind.g_LiteralSet_2:
							// traverse syntax tree node associated with production
							// LiteralSet: Literal

							node.m_Literal.Visit (visitor, appData);
							break;
						case LiteralSet.production_kind.g_LiteralSet_3:
							// traverse syntax tree node associated with production
							// LiteralSet: LiteralSet Literal

							node.m_Literal.Visit (visitor, appData);
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
			for (LiteralSet node = this; node != null; node = node.m_LiteralSet)
			{
				node.parent = parent;
				node.m_Literal?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule LiteralSet
		//

		public void _init ()
		{
			m_Literal = null;
			m_LiteralSet = null;
		}

		public delegate object IteratorDelegate (LiteralSet p_LiteralSet, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<LiteralSet> stack = new Stack<LiteralSet> ();
			LiteralSet p_LiteralSet;
			for (p_LiteralSet = this; p_LiteralSet != null; p_LiteralSet = p_LiteralSet.m_LiteralSet)
				stack.Push (p_LiteralSet);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule LiteralSet

		// counter of all nodes associated with syntax rule LiteralSet
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule LiteralSet
		[DataMember (Name = "m_Literal")] public Literal m_Literal { get; private set; }
		[DataMember (Name = "m_LiteralSet")] public LiteralSet m_LiteralSet { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule LiteralSet

		// delegate function (callback) prototype associated with syntax rule LiteralSet
		public delegate bool LiteralSet_Callback (SyntaxTreeCallbackReason reason, LiteralSet.production_kind kind, LiteralSet p_LiteralSet);

		// event associated with syntax rule LiteralSet
		public event LiteralSet_Callback LiteralSet_Event;

		// event trigger associated with syntax rule LiteralSet
		public bool Raise_LiteralSet_Event (SyntaxTreeCallbackReason reason, LiteralSet.production_kind kind, LiteralSet p_LiteralSet)
		{
			bool? status = LiteralSet_Event?.Invoke (reason, kind, p_LiteralSet);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule LiteralSet
		//
		// traverse syntax tree node associated with any production of syntax rule LiteralSet
		//

		public void Traverse (LiteralSet p_LiteralSet)
		{
			if (p_LiteralSet.isLocked())
				return;
			if (Raise_LiteralSet_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (LiteralSet.production_kind) p_LiteralSet.kind, p_LiteralSet))
				p_LiteralSet.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					LiteralSet.production_kind kind = (LiteralSet.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_LiteralSet_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case LiteralSet.production_kind.g_LiteralSet_1:
								// traverse syntax tree node associated with production
								// LiteralSet: %empty

							break;
							case LiteralSet.production_kind.g_LiteralSet_2:
								// traverse syntax tree node associated with production
								// LiteralSet: Literal

								if (Raise_LiteralSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Literal);
								node.turn_inc ();
								Raise_LiteralSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case LiteralSet.production_kind.g_LiteralSet_3:
								// traverse syntax tree node associated with production
								// LiteralSet: LiteralSet Literal

								if (Raise_LiteralSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_LiteralSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Literal);
								node.turn_inc ();
								Raise_LiteralSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_LiteralSet_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_LiteralSet_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (LiteralSet.production_kind) p_LiteralSet.kind, p_LiteralSet);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule LiteralSet
		//

		public void TraverseCommon (LiteralSet p_LiteralSet)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_LiteralSet.kind, p_LiteralSet))
				p_LiteralSet.Iterate (null, (node, appData) =>
				{
					LiteralSet.production_kind kind = (LiteralSet.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case LiteralSet.production_kind.g_LiteralSet_1:
							// traverse syntax tree node associated with production
							// LiteralSet: %empty

							break;
						case LiteralSet.production_kind.g_LiteralSet_2:
							// traverse syntax tree node associated with production
							// LiteralSet: Literal

							TraverseCommon (node.m_Literal);
							break;
						case LiteralSet.production_kind.g_LiteralSet_3:
							// traverse syntax tree node associated with production
							// LiteralSet: LiteralSet Literal

							TraverseCommon (node.m_Literal);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_LiteralSet.kind, p_LiteralSet);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule LiteralSet

		//
		// create syntax tree node associated with production
		// LiteralSet: %empty

		//

		public LiteralSet LiteralSet_1 ()
		{
			LiteralSet p_LiteralSet_ref = new LiteralSet();
			Raise_LiteralSet_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, LiteralSet.production_kind.g_LiteralSet_1, p_LiteralSet_ref);
			return p_LiteralSet_ref;
		}

		//
		// create syntax tree node associated with production
		// LiteralSet: Literal

		//

		public LiteralSet LiteralSet_2 (Literal p_Literal)
		{
			LiteralSet p_LiteralSet_ref = new LiteralSet(p_Literal);
			p_Literal.parent = p_LiteralSet_ref;
			Raise_LiteralSet_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, LiteralSet.production_kind.g_LiteralSet_2, p_LiteralSet_ref);
			return p_LiteralSet_ref;
		}

		//
		// create syntax tree node associated with production
		// LiteralSet: LiteralSet Literal

		//

		public LiteralSet LiteralSet_3 (LiteralSet p_LiteralSet, Literal p_Literal)
		{
			LiteralSet p_LiteralSet_ref = new LiteralSet(p_LiteralSet, p_Literal);
			p_LiteralSet.parent = p_LiteralSet_ref;
			p_Literal.parent = p_LiteralSet_ref;
			Raise_LiteralSet_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, LiteralSet.production_kind.g_LiteralSet_3, p_LiteralSet_ref);
			return p_LiteralSet_ref;
		}
		#endregion
	};
}
