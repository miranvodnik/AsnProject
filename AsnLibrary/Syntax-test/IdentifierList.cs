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
	// class associated with syntax rule IdentifierList
	//

	[DataContract]
	public class	IdentifierList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule IdentifierList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule IdentifierList
		{
			g_IdentifierList_1 = 1,	// identifier-token

			g_IdentifierList_2 = 2,	// IdentifierList "," identifier-token Left

		};
		#endregion
		#region production markers associated with the syntax rule IdentifierList

		// markers associated with production: IdentifierList -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};

		// markers associated with production: IdentifierList -> IdentifierList "," identifier-token Left

		public enum production_marker_2 : ushort
		{
			m_IdentifierList,
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule IdentifierList

		// Constructor declaration(s) associated with production(s) of syntax rule IdentifierList

		//
		// Constructor associated with the following production(s)
		// IdentifierList -> identifier-token

		//

		public IdentifierList (identifier_token p_identifier_token) : base ((uint) ProductionID._IdentifierList_ID, (uint) production_kind.g_IdentifierList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		//
		// Constructor associated with the following production(s)
		// IdentifierList -> IdentifierList "," identifier-token Left

		//

		public IdentifierList (IdentifierList p_IdentifierList, SyntaxTreeToken p_token, identifier_token p_identifier_token) : base ((uint) ProductionID._IdentifierList_ID, (uint) production_kind.g_IdentifierList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_IdentifierList = p_IdentifierList;
			children[1] = m_comma = p_token;
			children[2] = m_identifier_token = p_identifier_token;
		}

		public IdentifierList () { }

		// Copy constructor

		public IdentifierList (IdentifierList p_IdentifierList) : base (p_IdentifierList.id, p_IdentifierList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_IdentifierList.appInfo;
			switch ((production_kind) p_IdentifierList.kind)
			{
				case production_kind.g_IdentifierList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_IdentifierList.m_identifier_token != null) ? new identifier_token (p_IdentifierList.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				case production_kind.g_IdentifierList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_IdentifierList = (p_IdentifierList.m_IdentifierList != null) ? new IdentifierList (p_IdentifierList.m_IdentifierList) : null) != null) m_IdentifierList.parent = this;
					if ((children [1] = m_comma = (p_IdentifierList.m_comma != null) ? new SyntaxTreeToken (p_IdentifierList.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_identifier_token = (p_IdentifierList.m_identifier_token != null) ? new identifier_token (p_IdentifierList.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "IdentifierList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new IdentifierList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_identifier_token?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule IdentifierList

		// Content changing function(s) associated with production(s) of syntax rule IdentifierList

		//
		// Content changing function associated with following production(s)
		// IdentifierList -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_IdentifierList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// IdentifierList -> IdentifierList "," identifier-token Left

		//

		public void change(IdentifierList p_IdentifierList, SyntaxTreeToken p_token, identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_IdentifierList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_IdentifierList = p_IdentifierList;
			children [1] = m_comma = p_token;
			children [2] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule IdentifierList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_identifier_token != null) && node.m_identifier_token.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule IdentifierList

		//
		// emit production tree node associated with any production of syntax rule IdentifierList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_IdentifierList_1:
						// emit syntax tree node associated with production
						// IdentifierList: identifier-token

						s += " " + node.m_identifier_token.Emit (depth - 1);
						break;
					case production_kind.g_IdentifierList_2:
						// emit syntax tree node associated with production
						// IdentifierList: IdentifierList "," identifier-token Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_identifier_token.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule IdentifierList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "IdentifierList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_IdentifierList_1:
						// emit syntax tree node associated with production
						// IdentifierList: identifier-token

						str += node.m_identifier_token.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_IdentifierList_2:
						// emit syntax tree node associated with production
						// IdentifierList: IdentifierList "," identifier-token Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_identifier_token.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule IdentifierList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule IdentifierList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					IdentifierList.production_kind kind = (IdentifierList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case IdentifierList.production_kind.g_IdentifierList_1:
							// traverse syntax tree node associated with production
							// IdentifierList: identifier-token

							node.m_identifier_token.Visit (visitor, appData);
							break;
						case IdentifierList.production_kind.g_IdentifierList_2:
							// traverse syntax tree node associated with production
							// IdentifierList: IdentifierList "," identifier-token Left

							node.m_comma.Visit (visitor, appData);
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
			for (IdentifierList node = this; node != null; node = node.m_IdentifierList)
			{
				node.parent = parent;
				node.m_identifier_token?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule IdentifierList
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_IdentifierList = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (IdentifierList p_IdentifierList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<IdentifierList> stack = new Stack<IdentifierList> ();
			IdentifierList p_IdentifierList;
			for (p_IdentifierList = this; p_IdentifierList != null; p_IdentifierList = p_IdentifierList.m_IdentifierList)
				stack.Push (p_IdentifierList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule IdentifierList

		// counter of all nodes associated with syntax rule IdentifierList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule IdentifierList
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_IdentifierList")] public IdentifierList m_IdentifierList { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule IdentifierList

		// delegate function (callback) prototype associated with syntax rule IdentifierList
		public delegate bool IdentifierList_Callback (SyntaxTreeCallbackReason reason, IdentifierList.production_kind kind, IdentifierList p_IdentifierList);

		// event associated with syntax rule IdentifierList
		public event IdentifierList_Callback IdentifierList_Event;

		// event trigger associated with syntax rule IdentifierList
		public bool Raise_IdentifierList_Event (SyntaxTreeCallbackReason reason, IdentifierList.production_kind kind, IdentifierList p_IdentifierList)
		{
			bool? status = IdentifierList_Event?.Invoke (reason, kind, p_IdentifierList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule IdentifierList
		//
		// traverse syntax tree node associated with any production of syntax rule IdentifierList
		//

		public void Traverse (IdentifierList p_IdentifierList)
		{
			if (p_IdentifierList.isLocked())
				return;
			if (Raise_IdentifierList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (IdentifierList.production_kind) p_IdentifierList.kind, p_IdentifierList))
				p_IdentifierList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					IdentifierList.production_kind kind = (IdentifierList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_IdentifierList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case IdentifierList.production_kind.g_IdentifierList_1:
								// traverse syntax tree node associated with production
								// IdentifierList: identifier-token

								if (Raise_IdentifierList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_identifier_token);
								node.turn_inc ();
								Raise_IdentifierList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case IdentifierList.production_kind.g_IdentifierList_2:
								// traverse syntax tree node associated with production
								// IdentifierList: IdentifierList "," identifier-token Left

								if (Raise_IdentifierList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_IdentifierList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_identifier_token);
								node.turn_inc ();
								Raise_IdentifierList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_IdentifierList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_IdentifierList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (IdentifierList.production_kind) p_IdentifierList.kind, p_IdentifierList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule IdentifierList
		//

		public void TraverseCommon (IdentifierList p_IdentifierList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_IdentifierList.kind, p_IdentifierList))
				p_IdentifierList.Iterate (null, (node, appData) =>
				{
					IdentifierList.production_kind kind = (IdentifierList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case IdentifierList.production_kind.g_IdentifierList_1:
							// traverse syntax tree node associated with production
							// IdentifierList: identifier-token

							TraverseCommon (node.m_identifier_token);
							break;
						case IdentifierList.production_kind.g_IdentifierList_2:
							// traverse syntax tree node associated with production
							// IdentifierList: IdentifierList "," identifier-token Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_identifier_token);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_IdentifierList.kind, p_IdentifierList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule IdentifierList

		//
		// create syntax tree node associated with production
		// IdentifierList: identifier-token

		//

		public IdentifierList IdentifierList_1 (identifier_token p_identifier_token)
		{
			IdentifierList p_IdentifierList_ref = new IdentifierList(p_identifier_token);
			p_identifier_token.parent = p_IdentifierList_ref;
			Raise_IdentifierList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, IdentifierList.production_kind.g_IdentifierList_1, p_IdentifierList_ref);
			return p_IdentifierList_ref;
		}

		//
		// create syntax tree node associated with production
		// IdentifierList: IdentifierList "," identifier-token Left

		//

		public IdentifierList IdentifierList_2 (IdentifierList p_IdentifierList, SyntaxTreeToken p_token, identifier_token p_identifier_token)
		{
			IdentifierList p_IdentifierList_ref = new IdentifierList(p_IdentifierList, p_token, p_identifier_token);
			p_IdentifierList.parent = p_IdentifierList_ref;
			p_token.parent = p_IdentifierList_ref;
			p_identifier_token.parent = p_IdentifierList_ref;
			Raise_IdentifierList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, IdentifierList.production_kind.g_IdentifierList_2, p_IdentifierList_ref);
			return p_IdentifierList_ref;
		}
		#endregion
	};
}
