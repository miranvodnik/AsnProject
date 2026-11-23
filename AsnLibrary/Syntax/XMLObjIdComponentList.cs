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
	// class associated with syntax rule XMLObjIdComponentList
	//

	[DataContract]
	public class	XMLObjIdComponentList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLObjIdComponentList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLObjIdComponentList
		{
			g_XMLObjIdComponentList_1 = 1,	// XMLObjIdComponent

			g_XMLObjIdComponentList_2 = 2,	// XMLObjIdComponentList "." XMLObjIdComponent

		};
		#endregion
		#region production markers associated with the syntax rule XMLObjIdComponentList

		// markers associated with production: XMLObjIdComponentList -> XMLObjIdComponent

		public enum production_marker_1 : ushort
		{
			m_XMLObjIdComponent,
			final
		};

		// markers associated with production: XMLObjIdComponentList -> XMLObjIdComponentList "." XMLObjIdComponent

		public enum production_marker_2 : ushort
		{
			m_XMLObjIdComponentList,
			m_XMLObjIdComponent,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLObjIdComponentList

		// Constructor declaration(s) associated with production(s) of syntax rule XMLObjIdComponentList

		//
		// Constructor associated with the following production(s)
		// XMLObjIdComponentList -> XMLObjIdComponent

		//

		public XMLObjIdComponentList (XMLObjIdComponent p_XMLObjIdComponent) : base ((uint) ProductionID._XMLObjIdComponentList_ID, (uint) production_kind.g_XMLObjIdComponentList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_XMLObjIdComponent = p_XMLObjIdComponent;
		}

		//
		// Constructor associated with the following production(s)
		// XMLObjIdComponentList -> XMLObjIdComponentList "." XMLObjIdComponent

		//

		public XMLObjIdComponentList (XMLObjIdComponentList p_XMLObjIdComponentList, SyntaxTreeToken p_token, XMLObjIdComponent p_XMLObjIdComponent) : base ((uint) ProductionID._XMLObjIdComponentList_ID, (uint) production_kind.g_XMLObjIdComponentList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_XMLObjIdComponentList = p_XMLObjIdComponentList;
			children[1] = m_dot = p_token;
			children[2] = m_XMLObjIdComponent = p_XMLObjIdComponent;
		}

		public XMLObjIdComponentList () { }

		// Copy constructor

		public XMLObjIdComponentList (XMLObjIdComponentList p_XMLObjIdComponentList) : base (p_XMLObjIdComponentList.id, p_XMLObjIdComponentList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLObjIdComponentList.appInfo;
			switch ((production_kind) p_XMLObjIdComponentList.kind)
			{
				case production_kind.g_XMLObjIdComponentList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_XMLObjIdComponent = (p_XMLObjIdComponentList.m_XMLObjIdComponent != null) ? new XMLObjIdComponent (p_XMLObjIdComponentList.m_XMLObjIdComponent) : null) != null) m_XMLObjIdComponent.parent = this;
					break;
				case production_kind.g_XMLObjIdComponentList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_XMLObjIdComponentList = (p_XMLObjIdComponentList.m_XMLObjIdComponentList != null) ? new XMLObjIdComponentList (p_XMLObjIdComponentList.m_XMLObjIdComponentList) : null) != null) m_XMLObjIdComponentList.parent = this;
					if ((children [1] = m_dot = (p_XMLObjIdComponentList.m_dot != null) ? new SyntaxTreeToken (p_XMLObjIdComponentList.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_XMLObjIdComponent = (p_XMLObjIdComponentList.m_XMLObjIdComponent != null) ? new XMLObjIdComponent (p_XMLObjIdComponentList.m_XMLObjIdComponent) : null) != null) m_XMLObjIdComponent.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLObjIdComponentList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLObjIdComponentList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_XMLObjIdComponent?.Dispose ();
				node.m_dot?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLObjIdComponentList

		// Content changing function(s) associated with production(s) of syntax rule XMLObjIdComponentList

		//
		// Content changing function associated with following production(s)
		// XMLObjIdComponentList -> XMLObjIdComponent

		//

		public void change(XMLObjIdComponent p_XMLObjIdComponent)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLObjIdComponentList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_XMLObjIdComponent = p_XMLObjIdComponent;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// XMLObjIdComponentList -> XMLObjIdComponentList "." XMLObjIdComponent

		//

		public void change(XMLObjIdComponentList p_XMLObjIdComponentList, SyntaxTreeToken p_token, XMLObjIdComponent p_XMLObjIdComponent)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLObjIdComponentList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_XMLObjIdComponentList = p_XMLObjIdComponentList;
			children [1] = m_dot = p_token;
			children [2] = m_XMLObjIdComponent = p_XMLObjIdComponent;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLObjIdComponentList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_XMLObjIdComponent != null) && node.m_XMLObjIdComponent.checkInclusion (element) ||
					(node.m_dot != null) && node.m_dot.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLObjIdComponentList

		//
		// emit production tree node associated with any production of syntax rule XMLObjIdComponentList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_XMLObjIdComponentList_1:
						// emit syntax tree node associated with production
						// XMLObjIdComponentList: XMLObjIdComponent

						s += " " + node.m_XMLObjIdComponent.Emit (depth - 1);
						break;
					case production_kind.g_XMLObjIdComponentList_2:
						// emit syntax tree node associated with production
						// XMLObjIdComponentList: XMLObjIdComponentList "." XMLObjIdComponent

						s += " " + node.m_dot.Emit (depth - 1);
						s += " " + node.m_XMLObjIdComponent.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLObjIdComponentList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "XMLObjIdComponentList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_XMLObjIdComponentList_1:
						// emit syntax tree node associated with production
						// XMLObjIdComponentList: XMLObjIdComponent

						str += node.m_XMLObjIdComponent.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_XMLObjIdComponentList_2:
						// emit syntax tree node associated with production
						// XMLObjIdComponentList: XMLObjIdComponentList "." XMLObjIdComponent

						str += ' ';
						str += "dot";
						str += ' ';
						str += node.m_XMLObjIdComponent.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLObjIdComponentList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLObjIdComponentList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					XMLObjIdComponentList.production_kind kind = (XMLObjIdComponentList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case XMLObjIdComponentList.production_kind.g_XMLObjIdComponentList_1:
							// traverse syntax tree node associated with production
							// XMLObjIdComponentList: XMLObjIdComponent

							node.m_XMLObjIdComponent.Visit (visitor, appData);
							break;
						case XMLObjIdComponentList.production_kind.g_XMLObjIdComponentList_2:
							// traverse syntax tree node associated with production
							// XMLObjIdComponentList: XMLObjIdComponentList "." XMLObjIdComponent

							node.m_dot.Visit (visitor, appData);
							node.m_XMLObjIdComponent.Visit (visitor, appData);
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
			for (XMLObjIdComponentList node = this; node != null; node = node.m_XMLObjIdComponentList)
			{
				node.parent = parent;
				node.m_XMLObjIdComponent?.reparent (parent);
				node.m_dot?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule XMLObjIdComponentList
		//

		public void _init ()
		{
			m_XMLObjIdComponent = null;
			m_XMLObjIdComponentList = null;
			m_dot = null;
		}

		public delegate object IteratorDelegate (XMLObjIdComponentList p_XMLObjIdComponentList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<XMLObjIdComponentList> stack = new Stack<XMLObjIdComponentList> ();
			XMLObjIdComponentList p_XMLObjIdComponentList;
			for (p_XMLObjIdComponentList = this; p_XMLObjIdComponentList != null; p_XMLObjIdComponentList = p_XMLObjIdComponentList.m_XMLObjIdComponentList)
				stack.Push (p_XMLObjIdComponentList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLObjIdComponentList

		// counter of all nodes associated with syntax rule XMLObjIdComponentList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLObjIdComponentList
		[DataMember (Name = "m_XMLObjIdComponent")] public XMLObjIdComponent m_XMLObjIdComponent { get; private set; }
		[DataMember (Name = "m_XMLObjIdComponentList")] public XMLObjIdComponentList m_XMLObjIdComponentList { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLObjIdComponentList

		// delegate function (callback) prototype associated with syntax rule XMLObjIdComponentList
		public delegate bool XMLObjIdComponentList_Callback (SyntaxTreeCallbackReason reason, XMLObjIdComponentList.production_kind kind, XMLObjIdComponentList p_XMLObjIdComponentList);

		// event associated with syntax rule XMLObjIdComponentList
		public event XMLObjIdComponentList_Callback XMLObjIdComponentList_Event;

		// event trigger associated with syntax rule XMLObjIdComponentList
		public bool Raise_XMLObjIdComponentList_Event (SyntaxTreeCallbackReason reason, XMLObjIdComponentList.production_kind kind, XMLObjIdComponentList p_XMLObjIdComponentList)
		{
			bool? status = XMLObjIdComponentList_Event?.Invoke (reason, kind, p_XMLObjIdComponentList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLObjIdComponentList
		//
		// traverse syntax tree node associated with any production of syntax rule XMLObjIdComponentList
		//

		public void Traverse (XMLObjIdComponentList p_XMLObjIdComponentList)
		{
			if (p_XMLObjIdComponentList.isLocked())
				return;
			if (Raise_XMLObjIdComponentList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (XMLObjIdComponentList.production_kind) p_XMLObjIdComponentList.kind, p_XMLObjIdComponentList))
				p_XMLObjIdComponentList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					XMLObjIdComponentList.production_kind kind = (XMLObjIdComponentList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_XMLObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case XMLObjIdComponentList.production_kind.g_XMLObjIdComponentList_1:
								// traverse syntax tree node associated with production
								// XMLObjIdComponentList: XMLObjIdComponent

								if (Raise_XMLObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_XMLObjIdComponent);
								node.turn_inc ();
								Raise_XMLObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case XMLObjIdComponentList.production_kind.g_XMLObjIdComponentList_2:
								// traverse syntax tree node associated with production
								// XMLObjIdComponentList: XMLObjIdComponentList "." XMLObjIdComponent

								if (Raise_XMLObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_XMLObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_XMLObjIdComponent);
								node.turn_inc ();
								Raise_XMLObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_XMLObjIdComponentList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_XMLObjIdComponentList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (XMLObjIdComponentList.production_kind) p_XMLObjIdComponentList.kind, p_XMLObjIdComponentList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLObjIdComponentList
		//

		public void TraverseCommon (XMLObjIdComponentList p_XMLObjIdComponentList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_XMLObjIdComponentList.kind, p_XMLObjIdComponentList))
				p_XMLObjIdComponentList.Iterate (null, (node, appData) =>
				{
					XMLObjIdComponentList.production_kind kind = (XMLObjIdComponentList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case XMLObjIdComponentList.production_kind.g_XMLObjIdComponentList_1:
							// traverse syntax tree node associated with production
							// XMLObjIdComponentList: XMLObjIdComponent

							TraverseCommon (node.m_XMLObjIdComponent);
							break;
						case XMLObjIdComponentList.production_kind.g_XMLObjIdComponentList_2:
							// traverse syntax tree node associated with production
							// XMLObjIdComponentList: XMLObjIdComponentList "." XMLObjIdComponent

							TraverseCommon (node.m_dot);
							TraverseCommon (node.m_XMLObjIdComponent);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_XMLObjIdComponentList.kind, p_XMLObjIdComponentList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLObjIdComponentList

		//
		// create syntax tree node associated with production
		// XMLObjIdComponentList: XMLObjIdComponent

		//

		public XMLObjIdComponentList XMLObjIdComponentList_1 (XMLObjIdComponent p_XMLObjIdComponent)
		{
			XMLObjIdComponentList p_XMLObjIdComponentList_ref = new XMLObjIdComponentList(p_XMLObjIdComponent);
			p_XMLObjIdComponent.parent = p_XMLObjIdComponentList_ref;
			Raise_XMLObjIdComponentList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLObjIdComponentList.production_kind.g_XMLObjIdComponentList_1, p_XMLObjIdComponentList_ref);
			return p_XMLObjIdComponentList_ref;
		}

		//
		// create syntax tree node associated with production
		// XMLObjIdComponentList: XMLObjIdComponentList "." XMLObjIdComponent

		//

		public XMLObjIdComponentList XMLObjIdComponentList_2 (XMLObjIdComponentList p_XMLObjIdComponentList, SyntaxTreeToken p_token, XMLObjIdComponent p_XMLObjIdComponent)
		{
			XMLObjIdComponentList p_XMLObjIdComponentList_ref = new XMLObjIdComponentList(p_XMLObjIdComponentList, p_token, p_XMLObjIdComponent);
			p_XMLObjIdComponentList.parent = p_XMLObjIdComponentList_ref;
			p_token.parent = p_XMLObjIdComponentList_ref;
			p_XMLObjIdComponent.parent = p_XMLObjIdComponentList_ref;
			Raise_XMLObjIdComponentList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLObjIdComponentList.production_kind.g_XMLObjIdComponentList_2, p_XMLObjIdComponentList_ref);
			return p_XMLObjIdComponentList_ref;
		}
		#endregion
	};
}
