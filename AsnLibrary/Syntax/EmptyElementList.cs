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
	// class associated with syntax rule EmptyElementList
	//

	[DataContract]
	public class	EmptyElementList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EmptyElementList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EmptyElementList
		{
			g_EmptyElementList_1 = 1,	// EmptyElement

			g_EmptyElementList_2 = 2,	// EmptyElementList EmptyElement

		};
		#endregion
		#region production markers associated with the syntax rule EmptyElementList

		// markers associated with production: EmptyElementList -> EmptyElement

		public enum production_marker_1 : ushort
		{
			m_EmptyElement,
			final
		};

		// markers associated with production: EmptyElementList -> EmptyElementList EmptyElement

		public enum production_marker_2 : ushort
		{
			m_EmptyElementList,
			m_EmptyElement,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EmptyElementList

		// Constructor declaration(s) associated with production(s) of syntax rule EmptyElementList

		//
		// Constructor associated with the following production(s)
		// EmptyElementList -> EmptyElement

		//

		public EmptyElementList (EmptyElement p_EmptyElement) : base ((uint) ProductionID._EmptyElementList_ID, (uint) production_kind.g_EmptyElementList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EmptyElement = p_EmptyElement;
		}

		//
		// Constructor associated with the following production(s)
		// EmptyElementList -> EmptyElementList EmptyElement

		//

		public EmptyElementList (EmptyElementList p_EmptyElementList, EmptyElement p_EmptyElement) : base ((uint) ProductionID._EmptyElementList_ID, (uint) production_kind.g_EmptyElementList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_EmptyElementList = p_EmptyElementList;
			children[1] = m_EmptyElement = p_EmptyElement;
		}

		public EmptyElementList () { }

		// Copy constructor

		public EmptyElementList (EmptyElementList p_EmptyElementList) : base (p_EmptyElementList.id, p_EmptyElementList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EmptyElementList.appInfo;
			switch ((production_kind) p_EmptyElementList.kind)
			{
				case production_kind.g_EmptyElementList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EmptyElement = (p_EmptyElementList.m_EmptyElement != null) ? new EmptyElement (p_EmptyElementList.m_EmptyElement) : null) != null) m_EmptyElement.parent = this;
					break;
				case production_kind.g_EmptyElementList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_EmptyElementList = (p_EmptyElementList.m_EmptyElementList != null) ? new EmptyElementList (p_EmptyElementList.m_EmptyElementList) : null) != null) m_EmptyElementList.parent = this;
					if ((children [1] = m_EmptyElement = (p_EmptyElementList.m_EmptyElement != null) ? new EmptyElement (p_EmptyElementList.m_EmptyElement) : null) != null) m_EmptyElement.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EmptyElementList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EmptyElementList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_EmptyElement?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EmptyElementList

		// Content changing function(s) associated with production(s) of syntax rule EmptyElementList

		//
		// Content changing function associated with following production(s)
		// EmptyElementList -> EmptyElement

		//

		public void change(EmptyElement p_EmptyElement)
		{
			_init ();
			this.kind = (uint) production_kind.g_EmptyElementList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EmptyElement = p_EmptyElement;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// EmptyElementList -> EmptyElementList EmptyElement

		//

		public void change(EmptyElementList p_EmptyElementList, EmptyElement p_EmptyElement)
		{
			_init ();
			this.kind = (uint) production_kind.g_EmptyElementList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_EmptyElementList = p_EmptyElementList;
			children [1] = m_EmptyElement = p_EmptyElement;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EmptyElementList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_EmptyElement != null) && node.m_EmptyElement.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EmptyElementList

		//
		// emit production tree node associated with any production of syntax rule EmptyElementList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_EmptyElementList_1:
						// emit syntax tree node associated with production
						// EmptyElementList: EmptyElement

						s += " " + node.m_EmptyElement.Emit (depth - 1);
						break;
					case production_kind.g_EmptyElementList_2:
						// emit syntax tree node associated with production
						// EmptyElementList: EmptyElementList EmptyElement

						s += " " + node.m_EmptyElement.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EmptyElementList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "EmptyElementList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_EmptyElementList_1:
						// emit syntax tree node associated with production
						// EmptyElementList: EmptyElement

						str += node.m_EmptyElement.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_EmptyElementList_2:
						// emit syntax tree node associated with production
						// EmptyElementList: EmptyElementList EmptyElement

						str += ' ';
						str += node.m_EmptyElement.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EmptyElementList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					EmptyElementList.production_kind kind = (EmptyElementList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case EmptyElementList.production_kind.g_EmptyElementList_1:
							// traverse syntax tree node associated with production
							// EmptyElementList: EmptyElement

							node.m_EmptyElement.Visit (visitor, appData);
							break;
						case EmptyElementList.production_kind.g_EmptyElementList_2:
							// traverse syntax tree node associated with production
							// EmptyElementList: EmptyElementList EmptyElement

							node.m_EmptyElement.Visit (visitor, appData);
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
			for (EmptyElementList node = this; node != null; node = node.m_EmptyElementList)
			{
				node.parent = parent;
				node.m_EmptyElement?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule EmptyElementList
		//

		public void _init ()
		{
			m_EmptyElement = null;
			m_EmptyElementList = null;
		}

		public delegate object IteratorDelegate (EmptyElementList p_EmptyElementList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<EmptyElementList> stack = new Stack<EmptyElementList> ();
			EmptyElementList p_EmptyElementList;
			for (p_EmptyElementList = this; p_EmptyElementList != null; p_EmptyElementList = p_EmptyElementList.m_EmptyElementList)
				stack.Push (p_EmptyElementList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EmptyElementList

		// counter of all nodes associated with syntax rule EmptyElementList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EmptyElementList
		[DataMember (Name = "m_EmptyElement")] public EmptyElement m_EmptyElement { get; private set; }
		[DataMember (Name = "m_EmptyElementList")] public EmptyElementList m_EmptyElementList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EmptyElementList

		// delegate function (callback) prototype associated with syntax rule EmptyElementList
		public delegate bool EmptyElementList_Callback (SyntaxTreeCallbackReason reason, EmptyElementList.production_kind kind, EmptyElementList p_EmptyElementList);

		// event associated with syntax rule EmptyElementList
		public event EmptyElementList_Callback EmptyElementList_Event;

		// event trigger associated with syntax rule EmptyElementList
		public bool Raise_EmptyElementList_Event (SyntaxTreeCallbackReason reason, EmptyElementList.production_kind kind, EmptyElementList p_EmptyElementList)
		{
			bool? status = EmptyElementList_Event?.Invoke (reason, kind, p_EmptyElementList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EmptyElementList
		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementList
		//

		public void Traverse (EmptyElementList p_EmptyElementList)
		{
			if (p_EmptyElementList.isLocked())
				return;
			if (Raise_EmptyElementList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (EmptyElementList.production_kind) p_EmptyElementList.kind, p_EmptyElementList))
				p_EmptyElementList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					EmptyElementList.production_kind kind = (EmptyElementList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_EmptyElementList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case EmptyElementList.production_kind.g_EmptyElementList_1:
								// traverse syntax tree node associated with production
								// EmptyElementList: EmptyElement

								if (Raise_EmptyElementList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_EmptyElement);
								node.turn_inc ();
								Raise_EmptyElementList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case EmptyElementList.production_kind.g_EmptyElementList_2:
								// traverse syntax tree node associated with production
								// EmptyElementList: EmptyElementList EmptyElement

								if (Raise_EmptyElementList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_EmptyElementList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_EmptyElement);
								node.turn_inc ();
								Raise_EmptyElementList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_EmptyElementList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_EmptyElementList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (EmptyElementList.production_kind) p_EmptyElementList.kind, p_EmptyElementList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementList
		//

		public void TraverseCommon (EmptyElementList p_EmptyElementList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_EmptyElementList.kind, p_EmptyElementList))
				p_EmptyElementList.Iterate (null, (node, appData) =>
				{
					EmptyElementList.production_kind kind = (EmptyElementList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case EmptyElementList.production_kind.g_EmptyElementList_1:
							// traverse syntax tree node associated with production
							// EmptyElementList: EmptyElement

							TraverseCommon (node.m_EmptyElement);
							break;
						case EmptyElementList.production_kind.g_EmptyElementList_2:
							// traverse syntax tree node associated with production
							// EmptyElementList: EmptyElementList EmptyElement

							TraverseCommon (node.m_EmptyElement);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_EmptyElementList.kind, p_EmptyElementList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EmptyElementList

		//
		// create syntax tree node associated with production
		// EmptyElementList: EmptyElement

		//

		public EmptyElementList EmptyElementList_1 (EmptyElement p_EmptyElement)
		{
			EmptyElementList p_EmptyElementList_ref = new EmptyElementList(p_EmptyElement);
			p_EmptyElement.parent = p_EmptyElementList_ref;
			Raise_EmptyElementList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EmptyElementList.production_kind.g_EmptyElementList_1, p_EmptyElementList_ref);
			return p_EmptyElementList_ref;
		}

		//
		// create syntax tree node associated with production
		// EmptyElementList: EmptyElementList EmptyElement

		//

		public EmptyElementList EmptyElementList_2 (EmptyElementList p_EmptyElementList, EmptyElement p_EmptyElement)
		{
			EmptyElementList p_EmptyElementList_ref = new EmptyElementList(p_EmptyElementList, p_EmptyElement);
			p_EmptyElementList.parent = p_EmptyElementList_ref;
			p_EmptyElement.parent = p_EmptyElementList_ref;
			Raise_EmptyElementList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EmptyElementList.production_kind.g_EmptyElementList_2, p_EmptyElementList_ref);
			return p_EmptyElementList_ref;
		}
		#endregion
	};
}
