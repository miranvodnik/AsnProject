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
	// class associated with syntax rule DefinitiveObjIdComponentList
	//

	[DataContract]
	public class	DefinitiveObjIdComponentList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinitiveObjIdComponentList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinitiveObjIdComponentList
		{
			g_DefinitiveObjIdComponentList_1 = 1,	// DefinitiveObjIdComponent

			g_DefinitiveObjIdComponentList_2 = 2,	// DefinitiveObjIdComponentList DefinitiveObjIdComponent

		};
		#endregion
		#region production markers associated with the syntax rule DefinitiveObjIdComponentList

		// markers associated with production: DefinitiveObjIdComponentList -> DefinitiveObjIdComponent

		public enum production_marker_1 : ushort
		{
			m_DefinitiveObjIdComponent,
			final
		};

		// markers associated with production: DefinitiveObjIdComponentList -> DefinitiveObjIdComponentList DefinitiveObjIdComponent

		public enum production_marker_2 : ushort
		{
			m_DefinitiveObjIdComponentList,
			m_DefinitiveObjIdComponent,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinitiveObjIdComponentList

		// Constructor declaration(s) associated with production(s) of syntax rule DefinitiveObjIdComponentList

		//
		// Constructor associated with the following production(s)
		// DefinitiveObjIdComponentList -> DefinitiveObjIdComponent

		//

		public DefinitiveObjIdComponentList (DefinitiveObjIdComponent p_DefinitiveObjIdComponent) : base ((uint) ProductionID._DefinitiveObjIdComponentList_ID, (uint) production_kind.g_DefinitiveObjIdComponentList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinitiveObjIdComponent = p_DefinitiveObjIdComponent;
		}

		//
		// Constructor associated with the following production(s)
		// DefinitiveObjIdComponentList -> DefinitiveObjIdComponentList DefinitiveObjIdComponent

		//

		public DefinitiveObjIdComponentList (DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList, DefinitiveObjIdComponent p_DefinitiveObjIdComponent) : base ((uint) ProductionID._DefinitiveObjIdComponentList_ID, (uint) production_kind.g_DefinitiveObjIdComponentList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DefinitiveObjIdComponentList = p_DefinitiveObjIdComponentList;
			children[1] = m_DefinitiveObjIdComponent = p_DefinitiveObjIdComponent;
		}

		public DefinitiveObjIdComponentList () { }

		// Copy constructor

		public DefinitiveObjIdComponentList (DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList) : base (p_DefinitiveObjIdComponentList.id, p_DefinitiveObjIdComponentList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinitiveObjIdComponentList.appInfo;
			switch ((production_kind) p_DefinitiveObjIdComponentList.kind)
			{
				case production_kind.g_DefinitiveObjIdComponentList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinitiveObjIdComponent = (p_DefinitiveObjIdComponentList.m_DefinitiveObjIdComponent != null) ? new DefinitiveObjIdComponent (p_DefinitiveObjIdComponentList.m_DefinitiveObjIdComponent) : null) != null) m_DefinitiveObjIdComponent.parent = this;
					break;
				case production_kind.g_DefinitiveObjIdComponentList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DefinitiveObjIdComponentList = (p_DefinitiveObjIdComponentList.m_DefinitiveObjIdComponentList != null) ? new DefinitiveObjIdComponentList (p_DefinitiveObjIdComponentList.m_DefinitiveObjIdComponentList) : null) != null) m_DefinitiveObjIdComponentList.parent = this;
					if ((children [1] = m_DefinitiveObjIdComponent = (p_DefinitiveObjIdComponentList.m_DefinitiveObjIdComponent != null) ? new DefinitiveObjIdComponent (p_DefinitiveObjIdComponentList.m_DefinitiveObjIdComponent) : null) != null) m_DefinitiveObjIdComponent.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinitiveObjIdComponentList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinitiveObjIdComponentList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_DefinitiveObjIdComponent?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinitiveObjIdComponentList

		// Content changing function(s) associated with production(s) of syntax rule DefinitiveObjIdComponentList

		//
		// Content changing function associated with following production(s)
		// DefinitiveObjIdComponentList -> DefinitiveObjIdComponent

		//

		public void change(DefinitiveObjIdComponent p_DefinitiveObjIdComponent)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitiveObjIdComponentList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinitiveObjIdComponent = p_DefinitiveObjIdComponent;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinitiveObjIdComponentList -> DefinitiveObjIdComponentList DefinitiveObjIdComponent

		//

		public void change(DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList, DefinitiveObjIdComponent p_DefinitiveObjIdComponent)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitiveObjIdComponentList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DefinitiveObjIdComponentList = p_DefinitiveObjIdComponentList;
			children [1] = m_DefinitiveObjIdComponent = p_DefinitiveObjIdComponent;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinitiveObjIdComponentList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_DefinitiveObjIdComponent != null) && node.m_DefinitiveObjIdComponent.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinitiveObjIdComponentList

		//
		// emit production tree node associated with any production of syntax rule DefinitiveObjIdComponentList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_DefinitiveObjIdComponentList_1:
						// emit syntax tree node associated with production
						// DefinitiveObjIdComponentList: DefinitiveObjIdComponent

						s += " " + node.m_DefinitiveObjIdComponent.Emit (depth - 1);
						break;
					case production_kind.g_DefinitiveObjIdComponentList_2:
						// emit syntax tree node associated with production
						// DefinitiveObjIdComponentList: DefinitiveObjIdComponentList DefinitiveObjIdComponent

						s += " " + node.m_DefinitiveObjIdComponent.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinitiveObjIdComponentList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "DefinitiveObjIdComponentList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_DefinitiveObjIdComponentList_1:
						// emit syntax tree node associated with production
						// DefinitiveObjIdComponentList: DefinitiveObjIdComponent

						str += node.m_DefinitiveObjIdComponent.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_DefinitiveObjIdComponentList_2:
						// emit syntax tree node associated with production
						// DefinitiveObjIdComponentList: DefinitiveObjIdComponentList DefinitiveObjIdComponent

						str += ' ';
						str += node.m_DefinitiveObjIdComponent.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinitiveObjIdComponentList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveObjIdComponentList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					DefinitiveObjIdComponentList.production_kind kind = (DefinitiveObjIdComponentList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case DefinitiveObjIdComponentList.production_kind.g_DefinitiveObjIdComponentList_1:
							// traverse syntax tree node associated with production
							// DefinitiveObjIdComponentList: DefinitiveObjIdComponent

							node.m_DefinitiveObjIdComponent.Visit (visitor, appData);
							break;
						case DefinitiveObjIdComponentList.production_kind.g_DefinitiveObjIdComponentList_2:
							// traverse syntax tree node associated with production
							// DefinitiveObjIdComponentList: DefinitiveObjIdComponentList DefinitiveObjIdComponent

							node.m_DefinitiveObjIdComponent.Visit (visitor, appData);
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
			for (DefinitiveObjIdComponentList node = this; node != null; node = node.m_DefinitiveObjIdComponentList)
			{
				node.parent = parent;
				node.m_DefinitiveObjIdComponent?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule DefinitiveObjIdComponentList
		//

		public void _init ()
		{
			m_DefinitiveObjIdComponent = null;
			m_DefinitiveObjIdComponentList = null;
		}

		public delegate object IteratorDelegate (DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<DefinitiveObjIdComponentList> stack = new Stack<DefinitiveObjIdComponentList> ();
			DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList;
			for (p_DefinitiveObjIdComponentList = this; p_DefinitiveObjIdComponentList != null; p_DefinitiveObjIdComponentList = p_DefinitiveObjIdComponentList.m_DefinitiveObjIdComponentList)
				stack.Push (p_DefinitiveObjIdComponentList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinitiveObjIdComponentList

		// counter of all nodes associated with syntax rule DefinitiveObjIdComponentList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinitiveObjIdComponentList
		[DataMember (Name = "m_DefinitiveObjIdComponent")] public DefinitiveObjIdComponent m_DefinitiveObjIdComponent { get; private set; }
		[DataMember (Name = "m_DefinitiveObjIdComponentList")] public DefinitiveObjIdComponentList m_DefinitiveObjIdComponentList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinitiveObjIdComponentList

		// delegate function (callback) prototype associated with syntax rule DefinitiveObjIdComponentList
		public delegate bool DefinitiveObjIdComponentList_Callback (SyntaxTreeCallbackReason reason, DefinitiveObjIdComponentList.production_kind kind, DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList);

		// event associated with syntax rule DefinitiveObjIdComponentList
		public event DefinitiveObjIdComponentList_Callback DefinitiveObjIdComponentList_Event;

		// event trigger associated with syntax rule DefinitiveObjIdComponentList
		public bool Raise_DefinitiveObjIdComponentList_Event (SyntaxTreeCallbackReason reason, DefinitiveObjIdComponentList.production_kind kind, DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList)
		{
			bool? status = DefinitiveObjIdComponentList_Event?.Invoke (reason, kind, p_DefinitiveObjIdComponentList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinitiveObjIdComponentList
		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveObjIdComponentList
		//

		public void Traverse (DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList)
		{
			if (p_DefinitiveObjIdComponentList.isLocked())
				return;
			if (Raise_DefinitiveObjIdComponentList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (DefinitiveObjIdComponentList.production_kind) p_DefinitiveObjIdComponentList.kind, p_DefinitiveObjIdComponentList))
				p_DefinitiveObjIdComponentList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					DefinitiveObjIdComponentList.production_kind kind = (DefinitiveObjIdComponentList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_DefinitiveObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case DefinitiveObjIdComponentList.production_kind.g_DefinitiveObjIdComponentList_1:
								// traverse syntax tree node associated with production
								// DefinitiveObjIdComponentList: DefinitiveObjIdComponent

								if (Raise_DefinitiveObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_DefinitiveObjIdComponent);
								node.turn_inc ();
								Raise_DefinitiveObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case DefinitiveObjIdComponentList.production_kind.g_DefinitiveObjIdComponentList_2:
								// traverse syntax tree node associated with production
								// DefinitiveObjIdComponentList: DefinitiveObjIdComponentList DefinitiveObjIdComponent

								if (Raise_DefinitiveObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_DefinitiveObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_DefinitiveObjIdComponent);
								node.turn_inc ();
								Raise_DefinitiveObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_DefinitiveObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_DefinitiveObjIdComponentList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (DefinitiveObjIdComponentList.production_kind) p_DefinitiveObjIdComponentList.kind, p_DefinitiveObjIdComponentList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveObjIdComponentList
		//

		public void TraverseCommon (DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_DefinitiveObjIdComponentList.kind, p_DefinitiveObjIdComponentList))
				p_DefinitiveObjIdComponentList.Iterate (null, (node, appData) =>
				{
					DefinitiveObjIdComponentList.production_kind kind = (DefinitiveObjIdComponentList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case DefinitiveObjIdComponentList.production_kind.g_DefinitiveObjIdComponentList_1:
							// traverse syntax tree node associated with production
							// DefinitiveObjIdComponentList: DefinitiveObjIdComponent

							TraverseCommon (node.m_DefinitiveObjIdComponent);
							break;
						case DefinitiveObjIdComponentList.production_kind.g_DefinitiveObjIdComponentList_2:
							// traverse syntax tree node associated with production
							// DefinitiveObjIdComponentList: DefinitiveObjIdComponentList DefinitiveObjIdComponent

							TraverseCommon (node.m_DefinitiveObjIdComponent);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_DefinitiveObjIdComponentList.kind, p_DefinitiveObjIdComponentList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinitiveObjIdComponentList

		//
		// create syntax tree node associated with production
		// DefinitiveObjIdComponentList: DefinitiveObjIdComponent

		//

		public DefinitiveObjIdComponentList DefinitiveObjIdComponentList_1 (DefinitiveObjIdComponent p_DefinitiveObjIdComponent)
		{
			DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList_ref = new DefinitiveObjIdComponentList(p_DefinitiveObjIdComponent);
			p_DefinitiveObjIdComponent.parent = p_DefinitiveObjIdComponentList_ref;
			Raise_DefinitiveObjIdComponentList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitiveObjIdComponentList.production_kind.g_DefinitiveObjIdComponentList_1, p_DefinitiveObjIdComponentList_ref);
			return p_DefinitiveObjIdComponentList_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinitiveObjIdComponentList: DefinitiveObjIdComponentList DefinitiveObjIdComponent

		//

		public DefinitiveObjIdComponentList DefinitiveObjIdComponentList_2 (DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList, DefinitiveObjIdComponent p_DefinitiveObjIdComponent)
		{
			DefinitiveObjIdComponentList p_DefinitiveObjIdComponentList_ref = new DefinitiveObjIdComponentList(p_DefinitiveObjIdComponentList, p_DefinitiveObjIdComponent);
			p_DefinitiveObjIdComponentList.parent = p_DefinitiveObjIdComponentList_ref;
			p_DefinitiveObjIdComponent.parent = p_DefinitiveObjIdComponentList_ref;
			Raise_DefinitiveObjIdComponentList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitiveObjIdComponentList.production_kind.g_DefinitiveObjIdComponentList_2, p_DefinitiveObjIdComponentList_ref);
			return p_DefinitiveObjIdComponentList_ref;
		}
		#endregion
	};
}
