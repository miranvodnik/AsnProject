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
	// class associated with syntax rule AC-CreationPart
	//

	[DataContract]
	public class	AC_CreationPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-CreationPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-CreationPart
		{
			g_AC_CreationPart_1 = 1,	// CREATION-REQUIRES "{" AC-Cells "}"

			g_AC_CreationPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule AC-CreationPart

		// markers associated with production: AC-CreationPart -> CREATION-REQUIRES "{" AC-Cells "}"

		public enum production_marker_1 : ushort
		{
			m_AC_Cells,
			final
		};

		// markers associated with production: AC-CreationPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-CreationPart

		// Constructor declaration(s) associated with production(s) of syntax rule AC-CreationPart

		//
		// Constructor associated with the following production(s)
		// AC-CreationPart -> CREATION-REQUIRES "{" AC-Cells "}"

		//

		public AC_CreationPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, AC_Cells p_AC_Cells, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._AC_CreationPart_ID, (uint) production_kind.g_AC_CreationPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_CREATION_REQUIRES = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_AC_Cells = p_AC_Cells;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		//
		// Constructor associated with the following production(s)
		// AC-CreationPart -> %empty

		//

		public AC_CreationPart () : base ((uint) ProductionID._AC_CreationPart_ID, (uint) production_kind.g_AC_CreationPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public AC_CreationPart (AC_CreationPart p_AC_CreationPart) : base (p_AC_CreationPart.id, p_AC_CreationPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_CreationPart.appInfo;
			switch ((production_kind) p_AC_CreationPart.kind)
			{
				case production_kind.g_AC_CreationPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_CREATION_REQUIRES = (p_AC_CreationPart.m_CREATION_REQUIRES != null) ? new SyntaxTreeToken (p_AC_CreationPart.m_CREATION_REQUIRES) : null) != null) m_CREATION_REQUIRES.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_AC_CreationPart.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_AC_CreationPart.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_AC_Cells = (p_AC_CreationPart.m_AC_Cells != null) ? new AC_Cells (p_AC_CreationPart.m_AC_Cells) : null) != null) m_AC_Cells.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_AC_CreationPart.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_AC_CreationPart.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_AC_CreationPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "AC_CreationPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_CreationPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_CREATION_REQUIRES?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_AC_Cells?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-CreationPart

		// Content changing function(s) associated with production(s) of syntax rule AC-CreationPart

		//
		// Content changing function associated with following production(s)
		// AC-CreationPart -> CREATION-REQUIRES "{" AC-Cells "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, AC_Cells p_AC_Cells, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_CreationPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_CREATION_REQUIRES = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_AC_Cells = p_AC_Cells;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-CreationPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_CreationPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-CreationPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_CREATION_REQUIRES != null) && m_CREATION_REQUIRES.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_AC_Cells != null) && m_AC_Cells.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-CreationPart

		//
		// emit production tree node associated with any production of syntax rule AC-CreationPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_CreationPart_1:
					// emit syntax tree node associated with production
					// AC-CreationPart: CREATION-REQUIRES "{" AC-Cells "}"

					s += m_CREATION_REQUIRES.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_AC_Cells.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_AC_CreationPart_2:
					// emit syntax tree node associated with production
					// AC-CreationPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-CreationPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_CreationPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_CreationPart_1:
					// emit syntax tree node associated with production
					// AC-CreationPart: CREATION-REQUIRES "{" AC-Cells "}"

					s += "CREATION_REQUIRES";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_AC_Cells.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_AC_CreationPart_2:
					// emit syntax tree node associated with production
					// AC-CreationPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-CreationPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-CreationPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_CreationPart.production_kind kind = (AC_CreationPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_CreationPart.production_kind.g_AC_CreationPart_1:
					// traverse syntax tree node associated with production
					// AC-CreationPart: CREATION-REQUIRES "{" AC-Cells "}"

						m_CREATION_REQUIRES.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_AC_Cells.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case AC_CreationPart.production_kind.g_AC_CreationPart_2:
					// traverse syntax tree node associated with production
					// AC-CreationPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_CREATION_REQUIRES?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_AC_Cells?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-CreationPart
		//

		public void _init ()
		{
			m_CREATION_REQUIRES = null;
			m_left_curly_bracket = null;
			m_AC_Cells = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-CreationPart

		// counter of all nodes associated with syntax rule AC-CreationPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-CreationPart
		[DataMember (Name = "m_CREATION_REQUIRES")] public SyntaxTreeToken m_CREATION_REQUIRES { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_AC_Cells")] public AC_Cells m_AC_Cells { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-CreationPart

		// delegate function (callback) prototype associated with syntax rule AC-CreationPart
		public delegate bool AC_CreationPart_Callback (SyntaxTreeCallbackReason reason, AC_CreationPart.production_kind kind, AC_CreationPart p_AC_CreationPart);

		// event associated with syntax rule AC-CreationPart
		public event AC_CreationPart_Callback AC_CreationPart_Event;

		// event trigger associated with syntax rule AC-CreationPart
		public bool Raise_AC_CreationPart_Event (SyntaxTreeCallbackReason reason, AC_CreationPart.production_kind kind, AC_CreationPart p_AC_CreationPart)
		{
			bool? status = AC_CreationPart_Event?.Invoke (reason, kind, p_AC_CreationPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-CreationPart
		//
		// traverse syntax tree node associated with any production of syntax rule AC-CreationPart
		//

		public void Traverse (AC_CreationPart p_AC_CreationPart)
		{
			if (p_AC_CreationPart.isLocked())
				return;
			p_AC_CreationPart.dolock();
			AC_CreationPart.production_kind kind = (AC_CreationPart.production_kind) p_AC_CreationPart.kind;
			p_AC_CreationPart.turn_reset ();
			if (Raise_AC_CreationPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_CreationPart))
			switch (kind)
			{
				case AC_CreationPart.production_kind.g_AC_CreationPart_1:
					// traverse syntax tree node associated with production
					// AC-CreationPart: CREATION-REQUIRES "{" AC-Cells "}"

					if (Raise_AC_CreationPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_CreationPart))
						Traverse (p_AC_CreationPart.m_AC_Cells);
					p_AC_CreationPart.turn_inc ();
					Raise_AC_CreationPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_CreationPart);
				break;
				case AC_CreationPart.production_kind.g_AC_CreationPart_2:
					// traverse syntax tree node associated with production
					// AC-CreationPart: %empty

				break;
			}
			Raise_AC_CreationPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_CreationPart);
			p_AC_CreationPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-CreationPart
		//

		public void TraverseCommon (AC_CreationPart p_AC_CreationPart)
		{
			AC_CreationPart.production_kind kind = (AC_CreationPart.production_kind) p_AC_CreationPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_CreationPart))
			switch (kind)
			{
				case AC_CreationPart.production_kind.g_AC_CreationPart_1:
					// traverse syntax tree node associated with production
					// AC-CreationPart: CREATION-REQUIRES "{" AC-Cells "}"

						TraverseCommon (p_AC_CreationPart.m_CREATION_REQUIRES);
						TraverseCommon (p_AC_CreationPart.m_left_curly_bracket);
						TraverseCommon (p_AC_CreationPart.m_AC_Cells);
						TraverseCommon (p_AC_CreationPart.m_right_curly_bracket);
				break;
				case AC_CreationPart.production_kind.g_AC_CreationPart_2:
					// traverse syntax tree node associated with production
					// AC-CreationPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_CreationPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-CreationPart

		//
		// create syntax tree node associated with production
		// AC-CreationPart: CREATION-REQUIRES "{" AC-Cells "}"

		//

		public AC_CreationPart AC_CreationPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, AC_Cells p_AC_Cells, SyntaxTreeToken p_token_2)
		{
			AC_CreationPart p_AC_CreationPart_ref = new AC_CreationPart(p_token, p_token_1, p_AC_Cells, p_token_2);
			p_token.parent = p_AC_CreationPart_ref;
			p_token_1.parent = p_AC_CreationPart_ref;
			p_AC_Cells.parent = p_AC_CreationPart_ref;
			p_token_2.parent = p_AC_CreationPart_ref;
			Raise_AC_CreationPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_CreationPart.production_kind.g_AC_CreationPart_1, p_AC_CreationPart_ref);
			return p_AC_CreationPart_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-CreationPart: %empty

		//

		public AC_CreationPart AC_CreationPart_2 ()
		{
			AC_CreationPart p_AC_CreationPart_ref = new AC_CreationPart();
			Raise_AC_CreationPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_CreationPart.production_kind.g_AC_CreationPart_2, p_AC_CreationPart_ref);
			return p_AC_CreationPart_ref;
		}
		#endregion
	};
}
