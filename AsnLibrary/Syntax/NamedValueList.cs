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
	// class associated with syntax rule NamedValueList
	//

	[DataContract]
	public class	NamedValueList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NamedValueList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NamedValueList
		{
			g_NamedValueList_1 = 1,	// NamedValue

			g_NamedValueList_2 = 2,	// NamedValueList "," NamedValue

		};
		#endregion
		#region production markers associated with the syntax rule NamedValueList

		// markers associated with production: NamedValueList -> NamedValue

		public enum production_marker_1 : ushort
		{
			m_NamedValue,
			final
		};

		// markers associated with production: NamedValueList -> NamedValueList "," NamedValue

		public enum production_marker_2 : ushort
		{
			m_NamedValueList,
			m_NamedValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NamedValueList

		// Constructor declaration(s) associated with production(s) of syntax rule NamedValueList

		//
		// Constructor associated with the following production(s)
		// NamedValueList -> NamedValue

		//

		public NamedValueList (NamedValue p_NamedValue) : base ((uint) ProductionID._NamedValueList_ID, (uint) production_kind.g_NamedValueList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NamedValue = p_NamedValue;
		}

		//
		// Constructor associated with the following production(s)
		// NamedValueList -> NamedValueList "," NamedValue

		//

		public NamedValueList (NamedValueList p_NamedValueList, SyntaxTreeToken p_token, NamedValue p_NamedValue) : base ((uint) ProductionID._NamedValueList_ID, (uint) production_kind.g_NamedValueList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_NamedValueList = p_NamedValueList;
			children[1] = m_comma = p_token;
			children[2] = m_NamedValue = p_NamedValue;
		}

		public NamedValueList () { }

		// Copy constructor

		public NamedValueList (NamedValueList p_NamedValueList) : base (p_NamedValueList.id, p_NamedValueList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NamedValueList.appInfo;
			switch ((production_kind) p_NamedValueList.kind)
			{
				case production_kind.g_NamedValueList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NamedValue = (p_NamedValueList.m_NamedValue != null) ? new NamedValue (p_NamedValueList.m_NamedValue) : null) != null) m_NamedValue.parent = this;
					break;
				case production_kind.g_NamedValueList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_NamedValueList = (p_NamedValueList.m_NamedValueList != null) ? new NamedValueList (p_NamedValueList.m_NamedValueList) : null) != null) m_NamedValueList.parent = this;
					if ((children [1] = m_comma = (p_NamedValueList.m_comma != null) ? new SyntaxTreeToken (p_NamedValueList.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_NamedValue = (p_NamedValueList.m_NamedValue != null) ? new NamedValue (p_NamedValueList.m_NamedValue) : null) != null) m_NamedValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NamedValueList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NamedValueList (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule NamedValueList

		// Content changing function(s) associated with production(s) of syntax rule NamedValueList

		//
		// Content changing function associated with following production(s)
		// NamedValueList -> NamedValue

		//

		public void change(NamedValue p_NamedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedValueList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NamedValue = p_NamedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NamedValueList -> NamedValueList "," NamedValue

		//

		public void change(NamedValueList p_NamedValueList, SyntaxTreeToken p_token, NamedValue p_NamedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedValueList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_NamedValueList = p_NamedValueList;
			children [1] = m_comma = p_token;
			children [2] = m_NamedValue = p_NamedValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NamedValueList
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
		#region Syntax tree emit methods associated with the syntax rule NamedValueList

		//
		// emit production tree node associated with any production of syntax rule NamedValueList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_NamedValueList_1:
						// emit syntax tree node associated with production
						// NamedValueList: NamedValue

						s += " " + node.m_NamedValue.Emit (depth - 1);
						break;
					case production_kind.g_NamedValueList_2:
						// emit syntax tree node associated with production
						// NamedValueList: NamedValueList "," NamedValue

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_NamedValue.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NamedValueList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "NamedValueList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_NamedValueList_1:
						// emit syntax tree node associated with production
						// NamedValueList: NamedValue

						str += node.m_NamedValue.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_NamedValueList_2:
						// emit syntax tree node associated with production
						// NamedValueList: NamedValueList "," NamedValue

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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NamedValueList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NamedValueList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					NamedValueList.production_kind kind = (NamedValueList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case NamedValueList.production_kind.g_NamedValueList_1:
							// traverse syntax tree node associated with production
							// NamedValueList: NamedValue

							node.m_NamedValue.Visit (visitor, appData);
							break;
						case NamedValueList.production_kind.g_NamedValueList_2:
							// traverse syntax tree node associated with production
							// NamedValueList: NamedValueList "," NamedValue

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
			for (NamedValueList node = this; node != null; node = node.m_NamedValueList)
			{
				node.parent = parent;
				node.m_NamedValue?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule NamedValueList
		//

		public void _init ()
		{
			m_NamedValue = null;
			m_NamedValueList = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (NamedValueList p_NamedValueList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<NamedValueList> stack = new Stack<NamedValueList> ();
			NamedValueList p_NamedValueList;
			for (p_NamedValueList = this; p_NamedValueList != null; p_NamedValueList = p_NamedValueList.m_NamedValueList)
				stack.Push (p_NamedValueList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NamedValueList

		// counter of all nodes associated with syntax rule NamedValueList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NamedValueList
		[DataMember (Name = "m_NamedValue")] public NamedValue m_NamedValue { get; private set; }
		[DataMember (Name = "m_NamedValueList")] public NamedValueList m_NamedValueList { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NamedValueList

		// delegate function (callback) prototype associated with syntax rule NamedValueList
		public delegate bool NamedValueList_Callback (SyntaxTreeCallbackReason reason, NamedValueList.production_kind kind, NamedValueList p_NamedValueList);

		// event associated with syntax rule NamedValueList
		public event NamedValueList_Callback NamedValueList_Event;

		// event trigger associated with syntax rule NamedValueList
		public bool Raise_NamedValueList_Event (SyntaxTreeCallbackReason reason, NamedValueList.production_kind kind, NamedValueList p_NamedValueList)
		{
			bool? status = NamedValueList_Event?.Invoke (reason, kind, p_NamedValueList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NamedValueList
		//
		// traverse syntax tree node associated with any production of syntax rule NamedValueList
		//

		public void Traverse (NamedValueList p_NamedValueList)
		{
			if (p_NamedValueList.isLocked())
				return;
			if (Raise_NamedValueList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (NamedValueList.production_kind) p_NamedValueList.kind, p_NamedValueList))
				p_NamedValueList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					NamedValueList.production_kind kind = (NamedValueList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_NamedValueList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case NamedValueList.production_kind.g_NamedValueList_1:
								// traverse syntax tree node associated with production
								// NamedValueList: NamedValue

								if (Raise_NamedValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NamedValue);
								node.turn_inc ();
								Raise_NamedValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case NamedValueList.production_kind.g_NamedValueList_2:
								// traverse syntax tree node associated with production
								// NamedValueList: NamedValueList "," NamedValue

								if (Raise_NamedValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_NamedValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NamedValue);
								node.turn_inc ();
								Raise_NamedValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_NamedValueList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_NamedValueList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (NamedValueList.production_kind) p_NamedValueList.kind, p_NamedValueList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NamedValueList
		//

		public void TraverseCommon (NamedValueList p_NamedValueList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_NamedValueList.kind, p_NamedValueList))
				p_NamedValueList.Iterate (null, (node, appData) =>
				{
					NamedValueList.production_kind kind = (NamedValueList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case NamedValueList.production_kind.g_NamedValueList_1:
							// traverse syntax tree node associated with production
							// NamedValueList: NamedValue

							TraverseCommon (node.m_NamedValue);
							break;
						case NamedValueList.production_kind.g_NamedValueList_2:
							// traverse syntax tree node associated with production
							// NamedValueList: NamedValueList "," NamedValue

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_NamedValue);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_NamedValueList.kind, p_NamedValueList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NamedValueList

		//
		// create syntax tree node associated with production
		// NamedValueList: NamedValue

		//

		public NamedValueList NamedValueList_1 (NamedValue p_NamedValue)
		{
			NamedValueList p_NamedValueList_ref = new NamedValueList(p_NamedValue);
			p_NamedValue.parent = p_NamedValueList_ref;
			Raise_NamedValueList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedValueList.production_kind.g_NamedValueList_1, p_NamedValueList_ref);
			return p_NamedValueList_ref;
		}

		//
		// create syntax tree node associated with production
		// NamedValueList: NamedValueList "," NamedValue

		//

		public NamedValueList NamedValueList_2 (NamedValueList p_NamedValueList, SyntaxTreeToken p_token, NamedValue p_NamedValue)
		{
			NamedValueList p_NamedValueList_ref = new NamedValueList(p_NamedValueList, p_token, p_NamedValue);
			p_NamedValueList.parent = p_NamedValueList_ref;
			p_token.parent = p_NamedValueList_ref;
			p_NamedValue.parent = p_NamedValueList_ref;
			Raise_NamedValueList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedValueList.production_kind.g_NamedValueList_2, p_NamedValueList_ref);
			return p_NamedValueList_ref;
		}
		#endregion
	};
}
