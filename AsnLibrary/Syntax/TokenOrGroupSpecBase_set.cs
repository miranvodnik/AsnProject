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
	// class associated with syntax rule TokenOrGroupSpecBase-set
	//

	[DataContract]
	public class	TokenOrGroupSpecBase_set : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TokenOrGroupSpecBase-set
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TokenOrGroupSpecBase-set
		{
			g_TokenOrGroupSpecBase_set_1 = 1,	// TokenOrGroupSpecBase

			g_TokenOrGroupSpecBase_set_2 = 2,	// TokenOrGroupSpecBase-set TokenOrGroupSpecBase

		};
		#endregion
		#region production markers associated with the syntax rule TokenOrGroupSpecBase-set

		// markers associated with production: TokenOrGroupSpecBase-set -> TokenOrGroupSpecBase

		public enum production_marker_1 : ushort
		{
			m_TokenOrGroupSpecBase,
			final
		};

		// markers associated with production: TokenOrGroupSpecBase-set -> TokenOrGroupSpecBase-set TokenOrGroupSpecBase

		public enum production_marker_2 : ushort
		{
			m_TokenOrGroupSpecBase_set,
			m_TokenOrGroupSpecBase,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TokenOrGroupSpecBase-set

		// Constructor declaration(s) associated with production(s) of syntax rule TokenOrGroupSpecBase-set

		//
		// Constructor associated with the following production(s)
		// TokenOrGroupSpecBase-set -> TokenOrGroupSpecBase

		//

		public TokenOrGroupSpecBase_set (TokenOrGroupSpecBase p_TokenOrGroupSpecBase) : base ((uint) ProductionID._TokenOrGroupSpecBase_set_ID, (uint) production_kind.g_TokenOrGroupSpecBase_set_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TokenOrGroupSpecBase = p_TokenOrGroupSpecBase;
		}

		//
		// Constructor associated with the following production(s)
		// TokenOrGroupSpecBase-set -> TokenOrGroupSpecBase-set TokenOrGroupSpecBase

		//

		public TokenOrGroupSpecBase_set (TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set, TokenOrGroupSpecBase p_TokenOrGroupSpecBase) : base ((uint) ProductionID._TokenOrGroupSpecBase_set_ID, (uint) production_kind.g_TokenOrGroupSpecBase_set_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_TokenOrGroupSpecBase_set = p_TokenOrGroupSpecBase_set;
			children[1] = m_TokenOrGroupSpecBase = p_TokenOrGroupSpecBase;
		}

		public TokenOrGroupSpecBase_set () { }

		// Copy constructor

		public TokenOrGroupSpecBase_set (TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set) : base (p_TokenOrGroupSpecBase_set.id, p_TokenOrGroupSpecBase_set.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TokenOrGroupSpecBase_set.appInfo;
			switch ((production_kind) p_TokenOrGroupSpecBase_set.kind)
			{
				case production_kind.g_TokenOrGroupSpecBase_set_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TokenOrGroupSpecBase = (p_TokenOrGroupSpecBase_set.m_TokenOrGroupSpecBase != null) ? new TokenOrGroupSpecBase (p_TokenOrGroupSpecBase_set.m_TokenOrGroupSpecBase) : null) != null) m_TokenOrGroupSpecBase.parent = this;
					break;
				case production_kind.g_TokenOrGroupSpecBase_set_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_TokenOrGroupSpecBase_set = (p_TokenOrGroupSpecBase_set.m_TokenOrGroupSpecBase_set != null) ? new TokenOrGroupSpecBase_set (p_TokenOrGroupSpecBase_set.m_TokenOrGroupSpecBase_set) : null) != null) m_TokenOrGroupSpecBase_set.parent = this;
					if ((children [1] = m_TokenOrGroupSpecBase = (p_TokenOrGroupSpecBase_set.m_TokenOrGroupSpecBase != null) ? new TokenOrGroupSpecBase (p_TokenOrGroupSpecBase_set.m_TokenOrGroupSpecBase) : null) != null) m_TokenOrGroupSpecBase.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TokenOrGroupSpecBase_set" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TokenOrGroupSpecBase_set (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_TokenOrGroupSpecBase?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TokenOrGroupSpecBase-set

		// Content changing function(s) associated with production(s) of syntax rule TokenOrGroupSpecBase-set

		//
		// Content changing function associated with following production(s)
		// TokenOrGroupSpecBase-set -> TokenOrGroupSpecBase

		//

		public void change(TokenOrGroupSpecBase p_TokenOrGroupSpecBase)
		{
			_init ();
			this.kind = (uint) production_kind.g_TokenOrGroupSpecBase_set_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TokenOrGroupSpecBase = p_TokenOrGroupSpecBase;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TokenOrGroupSpecBase-set -> TokenOrGroupSpecBase-set TokenOrGroupSpecBase

		//

		public void change(TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set, TokenOrGroupSpecBase p_TokenOrGroupSpecBase)
		{
			_init ();
			this.kind = (uint) production_kind.g_TokenOrGroupSpecBase_set_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_TokenOrGroupSpecBase_set = p_TokenOrGroupSpecBase_set;
			children [1] = m_TokenOrGroupSpecBase = p_TokenOrGroupSpecBase;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TokenOrGroupSpecBase-set
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_TokenOrGroupSpecBase != null) && node.m_TokenOrGroupSpecBase.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TokenOrGroupSpecBase-set

		//
		// emit production tree node associated with any production of syntax rule TokenOrGroupSpecBase-set
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_TokenOrGroupSpecBase_set_1:
						// emit syntax tree node associated with production
						// TokenOrGroupSpecBase-set: TokenOrGroupSpecBase

						s += " " + node.m_TokenOrGroupSpecBase.Emit (depth - 1);
						break;
					case production_kind.g_TokenOrGroupSpecBase_set_2:
						// emit syntax tree node associated with production
						// TokenOrGroupSpecBase-set: TokenOrGroupSpecBase-set TokenOrGroupSpecBase

						s += " " + node.m_TokenOrGroupSpecBase.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TokenOrGroupSpecBase-set
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "TokenOrGroupSpecBase_set (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_TokenOrGroupSpecBase_set_1:
						// emit syntax tree node associated with production
						// TokenOrGroupSpecBase-set: TokenOrGroupSpecBase

						str += node.m_TokenOrGroupSpecBase.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_TokenOrGroupSpecBase_set_2:
						// emit syntax tree node associated with production
						// TokenOrGroupSpecBase-set: TokenOrGroupSpecBase-set TokenOrGroupSpecBase

						str += ' ';
						str += node.m_TokenOrGroupSpecBase.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TokenOrGroupSpecBase-set

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TokenOrGroupSpecBase-set with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					TokenOrGroupSpecBase_set.production_kind kind = (TokenOrGroupSpecBase_set.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case TokenOrGroupSpecBase_set.production_kind.g_TokenOrGroupSpecBase_set_1:
							// traverse syntax tree node associated with production
							// TokenOrGroupSpecBase-set: TokenOrGroupSpecBase

							node.m_TokenOrGroupSpecBase.Visit (visitor, appData);
							break;
						case TokenOrGroupSpecBase_set.production_kind.g_TokenOrGroupSpecBase_set_2:
							// traverse syntax tree node associated with production
							// TokenOrGroupSpecBase-set: TokenOrGroupSpecBase-set TokenOrGroupSpecBase

							node.m_TokenOrGroupSpecBase.Visit (visitor, appData);
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
			for (TokenOrGroupSpecBase_set node = this; node != null; node = node.m_TokenOrGroupSpecBase_set)
			{
				node.parent = parent;
				node.m_TokenOrGroupSpecBase?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule TokenOrGroupSpecBase-set
		//

		public void _init ()
		{
			m_TokenOrGroupSpecBase = null;
			m_TokenOrGroupSpecBase_set = null;
		}

		public delegate object IteratorDelegate (TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<TokenOrGroupSpecBase_set> stack = new Stack<TokenOrGroupSpecBase_set> ();
			TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set;
			for (p_TokenOrGroupSpecBase_set = this; p_TokenOrGroupSpecBase_set != null; p_TokenOrGroupSpecBase_set = p_TokenOrGroupSpecBase_set.m_TokenOrGroupSpecBase_set)
				stack.Push (p_TokenOrGroupSpecBase_set);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TokenOrGroupSpecBase-set

		// counter of all nodes associated with syntax rule TokenOrGroupSpecBase-set
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TokenOrGroupSpecBase-set
		[DataMember (Name = "m_TokenOrGroupSpecBase")] public TokenOrGroupSpecBase m_TokenOrGroupSpecBase { get; private set; }
		[DataMember (Name = "m_TokenOrGroupSpecBase_set")] public TokenOrGroupSpecBase_set m_TokenOrGroupSpecBase_set { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TokenOrGroupSpecBase-set

		// delegate function (callback) prototype associated with syntax rule TokenOrGroupSpecBase-set
		public delegate bool TokenOrGroupSpecBase_set_Callback (SyntaxTreeCallbackReason reason, TokenOrGroupSpecBase_set.production_kind kind, TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set);

		// event associated with syntax rule TokenOrGroupSpecBase-set
		public event TokenOrGroupSpecBase_set_Callback TokenOrGroupSpecBase_set_Event;

		// event trigger associated with syntax rule TokenOrGroupSpecBase-set
		public bool Raise_TokenOrGroupSpecBase_set_Event (SyntaxTreeCallbackReason reason, TokenOrGroupSpecBase_set.production_kind kind, TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set)
		{
			bool? status = TokenOrGroupSpecBase_set_Event?.Invoke (reason, kind, p_TokenOrGroupSpecBase_set);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TokenOrGroupSpecBase-set
		//
		// traverse syntax tree node associated with any production of syntax rule TokenOrGroupSpecBase-set
		//

		public void Traverse (TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set)
		{
			if (p_TokenOrGroupSpecBase_set.isLocked())
				return;
			if (Raise_TokenOrGroupSpecBase_set_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (TokenOrGroupSpecBase_set.production_kind) p_TokenOrGroupSpecBase_set.kind, p_TokenOrGroupSpecBase_set))
				p_TokenOrGroupSpecBase_set.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					TokenOrGroupSpecBase_set.production_kind kind = (TokenOrGroupSpecBase_set.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_TokenOrGroupSpecBase_set_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case TokenOrGroupSpecBase_set.production_kind.g_TokenOrGroupSpecBase_set_1:
								// traverse syntax tree node associated with production
								// TokenOrGroupSpecBase-set: TokenOrGroupSpecBase

								if (Raise_TokenOrGroupSpecBase_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_TokenOrGroupSpecBase);
								node.turn_inc ();
								Raise_TokenOrGroupSpecBase_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case TokenOrGroupSpecBase_set.production_kind.g_TokenOrGroupSpecBase_set_2:
								// traverse syntax tree node associated with production
								// TokenOrGroupSpecBase-set: TokenOrGroupSpecBase-set TokenOrGroupSpecBase

								if (Raise_TokenOrGroupSpecBase_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_TokenOrGroupSpecBase_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_TokenOrGroupSpecBase);
								node.turn_inc ();
								Raise_TokenOrGroupSpecBase_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_TokenOrGroupSpecBase_set_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_TokenOrGroupSpecBase_set_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (TokenOrGroupSpecBase_set.production_kind) p_TokenOrGroupSpecBase_set.kind, p_TokenOrGroupSpecBase_set);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TokenOrGroupSpecBase-set
		//

		public void TraverseCommon (TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_TokenOrGroupSpecBase_set.kind, p_TokenOrGroupSpecBase_set))
				p_TokenOrGroupSpecBase_set.Iterate (null, (node, appData) =>
				{
					TokenOrGroupSpecBase_set.production_kind kind = (TokenOrGroupSpecBase_set.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case TokenOrGroupSpecBase_set.production_kind.g_TokenOrGroupSpecBase_set_1:
							// traverse syntax tree node associated with production
							// TokenOrGroupSpecBase-set: TokenOrGroupSpecBase

							TraverseCommon (node.m_TokenOrGroupSpecBase);
							break;
						case TokenOrGroupSpecBase_set.production_kind.g_TokenOrGroupSpecBase_set_2:
							// traverse syntax tree node associated with production
							// TokenOrGroupSpecBase-set: TokenOrGroupSpecBase-set TokenOrGroupSpecBase

							TraverseCommon (node.m_TokenOrGroupSpecBase);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_TokenOrGroupSpecBase_set.kind, p_TokenOrGroupSpecBase_set);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TokenOrGroupSpecBase-set

		//
		// create syntax tree node associated with production
		// TokenOrGroupSpecBase-set: TokenOrGroupSpecBase

		//

		public TokenOrGroupSpecBase_set TokenOrGroupSpecBase_set_1 (TokenOrGroupSpecBase p_TokenOrGroupSpecBase)
		{
			TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set_ref = new TokenOrGroupSpecBase_set(p_TokenOrGroupSpecBase);
			p_TokenOrGroupSpecBase.parent = p_TokenOrGroupSpecBase_set_ref;
			Raise_TokenOrGroupSpecBase_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TokenOrGroupSpecBase_set.production_kind.g_TokenOrGroupSpecBase_set_1, p_TokenOrGroupSpecBase_set_ref);
			return p_TokenOrGroupSpecBase_set_ref;
		}

		//
		// create syntax tree node associated with production
		// TokenOrGroupSpecBase-set: TokenOrGroupSpecBase-set TokenOrGroupSpecBase

		//

		public TokenOrGroupSpecBase_set TokenOrGroupSpecBase_set_2 (TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set, TokenOrGroupSpecBase p_TokenOrGroupSpecBase)
		{
			TokenOrGroupSpecBase_set p_TokenOrGroupSpecBase_set_ref = new TokenOrGroupSpecBase_set(p_TokenOrGroupSpecBase_set, p_TokenOrGroupSpecBase);
			p_TokenOrGroupSpecBase_set.parent = p_TokenOrGroupSpecBase_set_ref;
			p_TokenOrGroupSpecBase.parent = p_TokenOrGroupSpecBase_set_ref;
			Raise_TokenOrGroupSpecBase_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TokenOrGroupSpecBase_set.production_kind.g_TokenOrGroupSpecBase_set_2, p_TokenOrGroupSpecBase_set_ref);
			return p_TokenOrGroupSpecBase_set_ref;
		}
		#endregion
	};
}
