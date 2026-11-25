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
	// class associated with syntax rule MI-Revisions
	//

	[DataContract]
	public class	MI_Revisions : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MI-Revisions
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MI-Revisions
		{
			g_MI_Revisions_1 = 1,	// MI-Revision

			g_MI_Revisions_2 = 2,	// MI-Revisions MI-Revision

		};
		#endregion
		#region production markers associated with the syntax rule MI-Revisions

		// markers associated with production: MI-Revisions -> MI-Revision

		public enum production_marker_1 : ushort
		{
			m_MI_Revision,
			final
		};

		// markers associated with production: MI-Revisions -> MI-Revisions MI-Revision

		public enum production_marker_2 : ushort
		{
			m_MI_Revisions,
			m_MI_Revision,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MI-Revisions

		// Constructor declaration(s) associated with production(s) of syntax rule MI-Revisions

		//
		// Constructor associated with the following production(s)
		// MI-Revisions -> MI-Revision

		//

		public MI_Revisions (MI_Revision p_MI_Revision) : base ((uint) ProductionID._MI_Revisions_ID, (uint) production_kind.g_MI_Revisions_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MI_Revision = p_MI_Revision;
		}

		//
		// Constructor associated with the following production(s)
		// MI-Revisions -> MI-Revisions MI-Revision

		//

		public MI_Revisions (MI_Revisions p_MI_Revisions, MI_Revision p_MI_Revision) : base ((uint) ProductionID._MI_Revisions_ID, (uint) production_kind.g_MI_Revisions_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_MI_Revisions = p_MI_Revisions;
			children[1] = m_MI_Revision = p_MI_Revision;
		}

		public MI_Revisions () { }

		// Copy constructor

		public MI_Revisions (MI_Revisions p_MI_Revisions) : base (p_MI_Revisions.id, p_MI_Revisions.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MI_Revisions.appInfo;
			switch ((production_kind) p_MI_Revisions.kind)
			{
				case production_kind.g_MI_Revisions_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MI_Revision = (p_MI_Revisions.m_MI_Revision != null) ? new MI_Revision (p_MI_Revisions.m_MI_Revision) : null) != null) m_MI_Revision.parent = this;
					break;
				case production_kind.g_MI_Revisions_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_MI_Revisions = (p_MI_Revisions.m_MI_Revisions != null) ? new MI_Revisions (p_MI_Revisions.m_MI_Revisions) : null) != null) m_MI_Revisions.parent = this;
					if ((children [1] = m_MI_Revision = (p_MI_Revisions.m_MI_Revision != null) ? new MI_Revision (p_MI_Revisions.m_MI_Revision) : null) != null) m_MI_Revision.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MI_Revisions" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MI_Revisions (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_MI_Revision?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MI-Revisions

		// Content changing function(s) associated with production(s) of syntax rule MI-Revisions

		//
		// Content changing function associated with following production(s)
		// MI-Revisions -> MI-Revision

		//

		public void change(MI_Revision p_MI_Revision)
		{
			_init ();
			this.kind = (uint) production_kind.g_MI_Revisions_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MI_Revision = p_MI_Revision;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MI-Revisions -> MI-Revisions MI-Revision

		//

		public void change(MI_Revisions p_MI_Revisions, MI_Revision p_MI_Revision)
		{
			_init ();
			this.kind = (uint) production_kind.g_MI_Revisions_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_MI_Revisions = p_MI_Revisions;
			children [1] = m_MI_Revision = p_MI_Revision;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MI-Revisions
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_MI_Revision != null) && node.m_MI_Revision.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MI-Revisions

		//
		// emit production tree node associated with any production of syntax rule MI-Revisions
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_MI_Revisions_1:
						// emit syntax tree node associated with production
						// MI-Revisions: MI-Revision

						s += " " + node.m_MI_Revision.Emit (depth - 1);
						break;
					case production_kind.g_MI_Revisions_2:
						// emit syntax tree node associated with production
						// MI-Revisions: MI-Revisions MI-Revision

						s += " " + node.m_MI_Revision.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MI-Revisions
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "MI_Revisions (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_MI_Revisions_1:
						// emit syntax tree node associated with production
						// MI-Revisions: MI-Revision

						str += node.m_MI_Revision.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_MI_Revisions_2:
						// emit syntax tree node associated with production
						// MI-Revisions: MI-Revisions MI-Revision

						str += ' ';
						str += node.m_MI_Revision.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MI-Revisions

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MI-Revisions with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					MI_Revisions.production_kind kind = (MI_Revisions.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case MI_Revisions.production_kind.g_MI_Revisions_1:
							// traverse syntax tree node associated with production
							// MI-Revisions: MI-Revision

							node.m_MI_Revision.Visit (visitor, appData);
							break;
						case MI_Revisions.production_kind.g_MI_Revisions_2:
							// traverse syntax tree node associated with production
							// MI-Revisions: MI-Revisions MI-Revision

							node.m_MI_Revision.Visit (visitor, appData);
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
			for (MI_Revisions node = this; node != null; node = node.m_MI_Revisions)
			{
				node.parent = parent;
				node.m_MI_Revision?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule MI-Revisions
		//

		public void _init ()
		{
			m_MI_Revision = null;
			m_MI_Revisions = null;
		}

		public delegate object IteratorDelegate (MI_Revisions p_MI_Revisions, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<MI_Revisions> stack = new Stack<MI_Revisions> ();
			MI_Revisions p_MI_Revisions;
			for (p_MI_Revisions = this; p_MI_Revisions != null; p_MI_Revisions = p_MI_Revisions.m_MI_Revisions)
				stack.Push (p_MI_Revisions);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MI-Revisions

		// counter of all nodes associated with syntax rule MI-Revisions
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MI-Revisions
		[DataMember (Name = "m_MI_Revision")] public MI_Revision m_MI_Revision { get; private set; }
		[DataMember (Name = "m_MI_Revisions")] public MI_Revisions m_MI_Revisions { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MI-Revisions

		// delegate function (callback) prototype associated with syntax rule MI-Revisions
		public delegate bool MI_Revisions_Callback (SyntaxTreeCallbackReason reason, MI_Revisions.production_kind kind, MI_Revisions p_MI_Revisions);

		// event associated with syntax rule MI-Revisions
		public event MI_Revisions_Callback MI_Revisions_Event;

		// event trigger associated with syntax rule MI-Revisions
		public bool Raise_MI_Revisions_Event (SyntaxTreeCallbackReason reason, MI_Revisions.production_kind kind, MI_Revisions p_MI_Revisions)
		{
			bool? status = MI_Revisions_Event?.Invoke (reason, kind, p_MI_Revisions);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MI-Revisions
		//
		// traverse syntax tree node associated with any production of syntax rule MI-Revisions
		//

		public void Traverse (MI_Revisions p_MI_Revisions)
		{
			if (p_MI_Revisions.isLocked())
				return;
			if (Raise_MI_Revisions_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (MI_Revisions.production_kind) p_MI_Revisions.kind, p_MI_Revisions))
				p_MI_Revisions.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					MI_Revisions.production_kind kind = (MI_Revisions.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_MI_Revisions_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case MI_Revisions.production_kind.g_MI_Revisions_1:
								// traverse syntax tree node associated with production
								// MI-Revisions: MI-Revision

								if (Raise_MI_Revisions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_MI_Revision);
								node.turn_inc ();
								Raise_MI_Revisions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case MI_Revisions.production_kind.g_MI_Revisions_2:
								// traverse syntax tree node associated with production
								// MI-Revisions: MI-Revisions MI-Revision

								if (Raise_MI_Revisions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_MI_Revisions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_MI_Revision);
								node.turn_inc ();
								Raise_MI_Revisions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_MI_Revisions_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_MI_Revisions_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (MI_Revisions.production_kind) p_MI_Revisions.kind, p_MI_Revisions);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MI-Revisions
		//

		public void TraverseCommon (MI_Revisions p_MI_Revisions)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_MI_Revisions.kind, p_MI_Revisions))
				p_MI_Revisions.Iterate (null, (node, appData) =>
				{
					MI_Revisions.production_kind kind = (MI_Revisions.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case MI_Revisions.production_kind.g_MI_Revisions_1:
							// traverse syntax tree node associated with production
							// MI-Revisions: MI-Revision

							TraverseCommon (node.m_MI_Revision);
							break;
						case MI_Revisions.production_kind.g_MI_Revisions_2:
							// traverse syntax tree node associated with production
							// MI-Revisions: MI-Revisions MI-Revision

							TraverseCommon (node.m_MI_Revision);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_MI_Revisions.kind, p_MI_Revisions);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MI-Revisions

		//
		// create syntax tree node associated with production
		// MI-Revisions: MI-Revision

		//

		public MI_Revisions MI_Revisions_1 (MI_Revision p_MI_Revision)
		{
			MI_Revisions p_MI_Revisions_ref = new MI_Revisions(p_MI_Revision);
			p_MI_Revision.parent = p_MI_Revisions_ref;
			Raise_MI_Revisions_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MI_Revisions.production_kind.g_MI_Revisions_1, p_MI_Revisions_ref);
			return p_MI_Revisions_ref;
		}

		//
		// create syntax tree node associated with production
		// MI-Revisions: MI-Revisions MI-Revision

		//

		public MI_Revisions MI_Revisions_2 (MI_Revisions p_MI_Revisions, MI_Revision p_MI_Revision)
		{
			MI_Revisions p_MI_Revisions_ref = new MI_Revisions(p_MI_Revisions, p_MI_Revision);
			p_MI_Revisions.parent = p_MI_Revisions_ref;
			p_MI_Revision.parent = p_MI_Revisions_ref;
			Raise_MI_Revisions_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MI_Revisions.production_kind.g_MI_Revisions_2, p_MI_Revisions_ref);
			return p_MI_Revisions_ref;
		}
		#endregion
	};
}
