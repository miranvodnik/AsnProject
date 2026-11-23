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
	// class associated with syntax rule NameAndNumberForm
	//

	[DataContract]
	public class	NameAndNumberForm : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NameAndNumberForm
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NameAndNumberForm
		{
			g_NameAndNumberForm_1 = 1,	// identifier-token "(" NumberForm ")"

		};
		#endregion
		#region production markers associated with the syntax rule NameAndNumberForm

		// markers associated with production: NameAndNumberForm -> identifier-token "(" NumberForm ")"

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			m_NumberForm,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NameAndNumberForm

		// Constructor declaration(s) associated with production(s) of syntax rule NameAndNumberForm

		//
		// Constructor associated with the following production(s)
		// NameAndNumberForm -> identifier-token "(" NumberForm ")"

		//

		public NameAndNumberForm (identifier_token p_identifier_token, SyntaxTreeToken p_token, NumberForm p_NumberForm, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._NameAndNumberForm_ID, (uint) production_kind.g_NameAndNumberForm_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_left_round_bracket = p_token;
			children[2] = m_NumberForm = p_NumberForm;
			children[3] = m_right_round_bracket = p_token_1;
		}

		public NameAndNumberForm () { }

		// Copy constructor

		public NameAndNumberForm (NameAndNumberForm p_NameAndNumberForm) : base (p_NameAndNumberForm.id, p_NameAndNumberForm.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NameAndNumberForm.appInfo;
			switch ((production_kind) p_NameAndNumberForm.kind)
			{
				case production_kind.g_NameAndNumberForm_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_identifier_token = (p_NameAndNumberForm.m_identifier_token != null) ? new identifier_token (p_NameAndNumberForm.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_left_round_bracket = (p_NameAndNumberForm.m_left_round_bracket != null) ? new SyntaxTreeToken (p_NameAndNumberForm.m_left_round_bracket) : null) != null) m_left_round_bracket.parent = this;
					if ((children [2] = m_NumberForm = (p_NameAndNumberForm.m_NumberForm != null) ? new NumberForm (p_NameAndNumberForm.m_NumberForm) : null) != null) m_NumberForm.parent = this;
					if ((children [3] = m_right_round_bracket = (p_NameAndNumberForm.m_right_round_bracket != null) ? new SyntaxTreeToken (p_NameAndNumberForm.m_right_round_bracket) : null) != null) m_right_round_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NameAndNumberForm" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NameAndNumberForm (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_left_round_bracket?.Dispose ();
			m_NumberForm?.Dispose ();
			m_right_round_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NameAndNumberForm

		// Content changing function(s) associated with production(s) of syntax rule NameAndNumberForm

		//
		// Content changing function associated with following production(s)
		// NameAndNumberForm -> identifier-token "(" NumberForm ")"

		//

		public void change(identifier_token p_identifier_token, SyntaxTreeToken p_token, NumberForm p_NumberForm, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_NameAndNumberForm_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_left_round_bracket = p_token;
			children [2] = m_NumberForm = p_NumberForm;
			children [3] = m_right_round_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NameAndNumberForm
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_left_round_bracket != null) && m_left_round_bracket.checkInclusion (element) ||
				(m_NumberForm != null) && m_NumberForm.checkInclusion (element) ||
				(m_right_round_bracket != null) && m_right_round_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NameAndNumberForm

		//
		// emit production tree node associated with any production of syntax rule NameAndNumberForm
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NameAndNumberForm_1:
					// emit syntax tree node associated with production
					// NameAndNumberForm: identifier-token "(" NumberForm ")"

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_left_round_bracket.Emit (depth - 1);
					s += " ";
					s += m_NumberForm.Emit (depth - 1);
					s += " ";
					s += m_right_round_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NameAndNumberForm
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NameAndNumberForm (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NameAndNumberForm_1:
					// emit syntax tree node associated with production
					// NameAndNumberForm: identifier-token "(" NumberForm ")"

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "left_round_bracket";
					s += ' ';
					s += m_NumberForm.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_round_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NameAndNumberForm

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NameAndNumberForm with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NameAndNumberForm.production_kind kind = (NameAndNumberForm.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NameAndNumberForm.production_kind.g_NameAndNumberForm_1:
					// traverse syntax tree node associated with production
					// NameAndNumberForm: identifier-token "(" NumberForm ")"

						m_identifier_token.Visit (visitor, appData);
						m_left_round_bracket.Visit (visitor, appData);
						m_NumberForm.Visit (visitor, appData);
						m_right_round_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier_token?.reparent (this);
			m_left_round_bracket?.reparent (this);
			m_NumberForm?.reparent (this);
			m_right_round_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NameAndNumberForm
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_left_round_bracket = null;
			m_NumberForm = null;
			m_right_round_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NameAndNumberForm

		// counter of all nodes associated with syntax rule NameAndNumberForm
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NameAndNumberForm
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_left_round_bracket")] public SyntaxTreeToken m_left_round_bracket { get; private set; }
		[DataMember (Name = "m_NumberForm")] public NumberForm m_NumberForm { get; private set; }
		[DataMember (Name = "m_right_round_bracket")] public SyntaxTreeToken m_right_round_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NameAndNumberForm

		// delegate function (callback) prototype associated with syntax rule NameAndNumberForm
		public delegate bool NameAndNumberForm_Callback (SyntaxTreeCallbackReason reason, NameAndNumberForm.production_kind kind, NameAndNumberForm p_NameAndNumberForm);

		// event associated with syntax rule NameAndNumberForm
		public event NameAndNumberForm_Callback NameAndNumberForm_Event;

		// event trigger associated with syntax rule NameAndNumberForm
		public bool Raise_NameAndNumberForm_Event (SyntaxTreeCallbackReason reason, NameAndNumberForm.production_kind kind, NameAndNumberForm p_NameAndNumberForm)
		{
			bool? status = NameAndNumberForm_Event?.Invoke (reason, kind, p_NameAndNumberForm);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NameAndNumberForm
		//
		// traverse syntax tree node associated with any production of syntax rule NameAndNumberForm
		//

		public void Traverse (NameAndNumberForm p_NameAndNumberForm)
		{
			if (p_NameAndNumberForm.isLocked())
				return;
			p_NameAndNumberForm.dolock();
			NameAndNumberForm.production_kind kind = (NameAndNumberForm.production_kind) p_NameAndNumberForm.kind;
			p_NameAndNumberForm.turn_reset ();
			if (Raise_NameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NameAndNumberForm))
			switch (kind)
			{
				case NameAndNumberForm.production_kind.g_NameAndNumberForm_1:
					// traverse syntax tree node associated with production
					// NameAndNumberForm: identifier-token "(" NumberForm ")"

					if (Raise_NameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NameAndNumberForm))
						Traverse (p_NameAndNumberForm.m_identifier_token);
					p_NameAndNumberForm.turn_inc ();
					if (Raise_NameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NameAndNumberForm))
						Traverse (p_NameAndNumberForm.m_NumberForm);
					p_NameAndNumberForm.turn_inc ();
					Raise_NameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NameAndNumberForm);
				break;
			}
			Raise_NameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NameAndNumberForm);
			p_NameAndNumberForm.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NameAndNumberForm
		//

		public void TraverseCommon (NameAndNumberForm p_NameAndNumberForm)
		{
			NameAndNumberForm.production_kind kind = (NameAndNumberForm.production_kind) p_NameAndNumberForm.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NameAndNumberForm))
			switch (kind)
			{
				case NameAndNumberForm.production_kind.g_NameAndNumberForm_1:
					// traverse syntax tree node associated with production
					// NameAndNumberForm: identifier-token "(" NumberForm ")"

						TraverseCommon (p_NameAndNumberForm.m_identifier_token);
						TraverseCommon (p_NameAndNumberForm.m_left_round_bracket);
						TraverseCommon (p_NameAndNumberForm.m_NumberForm);
						TraverseCommon (p_NameAndNumberForm.m_right_round_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NameAndNumberForm);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NameAndNumberForm

		//
		// create syntax tree node associated with production
		// NameAndNumberForm: identifier-token "(" NumberForm ")"

		//

		public NameAndNumberForm NameAndNumberForm_1 (identifier_token p_identifier_token, SyntaxTreeToken p_token, NumberForm p_NumberForm, SyntaxTreeToken p_token_1)
		{
			NameAndNumberForm p_NameAndNumberForm_ref = new NameAndNumberForm(p_identifier_token, p_token, p_NumberForm, p_token_1);
			p_identifier_token.parent = p_NameAndNumberForm_ref;
			p_token.parent = p_NameAndNumberForm_ref;
			p_NumberForm.parent = p_NameAndNumberForm_ref;
			p_token_1.parent = p_NameAndNumberForm_ref;
			Raise_NameAndNumberForm_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NameAndNumberForm.production_kind.g_NameAndNumberForm_1, p_NameAndNumberForm_ref);
			return p_NameAndNumberForm_ref;
		}
		#endregion
	};
}
