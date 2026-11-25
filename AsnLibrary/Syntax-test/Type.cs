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
	// class associated with syntax rule Type
	//

	[DataContract]
	public class	Type : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Type
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Type
		{
			g_Type_1 = 1,	// BuiltinType

			g_Type_2 = 2,	// ReferencedType

			g_Type_3 = 3,	// ConstrainedType

		};
		#endregion
		#region production markers associated with the syntax rule Type

		// markers associated with production: Type -> BuiltinType

		public enum production_marker_1 : ushort
		{
			m_BuiltinType,
			final
		};

		// markers associated with production: Type -> ReferencedType

		public enum production_marker_2 : ushort
		{
			m_ReferencedType,
			final
		};

		// markers associated with production: Type -> ConstrainedType

		public enum production_marker_3 : ushort
		{
			m_ConstrainedType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Type

		// Constructor declaration(s) associated with production(s) of syntax rule Type

		//
		// Constructor associated with the following production(s)
		// Type -> BuiltinType

		//

		public Type (BuiltinType p_BuiltinType) : base ((uint) ProductionID._Type_ID, (uint) production_kind.g_Type_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_BuiltinType = p_BuiltinType;
		}

		//
		// Constructor associated with the following production(s)
		// Type -> ReferencedType

		//

		public Type (ReferencedType p_ReferencedType) : base ((uint) ProductionID._Type_ID, (uint) production_kind.g_Type_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ReferencedType = p_ReferencedType;
		}

		//
		// Constructor associated with the following production(s)
		// Type -> ConstrainedType

		//

		public Type (ConstrainedType p_ConstrainedType) : base ((uint) ProductionID._Type_ID, (uint) production_kind.g_Type_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ConstrainedType = p_ConstrainedType;
		}

		public Type () { }

		// Copy constructor

		public Type (Type p_Type) : base (p_Type.id, p_Type.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Type.appInfo;
			switch ((production_kind) p_Type.kind)
			{
				case production_kind.g_Type_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BuiltinType = (p_Type.m_BuiltinType != null) ? new BuiltinType (p_Type.m_BuiltinType) : null) != null) m_BuiltinType.parent = this;
					break;
				case production_kind.g_Type_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ReferencedType = (p_Type.m_ReferencedType != null) ? new ReferencedType (p_Type.m_ReferencedType) : null) != null) m_ReferencedType.parent = this;
					break;
				case production_kind.g_Type_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ConstrainedType = (p_Type.m_ConstrainedType != null) ? new ConstrainedType (p_Type.m_ConstrainedType) : null) != null) m_ConstrainedType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Type" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Type (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_BuiltinType?.Dispose ();
			m_ReferencedType?.Dispose ();
			m_ConstrainedType?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Type

		// Content changing function(s) associated with production(s) of syntax rule Type

		//
		// Content changing function associated with following production(s)
		// Type -> BuiltinType

		//

		public void change(BuiltinType p_BuiltinType)
		{
			_init ();
			this.kind = (uint) production_kind.g_Type_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_BuiltinType = p_BuiltinType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Type -> ReferencedType

		//

		public void change(ReferencedType p_ReferencedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_Type_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ReferencedType = p_ReferencedType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Type -> ConstrainedType

		//

		public void change(ConstrainedType p_ConstrainedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_Type_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ConstrainedType = p_ConstrainedType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Type
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_BuiltinType != null) && m_BuiltinType.checkInclusion (element) ||
				(m_ReferencedType != null) && m_ReferencedType.checkInclusion (element) ||
				(m_ConstrainedType != null) && m_ConstrainedType.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Type

		//
		// emit production tree node associated with any production of syntax rule Type
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Type_1:
					// emit syntax tree node associated with production
					// Type: BuiltinType

					s += m_BuiltinType.Emit (depth - 1);
				break;
				case production_kind.g_Type_2:
					// emit syntax tree node associated with production
					// Type: ReferencedType

					s += m_ReferencedType.Emit (depth - 1);
				break;
				case production_kind.g_Type_3:
					// emit syntax tree node associated with production
					// Type: ConstrainedType

					s += m_ConstrainedType.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Type
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Type (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Type_1:
					// emit syntax tree node associated with production
					// Type: BuiltinType

					s += m_BuiltinType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Type_2:
					// emit syntax tree node associated with production
					// Type: ReferencedType

					s += m_ReferencedType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Type_3:
					// emit syntax tree node associated with production
					// Type: ConstrainedType

					s += m_ConstrainedType.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Type

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Type with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Type.production_kind kind = (Type.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Type.production_kind.g_Type_1:
					// traverse syntax tree node associated with production
					// Type: BuiltinType

						m_BuiltinType.Visit (visitor, appData);
				break;
				case Type.production_kind.g_Type_2:
					// traverse syntax tree node associated with production
					// Type: ReferencedType

						m_ReferencedType.Visit (visitor, appData);
				break;
				case Type.production_kind.g_Type_3:
					// traverse syntax tree node associated with production
					// Type: ConstrainedType

						m_ConstrainedType.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_BuiltinType?.reparent (this);
			m_ReferencedType?.reparent (this);
			m_ConstrainedType?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Type
		//

		public void _init ()
		{
			m_BuiltinType = null;
			m_ReferencedType = null;
			m_ConstrainedType = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Type

		// counter of all nodes associated with syntax rule Type
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Type
		[DataMember (Name = "m_BuiltinType")] public BuiltinType m_BuiltinType { get; private set; }
		[DataMember (Name = "m_ReferencedType")] public ReferencedType m_ReferencedType { get; private set; }
		[DataMember (Name = "m_ConstrainedType")] public ConstrainedType m_ConstrainedType { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Type

		// delegate function (callback) prototype associated with syntax rule Type
		public delegate bool Type_Callback (SyntaxTreeCallbackReason reason, Type.production_kind kind, Type p_Type);

		// event associated with syntax rule Type
		public event Type_Callback Type_Event;

		// event trigger associated with syntax rule Type
		public bool Raise_Type_Event (SyntaxTreeCallbackReason reason, Type.production_kind kind, Type p_Type)
		{
			bool? status = Type_Event?.Invoke (reason, kind, p_Type);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Type
		//
		// traverse syntax tree node associated with any production of syntax rule Type
		//

		public void Traverse (Type p_Type)
		{
			if (p_Type.isLocked())
				return;
			p_Type.dolock();
			Type.production_kind kind = (Type.production_kind) p_Type.kind;
			p_Type.turn_reset ();
			if (Raise_Type_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Type))
			switch (kind)
			{
				case Type.production_kind.g_Type_1:
					// traverse syntax tree node associated with production
					// Type: BuiltinType

					if (Raise_Type_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Type))
						Traverse (p_Type.m_BuiltinType);
					p_Type.turn_inc ();
					Raise_Type_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Type);
				break;
				case Type.production_kind.g_Type_2:
					// traverse syntax tree node associated with production
					// Type: ReferencedType

					if (Raise_Type_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Type))
						Traverse (p_Type.m_ReferencedType);
					p_Type.turn_inc ();
					Raise_Type_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Type);
				break;
				case Type.production_kind.g_Type_3:
					// traverse syntax tree node associated with production
					// Type: ConstrainedType

					if (Raise_Type_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Type))
						Traverse (p_Type.m_ConstrainedType);
					p_Type.turn_inc ();
					Raise_Type_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Type);
				break;
			}
			Raise_Type_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Type);
			p_Type.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Type
		//

		public void TraverseCommon (Type p_Type)
		{
			Type.production_kind kind = (Type.production_kind) p_Type.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Type))
			switch (kind)
			{
				case Type.production_kind.g_Type_1:
					// traverse syntax tree node associated with production
					// Type: BuiltinType

						TraverseCommon (p_Type.m_BuiltinType);
				break;
				case Type.production_kind.g_Type_2:
					// traverse syntax tree node associated with production
					// Type: ReferencedType

						TraverseCommon (p_Type.m_ReferencedType);
				break;
				case Type.production_kind.g_Type_3:
					// traverse syntax tree node associated with production
					// Type: ConstrainedType

						TraverseCommon (p_Type.m_ConstrainedType);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Type);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Type

		//
		// create syntax tree node associated with production
		// Type: BuiltinType

		//

		public Type Type_1 (BuiltinType p_BuiltinType)
		{
			Type p_Type_ref = new Type(p_BuiltinType);
			p_BuiltinType.parent = p_Type_ref;
			Raise_Type_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Type.production_kind.g_Type_1, p_Type_ref);
			return p_Type_ref;
		}

		//
		// create syntax tree node associated with production
		// Type: ReferencedType

		//

		public Type Type_2 (ReferencedType p_ReferencedType)
		{
			Type p_Type_ref = new Type(p_ReferencedType);
			p_ReferencedType.parent = p_Type_ref;
			Raise_Type_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Type.production_kind.g_Type_2, p_Type_ref);
			return p_Type_ref;
		}

		//
		// create syntax tree node associated with production
		// Type: ConstrainedType

		//

		public Type Type_3 (ConstrainedType p_ConstrainedType)
		{
			Type p_Type_ref = new Type(p_ConstrainedType);
			p_ConstrainedType.parent = p_Type_ref;
			Raise_Type_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Type.production_kind.g_Type_3, p_Type_ref);
			return p_Type_ref;
		}
		#endregion
	};
}
