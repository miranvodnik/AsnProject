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
	// class associated with syntax rule TextList
	//

	[DataContract]
	public class	TextList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TextList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TextList
		{
			g_TextList_1 = 1,	// identifier-token

			g_TextList_2 = 2,	// TextList identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule TextList

		// markers associated with production: TextList -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};

		// markers associated with production: TextList -> TextList identifier-token

		public enum production_marker_2 : ushort
		{
			m_TextList,
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TextList

		// Constructor declaration(s) associated with production(s) of syntax rule TextList

		//
		// Constructor associated with the following production(s)
		// TextList -> identifier-token

		//

		public TextList (identifier_token p_identifier_token) : base ((uint) ProductionID._TextList_ID, (uint) production_kind.g_TextList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		//
		// Constructor associated with the following production(s)
		// TextList -> TextList identifier-token

		//

		public TextList (TextList p_TextList, identifier_token p_identifier_token) : base ((uint) ProductionID._TextList_ID, (uint) production_kind.g_TextList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_TextList = p_TextList;
			children[1] = m_identifier_token = p_identifier_token;
		}

		public TextList () { }

		// Copy constructor

		public TextList (TextList p_TextList) : base (p_TextList.id, p_TextList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TextList.appInfo;
			switch ((production_kind) p_TextList.kind)
			{
				case production_kind.g_TextList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_TextList.m_identifier_token != null) ? new identifier_token (p_TextList.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				case production_kind.g_TextList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_TextList = (p_TextList.m_TextList != null) ? new TextList (p_TextList.m_TextList) : null) != null) m_TextList.parent = this;
					if ((children [1] = m_identifier_token = (p_TextList.m_identifier_token != null) ? new identifier_token (p_TextList.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TextList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TextList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_identifier_token?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TextList

		// Content changing function(s) associated with production(s) of syntax rule TextList

		//
		// Content changing function associated with following production(s)
		// TextList -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_TextList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TextList -> TextList identifier-token

		//

		public void change(TextList p_TextList, identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_TextList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_TextList = p_TextList;
			children [1] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TextList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_identifier_token != null) && node.m_identifier_token.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TextList

		//
		// emit production tree node associated with any production of syntax rule TextList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_TextList_1:
						// emit syntax tree node associated with production
						// TextList: identifier-token

						s += " " + node.m_identifier_token.Emit (depth - 1);
						break;
					case production_kind.g_TextList_2:
						// emit syntax tree node associated with production
						// TextList: TextList identifier-token

						s += " " + node.m_identifier_token.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TextList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "TextList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_TextList_1:
						// emit syntax tree node associated with production
						// TextList: identifier-token

						str += node.m_identifier_token.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_TextList_2:
						// emit syntax tree node associated with production
						// TextList: TextList identifier-token

						str += ' ';
						str += node.m_identifier_token.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TextList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TextList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					TextList.production_kind kind = (TextList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case TextList.production_kind.g_TextList_1:
							// traverse syntax tree node associated with production
							// TextList: identifier-token

							node.m_identifier_token.Visit (visitor, appData);
							break;
						case TextList.production_kind.g_TextList_2:
							// traverse syntax tree node associated with production
							// TextList: TextList identifier-token

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
			for (TextList node = this; node != null; node = node.m_TextList)
			{
				node.parent = parent;
				node.m_identifier_token?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule TextList
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_TextList = null;
		}

		public delegate object IteratorDelegate (TextList p_TextList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<TextList> stack = new Stack<TextList> ();
			TextList p_TextList;
			for (p_TextList = this; p_TextList != null; p_TextList = p_TextList.m_TextList)
				stack.Push (p_TextList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TextList

		// counter of all nodes associated with syntax rule TextList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TextList
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_TextList")] public TextList m_TextList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TextList

		// delegate function (callback) prototype associated with syntax rule TextList
		public delegate bool TextList_Callback (SyntaxTreeCallbackReason reason, TextList.production_kind kind, TextList p_TextList);

		// event associated with syntax rule TextList
		public event TextList_Callback TextList_Event;

		// event trigger associated with syntax rule TextList
		public bool Raise_TextList_Event (SyntaxTreeCallbackReason reason, TextList.production_kind kind, TextList p_TextList)
		{
			bool? status = TextList_Event?.Invoke (reason, kind, p_TextList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TextList
		//
		// traverse syntax tree node associated with any production of syntax rule TextList
		//

		public void Traverse (TextList p_TextList)
		{
			if (p_TextList.isLocked())
				return;
			if (Raise_TextList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (TextList.production_kind) p_TextList.kind, p_TextList))
				p_TextList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					TextList.production_kind kind = (TextList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_TextList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case TextList.production_kind.g_TextList_1:
								// traverse syntax tree node associated with production
								// TextList: identifier-token

								if (Raise_TextList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_identifier_token);
								node.turn_inc ();
								Raise_TextList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case TextList.production_kind.g_TextList_2:
								// traverse syntax tree node associated with production
								// TextList: TextList identifier-token

								if (Raise_TextList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_TextList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_identifier_token);
								node.turn_inc ();
								Raise_TextList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_TextList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_TextList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (TextList.production_kind) p_TextList.kind, p_TextList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TextList
		//

		public void TraverseCommon (TextList p_TextList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_TextList.kind, p_TextList))
				p_TextList.Iterate (null, (node, appData) =>
				{
					TextList.production_kind kind = (TextList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case TextList.production_kind.g_TextList_1:
							// traverse syntax tree node associated with production
							// TextList: identifier-token

							TraverseCommon (node.m_identifier_token);
							break;
						case TextList.production_kind.g_TextList_2:
							// traverse syntax tree node associated with production
							// TextList: TextList identifier-token

							TraverseCommon (node.m_identifier_token);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_TextList.kind, p_TextList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TextList

		//
		// create syntax tree node associated with production
		// TextList: identifier-token

		//

		public TextList TextList_1 (identifier_token p_identifier_token)
		{
			TextList p_TextList_ref = new TextList(p_identifier_token);
			p_identifier_token.parent = p_TextList_ref;
			Raise_TextList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TextList.production_kind.g_TextList_1, p_TextList_ref);
			return p_TextList_ref;
		}

		//
		// create syntax tree node associated with production
		// TextList: TextList identifier-token

		//

		public TextList TextList_2 (TextList p_TextList, identifier_token p_identifier_token)
		{
			TextList p_TextList_ref = new TextList(p_TextList, p_identifier_token);
			p_TextList.parent = p_TextList_ref;
			p_identifier_token.parent = p_TextList_ref;
			Raise_TextList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TextList.production_kind.g_TextList_2, p_TextList_ref);
			return p_TextList_ref;
		}
		#endregion
	};
}
