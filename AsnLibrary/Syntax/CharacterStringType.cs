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
	// class associated with syntax rule CharacterStringType
	//

	[DataContract]
	public class	CharacterStringType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule CharacterStringType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule CharacterStringType
		{
			g_CharacterStringType_1 = 1,	// RestrictedCharacterStringType

			g_CharacterStringType_2 = 2,	// UnrestrictedCharacterStringType

		};
		#endregion
		#region production markers associated with the syntax rule CharacterStringType

		// markers associated with production: CharacterStringType -> RestrictedCharacterStringType

		public enum production_marker_1 : ushort
		{
			m_RestrictedCharacterStringType,
			final
		};

		// markers associated with production: CharacterStringType -> UnrestrictedCharacterStringType

		public enum production_marker_2 : ushort
		{
			m_UnrestrictedCharacterStringType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule CharacterStringType

		// Constructor declaration(s) associated with production(s) of syntax rule CharacterStringType

		//
		// Constructor associated with the following production(s)
		// CharacterStringType -> RestrictedCharacterStringType

		//

		public CharacterStringType (RestrictedCharacterStringType p_RestrictedCharacterStringType) : base ((uint) ProductionID._CharacterStringType_ID, (uint) production_kind.g_CharacterStringType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RestrictedCharacterStringType = p_RestrictedCharacterStringType;
		}

		//
		// Constructor associated with the following production(s)
		// CharacterStringType -> UnrestrictedCharacterStringType

		//

		public CharacterStringType (UnrestrictedCharacterStringType p_UnrestrictedCharacterStringType) : base ((uint) ProductionID._CharacterStringType_ID, (uint) production_kind.g_CharacterStringType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_UnrestrictedCharacterStringType = p_UnrestrictedCharacterStringType;
		}

		public CharacterStringType () { }

		// Copy constructor

		public CharacterStringType (CharacterStringType p_CharacterStringType) : base (p_CharacterStringType.id, p_CharacterStringType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_CharacterStringType.appInfo;
			switch ((production_kind) p_CharacterStringType.kind)
			{
				case production_kind.g_CharacterStringType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RestrictedCharacterStringType = (p_CharacterStringType.m_RestrictedCharacterStringType != null) ? new RestrictedCharacterStringType (p_CharacterStringType.m_RestrictedCharacterStringType) : null) != null) m_RestrictedCharacterStringType.parent = this;
					break;
				case production_kind.g_CharacterStringType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UnrestrictedCharacterStringType = (p_CharacterStringType.m_UnrestrictedCharacterStringType != null) ? new UnrestrictedCharacterStringType (p_CharacterStringType.m_UnrestrictedCharacterStringType) : null) != null) m_UnrestrictedCharacterStringType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "CharacterStringType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new CharacterStringType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_RestrictedCharacterStringType?.Dispose ();
			m_UnrestrictedCharacterStringType?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule CharacterStringType

		// Content changing function(s) associated with production(s) of syntax rule CharacterStringType

		//
		// Content changing function associated with following production(s)
		// CharacterStringType -> RestrictedCharacterStringType

		//

		public void change(RestrictedCharacterStringType p_RestrictedCharacterStringType)
		{
			_init ();
			this.kind = (uint) production_kind.g_CharacterStringType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RestrictedCharacterStringType = p_RestrictedCharacterStringType;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// CharacterStringType -> UnrestrictedCharacterStringType

		//

		public void change(UnrestrictedCharacterStringType p_UnrestrictedCharacterStringType)
		{
			_init ();
			this.kind = (uint) production_kind.g_CharacterStringType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_UnrestrictedCharacterStringType = p_UnrestrictedCharacterStringType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule CharacterStringType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_RestrictedCharacterStringType != null) && m_RestrictedCharacterStringType.checkInclusion (element) ||
				(m_UnrestrictedCharacterStringType != null) && m_UnrestrictedCharacterStringType.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule CharacterStringType

		//
		// emit production tree node associated with any production of syntax rule CharacterStringType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_CharacterStringType_1:
					// emit syntax tree node associated with production
					// CharacterStringType: RestrictedCharacterStringType

					s += m_RestrictedCharacterStringType.Emit (depth - 1);
				break;
				case production_kind.g_CharacterStringType_2:
					// emit syntax tree node associated with production
					// CharacterStringType: UnrestrictedCharacterStringType

					s += m_UnrestrictedCharacterStringType.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule CharacterStringType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "CharacterStringType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_CharacterStringType_1:
					// emit syntax tree node associated with production
					// CharacterStringType: RestrictedCharacterStringType

					s += m_RestrictedCharacterStringType.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_CharacterStringType_2:
					// emit syntax tree node associated with production
					// CharacterStringType: UnrestrictedCharacterStringType

					s += m_UnrestrictedCharacterStringType.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule CharacterStringType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule CharacterStringType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			CharacterStringType.production_kind kind = (CharacterStringType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case CharacterStringType.production_kind.g_CharacterStringType_1:
					// traverse syntax tree node associated with production
					// CharacterStringType: RestrictedCharacterStringType

						m_RestrictedCharacterStringType.Visit (visitor, appData);
				break;
				case CharacterStringType.production_kind.g_CharacterStringType_2:
					// traverse syntax tree node associated with production
					// CharacterStringType: UnrestrictedCharacterStringType

						m_UnrestrictedCharacterStringType.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_RestrictedCharacterStringType?.reparent (this);
			m_UnrestrictedCharacterStringType?.reparent (this);
		}

		//
		// initialize object associated with syntax rule CharacterStringType
		//

		public void _init ()
		{
			m_RestrictedCharacterStringType = null;
			m_UnrestrictedCharacterStringType = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule CharacterStringType

		// counter of all nodes associated with syntax rule CharacterStringType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule CharacterStringType
		[DataMember (Name = "m_RestrictedCharacterStringType")] public RestrictedCharacterStringType m_RestrictedCharacterStringType { get; private set; }
		[DataMember (Name = "m_UnrestrictedCharacterStringType")] public UnrestrictedCharacterStringType m_UnrestrictedCharacterStringType { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule CharacterStringType

		// delegate function (callback) prototype associated with syntax rule CharacterStringType
		public delegate bool CharacterStringType_Callback (SyntaxTreeCallbackReason reason, CharacterStringType.production_kind kind, CharacterStringType p_CharacterStringType);

		// event associated with syntax rule CharacterStringType
		public event CharacterStringType_Callback CharacterStringType_Event;

		// event trigger associated with syntax rule CharacterStringType
		public bool Raise_CharacterStringType_Event (SyntaxTreeCallbackReason reason, CharacterStringType.production_kind kind, CharacterStringType p_CharacterStringType)
		{
			bool? status = CharacterStringType_Event?.Invoke (reason, kind, p_CharacterStringType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule CharacterStringType
		//
		// traverse syntax tree node associated with any production of syntax rule CharacterStringType
		//

		public void Traverse (CharacterStringType p_CharacterStringType)
		{
			if (p_CharacterStringType.isLocked())
				return;
			p_CharacterStringType.dolock();
			CharacterStringType.production_kind kind = (CharacterStringType.production_kind) p_CharacterStringType.kind;
			p_CharacterStringType.turn_reset ();
			if (Raise_CharacterStringType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_CharacterStringType))
			switch (kind)
			{
				case CharacterStringType.production_kind.g_CharacterStringType_1:
					// traverse syntax tree node associated with production
					// CharacterStringType: RestrictedCharacterStringType

					if (Raise_CharacterStringType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharacterStringType))
						Traverse (p_CharacterStringType.m_RestrictedCharacterStringType);
					p_CharacterStringType.turn_inc ();
					Raise_CharacterStringType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharacterStringType);
				break;
				case CharacterStringType.production_kind.g_CharacterStringType_2:
					// traverse syntax tree node associated with production
					// CharacterStringType: UnrestrictedCharacterStringType

					if (Raise_CharacterStringType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharacterStringType))
						Traverse (p_CharacterStringType.m_UnrestrictedCharacterStringType);
					p_CharacterStringType.turn_inc ();
					Raise_CharacterStringType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharacterStringType);
				break;
			}
			Raise_CharacterStringType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_CharacterStringType);
			p_CharacterStringType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule CharacterStringType
		//

		public void TraverseCommon (CharacterStringType p_CharacterStringType)
		{
			CharacterStringType.production_kind kind = (CharacterStringType.production_kind) p_CharacterStringType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_CharacterStringType))
			switch (kind)
			{
				case CharacterStringType.production_kind.g_CharacterStringType_1:
					// traverse syntax tree node associated with production
					// CharacterStringType: RestrictedCharacterStringType

						TraverseCommon (p_CharacterStringType.m_RestrictedCharacterStringType);
				break;
				case CharacterStringType.production_kind.g_CharacterStringType_2:
					// traverse syntax tree node associated with production
					// CharacterStringType: UnrestrictedCharacterStringType

						TraverseCommon (p_CharacterStringType.m_UnrestrictedCharacterStringType);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_CharacterStringType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule CharacterStringType

		//
		// create syntax tree node associated with production
		// CharacterStringType: RestrictedCharacterStringType

		//

		public CharacterStringType CharacterStringType_1 (RestrictedCharacterStringType p_RestrictedCharacterStringType)
		{
			CharacterStringType p_CharacterStringType_ref = new CharacterStringType(p_RestrictedCharacterStringType);
			p_RestrictedCharacterStringType.parent = p_CharacterStringType_ref;
			Raise_CharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, CharacterStringType.production_kind.g_CharacterStringType_1, p_CharacterStringType_ref);
			return p_CharacterStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// CharacterStringType: UnrestrictedCharacterStringType

		//

		public CharacterStringType CharacterStringType_2 (UnrestrictedCharacterStringType p_UnrestrictedCharacterStringType)
		{
			CharacterStringType p_CharacterStringType_ref = new CharacterStringType(p_UnrestrictedCharacterStringType);
			p_UnrestrictedCharacterStringType.parent = p_CharacterStringType_ref;
			Raise_CharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, CharacterStringType.production_kind.g_CharacterStringType_2, p_CharacterStringType_ref);
			return p_CharacterStringType_ref;
		}
		#endregion
	};
}
