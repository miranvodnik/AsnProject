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
	// class associated with syntax rule ReferencedType
	//

	[DataContract]
	public class	ReferencedType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ReferencedType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ReferencedType
		{
			g_ReferencedType_1 = 1,	// DefinedType

			g_ReferencedType_2 = 2,	// UsefulType

			g_ReferencedType_3 = 3,	// SelectionType

			g_ReferencedType_4 = 4,	// TypeFromObject

			g_ReferencedType_5 = 5,	// ValueSetFromObjects

		};
		#endregion
		#region production markers associated with the syntax rule ReferencedType

		// markers associated with production: ReferencedType -> DefinedType

		public enum production_marker_1 : ushort
		{
			m_DefinedType,
			final
		};

		// markers associated with production: ReferencedType -> UsefulType

		public enum production_marker_2 : ushort
		{
			m_UsefulType,
			final
		};

		// markers associated with production: ReferencedType -> SelectionType

		public enum production_marker_3 : ushort
		{
			m_SelectionType,
			final
		};

		// markers associated with production: ReferencedType -> TypeFromObject

		public enum production_marker_4 : ushort
		{
			m_TypeFromObject,
			final
		};

		// markers associated with production: ReferencedType -> ValueSetFromObjects

		public enum production_marker_5 : ushort
		{
			m_ValueSetFromObjects,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ReferencedType

		// Constructor declaration(s) associated with production(s) of syntax rule ReferencedType

		//
		// Constructor associated with the following production(s)
		// ReferencedType -> DefinedType

		//

		public ReferencedType (DefinedType p_DefinedType) : base ((uint) ProductionID._ReferencedType_ID, (uint) production_kind.g_ReferencedType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedType = p_DefinedType;
		}

		//
		// Constructor associated with the following production(s)
		// ReferencedType -> UsefulType

		//

		public ReferencedType (UsefulType p_UsefulType) : base ((uint) ProductionID._ReferencedType_ID, (uint) production_kind.g_ReferencedType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_UsefulType = p_UsefulType;
		}

		//
		// Constructor associated with the following production(s)
		// ReferencedType -> SelectionType

		//

		public ReferencedType (SelectionType p_SelectionType) : base ((uint) ProductionID._ReferencedType_ID, (uint) production_kind.g_ReferencedType_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SelectionType = p_SelectionType;
		}

		//
		// Constructor associated with the following production(s)
		// ReferencedType -> TypeFromObject

		//

		public ReferencedType (TypeFromObject p_TypeFromObject) : base ((uint) ProductionID._ReferencedType_ID, (uint) production_kind.g_ReferencedType_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TypeFromObject = p_TypeFromObject;
		}

		//
		// Constructor associated with the following production(s)
		// ReferencedType -> ValueSetFromObjects

		//

		public ReferencedType (ValueSetFromObjects p_ValueSetFromObjects) : base ((uint) ProductionID._ReferencedType_ID, (uint) production_kind.g_ReferencedType_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ValueSetFromObjects = p_ValueSetFromObjects;
		}

		public ReferencedType () { }

		// Copy constructor

		public ReferencedType (ReferencedType p_ReferencedType) : base (p_ReferencedType.id, p_ReferencedType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ReferencedType.appInfo;
			switch ((production_kind) p_ReferencedType.kind)
			{
				case production_kind.g_ReferencedType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedType = (p_ReferencedType.m_DefinedType != null) ? new DefinedType (p_ReferencedType.m_DefinedType) : null) != null) m_DefinedType.parent = this;
					break;
				case production_kind.g_ReferencedType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UsefulType = (p_ReferencedType.m_UsefulType != null) ? new UsefulType (p_ReferencedType.m_UsefulType) : null) != null) m_UsefulType.parent = this;
					break;
				case production_kind.g_ReferencedType_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SelectionType = (p_ReferencedType.m_SelectionType != null) ? new SelectionType (p_ReferencedType.m_SelectionType) : null) != null) m_SelectionType.parent = this;
					break;
				case production_kind.g_ReferencedType_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TypeFromObject = (p_ReferencedType.m_TypeFromObject != null) ? new TypeFromObject (p_ReferencedType.m_TypeFromObject) : null) != null) m_TypeFromObject.parent = this;
					break;
				case production_kind.g_ReferencedType_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ValueSetFromObjects = (p_ReferencedType.m_ValueSetFromObjects != null) ? new ValueSetFromObjects (p_ReferencedType.m_ValueSetFromObjects) : null) != null) m_ValueSetFromObjects.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ReferencedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ReferencedType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DefinedType?.Dispose ();
			m_UsefulType?.Dispose ();
			m_SelectionType?.Dispose ();
			m_TypeFromObject?.Dispose ();
			m_ValueSetFromObjects?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ReferencedType

		// Content changing function(s) associated with production(s) of syntax rule ReferencedType

		//
		// Content changing function associated with following production(s)
		// ReferencedType -> DefinedType

		//

		public void change(DefinedType p_DefinedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_ReferencedType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedType = p_DefinedType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ReferencedType -> UsefulType

		//

		public void change(UsefulType p_UsefulType)
		{
			_init ();
			this.kind = (uint) production_kind.g_ReferencedType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_UsefulType = p_UsefulType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ReferencedType -> SelectionType

		//

		public void change(SelectionType p_SelectionType)
		{
			_init ();
			this.kind = (uint) production_kind.g_ReferencedType_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SelectionType = p_SelectionType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ReferencedType -> TypeFromObject

		//

		public void change(TypeFromObject p_TypeFromObject)
		{
			_init ();
			this.kind = (uint) production_kind.g_ReferencedType_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TypeFromObject = p_TypeFromObject;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ReferencedType -> ValueSetFromObjects

		//

		public void change(ValueSetFromObjects p_ValueSetFromObjects)
		{
			_init ();
			this.kind = (uint) production_kind.g_ReferencedType_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ValueSetFromObjects = p_ValueSetFromObjects;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ReferencedType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DefinedType != null) && m_DefinedType.checkInclusion (element) ||
				(m_UsefulType != null) && m_UsefulType.checkInclusion (element) ||
				(m_SelectionType != null) && m_SelectionType.checkInclusion (element) ||
				(m_TypeFromObject != null) && m_TypeFromObject.checkInclusion (element) ||
				(m_ValueSetFromObjects != null) && m_ValueSetFromObjects.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ReferencedType

		//
		// emit production tree node associated with any production of syntax rule ReferencedType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ReferencedType_1:
					// emit syntax tree node associated with production
					// ReferencedType: DefinedType

					s += m_DefinedType.Emit (depth - 1);
				break;
				case production_kind.g_ReferencedType_2:
					// emit syntax tree node associated with production
					// ReferencedType: UsefulType

					s += m_UsefulType.Emit (depth - 1);
				break;
				case production_kind.g_ReferencedType_3:
					// emit syntax tree node associated with production
					// ReferencedType: SelectionType

					s += m_SelectionType.Emit (depth - 1);
				break;
				case production_kind.g_ReferencedType_4:
					// emit syntax tree node associated with production
					// ReferencedType: TypeFromObject

					s += m_TypeFromObject.Emit (depth - 1);
				break;
				case production_kind.g_ReferencedType_5:
					// emit syntax tree node associated with production
					// ReferencedType: ValueSetFromObjects

					s += m_ValueSetFromObjects.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ReferencedType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ReferencedType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ReferencedType_1:
					// emit syntax tree node associated with production
					// ReferencedType: DefinedType

					s += m_DefinedType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ReferencedType_2:
					// emit syntax tree node associated with production
					// ReferencedType: UsefulType

					s += m_UsefulType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ReferencedType_3:
					// emit syntax tree node associated with production
					// ReferencedType: SelectionType

					s += m_SelectionType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ReferencedType_4:
					// emit syntax tree node associated with production
					// ReferencedType: TypeFromObject

					s += m_TypeFromObject.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ReferencedType_5:
					// emit syntax tree node associated with production
					// ReferencedType: ValueSetFromObjects

					s += m_ValueSetFromObjects.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ReferencedType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ReferencedType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ReferencedType.production_kind kind = (ReferencedType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ReferencedType.production_kind.g_ReferencedType_1:
					// traverse syntax tree node associated with production
					// ReferencedType: DefinedType

						m_DefinedType.Visit (visitor, appData);
				break;
				case ReferencedType.production_kind.g_ReferencedType_2:
					// traverse syntax tree node associated with production
					// ReferencedType: UsefulType

						m_UsefulType.Visit (visitor, appData);
				break;
				case ReferencedType.production_kind.g_ReferencedType_3:
					// traverse syntax tree node associated with production
					// ReferencedType: SelectionType

						m_SelectionType.Visit (visitor, appData);
				break;
				case ReferencedType.production_kind.g_ReferencedType_4:
					// traverse syntax tree node associated with production
					// ReferencedType: TypeFromObject

						m_TypeFromObject.Visit (visitor, appData);
				break;
				case ReferencedType.production_kind.g_ReferencedType_5:
					// traverse syntax tree node associated with production
					// ReferencedType: ValueSetFromObjects

						m_ValueSetFromObjects.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DefinedType?.reparent (this);
			m_UsefulType?.reparent (this);
			m_SelectionType?.reparent (this);
			m_TypeFromObject?.reparent (this);
			m_ValueSetFromObjects?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ReferencedType
		//

		public void _init ()
		{
			m_DefinedType = null;
			m_UsefulType = null;
			m_SelectionType = null;
			m_TypeFromObject = null;
			m_ValueSetFromObjects = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ReferencedType

		// counter of all nodes associated with syntax rule ReferencedType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ReferencedType
		[DataMember (Name = "m_DefinedType")] public DefinedType m_DefinedType { get; private set; }
		[DataMember (Name = "m_UsefulType")] public UsefulType m_UsefulType { get; private set; }
		[DataMember (Name = "m_SelectionType")] public SelectionType m_SelectionType { get; private set; }
		[DataMember (Name = "m_TypeFromObject")] public TypeFromObject m_TypeFromObject { get; private set; }
		[DataMember (Name = "m_ValueSetFromObjects")] public ValueSetFromObjects m_ValueSetFromObjects { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ReferencedType

		// delegate function (callback) prototype associated with syntax rule ReferencedType
		public delegate bool ReferencedType_Callback (SyntaxTreeCallbackReason reason, ReferencedType.production_kind kind, ReferencedType p_ReferencedType);

		// event associated with syntax rule ReferencedType
		public event ReferencedType_Callback ReferencedType_Event;

		// event trigger associated with syntax rule ReferencedType
		public bool Raise_ReferencedType_Event (SyntaxTreeCallbackReason reason, ReferencedType.production_kind kind, ReferencedType p_ReferencedType)
		{
			bool? status = ReferencedType_Event?.Invoke (reason, kind, p_ReferencedType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ReferencedType
		//
		// traverse syntax tree node associated with any production of syntax rule ReferencedType
		//

		public void Traverse (ReferencedType p_ReferencedType)
		{
			if (p_ReferencedType.isLocked())
				return;
			p_ReferencedType.dolock();
			ReferencedType.production_kind kind = (ReferencedType.production_kind) p_ReferencedType.kind;
			p_ReferencedType.turn_reset ();
			if (Raise_ReferencedType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ReferencedType))
			switch (kind)
			{
				case ReferencedType.production_kind.g_ReferencedType_1:
					// traverse syntax tree node associated with production
					// ReferencedType: DefinedType

					if (Raise_ReferencedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedType))
						Traverse (p_ReferencedType.m_DefinedType);
					p_ReferencedType.turn_inc ();
					Raise_ReferencedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedType);
				break;
				case ReferencedType.production_kind.g_ReferencedType_2:
					// traverse syntax tree node associated with production
					// ReferencedType: UsefulType

					if (Raise_ReferencedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedType))
						Traverse (p_ReferencedType.m_UsefulType);
					p_ReferencedType.turn_inc ();
					Raise_ReferencedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedType);
				break;
				case ReferencedType.production_kind.g_ReferencedType_3:
					// traverse syntax tree node associated with production
					// ReferencedType: SelectionType

					if (Raise_ReferencedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedType))
						Traverse (p_ReferencedType.m_SelectionType);
					p_ReferencedType.turn_inc ();
					Raise_ReferencedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedType);
				break;
				case ReferencedType.production_kind.g_ReferencedType_4:
					// traverse syntax tree node associated with production
					// ReferencedType: TypeFromObject

					if (Raise_ReferencedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedType))
						Traverse (p_ReferencedType.m_TypeFromObject);
					p_ReferencedType.turn_inc ();
					Raise_ReferencedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedType);
				break;
				case ReferencedType.production_kind.g_ReferencedType_5:
					// traverse syntax tree node associated with production
					// ReferencedType: ValueSetFromObjects

					if (Raise_ReferencedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedType))
						Traverse (p_ReferencedType.m_ValueSetFromObjects);
					p_ReferencedType.turn_inc ();
					Raise_ReferencedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedType);
				break;
			}
			Raise_ReferencedType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ReferencedType);
			p_ReferencedType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ReferencedType
		//

		public void TraverseCommon (ReferencedType p_ReferencedType)
		{
			ReferencedType.production_kind kind = (ReferencedType.production_kind) p_ReferencedType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ReferencedType))
			switch (kind)
			{
				case ReferencedType.production_kind.g_ReferencedType_1:
					// traverse syntax tree node associated with production
					// ReferencedType: DefinedType

						TraverseCommon (p_ReferencedType.m_DefinedType);
				break;
				case ReferencedType.production_kind.g_ReferencedType_2:
					// traverse syntax tree node associated with production
					// ReferencedType: UsefulType

						TraverseCommon (p_ReferencedType.m_UsefulType);
				break;
				case ReferencedType.production_kind.g_ReferencedType_3:
					// traverse syntax tree node associated with production
					// ReferencedType: SelectionType

						TraverseCommon (p_ReferencedType.m_SelectionType);
				break;
				case ReferencedType.production_kind.g_ReferencedType_4:
					// traverse syntax tree node associated with production
					// ReferencedType: TypeFromObject

						TraverseCommon (p_ReferencedType.m_TypeFromObject);
				break;
				case ReferencedType.production_kind.g_ReferencedType_5:
					// traverse syntax tree node associated with production
					// ReferencedType: ValueSetFromObjects

						TraverseCommon (p_ReferencedType.m_ValueSetFromObjects);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ReferencedType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ReferencedType

		//
		// create syntax tree node associated with production
		// ReferencedType: DefinedType

		//

		public ReferencedType ReferencedType_1 (DefinedType p_DefinedType)
		{
			ReferencedType p_ReferencedType_ref = new ReferencedType(p_DefinedType);
			p_DefinedType.parent = p_ReferencedType_ref;
			Raise_ReferencedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ReferencedType.production_kind.g_ReferencedType_1, p_ReferencedType_ref);
			return p_ReferencedType_ref;
		}

		//
		// create syntax tree node associated with production
		// ReferencedType: UsefulType

		//

		public ReferencedType ReferencedType_2 (UsefulType p_UsefulType)
		{
			ReferencedType p_ReferencedType_ref = new ReferencedType(p_UsefulType);
			p_UsefulType.parent = p_ReferencedType_ref;
			Raise_ReferencedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ReferencedType.production_kind.g_ReferencedType_2, p_ReferencedType_ref);
			return p_ReferencedType_ref;
		}

		//
		// create syntax tree node associated with production
		// ReferencedType: SelectionType

		//

		public ReferencedType ReferencedType_3 (SelectionType p_SelectionType)
		{
			ReferencedType p_ReferencedType_ref = new ReferencedType(p_SelectionType);
			p_SelectionType.parent = p_ReferencedType_ref;
			Raise_ReferencedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ReferencedType.production_kind.g_ReferencedType_3, p_ReferencedType_ref);
			return p_ReferencedType_ref;
		}

		//
		// create syntax tree node associated with production
		// ReferencedType: TypeFromObject

		//

		public ReferencedType ReferencedType_4 (TypeFromObject p_TypeFromObject)
		{
			ReferencedType p_ReferencedType_ref = new ReferencedType(p_TypeFromObject);
			p_TypeFromObject.parent = p_ReferencedType_ref;
			Raise_ReferencedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ReferencedType.production_kind.g_ReferencedType_4, p_ReferencedType_ref);
			return p_ReferencedType_ref;
		}

		//
		// create syntax tree node associated with production
		// ReferencedType: ValueSetFromObjects

		//

		public ReferencedType ReferencedType_5 (ValueSetFromObjects p_ValueSetFromObjects)
		{
			ReferencedType p_ReferencedType_ref = new ReferencedType(p_ValueSetFromObjects);
			p_ValueSetFromObjects.parent = p_ReferencedType_ref;
			Raise_ReferencedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ReferencedType.production_kind.g_ReferencedType_5, p_ReferencedType_ref);
			return p_ReferencedType_ref;
		}
		#endregion
	};
}
