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
	// class associated with syntax rule AgentCapabilitiesMacro
	//

	[DataContract]
	public class	AgentCapabilitiesMacro : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AgentCapabilitiesMacro
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AgentCapabilitiesMacro
		{
			g_AgentCapabilitiesMacro_1 = 1,	// AGENT-CAPABILITIES PRODUCT-RELEASE cstring STATUS AC-Status DESCRIPTION cstring AC-ReferPart AC-ModulePart

		};
		#endregion
		#region production markers associated with the syntax rule AgentCapabilitiesMacro

		// markers associated with production: AgentCapabilitiesMacro -> AGENT-CAPABILITIES PRODUCT-RELEASE cstring STATUS AC-Status DESCRIPTION cstring AC-ReferPart AC-ModulePart

		public enum production_marker_1 : ushort
		{
			m_AC_Status,
			m_AC_ReferPart,
			m_AC_ModulePart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AgentCapabilitiesMacro

		// Constructor declaration(s) associated with production(s) of syntax rule AgentCapabilitiesMacro

		//
		// Constructor associated with the following production(s)
		// AgentCapabilitiesMacro -> AGENT-CAPABILITIES PRODUCT-RELEASE cstring STATUS AC-Status DESCRIPTION cstring AC-ReferPart AC-ModulePart

		//

		public AgentCapabilitiesMacro (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, AC_Status p_AC_Status, SyntaxTreeToken p_token_4, SyntaxTreeToken p_token_5, AC_ReferPart p_AC_ReferPart, AC_ModulePart p_AC_ModulePart) : base ((uint) ProductionID._AgentCapabilitiesMacro_ID, (uint) production_kind.g_AgentCapabilitiesMacro_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 9);
			children[0] = m_AGENT_CAPABILITIES = p_token;
			children[1] = m_PRODUCT_RELEASE = p_token_1;
			children[2] = m_cstring = p_token_2;
			children[3] = m_STATUS = p_token_3;
			children[4] = m_AC_Status = p_AC_Status;
			children[5] = m_DESCRIPTION = p_token_4;
			children[6] = m_cstring_1 = p_token_5;
			children[7] = m_AC_ReferPart = p_AC_ReferPart;
			children[8] = m_AC_ModulePart = p_AC_ModulePart;
		}

		public AgentCapabilitiesMacro () { }

		// Copy constructor

		public AgentCapabilitiesMacro (AgentCapabilitiesMacro p_AgentCapabilitiesMacro) : base (p_AgentCapabilitiesMacro.id, p_AgentCapabilitiesMacro.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AgentCapabilitiesMacro.appInfo;
			switch ((production_kind) p_AgentCapabilitiesMacro.kind)
			{
				case production_kind.g_AgentCapabilitiesMacro_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 9);
					if ((children [0] = m_AGENT_CAPABILITIES = (p_AgentCapabilitiesMacro.m_AGENT_CAPABILITIES != null) ? new SyntaxTreeToken (p_AgentCapabilitiesMacro.m_AGENT_CAPABILITIES) : null) != null) m_AGENT_CAPABILITIES.parent = this;
					if ((children [1] = m_PRODUCT_RELEASE = (p_AgentCapabilitiesMacro.m_PRODUCT_RELEASE != null) ? new SyntaxTreeToken (p_AgentCapabilitiesMacro.m_PRODUCT_RELEASE) : null) != null) m_PRODUCT_RELEASE.parent = this;
					if ((children [2] = m_cstring = (p_AgentCapabilitiesMacro.m_cstring != null) ? new SyntaxTreeToken (p_AgentCapabilitiesMacro.m_cstring) : null) != null) m_cstring.parent = this;
					if ((children [3] = m_STATUS = (p_AgentCapabilitiesMacro.m_STATUS != null) ? new SyntaxTreeToken (p_AgentCapabilitiesMacro.m_STATUS) : null) != null) m_STATUS.parent = this;
					if ((children [4] = m_AC_Status = (p_AgentCapabilitiesMacro.m_AC_Status != null) ? new AC_Status (p_AgentCapabilitiesMacro.m_AC_Status) : null) != null) m_AC_Status.parent = this;
					if ((children [5] = m_DESCRIPTION = (p_AgentCapabilitiesMacro.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_AgentCapabilitiesMacro.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [6] = m_cstring_1 = (p_AgentCapabilitiesMacro.m_cstring_1 != null) ? new SyntaxTreeToken (p_AgentCapabilitiesMacro.m_cstring_1) : null) != null) m_cstring_1.parent = this;
					if ((children [7] = m_AC_ReferPart = (p_AgentCapabilitiesMacro.m_AC_ReferPart != null) ? new AC_ReferPart (p_AgentCapabilitiesMacro.m_AC_ReferPart) : null) != null) m_AC_ReferPart.parent = this;
					if ((children [8] = m_AC_ModulePart = (p_AgentCapabilitiesMacro.m_AC_ModulePart != null) ? new AC_ModulePart (p_AgentCapabilitiesMacro.m_AC_ModulePart) : null) != null) m_AC_ModulePart.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AgentCapabilitiesMacro" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AgentCapabilitiesMacro (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_AGENT_CAPABILITIES?.Dispose ();
			m_PRODUCT_RELEASE?.Dispose ();
			m_cstring?.Dispose ();
			m_cstring_1?.Dispose ();
			m_STATUS?.Dispose ();
			m_AC_Status?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_AC_ReferPart?.Dispose ();
			m_AC_ModulePart?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AgentCapabilitiesMacro

		// Content changing function(s) associated with production(s) of syntax rule AgentCapabilitiesMacro

		//
		// Content changing function associated with following production(s)
		// AgentCapabilitiesMacro -> AGENT-CAPABILITIES PRODUCT-RELEASE cstring STATUS AC-Status DESCRIPTION cstring AC-ReferPart AC-ModulePart

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, AC_Status p_AC_Status, SyntaxTreeToken p_token_4, SyntaxTreeToken p_token_5, AC_ReferPart p_AC_ReferPart, AC_ModulePart p_AC_ModulePart)
		{
			_init ();
			this.kind = (uint) production_kind.g_AgentCapabilitiesMacro_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 9);
			children [0] = m_AGENT_CAPABILITIES = p_token;
			children [1] = m_PRODUCT_RELEASE = p_token_1;
			children [2] = m_cstring = p_token_2;
			children [3] = m_STATUS = p_token_3;
			children [4] = m_AC_Status = p_AC_Status;
			children [5] = m_DESCRIPTION = p_token_4;
			children [6] = m_cstring_1 = p_token_5;
			children [7] = m_AC_ReferPart = p_AC_ReferPart;
			children [8] = m_AC_ModulePart = p_AC_ModulePart;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AgentCapabilitiesMacro
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_AGENT_CAPABILITIES != null) && m_AGENT_CAPABILITIES.checkInclusion (element) ||
				(m_PRODUCT_RELEASE != null) && m_PRODUCT_RELEASE.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				(m_cstring_1 != null) && m_cstring_1.checkInclusion (element) ||
				(m_STATUS != null) && m_STATUS.checkInclusion (element) ||
				(m_AC_Status != null) && m_AC_Status.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_AC_ReferPart != null) && m_AC_ReferPart.checkInclusion (element) ||
				(m_AC_ModulePart != null) && m_AC_ModulePart.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AgentCapabilitiesMacro

		//
		// emit production tree node associated with any production of syntax rule AgentCapabilitiesMacro
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AgentCapabilitiesMacro_1:
					// emit syntax tree node associated with production
					// AgentCapabilitiesMacro: AGENT-CAPABILITIES PRODUCT-RELEASE cstring STATUS AC-Status DESCRIPTION cstring AC-ReferPart AC-ModulePart

					s += m_AGENT_CAPABILITIES.Emit (depth - 1);
					s += " ";
					s += m_PRODUCT_RELEASE.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
					s += " ";
					s += m_STATUS.Emit (depth - 1);
					s += " ";
					s += m_AC_Status.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring_1.Emit (depth - 1);
					s += " ";
					s += m_AC_ReferPart.Emit (depth - 1);
					s += " ";
					s += m_AC_ModulePart.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AgentCapabilitiesMacro
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AgentCapabilitiesMacro (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AgentCapabilitiesMacro_1:
					// emit syntax tree node associated with production
					// AgentCapabilitiesMacro: AGENT-CAPABILITIES PRODUCT-RELEASE cstring STATUS AC-Status DESCRIPTION cstring AC-ReferPart AC-ModulePart

					s += "AGENT_CAPABILITIES";
					s += ' ';
					s += "PRODUCT_RELEASE";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += "STATUS";
					s += ' ';
					s += m_AC_Status.EmitProductionTree (depth - 1);
					s += ' ';
					s += "DESCRIPTION";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += m_AC_ReferPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_AC_ModulePart.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AgentCapabilitiesMacro

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AgentCapabilitiesMacro with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AgentCapabilitiesMacro.production_kind kind = (AgentCapabilitiesMacro.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AgentCapabilitiesMacro.production_kind.g_AgentCapabilitiesMacro_1:
					// traverse syntax tree node associated with production
					// AgentCapabilitiesMacro: AGENT-CAPABILITIES PRODUCT-RELEASE cstring STATUS AC-Status DESCRIPTION cstring AC-ReferPart AC-ModulePart

						m_AGENT_CAPABILITIES.Visit (visitor, appData);
						m_PRODUCT_RELEASE.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
						m_STATUS.Visit (visitor, appData);
						m_AC_Status.Visit (visitor, appData);
						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring_1.Visit (visitor, appData);
						m_AC_ReferPart.Visit (visitor, appData);
						m_AC_ModulePart.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_AGENT_CAPABILITIES?.reparent (this);
			m_PRODUCT_RELEASE?.reparent (this);
			m_cstring?.reparent (this);
			m_cstring_1?.reparent (this);

			m_STATUS?.reparent (this);
			m_AC_Status?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_AC_ReferPart?.reparent (this);
			m_AC_ModulePart?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AgentCapabilitiesMacro
		//

		public void _init ()
		{
			m_AGENT_CAPABILITIES = null;
			m_PRODUCT_RELEASE = null;
			m_cstring = null;
			m_cstring_1 = null;
			m_STATUS = null;
			m_AC_Status = null;
			m_DESCRIPTION = null;
			m_AC_ReferPart = null;
			m_AC_ModulePart = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AgentCapabilitiesMacro

		// counter of all nodes associated with syntax rule AgentCapabilitiesMacro
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AgentCapabilitiesMacro
		[DataMember (Name = "m_AGENT_CAPABILITIES")] public SyntaxTreeToken m_AGENT_CAPABILITIES { get; private set; }
		[DataMember (Name = "m_PRODUCT_RELEASE")] public SyntaxTreeToken m_PRODUCT_RELEASE { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		[DataMember (Name = "m_cstring_1")] public SyntaxTreeToken m_cstring_1 { get; private set; }
		[DataMember (Name = "m_STATUS")] public SyntaxTreeToken m_STATUS { get; private set; }
		[DataMember (Name = "m_AC_Status")] public AC_Status m_AC_Status { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_AC_ReferPart")] public AC_ReferPart m_AC_ReferPart { get; private set; }
		[DataMember (Name = "m_AC_ModulePart")] public AC_ModulePart m_AC_ModulePart { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AgentCapabilitiesMacro

		// delegate function (callback) prototype associated with syntax rule AgentCapabilitiesMacro
		public delegate bool AgentCapabilitiesMacro_Callback (SyntaxTreeCallbackReason reason, AgentCapabilitiesMacro.production_kind kind, AgentCapabilitiesMacro p_AgentCapabilitiesMacro);

		// event associated with syntax rule AgentCapabilitiesMacro
		public event AgentCapabilitiesMacro_Callback AgentCapabilitiesMacro_Event;

		// event trigger associated with syntax rule AgentCapabilitiesMacro
		public bool Raise_AgentCapabilitiesMacro_Event (SyntaxTreeCallbackReason reason, AgentCapabilitiesMacro.production_kind kind, AgentCapabilitiesMacro p_AgentCapabilitiesMacro)
		{
			bool? status = AgentCapabilitiesMacro_Event?.Invoke (reason, kind, p_AgentCapabilitiesMacro);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AgentCapabilitiesMacro
		//
		// traverse syntax tree node associated with any production of syntax rule AgentCapabilitiesMacro
		//

		public void Traverse (AgentCapabilitiesMacro p_AgentCapabilitiesMacro)
		{
			if (p_AgentCapabilitiesMacro.isLocked())
				return;
			p_AgentCapabilitiesMacro.dolock();
			AgentCapabilitiesMacro.production_kind kind = (AgentCapabilitiesMacro.production_kind) p_AgentCapabilitiesMacro.kind;
			p_AgentCapabilitiesMacro.turn_reset ();
			if (Raise_AgentCapabilitiesMacro_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AgentCapabilitiesMacro))
			switch (kind)
			{
				case AgentCapabilitiesMacro.production_kind.g_AgentCapabilitiesMacro_1:
					// traverse syntax tree node associated with production
					// AgentCapabilitiesMacro: AGENT-CAPABILITIES PRODUCT-RELEASE cstring STATUS AC-Status DESCRIPTION cstring AC-ReferPart AC-ModulePart

					if (Raise_AgentCapabilitiesMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AgentCapabilitiesMacro))
						Traverse (p_AgentCapabilitiesMacro.m_AC_Status);
					p_AgentCapabilitiesMacro.turn_inc ();
					if (Raise_AgentCapabilitiesMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AgentCapabilitiesMacro))
						Traverse (p_AgentCapabilitiesMacro.m_AC_ReferPart);
					p_AgentCapabilitiesMacro.turn_inc ();
					if (Raise_AgentCapabilitiesMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AgentCapabilitiesMacro))
						Traverse (p_AgentCapabilitiesMacro.m_AC_ModulePart);
					p_AgentCapabilitiesMacro.turn_inc ();
					Raise_AgentCapabilitiesMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AgentCapabilitiesMacro);
				break;
			}
			Raise_AgentCapabilitiesMacro_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AgentCapabilitiesMacro);
			p_AgentCapabilitiesMacro.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AgentCapabilitiesMacro
		//

		public void TraverseCommon (AgentCapabilitiesMacro p_AgentCapabilitiesMacro)
		{
			AgentCapabilitiesMacro.production_kind kind = (AgentCapabilitiesMacro.production_kind) p_AgentCapabilitiesMacro.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AgentCapabilitiesMacro))
			switch (kind)
			{
				case AgentCapabilitiesMacro.production_kind.g_AgentCapabilitiesMacro_1:
					// traverse syntax tree node associated with production
					// AgentCapabilitiesMacro: AGENT-CAPABILITIES PRODUCT-RELEASE cstring STATUS AC-Status DESCRIPTION cstring AC-ReferPart AC-ModulePart

						TraverseCommon (p_AgentCapabilitiesMacro.m_AGENT_CAPABILITIES);
						TraverseCommon (p_AgentCapabilitiesMacro.m_PRODUCT_RELEASE);
						TraverseCommon (p_AgentCapabilitiesMacro.m_cstring);
						TraverseCommon (p_AgentCapabilitiesMacro.m_STATUS);
						TraverseCommon (p_AgentCapabilitiesMacro.m_AC_Status);
						TraverseCommon (p_AgentCapabilitiesMacro.m_DESCRIPTION);
						TraverseCommon (p_AgentCapabilitiesMacro.m_cstring_1);
						TraverseCommon (p_AgentCapabilitiesMacro.m_AC_ReferPart);
						TraverseCommon (p_AgentCapabilitiesMacro.m_AC_ModulePart);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AgentCapabilitiesMacro);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AgentCapabilitiesMacro

		//
		// create syntax tree node associated with production
		// AgentCapabilitiesMacro: AGENT-CAPABILITIES PRODUCT-RELEASE cstring STATUS AC-Status DESCRIPTION cstring AC-ReferPart AC-ModulePart

		//

		public AgentCapabilitiesMacro AgentCapabilitiesMacro_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, AC_Status p_AC_Status, SyntaxTreeToken p_token_4, SyntaxTreeToken p_token_5, AC_ReferPart p_AC_ReferPart, AC_ModulePart p_AC_ModulePart)
		{
			AgentCapabilitiesMacro p_AgentCapabilitiesMacro_ref = new AgentCapabilitiesMacro(p_token, p_token_1, p_token_2, p_token_3, p_AC_Status, p_token_4, p_token_5, p_AC_ReferPart, p_AC_ModulePart);
			p_token.parent = p_AgentCapabilitiesMacro_ref;
			p_token_1.parent = p_AgentCapabilitiesMacro_ref;
			p_token_2.parent = p_AgentCapabilitiesMacro_ref;
			p_token_3.parent = p_AgentCapabilitiesMacro_ref;
			p_AC_Status.parent = p_AgentCapabilitiesMacro_ref;
			p_token_4.parent = p_AgentCapabilitiesMacro_ref;
			p_token_5.parent = p_AgentCapabilitiesMacro_ref;
			p_AC_ReferPart.parent = p_AgentCapabilitiesMacro_ref;
			p_AC_ModulePart.parent = p_AgentCapabilitiesMacro_ref;
			Raise_AgentCapabilitiesMacro_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AgentCapabilitiesMacro.production_kind.g_AgentCapabilitiesMacro_1, p_AgentCapabilitiesMacro_ref);
			return p_AgentCapabilitiesMacro_ref;
		}
		#endregion
	};
}
