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
	// class associated with syntax rule IntegerType
	//

	[DataContract]
	public class	IntegerType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule IntegerType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule IntegerType
		{
			g_IntegerType_1 = 1,	// INTEGER

			g_IntegerType_2 = 2,	// INTEGER "{" NamedNumberList "}"

		};
		#endregion
		#region production markers associated with the syntax rule IntegerType

		// markers associated with production: IntegerType -> INTEGER

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: IntegerType -> INTEGER "{" NamedNumberList "}"

		public enum production_marker_2 : ushort
		{
			m_NamedNumberList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule IntegerType

		// Constructor declaration(s) associated with production(s) of syntax rule IntegerType

		//
		// Constructor associated with the following production(s)
		// IntegerType -> INTEGER

		//

		public IntegerType (SyntaxTreeToken p_token) : base ((uint) ProductionID._IntegerType_ID, (uint) production_kind.g_IntegerType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_INTEGER = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// IntegerType -> INTEGER "{" NamedNumberList "}"

		//

		public IntegerType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NamedNumberList p_NamedNumberList, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._IntegerType_ID, (uint) production_kind.g_IntegerType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_INTEGER = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_NamedNumberList = p_NamedNumberList;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		public IntegerType () { }

		// Copy constructor

		public IntegerType (IntegerType p_IntegerType) : base (p_IntegerType.id, p_IntegerType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_IntegerType.appInfo;
			switch ((production_kind) p_IntegerType.kind)
			{
				case production_kind.g_IntegerType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_INTEGER = (p_IntegerType.m_INTEGER != null) ? new SyntaxTreeToken (p_IntegerType.m_INTEGER) : null) != null) m_INTEGER.parent = this;
					break;
				case production_kind.g_IntegerType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_INTEGER = (p_IntegerType.m_INTEGER != null) ? new SyntaxTreeToken (p_IntegerType.m_INTEGER) : null) != null) m_INTEGER.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_IntegerType.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_IntegerType.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_NamedNumberList = (p_IntegerType.m_NamedNumberList != null) ? new NamedNumberList (p_IntegerType.m_NamedNumberList) : null) != null) m_NamedNumberList.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_IntegerType.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_IntegerType.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "IntegerType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new IntegerType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_INTEGER?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_NamedNumberList?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule IntegerType

		// Content changing function(s) associated with production(s) of syntax rule IntegerType

		//
		// Content changing function associated with following production(s)
		// IntegerType -> INTEGER

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_IntegerType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_INTEGER = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// IntegerType -> INTEGER "{" NamedNumberList "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NamedNumberList p_NamedNumberList, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_IntegerType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_INTEGER = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_NamedNumberList = p_NamedNumberList;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule IntegerType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_INTEGER != null) && m_INTEGER.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_NamedNumberList != null) && m_NamedNumberList.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule IntegerType

		//
		// emit production tree node associated with any production of syntax rule IntegerType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_IntegerType_1:
					// emit syntax tree node associated with production
					// IntegerType: INTEGER

					s += m_INTEGER.Emit (depth - 1);
				break;
				case production_kind.g_IntegerType_2:
					// emit syntax tree node associated with production
					// IntegerType: INTEGER "{" NamedNumberList "}"

					s += m_INTEGER.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_NamedNumberList.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule IntegerType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "IntegerType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_IntegerType_1:
					// emit syntax tree node associated with production
					// IntegerType: INTEGER

					s += "INTEGER";
				break;
				case production_kind.g_IntegerType_2:
					// emit syntax tree node associated with production
					// IntegerType: INTEGER "{" NamedNumberList "}"

					s += "INTEGER";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_NamedNumberList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule IntegerType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule IntegerType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			IntegerType.production_kind kind = (IntegerType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case IntegerType.production_kind.g_IntegerType_1:
					// traverse syntax tree node associated with production
					// IntegerType: INTEGER

						m_INTEGER.Visit (visitor, appData);
				break;
				case IntegerType.production_kind.g_IntegerType_2:
					// traverse syntax tree node associated with production
					// IntegerType: INTEGER "{" NamedNumberList "}"

						m_INTEGER.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_NamedNumberList.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_INTEGER?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_NamedNumberList?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule IntegerType
		//

		public void _init ()
		{
			m_INTEGER = null;
			m_left_curly_bracket = null;
			m_NamedNumberList = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule IntegerType

		// counter of all nodes associated with syntax rule IntegerType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule IntegerType
		[DataMember (Name = "m_INTEGER")] public SyntaxTreeToken m_INTEGER { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_NamedNumberList")] public NamedNumberList m_NamedNumberList { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule IntegerType

		// delegate function (callback) prototype associated with syntax rule IntegerType
		public delegate bool IntegerType_Callback (SyntaxTreeCallbackReason reason, IntegerType.production_kind kind, IntegerType p_IntegerType);

		// event associated with syntax rule IntegerType
		public event IntegerType_Callback IntegerType_Event;

		// event trigger associated with syntax rule IntegerType
		public bool Raise_IntegerType_Event (SyntaxTreeCallbackReason reason, IntegerType.production_kind kind, IntegerType p_IntegerType)
		{
			bool? status = IntegerType_Event?.Invoke (reason, kind, p_IntegerType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule IntegerType
		//
		// traverse syntax tree node associated with any production of syntax rule IntegerType
		//

		public void Traverse (IntegerType p_IntegerType)
		{
			if (p_IntegerType.isLocked())
				return;
			p_IntegerType.dolock();
			IntegerType.production_kind kind = (IntegerType.production_kind) p_IntegerType.kind;
			p_IntegerType.turn_reset ();
			if (Raise_IntegerType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_IntegerType))
			switch (kind)
			{
				case IntegerType.production_kind.g_IntegerType_1:
					// traverse syntax tree node associated with production
					// IntegerType: INTEGER

				break;
				case IntegerType.production_kind.g_IntegerType_2:
					// traverse syntax tree node associated with production
					// IntegerType: INTEGER "{" NamedNumberList "}"

					if (Raise_IntegerType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_IntegerType))
						Traverse (p_IntegerType.m_NamedNumberList);
					p_IntegerType.turn_inc ();
					Raise_IntegerType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_IntegerType);
				break;
			}
			Raise_IntegerType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_IntegerType);
			p_IntegerType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule IntegerType
		//

		public void TraverseCommon (IntegerType p_IntegerType)
		{
			IntegerType.production_kind kind = (IntegerType.production_kind) p_IntegerType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_IntegerType))
			switch (kind)
			{
				case IntegerType.production_kind.g_IntegerType_1:
					// traverse syntax tree node associated with production
					// IntegerType: INTEGER

						TraverseCommon (p_IntegerType.m_INTEGER);
				break;
				case IntegerType.production_kind.g_IntegerType_2:
					// traverse syntax tree node associated with production
					// IntegerType: INTEGER "{" NamedNumberList "}"

						TraverseCommon (p_IntegerType.m_INTEGER);
						TraverseCommon (p_IntegerType.m_left_curly_bracket);
						TraverseCommon (p_IntegerType.m_NamedNumberList);
						TraverseCommon (p_IntegerType.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_IntegerType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule IntegerType

		//
		// create syntax tree node associated with production
		// IntegerType: INTEGER

		//

		public IntegerType IntegerType_1 (SyntaxTreeToken p_token)
		{
			IntegerType p_IntegerType_ref = new IntegerType(p_token);
			p_token.parent = p_IntegerType_ref;
			Raise_IntegerType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, IntegerType.production_kind.g_IntegerType_1, p_IntegerType_ref);
			return p_IntegerType_ref;
		}

		//
		// create syntax tree node associated with production
		// IntegerType: INTEGER "{" NamedNumberList "}"

		//

		public IntegerType IntegerType_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NamedNumberList p_NamedNumberList, SyntaxTreeToken p_token_2)
		{
			IntegerType p_IntegerType_ref = new IntegerType(p_token, p_token_1, p_NamedNumberList, p_token_2);
			p_token.parent = p_IntegerType_ref;
			p_token_1.parent = p_IntegerType_ref;
			p_NamedNumberList.parent = p_IntegerType_ref;
			p_token_2.parent = p_IntegerType_ref;
			Raise_IntegerType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, IntegerType.production_kind.g_IntegerType_2, p_IntegerType_ref);
			return p_IntegerType_ref;
		}
		#endregion
	};
}
