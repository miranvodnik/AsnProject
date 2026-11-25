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
	// class associated with syntax rule NG-Notification
	//

	[DataContract]
	public class	NG_Notification : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NG-Notification
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NG-Notification
		{
			g_NG_Notification_1 = 1,	// Value

		};
		#endregion
		#region production markers associated with the syntax rule NG-Notification

		// markers associated with production: NG-Notification -> Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NG-Notification

		// Constructor declaration(s) associated with production(s) of syntax rule NG-Notification

		//
		// Constructor associated with the following production(s)
		// NG-Notification -> Value

		//

		public NG_Notification (Value p_Value) : base ((uint) ProductionID._NG_Notification_ID, (uint) production_kind.g_NG_Notification_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Value = p_Value;
		}

		public NG_Notification () { }

		// Copy constructor

		public NG_Notification (NG_Notification p_NG_Notification) : base (p_NG_Notification.id, p_NG_Notification.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NG_Notification.appInfo;
			switch ((production_kind) p_NG_Notification.kind)
			{
				case production_kind.g_NG_Notification_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Value = (p_NG_Notification.m_Value != null) ? new Value (p_NG_Notification.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NG_Notification" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NG_Notification (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NG-Notification

		// Content changing function(s) associated with production(s) of syntax rule NG-Notification

		//
		// Content changing function associated with following production(s)
		// NG-Notification -> Value

		//

		public void change(Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_NG_Notification_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NG-Notification
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NG-Notification

		//
		// emit production tree node associated with any production of syntax rule NG-Notification
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NG_Notification_1:
					// emit syntax tree node associated with production
					// NG-Notification: Value

					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NG-Notification
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NG_Notification (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NG_Notification_1:
					// emit syntax tree node associated with production
					// NG-Notification: Value

					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NG-Notification

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NG-Notification with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NG_Notification.production_kind kind = (NG_Notification.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NG_Notification.production_kind.g_NG_Notification_1:
					// traverse syntax tree node associated with production
					// NG-Notification: Value

						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NG-Notification
		//

		public void _init ()
		{
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NG-Notification

		// counter of all nodes associated with syntax rule NG-Notification
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NG-Notification
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NG-Notification

		// delegate function (callback) prototype associated with syntax rule NG-Notification
		public delegate bool NG_Notification_Callback (SyntaxTreeCallbackReason reason, NG_Notification.production_kind kind, NG_Notification p_NG_Notification);

		// event associated with syntax rule NG-Notification
		public event NG_Notification_Callback NG_Notification_Event;

		// event trigger associated with syntax rule NG-Notification
		public bool Raise_NG_Notification_Event (SyntaxTreeCallbackReason reason, NG_Notification.production_kind kind, NG_Notification p_NG_Notification)
		{
			bool? status = NG_Notification_Event?.Invoke (reason, kind, p_NG_Notification);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NG-Notification
		//
		// traverse syntax tree node associated with any production of syntax rule NG-Notification
		//

		public void Traverse (NG_Notification p_NG_Notification)
		{
			if (p_NG_Notification.isLocked())
				return;
			p_NG_Notification.dolock();
			NG_Notification.production_kind kind = (NG_Notification.production_kind) p_NG_Notification.kind;
			p_NG_Notification.turn_reset ();
			if (Raise_NG_Notification_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NG_Notification))
			switch (kind)
			{
				case NG_Notification.production_kind.g_NG_Notification_1:
					// traverse syntax tree node associated with production
					// NG-Notification: Value

					if (Raise_NG_Notification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NG_Notification))
						Traverse (p_NG_Notification.m_Value);
					p_NG_Notification.turn_inc ();
					Raise_NG_Notification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NG_Notification);
				break;
			}
			Raise_NG_Notification_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NG_Notification);
			p_NG_Notification.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NG-Notification
		//

		public void TraverseCommon (NG_Notification p_NG_Notification)
		{
			NG_Notification.production_kind kind = (NG_Notification.production_kind) p_NG_Notification.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NG_Notification))
			switch (kind)
			{
				case NG_Notification.production_kind.g_NG_Notification_1:
					// traverse syntax tree node associated with production
					// NG-Notification: Value

						TraverseCommon (p_NG_Notification.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NG_Notification);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NG-Notification

		//
		// create syntax tree node associated with production
		// NG-Notification: Value

		//

		public NG_Notification NG_Notification_1 (Value p_Value)
		{
			NG_Notification p_NG_Notification_ref = new NG_Notification(p_Value);
			p_Value.parent = p_NG_Notification_ref;
			Raise_NG_Notification_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NG_Notification.production_kind.g_NG_Notification_1, p_NG_Notification_ref);
			return p_NG_Notification_ref;
		}
		#endregion
	};
}
