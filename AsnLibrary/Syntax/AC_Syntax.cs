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
	// class associated with syntax rule AC-Syntax
	//

	[DataContract]
	public class	AC_Syntax : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-Syntax
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-Syntax
		{
			g_AC_Syntax_1 = 1,	// Type

			g_AC_Syntax_2 = 2,	// BITS "{" AC-NamedBits "}"

		};
		#endregion
		#region production markers associated with the syntax rule AC-Syntax

		// markers associated with production: AC-Syntax -> Type

		public enum production_marker_1 : ushort
		{
			m_Type,
			final
		};

		// markers associated with production: AC-Syntax -> BITS "{" AC-NamedBits "}"

		public enum production_marker_2 : ushort
		{
			m_AC_NamedBits,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-Syntax

		// Constructor declaration(s) associated with production(s) of syntax rule AC-Syntax

		//
		// Constructor associated with the following production(s)
		// AC-Syntax -> Type

		//

		public AC_Syntax (Type p_Type) : base ((uint) ProductionID._AC_Syntax_ID, (uint) production_kind.g_AC_Syntax_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// AC-Syntax -> BITS "{" AC-NamedBits "}"

		//

		public AC_Syntax (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, AC_NamedBits p_AC_NamedBits, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._AC_Syntax_ID, (uint) production_kind.g_AC_Syntax_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_BITS = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_AC_NamedBits = p_AC_NamedBits;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		public AC_Syntax () { }

		// Copy constructor

		public AC_Syntax (AC_Syntax p_AC_Syntax) : base (p_AC_Syntax.id, p_AC_Syntax.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_Syntax.appInfo;
			switch ((production_kind) p_AC_Syntax.kind)
			{
				case production_kind.g_AC_Syntax_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Type = (p_AC_Syntax.m_Type != null) ? new Type (p_AC_Syntax.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_AC_Syntax_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_BITS = (p_AC_Syntax.m_BITS != null) ? new SyntaxTreeToken (p_AC_Syntax.m_BITS) : null) != null) m_BITS.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_AC_Syntax.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_AC_Syntax.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_AC_NamedBits = (p_AC_Syntax.m_AC_NamedBits != null) ? new AC_NamedBits (p_AC_Syntax.m_AC_NamedBits) : null) != null) m_AC_NamedBits.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_AC_Syntax.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_AC_Syntax.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_Syntax" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_Syntax (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Type?.Dispose ();
			m_BITS?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_AC_NamedBits?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-Syntax

		// Content changing function(s) associated with production(s) of syntax rule AC-Syntax

		//
		// Content changing function associated with following production(s)
		// AC-Syntax -> Type

		//

		public void change(Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Syntax_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-Syntax -> BITS "{" AC-NamedBits "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, AC_NamedBits p_AC_NamedBits, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Syntax_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_BITS = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_AC_NamedBits = p_AC_NamedBits;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-Syntax
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_BITS != null) && m_BITS.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_AC_NamedBits != null) && m_AC_NamedBits.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-Syntax

		//
		// emit production tree node associated with any production of syntax rule AC-Syntax
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_Syntax_1:
					// emit syntax tree node associated with production
					// AC-Syntax: Type

					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_AC_Syntax_2:
					// emit syntax tree node associated with production
					// AC-Syntax: BITS "{" AC-NamedBits "}"

					s += m_BITS.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_AC_NamedBits.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-Syntax
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_Syntax (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_Syntax_1:
					// emit syntax tree node associated with production
					// AC-Syntax: Type

					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AC_Syntax_2:
					// emit syntax tree node associated with production
					// AC-Syntax: BITS "{" AC-NamedBits "}"

					s += "BITS";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_AC_NamedBits.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-Syntax

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Syntax with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_Syntax.production_kind kind = (AC_Syntax.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_Syntax.production_kind.g_AC_Syntax_1:
					// traverse syntax tree node associated with production
					// AC-Syntax: Type

						m_Type.Visit (visitor, appData);
				break;
				case AC_Syntax.production_kind.g_AC_Syntax_2:
					// traverse syntax tree node associated with production
					// AC-Syntax: BITS "{" AC-NamedBits "}"

						m_BITS.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_AC_NamedBits.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Type?.reparent (this);
			m_BITS?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_AC_NamedBits?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-Syntax
		//

		public void _init ()
		{
			m_Type = null;
			m_BITS = null;
			m_left_curly_bracket = null;
			m_AC_NamedBits = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-Syntax

		// counter of all nodes associated with syntax rule AC-Syntax
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-Syntax
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_BITS")] public SyntaxTreeToken m_BITS { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_AC_NamedBits")] public AC_NamedBits m_AC_NamedBits { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-Syntax

		// delegate function (callback) prototype associated with syntax rule AC-Syntax
		public delegate bool AC_Syntax_Callback (SyntaxTreeCallbackReason reason, AC_Syntax.production_kind kind, AC_Syntax p_AC_Syntax);

		// event associated with syntax rule AC-Syntax
		public event AC_Syntax_Callback AC_Syntax_Event;

		// event trigger associated with syntax rule AC-Syntax
		public bool Raise_AC_Syntax_Event (SyntaxTreeCallbackReason reason, AC_Syntax.production_kind kind, AC_Syntax p_AC_Syntax)
		{
			bool? status = AC_Syntax_Event?.Invoke (reason, kind, p_AC_Syntax);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-Syntax
		//
		// traverse syntax tree node associated with any production of syntax rule AC-Syntax
		//

		public void Traverse (AC_Syntax p_AC_Syntax)
		{
			if (p_AC_Syntax.isLocked())
				return;
			p_AC_Syntax.dolock();
			AC_Syntax.production_kind kind = (AC_Syntax.production_kind) p_AC_Syntax.kind;
			p_AC_Syntax.turn_reset ();
			if (Raise_AC_Syntax_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_Syntax))
			switch (kind)
			{
				case AC_Syntax.production_kind.g_AC_Syntax_1:
					// traverse syntax tree node associated with production
					// AC-Syntax: Type

					if (Raise_AC_Syntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Syntax))
						Traverse (p_AC_Syntax.m_Type);
					p_AC_Syntax.turn_inc ();
					Raise_AC_Syntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Syntax);
				break;
				case AC_Syntax.production_kind.g_AC_Syntax_2:
					// traverse syntax tree node associated with production
					// AC-Syntax: BITS "{" AC-NamedBits "}"

					if (Raise_AC_Syntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Syntax))
						Traverse (p_AC_Syntax.m_AC_NamedBits);
					p_AC_Syntax.turn_inc ();
					Raise_AC_Syntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Syntax);
				break;
			}
			Raise_AC_Syntax_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_Syntax);
			p_AC_Syntax.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Syntax
		//

		public void TraverseCommon (AC_Syntax p_AC_Syntax)
		{
			AC_Syntax.production_kind kind = (AC_Syntax.production_kind) p_AC_Syntax.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_Syntax))
			switch (kind)
			{
				case AC_Syntax.production_kind.g_AC_Syntax_1:
					// traverse syntax tree node associated with production
					// AC-Syntax: Type

						TraverseCommon (p_AC_Syntax.m_Type);
				break;
				case AC_Syntax.production_kind.g_AC_Syntax_2:
					// traverse syntax tree node associated with production
					// AC-Syntax: BITS "{" AC-NamedBits "}"

						TraverseCommon (p_AC_Syntax.m_BITS);
						TraverseCommon (p_AC_Syntax.m_left_curly_bracket);
						TraverseCommon (p_AC_Syntax.m_AC_NamedBits);
						TraverseCommon (p_AC_Syntax.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_Syntax);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-Syntax

		//
		// create syntax tree node associated with production
		// AC-Syntax: Type

		//

		public AC_Syntax AC_Syntax_1 (Type p_Type)
		{
			AC_Syntax p_AC_Syntax_ref = new AC_Syntax(p_Type);
			p_Type.parent = p_AC_Syntax_ref;
			Raise_AC_Syntax_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Syntax.production_kind.g_AC_Syntax_1, p_AC_Syntax_ref);
			return p_AC_Syntax_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-Syntax: BITS "{" AC-NamedBits "}"

		//

		public AC_Syntax AC_Syntax_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, AC_NamedBits p_AC_NamedBits, SyntaxTreeToken p_token_2)
		{
			AC_Syntax p_AC_Syntax_ref = new AC_Syntax(p_token, p_token_1, p_AC_NamedBits, p_token_2);
			p_token.parent = p_AC_Syntax_ref;
			p_token_1.parent = p_AC_Syntax_ref;
			p_AC_NamedBits.parent = p_AC_Syntax_ref;
			p_token_2.parent = p_AC_Syntax_ref;
			Raise_AC_Syntax_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Syntax.production_kind.g_AC_Syntax_2, p_AC_Syntax_ref);
			return p_AC_Syntax_ref;
		}
		#endregion
	};
}
