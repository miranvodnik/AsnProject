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
	// class associated with syntax rule ActualParameter-set
	//

	[DataContract]
	public class	ActualParameter_set : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ActualParameter-set
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ActualParameter-set
		{
			g_ActualParameter_set_1 = 1,	// ActualParameter

			g_ActualParameter_set_2 = 2,	// ActualParameter-set "," ActualParameter Left

		};
		#endregion
		#region production markers associated with the syntax rule ActualParameter-set

		// markers associated with production: ActualParameter-set -> ActualParameter

		public enum production_marker_1 : ushort
		{
			m_ActualParameter,
			final
		};

		// markers associated with production: ActualParameter-set -> ActualParameter-set "," ActualParameter Left

		public enum production_marker_2 : ushort
		{
			m_ActualParameter_set,
			m_ActualParameter,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ActualParameter-set

		// Constructor declaration(s) associated with production(s) of syntax rule ActualParameter-set

		//
		// Constructor associated with the following production(s)
		// ActualParameter-set -> ActualParameter

		//

		public ActualParameter_set (ActualParameter p_ActualParameter) : base ((uint) ProductionID._ActualParameter_set_ID, (uint) production_kind.g_ActualParameter_set_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ActualParameter = p_ActualParameter;
		}

		//
		// Constructor associated with the following production(s)
		// ActualParameter-set -> ActualParameter-set "," ActualParameter Left

		//

		public ActualParameter_set (ActualParameter_set p_ActualParameter_set, SyntaxTreeToken p_token, ActualParameter p_ActualParameter) : base ((uint) ProductionID._ActualParameter_set_ID, (uint) production_kind.g_ActualParameter_set_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ActualParameter_set = p_ActualParameter_set;
			children[1] = m_comma = p_token;
			children[2] = m_ActualParameter = p_ActualParameter;
		}

		public ActualParameter_set () { }

		// Copy constructor

		public ActualParameter_set (ActualParameter_set p_ActualParameter_set) : base (p_ActualParameter_set.id, p_ActualParameter_set.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ActualParameter_set.appInfo;
			switch ((production_kind) p_ActualParameter_set.kind)
			{
				case production_kind.g_ActualParameter_set_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ActualParameter = (p_ActualParameter_set.m_ActualParameter != null) ? new ActualParameter (p_ActualParameter_set.m_ActualParameter) : null) != null) m_ActualParameter.parent = this;
					break;
				case production_kind.g_ActualParameter_set_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ActualParameter_set = (p_ActualParameter_set.m_ActualParameter_set != null) ? new ActualParameter_set (p_ActualParameter_set.m_ActualParameter_set) : null) != null) m_ActualParameter_set.parent = this;
					if ((children [1] = m_comma = (p_ActualParameter_set.m_comma != null) ? new SyntaxTreeToken (p_ActualParameter_set.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_ActualParameter = (p_ActualParameter_set.m_ActualParameter != null) ? new ActualParameter (p_ActualParameter_set.m_ActualParameter) : null) != null) m_ActualParameter.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ActualParameter_set" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ActualParameter_set (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_ActualParameter?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ActualParameter-set

		// Content changing function(s) associated with production(s) of syntax rule ActualParameter-set

		//
		// Content changing function associated with following production(s)
		// ActualParameter-set -> ActualParameter

		//

		public void change(ActualParameter p_ActualParameter)
		{
			_init ();
			this.kind = (uint) production_kind.g_ActualParameter_set_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ActualParameter = p_ActualParameter;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ActualParameter-set -> ActualParameter-set "," ActualParameter Left

		//

		public void change(ActualParameter_set p_ActualParameter_set, SyntaxTreeToken p_token, ActualParameter p_ActualParameter)
		{
			_init ();
			this.kind = (uint) production_kind.g_ActualParameter_set_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ActualParameter_set = p_ActualParameter_set;
			children [1] = m_comma = p_token;
			children [2] = m_ActualParameter = p_ActualParameter;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ActualParameter-set
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_ActualParameter != null) && node.m_ActualParameter.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ActualParameter-set

		//
		// emit production tree node associated with any production of syntax rule ActualParameter-set
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ActualParameter_set_1:
						// emit syntax tree node associated with production
						// ActualParameter-set: ActualParameter

						s += " " + node.m_ActualParameter.Emit (depth - 1);
						break;
					case production_kind.g_ActualParameter_set_2:
						// emit syntax tree node associated with production
						// ActualParameter-set: ActualParameter-set "," ActualParameter Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_ActualParameter.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ActualParameter-set
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "ActualParameter_set (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ActualParameter_set_1:
						// emit syntax tree node associated with production
						// ActualParameter-set: ActualParameter

						str += node.m_ActualParameter.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_ActualParameter_set_2:
						// emit syntax tree node associated with production
						// ActualParameter-set: ActualParameter-set "," ActualParameter Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_ActualParameter.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ActualParameter-set

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ActualParameter-set with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					ActualParameter_set.production_kind kind = (ActualParameter_set.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case ActualParameter_set.production_kind.g_ActualParameter_set_1:
							// traverse syntax tree node associated with production
							// ActualParameter-set: ActualParameter

							node.m_ActualParameter.Visit (visitor, appData);
							break;
						case ActualParameter_set.production_kind.g_ActualParameter_set_2:
							// traverse syntax tree node associated with production
							// ActualParameter-set: ActualParameter-set "," ActualParameter Left

							node.m_comma.Visit (visitor, appData);
							node.m_ActualParameter.Visit (visitor, appData);
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
			for (ActualParameter_set node = this; node != null; node = node.m_ActualParameter_set)
			{
				node.parent = parent;
				node.m_ActualParameter?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule ActualParameter-set
		//

		public void _init ()
		{
			m_ActualParameter = null;
			m_ActualParameter_set = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (ActualParameter_set p_ActualParameter_set, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<ActualParameter_set> stack = new Stack<ActualParameter_set> ();
			ActualParameter_set p_ActualParameter_set;
			for (p_ActualParameter_set = this; p_ActualParameter_set != null; p_ActualParameter_set = p_ActualParameter_set.m_ActualParameter_set)
				stack.Push (p_ActualParameter_set);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ActualParameter-set

		// counter of all nodes associated with syntax rule ActualParameter-set
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ActualParameter-set
		[DataMember (Name = "m_ActualParameter")] public ActualParameter m_ActualParameter { get; private set; }
		[DataMember (Name = "m_ActualParameter_set")] public ActualParameter_set m_ActualParameter_set { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ActualParameter-set

		// delegate function (callback) prototype associated with syntax rule ActualParameter-set
		public delegate bool ActualParameter_set_Callback (SyntaxTreeCallbackReason reason, ActualParameter_set.production_kind kind, ActualParameter_set p_ActualParameter_set);

		// event associated with syntax rule ActualParameter-set
		public event ActualParameter_set_Callback ActualParameter_set_Event;

		// event trigger associated with syntax rule ActualParameter-set
		public bool Raise_ActualParameter_set_Event (SyntaxTreeCallbackReason reason, ActualParameter_set.production_kind kind, ActualParameter_set p_ActualParameter_set)
		{
			bool? status = ActualParameter_set_Event?.Invoke (reason, kind, p_ActualParameter_set);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ActualParameter-set
		//
		// traverse syntax tree node associated with any production of syntax rule ActualParameter-set
		//

		public void Traverse (ActualParameter_set p_ActualParameter_set)
		{
			if (p_ActualParameter_set.isLocked())
				return;
			if (Raise_ActualParameter_set_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (ActualParameter_set.production_kind) p_ActualParameter_set.kind, p_ActualParameter_set))
				p_ActualParameter_set.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					ActualParameter_set.production_kind kind = (ActualParameter_set.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_ActualParameter_set_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case ActualParameter_set.production_kind.g_ActualParameter_set_1:
								// traverse syntax tree node associated with production
								// ActualParameter-set: ActualParameter

								if (Raise_ActualParameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_ActualParameter);
								node.turn_inc ();
								Raise_ActualParameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case ActualParameter_set.production_kind.g_ActualParameter_set_2:
								// traverse syntax tree node associated with production
								// ActualParameter-set: ActualParameter-set "," ActualParameter Left

								if (Raise_ActualParameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_ActualParameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_ActualParameter);
								node.turn_inc ();
								Raise_ActualParameter_set_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_ActualParameter_set_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_ActualParameter_set_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (ActualParameter_set.production_kind) p_ActualParameter_set.kind, p_ActualParameter_set);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ActualParameter-set
		//

		public void TraverseCommon (ActualParameter_set p_ActualParameter_set)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_ActualParameter_set.kind, p_ActualParameter_set))
				p_ActualParameter_set.Iterate (null, (node, appData) =>
				{
					ActualParameter_set.production_kind kind = (ActualParameter_set.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case ActualParameter_set.production_kind.g_ActualParameter_set_1:
							// traverse syntax tree node associated with production
							// ActualParameter-set: ActualParameter

							TraverseCommon (node.m_ActualParameter);
							break;
						case ActualParameter_set.production_kind.g_ActualParameter_set_2:
							// traverse syntax tree node associated with production
							// ActualParameter-set: ActualParameter-set "," ActualParameter Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_ActualParameter);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_ActualParameter_set.kind, p_ActualParameter_set);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ActualParameter-set

		//
		// create syntax tree node associated with production
		// ActualParameter-set: ActualParameter

		//

		public ActualParameter_set ActualParameter_set_1 (ActualParameter p_ActualParameter)
		{
			ActualParameter_set p_ActualParameter_set_ref = new ActualParameter_set(p_ActualParameter);
			p_ActualParameter.parent = p_ActualParameter_set_ref;
			Raise_ActualParameter_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ActualParameter_set.production_kind.g_ActualParameter_set_1, p_ActualParameter_set_ref);
			return p_ActualParameter_set_ref;
		}

		//
		// create syntax tree node associated with production
		// ActualParameter-set: ActualParameter-set "," ActualParameter Left

		//

		public ActualParameter_set ActualParameter_set_2 (ActualParameter_set p_ActualParameter_set, SyntaxTreeToken p_token, ActualParameter p_ActualParameter)
		{
			ActualParameter_set p_ActualParameter_set_ref = new ActualParameter_set(p_ActualParameter_set, p_token, p_ActualParameter);
			p_ActualParameter_set.parent = p_ActualParameter_set_ref;
			p_token.parent = p_ActualParameter_set_ref;
			p_ActualParameter.parent = p_ActualParameter_set_ref;
			Raise_ActualParameter_set_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ActualParameter_set.production_kind.g_ActualParameter_set_2, p_ActualParameter_set_ref);
			return p_ActualParameter_set_ref;
		}
		#endregion
	};
}
