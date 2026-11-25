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
	// class associated with syntax rule MC-MandatoryPart
	//

	[DataContract]
	public class	MC_MandatoryPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-MandatoryPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-MandatoryPart
		{
			g_MC_MandatoryPart_1 = 1,	// MANDATORY-GROUPS "{" MC-Groups "}"

			g_MC_MandatoryPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule MC-MandatoryPart

		// markers associated with production: MC-MandatoryPart -> MANDATORY-GROUPS "{" MC-Groups "}"

		public enum production_marker_1 : ushort
		{
			m_MC_Groups,
			final
		};

		// markers associated with production: MC-MandatoryPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-MandatoryPart

		// Constructor declaration(s) associated with production(s) of syntax rule MC-MandatoryPart

		//
		// Constructor associated with the following production(s)
		// MC-MandatoryPart -> MANDATORY-GROUPS "{" MC-Groups "}"

		//

		public MC_MandatoryPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, MC_Groups p_MC_Groups, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._MC_MandatoryPart_ID, (uint) production_kind.g_MC_MandatoryPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_MANDATORY_GROUPS = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_MC_Groups = p_MC_Groups;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		//
		// Constructor associated with the following production(s)
		// MC-MandatoryPart -> %empty

		//

		public MC_MandatoryPart () : base ((uint) ProductionID._MC_MandatoryPart_ID, (uint) production_kind.g_MC_MandatoryPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public MC_MandatoryPart (MC_MandatoryPart p_MC_MandatoryPart) : base (p_MC_MandatoryPart.id, p_MC_MandatoryPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_MandatoryPart.appInfo;
			switch ((production_kind) p_MC_MandatoryPart.kind)
			{
				case production_kind.g_MC_MandatoryPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_MANDATORY_GROUPS = (p_MC_MandatoryPart.m_MANDATORY_GROUPS != null) ? new SyntaxTreeToken (p_MC_MandatoryPart.m_MANDATORY_GROUPS) : null) != null) m_MANDATORY_GROUPS.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_MC_MandatoryPart.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_MC_MandatoryPart.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_MC_Groups = (p_MC_MandatoryPart.m_MC_Groups != null) ? new MC_Groups (p_MC_MandatoryPart.m_MC_Groups) : null) != null) m_MC_Groups.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_MC_MandatoryPart.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_MC_MandatoryPart.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_MC_MandatoryPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "MC_MandatoryPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_MandatoryPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_MANDATORY_GROUPS?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_MC_Groups?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-MandatoryPart

		// Content changing function(s) associated with production(s) of syntax rule MC-MandatoryPart

		//
		// Content changing function associated with following production(s)
		// MC-MandatoryPart -> MANDATORY-GROUPS "{" MC-Groups "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, MC_Groups p_MC_Groups, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_MandatoryPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_MANDATORY_GROUPS = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_MC_Groups = p_MC_Groups;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MC-MandatoryPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_MandatoryPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-MandatoryPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_MANDATORY_GROUPS != null) && m_MANDATORY_GROUPS.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_MC_Groups != null) && m_MC_Groups.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-MandatoryPart

		//
		// emit production tree node associated with any production of syntax rule MC-MandatoryPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_MandatoryPart_1:
					// emit syntax tree node associated with production
					// MC-MandatoryPart: MANDATORY-GROUPS "{" MC-Groups "}"

					s += m_MANDATORY_GROUPS.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_MC_Groups.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_MC_MandatoryPart_2:
					// emit syntax tree node associated with production
					// MC-MandatoryPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-MandatoryPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_MandatoryPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_MandatoryPart_1:
					// emit syntax tree node associated with production
					// MC-MandatoryPart: MANDATORY-GROUPS "{" MC-Groups "}"

					s += "MANDATORY_GROUPS";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_MC_Groups.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_MC_MandatoryPart_2:
					// emit syntax tree node associated with production
					// MC-MandatoryPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-MandatoryPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-MandatoryPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_MandatoryPart.production_kind kind = (MC_MandatoryPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_MandatoryPart.production_kind.g_MC_MandatoryPart_1:
					// traverse syntax tree node associated with production
					// MC-MandatoryPart: MANDATORY-GROUPS "{" MC-Groups "}"

						m_MANDATORY_GROUPS.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_MC_Groups.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case MC_MandatoryPart.production_kind.g_MC_MandatoryPart_2:
					// traverse syntax tree node associated with production
					// MC-MandatoryPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_MANDATORY_GROUPS?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_MC_Groups?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MC-MandatoryPart
		//

		public void _init ()
		{
			m_MANDATORY_GROUPS = null;
			m_left_curly_bracket = null;
			m_MC_Groups = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-MandatoryPart

		// counter of all nodes associated with syntax rule MC-MandatoryPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-MandatoryPart
		[DataMember (Name = "m_MANDATORY_GROUPS")] public SyntaxTreeToken m_MANDATORY_GROUPS { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_MC_Groups")] public MC_Groups m_MC_Groups { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-MandatoryPart

		// delegate function (callback) prototype associated with syntax rule MC-MandatoryPart
		public delegate bool MC_MandatoryPart_Callback (SyntaxTreeCallbackReason reason, MC_MandatoryPart.production_kind kind, MC_MandatoryPart p_MC_MandatoryPart);

		// event associated with syntax rule MC-MandatoryPart
		public event MC_MandatoryPart_Callback MC_MandatoryPart_Event;

		// event trigger associated with syntax rule MC-MandatoryPart
		public bool Raise_MC_MandatoryPart_Event (SyntaxTreeCallbackReason reason, MC_MandatoryPart.production_kind kind, MC_MandatoryPart p_MC_MandatoryPart)
		{
			bool? status = MC_MandatoryPart_Event?.Invoke (reason, kind, p_MC_MandatoryPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-MandatoryPart
		//
		// traverse syntax tree node associated with any production of syntax rule MC-MandatoryPart
		//

		public void Traverse (MC_MandatoryPart p_MC_MandatoryPart)
		{
			if (p_MC_MandatoryPart.isLocked())
				return;
			p_MC_MandatoryPart.dolock();
			MC_MandatoryPart.production_kind kind = (MC_MandatoryPart.production_kind) p_MC_MandatoryPart.kind;
			p_MC_MandatoryPart.turn_reset ();
			if (Raise_MC_MandatoryPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_MandatoryPart))
			switch (kind)
			{
				case MC_MandatoryPart.production_kind.g_MC_MandatoryPart_1:
					// traverse syntax tree node associated with production
					// MC-MandatoryPart: MANDATORY-GROUPS "{" MC-Groups "}"

					if (Raise_MC_MandatoryPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_MandatoryPart))
						Traverse (p_MC_MandatoryPart.m_MC_Groups);
					p_MC_MandatoryPart.turn_inc ();
					Raise_MC_MandatoryPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_MandatoryPart);
				break;
				case MC_MandatoryPart.production_kind.g_MC_MandatoryPart_2:
					// traverse syntax tree node associated with production
					// MC-MandatoryPart: %empty

				break;
			}
			Raise_MC_MandatoryPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_MandatoryPart);
			p_MC_MandatoryPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-MandatoryPart
		//

		public void TraverseCommon (MC_MandatoryPart p_MC_MandatoryPart)
		{
			MC_MandatoryPart.production_kind kind = (MC_MandatoryPart.production_kind) p_MC_MandatoryPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_MandatoryPart))
			switch (kind)
			{
				case MC_MandatoryPart.production_kind.g_MC_MandatoryPart_1:
					// traverse syntax tree node associated with production
					// MC-MandatoryPart: MANDATORY-GROUPS "{" MC-Groups "}"

						TraverseCommon (p_MC_MandatoryPart.m_MANDATORY_GROUPS);
						TraverseCommon (p_MC_MandatoryPart.m_left_curly_bracket);
						TraverseCommon (p_MC_MandatoryPart.m_MC_Groups);
						TraverseCommon (p_MC_MandatoryPart.m_right_curly_bracket);
				break;
				case MC_MandatoryPart.production_kind.g_MC_MandatoryPart_2:
					// traverse syntax tree node associated with production
					// MC-MandatoryPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_MandatoryPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-MandatoryPart

		//
		// create syntax tree node associated with production
		// MC-MandatoryPart: MANDATORY-GROUPS "{" MC-Groups "}"

		//

		public MC_MandatoryPart MC_MandatoryPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, MC_Groups p_MC_Groups, SyntaxTreeToken p_token_2)
		{
			MC_MandatoryPart p_MC_MandatoryPart_ref = new MC_MandatoryPart(p_token, p_token_1, p_MC_Groups, p_token_2);
			p_token.parent = p_MC_MandatoryPart_ref;
			p_token_1.parent = p_MC_MandatoryPart_ref;
			p_MC_Groups.parent = p_MC_MandatoryPart_ref;
			p_token_2.parent = p_MC_MandatoryPart_ref;
			Raise_MC_MandatoryPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_MandatoryPart.production_kind.g_MC_MandatoryPart_1, p_MC_MandatoryPart_ref);
			return p_MC_MandatoryPart_ref;
		}

		//
		// create syntax tree node associated with production
		// MC-MandatoryPart: %empty

		//

		public MC_MandatoryPart MC_MandatoryPart_2 ()
		{
			MC_MandatoryPart p_MC_MandatoryPart_ref = new MC_MandatoryPart();
			Raise_MC_MandatoryPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_MandatoryPart.production_kind.g_MC_MandatoryPart_2, p_MC_MandatoryPart_ref);
			return p_MC_MandatoryPart_ref;
		}
		#endregion
	};
}
