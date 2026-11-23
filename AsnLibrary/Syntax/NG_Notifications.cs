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
	// class associated with syntax rule NG-Notifications
	//

	[DataContract]
	public class	NG_Notifications : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NG-Notifications
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NG-Notifications
		{
			g_NG_Notifications_1 = 1,	// NG-Notification

			g_NG_Notifications_2 = 2,	// NG-Notifications "," NG-Notification

		};
		#endregion
		#region production markers associated with the syntax rule NG-Notifications

		// markers associated with production: NG-Notifications -> NG-Notification

		public enum production_marker_1 : ushort
		{
			m_NG_Notification,
			final
		};

		// markers associated with production: NG-Notifications -> NG-Notifications "," NG-Notification

		public enum production_marker_2 : ushort
		{
			m_NG_Notifications,
			m_NG_Notification,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NG-Notifications

		// Constructor declaration(s) associated with production(s) of syntax rule NG-Notifications

		//
		// Constructor associated with the following production(s)
		// NG-Notifications -> NG-Notification

		//

		public NG_Notifications (NG_Notification p_NG_Notification) : base ((uint) ProductionID._NG_Notifications_ID, (uint) production_kind.g_NG_Notifications_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NG_Notification = p_NG_Notification;
		}

		//
		// Constructor associated with the following production(s)
		// NG-Notifications -> NG-Notifications "," NG-Notification

		//

		public NG_Notifications (NG_Notifications p_NG_Notifications, SyntaxTreeToken p_token, NG_Notification p_NG_Notification) : base ((uint) ProductionID._NG_Notifications_ID, (uint) production_kind.g_NG_Notifications_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_NG_Notifications = p_NG_Notifications;
			children[1] = m_comma = p_token;
			children[2] = m_NG_Notification = p_NG_Notification;
		}

		public NG_Notifications () { }

		// Copy constructor

		public NG_Notifications (NG_Notifications p_NG_Notifications) : base (p_NG_Notifications.id, p_NG_Notifications.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NG_Notifications.appInfo;
			switch ((production_kind) p_NG_Notifications.kind)
			{
				case production_kind.g_NG_Notifications_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NG_Notification = (p_NG_Notifications.m_NG_Notification != null) ? new NG_Notification (p_NG_Notifications.m_NG_Notification) : null) != null) m_NG_Notification.parent = this;
					break;
				case production_kind.g_NG_Notifications_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_NG_Notifications = (p_NG_Notifications.m_NG_Notifications != null) ? new NG_Notifications (p_NG_Notifications.m_NG_Notifications) : null) != null) m_NG_Notifications.parent = this;
					if ((children [1] = m_comma = (p_NG_Notifications.m_comma != null) ? new SyntaxTreeToken (p_NG_Notifications.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_NG_Notification = (p_NG_Notifications.m_NG_Notification != null) ? new NG_Notification (p_NG_Notifications.m_NG_Notification) : null) != null) m_NG_Notification.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NG_Notifications" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NG_Notifications (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_NG_Notification?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NG-Notifications

		// Content changing function(s) associated with production(s) of syntax rule NG-Notifications

		//
		// Content changing function associated with following production(s)
		// NG-Notifications -> NG-Notification

		//

		public void change(NG_Notification p_NG_Notification)
		{
			_init ();
			this.kind = (uint) production_kind.g_NG_Notifications_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NG_Notification = p_NG_Notification;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NG-Notifications -> NG-Notifications "," NG-Notification

		//

		public void change(NG_Notifications p_NG_Notifications, SyntaxTreeToken p_token, NG_Notification p_NG_Notification)
		{
			_init ();
			this.kind = (uint) production_kind.g_NG_Notifications_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_NG_Notifications = p_NG_Notifications;
			children [1] = m_comma = p_token;
			children [2] = m_NG_Notification = p_NG_Notification;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NG-Notifications
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_NG_Notification != null) && node.m_NG_Notification.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NG-Notifications

		//
		// emit production tree node associated with any production of syntax rule NG-Notifications
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_NG_Notifications_1:
						// emit syntax tree node associated with production
						// NG-Notifications: NG-Notification

						s += " " + node.m_NG_Notification.Emit (depth - 1);
						break;
					case production_kind.g_NG_Notifications_2:
						// emit syntax tree node associated with production
						// NG-Notifications: NG-Notifications "," NG-Notification

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_NG_Notification.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NG-Notifications
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "NG_Notifications (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_NG_Notifications_1:
						// emit syntax tree node associated with production
						// NG-Notifications: NG-Notification

						str += node.m_NG_Notification.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_NG_Notifications_2:
						// emit syntax tree node associated with production
						// NG-Notifications: NG-Notifications "," NG-Notification

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_NG_Notification.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NG-Notifications

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NG-Notifications with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					NG_Notifications.production_kind kind = (NG_Notifications.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case NG_Notifications.production_kind.g_NG_Notifications_1:
							// traverse syntax tree node associated with production
							// NG-Notifications: NG-Notification

							node.m_NG_Notification.Visit (visitor, appData);
							break;
						case NG_Notifications.production_kind.g_NG_Notifications_2:
							// traverse syntax tree node associated with production
							// NG-Notifications: NG-Notifications "," NG-Notification

							node.m_comma.Visit (visitor, appData);
							node.m_NG_Notification.Visit (visitor, appData);
							break;
						}
					visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node, appData);
					return null;
				});
			visitor (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) this.kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			for (NG_Notifications node = this; node != null; node = node.m_NG_Notifications)
			{
				node.parent = parent;
				node.m_NG_Notification?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule NG-Notifications
		//

		public void _init ()
		{
			m_NG_Notification = null;
			m_NG_Notifications = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (NG_Notifications p_NG_Notifications, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<NG_Notifications> stack = new Stack<NG_Notifications> ();
			NG_Notifications p_NG_Notifications;
			for (p_NG_Notifications = this; p_NG_Notifications != null; p_NG_Notifications = p_NG_Notifications.m_NG_Notifications)
				stack.Push (p_NG_Notifications);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NG-Notifications

		// counter of all nodes associated with syntax rule NG-Notifications
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NG-Notifications
		[DataMember (Name = "m_NG_Notification")] public NG_Notification m_NG_Notification { get; private set; }
		[DataMember (Name = "m_NG_Notifications")] public NG_Notifications m_NG_Notifications { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NG-Notifications

		// delegate function (callback) prototype associated with syntax rule NG-Notifications
		public delegate bool NG_Notifications_Callback (SyntaxTreeCallbackReason reason, NG_Notifications.production_kind kind, NG_Notifications p_NG_Notifications);

		// event associated with syntax rule NG-Notifications
		public event NG_Notifications_Callback NG_Notifications_Event;

		// event trigger associated with syntax rule NG-Notifications
		public bool Raise_NG_Notifications_Event (SyntaxTreeCallbackReason reason, NG_Notifications.production_kind kind, NG_Notifications p_NG_Notifications)
		{
			bool? status = NG_Notifications_Event?.Invoke (reason, kind, p_NG_Notifications);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NG-Notifications
		//
		// traverse syntax tree node associated with any production of syntax rule NG-Notifications
		//

		public void Traverse (NG_Notifications p_NG_Notifications)
		{
			if (p_NG_Notifications.isLocked())
				return;
			if (Raise_NG_Notifications_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (NG_Notifications.production_kind) p_NG_Notifications.kind, p_NG_Notifications))
				p_NG_Notifications.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					NG_Notifications.production_kind kind = (NG_Notifications.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_NG_Notifications_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case NG_Notifications.production_kind.g_NG_Notifications_1:
								// traverse syntax tree node associated with production
								// NG-Notifications: NG-Notification

								if (Raise_NG_Notifications_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NG_Notification);
								node.turn_inc ();
								Raise_NG_Notifications_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case NG_Notifications.production_kind.g_NG_Notifications_2:
								// traverse syntax tree node associated with production
								// NG-Notifications: NG-Notifications "," NG-Notification

								if (Raise_NG_Notifications_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_NG_Notifications_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_NG_Notification);
								node.turn_inc ();
								Raise_NG_Notifications_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_NG_Notifications_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_NG_Notifications_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (NG_Notifications.production_kind) p_NG_Notifications.kind, p_NG_Notifications);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NG-Notifications
		//

		public void TraverseCommon (NG_Notifications p_NG_Notifications)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_NG_Notifications.kind, p_NG_Notifications))
				p_NG_Notifications.Iterate (null, (node, appData) =>
				{
					NG_Notifications.production_kind kind = (NG_Notifications.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case NG_Notifications.production_kind.g_NG_Notifications_1:
							// traverse syntax tree node associated with production
							// NG-Notifications: NG-Notification

							TraverseCommon (node.m_NG_Notification);
							break;
						case NG_Notifications.production_kind.g_NG_Notifications_2:
							// traverse syntax tree node associated with production
							// NG-Notifications: NG-Notifications "," NG-Notification

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_NG_Notification);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_NG_Notifications.kind, p_NG_Notifications);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NG-Notifications

		//
		// create syntax tree node associated with production
		// NG-Notifications: NG-Notification

		//

		public NG_Notifications NG_Notifications_1 (NG_Notification p_NG_Notification)
		{
			NG_Notifications p_NG_Notifications_ref = new NG_Notifications(p_NG_Notification);
			p_NG_Notification.parent = p_NG_Notifications_ref;
			Raise_NG_Notifications_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NG_Notifications.production_kind.g_NG_Notifications_1, p_NG_Notifications_ref);
			return p_NG_Notifications_ref;
		}

		//
		// create syntax tree node associated with production
		// NG-Notifications: NG-Notifications "," NG-Notification

		//

		public NG_Notifications NG_Notifications_2 (NG_Notifications p_NG_Notifications, SyntaxTreeToken p_token, NG_Notification p_NG_Notification)
		{
			NG_Notifications p_NG_Notifications_ref = new NG_Notifications(p_NG_Notifications, p_token, p_NG_Notification);
			p_NG_Notifications.parent = p_NG_Notifications_ref;
			p_token.parent = p_NG_Notifications_ref;
			p_NG_Notification.parent = p_NG_Notifications_ref;
			Raise_NG_Notifications_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NG_Notifications.production_kind.g_NG_Notifications_2, p_NG_Notifications_ref);
			return p_NG_Notifications_ref;
		}
		#endregion
	};
}
