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
	// class associated with syntax rule MC-Syntax
	//

	[DataContract]
	public class	MC_Syntax : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-Syntax
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-Syntax
		{
			g_MC_Syntax_1 = 1,	// Type

			g_MC_Syntax_2 = 2,	// BITS "{" MC-NamedBits "}"

		};
		#endregion
		#region production markers associated with the syntax rule MC-Syntax

		// markers associated with production: MC-Syntax -> Type

		public enum production_marker_1 : ushort
		{
			m_Type,
			final
		};

		// markers associated with production: MC-Syntax -> BITS "{" MC-NamedBits "}"

		public enum production_marker_2 : ushort
		{
			m_MC_NamedBits,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-Syntax

		// Constructor declaration(s) associated with production(s) of syntax rule MC-Syntax

		//
		// Constructor associated with the following production(s)
		// MC-Syntax -> Type

		//

		public MC_Syntax (Type p_Type) : base ((uint) ProductionID._MC_Syntax_ID, (uint) production_kind.g_MC_Syntax_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// MC-Syntax -> BITS "{" MC-NamedBits "}"

		//

		public MC_Syntax (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, MC_NamedBits p_MC_NamedBits, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._MC_Syntax_ID, (uint) production_kind.g_MC_Syntax_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_BITS = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_MC_NamedBits = p_MC_NamedBits;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		public MC_Syntax () { }

		// Copy constructor

		public MC_Syntax (MC_Syntax p_MC_Syntax) : base (p_MC_Syntax.id, p_MC_Syntax.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_Syntax.appInfo;
			switch ((production_kind) p_MC_Syntax.kind)
			{
				case production_kind.g_MC_Syntax_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Type = (p_MC_Syntax.m_Type != null) ? new Type (p_MC_Syntax.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_MC_Syntax_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_BITS = (p_MC_Syntax.m_BITS != null) ? new SyntaxTreeToken (p_MC_Syntax.m_BITS) : null) != null) m_BITS.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_MC_Syntax.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_MC_Syntax.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_MC_NamedBits = (p_MC_Syntax.m_MC_NamedBits != null) ? new MC_NamedBits (p_MC_Syntax.m_MC_NamedBits) : null) != null) m_MC_NamedBits.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_MC_Syntax.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_MC_Syntax.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MC_Syntax" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_Syntax (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Type?.Dispose ();
			m_BITS?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_MC_NamedBits?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-Syntax

		// Content changing function(s) associated with production(s) of syntax rule MC-Syntax

		//
		// Content changing function associated with following production(s)
		// MC-Syntax -> Type

		//

		public void change(Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Syntax_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MC-Syntax -> BITS "{" MC-NamedBits "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, MC_NamedBits p_MC_NamedBits, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Syntax_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_BITS = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_MC_NamedBits = p_MC_NamedBits;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-Syntax
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_BITS != null) && m_BITS.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_MC_NamedBits != null) && m_MC_NamedBits.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-Syntax

		//
		// emit production tree node associated with any production of syntax rule MC-Syntax
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_Syntax_1:
					// emit syntax tree node associated with production
					// MC-Syntax: Type

					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_MC_Syntax_2:
					// emit syntax tree node associated with production
					// MC-Syntax: BITS "{" MC-NamedBits "}"

					s += m_BITS.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_MC_NamedBits.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-Syntax
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_Syntax (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_Syntax_1:
					// emit syntax tree node associated with production
					// MC-Syntax: Type

					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MC_Syntax_2:
					// emit syntax tree node associated with production
					// MC-Syntax: BITS "{" MC-NamedBits "}"

					s += "BITS";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_MC_NamedBits.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-Syntax

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Syntax with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_Syntax.production_kind kind = (MC_Syntax.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_Syntax.production_kind.g_MC_Syntax_1:
					// traverse syntax tree node associated with production
					// MC-Syntax: Type

						m_Type.Visit (visitor, appData);
				break;
				case MC_Syntax.production_kind.g_MC_Syntax_2:
					// traverse syntax tree node associated with production
					// MC-Syntax: BITS "{" MC-NamedBits "}"

						m_BITS.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_MC_NamedBits.Visit (visitor, appData);
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
			m_MC_NamedBits?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MC-Syntax
		//

		public void _init ()
		{
			m_Type = null;
			m_BITS = null;
			m_left_curly_bracket = null;
			m_MC_NamedBits = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-Syntax

		// counter of all nodes associated with syntax rule MC-Syntax
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-Syntax
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_BITS")] public SyntaxTreeToken m_BITS { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_MC_NamedBits")] public MC_NamedBits m_MC_NamedBits { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-Syntax

		// delegate function (callback) prototype associated with syntax rule MC-Syntax
		public delegate bool MC_Syntax_Callback (SyntaxTreeCallbackReason reason, MC_Syntax.production_kind kind, MC_Syntax p_MC_Syntax);

		// event associated with syntax rule MC-Syntax
		public event MC_Syntax_Callback MC_Syntax_Event;

		// event trigger associated with syntax rule MC-Syntax
		public bool Raise_MC_Syntax_Event (SyntaxTreeCallbackReason reason, MC_Syntax.production_kind kind, MC_Syntax p_MC_Syntax)
		{
			bool? status = MC_Syntax_Event?.Invoke (reason, kind, p_MC_Syntax);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-Syntax
		//
		// traverse syntax tree node associated with any production of syntax rule MC-Syntax
		//

		public void Traverse (MC_Syntax p_MC_Syntax)
		{
			if (p_MC_Syntax.isLocked())
				return;
			p_MC_Syntax.dolock();
			MC_Syntax.production_kind kind = (MC_Syntax.production_kind) p_MC_Syntax.kind;
			p_MC_Syntax.turn_reset ();
			if (Raise_MC_Syntax_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_Syntax))
			switch (kind)
			{
				case MC_Syntax.production_kind.g_MC_Syntax_1:
					// traverse syntax tree node associated with production
					// MC-Syntax: Type

					if (Raise_MC_Syntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Syntax))
						Traverse (p_MC_Syntax.m_Type);
					p_MC_Syntax.turn_inc ();
					Raise_MC_Syntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Syntax);
				break;
				case MC_Syntax.production_kind.g_MC_Syntax_2:
					// traverse syntax tree node associated with production
					// MC-Syntax: BITS "{" MC-NamedBits "}"

					if (Raise_MC_Syntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Syntax))
						Traverse (p_MC_Syntax.m_MC_NamedBits);
					p_MC_Syntax.turn_inc ();
					Raise_MC_Syntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Syntax);
				break;
			}
			Raise_MC_Syntax_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_Syntax);
			p_MC_Syntax.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Syntax
		//

		public void TraverseCommon (MC_Syntax p_MC_Syntax)
		{
			MC_Syntax.production_kind kind = (MC_Syntax.production_kind) p_MC_Syntax.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_Syntax))
			switch (kind)
			{
				case MC_Syntax.production_kind.g_MC_Syntax_1:
					// traverse syntax tree node associated with production
					// MC-Syntax: Type

						TraverseCommon (p_MC_Syntax.m_Type);
				break;
				case MC_Syntax.production_kind.g_MC_Syntax_2:
					// traverse syntax tree node associated with production
					// MC-Syntax: BITS "{" MC-NamedBits "}"

						TraverseCommon (p_MC_Syntax.m_BITS);
						TraverseCommon (p_MC_Syntax.m_left_curly_bracket);
						TraverseCommon (p_MC_Syntax.m_MC_NamedBits);
						TraverseCommon (p_MC_Syntax.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_Syntax);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-Syntax

		//
		// create syntax tree node associated with production
		// MC-Syntax: Type

		//

		public MC_Syntax MC_Syntax_1 (Type p_Type)
		{
			MC_Syntax p_MC_Syntax_ref = new MC_Syntax(p_Type);
			p_Type.parent = p_MC_Syntax_ref;
			Raise_MC_Syntax_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Syntax.production_kind.g_MC_Syntax_1, p_MC_Syntax_ref);
			return p_MC_Syntax_ref;
		}

		//
		// create syntax tree node associated with production
		// MC-Syntax: BITS "{" MC-NamedBits "}"

		//

		public MC_Syntax MC_Syntax_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, MC_NamedBits p_MC_NamedBits, SyntaxTreeToken p_token_2)
		{
			MC_Syntax p_MC_Syntax_ref = new MC_Syntax(p_token, p_token_1, p_MC_NamedBits, p_token_2);
			p_token.parent = p_MC_Syntax_ref;
			p_token_1.parent = p_MC_Syntax_ref;
			p_MC_NamedBits.parent = p_MC_Syntax_ref;
			p_token_2.parent = p_MC_Syntax_ref;
			Raise_MC_Syntax_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Syntax.production_kind.g_MC_Syntax_2, p_MC_Syntax_ref);
			return p_MC_Syntax_ref;
		}
		#endregion
	};
}
