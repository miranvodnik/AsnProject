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
	// class associated with syntax rule ObjIdComponentsList
	//

	[DataContract]
	public class	ObjIdComponentsList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjIdComponentsList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjIdComponentsList
		{
			g_ObjIdComponentsList_1 = 1,	// ObjIdComponents

			g_ObjIdComponentsList_2 = 2,	// ObjIdComponentsList ObjIdComponents

		};
		#endregion
		#region production markers associated with the syntax rule ObjIdComponentsList

		// markers associated with production: ObjIdComponentsList -> ObjIdComponents

		public enum production_marker_1 : ushort
		{
			m_ObjIdComponents,
			final
		};

		// markers associated with production: ObjIdComponentsList -> ObjIdComponentsList ObjIdComponents

		public enum production_marker_2 : ushort
		{
			m_ObjIdComponentsList,
			m_ObjIdComponents,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjIdComponentsList

		// Constructor declaration(s) associated with production(s) of syntax rule ObjIdComponentsList

		//
		// Constructor associated with the following production(s)
		// ObjIdComponentsList -> ObjIdComponents

		//

		public ObjIdComponentsList (ObjIdComponents p_ObjIdComponents) : base ((uint) ProductionID._ObjIdComponentsList_ID, (uint) production_kind.g_ObjIdComponentsList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjIdComponents = p_ObjIdComponents;
		}

		//
		// Constructor associated with the following production(s)
		// ObjIdComponentsList -> ObjIdComponentsList ObjIdComponents

		//

		public ObjIdComponentsList (ObjIdComponentsList p_ObjIdComponentsList, ObjIdComponents p_ObjIdComponents) : base ((uint) ProductionID._ObjIdComponentsList_ID, (uint) production_kind.g_ObjIdComponentsList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ObjIdComponentsList = p_ObjIdComponentsList;
			children[1] = m_ObjIdComponents = p_ObjIdComponents;
		}

		public ObjIdComponentsList () { }

		// Copy constructor

		public ObjIdComponentsList (ObjIdComponentsList p_ObjIdComponentsList) : base (p_ObjIdComponentsList.id, p_ObjIdComponentsList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjIdComponentsList.appInfo;
			switch ((production_kind) p_ObjIdComponentsList.kind)
			{
				case production_kind.g_ObjIdComponentsList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjIdComponents = (p_ObjIdComponentsList.m_ObjIdComponents != null) ? new ObjIdComponents (p_ObjIdComponentsList.m_ObjIdComponents) : null) != null) m_ObjIdComponents.parent = this;
					break;
				case production_kind.g_ObjIdComponentsList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ObjIdComponentsList = (p_ObjIdComponentsList.m_ObjIdComponentsList != null) ? new ObjIdComponentsList (p_ObjIdComponentsList.m_ObjIdComponentsList) : null) != null) m_ObjIdComponentsList.parent = this;
					if ((children [1] = m_ObjIdComponents = (p_ObjIdComponentsList.m_ObjIdComponents != null) ? new ObjIdComponents (p_ObjIdComponentsList.m_ObjIdComponents) : null) != null) m_ObjIdComponents.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjIdComponentsList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjIdComponentsList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_ObjIdComponents?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjIdComponentsList

		// Content changing function(s) associated with production(s) of syntax rule ObjIdComponentsList

		//
		// Content changing function associated with following production(s)
		// ObjIdComponentsList -> ObjIdComponents

		//

		public void change(ObjIdComponents p_ObjIdComponents)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjIdComponentsList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjIdComponents = p_ObjIdComponents;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjIdComponentsList -> ObjIdComponentsList ObjIdComponents

		//

		public void change(ObjIdComponentsList p_ObjIdComponentsList, ObjIdComponents p_ObjIdComponents)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjIdComponentsList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ObjIdComponentsList = p_ObjIdComponentsList;
			children [1] = m_ObjIdComponents = p_ObjIdComponents;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjIdComponentsList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_ObjIdComponents != null) && node.m_ObjIdComponents.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjIdComponentsList

		//
		// emit production tree node associated with any production of syntax rule ObjIdComponentsList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ObjIdComponentsList_1:
						// emit syntax tree node associated with production
						// ObjIdComponentsList: ObjIdComponents

						s += " " + node.m_ObjIdComponents.Emit (depth - 1);
						break;
					case production_kind.g_ObjIdComponentsList_2:
						// emit syntax tree node associated with production
						// ObjIdComponentsList: ObjIdComponentsList ObjIdComponents

						s += " " + node.m_ObjIdComponents.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjIdComponentsList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "ObjIdComponentsList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ObjIdComponentsList_1:
						// emit syntax tree node associated with production
						// ObjIdComponentsList: ObjIdComponents

						str += node.m_ObjIdComponents.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_ObjIdComponentsList_2:
						// emit syntax tree node associated with production
						// ObjIdComponentsList: ObjIdComponentsList ObjIdComponents

						str += ' ';
						str += node.m_ObjIdComponents.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjIdComponentsList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjIdComponentsList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					ObjIdComponentsList.production_kind kind = (ObjIdComponentsList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case ObjIdComponentsList.production_kind.g_ObjIdComponentsList_1:
							// traverse syntax tree node associated with production
							// ObjIdComponentsList: ObjIdComponents

							node.m_ObjIdComponents.Visit (visitor, appData);
							break;
						case ObjIdComponentsList.production_kind.g_ObjIdComponentsList_2:
							// traverse syntax tree node associated with production
							// ObjIdComponentsList: ObjIdComponentsList ObjIdComponents

							node.m_ObjIdComponents.Visit (visitor, appData);
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
			for (ObjIdComponentsList node = this; node != null; node = node.m_ObjIdComponentsList)
			{
				node.parent = parent;
				node.m_ObjIdComponents?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule ObjIdComponentsList
		//

		public void _init ()
		{
			m_ObjIdComponents = null;
			m_ObjIdComponentsList = null;
		}

		public delegate object IteratorDelegate (ObjIdComponentsList p_ObjIdComponentsList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<ObjIdComponentsList> stack = new Stack<ObjIdComponentsList> ();
			ObjIdComponentsList p_ObjIdComponentsList;
			for (p_ObjIdComponentsList = this; p_ObjIdComponentsList != null; p_ObjIdComponentsList = p_ObjIdComponentsList.m_ObjIdComponentsList)
				stack.Push (p_ObjIdComponentsList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjIdComponentsList

		// counter of all nodes associated with syntax rule ObjIdComponentsList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjIdComponentsList
		[DataMember (Name = "m_ObjIdComponents")] public ObjIdComponents m_ObjIdComponents { get; private set; }
		[DataMember (Name = "m_ObjIdComponentsList")] public ObjIdComponentsList m_ObjIdComponentsList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjIdComponentsList

		// delegate function (callback) prototype associated with syntax rule ObjIdComponentsList
		public delegate bool ObjIdComponentsList_Callback (SyntaxTreeCallbackReason reason, ObjIdComponentsList.production_kind kind, ObjIdComponentsList p_ObjIdComponentsList);

		// event associated with syntax rule ObjIdComponentsList
		public event ObjIdComponentsList_Callback ObjIdComponentsList_Event;

		// event trigger associated with syntax rule ObjIdComponentsList
		public bool Raise_ObjIdComponentsList_Event (SyntaxTreeCallbackReason reason, ObjIdComponentsList.production_kind kind, ObjIdComponentsList p_ObjIdComponentsList)
		{
			bool? status = ObjIdComponentsList_Event?.Invoke (reason, kind, p_ObjIdComponentsList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjIdComponentsList
		//
		// traverse syntax tree node associated with any production of syntax rule ObjIdComponentsList
		//

		public void Traverse (ObjIdComponentsList p_ObjIdComponentsList)
		{
			if (p_ObjIdComponentsList.isLocked())
				return;
			if (Raise_ObjIdComponentsList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (ObjIdComponentsList.production_kind) p_ObjIdComponentsList.kind, p_ObjIdComponentsList))
				p_ObjIdComponentsList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					ObjIdComponentsList.production_kind kind = (ObjIdComponentsList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_ObjIdComponentsList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case ObjIdComponentsList.production_kind.g_ObjIdComponentsList_1:
								// traverse syntax tree node associated with production
								// ObjIdComponentsList: ObjIdComponents

								if (Raise_ObjIdComponentsList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_ObjIdComponents);
								node.turn_inc ();
								Raise_ObjIdComponentsList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case ObjIdComponentsList.production_kind.g_ObjIdComponentsList_2:
								// traverse syntax tree node associated with production
								// ObjIdComponentsList: ObjIdComponentsList ObjIdComponents

								if (Raise_ObjIdComponentsList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_ObjIdComponentsList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_ObjIdComponents);
								node.turn_inc ();
								Raise_ObjIdComponentsList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_ObjIdComponentsList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_ObjIdComponentsList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (ObjIdComponentsList.production_kind) p_ObjIdComponentsList.kind, p_ObjIdComponentsList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjIdComponentsList
		//

		public void TraverseCommon (ObjIdComponentsList p_ObjIdComponentsList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_ObjIdComponentsList.kind, p_ObjIdComponentsList))
				p_ObjIdComponentsList.Iterate (null, (node, appData) =>
				{
					ObjIdComponentsList.production_kind kind = (ObjIdComponentsList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case ObjIdComponentsList.production_kind.g_ObjIdComponentsList_1:
							// traverse syntax tree node associated with production
							// ObjIdComponentsList: ObjIdComponents

							TraverseCommon (node.m_ObjIdComponents);
							break;
						case ObjIdComponentsList.production_kind.g_ObjIdComponentsList_2:
							// traverse syntax tree node associated with production
							// ObjIdComponentsList: ObjIdComponentsList ObjIdComponents

							TraverseCommon (node.m_ObjIdComponents);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_ObjIdComponentsList.kind, p_ObjIdComponentsList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjIdComponentsList

		//
		// create syntax tree node associated with production
		// ObjIdComponentsList: ObjIdComponents

		//

		public ObjIdComponentsList ObjIdComponentsList_1 (ObjIdComponents p_ObjIdComponents)
		{
			ObjIdComponentsList p_ObjIdComponentsList_ref = new ObjIdComponentsList(p_ObjIdComponents);
			p_ObjIdComponents.parent = p_ObjIdComponentsList_ref;
			Raise_ObjIdComponentsList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjIdComponentsList.production_kind.g_ObjIdComponentsList_1, p_ObjIdComponentsList_ref);
			return p_ObjIdComponentsList_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjIdComponentsList: ObjIdComponentsList ObjIdComponents

		//

		public ObjIdComponentsList ObjIdComponentsList_2 (ObjIdComponentsList p_ObjIdComponentsList, ObjIdComponents p_ObjIdComponents)
		{
			ObjIdComponentsList p_ObjIdComponentsList_ref = new ObjIdComponentsList(p_ObjIdComponentsList, p_ObjIdComponents);
			p_ObjIdComponentsList.parent = p_ObjIdComponentsList_ref;
			p_ObjIdComponents.parent = p_ObjIdComponentsList_ref;
			Raise_ObjIdComponentsList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjIdComponentsList.production_kind.g_ObjIdComponentsList_2, p_ObjIdComponentsList_ref);
			return p_ObjIdComponentsList_ref;
		}
		#endregion
	};
}
