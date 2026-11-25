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
	// class associated with syntax rule PrefixedType
	//

	[DataContract]
	public class	PrefixedType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule PrefixedType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule PrefixedType
		{
			g_PrefixedType_1 = 1,	// TaggedType

			g_PrefixedType_2 = 2,	// EncodingPrefixedType

		};
		#endregion
		#region production markers associated with the syntax rule PrefixedType

		// markers associated with production: PrefixedType -> TaggedType

		public enum production_marker_1 : ushort
		{
			m_TaggedType,
			final
		};

		// markers associated with production: PrefixedType -> EncodingPrefixedType

		public enum production_marker_2 : ushort
		{
			m_EncodingPrefixedType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule PrefixedType

		// Constructor declaration(s) associated with production(s) of syntax rule PrefixedType

		//
		// Constructor associated with the following production(s)
		// PrefixedType -> TaggedType

		//

		public PrefixedType (TaggedType p_TaggedType) : base ((uint) ProductionID._PrefixedType_ID, (uint) production_kind.g_PrefixedType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TaggedType = p_TaggedType;
		}

		//
		// Constructor associated with the following production(s)
		// PrefixedType -> EncodingPrefixedType

		//

		public PrefixedType (EncodingPrefixedType p_EncodingPrefixedType) : base ((uint) ProductionID._PrefixedType_ID, (uint) production_kind.g_PrefixedType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EncodingPrefixedType = p_EncodingPrefixedType;
		}

		public PrefixedType () { }

		// Copy constructor

		public PrefixedType (PrefixedType p_PrefixedType) : base (p_PrefixedType.id, p_PrefixedType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_PrefixedType.appInfo;
			switch ((production_kind) p_PrefixedType.kind)
			{
				case production_kind.g_PrefixedType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TaggedType = (p_PrefixedType.m_TaggedType != null) ? new TaggedType (p_PrefixedType.m_TaggedType) : null) != null) m_TaggedType.parent = this;
					break;
				case production_kind.g_PrefixedType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EncodingPrefixedType = (p_PrefixedType.m_EncodingPrefixedType != null) ? new EncodingPrefixedType (p_PrefixedType.m_EncodingPrefixedType) : null) != null) m_EncodingPrefixedType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "PrefixedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new PrefixedType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_TaggedType?.Dispose ();
			m_EncodingPrefixedType?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule PrefixedType

		// Content changing function(s) associated with production(s) of syntax rule PrefixedType

		//
		// Content changing function associated with following production(s)
		// PrefixedType -> TaggedType

		//

		public void change(TaggedType p_TaggedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_PrefixedType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TaggedType = p_TaggedType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// PrefixedType -> EncodingPrefixedType

		//

		public void change(EncodingPrefixedType p_EncodingPrefixedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_PrefixedType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EncodingPrefixedType = p_EncodingPrefixedType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule PrefixedType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_TaggedType != null) && m_TaggedType.checkInclusion (element) ||
				(m_EncodingPrefixedType != null) && m_EncodingPrefixedType.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule PrefixedType

		//
		// emit production tree node associated with any production of syntax rule PrefixedType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_PrefixedType_1:
					// emit syntax tree node associated with production
					// PrefixedType: TaggedType

					s += m_TaggedType.Emit (depth - 1);
				break;
				case production_kind.g_PrefixedType_2:
					// emit syntax tree node associated with production
					// PrefixedType: EncodingPrefixedType

					s += m_EncodingPrefixedType.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule PrefixedType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "PrefixedType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_PrefixedType_1:
					// emit syntax tree node associated with production
					// PrefixedType: TaggedType

					s += m_TaggedType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_PrefixedType_2:
					// emit syntax tree node associated with production
					// PrefixedType: EncodingPrefixedType

					s += m_EncodingPrefixedType.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule PrefixedType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule PrefixedType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			PrefixedType.production_kind kind = (PrefixedType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case PrefixedType.production_kind.g_PrefixedType_1:
					// traverse syntax tree node associated with production
					// PrefixedType: TaggedType

						m_TaggedType.Visit (visitor, appData);
				break;
				case PrefixedType.production_kind.g_PrefixedType_2:
					// traverse syntax tree node associated with production
					// PrefixedType: EncodingPrefixedType

						m_EncodingPrefixedType.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_TaggedType?.reparent (this);
			m_EncodingPrefixedType?.reparent (this);
		}

		//
		// initialize object associated with syntax rule PrefixedType
		//

		public void _init ()
		{
			m_TaggedType = null;
			m_EncodingPrefixedType = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule PrefixedType

		// counter of all nodes associated with syntax rule PrefixedType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule PrefixedType
		[DataMember (Name = "m_TaggedType")] public TaggedType m_TaggedType { get; private set; }
		[DataMember (Name = "m_EncodingPrefixedType")] public EncodingPrefixedType m_EncodingPrefixedType { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule PrefixedType

		// delegate function (callback) prototype associated with syntax rule PrefixedType
		public delegate bool PrefixedType_Callback (SyntaxTreeCallbackReason reason, PrefixedType.production_kind kind, PrefixedType p_PrefixedType);

		// event associated with syntax rule PrefixedType
		public event PrefixedType_Callback PrefixedType_Event;

		// event trigger associated with syntax rule PrefixedType
		public bool Raise_PrefixedType_Event (SyntaxTreeCallbackReason reason, PrefixedType.production_kind kind, PrefixedType p_PrefixedType)
		{
			bool? status = PrefixedType_Event?.Invoke (reason, kind, p_PrefixedType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule PrefixedType
		//
		// traverse syntax tree node associated with any production of syntax rule PrefixedType
		//

		public void Traverse (PrefixedType p_PrefixedType)
		{
			if (p_PrefixedType.isLocked())
				return;
			p_PrefixedType.dolock();
			PrefixedType.production_kind kind = (PrefixedType.production_kind) p_PrefixedType.kind;
			p_PrefixedType.turn_reset ();
			if (Raise_PrefixedType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_PrefixedType))
			switch (kind)
			{
				case PrefixedType.production_kind.g_PrefixedType_1:
					// traverse syntax tree node associated with production
					// PrefixedType: TaggedType

					if (Raise_PrefixedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrefixedType))
						Traverse (p_PrefixedType.m_TaggedType);
					p_PrefixedType.turn_inc ();
					Raise_PrefixedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrefixedType);
				break;
				case PrefixedType.production_kind.g_PrefixedType_2:
					// traverse syntax tree node associated with production
					// PrefixedType: EncodingPrefixedType

					if (Raise_PrefixedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrefixedType))
						Traverse (p_PrefixedType.m_EncodingPrefixedType);
					p_PrefixedType.turn_inc ();
					Raise_PrefixedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrefixedType);
				break;
			}
			Raise_PrefixedType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_PrefixedType);
			p_PrefixedType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule PrefixedType
		//

		public void TraverseCommon (PrefixedType p_PrefixedType)
		{
			PrefixedType.production_kind kind = (PrefixedType.production_kind) p_PrefixedType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_PrefixedType))
			switch (kind)
			{
				case PrefixedType.production_kind.g_PrefixedType_1:
					// traverse syntax tree node associated with production
					// PrefixedType: TaggedType

						TraverseCommon (p_PrefixedType.m_TaggedType);
				break;
				case PrefixedType.production_kind.g_PrefixedType_2:
					// traverse syntax tree node associated with production
					// PrefixedType: EncodingPrefixedType

						TraverseCommon (p_PrefixedType.m_EncodingPrefixedType);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_PrefixedType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule PrefixedType

		//
		// create syntax tree node associated with production
		// PrefixedType: TaggedType

		//

		public PrefixedType PrefixedType_1 (TaggedType p_TaggedType)
		{
			PrefixedType p_PrefixedType_ref = new PrefixedType(p_TaggedType);
			p_TaggedType.parent = p_PrefixedType_ref;
			Raise_PrefixedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PrefixedType.production_kind.g_PrefixedType_1, p_PrefixedType_ref);
			return p_PrefixedType_ref;
		}

		//
		// create syntax tree node associated with production
		// PrefixedType: EncodingPrefixedType

		//

		public PrefixedType PrefixedType_2 (EncodingPrefixedType p_EncodingPrefixedType)
		{
			PrefixedType p_PrefixedType_ref = new PrefixedType(p_EncodingPrefixedType);
			p_EncodingPrefixedType.parent = p_PrefixedType_ref;
			Raise_PrefixedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PrefixedType.production_kind.g_PrefixedType_2, p_PrefixedType_ref);
			return p_PrefixedType_ref;
		}
		#endregion
	};
}
