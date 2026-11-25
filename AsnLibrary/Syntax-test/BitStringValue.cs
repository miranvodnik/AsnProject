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
	// class associated with syntax rule BitStringValue
	//

	[DataContract]
	public class	BitStringValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule BitStringValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule BitStringValue
		{
			g_BitStringValue_1 = 1,	// bstring

			g_BitStringValue_2 = 2,	// hstring

			g_BitStringValue_3 = 3,	// "{" IdentifierList "}"

			g_BitStringValue_4 = 4,	// "{" "}"

			g_BitStringValue_5 = 5,	// CONTAINING Value

		};
		#endregion
		#region production markers associated with the syntax rule BitStringValue

		// markers associated with production: BitStringValue -> bstring

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: BitStringValue -> hstring

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: BitStringValue -> "{" IdentifierList "}"

		public enum production_marker_3 : ushort
		{
			m_IdentifierList,
			final
		};

		// markers associated with production: BitStringValue -> "{" "}"

		public enum production_marker_4 : ushort
		{
			final
		};

		// markers associated with production: BitStringValue -> CONTAINING Value

		public enum production_marker_5 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule BitStringValue

		// Constructor declaration(s) associated with production(s) of syntax rule BitStringValue

		//
		// Constructor associated with the following production(s)
		// BitStringValue -> bstring

		// BitStringValue -> hstring

		//

		public BitStringValue (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._BitStringValue_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_BitStringValue_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_bstring = p_token;
				break;
			case production_kind.g_BitStringValue_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_hstring = p_token;
				break;
			default:
				{
					string[] args = new string[] { "BitStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		//
		// Constructor associated with the following production(s)
		// BitStringValue -> "{" IdentifierList "}"

		//

		public BitStringValue (SyntaxTreeToken p_token, IdentifierList p_IdentifierList, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._BitStringValue_ID, (uint) production_kind.g_BitStringValue_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_IdentifierList = p_IdentifierList;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// BitStringValue -> "{" "}"

		//

		public BitStringValue (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._BitStringValue_ID, (uint) production_kind.g_BitStringValue_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_right_curly_bracket = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// BitStringValue -> CONTAINING Value

		//

		public BitStringValue (SyntaxTreeToken p_token, Value p_Value) : base ((uint) ProductionID._BitStringValue_ID, (uint) production_kind.g_BitStringValue_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_CONTAINING = p_token;
			children[1] = m_Value = p_Value;
		}

		public BitStringValue () { }

		// Copy constructor

		public BitStringValue (BitStringValue p_BitStringValue) : base (p_BitStringValue.id, p_BitStringValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_BitStringValue.appInfo;
			switch ((production_kind) p_BitStringValue.kind)
			{
				case production_kind.g_BitStringValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_bstring = (p_BitStringValue.m_bstring != null) ? new SyntaxTreeToken (p_BitStringValue.m_bstring) : null) != null) m_bstring.parent = this;
					break;
				case production_kind.g_BitStringValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_hstring = (p_BitStringValue.m_hstring != null) ? new SyntaxTreeToken (p_BitStringValue.m_hstring) : null) != null) m_hstring.parent = this;
					break;
				case production_kind.g_BitStringValue_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_BitStringValue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_BitStringValue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_IdentifierList = (p_BitStringValue.m_IdentifierList != null) ? new IdentifierList (p_BitStringValue.m_IdentifierList) : null) != null) m_IdentifierList.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_BitStringValue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_BitStringValue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_BitStringValue_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_left_curly_bracket = (p_BitStringValue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_BitStringValue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_right_curly_bracket = (p_BitStringValue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_BitStringValue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_BitStringValue_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_CONTAINING = (p_BitStringValue.m_CONTAINING != null) ? new SyntaxTreeToken (p_BitStringValue.m_CONTAINING) : null) != null) m_CONTAINING.parent = this;
					if ((children [1] = m_Value = (p_BitStringValue.m_Value != null) ? new Value (p_BitStringValue.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "BitStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new BitStringValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_bstring?.Dispose ();
			m_hstring?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_IdentifierList?.Dispose ();
			m_right_curly_bracket?.Dispose ();
			m_CONTAINING?.Dispose ();
			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule BitStringValue

		// Content changing function(s) associated with production(s) of syntax rule BitStringValue

		//
		// Content changing function associated with following production(s)
		// BitStringValue -> bstring

		// BitStringValue -> hstring

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_BitStringValue_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_bstring = p_token;
				break;
			case production_kind.g_BitStringValue_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_hstring = p_token;
				break;
			default:
				{
					string[] args = new string[] { "BitStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BitStringValue -> "{" IdentifierList "}"

		//

		public void change(SyntaxTreeToken p_token, IdentifierList p_IdentifierList, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_BitStringValue_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_IdentifierList = p_IdentifierList;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BitStringValue -> "{" "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_BitStringValue_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BitStringValue -> CONTAINING Value

		//

		public void change(SyntaxTreeToken p_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_BitStringValue_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_CONTAINING = p_token;
			children [1] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule BitStringValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_bstring != null) && m_bstring.checkInclusion (element) ||
				(m_hstring != null) && m_hstring.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_IdentifierList != null) && m_IdentifierList.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				(m_CONTAINING != null) && m_CONTAINING.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule BitStringValue

		//
		// emit production tree node associated with any production of syntax rule BitStringValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_BitStringValue_1:
					// emit syntax tree node associated with production
					// BitStringValue: bstring

					s += m_bstring.Emit (depth - 1);
				break;
				case production_kind.g_BitStringValue_2:
					// emit syntax tree node associated with production
					// BitStringValue: hstring

					s += m_hstring.Emit (depth - 1);
				break;
				case production_kind.g_BitStringValue_3:
					// emit syntax tree node associated with production
					// BitStringValue: "{" IdentifierList "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_IdentifierList.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_BitStringValue_4:
					// emit syntax tree node associated with production
					// BitStringValue: "{" "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_BitStringValue_5:
					// emit syntax tree node associated with production
					// BitStringValue: CONTAINING Value

					s += m_CONTAINING.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule BitStringValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "BitStringValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_BitStringValue_1:
					// emit syntax tree node associated with production
					// BitStringValue: bstring

					s += "bstring";
				break;
				case production_kind.g_BitStringValue_2:
					// emit syntax tree node associated with production
					// BitStringValue: hstring

					s += "hstring";
				break;
				case production_kind.g_BitStringValue_3:
					// emit syntax tree node associated with production
					// BitStringValue: "{" IdentifierList "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_IdentifierList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_BitStringValue_4:
					// emit syntax tree node associated with production
					// BitStringValue: "{" "}"

					s += "left_curly_bracket";
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_BitStringValue_5:
					// emit syntax tree node associated with production
					// BitStringValue: CONTAINING Value

					s += "CONTAINING";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule BitStringValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule BitStringValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			BitStringValue.production_kind kind = (BitStringValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case BitStringValue.production_kind.g_BitStringValue_1:
					// traverse syntax tree node associated with production
					// BitStringValue: bstring

						m_bstring.Visit (visitor, appData);
				break;
				case BitStringValue.production_kind.g_BitStringValue_2:
					// traverse syntax tree node associated with production
					// BitStringValue: hstring

						m_hstring.Visit (visitor, appData);
				break;
				case BitStringValue.production_kind.g_BitStringValue_3:
					// traverse syntax tree node associated with production
					// BitStringValue: "{" IdentifierList "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_IdentifierList.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case BitStringValue.production_kind.g_BitStringValue_4:
					// traverse syntax tree node associated with production
					// BitStringValue: "{" "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case BitStringValue.production_kind.g_BitStringValue_5:
					// traverse syntax tree node associated with production
					// BitStringValue: CONTAINING Value

						m_CONTAINING.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_bstring?.reparent (this);
			m_hstring?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_IdentifierList?.reparent (this);
			m_right_curly_bracket?.reparent (this);
			m_CONTAINING?.reparent (this);
			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule BitStringValue
		//

		public void _init ()
		{
			m_bstring = null;
			m_hstring = null;
			m_left_curly_bracket = null;
			m_IdentifierList = null;
			m_right_curly_bracket = null;
			m_CONTAINING = null;
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule BitStringValue

		// counter of all nodes associated with syntax rule BitStringValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule BitStringValue
		[DataMember (Name = "m_bstring")] public SyntaxTreeToken m_bstring { get; private set; }
		[DataMember (Name = "m_hstring")] public SyntaxTreeToken m_hstring { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_IdentifierList")] public IdentifierList m_IdentifierList { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		[DataMember (Name = "m_CONTAINING")] public SyntaxTreeToken m_CONTAINING { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule BitStringValue

		// delegate function (callback) prototype associated with syntax rule BitStringValue
		public delegate bool BitStringValue_Callback (SyntaxTreeCallbackReason reason, BitStringValue.production_kind kind, BitStringValue p_BitStringValue);

		// event associated with syntax rule BitStringValue
		public event BitStringValue_Callback BitStringValue_Event;

		// event trigger associated with syntax rule BitStringValue
		public bool Raise_BitStringValue_Event (SyntaxTreeCallbackReason reason, BitStringValue.production_kind kind, BitStringValue p_BitStringValue)
		{
			bool? status = BitStringValue_Event?.Invoke (reason, kind, p_BitStringValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule BitStringValue
		//
		// traverse syntax tree node associated with any production of syntax rule BitStringValue
		//

		public void Traverse (BitStringValue p_BitStringValue)
		{
			if (p_BitStringValue.isLocked())
				return;
			p_BitStringValue.dolock();
			BitStringValue.production_kind kind = (BitStringValue.production_kind) p_BitStringValue.kind;
			p_BitStringValue.turn_reset ();
			if (Raise_BitStringValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_BitStringValue))
			switch (kind)
			{
				case BitStringValue.production_kind.g_BitStringValue_1:
					// traverse syntax tree node associated with production
					// BitStringValue: bstring

				break;
				case BitStringValue.production_kind.g_BitStringValue_2:
					// traverse syntax tree node associated with production
					// BitStringValue: hstring

				break;
				case BitStringValue.production_kind.g_BitStringValue_3:
					// traverse syntax tree node associated with production
					// BitStringValue: "{" IdentifierList "}"

					if (Raise_BitStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BitStringValue))
						Traverse (p_BitStringValue.m_IdentifierList);
					p_BitStringValue.turn_inc ();
					Raise_BitStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BitStringValue);
				break;
				case BitStringValue.production_kind.g_BitStringValue_4:
					// traverse syntax tree node associated with production
					// BitStringValue: "{" "}"

				break;
				case BitStringValue.production_kind.g_BitStringValue_5:
					// traverse syntax tree node associated with production
					// BitStringValue: CONTAINING Value

					if (Raise_BitStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BitStringValue))
						Traverse (p_BitStringValue.m_Value);
					p_BitStringValue.turn_inc ();
					Raise_BitStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BitStringValue);
				break;
			}
			Raise_BitStringValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_BitStringValue);
			p_BitStringValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule BitStringValue
		//

		public void TraverseCommon (BitStringValue p_BitStringValue)
		{
			BitStringValue.production_kind kind = (BitStringValue.production_kind) p_BitStringValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_BitStringValue))
			switch (kind)
			{
				case BitStringValue.production_kind.g_BitStringValue_1:
					// traverse syntax tree node associated with production
					// BitStringValue: bstring

						TraverseCommon (p_BitStringValue.m_bstring);
				break;
				case BitStringValue.production_kind.g_BitStringValue_2:
					// traverse syntax tree node associated with production
					// BitStringValue: hstring

						TraverseCommon (p_BitStringValue.m_hstring);
				break;
				case BitStringValue.production_kind.g_BitStringValue_3:
					// traverse syntax tree node associated with production
					// BitStringValue: "{" IdentifierList "}"

						TraverseCommon (p_BitStringValue.m_left_curly_bracket);
						TraverseCommon (p_BitStringValue.m_IdentifierList);
						TraverseCommon (p_BitStringValue.m_right_curly_bracket);
				break;
				case BitStringValue.production_kind.g_BitStringValue_4:
					// traverse syntax tree node associated with production
					// BitStringValue: "{" "}"

						TraverseCommon (p_BitStringValue.m_left_curly_bracket);
						TraverseCommon (p_BitStringValue.m_right_curly_bracket);
				break;
				case BitStringValue.production_kind.g_BitStringValue_5:
					// traverse syntax tree node associated with production
					// BitStringValue: CONTAINING Value

						TraverseCommon (p_BitStringValue.m_CONTAINING);
						TraverseCommon (p_BitStringValue.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_BitStringValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule BitStringValue

		//
		// create syntax tree node associated with production
		// BitStringValue: bstring

		//

		public BitStringValue BitStringValue_1 (SyntaxTreeToken p_token)
		{
			BitStringValue p_BitStringValue_ref = new BitStringValue(p_token, 1);
			p_token.parent = p_BitStringValue_ref;
			Raise_BitStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BitStringValue.production_kind.g_BitStringValue_1, p_BitStringValue_ref);
			return p_BitStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BitStringValue: hstring

		//

		public BitStringValue BitStringValue_2 (SyntaxTreeToken p_token)
		{
			BitStringValue p_BitStringValue_ref = new BitStringValue(p_token, 2);
			p_token.parent = p_BitStringValue_ref;
			Raise_BitStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BitStringValue.production_kind.g_BitStringValue_2, p_BitStringValue_ref);
			return p_BitStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BitStringValue: "{" IdentifierList "}"

		//

		public BitStringValue BitStringValue_3 (SyntaxTreeToken p_token, IdentifierList p_IdentifierList, SyntaxTreeToken p_token_1)
		{
			BitStringValue p_BitStringValue_ref = new BitStringValue(p_token, p_IdentifierList, p_token_1);
			p_token.parent = p_BitStringValue_ref;
			p_IdentifierList.parent = p_BitStringValue_ref;
			p_token_1.parent = p_BitStringValue_ref;
			Raise_BitStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BitStringValue.production_kind.g_BitStringValue_3, p_BitStringValue_ref);
			return p_BitStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BitStringValue: "{" "}"

		//

		public BitStringValue BitStringValue_4 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			BitStringValue p_BitStringValue_ref = new BitStringValue(p_token, p_token_1);
			p_token.parent = p_BitStringValue_ref;
			p_token_1.parent = p_BitStringValue_ref;
			Raise_BitStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BitStringValue.production_kind.g_BitStringValue_4, p_BitStringValue_ref);
			return p_BitStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BitStringValue: CONTAINING Value

		//

		public BitStringValue BitStringValue_5 (SyntaxTreeToken p_token, Value p_Value)
		{
			BitStringValue p_BitStringValue_ref = new BitStringValue(p_token, p_Value);
			p_token.parent = p_BitStringValue_ref;
			p_Value.parent = p_BitStringValue_ref;
			Raise_BitStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BitStringValue.production_kind.g_BitStringValue_5, p_BitStringValue_ref);
			return p_BitStringValue_ref;
		}
		#endregion
	};
}
