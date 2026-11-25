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
	// class associated with syntax rule Arc-set
	//

	[DataContract]
	public class	Arc_set : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Arc-set
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Arc-set
		{
			g_Arc_set_1 = 1,	// Arc

			g_Arc_set_2 = 2,	// Arc-set Arc

		};
		#endregion
		#region production markers associated with the syntax rule Arc-set

		// markers associated with production: Arc-set -> Arc

		public enum production_marker_1 : ushort
		{
			m_Arc,
			final
		};

		// markers associated with production: Arc-set -> Arc-set Arc

		public enum production_marker_2 : ushort
		{
			m_Arc_set,
			m_Arc,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Arc-set

		// Constructor declaration(s) associated with production(s) of syntax rule Arc-set

		//
		// Constructor associated with the following production(s)
		// Arc-set -> Arc

		//

		public Arc_set (Arc p_Arc) : base ((uint) ProductionID._Arc_set_ID, (uint) production_kind.g_Arc_set_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Arc = p_Arc;
		}

		//
		// Constructor associated with the following production(s)
		// Arc-set -> Arc-set Arc

		//

		public Arc_set (Arc_set p_Arc_set, Arc p_Arc) : base ((uint) ProductionID._Arc_set_ID, (uint) production_kind.g_Arc_set_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_Arc_set = p_Arc_set;
			children[1] = m_Arc = p_Arc;
		}

		public Arc_set () { }

		// Copy constructor

		public Arc_set (Arc_set p_Arc_set) : base (p_Arc_set.id, p_Arc_set.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Arc_set.appInfo;
			switch ((production_kind) p_Arc_set.kind)
			{
				case production_kind.g_Arc_set_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Arc = (p_Arc_set.m_Arc != null) ? new Arc (p_Arc_set.m_Arc) : null) != null) m_Arc.parent = this;
					break;
				case production_kind.g_Arc_set_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_Arc_set = (p_Arc_set.m_Arc_set != null) ? new Arc_set (p_Arc_set.m_Arc_set) : null) != null) m_Arc_set.parent = this;
					if ((children [1] = m_Arc = (p_Arc_set.m_Arc != null) ? new Arc (p_Arc_set.m_Arc) : null) != null) m_Arc.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Arc_set" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Arc_set (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_Arc?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Arc-set

		// Content changing function(s) associated with production(s) of syntax rule Arc-set

		//
		// Content changing function associated with following production(s)
		// Arc-set -> Arc

		//

		public void change(Arc p_Arc)
		{
			_init ();
			this.kind = (uint) production_kind.g_Arc_set_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Arc = p_Arc;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Arc-set -> Arc-set Arc

		//

		public void change(Arc_set p_Arc_set, Arc p_Arc)
		{
			_init ();
			this.kind = (uint) production_kind.g_Arc_set_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_Arc_set = p_Arc_set;
			children [1] = m_Arc = p_Arc;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Arc-set
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_Arc != null) && node.m_Arc.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Arc-set

		//
		// emit production tree node associated with any production of syntax rule Arc-set
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_Arc_set_1:
						// emit syntax tree node associated with production
						// Arc-set: Arc

						s += " " + node.m_Arc.Emit (depth - 1);
						break;
					case production_kind.g_Arc_set_2:
						// emit syntax tree node associated with production
						// Arc-set: Arc-set Arc

						s += " " + node.m_Arc.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Arc-set
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "Arc_set (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_Arc_set_1:
						// emit syntax tree node associated with production
						// Arc-set: Arc

						str += node.m_Arc.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_Arc_set_2:
						// emit syntax tree node associated with production
						// Arc-set: Arc-set Arc

						str += ' ';
						str += node.m_Arc.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Arc-set

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Arc-set with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					Arc_set.production_kind kind = (Arc_set.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case Arc_set.production_kind.g_Arc_set_1:
							// traverse syntax tree node associated with production
							// Arc-set: Arc

							node.m_Arc.Visit (visitor, appData);
							break;
						case Arc_set.production_kind.g_Arc_set_2:
							// traverse syntax tree node associated with production
							// Arc-set: Arc-set Arc

							node.m_Arc.Visit (visitor, appData);
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
			for (Arc_set node = this; node != null; node = node.m_Arc_set)
			{
				node.parent = parent;
				node.m_Arc?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule Arc-set
		//

		public void _init ()
		{
			m_Arc = null;
			m_Arc_set = null;
		}

		public delegate object IteratorDelegate (Arc_set p_Arc_set, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<Arc_set> stack = new Stack<Arc_set> ();
			Arc_set p_Arc_set;
			for (p_Arc_set = this; p_Arc_set != null; p_Arc_set = p_Arc_set.m_Arc_set)
				stack.Push (p_Arc_set);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Arc-set

		// counter of all nodes associated with syntax rule Arc-set
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Arc-set
		[DataMember (Name = "m_Arc")] public Arc m_Arc { get; private set; }
		[DataMember (Name = "m_Arc_set")] public Arc_set m_Arc_set { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Arc-set

		// delegate function (callback) prototype associated with syntax rule Arc-set
		public delegate bool Arc_set_Callback (SyntaxTreeCallbackReason reason, Arc_set.production_kind kind, Arc_set p_Arc_set);

		// event associated with syntax rule Arc-set
		public event Arc_set_Callback Arc_set_Event;

		// event trigger associated with syntax rule Arc-set
		public bool Raise_Arc_set_Event (SyntaxTreeCallbackReason reason, Arc_set.production_kind kind, Arc_set p_Arc_set)
		{
			bool? status = Arc_set_Event?.Invoke (reason, kind, p_Arc_set);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Arc-set
		//
		// traverse syntax tree node associated with any production of syntax rule Arc-set
		//

		public void Traverse (Arc_set p_Arc_set)
		{
			if (p_Arc_set.isLocked())
				return;
			if (Raise_Arc_set_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (Arc_set.production_kind) p_Arc_set.kind, p_Arc_set))
				p_Arc_set.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					Arc_set.production_kind kind = (Arc_set.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_Arc_set_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case Arc_set.production_kind.g_Arc_set_1:
								// traverse syntax tree node associated with production
								// Arc-set: Arc

								if (Raise_Arc_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Arc);
								node.turn_inc ();
								Raise_Arc_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case Arc_set.production_kind.g_Arc_set_2:
								// traverse syntax tree node associated with production
								// Arc-set: Arc-set Arc

								if (Raise_Arc_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_Arc_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Arc);
								node.turn_inc ();
								Raise_Arc_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_Arc_set_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_Arc_set_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (Arc_set.production_kind) p_Arc_set.kind, p_Arc_set);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Arc-set
		//

		public void TraverseCommon (Arc_set p_Arc_set)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_Arc_set.kind, p_Arc_set))
				p_Arc_set.Iterate (null, (node, appData) =>
				{
					Arc_set.production_kind kind = (Arc_set.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case Arc_set.production_kind.g_Arc_set_1:
							// traverse syntax tree node associated with production
							// Arc-set: Arc

							TraverseCommon (node.m_Arc);
							break;
						case Arc_set.production_kind.g_Arc_set_2:
							// traverse syntax tree node associated with production
							// Arc-set: Arc-set Arc

							TraverseCommon (node.m_Arc);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_Arc_set.kind, p_Arc_set);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Arc-set

		//
		// create syntax tree node associated with production
		// Arc-set: Arc

		//

		public Arc_set Arc_set_1 (Arc p_Arc)
		{
			Arc_set p_Arc_set_ref = new Arc_set(p_Arc);
			p_Arc.parent = p_Arc_set_ref;
			Raise_Arc_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Arc_set.production_kind.g_Arc_set_1, p_Arc_set_ref);
			return p_Arc_set_ref;
		}

		//
		// create syntax tree node associated with production
		// Arc-set: Arc-set Arc

		//

		public Arc_set Arc_set_2 (Arc_set p_Arc_set, Arc p_Arc)
		{
			Arc_set p_Arc_set_ref = new Arc_set(p_Arc_set, p_Arc);
			p_Arc_set.parent = p_Arc_set_ref;
			p_Arc.parent = p_Arc_set_ref;
			Raise_Arc_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Arc_set.production_kind.g_Arc_set_2, p_Arc_set_ref);
			return p_Arc_set_ref;
		}
		#endregion
	};
}
