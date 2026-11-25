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
	// class associated with syntax rule XMLValueList
	//

	[DataContract]
	public class	XMLValueList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLValueList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLValueList
		{
			g_XMLValueList_1 = 1,	// XMLValueOrEmpty

			g_XMLValueList_2 = 2,	// XMLValueList XMLValueOrEmpty

		};
		#endregion
		#region production markers associated with the syntax rule XMLValueList

		// markers associated with production: XMLValueList -> XMLValueOrEmpty

		public enum production_marker_1 : ushort
		{
			m_XMLValueOrEmpty,
			final
		};

		// markers associated with production: XMLValueList -> XMLValueList XMLValueOrEmpty

		public enum production_marker_2 : ushort
		{
			m_XMLValueList,
			m_XMLValueOrEmpty,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLValueList

		// Constructor declaration(s) associated with production(s) of syntax rule XMLValueList

		//
		// Constructor associated with the following production(s)
		// XMLValueList -> XMLValueOrEmpty

		//

		public XMLValueList (XMLValueOrEmpty p_XMLValueOrEmpty) : base ((uint) ProductionID._XMLValueList_ID, (uint) production_kind.g_XMLValueList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLValueOrEmpty = p_XMLValueOrEmpty;
		}

		//
		// Constructor associated with the following production(s)
		// XMLValueList -> XMLValueList XMLValueOrEmpty

		//

		public XMLValueList (XMLValueList p_XMLValueList, XMLValueOrEmpty p_XMLValueOrEmpty) : base ((uint) ProductionID._XMLValueList_ID, (uint) production_kind.g_XMLValueList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_XMLValueList = p_XMLValueList;
			children[1] = m_XMLValueOrEmpty = p_XMLValueOrEmpty;
		}

		public XMLValueList () { }

		// Copy constructor

		public XMLValueList (XMLValueList p_XMLValueList) : base (p_XMLValueList.id, p_XMLValueList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLValueList.appInfo;
			switch ((production_kind) p_XMLValueList.kind)
			{
				case production_kind.g_XMLValueList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLValueOrEmpty = (p_XMLValueList.m_XMLValueOrEmpty != null) ? new XMLValueOrEmpty (p_XMLValueList.m_XMLValueOrEmpty) : null) != null) m_XMLValueOrEmpty.parent = this;
					break;
				case production_kind.g_XMLValueList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_XMLValueList = (p_XMLValueList.m_XMLValueList != null) ? new XMLValueList (p_XMLValueList.m_XMLValueList) : null) != null) m_XMLValueList.parent = this;
					if ((children [1] = m_XMLValueOrEmpty = (p_XMLValueList.m_XMLValueOrEmpty != null) ? new XMLValueOrEmpty (p_XMLValueList.m_XMLValueOrEmpty) : null) != null) m_XMLValueOrEmpty.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLValueList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLValueList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_XMLValueOrEmpty?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLValueList

		// Content changing function(s) associated with production(s) of syntax rule XMLValueList

		//
		// Content changing function associated with following production(s)
		// XMLValueList -> XMLValueOrEmpty

		//

		public void change(XMLValueOrEmpty p_XMLValueOrEmpty)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLValueList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLValueOrEmpty = p_XMLValueOrEmpty;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLValueList -> XMLValueList XMLValueOrEmpty

		//

		public void change(XMLValueList p_XMLValueList, XMLValueOrEmpty p_XMLValueOrEmpty)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLValueList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_XMLValueList = p_XMLValueList;
			children [1] = m_XMLValueOrEmpty = p_XMLValueOrEmpty;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLValueList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_XMLValueOrEmpty != null) && node.m_XMLValueOrEmpty.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLValueList

		//
		// emit production tree node associated with any production of syntax rule XMLValueList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_XMLValueList_1:
						// emit syntax tree node associated with production
						// XMLValueList: XMLValueOrEmpty

						s += " " + node.m_XMLValueOrEmpty.Emit (depth - 1);
						break;
					case production_kind.g_XMLValueList_2:
						// emit syntax tree node associated with production
						// XMLValueList: XMLValueList XMLValueOrEmpty

						s += " " + node.m_XMLValueOrEmpty.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLValueList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "XMLValueList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_XMLValueList_1:
						// emit syntax tree node associated with production
						// XMLValueList: XMLValueOrEmpty

						str += node.m_XMLValueOrEmpty.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_XMLValueList_2:
						// emit syntax tree node associated with production
						// XMLValueList: XMLValueList XMLValueOrEmpty

						str += ' ';
						str += node.m_XMLValueOrEmpty.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLValueList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLValueList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					XMLValueList.production_kind kind = (XMLValueList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case XMLValueList.production_kind.g_XMLValueList_1:
							// traverse syntax tree node associated with production
							// XMLValueList: XMLValueOrEmpty

							node.m_XMLValueOrEmpty.Visit (visitor, appData);
							break;
						case XMLValueList.production_kind.g_XMLValueList_2:
							// traverse syntax tree node associated with production
							// XMLValueList: XMLValueList XMLValueOrEmpty

							node.m_XMLValueOrEmpty.Visit (visitor, appData);
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
			for (XMLValueList node = this; node != null; node = node.m_XMLValueList)
			{
				node.parent = parent;
				node.m_XMLValueOrEmpty?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule XMLValueList
		//

		public void _init ()
		{
			m_XMLValueOrEmpty = null;
			m_XMLValueList = null;
		}

		public delegate object IteratorDelegate (XMLValueList p_XMLValueList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<XMLValueList> stack = new Stack<XMLValueList> ();
			XMLValueList p_XMLValueList;
			for (p_XMLValueList = this; p_XMLValueList != null; p_XMLValueList = p_XMLValueList.m_XMLValueList)
				stack.Push (p_XMLValueList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLValueList

		// counter of all nodes associated with syntax rule XMLValueList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLValueList
		[DataMember (Name = "m_XMLValueOrEmpty")] public XMLValueOrEmpty m_XMLValueOrEmpty { get; private set; }
		[DataMember (Name = "m_XMLValueList")] public XMLValueList m_XMLValueList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLValueList

		// delegate function (callback) prototype associated with syntax rule XMLValueList
		public delegate bool XMLValueList_Callback (SyntaxTreeCallbackReason reason, XMLValueList.production_kind kind, XMLValueList p_XMLValueList);

		// event associated with syntax rule XMLValueList
		public event XMLValueList_Callback XMLValueList_Event;

		// event trigger associated with syntax rule XMLValueList
		public bool Raise_XMLValueList_Event (SyntaxTreeCallbackReason reason, XMLValueList.production_kind kind, XMLValueList p_XMLValueList)
		{
			bool? status = XMLValueList_Event?.Invoke (reason, kind, p_XMLValueList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLValueList
		//
		// traverse syntax tree node associated with any production of syntax rule XMLValueList
		//

		public void Traverse (XMLValueList p_XMLValueList)
		{
			if (p_XMLValueList.isLocked())
				return;
			if (Raise_XMLValueList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (XMLValueList.production_kind) p_XMLValueList.kind, p_XMLValueList))
				p_XMLValueList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					XMLValueList.production_kind kind = (XMLValueList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_XMLValueList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case XMLValueList.production_kind.g_XMLValueList_1:
								// traverse syntax tree node associated with production
								// XMLValueList: XMLValueOrEmpty

								if (Raise_XMLValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_XMLValueOrEmpty);
								node.turn_inc ();
								Raise_XMLValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case XMLValueList.production_kind.g_XMLValueList_2:
								// traverse syntax tree node associated with production
								// XMLValueList: XMLValueList XMLValueOrEmpty

								if (Raise_XMLValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_XMLValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_XMLValueOrEmpty);
								node.turn_inc ();
								Raise_XMLValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_XMLValueList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_XMLValueList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (XMLValueList.production_kind) p_XMLValueList.kind, p_XMLValueList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLValueList
		//

		public void TraverseCommon (XMLValueList p_XMLValueList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_XMLValueList.kind, p_XMLValueList))
				p_XMLValueList.Iterate (null, (node, appData) =>
				{
					XMLValueList.production_kind kind = (XMLValueList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case XMLValueList.production_kind.g_XMLValueList_1:
							// traverse syntax tree node associated with production
							// XMLValueList: XMLValueOrEmpty

							TraverseCommon (node.m_XMLValueOrEmpty);
							break;
						case XMLValueList.production_kind.g_XMLValueList_2:
							// traverse syntax tree node associated with production
							// XMLValueList: XMLValueList XMLValueOrEmpty

							TraverseCommon (node.m_XMLValueOrEmpty);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_XMLValueList.kind, p_XMLValueList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLValueList

		//
		// create syntax tree node associated with production
		// XMLValueList: XMLValueOrEmpty

		//

		public XMLValueList XMLValueList_1 (XMLValueOrEmpty p_XMLValueOrEmpty)
		{
			XMLValueList p_XMLValueList_ref = new XMLValueList(p_XMLValueOrEmpty);
			p_XMLValueOrEmpty.parent = p_XMLValueList_ref;
			Raise_XMLValueList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLValueList.production_kind.g_XMLValueList_1, p_XMLValueList_ref);
			return p_XMLValueList_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLValueList: XMLValueList XMLValueOrEmpty

		//

		public XMLValueList XMLValueList_2 (XMLValueList p_XMLValueList, XMLValueOrEmpty p_XMLValueOrEmpty)
		{
			XMLValueList p_XMLValueList_ref = new XMLValueList(p_XMLValueList, p_XMLValueOrEmpty);
			p_XMLValueList.parent = p_XMLValueList_ref;
			p_XMLValueOrEmpty.parent = p_XMLValueList_ref;
			Raise_XMLValueList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLValueList.production_kind.g_XMLValueList_2, p_XMLValueList_ref);
			return p_XMLValueList_ref;
		}
		#endregion
	};
}
