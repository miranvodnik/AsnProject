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
	// class associated with syntax rule XMLNameAndNumberForm
	//

	[DataContract]
	public class	XMLNameAndNumberForm : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule XMLNameAndNumberForm
		public enum production_kind : ushort	// enumerated production(s) of syntax rule XMLNameAndNumberForm
		{
			g_XMLNameAndNumberForm_1 = 1,	// identifier-token "(" XMLNumberForm ")"

		};
		#endregion
		#region production markers associated with the syntax rule XMLNameAndNumberForm

		// markers associated with production: XMLNameAndNumberForm -> identifier-token "(" XMLNumberForm ")"

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			m_XMLNumberForm,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule XMLNameAndNumberForm

		// Constructor declaration(s) associated with production(s) of syntax rule XMLNameAndNumberForm

		//
		// Constructor associated with the following production(s)
		// XMLNameAndNumberForm -> identifier-token "(" XMLNumberForm ")"

		//

		public XMLNameAndNumberForm (identifier_token p_identifier_token, SyntaxTreeToken p_token, XMLNumberForm p_XMLNumberForm, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._XMLNameAndNumberForm_ID, (uint) production_kind.g_XMLNameAndNumberForm_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_left_round_bracket = p_token;
			children[2] = m_XMLNumberForm = p_XMLNumberForm;
			children[3] = m_right_round_bracket = p_token_1;
		}

		public XMLNameAndNumberForm () { }

		// Copy constructor

		public XMLNameAndNumberForm (XMLNameAndNumberForm p_XMLNameAndNumberForm) : base (p_XMLNameAndNumberForm.id, p_XMLNameAndNumberForm.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_XMLNameAndNumberForm.appInfo;
			switch ((production_kind) p_XMLNameAndNumberForm.kind)
			{
				case production_kind.g_XMLNameAndNumberForm_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_identifier_token = (p_XMLNameAndNumberForm.m_identifier_token != null) ? new identifier_token (p_XMLNameAndNumberForm.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_left_round_bracket = (p_XMLNameAndNumberForm.m_left_round_bracket != null) ? new SyntaxTreeToken (p_XMLNameAndNumberForm.m_left_round_bracket) : null) != null) m_left_round_bracket.parent = this;
					if ((children [2] = m_XMLNumberForm = (p_XMLNameAndNumberForm.m_XMLNumberForm != null) ? new XMLNumberForm (p_XMLNameAndNumberForm.m_XMLNumberForm) : null) != null) m_XMLNumberForm.parent = this;
					if ((children [3] = m_right_round_bracket = (p_XMLNameAndNumberForm.m_right_round_bracket != null) ? new SyntaxTreeToken (p_XMLNameAndNumberForm.m_right_round_bracket) : null) != null) m_right_round_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "XMLNameAndNumberForm" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new XMLNameAndNumberForm (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_left_round_bracket?.Dispose ();
			m_XMLNumberForm?.Dispose ();
			m_right_round_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule XMLNameAndNumberForm

		// Content changing function(s) associated with production(s) of syntax rule XMLNameAndNumberForm

		//
		// Content changing function associated with following production(s)
		// XMLNameAndNumberForm -> identifier-token "(" XMLNumberForm ")"

		//

		public void change(identifier_token p_identifier_token, SyntaxTreeToken p_token, XMLNumberForm p_XMLNumberForm, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_XMLNameAndNumberForm_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_left_round_bracket = p_token;
			children [2] = m_XMLNumberForm = p_XMLNumberForm;
			children [3] = m_right_round_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule XMLNameAndNumberForm
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_left_round_bracket != null) && m_left_round_bracket.checkInclusion (element) ||
				(m_XMLNumberForm != null) && m_XMLNumberForm.checkInclusion (element) ||
				(m_right_round_bracket != null) && m_right_round_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule XMLNameAndNumberForm

		//
		// emit production tree node associated with any production of syntax rule XMLNameAndNumberForm
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_XMLNameAndNumberForm_1:
					// emit syntax tree node associated with production
					// XMLNameAndNumberForm: identifier-token "(" XMLNumberForm ")"

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_left_round_bracket.Emit (depth - 1);
					s += " ";
					s += m_XMLNumberForm.Emit (depth - 1);
					s += " ";
					s += m_right_round_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule XMLNameAndNumberForm
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "XMLNameAndNumberForm (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_XMLNameAndNumberForm_1:
					// emit syntax tree node associated with production
					// XMLNameAndNumberForm: identifier-token "(" XMLNumberForm ")"

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "left_round_bracket";
					s += ' ';
					s += m_XMLNumberForm.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_round_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule XMLNameAndNumberForm

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule XMLNameAndNumberForm with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			XMLNameAndNumberForm.production_kind kind = (XMLNameAndNumberForm.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case XMLNameAndNumberForm.production_kind.g_XMLNameAndNumberForm_1:
					// traverse syntax tree node associated with production
					// XMLNameAndNumberForm: identifier-token "(" XMLNumberForm ")"

						m_identifier_token.Visit (visitor, appData);
						m_left_round_bracket.Visit (visitor, appData);
						m_XMLNumberForm.Visit (visitor, appData);
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
			m_XMLNumberForm?.reparent (this);
			m_right_round_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule XMLNameAndNumberForm
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_left_round_bracket = null;
			m_XMLNumberForm = null;
			m_right_round_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule XMLNameAndNumberForm

		// counter of all nodes associated with syntax rule XMLNameAndNumberForm
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule XMLNameAndNumberForm
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_left_round_bracket")] public SyntaxTreeToken m_left_round_bracket { get; private set; }
		[DataMember (Name = "m_XMLNumberForm")] public XMLNumberForm m_XMLNumberForm { get; private set; }
		[DataMember (Name = "m_right_round_bracket")] public SyntaxTreeToken m_right_round_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule XMLNameAndNumberForm

		// delegate function (callback) prototype associated with syntax rule XMLNameAndNumberForm
		public delegate bool XMLNameAndNumberForm_Callback (SyntaxTreeCallbackReason reason, XMLNameAndNumberForm.production_kind kind, XMLNameAndNumberForm p_XMLNameAndNumberForm);

		// event associated with syntax rule XMLNameAndNumberForm
		public event XMLNameAndNumberForm_Callback XMLNameAndNumberForm_Event;

		// event trigger associated with syntax rule XMLNameAndNumberForm
		public bool Raise_XMLNameAndNumberForm_Event (SyntaxTreeCallbackReason reason, XMLNameAndNumberForm.production_kind kind, XMLNameAndNumberForm p_XMLNameAndNumberForm)
		{
			bool? status = XMLNameAndNumberForm_Event?.Invoke (reason, kind, p_XMLNameAndNumberForm);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule XMLNameAndNumberForm
		//
		// traverse syntax tree node associated with any production of syntax rule XMLNameAndNumberForm
		//

		public void Traverse (XMLNameAndNumberForm p_XMLNameAndNumberForm)
		{
			if (p_XMLNameAndNumberForm.isLocked())
				return;
			p_XMLNameAndNumberForm.dolock();
			XMLNameAndNumberForm.production_kind kind = (XMLNameAndNumberForm.production_kind) p_XMLNameAndNumberForm.kind;
			p_XMLNameAndNumberForm.turn_reset ();
			if (Raise_XMLNameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_XMLNameAndNumberForm))
			switch (kind)
			{
				case XMLNameAndNumberForm.production_kind.g_XMLNameAndNumberForm_1:
					// traverse syntax tree node associated with production
					// XMLNameAndNumberForm: identifier-token "(" XMLNumberForm ")"

					if (Raise_XMLNameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLNameAndNumberForm))
						Traverse (p_XMLNameAndNumberForm.m_identifier_token);
					p_XMLNameAndNumberForm.turn_inc ();
					if (Raise_XMLNameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLNameAndNumberForm))
						Traverse (p_XMLNameAndNumberForm.m_XMLNumberForm);
					p_XMLNameAndNumberForm.turn_inc ();
					Raise_XMLNameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_XMLNameAndNumberForm);
				break;
			}
			Raise_XMLNameAndNumberForm_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_XMLNameAndNumberForm);
			p_XMLNameAndNumberForm.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule XMLNameAndNumberForm
		//

		public void TraverseCommon (XMLNameAndNumberForm p_XMLNameAndNumberForm)
		{
			XMLNameAndNumberForm.production_kind kind = (XMLNameAndNumberForm.production_kind) p_XMLNameAndNumberForm.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_XMLNameAndNumberForm))
			switch (kind)
			{
				case XMLNameAndNumberForm.production_kind.g_XMLNameAndNumberForm_1:
					// traverse syntax tree node associated with production
					// XMLNameAndNumberForm: identifier-token "(" XMLNumberForm ")"

						TraverseCommon (p_XMLNameAndNumberForm.m_identifier_token);
						TraverseCommon (p_XMLNameAndNumberForm.m_left_round_bracket);
						TraverseCommon (p_XMLNameAndNumberForm.m_XMLNumberForm);
						TraverseCommon (p_XMLNameAndNumberForm.m_right_round_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_XMLNameAndNumberForm);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule XMLNameAndNumberForm

		//
		// create syntax tree node associated with production
		// XMLNameAndNumberForm: identifier-token "(" XMLNumberForm ")"

		//

		public XMLNameAndNumberForm XMLNameAndNumberForm_1 (identifier_token p_identifier_token, SyntaxTreeToken p_token, XMLNumberForm p_XMLNumberForm, SyntaxTreeToken p_token_1)
		{
			XMLNameAndNumberForm p_XMLNameAndNumberForm_ref = new XMLNameAndNumberForm(p_identifier_token, p_token, p_XMLNumberForm, p_token_1);
			p_identifier_token.parent = p_XMLNameAndNumberForm_ref;
			p_token.parent = p_XMLNameAndNumberForm_ref;
			p_XMLNumberForm.parent = p_XMLNameAndNumberForm_ref;
			p_token_1.parent = p_XMLNameAndNumberForm_ref;
			Raise_XMLNameAndNumberForm_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, XMLNameAndNumberForm.production_kind.g_XMLNameAndNumberForm_1, p_XMLNameAndNumberForm_ref);
			return p_XMLNameAndNumberForm_ref;
		}
		#endregion
	};
}
