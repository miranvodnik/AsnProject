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
	// class associated with syntax rule NamedNumberItem
	//

	[DataContract]
	public class	NamedNumberItem : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NamedNumberItem
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NamedNumberItem
		{
			g_NamedNumberItem_1 = 1,	// identifier-token "(" SignedNumber ")"

			g_NamedNumberItem_2 = 2,	// identifier-token "(" DefinedValue ")"

		};
		#endregion
		#region production markers associated with the syntax rule NamedNumberItem

		// markers associated with production: NamedNumberItem -> identifier-token "(" SignedNumber ")"

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			m_SignedNumber,
			final
		};

		// markers associated with production: NamedNumberItem -> identifier-token "(" DefinedValue ")"

		public enum production_marker_2 : ushort
		{
			m_identifier_token,
			m_DefinedValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NamedNumberItem

		// Constructor declaration(s) associated with production(s) of syntax rule NamedNumberItem

		//
		// Constructor associated with the following production(s)
		// NamedNumberItem -> identifier-token "(" SignedNumber ")"

		//

		public NamedNumberItem (identifier_token p_identifier_token, SyntaxTreeToken p_token, SignedNumber p_SignedNumber, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._NamedNumberItem_ID, (uint) production_kind.g_NamedNumberItem_1)
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
		// NamedNumberItem -> identifier-token "(" DefinedValue ")"

		//

		public NamedNumberItem (identifier_token p_identifier_token, SyntaxTreeToken p_token, DefinedValue p_DefinedValue, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._NamedNumberItem_ID, (uint) production_kind.g_NamedNumberItem_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_left_round_bracket = p_token;
			children[2] = m_DefinedValue = p_DefinedValue;
			children[3] = m_right_round_bracket = p_token_1;
		}

		public NamedNumberItem () { }

		// Copy constructor

		public NamedNumberItem (NamedNumberItem p_NamedNumberItem) : base (p_NamedNumberItem.id, p_NamedNumberItem.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NamedNumberItem.appInfo;
			switch ((production_kind) p_NamedNumberItem.kind)
			{
				case production_kind.g_NamedNumberItem_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_identifier_token = (p_NamedNumberItem.m_identifier_token != null) ? new identifier_token (p_NamedNumberItem.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_left_round_bracket = (p_NamedNumberItem.m_left_round_bracket != null) ? new SyntaxTreeToken (p_NamedNumberItem.m_left_round_bracket) : null) != null) m_left_round_bracket.parent = this;
					if ((children [2] = m_SignedNumber = (p_NamedNumberItem.m_SignedNumber != null) ? new SignedNumber (p_NamedNumberItem.m_SignedNumber) : null) != null) m_SignedNumber.parent = this;
					if ((children [3] = m_right_round_bracket = (p_NamedNumberItem.m_right_round_bracket != null) ? new SyntaxTreeToken (p_NamedNumberItem.m_right_round_bracket) : null) != null) m_right_round_bracket.parent = this;
					break;
				case production_kind.g_NamedNumberItem_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_identifier_token = (p_NamedNumberItem.m_identifier_token != null) ? new identifier_token (p_NamedNumberItem.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_left_round_bracket = (p_NamedNumberItem.m_left_round_bracket != null) ? new SyntaxTreeToken (p_NamedNumberItem.m_left_round_bracket) : null) != null) m_left_round_bracket.parent = this;
					if ((children [2] = m_DefinedValue = (p_NamedNumberItem.m_DefinedValue != null) ? new DefinedValue (p_NamedNumberItem.m_DefinedValue) : null) != null) m_DefinedValue.parent = this;
					if ((children [3] = m_right_round_bracket = (p_NamedNumberItem.m_right_round_bracket != null) ? new SyntaxTreeToken (p_NamedNumberItem.m_right_round_bracket) : null) != null) m_right_round_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NamedNumberItem" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NamedNumberItem (this); }

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
		#region Content changing and inclusion checking methods associated with the syntax rule NamedNumberItem

		// Content changing function(s) associated with production(s) of syntax rule NamedNumberItem

		//
		// Content changing function associated with following production(s)
		// NamedNumberItem -> identifier-token "(" SignedNumber ")"

		//

		public void change(identifier_token p_identifier_token, SyntaxTreeToken p_token, SignedNumber p_SignedNumber, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedNumberItem_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_left_round_bracket = p_token;
			children [2] = m_SignedNumber = p_SignedNumber;
			children [3] = m_right_round_bracket = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NamedNumberItem -> identifier-token "(" DefinedValue ")"

		//

		public void change(identifier_token p_identifier_token, SyntaxTreeToken p_token, DefinedValue p_DefinedValue, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedNumberItem_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_left_round_bracket = p_token;
			children [2] = m_DefinedValue = p_DefinedValue;
			children [3] = m_right_round_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NamedNumberItem
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
		#region Syntax tree emit methods associated with the syntax rule NamedNumberItem

		//
		// emit production tree node associated with any production of syntax rule NamedNumberItem
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NamedNumberItem_1:
					// emit syntax tree node associated with production
					// NamedNumberItem: identifier-token "(" SignedNumber ")"

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_left_round_bracket.Emit (depth - 1);
					s += " ";
					s += m_SignedNumber.Emit (depth - 1);
					s += " ";
					s += m_right_round_bracket.Emit (depth - 1);
				break;
				case production_kind.g_NamedNumberItem_2:
					// emit syntax tree node associated with production
					// NamedNumberItem: identifier-token "(" DefinedValue ")"

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
		// emit production tree node associated with any production of syntax rule NamedNumberItem
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NamedNumberItem (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NamedNumberItem_1:
					// emit syntax tree node associated with production
					// NamedNumberItem: identifier-token "(" SignedNumber ")"

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "left_round_bracket";
					s += ' ';
					s += m_SignedNumber.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_round_bracket";
				break;
				case production_kind.g_NamedNumberItem_2:
					// emit syntax tree node associated with production
					// NamedNumberItem: identifier-token "(" DefinedValue ")"

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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NamedNumberItem

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NamedNumberItem with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NamedNumberItem.production_kind kind = (NamedNumberItem.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NamedNumberItem.production_kind.g_NamedNumberItem_1:
					// traverse syntax tree node associated with production
					// NamedNumberItem: identifier-token "(" SignedNumber ")"

						m_identifier_token.Visit (visitor, appData);
						m_left_round_bracket.Visit (visitor, appData);
						m_SignedNumber.Visit (visitor, appData);
						m_right_round_bracket.Visit (visitor, appData);
				break;
				case NamedNumberItem.production_kind.g_NamedNumberItem_2:
					// traverse syntax tree node associated with production
					// NamedNumberItem: identifier-token "(" DefinedValue ")"

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
		// initialize object associated with syntax rule NamedNumberItem
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
		#region Fields and properties associated with the syntax rule NamedNumberItem

		// counter of all nodes associated with syntax rule NamedNumberItem
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NamedNumberItem
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_left_round_bracket")] public SyntaxTreeToken m_left_round_bracket { get; private set; }
		[DataMember (Name = "m_SignedNumber")] public SignedNumber m_SignedNumber { get; private set; }
		[DataMember (Name = "m_right_round_bracket")] public SyntaxTreeToken m_right_round_bracket { get; private set; }
		[DataMember (Name = "m_DefinedValue")] public DefinedValue m_DefinedValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NamedNumberItem

		// delegate function (callback) prototype associated with syntax rule NamedNumberItem
		public delegate bool NamedNumberItem_Callback (SyntaxTreeCallbackReason reason, NamedNumberItem.production_kind kind, NamedNumberItem p_NamedNumberItem);

		// event associated with syntax rule NamedNumberItem
		public event NamedNumberItem_Callback NamedNumberItem_Event;

		// event trigger associated with syntax rule NamedNumberItem
		public bool Raise_NamedNumberItem_Event (SyntaxTreeCallbackReason reason, NamedNumberItem.production_kind kind, NamedNumberItem p_NamedNumberItem)
		{
			bool? status = NamedNumberItem_Event?.Invoke (reason, kind, p_NamedNumberItem);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NamedNumberItem
		//
		// traverse syntax tree node associated with any production of syntax rule NamedNumberItem
		//

		public void Traverse (NamedNumberItem p_NamedNumberItem)
		{
			if (p_NamedNumberItem.isLocked())
				return;
			p_NamedNumberItem.dolock();
			NamedNumberItem.production_kind kind = (NamedNumberItem.production_kind) p_NamedNumberItem.kind;
			p_NamedNumberItem.turn_reset ();
			if (Raise_NamedNumberItem_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NamedNumberItem))
			switch (kind)
			{
				case NamedNumberItem.production_kind.g_NamedNumberItem_1:
					// traverse syntax tree node associated with production
					// NamedNumberItem: identifier-token "(" SignedNumber ")"

					if (Raise_NamedNumberItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedNumberItem))
						Traverse (p_NamedNumberItem.m_identifier_token);
					p_NamedNumberItem.turn_inc ();
					if (Raise_NamedNumberItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedNumberItem))
						Traverse (p_NamedNumberItem.m_SignedNumber);
					p_NamedNumberItem.turn_inc ();
					Raise_NamedNumberItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedNumberItem);
				break;
				case NamedNumberItem.production_kind.g_NamedNumberItem_2:
					// traverse syntax tree node associated with production
					// NamedNumberItem: identifier-token "(" DefinedValue ")"

					if (Raise_NamedNumberItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedNumberItem))
						Traverse (p_NamedNumberItem.m_identifier_token);
					p_NamedNumberItem.turn_inc ();
					if (Raise_NamedNumberItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedNumberItem))
						Traverse (p_NamedNumberItem.m_DefinedValue);
					p_NamedNumberItem.turn_inc ();
					Raise_NamedNumberItem_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedNumberItem);
				break;
			}
			Raise_NamedNumberItem_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NamedNumberItem);
			p_NamedNumberItem.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NamedNumberItem
		//

		public void TraverseCommon (NamedNumberItem p_NamedNumberItem)
		{
			NamedNumberItem.production_kind kind = (NamedNumberItem.production_kind) p_NamedNumberItem.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NamedNumberItem))
			switch (kind)
			{
				case NamedNumberItem.production_kind.g_NamedNumberItem_1:
					// traverse syntax tree node associated with production
					// NamedNumberItem: identifier-token "(" SignedNumber ")"

						TraverseCommon (p_NamedNumberItem.m_identifier_token);
						TraverseCommon (p_NamedNumberItem.m_left_round_bracket);
						TraverseCommon (p_NamedNumberItem.m_SignedNumber);
						TraverseCommon (p_NamedNumberItem.m_right_round_bracket);
				break;
				case NamedNumberItem.production_kind.g_NamedNumberItem_2:
					// traverse syntax tree node associated with production
					// NamedNumberItem: identifier-token "(" DefinedValue ")"

						TraverseCommon (p_NamedNumberItem.m_identifier_token);
						TraverseCommon (p_NamedNumberItem.m_left_round_bracket);
						TraverseCommon (p_NamedNumberItem.m_DefinedValue);
						TraverseCommon (p_NamedNumberItem.m_right_round_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NamedNumberItem);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NamedNumberItem

		//
		// create syntax tree node associated with production
		// NamedNumberItem: identifier-token "(" SignedNumber ")"

		//

		public NamedNumberItem NamedNumberItem_1 (identifier_token p_identifier_token, SyntaxTreeToken p_token, SignedNumber p_SignedNumber, SyntaxTreeToken p_token_1)
		{
			NamedNumberItem p_NamedNumberItem_ref = new NamedNumberItem(p_identifier_token, p_token, p_SignedNumber, p_token_1);
			p_identifier_token.parent = p_NamedNumberItem_ref;
			p_token.parent = p_NamedNumberItem_ref;
			p_SignedNumber.parent = p_NamedNumberItem_ref;
			p_token_1.parent = p_NamedNumberItem_ref;
			Raise_NamedNumberItem_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedNumberItem.production_kind.g_NamedNumberItem_1, p_NamedNumberItem_ref);
			return p_NamedNumberItem_ref;
		}

		//
		// create syntax tree node associated with production
		// NamedNumberItem: identifier-token "(" DefinedValue ")"

		//

		public NamedNumberItem NamedNumberItem_2 (identifier_token p_identifier_token, SyntaxTreeToken p_token, DefinedValue p_DefinedValue, SyntaxTreeToken p_token_1)
		{
			NamedNumberItem p_NamedNumberItem_ref = new NamedNumberItem(p_identifier_token, p_token, p_DefinedValue, p_token_1);
			p_identifier_token.parent = p_NamedNumberItem_ref;
			p_token.parent = p_NamedNumberItem_ref;
			p_DefinedValue.parent = p_NamedNumberItem_ref;
			p_token_1.parent = p_NamedNumberItem_ref;
			Raise_NamedNumberItem_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedNumberItem.production_kind.g_NamedNumberItem_2, p_NamedNumberItem_ref);
			return p_NamedNumberItem_ref;
		}
		#endregion
	};
}
