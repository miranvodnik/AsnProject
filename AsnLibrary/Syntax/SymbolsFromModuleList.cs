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
	// class associated with syntax rule SymbolsFromModuleList
	//

	[DataContract]
	public class	SymbolsFromModuleList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SymbolsFromModuleList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SymbolsFromModuleList
		{
			g_SymbolsFromModuleList_1 = 1,	// SymbolsFromModule

			g_SymbolsFromModuleList_2 = 2,	// SymbolsFromModuleList SymbolsFromModule

		};
		#endregion
		#region production markers associated with the syntax rule SymbolsFromModuleList

		// markers associated with production: SymbolsFromModuleList -> SymbolsFromModule

		public enum production_marker_1 : ushort
		{
			m_SymbolsFromModule,
			final
		};

		// markers associated with production: SymbolsFromModuleList -> SymbolsFromModuleList SymbolsFromModule

		public enum production_marker_2 : ushort
		{
			m_SymbolsFromModuleList,
			m_SymbolsFromModule,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SymbolsFromModuleList

		// Constructor declaration(s) associated with production(s) of syntax rule SymbolsFromModuleList

		//
		// Constructor associated with the following production(s)
		// SymbolsFromModuleList -> SymbolsFromModule

		//

		public SymbolsFromModuleList (SymbolsFromModule p_SymbolsFromModule) : base ((uint) ProductionID._SymbolsFromModuleList_ID, (uint) production_kind.g_SymbolsFromModuleList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SymbolsFromModule = p_SymbolsFromModule;
		}

		//
		// Constructor associated with the following production(s)
		// SymbolsFromModuleList -> SymbolsFromModuleList SymbolsFromModule

		//

		public SymbolsFromModuleList (SymbolsFromModuleList p_SymbolsFromModuleList, SymbolsFromModule p_SymbolsFromModule) : base ((uint) ProductionID._SymbolsFromModuleList_ID, (uint) production_kind.g_SymbolsFromModuleList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_SymbolsFromModuleList = p_SymbolsFromModuleList;
			children[1] = m_SymbolsFromModule = p_SymbolsFromModule;
		}

		public SymbolsFromModuleList () { }

		// Copy constructor

		public SymbolsFromModuleList (SymbolsFromModuleList p_SymbolsFromModuleList) : base (p_SymbolsFromModuleList.id, p_SymbolsFromModuleList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SymbolsFromModuleList.appInfo;
			switch ((production_kind) p_SymbolsFromModuleList.kind)
			{
				case production_kind.g_SymbolsFromModuleList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SymbolsFromModule = (p_SymbolsFromModuleList.m_SymbolsFromModule != null) ? new SymbolsFromModule (p_SymbolsFromModuleList.m_SymbolsFromModule) : null) != null) m_SymbolsFromModule.parent = this;
					break;
				case production_kind.g_SymbolsFromModuleList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_SymbolsFromModuleList = (p_SymbolsFromModuleList.m_SymbolsFromModuleList != null) ? new SymbolsFromModuleList (p_SymbolsFromModuleList.m_SymbolsFromModuleList) : null) != null) m_SymbolsFromModuleList.parent = this;
					if ((children [1] = m_SymbolsFromModule = (p_SymbolsFromModuleList.m_SymbolsFromModule != null) ? new SymbolsFromModule (p_SymbolsFromModuleList.m_SymbolsFromModule) : null) != null) m_SymbolsFromModule.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SymbolsFromModuleList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SymbolsFromModuleList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_SymbolsFromModule?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SymbolsFromModuleList

		// Content changing function(s) associated with production(s) of syntax rule SymbolsFromModuleList

		//
		// Content changing function associated with following production(s)
		// SymbolsFromModuleList -> SymbolsFromModule

		//

		public void change(SymbolsFromModule p_SymbolsFromModule)
		{
			_init ();
			this.kind = (uint) production_kind.g_SymbolsFromModuleList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SymbolsFromModule = p_SymbolsFromModule;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SymbolsFromModuleList -> SymbolsFromModuleList SymbolsFromModule

		//

		public void change(SymbolsFromModuleList p_SymbolsFromModuleList, SymbolsFromModule p_SymbolsFromModule)
		{
			_init ();
			this.kind = (uint) production_kind.g_SymbolsFromModuleList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_SymbolsFromModuleList = p_SymbolsFromModuleList;
			children [1] = m_SymbolsFromModule = p_SymbolsFromModule;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SymbolsFromModuleList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_SymbolsFromModule != null) && node.m_SymbolsFromModule.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SymbolsFromModuleList

		//
		// emit production tree node associated with any production of syntax rule SymbolsFromModuleList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_SymbolsFromModuleList_1:
						// emit syntax tree node associated with production
						// SymbolsFromModuleList: SymbolsFromModule

						s += " " + node.m_SymbolsFromModule.Emit (depth - 1);
						break;
					case production_kind.g_SymbolsFromModuleList_2:
						// emit syntax tree node associated with production
						// SymbolsFromModuleList: SymbolsFromModuleList SymbolsFromModule

						s += " " + node.m_SymbolsFromModule.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SymbolsFromModuleList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "SymbolsFromModuleList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_SymbolsFromModuleList_1:
						// emit syntax tree node associated with production
						// SymbolsFromModuleList: SymbolsFromModule

						str += node.m_SymbolsFromModule.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_SymbolsFromModuleList_2:
						// emit syntax tree node associated with production
						// SymbolsFromModuleList: SymbolsFromModuleList SymbolsFromModule

						str += ' ';
						str += node.m_SymbolsFromModule.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SymbolsFromModuleList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SymbolsFromModuleList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					SymbolsFromModuleList.production_kind kind = (SymbolsFromModuleList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case SymbolsFromModuleList.production_kind.g_SymbolsFromModuleList_1:
							// traverse syntax tree node associated with production
							// SymbolsFromModuleList: SymbolsFromModule

							node.m_SymbolsFromModule.Visit (visitor, appData);
							break;
						case SymbolsFromModuleList.production_kind.g_SymbolsFromModuleList_2:
							// traverse syntax tree node associated with production
							// SymbolsFromModuleList: SymbolsFromModuleList SymbolsFromModule

							node.m_SymbolsFromModule.Visit (visitor, appData);
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
			for (SymbolsFromModuleList node = this; node != null; node = node.m_SymbolsFromModuleList)
			{
				node.parent = parent;
				node.m_SymbolsFromModule?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule SymbolsFromModuleList
		//

		public void _init ()
		{
			m_SymbolsFromModule = null;
			m_SymbolsFromModuleList = null;
		}

		public delegate object IteratorDelegate (SymbolsFromModuleList p_SymbolsFromModuleList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<SymbolsFromModuleList> stack = new Stack<SymbolsFromModuleList> ();
			SymbolsFromModuleList p_SymbolsFromModuleList;
			for (p_SymbolsFromModuleList = this; p_SymbolsFromModuleList != null; p_SymbolsFromModuleList = p_SymbolsFromModuleList.m_SymbolsFromModuleList)
				stack.Push (p_SymbolsFromModuleList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SymbolsFromModuleList

		// counter of all nodes associated with syntax rule SymbolsFromModuleList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SymbolsFromModuleList
		[DataMember (Name = "m_SymbolsFromModule")] public SymbolsFromModule m_SymbolsFromModule { get; private set; }
		[DataMember (Name = "m_SymbolsFromModuleList")] public SymbolsFromModuleList m_SymbolsFromModuleList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SymbolsFromModuleList

		// delegate function (callback) prototype associated with syntax rule SymbolsFromModuleList
		public delegate bool SymbolsFromModuleList_Callback (SyntaxTreeCallbackReason reason, SymbolsFromModuleList.production_kind kind, SymbolsFromModuleList p_SymbolsFromModuleList);

		// event associated with syntax rule SymbolsFromModuleList
		public event SymbolsFromModuleList_Callback SymbolsFromModuleList_Event;

		// event trigger associated with syntax rule SymbolsFromModuleList
		public bool Raise_SymbolsFromModuleList_Event (SyntaxTreeCallbackReason reason, SymbolsFromModuleList.production_kind kind, SymbolsFromModuleList p_SymbolsFromModuleList)
		{
			bool? status = SymbolsFromModuleList_Event?.Invoke (reason, kind, p_SymbolsFromModuleList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SymbolsFromModuleList
		//
		// traverse syntax tree node associated with any production of syntax rule SymbolsFromModuleList
		//

		public void Traverse (SymbolsFromModuleList p_SymbolsFromModuleList)
		{
			if (p_SymbolsFromModuleList.isLocked())
				return;
			if (Raise_SymbolsFromModuleList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (SymbolsFromModuleList.production_kind) p_SymbolsFromModuleList.kind, p_SymbolsFromModuleList))
				p_SymbolsFromModuleList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					SymbolsFromModuleList.production_kind kind = (SymbolsFromModuleList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_SymbolsFromModuleList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case SymbolsFromModuleList.production_kind.g_SymbolsFromModuleList_1:
								// traverse syntax tree node associated with production
								// SymbolsFromModuleList: SymbolsFromModule

								if (Raise_SymbolsFromModuleList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_SymbolsFromModule);
								node.turn_inc ();
								Raise_SymbolsFromModuleList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case SymbolsFromModuleList.production_kind.g_SymbolsFromModuleList_2:
								// traverse syntax tree node associated with production
								// SymbolsFromModuleList: SymbolsFromModuleList SymbolsFromModule

								if (Raise_SymbolsFromModuleList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_SymbolsFromModuleList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_SymbolsFromModule);
								node.turn_inc ();
								Raise_SymbolsFromModuleList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_SymbolsFromModuleList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_SymbolsFromModuleList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (SymbolsFromModuleList.production_kind) p_SymbolsFromModuleList.kind, p_SymbolsFromModuleList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SymbolsFromModuleList
		//

		public void TraverseCommon (SymbolsFromModuleList p_SymbolsFromModuleList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_SymbolsFromModuleList.kind, p_SymbolsFromModuleList))
				p_SymbolsFromModuleList.Iterate (null, (node, appData) =>
				{
					SymbolsFromModuleList.production_kind kind = (SymbolsFromModuleList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case SymbolsFromModuleList.production_kind.g_SymbolsFromModuleList_1:
							// traverse syntax tree node associated with production
							// SymbolsFromModuleList: SymbolsFromModule

							TraverseCommon (node.m_SymbolsFromModule);
							break;
						case SymbolsFromModuleList.production_kind.g_SymbolsFromModuleList_2:
							// traverse syntax tree node associated with production
							// SymbolsFromModuleList: SymbolsFromModuleList SymbolsFromModule

							TraverseCommon (node.m_SymbolsFromModule);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_SymbolsFromModuleList.kind, p_SymbolsFromModuleList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SymbolsFromModuleList

		//
		// create syntax tree node associated with production
		// SymbolsFromModuleList: SymbolsFromModule

		//

		public SymbolsFromModuleList SymbolsFromModuleList_1 (SymbolsFromModule p_SymbolsFromModule)
		{
			SymbolsFromModuleList p_SymbolsFromModuleList_ref = new SymbolsFromModuleList(p_SymbolsFromModule);
			p_SymbolsFromModule.parent = p_SymbolsFromModuleList_ref;
			Raise_SymbolsFromModuleList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SymbolsFromModuleList.production_kind.g_SymbolsFromModuleList_1, p_SymbolsFromModuleList_ref);
			return p_SymbolsFromModuleList_ref;
		}

		//
		// create syntax tree node associated with production
		// SymbolsFromModuleList: SymbolsFromModuleList SymbolsFromModule

		//

		public SymbolsFromModuleList SymbolsFromModuleList_2 (SymbolsFromModuleList p_SymbolsFromModuleList, SymbolsFromModule p_SymbolsFromModule)
		{
			SymbolsFromModuleList p_SymbolsFromModuleList_ref = new SymbolsFromModuleList(p_SymbolsFromModuleList, p_SymbolsFromModule);
			p_SymbolsFromModuleList.parent = p_SymbolsFromModuleList_ref;
			p_SymbolsFromModule.parent = p_SymbolsFromModuleList_ref;
			Raise_SymbolsFromModuleList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SymbolsFromModuleList.production_kind.g_SymbolsFromModuleList_2, p_SymbolsFromModuleList_ref);
			return p_SymbolsFromModuleList_ref;
		}
		#endregion
	};
}
