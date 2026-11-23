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
	// class associated with syntax rule ComponentType
	//

	[DataContract]
	public class	ComponentType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ComponentType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ComponentType
		{
			g_ComponentType_1 = 1,	// TypeOrNamedType

			g_ComponentType_2 = 2,	// TypeOrNamedType OPTIONAL

			g_ComponentType_3 = 3,	// TypeOrNamedType DEFAULT Value

			g_ComponentType_4 = 4,	// COMPONENTS OF Type

		};
		#endregion
		#region production markers associated with the syntax rule ComponentType

		// markers associated with production: ComponentType -> TypeOrNamedType

		public enum production_marker_1 : ushort
		{
			m_TypeOrNamedType,
			final
		};

		// markers associated with production: ComponentType -> TypeOrNamedType OPTIONAL

		public enum production_marker_2 : ushort
		{
			m_TypeOrNamedType,
			final
		};

		// markers associated with production: ComponentType -> TypeOrNamedType DEFAULT Value

		public enum production_marker_3 : ushort
		{
			m_TypeOrNamedType,
			m_Value,
			final
		};

		// markers associated with production: ComponentType -> COMPONENTS OF Type

		public enum production_marker_4 : ushort
		{
			m_Type,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ComponentType

		// Constructor declaration(s) associated with production(s) of syntax rule ComponentType

		//
		// Constructor associated with the following production(s)
		// ComponentType -> TypeOrNamedType

		//

		public ComponentType (TypeOrNamedType p_TypeOrNamedType) : base ((uint) ProductionID._ComponentType_ID, (uint) production_kind.g_ComponentType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TypeOrNamedType = p_TypeOrNamedType;
		}

		//
		// Constructor associated with the following production(s)
		// ComponentType -> TypeOrNamedType OPTIONAL

		//

		public ComponentType (TypeOrNamedType p_TypeOrNamedType, SyntaxTreeToken p_token) : base ((uint) ProductionID._ComponentType_ID, (uint) production_kind.g_ComponentType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_TypeOrNamedType = p_TypeOrNamedType;
			children[1] = m_OPTIONAL = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// ComponentType -> TypeOrNamedType DEFAULT Value

		//

		public ComponentType (TypeOrNamedType p_TypeOrNamedType, SyntaxTreeToken p_token, Value p_Value) : base ((uint) ProductionID._ComponentType_ID, (uint) production_kind.g_ComponentType_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_TypeOrNamedType = p_TypeOrNamedType;
			children[1] = m_DEFAULT = p_token;
			children[2] = m_Value = p_Value;
		}

		//
		// Constructor associated with the following production(s)
		// ComponentType -> COMPONENTS OF Type

		//

		public ComponentType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Type p_Type) : base ((uint) ProductionID._ComponentType_ID, (uint) production_kind.g_ComponentType_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_COMPONENTS = p_token;
			children[1] = m_OF = p_token_1;
			children[2] = m_Type = p_Type;
		}

		public ComponentType () { }

		// Copy constructor

		public ComponentType (ComponentType p_ComponentType) : base (p_ComponentType.id, p_ComponentType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ComponentType.appInfo;
			switch ((production_kind) p_ComponentType.kind)
			{
				case production_kind.g_ComponentType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TypeOrNamedType = (p_ComponentType.m_TypeOrNamedType != null) ? new TypeOrNamedType (p_ComponentType.m_TypeOrNamedType) : null) != null) m_TypeOrNamedType.parent = this;
					break;
				case production_kind.g_ComponentType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_TypeOrNamedType = (p_ComponentType.m_TypeOrNamedType != null) ? new TypeOrNamedType (p_ComponentType.m_TypeOrNamedType) : null) != null) m_TypeOrNamedType.parent = this;
					if ((children [1] = m_OPTIONAL = (p_ComponentType.m_OPTIONAL != null) ? new SyntaxTreeToken (p_ComponentType.m_OPTIONAL) : null) != null) m_OPTIONAL.parent = this;
					break;
				case production_kind.g_ComponentType_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_TypeOrNamedType = (p_ComponentType.m_TypeOrNamedType != null) ? new TypeOrNamedType (p_ComponentType.m_TypeOrNamedType) : null) != null) m_TypeOrNamedType.parent = this;
					if ((children [1] = m_DEFAULT = (p_ComponentType.m_DEFAULT != null) ? new SyntaxTreeToken (p_ComponentType.m_DEFAULT) : null) != null) m_DEFAULT.parent = this;
					if ((children [2] = m_Value = (p_ComponentType.m_Value != null) ? new Value (p_ComponentType.m_Value) : null) != null) m_Value.parent = this;
					break;
				case production_kind.g_ComponentType_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_COMPONENTS = (p_ComponentType.m_COMPONENTS != null) ? new SyntaxTreeToken (p_ComponentType.m_COMPONENTS) : null) != null) m_COMPONENTS.parent = this;
					if ((children [1] = m_OF = (p_ComponentType.m_OF != null) ? new SyntaxTreeToken (p_ComponentType.m_OF) : null) != null) m_OF.parent = this;
					if ((children [2] = m_Type = (p_ComponentType.m_Type != null) ? new Type (p_ComponentType.m_Type) : null) != null) m_Type.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ComponentType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ComponentType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_TypeOrNamedType?.Dispose ();
			m_OPTIONAL?.Dispose ();
			m_DEFAULT?.Dispose ();
			m_Value?.Dispose ();
			m_COMPONENTS?.Dispose ();
			m_OF?.Dispose ();
			m_Type?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ComponentType

		// Content changing function(s) associated with production(s) of syntax rule ComponentType

		//
		// Content changing function associated with following production(s)
		// ComponentType -> TypeOrNamedType

		//

		public void change(TypeOrNamedType p_TypeOrNamedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TypeOrNamedType = p_TypeOrNamedType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ComponentType -> TypeOrNamedType OPTIONAL

		//

		public void change(TypeOrNamedType p_TypeOrNamedType, SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_TypeOrNamedType = p_TypeOrNamedType;
			children [1] = m_OPTIONAL = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ComponentType -> TypeOrNamedType DEFAULT Value

		//

		public void change(TypeOrNamedType p_TypeOrNamedType, SyntaxTreeToken p_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentType_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_TypeOrNamedType = p_TypeOrNamedType;
			children [1] = m_DEFAULT = p_token;
			children [2] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ComponentType -> COMPONENTS OF Type

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentType_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_COMPONENTS = p_token;
			children [1] = m_OF = p_token_1;
			children [2] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ComponentType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_TypeOrNamedType != null) && m_TypeOrNamedType.checkInclusion (element) ||
				(m_OPTIONAL != null) && m_OPTIONAL.checkInclusion (element) ||
				(m_DEFAULT != null) && m_DEFAULT.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_COMPONENTS != null) && m_COMPONENTS.checkInclusion (element) ||
				(m_OF != null) && m_OF.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ComponentType

		//
		// emit production tree node associated with any production of syntax rule ComponentType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ComponentType_1:
					// emit syntax tree node associated with production
					// ComponentType: TypeOrNamedType

					s += m_TypeOrNamedType.Emit (depth - 1);
				break;
				case production_kind.g_ComponentType_2:
					// emit syntax tree node associated with production
					// ComponentType: TypeOrNamedType OPTIONAL

					s += m_TypeOrNamedType.Emit (depth - 1);
					s += " ";
					s += m_OPTIONAL.Emit (depth - 1);
				break;
				case production_kind.g_ComponentType_3:
					// emit syntax tree node associated with production
					// ComponentType: TypeOrNamedType DEFAULT Value

					s += m_TypeOrNamedType.Emit (depth - 1);
					s += " ";
					s += m_DEFAULT.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
				case production_kind.g_ComponentType_4:
					// emit syntax tree node associated with production
					// ComponentType: COMPONENTS OF Type

					s += m_COMPONENTS.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ComponentType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ComponentType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ComponentType_1:
					// emit syntax tree node associated with production
					// ComponentType: TypeOrNamedType

					s += m_TypeOrNamedType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ComponentType_2:
					// emit syntax tree node associated with production
					// ComponentType: TypeOrNamedType OPTIONAL

					s += m_TypeOrNamedType.EmitProductionTree (depth - 1);
					s += ' ';
					s += "OPTIONAL";
				break;
				case production_kind.g_ComponentType_3:
					// emit syntax tree node associated with production
					// ComponentType: TypeOrNamedType DEFAULT Value

					s += m_TypeOrNamedType.EmitProductionTree (depth - 1);
					s += ' ';
					s += "DEFAULT";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ComponentType_4:
					// emit syntax tree node associated with production
					// ComponentType: COMPONENTS OF Type

					s += "COMPONENTS";
					s += ' ';
					s += "OF";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ComponentType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ComponentType.production_kind kind = (ComponentType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ComponentType.production_kind.g_ComponentType_1:
					// traverse syntax tree node associated with production
					// ComponentType: TypeOrNamedType

						m_TypeOrNamedType.Visit (visitor, appData);
				break;
				case ComponentType.production_kind.g_ComponentType_2:
					// traverse syntax tree node associated with production
					// ComponentType: TypeOrNamedType OPTIONAL

						m_TypeOrNamedType.Visit (visitor, appData);
						m_OPTIONAL.Visit (visitor, appData);
				break;
				case ComponentType.production_kind.g_ComponentType_3:
					// traverse syntax tree node associated with production
					// ComponentType: TypeOrNamedType DEFAULT Value

						m_TypeOrNamedType.Visit (visitor, appData);
						m_DEFAULT.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
				break;
				case ComponentType.production_kind.g_ComponentType_4:
					// traverse syntax tree node associated with production
					// ComponentType: COMPONENTS OF Type

						m_COMPONENTS.Visit (visitor, appData);
						m_OF.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_TypeOrNamedType?.reparent (this);
			m_OPTIONAL?.reparent (this);
			m_DEFAULT?.reparent (this);
			m_Value?.reparent (this);
			m_COMPONENTS?.reparent (this);
			m_OF?.reparent (this);
			m_Type?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ComponentType
		//

		public void _init ()
		{
			m_TypeOrNamedType = null;
			m_OPTIONAL = null;
			m_DEFAULT = null;
			m_Value = null;
			m_COMPONENTS = null;
			m_OF = null;
			m_Type = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ComponentType

		// counter of all nodes associated with syntax rule ComponentType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ComponentType
		[DataMember (Name = "m_TypeOrNamedType")] public TypeOrNamedType m_TypeOrNamedType { get; private set; }
		[DataMember (Name = "m_OPTIONAL")] public SyntaxTreeToken m_OPTIONAL { get; private set; }
		[DataMember (Name = "m_DEFAULT")] public SyntaxTreeToken m_DEFAULT { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_COMPONENTS")] public SyntaxTreeToken m_COMPONENTS { get; private set; }
		[DataMember (Name = "m_OF")] public SyntaxTreeToken m_OF { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }

		public enum __p3_markers
		{
			m1 = 1,
			m2 = 2,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ComponentType

		// delegate function (callback) prototype associated with syntax rule ComponentType
		public delegate bool ComponentType_Callback (SyntaxTreeCallbackReason reason, ComponentType.production_kind kind, ComponentType p_ComponentType);

		// event associated with syntax rule ComponentType
		public event ComponentType_Callback ComponentType_Event;

		// event trigger associated with syntax rule ComponentType
		public bool Raise_ComponentType_Event (SyntaxTreeCallbackReason reason, ComponentType.production_kind kind, ComponentType p_ComponentType)
		{
			bool? status = ComponentType_Event?.Invoke (reason, kind, p_ComponentType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ComponentType
		//
		// traverse syntax tree node associated with any production of syntax rule ComponentType
		//

		public void Traverse (ComponentType p_ComponentType)
		{
			if (p_ComponentType.isLocked())
				return;
			p_ComponentType.dolock();
			ComponentType.production_kind kind = (ComponentType.production_kind) p_ComponentType.kind;
			p_ComponentType.turn_reset ();
			if (Raise_ComponentType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ComponentType))
			switch (kind)
			{
				case ComponentType.production_kind.g_ComponentType_1:
					// traverse syntax tree node associated with production
					// ComponentType: TypeOrNamedType

					if (Raise_ComponentType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentType))
						Traverse (p_ComponentType.m_TypeOrNamedType);
					p_ComponentType.turn_inc ();
					Raise_ComponentType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentType);
				break;
				case ComponentType.production_kind.g_ComponentType_2:
					// traverse syntax tree node associated with production
					// ComponentType: TypeOrNamedType OPTIONAL

					if (Raise_ComponentType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentType))
						Traverse (p_ComponentType.m_TypeOrNamedType);
					p_ComponentType.turn_inc ();
					Raise_ComponentType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentType);
				break;
				case ComponentType.production_kind.g_ComponentType_3:
					// traverse syntax tree node associated with production
					// ComponentType: TypeOrNamedType DEFAULT Value

					if (Raise_ComponentType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentType))
						Traverse (p_ComponentType.m_TypeOrNamedType);
					p_ComponentType.turn_inc ();
					if (Raise_ComponentType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentType))
						Traverse (p_ComponentType.m_Value);
					p_ComponentType.turn_inc ();
					Raise_ComponentType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentType);
				break;
				case ComponentType.production_kind.g_ComponentType_4:
					// traverse syntax tree node associated with production
					// ComponentType: COMPONENTS OF Type

					if (Raise_ComponentType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentType))
						Traverse (p_ComponentType.m_Type);
					p_ComponentType.turn_inc ();
					Raise_ComponentType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentType);
				break;
			}
			Raise_ComponentType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ComponentType);
			p_ComponentType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentType
		//

		public void TraverseCommon (ComponentType p_ComponentType)
		{
			ComponentType.production_kind kind = (ComponentType.production_kind) p_ComponentType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ComponentType))
			switch (kind)
			{
				case ComponentType.production_kind.g_ComponentType_1:
					// traverse syntax tree node associated with production
					// ComponentType: TypeOrNamedType

						TraverseCommon (p_ComponentType.m_TypeOrNamedType);
				break;
				case ComponentType.production_kind.g_ComponentType_2:
					// traverse syntax tree node associated with production
					// ComponentType: TypeOrNamedType OPTIONAL

						TraverseCommon (p_ComponentType.m_TypeOrNamedType);
						TraverseCommon (p_ComponentType.m_OPTIONAL);
				break;
				case ComponentType.production_kind.g_ComponentType_3:
					// traverse syntax tree node associated with production
					// ComponentType: TypeOrNamedType DEFAULT Value

						TraverseCommon (p_ComponentType.m_TypeOrNamedType);
						TraverseCommon (p_ComponentType.m_DEFAULT);
						TraverseCommon (p_ComponentType.m_Value);
				break;
				case ComponentType.production_kind.g_ComponentType_4:
					// traverse syntax tree node associated with production
					// ComponentType: COMPONENTS OF Type

						TraverseCommon (p_ComponentType.m_COMPONENTS);
						TraverseCommon (p_ComponentType.m_OF);
						TraverseCommon (p_ComponentType.m_Type);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ComponentType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ComponentType

		//
		// create syntax tree node associated with production
		// ComponentType: TypeOrNamedType

		//

		public ComponentType ComponentType_1 (TypeOrNamedType p_TypeOrNamedType)
		{
			ComponentType p_ComponentType_ref = new ComponentType(p_TypeOrNamedType);
			p_TypeOrNamedType.parent = p_ComponentType_ref;
			Raise_ComponentType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentType.production_kind.g_ComponentType_1, p_ComponentType_ref);
			return p_ComponentType_ref;
		}

		//
		// create syntax tree node associated with production
		// ComponentType: TypeOrNamedType OPTIONAL

		//

		public ComponentType ComponentType_2 (TypeOrNamedType p_TypeOrNamedType, SyntaxTreeToken p_token)
		{
			ComponentType p_ComponentType_ref = new ComponentType(p_TypeOrNamedType, p_token);
			p_TypeOrNamedType.parent = p_ComponentType_ref;
			p_token.parent = p_ComponentType_ref;
			Raise_ComponentType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentType.production_kind.g_ComponentType_2, p_ComponentType_ref);
			return p_ComponentType_ref;
		}

		//
		// create syntax tree node associated with production
		// ComponentType: TypeOrNamedType DEFAULT Value

		//

		public ComponentType ComponentType_3 (TypeOrNamedType p_TypeOrNamedType, SyntaxTreeToken p_token, Value p_Value)
		{
			ComponentType p_ComponentType_ref = new ComponentType(p_TypeOrNamedType, p_token, p_Value);
			p_TypeOrNamedType.parent = p_ComponentType_ref;
			p_token.parent = p_ComponentType_ref;
			p_Value.parent = p_ComponentType_ref;
			Raise_ComponentType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentType.production_kind.g_ComponentType_3, p_ComponentType_ref);
			return p_ComponentType_ref;
		}

		//
		// create syntax tree node associated with production
		// ComponentType: COMPONENTS OF Type

		//

		public ComponentType ComponentType_4 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Type p_Type)
		{
			ComponentType p_ComponentType_ref = new ComponentType(p_token, p_token_1, p_Type);
			p_token.parent = p_ComponentType_ref;
			p_token_1.parent = p_ComponentType_ref;
			p_Type.parent = p_ComponentType_ref;
			Raise_ComponentType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentType.production_kind.g_ComponentType_4, p_ComponentType_ref);
			return p_ComponentType_ref;
		}
		#endregion
	};
}
