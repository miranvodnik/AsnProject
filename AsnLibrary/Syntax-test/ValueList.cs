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
	// class associated with syntax rule ValueList
	//

	[DataContract]
	public class	ValueList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ValueList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ValueList
		{
			g_ValueList_1 = 1,	// Value

			g_ValueList_2 = 2,	// ValueList "," Value Left

		};
		#endregion
		#region production markers associated with the syntax rule ValueList

		// markers associated with production: ValueList -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};

		// markers associated with production: ValueList -> ValueList "," Value Left

		public enum production_marker_2 : ushort
		{
			m_ValueList,
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ValueList

		// Constructor declaration(s) associated with production(s) of syntax rule ValueList

		//
		// Constructor associated with the following production(s)
		// ValueList -> Value

		//

		public ValueList (Value p_Value) : base ((uint) ProductionID._ValueList_ID, (uint) production_kind.g_ValueList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		//
		// Constructor associated with the following production(s)
		// ValueList -> ValueList "," Value Left

		//

		public ValueList (ValueList p_ValueList, SyntaxTreeToken p_token, Value p_Value) : base ((uint) ProductionID._ValueList_ID, (uint) production_kind.g_ValueList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ValueList = p_ValueList;
			children[1] = m_comma = p_token;
			children[2] = m_Value = p_Value;
		}

		public ValueList () { }

		// Copy constructor

		public ValueList (ValueList p_ValueList) : base (p_ValueList.id, p_ValueList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ValueList.appInfo;
			switch ((production_kind) p_ValueList.kind)
			{
				case production_kind.g_ValueList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_ValueList.m_Value != null) ? new Value (p_ValueList.m_Value) : null) != null) m_Value.parent = this;
					break;
				case production_kind.g_ValueList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ValueList = (p_ValueList.m_ValueList != null) ? new ValueList (p_ValueList.m_ValueList) : null) != null) m_ValueList.parent = this;
					if ((children [1] = m_comma = (p_ValueList.m_comma != null) ? new SyntaxTreeToken (p_ValueList.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_Value = (p_ValueList.m_Value != null) ? new Value (p_ValueList.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ValueList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ValueList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_Value?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ValueList

		// Content changing function(s) associated with production(s) of syntax rule ValueList

		//
		// Content changing function associated with following production(s)
		// ValueList -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ValueList -> ValueList "," Value Left

		//

		public void change(ValueList p_ValueList, SyntaxTreeToken p_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ValueList = p_ValueList;
			children [1] = m_comma = p_token;
			children [2] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ValueList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_Value != null) && node.m_Value.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ValueList

		//
		// emit production tree node associated with any production of syntax rule ValueList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ValueList_1:
						// emit syntax tree node associated with production
						// ValueList: Value

						s += " " + node.m_Value.Emit (depth - 1);
						break;
					case production_kind.g_ValueList_2:
						// emit syntax tree node associated with production
						// ValueList: ValueList "," Value Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_Value.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ValueList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "ValueList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ValueList_1:
						// emit syntax tree node associated with production
						// ValueList: Value

						str += node.m_Value.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_ValueList_2:
						// emit syntax tree node associated with production
						// ValueList: ValueList "," Value Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_Value.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ValueList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ValueList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					ValueList.production_kind kind = (ValueList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case ValueList.production_kind.g_ValueList_1:
							// traverse syntax tree node associated with production
							// ValueList: Value

							node.m_Value.Visit (visitor, appData);
							break;
						case ValueList.production_kind.g_ValueList_2:
							// traverse syntax tree node associated with production
							// ValueList: ValueList "," Value Left

							node.m_comma.Visit (visitor, appData);
							node.m_Value.Visit (visitor, appData);
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
			for (ValueList node = this; node != null; node = node.m_ValueList)
			{
				node.parent = parent;
				node.m_Value?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule ValueList
		//

		public void _init ()
		{
			m_Value = null;
			m_ValueList = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (ValueList p_ValueList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<ValueList> stack = new Stack<ValueList> ();
			ValueList p_ValueList;
			for (p_ValueList = this; p_ValueList != null; p_ValueList = p_ValueList.m_ValueList)
				stack.Push (p_ValueList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ValueList

		// counter of all nodes associated with syntax rule ValueList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ValueList
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_ValueList")] public ValueList m_ValueList { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ValueList

		// delegate function (callback) prototype associated with syntax rule ValueList
		public delegate bool ValueList_Callback (SyntaxTreeCallbackReason reason, ValueList.production_kind kind, ValueList p_ValueList);

		// event associated with syntax rule ValueList
		public event ValueList_Callback ValueList_Event;

		// event trigger associated with syntax rule ValueList
		public bool Raise_ValueList_Event (SyntaxTreeCallbackReason reason, ValueList.production_kind kind, ValueList p_ValueList)
		{
			bool? status = ValueList_Event?.Invoke (reason, kind, p_ValueList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ValueList
		//
		// traverse syntax tree node associated with any production of syntax rule ValueList
		//

		public void Traverse (ValueList p_ValueList)
		{
			if (p_ValueList.isLocked())
				return;
			if (Raise_ValueList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (ValueList.production_kind) p_ValueList.kind, p_ValueList))
				p_ValueList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					ValueList.production_kind kind = (ValueList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_ValueList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case ValueList.production_kind.g_ValueList_1:
								// traverse syntax tree node associated with production
								// ValueList: Value

								if (Raise_ValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Value);
								node.turn_inc ();
								Raise_ValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case ValueList.production_kind.g_ValueList_2:
								// traverse syntax tree node associated with production
								// ValueList: ValueList "," Value Left

								if (Raise_ValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_ValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Value);
								node.turn_inc ();
								Raise_ValueList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_ValueList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_ValueList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (ValueList.production_kind) p_ValueList.kind, p_ValueList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ValueList
		//

		public void TraverseCommon (ValueList p_ValueList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_ValueList.kind, p_ValueList))
				p_ValueList.Iterate (null, (node, appData) =>
				{
					ValueList.production_kind kind = (ValueList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case ValueList.production_kind.g_ValueList_1:
							// traverse syntax tree node associated with production
							// ValueList: Value

							TraverseCommon (node.m_Value);
							break;
						case ValueList.production_kind.g_ValueList_2:
							// traverse syntax tree node associated with production
							// ValueList: ValueList "," Value Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_Value);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_ValueList.kind, p_ValueList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ValueList

		//
		// create syntax tree node associated with production
		// ValueList: Value

		//

		public ValueList ValueList_1 (Value p_Value)
		{
			ValueList p_ValueList_ref = new ValueList(p_Value);
			p_Value.parent = p_ValueList_ref;
			Raise_ValueList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueList.production_kind.g_ValueList_1, p_ValueList_ref);
			return p_ValueList_ref;
		}

		//
		// create syntax tree node associated with production
		// ValueList: ValueList "," Value Left

		//

		public ValueList ValueList_2 (ValueList p_ValueList, SyntaxTreeToken p_token, Value p_Value)
		{
			ValueList p_ValueList_ref = new ValueList(p_ValueList, p_token, p_Value);
			p_ValueList.parent = p_ValueList_ref;
			p_token.parent = p_ValueList_ref;
			p_Value.parent = p_ValueList_ref;
			Raise_ValueList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueList.production_kind.g_ValueList_2, p_ValueList_ref);
			return p_ValueList_ref;
		}
		#endregion
	};
}
