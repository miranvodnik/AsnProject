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
	// class associated with syntax rule AC-Variations
	//

	[DataContract]
	public class	AC_Variations : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-Variations
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-Variations
		{
			g_AC_Variations_1 = 1,	// AC-Variation

			g_AC_Variations_2 = 2,	// AC-Variations AC-Variation

		};
		#endregion
		#region production markers associated with the syntax rule AC-Variations

		// markers associated with production: AC-Variations -> AC-Variation

		public enum production_marker_1 : ushort
		{
			m_AC_Variation,
			final
		};

		// markers associated with production: AC-Variations -> AC-Variations AC-Variation

		public enum production_marker_2 : ushort
		{
			m_AC_Variations,
			m_AC_Variation,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-Variations

		// Constructor declaration(s) associated with production(s) of syntax rule AC-Variations

		//
		// Constructor associated with the following production(s)
		// AC-Variations -> AC-Variation

		//

		public AC_Variations (AC_Variation p_AC_Variation) : base ((uint) ProductionID._AC_Variations_ID, (uint) production_kind.g_AC_Variations_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AC_Variation = p_AC_Variation;
		}

		//
		// Constructor associated with the following production(s)
		// AC-Variations -> AC-Variations AC-Variation

		//

		public AC_Variations (AC_Variations p_AC_Variations, AC_Variation p_AC_Variation) : base ((uint) ProductionID._AC_Variations_ID, (uint) production_kind.g_AC_Variations_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_AC_Variations = p_AC_Variations;
			children[1] = m_AC_Variation = p_AC_Variation;
		}

		public AC_Variations () { }

		// Copy constructor

		public AC_Variations (AC_Variations p_AC_Variations) : base (p_AC_Variations.id, p_AC_Variations.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_Variations.appInfo;
			switch ((production_kind) p_AC_Variations.kind)
			{
				case production_kind.g_AC_Variations_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AC_Variation = (p_AC_Variations.m_AC_Variation != null) ? new AC_Variation (p_AC_Variations.m_AC_Variation) : null) != null) m_AC_Variation.parent = this;
					break;
				case production_kind.g_AC_Variations_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_AC_Variations = (p_AC_Variations.m_AC_Variations != null) ? new AC_Variations (p_AC_Variations.m_AC_Variations) : null) != null) m_AC_Variations.parent = this;
					if ((children [1] = m_AC_Variation = (p_AC_Variations.m_AC_Variation != null) ? new AC_Variation (p_AC_Variations.m_AC_Variation) : null) != null) m_AC_Variation.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_Variations" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_Variations (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_AC_Variation?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-Variations

		// Content changing function(s) associated with production(s) of syntax rule AC-Variations

		//
		// Content changing function associated with following production(s)
		// AC-Variations -> AC-Variation

		//

		public void change(AC_Variation p_AC_Variation)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Variations_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AC_Variation = p_AC_Variation;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-Variations -> AC-Variations AC-Variation

		//

		public void change(AC_Variations p_AC_Variations, AC_Variation p_AC_Variation)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Variations_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_AC_Variations = p_AC_Variations;
			children [1] = m_AC_Variation = p_AC_Variation;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-Variations
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_AC_Variation != null) && node.m_AC_Variation.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-Variations

		//
		// emit production tree node associated with any production of syntax rule AC-Variations
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AC_Variations_1:
						// emit syntax tree node associated with production
						// AC-Variations: AC-Variation

						s += " " + node.m_AC_Variation.Emit (depth - 1);
						break;
					case production_kind.g_AC_Variations_2:
						// emit syntax tree node associated with production
						// AC-Variations: AC-Variations AC-Variation

						s += " " + node.m_AC_Variation.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-Variations
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "AC_Variations (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AC_Variations_1:
						// emit syntax tree node associated with production
						// AC-Variations: AC-Variation

						str += node.m_AC_Variation.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_AC_Variations_2:
						// emit syntax tree node associated with production
						// AC-Variations: AC-Variations AC-Variation

						str += ' ';
						str += node.m_AC_Variation.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-Variations

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Variations with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					AC_Variations.production_kind kind = (AC_Variations.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case AC_Variations.production_kind.g_AC_Variations_1:
							// traverse syntax tree node associated with production
							// AC-Variations: AC-Variation

							node.m_AC_Variation.Visit (visitor, appData);
							break;
						case AC_Variations.production_kind.g_AC_Variations_2:
							// traverse syntax tree node associated with production
							// AC-Variations: AC-Variations AC-Variation

							node.m_AC_Variation.Visit (visitor, appData);
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
			for (AC_Variations node = this; node != null; node = node.m_AC_Variations)
			{
				node.parent = parent;
				node.m_AC_Variation?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule AC-Variations
		//

		public void _init ()
		{
			m_AC_Variation = null;
			m_AC_Variations = null;
		}

		public delegate object IteratorDelegate (AC_Variations p_AC_Variations, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<AC_Variations> stack = new Stack<AC_Variations> ();
			AC_Variations p_AC_Variations;
			for (p_AC_Variations = this; p_AC_Variations != null; p_AC_Variations = p_AC_Variations.m_AC_Variations)
				stack.Push (p_AC_Variations);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-Variations

		// counter of all nodes associated with syntax rule AC-Variations
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-Variations
		[DataMember (Name = "m_AC_Variation")] public AC_Variation m_AC_Variation { get; private set; }
		[DataMember (Name = "m_AC_Variations")] public AC_Variations m_AC_Variations { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-Variations

		// delegate function (callback) prototype associated with syntax rule AC-Variations
		public delegate bool AC_Variations_Callback (SyntaxTreeCallbackReason reason, AC_Variations.production_kind kind, AC_Variations p_AC_Variations);

		// event associated with syntax rule AC-Variations
		public event AC_Variations_Callback AC_Variations_Event;

		// event trigger associated with syntax rule AC-Variations
		public bool Raise_AC_Variations_Event (SyntaxTreeCallbackReason reason, AC_Variations.production_kind kind, AC_Variations p_AC_Variations)
		{
			bool? status = AC_Variations_Event?.Invoke (reason, kind, p_AC_Variations);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-Variations
		//
		// traverse syntax tree node associated with any production of syntax rule AC-Variations
		//

		public void Traverse (AC_Variations p_AC_Variations)
		{
			if (p_AC_Variations.isLocked())
				return;
			if (Raise_AC_Variations_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (AC_Variations.production_kind) p_AC_Variations.kind, p_AC_Variations))
				p_AC_Variations.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					AC_Variations.production_kind kind = (AC_Variations.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_AC_Variations_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case AC_Variations.production_kind.g_AC_Variations_1:
								// traverse syntax tree node associated with production
								// AC-Variations: AC-Variation

								if (Raise_AC_Variations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AC_Variation);
								node.turn_inc ();
								Raise_AC_Variations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case AC_Variations.production_kind.g_AC_Variations_2:
								// traverse syntax tree node associated with production
								// AC-Variations: AC-Variations AC-Variation

								if (Raise_AC_Variations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_AC_Variations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AC_Variation);
								node.turn_inc ();
								Raise_AC_Variations_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_AC_Variations_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_AC_Variations_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (AC_Variations.production_kind) p_AC_Variations.kind, p_AC_Variations);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Variations
		//

		public void TraverseCommon (AC_Variations p_AC_Variations)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_AC_Variations.kind, p_AC_Variations))
				p_AC_Variations.Iterate (null, (node, appData) =>
				{
					AC_Variations.production_kind kind = (AC_Variations.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case AC_Variations.production_kind.g_AC_Variations_1:
							// traverse syntax tree node associated with production
							// AC-Variations: AC-Variation

							TraverseCommon (node.m_AC_Variation);
							break;
						case AC_Variations.production_kind.g_AC_Variations_2:
							// traverse syntax tree node associated with production
							// AC-Variations: AC-Variations AC-Variation

							TraverseCommon (node.m_AC_Variation);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_AC_Variations.kind, p_AC_Variations);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-Variations

		//
		// create syntax tree node associated with production
		// AC-Variations: AC-Variation

		//

		public AC_Variations AC_Variations_1 (AC_Variation p_AC_Variation)
		{
			AC_Variations p_AC_Variations_ref = new AC_Variations(p_AC_Variation);
			p_AC_Variation.parent = p_AC_Variations_ref;
			Raise_AC_Variations_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Variations.production_kind.g_AC_Variations_1, p_AC_Variations_ref);
			return p_AC_Variations_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-Variations: AC-Variations AC-Variation

		//

		public AC_Variations AC_Variations_2 (AC_Variations p_AC_Variations, AC_Variation p_AC_Variation)
		{
			AC_Variations p_AC_Variations_ref = new AC_Variations(p_AC_Variations, p_AC_Variation);
			p_AC_Variations.parent = p_AC_Variations_ref;
			p_AC_Variation.parent = p_AC_Variations_ref;
			Raise_AC_Variations_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Variations.production_kind.g_AC_Variations_2, p_AC_Variations_ref);
			return p_AC_Variations_ref;
		}
		#endregion
	};
}
