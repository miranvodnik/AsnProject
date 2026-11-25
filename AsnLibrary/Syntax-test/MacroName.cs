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
	// class associated with syntax rule MacroName
	//

	[DataContract]
	public class	MacroName : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MacroName
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MacroName
		{
			g_MacroName_1 = 1,	// MODULE-IDENTITY

			g_MacroName_2 = 2,	// OBJECT-IDENTITY

			g_MacroName_3 = 3,	// OBJECT-TYPE

			g_MacroName_4 = 4,	// NOTIFICATION-TYPE

			g_MacroName_5 = 5,	// TEXTUAL-CONVENTION

			g_MacroName_6 = 6,	// OBJECT-GROUP

			g_MacroName_7 = 7,	// NOTIFICATION-GROUP

			g_MacroName_8 = 8,	// MODULE-COMPLIANCE

			g_MacroName_9 = 9,	// AGENT-CAPABILITIES

			g_MacroName_10 = 10,	// TRAP-TYPE

		};
		#endregion
		#region production markers associated with the syntax rule MacroName

		// markers associated with production: MacroName -> MODULE-IDENTITY

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: MacroName -> OBJECT-IDENTITY

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: MacroName -> OBJECT-TYPE

		public enum production_marker_3 : ushort
		{
			final
		};

		// markers associated with production: MacroName -> NOTIFICATION-TYPE

		public enum production_marker_4 : ushort
		{
			final
		};

		// markers associated with production: MacroName -> TEXTUAL-CONVENTION

		public enum production_marker_5 : ushort
		{
			final
		};

		// markers associated with production: MacroName -> OBJECT-GROUP

		public enum production_marker_6 : ushort
		{
			final
		};

		// markers associated with production: MacroName -> NOTIFICATION-GROUP

		public enum production_marker_7 : ushort
		{
			final
		};

		// markers associated with production: MacroName -> MODULE-COMPLIANCE

		public enum production_marker_8 : ushort
		{
			final
		};

		// markers associated with production: MacroName -> AGENT-CAPABILITIES

		public enum production_marker_9 : ushort
		{
			final
		};

		// markers associated with production: MacroName -> TRAP-TYPE

		public enum production_marker_10 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MacroName

		// Constructor declaration(s) associated with production(s) of syntax rule MacroName

		//
		// Constructor associated with the following production(s)
		// MacroName -> MODULE-IDENTITY

		// MacroName -> OBJECT-IDENTITY

		// MacroName -> OBJECT-TYPE

		// MacroName -> NOTIFICATION-TYPE

		// MacroName -> TEXTUAL-CONVENTION

		// MacroName -> OBJECT-GROUP

		// MacroName -> NOTIFICATION-GROUP

		// MacroName -> MODULE-COMPLIANCE

		// MacroName -> AGENT-CAPABILITIES

		// MacroName -> TRAP-TYPE

		//

		public MacroName (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._MacroName_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_MacroName_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MODULE_IDENTITY = p_token;
				break;
			case production_kind.g_MacroName_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_OBJECT_IDENTITY = p_token;
				break;
			case production_kind.g_MacroName_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_OBJECT_TYPE = p_token;
				break;
			case production_kind.g_MacroName_4:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_NOTIFICATION_TYPE = p_token;
				break;
			case production_kind.g_MacroName_5:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TEXTUAL_CONVENTION = p_token;
				break;
			case production_kind.g_MacroName_6:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_OBJECT_GROUP = p_token;
				break;
			case production_kind.g_MacroName_7:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_NOTIFICATION_GROUP = p_token;
				break;
			case production_kind.g_MacroName_8:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MODULE_COMPLIANCE = p_token;
				break;
			case production_kind.g_MacroName_9:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_AGENT_CAPABILITIES = p_token;
				break;
			case production_kind.g_MacroName_10:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TRAP_TYPE = p_token;
				break;
			default:
				{
					string[] args = new string[] { "MacroName" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public MacroName () { }

		// Copy constructor

		public MacroName (MacroName p_MacroName) : base (p_MacroName.id, p_MacroName.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MacroName.appInfo;
			switch ((production_kind) p_MacroName.kind)
			{
				case production_kind.g_MacroName_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MODULE_IDENTITY = (p_MacroName.m_MODULE_IDENTITY != null) ? new SyntaxTreeToken (p_MacroName.m_MODULE_IDENTITY) : null) != null) m_MODULE_IDENTITY.parent = this;
					break;
				case production_kind.g_MacroName_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OBJECT_IDENTITY = (p_MacroName.m_OBJECT_IDENTITY != null) ? new SyntaxTreeToken (p_MacroName.m_OBJECT_IDENTITY) : null) != null) m_OBJECT_IDENTITY.parent = this;
					break;
				case production_kind.g_MacroName_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OBJECT_TYPE = (p_MacroName.m_OBJECT_TYPE != null) ? new SyntaxTreeToken (p_MacroName.m_OBJECT_TYPE) : null) != null) m_OBJECT_TYPE.parent = this;
					break;
				case production_kind.g_MacroName_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NOTIFICATION_TYPE = (p_MacroName.m_NOTIFICATION_TYPE != null) ? new SyntaxTreeToken (p_MacroName.m_NOTIFICATION_TYPE) : null) != null) m_NOTIFICATION_TYPE.parent = this;
					break;
				case production_kind.g_MacroName_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TEXTUAL_CONVENTION = (p_MacroName.m_TEXTUAL_CONVENTION != null) ? new SyntaxTreeToken (p_MacroName.m_TEXTUAL_CONVENTION) : null) != null) m_TEXTUAL_CONVENTION.parent = this;
					break;
				case production_kind.g_MacroName_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OBJECT_GROUP = (p_MacroName.m_OBJECT_GROUP != null) ? new SyntaxTreeToken (p_MacroName.m_OBJECT_GROUP) : null) != null) m_OBJECT_GROUP.parent = this;
					break;
				case production_kind.g_MacroName_7:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NOTIFICATION_GROUP = (p_MacroName.m_NOTIFICATION_GROUP != null) ? new SyntaxTreeToken (p_MacroName.m_NOTIFICATION_GROUP) : null) != null) m_NOTIFICATION_GROUP.parent = this;
					break;
				case production_kind.g_MacroName_8:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MODULE_COMPLIANCE = (p_MacroName.m_MODULE_COMPLIANCE != null) ? new SyntaxTreeToken (p_MacroName.m_MODULE_COMPLIANCE) : null) != null) m_MODULE_COMPLIANCE.parent = this;
					break;
				case production_kind.g_MacroName_9:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AGENT_CAPABILITIES = (p_MacroName.m_AGENT_CAPABILITIES != null) ? new SyntaxTreeToken (p_MacroName.m_AGENT_CAPABILITIES) : null) != null) m_AGENT_CAPABILITIES.parent = this;
					break;
				case production_kind.g_MacroName_10:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TRAP_TYPE = (p_MacroName.m_TRAP_TYPE != null) ? new SyntaxTreeToken (p_MacroName.m_TRAP_TYPE) : null) != null) m_TRAP_TYPE.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MacroName" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MacroName (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_MODULE_IDENTITY?.Dispose ();
			m_OBJECT_IDENTITY?.Dispose ();
			m_OBJECT_TYPE?.Dispose ();
			m_NOTIFICATION_TYPE?.Dispose ();
			m_TEXTUAL_CONVENTION?.Dispose ();
			m_OBJECT_GROUP?.Dispose ();
			m_NOTIFICATION_GROUP?.Dispose ();
			m_MODULE_COMPLIANCE?.Dispose ();
			m_AGENT_CAPABILITIES?.Dispose ();
			m_TRAP_TYPE?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MacroName

		// Content changing function(s) associated with production(s) of syntax rule MacroName

		//
		// Content changing function associated with following production(s)
		// MacroName -> MODULE-IDENTITY

		// MacroName -> OBJECT-IDENTITY

		// MacroName -> OBJECT-TYPE

		// MacroName -> NOTIFICATION-TYPE

		// MacroName -> TEXTUAL-CONVENTION

		// MacroName -> OBJECT-GROUP

		// MacroName -> NOTIFICATION-GROUP

		// MacroName -> MODULE-COMPLIANCE

		// MacroName -> AGENT-CAPABILITIES

		// MacroName -> TRAP-TYPE

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_MacroName_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MODULE_IDENTITY = p_token;
				break;
			case production_kind.g_MacroName_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_OBJECT_IDENTITY = p_token;
				break;
			case production_kind.g_MacroName_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_OBJECT_TYPE = p_token;
				break;
			case production_kind.g_MacroName_4:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_NOTIFICATION_TYPE = p_token;
				break;
			case production_kind.g_MacroName_5:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TEXTUAL_CONVENTION = p_token;
				break;
			case production_kind.g_MacroName_6:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_OBJECT_GROUP = p_token;
				break;
			case production_kind.g_MacroName_7:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_NOTIFICATION_GROUP = p_token;
				break;
			case production_kind.g_MacroName_8:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MODULE_COMPLIANCE = p_token;
				break;
			case production_kind.g_MacroName_9:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_AGENT_CAPABILITIES = p_token;
				break;
			case production_kind.g_MacroName_10:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TRAP_TYPE = p_token;
				break;
			default:
				{
					string[] args = new string[] { "MacroName" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MacroName
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_MODULE_IDENTITY != null) && m_MODULE_IDENTITY.checkInclusion (element) ||
				(m_OBJECT_IDENTITY != null) && m_OBJECT_IDENTITY.checkInclusion (element) ||
				(m_OBJECT_TYPE != null) && m_OBJECT_TYPE.checkInclusion (element) ||
				(m_NOTIFICATION_TYPE != null) && m_NOTIFICATION_TYPE.checkInclusion (element) ||
				(m_TEXTUAL_CONVENTION != null) && m_TEXTUAL_CONVENTION.checkInclusion (element) ||
				(m_OBJECT_GROUP != null) && m_OBJECT_GROUP.checkInclusion (element) ||
				(m_NOTIFICATION_GROUP != null) && m_NOTIFICATION_GROUP.checkInclusion (element) ||
				(m_MODULE_COMPLIANCE != null) && m_MODULE_COMPLIANCE.checkInclusion (element) ||
				(m_AGENT_CAPABILITIES != null) && m_AGENT_CAPABILITIES.checkInclusion (element) ||
				(m_TRAP_TYPE != null) && m_TRAP_TYPE.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MacroName

		//
		// emit production tree node associated with any production of syntax rule MacroName
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MacroName_1:
					// emit syntax tree node associated with production
					// MacroName: MODULE-IDENTITY

					s += m_MODULE_IDENTITY.Emit (depth - 1);
				break;
				case production_kind.g_MacroName_2:
					// emit syntax tree node associated with production
					// MacroName: OBJECT-IDENTITY

					s += m_OBJECT_IDENTITY.Emit (depth - 1);
				break;
				case production_kind.g_MacroName_3:
					// emit syntax tree node associated with production
					// MacroName: OBJECT-TYPE

					s += m_OBJECT_TYPE.Emit (depth - 1);
				break;
				case production_kind.g_MacroName_4:
					// emit syntax tree node associated with production
					// MacroName: NOTIFICATION-TYPE

					s += m_NOTIFICATION_TYPE.Emit (depth - 1);
				break;
				case production_kind.g_MacroName_5:
					// emit syntax tree node associated with production
					// MacroName: TEXTUAL-CONVENTION

					s += m_TEXTUAL_CONVENTION.Emit (depth - 1);
				break;
				case production_kind.g_MacroName_6:
					// emit syntax tree node associated with production
					// MacroName: OBJECT-GROUP

					s += m_OBJECT_GROUP.Emit (depth - 1);
				break;
				case production_kind.g_MacroName_7:
					// emit syntax tree node associated with production
					// MacroName: NOTIFICATION-GROUP

					s += m_NOTIFICATION_GROUP.Emit (depth - 1);
				break;
				case production_kind.g_MacroName_8:
					// emit syntax tree node associated with production
					// MacroName: MODULE-COMPLIANCE

					s += m_MODULE_COMPLIANCE.Emit (depth - 1);
				break;
				case production_kind.g_MacroName_9:
					// emit syntax tree node associated with production
					// MacroName: AGENT-CAPABILITIES

					s += m_AGENT_CAPABILITIES.Emit (depth - 1);
				break;
				case production_kind.g_MacroName_10:
					// emit syntax tree node associated with production
					// MacroName: TRAP-TYPE

					s += m_TRAP_TYPE.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MacroName
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MacroName (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MacroName_1:
					// emit syntax tree node associated with production
					// MacroName: MODULE-IDENTITY

					s += "MODULE_IDENTITY";
				break;
				case production_kind.g_MacroName_2:
					// emit syntax tree node associated with production
					// MacroName: OBJECT-IDENTITY

					s += "OBJECT_IDENTITY";
				break;
				case production_kind.g_MacroName_3:
					// emit syntax tree node associated with production
					// MacroName: OBJECT-TYPE

					s += "OBJECT_TYPE";
				break;
				case production_kind.g_MacroName_4:
					// emit syntax tree node associated with production
					// MacroName: NOTIFICATION-TYPE

					s += "NOTIFICATION_TYPE";
				break;
				case production_kind.g_MacroName_5:
					// emit syntax tree node associated with production
					// MacroName: TEXTUAL-CONVENTION

					s += "TEXTUAL_CONVENTION";
				break;
				case production_kind.g_MacroName_6:
					// emit syntax tree node associated with production
					// MacroName: OBJECT-GROUP

					s += "OBJECT_GROUP";
				break;
				case production_kind.g_MacroName_7:
					// emit syntax tree node associated with production
					// MacroName: NOTIFICATION-GROUP

					s += "NOTIFICATION_GROUP";
				break;
				case production_kind.g_MacroName_8:
					// emit syntax tree node associated with production
					// MacroName: MODULE-COMPLIANCE

					s += "MODULE_COMPLIANCE";
				break;
				case production_kind.g_MacroName_9:
					// emit syntax tree node associated with production
					// MacroName: AGENT-CAPABILITIES

					s += "AGENT_CAPABILITIES";
				break;
				case production_kind.g_MacroName_10:
					// emit syntax tree node associated with production
					// MacroName: TRAP-TYPE

					s += "TRAP_TYPE";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MacroName

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MacroName with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MacroName.production_kind kind = (MacroName.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MacroName.production_kind.g_MacroName_1:
					// traverse syntax tree node associated with production
					// MacroName: MODULE-IDENTITY

						m_MODULE_IDENTITY.Visit (visitor, appData);
				break;
				case MacroName.production_kind.g_MacroName_2:
					// traverse syntax tree node associated with production
					// MacroName: OBJECT-IDENTITY

						m_OBJECT_IDENTITY.Visit (visitor, appData);
				break;
				case MacroName.production_kind.g_MacroName_3:
					// traverse syntax tree node associated with production
					// MacroName: OBJECT-TYPE

						m_OBJECT_TYPE.Visit (visitor, appData);
				break;
				case MacroName.production_kind.g_MacroName_4:
					// traverse syntax tree node associated with production
					// MacroName: NOTIFICATION-TYPE

						m_NOTIFICATION_TYPE.Visit (visitor, appData);
				break;
				case MacroName.production_kind.g_MacroName_5:
					// traverse syntax tree node associated with production
					// MacroName: TEXTUAL-CONVENTION

						m_TEXTUAL_CONVENTION.Visit (visitor, appData);
				break;
				case MacroName.production_kind.g_MacroName_6:
					// traverse syntax tree node associated with production
					// MacroName: OBJECT-GROUP

						m_OBJECT_GROUP.Visit (visitor, appData);
				break;
				case MacroName.production_kind.g_MacroName_7:
					// traverse syntax tree node associated with production
					// MacroName: NOTIFICATION-GROUP

						m_NOTIFICATION_GROUP.Visit (visitor, appData);
				break;
				case MacroName.production_kind.g_MacroName_8:
					// traverse syntax tree node associated with production
					// MacroName: MODULE-COMPLIANCE

						m_MODULE_COMPLIANCE.Visit (visitor, appData);
				break;
				case MacroName.production_kind.g_MacroName_9:
					// traverse syntax tree node associated with production
					// MacroName: AGENT-CAPABILITIES

						m_AGENT_CAPABILITIES.Visit (visitor, appData);
				break;
				case MacroName.production_kind.g_MacroName_10:
					// traverse syntax tree node associated with production
					// MacroName: TRAP-TYPE

						m_TRAP_TYPE.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_MODULE_IDENTITY?.reparent (this);
			m_OBJECT_IDENTITY?.reparent (this);
			m_OBJECT_TYPE?.reparent (this);
			m_NOTIFICATION_TYPE?.reparent (this);
			m_TEXTUAL_CONVENTION?.reparent (this);
			m_OBJECT_GROUP?.reparent (this);
			m_NOTIFICATION_GROUP?.reparent (this);
			m_MODULE_COMPLIANCE?.reparent (this);
			m_AGENT_CAPABILITIES?.reparent (this);
			m_TRAP_TYPE?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MacroName
		//

		public void _init ()
		{
			m_MODULE_IDENTITY = null;
			m_OBJECT_IDENTITY = null;
			m_OBJECT_TYPE = null;
			m_NOTIFICATION_TYPE = null;
			m_TEXTUAL_CONVENTION = null;
			m_OBJECT_GROUP = null;
			m_NOTIFICATION_GROUP = null;
			m_MODULE_COMPLIANCE = null;
			m_AGENT_CAPABILITIES = null;
			m_TRAP_TYPE = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MacroName

		// counter of all nodes associated with syntax rule MacroName
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MacroName
		[DataMember (Name = "m_MODULE_IDENTITY")] public SyntaxTreeToken m_MODULE_IDENTITY { get; private set; }
		[DataMember (Name = "m_OBJECT_IDENTITY")] public SyntaxTreeToken m_OBJECT_IDENTITY { get; private set; }
		[DataMember (Name = "m_OBJECT_TYPE")] public SyntaxTreeToken m_OBJECT_TYPE { get; private set; }
		[DataMember (Name = "m_NOTIFICATION_TYPE")] public SyntaxTreeToken m_NOTIFICATION_TYPE { get; private set; }
		[DataMember (Name = "m_TEXTUAL_CONVENTION")] public SyntaxTreeToken m_TEXTUAL_CONVENTION { get; private set; }
		[DataMember (Name = "m_OBJECT_GROUP")] public SyntaxTreeToken m_OBJECT_GROUP { get; private set; }
		[DataMember (Name = "m_NOTIFICATION_GROUP")] public SyntaxTreeToken m_NOTIFICATION_GROUP { get; private set; }
		[DataMember (Name = "m_MODULE_COMPLIANCE")] public SyntaxTreeToken m_MODULE_COMPLIANCE { get; private set; }
		[DataMember (Name = "m_AGENT_CAPABILITIES")] public SyntaxTreeToken m_AGENT_CAPABILITIES { get; private set; }
		[DataMember (Name = "m_TRAP_TYPE")] public SyntaxTreeToken m_TRAP_TYPE { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MacroName

		// delegate function (callback) prototype associated with syntax rule MacroName
		public delegate bool MacroName_Callback (SyntaxTreeCallbackReason reason, MacroName.production_kind kind, MacroName p_MacroName);

		// event associated with syntax rule MacroName
		public event MacroName_Callback MacroName_Event;

		// event trigger associated with syntax rule MacroName
		public bool Raise_MacroName_Event (SyntaxTreeCallbackReason reason, MacroName.production_kind kind, MacroName p_MacroName)
		{
			bool? status = MacroName_Event?.Invoke (reason, kind, p_MacroName);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MacroName
		//
		// traverse syntax tree node associated with any production of syntax rule MacroName
		//

		public void Traverse (MacroName p_MacroName)
		{
			if (p_MacroName.isLocked())
				return;
			p_MacroName.dolock();
			MacroName.production_kind kind = (MacroName.production_kind) p_MacroName.kind;
			p_MacroName.turn_reset ();
			if (Raise_MacroName_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MacroName))
			switch (kind)
			{
				case MacroName.production_kind.g_MacroName_1:
					// traverse syntax tree node associated with production
					// MacroName: MODULE-IDENTITY

				break;
				case MacroName.production_kind.g_MacroName_2:
					// traverse syntax tree node associated with production
					// MacroName: OBJECT-IDENTITY

				break;
				case MacroName.production_kind.g_MacroName_3:
					// traverse syntax tree node associated with production
					// MacroName: OBJECT-TYPE

				break;
				case MacroName.production_kind.g_MacroName_4:
					// traverse syntax tree node associated with production
					// MacroName: NOTIFICATION-TYPE

				break;
				case MacroName.production_kind.g_MacroName_5:
					// traverse syntax tree node associated with production
					// MacroName: TEXTUAL-CONVENTION

				break;
				case MacroName.production_kind.g_MacroName_6:
					// traverse syntax tree node associated with production
					// MacroName: OBJECT-GROUP

				break;
				case MacroName.production_kind.g_MacroName_7:
					// traverse syntax tree node associated with production
					// MacroName: NOTIFICATION-GROUP

				break;
				case MacroName.production_kind.g_MacroName_8:
					// traverse syntax tree node associated with production
					// MacroName: MODULE-COMPLIANCE

				break;
				case MacroName.production_kind.g_MacroName_9:
					// traverse syntax tree node associated with production
					// MacroName: AGENT-CAPABILITIES

				break;
				case MacroName.production_kind.g_MacroName_10:
					// traverse syntax tree node associated with production
					// MacroName: TRAP-TYPE

				break;
			}
			Raise_MacroName_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MacroName);
			p_MacroName.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MacroName
		//

		public void TraverseCommon (MacroName p_MacroName)
		{
			MacroName.production_kind kind = (MacroName.production_kind) p_MacroName.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MacroName))
			switch (kind)
			{
				case MacroName.production_kind.g_MacroName_1:
					// traverse syntax tree node associated with production
					// MacroName: MODULE-IDENTITY

						TraverseCommon (p_MacroName.m_MODULE_IDENTITY);
				break;
				case MacroName.production_kind.g_MacroName_2:
					// traverse syntax tree node associated with production
					// MacroName: OBJECT-IDENTITY

						TraverseCommon (p_MacroName.m_OBJECT_IDENTITY);
				break;
				case MacroName.production_kind.g_MacroName_3:
					// traverse syntax tree node associated with production
					// MacroName: OBJECT-TYPE

						TraverseCommon (p_MacroName.m_OBJECT_TYPE);
				break;
				case MacroName.production_kind.g_MacroName_4:
					// traverse syntax tree node associated with production
					// MacroName: NOTIFICATION-TYPE

						TraverseCommon (p_MacroName.m_NOTIFICATION_TYPE);
				break;
				case MacroName.production_kind.g_MacroName_5:
					// traverse syntax tree node associated with production
					// MacroName: TEXTUAL-CONVENTION

						TraverseCommon (p_MacroName.m_TEXTUAL_CONVENTION);
				break;
				case MacroName.production_kind.g_MacroName_6:
					// traverse syntax tree node associated with production
					// MacroName: OBJECT-GROUP

						TraverseCommon (p_MacroName.m_OBJECT_GROUP);
				break;
				case MacroName.production_kind.g_MacroName_7:
					// traverse syntax tree node associated with production
					// MacroName: NOTIFICATION-GROUP

						TraverseCommon (p_MacroName.m_NOTIFICATION_GROUP);
				break;
				case MacroName.production_kind.g_MacroName_8:
					// traverse syntax tree node associated with production
					// MacroName: MODULE-COMPLIANCE

						TraverseCommon (p_MacroName.m_MODULE_COMPLIANCE);
				break;
				case MacroName.production_kind.g_MacroName_9:
					// traverse syntax tree node associated with production
					// MacroName: AGENT-CAPABILITIES

						TraverseCommon (p_MacroName.m_AGENT_CAPABILITIES);
				break;
				case MacroName.production_kind.g_MacroName_10:
					// traverse syntax tree node associated with production
					// MacroName: TRAP-TYPE

						TraverseCommon (p_MacroName.m_TRAP_TYPE);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MacroName);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MacroName

		//
		// create syntax tree node associated with production
		// MacroName: MODULE-IDENTITY

		//

		public MacroName MacroName_1 (SyntaxTreeToken p_token)
		{
			MacroName p_MacroName_ref = new MacroName(p_token, 1);
			p_token.parent = p_MacroName_ref;
			Raise_MacroName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroName.production_kind.g_MacroName_1, p_MacroName_ref);
			return p_MacroName_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroName: OBJECT-IDENTITY

		//

		public MacroName MacroName_2 (SyntaxTreeToken p_token)
		{
			MacroName p_MacroName_ref = new MacroName(p_token, 2);
			p_token.parent = p_MacroName_ref;
			Raise_MacroName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroName.production_kind.g_MacroName_2, p_MacroName_ref);
			return p_MacroName_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroName: OBJECT-TYPE

		//

		public MacroName MacroName_3 (SyntaxTreeToken p_token)
		{
			MacroName p_MacroName_ref = new MacroName(p_token, 3);
			p_token.parent = p_MacroName_ref;
			Raise_MacroName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroName.production_kind.g_MacroName_3, p_MacroName_ref);
			return p_MacroName_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroName: NOTIFICATION-TYPE

		//

		public MacroName MacroName_4 (SyntaxTreeToken p_token)
		{
			MacroName p_MacroName_ref = new MacroName(p_token, 4);
			p_token.parent = p_MacroName_ref;
			Raise_MacroName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroName.production_kind.g_MacroName_4, p_MacroName_ref);
			return p_MacroName_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroName: TEXTUAL-CONVENTION

		//

		public MacroName MacroName_5 (SyntaxTreeToken p_token)
		{
			MacroName p_MacroName_ref = new MacroName(p_token, 5);
			p_token.parent = p_MacroName_ref;
			Raise_MacroName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroName.production_kind.g_MacroName_5, p_MacroName_ref);
			return p_MacroName_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroName: OBJECT-GROUP

		//

		public MacroName MacroName_6 (SyntaxTreeToken p_token)
		{
			MacroName p_MacroName_ref = new MacroName(p_token, 6);
			p_token.parent = p_MacroName_ref;
			Raise_MacroName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroName.production_kind.g_MacroName_6, p_MacroName_ref);
			return p_MacroName_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroName: NOTIFICATION-GROUP

		//

		public MacroName MacroName_7 (SyntaxTreeToken p_token)
		{
			MacroName p_MacroName_ref = new MacroName(p_token, 7);
			p_token.parent = p_MacroName_ref;
			Raise_MacroName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroName.production_kind.g_MacroName_7, p_MacroName_ref);
			return p_MacroName_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroName: MODULE-COMPLIANCE

		//

		public MacroName MacroName_8 (SyntaxTreeToken p_token)
		{
			MacroName p_MacroName_ref = new MacroName(p_token, 8);
			p_token.parent = p_MacroName_ref;
			Raise_MacroName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroName.production_kind.g_MacroName_8, p_MacroName_ref);
			return p_MacroName_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroName: AGENT-CAPABILITIES

		//

		public MacroName MacroName_9 (SyntaxTreeToken p_token)
		{
			MacroName p_MacroName_ref = new MacroName(p_token, 9);
			p_token.parent = p_MacroName_ref;
			Raise_MacroName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroName.production_kind.g_MacroName_9, p_MacroName_ref);
			return p_MacroName_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroName: TRAP-TYPE

		//

		public MacroName MacroName_10 (SyntaxTreeToken p_token)
		{
			MacroName p_MacroName_ref = new MacroName(p_token, 10);
			p_token.parent = p_MacroName_ref;
			Raise_MacroName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroName.production_kind.g_MacroName_10, p_MacroName_ref);
			return p_MacroName_ref;
		}
		#endregion
	};
}
