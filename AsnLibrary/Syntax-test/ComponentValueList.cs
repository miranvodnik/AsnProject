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
	// class associated with syntax rule ComponentValueList
	//

	[DataContract]
	public class	ComponentValueList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ComponentValueList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ComponentValueList
		{
			g_ComponentValueList_1 = 1,	// NamedValue

			g_ComponentValueList_2 = 2,	// ComponentValueList "," NamedValue Left

		};
		#endregion
		#region production markers associated with the syntax rule ComponentValueList

		// markers associated with production: ComponentValueList -> NamedValue

		public enum production_marker_1 : ushort
		{
			m_NamedValue,
			final
		};

		// markers associated with production: ComponentValueList -> ComponentValueList "," NamedValue Left

		public enum production_marker_2 : ushort
		{
			m_ComponentValueList,
			m_NamedValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ComponentValueList

		// Constructor declaration(s) associated with production(s) of syntax rule ComponentValueList

		//
		// Constructor associated with the following production(s)
		// ComponentValueList -> NamedValue

		//

		public ComponentValueList (NamedValue p_NamedValue) : base ((uint) ProductionID._ComponentValueList_ID, (uint) production_kind.g_ComponentValueList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NamedValue = p_NamedValue;
		}

		//
		// Constructor associated with the following production(s)
		// ComponentValueList -> ComponentValueList "," NamedValue Left

		//

		public ComponentValueList (ComponentValueList p_ComponentValueList, SyntaxTreeToken p_token, NamedValue p_NamedValue) : base ((uint) ProductionID._ComponentValueList_ID, (uint) production_kind.g_ComponentValueList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ComponentValueList = p_ComponentValueList;
			children[1] = m_comma = p_token;
			children[2] = m_NamedValue = p_NamedValue;
		}

		public ComponentValueList () { }

		// Copy constructor

		public ComponentValueList (ComponentValueList p_ComponentValueList) : base (p_ComponentValueList.id, p_ComponentValueList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ComponentValueList.appInfo;
			switch ((production_kind) p_ComponentValueList.kind)
			{
				case production_kind.g_ComponentValueList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NamedValue = (p_ComponentValueList.m_NamedValue != null) ? new NamedValue (p_ComponentValueList.m_NamedValue) : null) != null) m_NamedValue.parent = this;
					break;
				case production_kind.g_ComponentValueList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ComponentValueList = (p_ComponentValueList.m_ComponentValueList != null) ? new ComponentValueList (p_ComponentValueList.m_ComponentValueList) : null) != null) m_ComponentValueList.parent = this;
					if ((children [1] = m_comma = (p_ComponentValueList.m_comma != null) ? new SyntaxTreeToken (p_ComponentValueList.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_NamedValue = (p_ComponentValueList.m_NamedValue != null) ? new NamedValue (p_ComponentValueList.m_NamedValue) : null) != null) m_NamedValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ComponentValueList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ComponentValueList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_NamedValue?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ComponentValueList

		// Content changing function(s) associated with production(s) of syntax rule ComponentValueList

		//
		// Content changing function associated with following production(s)
		// ComponentValueList -> NamedValue

		//

		public void change(NamedValue p_NamedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentValueList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NamedValue = p_NamedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ComponentValueList -> ComponentValueList "," NamedValue Left

		//

		public void change(ComponentValueList p_ComponentValueList, SyntaxTreeToken p_token, NamedValue p_NamedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentValueList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ComponentValueList = p_ComponentValueList;
			children [1] = m_comma = p_token;
			children [2] = m_NamedValue = p_NamedValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ComponentValueList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_NamedValue != null) && node.m_NamedValue.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ComponentValueList

		//
		// emit production tree node associated with any production of syntax rule ComponentValueList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ComponentValueList_1:
						// emit syntax tree node associated with production
						// ComponentValueList: NamedValue

						s += " " + node.m_NamedValue.Emit (depth - 1);
						break;
					case production_kind.g_ComponentValueList_2:
						// emit syntax tree node associated with production
						// ComponentValueList: ComponentValueList "," NamedValue Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_NamedValue.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ComponentValueList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "ComponentValueList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ComponentValueList_1:
						// emit syntax tree node associated with production
						// ComponentValueList: NamedValue

						str += node.m_NamedValue.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_ComponentValueList_2:
						// emit syntax tree node associated with production
						// ComponentValueList: ComponentValueList "," NamedValue Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_NamedValue.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ComponentValueList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentValueList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					ComponentValueList.production_kind kind = (ComponentValueList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case ComponentValueList.production_kind.g_ComponentValueList_1:
							// traverse syntax tree node associated with production
							// ComponentValueList: NamedValue

							node.m_NamedValue.Visit (visitor, appData);
							break;
						case ComponentValueList.production_kind.g_ComponentValueList_2:
							// traverse syntax tree node associated with production
							// ComponentValueList: ComponentValueList "," NamedValue Left

							node.m_comma.Visit (visitor, appData);
							node.m_NamedValue.Visit (visitor, appData);
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
			for (ComponentValueList node = this; node != null; node = node.m_ComponentValueList)
			{
				node.parent = parent;
				node.m_NamedValue?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule ComponentValueList
		//

		public void _init ()
		{
			m_NamedValue = null;
			m_ComponentValueList = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (ComponentValueList p_ComponentValueList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<ComponentValueList> stack = new Stack<ComponentValueList> ();
			ComponentValueList p_ComponentValueList;
			for (p_ComponentValueList = this; p_ComponentValueList != null; p_ComponentValueList = p_ComponentValueList.m_ComponentValueList)
				stack.Push (p_ComponentValueList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ComponentValueList

		// counter of all nodes associated with syntax rule ComponentValueList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ComponentValueList
		[DataMember (Name = "m_NamedValue")] public NamedValue m_NamedValue { get; private set; }
		[DataMember (Name = "m_ComponentValueList")] public ComponentValueList m_ComponentValueList { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ComponentValueList

		// delegate function (callback) prototype associated with syntax rule ComponentValueList
		public delegate bool ComponentValueList_Callback (SyntaxTreeCallbackReason reason, ComponentValueList.production_kind kind, ComponentValueList p_ComponentValueList);

		// event associated with syntax rule ComponentValueList
		public event ComponentValueList_Callback ComponentValueList_Event;

		// event trigger associated with syntax rule ComponentValueList
		public bool Raise_ComponentValueList_Event (SyntaxTreeCallbackReason reason, ComponentValueList.production_kind kind, ComponentValueList p_ComponentValueList)
		{
			bool? status = ComponentValueList_Event?.Invoke (reason, kind, p_ComponentValueList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ComponentValueList
		//
		// traverse syntax tree node associated with any production of syntax rule ComponentValueList
		//

		public void Traverse (ComponentValueList p_ComponentValueList)
		{
			if (p_ComponentValueList.isLocked())
				return;
			if (Raise_ComponentValueList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (ComponentValueList.production_kind) p_ComponentValueList.kind, p_ComponentValueList))
				p_ComponentValueList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					ComponentValueList.production_kind kind = (ComponentValueList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_ComponentValueList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case ComponentValueList.production_kind.g_ComponentValueList_1:
								// traverse syntax tree node associated with production
								// ComponentValueList: NamedValue

								if (Raise_ComponentValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NamedValue);
								node.turn_inc ();
								Raise_ComponentValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case ComponentValueList.production_kind.g_ComponentValueList_2:
								// traverse syntax tree node associated with production
								// ComponentValueList: ComponentValueList "," NamedValue Left

								if (Raise_ComponentValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_ComponentValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NamedValue);
								node.turn_inc ();
								Raise_ComponentValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_ComponentValueList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_ComponentValueList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (ComponentValueList.production_kind) p_ComponentValueList.kind, p_ComponentValueList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentValueList
		//

		public void TraverseCommon (ComponentValueList p_ComponentValueList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_ComponentValueList.kind, p_ComponentValueList))
				p_ComponentValueList.Iterate (null, (node, appData) =>
				{
					ComponentValueList.production_kind kind = (ComponentValueList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case ComponentValueList.production_kind.g_ComponentValueList_1:
							// traverse syntax tree node associated with production
							// ComponentValueList: NamedValue

							TraverseCommon (node.m_NamedValue);
							break;
						case ComponentValueList.production_kind.g_ComponentValueList_2:
							// traverse syntax tree node associated with production
							// ComponentValueList: ComponentValueList "," NamedValue Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_NamedValue);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_ComponentValueList.kind, p_ComponentValueList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ComponentValueList

		//
		// create syntax tree node associated with production
		// ComponentValueList: NamedValue

		//

		public ComponentValueList ComponentValueList_1 (NamedValue p_NamedValue)
		{
			ComponentValueList p_ComponentValueList_ref = new ComponentValueList(p_NamedValue);
			p_NamedValue.parent = p_ComponentValueList_ref;
			Raise_ComponentValueList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentValueList.production_kind.g_ComponentValueList_1, p_ComponentValueList_ref);
			return p_ComponentValueList_ref;
		}

		//
		// create syntax tree node associated with production
		// ComponentValueList: ComponentValueList "," NamedValue Left

		//

		public ComponentValueList ComponentValueList_2 (ComponentValueList p_ComponentValueList, SyntaxTreeToken p_token, NamedValue p_NamedValue)
		{
			ComponentValueList p_ComponentValueList_ref = new ComponentValueList(p_ComponentValueList, p_token, p_NamedValue);
			p_ComponentValueList.parent = p_ComponentValueList_ref;
			p_token.parent = p_ComponentValueList_ref;
			p_NamedValue.parent = p_ComponentValueList_ref;
			Raise_ComponentValueList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentValueList.production_kind.g_ComponentValueList_2, p_ComponentValueList_ref);
			return p_ComponentValueList_ref;
		}
		#endregion
	};
}
