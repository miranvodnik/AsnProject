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
	// class associated with syntax rule ComponentIdList
	//

	[DataContract]
	public class	ComponentIdList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ComponentIdList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ComponentIdList
		{
			g_ComponentIdList_1 = 1,	// identifier-token

			g_ComponentIdList_2 = 2,	// ComponentIdList "." identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule ComponentIdList

		// markers associated with production: ComponentIdList -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};

		// markers associated with production: ComponentIdList -> ComponentIdList "." identifier-token

		public enum production_marker_2 : ushort
		{
			m_ComponentIdList,
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ComponentIdList

		// Constructor declaration(s) associated with production(s) of syntax rule ComponentIdList

		//
		// Constructor associated with the following production(s)
		// ComponentIdList -> identifier-token

		//

		public ComponentIdList (identifier_token p_identifier_token) : base ((uint) ProductionID._ComponentIdList_ID, (uint) production_kind.g_ComponentIdList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		//
		// Constructor associated with the following production(s)
		// ComponentIdList -> ComponentIdList "." identifier-token

		//

		public ComponentIdList (ComponentIdList p_ComponentIdList, SyntaxTreeToken p_token, identifier_token p_identifier_token) : base ((uint) ProductionID._ComponentIdList_ID, (uint) production_kind.g_ComponentIdList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ComponentIdList = p_ComponentIdList;
			children[1] = m_dot = p_token;
			children[2] = m_identifier_token = p_identifier_token;
		}

		public ComponentIdList () { }

		// Copy constructor

		public ComponentIdList (ComponentIdList p_ComponentIdList) : base (p_ComponentIdList.id, p_ComponentIdList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ComponentIdList.appInfo;
			switch ((production_kind) p_ComponentIdList.kind)
			{
				case production_kind.g_ComponentIdList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_ComponentIdList.m_identifier_token != null) ? new identifier_token (p_ComponentIdList.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				case production_kind.g_ComponentIdList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ComponentIdList = (p_ComponentIdList.m_ComponentIdList != null) ? new ComponentIdList (p_ComponentIdList.m_ComponentIdList) : null) != null) m_ComponentIdList.parent = this;
					if ((children [1] = m_dot = (p_ComponentIdList.m_dot != null) ? new SyntaxTreeToken (p_ComponentIdList.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_identifier_token = (p_ComponentIdList.m_identifier_token != null) ? new identifier_token (p_ComponentIdList.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ComponentIdList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ComponentIdList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_identifier_token?.Dispose ();
				node.m_dot?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ComponentIdList

		// Content changing function(s) associated with production(s) of syntax rule ComponentIdList

		//
		// Content changing function associated with following production(s)
		// ComponentIdList -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentIdList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ComponentIdList -> ComponentIdList "." identifier-token

		//

		public void change(ComponentIdList p_ComponentIdList, SyntaxTreeToken p_token, identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentIdList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ComponentIdList = p_ComponentIdList;
			children [1] = m_dot = p_token;
			children [2] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ComponentIdList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_identifier_token != null) && node.m_identifier_token.checkInclusion (element) ||
					(node.m_dot != null) && node.m_dot.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ComponentIdList

		//
		// emit production tree node associated with any production of syntax rule ComponentIdList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ComponentIdList_1:
						// emit syntax tree node associated with production
						// ComponentIdList: identifier-token

						s += " " + node.m_identifier_token.Emit (depth - 1);
						break;
					case production_kind.g_ComponentIdList_2:
						// emit syntax tree node associated with production
						// ComponentIdList: ComponentIdList "." identifier-token

						s += " " + node.m_dot.Emit (depth - 1);
						s += " " + node.m_identifier_token.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ComponentIdList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "ComponentIdList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ComponentIdList_1:
						// emit syntax tree node associated with production
						// ComponentIdList: identifier-token

						str += node.m_identifier_token.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_ComponentIdList_2:
						// emit syntax tree node associated with production
						// ComponentIdList: ComponentIdList "." identifier-token

						str += ' ';
						str += "dot";
						str += ' ';
						str += node.m_identifier_token.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ComponentIdList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentIdList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					ComponentIdList.production_kind kind = (ComponentIdList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case ComponentIdList.production_kind.g_ComponentIdList_1:
							// traverse syntax tree node associated with production
							// ComponentIdList: identifier-token

							node.m_identifier_token.Visit (visitor, appData);
							break;
						case ComponentIdList.production_kind.g_ComponentIdList_2:
							// traverse syntax tree node associated with production
							// ComponentIdList: ComponentIdList "." identifier-token

							node.m_dot.Visit (visitor, appData);
							node.m_identifier_token.Visit (visitor, appData);
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
			for (ComponentIdList node = this; node != null; node = node.m_ComponentIdList)
			{
				node.parent = parent;
				node.m_identifier_token?.reparent (parent);
				node.m_dot?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule ComponentIdList
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_ComponentIdList = null;
			m_dot = null;
		}

		public delegate object IteratorDelegate (ComponentIdList p_ComponentIdList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<ComponentIdList> stack = new Stack<ComponentIdList> ();
			ComponentIdList p_ComponentIdList;
			for (p_ComponentIdList = this; p_ComponentIdList != null; p_ComponentIdList = p_ComponentIdList.m_ComponentIdList)
				stack.Push (p_ComponentIdList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ComponentIdList

		// counter of all nodes associated with syntax rule ComponentIdList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ComponentIdList
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_ComponentIdList")] public ComponentIdList m_ComponentIdList { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ComponentIdList

		// delegate function (callback) prototype associated with syntax rule ComponentIdList
		public delegate bool ComponentIdList_Callback (SyntaxTreeCallbackReason reason, ComponentIdList.production_kind kind, ComponentIdList p_ComponentIdList);

		// event associated with syntax rule ComponentIdList
		public event ComponentIdList_Callback ComponentIdList_Event;

		// event trigger associated with syntax rule ComponentIdList
		public bool Raise_ComponentIdList_Event (SyntaxTreeCallbackReason reason, ComponentIdList.production_kind kind, ComponentIdList p_ComponentIdList)
		{
			bool? status = ComponentIdList_Event?.Invoke (reason, kind, p_ComponentIdList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ComponentIdList
		//
		// traverse syntax tree node associated with any production of syntax rule ComponentIdList
		//

		public void Traverse (ComponentIdList p_ComponentIdList)
		{
			if (p_ComponentIdList.isLocked())
				return;
			if (Raise_ComponentIdList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (ComponentIdList.production_kind) p_ComponentIdList.kind, p_ComponentIdList))
				p_ComponentIdList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					ComponentIdList.production_kind kind = (ComponentIdList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_ComponentIdList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case ComponentIdList.production_kind.g_ComponentIdList_1:
								// traverse syntax tree node associated with production
								// ComponentIdList: identifier-token

								if (Raise_ComponentIdList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_identifier_token);
								node.turn_inc ();
								Raise_ComponentIdList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case ComponentIdList.production_kind.g_ComponentIdList_2:
								// traverse syntax tree node associated with production
								// ComponentIdList: ComponentIdList "." identifier-token

								if (Raise_ComponentIdList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_ComponentIdList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_identifier_token);
								node.turn_inc ();
								Raise_ComponentIdList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_ComponentIdList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_ComponentIdList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (ComponentIdList.production_kind) p_ComponentIdList.kind, p_ComponentIdList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentIdList
		//

		public void TraverseCommon (ComponentIdList p_ComponentIdList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_ComponentIdList.kind, p_ComponentIdList))
				p_ComponentIdList.Iterate (null, (node, appData) =>
				{
					ComponentIdList.production_kind kind = (ComponentIdList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case ComponentIdList.production_kind.g_ComponentIdList_1:
							// traverse syntax tree node associated with production
							// ComponentIdList: identifier-token

							TraverseCommon (node.m_identifier_token);
							break;
						case ComponentIdList.production_kind.g_ComponentIdList_2:
							// traverse syntax tree node associated with production
							// ComponentIdList: ComponentIdList "." identifier-token

							TraverseCommon (node.m_dot);
							TraverseCommon (node.m_identifier_token);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_ComponentIdList.kind, p_ComponentIdList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ComponentIdList

		//
		// create syntax tree node associated with production
		// ComponentIdList: identifier-token

		//

		public ComponentIdList ComponentIdList_1 (identifier_token p_identifier_token)
		{
			ComponentIdList p_ComponentIdList_ref = new ComponentIdList(p_identifier_token);
			p_identifier_token.parent = p_ComponentIdList_ref;
			Raise_ComponentIdList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentIdList.production_kind.g_ComponentIdList_1, p_ComponentIdList_ref);
			return p_ComponentIdList_ref;
		}

		//
		// create syntax tree node associated with production
		// ComponentIdList: ComponentIdList "." identifier-token

		//

		public ComponentIdList ComponentIdList_2 (ComponentIdList p_ComponentIdList, SyntaxTreeToken p_token, identifier_token p_identifier_token)
		{
			ComponentIdList p_ComponentIdList_ref = new ComponentIdList(p_ComponentIdList, p_token, p_identifier_token);
			p_ComponentIdList.parent = p_ComponentIdList_ref;
			p_token.parent = p_ComponentIdList_ref;
			p_identifier_token.parent = p_ComponentIdList_ref;
			Raise_ComponentIdList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentIdList.production_kind.g_ComponentIdList_2, p_ComponentIdList_ref);
			return p_ComponentIdList_ref;
		}
		#endregion
	};
}
