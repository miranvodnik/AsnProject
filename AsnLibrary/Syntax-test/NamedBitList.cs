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
	// class associated with syntax rule NamedBitList
	//

	[DataContract]
	public class	NamedBitList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NamedBitList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NamedBitList
		{
			g_NamedBitList_1 = 1,	// NamedBit

			g_NamedBitList_2 = 2,	// NamedBitList "," NamedBit Left

		};
		#endregion
		#region production markers associated with the syntax rule NamedBitList

		// markers associated with production: NamedBitList -> NamedBit

		public enum production_marker_1 : ushort
		{
			m_NamedBit,
			final
		};

		// markers associated with production: NamedBitList -> NamedBitList "," NamedBit Left

		public enum production_marker_2 : ushort
		{
			m_NamedBitList,
			m_NamedBit,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NamedBitList

		// Constructor declaration(s) associated with production(s) of syntax rule NamedBitList

		//
		// Constructor associated with the following production(s)
		// NamedBitList -> NamedBit

		//

		public NamedBitList (NamedBit p_NamedBit) : base ((uint) ProductionID._NamedBitList_ID, (uint) production_kind.g_NamedBitList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NamedBit = p_NamedBit;
		}

		//
		// Constructor associated with the following production(s)
		// NamedBitList -> NamedBitList "," NamedBit Left

		//

		public NamedBitList (NamedBitList p_NamedBitList, SyntaxTreeToken p_token, NamedBit p_NamedBit) : base ((uint) ProductionID._NamedBitList_ID, (uint) production_kind.g_NamedBitList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_NamedBitList = p_NamedBitList;
			children[1] = m_comma = p_token;
			children[2] = m_NamedBit = p_NamedBit;
		}

		public NamedBitList () { }

		// Copy constructor

		public NamedBitList (NamedBitList p_NamedBitList) : base (p_NamedBitList.id, p_NamedBitList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NamedBitList.appInfo;
			switch ((production_kind) p_NamedBitList.kind)
			{
				case production_kind.g_NamedBitList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NamedBit = (p_NamedBitList.m_NamedBit != null) ? new NamedBit (p_NamedBitList.m_NamedBit) : null) != null) m_NamedBit.parent = this;
					break;
				case production_kind.g_NamedBitList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_NamedBitList = (p_NamedBitList.m_NamedBitList != null) ? new NamedBitList (p_NamedBitList.m_NamedBitList) : null) != null) m_NamedBitList.parent = this;
					if ((children [1] = m_comma = (p_NamedBitList.m_comma != null) ? new SyntaxTreeToken (p_NamedBitList.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_NamedBit = (p_NamedBitList.m_NamedBit != null) ? new NamedBit (p_NamedBitList.m_NamedBit) : null) != null) m_NamedBit.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NamedBitList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NamedBitList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_NamedBit?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NamedBitList

		// Content changing function(s) associated with production(s) of syntax rule NamedBitList

		//
		// Content changing function associated with following production(s)
		// NamedBitList -> NamedBit

		//

		public void change(NamedBit p_NamedBit)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedBitList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NamedBit = p_NamedBit;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NamedBitList -> NamedBitList "," NamedBit Left

		//

		public void change(NamedBitList p_NamedBitList, SyntaxTreeToken p_token, NamedBit p_NamedBit)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedBitList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_NamedBitList = p_NamedBitList;
			children [1] = m_comma = p_token;
			children [2] = m_NamedBit = p_NamedBit;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NamedBitList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_NamedBit != null) && node.m_NamedBit.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NamedBitList

		//
		// emit production tree node associated with any production of syntax rule NamedBitList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_NamedBitList_1:
						// emit syntax tree node associated with production
						// NamedBitList: NamedBit

						s += " " + node.m_NamedBit.Emit (depth - 1);
						break;
					case production_kind.g_NamedBitList_2:
						// emit syntax tree node associated with production
						// NamedBitList: NamedBitList "," NamedBit Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_NamedBit.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NamedBitList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "NamedBitList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_NamedBitList_1:
						// emit syntax tree node associated with production
						// NamedBitList: NamedBit

						str += node.m_NamedBit.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_NamedBitList_2:
						// emit syntax tree node associated with production
						// NamedBitList: NamedBitList "," NamedBit Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_NamedBit.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NamedBitList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NamedBitList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					NamedBitList.production_kind kind = (NamedBitList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case NamedBitList.production_kind.g_NamedBitList_1:
							// traverse syntax tree node associated with production
							// NamedBitList: NamedBit

							node.m_NamedBit.Visit (visitor, appData);
							break;
						case NamedBitList.production_kind.g_NamedBitList_2:
							// traverse syntax tree node associated with production
							// NamedBitList: NamedBitList "," NamedBit Left

							node.m_comma.Visit (visitor, appData);
							node.m_NamedBit.Visit (visitor, appData);
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
			for (NamedBitList node = this; node != null; node = node.m_NamedBitList)
			{
				node.parent = parent;
				node.m_NamedBit?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule NamedBitList
		//

		public void _init ()
		{
			m_NamedBit = null;
			m_NamedBitList = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (NamedBitList p_NamedBitList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<NamedBitList> stack = new Stack<NamedBitList> ();
			NamedBitList p_NamedBitList;
			for (p_NamedBitList = this; p_NamedBitList != null; p_NamedBitList = p_NamedBitList.m_NamedBitList)
				stack.Push (p_NamedBitList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NamedBitList

		// counter of all nodes associated with syntax rule NamedBitList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NamedBitList
		[DataMember (Name = "m_NamedBit")] public NamedBit m_NamedBit { get; private set; }
		[DataMember (Name = "m_NamedBitList")] public NamedBitList m_NamedBitList { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NamedBitList

		// delegate function (callback) prototype associated with syntax rule NamedBitList
		public delegate bool NamedBitList_Callback (SyntaxTreeCallbackReason reason, NamedBitList.production_kind kind, NamedBitList p_NamedBitList);

		// event associated with syntax rule NamedBitList
		public event NamedBitList_Callback NamedBitList_Event;

		// event trigger associated with syntax rule NamedBitList
		public bool Raise_NamedBitList_Event (SyntaxTreeCallbackReason reason, NamedBitList.production_kind kind, NamedBitList p_NamedBitList)
		{
			bool? status = NamedBitList_Event?.Invoke (reason, kind, p_NamedBitList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NamedBitList
		//
		// traverse syntax tree node associated with any production of syntax rule NamedBitList
		//

		public void Traverse (NamedBitList p_NamedBitList)
		{
			if (p_NamedBitList.isLocked())
				return;
			if (Raise_NamedBitList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (NamedBitList.production_kind) p_NamedBitList.kind, p_NamedBitList))
				p_NamedBitList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					NamedBitList.production_kind kind = (NamedBitList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_NamedBitList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case NamedBitList.production_kind.g_NamedBitList_1:
								// traverse syntax tree node associated with production
								// NamedBitList: NamedBit

								if (Raise_NamedBitList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NamedBit);
								node.turn_inc ();
								Raise_NamedBitList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case NamedBitList.production_kind.g_NamedBitList_2:
								// traverse syntax tree node associated with production
								// NamedBitList: NamedBitList "," NamedBit Left

								if (Raise_NamedBitList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_NamedBitList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NamedBit);
								node.turn_inc ();
								Raise_NamedBitList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_NamedBitList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_NamedBitList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (NamedBitList.production_kind) p_NamedBitList.kind, p_NamedBitList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NamedBitList
		//

		public void TraverseCommon (NamedBitList p_NamedBitList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_NamedBitList.kind, p_NamedBitList))
				p_NamedBitList.Iterate (null, (node, appData) =>
				{
					NamedBitList.production_kind kind = (NamedBitList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case NamedBitList.production_kind.g_NamedBitList_1:
							// traverse syntax tree node associated with production
							// NamedBitList: NamedBit

							TraverseCommon (node.m_NamedBit);
							break;
						case NamedBitList.production_kind.g_NamedBitList_2:
							// traverse syntax tree node associated with production
							// NamedBitList: NamedBitList "," NamedBit Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_NamedBit);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_NamedBitList.kind, p_NamedBitList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NamedBitList

		//
		// create syntax tree node associated with production
		// NamedBitList: NamedBit

		//

		public NamedBitList NamedBitList_1 (NamedBit p_NamedBit)
		{
			NamedBitList p_NamedBitList_ref = new NamedBitList(p_NamedBit);
			p_NamedBit.parent = p_NamedBitList_ref;
			Raise_NamedBitList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedBitList.production_kind.g_NamedBitList_1, p_NamedBitList_ref);
			return p_NamedBitList_ref;
		}

		//
		// create syntax tree node associated with production
		// NamedBitList: NamedBitList "," NamedBit Left

		//

		public NamedBitList NamedBitList_2 (NamedBitList p_NamedBitList, SyntaxTreeToken p_token, NamedBit p_NamedBit)
		{
			NamedBitList p_NamedBitList_ref = new NamedBitList(p_NamedBitList, p_token, p_NamedBit);
			p_NamedBitList.parent = p_NamedBitList_ref;
			p_token.parent = p_NamedBitList_ref;
			p_NamedBit.parent = p_NamedBitList_ref;
			Raise_NamedBitList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedBitList.production_kind.g_NamedBitList_2, p_NamedBitList_ref);
			return p_NamedBitList_ref;
		}
		#endregion
	};
}
