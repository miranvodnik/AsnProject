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
	// class associated with syntax rule NamedNumberList
	//

	[DataContract]
	public class	NamedNumberList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NamedNumberList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NamedNumberList
		{
			g_NamedNumberList_1 = 1,	// NamedNumberItem

			g_NamedNumberList_2 = 2,	// NamedNumberList "," NamedNumberItem

		};
		#endregion
		#region production markers associated with the syntax rule NamedNumberList

		// markers associated with production: NamedNumberList -> NamedNumberItem

		public enum production_marker_1 : ushort
		{
			m_NamedNumberItem,
			final
		};

		// markers associated with production: NamedNumberList -> NamedNumberList "," NamedNumberItem

		public enum production_marker_2 : ushort
		{
			m_NamedNumberList,
			m_NamedNumberItem,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NamedNumberList

		// Constructor declaration(s) associated with production(s) of syntax rule NamedNumberList

		//
		// Constructor associated with the following production(s)
		// NamedNumberList -> NamedNumberItem

		//

		public NamedNumberList (NamedNumberItem p_NamedNumberItem) : base ((uint) ProductionID._NamedNumberList_ID, (uint) production_kind.g_NamedNumberList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NamedNumberItem = p_NamedNumberItem;
		}

		//
		// Constructor associated with the following production(s)
		// NamedNumberList -> NamedNumberList "," NamedNumberItem

		//

		public NamedNumberList (NamedNumberList p_NamedNumberList, SyntaxTreeToken p_token, NamedNumberItem p_NamedNumberItem) : base ((uint) ProductionID._NamedNumberList_ID, (uint) production_kind.g_NamedNumberList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_NamedNumberList = p_NamedNumberList;
			children[1] = m_comma = p_token;
			children[2] = m_NamedNumberItem = p_NamedNumberItem;
		}

		public NamedNumberList () { }

		// Copy constructor

		public NamedNumberList (NamedNumberList p_NamedNumberList) : base (p_NamedNumberList.id, p_NamedNumberList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NamedNumberList.appInfo;
			switch ((production_kind) p_NamedNumberList.kind)
			{
				case production_kind.g_NamedNumberList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NamedNumberItem = (p_NamedNumberList.m_NamedNumberItem != null) ? new NamedNumberItem (p_NamedNumberList.m_NamedNumberItem) : null) != null) m_NamedNumberItem.parent = this;
					break;
				case production_kind.g_NamedNumberList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_NamedNumberList = (p_NamedNumberList.m_NamedNumberList != null) ? new NamedNumberList (p_NamedNumberList.m_NamedNumberList) : null) != null) m_NamedNumberList.parent = this;
					if ((children [1] = m_comma = (p_NamedNumberList.m_comma != null) ? new SyntaxTreeToken (p_NamedNumberList.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_NamedNumberItem = (p_NamedNumberList.m_NamedNumberItem != null) ? new NamedNumberItem (p_NamedNumberList.m_NamedNumberItem) : null) != null) m_NamedNumberItem.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NamedNumberList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NamedNumberList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_NamedNumberItem?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NamedNumberList

		// Content changing function(s) associated with production(s) of syntax rule NamedNumberList

		//
		// Content changing function associated with following production(s)
		// NamedNumberList -> NamedNumberItem

		//

		public void change(NamedNumberItem p_NamedNumberItem)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedNumberList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NamedNumberItem = p_NamedNumberItem;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NamedNumberList -> NamedNumberList "," NamedNumberItem

		//

		public void change(NamedNumberList p_NamedNumberList, SyntaxTreeToken p_token, NamedNumberItem p_NamedNumberItem)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedNumberList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_NamedNumberList = p_NamedNumberList;
			children [1] = m_comma = p_token;
			children [2] = m_NamedNumberItem = p_NamedNumberItem;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NamedNumberList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_NamedNumberItem != null) && node.m_NamedNumberItem.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NamedNumberList

		//
		// emit production tree node associated with any production of syntax rule NamedNumberList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_NamedNumberList_1:
						// emit syntax tree node associated with production
						// NamedNumberList: NamedNumberItem

						s += " " + node.m_NamedNumberItem.Emit (depth - 1);
						break;
					case production_kind.g_NamedNumberList_2:
						// emit syntax tree node associated with production
						// NamedNumberList: NamedNumberList "," NamedNumberItem

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_NamedNumberItem.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NamedNumberList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "NamedNumberList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_NamedNumberList_1:
						// emit syntax tree node associated with production
						// NamedNumberList: NamedNumberItem

						str += node.m_NamedNumberItem.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_NamedNumberList_2:
						// emit syntax tree node associated with production
						// NamedNumberList: NamedNumberList "," NamedNumberItem

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_NamedNumberItem.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NamedNumberList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NamedNumberList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					NamedNumberList.production_kind kind = (NamedNumberList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case NamedNumberList.production_kind.g_NamedNumberList_1:
							// traverse syntax tree node associated with production
							// NamedNumberList: NamedNumberItem

							node.m_NamedNumberItem.Visit (visitor, appData);
							break;
						case NamedNumberList.production_kind.g_NamedNumberList_2:
							// traverse syntax tree node associated with production
							// NamedNumberList: NamedNumberList "," NamedNumberItem

							node.m_comma.Visit (visitor, appData);
							node.m_NamedNumberItem.Visit (visitor, appData);
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
			for (NamedNumberList node = this; node != null; node = node.m_NamedNumberList)
			{
				node.parent = parent;
				node.m_NamedNumberItem?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule NamedNumberList
		//

		public void _init ()
		{
			m_NamedNumberItem = null;
			m_NamedNumberList = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (NamedNumberList p_NamedNumberList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<NamedNumberList> stack = new Stack<NamedNumberList> ();
			NamedNumberList p_NamedNumberList;
			for (p_NamedNumberList = this; p_NamedNumberList != null; p_NamedNumberList = p_NamedNumberList.m_NamedNumberList)
				stack.Push (p_NamedNumberList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NamedNumberList

		// counter of all nodes associated with syntax rule NamedNumberList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NamedNumberList
		[DataMember (Name = "m_NamedNumberItem")] public NamedNumberItem m_NamedNumberItem { get; private set; }
		[DataMember (Name = "m_NamedNumberList")] public NamedNumberList m_NamedNumberList { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NamedNumberList

		// delegate function (callback) prototype associated with syntax rule NamedNumberList
		public delegate bool NamedNumberList_Callback (SyntaxTreeCallbackReason reason, NamedNumberList.production_kind kind, NamedNumberList p_NamedNumberList);

		// event associated with syntax rule NamedNumberList
		public event NamedNumberList_Callback NamedNumberList_Event;

		// event trigger associated with syntax rule NamedNumberList
		public bool Raise_NamedNumberList_Event (SyntaxTreeCallbackReason reason, NamedNumberList.production_kind kind, NamedNumberList p_NamedNumberList)
		{
			bool? status = NamedNumberList_Event?.Invoke (reason, kind, p_NamedNumberList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NamedNumberList
		//
		// traverse syntax tree node associated with any production of syntax rule NamedNumberList
		//

		public void Traverse (NamedNumberList p_NamedNumberList)
		{
			if (p_NamedNumberList.isLocked())
				return;
			if (Raise_NamedNumberList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (NamedNumberList.production_kind) p_NamedNumberList.kind, p_NamedNumberList))
				p_NamedNumberList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					NamedNumberList.production_kind kind = (NamedNumberList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_NamedNumberList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case NamedNumberList.production_kind.g_NamedNumberList_1:
								// traverse syntax tree node associated with production
								// NamedNumberList: NamedNumberItem

								if (Raise_NamedNumberList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NamedNumberItem);
								node.turn_inc ();
								Raise_NamedNumberList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case NamedNumberList.production_kind.g_NamedNumberList_2:
								// traverse syntax tree node associated with production
								// NamedNumberList: NamedNumberList "," NamedNumberItem

								if (Raise_NamedNumberList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_NamedNumberList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NamedNumberItem);
								node.turn_inc ();
								Raise_NamedNumberList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_NamedNumberList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_NamedNumberList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (NamedNumberList.production_kind) p_NamedNumberList.kind, p_NamedNumberList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NamedNumberList
		//

		public void TraverseCommon (NamedNumberList p_NamedNumberList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_NamedNumberList.kind, p_NamedNumberList))
				p_NamedNumberList.Iterate (null, (node, appData) =>
				{
					NamedNumberList.production_kind kind = (NamedNumberList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case NamedNumberList.production_kind.g_NamedNumberList_1:
							// traverse syntax tree node associated with production
							// NamedNumberList: NamedNumberItem

							TraverseCommon (node.m_NamedNumberItem);
							break;
						case NamedNumberList.production_kind.g_NamedNumberList_2:
							// traverse syntax tree node associated with production
							// NamedNumberList: NamedNumberList "," NamedNumberItem

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_NamedNumberItem);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_NamedNumberList.kind, p_NamedNumberList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NamedNumberList

		//
		// create syntax tree node associated with production
		// NamedNumberList: NamedNumberItem

		//

		public NamedNumberList NamedNumberList_1 (NamedNumberItem p_NamedNumberItem)
		{
			NamedNumberList p_NamedNumberList_ref = new NamedNumberList(p_NamedNumberItem);
			p_NamedNumberItem.parent = p_NamedNumberList_ref;
			Raise_NamedNumberList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedNumberList.production_kind.g_NamedNumberList_1, p_NamedNumberList_ref);
			return p_NamedNumberList_ref;
		}

		//
		// create syntax tree node associated with production
		// NamedNumberList: NamedNumberList "," NamedNumberItem

		//

		public NamedNumberList NamedNumberList_2 (NamedNumberList p_NamedNumberList, SyntaxTreeToken p_token, NamedNumberItem p_NamedNumberItem)
		{
			NamedNumberList p_NamedNumberList_ref = new NamedNumberList(p_NamedNumberList, p_token, p_NamedNumberItem);
			p_NamedNumberList.parent = p_NamedNumberList_ref;
			p_token.parent = p_NamedNumberList_ref;
			p_NamedNumberItem.parent = p_NamedNumberList_ref;
			Raise_NamedNumberList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedNumberList.production_kind.g_NamedNumberList_2, p_NamedNumberList_ref);
			return p_NamedNumberList_ref;
		}
		#endregion
	};
}
