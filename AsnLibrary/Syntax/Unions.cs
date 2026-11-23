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
	// class associated with syntax rule Unions
	//

	[DataContract]
	public class	Unions : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Unions
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Unions
		{
			g_Unions_1 = 1,	// Intersections

			g_Unions_2 = 2,	// Unions UnionMark Intersections

		};
		#endregion
		#region production markers associated with the syntax rule Unions

		// markers associated with production: Unions -> Intersections

		public enum production_marker_1 : ushort
		{
			m_Intersections,
			final
		};

		// markers associated with production: Unions -> Unions UnionMark Intersections

		public enum production_marker_2 : ushort
		{
			m_Unions,
			m_UnionMark,
			m_Intersections,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Unions

		// Constructor declaration(s) associated with production(s) of syntax rule Unions

		//
		// Constructor associated with the following production(s)
		// Unions -> Intersections

		//

		public Unions (Intersections p_Intersections) : base ((uint) ProductionID._Unions_ID, (uint) production_kind.g_Unions_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Intersections = p_Intersections;
		}

		//
		// Constructor associated with the following production(s)
		// Unions -> Unions UnionMark Intersections

		//

		public Unions (Unions p_Unions, UnionMark p_UnionMark, Intersections p_Intersections) : base ((uint) ProductionID._Unions_ID, (uint) production_kind.g_Unions_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_Unions = p_Unions;
			children[1] = m_UnionMark = p_UnionMark;
			children[2] = m_Intersections = p_Intersections;
		}

		public Unions () { }

		// Copy constructor

		public Unions (Unions p_Unions) : base (p_Unions.id, p_Unions.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Unions.appInfo;
			switch ((production_kind) p_Unions.kind)
			{
				case production_kind.g_Unions_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Intersections = (p_Unions.m_Intersections != null) ? new Intersections (p_Unions.m_Intersections) : null) != null) m_Intersections.parent = this;
					break;
				case production_kind.g_Unions_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_Unions = (p_Unions.m_Unions != null) ? new Unions (p_Unions.m_Unions) : null) != null) m_Unions.parent = this;
					if ((children [1] = m_UnionMark = (p_Unions.m_UnionMark != null) ? new UnionMark (p_Unions.m_UnionMark) : null) != null) m_UnionMark.parent = this;
					if ((children [2] = m_Intersections = (p_Unions.m_Intersections != null) ? new Intersections (p_Unions.m_Intersections) : null) != null) m_Intersections.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Unions" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Unions (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_Intersections?.Dispose ();
				node.m_UnionMark?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Unions

		// Content changing function(s) associated with production(s) of syntax rule Unions

		//
		// Content changing function associated with following production(s)
		// Unions -> Intersections

		//

		public void change(Intersections p_Intersections)
		{
			_init ();
			this.kind = (uint) production_kind.g_Unions_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Intersections = p_Intersections;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Unions -> Unions UnionMark Intersections

		//

		public void change(Unions p_Unions, UnionMark p_UnionMark, Intersections p_Intersections)
		{
			_init ();
			this.kind = (uint) production_kind.g_Unions_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_Unions = p_Unions;
			children [1] = m_UnionMark = p_UnionMark;
			children [2] = m_Intersections = p_Intersections;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Unions
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_Intersections != null) && node.m_Intersections.checkInclusion (element) ||
					(node.m_UnionMark != null) && node.m_UnionMark.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Unions

		//
		// emit production tree node associated with any production of syntax rule Unions
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_Unions_1:
						// emit syntax tree node associated with production
						// Unions: Intersections

						s += " " + node.m_Intersections.Emit (depth - 1);
						break;
					case production_kind.g_Unions_2:
						// emit syntax tree node associated with production
						// Unions: Unions UnionMark Intersections

						s += " " + node.m_UnionMark.Emit (depth - 1);
						s += " " + node.m_Intersections.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Unions
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "Unions (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_Unions_1:
						// emit syntax tree node associated with production
						// Unions: Intersections

						str += node.m_Intersections.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_Unions_2:
						// emit syntax tree node associated with production
						// Unions: Unions UnionMark Intersections

						str += ' ';
						str += node.m_UnionMark.EmitProductionTree (depth - 1);
						str += ' ';
						str += node.m_Intersections.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Unions

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Unions with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					Unions.production_kind kind = (Unions.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case Unions.production_kind.g_Unions_1:
							// traverse syntax tree node associated with production
							// Unions: Intersections

							node.m_Intersections.Visit (visitor, appData);
							break;
						case Unions.production_kind.g_Unions_2:
							// traverse syntax tree node associated with production
							// Unions: Unions UnionMark Intersections

							node.m_UnionMark.Visit (visitor, appData);
							node.m_Intersections.Visit (visitor, appData);
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
			for (Unions node = this; node != null; node = node.m_Unions)
			{
				node.parent = parent;
				node.m_Intersections?.reparent (parent);
				node.m_UnionMark?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule Unions
		//

		public void _init ()
		{
			m_Intersections = null;
			m_Unions = null;
			m_UnionMark = null;
		}

		public delegate object IteratorDelegate (Unions p_Unions, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<Unions> stack = new Stack<Unions> ();
			Unions p_Unions;
			for (p_Unions = this; p_Unions != null; p_Unions = p_Unions.m_Unions)
				stack.Push (p_Unions);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Unions

		// counter of all nodes associated with syntax rule Unions
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Unions
		[DataMember (Name = "m_Intersections")] public Intersections m_Intersections { get; private set; }
		[DataMember (Name = "m_Unions")] public Unions m_Unions { get; private set; }
		[DataMember (Name = "m_UnionMark")] public UnionMark m_UnionMark { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Unions

		// delegate function (callback) prototype associated with syntax rule Unions
		public delegate bool Unions_Callback (SyntaxTreeCallbackReason reason, Unions.production_kind kind, Unions p_Unions);

		// event associated with syntax rule Unions
		public event Unions_Callback Unions_Event;

		// event trigger associated with syntax rule Unions
		public bool Raise_Unions_Event (SyntaxTreeCallbackReason reason, Unions.production_kind kind, Unions p_Unions)
		{
			bool? status = Unions_Event?.Invoke (reason, kind, p_Unions);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Unions
		//
		// traverse syntax tree node associated with any production of syntax rule Unions
		//

		public void Traverse (Unions p_Unions)
		{
			if (p_Unions.isLocked())
				return;
			if (Raise_Unions_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (Unions.production_kind) p_Unions.kind, p_Unions))
				p_Unions.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					Unions.production_kind kind = (Unions.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_Unions_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case Unions.production_kind.g_Unions_1:
								// traverse syntax tree node associated with production
								// Unions: Intersections

								if (Raise_Unions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Intersections);
								node.turn_inc ();
								Raise_Unions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case Unions.production_kind.g_Unions_2:
								// traverse syntax tree node associated with production
								// Unions: Unions UnionMark Intersections

								if (Raise_Unions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_Unions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_UnionMark);
								node.turn_inc ();
								if (Raise_Unions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_Intersections);
								node.turn_inc ();
								Raise_Unions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_Unions_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_Unions_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (Unions.production_kind) p_Unions.kind, p_Unions);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Unions
		//

		public void TraverseCommon (Unions p_Unions)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_Unions.kind, p_Unions))
				p_Unions.Iterate (null, (node, appData) =>
				{
					Unions.production_kind kind = (Unions.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case Unions.production_kind.g_Unions_1:
							// traverse syntax tree node associated with production
							// Unions: Intersections

							TraverseCommon (node.m_Intersections);
							break;
						case Unions.production_kind.g_Unions_2:
							// traverse syntax tree node associated with production
							// Unions: Unions UnionMark Intersections

							TraverseCommon (node.m_UnionMark);
							TraverseCommon (node.m_Intersections);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_Unions.kind, p_Unions);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Unions

		//
		// create syntax tree node associated with production
		// Unions: Intersections

		//

		public Unions Unions_1 (Intersections p_Intersections)
		{
			Unions p_Unions_ref = new Unions(p_Intersections);
			p_Intersections.parent = p_Unions_ref;
			Raise_Unions_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Unions.production_kind.g_Unions_1, p_Unions_ref);
			return p_Unions_ref;
		}

		//
		// create syntax tree node associated with production
		// Unions: Unions UnionMark Intersections

		//

		public Unions Unions_2 (Unions p_Unions, UnionMark p_UnionMark, Intersections p_Intersections)
		{
			Unions p_Unions_ref = new Unions(p_Unions, p_UnionMark, p_Intersections);
			p_Unions.parent = p_Unions_ref;
			p_UnionMark.parent = p_Unions_ref;
			p_Intersections.parent = p_Unions_ref;
			Raise_Unions_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Unions.production_kind.g_Unions_2, p_Unions_ref);
			return p_Unions_ref;
		}
		#endregion
	};
}
