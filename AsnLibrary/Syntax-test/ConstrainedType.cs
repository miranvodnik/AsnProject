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
	// class associated with syntax rule ConstrainedType
	//

	[DataContract]
	public class	ConstrainedType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ConstrainedType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ConstrainedType
		{
			g_ConstrainedType_1 = 1,	// Type Constraint

			g_ConstrainedType_2 = 2,	// TypeWithConstraint

		};
		#endregion
		#region production markers associated with the syntax rule ConstrainedType

		// markers associated with production: ConstrainedType -> Type Constraint

		public enum production_marker_1 : ushort
		{
			m_Type,
			m_Constraint,
			final
		};

		// markers associated with production: ConstrainedType -> TypeWithConstraint

		public enum production_marker_2 : ushort
		{
			m_TypeWithConstraint,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ConstrainedType

		// Constructor declaration(s) associated with production(s) of syntax rule ConstrainedType

		//
		// Constructor associated with the following production(s)
		// ConstrainedType -> Type Constraint

		//

		public ConstrainedType (Type p_Type, Constraint p_Constraint) : base ((uint) ProductionID._ConstrainedType_ID, (uint) production_kind.g_ConstrainedType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_Type = p_Type;
			children[1] = m_Constraint = p_Constraint;
		}

		//
		// Constructor associated with the following production(s)
		// ConstrainedType -> TypeWithConstraint

		//

		public ConstrainedType (TypeWithConstraint p_TypeWithConstraint) : base ((uint) ProductionID._ConstrainedType_ID, (uint) production_kind.g_ConstrainedType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TypeWithConstraint = p_TypeWithConstraint;
		}

		public ConstrainedType () { }

		// Copy constructor

		public ConstrainedType (ConstrainedType p_ConstrainedType) : base (p_ConstrainedType.id, p_ConstrainedType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ConstrainedType.appInfo;
			switch ((production_kind) p_ConstrainedType.kind)
			{
				case production_kind.g_ConstrainedType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_Type = (p_ConstrainedType.m_Type != null) ? new Type (p_ConstrainedType.m_Type) : null) != null) m_Type.parent = this;
					if ((children [1] = m_Constraint = (p_ConstrainedType.m_Constraint != null) ? new Constraint (p_ConstrainedType.m_Constraint) : null) != null) m_Constraint.parent = this;
					break;
				case production_kind.g_ConstrainedType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TypeWithConstraint = (p_ConstrainedType.m_TypeWithConstraint != null) ? new TypeWithConstraint (p_ConstrainedType.m_TypeWithConstraint) : null) != null) m_TypeWithConstraint.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ConstrainedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ConstrainedType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Type?.Dispose ();
			m_Constraint?.Dispose ();
			m_TypeWithConstraint?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ConstrainedType

		// Content changing function(s) associated with production(s) of syntax rule ConstrainedType

		//
		// Content changing function associated with following production(s)
		// ConstrainedType -> Type Constraint

		//

		public void change(Type p_Type, Constraint p_Constraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_ConstrainedType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_Type = p_Type;
			children [1] = m_Constraint = p_Constraint;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ConstrainedType -> TypeWithConstraint

		//

		public void change(TypeWithConstraint p_TypeWithConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_ConstrainedType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TypeWithConstraint = p_TypeWithConstraint;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ConstrainedType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_Constraint != null) && m_Constraint.checkInclusion (element) ||
				(m_TypeWithConstraint != null) && m_TypeWithConstraint.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ConstrainedType

		//
		// emit production tree node associated with any production of syntax rule ConstrainedType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ConstrainedType_1:
					// emit syntax tree node associated with production
					// ConstrainedType: Type Constraint

					s += m_Type.Emit (depth - 1);
					s += " ";
					s += m_Constraint.Emit (depth - 1);
				break;
				case production_kind.g_ConstrainedType_2:
					// emit syntax tree node associated with production
					// ConstrainedType: TypeWithConstraint

					s += m_TypeWithConstraint.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ConstrainedType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ConstrainedType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ConstrainedType_1:
					// emit syntax tree node associated with production
					// ConstrainedType: Type Constraint

					s += m_Type.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Constraint.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ConstrainedType_2:
					// emit syntax tree node associated with production
					// ConstrainedType: TypeWithConstraint

					s += m_TypeWithConstraint.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ConstrainedType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ConstrainedType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ConstrainedType.production_kind kind = (ConstrainedType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ConstrainedType.production_kind.g_ConstrainedType_1:
					// traverse syntax tree node associated with production
					// ConstrainedType: Type Constraint

						m_Type.Visit (visitor, appData);
						m_Constraint.Visit (visitor, appData);
				break;
				case ConstrainedType.production_kind.g_ConstrainedType_2:
					// traverse syntax tree node associated with production
					// ConstrainedType: TypeWithConstraint

						m_TypeWithConstraint.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Type?.reparent (this);
			m_Constraint?.reparent (this);
			m_TypeWithConstraint?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ConstrainedType
		//

		public void _init ()
		{
			m_Type = null;
			m_Constraint = null;
			m_TypeWithConstraint = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ConstrainedType

		// counter of all nodes associated with syntax rule ConstrainedType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ConstrainedType
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_Constraint")] public Constraint m_Constraint { get; private set; }
		[DataMember (Name = "m_TypeWithConstraint")] public TypeWithConstraint m_TypeWithConstraint { get; private set; }

		public enum __p1_markers
		{
			m1 = 1,
			m2 = 2,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ConstrainedType

		// delegate function (callback) prototype associated with syntax rule ConstrainedType
		public delegate bool ConstrainedType_Callback (SyntaxTreeCallbackReason reason, ConstrainedType.production_kind kind, ConstrainedType p_ConstrainedType);

		// event associated with syntax rule ConstrainedType
		public event ConstrainedType_Callback ConstrainedType_Event;

		// event trigger associated with syntax rule ConstrainedType
		public bool Raise_ConstrainedType_Event (SyntaxTreeCallbackReason reason, ConstrainedType.production_kind kind, ConstrainedType p_ConstrainedType)
		{
			bool? status = ConstrainedType_Event?.Invoke (reason, kind, p_ConstrainedType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ConstrainedType
		//
		// traverse syntax tree node associated with any production of syntax rule ConstrainedType
		//

		public void Traverse (ConstrainedType p_ConstrainedType)
		{
			if (p_ConstrainedType.isLocked())
				return;
			p_ConstrainedType.dolock();
			ConstrainedType.production_kind kind = (ConstrainedType.production_kind) p_ConstrainedType.kind;
			p_ConstrainedType.turn_reset ();
			if (Raise_ConstrainedType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ConstrainedType))
			switch (kind)
			{
				case ConstrainedType.production_kind.g_ConstrainedType_1:
					// traverse syntax tree node associated with production
					// ConstrainedType: Type Constraint

					if (Raise_ConstrainedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ConstrainedType))
						Traverse (p_ConstrainedType.m_Type);
					p_ConstrainedType.turn_inc ();
					if (Raise_ConstrainedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ConstrainedType))
						Traverse (p_ConstrainedType.m_Constraint);
					p_ConstrainedType.turn_inc ();
					Raise_ConstrainedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ConstrainedType);
				break;
				case ConstrainedType.production_kind.g_ConstrainedType_2:
					// traverse syntax tree node associated with production
					// ConstrainedType: TypeWithConstraint

					if (Raise_ConstrainedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ConstrainedType))
						Traverse (p_ConstrainedType.m_TypeWithConstraint);
					p_ConstrainedType.turn_inc ();
					Raise_ConstrainedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ConstrainedType);
				break;
			}
			Raise_ConstrainedType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ConstrainedType);
			p_ConstrainedType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ConstrainedType
		//

		public void TraverseCommon (ConstrainedType p_ConstrainedType)
		{
			ConstrainedType.production_kind kind = (ConstrainedType.production_kind) p_ConstrainedType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ConstrainedType))
			switch (kind)
			{
				case ConstrainedType.production_kind.g_ConstrainedType_1:
					// traverse syntax tree node associated with production
					// ConstrainedType: Type Constraint

						TraverseCommon (p_ConstrainedType.m_Type);
						TraverseCommon (p_ConstrainedType.m_Constraint);
				break;
				case ConstrainedType.production_kind.g_ConstrainedType_2:
					// traverse syntax tree node associated with production
					// ConstrainedType: TypeWithConstraint

						TraverseCommon (p_ConstrainedType.m_TypeWithConstraint);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ConstrainedType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ConstrainedType

		//
		// create syntax tree node associated with production
		// ConstrainedType: Type Constraint

		//

		public ConstrainedType ConstrainedType_1 (Type p_Type, Constraint p_Constraint)
		{
			ConstrainedType p_ConstrainedType_ref = new ConstrainedType(p_Type, p_Constraint);
			p_Type.parent = p_ConstrainedType_ref;
			p_Constraint.parent = p_ConstrainedType_ref;
			Raise_ConstrainedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ConstrainedType.production_kind.g_ConstrainedType_1, p_ConstrainedType_ref);
			return p_ConstrainedType_ref;
		}

		//
		// create syntax tree node associated with production
		// ConstrainedType: TypeWithConstraint

		//

		public ConstrainedType ConstrainedType_2 (TypeWithConstraint p_TypeWithConstraint)
		{
			ConstrainedType p_ConstrainedType_ref = new ConstrainedType(p_TypeWithConstraint);
			p_TypeWithConstraint.parent = p_ConstrainedType_ref;
			Raise_ConstrainedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ConstrainedType.production_kind.g_ConstrainedType_2, p_ConstrainedType_ref);
			return p_ConstrainedType_ref;
		}
		#endregion
	};
}
