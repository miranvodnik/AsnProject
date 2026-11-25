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
	// class associated with syntax rule BitStringType
	//

	[DataContract]
	public class	BitStringType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule BitStringType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule BitStringType
		{
			g_BitStringType_1 = 1,	// BIT STRING

			g_BitStringType_2 = 2,	// BIT STRING "{" NamedBitList "}"

		};
		#endregion
		#region production markers associated with the syntax rule BitStringType

		// markers associated with production: BitStringType -> BIT STRING

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: BitStringType -> BIT STRING "{" NamedBitList "}"

		public enum production_marker_2 : ushort
		{
			m_NamedBitList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule BitStringType

		// Constructor declaration(s) associated with production(s) of syntax rule BitStringType

		//
		// Constructor associated with the following production(s)
		// BitStringType -> BIT STRING

		//

		public BitStringType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._BitStringType_ID, (uint) production_kind.g_BitStringType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_BIT = p_token;
			children[1] = m_STRING = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// BitStringType -> BIT STRING "{" NamedBitList "}"

		//

		public BitStringType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, NamedBitList p_NamedBitList, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._BitStringType_ID, (uint) production_kind.g_BitStringType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_BIT = p_token;
			children[1] = m_STRING = p_token_1;
			children[2] = m_left_curly_bracket = p_token_2;
			children[3] = m_NamedBitList = p_NamedBitList;
			children[4] = m_right_curly_bracket = p_token_3;
		}

		public BitStringType () { }

		// Copy constructor

		public BitStringType (BitStringType p_BitStringType) : base (p_BitStringType.id, p_BitStringType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_BitStringType.appInfo;
			switch ((production_kind) p_BitStringType.kind)
			{
				case production_kind.g_BitStringType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_BIT = (p_BitStringType.m_BIT != null) ? new SyntaxTreeToken (p_BitStringType.m_BIT) : null) != null) m_BIT.parent = this;
					if ((children [1] = m_STRING = (p_BitStringType.m_STRING != null) ? new SyntaxTreeToken (p_BitStringType.m_STRING) : null) != null) m_STRING.parent = this;
					break;
				case production_kind.g_BitStringType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_BIT = (p_BitStringType.m_BIT != null) ? new SyntaxTreeToken (p_BitStringType.m_BIT) : null) != null) m_BIT.parent = this;
					if ((children [1] = m_STRING = (p_BitStringType.m_STRING != null) ? new SyntaxTreeToken (p_BitStringType.m_STRING) : null) != null) m_STRING.parent = this;
					if ((children [2] = m_left_curly_bracket = (p_BitStringType.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_BitStringType.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [3] = m_NamedBitList = (p_BitStringType.m_NamedBitList != null) ? new NamedBitList (p_BitStringType.m_NamedBitList) : null) != null) m_NamedBitList.parent = this;
					if ((children [4] = m_right_curly_bracket = (p_BitStringType.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_BitStringType.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "BitStringType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new BitStringType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_BIT?.Dispose ();
			m_STRING?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_NamedBitList?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule BitStringType

		// Content changing function(s) associated with production(s) of syntax rule BitStringType

		//
		// Content changing function associated with following production(s)
		// BitStringType -> BIT STRING

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_BitStringType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_BIT = p_token;
			children [1] = m_STRING = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// BitStringType -> BIT STRING "{" NamedBitList "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, NamedBitList p_NamedBitList, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_BitStringType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_BIT = p_token;
			children [1] = m_STRING = p_token_1;
			children [2] = m_left_curly_bracket = p_token_2;
			children [3] = m_NamedBitList = p_NamedBitList;
			children [4] = m_right_curly_bracket = p_token_3;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule BitStringType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_BIT != null) && m_BIT.checkInclusion (element) ||
				(m_STRING != null) && m_STRING.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_NamedBitList != null) && m_NamedBitList.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule BitStringType

		//
		// emit production tree node associated with any production of syntax rule BitStringType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_BitStringType_1:
					// emit syntax tree node associated with production
					// BitStringType: BIT STRING

					s += m_BIT.Emit (depth - 1);
					s += " ";
					s += m_STRING.Emit (depth - 1);
				break;
				case production_kind.g_BitStringType_2:
					// emit syntax tree node associated with production
					// BitStringType: BIT STRING "{" NamedBitList "}"

					s += m_BIT.Emit (depth - 1);
					s += " ";
					s += m_STRING.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_NamedBitList.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule BitStringType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "BitStringType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_BitStringType_1:
					// emit syntax tree node associated with production
					// BitStringType: BIT STRING

					s += "BIT";
					s += ' ';
					s += "STRING";
				break;
				case production_kind.g_BitStringType_2:
					// emit syntax tree node associated with production
					// BitStringType: BIT STRING "{" NamedBitList "}"

					s += "BIT";
					s += ' ';
					s += "STRING";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_NamedBitList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule BitStringType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule BitStringType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			BitStringType.production_kind kind = (BitStringType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case BitStringType.production_kind.g_BitStringType_1:
					// traverse syntax tree node associated with production
					// BitStringType: BIT STRING

						m_BIT.Visit (visitor, appData);
						m_STRING.Visit (visitor, appData);
				break;
				case BitStringType.production_kind.g_BitStringType_2:
					// traverse syntax tree node associated with production
					// BitStringType: BIT STRING "{" NamedBitList "}"

						m_BIT.Visit (visitor, appData);
						m_STRING.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_NamedBitList.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_BIT?.reparent (this);
			m_STRING?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_NamedBitList?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule BitStringType
		//

		public void _init ()
		{
			m_BIT = null;
			m_STRING = null;
			m_left_curly_bracket = null;
			m_NamedBitList = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule BitStringType

		// counter of all nodes associated with syntax rule BitStringType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule BitStringType
		[DataMember (Name = "m_BIT")] public SyntaxTreeToken m_BIT { get; private set; }
		[DataMember (Name = "m_STRING")] public SyntaxTreeToken m_STRING { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_NamedBitList")] public NamedBitList m_NamedBitList { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule BitStringType

		// delegate function (callback) prototype associated with syntax rule BitStringType
		public delegate bool BitStringType_Callback (SyntaxTreeCallbackReason reason, BitStringType.production_kind kind, BitStringType p_BitStringType);

		// event associated with syntax rule BitStringType
		public event BitStringType_Callback BitStringType_Event;

		// event trigger associated with syntax rule BitStringType
		public bool Raise_BitStringType_Event (SyntaxTreeCallbackReason reason, BitStringType.production_kind kind, BitStringType p_BitStringType)
		{
			bool? status = BitStringType_Event?.Invoke (reason, kind, p_BitStringType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule BitStringType
		//
		// traverse syntax tree node associated with any production of syntax rule BitStringType
		//

		public void Traverse (BitStringType p_BitStringType)
		{
			if (p_BitStringType.isLocked())
				return;
			p_BitStringType.dolock();
			BitStringType.production_kind kind = (BitStringType.production_kind) p_BitStringType.kind;
			p_BitStringType.turn_reset ();
			if (Raise_BitStringType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_BitStringType))
			switch (kind)
			{
				case BitStringType.production_kind.g_BitStringType_1:
					// traverse syntax tree node associated with production
					// BitStringType: BIT STRING

				break;
				case BitStringType.production_kind.g_BitStringType_2:
					// traverse syntax tree node associated with production
					// BitStringType: BIT STRING "{" NamedBitList "}"

					if (Raise_BitStringType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BitStringType))
						Traverse (p_BitStringType.m_NamedBitList);
					p_BitStringType.turn_inc ();
					Raise_BitStringType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_BitStringType);
				break;
			}
			Raise_BitStringType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_BitStringType);
			p_BitStringType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule BitStringType
		//

		public void TraverseCommon (BitStringType p_BitStringType)
		{
			BitStringType.production_kind kind = (BitStringType.production_kind) p_BitStringType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_BitStringType))
			switch (kind)
			{
				case BitStringType.production_kind.g_BitStringType_1:
					// traverse syntax tree node associated with production
					// BitStringType: BIT STRING

						TraverseCommon (p_BitStringType.m_BIT);
						TraverseCommon (p_BitStringType.m_STRING);
				break;
				case BitStringType.production_kind.g_BitStringType_2:
					// traverse syntax tree node associated with production
					// BitStringType: BIT STRING "{" NamedBitList "}"

						TraverseCommon (p_BitStringType.m_BIT);
						TraverseCommon (p_BitStringType.m_STRING);
						TraverseCommon (p_BitStringType.m_left_curly_bracket);
						TraverseCommon (p_BitStringType.m_NamedBitList);
						TraverseCommon (p_BitStringType.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_BitStringType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule BitStringType

		//
		// create syntax tree node associated with production
		// BitStringType: BIT STRING

		//

		public BitStringType BitStringType_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			BitStringType p_BitStringType_ref = new BitStringType(p_token, p_token_1);
			p_token.parent = p_BitStringType_ref;
			p_token_1.parent = p_BitStringType_ref;
			Raise_BitStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BitStringType.production_kind.g_BitStringType_1, p_BitStringType_ref);
			return p_BitStringType_ref;
		}

		//
		// create syntax tree node associated with production
		// BitStringType: BIT STRING "{" NamedBitList "}"

		//

		public BitStringType BitStringType_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, NamedBitList p_NamedBitList, SyntaxTreeToken p_token_3)
		{
			BitStringType p_BitStringType_ref = new BitStringType(p_token, p_token_1, p_token_2, p_NamedBitList, p_token_3);
			p_token.parent = p_BitStringType_ref;
			p_token_1.parent = p_BitStringType_ref;
			p_token_2.parent = p_BitStringType_ref;
			p_NamedBitList.parent = p_BitStringType_ref;
			p_token_3.parent = p_BitStringType_ref;
			Raise_BitStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BitStringType.production_kind.g_BitStringType_2, p_BitStringType_ref);
			return p_BitStringType_ref;
		}
		#endregion
	};
}
