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
	// class associated with syntax rule ChoiceType
	//

	[DataContract]
	public class	ChoiceType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ChoiceType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ChoiceType
		{
			g_ChoiceType_1 = 1,	// CHOICE "{" AlternativeTypeLists "}"

		};
		#endregion
		#region production markers associated with the syntax rule ChoiceType

		// markers associated with production: ChoiceType -> CHOICE "{" AlternativeTypeLists "}"

		public enum production_marker_1 : ushort
		{
			m_AlternativeTypeLists,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ChoiceType

		// Constructor declaration(s) associated with production(s) of syntax rule ChoiceType

		//
		// Constructor associated with the following production(s)
		// ChoiceType -> CHOICE "{" AlternativeTypeLists "}"

		//

		public ChoiceType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, AlternativeTypeLists p_AlternativeTypeLists, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._ChoiceType_ID, (uint) production_kind.g_ChoiceType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_CHOICE = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_AlternativeTypeLists = p_AlternativeTypeLists;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		public ChoiceType () { }

		// Copy constructor

		public ChoiceType (ChoiceType p_ChoiceType) : base (p_ChoiceType.id, p_ChoiceType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ChoiceType.appInfo;
			switch ((production_kind) p_ChoiceType.kind)
			{
				case production_kind.g_ChoiceType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_CHOICE = (p_ChoiceType.m_CHOICE != null) ? new SyntaxTreeToken (p_ChoiceType.m_CHOICE) : null) != null) m_CHOICE.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_ChoiceType.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_ChoiceType.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_AlternativeTypeLists = (p_ChoiceType.m_AlternativeTypeLists != null) ? new AlternativeTypeLists (p_ChoiceType.m_AlternativeTypeLists) : null) != null) m_AlternativeTypeLists.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_ChoiceType.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_ChoiceType.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ChoiceType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ChoiceType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_CHOICE?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_AlternativeTypeLists?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ChoiceType

		// Content changing function(s) associated with production(s) of syntax rule ChoiceType

		//
		// Content changing function associated with following production(s)
		// ChoiceType -> CHOICE "{" AlternativeTypeLists "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, AlternativeTypeLists p_AlternativeTypeLists, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_ChoiceType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_CHOICE = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_AlternativeTypeLists = p_AlternativeTypeLists;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ChoiceType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_CHOICE != null) && m_CHOICE.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_AlternativeTypeLists != null) && m_AlternativeTypeLists.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ChoiceType

		//
		// emit production tree node associated with any production of syntax rule ChoiceType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ChoiceType_1:
					// emit syntax tree node associated with production
					// ChoiceType: CHOICE "{" AlternativeTypeLists "}"

					s += m_CHOICE.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_AlternativeTypeLists.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ChoiceType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ChoiceType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ChoiceType_1:
					// emit syntax tree node associated with production
					// ChoiceType: CHOICE "{" AlternativeTypeLists "}"

					s += "CHOICE";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_AlternativeTypeLists.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ChoiceType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ChoiceType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ChoiceType.production_kind kind = (ChoiceType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ChoiceType.production_kind.g_ChoiceType_1:
					// traverse syntax tree node associated with production
					// ChoiceType: CHOICE "{" AlternativeTypeLists "}"

						m_CHOICE.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_AlternativeTypeLists.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_CHOICE?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_AlternativeTypeLists?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ChoiceType
		//

		public void _init ()
		{
			m_CHOICE = null;
			m_left_curly_bracket = null;
			m_AlternativeTypeLists = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ChoiceType

		// counter of all nodes associated with syntax rule ChoiceType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ChoiceType
		[DataMember (Name = "m_CHOICE")] public SyntaxTreeToken m_CHOICE { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_AlternativeTypeLists")] public AlternativeTypeLists m_AlternativeTypeLists { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ChoiceType

		// delegate function (callback) prototype associated with syntax rule ChoiceType
		public delegate bool ChoiceType_Callback (SyntaxTreeCallbackReason reason, ChoiceType.production_kind kind, ChoiceType p_ChoiceType);

		// event associated with syntax rule ChoiceType
		public event ChoiceType_Callback ChoiceType_Event;

		// event trigger associated with syntax rule ChoiceType
		public bool Raise_ChoiceType_Event (SyntaxTreeCallbackReason reason, ChoiceType.production_kind kind, ChoiceType p_ChoiceType)
		{
			bool? status = ChoiceType_Event?.Invoke (reason, kind, p_ChoiceType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ChoiceType
		//
		// traverse syntax tree node associated with any production of syntax rule ChoiceType
		//

		public void Traverse (ChoiceType p_ChoiceType)
		{
			if (p_ChoiceType.isLocked())
				return;
			p_ChoiceType.dolock();
			ChoiceType.production_kind kind = (ChoiceType.production_kind) p_ChoiceType.kind;
			p_ChoiceType.turn_reset ();
			if (Raise_ChoiceType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ChoiceType))
			switch (kind)
			{
				case ChoiceType.production_kind.g_ChoiceType_1:
					// traverse syntax tree node associated with production
					// ChoiceType: CHOICE "{" AlternativeTypeLists "}"

					if (Raise_ChoiceType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ChoiceType))
						Traverse (p_ChoiceType.m_AlternativeTypeLists);
					p_ChoiceType.turn_inc ();
					Raise_ChoiceType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ChoiceType);
				break;
			}
			Raise_ChoiceType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ChoiceType);
			p_ChoiceType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ChoiceType
		//

		public void TraverseCommon (ChoiceType p_ChoiceType)
		{
			ChoiceType.production_kind kind = (ChoiceType.production_kind) p_ChoiceType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ChoiceType))
			switch (kind)
			{
				case ChoiceType.production_kind.g_ChoiceType_1:
					// traverse syntax tree node associated with production
					// ChoiceType: CHOICE "{" AlternativeTypeLists "}"

						TraverseCommon (p_ChoiceType.m_CHOICE);
						TraverseCommon (p_ChoiceType.m_left_curly_bracket);
						TraverseCommon (p_ChoiceType.m_AlternativeTypeLists);
						TraverseCommon (p_ChoiceType.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ChoiceType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ChoiceType

		//
		// create syntax tree node associated with production
		// ChoiceType: CHOICE "{" AlternativeTypeLists "}"

		//

		public ChoiceType ChoiceType_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, AlternativeTypeLists p_AlternativeTypeLists, SyntaxTreeToken p_token_2)
		{
			ChoiceType p_ChoiceType_ref = new ChoiceType(p_token, p_token_1, p_AlternativeTypeLists, p_token_2);
			p_token.parent = p_ChoiceType_ref;
			p_token_1.parent = p_ChoiceType_ref;
			p_AlternativeTypeLists.parent = p_ChoiceType_ref;
			p_token_2.parent = p_ChoiceType_ref;
			Raise_ChoiceType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ChoiceType.production_kind.g_ChoiceType_1, p_ChoiceType_ref);
			return p_ChoiceType_ref;
		}
		#endregion
	};
}
