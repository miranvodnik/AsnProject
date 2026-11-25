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
	// class associated with syntax rule NotificationTypeMacro
	//

	[DataContract]
	public class	NotificationTypeMacro : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NotificationTypeMacro
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NotificationTypeMacro
		{
			g_NotificationTypeMacro_1 = 1,	// NOTIFICATION-TYPE NT-ObjectsPart STATUS NT-Status DESCRIPTION cstring NT-ReferPart

		};
		#endregion
		#region production markers associated with the syntax rule NotificationTypeMacro

		// markers associated with production: NotificationTypeMacro -> NOTIFICATION-TYPE NT-ObjectsPart STATUS NT-Status DESCRIPTION cstring NT-ReferPart

		public enum production_marker_1 : ushort
		{
			m_NT_ObjectsPart,
			m_NT_Status,
			m_NT_ReferPart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NotificationTypeMacro

		// Constructor declaration(s) associated with production(s) of syntax rule NotificationTypeMacro

		//
		// Constructor associated with the following production(s)
		// NotificationTypeMacro -> NOTIFICATION-TYPE NT-ObjectsPart STATUS NT-Status DESCRIPTION cstring NT-ReferPart

		//

		public NotificationTypeMacro (SyntaxTreeToken p_token, NT_ObjectsPart p_NT_ObjectsPart, SyntaxTreeToken p_token_1, NT_Status p_NT_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, NT_ReferPart p_NT_ReferPart) : base ((uint) ProductionID._NotificationTypeMacro_ID, (uint) production_kind.g_NotificationTypeMacro_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children[0] = m_NOTIFICATION_TYPE = p_token;
			children[1] = m_NT_ObjectsPart = p_NT_ObjectsPart;
			children[2] = m_STATUS = p_token_1;
			children[3] = m_NT_Status = p_NT_Status;
			children[4] = m_DESCRIPTION = p_token_2;
			children[5] = m_cstring = p_token_3;
			children[6] = m_NT_ReferPart = p_NT_ReferPart;
		}

		public NotificationTypeMacro () { }

		// Copy constructor

		public NotificationTypeMacro (NotificationTypeMacro p_NotificationTypeMacro) : base (p_NotificationTypeMacro.id, p_NotificationTypeMacro.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NotificationTypeMacro.appInfo;
			switch ((production_kind) p_NotificationTypeMacro.kind)
			{
				case production_kind.g_NotificationTypeMacro_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_NOTIFICATION_TYPE = (p_NotificationTypeMacro.m_NOTIFICATION_TYPE != null) ? new SyntaxTreeToken (p_NotificationTypeMacro.m_NOTIFICATION_TYPE) : null) != null) m_NOTIFICATION_TYPE.parent = this;
					if ((children [1] = m_NT_ObjectsPart = (p_NotificationTypeMacro.m_NT_ObjectsPart != null) ? new NT_ObjectsPart (p_NotificationTypeMacro.m_NT_ObjectsPart) : null) != null) m_NT_ObjectsPart.parent = this;
					if ((children [2] = m_STATUS = (p_NotificationTypeMacro.m_STATUS != null) ? new SyntaxTreeToken (p_NotificationTypeMacro.m_STATUS) : null) != null) m_STATUS.parent = this;
					if ((children [3] = m_NT_Status = (p_NotificationTypeMacro.m_NT_Status != null) ? new NT_Status (p_NotificationTypeMacro.m_NT_Status) : null) != null) m_NT_Status.parent = this;
					if ((children [4] = m_DESCRIPTION = (p_NotificationTypeMacro.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_NotificationTypeMacro.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [5] = m_cstring = (p_NotificationTypeMacro.m_cstring != null) ? new SyntaxTreeToken (p_NotificationTypeMacro.m_cstring) : null) != null) m_cstring.parent = this;
					if ((children [6] = m_NT_ReferPart = (p_NotificationTypeMacro.m_NT_ReferPart != null) ? new NT_ReferPart (p_NotificationTypeMacro.m_NT_ReferPart) : null) != null) m_NT_ReferPart.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NotificationTypeMacro" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NotificationTypeMacro (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_NOTIFICATION_TYPE?.Dispose ();
			m_NT_ObjectsPart?.Dispose ();
			m_STATUS?.Dispose ();
			m_NT_Status?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_cstring?.Dispose ();
			m_NT_ReferPart?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NotificationTypeMacro

		// Content changing function(s) associated with production(s) of syntax rule NotificationTypeMacro

		//
		// Content changing function associated with following production(s)
		// NotificationTypeMacro -> NOTIFICATION-TYPE NT-ObjectsPart STATUS NT-Status DESCRIPTION cstring NT-ReferPart

		//

		public void change(SyntaxTreeToken p_token, NT_ObjectsPart p_NT_ObjectsPart, SyntaxTreeToken p_token_1, NT_Status p_NT_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, NT_ReferPart p_NT_ReferPart)
		{
			_init ();
			this.kind = (uint) production_kind.g_NotificationTypeMacro_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children [0] = m_NOTIFICATION_TYPE = p_token;
			children [1] = m_NT_ObjectsPart = p_NT_ObjectsPart;
			children [2] = m_STATUS = p_token_1;
			children [3] = m_NT_Status = p_NT_Status;
			children [4] = m_DESCRIPTION = p_token_2;
			children [5] = m_cstring = p_token_3;
			children [6] = m_NT_ReferPart = p_NT_ReferPart;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NotificationTypeMacro
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_NOTIFICATION_TYPE != null) && m_NOTIFICATION_TYPE.checkInclusion (element) ||
				(m_NT_ObjectsPart != null) && m_NT_ObjectsPart.checkInclusion (element) ||
				(m_STATUS != null) && m_STATUS.checkInclusion (element) ||
				(m_NT_Status != null) && m_NT_Status.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				(m_NT_ReferPart != null) && m_NT_ReferPart.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NotificationTypeMacro

		//
		// emit production tree node associated with any production of syntax rule NotificationTypeMacro
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NotificationTypeMacro_1:
					// emit syntax tree node associated with production
					// NotificationTypeMacro: NOTIFICATION-TYPE NT-ObjectsPart STATUS NT-Status DESCRIPTION cstring NT-ReferPart

					s += m_NOTIFICATION_TYPE.Emit (depth - 1);
					s += " ";
					s += m_NT_ObjectsPart.Emit (depth - 1);
					s += " ";
					s += m_STATUS.Emit (depth - 1);
					s += " ";
					s += m_NT_Status.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
					s += " ";
					s += m_NT_ReferPart.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NotificationTypeMacro
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NotificationTypeMacro (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NotificationTypeMacro_1:
					// emit syntax tree node associated with production
					// NotificationTypeMacro: NOTIFICATION-TYPE NT-ObjectsPart STATUS NT-Status DESCRIPTION cstring NT-ReferPart

					s += "NOTIFICATION_TYPE";
					s += ' ';
					s += m_NT_ObjectsPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += "STATUS";
					s += ' ';
					s += m_NT_Status.EmitProductionTree (depth - 1);
					s += ' ';
					s += "DESCRIPTION";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += m_NT_ReferPart.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NotificationTypeMacro

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NotificationTypeMacro with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NotificationTypeMacro.production_kind kind = (NotificationTypeMacro.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NotificationTypeMacro.production_kind.g_NotificationTypeMacro_1:
					// traverse syntax tree node associated with production
					// NotificationTypeMacro: NOTIFICATION-TYPE NT-ObjectsPart STATUS NT-Status DESCRIPTION cstring NT-ReferPart

						m_NOTIFICATION_TYPE.Visit (visitor, appData);
						m_NT_ObjectsPart.Visit (visitor, appData);
						m_STATUS.Visit (visitor, appData);
						m_NT_Status.Visit (visitor, appData);
						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
						m_NT_ReferPart.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_NOTIFICATION_TYPE?.reparent (this);
			m_NT_ObjectsPart?.reparent (this);
			m_STATUS?.reparent (this);
			m_NT_Status?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_cstring?.reparent (this);
			m_NT_ReferPart?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NotificationTypeMacro
		//

		public void _init ()
		{
			m_NOTIFICATION_TYPE = null;
			m_NT_ObjectsPart = null;
			m_STATUS = null;
			m_NT_Status = null;
			m_DESCRIPTION = null;
			m_cstring = null;
			m_NT_ReferPart = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NotificationTypeMacro

		// counter of all nodes associated with syntax rule NotificationTypeMacro
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NotificationTypeMacro
		[DataMember (Name = "m_NOTIFICATION_TYPE")] public SyntaxTreeToken m_NOTIFICATION_TYPE { get; private set; }
		[DataMember (Name = "m_NT_ObjectsPart")] public NT_ObjectsPart m_NT_ObjectsPart { get; private set; }
		[DataMember (Name = "m_STATUS")] public SyntaxTreeToken m_STATUS { get; private set; }
		[DataMember (Name = "m_NT_Status")] public NT_Status m_NT_Status { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		[DataMember (Name = "m_NT_ReferPart")] public NT_ReferPart m_NT_ReferPart { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NotificationTypeMacro

		// delegate function (callback) prototype associated with syntax rule NotificationTypeMacro
		public delegate bool NotificationTypeMacro_Callback (SyntaxTreeCallbackReason reason, NotificationTypeMacro.production_kind kind, NotificationTypeMacro p_NotificationTypeMacro);

		// event associated with syntax rule NotificationTypeMacro
		public event NotificationTypeMacro_Callback NotificationTypeMacro_Event;

		// event trigger associated with syntax rule NotificationTypeMacro
		public bool Raise_NotificationTypeMacro_Event (SyntaxTreeCallbackReason reason, NotificationTypeMacro.production_kind kind, NotificationTypeMacro p_NotificationTypeMacro)
		{
			bool? status = NotificationTypeMacro_Event?.Invoke (reason, kind, p_NotificationTypeMacro);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NotificationTypeMacro
		//
		// traverse syntax tree node associated with any production of syntax rule NotificationTypeMacro
		//

		public void Traverse (NotificationTypeMacro p_NotificationTypeMacro)
		{
			if (p_NotificationTypeMacro.isLocked())
				return;
			p_NotificationTypeMacro.dolock();
			NotificationTypeMacro.production_kind kind = (NotificationTypeMacro.production_kind) p_NotificationTypeMacro.kind;
			p_NotificationTypeMacro.turn_reset ();
			if (Raise_NotificationTypeMacro_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NotificationTypeMacro))
			switch (kind)
			{
				case NotificationTypeMacro.production_kind.g_NotificationTypeMacro_1:
					// traverse syntax tree node associated with production
					// NotificationTypeMacro: NOTIFICATION-TYPE NT-ObjectsPart STATUS NT-Status DESCRIPTION cstring NT-ReferPart

					if (Raise_NotificationTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NotificationTypeMacro))
						Traverse (p_NotificationTypeMacro.m_NT_ObjectsPart);
					p_NotificationTypeMacro.turn_inc ();
					if (Raise_NotificationTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NotificationTypeMacro))
						Traverse (p_NotificationTypeMacro.m_NT_Status);
					p_NotificationTypeMacro.turn_inc ();
					if (Raise_NotificationTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NotificationTypeMacro))
						Traverse (p_NotificationTypeMacro.m_NT_ReferPart);
					p_NotificationTypeMacro.turn_inc ();
					Raise_NotificationTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NotificationTypeMacro);
				break;
			}
			Raise_NotificationTypeMacro_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NotificationTypeMacro);
			p_NotificationTypeMacro.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NotificationTypeMacro
		//

		public void TraverseCommon (NotificationTypeMacro p_NotificationTypeMacro)
		{
			NotificationTypeMacro.production_kind kind = (NotificationTypeMacro.production_kind) p_NotificationTypeMacro.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NotificationTypeMacro))
			switch (kind)
			{
				case NotificationTypeMacro.production_kind.g_NotificationTypeMacro_1:
					// traverse syntax tree node associated with production
					// NotificationTypeMacro: NOTIFICATION-TYPE NT-ObjectsPart STATUS NT-Status DESCRIPTION cstring NT-ReferPart

						TraverseCommon (p_NotificationTypeMacro.m_NOTIFICATION_TYPE);
						TraverseCommon (p_NotificationTypeMacro.m_NT_ObjectsPart);
						TraverseCommon (p_NotificationTypeMacro.m_STATUS);
						TraverseCommon (p_NotificationTypeMacro.m_NT_Status);
						TraverseCommon (p_NotificationTypeMacro.m_DESCRIPTION);
						TraverseCommon (p_NotificationTypeMacro.m_cstring);
						TraverseCommon (p_NotificationTypeMacro.m_NT_ReferPart);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NotificationTypeMacro);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NotificationTypeMacro

		//
		// create syntax tree node associated with production
		// NotificationTypeMacro: NOTIFICATION-TYPE NT-ObjectsPart STATUS NT-Status DESCRIPTION cstring NT-ReferPart

		//

		public NotificationTypeMacro NotificationTypeMacro_1 (SyntaxTreeToken p_token, NT_ObjectsPart p_NT_ObjectsPart, SyntaxTreeToken p_token_1, NT_Status p_NT_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, NT_ReferPart p_NT_ReferPart)
		{
			NotificationTypeMacro p_NotificationTypeMacro_ref = new NotificationTypeMacro(p_token, p_NT_ObjectsPart, p_token_1, p_NT_Status, p_token_2, p_token_3, p_NT_ReferPart);
			p_token.parent = p_NotificationTypeMacro_ref;
			p_NT_ObjectsPart.parent = p_NotificationTypeMacro_ref;
			p_token_1.parent = p_NotificationTypeMacro_ref;
			p_NT_Status.parent = p_NotificationTypeMacro_ref;
			p_token_2.parent = p_NotificationTypeMacro_ref;
			p_token_3.parent = p_NotificationTypeMacro_ref;
			p_NT_ReferPart.parent = p_NotificationTypeMacro_ref;
			Raise_NotificationTypeMacro_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NotificationTypeMacro.production_kind.g_NotificationTypeMacro_1, p_NotificationTypeMacro_ref);
			return p_NotificationTypeMacro_ref;
		}
		#endregion
	};
}
