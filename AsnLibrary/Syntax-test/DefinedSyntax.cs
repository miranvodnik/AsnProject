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
	// class associated with syntax rule DefinedSyntax
	//

	[DataContract]
	public class	DefinedSyntax : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinedSyntax
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinedSyntax
		{
			g_DefinedSyntax_1 = 1,	// "{" "}"

			g_DefinedSyntax_2 = 2,	// "{" DefinedSyntaxToken-set "}"

		};
		#endregion
		#region production markers associated with the syntax rule DefinedSyntax

		// markers associated with production: DefinedSyntax -> "{" "}"

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: DefinedSyntax -> "{" DefinedSyntaxToken-set "}"

		public enum production_marker_2 : ushort
		{
			m_DefinedSyntaxToken_set,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinedSyntax

		// Constructor declaration(s) associated with production(s) of syntax rule DefinedSyntax

		//
		// Constructor associated with the following production(s)
		// DefinedSyntax -> "{" "}"

		//

		public DefinedSyntax (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._DefinedSyntax_ID, (uint) production_kind.g_DefinedSyntax_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_right_curly_bracket = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// DefinedSyntax -> "{" DefinedSyntaxToken-set "}"

		//

		public DefinedSyntax (SyntaxTreeToken p_token, DefinedSyntaxToken_set p_DefinedSyntaxToken_set, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._DefinedSyntax_ID, (uint) production_kind.g_DefinedSyntax_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_DefinedSyntaxToken_set = p_DefinedSyntaxToken_set;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public DefinedSyntax () { }

		// Copy constructor

		public DefinedSyntax (DefinedSyntax p_DefinedSyntax) : base (p_DefinedSyntax.id, p_DefinedSyntax.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinedSyntax.appInfo;
			switch ((production_kind) p_DefinedSyntax.kind)
			{
				case production_kind.g_DefinedSyntax_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_left_curly_bracket = (p_DefinedSyntax.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_DefinedSyntax.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_right_curly_bracket = (p_DefinedSyntax.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_DefinedSyntax.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_DefinedSyntax_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_DefinedSyntax.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_DefinedSyntax.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_DefinedSyntaxToken_set = (p_DefinedSyntax.m_DefinedSyntaxToken_set != null) ? new DefinedSyntaxToken_set (p_DefinedSyntax.m_DefinedSyntaxToken_set) : null) != null) m_DefinedSyntaxToken_set.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_DefinedSyntax.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_DefinedSyntax.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinedSyntax" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinedSyntax (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_right_curly_bracket?.Dispose ();
			m_DefinedSyntaxToken_set?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinedSyntax

		// Content changing function(s) associated with production(s) of syntax rule DefinedSyntax

		//
		// Content changing function associated with following production(s)
		// DefinedSyntax -> "{" "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedSyntax_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinedSyntax -> "{" DefinedSyntaxToken-set "}"

		//

		public void change(SyntaxTreeToken p_token, DefinedSyntaxToken_set p_DefinedSyntaxToken_set, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedSyntax_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_DefinedSyntaxToken_set = p_DefinedSyntaxToken_set;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinedSyntax
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				(m_DefinedSyntaxToken_set != null) && m_DefinedSyntaxToken_set.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinedSyntax

		//
		// emit production tree node associated with any production of syntax rule DefinedSyntax
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinedSyntax_1:
					// emit syntax tree node associated with production
					// DefinedSyntax: "{" "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_DefinedSyntax_2:
					// emit syntax tree node associated with production
					// DefinedSyntax: "{" DefinedSyntaxToken-set "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_DefinedSyntaxToken_set.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinedSyntax
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinedSyntax (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinedSyntax_1:
					// emit syntax tree node associated with production
					// DefinedSyntax: "{" "}"

					s += "left_curly_bracket";
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_DefinedSyntax_2:
					// emit syntax tree node associated with production
					// DefinedSyntax: "{" DefinedSyntaxToken-set "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_DefinedSyntaxToken_set.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinedSyntax

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedSyntax with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinedSyntax.production_kind kind = (DefinedSyntax.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinedSyntax.production_kind.g_DefinedSyntax_1:
					// traverse syntax tree node associated with production
					// DefinedSyntax: "{" "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case DefinedSyntax.production_kind.g_DefinedSyntax_2:
					// traverse syntax tree node associated with production
					// DefinedSyntax: "{" DefinedSyntaxToken-set "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_DefinedSyntaxToken_set.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_left_curly_bracket?.reparent (this);
			m_right_curly_bracket?.reparent (this);
			m_DefinedSyntaxToken_set?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefinedSyntax
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_right_curly_bracket = null;
			m_DefinedSyntaxToken_set = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinedSyntax

		// counter of all nodes associated with syntax rule DefinedSyntax
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinedSyntax
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		[DataMember (Name = "m_DefinedSyntaxToken_set")] public DefinedSyntaxToken_set m_DefinedSyntaxToken_set { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinedSyntax

		// delegate function (callback) prototype associated with syntax rule DefinedSyntax
		public delegate bool DefinedSyntax_Callback (SyntaxTreeCallbackReason reason, DefinedSyntax.production_kind kind, DefinedSyntax p_DefinedSyntax);

		// event associated with syntax rule DefinedSyntax
		public event DefinedSyntax_Callback DefinedSyntax_Event;

		// event trigger associated with syntax rule DefinedSyntax
		public bool Raise_DefinedSyntax_Event (SyntaxTreeCallbackReason reason, DefinedSyntax.production_kind kind, DefinedSyntax p_DefinedSyntax)
		{
			bool? status = DefinedSyntax_Event?.Invoke (reason, kind, p_DefinedSyntax);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinedSyntax
		//
		// traverse syntax tree node associated with any production of syntax rule DefinedSyntax
		//

		public void Traverse (DefinedSyntax p_DefinedSyntax)
		{
			if (p_DefinedSyntax.isLocked())
				return;
			p_DefinedSyntax.dolock();
			DefinedSyntax.production_kind kind = (DefinedSyntax.production_kind) p_DefinedSyntax.kind;
			p_DefinedSyntax.turn_reset ();
			if (Raise_DefinedSyntax_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinedSyntax))
			switch (kind)
			{
				case DefinedSyntax.production_kind.g_DefinedSyntax_1:
					// traverse syntax tree node associated with production
					// DefinedSyntax: "{" "}"

				break;
				case DefinedSyntax.production_kind.g_DefinedSyntax_2:
					// traverse syntax tree node associated with production
					// DefinedSyntax: "{" DefinedSyntaxToken-set "}"

					if (Raise_DefinedSyntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedSyntax))
						Traverse (p_DefinedSyntax.m_DefinedSyntaxToken_set);
					p_DefinedSyntax.turn_inc ();
					Raise_DefinedSyntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedSyntax);
				break;
			}
			Raise_DefinedSyntax_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinedSyntax);
			p_DefinedSyntax.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedSyntax
		//

		public void TraverseCommon (DefinedSyntax p_DefinedSyntax)
		{
			DefinedSyntax.production_kind kind = (DefinedSyntax.production_kind) p_DefinedSyntax.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinedSyntax))
			switch (kind)
			{
				case DefinedSyntax.production_kind.g_DefinedSyntax_1:
					// traverse syntax tree node associated with production
					// DefinedSyntax: "{" "}"

						TraverseCommon (p_DefinedSyntax.m_left_curly_bracket);
						TraverseCommon (p_DefinedSyntax.m_right_curly_bracket);
				break;
				case DefinedSyntax.production_kind.g_DefinedSyntax_2:
					// traverse syntax tree node associated with production
					// DefinedSyntax: "{" DefinedSyntaxToken-set "}"

						TraverseCommon (p_DefinedSyntax.m_left_curly_bracket);
						TraverseCommon (p_DefinedSyntax.m_DefinedSyntaxToken_set);
						TraverseCommon (p_DefinedSyntax.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinedSyntax);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinedSyntax

		//
		// create syntax tree node associated with production
		// DefinedSyntax: "{" "}"

		//

		public DefinedSyntax DefinedSyntax_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			DefinedSyntax p_DefinedSyntax_ref = new DefinedSyntax(p_token, p_token_1);
			p_token.parent = p_DefinedSyntax_ref;
			p_token_1.parent = p_DefinedSyntax_ref;
			Raise_DefinedSyntax_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedSyntax.production_kind.g_DefinedSyntax_1, p_DefinedSyntax_ref);
			return p_DefinedSyntax_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinedSyntax: "{" DefinedSyntaxToken-set "}"

		//

		public DefinedSyntax DefinedSyntax_2 (SyntaxTreeToken p_token, DefinedSyntaxToken_set p_DefinedSyntaxToken_set, SyntaxTreeToken p_token_1)
		{
			DefinedSyntax p_DefinedSyntax_ref = new DefinedSyntax(p_token, p_DefinedSyntaxToken_set, p_token_1);
			p_token.parent = p_DefinedSyntax_ref;
			p_DefinedSyntaxToken_set.parent = p_DefinedSyntax_ref;
			p_token_1.parent = p_DefinedSyntax_ref;
			Raise_DefinedSyntax_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedSyntax.production_kind.g_DefinedSyntax_2, p_DefinedSyntax_ref);
			return p_DefinedSyntax_ref;
		}
		#endregion
	};
}
