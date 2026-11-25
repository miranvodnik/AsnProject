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
	// class associated with syntax rule DefinedSyntaxToken-set
	//

	[DataContract]
	public class	DefinedSyntaxToken_set : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinedSyntaxToken-set
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinedSyntaxToken-set
		{
			g_DefinedSyntaxToken_set_1 = 1,	// DefinedSyntaxToken

			g_DefinedSyntaxToken_set_2 = 2,	// DefinedSyntaxToken-set DefinedSyntaxToken

		};
		#endregion
		#region production markers associated with the syntax rule DefinedSyntaxToken-set

		// markers associated with production: DefinedSyntaxToken-set -> DefinedSyntaxToken

		public enum production_marker_1 : ushort
		{
			m_DefinedSyntaxToken,
			final
		};

		// markers associated with production: DefinedSyntaxToken-set -> DefinedSyntaxToken-set DefinedSyntaxToken

		public enum production_marker_2 : ushort
		{
			m_DefinedSyntaxToken_set,
			m_DefinedSyntaxToken,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinedSyntaxToken-set

		// Constructor declaration(s) associated with production(s) of syntax rule DefinedSyntaxToken-set

		//
		// Constructor associated with the following production(s)
		// DefinedSyntaxToken-set -> DefinedSyntaxToken

		//

		public DefinedSyntaxToken_set (DefinedSyntaxToken p_DefinedSyntaxToken) : base ((uint) ProductionID._DefinedSyntaxToken_set_ID, (uint) production_kind.g_DefinedSyntaxToken_set_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedSyntaxToken = p_DefinedSyntaxToken;
		}

		//
		// Constructor associated with the following production(s)
		// DefinedSyntaxToken-set -> DefinedSyntaxToken-set DefinedSyntaxToken

		//

		public DefinedSyntaxToken_set (DefinedSyntaxToken_set p_DefinedSyntaxToken_set, DefinedSyntaxToken p_DefinedSyntaxToken) : base ((uint) ProductionID._DefinedSyntaxToken_set_ID, (uint) production_kind.g_DefinedSyntaxToken_set_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DefinedSyntaxToken_set = p_DefinedSyntaxToken_set;
			children[1] = m_DefinedSyntaxToken = p_DefinedSyntaxToken;
		}

		public DefinedSyntaxToken_set () { }

		// Copy constructor

		public DefinedSyntaxToken_set (DefinedSyntaxToken_set p_DefinedSyntaxToken_set) : base (p_DefinedSyntaxToken_set.id, p_DefinedSyntaxToken_set.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinedSyntaxToken_set.appInfo;
			switch ((production_kind) p_DefinedSyntaxToken_set.kind)
			{
				case production_kind.g_DefinedSyntaxToken_set_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedSyntaxToken = (p_DefinedSyntaxToken_set.m_DefinedSyntaxToken != null) ? new DefinedSyntaxToken (p_DefinedSyntaxToken_set.m_DefinedSyntaxToken) : null) != null) m_DefinedSyntaxToken.parent = this;
					break;
				case production_kind.g_DefinedSyntaxToken_set_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DefinedSyntaxToken_set = (p_DefinedSyntaxToken_set.m_DefinedSyntaxToken_set != null) ? new DefinedSyntaxToken_set (p_DefinedSyntaxToken_set.m_DefinedSyntaxToken_set) : null) != null) m_DefinedSyntaxToken_set.parent = this;
					if ((children [1] = m_DefinedSyntaxToken = (p_DefinedSyntaxToken_set.m_DefinedSyntaxToken != null) ? new DefinedSyntaxToken (p_DefinedSyntaxToken_set.m_DefinedSyntaxToken) : null) != null) m_DefinedSyntaxToken.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinedSyntaxToken_set" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinedSyntaxToken_set (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_DefinedSyntaxToken?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinedSyntaxToken-set

		// Content changing function(s) associated with production(s) of syntax rule DefinedSyntaxToken-set

		//
		// Content changing function associated with following production(s)
		// DefinedSyntaxToken-set -> DefinedSyntaxToken

		//

		public void change(DefinedSyntaxToken p_DefinedSyntaxToken)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedSyntaxToken_set_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedSyntaxToken = p_DefinedSyntaxToken;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinedSyntaxToken-set -> DefinedSyntaxToken-set DefinedSyntaxToken

		//

		public void change(DefinedSyntaxToken_set p_DefinedSyntaxToken_set, DefinedSyntaxToken p_DefinedSyntaxToken)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedSyntaxToken_set_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DefinedSyntaxToken_set = p_DefinedSyntaxToken_set;
			children [1] = m_DefinedSyntaxToken = p_DefinedSyntaxToken;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinedSyntaxToken-set
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_DefinedSyntaxToken != null) && node.m_DefinedSyntaxToken.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinedSyntaxToken-set

		//
		// emit production tree node associated with any production of syntax rule DefinedSyntaxToken-set
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_DefinedSyntaxToken_set_1:
						// emit syntax tree node associated with production
						// DefinedSyntaxToken-set: DefinedSyntaxToken

						s += " " + node.m_DefinedSyntaxToken.Emit (depth - 1);
						break;
					case production_kind.g_DefinedSyntaxToken_set_2:
						// emit syntax tree node associated with production
						// DefinedSyntaxToken-set: DefinedSyntaxToken-set DefinedSyntaxToken

						s += " " + node.m_DefinedSyntaxToken.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinedSyntaxToken-set
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "DefinedSyntaxToken_set (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_DefinedSyntaxToken_set_1:
						// emit syntax tree node associated with production
						// DefinedSyntaxToken-set: DefinedSyntaxToken

						str += node.m_DefinedSyntaxToken.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_DefinedSyntaxToken_set_2:
						// emit syntax tree node associated with production
						// DefinedSyntaxToken-set: DefinedSyntaxToken-set DefinedSyntaxToken

						str += ' ';
						str += node.m_DefinedSyntaxToken.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinedSyntaxToken-set

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedSyntaxToken-set with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					DefinedSyntaxToken_set.production_kind kind = (DefinedSyntaxToken_set.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case DefinedSyntaxToken_set.production_kind.g_DefinedSyntaxToken_set_1:
							// traverse syntax tree node associated with production
							// DefinedSyntaxToken-set: DefinedSyntaxToken

							node.m_DefinedSyntaxToken.Visit (visitor, appData);
							break;
						case DefinedSyntaxToken_set.production_kind.g_DefinedSyntaxToken_set_2:
							// traverse syntax tree node associated with production
							// DefinedSyntaxToken-set: DefinedSyntaxToken-set DefinedSyntaxToken

							node.m_DefinedSyntaxToken.Visit (visitor, appData);
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
			for (DefinedSyntaxToken_set node = this; node != null; node = node.m_DefinedSyntaxToken_set)
			{
				node.parent = parent;
				node.m_DefinedSyntaxToken?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule DefinedSyntaxToken-set
		//

		public void _init ()
		{
			m_DefinedSyntaxToken = null;
			m_DefinedSyntaxToken_set = null;
		}

		public delegate object IteratorDelegate (DefinedSyntaxToken_set p_DefinedSyntaxToken_set, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<DefinedSyntaxToken_set> stack = new Stack<DefinedSyntaxToken_set> ();
			DefinedSyntaxToken_set p_DefinedSyntaxToken_set;
			for (p_DefinedSyntaxToken_set = this; p_DefinedSyntaxToken_set != null; p_DefinedSyntaxToken_set = p_DefinedSyntaxToken_set.m_DefinedSyntaxToken_set)
				stack.Push (p_DefinedSyntaxToken_set);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinedSyntaxToken-set

		// counter of all nodes associated with syntax rule DefinedSyntaxToken-set
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinedSyntaxToken-set
		[DataMember (Name = "m_DefinedSyntaxToken")] public DefinedSyntaxToken m_DefinedSyntaxToken { get; private set; }
		[DataMember (Name = "m_DefinedSyntaxToken_set")] public DefinedSyntaxToken_set m_DefinedSyntaxToken_set { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinedSyntaxToken-set

		// delegate function (callback) prototype associated with syntax rule DefinedSyntaxToken-set
		public delegate bool DefinedSyntaxToken_set_Callback (SyntaxTreeCallbackReason reason, DefinedSyntaxToken_set.production_kind kind, DefinedSyntaxToken_set p_DefinedSyntaxToken_set);

		// event associated with syntax rule DefinedSyntaxToken-set
		public event DefinedSyntaxToken_set_Callback DefinedSyntaxToken_set_Event;

		// event trigger associated with syntax rule DefinedSyntaxToken-set
		public bool Raise_DefinedSyntaxToken_set_Event (SyntaxTreeCallbackReason reason, DefinedSyntaxToken_set.production_kind kind, DefinedSyntaxToken_set p_DefinedSyntaxToken_set)
		{
			bool? status = DefinedSyntaxToken_set_Event?.Invoke (reason, kind, p_DefinedSyntaxToken_set);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinedSyntaxToken-set
		//
		// traverse syntax tree node associated with any production of syntax rule DefinedSyntaxToken-set
		//

		public void Traverse (DefinedSyntaxToken_set p_DefinedSyntaxToken_set)
		{
			if (p_DefinedSyntaxToken_set.isLocked())
				return;
			if (Raise_DefinedSyntaxToken_set_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (DefinedSyntaxToken_set.production_kind) p_DefinedSyntaxToken_set.kind, p_DefinedSyntaxToken_set))
				p_DefinedSyntaxToken_set.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					DefinedSyntaxToken_set.production_kind kind = (DefinedSyntaxToken_set.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_DefinedSyntaxToken_set_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case DefinedSyntaxToken_set.production_kind.g_DefinedSyntaxToken_set_1:
								// traverse syntax tree node associated with production
								// DefinedSyntaxToken-set: DefinedSyntaxToken

								if (Raise_DefinedSyntaxToken_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_DefinedSyntaxToken);
								node.turn_inc ();
								Raise_DefinedSyntaxToken_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case DefinedSyntaxToken_set.production_kind.g_DefinedSyntaxToken_set_2:
								// traverse syntax tree node associated with production
								// DefinedSyntaxToken-set: DefinedSyntaxToken-set DefinedSyntaxToken

								if (Raise_DefinedSyntaxToken_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_DefinedSyntaxToken_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_DefinedSyntaxToken);
								node.turn_inc ();
								Raise_DefinedSyntaxToken_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_DefinedSyntaxToken_set_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_DefinedSyntaxToken_set_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (DefinedSyntaxToken_set.production_kind) p_DefinedSyntaxToken_set.kind, p_DefinedSyntaxToken_set);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedSyntaxToken-set
		//

		public void TraverseCommon (DefinedSyntaxToken_set p_DefinedSyntaxToken_set)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_DefinedSyntaxToken_set.kind, p_DefinedSyntaxToken_set))
				p_DefinedSyntaxToken_set.Iterate (null, (node, appData) =>
				{
					DefinedSyntaxToken_set.production_kind kind = (DefinedSyntaxToken_set.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case DefinedSyntaxToken_set.production_kind.g_DefinedSyntaxToken_set_1:
							// traverse syntax tree node associated with production
							// DefinedSyntaxToken-set: DefinedSyntaxToken

							TraverseCommon (node.m_DefinedSyntaxToken);
							break;
						case DefinedSyntaxToken_set.production_kind.g_DefinedSyntaxToken_set_2:
							// traverse syntax tree node associated with production
							// DefinedSyntaxToken-set: DefinedSyntaxToken-set DefinedSyntaxToken

							TraverseCommon (node.m_DefinedSyntaxToken);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_DefinedSyntaxToken_set.kind, p_DefinedSyntaxToken_set);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinedSyntaxToken-set

		//
		// create syntax tree node associated with production
		// DefinedSyntaxToken-set: DefinedSyntaxToken

		//

		public DefinedSyntaxToken_set DefinedSyntaxToken_set_1 (DefinedSyntaxToken p_DefinedSyntaxToken)
		{
			DefinedSyntaxToken_set p_DefinedSyntaxToken_set_ref = new DefinedSyntaxToken_set(p_DefinedSyntaxToken);
			p_DefinedSyntaxToken.parent = p_DefinedSyntaxToken_set_ref;
			Raise_DefinedSyntaxToken_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedSyntaxToken_set.production_kind.g_DefinedSyntaxToken_set_1, p_DefinedSyntaxToken_set_ref);
			return p_DefinedSyntaxToken_set_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinedSyntaxToken-set: DefinedSyntaxToken-set DefinedSyntaxToken

		//

		public DefinedSyntaxToken_set DefinedSyntaxToken_set_2 (DefinedSyntaxToken_set p_DefinedSyntaxToken_set, DefinedSyntaxToken p_DefinedSyntaxToken)
		{
			DefinedSyntaxToken_set p_DefinedSyntaxToken_set_ref = new DefinedSyntaxToken_set(p_DefinedSyntaxToken_set, p_DefinedSyntaxToken);
			p_DefinedSyntaxToken_set.parent = p_DefinedSyntaxToken_set_ref;
			p_DefinedSyntaxToken.parent = p_DefinedSyntaxToken_set_ref;
			Raise_DefinedSyntaxToken_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedSyntaxToken_set.production_kind.g_DefinedSyntaxToken_set_2, p_DefinedSyntaxToken_set_ref);
			return p_DefinedSyntaxToken_set_ref;
		}
		#endregion
	};
}
