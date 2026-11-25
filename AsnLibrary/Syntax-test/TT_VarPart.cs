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
	// class associated with syntax rule TT-VarPart
	//

	[DataContract]
	public class	TT_VarPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TT-VarPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TT-VarPart
		{
			g_TT_VarPart_1 = 1,	// VARIABLES "{" TT-VarTypes "}"

			g_TT_VarPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule TT-VarPart

		// markers associated with production: TT-VarPart -> VARIABLES "{" TT-VarTypes "}"

		public enum production_marker_1 : ushort
		{
			m_TT_VarTypes,
			final
		};

		// markers associated with production: TT-VarPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TT-VarPart

		// Constructor declaration(s) associated with production(s) of syntax rule TT-VarPart

		//
		// Constructor associated with the following production(s)
		// TT-VarPart -> VARIABLES "{" TT-VarTypes "}"

		//

		public TT_VarPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, TT_VarTypes p_TT_VarTypes, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._TT_VarPart_ID, (uint) production_kind.g_TT_VarPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_VARIABLES = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_TT_VarTypes = p_TT_VarTypes;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		//
		// Constructor associated with the following production(s)
		// TT-VarPart -> %empty

		//

		public TT_VarPart () : base ((uint) ProductionID._TT_VarPart_ID, (uint) production_kind.g_TT_VarPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public TT_VarPart (TT_VarPart p_TT_VarPart) : base (p_TT_VarPart.id, p_TT_VarPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TT_VarPart.appInfo;
			switch ((production_kind) p_TT_VarPart.kind)
			{
				case production_kind.g_TT_VarPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_VARIABLES = (p_TT_VarPart.m_VARIABLES != null) ? new SyntaxTreeToken (p_TT_VarPart.m_VARIABLES) : null) != null) m_VARIABLES.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_TT_VarPart.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_TT_VarPart.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_TT_VarTypes = (p_TT_VarPart.m_TT_VarTypes != null) ? new TT_VarTypes (p_TT_VarPart.m_TT_VarTypes) : null) != null) m_TT_VarTypes.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_TT_VarPart.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_TT_VarPart.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_TT_VarPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "TT_VarPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TT_VarPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_VARIABLES?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_TT_VarTypes?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TT-VarPart

		// Content changing function(s) associated with production(s) of syntax rule TT-VarPart

		//
		// Content changing function associated with following production(s)
		// TT-VarPart -> VARIABLES "{" TT-VarTypes "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, TT_VarTypes p_TT_VarTypes, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_TT_VarPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_VARIABLES = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_TT_VarTypes = p_TT_VarTypes;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TT-VarPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_TT_VarPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TT-VarPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_VARIABLES != null) && m_VARIABLES.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_TT_VarTypes != null) && m_TT_VarTypes.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TT-VarPart

		//
		// emit production tree node associated with any production of syntax rule TT-VarPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TT_VarPart_1:
					// emit syntax tree node associated with production
					// TT-VarPart: VARIABLES "{" TT-VarTypes "}"

					s += m_VARIABLES.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_TT_VarTypes.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_TT_VarPart_2:
					// emit syntax tree node associated with production
					// TT-VarPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TT-VarPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TT_VarPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TT_VarPart_1:
					// emit syntax tree node associated with production
					// TT-VarPart: VARIABLES "{" TT-VarTypes "}"

					s += "VARIABLES";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_TT_VarTypes.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_TT_VarPart_2:
					// emit syntax tree node associated with production
					// TT-VarPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TT-VarPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TT-VarPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TT_VarPart.production_kind kind = (TT_VarPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TT_VarPart.production_kind.g_TT_VarPart_1:
					// traverse syntax tree node associated with production
					// TT-VarPart: VARIABLES "{" TT-VarTypes "}"

						m_VARIABLES.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_TT_VarTypes.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case TT_VarPart.production_kind.g_TT_VarPart_2:
					// traverse syntax tree node associated with production
					// TT-VarPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_VARIABLES?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_TT_VarTypes?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TT-VarPart
		//

		public void _init ()
		{
			m_VARIABLES = null;
			m_left_curly_bracket = null;
			m_TT_VarTypes = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TT-VarPart

		// counter of all nodes associated with syntax rule TT-VarPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TT-VarPart
		[DataMember (Name = "m_VARIABLES")] public SyntaxTreeToken m_VARIABLES { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_TT_VarTypes")] public TT_VarTypes m_TT_VarTypes { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TT-VarPart

		// delegate function (callback) prototype associated with syntax rule TT-VarPart
		public delegate bool TT_VarPart_Callback (SyntaxTreeCallbackReason reason, TT_VarPart.production_kind kind, TT_VarPart p_TT_VarPart);

		// event associated with syntax rule TT-VarPart
		public event TT_VarPart_Callback TT_VarPart_Event;

		// event trigger associated with syntax rule TT-VarPart
		public bool Raise_TT_VarPart_Event (SyntaxTreeCallbackReason reason, TT_VarPart.production_kind kind, TT_VarPart p_TT_VarPart)
		{
			bool? status = TT_VarPart_Event?.Invoke (reason, kind, p_TT_VarPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TT-VarPart
		//
		// traverse syntax tree node associated with any production of syntax rule TT-VarPart
		//

		public void Traverse (TT_VarPart p_TT_VarPart)
		{
			if (p_TT_VarPart.isLocked())
				return;
			p_TT_VarPart.dolock();
			TT_VarPart.production_kind kind = (TT_VarPart.production_kind) p_TT_VarPart.kind;
			p_TT_VarPart.turn_reset ();
			if (Raise_TT_VarPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TT_VarPart))
			switch (kind)
			{
				case TT_VarPart.production_kind.g_TT_VarPart_1:
					// traverse syntax tree node associated with production
					// TT-VarPart: VARIABLES "{" TT-VarTypes "}"

					if (Raise_TT_VarPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TT_VarPart))
						Traverse (p_TT_VarPart.m_TT_VarTypes);
					p_TT_VarPart.turn_inc ();
					Raise_TT_VarPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TT_VarPart);
				break;
				case TT_VarPart.production_kind.g_TT_VarPart_2:
					// traverse syntax tree node associated with production
					// TT-VarPart: %empty

				break;
			}
			Raise_TT_VarPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TT_VarPart);
			p_TT_VarPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TT-VarPart
		//

		public void TraverseCommon (TT_VarPart p_TT_VarPart)
		{
			TT_VarPart.production_kind kind = (TT_VarPart.production_kind) p_TT_VarPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TT_VarPart))
			switch (kind)
			{
				case TT_VarPart.production_kind.g_TT_VarPart_1:
					// traverse syntax tree node associated with production
					// TT-VarPart: VARIABLES "{" TT-VarTypes "}"

						TraverseCommon (p_TT_VarPart.m_VARIABLES);
						TraverseCommon (p_TT_VarPart.m_left_curly_bracket);
						TraverseCommon (p_TT_VarPart.m_TT_VarTypes);
						TraverseCommon (p_TT_VarPart.m_right_curly_bracket);
				break;
				case TT_VarPart.production_kind.g_TT_VarPart_2:
					// traverse syntax tree node associated with production
					// TT-VarPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TT_VarPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TT-VarPart

		//
		// create syntax tree node associated with production
		// TT-VarPart: VARIABLES "{" TT-VarTypes "}"

		//

		public TT_VarPart TT_VarPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, TT_VarTypes p_TT_VarTypes, SyntaxTreeToken p_token_2)
		{
			TT_VarPart p_TT_VarPart_ref = new TT_VarPart(p_token, p_token_1, p_TT_VarTypes, p_token_2);
			p_token.parent = p_TT_VarPart_ref;
			p_token_1.parent = p_TT_VarPart_ref;
			p_TT_VarTypes.parent = p_TT_VarPart_ref;
			p_token_2.parent = p_TT_VarPart_ref;
			Raise_TT_VarPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TT_VarPart.production_kind.g_TT_VarPart_1, p_TT_VarPart_ref);
			return p_TT_VarPart_ref;
		}

		//
		// create syntax tree node associated with production
		// TT-VarPart: %empty

		//

		public TT_VarPart TT_VarPart_2 ()
		{
			TT_VarPart p_TT_VarPart_ref = new TT_VarPart();
			Raise_TT_VarPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TT_VarPart.production_kind.g_TT_VarPart_2, p_TT_VarPart_ref);
			return p_TT_VarPart_ref;
		}
		#endregion
	};
}
