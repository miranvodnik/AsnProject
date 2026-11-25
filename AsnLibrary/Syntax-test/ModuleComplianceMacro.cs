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
	// class associated with syntax rule ModuleComplianceMacro
	//

	[DataContract]
	public class	ModuleComplianceMacro : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ModuleComplianceMacro
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ModuleComplianceMacro
		{
			g_ModuleComplianceMacro_1 = 1,	// MODULE-COMPLIANCE STATUS MC-Status DESCRIPTION cstring MC-ReferPart MC-ModulePart

		};
		#endregion
		#region production markers associated with the syntax rule ModuleComplianceMacro

		// markers associated with production: ModuleComplianceMacro -> MODULE-COMPLIANCE STATUS MC-Status DESCRIPTION cstring MC-ReferPart MC-ModulePart

		public enum production_marker_1 : ushort
		{
			m_MC_Status,
			m_MC_ReferPart,
			m_MC_ModulePart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ModuleComplianceMacro

		// Constructor declaration(s) associated with production(s) of syntax rule ModuleComplianceMacro

		//
		// Constructor associated with the following production(s)
		// ModuleComplianceMacro -> MODULE-COMPLIANCE STATUS MC-Status DESCRIPTION cstring MC-ReferPart MC-ModulePart

		//

		public ModuleComplianceMacro (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, MC_Status p_MC_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, MC_ReferPart p_MC_ReferPart, MC_ModulePart p_MC_ModulePart) : base ((uint) ProductionID._ModuleComplianceMacro_ID, (uint) production_kind.g_ModuleComplianceMacro_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children[0] = m_MODULE_COMPLIANCE = p_token;
			children[1] = m_STATUS = p_token_1;
			children[2] = m_MC_Status = p_MC_Status;
			children[3] = m_DESCRIPTION = p_token_2;
			children[4] = m_cstring = p_token_3;
			children[5] = m_MC_ReferPart = p_MC_ReferPart;
			children[6] = m_MC_ModulePart = p_MC_ModulePart;
		}

		public ModuleComplianceMacro () { }

		// Copy constructor

		public ModuleComplianceMacro (ModuleComplianceMacro p_ModuleComplianceMacro) : base (p_ModuleComplianceMacro.id, p_ModuleComplianceMacro.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ModuleComplianceMacro.appInfo;
			switch ((production_kind) p_ModuleComplianceMacro.kind)
			{
				case production_kind.g_ModuleComplianceMacro_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_MODULE_COMPLIANCE = (p_ModuleComplianceMacro.m_MODULE_COMPLIANCE != null) ? new SyntaxTreeToken (p_ModuleComplianceMacro.m_MODULE_COMPLIANCE) : null) != null) m_MODULE_COMPLIANCE.parent = this;
					if ((children [1] = m_STATUS = (p_ModuleComplianceMacro.m_STATUS != null) ? new SyntaxTreeToken (p_ModuleComplianceMacro.m_STATUS) : null) != null) m_STATUS.parent = this;
					if ((children [2] = m_MC_Status = (p_ModuleComplianceMacro.m_MC_Status != null) ? new MC_Status (p_ModuleComplianceMacro.m_MC_Status) : null) != null) m_MC_Status.parent = this;
					if ((children [3] = m_DESCRIPTION = (p_ModuleComplianceMacro.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_ModuleComplianceMacro.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [4] = m_cstring = (p_ModuleComplianceMacro.m_cstring != null) ? new SyntaxTreeToken (p_ModuleComplianceMacro.m_cstring) : null) != null) m_cstring.parent = this;
					if ((children [5] = m_MC_ReferPart = (p_ModuleComplianceMacro.m_MC_ReferPart != null) ? new MC_ReferPart (p_ModuleComplianceMacro.m_MC_ReferPart) : null) != null) m_MC_ReferPart.parent = this;
					if ((children [6] = m_MC_ModulePart = (p_ModuleComplianceMacro.m_MC_ModulePart != null) ? new MC_ModulePart (p_ModuleComplianceMacro.m_MC_ModulePart) : null) != null) m_MC_ModulePart.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ModuleComplianceMacro" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ModuleComplianceMacro (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_MODULE_COMPLIANCE?.Dispose ();
			m_STATUS?.Dispose ();
			m_MC_Status?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_cstring?.Dispose ();
			m_MC_ReferPart?.Dispose ();
			m_MC_ModulePart?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ModuleComplianceMacro

		// Content changing function(s) associated with production(s) of syntax rule ModuleComplianceMacro

		//
		// Content changing function associated with following production(s)
		// ModuleComplianceMacro -> MODULE-COMPLIANCE STATUS MC-Status DESCRIPTION cstring MC-ReferPart MC-ModulePart

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, MC_Status p_MC_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, MC_ReferPart p_MC_ReferPart, MC_ModulePart p_MC_ModulePart)
		{
			_init ();
			this.kind = (uint) production_kind.g_ModuleComplianceMacro_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children [0] = m_MODULE_COMPLIANCE = p_token;
			children [1] = m_STATUS = p_token_1;
			children [2] = m_MC_Status = p_MC_Status;
			children [3] = m_DESCRIPTION = p_token_2;
			children [4] = m_cstring = p_token_3;
			children [5] = m_MC_ReferPart = p_MC_ReferPart;
			children [6] = m_MC_ModulePart = p_MC_ModulePart;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ModuleComplianceMacro
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_MODULE_COMPLIANCE != null) && m_MODULE_COMPLIANCE.checkInclusion (element) ||
				(m_STATUS != null) && m_STATUS.checkInclusion (element) ||
				(m_MC_Status != null) && m_MC_Status.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				(m_MC_ReferPart != null) && m_MC_ReferPart.checkInclusion (element) ||
				(m_MC_ModulePart != null) && m_MC_ModulePart.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ModuleComplianceMacro

		//
		// emit production tree node associated with any production of syntax rule ModuleComplianceMacro
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ModuleComplianceMacro_1:
					// emit syntax tree node associated with production
					// ModuleComplianceMacro: MODULE-COMPLIANCE STATUS MC-Status DESCRIPTION cstring MC-ReferPart MC-ModulePart

					s += m_MODULE_COMPLIANCE.Emit (depth - 1);
					s += " ";
					s += m_STATUS.Emit (depth - 1);
					s += " ";
					s += m_MC_Status.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
					s += " ";
					s += m_MC_ReferPart.Emit (depth - 1);
					s += " ";
					s += m_MC_ModulePart.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ModuleComplianceMacro
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ModuleComplianceMacro (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ModuleComplianceMacro_1:
					// emit syntax tree node associated with production
					// ModuleComplianceMacro: MODULE-COMPLIANCE STATUS MC-Status DESCRIPTION cstring MC-ReferPart MC-ModulePart

					s += "MODULE_COMPLIANCE";
					s += ' ';
					s += "STATUS";
					s += ' ';
					s += m_MC_Status.EmitProductionTree (depth - 1);
					s += ' ';
					s += "DESCRIPTION";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += m_MC_ReferPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_MC_ModulePart.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ModuleComplianceMacro

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ModuleComplianceMacro with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ModuleComplianceMacro.production_kind kind = (ModuleComplianceMacro.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ModuleComplianceMacro.production_kind.g_ModuleComplianceMacro_1:
					// traverse syntax tree node associated with production
					// ModuleComplianceMacro: MODULE-COMPLIANCE STATUS MC-Status DESCRIPTION cstring MC-ReferPart MC-ModulePart

						m_MODULE_COMPLIANCE.Visit (visitor, appData);
						m_STATUS.Visit (visitor, appData);
						m_MC_Status.Visit (visitor, appData);
						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
						m_MC_ReferPart.Visit (visitor, appData);
						m_MC_ModulePart.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_MODULE_COMPLIANCE?.reparent (this);
			m_STATUS?.reparent (this);
			m_MC_Status?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_cstring?.reparent (this);
			m_MC_ReferPart?.reparent (this);
			m_MC_ModulePart?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ModuleComplianceMacro
		//

		public void _init ()
		{
			m_MODULE_COMPLIANCE = null;
			m_STATUS = null;
			m_MC_Status = null;
			m_DESCRIPTION = null;
			m_cstring = null;
			m_MC_ReferPart = null;
			m_MC_ModulePart = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ModuleComplianceMacro

		// counter of all nodes associated with syntax rule ModuleComplianceMacro
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ModuleComplianceMacro
		[DataMember (Name = "m_MODULE_COMPLIANCE")] public SyntaxTreeToken m_MODULE_COMPLIANCE { get; private set; }
		[DataMember (Name = "m_STATUS")] public SyntaxTreeToken m_STATUS { get; private set; }
		[DataMember (Name = "m_MC_Status")] public MC_Status m_MC_Status { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		[DataMember (Name = "m_MC_ReferPart")] public MC_ReferPart m_MC_ReferPart { get; private set; }
		[DataMember (Name = "m_MC_ModulePart")] public MC_ModulePart m_MC_ModulePart { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ModuleComplianceMacro

		// delegate function (callback) prototype associated with syntax rule ModuleComplianceMacro
		public delegate bool ModuleComplianceMacro_Callback (SyntaxTreeCallbackReason reason, ModuleComplianceMacro.production_kind kind, ModuleComplianceMacro p_ModuleComplianceMacro);

		// event associated with syntax rule ModuleComplianceMacro
		public event ModuleComplianceMacro_Callback ModuleComplianceMacro_Event;

		// event trigger associated with syntax rule ModuleComplianceMacro
		public bool Raise_ModuleComplianceMacro_Event (SyntaxTreeCallbackReason reason, ModuleComplianceMacro.production_kind kind, ModuleComplianceMacro p_ModuleComplianceMacro)
		{
			bool? status = ModuleComplianceMacro_Event?.Invoke (reason, kind, p_ModuleComplianceMacro);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ModuleComplianceMacro
		//
		// traverse syntax tree node associated with any production of syntax rule ModuleComplianceMacro
		//

		public void Traverse (ModuleComplianceMacro p_ModuleComplianceMacro)
		{
			if (p_ModuleComplianceMacro.isLocked())
				return;
			p_ModuleComplianceMacro.dolock();
			ModuleComplianceMacro.production_kind kind = (ModuleComplianceMacro.production_kind) p_ModuleComplianceMacro.kind;
			p_ModuleComplianceMacro.turn_reset ();
			if (Raise_ModuleComplianceMacro_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ModuleComplianceMacro))
			switch (kind)
			{
				case ModuleComplianceMacro.production_kind.g_ModuleComplianceMacro_1:
					// traverse syntax tree node associated with production
					// ModuleComplianceMacro: MODULE-COMPLIANCE STATUS MC-Status DESCRIPTION cstring MC-ReferPart MC-ModulePart

					if (Raise_ModuleComplianceMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleComplianceMacro))
						Traverse (p_ModuleComplianceMacro.m_MC_Status);
					p_ModuleComplianceMacro.turn_inc ();
					if (Raise_ModuleComplianceMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleComplianceMacro))
						Traverse (p_ModuleComplianceMacro.m_MC_ReferPart);
					p_ModuleComplianceMacro.turn_inc ();
					if (Raise_ModuleComplianceMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleComplianceMacro))
						Traverse (p_ModuleComplianceMacro.m_MC_ModulePart);
					p_ModuleComplianceMacro.turn_inc ();
					Raise_ModuleComplianceMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleComplianceMacro);
				break;
			}
			Raise_ModuleComplianceMacro_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ModuleComplianceMacro);
			p_ModuleComplianceMacro.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ModuleComplianceMacro
		//

		public void TraverseCommon (ModuleComplianceMacro p_ModuleComplianceMacro)
		{
			ModuleComplianceMacro.production_kind kind = (ModuleComplianceMacro.production_kind) p_ModuleComplianceMacro.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ModuleComplianceMacro))
			switch (kind)
			{
				case ModuleComplianceMacro.production_kind.g_ModuleComplianceMacro_1:
					// traverse syntax tree node associated with production
					// ModuleComplianceMacro: MODULE-COMPLIANCE STATUS MC-Status DESCRIPTION cstring MC-ReferPart MC-ModulePart

						TraverseCommon (p_ModuleComplianceMacro.m_MODULE_COMPLIANCE);
						TraverseCommon (p_ModuleComplianceMacro.m_STATUS);
						TraverseCommon (p_ModuleComplianceMacro.m_MC_Status);
						TraverseCommon (p_ModuleComplianceMacro.m_DESCRIPTION);
						TraverseCommon (p_ModuleComplianceMacro.m_cstring);
						TraverseCommon (p_ModuleComplianceMacro.m_MC_ReferPart);
						TraverseCommon (p_ModuleComplianceMacro.m_MC_ModulePart);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ModuleComplianceMacro);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ModuleComplianceMacro

		//
		// create syntax tree node associated with production
		// ModuleComplianceMacro: MODULE-COMPLIANCE STATUS MC-Status DESCRIPTION cstring MC-ReferPart MC-ModulePart

		//

		public ModuleComplianceMacro ModuleComplianceMacro_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, MC_Status p_MC_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, MC_ReferPart p_MC_ReferPart, MC_ModulePart p_MC_ModulePart)
		{
			ModuleComplianceMacro p_ModuleComplianceMacro_ref = new ModuleComplianceMacro(p_token, p_token_1, p_MC_Status, p_token_2, p_token_3, p_MC_ReferPart, p_MC_ModulePart);
			p_token.parent = p_ModuleComplianceMacro_ref;
			p_token_1.parent = p_ModuleComplianceMacro_ref;
			p_MC_Status.parent = p_ModuleComplianceMacro_ref;
			p_token_2.parent = p_ModuleComplianceMacro_ref;
			p_token_3.parent = p_ModuleComplianceMacro_ref;
			p_MC_ReferPart.parent = p_ModuleComplianceMacro_ref;
			p_MC_ModulePart.parent = p_ModuleComplianceMacro_ref;
			Raise_ModuleComplianceMacro_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ModuleComplianceMacro.production_kind.g_ModuleComplianceMacro_1, p_ModuleComplianceMacro_ref);
			return p_ModuleComplianceMacro_ref;
		}
		#endregion
	};
}
