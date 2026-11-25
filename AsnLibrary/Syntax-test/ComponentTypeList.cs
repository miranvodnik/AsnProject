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
	// class associated with syntax rule ComponentTypeList
	//

	[DataContract]
	public class	ComponentTypeList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ComponentTypeList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ComponentTypeList
		{
			g_ComponentTypeList_1 = 1,	// ComponentType

			g_ComponentTypeList_2 = 2,	// ComponentTypeList "," ComponentType Left

		};
		#endregion
		#region production markers associated with the syntax rule ComponentTypeList

		// markers associated with production: ComponentTypeList -> ComponentType

		public enum production_marker_1 : ushort
		{
			m_ComponentType,
			final
		};

		// markers associated with production: ComponentTypeList -> ComponentTypeList "," ComponentType Left

		public enum production_marker_2 : ushort
		{
			m_ComponentTypeList,
			m_ComponentType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ComponentTypeList

		// Constructor declaration(s) associated with production(s) of syntax rule ComponentTypeList

		//
		// Constructor associated with the following production(s)
		// ComponentTypeList -> ComponentType

		//

		public ComponentTypeList (ComponentType p_ComponentType) : base ((uint) ProductionID._ComponentTypeList_ID, (uint) production_kind.g_ComponentTypeList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ComponentType = p_ComponentType;
		}

		//
		// Constructor associated with the following production(s)
		// ComponentTypeList -> ComponentTypeList "," ComponentType Left

		//

		public ComponentTypeList (ComponentTypeList p_ComponentTypeList, SyntaxTreeToken p_token, ComponentType p_ComponentType) : base ((uint) ProductionID._ComponentTypeList_ID, (uint) production_kind.g_ComponentTypeList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ComponentTypeList = p_ComponentTypeList;
			children[1] = m_comma = p_token;
			children[2] = m_ComponentType = p_ComponentType;
		}

		public ComponentTypeList () { }

		// Copy constructor

		public ComponentTypeList (ComponentTypeList p_ComponentTypeList) : base (p_ComponentTypeList.id, p_ComponentTypeList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ComponentTypeList.appInfo;
			switch ((production_kind) p_ComponentTypeList.kind)
			{
				case production_kind.g_ComponentTypeList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ComponentType = (p_ComponentTypeList.m_ComponentType != null) ? new ComponentType (p_ComponentTypeList.m_ComponentType) : null) != null) m_ComponentType.parent = this;
					break;
				case production_kind.g_ComponentTypeList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ComponentTypeList = (p_ComponentTypeList.m_ComponentTypeList != null) ? new ComponentTypeList (p_ComponentTypeList.m_ComponentTypeList) : null) != null) m_ComponentTypeList.parent = this;
					if ((children [1] = m_comma = (p_ComponentTypeList.m_comma != null) ? new SyntaxTreeToken (p_ComponentTypeList.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_ComponentType = (p_ComponentTypeList.m_ComponentType != null) ? new ComponentType (p_ComponentTypeList.m_ComponentType) : null) != null) m_ComponentType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ComponentTypeList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ComponentTypeList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_ComponentType?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ComponentTypeList

		// Content changing function(s) associated with production(s) of syntax rule ComponentTypeList

		//
		// Content changing function associated with following production(s)
		// ComponentTypeList -> ComponentType

		//

		public void change(ComponentType p_ComponentType)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentTypeList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ComponentType = p_ComponentType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ComponentTypeList -> ComponentTypeList "," ComponentType Left

		//

		public void change(ComponentTypeList p_ComponentTypeList, SyntaxTreeToken p_token, ComponentType p_ComponentType)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentTypeList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ComponentTypeList = p_ComponentTypeList;
			children [1] = m_comma = p_token;
			children [2] = m_ComponentType = p_ComponentType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ComponentTypeList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_ComponentType != null) && node.m_ComponentType.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ComponentTypeList

		//
		// emit production tree node associated with any production of syntax rule ComponentTypeList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ComponentTypeList_1:
						// emit syntax tree node associated with production
						// ComponentTypeList: ComponentType

						s += " " + node.m_ComponentType.Emit (depth - 1);
						break;
					case production_kind.g_ComponentTypeList_2:
						// emit syntax tree node associated with production
						// ComponentTypeList: ComponentTypeList "," ComponentType Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_ComponentType.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ComponentTypeList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "ComponentTypeList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ComponentTypeList_1:
						// emit syntax tree node associated with production
						// ComponentTypeList: ComponentType

						str += node.m_ComponentType.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_ComponentTypeList_2:
						// emit syntax tree node associated with production
						// ComponentTypeList: ComponentTypeList "," ComponentType Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_ComponentType.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ComponentTypeList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentTypeList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					ComponentTypeList.production_kind kind = (ComponentTypeList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case ComponentTypeList.production_kind.g_ComponentTypeList_1:
							// traverse syntax tree node associated with production
							// ComponentTypeList: ComponentType

							node.m_ComponentType.Visit (visitor, appData);
							break;
						case ComponentTypeList.production_kind.g_ComponentTypeList_2:
							// traverse syntax tree node associated with production
							// ComponentTypeList: ComponentTypeList "," ComponentType Left

							node.m_comma.Visit (visitor, appData);
							node.m_ComponentType.Visit (visitor, appData);
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
			for (ComponentTypeList node = this; node != null; node = node.m_ComponentTypeList)
			{
				node.parent = parent;
				node.m_ComponentType?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule ComponentTypeList
		//

		public void _init ()
		{
			m_ComponentType = null;
			m_ComponentTypeList = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (ComponentTypeList p_ComponentTypeList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<ComponentTypeList> stack = new Stack<ComponentTypeList> ();
			ComponentTypeList p_ComponentTypeList;
			for (p_ComponentTypeList = this; p_ComponentTypeList != null; p_ComponentTypeList = p_ComponentTypeList.m_ComponentTypeList)
				stack.Push (p_ComponentTypeList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ComponentTypeList

		// counter of all nodes associated with syntax rule ComponentTypeList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ComponentTypeList
		[DataMember (Name = "m_ComponentType")] public ComponentType m_ComponentType { get; private set; }
		[DataMember (Name = "m_ComponentTypeList")] public ComponentTypeList m_ComponentTypeList { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ComponentTypeList

		// delegate function (callback) prototype associated with syntax rule ComponentTypeList
		public delegate bool ComponentTypeList_Callback (SyntaxTreeCallbackReason reason, ComponentTypeList.production_kind kind, ComponentTypeList p_ComponentTypeList);

		// event associated with syntax rule ComponentTypeList
		public event ComponentTypeList_Callback ComponentTypeList_Event;

		// event trigger associated with syntax rule ComponentTypeList
		public bool Raise_ComponentTypeList_Event (SyntaxTreeCallbackReason reason, ComponentTypeList.production_kind kind, ComponentTypeList p_ComponentTypeList)
		{
			bool? status = ComponentTypeList_Event?.Invoke (reason, kind, p_ComponentTypeList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ComponentTypeList
		//
		// traverse syntax tree node associated with any production of syntax rule ComponentTypeList
		//

		public void Traverse (ComponentTypeList p_ComponentTypeList)
		{
			if (p_ComponentTypeList.isLocked())
				return;
			if (Raise_ComponentTypeList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (ComponentTypeList.production_kind) p_ComponentTypeList.kind, p_ComponentTypeList))
				p_ComponentTypeList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					ComponentTypeList.production_kind kind = (ComponentTypeList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_ComponentTypeList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case ComponentTypeList.production_kind.g_ComponentTypeList_1:
								// traverse syntax tree node associated with production
								// ComponentTypeList: ComponentType

								if (Raise_ComponentTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_ComponentType);
								node.turn_inc ();
								Raise_ComponentTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case ComponentTypeList.production_kind.g_ComponentTypeList_2:
								// traverse syntax tree node associated with production
								// ComponentTypeList: ComponentTypeList "," ComponentType Left

								if (Raise_ComponentTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_ComponentTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_ComponentType);
								node.turn_inc ();
								Raise_ComponentTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_ComponentTypeList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_ComponentTypeList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (ComponentTypeList.production_kind) p_ComponentTypeList.kind, p_ComponentTypeList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentTypeList
		//

		public void TraverseCommon (ComponentTypeList p_ComponentTypeList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_ComponentTypeList.kind, p_ComponentTypeList))
				p_ComponentTypeList.Iterate (null, (node, appData) =>
				{
					ComponentTypeList.production_kind kind = (ComponentTypeList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case ComponentTypeList.production_kind.g_ComponentTypeList_1:
							// traverse syntax tree node associated with production
							// ComponentTypeList: ComponentType

							TraverseCommon (node.m_ComponentType);
							break;
						case ComponentTypeList.production_kind.g_ComponentTypeList_2:
							// traverse syntax tree node associated with production
							// ComponentTypeList: ComponentTypeList "," ComponentType Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_ComponentType);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_ComponentTypeList.kind, p_ComponentTypeList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ComponentTypeList

		//
		// create syntax tree node associated with production
		// ComponentTypeList: ComponentType

		//

		public ComponentTypeList ComponentTypeList_1 (ComponentType p_ComponentType)
		{
			ComponentTypeList p_ComponentTypeList_ref = new ComponentTypeList(p_ComponentType);
			p_ComponentType.parent = p_ComponentTypeList_ref;
			Raise_ComponentTypeList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentTypeList.production_kind.g_ComponentTypeList_1, p_ComponentTypeList_ref);
			return p_ComponentTypeList_ref;
		}

		//
		// create syntax tree node associated with production
		// ComponentTypeList: ComponentTypeList "," ComponentType Left

		//

		public ComponentTypeList ComponentTypeList_2 (ComponentTypeList p_ComponentTypeList, SyntaxTreeToken p_token, ComponentType p_ComponentType)
		{
			ComponentTypeList p_ComponentTypeList_ref = new ComponentTypeList(p_ComponentTypeList, p_token, p_ComponentType);
			p_ComponentTypeList.parent = p_ComponentTypeList_ref;
			p_token.parent = p_ComponentTypeList_ref;
			p_ComponentType.parent = p_ComponentTypeList_ref;
			Raise_ComponentTypeList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentTypeList.production_kind.g_ComponentTypeList_2, p_ComponentTypeList_ref);
			return p_ComponentTypeList_ref;
		}
		#endregion
	};
}
