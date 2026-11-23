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
	// class associated with syntax rule XMLDelimitedItemList
	//

	[DataContract]
	public class	XMLDelimitedItemList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLDelimitedItemList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLDelimitedItemList
		{
			g_XMLDelimitedItemList_1 = 1,	// XMLDelimitedItem

			g_XMLDelimitedItemList_2 = 2,	// XMLDelimitedItemList XMLDelimitedItem

		};
		#endregion
		#region production markers associated with the syntax rule XMLDelimitedItemList

		// markers associated with production: XMLDelimitedItemList -> XMLDelimitedItem

		public enum production_marker_1 : ushort
		{
			m_XMLDelimitedItem,
			final
		};

		// markers associated with production: XMLDelimitedItemList -> XMLDelimitedItemList XMLDelimitedItem

		public enum production_marker_2 : ushort
		{
			m_XMLDelimitedItemList,
			m_XMLDelimitedItem,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLDelimitedItemList

		// Constructor declaration(s) associated with production(s) of syntax rule XMLDelimitedItemList

		//
		// Constructor associated with the following production(s)
		// XMLDelimitedItemList -> XMLDelimitedItem

		//

		public XMLDelimitedItemList (XMLDelimitedItem p_XMLDelimitedItem) : base ((uint) ProductionID._XMLDelimitedItemList_ID, (uint) production_kind.g_XMLDelimitedItemList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLDelimitedItem = p_XMLDelimitedItem;
		}

		//
		// Constructor associated with the following production(s)
		// XMLDelimitedItemList -> XMLDelimitedItemList XMLDelimitedItem

		//

		public XMLDelimitedItemList (XMLDelimitedItemList p_XMLDelimitedItemList, XMLDelimitedItem p_XMLDelimitedItem) : base ((uint) ProductionID._XMLDelimitedItemList_ID, (uint) production_kind.g_XMLDelimitedItemList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_XMLDelimitedItemList = p_XMLDelimitedItemList;
			children[1] = m_XMLDelimitedItem = p_XMLDelimitedItem;
		}

		public XMLDelimitedItemList () { }

		// Copy constructor

		public XMLDelimitedItemList (XMLDelimitedItemList p_XMLDelimitedItemList) : base (p_XMLDelimitedItemList.id, p_XMLDelimitedItemList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLDelimitedItemList.appInfo;
			switch ((production_kind) p_XMLDelimitedItemList.kind)
			{
				case production_kind.g_XMLDelimitedItemList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLDelimitedItem = (p_XMLDelimitedItemList.m_XMLDelimitedItem != null) ? new XMLDelimitedItem (p_XMLDelimitedItemList.m_XMLDelimitedItem) : null) != null) m_XMLDelimitedItem.parent = this;
					break;
				case production_kind.g_XMLDelimitedItemList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_XMLDelimitedItemList = (p_XMLDelimitedItemList.m_XMLDelimitedItemList != null) ? new XMLDelimitedItemList (p_XMLDelimitedItemList.m_XMLDelimitedItemList) : null) != null) m_XMLDelimitedItemList.parent = this;
					if ((children [1] = m_XMLDelimitedItem = (p_XMLDelimitedItemList.m_XMLDelimitedItem != null) ? new XMLDelimitedItem (p_XMLDelimitedItemList.m_XMLDelimitedItem) : null) != null) m_XMLDelimitedItem.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLDelimitedItemList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLDelimitedItemList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_XMLDelimitedItem?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLDelimitedItemList

		// Content changing function(s) associated with production(s) of syntax rule XMLDelimitedItemList

		//
		// Content changing function associated with following production(s)
		// XMLDelimitedItemList -> XMLDelimitedItem

		//

		public void change(XMLDelimitedItem p_XMLDelimitedItem)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLDelimitedItemList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLDelimitedItem = p_XMLDelimitedItem;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLDelimitedItemList -> XMLDelimitedItemList XMLDelimitedItem

		//

		public void change(XMLDelimitedItemList p_XMLDelimitedItemList, XMLDelimitedItem p_XMLDelimitedItem)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLDelimitedItemList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_XMLDelimitedItemList = p_XMLDelimitedItemList;
			children [1] = m_XMLDelimitedItem = p_XMLDelimitedItem;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLDelimitedItemList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_XMLDelimitedItem != null) && node.m_XMLDelimitedItem.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLDelimitedItemList

		//
		// emit production tree node associated with any production of syntax rule XMLDelimitedItemList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_XMLDelimitedItemList_1:
						// emit syntax tree node associated with production
						// XMLDelimitedItemList: XMLDelimitedItem

						s += " " + node.m_XMLDelimitedItem.Emit (depth - 1);
						break;
					case production_kind.g_XMLDelimitedItemList_2:
						// emit syntax tree node associated with production
						// XMLDelimitedItemList: XMLDelimitedItemList XMLDelimitedItem

						s += " " + node.m_XMLDelimitedItem.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLDelimitedItemList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "XMLDelimitedItemList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_XMLDelimitedItemList_1:
						// emit syntax tree node associated with production
						// XMLDelimitedItemList: XMLDelimitedItem

						str += node.m_XMLDelimitedItem.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_XMLDelimitedItemList_2:
						// emit syntax tree node associated with production
						// XMLDelimitedItemList: XMLDelimitedItemList XMLDelimitedItem

						str += ' ';
						str += node.m_XMLDelimitedItem.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLDelimitedItemList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLDelimitedItemList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					XMLDelimitedItemList.production_kind kind = (XMLDelimitedItemList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case XMLDelimitedItemList.production_kind.g_XMLDelimitedItemList_1:
							// traverse syntax tree node associated with production
							// XMLDelimitedItemList: XMLDelimitedItem

							node.m_XMLDelimitedItem.Visit (visitor, appData);
							break;
						case XMLDelimitedItemList.production_kind.g_XMLDelimitedItemList_2:
							// traverse syntax tree node associated with production
							// XMLDelimitedItemList: XMLDelimitedItemList XMLDelimitedItem

							node.m_XMLDelimitedItem.Visit (visitor, appData);
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
			for (XMLDelimitedItemList node = this; node != null; node = node.m_XMLDelimitedItemList)
			{
				node.parent = parent;
				node.m_XMLDelimitedItem?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule XMLDelimitedItemList
		//

		public void _init ()
		{
			m_XMLDelimitedItem = null;
			m_XMLDelimitedItemList = null;
		}

		public delegate object IteratorDelegate (XMLDelimitedItemList p_XMLDelimitedItemList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<XMLDelimitedItemList> stack = new Stack<XMLDelimitedItemList> ();
			XMLDelimitedItemList p_XMLDelimitedItemList;
			for (p_XMLDelimitedItemList = this; p_XMLDelimitedItemList != null; p_XMLDelimitedItemList = p_XMLDelimitedItemList.m_XMLDelimitedItemList)
				stack.Push (p_XMLDelimitedItemList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLDelimitedItemList

		// counter of all nodes associated with syntax rule XMLDelimitedItemList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLDelimitedItemList
		[DataMember (Name = "m_XMLDelimitedItem")] public XMLDelimitedItem m_XMLDelimitedItem { get; private set; }
		[DataMember (Name = "m_XMLDelimitedItemList")] public XMLDelimitedItemList m_XMLDelimitedItemList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLDelimitedItemList

		// delegate function (callback) prototype associated with syntax rule XMLDelimitedItemList
		public delegate bool XMLDelimitedItemList_Callback (SyntaxTreeCallbackReason reason, XMLDelimitedItemList.production_kind kind, XMLDelimitedItemList p_XMLDelimitedItemList);

		// event associated with syntax rule XMLDelimitedItemList
		public event XMLDelimitedItemList_Callback XMLDelimitedItemList_Event;

		// event trigger associated with syntax rule XMLDelimitedItemList
		public bool Raise_XMLDelimitedItemList_Event (SyntaxTreeCallbackReason reason, XMLDelimitedItemList.production_kind kind, XMLDelimitedItemList p_XMLDelimitedItemList)
		{
			bool? status = XMLDelimitedItemList_Event?.Invoke (reason, kind, p_XMLDelimitedItemList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLDelimitedItemList
		//
		// traverse syntax tree node associated with any production of syntax rule XMLDelimitedItemList
		//

		public void Traverse (XMLDelimitedItemList p_XMLDelimitedItemList)
		{
			if (p_XMLDelimitedItemList.isLocked())
				return;
			if (Raise_XMLDelimitedItemList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (XMLDelimitedItemList.production_kind) p_XMLDelimitedItemList.kind, p_XMLDelimitedItemList))
				p_XMLDelimitedItemList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					XMLDelimitedItemList.production_kind kind = (XMLDelimitedItemList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_XMLDelimitedItemList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case XMLDelimitedItemList.production_kind.g_XMLDelimitedItemList_1:
								// traverse syntax tree node associated with production
								// XMLDelimitedItemList: XMLDelimitedItem

								if (Raise_XMLDelimitedItemList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_XMLDelimitedItem);
								node.turn_inc ();
								Raise_XMLDelimitedItemList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case XMLDelimitedItemList.production_kind.g_XMLDelimitedItemList_2:
								// traverse syntax tree node associated with production
								// XMLDelimitedItemList: XMLDelimitedItemList XMLDelimitedItem

								if (Raise_XMLDelimitedItemList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_XMLDelimitedItemList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_XMLDelimitedItem);
								node.turn_inc ();
								Raise_XMLDelimitedItemList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_XMLDelimitedItemList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_XMLDelimitedItemList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (XMLDelimitedItemList.production_kind) p_XMLDelimitedItemList.kind, p_XMLDelimitedItemList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLDelimitedItemList
		//

		public void TraverseCommon (XMLDelimitedItemList p_XMLDelimitedItemList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_XMLDelimitedItemList.kind, p_XMLDelimitedItemList))
				p_XMLDelimitedItemList.Iterate (null, (node, appData) =>
				{
					XMLDelimitedItemList.production_kind kind = (XMLDelimitedItemList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case XMLDelimitedItemList.production_kind.g_XMLDelimitedItemList_1:
							// traverse syntax tree node associated with production
							// XMLDelimitedItemList: XMLDelimitedItem

							TraverseCommon (node.m_XMLDelimitedItem);
							break;
						case XMLDelimitedItemList.production_kind.g_XMLDelimitedItemList_2:
							// traverse syntax tree node associated with production
							// XMLDelimitedItemList: XMLDelimitedItemList XMLDelimitedItem

							TraverseCommon (node.m_XMLDelimitedItem);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_XMLDelimitedItemList.kind, p_XMLDelimitedItemList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLDelimitedItemList

		//
		// create syntax tree node associated with production
		// XMLDelimitedItemList: XMLDelimitedItem

		//

		public XMLDelimitedItemList XMLDelimitedItemList_1 (XMLDelimitedItem p_XMLDelimitedItem)
		{
			XMLDelimitedItemList p_XMLDelimitedItemList_ref = new XMLDelimitedItemList(p_XMLDelimitedItem);
			p_XMLDelimitedItem.parent = p_XMLDelimitedItemList_ref;
			Raise_XMLDelimitedItemList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLDelimitedItemList.production_kind.g_XMLDelimitedItemList_1, p_XMLDelimitedItemList_ref);
			return p_XMLDelimitedItemList_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLDelimitedItemList: XMLDelimitedItemList XMLDelimitedItem

		//

		public XMLDelimitedItemList XMLDelimitedItemList_2 (XMLDelimitedItemList p_XMLDelimitedItemList, XMLDelimitedItem p_XMLDelimitedItem)
		{
			XMLDelimitedItemList p_XMLDelimitedItemList_ref = new XMLDelimitedItemList(p_XMLDelimitedItemList, p_XMLDelimitedItem);
			p_XMLDelimitedItemList.parent = p_XMLDelimitedItemList_ref;
			p_XMLDelimitedItem.parent = p_XMLDelimitedItemList_ref;
			Raise_XMLDelimitedItemList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLDelimitedItemList.production_kind.g_XMLDelimitedItemList_2, p_XMLDelimitedItemList_ref);
			return p_XMLDelimitedItemList_ref;
		}
		#endregion
	};
}
