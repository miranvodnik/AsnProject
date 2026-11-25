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
	// class associated with syntax rule AtNotation-set
	//

	[DataContract]
	public class	AtNotation_set : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AtNotation-set
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AtNotation-set
		{
			g_AtNotation_set_1 = 1,	// AtNotation

			g_AtNotation_set_2 = 2,	// AtNotation-set "," AtNotation Left

		};
		#endregion
		#region production markers associated with the syntax rule AtNotation-set

		// markers associated with production: AtNotation-set -> AtNotation

		public enum production_marker_1 : ushort
		{
			m_AtNotation,
			final
		};

		// markers associated with production: AtNotation-set -> AtNotation-set "," AtNotation Left

		public enum production_marker_2 : ushort
		{
			m_AtNotation_set,
			m_AtNotation,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AtNotation-set

		// Constructor declaration(s) associated with production(s) of syntax rule AtNotation-set

		//
		// Constructor associated with the following production(s)
		// AtNotation-set -> AtNotation

		//

		public AtNotation_set (AtNotation p_AtNotation) : base ((uint) ProductionID._AtNotation_set_ID, (uint) production_kind.g_AtNotation_set_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AtNotation = p_AtNotation;
		}

		//
		// Constructor associated with the following production(s)
		// AtNotation-set -> AtNotation-set "," AtNotation Left

		//

		public AtNotation_set (AtNotation_set p_AtNotation_set, SyntaxTreeToken p_token, AtNotation p_AtNotation) : base ((uint) ProductionID._AtNotation_set_ID, (uint) production_kind.g_AtNotation_set_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_AtNotation_set = p_AtNotation_set;
			children[1] = m_comma = p_token;
			children[2] = m_AtNotation = p_AtNotation;
		}

		public AtNotation_set () { }

		// Copy constructor

		public AtNotation_set (AtNotation_set p_AtNotation_set) : base (p_AtNotation_set.id, p_AtNotation_set.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AtNotation_set.appInfo;
			switch ((production_kind) p_AtNotation_set.kind)
			{
				case production_kind.g_AtNotation_set_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AtNotation = (p_AtNotation_set.m_AtNotation != null) ? new AtNotation (p_AtNotation_set.m_AtNotation) : null) != null) m_AtNotation.parent = this;
					break;
				case production_kind.g_AtNotation_set_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_AtNotation_set = (p_AtNotation_set.m_AtNotation_set != null) ? new AtNotation_set (p_AtNotation_set.m_AtNotation_set) : null) != null) m_AtNotation_set.parent = this;
					if ((children [1] = m_comma = (p_AtNotation_set.m_comma != null) ? new SyntaxTreeToken (p_AtNotation_set.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_AtNotation = (p_AtNotation_set.m_AtNotation != null) ? new AtNotation (p_AtNotation_set.m_AtNotation) : null) != null) m_AtNotation.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AtNotation_set" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AtNotation_set (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_AtNotation?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AtNotation-set

		// Content changing function(s) associated with production(s) of syntax rule AtNotation-set

		//
		// Content changing function associated with following production(s)
		// AtNotation-set -> AtNotation

		//

		public void change(AtNotation p_AtNotation)
		{
			_init ();
			this.kind = (uint) production_kind.g_AtNotation_set_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AtNotation = p_AtNotation;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AtNotation-set -> AtNotation-set "," AtNotation Left

		//

		public void change(AtNotation_set p_AtNotation_set, SyntaxTreeToken p_token, AtNotation p_AtNotation)
		{
			_init ();
			this.kind = (uint) production_kind.g_AtNotation_set_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_AtNotation_set = p_AtNotation_set;
			children [1] = m_comma = p_token;
			children [2] = m_AtNotation = p_AtNotation;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AtNotation-set
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_AtNotation != null) && node.m_AtNotation.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AtNotation-set

		//
		// emit production tree node associated with any production of syntax rule AtNotation-set
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AtNotation_set_1:
						// emit syntax tree node associated with production
						// AtNotation-set: AtNotation

						s += " " + node.m_AtNotation.Emit (depth - 1);
						break;
					case production_kind.g_AtNotation_set_2:
						// emit syntax tree node associated with production
						// AtNotation-set: AtNotation-set "," AtNotation Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_AtNotation.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AtNotation-set
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "AtNotation_set (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AtNotation_set_1:
						// emit syntax tree node associated with production
						// AtNotation-set: AtNotation

						str += node.m_AtNotation.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_AtNotation_set_2:
						// emit syntax tree node associated with production
						// AtNotation-set: AtNotation-set "," AtNotation Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_AtNotation.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AtNotation-set

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AtNotation-set with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					AtNotation_set.production_kind kind = (AtNotation_set.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case AtNotation_set.production_kind.g_AtNotation_set_1:
							// traverse syntax tree node associated with production
							// AtNotation-set: AtNotation

							node.m_AtNotation.Visit (visitor, appData);
							break;
						case AtNotation_set.production_kind.g_AtNotation_set_2:
							// traverse syntax tree node associated with production
							// AtNotation-set: AtNotation-set "," AtNotation Left

							node.m_comma.Visit (visitor, appData);
							node.m_AtNotation.Visit (visitor, appData);
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
			for (AtNotation_set node = this; node != null; node = node.m_AtNotation_set)
			{
				node.parent = parent;
				node.m_AtNotation?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule AtNotation-set
		//

		public void _init ()
		{
			m_AtNotation = null;
			m_AtNotation_set = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (AtNotation_set p_AtNotation_set, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<AtNotation_set> stack = new Stack<AtNotation_set> ();
			AtNotation_set p_AtNotation_set;
			for (p_AtNotation_set = this; p_AtNotation_set != null; p_AtNotation_set = p_AtNotation_set.m_AtNotation_set)
				stack.Push (p_AtNotation_set);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AtNotation-set

		// counter of all nodes associated with syntax rule AtNotation-set
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AtNotation-set
		[DataMember (Name = "m_AtNotation")] public AtNotation m_AtNotation { get; private set; }
		[DataMember (Name = "m_AtNotation_set")] public AtNotation_set m_AtNotation_set { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AtNotation-set

		// delegate function (callback) prototype associated with syntax rule AtNotation-set
		public delegate bool AtNotation_set_Callback (SyntaxTreeCallbackReason reason, AtNotation_set.production_kind kind, AtNotation_set p_AtNotation_set);

		// event associated with syntax rule AtNotation-set
		public event AtNotation_set_Callback AtNotation_set_Event;

		// event trigger associated with syntax rule AtNotation-set
		public bool Raise_AtNotation_set_Event (SyntaxTreeCallbackReason reason, AtNotation_set.production_kind kind, AtNotation_set p_AtNotation_set)
		{
			bool? status = AtNotation_set_Event?.Invoke (reason, kind, p_AtNotation_set);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AtNotation-set
		//
		// traverse syntax tree node associated with any production of syntax rule AtNotation-set
		//

		public void Traverse (AtNotation_set p_AtNotation_set)
		{
			if (p_AtNotation_set.isLocked())
				return;
			if (Raise_AtNotation_set_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (AtNotation_set.production_kind) p_AtNotation_set.kind, p_AtNotation_set))
				p_AtNotation_set.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					AtNotation_set.production_kind kind = (AtNotation_set.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_AtNotation_set_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case AtNotation_set.production_kind.g_AtNotation_set_1:
								// traverse syntax tree node associated with production
								// AtNotation-set: AtNotation

								if (Raise_AtNotation_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AtNotation);
								node.turn_inc ();
								Raise_AtNotation_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case AtNotation_set.production_kind.g_AtNotation_set_2:
								// traverse syntax tree node associated with production
								// AtNotation-set: AtNotation-set "," AtNotation Left

								if (Raise_AtNotation_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_AtNotation_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AtNotation);
								node.turn_inc ();
								Raise_AtNotation_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_AtNotation_set_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_AtNotation_set_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (AtNotation_set.production_kind) p_AtNotation_set.kind, p_AtNotation_set);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AtNotation-set
		//

		public void TraverseCommon (AtNotation_set p_AtNotation_set)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_AtNotation_set.kind, p_AtNotation_set))
				p_AtNotation_set.Iterate (null, (node, appData) =>
				{
					AtNotation_set.production_kind kind = (AtNotation_set.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case AtNotation_set.production_kind.g_AtNotation_set_1:
							// traverse syntax tree node associated with production
							// AtNotation-set: AtNotation

							TraverseCommon (node.m_AtNotation);
							break;
						case AtNotation_set.production_kind.g_AtNotation_set_2:
							// traverse syntax tree node associated with production
							// AtNotation-set: AtNotation-set "," AtNotation Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_AtNotation);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_AtNotation_set.kind, p_AtNotation_set);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AtNotation-set

		//
		// create syntax tree node associated with production
		// AtNotation-set: AtNotation

		//

		public AtNotation_set AtNotation_set_1 (AtNotation p_AtNotation)
		{
			AtNotation_set p_AtNotation_set_ref = new AtNotation_set(p_AtNotation);
			p_AtNotation.parent = p_AtNotation_set_ref;
			Raise_AtNotation_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AtNotation_set.production_kind.g_AtNotation_set_1, p_AtNotation_set_ref);
			return p_AtNotation_set_ref;
		}

		//
		// create syntax tree node associated with production
		// AtNotation-set: AtNotation-set "," AtNotation Left

		//

		public AtNotation_set AtNotation_set_2 (AtNotation_set p_AtNotation_set, SyntaxTreeToken p_token, AtNotation p_AtNotation)
		{
			AtNotation_set p_AtNotation_set_ref = new AtNotation_set(p_AtNotation_set, p_token, p_AtNotation);
			p_AtNotation_set.parent = p_AtNotation_set_ref;
			p_token.parent = p_AtNotation_set_ref;
			p_AtNotation.parent = p_AtNotation_set_ref;
			Raise_AtNotation_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AtNotation_set.production_kind.g_AtNotation_set_2, p_AtNotation_set_ref);
			return p_AtNotation_set_ref;
		}
		#endregion
	};
}
