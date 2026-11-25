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
	// class associated with syntax rule TT-VarTypes
	//

	[DataContract]
	public class	TT_VarTypes : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TT-VarTypes
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TT-VarTypes
		{
			g_TT_VarTypes_1 = 1,	// TT-VarType

			g_TT_VarTypes_2 = 2,	// TT-VarTypes "," TT-VarType Left

		};
		#endregion
		#region production markers associated with the syntax rule TT-VarTypes

		// markers associated with production: TT-VarTypes -> TT-VarType

		public enum production_marker_1 : ushort
		{
			m_TT_VarType,
			final
		};

		// markers associated with production: TT-VarTypes -> TT-VarTypes "," TT-VarType Left

		public enum production_marker_2 : ushort
		{
			m_TT_VarTypes,
			m_TT_VarType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TT-VarTypes

		// Constructor declaration(s) associated with production(s) of syntax rule TT-VarTypes

		//
		// Constructor associated with the following production(s)
		// TT-VarTypes -> TT-VarType

		//

		public TT_VarTypes (TT_VarType p_TT_VarType) : base ((uint) ProductionID._TT_VarTypes_ID, (uint) production_kind.g_TT_VarTypes_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TT_VarType = p_TT_VarType;
		}

		//
		// Constructor associated with the following production(s)
		// TT-VarTypes -> TT-VarTypes "," TT-VarType Left

		//

		public TT_VarTypes (TT_VarTypes p_TT_VarTypes, SyntaxTreeToken p_token, TT_VarType p_TT_VarType) : base ((uint) ProductionID._TT_VarTypes_ID, (uint) production_kind.g_TT_VarTypes_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_TT_VarTypes = p_TT_VarTypes;
			children[1] = m_comma = p_token;
			children[2] = m_TT_VarType = p_TT_VarType;
		}

		public TT_VarTypes () { }

		// Copy constructor

		public TT_VarTypes (TT_VarTypes p_TT_VarTypes) : base (p_TT_VarTypes.id, p_TT_VarTypes.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TT_VarTypes.appInfo;
			switch ((production_kind) p_TT_VarTypes.kind)
			{
				case production_kind.g_TT_VarTypes_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TT_VarType = (p_TT_VarTypes.m_TT_VarType != null) ? new TT_VarType (p_TT_VarTypes.m_TT_VarType) : null) != null) m_TT_VarType.parent = this;
					break;
				case production_kind.g_TT_VarTypes_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_TT_VarTypes = (p_TT_VarTypes.m_TT_VarTypes != null) ? new TT_VarTypes (p_TT_VarTypes.m_TT_VarTypes) : null) != null) m_TT_VarTypes.parent = this;
					if ((children [1] = m_comma = (p_TT_VarTypes.m_comma != null) ? new SyntaxTreeToken (p_TT_VarTypes.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_TT_VarType = (p_TT_VarTypes.m_TT_VarType != null) ? new TT_VarType (p_TT_VarTypes.m_TT_VarType) : null) != null) m_TT_VarType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TT_VarTypes" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TT_VarTypes (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_TT_VarType?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TT-VarTypes

		// Content changing function(s) associated with production(s) of syntax rule TT-VarTypes

		//
		// Content changing function associated with following production(s)
		// TT-VarTypes -> TT-VarType

		//

		public void change(TT_VarType p_TT_VarType)
		{
			_init ();
			this.kind = (uint) production_kind.g_TT_VarTypes_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TT_VarType = p_TT_VarType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TT-VarTypes -> TT-VarTypes "," TT-VarType Left

		//

		public void change(TT_VarTypes p_TT_VarTypes, SyntaxTreeToken p_token, TT_VarType p_TT_VarType)
		{
			_init ();
			this.kind = (uint) production_kind.g_TT_VarTypes_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_TT_VarTypes = p_TT_VarTypes;
			children [1] = m_comma = p_token;
			children [2] = m_TT_VarType = p_TT_VarType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TT-VarTypes
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_TT_VarType != null) && node.m_TT_VarType.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TT-VarTypes

		//
		// emit production tree node associated with any production of syntax rule TT-VarTypes
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_TT_VarTypes_1:
						// emit syntax tree node associated with production
						// TT-VarTypes: TT-VarType

						s += " " + node.m_TT_VarType.Emit (depth - 1);
						break;
					case production_kind.g_TT_VarTypes_2:
						// emit syntax tree node associated with production
						// TT-VarTypes: TT-VarTypes "," TT-VarType Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_TT_VarType.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TT-VarTypes
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "TT_VarTypes (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_TT_VarTypes_1:
						// emit syntax tree node associated with production
						// TT-VarTypes: TT-VarType

						str += node.m_TT_VarType.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_TT_VarTypes_2:
						// emit syntax tree node associated with production
						// TT-VarTypes: TT-VarTypes "," TT-VarType Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_TT_VarType.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TT-VarTypes

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TT-VarTypes with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					TT_VarTypes.production_kind kind = (TT_VarTypes.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case TT_VarTypes.production_kind.g_TT_VarTypes_1:
							// traverse syntax tree node associated with production
							// TT-VarTypes: TT-VarType

							node.m_TT_VarType.Visit (visitor, appData);
							break;
						case TT_VarTypes.production_kind.g_TT_VarTypes_2:
							// traverse syntax tree node associated with production
							// TT-VarTypes: TT-VarTypes "," TT-VarType Left

							node.m_comma.Visit (visitor, appData);
							node.m_TT_VarType.Visit (visitor, appData);
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
			for (TT_VarTypes node = this; node != null; node = node.m_TT_VarTypes)
			{
				node.parent = parent;
				node.m_TT_VarType?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule TT-VarTypes
		//

		public void _init ()
		{
			m_TT_VarType = null;
			m_TT_VarTypes = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (TT_VarTypes p_TT_VarTypes, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<TT_VarTypes> stack = new Stack<TT_VarTypes> ();
			TT_VarTypes p_TT_VarTypes;
			for (p_TT_VarTypes = this; p_TT_VarTypes != null; p_TT_VarTypes = p_TT_VarTypes.m_TT_VarTypes)
				stack.Push (p_TT_VarTypes);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TT-VarTypes

		// counter of all nodes associated with syntax rule TT-VarTypes
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TT-VarTypes
		[DataMember (Name = "m_TT_VarType")] public TT_VarType m_TT_VarType { get; private set; }
		[DataMember (Name = "m_TT_VarTypes")] public TT_VarTypes m_TT_VarTypes { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TT-VarTypes

		// delegate function (callback) prototype associated with syntax rule TT-VarTypes
		public delegate bool TT_VarTypes_Callback (SyntaxTreeCallbackReason reason, TT_VarTypes.production_kind kind, TT_VarTypes p_TT_VarTypes);

		// event associated with syntax rule TT-VarTypes
		public event TT_VarTypes_Callback TT_VarTypes_Event;

		// event trigger associated with syntax rule TT-VarTypes
		public bool Raise_TT_VarTypes_Event (SyntaxTreeCallbackReason reason, TT_VarTypes.production_kind kind, TT_VarTypes p_TT_VarTypes)
		{
			bool? status = TT_VarTypes_Event?.Invoke (reason, kind, p_TT_VarTypes);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TT-VarTypes
		//
		// traverse syntax tree node associated with any production of syntax rule TT-VarTypes
		//

		public void Traverse (TT_VarTypes p_TT_VarTypes)
		{
			if (p_TT_VarTypes.isLocked())
				return;
			if (Raise_TT_VarTypes_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (TT_VarTypes.production_kind) p_TT_VarTypes.kind, p_TT_VarTypes))
				p_TT_VarTypes.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					TT_VarTypes.production_kind kind = (TT_VarTypes.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_TT_VarTypes_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case TT_VarTypes.production_kind.g_TT_VarTypes_1:
								// traverse syntax tree node associated with production
								// TT-VarTypes: TT-VarType

								if (Raise_TT_VarTypes_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_TT_VarType);
								node.turn_inc ();
								Raise_TT_VarTypes_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case TT_VarTypes.production_kind.g_TT_VarTypes_2:
								// traverse syntax tree node associated with production
								// TT-VarTypes: TT-VarTypes "," TT-VarType Left

								if (Raise_TT_VarTypes_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_TT_VarTypes_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_TT_VarType);
								node.turn_inc ();
								Raise_TT_VarTypes_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_TT_VarTypes_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_TT_VarTypes_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (TT_VarTypes.production_kind) p_TT_VarTypes.kind, p_TT_VarTypes);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TT-VarTypes
		//

		public void TraverseCommon (TT_VarTypes p_TT_VarTypes)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_TT_VarTypes.kind, p_TT_VarTypes))
				p_TT_VarTypes.Iterate (null, (node, appData) =>
				{
					TT_VarTypes.production_kind kind = (TT_VarTypes.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case TT_VarTypes.production_kind.g_TT_VarTypes_1:
							// traverse syntax tree node associated with production
							// TT-VarTypes: TT-VarType

							TraverseCommon (node.m_TT_VarType);
							break;
						case TT_VarTypes.production_kind.g_TT_VarTypes_2:
							// traverse syntax tree node associated with production
							// TT-VarTypes: TT-VarTypes "," TT-VarType Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_TT_VarType);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_TT_VarTypes.kind, p_TT_VarTypes);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TT-VarTypes

		//
		// create syntax tree node associated with production
		// TT-VarTypes: TT-VarType

		//

		public TT_VarTypes TT_VarTypes_1 (TT_VarType p_TT_VarType)
		{
			TT_VarTypes p_TT_VarTypes_ref = new TT_VarTypes(p_TT_VarType);
			p_TT_VarType.parent = p_TT_VarTypes_ref;
			Raise_TT_VarTypes_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TT_VarTypes.production_kind.g_TT_VarTypes_1, p_TT_VarTypes_ref);
			return p_TT_VarTypes_ref;
		}

		//
		// create syntax tree node associated with production
		// TT-VarTypes: TT-VarTypes "," TT-VarType Left

		//

		public TT_VarTypes TT_VarTypes_2 (TT_VarTypes p_TT_VarTypes, SyntaxTreeToken p_token, TT_VarType p_TT_VarType)
		{
			TT_VarTypes p_TT_VarTypes_ref = new TT_VarTypes(p_TT_VarTypes, p_token, p_TT_VarType);
			p_TT_VarTypes.parent = p_TT_VarTypes_ref;
			p_token.parent = p_TT_VarTypes_ref;
			p_TT_VarType.parent = p_TT_VarTypes_ref;
			Raise_TT_VarTypes_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TT_VarTypes.production_kind.g_TT_VarTypes_2, p_TT_VarTypes_ref);
			return p_TT_VarTypes_ref;
		}
		#endregion
	};
}
