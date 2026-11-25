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
	// class associated with syntax rule OT-IndexTypes
	//

	[DataContract]
	public class	OT_IndexTypes : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OT-IndexTypes
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OT-IndexTypes
		{
			g_OT_IndexTypes_1 = 1,	// OT-IndexType

			g_OT_IndexTypes_2 = 2,	// OT-IndexTypes "," OT-IndexType Left

		};
		#endregion
		#region production markers associated with the syntax rule OT-IndexTypes

		// markers associated with production: OT-IndexTypes -> OT-IndexType

		public enum production_marker_1 : ushort
		{
			m_OT_IndexType,
			final
		};

		// markers associated with production: OT-IndexTypes -> OT-IndexTypes "," OT-IndexType Left

		public enum production_marker_2 : ushort
		{
			m_OT_IndexTypes,
			m_OT_IndexType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OT-IndexTypes

		// Constructor declaration(s) associated with production(s) of syntax rule OT-IndexTypes

		//
		// Constructor associated with the following production(s)
		// OT-IndexTypes -> OT-IndexType

		//

		public OT_IndexTypes (OT_IndexType p_OT_IndexType) : base ((uint) ProductionID._OT_IndexTypes_ID, (uint) production_kind.g_OT_IndexTypes_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OT_IndexType = p_OT_IndexType;
		}

		//
		// Constructor associated with the following production(s)
		// OT-IndexTypes -> OT-IndexTypes "," OT-IndexType Left

		//

		public OT_IndexTypes (OT_IndexTypes p_OT_IndexTypes, SyntaxTreeToken p_token, OT_IndexType p_OT_IndexType) : base ((uint) ProductionID._OT_IndexTypes_ID, (uint) production_kind.g_OT_IndexTypes_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_OT_IndexTypes = p_OT_IndexTypes;
			children[1] = m_comma = p_token;
			children[2] = m_OT_IndexType = p_OT_IndexType;
		}

		public OT_IndexTypes () { }

		// Copy constructor

		public OT_IndexTypes (OT_IndexTypes p_OT_IndexTypes) : base (p_OT_IndexTypes.id, p_OT_IndexTypes.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OT_IndexTypes.appInfo;
			switch ((production_kind) p_OT_IndexTypes.kind)
			{
				case production_kind.g_OT_IndexTypes_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OT_IndexType = (p_OT_IndexTypes.m_OT_IndexType != null) ? new OT_IndexType (p_OT_IndexTypes.m_OT_IndexType) : null) != null) m_OT_IndexType.parent = this;
					break;
				case production_kind.g_OT_IndexTypes_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_OT_IndexTypes = (p_OT_IndexTypes.m_OT_IndexTypes != null) ? new OT_IndexTypes (p_OT_IndexTypes.m_OT_IndexTypes) : null) != null) m_OT_IndexTypes.parent = this;
					if ((children [1] = m_comma = (p_OT_IndexTypes.m_comma != null) ? new SyntaxTreeToken (p_OT_IndexTypes.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_OT_IndexType = (p_OT_IndexTypes.m_OT_IndexType != null) ? new OT_IndexType (p_OT_IndexTypes.m_OT_IndexType) : null) != null) m_OT_IndexType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OT_IndexTypes" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OT_IndexTypes (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_OT_IndexType?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OT-IndexTypes

		// Content changing function(s) associated with production(s) of syntax rule OT-IndexTypes

		//
		// Content changing function associated with following production(s)
		// OT-IndexTypes -> OT-IndexType

		//

		public void change(OT_IndexType p_OT_IndexType)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_IndexTypes_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OT_IndexType = p_OT_IndexType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OT-IndexTypes -> OT-IndexTypes "," OT-IndexType Left

		//

		public void change(OT_IndexTypes p_OT_IndexTypes, SyntaxTreeToken p_token, OT_IndexType p_OT_IndexType)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_IndexTypes_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_OT_IndexTypes = p_OT_IndexTypes;
			children [1] = m_comma = p_token;
			children [2] = m_OT_IndexType = p_OT_IndexType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OT-IndexTypes
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_OT_IndexType != null) && node.m_OT_IndexType.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OT-IndexTypes

		//
		// emit production tree node associated with any production of syntax rule OT-IndexTypes
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_OT_IndexTypes_1:
						// emit syntax tree node associated with production
						// OT-IndexTypes: OT-IndexType

						s += " " + node.m_OT_IndexType.Emit (depth - 1);
						break;
					case production_kind.g_OT_IndexTypes_2:
						// emit syntax tree node associated with production
						// OT-IndexTypes: OT-IndexTypes "," OT-IndexType Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_OT_IndexType.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OT-IndexTypes
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "OT_IndexTypes (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_OT_IndexTypes_1:
						// emit syntax tree node associated with production
						// OT-IndexTypes: OT-IndexType

						str += node.m_OT_IndexType.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_OT_IndexTypes_2:
						// emit syntax tree node associated with production
						// OT-IndexTypes: OT-IndexTypes "," OT-IndexType Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_OT_IndexType.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OT-IndexTypes

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OT-IndexTypes with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					OT_IndexTypes.production_kind kind = (OT_IndexTypes.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case OT_IndexTypes.production_kind.g_OT_IndexTypes_1:
							// traverse syntax tree node associated with production
							// OT-IndexTypes: OT-IndexType

							node.m_OT_IndexType.Visit (visitor, appData);
							break;
						case OT_IndexTypes.production_kind.g_OT_IndexTypes_2:
							// traverse syntax tree node associated with production
							// OT-IndexTypes: OT-IndexTypes "," OT-IndexType Left

							node.m_comma.Visit (visitor, appData);
							node.m_OT_IndexType.Visit (visitor, appData);
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
			for (OT_IndexTypes node = this; node != null; node = node.m_OT_IndexTypes)
			{
				node.parent = parent;
				node.m_OT_IndexType?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule OT-IndexTypes
		//

		public void _init ()
		{
			m_OT_IndexType = null;
			m_OT_IndexTypes = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (OT_IndexTypes p_OT_IndexTypes, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<OT_IndexTypes> stack = new Stack<OT_IndexTypes> ();
			OT_IndexTypes p_OT_IndexTypes;
			for (p_OT_IndexTypes = this; p_OT_IndexTypes != null; p_OT_IndexTypes = p_OT_IndexTypes.m_OT_IndexTypes)
				stack.Push (p_OT_IndexTypes);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OT-IndexTypes

		// counter of all nodes associated with syntax rule OT-IndexTypes
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OT-IndexTypes
		[DataMember (Name = "m_OT_IndexType")] public OT_IndexType m_OT_IndexType { get; private set; }
		[DataMember (Name = "m_OT_IndexTypes")] public OT_IndexTypes m_OT_IndexTypes { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OT-IndexTypes

		// delegate function (callback) prototype associated with syntax rule OT-IndexTypes
		public delegate bool OT_IndexTypes_Callback (SyntaxTreeCallbackReason reason, OT_IndexTypes.production_kind kind, OT_IndexTypes p_OT_IndexTypes);

		// event associated with syntax rule OT-IndexTypes
		public event OT_IndexTypes_Callback OT_IndexTypes_Event;

		// event trigger associated with syntax rule OT-IndexTypes
		public bool Raise_OT_IndexTypes_Event (SyntaxTreeCallbackReason reason, OT_IndexTypes.production_kind kind, OT_IndexTypes p_OT_IndexTypes)
		{
			bool? status = OT_IndexTypes_Event?.Invoke (reason, kind, p_OT_IndexTypes);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OT-IndexTypes
		//
		// traverse syntax tree node associated with any production of syntax rule OT-IndexTypes
		//

		public void Traverse (OT_IndexTypes p_OT_IndexTypes)
		{
			if (p_OT_IndexTypes.isLocked())
				return;
			if (Raise_OT_IndexTypes_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (OT_IndexTypes.production_kind) p_OT_IndexTypes.kind, p_OT_IndexTypes))
				p_OT_IndexTypes.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					OT_IndexTypes.production_kind kind = (OT_IndexTypes.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_OT_IndexTypes_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case OT_IndexTypes.production_kind.g_OT_IndexTypes_1:
								// traverse syntax tree node associated with production
								// OT-IndexTypes: OT-IndexType

								if (Raise_OT_IndexTypes_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_OT_IndexType);
								node.turn_inc ();
								Raise_OT_IndexTypes_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case OT_IndexTypes.production_kind.g_OT_IndexTypes_2:
								// traverse syntax tree node associated with production
								// OT-IndexTypes: OT-IndexTypes "," OT-IndexType Left

								if (Raise_OT_IndexTypes_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_OT_IndexTypes_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_OT_IndexType);
								node.turn_inc ();
								Raise_OT_IndexTypes_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_OT_IndexTypes_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_OT_IndexTypes_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (OT_IndexTypes.production_kind) p_OT_IndexTypes.kind, p_OT_IndexTypes);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OT-IndexTypes
		//

		public void TraverseCommon (OT_IndexTypes p_OT_IndexTypes)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_OT_IndexTypes.kind, p_OT_IndexTypes))
				p_OT_IndexTypes.Iterate (null, (node, appData) =>
				{
					OT_IndexTypes.production_kind kind = (OT_IndexTypes.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case OT_IndexTypes.production_kind.g_OT_IndexTypes_1:
							// traverse syntax tree node associated with production
							// OT-IndexTypes: OT-IndexType

							TraverseCommon (node.m_OT_IndexType);
							break;
						case OT_IndexTypes.production_kind.g_OT_IndexTypes_2:
							// traverse syntax tree node associated with production
							// OT-IndexTypes: OT-IndexTypes "," OT-IndexType Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_OT_IndexType);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_OT_IndexTypes.kind, p_OT_IndexTypes);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OT-IndexTypes

		//
		// create syntax tree node associated with production
		// OT-IndexTypes: OT-IndexType

		//

		public OT_IndexTypes OT_IndexTypes_1 (OT_IndexType p_OT_IndexType)
		{
			OT_IndexTypes p_OT_IndexTypes_ref = new OT_IndexTypes(p_OT_IndexType);
			p_OT_IndexType.parent = p_OT_IndexTypes_ref;
			Raise_OT_IndexTypes_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_IndexTypes.production_kind.g_OT_IndexTypes_1, p_OT_IndexTypes_ref);
			return p_OT_IndexTypes_ref;
		}

		//
		// create syntax tree node associated with production
		// OT-IndexTypes: OT-IndexTypes "," OT-IndexType Left

		//

		public OT_IndexTypes OT_IndexTypes_2 (OT_IndexTypes p_OT_IndexTypes, SyntaxTreeToken p_token, OT_IndexType p_OT_IndexType)
		{
			OT_IndexTypes p_OT_IndexTypes_ref = new OT_IndexTypes(p_OT_IndexTypes, p_token, p_OT_IndexType);
			p_OT_IndexTypes.parent = p_OT_IndexTypes_ref;
			p_token.parent = p_OT_IndexTypes_ref;
			p_OT_IndexType.parent = p_OT_IndexTypes_ref;
			Raise_OT_IndexTypes_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_IndexTypes.production_kind.g_OT_IndexTypes_2, p_OT_IndexTypes_ref);
			return p_OT_IndexTypes_ref;
		}
		#endregion
	};
}
