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
	// class associated with syntax rule NotificationGroupMacro
	//

	[DataContract]
	public class	NotificationGroupMacro : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NotificationGroupMacro
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NotificationGroupMacro
		{
			g_NotificationGroupMacro_1 = 1,	// NOTIFICATION-GROUP NG-NotificationsPart STATUS NG-Status DESCRIPTION cstring NG-ReferPart

		};
		#endregion
		#region production markers associated with the syntax rule NotificationGroupMacro

		// markers associated with production: NotificationGroupMacro -> NOTIFICATION-GROUP NG-NotificationsPart STATUS NG-Status DESCRIPTION cstring NG-ReferPart

		public enum production_marker_1 : ushort
		{
			m_NG_NotificationsPart,
			m_NG_Status,
			m_NG_ReferPart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NotificationGroupMacro

		// Constructor declaration(s) associated with production(s) of syntax rule NotificationGroupMacro

		//
		// Constructor associated with the following production(s)
		// NotificationGroupMacro -> NOTIFICATION-GROUP NG-NotificationsPart STATUS NG-Status DESCRIPTION cstring NG-ReferPart

		//

		public NotificationGroupMacro (SyntaxTreeToken p_token, NG_NotificationsPart p_NG_NotificationsPart, SyntaxTreeToken p_token_1, NG_Status p_NG_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, NG_ReferPart p_NG_ReferPart) : base ((uint) ProductionID._NotificationGroupMacro_ID, (uint) production_kind.g_NotificationGroupMacro_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children[0] = m_NOTIFICATION_GROUP = p_token;
			children[1] = m_NG_NotificationsPart = p_NG_NotificationsPart;
			children[2] = m_STATUS = p_token_1;
			children[3] = m_NG_Status = p_NG_Status;
			children[4] = m_DESCRIPTION = p_token_2;
			children[5] = m_cstring = p_token_3;
			children[6] = m_NG_ReferPart = p_NG_ReferPart;
		}

		public NotificationGroupMacro () { }

		// Copy constructor

		public NotificationGroupMacro (NotificationGroupMacro p_NotificationGroupMacro) : base (p_NotificationGroupMacro.id, p_NotificationGroupMacro.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NotificationGroupMacro.appInfo;
			switch ((production_kind) p_NotificationGroupMacro.kind)
			{
				case production_kind.g_NotificationGroupMacro_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_NOTIFICATION_GROUP = (p_NotificationGroupMacro.m_NOTIFICATION_GROUP != null) ? new SyntaxTreeToken (p_NotificationGroupMacro.m_NOTIFICATION_GROUP) : null) != null) m_NOTIFICATION_GROUP.parent = this;
					if ((children [1] = m_NG_NotificationsPart = (p_NotificationGroupMacro.m_NG_NotificationsPart != null) ? new NG_NotificationsPart (p_NotificationGroupMacro.m_NG_NotificationsPart) : null) != null) m_NG_NotificationsPart.parent = this;
					if ((children [2] = m_STATUS = (p_NotificationGroupMacro.m_STATUS != null) ? new SyntaxTreeToken (p_NotificationGroupMacro.m_STATUS) : null) != null) m_STATUS.parent = this;
					if ((children [3] = m_NG_Status = (p_NotificationGroupMacro.m_NG_Status != null) ? new NG_Status (p_NotificationGroupMacro.m_NG_Status) : null) != null) m_NG_Status.parent = this;
					if ((children [4] = m_DESCRIPTION = (p_NotificationGroupMacro.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_NotificationGroupMacro.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [5] = m_cstring = (p_NotificationGroupMacro.m_cstring != null) ? new SyntaxTreeToken (p_NotificationGroupMacro.m_cstring) : null) != null) m_cstring.parent = this;
					if ((children [6] = m_NG_ReferPart = (p_NotificationGroupMacro.m_NG_ReferPart != null) ? new NG_ReferPart (p_NotificationGroupMacro.m_NG_ReferPart) : null) != null) m_NG_ReferPart.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NotificationGroupMacro" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NotificationGroupMacro (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_NOTIFICATION_GROUP?.Dispose ();
			m_NG_NotificationsPart?.Dispose ();
			m_STATUS?.Dispose ();
			m_NG_Status?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_cstring?.Dispose ();
			m_NG_ReferPart?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NotificationGroupMacro

		// Content changing function(s) associated with production(s) of syntax rule NotificationGroupMacro

		//
		// Content changing function associated with following production(s)
		// NotificationGroupMacro -> NOTIFICATION-GROUP NG-NotificationsPart STATUS NG-Status DESCRIPTION cstring NG-ReferPart

		//

		public void change(SyntaxTreeToken p_token, NG_NotificationsPart p_NG_NotificationsPart, SyntaxTreeToken p_token_1, NG_Status p_NG_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, NG_ReferPart p_NG_ReferPart)
		{
			_init ();
			this.kind = (uint) production_kind.g_NotificationGroupMacro_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children [0] = m_NOTIFICATION_GROUP = p_token;
			children [1] = m_NG_NotificationsPart = p_NG_NotificationsPart;
			children [2] = m_STATUS = p_token_1;
			children [3] = m_NG_Status = p_NG_Status;
			children [4] = m_DESCRIPTION = p_token_2;
			children [5] = m_cstring = p_token_3;
			children [6] = m_NG_ReferPart = p_NG_ReferPart;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NotificationGroupMacro
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_NOTIFICATION_GROUP != null) && m_NOTIFICATION_GROUP.checkInclusion (element) ||
				(m_NG_NotificationsPart != null) && m_NG_NotificationsPart.checkInclusion (element) ||
				(m_STATUS != null) && m_STATUS.checkInclusion (element) ||
				(m_NG_Status != null) && m_NG_Status.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				(m_NG_ReferPart != null) && m_NG_ReferPart.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NotificationGroupMacro

		//
		// emit production tree node associated with any production of syntax rule NotificationGroupMacro
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NotificationGroupMacro_1:
					// emit syntax tree node associated with production
					// NotificationGroupMacro: NOTIFICATION-GROUP NG-NotificationsPart STATUS NG-Status DESCRIPTION cstring NG-ReferPart

					s += m_NOTIFICATION_GROUP.Emit (depth - 1);
					s += " ";
					s += m_NG_NotificationsPart.Emit (depth - 1);
					s += " ";
					s += m_STATUS.Emit (depth - 1);
					s += " ";
					s += m_NG_Status.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
					s += " ";
					s += m_NG_ReferPart.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NotificationGroupMacro
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NotificationGroupMacro (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NotificationGroupMacro_1:
					// emit syntax tree node associated with production
					// NotificationGroupMacro: NOTIFICATION-GROUP NG-NotificationsPart STATUS NG-Status DESCRIPTION cstring NG-ReferPart

					s += "NOTIFICATION_GROUP";
					s += ' ';
					s += m_NG_NotificationsPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += "STATUS";
					s += ' ';
					s += m_NG_Status.EmitProductionTree (depth - 1);
					s += ' ';
					s += "DESCRIPTION";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += m_NG_ReferPart.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NotificationGroupMacro

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NotificationGroupMacro with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NotificationGroupMacro.production_kind kind = (NotificationGroupMacro.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NotificationGroupMacro.production_kind.g_NotificationGroupMacro_1:
					// traverse syntax tree node associated with production
					// NotificationGroupMacro: NOTIFICATION-GROUP NG-NotificationsPart STATUS NG-Status DESCRIPTION cstring NG-ReferPart

						m_NOTIFICATION_GROUP.Visit (visitor, appData);
						m_NG_NotificationsPart.Visit (visitor, appData);
						m_STATUS.Visit (visitor, appData);
						m_NG_Status.Visit (visitor, appData);
						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
						m_NG_ReferPart.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_NOTIFICATION_GROUP?.reparent (this);
			m_NG_NotificationsPart?.reparent (this);
			m_STATUS?.reparent (this);
			m_NG_Status?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_cstring?.reparent (this);
			m_NG_ReferPart?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NotificationGroupMacro
		//

		public void _init ()
		{
			m_NOTIFICATION_GROUP = null;
			m_NG_NotificationsPart = null;
			m_STATUS = null;
			m_NG_Status = null;
			m_DESCRIPTION = null;
			m_cstring = null;
			m_NG_ReferPart = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NotificationGroupMacro

		// counter of all nodes associated with syntax rule NotificationGroupMacro
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NotificationGroupMacro
		[DataMember (Name = "m_NOTIFICATION_GROUP")] public SyntaxTreeToken m_NOTIFICATION_GROUP { get; private set; }
		[DataMember (Name = "m_NG_NotificationsPart")] public NG_NotificationsPart m_NG_NotificationsPart { get; private set; }
		[DataMember (Name = "m_STATUS")] public SyntaxTreeToken m_STATUS { get; private set; }
		[DataMember (Name = "m_NG_Status")] public NG_Status m_NG_Status { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		[DataMember (Name = "m_NG_ReferPart")] public NG_ReferPart m_NG_ReferPart { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NotificationGroupMacro

		// delegate function (callback) prototype associated with syntax rule NotificationGroupMacro
		public delegate bool NotificationGroupMacro_Callback (SyntaxTreeCallbackReason reason, NotificationGroupMacro.production_kind kind, NotificationGroupMacro p_NotificationGroupMacro);

		// event associated with syntax rule NotificationGroupMacro
		public event NotificationGroupMacro_Callback NotificationGroupMacro_Event;

		// event trigger associated with syntax rule NotificationGroupMacro
		public bool Raise_NotificationGroupMacro_Event (SyntaxTreeCallbackReason reason, NotificationGroupMacro.production_kind kind, NotificationGroupMacro p_NotificationGroupMacro)
		{
			bool? status = NotificationGroupMacro_Event?.Invoke (reason, kind, p_NotificationGroupMacro);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NotificationGroupMacro
		//
		// traverse syntax tree node associated with any production of syntax rule NotificationGroupMacro
		//

		public void Traverse (NotificationGroupMacro p_NotificationGroupMacro)
		{
			if (p_NotificationGroupMacro.isLocked())
				return;
			p_NotificationGroupMacro.dolock();
			NotificationGroupMacro.production_kind kind = (NotificationGroupMacro.production_kind) p_NotificationGroupMacro.kind;
			p_NotificationGroupMacro.turn_reset ();
			if (Raise_NotificationGroupMacro_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NotificationGroupMacro))
			switch (kind)
			{
				case NotificationGroupMacro.production_kind.g_NotificationGroupMacro_1:
					// traverse syntax tree node associated with production
					// NotificationGroupMacro: NOTIFICATION-GROUP NG-NotificationsPart STATUS NG-Status DESCRIPTION cstring NG-ReferPart

					if (Raise_NotificationGroupMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NotificationGroupMacro))
						Traverse (p_NotificationGroupMacro.m_NG_NotificationsPart);
					p_NotificationGroupMacro.turn_inc ();
					if (Raise_NotificationGroupMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NotificationGroupMacro))
						Traverse (p_NotificationGroupMacro.m_NG_Status);
					p_NotificationGroupMacro.turn_inc ();
					if (Raise_NotificationGroupMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NotificationGroupMacro))
						Traverse (p_NotificationGroupMacro.m_NG_ReferPart);
					p_NotificationGroupMacro.turn_inc ();
					Raise_NotificationGroupMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NotificationGroupMacro);
				break;
			}
			Raise_NotificationGroupMacro_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NotificationGroupMacro);
			p_NotificationGroupMacro.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NotificationGroupMacro
		//

		public void TraverseCommon (NotificationGroupMacro p_NotificationGroupMacro)
		{
			NotificationGroupMacro.production_kind kind = (NotificationGroupMacro.production_kind) p_NotificationGroupMacro.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NotificationGroupMacro))
			switch (kind)
			{
				case NotificationGroupMacro.production_kind.g_NotificationGroupMacro_1:
					// traverse syntax tree node associated with production
					// NotificationGroupMacro: NOTIFICATION-GROUP NG-NotificationsPart STATUS NG-Status DESCRIPTION cstring NG-ReferPart

						TraverseCommon (p_NotificationGroupMacro.m_NOTIFICATION_GROUP);
						TraverseCommon (p_NotificationGroupMacro.m_NG_NotificationsPart);
						TraverseCommon (p_NotificationGroupMacro.m_STATUS);
						TraverseCommon (p_NotificationGroupMacro.m_NG_Status);
						TraverseCommon (p_NotificationGroupMacro.m_DESCRIPTION);
						TraverseCommon (p_NotificationGroupMacro.m_cstring);
						TraverseCommon (p_NotificationGroupMacro.m_NG_ReferPart);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NotificationGroupMacro);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NotificationGroupMacro

		//
		// create syntax tree node associated with production
		// NotificationGroupMacro: NOTIFICATION-GROUP NG-NotificationsPart STATUS NG-Status DESCRIPTION cstring NG-ReferPart

		//

		public NotificationGroupMacro NotificationGroupMacro_1 (SyntaxTreeToken p_token, NG_NotificationsPart p_NG_NotificationsPart, SyntaxTreeToken p_token_1, NG_Status p_NG_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, NG_ReferPart p_NG_ReferPart)
		{
			NotificationGroupMacro p_NotificationGroupMacro_ref = new NotificationGroupMacro(p_token, p_NG_NotificationsPart, p_token_1, p_NG_Status, p_token_2, p_token_3, p_NG_ReferPart);
			p_token.parent = p_NotificationGroupMacro_ref;
			p_NG_NotificationsPart.parent = p_NotificationGroupMacro_ref;
			p_token_1.parent = p_NotificationGroupMacro_ref;
			p_NG_Status.parent = p_NotificationGroupMacro_ref;
			p_token_2.parent = p_NotificationGroupMacro_ref;
			p_token_3.parent = p_NotificationGroupMacro_ref;
			p_NG_ReferPart.parent = p_NotificationGroupMacro_ref;
			Raise_NotificationGroupMacro_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NotificationGroupMacro.production_kind.g_NotificationGroupMacro_1, p_NotificationGroupMacro_ref);
			return p_NotificationGroupMacro_ref;
		}
		#endregion
	};
}
