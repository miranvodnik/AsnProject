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
	// class associated with syntax rule AC-ModulePart
	//

	[DataContract]
	public class	AC_ModulePart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-ModulePart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-ModulePart
		{
			g_AC_ModulePart_1 = 1,	// AC-Modules

			g_AC_ModulePart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule AC-ModulePart

		// markers associated with production: AC-ModulePart -> AC-Modules

		public enum production_marker_1 : ushort
		{
			m_AC_Modules,
			final
		};

		// markers associated with production: AC-ModulePart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-ModulePart

		// Constructor declaration(s) associated with production(s) of syntax rule AC-ModulePart

		//
		// Constructor associated with the following production(s)
		// AC-ModulePart -> AC-Modules

		//

		public AC_ModulePart (AC_Modules p_AC_Modules) : base ((uint) ProductionID._AC_ModulePart_ID, (uint) production_kind.g_AC_ModulePart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AC_Modules = p_AC_Modules;
		}

		//
		// Constructor associated with the following production(s)
		// AC-ModulePart -> %empty

		//

		public AC_ModulePart () : base ((uint) ProductionID._AC_ModulePart_ID, (uint) production_kind.g_AC_ModulePart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public AC_ModulePart (AC_ModulePart p_AC_ModulePart) : base (p_AC_ModulePart.id, p_AC_ModulePart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_ModulePart.appInfo;
			switch ((production_kind) p_AC_ModulePart.kind)
			{
				case production_kind.g_AC_ModulePart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AC_Modules = (p_AC_ModulePart.m_AC_Modules != null) ? new AC_Modules (p_AC_ModulePart.m_AC_Modules) : null) != null) m_AC_Modules.parent = this;
					break;
				case production_kind.g_AC_ModulePart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "AC_ModulePart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_ModulePart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_AC_Modules?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-ModulePart

		// Content changing function(s) associated with production(s) of syntax rule AC-ModulePart

		//
		// Content changing function associated with following production(s)
		// AC-ModulePart -> AC-Modules

		//

		public void change(AC_Modules p_AC_Modules)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_ModulePart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AC_Modules = p_AC_Modules;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-ModulePart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_ModulePart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-ModulePart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_AC_Modules != null) && m_AC_Modules.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-ModulePart

		//
		// emit production tree node associated with any production of syntax rule AC-ModulePart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_ModulePart_1:
					// emit syntax tree node associated with production
					// AC-ModulePart: AC-Modules

					s += m_AC_Modules.Emit (depth - 1);
				break;
				case production_kind.g_AC_ModulePart_2:
					// emit syntax tree node associated with production
					// AC-ModulePart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-ModulePart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_ModulePart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_ModulePart_1:
					// emit syntax tree node associated with production
					// AC-ModulePart: AC-Modules

					s += m_AC_Modules.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AC_ModulePart_2:
					// emit syntax tree node associated with production
					// AC-ModulePart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-ModulePart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-ModulePart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_ModulePart.production_kind kind = (AC_ModulePart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_ModulePart.production_kind.g_AC_ModulePart_1:
					// traverse syntax tree node associated with production
					// AC-ModulePart: AC-Modules

						m_AC_Modules.Visit (visitor, appData);
				break;
				case AC_ModulePart.production_kind.g_AC_ModulePart_2:
					// traverse syntax tree node associated with production
					// AC-ModulePart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_AC_Modules?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-ModulePart
		//

		public void _init ()
		{
			m_AC_Modules = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-ModulePart

		// counter of all nodes associated with syntax rule AC-ModulePart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-ModulePart
		[DataMember (Name = "m_AC_Modules")] public AC_Modules m_AC_Modules { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-ModulePart

		// delegate function (callback) prototype associated with syntax rule AC-ModulePart
		public delegate bool AC_ModulePart_Callback (SyntaxTreeCallbackReason reason, AC_ModulePart.production_kind kind, AC_ModulePart p_AC_ModulePart);

		// event associated with syntax rule AC-ModulePart
		public event AC_ModulePart_Callback AC_ModulePart_Event;

		// event trigger associated with syntax rule AC-ModulePart
		public bool Raise_AC_ModulePart_Event (SyntaxTreeCallbackReason reason, AC_ModulePart.production_kind kind, AC_ModulePart p_AC_ModulePart)
		{
			bool? status = AC_ModulePart_Event?.Invoke (reason, kind, p_AC_ModulePart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-ModulePart
		//
		// traverse syntax tree node associated with any production of syntax rule AC-ModulePart
		//

		public void Traverse (AC_ModulePart p_AC_ModulePart)
		{
			if (p_AC_ModulePart.isLocked())
				return;
			p_AC_ModulePart.dolock();
			AC_ModulePart.production_kind kind = (AC_ModulePart.production_kind) p_AC_ModulePart.kind;
			p_AC_ModulePart.turn_reset ();
			if (Raise_AC_ModulePart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_ModulePart))
			switch (kind)
			{
				case AC_ModulePart.production_kind.g_AC_ModulePart_1:
					// traverse syntax tree node associated with production
					// AC-ModulePart: AC-Modules

					if (Raise_AC_ModulePart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ModulePart))
						Traverse (p_AC_ModulePart.m_AC_Modules);
					p_AC_ModulePart.turn_inc ();
					Raise_AC_ModulePart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ModulePart);
				break;
				case AC_ModulePart.production_kind.g_AC_ModulePart_2:
					// traverse syntax tree node associated with production
					// AC-ModulePart: %empty

				break;
			}
			Raise_AC_ModulePart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_ModulePart);
			p_AC_ModulePart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-ModulePart
		//

		public void TraverseCommon (AC_ModulePart p_AC_ModulePart)
		{
			AC_ModulePart.production_kind kind = (AC_ModulePart.production_kind) p_AC_ModulePart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_ModulePart))
			switch (kind)
			{
				case AC_ModulePart.production_kind.g_AC_ModulePart_1:
					// traverse syntax tree node associated with production
					// AC-ModulePart: AC-Modules

						TraverseCommon (p_AC_ModulePart.m_AC_Modules);
				break;
				case AC_ModulePart.production_kind.g_AC_ModulePart_2:
					// traverse syntax tree node associated with production
					// AC-ModulePart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_ModulePart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-ModulePart

		//
		// create syntax tree node associated with production
		// AC-ModulePart: AC-Modules

		//

		public AC_ModulePart AC_ModulePart_1 (AC_Modules p_AC_Modules)
		{
			AC_ModulePart p_AC_ModulePart_ref = new AC_ModulePart(p_AC_Modules);
			p_AC_Modules.parent = p_AC_ModulePart_ref;
			Raise_AC_ModulePart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_ModulePart.production_kind.g_AC_ModulePart_1, p_AC_ModulePart_ref);
			return p_AC_ModulePart_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-ModulePart: %empty

		//

		public AC_ModulePart AC_ModulePart_2 ()
		{
			AC_ModulePart p_AC_ModulePart_ref = new AC_ModulePart();
			Raise_AC_ModulePart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_ModulePart.production_kind.g_AC_ModulePart_2, p_AC_ModulePart_ref);
			return p_AC_ModulePart_ref;
		}
		#endregion
	};
}
