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
	// class associated with syntax rule XMLRelativeOIDComponentList
	//

	[DataContract]
	public class	XMLRelativeOIDComponentList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLRelativeOIDComponentList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLRelativeOIDComponentList
		{
			g_XMLRelativeOIDComponentList_1 = 1,	// XMLRelativeOIDComponent

			g_XMLRelativeOIDComponentList_2 = 2,	// XMLRelativeOIDComponentList "." XMLRelativeOIDComponent Left

		};
		#endregion
		#region production markers associated with the syntax rule XMLRelativeOIDComponentList

		// markers associated with production: XMLRelativeOIDComponentList -> XMLRelativeOIDComponent

		public enum production_marker_1 : ushort
		{
			m_XMLRelativeOIDComponent,
			final
		};

		// markers associated with production: XMLRelativeOIDComponentList -> XMLRelativeOIDComponentList "." XMLRelativeOIDComponent Left

		public enum production_marker_2 : ushort
		{
			m_XMLRelativeOIDComponentList,
			m_XMLRelativeOIDComponent,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLRelativeOIDComponentList

		// Constructor declaration(s) associated with production(s) of syntax rule XMLRelativeOIDComponentList

		//
		// Constructor associated with the following production(s)
		// XMLRelativeOIDComponentList -> XMLRelativeOIDComponent

		//

		public XMLRelativeOIDComponentList (XMLRelativeOIDComponent p_XMLRelativeOIDComponent) : base ((uint) ProductionID._XMLRelativeOIDComponentList_ID, (uint) production_kind.g_XMLRelativeOIDComponentList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLRelativeOIDComponent = p_XMLRelativeOIDComponent;
		}

		//
		// Constructor associated with the following production(s)
		// XMLRelativeOIDComponentList -> XMLRelativeOIDComponentList "." XMLRelativeOIDComponent Left

		//

		public XMLRelativeOIDComponentList (XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList, SyntaxTreeToken p_token, XMLRelativeOIDComponent p_XMLRelativeOIDComponent) : base ((uint) ProductionID._XMLRelativeOIDComponentList_ID, (uint) production_kind.g_XMLRelativeOIDComponentList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_XMLRelativeOIDComponentList = p_XMLRelativeOIDComponentList;
			children[1] = m_dot = p_token;
			children[2] = m_XMLRelativeOIDComponent = p_XMLRelativeOIDComponent;
		}

		public XMLRelativeOIDComponentList () { }

		// Copy constructor

		public XMLRelativeOIDComponentList (XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList) : base (p_XMLRelativeOIDComponentList.id, p_XMLRelativeOIDComponentList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLRelativeOIDComponentList.appInfo;
			switch ((production_kind) p_XMLRelativeOIDComponentList.kind)
			{
				case production_kind.g_XMLRelativeOIDComponentList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLRelativeOIDComponent = (p_XMLRelativeOIDComponentList.m_XMLRelativeOIDComponent != null) ? new XMLRelativeOIDComponent (p_XMLRelativeOIDComponentList.m_XMLRelativeOIDComponent) : null) != null) m_XMLRelativeOIDComponent.parent = this;
					break;
				case production_kind.g_XMLRelativeOIDComponentList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_XMLRelativeOIDComponentList = (p_XMLRelativeOIDComponentList.m_XMLRelativeOIDComponentList != null) ? new XMLRelativeOIDComponentList (p_XMLRelativeOIDComponentList.m_XMLRelativeOIDComponentList) : null) != null) m_XMLRelativeOIDComponentList.parent = this;
					if ((children [1] = m_dot = (p_XMLRelativeOIDComponentList.m_dot != null) ? new SyntaxTreeToken (p_XMLRelativeOIDComponentList.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_XMLRelativeOIDComponent = (p_XMLRelativeOIDComponentList.m_XMLRelativeOIDComponent != null) ? new XMLRelativeOIDComponent (p_XMLRelativeOIDComponentList.m_XMLRelativeOIDComponent) : null) != null) m_XMLRelativeOIDComponent.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLRelativeOIDComponentList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLRelativeOIDComponentList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_XMLRelativeOIDComponent?.Dispose ();
				node.m_dot?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLRelativeOIDComponentList

		// Content changing function(s) associated with production(s) of syntax rule XMLRelativeOIDComponentList

		//
		// Content changing function associated with following production(s)
		// XMLRelativeOIDComponentList -> XMLRelativeOIDComponent

		//

		public void change(XMLRelativeOIDComponent p_XMLRelativeOIDComponent)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLRelativeOIDComponentList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLRelativeOIDComponent = p_XMLRelativeOIDComponent;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLRelativeOIDComponentList -> XMLRelativeOIDComponentList "." XMLRelativeOIDComponent Left

		//

		public void change(XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList, SyntaxTreeToken p_token, XMLRelativeOIDComponent p_XMLRelativeOIDComponent)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLRelativeOIDComponentList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_XMLRelativeOIDComponentList = p_XMLRelativeOIDComponentList;
			children [1] = m_dot = p_token;
			children [2] = m_XMLRelativeOIDComponent = p_XMLRelativeOIDComponent;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLRelativeOIDComponentList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_XMLRelativeOIDComponent != null) && node.m_XMLRelativeOIDComponent.checkInclusion (element) ||
					(node.m_dot != null) && node.m_dot.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLRelativeOIDComponentList

		//
		// emit production tree node associated with any production of syntax rule XMLRelativeOIDComponentList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_XMLRelativeOIDComponentList_1:
						// emit syntax tree node associated with production
						// XMLRelativeOIDComponentList: XMLRelativeOIDComponent

						s += " " + node.m_XMLRelativeOIDComponent.Emit (depth - 1);
						break;
					case production_kind.g_XMLRelativeOIDComponentList_2:
						// emit syntax tree node associated with production
						// XMLRelativeOIDComponentList: XMLRelativeOIDComponentList "." XMLRelativeOIDComponent Left

						s += " " + node.m_dot.Emit (depth - 1);
						s += " " + node.m_XMLRelativeOIDComponent.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLRelativeOIDComponentList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "XMLRelativeOIDComponentList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_XMLRelativeOIDComponentList_1:
						// emit syntax tree node associated with production
						// XMLRelativeOIDComponentList: XMLRelativeOIDComponent

						str += node.m_XMLRelativeOIDComponent.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_XMLRelativeOIDComponentList_2:
						// emit syntax tree node associated with production
						// XMLRelativeOIDComponentList: XMLRelativeOIDComponentList "." XMLRelativeOIDComponent Left

						str += ' ';
						str += "dot";
						str += ' ';
						str += node.m_XMLRelativeOIDComponent.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLRelativeOIDComponentList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLRelativeOIDComponentList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					XMLRelativeOIDComponentList.production_kind kind = (XMLRelativeOIDComponentList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case XMLRelativeOIDComponentList.production_kind.g_XMLRelativeOIDComponentList_1:
							// traverse syntax tree node associated with production
							// XMLRelativeOIDComponentList: XMLRelativeOIDComponent

							node.m_XMLRelativeOIDComponent.Visit (visitor, appData);
							break;
						case XMLRelativeOIDComponentList.production_kind.g_XMLRelativeOIDComponentList_2:
							// traverse syntax tree node associated with production
							// XMLRelativeOIDComponentList: XMLRelativeOIDComponentList "." XMLRelativeOIDComponent Left

							node.m_dot.Visit (visitor, appData);
							node.m_XMLRelativeOIDComponent.Visit (visitor, appData);
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
			for (XMLRelativeOIDComponentList node = this; node != null; node = node.m_XMLRelativeOIDComponentList)
			{
				node.parent = parent;
				node.m_XMLRelativeOIDComponent?.reparent (parent);
				node.m_dot?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule XMLRelativeOIDComponentList
		//

		public void _init ()
		{
			m_XMLRelativeOIDComponent = null;
			m_XMLRelativeOIDComponentList = null;
			m_dot = null;
		}

		public delegate object IteratorDelegate (XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<XMLRelativeOIDComponentList> stack = new Stack<XMLRelativeOIDComponentList> ();
			XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList;
			for (p_XMLRelativeOIDComponentList = this; p_XMLRelativeOIDComponentList != null; p_XMLRelativeOIDComponentList = p_XMLRelativeOIDComponentList.m_XMLRelativeOIDComponentList)
				stack.Push (p_XMLRelativeOIDComponentList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLRelativeOIDComponentList

		// counter of all nodes associated with syntax rule XMLRelativeOIDComponentList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLRelativeOIDComponentList
		[DataMember (Name = "m_XMLRelativeOIDComponent")] public XMLRelativeOIDComponent m_XMLRelativeOIDComponent { get; private set; }
		[DataMember (Name = "m_XMLRelativeOIDComponentList")] public XMLRelativeOIDComponentList m_XMLRelativeOIDComponentList { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLRelativeOIDComponentList

		// delegate function (callback) prototype associated with syntax rule XMLRelativeOIDComponentList
		public delegate bool XMLRelativeOIDComponentList_Callback (SyntaxTreeCallbackReason reason, XMLRelativeOIDComponentList.production_kind kind, XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList);

		// event associated with syntax rule XMLRelativeOIDComponentList
		public event XMLRelativeOIDComponentList_Callback XMLRelativeOIDComponentList_Event;

		// event trigger associated with syntax rule XMLRelativeOIDComponentList
		public bool Raise_XMLRelativeOIDComponentList_Event (SyntaxTreeCallbackReason reason, XMLRelativeOIDComponentList.production_kind kind, XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList)
		{
			bool? status = XMLRelativeOIDComponentList_Event?.Invoke (reason, kind, p_XMLRelativeOIDComponentList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLRelativeOIDComponentList
		//
		// traverse syntax tree node associated with any production of syntax rule XMLRelativeOIDComponentList
		//

		public void Traverse (XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList)
		{
			if (p_XMLRelativeOIDComponentList.isLocked())
				return;
			if (Raise_XMLRelativeOIDComponentList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (XMLRelativeOIDComponentList.production_kind) p_XMLRelativeOIDComponentList.kind, p_XMLRelativeOIDComponentList))
				p_XMLRelativeOIDComponentList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					XMLRelativeOIDComponentList.production_kind kind = (XMLRelativeOIDComponentList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_XMLRelativeOIDComponentList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case XMLRelativeOIDComponentList.production_kind.g_XMLRelativeOIDComponentList_1:
								// traverse syntax tree node associated with production
								// XMLRelativeOIDComponentList: XMLRelativeOIDComponent

								if (Raise_XMLRelativeOIDComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_XMLRelativeOIDComponent);
								node.turn_inc ();
								Raise_XMLRelativeOIDComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case XMLRelativeOIDComponentList.production_kind.g_XMLRelativeOIDComponentList_2:
								// traverse syntax tree node associated with production
								// XMLRelativeOIDComponentList: XMLRelativeOIDComponentList "." XMLRelativeOIDComponent Left

								if (Raise_XMLRelativeOIDComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_XMLRelativeOIDComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_XMLRelativeOIDComponent);
								node.turn_inc ();
								Raise_XMLRelativeOIDComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_XMLRelativeOIDComponentList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_XMLRelativeOIDComponentList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (XMLRelativeOIDComponentList.production_kind) p_XMLRelativeOIDComponentList.kind, p_XMLRelativeOIDComponentList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLRelativeOIDComponentList
		//

		public void TraverseCommon (XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_XMLRelativeOIDComponentList.kind, p_XMLRelativeOIDComponentList))
				p_XMLRelativeOIDComponentList.Iterate (null, (node, appData) =>
				{
					XMLRelativeOIDComponentList.production_kind kind = (XMLRelativeOIDComponentList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case XMLRelativeOIDComponentList.production_kind.g_XMLRelativeOIDComponentList_1:
							// traverse syntax tree node associated with production
							// XMLRelativeOIDComponentList: XMLRelativeOIDComponent

							TraverseCommon (node.m_XMLRelativeOIDComponent);
							break;
						case XMLRelativeOIDComponentList.production_kind.g_XMLRelativeOIDComponentList_2:
							// traverse syntax tree node associated with production
							// XMLRelativeOIDComponentList: XMLRelativeOIDComponentList "." XMLRelativeOIDComponent Left

							TraverseCommon (node.m_dot);
							TraverseCommon (node.m_XMLRelativeOIDComponent);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_XMLRelativeOIDComponentList.kind, p_XMLRelativeOIDComponentList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLRelativeOIDComponentList

		//
		// create syntax tree node associated with production
		// XMLRelativeOIDComponentList: XMLRelativeOIDComponent

		//

		public XMLRelativeOIDComponentList XMLRelativeOIDComponentList_1 (XMLRelativeOIDComponent p_XMLRelativeOIDComponent)
		{
			XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList_ref = new XMLRelativeOIDComponentList(p_XMLRelativeOIDComponent);
			p_XMLRelativeOIDComponent.parent = p_XMLRelativeOIDComponentList_ref;
			Raise_XMLRelativeOIDComponentList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLRelativeOIDComponentList.production_kind.g_XMLRelativeOIDComponentList_1, p_XMLRelativeOIDComponentList_ref);
			return p_XMLRelativeOIDComponentList_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLRelativeOIDComponentList: XMLRelativeOIDComponentList "." XMLRelativeOIDComponent Left

		//

		public XMLRelativeOIDComponentList XMLRelativeOIDComponentList_2 (XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList, SyntaxTreeToken p_token, XMLRelativeOIDComponent p_XMLRelativeOIDComponent)
		{
			XMLRelativeOIDComponentList p_XMLRelativeOIDComponentList_ref = new XMLRelativeOIDComponentList(p_XMLRelativeOIDComponentList, p_token, p_XMLRelativeOIDComponent);
			p_XMLRelativeOIDComponentList.parent = p_XMLRelativeOIDComponentList_ref;
			p_token.parent = p_XMLRelativeOIDComponentList_ref;
			p_XMLRelativeOIDComponent.parent = p_XMLRelativeOIDComponentList_ref;
			Raise_XMLRelativeOIDComponentList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLRelativeOIDComponentList.production_kind.g_XMLRelativeOIDComponentList_2, p_XMLRelativeOIDComponentList_ref);
			return p_XMLRelativeOIDComponentList_ref;
		}
		#endregion
	};
}
