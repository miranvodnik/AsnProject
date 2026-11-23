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
	// class associated with syntax rule TC-Syntax
	//

	[DataContract]
	public class	TC_Syntax : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TC-Syntax
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TC-Syntax
		{
			g_TC_Syntax_1 = 1,	// Type

			g_TC_Syntax_2 = 2,	// BITS "{" TC-NamedBits "}"

		};
		#endregion
		#region production markers associated with the syntax rule TC-Syntax

		// markers associated with production: TC-Syntax -> Type

		public enum production_marker_1 : ushort
		{
			m_Type,
			final
		};

		// markers associated with production: TC-Syntax -> BITS "{" TC-NamedBits "}"

		public enum production_marker_2 : ushort
		{
			m_TC_NamedBits,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TC-Syntax

		// Constructor declaration(s) associated with production(s) of syntax rule TC-Syntax

		//
		// Constructor associated with the following production(s)
		// TC-Syntax -> Type

		//

		public TC_Syntax (Type p_Type) : base ((uint) ProductionID._TC_Syntax_ID, (uint) production_kind.g_TC_Syntax_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// TC-Syntax -> BITS "{" TC-NamedBits "}"

		//

		public TC_Syntax (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, TC_NamedBits p_TC_NamedBits, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._TC_Syntax_ID, (uint) production_kind.g_TC_Syntax_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_BITS = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_TC_NamedBits = p_TC_NamedBits;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		public TC_Syntax () { }

		// Copy constructor

		public TC_Syntax (TC_Syntax p_TC_Syntax) : base (p_TC_Syntax.id, p_TC_Syntax.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TC_Syntax.appInfo;
			switch ((production_kind) p_TC_Syntax.kind)
			{
				case production_kind.g_TC_Syntax_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Type = (p_TC_Syntax.m_Type != null) ? new Type (p_TC_Syntax.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_TC_Syntax_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_BITS = (p_TC_Syntax.m_BITS != null) ? new SyntaxTreeToken (p_TC_Syntax.m_BITS) : null) != null) m_BITS.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_TC_Syntax.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_TC_Syntax.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_TC_NamedBits = (p_TC_Syntax.m_TC_NamedBits != null) ? new TC_NamedBits (p_TC_Syntax.m_TC_NamedBits) : null) != null) m_TC_NamedBits.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_TC_Syntax.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_TC_Syntax.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TC_Syntax" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TC_Syntax (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Type?.Dispose ();
			m_BITS?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_TC_NamedBits?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TC-Syntax

		// Content changing function(s) associated with production(s) of syntax rule TC-Syntax

		//
		// Content changing function associated with following production(s)
		// TC-Syntax -> Type

		//

		public void change(Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_TC_Syntax_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TC-Syntax -> BITS "{" TC-NamedBits "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, TC_NamedBits p_TC_NamedBits, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_TC_Syntax_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_BITS = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_TC_NamedBits = p_TC_NamedBits;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TC-Syntax
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_BITS != null) && m_BITS.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_TC_NamedBits != null) && m_TC_NamedBits.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TC-Syntax

		//
		// emit production tree node associated with any production of syntax rule TC-Syntax
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TC_Syntax_1:
					// emit syntax tree node associated with production
					// TC-Syntax: Type

					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_TC_Syntax_2:
					// emit syntax tree node associated with production
					// TC-Syntax: BITS "{" TC-NamedBits "}"

					s += m_BITS.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_TC_NamedBits.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TC-Syntax
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TC_Syntax (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TC_Syntax_1:
					// emit syntax tree node associated with production
					// TC-Syntax: Type

					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TC_Syntax_2:
					// emit syntax tree node associated with production
					// TC-Syntax: BITS "{" TC-NamedBits "}"

					s += "BITS";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_TC_NamedBits.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TC-Syntax

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TC-Syntax with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TC_Syntax.production_kind kind = (TC_Syntax.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TC_Syntax.production_kind.g_TC_Syntax_1:
					// traverse syntax tree node associated with production
					// TC-Syntax: Type

						m_Type.Visit (visitor, appData);
				break;
				case TC_Syntax.production_kind.g_TC_Syntax_2:
					// traverse syntax tree node associated with production
					// TC-Syntax: BITS "{" TC-NamedBits "}"

						m_BITS.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_TC_NamedBits.Visit (visitor, appData);
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
			m_TC_NamedBits?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TC-Syntax
		//

		public void _init ()
		{
			m_Type = null;
			m_BITS = null;
			m_left_curly_bracket = null;
			m_TC_NamedBits = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TC-Syntax

		// counter of all nodes associated with syntax rule TC-Syntax
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TC-Syntax
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_BITS")] public SyntaxTreeToken m_BITS { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_TC_NamedBits")] public TC_NamedBits m_TC_NamedBits { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TC-Syntax

		// delegate function (callback) prototype associated with syntax rule TC-Syntax
		public delegate bool TC_Syntax_Callback (SyntaxTreeCallbackReason reason, TC_Syntax.production_kind kind, TC_Syntax p_TC_Syntax);

		// event associated with syntax rule TC-Syntax
		public event TC_Syntax_Callback TC_Syntax_Event;

		// event trigger associated with syntax rule TC-Syntax
		public bool Raise_TC_Syntax_Event (SyntaxTreeCallbackReason reason, TC_Syntax.production_kind kind, TC_Syntax p_TC_Syntax)
		{
			bool? status = TC_Syntax_Event?.Invoke (reason, kind, p_TC_Syntax);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TC-Syntax
		//
		// traverse syntax tree node associated with any production of syntax rule TC-Syntax
		//

		public void Traverse (TC_Syntax p_TC_Syntax)
		{
			if (p_TC_Syntax.isLocked())
				return;
			p_TC_Syntax.dolock();
			TC_Syntax.production_kind kind = (TC_Syntax.production_kind) p_TC_Syntax.kind;
			p_TC_Syntax.turn_reset ();
			if (Raise_TC_Syntax_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TC_Syntax))
			switch (kind)
			{
				case TC_Syntax.production_kind.g_TC_Syntax_1:
					// traverse syntax tree node associated with production
					// TC-Syntax: Type

					if (Raise_TC_Syntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TC_Syntax))
						Traverse (p_TC_Syntax.m_Type);
					p_TC_Syntax.turn_inc ();
					Raise_TC_Syntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TC_Syntax);
				break;
				case TC_Syntax.production_kind.g_TC_Syntax_2:
					// traverse syntax tree node associated with production
					// TC-Syntax: BITS "{" TC-NamedBits "}"

					if (Raise_TC_Syntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TC_Syntax))
						Traverse (p_TC_Syntax.m_TC_NamedBits);
					p_TC_Syntax.turn_inc ();
					Raise_TC_Syntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TC_Syntax);
				break;
			}
			Raise_TC_Syntax_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TC_Syntax);
			p_TC_Syntax.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TC-Syntax
		//

		public void TraverseCommon (TC_Syntax p_TC_Syntax)
		{
			TC_Syntax.production_kind kind = (TC_Syntax.production_kind) p_TC_Syntax.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TC_Syntax))
			switch (kind)
			{
				case TC_Syntax.production_kind.g_TC_Syntax_1:
					// traverse syntax tree node associated with production
					// TC-Syntax: Type

						TraverseCommon (p_TC_Syntax.m_Type);
				break;
				case TC_Syntax.production_kind.g_TC_Syntax_2:
					// traverse syntax tree node associated with production
					// TC-Syntax: BITS "{" TC-NamedBits "}"

						TraverseCommon (p_TC_Syntax.m_BITS);
						TraverseCommon (p_TC_Syntax.m_left_curly_bracket);
						TraverseCommon (p_TC_Syntax.m_TC_NamedBits);
						TraverseCommon (p_TC_Syntax.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TC_Syntax);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TC-Syntax

		//
		// create syntax tree node associated with production
		// TC-Syntax: Type

		//

		public TC_Syntax TC_Syntax_1 (Type p_Type)
		{
			TC_Syntax p_TC_Syntax_ref = new TC_Syntax(p_Type);
			p_Type.parent = p_TC_Syntax_ref;
			Raise_TC_Syntax_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TC_Syntax.production_kind.g_TC_Syntax_1, p_TC_Syntax_ref);
			return p_TC_Syntax_ref;
		}

		//
		// create syntax tree node associated with production
		// TC-Syntax: BITS "{" TC-NamedBits "}"

		//

		public TC_Syntax TC_Syntax_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, TC_NamedBits p_TC_NamedBits, SyntaxTreeToken p_token_2)
		{
			TC_Syntax p_TC_Syntax_ref = new TC_Syntax(p_token, p_token_1, p_TC_NamedBits, p_token_2);
			p_token.parent = p_TC_Syntax_ref;
			p_token_1.parent = p_TC_Syntax_ref;
			p_TC_NamedBits.parent = p_TC_Syntax_ref;
			p_token_2.parent = p_TC_Syntax_ref;
			Raise_TC_Syntax_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TC_Syntax.production_kind.g_TC_Syntax_2, p_TC_Syntax_ref);
			return p_TC_Syntax_ref;
		}
		#endregion
	};
}
