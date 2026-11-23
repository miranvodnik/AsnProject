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
	// class associated with syntax rule AssignmentList
	//

	[DataContract]
	public class	AssignmentList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AssignmentList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AssignmentList
		{
			g_AssignmentList_1 = 1,	// Assignment

			g_AssignmentList_2 = 2,	// AssignmentList Assignment

		};
		#endregion
		#region production markers associated with the syntax rule AssignmentList

		// markers associated with production: AssignmentList -> Assignment

		public enum production_marker_1 : ushort
		{
			m_Assignment,
			final
		};

		// markers associated with production: AssignmentList -> AssignmentList Assignment

		public enum production_marker_2 : ushort
		{
			m_AssignmentList,
			m_Assignment,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AssignmentList

		// Constructor declaration(s) associated with production(s) of syntax rule AssignmentList

		//
		// Constructor associated with the following production(s)
		// AssignmentList -> Assignment

		//

		public AssignmentList (Assignment p_Assignment) : base ((uint) ProductionID._AssignmentList_ID, (uint) production_kind.g_AssignmentList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Assignment = p_Assignment;
		}

		//
		// Constructor associated with the following production(s)
		// AssignmentList -> AssignmentList Assignment

		//

		public AssignmentList (AssignmentList p_AssignmentList, Assignment p_Assignment) : base ((uint) ProductionID._AssignmentList_ID, (uint) production_kind.g_AssignmentList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_AssignmentList = p_AssignmentList;
			children[1] = m_Assignment = p_Assignment;
		}

		public AssignmentList () { }

		// Copy constructor

		public AssignmentList (AssignmentList p_AssignmentList) : base (p_AssignmentList.id, p_AssignmentList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AssignmentList.appInfo;
			switch ((production_kind) p_AssignmentList.kind)
			{
				case production_kind.g_AssignmentList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Assignment = (p_AssignmentList.m_Assignment != null) ? new Assignment (p_AssignmentList.m_Assignment) : null) != null) m_Assignment.parent = this;
					break;
				case production_kind.g_AssignmentList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_AssignmentList = (p_AssignmentList.m_AssignmentList != null) ? new AssignmentList (p_AssignmentList.m_AssignmentList) : null) != null) m_AssignmentList.parent = this;
					if ((children [1] = m_Assignment = (p_AssignmentList.m_Assignment != null) ? new Assignment (p_AssignmentList.m_Assignment) : null) != null) m_Assignment.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AssignmentList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AssignmentList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_Assignment?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AssignmentList

		// Content changing function(s) associated with production(s) of syntax rule AssignmentList

		//
		// Content changing function associated with following production(s)
		// AssignmentList -> Assignment

		//

		public void change(Assignment p_Assignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_AssignmentList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Assignment = p_Assignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AssignmentList -> AssignmentList Assignment

		//

		public void change(AssignmentList p_AssignmentList, Assignment p_Assignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_AssignmentList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_AssignmentList = p_AssignmentList;
			children [1] = m_Assignment = p_Assignment;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AssignmentList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_Assignment != null) && node.m_Assignment.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AssignmentList

		//
		// emit production tree node associated with any production of syntax rule AssignmentList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AssignmentList_1:
						// emit syntax tree node associated with production
						// AssignmentList: Assignment

						s += " " + node.m_Assignment.Emit (depth - 1);
						break;
					case production_kind.g_AssignmentList_2:
						// emit syntax tree node associated with production
						// AssignmentList: AssignmentList Assignment

						s += " " + node.m_Assignment.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AssignmentList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "AssignmentList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AssignmentList_1:
						// emit syntax tree node associated with production
						// AssignmentList: Assignment

						str += node.m_Assignment.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_AssignmentList_2:
						// emit syntax tree node associated with production
						// AssignmentList: AssignmentList Assignment

						str += ' ';
						str += node.m_Assignment.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AssignmentList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AssignmentList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					AssignmentList.production_kind kind = (AssignmentList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case AssignmentList.production_kind.g_AssignmentList_1:
							// traverse syntax tree node associated with production
							// AssignmentList: Assignment

							node.m_Assignment.Visit (visitor, appData);
							break;
						case AssignmentList.production_kind.g_AssignmentList_2:
							// traverse syntax tree node associated with production
							// AssignmentList: AssignmentList Assignment

							node.m_Assignment.Visit (visitor, appData);
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
			for (AssignmentList node = this; node != null; node = node.m_AssignmentList)
			{
				node.parent = parent;
				node.m_Assignment?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule AssignmentList
		//

		public void _init ()
		{
			m_Assignment = null;
			m_AssignmentList = null;
		}

		public delegate object IteratorDelegate (AssignmentList p_AssignmentList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<AssignmentList> stack = new Stack<AssignmentList> ();
			AssignmentList p_AssignmentList;
			for (p_AssignmentList = this; p_AssignmentList != null; p_AssignmentList = p_AssignmentList.m_AssignmentList)
				stack.Push (p_AssignmentList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AssignmentList

		// counter of all nodes associated with syntax rule AssignmentList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AssignmentList
		[DataMember (Name = "m_Assignment")] public Assignment m_Assignment { get; private set; }
		[DataMember (Name = "m_AssignmentList")] public AssignmentList m_AssignmentList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AssignmentList

		// delegate function (callback) prototype associated with syntax rule AssignmentList
		public delegate bool AssignmentList_Callback (SyntaxTreeCallbackReason reason, AssignmentList.production_kind kind, AssignmentList p_AssignmentList);

		// event associated with syntax rule AssignmentList
		public event AssignmentList_Callback AssignmentList_Event;

		// event trigger associated with syntax rule AssignmentList
		public bool Raise_AssignmentList_Event (SyntaxTreeCallbackReason reason, AssignmentList.production_kind kind, AssignmentList p_AssignmentList)
		{
			bool? status = AssignmentList_Event?.Invoke (reason, kind, p_AssignmentList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AssignmentList
		//
		// traverse syntax tree node associated with any production of syntax rule AssignmentList
		//

		public void Traverse (AssignmentList p_AssignmentList)
		{
			if (p_AssignmentList.isLocked())
				return;
			if (Raise_AssignmentList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (AssignmentList.production_kind) p_AssignmentList.kind, p_AssignmentList))
				p_AssignmentList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					AssignmentList.production_kind kind = (AssignmentList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_AssignmentList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case AssignmentList.production_kind.g_AssignmentList_1:
								// traverse syntax tree node associated with production
								// AssignmentList: Assignment

								if (Raise_AssignmentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Assignment);
								node.turn_inc ();
								Raise_AssignmentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case AssignmentList.production_kind.g_AssignmentList_2:
								// traverse syntax tree node associated with production
								// AssignmentList: AssignmentList Assignment

								if (Raise_AssignmentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_AssignmentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Assignment);
								node.turn_inc ();
								Raise_AssignmentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_AssignmentList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_AssignmentList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (AssignmentList.production_kind) p_AssignmentList.kind, p_AssignmentList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AssignmentList
		//

		public void TraverseCommon (AssignmentList p_AssignmentList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_AssignmentList.kind, p_AssignmentList))
				p_AssignmentList.Iterate (null, (node, appData) =>
				{
					AssignmentList.production_kind kind = (AssignmentList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case AssignmentList.production_kind.g_AssignmentList_1:
							// traverse syntax tree node associated with production
							// AssignmentList: Assignment

							TraverseCommon (node.m_Assignment);
							break;
						case AssignmentList.production_kind.g_AssignmentList_2:
							// traverse syntax tree node associated with production
							// AssignmentList: AssignmentList Assignment

							TraverseCommon (node.m_Assignment);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_AssignmentList.kind, p_AssignmentList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AssignmentList

		//
		// create syntax tree node associated with production
		// AssignmentList: Assignment

		//

		public AssignmentList AssignmentList_1 (Assignment p_Assignment)
		{
			AssignmentList p_AssignmentList_ref = new AssignmentList(p_Assignment);
			p_Assignment.parent = p_AssignmentList_ref;
			Raise_AssignmentList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AssignmentList.production_kind.g_AssignmentList_1, p_AssignmentList_ref);
			return p_AssignmentList_ref;
		}

		//
		// create syntax tree node associated with production
		// AssignmentList: AssignmentList Assignment

		//

		public AssignmentList AssignmentList_2 (AssignmentList p_AssignmentList, Assignment p_Assignment)
		{
			AssignmentList p_AssignmentList_ref = new AssignmentList(p_AssignmentList, p_Assignment);
			p_AssignmentList.parent = p_AssignmentList_ref;
			p_Assignment.parent = p_AssignmentList_ref;
			Raise_AssignmentList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AssignmentList.production_kind.g_AssignmentList_2, p_AssignmentList_ref);
			return p_AssignmentList_ref;
		}
		#endregion
	};
}
