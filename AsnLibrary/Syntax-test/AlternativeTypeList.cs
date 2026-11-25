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
	// class associated with syntax rule AlternativeTypeList
	//

	[DataContract]
	public class	AlternativeTypeList : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AlternativeTypeList
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AlternativeTypeList
		{
			g_AlternativeTypeList_1 = 1,	// AltTypeOrNamedType

			g_AlternativeTypeList_2 = 2,	// AlternativeTypeList "," AltTypeOrNamedType Left

		};
		#endregion
		#region production markers associated with the syntax rule AlternativeTypeList

		// markers associated with production: AlternativeTypeList -> AltTypeOrNamedType

		public enum production_marker_1 : ushort
		{
			m_AltTypeOrNamedType,
			final
		};

		// markers associated with production: AlternativeTypeList -> AlternativeTypeList "," AltTypeOrNamedType Left

		public enum production_marker_2 : ushort
		{
			m_AlternativeTypeList,
			m_AltTypeOrNamedType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AlternativeTypeList

		// Constructor declaration(s) associated with production(s) of syntax rule AlternativeTypeList

		//
		// Constructor associated with the following production(s)
		// AlternativeTypeList -> AltTypeOrNamedType

		//

		public AlternativeTypeList (AltTypeOrNamedType p_AltTypeOrNamedType) : base ((uint) ProductionID._AlternativeTypeList_ID, (uint) production_kind.g_AlternativeTypeList_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AltTypeOrNamedType = p_AltTypeOrNamedType;
		}

		//
		// Constructor associated with the following production(s)
		// AlternativeTypeList -> AlternativeTypeList "," AltTypeOrNamedType Left

		//

		public AlternativeTypeList (AlternativeTypeList p_AlternativeTypeList, SyntaxTreeToken p_token, AltTypeOrNamedType p_AltTypeOrNamedType) : base ((uint) ProductionID._AlternativeTypeList_ID, (uint) production_kind.g_AlternativeTypeList_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_AlternativeTypeList = p_AlternativeTypeList;
			children[1] = m_comma = p_token;
			children[2] = m_AltTypeOrNamedType = p_AltTypeOrNamedType;
		}

		public AlternativeTypeList () { }

		// Copy constructor

		public AlternativeTypeList (AlternativeTypeList p_AlternativeTypeList) : base (p_AlternativeTypeList.id, p_AlternativeTypeList.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AlternativeTypeList.appInfo;
			switch ((production_kind) p_AlternativeTypeList.kind)
			{
				case production_kind.g_AlternativeTypeList_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AltTypeOrNamedType = (p_AlternativeTypeList.m_AltTypeOrNamedType != null) ? new AltTypeOrNamedType (p_AlternativeTypeList.m_AltTypeOrNamedType) : null) != null) m_AltTypeOrNamedType.parent = this;
					break;
				case production_kind.g_AlternativeTypeList_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_AlternativeTypeList = (p_AlternativeTypeList.m_AlternativeTypeList != null) ? new AlternativeTypeList (p_AlternativeTypeList.m_AlternativeTypeList) : null) != null) m_AlternativeTypeList.parent = this;
					if ((children [1] = m_comma = (p_AlternativeTypeList.m_comma != null) ? new SyntaxTreeToken (p_AlternativeTypeList.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_AltTypeOrNamedType = (p_AlternativeTypeList.m_AltTypeOrNamedType != null) ? new AltTypeOrNamedType (p_AlternativeTypeList.m_AltTypeOrNamedType) : null) != null) m_AltTypeOrNamedType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AlternativeTypeList" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AlternativeTypeList (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_AltTypeOrNamedType?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AlternativeTypeList

		// Content changing function(s) associated with production(s) of syntax rule AlternativeTypeList

		//
		// Content changing function associated with following production(s)
		// AlternativeTypeList -> AltTypeOrNamedType

		//

		public void change(AltTypeOrNamedType p_AltTypeOrNamedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_AlternativeTypeList_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AltTypeOrNamedType = p_AltTypeOrNamedType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AlternativeTypeList -> AlternativeTypeList "," AltTypeOrNamedType Left

		//

		public void change(AlternativeTypeList p_AlternativeTypeList, SyntaxTreeToken p_token, AltTypeOrNamedType p_AltTypeOrNamedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_AlternativeTypeList_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_AlternativeTypeList = p_AlternativeTypeList;
			children [1] = m_comma = p_token;
			children [2] = m_AltTypeOrNamedType = p_AltTypeOrNamedType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AlternativeTypeList
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_AltTypeOrNamedType != null) && node.m_AltTypeOrNamedType.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AlternativeTypeList

		//
		// emit production tree node associated with any production of syntax rule AlternativeTypeList
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AlternativeTypeList_1:
						// emit syntax tree node associated with production
						// AlternativeTypeList: AltTypeOrNamedType

						s += " " + node.m_AltTypeOrNamedType.Emit (depth - 1);
						break;
					case production_kind.g_AlternativeTypeList_2:
						// emit syntax tree node associated with production
						// AlternativeTypeList: AlternativeTypeList "," AltTypeOrNamedType Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_AltTypeOrNamedType.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AlternativeTypeList
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "AlternativeTypeList (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_AlternativeTypeList_1:
						// emit syntax tree node associated with production
						// AlternativeTypeList: AltTypeOrNamedType

						str += node.m_AltTypeOrNamedType.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_AlternativeTypeList_2:
						// emit syntax tree node associated with production
						// AlternativeTypeList: AlternativeTypeList "," AltTypeOrNamedType Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_AltTypeOrNamedType.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AlternativeTypeList

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AlternativeTypeList with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					AlternativeTypeList.production_kind kind = (AlternativeTypeList.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case AlternativeTypeList.production_kind.g_AlternativeTypeList_1:
							// traverse syntax tree node associated with production
							// AlternativeTypeList: AltTypeOrNamedType

							node.m_AltTypeOrNamedType.Visit (visitor, appData);
							break;
						case AlternativeTypeList.production_kind.g_AlternativeTypeList_2:
							// traverse syntax tree node associated with production
							// AlternativeTypeList: AlternativeTypeList "," AltTypeOrNamedType Left

							node.m_comma.Visit (visitor, appData);
							node.m_AltTypeOrNamedType.Visit (visitor, appData);
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
			for (AlternativeTypeList node = this; node != null; node = node.m_AlternativeTypeList)
			{
				node.parent = parent;
				node.m_AltTypeOrNamedType?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule AlternativeTypeList
		//

		public void _init ()
		{
			m_AltTypeOrNamedType = null;
			m_AlternativeTypeList = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (AlternativeTypeList p_AlternativeTypeList, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<AlternativeTypeList> stack = new Stack<AlternativeTypeList> ();
			AlternativeTypeList p_AlternativeTypeList;
			for (p_AlternativeTypeList = this; p_AlternativeTypeList != null; p_AlternativeTypeList = p_AlternativeTypeList.m_AlternativeTypeList)
				stack.Push (p_AlternativeTypeList);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AlternativeTypeList

		// counter of all nodes associated with syntax rule AlternativeTypeList
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AlternativeTypeList
		[DataMember (Name = "m_AltTypeOrNamedType")] public AltTypeOrNamedType m_AltTypeOrNamedType { get; private set; }
		[DataMember (Name = "m_AlternativeTypeList")] public AlternativeTypeList m_AlternativeTypeList { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AlternativeTypeList

		// delegate function (callback) prototype associated with syntax rule AlternativeTypeList
		public delegate bool AlternativeTypeList_Callback (SyntaxTreeCallbackReason reason, AlternativeTypeList.production_kind kind, AlternativeTypeList p_AlternativeTypeList);

		// event associated with syntax rule AlternativeTypeList
		public event AlternativeTypeList_Callback AlternativeTypeList_Event;

		// event trigger associated with syntax rule AlternativeTypeList
		public bool Raise_AlternativeTypeList_Event (SyntaxTreeCallbackReason reason, AlternativeTypeList.production_kind kind, AlternativeTypeList p_AlternativeTypeList)
		{
			bool? status = AlternativeTypeList_Event?.Invoke (reason, kind, p_AlternativeTypeList);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AlternativeTypeList
		//
		// traverse syntax tree node associated with any production of syntax rule AlternativeTypeList
		//

		public void Traverse (AlternativeTypeList p_AlternativeTypeList)
		{
			if (p_AlternativeTypeList.isLocked())
				return;
			if (Raise_AlternativeTypeList_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (AlternativeTypeList.production_kind) p_AlternativeTypeList.kind, p_AlternativeTypeList))
				p_AlternativeTypeList.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					AlternativeTypeList.production_kind kind = (AlternativeTypeList.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_AlternativeTypeList_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case AlternativeTypeList.production_kind.g_AlternativeTypeList_1:
								// traverse syntax tree node associated with production
								// AlternativeTypeList: AltTypeOrNamedType

								if (Raise_AlternativeTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AltTypeOrNamedType);
								node.turn_inc ();
								Raise_AlternativeTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case AlternativeTypeList.production_kind.g_AlternativeTypeList_2:
								// traverse syntax tree node associated with production
								// AlternativeTypeList: AlternativeTypeList "," AltTypeOrNamedType Left

								if (Raise_AlternativeTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_AlternativeTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_AltTypeOrNamedType);
								node.turn_inc ();
								Raise_AlternativeTypeList_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_AlternativeTypeList_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_AlternativeTypeList_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (AlternativeTypeList.production_kind) p_AlternativeTypeList.kind, p_AlternativeTypeList);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AlternativeTypeList
		//

		public void TraverseCommon (AlternativeTypeList p_AlternativeTypeList)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_AlternativeTypeList.kind, p_AlternativeTypeList))
				p_AlternativeTypeList.Iterate (null, (node, appData) =>
				{
					AlternativeTypeList.production_kind kind = (AlternativeTypeList.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case AlternativeTypeList.production_kind.g_AlternativeTypeList_1:
							// traverse syntax tree node associated with production
							// AlternativeTypeList: AltTypeOrNamedType

							TraverseCommon (node.m_AltTypeOrNamedType);
							break;
						case AlternativeTypeList.production_kind.g_AlternativeTypeList_2:
							// traverse syntax tree node associated with production
							// AlternativeTypeList: AlternativeTypeList "," AltTypeOrNamedType Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_AltTypeOrNamedType);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_AlternativeTypeList.kind, p_AlternativeTypeList);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AlternativeTypeList

		//
		// create syntax tree node associated with production
		// AlternativeTypeList: AltTypeOrNamedType

		//

		public AlternativeTypeList AlternativeTypeList_1 (AltTypeOrNamedType p_AltTypeOrNamedType)
		{
			AlternativeTypeList p_AlternativeTypeList_ref = new AlternativeTypeList(p_AltTypeOrNamedType);
			p_AltTypeOrNamedType.parent = p_AlternativeTypeList_ref;
			Raise_AlternativeTypeList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AlternativeTypeList.production_kind.g_AlternativeTypeList_1, p_AlternativeTypeList_ref);
			return p_AlternativeTypeList_ref;
		}

		//
		// create syntax tree node associated with production
		// AlternativeTypeList: AlternativeTypeList "," AltTypeOrNamedType Left

		//

		public AlternativeTypeList AlternativeTypeList_2 (AlternativeTypeList p_AlternativeTypeList, SyntaxTreeToken p_token, AltTypeOrNamedType p_AltTypeOrNamedType)
		{
			AlternativeTypeList p_AlternativeTypeList_ref = new AlternativeTypeList(p_AlternativeTypeList, p_token, p_AltTypeOrNamedType);
			p_AlternativeTypeList.parent = p_AlternativeTypeList_ref;
			p_token.parent = p_AlternativeTypeList_ref;
			p_AltTypeOrNamedType.parent = p_AlternativeTypeList_ref;
			Raise_AlternativeTypeList_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AlternativeTypeList.production_kind.g_AlternativeTypeList_2, p_AlternativeTypeList_ref);
			return p_AlternativeTypeList_ref;
		}
		#endregion
	};
}
