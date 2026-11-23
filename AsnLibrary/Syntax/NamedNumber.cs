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
	// class associated with syntax rule NamedNumber
	//

	[DataContract]
	public class	NamedNumber : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NamedNumber
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NamedNumber
		{
			g_NamedNumber_1 = 1,	// identifier-token "(" SignedNumber ")"

			g_NamedNumber_2 = 2,	// identifier-token "(" DefinedValue ")"

		};
		#endregion
		#region production markers associated with the syntax rule NamedNumber

		// markers associated with production: NamedNumber -> identifier-token "(" SignedNumber ")"

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			m_SignedNumber,
			final
		};

		// markers associated with production: NamedNumber -> identifier-token "(" DefinedValue ")"

		public enum production_marker_2 : ushort
		{
			m_identifier_token,
			m_DefinedValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NamedNumber

		// Constructor declaration(s) associated with production(s) of syntax rule NamedNumber

		//
		// Constructor associated with the following production(s)
		// NamedNumber -> identifier-token "(" SignedNumber ")"

		//

		public NamedNumber (identifier_token p_identifier_token, SyntaxTreeToken p_token, SignedNumber p_SignedNumber, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._NamedNumber_ID, (uint) production_kind.g_NamedNumber_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_left_round_bracket = p_token;
			children[2] = m_SignedNumber = p_SignedNumber;
			children[3] = m_right_round_bracket = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// NamedNumber -> identifier-token "(" DefinedValue ")"

		//

		public NamedNumber (identifier_token p_identifier_token, SyntaxTreeToken p_token, DefinedValue p_DefinedValue, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._NamedNumber_ID, (uint) production_kind.g_NamedNumber_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_left_round_bracket = p_token;
			children[2] = m_DefinedValue = p_DefinedValue;
			children[3] = m_right_round_bracket = p_token_1;
		}

		public NamedNumber () { }

		// Copy constructor

		public NamedNumber (NamedNumber p_NamedNumber) : base (p_NamedNumber.id, p_NamedNumber.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NamedNumber.appInfo;
			switch ((production_kind) p_NamedNumber.kind)
			{
				case production_kind.g_NamedNumber_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_identifier_token = (p_NamedNumber.m_identifier_token != null) ? new identifier_token (p_NamedNumber.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_left_round_bracket = (p_NamedNumber.m_left_round_bracket != null) ? new SyntaxTreeToken (p_NamedNumber.m_left_round_bracket) : null) != null) m_left_round_bracket.parent = this;
					if ((children [2] = m_SignedNumber = (p_NamedNumber.m_SignedNumber != null) ? new SignedNumber (p_NamedNumber.m_SignedNumber) : null) != null) m_SignedNumber.parent = this;
					if ((children [3] = m_right_round_bracket = (p_NamedNumber.m_right_round_bracket != null) ? new SyntaxTreeToken (p_NamedNumber.m_right_round_bracket) : null) != null) m_right_round_bracket.parent = this;
					break;
				case production_kind.g_NamedNumber_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_identifier_token = (p_NamedNumber.m_identifier_token != null) ? new identifier_token (p_NamedNumber.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_left_round_bracket = (p_NamedNumber.m_left_round_bracket != null) ? new SyntaxTreeToken (p_NamedNumber.m_left_round_bracket) : null) != null) m_left_round_bracket.parent = this;
					if ((children [2] = m_DefinedValue = (p_NamedNumber.m_DefinedValue != null) ? new DefinedValue (p_NamedNumber.m_DefinedValue) : null) != null) m_DefinedValue.parent = this;
					if ((children [3] = m_right_round_bracket = (p_NamedNumber.m_right_round_bracket != null) ? new SyntaxTreeToken (p_NamedNumber.m_right_round_bracket) : null) != null) m_right_round_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NamedNumber" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NamedNumber (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_left_round_bracket?.Dispose ();
			m_SignedNumber?.Dispose ();
			m_right_round_bracket?.Dispose ();
			m_DefinedValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NamedNumber

		// Content changing function(s) associated with production(s) of syntax rule NamedNumber

		//
		// Content changing function associated with following production(s)
		// NamedNumber -> identifier-token "(" SignedNumber ")"

		//

		public void change(identifier_token p_identifier_token, SyntaxTreeToken p_token, SignedNumber p_SignedNumber, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedNumber_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_left_round_bracket = p_token;
			children [2] = m_SignedNumber = p_SignedNumber;
			children [3] = m_right_round_bracket = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NamedNumber -> identifier-token "(" DefinedValue ")"

		//

		public void change(identifier_token p_identifier_token, SyntaxTreeToken p_token, DefinedValue p_DefinedValue, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedNumber_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_left_round_bracket = p_token;
			children [2] = m_DefinedValue = p_DefinedValue;
			children [3] = m_right_round_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NamedNumber
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_left_round_bracket != null) && m_left_round_bracket.checkInclusion (element) ||
				(m_SignedNumber != null) && m_SignedNumber.checkInclusion (element) ||
				(m_right_round_bracket != null) && m_right_round_bracket.checkInclusion (element) ||
				(m_DefinedValue != null) && m_DefinedValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NamedNumber

		//
		// emit production tree node associated with any production of syntax rule NamedNumber
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NamedNumber_1:
					// emit syntax tree node associated with production
					// NamedNumber: identifier-token "(" SignedNumber ")"

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_left_round_bracket.Emit (depth - 1);
					s += " ";
					s += m_SignedNumber.Emit (depth - 1);
					s += " ";
					s += m_right_round_bracket.Emit (depth - 1);
				break;
				case production_kind.g_NamedNumber_2:
					// emit syntax tree node associated with production
					// NamedNumber: identifier-token "(" DefinedValue ")"

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
		// emit production tree node associated with any production of syntax rule NamedNumber
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NamedNumber (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NamedNumber_1:
					// emit syntax tree node associated with production
					// NamedNumber: identifier-token "(" SignedNumber ")"

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "left_round_bracket";
					s += ' ';
					s += m_SignedNumber.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_round_bracket";
				break;
				case production_kind.g_NamedNumber_2:
					// emit syntax tree node associated with production
					// NamedNumber: identifier-token "(" DefinedValue ")"

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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NamedNumber

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NamedNumber with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NamedNumber.production_kind kind = (NamedNumber.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NamedNumber.production_kind.g_NamedNumber_1:
					// traverse syntax tree node associated with production
					// NamedNumber: identifier-token "(" SignedNumber ")"

						m_identifier_token.Visit (visitor, appData);
						m_left_round_bracket.Visit (visitor, appData);
						m_SignedNumber.Visit (visitor, appData);
						m_right_round_bracket.Visit (visitor, appData);
				break;
				case NamedNumber.production_kind.g_NamedNumber_2:
					// traverse syntax tree node associated with production
					// NamedNumber: identifier-token "(" DefinedValue ")"

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
			m_SignedNumber?.reparent (this);
			m_right_round_bracket?.reparent (this);
			m_DefinedValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NamedNumber
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_left_round_bracket = null;
			m_SignedNumber = null;
			m_right_round_bracket = null;
			m_DefinedValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NamedNumber

		// counter of all nodes associated with syntax rule NamedNumber
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NamedNumber
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_left_round_bracket")] public SyntaxTreeToken m_left_round_bracket { get; private set; }
		[DataMember (Name = "m_SignedNumber")] public SignedNumber m_SignedNumber { get; private set; }
		[DataMember (Name = "m_right_round_bracket")] public SyntaxTreeToken m_right_round_bracket { get; private set; }
		[DataMember (Name = "m_DefinedValue")] public DefinedValue m_DefinedValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NamedNumber

		// delegate function (callback) prototype associated with syntax rule NamedNumber
		public delegate bool NamedNumber_Callback (SyntaxTreeCallbackReason reason, NamedNumber.production_kind kind, NamedNumber p_NamedNumber);

		// event associated with syntax rule NamedNumber
		public event NamedNumber_Callback NamedNumber_Event;

		// event trigger associated with syntax rule NamedNumber
		public bool Raise_NamedNumber_Event (SyntaxTreeCallbackReason reason, NamedNumber.production_kind kind, NamedNumber p_NamedNumber)
		{
			bool? status = NamedNumber_Event?.Invoke (reason, kind, p_NamedNumber);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NamedNumber
		//
		// traverse syntax tree node associated with any production of syntax rule NamedNumber
		//

		public void Traverse (NamedNumber p_NamedNumber)
		{
			if (p_NamedNumber.isLocked())
				return;
			p_NamedNumber.dolock();
			NamedNumber.production_kind kind = (NamedNumber.production_kind) p_NamedNumber.kind;
			p_NamedNumber.turn_reset ();
			if (Raise_NamedNumber_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NamedNumber))
			switch (kind)
			{
				case NamedNumber.production_kind.g_NamedNumber_1:
					// traverse syntax tree node associated with production
					// NamedNumber: identifier-token "(" SignedNumber ")"

					if (Raise_NamedNumber_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedNumber))
						Traverse (p_NamedNumber.m_identifier_token);
					p_NamedNumber.turn_inc ();
					if (Raise_NamedNumber_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedNumber))
						Traverse (p_NamedNumber.m_SignedNumber);
					p_NamedNumber.turn_inc ();
					Raise_NamedNumber_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedNumber);
				break;
				case NamedNumber.production_kind.g_NamedNumber_2:
					// traverse syntax tree node associated with production
					// NamedNumber: identifier-token "(" DefinedValue ")"

					if (Raise_NamedNumber_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedNumber))
						Traverse (p_NamedNumber.m_identifier_token);
					p_NamedNumber.turn_inc ();
					if (Raise_NamedNumber_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedNumber))
						Traverse (p_NamedNumber.m_DefinedValue);
					p_NamedNumber.turn_inc ();
					Raise_NamedNumber_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedNumber);
				break;
			}
			Raise_NamedNumber_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NamedNumber);
			p_NamedNumber.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NamedNumber
		//

		public void TraverseCommon (NamedNumber p_NamedNumber)
		{
			NamedNumber.production_kind kind = (NamedNumber.production_kind) p_NamedNumber.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NamedNumber))
			switch (kind)
			{
				case NamedNumber.production_kind.g_NamedNumber_1:
					// traverse syntax tree node associated with production
					// NamedNumber: identifier-token "(" SignedNumber ")"

						TraverseCommon (p_NamedNumber.m_identifier_token);
						TraverseCommon (p_NamedNumber.m_left_round_bracket);
						TraverseCommon (p_NamedNumber.m_SignedNumber);
						TraverseCommon (p_NamedNumber.m_right_round_bracket);
				break;
				case NamedNumber.production_kind.g_NamedNumber_2:
					// traverse syntax tree node associated with production
					// NamedNumber: identifier-token "(" DefinedValue ")"

						TraverseCommon (p_NamedNumber.m_identifier_token);
						TraverseCommon (p_NamedNumber.m_left_round_bracket);
						TraverseCommon (p_NamedNumber.m_DefinedValue);
						TraverseCommon (p_NamedNumber.m_right_round_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NamedNumber);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NamedNumber

		//
		// create syntax tree node associated with production
		// NamedNumber: identifier-token "(" SignedNumber ")"

		//

		public NamedNumber NamedNumber_1 (identifier_token p_identifier_token, SyntaxTreeToken p_token, SignedNumber p_SignedNumber, SyntaxTreeToken p_token_1)
		{
			NamedNumber p_NamedNumber_ref = new NamedNumber(p_identifier_token, p_token, p_SignedNumber, p_token_1);
			p_identifier_token.parent = p_NamedNumber_ref;
			p_token.parent = p_NamedNumber_ref;
			p_SignedNumber.parent = p_NamedNumber_ref;
			p_token_1.parent = p_NamedNumber_ref;
			Raise_NamedNumber_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedNumber.production_kind.g_NamedNumber_1, p_NamedNumber_ref);
			return p_NamedNumber_ref;
		}

		//
		// create syntax tree node associated with production
		// NamedNumber: identifier-token "(" DefinedValue ")"

		//

		public NamedNumber NamedNumber_2 (identifier_token p_identifier_token, SyntaxTreeToken p_token, DefinedValue p_DefinedValue, SyntaxTreeToken p_token_1)
		{
			NamedNumber p_NamedNumber_ref = new NamedNumber(p_identifier_token, p_token, p_DefinedValue, p_token_1);
			p_identifier_token.parent = p_NamedNumber_ref;
			p_token.parent = p_NamedNumber_ref;
			p_DefinedValue.parent = p_NamedNumber_ref;
			p_token_1.parent = p_NamedNumber_ref;
			Raise_NamedNumber_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedNumber.production_kind.g_NamedNumber_2, p_NamedNumber_ref);
			return p_NamedNumber_ref;
		}
		#endregion
	};
}
