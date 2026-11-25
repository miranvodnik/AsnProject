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
	// class associated with syntax rule SequenceType
	//

	[DataContract]
	public class	SequenceType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SequenceType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SequenceType
		{
			g_SequenceType_1 = 1,	// SEQUENCE "{" ComponentTypeLists-optional "}"

		};
		#endregion
		#region production markers associated with the syntax rule SequenceType

		// markers associated with production: SequenceType -> SEQUENCE "{" ComponentTypeLists-optional "}"

		public enum production_marker_1 : ushort
		{
			m_ComponentTypeLists_optional,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SequenceType

		// Constructor declaration(s) associated with production(s) of syntax rule SequenceType

		//
		// Constructor associated with the following production(s)
		// SequenceType -> SEQUENCE "{" ComponentTypeLists-optional "}"

		//

		public SequenceType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, ComponentTypeLists_optional p_ComponentTypeLists_optional, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._SequenceType_ID, (uint) production_kind.g_SequenceType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_SEQUENCE = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_ComponentTypeLists_optional = p_ComponentTypeLists_optional;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		public SequenceType () { }

		// Copy constructor

		public SequenceType (SequenceType p_SequenceType) : base (p_SequenceType.id, p_SequenceType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SequenceType.appInfo;
			switch ((production_kind) p_SequenceType.kind)
			{
				case production_kind.g_SequenceType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_SEQUENCE = (p_SequenceType.m_SEQUENCE != null) ? new SyntaxTreeToken (p_SequenceType.m_SEQUENCE) : null) != null) m_SEQUENCE.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_SequenceType.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_SequenceType.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_ComponentTypeLists_optional = (p_SequenceType.m_ComponentTypeLists_optional != null) ? new ComponentTypeLists_optional (p_SequenceType.m_ComponentTypeLists_optional) : null) != null) m_ComponentTypeLists_optional.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_SequenceType.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_SequenceType.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SequenceType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SequenceType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SEQUENCE?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_ComponentTypeLists_optional?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SequenceType

		// Content changing function(s) associated with production(s) of syntax rule SequenceType

		//
		// Content changing function associated with following production(s)
		// SequenceType -> SEQUENCE "{" ComponentTypeLists-optional "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, ComponentTypeLists_optional p_ComponentTypeLists_optional, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_SequenceType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_SEQUENCE = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_ComponentTypeLists_optional = p_ComponentTypeLists_optional;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SequenceType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SEQUENCE != null) && m_SEQUENCE.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_ComponentTypeLists_optional != null) && m_ComponentTypeLists_optional.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SequenceType

		//
		// emit production tree node associated with any production of syntax rule SequenceType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SequenceType_1:
					// emit syntax tree node associated with production
					// SequenceType: SEQUENCE "{" ComponentTypeLists-optional "}"

					s += m_SEQUENCE.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_ComponentTypeLists_optional.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SequenceType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SequenceType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SequenceType_1:
					// emit syntax tree node associated with production
					// SequenceType: SEQUENCE "{" ComponentTypeLists-optional "}"

					s += "SEQUENCE";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_ComponentTypeLists_optional.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SequenceType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SequenceType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SequenceType.production_kind kind = (SequenceType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SequenceType.production_kind.g_SequenceType_1:
					// traverse syntax tree node associated with production
					// SequenceType: SEQUENCE "{" ComponentTypeLists-optional "}"

						m_SEQUENCE.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_ComponentTypeLists_optional.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SEQUENCE?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_ComponentTypeLists_optional?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SequenceType
		//

		public void _init ()
		{
			m_SEQUENCE = null;
			m_left_curly_bracket = null;
			m_ComponentTypeLists_optional = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SequenceType

		// counter of all nodes associated with syntax rule SequenceType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SequenceType
		[DataMember (Name = "m_SEQUENCE")] public SyntaxTreeToken m_SEQUENCE { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_ComponentTypeLists_optional")] public ComponentTypeLists_optional m_ComponentTypeLists_optional { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SequenceType

		// delegate function (callback) prototype associated with syntax rule SequenceType
		public delegate bool SequenceType_Callback (SyntaxTreeCallbackReason reason, SequenceType.production_kind kind, SequenceType p_SequenceType);

		// event associated with syntax rule SequenceType
		public event SequenceType_Callback SequenceType_Event;

		// event trigger associated with syntax rule SequenceType
		public bool Raise_SequenceType_Event (SyntaxTreeCallbackReason reason, SequenceType.production_kind kind, SequenceType p_SequenceType)
		{
			bool? status = SequenceType_Event?.Invoke (reason, kind, p_SequenceType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SequenceType
		//
		// traverse syntax tree node associated with any production of syntax rule SequenceType
		//

		public void Traverse (SequenceType p_SequenceType)
		{
			if (p_SequenceType.isLocked())
				return;
			p_SequenceType.dolock();
			SequenceType.production_kind kind = (SequenceType.production_kind) p_SequenceType.kind;
			p_SequenceType.turn_reset ();
			if (Raise_SequenceType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SequenceType))
			switch (kind)
			{
				case SequenceType.production_kind.g_SequenceType_1:
					// traverse syntax tree node associated with production
					// SequenceType: SEQUENCE "{" ComponentTypeLists-optional "}"

					if (Raise_SequenceType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SequenceType))
						Traverse (p_SequenceType.m_ComponentTypeLists_optional);
					p_SequenceType.turn_inc ();
					Raise_SequenceType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SequenceType);
				break;
			}
			Raise_SequenceType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SequenceType);
			p_SequenceType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SequenceType
		//

		public void TraverseCommon (SequenceType p_SequenceType)
		{
			SequenceType.production_kind kind = (SequenceType.production_kind) p_SequenceType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SequenceType))
			switch (kind)
			{
				case SequenceType.production_kind.g_SequenceType_1:
					// traverse syntax tree node associated with production
					// SequenceType: SEQUENCE "{" ComponentTypeLists-optional "}"

						TraverseCommon (p_SequenceType.m_SEQUENCE);
						TraverseCommon (p_SequenceType.m_left_curly_bracket);
						TraverseCommon (p_SequenceType.m_ComponentTypeLists_optional);
						TraverseCommon (p_SequenceType.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SequenceType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SequenceType

		//
		// create syntax tree node associated with production
		// SequenceType: SEQUENCE "{" ComponentTypeLists-optional "}"

		//

		public SequenceType SequenceType_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, ComponentTypeLists_optional p_ComponentTypeLists_optional, SyntaxTreeToken p_token_2)
		{
			SequenceType p_SequenceType_ref = new SequenceType(p_token, p_token_1, p_ComponentTypeLists_optional, p_token_2);
			p_token.parent = p_SequenceType_ref;
			p_token_1.parent = p_SequenceType_ref;
			p_ComponentTypeLists_optional.parent = p_SequenceType_ref;
			p_token_2.parent = p_SequenceType_ref;
			Raise_SequenceType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SequenceType.production_kind.g_SequenceType_1, p_SequenceType_ref);
			return p_SequenceType_ref;
		}
		#endregion
	};
}
