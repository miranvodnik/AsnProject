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
	// class associated with syntax rule TypeOrNamedType
	//

	[DataContract]
	public class	TypeOrNamedType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TypeOrNamedType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TypeOrNamedType
		{
			g_TypeOrNamedType_1 = 1,	// Type

			g_TypeOrNamedType_2 = 2,	// NamedType

		};
		#endregion
		#region production markers associated with the syntax rule TypeOrNamedType

		// markers associated with production: TypeOrNamedType -> Type

		public enum production_marker_1 : ushort
		{
			m_Type,
			final
		};

		// markers associated with production: TypeOrNamedType -> NamedType

		public enum production_marker_2 : ushort
		{
			m_NamedType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TypeOrNamedType

		// Constructor declaration(s) associated with production(s) of syntax rule TypeOrNamedType

		//
		// Constructor associated with the following production(s)
		// TypeOrNamedType -> Type

		//

		public TypeOrNamedType (Type p_Type) : base ((uint) ProductionID._TypeOrNamedType_ID, (uint) production_kind.g_TypeOrNamedType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// TypeOrNamedType -> NamedType

		//

		public TypeOrNamedType (NamedType p_NamedType) : base ((uint) ProductionID._TypeOrNamedType_ID, (uint) production_kind.g_TypeOrNamedType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NamedType = p_NamedType;
		}

		public TypeOrNamedType () { }

		// Copy constructor

		public TypeOrNamedType (TypeOrNamedType p_TypeOrNamedType) : base (p_TypeOrNamedType.id, p_TypeOrNamedType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TypeOrNamedType.appInfo;
			switch ((production_kind) p_TypeOrNamedType.kind)
			{
				case production_kind.g_TypeOrNamedType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Type = (p_TypeOrNamedType.m_Type != null) ? new Type (p_TypeOrNamedType.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_TypeOrNamedType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NamedType = (p_TypeOrNamedType.m_NamedType != null) ? new NamedType (p_TypeOrNamedType.m_NamedType) : null) != null) m_NamedType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TypeOrNamedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TypeOrNamedType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Type?.Dispose ();
			m_NamedType?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TypeOrNamedType

		// Content changing function(s) associated with production(s) of syntax rule TypeOrNamedType

		//
		// Content changing function associated with following production(s)
		// TypeOrNamedType -> Type

		//

		public void change(Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_TypeOrNamedType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TypeOrNamedType -> NamedType

		//

		public void change(NamedType p_NamedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_TypeOrNamedType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NamedType = p_NamedType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TypeOrNamedType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_NamedType != null) && m_NamedType.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TypeOrNamedType

		//
		// emit production tree node associated with any production of syntax rule TypeOrNamedType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TypeOrNamedType_1:
					// emit syntax tree node associated with production
					// TypeOrNamedType: Type

					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_TypeOrNamedType_2:
					// emit syntax tree node associated with production
					// TypeOrNamedType: NamedType

					s += m_NamedType.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TypeOrNamedType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TypeOrNamedType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TypeOrNamedType_1:
					// emit syntax tree node associated with production
					// TypeOrNamedType: Type

					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TypeOrNamedType_2:
					// emit syntax tree node associated with production
					// TypeOrNamedType: NamedType

					s += m_NamedType.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TypeOrNamedType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TypeOrNamedType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TypeOrNamedType.production_kind kind = (TypeOrNamedType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TypeOrNamedType.production_kind.g_TypeOrNamedType_1:
					// traverse syntax tree node associated with production
					// TypeOrNamedType: Type

						m_Type.Visit (visitor, appData);
				break;
				case TypeOrNamedType.production_kind.g_TypeOrNamedType_2:
					// traverse syntax tree node associated with production
					// TypeOrNamedType: NamedType

						m_NamedType.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Type?.reparent (this);
			m_NamedType?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TypeOrNamedType
		//

		public void _init ()
		{
			m_Type = null;
			m_NamedType = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TypeOrNamedType

		// counter of all nodes associated with syntax rule TypeOrNamedType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TypeOrNamedType
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_NamedType")] public NamedType m_NamedType { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TypeOrNamedType

		// delegate function (callback) prototype associated with syntax rule TypeOrNamedType
		public delegate bool TypeOrNamedType_Callback (SyntaxTreeCallbackReason reason, TypeOrNamedType.production_kind kind, TypeOrNamedType p_TypeOrNamedType);

		// event associated with syntax rule TypeOrNamedType
		public event TypeOrNamedType_Callback TypeOrNamedType_Event;

		// event trigger associated with syntax rule TypeOrNamedType
		public bool Raise_TypeOrNamedType_Event (SyntaxTreeCallbackReason reason, TypeOrNamedType.production_kind kind, TypeOrNamedType p_TypeOrNamedType)
		{
			bool? status = TypeOrNamedType_Event?.Invoke (reason, kind, p_TypeOrNamedType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TypeOrNamedType
		//
		// traverse syntax tree node associated with any production of syntax rule TypeOrNamedType
		//

		public void Traverse (TypeOrNamedType p_TypeOrNamedType)
		{
			if (p_TypeOrNamedType.isLocked())
				return;
			p_TypeOrNamedType.dolock();
			TypeOrNamedType.production_kind kind = (TypeOrNamedType.production_kind) p_TypeOrNamedType.kind;
			p_TypeOrNamedType.turn_reset ();
			if (Raise_TypeOrNamedType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TypeOrNamedType))
			switch (kind)
			{
				case TypeOrNamedType.production_kind.g_TypeOrNamedType_1:
					// traverse syntax tree node associated with production
					// TypeOrNamedType: Type

					if (Raise_TypeOrNamedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeOrNamedType))
						Traverse (p_TypeOrNamedType.m_Type);
					p_TypeOrNamedType.turn_inc ();
					Raise_TypeOrNamedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeOrNamedType);
				break;
				case TypeOrNamedType.production_kind.g_TypeOrNamedType_2:
					// traverse syntax tree node associated with production
					// TypeOrNamedType: NamedType

					if (Raise_TypeOrNamedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeOrNamedType))
						Traverse (p_TypeOrNamedType.m_NamedType);
					p_TypeOrNamedType.turn_inc ();
					Raise_TypeOrNamedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeOrNamedType);
				break;
			}
			Raise_TypeOrNamedType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TypeOrNamedType);
			p_TypeOrNamedType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TypeOrNamedType
		//

		public void TraverseCommon (TypeOrNamedType p_TypeOrNamedType)
		{
			TypeOrNamedType.production_kind kind = (TypeOrNamedType.production_kind) p_TypeOrNamedType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TypeOrNamedType))
			switch (kind)
			{
				case TypeOrNamedType.production_kind.g_TypeOrNamedType_1:
					// traverse syntax tree node associated with production
					// TypeOrNamedType: Type

						TraverseCommon (p_TypeOrNamedType.m_Type);
				break;
				case TypeOrNamedType.production_kind.g_TypeOrNamedType_2:
					// traverse syntax tree node associated with production
					// TypeOrNamedType: NamedType

						TraverseCommon (p_TypeOrNamedType.m_NamedType);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TypeOrNamedType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TypeOrNamedType

		//
		// create syntax tree node associated with production
		// TypeOrNamedType: Type

		//

		public TypeOrNamedType TypeOrNamedType_1 (Type p_Type)
		{
			TypeOrNamedType p_TypeOrNamedType_ref = new TypeOrNamedType(p_Type);
			p_Type.parent = p_TypeOrNamedType_ref;
			Raise_TypeOrNamedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeOrNamedType.production_kind.g_TypeOrNamedType_1, p_TypeOrNamedType_ref);
			return p_TypeOrNamedType_ref;
		}

		//
		// create syntax tree node associated with production
		// TypeOrNamedType: NamedType

		//

		public TypeOrNamedType TypeOrNamedType_2 (NamedType p_NamedType)
		{
			TypeOrNamedType p_TypeOrNamedType_ref = new TypeOrNamedType(p_NamedType);
			p_NamedType.parent = p_TypeOrNamedType_ref;
			Raise_TypeOrNamedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeOrNamedType.production_kind.g_TypeOrNamedType_2, p_TypeOrNamedType_ref);
			return p_TypeOrNamedType_ref;
		}
		#endregion
	};
}
