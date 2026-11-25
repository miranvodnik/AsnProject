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
	// class associated with syntax rule XMLComponentValueList
	//

	[DataContract]
	public class	XMLComponentValueList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLComponentValueList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLComponentValueList
		{
			g_XMLComponentValueList_1 = 1,	// XMLNamedValue

			g_XMLComponentValueList_2 = 2,	// XMLComponentValueList XMLNamedValue

		};
		#endregion
		#region production markers associated with the syntax rule XMLComponentValueList

		// markers associated with production: XMLComponentValueList -> XMLNamedValue

		public enum production_marker_1 : ushort
		{
			m_XMLNamedValue,
			final
		};

		// markers associated with production: XMLComponentValueList -> XMLComponentValueList XMLNamedValue

		public enum production_marker_2 : ushort
		{
			m_XMLComponentValueList,
			m_XMLNamedValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLComponentValueList

		// Constructor declaration(s) associated with production(s) of syntax rule XMLComponentValueList

		//
		// Constructor associated with the following production(s)
		// XMLComponentValueList -> XMLNamedValue

		//

		public XMLComponentValueList (XMLNamedValue p_XMLNamedValue) : base ((uint) ProductionID._XMLComponentValueList_ID, (uint) production_kind.g_XMLComponentValueList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLNamedValue = p_XMLNamedValue;
		}

		//
		// Constructor associated with the following production(s)
		// XMLComponentValueList -> XMLComponentValueList XMLNamedValue

		//

		public XMLComponentValueList (XMLComponentValueList p_XMLComponentValueList, XMLNamedValue p_XMLNamedValue) : base ((uint) ProductionID._XMLComponentValueList_ID, (uint) production_kind.g_XMLComponentValueList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_XMLComponentValueList = p_XMLComponentValueList;
			children[1] = m_XMLNamedValue = p_XMLNamedValue;
		}

		public XMLComponentValueList () { }

		// Copy constructor

		public XMLComponentValueList (XMLComponentValueList p_XMLComponentValueList) : base (p_XMLComponentValueList.id, p_XMLComponentValueList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLComponentValueList.appInfo;
			switch ((production_kind) p_XMLComponentValueList.kind)
			{
				case production_kind.g_XMLComponentValueList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLNamedValue = (p_XMLComponentValueList.m_XMLNamedValue != null) ? new XMLNamedValue (p_XMLComponentValueList.m_XMLNamedValue) : null) != null) m_XMLNamedValue.parent = this;
					break;
				case production_kind.g_XMLComponentValueList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_XMLComponentValueList = (p_XMLComponentValueList.m_XMLComponentValueList != null) ? new XMLComponentValueList (p_XMLComponentValueList.m_XMLComponentValueList) : null) != null) m_XMLComponentValueList.parent = this;
					if ((children [1] = m_XMLNamedValue = (p_XMLComponentValueList.m_XMLNamedValue != null) ? new XMLNamedValue (p_XMLComponentValueList.m_XMLNamedValue) : null) != null) m_XMLNamedValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLComponentValueList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLComponentValueList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_XMLNamedValue?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLComponentValueList

		// Content changing function(s) associated with production(s) of syntax rule XMLComponentValueList

		//
		// Content changing function associated with following production(s)
		// XMLComponentValueList -> XMLNamedValue

		//

		public void change(XMLNamedValue p_XMLNamedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLComponentValueList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLNamedValue = p_XMLNamedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLComponentValueList -> XMLComponentValueList XMLNamedValue

		//

		public void change(XMLComponentValueList p_XMLComponentValueList, XMLNamedValue p_XMLNamedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLComponentValueList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_XMLComponentValueList = p_XMLComponentValueList;
			children [1] = m_XMLNamedValue = p_XMLNamedValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLComponentValueList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_XMLNamedValue != null) && node.m_XMLNamedValue.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLComponentValueList

		//
		// emit production tree node associated with any production of syntax rule XMLComponentValueList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_XMLComponentValueList_1:
						// emit syntax tree node associated with production
						// XMLComponentValueList: XMLNamedValue

						s += " " + node.m_XMLNamedValue.Emit (depth - 1);
						break;
					case production_kind.g_XMLComponentValueList_2:
						// emit syntax tree node associated with production
						// XMLComponentValueList: XMLComponentValueList XMLNamedValue

						s += " " + node.m_XMLNamedValue.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLComponentValueList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "XMLComponentValueList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_XMLComponentValueList_1:
						// emit syntax tree node associated with production
						// XMLComponentValueList: XMLNamedValue

						str += node.m_XMLNamedValue.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_XMLComponentValueList_2:
						// emit syntax tree node associated with production
						// XMLComponentValueList: XMLComponentValueList XMLNamedValue

						str += ' ';
						str += node.m_XMLNamedValue.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLComponentValueList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLComponentValueList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					XMLComponentValueList.production_kind kind = (XMLComponentValueList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case XMLComponentValueList.production_kind.g_XMLComponentValueList_1:
							// traverse syntax tree node associated with production
							// XMLComponentValueList: XMLNamedValue

							node.m_XMLNamedValue.Visit (visitor, appData);
							break;
						case XMLComponentValueList.production_kind.g_XMLComponentValueList_2:
							// traverse syntax tree node associated with production
							// XMLComponentValueList: XMLComponentValueList XMLNamedValue

							node.m_XMLNamedValue.Visit (visitor, appData);
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
			for (XMLComponentValueList node = this; node != null; node = node.m_XMLComponentValueList)
			{
				node.parent = parent;
				node.m_XMLNamedValue?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule XMLComponentValueList
		//

		public void _init ()
		{
			m_XMLNamedValue = null;
			m_XMLComponentValueList = null;
		}

		public delegate object IteratorDelegate (XMLComponentValueList p_XMLComponentValueList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<XMLComponentValueList> stack = new Stack<XMLComponentValueList> ();
			XMLComponentValueList p_XMLComponentValueList;
			for (p_XMLComponentValueList = this; p_XMLComponentValueList != null; p_XMLComponentValueList = p_XMLComponentValueList.m_XMLComponentValueList)
				stack.Push (p_XMLComponentValueList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLComponentValueList

		// counter of all nodes associated with syntax rule XMLComponentValueList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLComponentValueList
		[DataMember (Name = "m_XMLNamedValue")] public XMLNamedValue m_XMLNamedValue { get; private set; }
		[DataMember (Name = "m_XMLComponentValueList")] public XMLComponentValueList m_XMLComponentValueList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLComponentValueList

		// delegate function (callback) prototype associated with syntax rule XMLComponentValueList
		public delegate bool XMLComponentValueList_Callback (SyntaxTreeCallbackReason reason, XMLComponentValueList.production_kind kind, XMLComponentValueList p_XMLComponentValueList);

		// event associated with syntax rule XMLComponentValueList
		public event XMLComponentValueList_Callback XMLComponentValueList_Event;

		// event trigger associated with syntax rule XMLComponentValueList
		public bool Raise_XMLComponentValueList_Event (SyntaxTreeCallbackReason reason, XMLComponentValueList.production_kind kind, XMLComponentValueList p_XMLComponentValueList)
		{
			bool? status = XMLComponentValueList_Event?.Invoke (reason, kind, p_XMLComponentValueList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLComponentValueList
		//
		// traverse syntax tree node associated with any production of syntax rule XMLComponentValueList
		//

		public void Traverse (XMLComponentValueList p_XMLComponentValueList)
		{
			if (p_XMLComponentValueList.isLocked())
				return;
			if (Raise_XMLComponentValueList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (XMLComponentValueList.production_kind) p_XMLComponentValueList.kind, p_XMLComponentValueList))
				p_XMLComponentValueList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					XMLComponentValueList.production_kind kind = (XMLComponentValueList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_XMLComponentValueList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case XMLComponentValueList.production_kind.g_XMLComponentValueList_1:
								// traverse syntax tree node associated with production
								// XMLComponentValueList: XMLNamedValue

								if (Raise_XMLComponentValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_XMLNamedValue);
								node.turn_inc ();
								Raise_XMLComponentValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case XMLComponentValueList.production_kind.g_XMLComponentValueList_2:
								// traverse syntax tree node associated with production
								// XMLComponentValueList: XMLComponentValueList XMLNamedValue

								if (Raise_XMLComponentValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_XMLComponentValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_XMLNamedValue);
								node.turn_inc ();
								Raise_XMLComponentValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_XMLComponentValueList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_XMLComponentValueList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (XMLComponentValueList.production_kind) p_XMLComponentValueList.kind, p_XMLComponentValueList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLComponentValueList
		//

		public void TraverseCommon (XMLComponentValueList p_XMLComponentValueList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_XMLComponentValueList.kind, p_XMLComponentValueList))
				p_XMLComponentValueList.Iterate (null, (node, appData) =>
				{
					XMLComponentValueList.production_kind kind = (XMLComponentValueList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case XMLComponentValueList.production_kind.g_XMLComponentValueList_1:
							// traverse syntax tree node associated with production
							// XMLComponentValueList: XMLNamedValue

							TraverseCommon (node.m_XMLNamedValue);
							break;
						case XMLComponentValueList.production_kind.g_XMLComponentValueList_2:
							// traverse syntax tree node associated with production
							// XMLComponentValueList: XMLComponentValueList XMLNamedValue

							TraverseCommon (node.m_XMLNamedValue);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_XMLComponentValueList.kind, p_XMLComponentValueList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLComponentValueList

		//
		// create syntax tree node associated with production
		// XMLComponentValueList: XMLNamedValue

		//

		public XMLComponentValueList XMLComponentValueList_1 (XMLNamedValue p_XMLNamedValue)
		{
			XMLComponentValueList p_XMLComponentValueList_ref = new XMLComponentValueList(p_XMLNamedValue);
			p_XMLNamedValue.parent = p_XMLComponentValueList_ref;
			Raise_XMLComponentValueList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLComponentValueList.production_kind.g_XMLComponentValueList_1, p_XMLComponentValueList_ref);
			return p_XMLComponentValueList_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLComponentValueList: XMLComponentValueList XMLNamedValue

		//

		public XMLComponentValueList XMLComponentValueList_2 (XMLComponentValueList p_XMLComponentValueList, XMLNamedValue p_XMLNamedValue)
		{
			XMLComponentValueList p_XMLComponentValueList_ref = new XMLComponentValueList(p_XMLComponentValueList, p_XMLNamedValue);
			p_XMLComponentValueList.parent = p_XMLComponentValueList_ref;
			p_XMLNamedValue.parent = p_XMLComponentValueList_ref;
			Raise_XMLComponentValueList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLComponentValueList.production_kind.g_XMLComponentValueList_2, p_XMLComponentValueList_ref);
			return p_XMLComponentValueList_ref;
		}
		#endregion
	};
}
