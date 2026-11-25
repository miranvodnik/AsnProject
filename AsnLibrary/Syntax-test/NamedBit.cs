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
	// class associated with syntax rule NamedBit
	//

	[DataContract]
	public class	NamedBit : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NamedBit
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NamedBit
		{
			g_NamedBit_1 = 1,	// identifier-token "(" number ")"

			g_NamedBit_2 = 2,	// identifier-token "(" DefinedValue ")"

		};
		#endregion
		#region production markers associated with the syntax rule NamedBit

		// markers associated with production: NamedBit -> identifier-token "(" number ")"

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};

		// markers associated with production: NamedBit -> identifier-token "(" DefinedValue ")"

		public enum production_marker_2 : ushort
		{
			m_identifier_token,
			m_DefinedValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NamedBit

		// Constructor declaration(s) associated with production(s) of syntax rule NamedBit

		//
		// Constructor associated with the following production(s)
		// NamedBit -> identifier-token "(" number ")"

		//

		public NamedBit (identifier_token p_identifier_token, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._NamedBit_ID, (uint) production_kind.g_NamedBit_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_left_round_bracket = p_token;
			children[2] = m_number = p_token_1;
			children[3] = m_right_round_bracket = p_token_2;
		}

		//
		// Constructor associated with the following production(s)
		// NamedBit -> identifier-token "(" DefinedValue ")"

		//

		public NamedBit (identifier_token p_identifier_token, SyntaxTreeToken p_token, DefinedValue p_DefinedValue, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._NamedBit_ID, (uint) production_kind.g_NamedBit_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_left_round_bracket = p_token;
			children[2] = m_DefinedValue = p_DefinedValue;
			children[3] = m_right_round_bracket = p_token_1;
		}

		public NamedBit () { }

		// Copy constructor

		public NamedBit (NamedBit p_NamedBit) : base (p_NamedBit.id, p_NamedBit.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NamedBit.appInfo;
			switch ((production_kind) p_NamedBit.kind)
			{
				case production_kind.g_NamedBit_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_identifier_token = (p_NamedBit.m_identifier_token != null) ? new identifier_token (p_NamedBit.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_left_round_bracket = (p_NamedBit.m_left_round_bracket != null) ? new SyntaxTreeToken (p_NamedBit.m_left_round_bracket) : null) != null) m_left_round_bracket.parent = this;
					if ((children [2] = m_number = (p_NamedBit.m_number != null) ? new SyntaxTreeToken (p_NamedBit.m_number) : null) != null) m_number.parent = this;
					if ((children [3] = m_right_round_bracket = (p_NamedBit.m_right_round_bracket != null) ? new SyntaxTreeToken (p_NamedBit.m_right_round_bracket) : null) != null) m_right_round_bracket.parent = this;
					break;
				case production_kind.g_NamedBit_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_identifier_token = (p_NamedBit.m_identifier_token != null) ? new identifier_token (p_NamedBit.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_left_round_bracket = (p_NamedBit.m_left_round_bracket != null) ? new SyntaxTreeToken (p_NamedBit.m_left_round_bracket) : null) != null) m_left_round_bracket.parent = this;
					if ((children [2] = m_DefinedValue = (p_NamedBit.m_DefinedValue != null) ? new DefinedValue (p_NamedBit.m_DefinedValue) : null) != null) m_DefinedValue.parent = this;
					if ((children [3] = m_right_round_bracket = (p_NamedBit.m_right_round_bracket != null) ? new SyntaxTreeToken (p_NamedBit.m_right_round_bracket) : null) != null) m_right_round_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NamedBit" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NamedBit (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_left_round_bracket?.Dispose ();
			m_number?.Dispose ();
			m_right_round_bracket?.Dispose ();
			m_DefinedValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NamedBit

		// Content changing function(s) associated with production(s) of syntax rule NamedBit

		//
		// Content changing function associated with following production(s)
		// NamedBit -> identifier-token "(" number ")"

		//

		public void change(identifier_token p_identifier_token, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedBit_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_left_round_bracket = p_token;
			children [2] = m_number = p_token_1;
			children [3] = m_right_round_bracket = p_token_2;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NamedBit -> identifier-token "(" DefinedValue ")"

		//

		public void change(identifier_token p_identifier_token, SyntaxTreeToken p_token, DefinedValue p_DefinedValue, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedBit_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_left_round_bracket = p_token;
			children [2] = m_DefinedValue = p_DefinedValue;
			children [3] = m_right_round_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NamedBit
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_left_round_bracket != null) && m_left_round_bracket.checkInclusion (element) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				(m_right_round_bracket != null) && m_right_round_bracket.checkInclusion (element) ||
				(m_DefinedValue != null) && m_DefinedValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NamedBit

		//
		// emit production tree node associated with any production of syntax rule NamedBit
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NamedBit_1:
					// emit syntax tree node associated with production
					// NamedBit: identifier-token "(" number ")"

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_left_round_bracket.Emit (depth - 1);
					s += " ";
					s += m_number.Emit (depth - 1);
					s += " ";
					s += m_right_round_bracket.Emit (depth - 1);
				break;
				case production_kind.g_NamedBit_2:
					// emit syntax tree node associated with production
					// NamedBit: identifier-token "(" DefinedValue ")"

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_left_round_bracket.Emit (depth - 1);
					s += " ";
					s += m_DefinedValue.Emit (depth - 1);
					s += " ";
					s += m_right_round_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NamedBit
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NamedBit (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NamedBit_1:
					// emit syntax tree node associated with production
					// NamedBit: identifier-token "(" number ")"

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "left_round_bracket";
					s += ' ';
					s += "number";
					s += ' ';
					s += "right_round_bracket";
				break;
				case production_kind.g_NamedBit_2:
					// emit syntax tree node associated with production
					// NamedBit: identifier-token "(" DefinedValue ")"

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "left_round_bracket";
					s += ' ';
					s += m_DefinedValue.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_round_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NamedBit

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NamedBit with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NamedBit.production_kind kind = (NamedBit.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NamedBit.production_kind.g_NamedBit_1:
					// traverse syntax tree node associated with production
					// NamedBit: identifier-token "(" number ")"

						m_identifier_token.Visit (visitor, appData);
						m_left_round_bracket.Visit (visitor, appData);
						m_number.Visit (visitor, appData);
						m_right_round_bracket.Visit (visitor, appData);
				break;
				case NamedBit.production_kind.g_NamedBit_2:
					// traverse syntax tree node associated with production
					// NamedBit: identifier-token "(" DefinedValue ")"

						m_identifier_token.Visit (visitor, appData);
						m_left_round_bracket.Visit (visitor, appData);
						m_DefinedValue.Visit (visitor, appData);
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
			m_DefinedValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NamedBit
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_left_round_bracket = null;
			m_number = null;
			m_right_round_bracket = null;
			m_DefinedValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NamedBit

		// counter of all nodes associated with syntax rule NamedBit
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NamedBit
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_left_round_bracket")] public SyntaxTreeToken m_left_round_bracket { get; private set; }
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		[DataMember (Name = "m_right_round_bracket")] public SyntaxTreeToken m_right_round_bracket { get; private set; }
		[DataMember (Name = "m_DefinedValue")] public DefinedValue m_DefinedValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NamedBit

		// delegate function (callback) prototype associated with syntax rule NamedBit
		public delegate bool NamedBit_Callback (SyntaxTreeCallbackReason reason, NamedBit.production_kind kind, NamedBit p_NamedBit);

		// event associated with syntax rule NamedBit
		public event NamedBit_Callback NamedBit_Event;

		// event trigger associated with syntax rule NamedBit
		public bool Raise_NamedBit_Event (SyntaxTreeCallbackReason reason, NamedBit.production_kind kind, NamedBit p_NamedBit)
		{
			bool? status = NamedBit_Event?.Invoke (reason, kind, p_NamedBit);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NamedBit
		//
		// traverse syntax tree node associated with any production of syntax rule NamedBit
		//

		public void Traverse (NamedBit p_NamedBit)
		{
			if (p_NamedBit.isLocked())
				return;
			p_NamedBit.dolock();
			NamedBit.production_kind kind = (NamedBit.production_kind) p_NamedBit.kind;
			p_NamedBit.turn_reset ();
			if (Raise_NamedBit_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NamedBit))
			switch (kind)
			{
				case NamedBit.production_kind.g_NamedBit_1:
					// traverse syntax tree node associated with production
					// NamedBit: identifier-token "(" number ")"

					if (Raise_NamedBit_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedBit))
						Traverse (p_NamedBit.m_identifier_token);
					p_NamedBit.turn_inc ();
					Raise_NamedBit_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedBit);
				break;
				case NamedBit.production_kind.g_NamedBit_2:
					// traverse syntax tree node associated with production
					// NamedBit: identifier-token "(" DefinedValue ")"

					if (Raise_NamedBit_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedBit))
						Traverse (p_NamedBit.m_identifier_token);
					p_NamedBit.turn_inc ();
					if (Raise_NamedBit_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedBit))
						Traverse (p_NamedBit.m_DefinedValue);
					p_NamedBit.turn_inc ();
					Raise_NamedBit_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedBit);
				break;
			}
			Raise_NamedBit_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NamedBit);
			p_NamedBit.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NamedBit
		//

		public void TraverseCommon (NamedBit p_NamedBit)
		{
			NamedBit.production_kind kind = (NamedBit.production_kind) p_NamedBit.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NamedBit))
			switch (kind)
			{
				case NamedBit.production_kind.g_NamedBit_1:
					// traverse syntax tree node associated with production
					// NamedBit: identifier-token "(" number ")"

						TraverseCommon (p_NamedBit.m_identifier_token);
						TraverseCommon (p_NamedBit.m_left_round_bracket);
						TraverseCommon (p_NamedBit.m_number);
						TraverseCommon (p_NamedBit.m_right_round_bracket);
				break;
				case NamedBit.production_kind.g_NamedBit_2:
					// traverse syntax tree node associated with production
					// NamedBit: identifier-token "(" DefinedValue ")"

						TraverseCommon (p_NamedBit.m_identifier_token);
						TraverseCommon (p_NamedBit.m_left_round_bracket);
						TraverseCommon (p_NamedBit.m_DefinedValue);
						TraverseCommon (p_NamedBit.m_right_round_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NamedBit);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NamedBit

		//
		// create syntax tree node associated with production
		// NamedBit: identifier-token "(" number ")"

		//

		public NamedBit NamedBit_1 (identifier_token p_identifier_token, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			NamedBit p_NamedBit_ref = new NamedBit(p_identifier_token, p_token, p_token_1, p_token_2);
			p_identifier_token.parent = p_NamedBit_ref;
			p_token.parent = p_NamedBit_ref;
			p_token_1.parent = p_NamedBit_ref;
			p_token_2.parent = p_NamedBit_ref;
			Raise_NamedBit_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedBit.production_kind.g_NamedBit_1, p_NamedBit_ref);
			return p_NamedBit_ref;
		}

		//
		// create syntax tree node associated with production
		// NamedBit: identifier-token "(" DefinedValue ")"

		//

		public NamedBit NamedBit_2 (identifier_token p_identifier_token, SyntaxTreeToken p_token, DefinedValue p_DefinedValue, SyntaxTreeToken p_token_1)
		{
			NamedBit p_NamedBit_ref = new NamedBit(p_identifier_token, p_token, p_DefinedValue, p_token_1);
			p_identifier_token.parent = p_NamedBit_ref;
			p_token.parent = p_NamedBit_ref;
			p_DefinedValue.parent = p_NamedBit_ref;
			p_token_1.parent = p_NamedBit_ref;
			Raise_NamedBit_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedBit.production_kind.g_NamedBit_2, p_NamedBit_ref);
			return p_NamedBit_ref;
		}
		#endregion
	};
}
