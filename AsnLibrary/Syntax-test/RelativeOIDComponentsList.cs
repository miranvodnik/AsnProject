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
	// class associated with syntax rule RelativeOIDComponentsList
	//

	[DataContract]
	public class	RelativeOIDComponentsList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RelativeOIDComponentsList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RelativeOIDComponentsList
		{
			g_RelativeOIDComponentsList_1 = 1,	// RelativeOIDComponents

			g_RelativeOIDComponentsList_2 = 2,	// RelativeOIDComponentsList RelativeOIDComponents

		};
		#endregion
		#region production markers associated with the syntax rule RelativeOIDComponentsList

		// markers associated with production: RelativeOIDComponentsList -> RelativeOIDComponents

		public enum production_marker_1 : ushort
		{
			m_RelativeOIDComponents,
			final
		};

		// markers associated with production: RelativeOIDComponentsList -> RelativeOIDComponentsList RelativeOIDComponents

		public enum production_marker_2 : ushort
		{
			m_RelativeOIDComponentsList,
			m_RelativeOIDComponents,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RelativeOIDComponentsList

		// Constructor declaration(s) associated with production(s) of syntax rule RelativeOIDComponentsList

		//
		// Constructor associated with the following production(s)
		// RelativeOIDComponentsList -> RelativeOIDComponents

		//

		public RelativeOIDComponentsList (RelativeOIDComponents p_RelativeOIDComponents) : base ((uint) ProductionID._RelativeOIDComponentsList_ID, (uint) production_kind.g_RelativeOIDComponentsList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RelativeOIDComponents = p_RelativeOIDComponents;
		}

		//
		// Constructor associated with the following production(s)
		// RelativeOIDComponentsList -> RelativeOIDComponentsList RelativeOIDComponents

		//

		public RelativeOIDComponentsList (RelativeOIDComponentsList p_RelativeOIDComponentsList, RelativeOIDComponents p_RelativeOIDComponents) : base ((uint) ProductionID._RelativeOIDComponentsList_ID, (uint) production_kind.g_RelativeOIDComponentsList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_RelativeOIDComponentsList = p_RelativeOIDComponentsList;
			children[1] = m_RelativeOIDComponents = p_RelativeOIDComponents;
		}

		public RelativeOIDComponentsList () { }

		// Copy constructor

		public RelativeOIDComponentsList (RelativeOIDComponentsList p_RelativeOIDComponentsList) : base (p_RelativeOIDComponentsList.id, p_RelativeOIDComponentsList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RelativeOIDComponentsList.appInfo;
			switch ((production_kind) p_RelativeOIDComponentsList.kind)
			{
				case production_kind.g_RelativeOIDComponentsList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RelativeOIDComponents = (p_RelativeOIDComponentsList.m_RelativeOIDComponents != null) ? new RelativeOIDComponents (p_RelativeOIDComponentsList.m_RelativeOIDComponents) : null) != null) m_RelativeOIDComponents.parent = this;
					break;
				case production_kind.g_RelativeOIDComponentsList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_RelativeOIDComponentsList = (p_RelativeOIDComponentsList.m_RelativeOIDComponentsList != null) ? new RelativeOIDComponentsList (p_RelativeOIDComponentsList.m_RelativeOIDComponentsList) : null) != null) m_RelativeOIDComponentsList.parent = this;
					if ((children [1] = m_RelativeOIDComponents = (p_RelativeOIDComponentsList.m_RelativeOIDComponents != null) ? new RelativeOIDComponents (p_RelativeOIDComponentsList.m_RelativeOIDComponents) : null) != null) m_RelativeOIDComponents.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RelativeOIDComponentsList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RelativeOIDComponentsList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_RelativeOIDComponents?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RelativeOIDComponentsList

		// Content changing function(s) associated with production(s) of syntax rule RelativeOIDComponentsList

		//
		// Content changing function associated with following production(s)
		// RelativeOIDComponentsList -> RelativeOIDComponents

		//

		public void change(RelativeOIDComponents p_RelativeOIDComponents)
		{
			_init ();
			this.kind = (uint) production_kind.g_RelativeOIDComponentsList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RelativeOIDComponents = p_RelativeOIDComponents;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// RelativeOIDComponentsList -> RelativeOIDComponentsList RelativeOIDComponents

		//

		public void change(RelativeOIDComponentsList p_RelativeOIDComponentsList, RelativeOIDComponents p_RelativeOIDComponents)
		{
			_init ();
			this.kind = (uint) production_kind.g_RelativeOIDComponentsList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_RelativeOIDComponentsList = p_RelativeOIDComponentsList;
			children [1] = m_RelativeOIDComponents = p_RelativeOIDComponents;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RelativeOIDComponentsList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_RelativeOIDComponents != null) && node.m_RelativeOIDComponents.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RelativeOIDComponentsList

		//
		// emit production tree node associated with any production of syntax rule RelativeOIDComponentsList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_RelativeOIDComponentsList_1:
						// emit syntax tree node associated with production
						// RelativeOIDComponentsList: RelativeOIDComponents

						s += " " + node.m_RelativeOIDComponents.Emit (depth - 1);
						break;
					case production_kind.g_RelativeOIDComponentsList_2:
						// emit syntax tree node associated with production
						// RelativeOIDComponentsList: RelativeOIDComponentsList RelativeOIDComponents

						s += " " + node.m_RelativeOIDComponents.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RelativeOIDComponentsList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "RelativeOIDComponentsList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_RelativeOIDComponentsList_1:
						// emit syntax tree node associated with production
						// RelativeOIDComponentsList: RelativeOIDComponents

						str += node.m_RelativeOIDComponents.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_RelativeOIDComponentsList_2:
						// emit syntax tree node associated with production
						// RelativeOIDComponentsList: RelativeOIDComponentsList RelativeOIDComponents

						str += ' ';
						str += node.m_RelativeOIDComponents.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RelativeOIDComponentsList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RelativeOIDComponentsList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					RelativeOIDComponentsList.production_kind kind = (RelativeOIDComponentsList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case RelativeOIDComponentsList.production_kind.g_RelativeOIDComponentsList_1:
							// traverse syntax tree node associated with production
							// RelativeOIDComponentsList: RelativeOIDComponents

							node.m_RelativeOIDComponents.Visit (visitor, appData);
							break;
						case RelativeOIDComponentsList.production_kind.g_RelativeOIDComponentsList_2:
							// traverse syntax tree node associated with production
							// RelativeOIDComponentsList: RelativeOIDComponentsList RelativeOIDComponents

							node.m_RelativeOIDComponents.Visit (visitor, appData);
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
			for (RelativeOIDComponentsList node = this; node != null; node = node.m_RelativeOIDComponentsList)
			{
				node.parent = parent;
				node.m_RelativeOIDComponents?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule RelativeOIDComponentsList
		//

		public void _init ()
		{
			m_RelativeOIDComponents = null;
			m_RelativeOIDComponentsList = null;
		}

		public delegate object IteratorDelegate (RelativeOIDComponentsList p_RelativeOIDComponentsList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<RelativeOIDComponentsList> stack = new Stack<RelativeOIDComponentsList> ();
			RelativeOIDComponentsList p_RelativeOIDComponentsList;
			for (p_RelativeOIDComponentsList = this; p_RelativeOIDComponentsList != null; p_RelativeOIDComponentsList = p_RelativeOIDComponentsList.m_RelativeOIDComponentsList)
				stack.Push (p_RelativeOIDComponentsList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RelativeOIDComponentsList

		// counter of all nodes associated with syntax rule RelativeOIDComponentsList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RelativeOIDComponentsList
		[DataMember (Name = "m_RelativeOIDComponents")] public RelativeOIDComponents m_RelativeOIDComponents { get; private set; }
		[DataMember (Name = "m_RelativeOIDComponentsList")] public RelativeOIDComponentsList m_RelativeOIDComponentsList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RelativeOIDComponentsList

		// delegate function (callback) prototype associated with syntax rule RelativeOIDComponentsList
		public delegate bool RelativeOIDComponentsList_Callback (SyntaxTreeCallbackReason reason, RelativeOIDComponentsList.production_kind kind, RelativeOIDComponentsList p_RelativeOIDComponentsList);

		// event associated with syntax rule RelativeOIDComponentsList
		public event RelativeOIDComponentsList_Callback RelativeOIDComponentsList_Event;

		// event trigger associated with syntax rule RelativeOIDComponentsList
		public bool Raise_RelativeOIDComponentsList_Event (SyntaxTreeCallbackReason reason, RelativeOIDComponentsList.production_kind kind, RelativeOIDComponentsList p_RelativeOIDComponentsList)
		{
			bool? status = RelativeOIDComponentsList_Event?.Invoke (reason, kind, p_RelativeOIDComponentsList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RelativeOIDComponentsList
		//
		// traverse syntax tree node associated with any production of syntax rule RelativeOIDComponentsList
		//

		public void Traverse (RelativeOIDComponentsList p_RelativeOIDComponentsList)
		{
			if (p_RelativeOIDComponentsList.isLocked())
				return;
			if (Raise_RelativeOIDComponentsList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (RelativeOIDComponentsList.production_kind) p_RelativeOIDComponentsList.kind, p_RelativeOIDComponentsList))
				p_RelativeOIDComponentsList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					RelativeOIDComponentsList.production_kind kind = (RelativeOIDComponentsList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_RelativeOIDComponentsList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case RelativeOIDComponentsList.production_kind.g_RelativeOIDComponentsList_1:
								// traverse syntax tree node associated with production
								// RelativeOIDComponentsList: RelativeOIDComponents

								if (Raise_RelativeOIDComponentsList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_RelativeOIDComponents);
								node.turn_inc ();
								Raise_RelativeOIDComponentsList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case RelativeOIDComponentsList.production_kind.g_RelativeOIDComponentsList_2:
								// traverse syntax tree node associated with production
								// RelativeOIDComponentsList: RelativeOIDComponentsList RelativeOIDComponents

								if (Raise_RelativeOIDComponentsList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_RelativeOIDComponentsList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_RelativeOIDComponents);
								node.turn_inc ();
								Raise_RelativeOIDComponentsList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_RelativeOIDComponentsList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_RelativeOIDComponentsList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (RelativeOIDComponentsList.production_kind) p_RelativeOIDComponentsList.kind, p_RelativeOIDComponentsList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RelativeOIDComponentsList
		//

		public void TraverseCommon (RelativeOIDComponentsList p_RelativeOIDComponentsList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_RelativeOIDComponentsList.kind, p_RelativeOIDComponentsList))
				p_RelativeOIDComponentsList.Iterate (null, (node, appData) =>
				{
					RelativeOIDComponentsList.production_kind kind = (RelativeOIDComponentsList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case RelativeOIDComponentsList.production_kind.g_RelativeOIDComponentsList_1:
							// traverse syntax tree node associated with production
							// RelativeOIDComponentsList: RelativeOIDComponents

							TraverseCommon (node.m_RelativeOIDComponents);
							break;
						case RelativeOIDComponentsList.production_kind.g_RelativeOIDComponentsList_2:
							// traverse syntax tree node associated with production
							// RelativeOIDComponentsList: RelativeOIDComponentsList RelativeOIDComponents

							TraverseCommon (node.m_RelativeOIDComponents);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_RelativeOIDComponentsList.kind, p_RelativeOIDComponentsList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RelativeOIDComponentsList

		//
		// create syntax tree node associated with production
		// RelativeOIDComponentsList: RelativeOIDComponents

		//

		public RelativeOIDComponentsList RelativeOIDComponentsList_1 (RelativeOIDComponents p_RelativeOIDComponents)
		{
			RelativeOIDComponentsList p_RelativeOIDComponentsList_ref = new RelativeOIDComponentsList(p_RelativeOIDComponents);
			p_RelativeOIDComponents.parent = p_RelativeOIDComponentsList_ref;
			Raise_RelativeOIDComponentsList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RelativeOIDComponentsList.production_kind.g_RelativeOIDComponentsList_1, p_RelativeOIDComponentsList_ref);
			return p_RelativeOIDComponentsList_ref;
		}

		//
		// create syntax tree node associated with production
		// RelativeOIDComponentsList: RelativeOIDComponentsList RelativeOIDComponents

		//

		public RelativeOIDComponentsList RelativeOIDComponentsList_2 (RelativeOIDComponentsList p_RelativeOIDComponentsList, RelativeOIDComponents p_RelativeOIDComponents)
		{
			RelativeOIDComponentsList p_RelativeOIDComponentsList_ref = new RelativeOIDComponentsList(p_RelativeOIDComponentsList, p_RelativeOIDComponents);
			p_RelativeOIDComponentsList.parent = p_RelativeOIDComponentsList_ref;
			p_RelativeOIDComponents.parent = p_RelativeOIDComponentsList_ref;
			Raise_RelativeOIDComponentsList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RelativeOIDComponentsList.production_kind.g_RelativeOIDComponentsList_2, p_RelativeOIDComponentsList_ref);
			return p_RelativeOIDComponentsList_ref;
		}
		#endregion
	};
}
