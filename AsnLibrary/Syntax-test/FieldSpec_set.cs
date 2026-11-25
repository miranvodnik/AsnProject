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
	// class associated with syntax rule FieldSpec-set
	//

	[DataContract]
	public class	FieldSpec_set : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule FieldSpec-set
		public enum production_kind : ushort	// enumerated production(s) of syntax rule FieldSpec-set
		{
			g_FieldSpec_set_1 = 1,	// FieldSpec

			g_FieldSpec_set_2 = 2,	// FieldSpec-set "," FieldSpec Left

		};
		#endregion
		#region production markers associated with the syntax rule FieldSpec-set

		// markers associated with production: FieldSpec-set -> FieldSpec

		public enum production_marker_1 : ushort
		{
			m_FieldSpec,
			final
		};

		// markers associated with production: FieldSpec-set -> FieldSpec-set "," FieldSpec Left

		public enum production_marker_2 : ushort
		{
			m_FieldSpec_set,
			m_FieldSpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule FieldSpec-set

		// Constructor declaration(s) associated with production(s) of syntax rule FieldSpec-set

		//
		// Constructor associated with the following production(s)
		// FieldSpec-set -> FieldSpec

		//

		public FieldSpec_set (FieldSpec p_FieldSpec) : base ((uint) ProductionID._FieldSpec_set_ID, (uint) production_kind.g_FieldSpec_set_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_FieldSpec = p_FieldSpec;
		}

		//
		// Constructor associated with the following production(s)
		// FieldSpec-set -> FieldSpec-set "," FieldSpec Left

		//

		public FieldSpec_set (FieldSpec_set p_FieldSpec_set, SyntaxTreeToken p_token, FieldSpec p_FieldSpec) : base ((uint) ProductionID._FieldSpec_set_ID, (uint) production_kind.g_FieldSpec_set_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_FieldSpec_set = p_FieldSpec_set;
			children[1] = m_comma = p_token;
			children[2] = m_FieldSpec = p_FieldSpec;
		}

		public FieldSpec_set () { }

		// Copy constructor

		public FieldSpec_set (FieldSpec_set p_FieldSpec_set) : base (p_FieldSpec_set.id, p_FieldSpec_set.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_FieldSpec_set.appInfo;
			switch ((production_kind) p_FieldSpec_set.kind)
			{
				case production_kind.g_FieldSpec_set_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_FieldSpec = (p_FieldSpec_set.m_FieldSpec != null) ? new FieldSpec (p_FieldSpec_set.m_FieldSpec) : null) != null) m_FieldSpec.parent = this;
					break;
				case production_kind.g_FieldSpec_set_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_FieldSpec_set = (p_FieldSpec_set.m_FieldSpec_set != null) ? new FieldSpec_set (p_FieldSpec_set.m_FieldSpec_set) : null) != null) m_FieldSpec_set.parent = this;
					if ((children [1] = m_comma = (p_FieldSpec_set.m_comma != null) ? new SyntaxTreeToken (p_FieldSpec_set.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_FieldSpec = (p_FieldSpec_set.m_FieldSpec != null) ? new FieldSpec (p_FieldSpec_set.m_FieldSpec) : null) != null) m_FieldSpec.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "FieldSpec_set" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new FieldSpec_set (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_FieldSpec?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule FieldSpec-set

		// Content changing function(s) associated with production(s) of syntax rule FieldSpec-set

		//
		// Content changing function associated with following production(s)
		// FieldSpec-set -> FieldSpec

		//

		public void change(FieldSpec p_FieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldSpec_set_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_FieldSpec = p_FieldSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// FieldSpec-set -> FieldSpec-set "," FieldSpec Left

		//

		public void change(FieldSpec_set p_FieldSpec_set, SyntaxTreeToken p_token, FieldSpec p_FieldSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldSpec_set_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_FieldSpec_set = p_FieldSpec_set;
			children [1] = m_comma = p_token;
			children [2] = m_FieldSpec = p_FieldSpec;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule FieldSpec-set
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_FieldSpec != null) && node.m_FieldSpec.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule FieldSpec-set

		//
		// emit production tree node associated with any production of syntax rule FieldSpec-set
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_FieldSpec_set_1:
						// emit syntax tree node associated with production
						// FieldSpec-set: FieldSpec

						s += " " + node.m_FieldSpec.Emit (depth - 1);
						break;
					case production_kind.g_FieldSpec_set_2:
						// emit syntax tree node associated with production
						// FieldSpec-set: FieldSpec-set "," FieldSpec Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_FieldSpec.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule FieldSpec-set
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "FieldSpec_set (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_FieldSpec_set_1:
						// emit syntax tree node associated with production
						// FieldSpec-set: FieldSpec

						str += node.m_FieldSpec.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_FieldSpec_set_2:
						// emit syntax tree node associated with production
						// FieldSpec-set: FieldSpec-set "," FieldSpec Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_FieldSpec.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule FieldSpec-set

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule FieldSpec-set with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					FieldSpec_set.production_kind kind = (FieldSpec_set.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case FieldSpec_set.production_kind.g_FieldSpec_set_1:
							// traverse syntax tree node associated with production
							// FieldSpec-set: FieldSpec

							node.m_FieldSpec.Visit (visitor, appData);
							break;
						case FieldSpec_set.production_kind.g_FieldSpec_set_2:
							// traverse syntax tree node associated with production
							// FieldSpec-set: FieldSpec-set "," FieldSpec Left

							node.m_comma.Visit (visitor, appData);
							node.m_FieldSpec.Visit (visitor, appData);
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
			for (FieldSpec_set node = this; node != null; node = node.m_FieldSpec_set)
			{
				node.parent = parent;
				node.m_FieldSpec?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule FieldSpec-set
		//

		public void _init ()
		{
			m_FieldSpec = null;
			m_FieldSpec_set = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (FieldSpec_set p_FieldSpec_set, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<FieldSpec_set> stack = new Stack<FieldSpec_set> ();
			FieldSpec_set p_FieldSpec_set;
			for (p_FieldSpec_set = this; p_FieldSpec_set != null; p_FieldSpec_set = p_FieldSpec_set.m_FieldSpec_set)
				stack.Push (p_FieldSpec_set);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule FieldSpec-set

		// counter of all nodes associated with syntax rule FieldSpec-set
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule FieldSpec-set
		[DataMember (Name = "m_FieldSpec")] public FieldSpec m_FieldSpec { get; private set; }
		[DataMember (Name = "m_FieldSpec_set")] public FieldSpec_set m_FieldSpec_set { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule FieldSpec-set

		// delegate function (callback) prototype associated with syntax rule FieldSpec-set
		public delegate bool FieldSpec_set_Callback (SyntaxTreeCallbackReason reason, FieldSpec_set.production_kind kind, FieldSpec_set p_FieldSpec_set);

		// event associated with syntax rule FieldSpec-set
		public event FieldSpec_set_Callback FieldSpec_set_Event;

		// event trigger associated with syntax rule FieldSpec-set
		public bool Raise_FieldSpec_set_Event (SyntaxTreeCallbackReason reason, FieldSpec_set.production_kind kind, FieldSpec_set p_FieldSpec_set)
		{
			bool? status = FieldSpec_set_Event?.Invoke (reason, kind, p_FieldSpec_set);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule FieldSpec-set
		//
		// traverse syntax tree node associated with any production of syntax rule FieldSpec-set
		//

		public void Traverse (FieldSpec_set p_FieldSpec_set)
		{
			if (p_FieldSpec_set.isLocked())
				return;
			if (Raise_FieldSpec_set_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (FieldSpec_set.production_kind) p_FieldSpec_set.kind, p_FieldSpec_set))
				p_FieldSpec_set.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					FieldSpec_set.production_kind kind = (FieldSpec_set.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_FieldSpec_set_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case FieldSpec_set.production_kind.g_FieldSpec_set_1:
								// traverse syntax tree node associated with production
								// FieldSpec-set: FieldSpec

								if (Raise_FieldSpec_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_FieldSpec);
								node.turn_inc ();
								Raise_FieldSpec_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case FieldSpec_set.production_kind.g_FieldSpec_set_2:
								// traverse syntax tree node associated with production
								// FieldSpec-set: FieldSpec-set "," FieldSpec Left

								if (Raise_FieldSpec_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_FieldSpec_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_FieldSpec);
								node.turn_inc ();
								Raise_FieldSpec_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_FieldSpec_set_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_FieldSpec_set_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (FieldSpec_set.production_kind) p_FieldSpec_set.kind, p_FieldSpec_set);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule FieldSpec-set
		//

		public void TraverseCommon (FieldSpec_set p_FieldSpec_set)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_FieldSpec_set.kind, p_FieldSpec_set))
				p_FieldSpec_set.Iterate (null, (node, appData) =>
				{
					FieldSpec_set.production_kind kind = (FieldSpec_set.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case FieldSpec_set.production_kind.g_FieldSpec_set_1:
							// traverse syntax tree node associated with production
							// FieldSpec-set: FieldSpec

							TraverseCommon (node.m_FieldSpec);
							break;
						case FieldSpec_set.production_kind.g_FieldSpec_set_2:
							// traverse syntax tree node associated with production
							// FieldSpec-set: FieldSpec-set "," FieldSpec Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_FieldSpec);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_FieldSpec_set.kind, p_FieldSpec_set);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule FieldSpec-set

		//
		// create syntax tree node associated with production
		// FieldSpec-set: FieldSpec

		//

		public FieldSpec_set FieldSpec_set_1 (FieldSpec p_FieldSpec)
		{
			FieldSpec_set p_FieldSpec_set_ref = new FieldSpec_set(p_FieldSpec);
			p_FieldSpec.parent = p_FieldSpec_set_ref;
			Raise_FieldSpec_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldSpec_set.production_kind.g_FieldSpec_set_1, p_FieldSpec_set_ref);
			return p_FieldSpec_set_ref;
		}

		//
		// create syntax tree node associated with production
		// FieldSpec-set: FieldSpec-set "," FieldSpec Left

		//

		public FieldSpec_set FieldSpec_set_2 (FieldSpec_set p_FieldSpec_set, SyntaxTreeToken p_token, FieldSpec p_FieldSpec)
		{
			FieldSpec_set p_FieldSpec_set_ref = new FieldSpec_set(p_FieldSpec_set, p_token, p_FieldSpec);
			p_FieldSpec_set.parent = p_FieldSpec_set_ref;
			p_token.parent = p_FieldSpec_set_ref;
			p_FieldSpec.parent = p_FieldSpec_set_ref;
			Raise_FieldSpec_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldSpec_set.production_kind.g_FieldSpec_set_2, p_FieldSpec_set_ref);
			return p_FieldSpec_set_ref;
		}
		#endregion
	};
}
