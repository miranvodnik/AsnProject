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
	// class associated with syntax rule EncodingControlSections
	//

	[DataContract]
	public class	EncodingControlSections : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EncodingControlSections
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EncodingControlSections
		{
			g_EncodingControlSections_1 = 1,	// %empty

			g_EncodingControlSections_2 = 2,	// EncodingControlSection

			g_EncodingControlSections_3 = 3,	// EncodingControlSections EncodingControlSection

		};
		#endregion
		#region production markers associated with the syntax rule EncodingControlSections

		// markers associated with production: EncodingControlSections -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: EncodingControlSections -> EncodingControlSection

		public enum production_marker_2 : ushort
		{
			m_EncodingControlSection,
			final
		};

		// markers associated with production: EncodingControlSections -> EncodingControlSections EncodingControlSection

		public enum production_marker_3 : ushort
		{
			m_EncodingControlSections,
			m_EncodingControlSection,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EncodingControlSections

		// Constructor declaration(s) associated with production(s) of syntax rule EncodingControlSections

		//
		// Constructor associated with the following production(s)
		// EncodingControlSections -> %empty

		//

		public EncodingControlSections () : base ((uint) ProductionID._EncodingControlSections_ID, (uint) production_kind.g_EncodingControlSections_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// EncodingControlSections -> EncodingControlSection

		//

		public EncodingControlSections (EncodingControlSection p_EncodingControlSection) : base ((uint) ProductionID._EncodingControlSections_ID, (uint) production_kind.g_EncodingControlSections_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EncodingControlSection = p_EncodingControlSection;
		}

		//
		// Constructor associated with the following production(s)
		// EncodingControlSections -> EncodingControlSections EncodingControlSection

		//

		public EncodingControlSections (EncodingControlSections p_EncodingControlSections, EncodingControlSection p_EncodingControlSection) : base ((uint) ProductionID._EncodingControlSections_ID, (uint) production_kind.g_EncodingControlSections_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_EncodingControlSections = p_EncodingControlSections;
			children[1] = m_EncodingControlSection = p_EncodingControlSection;
		}

		// Copy constructor

		public EncodingControlSections (EncodingControlSections p_EncodingControlSections) : base (p_EncodingControlSections.id, p_EncodingControlSections.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EncodingControlSections.appInfo;
			switch ((production_kind) p_EncodingControlSections.kind)
			{
				case production_kind.g_EncodingControlSections_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_EncodingControlSections_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EncodingControlSection = (p_EncodingControlSections.m_EncodingControlSection != null) ? new EncodingControlSection (p_EncodingControlSections.m_EncodingControlSection) : null) != null) m_EncodingControlSection.parent = this;
					break;
				case production_kind.g_EncodingControlSections_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_EncodingControlSections = (p_EncodingControlSections.m_EncodingControlSections != null) ? new EncodingControlSections (p_EncodingControlSections.m_EncodingControlSections) : null) != null) m_EncodingControlSections.parent = this;
					if ((children [1] = m_EncodingControlSection = (p_EncodingControlSections.m_EncodingControlSection != null) ? new EncodingControlSection (p_EncodingControlSections.m_EncodingControlSection) : null) != null) m_EncodingControlSection.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EncodingControlSections" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EncodingControlSections (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_EncodingControlSection?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EncodingControlSections

		// Content changing function(s) associated with production(s) of syntax rule EncodingControlSections

		//
		// Content changing function associated with following production(s)
		// EncodingControlSections -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_EncodingControlSections_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// EncodingControlSections -> EncodingControlSection

		//

		public void change(EncodingControlSection p_EncodingControlSection)
		{
			_init ();
			this.kind = (uint) production_kind.g_EncodingControlSections_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EncodingControlSection = p_EncodingControlSection;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// EncodingControlSections -> EncodingControlSections EncodingControlSection

		//

		public void change(EncodingControlSections p_EncodingControlSections, EncodingControlSection p_EncodingControlSection)
		{
			_init ();
			this.kind = (uint) production_kind.g_EncodingControlSections_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_EncodingControlSections = p_EncodingControlSections;
			children [1] = m_EncodingControlSection = p_EncodingControlSection;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EncodingControlSections
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_EncodingControlSection != null) && node.m_EncodingControlSection.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EncodingControlSections

		//
		// emit production tree node associated with any production of syntax rule EncodingControlSections
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_EncodingControlSections_1:
						// emit syntax tree node associated with production
						// EncodingControlSections: %empty

						break;
					case production_kind.g_EncodingControlSections_2:
						// emit syntax tree node associated with production
						// EncodingControlSections: EncodingControlSection

						s += " " + node.m_EncodingControlSection.Emit (depth - 1);
						break;
					case production_kind.g_EncodingControlSections_3:
						// emit syntax tree node associated with production
						// EncodingControlSections: EncodingControlSections EncodingControlSection

						s += " " + node.m_EncodingControlSection.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EncodingControlSections
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "EncodingControlSections (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_EncodingControlSections_1:
						// emit syntax tree node associated with production
						// EncodingControlSections: %empty

						break;
					case production_kind.g_EncodingControlSections_2:
						// emit syntax tree node associated with production
						// EncodingControlSections: EncodingControlSection

						str += node.m_EncodingControlSection.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_EncodingControlSections_3:
						// emit syntax tree node associated with production
						// EncodingControlSections: EncodingControlSections EncodingControlSection

						str += ' ';
						str += node.m_EncodingControlSection.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EncodingControlSections

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EncodingControlSections with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					EncodingControlSections.production_kind kind = (EncodingControlSections.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case EncodingControlSections.production_kind.g_EncodingControlSections_1:
							// traverse syntax tree node associated with production
							// EncodingControlSections: %empty

							break;
						case EncodingControlSections.production_kind.g_EncodingControlSections_2:
							// traverse syntax tree node associated with production
							// EncodingControlSections: EncodingControlSection

							node.m_EncodingControlSection.Visit (visitor, appData);
							break;
						case EncodingControlSections.production_kind.g_EncodingControlSections_3:
							// traverse syntax tree node associated with production
							// EncodingControlSections: EncodingControlSections EncodingControlSection

							node.m_EncodingControlSection.Visit (visitor, appData);
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
			for (EncodingControlSections node = this; node != null; node = node.m_EncodingControlSections)
			{
				node.parent = parent;
				node.m_EncodingControlSection?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule EncodingControlSections
		//

		public void _init ()
		{
			m_EncodingControlSection = null;
			m_EncodingControlSections = null;
		}

		public delegate object IteratorDelegate (EncodingControlSections p_EncodingControlSections, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<EncodingControlSections> stack = new Stack<EncodingControlSections> ();
			EncodingControlSections p_EncodingControlSections;
			for (p_EncodingControlSections = this; p_EncodingControlSections != null; p_EncodingControlSections = p_EncodingControlSections.m_EncodingControlSections)
				stack.Push (p_EncodingControlSections);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EncodingControlSections

		// counter of all nodes associated with syntax rule EncodingControlSections
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EncodingControlSections
		[DataMember (Name = "m_EncodingControlSection")] public EncodingControlSection m_EncodingControlSection { get; private set; }
		[DataMember (Name = "m_EncodingControlSections")] public EncodingControlSections m_EncodingControlSections { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EncodingControlSections

		// delegate function (callback) prototype associated with syntax rule EncodingControlSections
		public delegate bool EncodingControlSections_Callback (SyntaxTreeCallbackReason reason, EncodingControlSections.production_kind kind, EncodingControlSections p_EncodingControlSections);

		// event associated with syntax rule EncodingControlSections
		public event EncodingControlSections_Callback EncodingControlSections_Event;

		// event trigger associated with syntax rule EncodingControlSections
		public bool Raise_EncodingControlSections_Event (SyntaxTreeCallbackReason reason, EncodingControlSections.production_kind kind, EncodingControlSections p_EncodingControlSections)
		{
			bool? status = EncodingControlSections_Event?.Invoke (reason, kind, p_EncodingControlSections);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EncodingControlSections
		//
		// traverse syntax tree node associated with any production of syntax rule EncodingControlSections
		//

		public void Traverse (EncodingControlSections p_EncodingControlSections)
		{
			if (p_EncodingControlSections.isLocked())
				return;
			if (Raise_EncodingControlSections_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (EncodingControlSections.production_kind) p_EncodingControlSections.kind, p_EncodingControlSections))
				p_EncodingControlSections.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					EncodingControlSections.production_kind kind = (EncodingControlSections.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_EncodingControlSections_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case EncodingControlSections.production_kind.g_EncodingControlSections_1:
								// traverse syntax tree node associated with production
								// EncodingControlSections: %empty

							break;
							case EncodingControlSections.production_kind.g_EncodingControlSections_2:
								// traverse syntax tree node associated with production
								// EncodingControlSections: EncodingControlSection

								if (Raise_EncodingControlSections_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_EncodingControlSection);
								node.turn_inc ();
								Raise_EncodingControlSections_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case EncodingControlSections.production_kind.g_EncodingControlSections_3:
								// traverse syntax tree node associated with production
								// EncodingControlSections: EncodingControlSections EncodingControlSection

								if (Raise_EncodingControlSections_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_EncodingControlSections_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_EncodingControlSection);
								node.turn_inc ();
								Raise_EncodingControlSections_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_EncodingControlSections_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_EncodingControlSections_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (EncodingControlSections.production_kind) p_EncodingControlSections.kind, p_EncodingControlSections);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EncodingControlSections
		//

		public void TraverseCommon (EncodingControlSections p_EncodingControlSections)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_EncodingControlSections.kind, p_EncodingControlSections))
				p_EncodingControlSections.Iterate (null, (node, appData) =>
				{
					EncodingControlSections.production_kind kind = (EncodingControlSections.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case EncodingControlSections.production_kind.g_EncodingControlSections_1:
							// traverse syntax tree node associated with production
							// EncodingControlSections: %empty

							break;
						case EncodingControlSections.production_kind.g_EncodingControlSections_2:
							// traverse syntax tree node associated with production
							// EncodingControlSections: EncodingControlSection

							TraverseCommon (node.m_EncodingControlSection);
							break;
						case EncodingControlSections.production_kind.g_EncodingControlSections_3:
							// traverse syntax tree node associated with production
							// EncodingControlSections: EncodingControlSections EncodingControlSection

							TraverseCommon (node.m_EncodingControlSection);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_EncodingControlSections.kind, p_EncodingControlSections);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EncodingControlSections

		//
		// create syntax tree node associated with production
		// EncodingControlSections: %empty

		//

		public EncodingControlSections EncodingControlSections_1 ()
		{
			EncodingControlSections p_EncodingControlSections_ref = new EncodingControlSections();
			Raise_EncodingControlSections_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EncodingControlSections.production_kind.g_EncodingControlSections_1, p_EncodingControlSections_ref);
			return p_EncodingControlSections_ref;
		}

		//
		// create syntax tree node associated with production
		// EncodingControlSections: EncodingControlSection

		//

		public EncodingControlSections EncodingControlSections_2 (EncodingControlSection p_EncodingControlSection)
		{
			EncodingControlSections p_EncodingControlSections_ref = new EncodingControlSections(p_EncodingControlSection);
			p_EncodingControlSection.parent = p_EncodingControlSections_ref;
			Raise_EncodingControlSections_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EncodingControlSections.production_kind.g_EncodingControlSections_2, p_EncodingControlSections_ref);
			return p_EncodingControlSections_ref;
		}

		//
		// create syntax tree node associated with production
		// EncodingControlSections: EncodingControlSections EncodingControlSection

		//

		public EncodingControlSections EncodingControlSections_3 (EncodingControlSections p_EncodingControlSections, EncodingControlSection p_EncodingControlSection)
		{
			EncodingControlSections p_EncodingControlSections_ref = new EncodingControlSections(p_EncodingControlSections, p_EncodingControlSection);
			p_EncodingControlSections.parent = p_EncodingControlSections_ref;
			p_EncodingControlSection.parent = p_EncodingControlSections_ref;
			Raise_EncodingControlSections_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EncodingControlSections.production_kind.g_EncodingControlSections_3, p_EncodingControlSections_ref);
			return p_EncodingControlSections_ref;
		}
		#endregion
	};
}
