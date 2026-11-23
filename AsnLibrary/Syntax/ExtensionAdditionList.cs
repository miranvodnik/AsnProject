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
	// class associated with syntax rule ExtensionAdditionList
	//

	[DataContract]
	public class	ExtensionAdditionList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExtensionAdditionList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExtensionAdditionList
		{
			g_ExtensionAdditionList_1 = 1,	// ExtensionAddition

			g_ExtensionAdditionList_2 = 2,	// ExtensionAdditionList "," ExtensionAddition

		};
		#endregion
		#region production markers associated with the syntax rule ExtensionAdditionList

		// markers associated with production: ExtensionAdditionList -> ExtensionAddition

		public enum production_marker_1 : ushort
		{
			m_ExtensionAddition,
			final
		};

		// markers associated with production: ExtensionAdditionList -> ExtensionAdditionList "," ExtensionAddition

		public enum production_marker_2 : ushort
		{
			m_ExtensionAdditionList,
			m_ExtensionAddition,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExtensionAdditionList

		// Constructor declaration(s) associated with production(s) of syntax rule ExtensionAdditionList

		//
		// Constructor associated with the following production(s)
		// ExtensionAdditionList -> ExtensionAddition

		//

		public ExtensionAdditionList (ExtensionAddition p_ExtensionAddition) : base ((uint) ProductionID._ExtensionAdditionList_ID, (uint) production_kind.g_ExtensionAdditionList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExtensionAddition = p_ExtensionAddition;
		}

		//
		// Constructor associated with the following production(s)
		// ExtensionAdditionList -> ExtensionAdditionList "," ExtensionAddition

		//

		public ExtensionAdditionList (ExtensionAdditionList p_ExtensionAdditionList, SyntaxTreeToken p_token, ExtensionAddition p_ExtensionAddition) : base ((uint) ProductionID._ExtensionAdditionList_ID, (uint) production_kind.g_ExtensionAdditionList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ExtensionAdditionList = p_ExtensionAdditionList;
			children[1] = m_comma = p_token;
			children[2] = m_ExtensionAddition = p_ExtensionAddition;
		}

		public ExtensionAdditionList () { }

		// Copy constructor

		public ExtensionAdditionList (ExtensionAdditionList p_ExtensionAdditionList) : base (p_ExtensionAdditionList.id, p_ExtensionAdditionList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExtensionAdditionList.appInfo;
			switch ((production_kind) p_ExtensionAdditionList.kind)
			{
				case production_kind.g_ExtensionAdditionList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExtensionAddition = (p_ExtensionAdditionList.m_ExtensionAddition != null) ? new ExtensionAddition (p_ExtensionAdditionList.m_ExtensionAddition) : null) != null) m_ExtensionAddition.parent = this;
					break;
				case production_kind.g_ExtensionAdditionList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ExtensionAdditionList = (p_ExtensionAdditionList.m_ExtensionAdditionList != null) ? new ExtensionAdditionList (p_ExtensionAdditionList.m_ExtensionAdditionList) : null) != null) m_ExtensionAdditionList.parent = this;
					if ((children [1] = m_comma = (p_ExtensionAdditionList.m_comma != null) ? new SyntaxTreeToken (p_ExtensionAdditionList.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_ExtensionAddition = (p_ExtensionAdditionList.m_ExtensionAddition != null) ? new ExtensionAddition (p_ExtensionAdditionList.m_ExtensionAddition) : null) != null) m_ExtensionAddition.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExtensionAdditionList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExtensionAdditionList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_ExtensionAddition?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExtensionAdditionList

		// Content changing function(s) associated with production(s) of syntax rule ExtensionAdditionList

		//
		// Content changing function associated with following production(s)
		// ExtensionAdditionList -> ExtensionAddition

		//

		public void change(ExtensionAddition p_ExtensionAddition)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAdditionList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExtensionAddition = p_ExtensionAddition;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ExtensionAdditionList -> ExtensionAdditionList "," ExtensionAddition

		//

		public void change(ExtensionAdditionList p_ExtensionAdditionList, SyntaxTreeToken p_token, ExtensionAddition p_ExtensionAddition)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAdditionList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ExtensionAdditionList = p_ExtensionAdditionList;
			children [1] = m_comma = p_token;
			children [2] = m_ExtensionAddition = p_ExtensionAddition;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExtensionAdditionList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_ExtensionAddition != null) && node.m_ExtensionAddition.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExtensionAdditionList

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditionList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ExtensionAdditionList_1:
						// emit syntax tree node associated with production
						// ExtensionAdditionList: ExtensionAddition

						s += " " + node.m_ExtensionAddition.Emit (depth - 1);
						break;
					case production_kind.g_ExtensionAdditionList_2:
						// emit syntax tree node associated with production
						// ExtensionAdditionList: ExtensionAdditionList "," ExtensionAddition

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_ExtensionAddition.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditionList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "ExtensionAdditionList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_ExtensionAdditionList_1:
						// emit syntax tree node associated with production
						// ExtensionAdditionList: ExtensionAddition

						str += node.m_ExtensionAddition.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_ExtensionAdditionList_2:
						// emit syntax tree node associated with production
						// ExtensionAdditionList: ExtensionAdditionList "," ExtensionAddition

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_ExtensionAddition.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExtensionAdditionList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					ExtensionAdditionList.production_kind kind = (ExtensionAdditionList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case ExtensionAdditionList.production_kind.g_ExtensionAdditionList_1:
							// traverse syntax tree node associated with production
							// ExtensionAdditionList: ExtensionAddition

							node.m_ExtensionAddition.Visit (visitor, appData);
							break;
						case ExtensionAdditionList.production_kind.g_ExtensionAdditionList_2:
							// traverse syntax tree node associated with production
							// ExtensionAdditionList: ExtensionAdditionList "," ExtensionAddition

							node.m_comma.Visit (visitor, appData);
							node.m_ExtensionAddition.Visit (visitor, appData);
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
			for (ExtensionAdditionList node = this; node != null; node = node.m_ExtensionAdditionList)
			{
				node.parent = parent;
				node.m_ExtensionAddition?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule ExtensionAdditionList
		//

		public void _init ()
		{
			m_ExtensionAddition = null;
			m_ExtensionAdditionList = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (ExtensionAdditionList p_ExtensionAdditionList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<ExtensionAdditionList> stack = new Stack<ExtensionAdditionList> ();
			ExtensionAdditionList p_ExtensionAdditionList;
			for (p_ExtensionAdditionList = this; p_ExtensionAdditionList != null; p_ExtensionAdditionList = p_ExtensionAdditionList.m_ExtensionAdditionList)
				stack.Push (p_ExtensionAdditionList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExtensionAdditionList

		// counter of all nodes associated with syntax rule ExtensionAdditionList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExtensionAdditionList
		[DataMember (Name = "m_ExtensionAddition")] public ExtensionAddition m_ExtensionAddition { get; private set; }
		[DataMember (Name = "m_ExtensionAdditionList")] public ExtensionAdditionList m_ExtensionAdditionList { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExtensionAdditionList

		// delegate function (callback) prototype associated with syntax rule ExtensionAdditionList
		public delegate bool ExtensionAdditionList_Callback (SyntaxTreeCallbackReason reason, ExtensionAdditionList.production_kind kind, ExtensionAdditionList p_ExtensionAdditionList);

		// event associated with syntax rule ExtensionAdditionList
		public event ExtensionAdditionList_Callback ExtensionAdditionList_Event;

		// event trigger associated with syntax rule ExtensionAdditionList
		public bool Raise_ExtensionAdditionList_Event (SyntaxTreeCallbackReason reason, ExtensionAdditionList.production_kind kind, ExtensionAdditionList p_ExtensionAdditionList)
		{
			bool? status = ExtensionAdditionList_Event?.Invoke (reason, kind, p_ExtensionAdditionList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExtensionAdditionList
		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionList
		//

		public void Traverse (ExtensionAdditionList p_ExtensionAdditionList)
		{
			if (p_ExtensionAdditionList.isLocked())
				return;
			if (Raise_ExtensionAdditionList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (ExtensionAdditionList.production_kind) p_ExtensionAdditionList.kind, p_ExtensionAdditionList))
				p_ExtensionAdditionList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					ExtensionAdditionList.production_kind kind = (ExtensionAdditionList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_ExtensionAdditionList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case ExtensionAdditionList.production_kind.g_ExtensionAdditionList_1:
								// traverse syntax tree node associated with production
								// ExtensionAdditionList: ExtensionAddition

								if (Raise_ExtensionAdditionList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_ExtensionAddition);
								node.turn_inc ();
								Raise_ExtensionAdditionList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case ExtensionAdditionList.production_kind.g_ExtensionAdditionList_2:
								// traverse syntax tree node associated with production
								// ExtensionAdditionList: ExtensionAdditionList "," ExtensionAddition

								if (Raise_ExtensionAdditionList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_ExtensionAdditionList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_ExtensionAddition);
								node.turn_inc ();
								Raise_ExtensionAdditionList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_ExtensionAdditionList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_ExtensionAdditionList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (ExtensionAdditionList.production_kind) p_ExtensionAdditionList.kind, p_ExtensionAdditionList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionList
		//

		public void TraverseCommon (ExtensionAdditionList p_ExtensionAdditionList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_ExtensionAdditionList.kind, p_ExtensionAdditionList))
				p_ExtensionAdditionList.Iterate (null, (node, appData) =>
				{
					ExtensionAdditionList.production_kind kind = (ExtensionAdditionList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case ExtensionAdditionList.production_kind.g_ExtensionAdditionList_1:
							// traverse syntax tree node associated with production
							// ExtensionAdditionList: ExtensionAddition

							TraverseCommon (node.m_ExtensionAddition);
							break;
						case ExtensionAdditionList.production_kind.g_ExtensionAdditionList_2:
							// traverse syntax tree node associated with production
							// ExtensionAdditionList: ExtensionAdditionList "," ExtensionAddition

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_ExtensionAddition);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_ExtensionAdditionList.kind, p_ExtensionAdditionList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExtensionAdditionList

		//
		// create syntax tree node associated with production
		// ExtensionAdditionList: ExtensionAddition

		//

		public ExtensionAdditionList ExtensionAdditionList_1 (ExtensionAddition p_ExtensionAddition)
		{
			ExtensionAdditionList p_ExtensionAdditionList_ref = new ExtensionAdditionList(p_ExtensionAddition);
			p_ExtensionAddition.parent = p_ExtensionAdditionList_ref;
			Raise_ExtensionAdditionList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAdditionList.production_kind.g_ExtensionAdditionList_1, p_ExtensionAdditionList_ref);
			return p_ExtensionAdditionList_ref;
		}

		//
		// create syntax tree node associated with production
		// ExtensionAdditionList: ExtensionAdditionList "," ExtensionAddition

		//

		public ExtensionAdditionList ExtensionAdditionList_2 (ExtensionAdditionList p_ExtensionAdditionList, SyntaxTreeToken p_token, ExtensionAddition p_ExtensionAddition)
		{
			ExtensionAdditionList p_ExtensionAdditionList_ref = new ExtensionAdditionList(p_ExtensionAdditionList, p_token, p_ExtensionAddition);
			p_ExtensionAdditionList.parent = p_ExtensionAdditionList_ref;
			p_token.parent = p_ExtensionAdditionList_ref;
			p_ExtensionAddition.parent = p_ExtensionAdditionList_ref;
			Raise_ExtensionAdditionList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAdditionList.production_kind.g_ExtensionAdditionList_2, p_ExtensionAdditionList_ref);
			return p_ExtensionAdditionList_ref;
		}
		#endregion
	};
}
