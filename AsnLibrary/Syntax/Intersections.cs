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
	// class associated with syntax rule Intersections
	//

	[DataContract]
	public class	Intersections : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Intersections
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Intersections
		{
			g_Intersections_1 = 1,	// IntersectionElements

			g_Intersections_2 = 2,	// Intersections IntersectionMark IntersectionElements

		};
		#endregion
		#region production markers associated with the syntax rule Intersections

		// markers associated with production: Intersections -> IntersectionElements

		public enum production_marker_1 : ushort
		{
			m_IntersectionElements,
			final
		};

		// markers associated with production: Intersections -> Intersections IntersectionMark IntersectionElements

		public enum production_marker_2 : ushort
		{
			m_Intersections,
			m_IntersectionMark,
			m_IntersectionElements,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Intersections

		// Constructor declaration(s) associated with production(s) of syntax rule Intersections

		//
		// Constructor associated with the following production(s)
		// Intersections -> IntersectionElements

		//

		public Intersections (IntersectionElements p_IntersectionElements) : base ((uint) ProductionID._Intersections_ID, (uint) production_kind.g_Intersections_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_IntersectionElements = p_IntersectionElements;
		}

		//
		// Constructor associated with the following production(s)
		// Intersections -> Intersections IntersectionMark IntersectionElements

		//

		public Intersections (Intersections p_Intersections, IntersectionMark p_IntersectionMark, IntersectionElements p_IntersectionElements) : base ((uint) ProductionID._Intersections_ID, (uint) production_kind.g_Intersections_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_Intersections = p_Intersections;
			children[1] = m_IntersectionMark = p_IntersectionMark;
			children[2] = m_IntersectionElements = p_IntersectionElements;
		}

		public Intersections () { }

		// Copy constructor

		public Intersections (Intersections p_Intersections) : base (p_Intersections.id, p_Intersections.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Intersections.appInfo;
			switch ((production_kind) p_Intersections.kind)
			{
				case production_kind.g_Intersections_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_IntersectionElements = (p_Intersections.m_IntersectionElements != null) ? new IntersectionElements (p_Intersections.m_IntersectionElements) : null) != null) m_IntersectionElements.parent = this;
					break;
				case production_kind.g_Intersections_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_Intersections = (p_Intersections.m_Intersections != null) ? new Intersections (p_Intersections.m_Intersections) : null) != null) m_Intersections.parent = this;
					if ((children [1] = m_IntersectionMark = (p_Intersections.m_IntersectionMark != null) ? new IntersectionMark (p_Intersections.m_IntersectionMark) : null) != null) m_IntersectionMark.parent = this;
					if ((children [2] = m_IntersectionElements = (p_Intersections.m_IntersectionElements != null) ? new IntersectionElements (p_Intersections.m_IntersectionElements) : null) != null) m_IntersectionElements.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Intersections" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Intersections (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_IntersectionElements?.Dispose ();
				node.m_IntersectionMark?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Intersections

		// Content changing function(s) associated with production(s) of syntax rule Intersections

		//
		// Content changing function associated with following production(s)
		// Intersections -> IntersectionElements

		//

		public void change(IntersectionElements p_IntersectionElements)
		{
			_init ();
			this.kind = (uint) production_kind.g_Intersections_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_IntersectionElements = p_IntersectionElements;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Intersections -> Intersections IntersectionMark IntersectionElements

		//

		public void change(Intersections p_Intersections, IntersectionMark p_IntersectionMark, IntersectionElements p_IntersectionElements)
		{
			_init ();
			this.kind = (uint) production_kind.g_Intersections_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_Intersections = p_Intersections;
			children [1] = m_IntersectionMark = p_IntersectionMark;
			children [2] = m_IntersectionElements = p_IntersectionElements;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Intersections
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_IntersectionElements != null) && node.m_IntersectionElements.checkInclusion (element) ||
					(node.m_IntersectionMark != null) && node.m_IntersectionMark.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Intersections

		//
		// emit production tree node associated with any production of syntax rule Intersections
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_Intersections_1:
						// emit syntax tree node associated with production
						// Intersections: IntersectionElements

						s += " " + node.m_IntersectionElements.Emit (depth - 1);
						break;
					case production_kind.g_Intersections_2:
						// emit syntax tree node associated with production
						// Intersections: Intersections IntersectionMark IntersectionElements

						s += " " + node.m_IntersectionMark.Emit (depth - 1);
						s += " " + node.m_IntersectionElements.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Intersections
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "Intersections (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_Intersections_1:
						// emit syntax tree node associated with production
						// Intersections: IntersectionElements

						str += node.m_IntersectionElements.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_Intersections_2:
						// emit syntax tree node associated with production
						// Intersections: Intersections IntersectionMark IntersectionElements

						str += ' ';
						str += node.m_IntersectionMark.EmitProductionTree (depth - 1);
						str += ' ';
						str += node.m_IntersectionElements.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Intersections

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Intersections with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					Intersections.production_kind kind = (Intersections.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case Intersections.production_kind.g_Intersections_1:
							// traverse syntax tree node associated with production
							// Intersections: IntersectionElements

							node.m_IntersectionElements.Visit (visitor, appData);
							break;
						case Intersections.production_kind.g_Intersections_2:
							// traverse syntax tree node associated with production
							// Intersections: Intersections IntersectionMark IntersectionElements

							node.m_IntersectionMark.Visit (visitor, appData);
							node.m_IntersectionElements.Visit (visitor, appData);
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
			for (Intersections node = this; node != null; node = node.m_Intersections)
			{
				node.parent = parent;
				node.m_IntersectionElements?.reparent (parent);
				node.m_IntersectionMark?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule Intersections
		//

		public void _init ()
		{
			m_IntersectionElements = null;
			m_Intersections = null;
			m_IntersectionMark = null;
		}

		public delegate object IteratorDelegate (Intersections p_Intersections, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<Intersections> stack = new Stack<Intersections> ();
			Intersections p_Intersections;
			for (p_Intersections = this; p_Intersections != null; p_Intersections = p_Intersections.m_Intersections)
				stack.Push (p_Intersections);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Intersections

		// counter of all nodes associated with syntax rule Intersections
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Intersections
		[DataMember (Name = "m_IntersectionElements")] public IntersectionElements m_IntersectionElements { get; private set; }
		[DataMember (Name = "m_Intersections")] public Intersections m_Intersections { get; private set; }
		[DataMember (Name = "m_IntersectionMark")] public IntersectionMark m_IntersectionMark { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Intersections

		// delegate function (callback) prototype associated with syntax rule Intersections
		public delegate bool Intersections_Callback (SyntaxTreeCallbackReason reason, Intersections.production_kind kind, Intersections p_Intersections);

		// event associated with syntax rule Intersections
		public event Intersections_Callback Intersections_Event;

		// event trigger associated with syntax rule Intersections
		public bool Raise_Intersections_Event (SyntaxTreeCallbackReason reason, Intersections.production_kind kind, Intersections p_Intersections)
		{
			bool? status = Intersections_Event?.Invoke (reason, kind, p_Intersections);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Intersections
		//
		// traverse syntax tree node associated with any production of syntax rule Intersections
		//

		public void Traverse (Intersections p_Intersections)
		{
			if (p_Intersections.isLocked())
				return;
			if (Raise_Intersections_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (Intersections.production_kind) p_Intersections.kind, p_Intersections))
				p_Intersections.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					Intersections.production_kind kind = (Intersections.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_Intersections_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case Intersections.production_kind.g_Intersections_1:
								// traverse syntax tree node associated with production
								// Intersections: IntersectionElements

								if (Raise_Intersections_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_IntersectionElements);
								node.turn_inc ();
								Raise_Intersections_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case Intersections.production_kind.g_Intersections_2:
								// traverse syntax tree node associated with production
								// Intersections: Intersections IntersectionMark IntersectionElements

								if (Raise_Intersections_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_Intersections_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_IntersectionMark);
								node.turn_inc ();
								if (Raise_Intersections_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_IntersectionElements);
								node.turn_inc ();
								Raise_Intersections_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_Intersections_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_Intersections_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (Intersections.production_kind) p_Intersections.kind, p_Intersections);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Intersections
		//

		public void TraverseCommon (Intersections p_Intersections)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_Intersections.kind, p_Intersections))
				p_Intersections.Iterate (null, (node, appData) =>
				{
					Intersections.production_kind kind = (Intersections.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case Intersections.production_kind.g_Intersections_1:
							// traverse syntax tree node associated with production
							// Intersections: IntersectionElements

							TraverseCommon (node.m_IntersectionElements);
							break;
						case Intersections.production_kind.g_Intersections_2:
							// traverse syntax tree node associated with production
							// Intersections: Intersections IntersectionMark IntersectionElements

							TraverseCommon (node.m_IntersectionMark);
							TraverseCommon (node.m_IntersectionElements);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_Intersections.kind, p_Intersections);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Intersections

		//
		// create syntax tree node associated with production
		// Intersections: IntersectionElements

		//

		public Intersections Intersections_1 (IntersectionElements p_IntersectionElements)
		{
			Intersections p_Intersections_ref = new Intersections(p_IntersectionElements);
			p_IntersectionElements.parent = p_Intersections_ref;
			Raise_Intersections_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Intersections.production_kind.g_Intersections_1, p_Intersections_ref);
			return p_Intersections_ref;
		}

		//
		// create syntax tree node associated with production
		// Intersections: Intersections IntersectionMark IntersectionElements

		//

		public Intersections Intersections_2 (Intersections p_Intersections, IntersectionMark p_IntersectionMark, IntersectionElements p_IntersectionElements)
		{
			Intersections p_Intersections_ref = new Intersections(p_Intersections, p_IntersectionMark, p_IntersectionElements);
			p_Intersections.parent = p_Intersections_ref;
			p_IntersectionMark.parent = p_Intersections_ref;
			p_IntersectionElements.parent = p_Intersections_ref;
			Raise_Intersections_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Intersections.production_kind.g_Intersections_2, p_Intersections_ref);
			return p_Intersections_ref;
		}
		#endregion
	};
}
