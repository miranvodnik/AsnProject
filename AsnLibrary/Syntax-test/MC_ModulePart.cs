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
	// class associated with syntax rule MC-ModulePart
	//

	[DataContract]
	public class	MC_ModulePart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-ModulePart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-ModulePart
		{
			g_MC_ModulePart_1 = 1,	// MC-Modules

		};
		#endregion
		#region production markers associated with the syntax rule MC-ModulePart

		// markers associated with production: MC-ModulePart -> MC-Modules

		public enum production_marker_1 : ushort
		{
			m_MC_Modules,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-ModulePart

		// Constructor declaration(s) associated with production(s) of syntax rule MC-ModulePart

		//
		// Constructor associated with the following production(s)
		// MC-ModulePart -> MC-Modules

		//

		public MC_ModulePart (MC_Modules p_MC_Modules) : base ((uint) ProductionID._MC_ModulePart_ID, (uint) production_kind.g_MC_ModulePart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MC_Modules = p_MC_Modules;
		}

		public MC_ModulePart () { }

		// Copy constructor

		public MC_ModulePart (MC_ModulePart p_MC_ModulePart) : base (p_MC_ModulePart.id, p_MC_ModulePart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_ModulePart.appInfo;
			switch ((production_kind) p_MC_ModulePart.kind)
			{
				case production_kind.g_MC_ModulePart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MC_Modules = (p_MC_ModulePart.m_MC_Modules != null) ? new MC_Modules (p_MC_ModulePart.m_MC_Modules) : null) != null) m_MC_Modules.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MC_ModulePart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_ModulePart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_MC_Modules?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-ModulePart

		// Content changing function(s) associated with production(s) of syntax rule MC-ModulePart

		//
		// Content changing function associated with following production(s)
		// MC-ModulePart -> MC-Modules

		//

		public void change(MC_Modules p_MC_Modules)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_ModulePart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MC_Modules = p_MC_Modules;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-ModulePart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_MC_Modules != null) && m_MC_Modules.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-ModulePart

		//
		// emit production tree node associated with any production of syntax rule MC-ModulePart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_ModulePart_1:
					// emit syntax tree node associated with production
					// MC-ModulePart: MC-Modules

					s += m_MC_Modules.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-ModulePart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_ModulePart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_ModulePart_1:
					// emit syntax tree node associated with production
					// MC-ModulePart: MC-Modules

					s += m_MC_Modules.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-ModulePart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-ModulePart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_ModulePart.production_kind kind = (MC_ModulePart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_ModulePart.production_kind.g_MC_ModulePart_1:
					// traverse syntax tree node associated with production
					// MC-ModulePart: MC-Modules

						m_MC_Modules.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_MC_Modules?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MC-ModulePart
		//

		public void _init ()
		{
			m_MC_Modules = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-ModulePart

		// counter of all nodes associated with syntax rule MC-ModulePart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-ModulePart
		[DataMember (Name = "m_MC_Modules")] public MC_Modules m_MC_Modules { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-ModulePart

		// delegate function (callback) prototype associated with syntax rule MC-ModulePart
		public delegate bool MC_ModulePart_Callback (SyntaxTreeCallbackReason reason, MC_ModulePart.production_kind kind, MC_ModulePart p_MC_ModulePart);

		// event associated with syntax rule MC-ModulePart
		public event MC_ModulePart_Callback MC_ModulePart_Event;

		// event trigger associated with syntax rule MC-ModulePart
		public bool Raise_MC_ModulePart_Event (SyntaxTreeCallbackReason reason, MC_ModulePart.production_kind kind, MC_ModulePart p_MC_ModulePart)
		{
			bool? status = MC_ModulePart_Event?.Invoke (reason, kind, p_MC_ModulePart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-ModulePart
		//
		// traverse syntax tree node associated with any production of syntax rule MC-ModulePart
		//

		public void Traverse (MC_ModulePart p_MC_ModulePart)
		{
			if (p_MC_ModulePart.isLocked())
				return;
			p_MC_ModulePart.dolock();
			MC_ModulePart.production_kind kind = (MC_ModulePart.production_kind) p_MC_ModulePart.kind;
			p_MC_ModulePart.turn_reset ();
			if (Raise_MC_ModulePart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_ModulePart))
			switch (kind)
			{
				case MC_ModulePart.production_kind.g_MC_ModulePart_1:
					// traverse syntax tree node associated with production
					// MC-ModulePart: MC-Modules

					if (Raise_MC_ModulePart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_ModulePart))
						Traverse (p_MC_ModulePart.m_MC_Modules);
					p_MC_ModulePart.turn_inc ();
					Raise_MC_ModulePart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_ModulePart);
				break;
			}
			Raise_MC_ModulePart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_ModulePart);
			p_MC_ModulePart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-ModulePart
		//

		public void TraverseCommon (MC_ModulePart p_MC_ModulePart)
		{
			MC_ModulePart.production_kind kind = (MC_ModulePart.production_kind) p_MC_ModulePart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_ModulePart))
			switch (kind)
			{
				case MC_ModulePart.production_kind.g_MC_ModulePart_1:
					// traverse syntax tree node associated with production
					// MC-ModulePart: MC-Modules

						TraverseCommon (p_MC_ModulePart.m_MC_Modules);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_ModulePart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-ModulePart

		//
		// create syntax tree node associated with production
		// MC-ModulePart: MC-Modules

		//

		public MC_ModulePart MC_ModulePart_1 (MC_Modules p_MC_Modules)
		{
			MC_ModulePart p_MC_ModulePart_ref = new MC_ModulePart(p_MC_Modules);
			p_MC_Modules.parent = p_MC_ModulePart_ref;
			Raise_MC_ModulePart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_ModulePart.production_kind.g_MC_ModulePart_1, p_MC_ModulePart_ref);
			return p_MC_ModulePart_ref;
		}
		#endregion
	};
}
