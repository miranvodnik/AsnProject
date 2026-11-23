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
	// class associated with syntax rule TC-NamedBit
	//

	[DataContract]
	public class	TC_NamedBit : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TC-NamedBit
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TC-NamedBit
		{
			g_TC_NamedBit_1 = 1,	// identifier-token "(" number ")"

		};
		#endregion
		#region production markers associated with the syntax rule TC-NamedBit

		// markers associated with production: TC-NamedBit -> identifier-token "(" number ")"

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TC-NamedBit

		// Constructor declaration(s) associated with production(s) of syntax rule TC-NamedBit

		//
		// Constructor associated with the following production(s)
		// TC-NamedBit -> identifier-token "(" number ")"

		//

		public TC_NamedBit (identifier_token p_identifier_token, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._TC_NamedBit_ID, (uint) production_kind.g_TC_NamedBit_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_left_round_bracket = p_token;
			children[2] = m_number = p_token_1;
			children[3] = m_right_round_bracket = p_token_2;
		}

		public TC_NamedBit () { }

		// Copy constructor

		public TC_NamedBit (TC_NamedBit p_TC_NamedBit) : base (p_TC_NamedBit.id, p_TC_NamedBit.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TC_NamedBit.appInfo;
			switch ((production_kind) p_TC_NamedBit.kind)
			{
				case production_kind.g_TC_NamedBit_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_identifier_token = (p_TC_NamedBit.m_identifier_token != null) ? new identifier_token (p_TC_NamedBit.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_left_round_bracket = (p_TC_NamedBit.m_left_round_bracket != null) ? new SyntaxTreeToken (p_TC_NamedBit.m_left_round_bracket) : null) != null) m_left_round_bracket.parent = this;
					if ((children [2] = m_number = (p_TC_NamedBit.m_number != null) ? new SyntaxTreeToken (p_TC_NamedBit.m_number) : null) != null) m_number.parent = this;
					if ((children [3] = m_right_round_bracket = (p_TC_NamedBit.m_right_round_bracket != null) ? new SyntaxTreeToken (p_TC_NamedBit.m_right_round_bracket) : null) != null) m_right_round_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TC_NamedBit" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TC_NamedBit (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_left_round_bracket?.Dispose ();
			m_number?.Dispose ();
			m_right_round_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TC-NamedBit

		// Content changing function(s) associated with production(s) of syntax rule TC-NamedBit

		//
		// Content changing function associated with following production(s)
		// TC-NamedBit -> identifier-token "(" number ")"

		//

		public void change(identifier_token p_identifier_token, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_TC_NamedBit_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_left_round_bracket = p_token;
			children [2] = m_number = p_token_1;
			children [3] = m_right_round_bracket = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TC-NamedBit
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_left_round_bracket != null) && m_left_round_bracket.checkInclusion (element) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				(m_right_round_bracket != null) && m_right_round_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TC-NamedBit

		//
		// emit production tree node associated with any production of syntax rule TC-NamedBit
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TC_NamedBit_1:
					// emit syntax tree node associated with production
					// TC-NamedBit: identifier-token "(" number ")"

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_left_round_bracket.Emit (depth - 1);
					s += " ";
					s += m_number.Emit (depth - 1);
					s += " ";
					s += m_right_round_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TC-NamedBit
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TC_NamedBit (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TC_NamedBit_1:
					// emit syntax tree node associated with production
					// TC-NamedBit: identifier-token "(" number ")"

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "left_round_bracket";
					s += ' ';
					s += "number";
					s += ' ';
					s += "right_round_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TC-NamedBit

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TC-NamedBit with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TC_NamedBit.production_kind kind = (TC_NamedBit.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TC_NamedBit.production_kind.g_TC_NamedBit_1:
					// traverse syntax tree node associated with production
					// TC-NamedBit: identifier-token "(" number ")"

						m_identifier_token.Visit (visitor, appData);
						m_left_round_bracket.Visit (visitor, appData);
						m_number.Visit (visitor, appData);
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
			m_number?.reparent (this);
			m_right_round_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TC-NamedBit
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_left_round_bracket = null;
			m_number = null;
			m_right_round_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TC-NamedBit

		// counter of all nodes associated with syntax rule TC-NamedBit
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TC-NamedBit
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_left_round_bracket")] public SyntaxTreeToken m_left_round_bracket { get; private set; }
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		[DataMember (Name = "m_right_round_bracket")] public SyntaxTreeToken m_right_round_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TC-NamedBit

		// delegate function (callback) prototype associated with syntax rule TC-NamedBit
		public delegate bool TC_NamedBit_Callback (SyntaxTreeCallbackReason reason, TC_NamedBit.production_kind kind, TC_NamedBit p_TC_NamedBit);

		// event associated with syntax rule TC-NamedBit
		public event TC_NamedBit_Callback TC_NamedBit_Event;

		// event trigger associated with syntax rule TC-NamedBit
		public bool Raise_TC_NamedBit_Event (SyntaxTreeCallbackReason reason, TC_NamedBit.production_kind kind, TC_NamedBit p_TC_NamedBit)
		{
			bool? status = TC_NamedBit_Event?.Invoke (reason, kind, p_TC_NamedBit);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TC-NamedBit
		//
		// traverse syntax tree node associated with any production of syntax rule TC-NamedBit
		//

		public void Traverse (TC_NamedBit p_TC_NamedBit)
		{
			if (p_TC_NamedBit.isLocked())
				return;
			p_TC_NamedBit.dolock();
			TC_NamedBit.production_kind kind = (TC_NamedBit.production_kind) p_TC_NamedBit.kind;
			p_TC_NamedBit.turn_reset ();
			if (Raise_TC_NamedBit_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TC_NamedBit))
			switch (kind)
			{
				case TC_NamedBit.production_kind.g_TC_NamedBit_1:
					// traverse syntax tree node associated with production
					// TC-NamedBit: identifier-token "(" number ")"

					if (Raise_TC_NamedBit_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TC_NamedBit))
						Traverse (p_TC_NamedBit.m_identifier_token);
					p_TC_NamedBit.turn_inc ();
					Raise_TC_NamedBit_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TC_NamedBit);
				break;
			}
			Raise_TC_NamedBit_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TC_NamedBit);
			p_TC_NamedBit.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TC-NamedBit
		//

		public void TraverseCommon (TC_NamedBit p_TC_NamedBit)
		{
			TC_NamedBit.production_kind kind = (TC_NamedBit.production_kind) p_TC_NamedBit.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TC_NamedBit))
			switch (kind)
			{
				case TC_NamedBit.production_kind.g_TC_NamedBit_1:
					// traverse syntax tree node associated with production
					// TC-NamedBit: identifier-token "(" number ")"

						TraverseCommon (p_TC_NamedBit.m_identifier_token);
						TraverseCommon (p_TC_NamedBit.m_left_round_bracket);
						TraverseCommon (p_TC_NamedBit.m_number);
						TraverseCommon (p_TC_NamedBit.m_right_round_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TC_NamedBit);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TC-NamedBit

		//
		// create syntax tree node associated with production
		// TC-NamedBit: identifier-token "(" number ")"

		//

		public TC_NamedBit TC_NamedBit_1 (identifier_token p_identifier_token, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			TC_NamedBit p_TC_NamedBit_ref = new TC_NamedBit(p_identifier_token, p_token, p_token_1, p_token_2);
			p_identifier_token.parent = p_TC_NamedBit_ref;
			p_token.parent = p_TC_NamedBit_ref;
			p_token_1.parent = p_TC_NamedBit_ref;
			p_token_2.parent = p_TC_NamedBit_ref;
			Raise_TC_NamedBit_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TC_NamedBit.production_kind.g_TC_NamedBit_1, p_TC_NamedBit_ref);
			return p_TC_NamedBit_ref;
		}
		#endregion
	};
}
