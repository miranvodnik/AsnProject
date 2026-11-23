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
	// class associated with syntax rule SymbolList
	//

	[DataContract]
	public class	SymbolList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SymbolList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SymbolList
		{
			g_SymbolList_1 = 1,	// Symbol

			g_SymbolList_2 = 2,	// SymbolList "," Symbol

		};
		#endregion
		#region production markers associated with the syntax rule SymbolList

		// markers associated with production: SymbolList -> Symbol

		public enum production_marker_1 : ushort
		{
			m_Symbol,
			final
		};

		// markers associated with production: SymbolList -> SymbolList "," Symbol

		public enum production_marker_2 : ushort
		{
			m_SymbolList,
			m_Symbol,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SymbolList

		// Constructor declaration(s) associated with production(s) of syntax rule SymbolList

		//
		// Constructor associated with the following production(s)
		// SymbolList -> Symbol

		//

		public SymbolList (Symbol p_Symbol) : base ((uint) ProductionID._SymbolList_ID, (uint) production_kind.g_SymbolList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Symbol = p_Symbol;
		}

		//
		// Constructor associated with the following production(s)
		// SymbolList -> SymbolList "," Symbol

		//

		public SymbolList (SymbolList p_SymbolList, SyntaxTreeToken p_token, Symbol p_Symbol) : base ((uint) ProductionID._SymbolList_ID, (uint) production_kind.g_SymbolList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_SymbolList = p_SymbolList;
			children[1] = m_comma = p_token;
			children[2] = m_Symbol = p_Symbol;
		}

		public SymbolList () { }

		// Copy constructor

		public SymbolList (SymbolList p_SymbolList) : base (p_SymbolList.id, p_SymbolList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SymbolList.appInfo;
			switch ((production_kind) p_SymbolList.kind)
			{
				case production_kind.g_SymbolList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Symbol = (p_SymbolList.m_Symbol != null) ? new Symbol (p_SymbolList.m_Symbol) : null) != null) m_Symbol.parent = this;
					break;
				case production_kind.g_SymbolList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_SymbolList = (p_SymbolList.m_SymbolList != null) ? new SymbolList (p_SymbolList.m_SymbolList) : null) != null) m_SymbolList.parent = this;
					if ((children [1] = m_comma = (p_SymbolList.m_comma != null) ? new SyntaxTreeToken (p_SymbolList.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_Symbol = (p_SymbolList.m_Symbol != null) ? new Symbol (p_SymbolList.m_Symbol) : null) != null) m_Symbol.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SymbolList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SymbolList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_Symbol?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SymbolList

		// Content changing function(s) associated with production(s) of syntax rule SymbolList

		//
		// Content changing function associated with following production(s)
		// SymbolList -> Symbol

		//

		public void change(Symbol p_Symbol)
		{
			_init ();
			this.kind = (uint) production_kind.g_SymbolList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Symbol = p_Symbol;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SymbolList -> SymbolList "," Symbol

		//

		public void change(SymbolList p_SymbolList, SyntaxTreeToken p_token, Symbol p_Symbol)
		{
			_init ();
			this.kind = (uint) production_kind.g_SymbolList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_SymbolList = p_SymbolList;
			children [1] = m_comma = p_token;
			children [2] = m_Symbol = p_Symbol;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SymbolList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_Symbol != null) && node.m_Symbol.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SymbolList

		//
		// emit production tree node associated with any production of syntax rule SymbolList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_SymbolList_1:
						// emit syntax tree node associated with production
						// SymbolList: Symbol

						s += " " + node.m_Symbol.Emit (depth - 1);
						break;
					case production_kind.g_SymbolList_2:
						// emit syntax tree node associated with production
						// SymbolList: SymbolList "," Symbol

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_Symbol.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SymbolList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "SymbolList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_SymbolList_1:
						// emit syntax tree node associated with production
						// SymbolList: Symbol

						str += node.m_Symbol.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_SymbolList_2:
						// emit syntax tree node associated with production
						// SymbolList: SymbolList "," Symbol

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_Symbol.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SymbolList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SymbolList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					SymbolList.production_kind kind = (SymbolList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case SymbolList.production_kind.g_SymbolList_1:
							// traverse syntax tree node associated with production
							// SymbolList: Symbol

							node.m_Symbol.Visit (visitor, appData);
							break;
						case SymbolList.production_kind.g_SymbolList_2:
							// traverse syntax tree node associated with production
							// SymbolList: SymbolList "," Symbol

							node.m_comma.Visit (visitor, appData);
							node.m_Symbol.Visit (visitor, appData);
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
			for (SymbolList node = this; node != null; node = node.m_SymbolList)
			{
				node.parent = parent;
				node.m_Symbol?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule SymbolList
		//

		public void _init ()
		{
			m_Symbol = null;
			m_SymbolList = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (SymbolList p_SymbolList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<SymbolList> stack = new Stack<SymbolList> ();
			SymbolList p_SymbolList;
			for (p_SymbolList = this; p_SymbolList != null; p_SymbolList = p_SymbolList.m_SymbolList)
				stack.Push (p_SymbolList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SymbolList

		// counter of all nodes associated with syntax rule SymbolList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SymbolList
		[DataMember (Name = "m_Symbol")] public Symbol m_Symbol { get; private set; }
		[DataMember (Name = "m_SymbolList")] public SymbolList m_SymbolList { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SymbolList

		// delegate function (callback) prototype associated with syntax rule SymbolList
		public delegate bool SymbolList_Callback (SyntaxTreeCallbackReason reason, SymbolList.production_kind kind, SymbolList p_SymbolList);

		// event associated with syntax rule SymbolList
		public event SymbolList_Callback SymbolList_Event;

		// event trigger associated with syntax rule SymbolList
		public bool Raise_SymbolList_Event (SyntaxTreeCallbackReason reason, SymbolList.production_kind kind, SymbolList p_SymbolList)
		{
			bool? status = SymbolList_Event?.Invoke (reason, kind, p_SymbolList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SymbolList
		//
		// traverse syntax tree node associated with any production of syntax rule SymbolList
		//

		public void Traverse (SymbolList p_SymbolList)
		{
			if (p_SymbolList.isLocked())
				return;
			if (Raise_SymbolList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (SymbolList.production_kind) p_SymbolList.kind, p_SymbolList))
				p_SymbolList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					SymbolList.production_kind kind = (SymbolList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_SymbolList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case SymbolList.production_kind.g_SymbolList_1:
								// traverse syntax tree node associated with production
								// SymbolList: Symbol

								if (Raise_SymbolList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Symbol);
								node.turn_inc ();
								Raise_SymbolList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case SymbolList.production_kind.g_SymbolList_2:
								// traverse syntax tree node associated with production
								// SymbolList: SymbolList "," Symbol

								if (Raise_SymbolList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_SymbolList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Symbol);
								node.turn_inc ();
								Raise_SymbolList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_SymbolList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_SymbolList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (SymbolList.production_kind) p_SymbolList.kind, p_SymbolList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SymbolList
		//

		public void TraverseCommon (SymbolList p_SymbolList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_SymbolList.kind, p_SymbolList))
				p_SymbolList.Iterate (null, (node, appData) =>
				{
					SymbolList.production_kind kind = (SymbolList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case SymbolList.production_kind.g_SymbolList_1:
							// traverse syntax tree node associated with production
							// SymbolList: Symbol

							TraverseCommon (node.m_Symbol);
							break;
						case SymbolList.production_kind.g_SymbolList_2:
							// traverse syntax tree node associated with production
							// SymbolList: SymbolList "," Symbol

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_Symbol);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_SymbolList.kind, p_SymbolList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SymbolList

		//
		// create syntax tree node associated with production
		// SymbolList: Symbol

		//

		public SymbolList SymbolList_1 (Symbol p_Symbol)
		{
			SymbolList p_SymbolList_ref = new SymbolList(p_Symbol);
			p_Symbol.parent = p_SymbolList_ref;
			Raise_SymbolList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SymbolList.production_kind.g_SymbolList_1, p_SymbolList_ref);
			return p_SymbolList_ref;
		}

		//
		// create syntax tree node associated with production
		// SymbolList: SymbolList "," Symbol

		//

		public SymbolList SymbolList_2 (SymbolList p_SymbolList, SyntaxTreeToken p_token, Symbol p_Symbol)
		{
			SymbolList p_SymbolList_ref = new SymbolList(p_SymbolList, p_token, p_Symbol);
			p_SymbolList.parent = p_SymbolList_ref;
			p_token.parent = p_SymbolList_ref;
			p_Symbol.parent = p_SymbolList_ref;
			Raise_SymbolList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SymbolList.production_kind.g_SymbolList_2, p_SymbolList_ref);
			return p_SymbolList_ref;
		}
		#endregion
	};
}
