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
	// class associated with syntax rule DefinitiveNameAndNumberForm
	//

	[DataContract]
	public class	DefinitiveNameAndNumberForm : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinitiveNameAndNumberForm
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinitiveNameAndNumberForm
		{
			g_DefinitiveNameAndNumberForm_1 = 1,	// identifier-token "(" DefinitiveNumberForm ")"

		};
		#endregion
		#region production markers associated with the syntax rule DefinitiveNameAndNumberForm

		// markers associated with production: DefinitiveNameAndNumberForm -> identifier-token "(" DefinitiveNumberForm ")"

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			m_DefinitiveNumberForm,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinitiveNameAndNumberForm

		// Constructor declaration(s) associated with production(s) of syntax rule DefinitiveNameAndNumberForm

		//
		// Constructor associated with the following production(s)
		// DefinitiveNameAndNumberForm -> identifier-token "(" DefinitiveNumberForm ")"

		//

		public DefinitiveNameAndNumberForm (identifier_token p_identifier_token, SyntaxTreeToken p_token, DefinitiveNumberForm p_DefinitiveNumberForm, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._DefinitiveNameAndNumberForm_ID, (uint) production_kind.g_DefinitiveNameAndNumberForm_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_left_round_bracket = p_token;
			children[2] = m_DefinitiveNumberForm = p_DefinitiveNumberForm;
			children[3] = m_right_round_bracket = p_token_1;
		}

		public DefinitiveNameAndNumberForm () { }

		// Copy constructor

		public DefinitiveNameAndNumberForm (DefinitiveNameAndNumberForm p_DefinitiveNameAndNumberForm) : base (p_DefinitiveNameAndNumberForm.id, p_DefinitiveNameAndNumberForm.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinitiveNameAndNumberForm.appInfo;
			switch ((production_kind) p_DefinitiveNameAndNumberForm.kind)
			{
				case production_kind.g_DefinitiveNameAndNumberForm_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_identifier_token = (p_DefinitiveNameAndNumberForm.m_identifier_token != null) ? new identifier_token (p_DefinitiveNameAndNumberForm.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_left_round_bracket = (p_DefinitiveNameAndNumberForm.m_left_round_bracket != null) ? new SyntaxTreeToken (p_DefinitiveNameAndNumberForm.m_left_round_bracket) : null) != null) m_left_round_bracket.parent = this;
					if ((children [2] = m_DefinitiveNumberForm = (p_DefinitiveNameAndNumberForm.m_DefinitiveNumberForm != null) ? new DefinitiveNumberForm (p_DefinitiveNameAndNumberForm.m_DefinitiveNumberForm) : null) != null) m_DefinitiveNumberForm.parent = this;
					if ((children [3] = m_right_round_bracket = (p_DefinitiveNameAndNumberForm.m_right_round_bracket != null) ? new SyntaxTreeToken (p_DefinitiveNameAndNumberForm.m_right_round_bracket) : null) != null) m_right_round_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinitiveNameAndNumberForm" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinitiveNameAndNumberForm (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_left_round_bracket?.Dispose ();
			m_DefinitiveNumberForm?.Dispose ();
			m_right_round_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinitiveNameAndNumberForm

		// Content changing function(s) associated with production(s) of syntax rule DefinitiveNameAndNumberForm

		//
		// Content changing function associated with following production(s)
		// DefinitiveNameAndNumberForm -> identifier-token "(" DefinitiveNumberForm ")"

		//

		public void change(identifier_token p_identifier_token, SyntaxTreeToken p_token, DefinitiveNumberForm p_DefinitiveNumberForm, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitiveNameAndNumberForm_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_left_round_bracket = p_token;
			children [2] = m_DefinitiveNumberForm = p_DefinitiveNumberForm;
			children [3] = m_right_round_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinitiveNameAndNumberForm
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_left_round_bracket != null) && m_left_round_bracket.checkInclusion (element) ||
				(m_DefinitiveNumberForm != null) && m_DefinitiveNumberForm.checkInclusion (element) ||
				(m_right_round_bracket != null) && m_right_round_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinitiveNameAndNumberForm

		//
		// emit production tree node associated with any production of syntax rule DefinitiveNameAndNumberForm
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinitiveNameAndNumberForm_1:
					// emit syntax tree node associated with production
					// DefinitiveNameAndNumberForm: identifier-token "(" DefinitiveNumberForm ")"

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_left_round_bracket.Emit (depth - 1);
					s += " ";
					s += m_DefinitiveNumberForm.Emit (depth - 1);
					s += " ";
					s += m_right_round_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinitiveNameAndNumberForm
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinitiveNameAndNumberForm (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinitiveNameAndNumberForm_1:
					// emit syntax tree node associated with production
					// DefinitiveNameAndNumberForm: identifier-token "(" DefinitiveNumberForm ")"

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "left_round_bracket";
					s += ' ';
					s += m_DefinitiveNumberForm.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_round_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinitiveNameAndNumberForm

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveNameAndNumberForm with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinitiveNameAndNumberForm.production_kind kind = (DefinitiveNameAndNumberForm.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinitiveNameAndNumberForm.production_kind.g_DefinitiveNameAndNumberForm_1:
					// traverse syntax tree node associated with production
					// DefinitiveNameAndNumberForm: identifier-token "(" DefinitiveNumberForm ")"

						m_identifier_token.Visit (visitor, appData);
						m_left_round_bracket.Visit (visitor, appData);
						m_DefinitiveNumberForm.Visit (visitor, appData);
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
			m_DefinitiveNumberForm?.reparent (this);
			m_right_round_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefinitiveNameAndNumberForm
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_left_round_bracket = null;
			m_DefinitiveNumberForm = null;
			m_right_round_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinitiveNameAndNumberForm

		// counter of all nodes associated with syntax rule DefinitiveNameAndNumberForm
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinitiveNameAndNumberForm
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_left_round_bracket")] public SyntaxTreeToken m_left_round_bracket { get; private set; }
		[DataMember (Name = "m_DefinitiveNumberForm")] public DefinitiveNumberForm m_DefinitiveNumberForm { get; private set; }
		[DataMember (Name = "m_right_round_bracket")] public SyntaxTreeToken m_right_round_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinitiveNameAndNumberForm

		// delegate function (callback) prototype associated with syntax rule DefinitiveNameAndNumberForm
		public delegate bool DefinitiveNameAndNumberForm_Callback (SyntaxTreeCallbackReason reason, DefinitiveNameAndNumberForm.production_kind kind, DefinitiveNameAndNumberForm p_DefinitiveNameAndNumberForm);

		// event associated with syntax rule DefinitiveNameAndNumberForm
		public event DefinitiveNameAndNumberForm_Callback DefinitiveNameAndNumberForm_Event;

		// event trigger associated with syntax rule DefinitiveNameAndNumberForm
		public bool Raise_DefinitiveNameAndNumberForm_Event (SyntaxTreeCallbackReason reason, DefinitiveNameAndNumberForm.production_kind kind, DefinitiveNameAndNumberForm p_DefinitiveNameAndNumberForm)
		{
			bool? status = DefinitiveNameAndNumberForm_Event?.Invoke (reason, kind, p_DefinitiveNameAndNumberForm);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinitiveNameAndNumberForm
		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveNameAndNumberForm
		//

		public void Traverse (DefinitiveNameAndNumberForm p_DefinitiveNameAndNumberForm)
		{
			if (p_DefinitiveNameAndNumberForm.isLocked())
				return;
			p_DefinitiveNameAndNumberForm.dolock();
			DefinitiveNameAndNumberForm.production_kind kind = (DefinitiveNameAndNumberForm.production_kind) p_DefinitiveNameAndNumberForm.kind;
			p_DefinitiveNameAndNumberForm.turn_reset ();
			if (Raise_DefinitiveNameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinitiveNameAndNumberForm))
			switch (kind)
			{
				case DefinitiveNameAndNumberForm.production_kind.g_DefinitiveNameAndNumberForm_1:
					// traverse syntax tree node associated with production
					// DefinitiveNameAndNumberForm: identifier-token "(" DefinitiveNumberForm ")"

					if (Raise_DefinitiveNameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveNameAndNumberForm))
						Traverse (p_DefinitiveNameAndNumberForm.m_identifier_token);
					p_DefinitiveNameAndNumberForm.turn_inc ();
					if (Raise_DefinitiveNameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveNameAndNumberForm))
						Traverse (p_DefinitiveNameAndNumberForm.m_DefinitiveNumberForm);
					p_DefinitiveNameAndNumberForm.turn_inc ();
					Raise_DefinitiveNameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveNameAndNumberForm);
				break;
			}
			Raise_DefinitiveNameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinitiveNameAndNumberForm);
			p_DefinitiveNameAndNumberForm.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveNameAndNumberForm
		//

		public void TraverseCommon (DefinitiveNameAndNumberForm p_DefinitiveNameAndNumberForm)
		{
			DefinitiveNameAndNumberForm.production_kind kind = (DefinitiveNameAndNumberForm.production_kind) p_DefinitiveNameAndNumberForm.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinitiveNameAndNumberForm))
			switch (kind)
			{
				case DefinitiveNameAndNumberForm.production_kind.g_DefinitiveNameAndNumberForm_1:
					// traverse syntax tree node associated with production
					// DefinitiveNameAndNumberForm: identifier-token "(" DefinitiveNumberForm ")"

						TraverseCommon (p_DefinitiveNameAndNumberForm.m_identifier_token);
						TraverseCommon (p_DefinitiveNameAndNumberForm.m_left_round_bracket);
						TraverseCommon (p_DefinitiveNameAndNumberForm.m_DefinitiveNumberForm);
						TraverseCommon (p_DefinitiveNameAndNumberForm.m_right_round_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinitiveNameAndNumberForm);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinitiveNameAndNumberForm

		//
		// create syntax tree node associated with production
		// DefinitiveNameAndNumberForm: identifier-token "(" DefinitiveNumberForm ")"

		//

		public DefinitiveNameAndNumberForm DefinitiveNameAndNumberForm_1 (identifier_token p_identifier_token, SyntaxTreeToken p_token, DefinitiveNumberForm p_DefinitiveNumberForm, SyntaxTreeToken p_token_1)
		{
			DefinitiveNameAndNumberForm p_DefinitiveNameAndNumberForm_ref = new DefinitiveNameAndNumberForm(p_identifier_token, p_token, p_DefinitiveNumberForm, p_token_1);
			p_identifier_token.parent = p_DefinitiveNameAndNumberForm_ref;
			p_token.parent = p_DefinitiveNameAndNumberForm_ref;
			p_DefinitiveNumberForm.parent = p_DefinitiveNameAndNumberForm_ref;
			p_token_1.parent = p_DefinitiveNameAndNumberForm_ref;
			Raise_DefinitiveNameAndNumberForm_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitiveNameAndNumberForm.production_kind.g_DefinitiveNameAndNumberForm_1, p_DefinitiveNameAndNumberForm_ref);
			return p_DefinitiveNameAndNumberForm_ref;
		}
		#endregion
	};
}
