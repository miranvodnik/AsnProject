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
	// class associated with syntax rule TextualConventionMacro
	//

	[DataContract]
	public class	TextualConventionMacro : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TextualConventionMacro
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TextualConventionMacro
		{
			g_TextualConventionMacro_1 = 1,	// TEXTUAL-CONVENTION TC-DisplayPart STATUS TC-Status DESCRIPTION cstring TC-ReferPart SYNTAX TC-Syntax

		};
		#endregion
		#region production markers associated with the syntax rule TextualConventionMacro

		// markers associated with production: TextualConventionMacro -> TEXTUAL-CONVENTION TC-DisplayPart STATUS TC-Status DESCRIPTION cstring TC-ReferPart SYNTAX TC-Syntax

		public enum production_marker_1 : ushort
		{
			m_TC_DisplayPart,
			m_TC_Status,
			m_TC_ReferPart,
			m_TC_Syntax,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TextualConventionMacro

		// Constructor declaration(s) associated with production(s) of syntax rule TextualConventionMacro

		//
		// Constructor associated with the following production(s)
		// TextualConventionMacro -> TEXTUAL-CONVENTION TC-DisplayPart STATUS TC-Status DESCRIPTION cstring TC-ReferPart SYNTAX TC-Syntax

		//

		public TextualConventionMacro (SyntaxTreeToken p_token, TC_DisplayPart p_TC_DisplayPart, SyntaxTreeToken p_token_1, TC_Status p_TC_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, TC_ReferPart p_TC_ReferPart, SyntaxTreeToken p_token_4, TC_Syntax p_TC_Syntax) : base ((uint) ProductionID._TextualConventionMacro_ID, (uint) production_kind.g_TextualConventionMacro_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 9);
			children[0] = m_TEXTUAL_CONVENTION = p_token;
			children[1] = m_TC_DisplayPart = p_TC_DisplayPart;
			children[2] = m_STATUS = p_token_1;
			children[3] = m_TC_Status = p_TC_Status;
			children[4] = m_DESCRIPTION = p_token_2;
			children[5] = m_cstring = p_token_3;
			children[6] = m_TC_ReferPart = p_TC_ReferPart;
			children[7] = m_SYNTAX = p_token_4;
			children[8] = m_TC_Syntax = p_TC_Syntax;
		}

		public TextualConventionMacro () { }

		// Copy constructor

		public TextualConventionMacro (TextualConventionMacro p_TextualConventionMacro) : base (p_TextualConventionMacro.id, p_TextualConventionMacro.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TextualConventionMacro.appInfo;
			switch ((production_kind) p_TextualConventionMacro.kind)
			{
				case production_kind.g_TextualConventionMacro_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 9);
					if ((children [0] = m_TEXTUAL_CONVENTION = (p_TextualConventionMacro.m_TEXTUAL_CONVENTION != null) ? new SyntaxTreeToken (p_TextualConventionMacro.m_TEXTUAL_CONVENTION) : null) != null) m_TEXTUAL_CONVENTION.parent = this;
					if ((children [1] = m_TC_DisplayPart = (p_TextualConventionMacro.m_TC_DisplayPart != null) ? new TC_DisplayPart (p_TextualConventionMacro.m_TC_DisplayPart) : null) != null) m_TC_DisplayPart.parent = this;
					if ((children [2] = m_STATUS = (p_TextualConventionMacro.m_STATUS != null) ? new SyntaxTreeToken (p_TextualConventionMacro.m_STATUS) : null) != null) m_STATUS.parent = this;
					if ((children [3] = m_TC_Status = (p_TextualConventionMacro.m_TC_Status != null) ? new TC_Status (p_TextualConventionMacro.m_TC_Status) : null) != null) m_TC_Status.parent = this;
					if ((children [4] = m_DESCRIPTION = (p_TextualConventionMacro.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_TextualConventionMacro.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [5] = m_cstring = (p_TextualConventionMacro.m_cstring != null) ? new SyntaxTreeToken (p_TextualConventionMacro.m_cstring) : null) != null) m_cstring.parent = this;
					if ((children [6] = m_TC_ReferPart = (p_TextualConventionMacro.m_TC_ReferPart != null) ? new TC_ReferPart (p_TextualConventionMacro.m_TC_ReferPart) : null) != null) m_TC_ReferPart.parent = this;
					if ((children [7] = m_SYNTAX = (p_TextualConventionMacro.m_SYNTAX != null) ? new SyntaxTreeToken (p_TextualConventionMacro.m_SYNTAX) : null) != null) m_SYNTAX.parent = this;
					if ((children [8] = m_TC_Syntax = (p_TextualConventionMacro.m_TC_Syntax != null) ? new TC_Syntax (p_TextualConventionMacro.m_TC_Syntax) : null) != null) m_TC_Syntax.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TextualConventionMacro" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TextualConventionMacro (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_TEXTUAL_CONVENTION?.Dispose ();
			m_TC_DisplayPart?.Dispose ();
			m_STATUS?.Dispose ();
			m_TC_Status?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_cstring?.Dispose ();
			m_TC_ReferPart?.Dispose ();
			m_SYNTAX?.Dispose ();
			m_TC_Syntax?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TextualConventionMacro

		// Content changing function(s) associated with production(s) of syntax rule TextualConventionMacro

		//
		// Content changing function associated with following production(s)
		// TextualConventionMacro -> TEXTUAL-CONVENTION TC-DisplayPart STATUS TC-Status DESCRIPTION cstring TC-ReferPart SYNTAX TC-Syntax

		//

		public void change(SyntaxTreeToken p_token, TC_DisplayPart p_TC_DisplayPart, SyntaxTreeToken p_token_1, TC_Status p_TC_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, TC_ReferPart p_TC_ReferPart, SyntaxTreeToken p_token_4, TC_Syntax p_TC_Syntax)
		{
			_init ();
			this.kind = (uint) production_kind.g_TextualConventionMacro_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 9);
			children [0] = m_TEXTUAL_CONVENTION = p_token;
			children [1] = m_TC_DisplayPart = p_TC_DisplayPart;
			children [2] = m_STATUS = p_token_1;
			children [3] = m_TC_Status = p_TC_Status;
			children [4] = m_DESCRIPTION = p_token_2;
			children [5] = m_cstring = p_token_3;
			children [6] = m_TC_ReferPart = p_TC_ReferPart;
			children [7] = m_SYNTAX = p_token_4;
			children [8] = m_TC_Syntax = p_TC_Syntax;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TextualConventionMacro
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_TEXTUAL_CONVENTION != null) && m_TEXTUAL_CONVENTION.checkInclusion (element) ||
				(m_TC_DisplayPart != null) && m_TC_DisplayPart.checkInclusion (element) ||
				(m_STATUS != null) && m_STATUS.checkInclusion (element) ||
				(m_TC_Status != null) && m_TC_Status.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				(m_TC_ReferPart != null) && m_TC_ReferPart.checkInclusion (element) ||
				(m_SYNTAX != null) && m_SYNTAX.checkInclusion (element) ||
				(m_TC_Syntax != null) && m_TC_Syntax.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TextualConventionMacro

		//
		// emit production tree node associated with any production of syntax rule TextualConventionMacro
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TextualConventionMacro_1:
					// emit syntax tree node associated with production
					// TextualConventionMacro: TEXTUAL-CONVENTION TC-DisplayPart STATUS TC-Status DESCRIPTION cstring TC-ReferPart SYNTAX TC-Syntax

					s += m_TEXTUAL_CONVENTION.Emit (depth - 1);
					s += " ";
					s += m_TC_DisplayPart.Emit (depth - 1);
					s += " ";
					s += m_STATUS.Emit (depth - 1);
					s += " ";
					s += m_TC_Status.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
					s += " ";
					s += m_TC_ReferPart.Emit (depth - 1);
					s += " ";
					s += m_SYNTAX.Emit (depth - 1);
					s += " ";
					s += m_TC_Syntax.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TextualConventionMacro
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TextualConventionMacro (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TextualConventionMacro_1:
					// emit syntax tree node associated with production
					// TextualConventionMacro: TEXTUAL-CONVENTION TC-DisplayPart STATUS TC-Status DESCRIPTION cstring TC-ReferPart SYNTAX TC-Syntax

					s += "TEXTUAL_CONVENTION";
					s += ' ';
					s += m_TC_DisplayPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += "STATUS";
					s += ' ';
					s += m_TC_Status.EmitProductionTree (depth - 1);
					s += ' ';
					s += "DESCRIPTION";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += m_TC_ReferPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += "SYNTAX";
					s += ' ';
					s += m_TC_Syntax.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TextualConventionMacro

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TextualConventionMacro with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TextualConventionMacro.production_kind kind = (TextualConventionMacro.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TextualConventionMacro.production_kind.g_TextualConventionMacro_1:
					// traverse syntax tree node associated with production
					// TextualConventionMacro: TEXTUAL-CONVENTION TC-DisplayPart STATUS TC-Status DESCRIPTION cstring TC-ReferPart SYNTAX TC-Syntax

						m_TEXTUAL_CONVENTION.Visit (visitor, appData);
						m_TC_DisplayPart.Visit (visitor, appData);
						m_STATUS.Visit (visitor, appData);
						m_TC_Status.Visit (visitor, appData);
						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
						m_TC_ReferPart.Visit (visitor, appData);
						m_SYNTAX.Visit (visitor, appData);
						m_TC_Syntax.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_TEXTUAL_CONVENTION?.reparent (this);
			m_TC_DisplayPart?.reparent (this);
			m_STATUS?.reparent (this);
			m_TC_Status?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_cstring?.reparent (this);
			m_TC_ReferPart?.reparent (this);
			m_SYNTAX?.reparent (this);
			m_TC_Syntax?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TextualConventionMacro
		//

		public void _init ()
		{
			m_TEXTUAL_CONVENTION = null;
			m_TC_DisplayPart = null;
			m_STATUS = null;
			m_TC_Status = null;
			m_DESCRIPTION = null;
			m_cstring = null;
			m_TC_ReferPart = null;
			m_SYNTAX = null;
			m_TC_Syntax = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TextualConventionMacro

		// counter of all nodes associated with syntax rule TextualConventionMacro
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TextualConventionMacro
		[DataMember (Name = "m_TEXTUAL_CONVENTION")] public SyntaxTreeToken m_TEXTUAL_CONVENTION { get; private set; }
		[DataMember (Name = "m_TC_DisplayPart")] public TC_DisplayPart m_TC_DisplayPart { get; private set; }
		[DataMember (Name = "m_STATUS")] public SyntaxTreeToken m_STATUS { get; private set; }
		[DataMember (Name = "m_TC_Status")] public TC_Status m_TC_Status { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		[DataMember (Name = "m_TC_ReferPart")] public TC_ReferPart m_TC_ReferPart { get; private set; }
		[DataMember (Name = "m_SYNTAX")] public SyntaxTreeToken m_SYNTAX { get; private set; }
		[DataMember (Name = "m_TC_Syntax")] public TC_Syntax m_TC_Syntax { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TextualConventionMacro

		// delegate function (callback) prototype associated with syntax rule TextualConventionMacro
		public delegate bool TextualConventionMacro_Callback (SyntaxTreeCallbackReason reason, TextualConventionMacro.production_kind kind, TextualConventionMacro p_TextualConventionMacro);

		// event associated with syntax rule TextualConventionMacro
		public event TextualConventionMacro_Callback TextualConventionMacro_Event;

		// event trigger associated with syntax rule TextualConventionMacro
		public bool Raise_TextualConventionMacro_Event (SyntaxTreeCallbackReason reason, TextualConventionMacro.production_kind kind, TextualConventionMacro p_TextualConventionMacro)
		{
			bool? status = TextualConventionMacro_Event?.Invoke (reason, kind, p_TextualConventionMacro);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TextualConventionMacro
		//
		// traverse syntax tree node associated with any production of syntax rule TextualConventionMacro
		//

		public void Traverse (TextualConventionMacro p_TextualConventionMacro)
		{
			if (p_TextualConventionMacro.isLocked())
				return;
			p_TextualConventionMacro.dolock();
			TextualConventionMacro.production_kind kind = (TextualConventionMacro.production_kind) p_TextualConventionMacro.kind;
			p_TextualConventionMacro.turn_reset ();
			if (Raise_TextualConventionMacro_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TextualConventionMacro))
			switch (kind)
			{
				case TextualConventionMacro.production_kind.g_TextualConventionMacro_1:
					// traverse syntax tree node associated with production
					// TextualConventionMacro: TEXTUAL-CONVENTION TC-DisplayPart STATUS TC-Status DESCRIPTION cstring TC-ReferPart SYNTAX TC-Syntax

					if (Raise_TextualConventionMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TextualConventionMacro))
						Traverse (p_TextualConventionMacro.m_TC_DisplayPart);
					p_TextualConventionMacro.turn_inc ();
					if (Raise_TextualConventionMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TextualConventionMacro))
						Traverse (p_TextualConventionMacro.m_TC_Status);
					p_TextualConventionMacro.turn_inc ();
					if (Raise_TextualConventionMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TextualConventionMacro))
						Traverse (p_TextualConventionMacro.m_TC_ReferPart);
					p_TextualConventionMacro.turn_inc ();
					if (Raise_TextualConventionMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TextualConventionMacro))
						Traverse (p_TextualConventionMacro.m_TC_Syntax);
					p_TextualConventionMacro.turn_inc ();
					Raise_TextualConventionMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TextualConventionMacro);
				break;
			}
			Raise_TextualConventionMacro_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TextualConventionMacro);
			p_TextualConventionMacro.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TextualConventionMacro
		//

		public void TraverseCommon (TextualConventionMacro p_TextualConventionMacro)
		{
			TextualConventionMacro.production_kind kind = (TextualConventionMacro.production_kind) p_TextualConventionMacro.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TextualConventionMacro))
			switch (kind)
			{
				case TextualConventionMacro.production_kind.g_TextualConventionMacro_1:
					// traverse syntax tree node associated with production
					// TextualConventionMacro: TEXTUAL-CONVENTION TC-DisplayPart STATUS TC-Status DESCRIPTION cstring TC-ReferPart SYNTAX TC-Syntax

						TraverseCommon (p_TextualConventionMacro.m_TEXTUAL_CONVENTION);
						TraverseCommon (p_TextualConventionMacro.m_TC_DisplayPart);
						TraverseCommon (p_TextualConventionMacro.m_STATUS);
						TraverseCommon (p_TextualConventionMacro.m_TC_Status);
						TraverseCommon (p_TextualConventionMacro.m_DESCRIPTION);
						TraverseCommon (p_TextualConventionMacro.m_cstring);
						TraverseCommon (p_TextualConventionMacro.m_TC_ReferPart);
						TraverseCommon (p_TextualConventionMacro.m_SYNTAX);
						TraverseCommon (p_TextualConventionMacro.m_TC_Syntax);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TextualConventionMacro);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TextualConventionMacro

		//
		// create syntax tree node associated with production
		// TextualConventionMacro: TEXTUAL-CONVENTION TC-DisplayPart STATUS TC-Status DESCRIPTION cstring TC-ReferPart SYNTAX TC-Syntax

		//

		public TextualConventionMacro TextualConventionMacro_1 (SyntaxTreeToken p_token, TC_DisplayPart p_TC_DisplayPart, SyntaxTreeToken p_token_1, TC_Status p_TC_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, TC_ReferPart p_TC_ReferPart, SyntaxTreeToken p_token_4, TC_Syntax p_TC_Syntax)
		{
			TextualConventionMacro p_TextualConventionMacro_ref = new TextualConventionMacro(p_token, p_TC_DisplayPart, p_token_1, p_TC_Status, p_token_2, p_token_3, p_TC_ReferPart, p_token_4, p_TC_Syntax);
			p_token.parent = p_TextualConventionMacro_ref;
			p_TC_DisplayPart.parent = p_TextualConventionMacro_ref;
			p_token_1.parent = p_TextualConventionMacro_ref;
			p_TC_Status.parent = p_TextualConventionMacro_ref;
			p_token_2.parent = p_TextualConventionMacro_ref;
			p_token_3.parent = p_TextualConventionMacro_ref;
			p_TC_ReferPart.parent = p_TextualConventionMacro_ref;
			p_token_4.parent = p_TextualConventionMacro_ref;
			p_TC_Syntax.parent = p_TextualConventionMacro_ref;
			Raise_TextualConventionMacro_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TextualConventionMacro.production_kind.g_TextualConventionMacro_1, p_TextualConventionMacro_ref);
			return p_TextualConventionMacro_ref;
		}
		#endregion
	};
}
