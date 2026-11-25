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
	// class associated with syntax rule AltTypeOrNamedType
	//

	[DataContract]
	public class	AltTypeOrNamedType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AltTypeOrNamedType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AltTypeOrNamedType
		{
			g_AltTypeOrNamedType_1 = 1,	// TypeOrNamedType

		};
		#endregion
		#region production markers associated with the syntax rule AltTypeOrNamedType

		// markers associated with production: AltTypeOrNamedType -> TypeOrNamedType

		public enum production_marker_1 : ushort
		{
			m_TypeOrNamedType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AltTypeOrNamedType

		// Constructor declaration(s) associated with production(s) of syntax rule AltTypeOrNamedType

		//
		// Constructor associated with the following production(s)
		// AltTypeOrNamedType -> TypeOrNamedType

		//

		public AltTypeOrNamedType (TypeOrNamedType p_TypeOrNamedType) : base ((uint) ProductionID._AltTypeOrNamedType_ID, (uint) production_kind.g_AltTypeOrNamedType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TypeOrNamedType = p_TypeOrNamedType;
		}

		public AltTypeOrNamedType () { }

		// Copy constructor

		public AltTypeOrNamedType (AltTypeOrNamedType p_AltTypeOrNamedType) : base (p_AltTypeOrNamedType.id, p_AltTypeOrNamedType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AltTypeOrNamedType.appInfo;
			switch ((production_kind) p_AltTypeOrNamedType.kind)
			{
				case production_kind.g_AltTypeOrNamedType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TypeOrNamedType = (p_AltTypeOrNamedType.m_TypeOrNamedType != null) ? new TypeOrNamedType (p_AltTypeOrNamedType.m_TypeOrNamedType) : null) != null) m_TypeOrNamedType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AltTypeOrNamedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AltTypeOrNamedType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_TypeOrNamedType?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AltTypeOrNamedType

		// Content changing function(s) associated with production(s) of syntax rule AltTypeOrNamedType

		//
		// Content changing function associated with following production(s)
		// AltTypeOrNamedType -> TypeOrNamedType

		//

		public void change(TypeOrNamedType p_TypeOrNamedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_AltTypeOrNamedType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TypeOrNamedType = p_TypeOrNamedType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AltTypeOrNamedType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_TypeOrNamedType != null) && m_TypeOrNamedType.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AltTypeOrNamedType

		//
		// emit production tree node associated with any production of syntax rule AltTypeOrNamedType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AltTypeOrNamedType_1:
					// emit syntax tree node associated with production
					// AltTypeOrNamedType: TypeOrNamedType

					s += m_TypeOrNamedType.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AltTypeOrNamedType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AltTypeOrNamedType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AltTypeOrNamedType_1:
					// emit syntax tree node associated with production
					// AltTypeOrNamedType: TypeOrNamedType

					s += m_TypeOrNamedType.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AltTypeOrNamedType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AltTypeOrNamedType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AltTypeOrNamedType.production_kind kind = (AltTypeOrNamedType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AltTypeOrNamedType.production_kind.g_AltTypeOrNamedType_1:
					// traverse syntax tree node associated with production
					// AltTypeOrNamedType: TypeOrNamedType

						m_TypeOrNamedType.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_TypeOrNamedType?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AltTypeOrNamedType
		//

		public void _init ()
		{
			m_TypeOrNamedType = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AltTypeOrNamedType

		// counter of all nodes associated with syntax rule AltTypeOrNamedType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AltTypeOrNamedType
		[DataMember (Name = "m_TypeOrNamedType")] public TypeOrNamedType m_TypeOrNamedType { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AltTypeOrNamedType

		// delegate function (callback) prototype associated with syntax rule AltTypeOrNamedType
		public delegate bool AltTypeOrNamedType_Callback (SyntaxTreeCallbackReason reason, AltTypeOrNamedType.production_kind kind, AltTypeOrNamedType p_AltTypeOrNamedType);

		// event associated with syntax rule AltTypeOrNamedType
		public event AltTypeOrNamedType_Callback AltTypeOrNamedType_Event;

		// event trigger associated with syntax rule AltTypeOrNamedType
		public bool Raise_AltTypeOrNamedType_Event (SyntaxTreeCallbackReason reason, AltTypeOrNamedType.production_kind kind, AltTypeOrNamedType p_AltTypeOrNamedType)
		{
			bool? status = AltTypeOrNamedType_Event?.Invoke (reason, kind, p_AltTypeOrNamedType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AltTypeOrNamedType
		//
		// traverse syntax tree node associated with any production of syntax rule AltTypeOrNamedType
		//

		public void Traverse (AltTypeOrNamedType p_AltTypeOrNamedType)
		{
			if (p_AltTypeOrNamedType.isLocked())
				return;
			p_AltTypeOrNamedType.dolock();
			AltTypeOrNamedType.production_kind kind = (AltTypeOrNamedType.production_kind) p_AltTypeOrNamedType.kind;
			p_AltTypeOrNamedType.turn_reset ();
			if (Raise_AltTypeOrNamedType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AltTypeOrNamedType))
			switch (kind)
			{
				case AltTypeOrNamedType.production_kind.g_AltTypeOrNamedType_1:
					// traverse syntax tree node associated with production
					// AltTypeOrNamedType: TypeOrNamedType

					if (Raise_AltTypeOrNamedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AltTypeOrNamedType))
						Traverse (p_AltTypeOrNamedType.m_TypeOrNamedType);
					p_AltTypeOrNamedType.turn_inc ();
					Raise_AltTypeOrNamedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AltTypeOrNamedType);
				break;
			}
			Raise_AltTypeOrNamedType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AltTypeOrNamedType);
			p_AltTypeOrNamedType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AltTypeOrNamedType
		//

		public void TraverseCommon (AltTypeOrNamedType p_AltTypeOrNamedType)
		{
			AltTypeOrNamedType.production_kind kind = (AltTypeOrNamedType.production_kind) p_AltTypeOrNamedType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AltTypeOrNamedType))
			switch (kind)
			{
				case AltTypeOrNamedType.production_kind.g_AltTypeOrNamedType_1:
					// traverse syntax tree node associated with production
					// AltTypeOrNamedType: TypeOrNamedType

						TraverseCommon (p_AltTypeOrNamedType.m_TypeOrNamedType);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AltTypeOrNamedType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AltTypeOrNamedType

		//
		// create syntax tree node associated with production
		// AltTypeOrNamedType: TypeOrNamedType

		//

		public AltTypeOrNamedType AltTypeOrNamedType_1 (TypeOrNamedType p_TypeOrNamedType)
		{
			AltTypeOrNamedType p_AltTypeOrNamedType_ref = new AltTypeOrNamedType(p_TypeOrNamedType);
			p_TypeOrNamedType.parent = p_AltTypeOrNamedType_ref;
			Raise_AltTypeOrNamedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AltTypeOrNamedType.production_kind.g_AltTypeOrNamedType_1, p_AltTypeOrNamedType_ref);
			return p_AltTypeOrNamedType_ref;
		}
		#endregion
	};
}
