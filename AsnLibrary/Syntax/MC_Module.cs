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
	// class associated with syntax rule MC-Module
	//

	[DataContract]
	public class	MC_Module : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-Module
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-Module
		{
			g_MC_Module_1 = 1,	// MODULE MC-ModuleName MC-MandatoryPart MC-CompliancePart

		};
		#endregion
		#region production markers associated with the syntax rule MC-Module

		// markers associated with production: MC-Module -> MODULE MC-ModuleName MC-MandatoryPart MC-CompliancePart

		public enum production_marker_1 : ushort
		{
			m_MC_ModuleName,
			m_MC_MandatoryPart,
			m_MC_CompliancePart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-Module

		// Constructor declaration(s) associated with production(s) of syntax rule MC-Module

		//
		// Constructor associated with the following production(s)
		// MC-Module -> MODULE MC-ModuleName MC-MandatoryPart MC-CompliancePart

		//

		public MC_Module (SyntaxTreeToken p_token, MC_ModuleName p_MC_ModuleName, MC_MandatoryPart p_MC_MandatoryPart, MC_CompliancePart p_MC_CompliancePart) : base ((uint) ProductionID._MC_Module_ID, (uint) production_kind.g_MC_Module_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_MODULE = p_token;
			children[1] = m_MC_ModuleName = p_MC_ModuleName;
			children[2] = m_MC_MandatoryPart = p_MC_MandatoryPart;
			children[3] = m_MC_CompliancePart = p_MC_CompliancePart;
		}

		public MC_Module () { }

		// Copy constructor

		public MC_Module (MC_Module p_MC_Module) : base (p_MC_Module.id, p_MC_Module.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_Module.appInfo;
			switch ((production_kind) p_MC_Module.kind)
			{
				case production_kind.g_MC_Module_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_MODULE = (p_MC_Module.m_MODULE != null) ? new SyntaxTreeToken (p_MC_Module.m_MODULE) : null) != null) m_MODULE.parent = this;
					if ((children [1] = m_MC_ModuleName = (p_MC_Module.m_MC_ModuleName != null) ? new MC_ModuleName (p_MC_Module.m_MC_ModuleName) : null) != null) m_MC_ModuleName.parent = this;
					if ((children [2] = m_MC_MandatoryPart = (p_MC_Module.m_MC_MandatoryPart != null) ? new MC_MandatoryPart (p_MC_Module.m_MC_MandatoryPart) : null) != null) m_MC_MandatoryPart.parent = this;
					if ((children [3] = m_MC_CompliancePart = (p_MC_Module.m_MC_CompliancePart != null) ? new MC_CompliancePart (p_MC_Module.m_MC_CompliancePart) : null) != null) m_MC_CompliancePart.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MC_Module" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_Module (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_MODULE?.Dispose ();
			m_MC_ModuleName?.Dispose ();
			m_MC_MandatoryPart?.Dispose ();
			m_MC_CompliancePart?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-Module

		// Content changing function(s) associated with production(s) of syntax rule MC-Module

		//
		// Content changing function associated with following production(s)
		// MC-Module -> MODULE MC-ModuleName MC-MandatoryPart MC-CompliancePart

		//

		public void change(SyntaxTreeToken p_token, MC_ModuleName p_MC_ModuleName, MC_MandatoryPart p_MC_MandatoryPart, MC_CompliancePart p_MC_CompliancePart)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Module_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_MODULE = p_token;
			children [1] = m_MC_ModuleName = p_MC_ModuleName;
			children [2] = m_MC_MandatoryPart = p_MC_MandatoryPart;
			children [3] = m_MC_CompliancePart = p_MC_CompliancePart;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-Module
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_MODULE != null) && m_MODULE.checkInclusion (element) ||
				(m_MC_ModuleName != null) && m_MC_ModuleName.checkInclusion (element) ||
				(m_MC_MandatoryPart != null) && m_MC_MandatoryPart.checkInclusion (element) ||
				(m_MC_CompliancePart != null) && m_MC_CompliancePart.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-Module

		//
		// emit production tree node associated with any production of syntax rule MC-Module
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_Module_1:
					// emit syntax tree node associated with production
					// MC-Module: MODULE MC-ModuleName MC-MandatoryPart MC-CompliancePart

					s += m_MODULE.Emit (depth - 1);
					s += " ";
					s += m_MC_ModuleName.Emit (depth - 1);
					s += " ";
					s += m_MC_MandatoryPart.Emit (depth - 1);
					s += " ";
					s += m_MC_CompliancePart.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-Module
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_Module (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_Module_1:
					// emit syntax tree node associated with production
					// MC-Module: MODULE MC-ModuleName MC-MandatoryPart MC-CompliancePart

					s += "MODULE";
					s += ' ';
					s += m_MC_ModuleName.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_MC_MandatoryPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_MC_CompliancePart.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-Module

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Module with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_Module.production_kind kind = (MC_Module.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_Module.production_kind.g_MC_Module_1:
					// traverse syntax tree node associated with production
					// MC-Module: MODULE MC-ModuleName MC-MandatoryPart MC-CompliancePart

						m_MODULE.Visit (visitor, appData);
						m_MC_ModuleName.Visit (visitor, appData);
						m_MC_MandatoryPart.Visit (visitor, appData);
						m_MC_CompliancePart.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_MODULE?.reparent (this);
			m_MC_ModuleName?.reparent (this);
			m_MC_MandatoryPart?.reparent (this);
			m_MC_CompliancePart?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MC-Module
		//

		public void _init ()
		{
			m_MODULE = null;
			m_MC_ModuleName = null;
			m_MC_MandatoryPart = null;
			m_MC_CompliancePart = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-Module

		// counter of all nodes associated with syntax rule MC-Module
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-Module
		[DataMember (Name = "m_MODULE")] public SyntaxTreeToken m_MODULE { get; private set; }
		[DataMember (Name = "m_MC_ModuleName")] public MC_ModuleName m_MC_ModuleName { get; private set; }
		[DataMember (Name = "m_MC_MandatoryPart")] public MC_MandatoryPart m_MC_MandatoryPart { get; private set; }
		[DataMember (Name = "m_MC_CompliancePart")] public MC_CompliancePart m_MC_CompliancePart { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-Module

		// delegate function (callback) prototype associated with syntax rule MC-Module
		public delegate bool MC_Module_Callback (SyntaxTreeCallbackReason reason, MC_Module.production_kind kind, MC_Module p_MC_Module);

		// event associated with syntax rule MC-Module
		public event MC_Module_Callback MC_Module_Event;

		// event trigger associated with syntax rule MC-Module
		public bool Raise_MC_Module_Event (SyntaxTreeCallbackReason reason, MC_Module.production_kind kind, MC_Module p_MC_Module)
		{
			bool? status = MC_Module_Event?.Invoke (reason, kind, p_MC_Module);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-Module
		//
		// traverse syntax tree node associated with any production of syntax rule MC-Module
		//

		public void Traverse (MC_Module p_MC_Module)
		{
			if (p_MC_Module.isLocked())
				return;
			p_MC_Module.dolock();
			MC_Module.production_kind kind = (MC_Module.production_kind) p_MC_Module.kind;
			p_MC_Module.turn_reset ();
			if (Raise_MC_Module_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_Module))
			switch (kind)
			{
				case MC_Module.production_kind.g_MC_Module_1:
					// traverse syntax tree node associated with production
					// MC-Module: MODULE MC-ModuleName MC-MandatoryPart MC-CompliancePart

					if (Raise_MC_Module_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Module))
						Traverse (p_MC_Module.m_MC_ModuleName);
					p_MC_Module.turn_inc ();
					if (Raise_MC_Module_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Module))
						Traverse (p_MC_Module.m_MC_MandatoryPart);
					p_MC_Module.turn_inc ();
					if (Raise_MC_Module_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Module))
						Traverse (p_MC_Module.m_MC_CompliancePart);
					p_MC_Module.turn_inc ();
					Raise_MC_Module_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Module);
				break;
			}
			Raise_MC_Module_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_Module);
			p_MC_Module.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Module
		//

		public void TraverseCommon (MC_Module p_MC_Module)
		{
			MC_Module.production_kind kind = (MC_Module.production_kind) p_MC_Module.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_Module))
			switch (kind)
			{
				case MC_Module.production_kind.g_MC_Module_1:
					// traverse syntax tree node associated with production
					// MC-Module: MODULE MC-ModuleName MC-MandatoryPart MC-CompliancePart

						TraverseCommon (p_MC_Module.m_MODULE);
						TraverseCommon (p_MC_Module.m_MC_ModuleName);
						TraverseCommon (p_MC_Module.m_MC_MandatoryPart);
						TraverseCommon (p_MC_Module.m_MC_CompliancePart);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_Module);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-Module

		//
		// create syntax tree node associated with production
		// MC-Module: MODULE MC-ModuleName MC-MandatoryPart MC-CompliancePart

		//

		public MC_Module MC_Module_1 (SyntaxTreeToken p_token, MC_ModuleName p_MC_ModuleName, MC_MandatoryPart p_MC_MandatoryPart, MC_CompliancePart p_MC_CompliancePart)
		{
			MC_Module p_MC_Module_ref = new MC_Module(p_token, p_MC_ModuleName, p_MC_MandatoryPart, p_MC_CompliancePart);
			p_token.parent = p_MC_Module_ref;
			p_MC_ModuleName.parent = p_MC_Module_ref;
			p_MC_MandatoryPart.parent = p_MC_Module_ref;
			p_MC_CompliancePart.parent = p_MC_Module_ref;
			Raise_MC_Module_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Module.production_kind.g_MC_Module_1, p_MC_Module_ref);
			return p_MC_Module_ref;
		}
		#endregion
	};
}
