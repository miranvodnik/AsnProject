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
	// class associated with syntax rule MC-Compliance
	//

	[DataContract]
	public class	MC_Compliance : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-Compliance
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-Compliance
		{
			g_MC_Compliance_1 = 1,	// MC-ComplianceGroup

			g_MC_Compliance_2 = 2,	// MC-Object

		};
		#endregion
		#region production markers associated with the syntax rule MC-Compliance

		// markers associated with production: MC-Compliance -> MC-ComplianceGroup

		public enum production_marker_1 : ushort
		{
			m_MC_ComplianceGroup,
			final
		};

		// markers associated with production: MC-Compliance -> MC-Object

		public enum production_marker_2 : ushort
		{
			m_MC_Object,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-Compliance

		// Constructor declaration(s) associated with production(s) of syntax rule MC-Compliance

		//
		// Constructor associated with the following production(s)
		// MC-Compliance -> MC-ComplianceGroup

		//

		public MC_Compliance (MC_ComplianceGroup p_MC_ComplianceGroup) : base ((uint) ProductionID._MC_Compliance_ID, (uint) production_kind.g_MC_Compliance_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MC_ComplianceGroup = p_MC_ComplianceGroup;
		}

		//
		// Constructor associated with the following production(s)
		// MC-Compliance -> MC-Object

		//

		public MC_Compliance (MC_Object p_MC_Object) : base ((uint) ProductionID._MC_Compliance_ID, (uint) production_kind.g_MC_Compliance_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MC_Object = p_MC_Object;
		}

		public MC_Compliance () { }

		// Copy constructor

		public MC_Compliance (MC_Compliance p_MC_Compliance) : base (p_MC_Compliance.id, p_MC_Compliance.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_Compliance.appInfo;
			switch ((production_kind) p_MC_Compliance.kind)
			{
				case production_kind.g_MC_Compliance_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MC_ComplianceGroup = (p_MC_Compliance.m_MC_ComplianceGroup != null) ? new MC_ComplianceGroup (p_MC_Compliance.m_MC_ComplianceGroup) : null) != null) m_MC_ComplianceGroup.parent = this;
					break;
				case production_kind.g_MC_Compliance_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MC_Object = (p_MC_Compliance.m_MC_Object != null) ? new MC_Object (p_MC_Compliance.m_MC_Object) : null) != null) m_MC_Object.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MC_Compliance" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_Compliance (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_MC_ComplianceGroup?.Dispose ();
			m_MC_Object?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-Compliance

		// Content changing function(s) associated with production(s) of syntax rule MC-Compliance

		//
		// Content changing function associated with following production(s)
		// MC-Compliance -> MC-ComplianceGroup

		//

		public void change(MC_ComplianceGroup p_MC_ComplianceGroup)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Compliance_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MC_ComplianceGroup = p_MC_ComplianceGroup;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MC-Compliance -> MC-Object

		//

		public void change(MC_Object p_MC_Object)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Compliance_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MC_Object = p_MC_Object;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-Compliance
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_MC_ComplianceGroup != null) && m_MC_ComplianceGroup.checkInclusion (element) ||
				(m_MC_Object != null) && m_MC_Object.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-Compliance

		//
		// emit production tree node associated with any production of syntax rule MC-Compliance
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_Compliance_1:
					// emit syntax tree node associated with production
					// MC-Compliance: MC-ComplianceGroup

					s += m_MC_ComplianceGroup.Emit (depth - 1);
				break;
				case production_kind.g_MC_Compliance_2:
					// emit syntax tree node associated with production
					// MC-Compliance: MC-Object

					s += m_MC_Object.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-Compliance
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_Compliance (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_Compliance_1:
					// emit syntax tree node associated with production
					// MC-Compliance: MC-ComplianceGroup

					s += m_MC_ComplianceGroup.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MC_Compliance_2:
					// emit syntax tree node associated with production
					// MC-Compliance: MC-Object

					s += m_MC_Object.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-Compliance

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Compliance with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_Compliance.production_kind kind = (MC_Compliance.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_Compliance.production_kind.g_MC_Compliance_1:
					// traverse syntax tree node associated with production
					// MC-Compliance: MC-ComplianceGroup

						m_MC_ComplianceGroup.Visit (visitor, appData);
				break;
				case MC_Compliance.production_kind.g_MC_Compliance_2:
					// traverse syntax tree node associated with production
					// MC-Compliance: MC-Object

						m_MC_Object.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_MC_ComplianceGroup?.reparent (this);
			m_MC_Object?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MC-Compliance
		//

		public void _init ()
		{
			m_MC_ComplianceGroup = null;
			m_MC_Object = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-Compliance

		// counter of all nodes associated with syntax rule MC-Compliance
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-Compliance
		[DataMember (Name = "m_MC_ComplianceGroup")] public MC_ComplianceGroup m_MC_ComplianceGroup { get; private set; }
		[DataMember (Name = "m_MC_Object")] public MC_Object m_MC_Object { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-Compliance

		// delegate function (callback) prototype associated with syntax rule MC-Compliance
		public delegate bool MC_Compliance_Callback (SyntaxTreeCallbackReason reason, MC_Compliance.production_kind kind, MC_Compliance p_MC_Compliance);

		// event associated with syntax rule MC-Compliance
		public event MC_Compliance_Callback MC_Compliance_Event;

		// event trigger associated with syntax rule MC-Compliance
		public bool Raise_MC_Compliance_Event (SyntaxTreeCallbackReason reason, MC_Compliance.production_kind kind, MC_Compliance p_MC_Compliance)
		{
			bool? status = MC_Compliance_Event?.Invoke (reason, kind, p_MC_Compliance);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-Compliance
		//
		// traverse syntax tree node associated with any production of syntax rule MC-Compliance
		//

		public void Traverse (MC_Compliance p_MC_Compliance)
		{
			if (p_MC_Compliance.isLocked())
				return;
			p_MC_Compliance.dolock();
			MC_Compliance.production_kind kind = (MC_Compliance.production_kind) p_MC_Compliance.kind;
			p_MC_Compliance.turn_reset ();
			if (Raise_MC_Compliance_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_Compliance))
			switch (kind)
			{
				case MC_Compliance.production_kind.g_MC_Compliance_1:
					// traverse syntax tree node associated with production
					// MC-Compliance: MC-ComplianceGroup

					if (Raise_MC_Compliance_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Compliance))
						Traverse (p_MC_Compliance.m_MC_ComplianceGroup);
					p_MC_Compliance.turn_inc ();
					Raise_MC_Compliance_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Compliance);
				break;
				case MC_Compliance.production_kind.g_MC_Compliance_2:
					// traverse syntax tree node associated with production
					// MC-Compliance: MC-Object

					if (Raise_MC_Compliance_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Compliance))
						Traverse (p_MC_Compliance.m_MC_Object);
					p_MC_Compliance.turn_inc ();
					Raise_MC_Compliance_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Compliance);
				break;
			}
			Raise_MC_Compliance_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_Compliance);
			p_MC_Compliance.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Compliance
		//

		public void TraverseCommon (MC_Compliance p_MC_Compliance)
		{
			MC_Compliance.production_kind kind = (MC_Compliance.production_kind) p_MC_Compliance.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_Compliance))
			switch (kind)
			{
				case MC_Compliance.production_kind.g_MC_Compliance_1:
					// traverse syntax tree node associated with production
					// MC-Compliance: MC-ComplianceGroup

						TraverseCommon (p_MC_Compliance.m_MC_ComplianceGroup);
				break;
				case MC_Compliance.production_kind.g_MC_Compliance_2:
					// traverse syntax tree node associated with production
					// MC-Compliance: MC-Object

						TraverseCommon (p_MC_Compliance.m_MC_Object);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_Compliance);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-Compliance

		//
		// create syntax tree node associated with production
		// MC-Compliance: MC-ComplianceGroup

		//

		public MC_Compliance MC_Compliance_1 (MC_ComplianceGroup p_MC_ComplianceGroup)
		{
			MC_Compliance p_MC_Compliance_ref = new MC_Compliance(p_MC_ComplianceGroup);
			p_MC_ComplianceGroup.parent = p_MC_Compliance_ref;
			Raise_MC_Compliance_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Compliance.production_kind.g_MC_Compliance_1, p_MC_Compliance_ref);
			return p_MC_Compliance_ref;
		}

		//
		// create syntax tree node associated with production
		// MC-Compliance: MC-Object

		//

		public MC_Compliance MC_Compliance_2 (MC_Object p_MC_Object)
		{
			MC_Compliance p_MC_Compliance_ref = new MC_Compliance(p_MC_Object);
			p_MC_Object.parent = p_MC_Compliance_ref;
			Raise_MC_Compliance_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Compliance.production_kind.g_MC_Compliance_2, p_MC_Compliance_ref);
			return p_MC_Compliance_ref;
		}
		#endregion
	};
}
