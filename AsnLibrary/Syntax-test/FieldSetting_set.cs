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
	// class associated with syntax rule FieldSetting-set
	//

	[DataContract]
	public class	FieldSetting_set : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule FieldSetting-set
		public enum production_kind : ushort	// enumerated production(s) of syntax rule FieldSetting-set
		{
			g_FieldSetting_set_1 = 1,	// FieldSetting

			g_FieldSetting_set_2 = 2,	// FieldSetting-set <generated-rule-4> FieldSetting Left

		};
		#endregion
		#region production markers associated with the syntax rule FieldSetting-set

		// markers associated with production: FieldSetting-set -> FieldSetting

		public enum production_marker_1 : ushort
		{
			m_FieldSetting,
			final
		};

		// markers associated with production: FieldSetting-set -> FieldSetting-set <generated-rule-4> FieldSetting Left

		public enum production_marker_2 : ushort
		{
			m_FieldSetting_set,
			m__generated_rule_4_,
			m_FieldSetting,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule FieldSetting-set

		// Constructor declaration(s) associated with production(s) of syntax rule FieldSetting-set

		//
		// Constructor associated with the following production(s)
		// FieldSetting-set -> FieldSetting

		//

		public FieldSetting_set (FieldSetting p_FieldSetting) : base ((uint) ProductionID._FieldSetting_set_ID, (uint) production_kind.g_FieldSetting_set_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_FieldSetting = p_FieldSetting;
		}

		//
		// Constructor associated with the following production(s)
		// FieldSetting-set -> FieldSetting-set <generated-rule-4> FieldSetting Left

		//

		public FieldSetting_set (FieldSetting_set p_FieldSetting_set, _generated_rule_4_ p__generated_rule_4_, FieldSetting p_FieldSetting) : base ((uint) ProductionID._FieldSetting_set_ID, (uint) production_kind.g_FieldSetting_set_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_FieldSetting_set = p_FieldSetting_set;
			children[1] = m__generated_rule_4_ = p__generated_rule_4_;
			children[2] = m_FieldSetting = p_FieldSetting;
		}

		public FieldSetting_set () { }

		// Copy constructor

		public FieldSetting_set (FieldSetting_set p_FieldSetting_set) : base (p_FieldSetting_set.id, p_FieldSetting_set.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_FieldSetting_set.appInfo;
			switch ((production_kind) p_FieldSetting_set.kind)
			{
				case production_kind.g_FieldSetting_set_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_FieldSetting = (p_FieldSetting_set.m_FieldSetting != null) ? new FieldSetting (p_FieldSetting_set.m_FieldSetting) : null) != null) m_FieldSetting.parent = this;
					break;
				case production_kind.g_FieldSetting_set_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_FieldSetting_set = (p_FieldSetting_set.m_FieldSetting_set != null) ? new FieldSetting_set (p_FieldSetting_set.m_FieldSetting_set) : null) != null) m_FieldSetting_set.parent = this;
					if ((children [1] = m__generated_rule_4_ = (p_FieldSetting_set.m__generated_rule_4_ != null) ? new _generated_rule_4_ (p_FieldSetting_set.m__generated_rule_4_) : null) != null) m__generated_rule_4_.parent = this;
					if ((children [2] = m_FieldSetting = (p_FieldSetting_set.m_FieldSetting != null) ? new FieldSetting (p_FieldSetting_set.m_FieldSetting) : null) != null) m_FieldSetting.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "FieldSetting_set" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new FieldSetting_set (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_FieldSetting?.Dispose ();
				node.m__generated_rule_4_?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule FieldSetting-set

		// Content changing function(s) associated with production(s) of syntax rule FieldSetting-set

		//
		// Content changing function associated with following production(s)
		// FieldSetting-set -> FieldSetting

		//

		public void change(FieldSetting p_FieldSetting)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldSetting_set_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_FieldSetting = p_FieldSetting;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// FieldSetting-set -> FieldSetting-set <generated-rule-4> FieldSetting Left

		//

		public void change(FieldSetting_set p_FieldSetting_set, _generated_rule_4_ p__generated_rule_4_, FieldSetting p_FieldSetting)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldSetting_set_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_FieldSetting_set = p_FieldSetting_set;
			children [1] = m__generated_rule_4_ = p__generated_rule_4_;
			children [2] = m_FieldSetting = p_FieldSetting;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule FieldSetting-set
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_FieldSetting != null) && node.m_FieldSetting.checkInclusion (element) ||
					(node.m__generated_rule_4_ != null) && node.m__generated_rule_4_.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule FieldSetting-set

		//
		// emit production tree node associated with any production of syntax rule FieldSetting-set
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_FieldSetting_set_1:
						// emit syntax tree node associated with production
						// FieldSetting-set: FieldSetting

						s += " " + node.m_FieldSetting.Emit (depth - 1);
						break;
					case production_kind.g_FieldSetting_set_2:
						// emit syntax tree node associated with production
						// FieldSetting-set: FieldSetting-set <generated-rule-4> FieldSetting Left

						s += " " + node.m__generated_rule_4_.Emit (depth - 1);
						s += " " + node.m_FieldSetting.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule FieldSetting-set
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "FieldSetting_set (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_FieldSetting_set_1:
						// emit syntax tree node associated with production
						// FieldSetting-set: FieldSetting

						str += node.m_FieldSetting.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_FieldSetting_set_2:
						// emit syntax tree node associated with production
						// FieldSetting-set: FieldSetting-set <generated-rule-4> FieldSetting Left

						str += ' ';
						str += node.m__generated_rule_4_.EmitProductionTree (depth - 1);
						str += ' ';
						str += node.m_FieldSetting.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule FieldSetting-set

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule FieldSetting-set with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					FieldSetting_set.production_kind kind = (FieldSetting_set.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case FieldSetting_set.production_kind.g_FieldSetting_set_1:
							// traverse syntax tree node associated with production
							// FieldSetting-set: FieldSetting

							node.m_FieldSetting.Visit (visitor, appData);
							break;
						case FieldSetting_set.production_kind.g_FieldSetting_set_2:
							// traverse syntax tree node associated with production
							// FieldSetting-set: FieldSetting-set <generated-rule-4> FieldSetting Left

							node.m__generated_rule_4_.Visit (visitor, appData);
							node.m_FieldSetting.Visit (visitor, appData);
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
			for (FieldSetting_set node = this; node != null; node = node.m_FieldSetting_set)
			{
				node.parent = parent;
				node.m_FieldSetting?.reparent (parent);
				node.m__generated_rule_4_?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule FieldSetting-set
		//

		public void _init ()
		{
			m_FieldSetting = null;
			m_FieldSetting_set = null;
			m__generated_rule_4_ = null;
		}

		public delegate object IteratorDelegate (FieldSetting_set p_FieldSetting_set, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<FieldSetting_set> stack = new Stack<FieldSetting_set> ();
			FieldSetting_set p_FieldSetting_set;
			for (p_FieldSetting_set = this; p_FieldSetting_set != null; p_FieldSetting_set = p_FieldSetting_set.m_FieldSetting_set)
				stack.Push (p_FieldSetting_set);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule FieldSetting-set

		// counter of all nodes associated with syntax rule FieldSetting-set
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule FieldSetting-set
		[DataMember (Name = "m_FieldSetting")] public FieldSetting m_FieldSetting { get; private set; }
		[DataMember (Name = "m_FieldSetting_set")] public FieldSetting_set m_FieldSetting_set { get; private set; }
		[DataMember (Name = "m__generated_rule_4_")] public _generated_rule_4_ m__generated_rule_4_ { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule FieldSetting-set

		// delegate function (callback) prototype associated with syntax rule FieldSetting-set
		public delegate bool FieldSetting_set_Callback (SyntaxTreeCallbackReason reason, FieldSetting_set.production_kind kind, FieldSetting_set p_FieldSetting_set);

		// event associated with syntax rule FieldSetting-set
		public event FieldSetting_set_Callback FieldSetting_set_Event;

		// event trigger associated with syntax rule FieldSetting-set
		public bool Raise_FieldSetting_set_Event (SyntaxTreeCallbackReason reason, FieldSetting_set.production_kind kind, FieldSetting_set p_FieldSetting_set)
		{
			bool? status = FieldSetting_set_Event?.Invoke (reason, kind, p_FieldSetting_set);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule FieldSetting-set
		//
		// traverse syntax tree node associated with any production of syntax rule FieldSetting-set
		//

		public void Traverse (FieldSetting_set p_FieldSetting_set)
		{
			if (p_FieldSetting_set.isLocked())
				return;
			if (Raise_FieldSetting_set_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (FieldSetting_set.production_kind) p_FieldSetting_set.kind, p_FieldSetting_set))
				p_FieldSetting_set.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					FieldSetting_set.production_kind kind = (FieldSetting_set.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_FieldSetting_set_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case FieldSetting_set.production_kind.g_FieldSetting_set_1:
								// traverse syntax tree node associated with production
								// FieldSetting-set: FieldSetting

								if (Raise_FieldSetting_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_FieldSetting);
								node.turn_inc ();
								Raise_FieldSetting_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case FieldSetting_set.production_kind.g_FieldSetting_set_2:
								// traverse syntax tree node associated with production
								// FieldSetting-set: FieldSetting-set <generated-rule-4> FieldSetting Left

								if (Raise_FieldSetting_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_FieldSetting_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m__generated_rule_4_);
								node.turn_inc ();
								if (Raise_FieldSetting_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_FieldSetting);
								node.turn_inc ();
								Raise_FieldSetting_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_FieldSetting_set_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_FieldSetting_set_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (FieldSetting_set.production_kind) p_FieldSetting_set.kind, p_FieldSetting_set);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule FieldSetting-set
		//

		public void TraverseCommon (FieldSetting_set p_FieldSetting_set)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_FieldSetting_set.kind, p_FieldSetting_set))
				p_FieldSetting_set.Iterate (null, (node, appData) =>
				{
					FieldSetting_set.production_kind kind = (FieldSetting_set.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case FieldSetting_set.production_kind.g_FieldSetting_set_1:
							// traverse syntax tree node associated with production
							// FieldSetting-set: FieldSetting

							TraverseCommon (node.m_FieldSetting);
							break;
						case FieldSetting_set.production_kind.g_FieldSetting_set_2:
							// traverse syntax tree node associated with production
							// FieldSetting-set: FieldSetting-set <generated-rule-4> FieldSetting Left

							TraverseCommon (node.m__generated_rule_4_);
							TraverseCommon (node.m_FieldSetting);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_FieldSetting_set.kind, p_FieldSetting_set);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule FieldSetting-set

		//
		// create syntax tree node associated with production
		// FieldSetting-set: FieldSetting

		//

		public FieldSetting_set FieldSetting_set_1 (FieldSetting p_FieldSetting)
		{
			FieldSetting_set p_FieldSetting_set_ref = new FieldSetting_set(p_FieldSetting);
			p_FieldSetting.parent = p_FieldSetting_set_ref;
			Raise_FieldSetting_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldSetting_set.production_kind.g_FieldSetting_set_1, p_FieldSetting_set_ref);
			return p_FieldSetting_set_ref;
		}

		//
		// create syntax tree node associated with production
		// FieldSetting-set: FieldSetting-set <generated-rule-4> FieldSetting Left

		//

		public FieldSetting_set FieldSetting_set_2 (FieldSetting_set p_FieldSetting_set, _generated_rule_4_ p__generated_rule_4_, FieldSetting p_FieldSetting)
		{
			FieldSetting_set p_FieldSetting_set_ref = new FieldSetting_set(p_FieldSetting_set, p__generated_rule_4_, p_FieldSetting);
			p_FieldSetting_set.parent = p_FieldSetting_set_ref;
			p__generated_rule_4_.parent = p_FieldSetting_set_ref;
			p_FieldSetting.parent = p_FieldSetting_set_ref;
			Raise_FieldSetting_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldSetting_set.production_kind.g_FieldSetting_set_2, p_FieldSetting_set_ref);
			return p_FieldSetting_set_ref;
		}
		#endregion
	};
}
