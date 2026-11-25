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
	// class associated with syntax rule NG-NotificationsPart
	//

	[DataContract]
	public class	NG_NotificationsPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NG-NotificationsPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NG-NotificationsPart
		{
			g_NG_NotificationsPart_1 = 1,	// NOTIFICATIONS "{" NG-Notifications "}"

		};
		#endregion
		#region production markers associated with the syntax rule NG-NotificationsPart

		// markers associated with production: NG-NotificationsPart -> NOTIFICATIONS "{" NG-Notifications "}"

		public enum production_marker_1 : ushort
		{
			m_NG_Notifications,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NG-NotificationsPart

		// Constructor declaration(s) associated with production(s) of syntax rule NG-NotificationsPart

		//
		// Constructor associated with the following production(s)
		// NG-NotificationsPart -> NOTIFICATIONS "{" NG-Notifications "}"

		//

		public NG_NotificationsPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NG_Notifications p_NG_Notifications, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._NG_NotificationsPart_ID, (uint) production_kind.g_NG_NotificationsPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_NOTIFICATIONS = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_NG_Notifications = p_NG_Notifications;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		public NG_NotificationsPart () { }

		// Copy constructor

		public NG_NotificationsPart (NG_NotificationsPart p_NG_NotificationsPart) : base (p_NG_NotificationsPart.id, p_NG_NotificationsPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NG_NotificationsPart.appInfo;
			switch ((production_kind) p_NG_NotificationsPart.kind)
			{
				case production_kind.g_NG_NotificationsPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_NOTIFICATIONS = (p_NG_NotificationsPart.m_NOTIFICATIONS != null) ? new SyntaxTreeToken (p_NG_NotificationsPart.m_NOTIFICATIONS) : null) != null) m_NOTIFICATIONS.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_NG_NotificationsPart.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_NG_NotificationsPart.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_NG_Notifications = (p_NG_NotificationsPart.m_NG_Notifications != null) ? new NG_Notifications (p_NG_NotificationsPart.m_NG_Notifications) : null) != null) m_NG_Notifications.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_NG_NotificationsPart.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_NG_NotificationsPart.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NG_NotificationsPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NG_NotificationsPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_NOTIFICATIONS?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_NG_Notifications?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NG-NotificationsPart

		// Content changing function(s) associated with production(s) of syntax rule NG-NotificationsPart

		//
		// Content changing function associated with following production(s)
		// NG-NotificationsPart -> NOTIFICATIONS "{" NG-Notifications "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NG_Notifications p_NG_Notifications, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_NG_NotificationsPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_NOTIFICATIONS = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_NG_Notifications = p_NG_Notifications;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NG-NotificationsPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_NOTIFICATIONS != null) && m_NOTIFICATIONS.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_NG_Notifications != null) && m_NG_Notifications.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NG-NotificationsPart

		//
		// emit production tree node associated with any production of syntax rule NG-NotificationsPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NG_NotificationsPart_1:
					// emit syntax tree node associated with production
					// NG-NotificationsPart: NOTIFICATIONS "{" NG-Notifications "}"

					s += m_NOTIFICATIONS.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_NG_Notifications.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NG-NotificationsPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NG_NotificationsPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NG_NotificationsPart_1:
					// emit syntax tree node associated with production
					// NG-NotificationsPart: NOTIFICATIONS "{" NG-Notifications "}"

					s += "NOTIFICATIONS";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_NG_Notifications.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NG-NotificationsPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NG-NotificationsPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NG_NotificationsPart.production_kind kind = (NG_NotificationsPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NG_NotificationsPart.production_kind.g_NG_NotificationsPart_1:
					// traverse syntax tree node associated with production
					// NG-NotificationsPart: NOTIFICATIONS "{" NG-Notifications "}"

						m_NOTIFICATIONS.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_NG_Notifications.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_NOTIFICATIONS?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_NG_Notifications?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NG-NotificationsPart
		//

		public void _init ()
		{
			m_NOTIFICATIONS = null;
			m_left_curly_bracket = null;
			m_NG_Notifications = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NG-NotificationsPart

		// counter of all nodes associated with syntax rule NG-NotificationsPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NG-NotificationsPart
		[DataMember (Name = "m_NOTIFICATIONS")] public SyntaxTreeToken m_NOTIFICATIONS { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_NG_Notifications")] public NG_Notifications m_NG_Notifications { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NG-NotificationsPart

		// delegate function (callback) prototype associated with syntax rule NG-NotificationsPart
		public delegate bool NG_NotificationsPart_Callback (SyntaxTreeCallbackReason reason, NG_NotificationsPart.production_kind kind, NG_NotificationsPart p_NG_NotificationsPart);

		// event associated with syntax rule NG-NotificationsPart
		public event NG_NotificationsPart_Callback NG_NotificationsPart_Event;

		// event trigger associated with syntax rule NG-NotificationsPart
		public bool Raise_NG_NotificationsPart_Event (SyntaxTreeCallbackReason reason, NG_NotificationsPart.production_kind kind, NG_NotificationsPart p_NG_NotificationsPart)
		{
			bool? status = NG_NotificationsPart_Event?.Invoke (reason, kind, p_NG_NotificationsPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NG-NotificationsPart
		//
		// traverse syntax tree node associated with any production of syntax rule NG-NotificationsPart
		//

		public void Traverse (NG_NotificationsPart p_NG_NotificationsPart)
		{
			if (p_NG_NotificationsPart.isLocked())
				return;
			p_NG_NotificationsPart.dolock();
			NG_NotificationsPart.production_kind kind = (NG_NotificationsPart.production_kind) p_NG_NotificationsPart.kind;
			p_NG_NotificationsPart.turn_reset ();
			if (Raise_NG_NotificationsPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NG_NotificationsPart))
			switch (kind)
			{
				case NG_NotificationsPart.production_kind.g_NG_NotificationsPart_1:
					// traverse syntax tree node associated with production
					// NG-NotificationsPart: NOTIFICATIONS "{" NG-Notifications "}"

					if (Raise_NG_NotificationsPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NG_NotificationsPart))
						Traverse (p_NG_NotificationsPart.m_NG_Notifications);
					p_NG_NotificationsPart.turn_inc ();
					Raise_NG_NotificationsPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NG_NotificationsPart);
				break;
			}
			Raise_NG_NotificationsPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NG_NotificationsPart);
			p_NG_NotificationsPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NG-NotificationsPart
		//

		public void TraverseCommon (NG_NotificationsPart p_NG_NotificationsPart)
		{
			NG_NotificationsPart.production_kind kind = (NG_NotificationsPart.production_kind) p_NG_NotificationsPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NG_NotificationsPart))
			switch (kind)
			{
				case NG_NotificationsPart.production_kind.g_NG_NotificationsPart_1:
					// traverse syntax tree node associated with production
					// NG-NotificationsPart: NOTIFICATIONS "{" NG-Notifications "}"

						TraverseCommon (p_NG_NotificationsPart.m_NOTIFICATIONS);
						TraverseCommon (p_NG_NotificationsPart.m_left_curly_bracket);
						TraverseCommon (p_NG_NotificationsPart.m_NG_Notifications);
						TraverseCommon (p_NG_NotificationsPart.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NG_NotificationsPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NG-NotificationsPart

		//
		// create syntax tree node associated with production
		// NG-NotificationsPart: NOTIFICATIONS "{" NG-Notifications "}"

		//

		public NG_NotificationsPart NG_NotificationsPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NG_Notifications p_NG_Notifications, SyntaxTreeToken p_token_2)
		{
			NG_NotificationsPart p_NG_NotificationsPart_ref = new NG_NotificationsPart(p_token, p_token_1, p_NG_Notifications, p_token_2);
			p_token.parent = p_NG_NotificationsPart_ref;
			p_token_1.parent = p_NG_NotificationsPart_ref;
			p_NG_Notifications.parent = p_NG_NotificationsPart_ref;
			p_token_2.parent = p_NG_NotificationsPart_ref;
			Raise_NG_NotificationsPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NG_NotificationsPart.production_kind.g_NG_NotificationsPart_1, p_NG_NotificationsPart_ref);
			return p_NG_NotificationsPart_ref;
		}
		#endregion
	};
}
