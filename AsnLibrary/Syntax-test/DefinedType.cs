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
	// class associated with syntax rule DefinedType
	//

	[DataContract]
	public class	DefinedType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinedType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinedType
		{
			g_DefinedType_1 = 1,	// ExternalTypeReference

			g_DefinedType_2 = 2,	// typereference-token

			g_DefinedType_3 = 3,	// ParameterizedType

			g_DefinedType_4 = 4,	// ParameterizedValueSetType

		};
		#endregion
		#region production markers associated with the syntax rule DefinedType

		// markers associated with production: DefinedType -> ExternalTypeReference

		public enum production_marker_1 : ushort
		{
			m_ExternalTypeReference,
			final
		};

		// markers associated with production: DefinedType -> typereference-token

		public enum production_marker_2 : ushort
		{
			m_typereference_token,
			final
		};

		// markers associated with production: DefinedType -> ParameterizedType

		public enum production_marker_3 : ushort
		{
			m_ParameterizedType,
			final
		};

		// markers associated with production: DefinedType -> ParameterizedValueSetType

		public enum production_marker_4 : ushort
		{
			m_ParameterizedValueSetType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinedType

		// Constructor declaration(s) associated with production(s) of syntax rule DefinedType

		//
		// Constructor associated with the following production(s)
		// DefinedType -> ExternalTypeReference

		//

		public DefinedType (ExternalTypeReference p_ExternalTypeReference) : base ((uint) ProductionID._DefinedType_ID, (uint) production_kind.g_DefinedType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExternalTypeReference = p_ExternalTypeReference;
		}

		//
		// Constructor associated with the following production(s)
		// DefinedType -> typereference-token

		//

		public DefinedType (typereference_token p_typereference_token) : base ((uint) ProductionID._DefinedType_ID, (uint) production_kind.g_DefinedType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_typereference_token = p_typereference_token;
		}

		//
		// Constructor associated with the following production(s)
		// DefinedType -> ParameterizedType

		//

		public DefinedType (ParameterizedType p_ParameterizedType) : base ((uint) ProductionID._DefinedType_ID, (uint) production_kind.g_DefinedType_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedType = p_ParameterizedType;
		}

		//
		// Constructor associated with the following production(s)
		// DefinedType -> ParameterizedValueSetType

		//

		public DefinedType (ParameterizedValueSetType p_ParameterizedValueSetType) : base ((uint) ProductionID._DefinedType_ID, (uint) production_kind.g_DefinedType_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedValueSetType = p_ParameterizedValueSetType;
		}

		public DefinedType () { }

		// Copy constructor

		public DefinedType (DefinedType p_DefinedType) : base (p_DefinedType.id, p_DefinedType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinedType.appInfo;
			switch ((production_kind) p_DefinedType.kind)
			{
				case production_kind.g_DefinedType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExternalTypeReference = (p_DefinedType.m_ExternalTypeReference != null) ? new ExternalTypeReference (p_DefinedType.m_ExternalTypeReference) : null) != null) m_ExternalTypeReference.parent = this;
					break;
				case production_kind.g_DefinedType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_typereference_token = (p_DefinedType.m_typereference_token != null) ? new typereference_token (p_DefinedType.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					break;
				case production_kind.g_DefinedType_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedType = (p_DefinedType.m_ParameterizedType != null) ? new ParameterizedType (p_DefinedType.m_ParameterizedType) : null) != null) m_ParameterizedType.parent = this;
					break;
				case production_kind.g_DefinedType_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedValueSetType = (p_DefinedType.m_ParameterizedValueSetType != null) ? new ParameterizedValueSetType (p_DefinedType.m_ParameterizedValueSetType) : null) != null) m_ParameterizedValueSetType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinedType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ExternalTypeReference?.Dispose ();
			m_typereference_token?.Dispose ();
			m_ParameterizedType?.Dispose ();
			m_ParameterizedValueSetType?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinedType

		// Content changing function(s) associated with production(s) of syntax rule DefinedType

		//
		// Content changing function associated with following production(s)
		// DefinedType -> ExternalTypeReference

		//

		public void change(ExternalTypeReference p_ExternalTypeReference)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExternalTypeReference = p_ExternalTypeReference;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinedType -> typereference-token

		//

		public void change(typereference_token p_typereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_typereference_token = p_typereference_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinedType -> ParameterizedType

		//

		public void change(ParameterizedType p_ParameterizedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedType_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedType = p_ParameterizedType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinedType -> ParameterizedValueSetType

		//

		public void change(ParameterizedValueSetType p_ParameterizedValueSetType)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedType_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedValueSetType = p_ParameterizedValueSetType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinedType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ExternalTypeReference != null) && m_ExternalTypeReference.checkInclusion (element) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				(m_ParameterizedType != null) && m_ParameterizedType.checkInclusion (element) ||
				(m_ParameterizedValueSetType != null) && m_ParameterizedValueSetType.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinedType

		//
		// emit production tree node associated with any production of syntax rule DefinedType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinedType_1:
					// emit syntax tree node associated with production
					// DefinedType: ExternalTypeReference

					s += m_ExternalTypeReference.Emit (depth - 1);
				break;
				case production_kind.g_DefinedType_2:
					// emit syntax tree node associated with production
					// DefinedType: typereference-token

					s += m_typereference_token.Emit (depth - 1);
				break;
				case production_kind.g_DefinedType_3:
					// emit syntax tree node associated with production
					// DefinedType: ParameterizedType

					s += m_ParameterizedType.Emit (depth - 1);
				break;
				case production_kind.g_DefinedType_4:
					// emit syntax tree node associated with production
					// DefinedType: ParameterizedValueSetType

					s += m_ParameterizedValueSetType.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinedType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinedType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinedType_1:
					// emit syntax tree node associated with production
					// DefinedType: ExternalTypeReference

					s += m_ExternalTypeReference.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinedType_2:
					// emit syntax tree node associated with production
					// DefinedType: typereference-token

					s += m_typereference_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinedType_3:
					// emit syntax tree node associated with production
					// DefinedType: ParameterizedType

					s += m_ParameterizedType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinedType_4:
					// emit syntax tree node associated with production
					// DefinedType: ParameterizedValueSetType

					s += m_ParameterizedValueSetType.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinedType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinedType.production_kind kind = (DefinedType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinedType.production_kind.g_DefinedType_1:
					// traverse syntax tree node associated with production
					// DefinedType: ExternalTypeReference

						m_ExternalTypeReference.Visit (visitor, appData);
				break;
				case DefinedType.production_kind.g_DefinedType_2:
					// traverse syntax tree node associated with production
					// DefinedType: typereference-token

						m_typereference_token.Visit (visitor, appData);
				break;
				case DefinedType.production_kind.g_DefinedType_3:
					// traverse syntax tree node associated with production
					// DefinedType: ParameterizedType

						m_ParameterizedType.Visit (visitor, appData);
				break;
				case DefinedType.production_kind.g_DefinedType_4:
					// traverse syntax tree node associated with production
					// DefinedType: ParameterizedValueSetType

						m_ParameterizedValueSetType.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ExternalTypeReference?.reparent (this);
			m_typereference_token?.reparent (this);
			m_ParameterizedType?.reparent (this);
			m_ParameterizedValueSetType?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefinedType
		//

		public void _init ()
		{
			m_ExternalTypeReference = null;
			m_typereference_token = null;
			m_ParameterizedType = null;
			m_ParameterizedValueSetType = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinedType

		// counter of all nodes associated with syntax rule DefinedType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinedType
		[DataMember (Name = "m_ExternalTypeReference")] public ExternalTypeReference m_ExternalTypeReference { get; private set; }
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		[DataMember (Name = "m_ParameterizedType")] public ParameterizedType m_ParameterizedType { get; private set; }
		[DataMember (Name = "m_ParameterizedValueSetType")] public ParameterizedValueSetType m_ParameterizedValueSetType { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinedType

		// delegate function (callback) prototype associated with syntax rule DefinedType
		public delegate bool DefinedType_Callback (SyntaxTreeCallbackReason reason, DefinedType.production_kind kind, DefinedType p_DefinedType);

		// event associated with syntax rule DefinedType
		public event DefinedType_Callback DefinedType_Event;

		// event trigger associated with syntax rule DefinedType
		public bool Raise_DefinedType_Event (SyntaxTreeCallbackReason reason, DefinedType.production_kind kind, DefinedType p_DefinedType)
		{
			bool? status = DefinedType_Event?.Invoke (reason, kind, p_DefinedType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinedType
		//
		// traverse syntax tree node associated with any production of syntax rule DefinedType
		//

		public void Traverse (DefinedType p_DefinedType)
		{
			if (p_DefinedType.isLocked())
				return;
			p_DefinedType.dolock();
			DefinedType.production_kind kind = (DefinedType.production_kind) p_DefinedType.kind;
			p_DefinedType.turn_reset ();
			if (Raise_DefinedType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinedType))
			switch (kind)
			{
				case DefinedType.production_kind.g_DefinedType_1:
					// traverse syntax tree node associated with production
					// DefinedType: ExternalTypeReference

					if (Raise_DefinedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedType))
						Traverse (p_DefinedType.m_ExternalTypeReference);
					p_DefinedType.turn_inc ();
					Raise_DefinedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedType);
				break;
				case DefinedType.production_kind.g_DefinedType_2:
					// traverse syntax tree node associated with production
					// DefinedType: typereference-token

					if (Raise_DefinedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedType))
						Traverse (p_DefinedType.m_typereference_token);
					p_DefinedType.turn_inc ();
					Raise_DefinedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedType);
				break;
				case DefinedType.production_kind.g_DefinedType_3:
					// traverse syntax tree node associated with production
					// DefinedType: ParameterizedType

					if (Raise_DefinedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedType))
						Traverse (p_DefinedType.m_ParameterizedType);
					p_DefinedType.turn_inc ();
					Raise_DefinedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedType);
				break;
				case DefinedType.production_kind.g_DefinedType_4:
					// traverse syntax tree node associated with production
					// DefinedType: ParameterizedValueSetType

					if (Raise_DefinedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedType))
						Traverse (p_DefinedType.m_ParameterizedValueSetType);
					p_DefinedType.turn_inc ();
					Raise_DefinedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedType);
				break;
			}
			Raise_DefinedType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinedType);
			p_DefinedType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedType
		//

		public void TraverseCommon (DefinedType p_DefinedType)
		{
			DefinedType.production_kind kind = (DefinedType.production_kind) p_DefinedType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinedType))
			switch (kind)
			{
				case DefinedType.production_kind.g_DefinedType_1:
					// traverse syntax tree node associated with production
					// DefinedType: ExternalTypeReference

						TraverseCommon (p_DefinedType.m_ExternalTypeReference);
				break;
				case DefinedType.production_kind.g_DefinedType_2:
					// traverse syntax tree node associated with production
					// DefinedType: typereference-token

						TraverseCommon (p_DefinedType.m_typereference_token);
				break;
				case DefinedType.production_kind.g_DefinedType_3:
					// traverse syntax tree node associated with production
					// DefinedType: ParameterizedType

						TraverseCommon (p_DefinedType.m_ParameterizedType);
				break;
				case DefinedType.production_kind.g_DefinedType_4:
					// traverse syntax tree node associated with production
					// DefinedType: ParameterizedValueSetType

						TraverseCommon (p_DefinedType.m_ParameterizedValueSetType);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinedType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinedType

		//
		// create syntax tree node associated with production
		// DefinedType: ExternalTypeReference

		//

		public DefinedType DefinedType_1 (ExternalTypeReference p_ExternalTypeReference)
		{
			DefinedType p_DefinedType_ref = new DefinedType(p_ExternalTypeReference);
			p_ExternalTypeReference.parent = p_DefinedType_ref;
			Raise_DefinedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedType.production_kind.g_DefinedType_1, p_DefinedType_ref);
			return p_DefinedType_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinedType: typereference-token

		//

		public DefinedType DefinedType_2 (typereference_token p_typereference_token)
		{
			DefinedType p_DefinedType_ref = new DefinedType(p_typereference_token);
			p_typereference_token.parent = p_DefinedType_ref;
			Raise_DefinedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedType.production_kind.g_DefinedType_2, p_DefinedType_ref);
			return p_DefinedType_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinedType: ParameterizedType

		//

		public DefinedType DefinedType_3 (ParameterizedType p_ParameterizedType)
		{
			DefinedType p_DefinedType_ref = new DefinedType(p_ParameterizedType);
			p_ParameterizedType.parent = p_DefinedType_ref;
			Raise_DefinedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedType.production_kind.g_DefinedType_3, p_DefinedType_ref);
			return p_DefinedType_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinedType: ParameterizedValueSetType

		//

		public DefinedType DefinedType_4 (ParameterizedValueSetType p_ParameterizedValueSetType)
		{
			DefinedType p_DefinedType_ref = new DefinedType(p_ParameterizedValueSetType);
			p_ParameterizedValueSetType.parent = p_DefinedType_ref;
			Raise_DefinedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedType.production_kind.g_DefinedType_4, p_DefinedType_ref);
			return p_DefinedType_ref;
		}
		#endregion
	};
}
