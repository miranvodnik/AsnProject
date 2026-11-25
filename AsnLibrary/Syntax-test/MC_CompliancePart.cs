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
	// class associated with syntax rule MC-CompliancePart
	//

	[DataContract]
	public class	MC_CompliancePart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-CompliancePart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-CompliancePart
		{
			g_MC_CompliancePart_1 = 1,	// MC-Compliances

			g_MC_CompliancePart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule MC-CompliancePart

		// markers associated with production: MC-CompliancePart -> MC-Compliances

		public enum production_marker_1 : ushort
		{
			m_MC_Compliances,
			final
		};

		// markers associated with production: MC-CompliancePart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-CompliancePart

		// Constructor declaration(s) associated with production(s) of syntax rule MC-CompliancePart

		//
		// Constructor associated with the following production(s)
		// MC-CompliancePart -> MC-Compliances

		//

		public MC_CompliancePart (MC_Compliances p_MC_Compliances) : base ((uint) ProductionID._MC_CompliancePart_ID, (uint) production_kind.g_MC_CompliancePart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MC_Compliances = p_MC_Compliances;
		}

		//
		// Constructor associated with the following production(s)
		// MC-CompliancePart -> %empty

		//

		public MC_CompliancePart () : base ((uint) ProductionID._MC_CompliancePart_ID, (uint) production_kind.g_MC_CompliancePart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public MC_CompliancePart (MC_CompliancePart p_MC_CompliancePart) : base (p_MC_CompliancePart.id, p_MC_CompliancePart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_CompliancePart.appInfo;
			switch ((production_kind) p_MC_CompliancePart.kind)
			{
				case production_kind.g_MC_CompliancePart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MC_Compliances = (p_MC_CompliancePart.m_MC_Compliances != null) ? new MC_Compliances (p_MC_CompliancePart.m_MC_Compliances) : null) != null) m_MC_Compliances.parent = this;
					break;
				case production_kind.g_MC_CompliancePart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "MC_CompliancePart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_CompliancePart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_MC_Compliances?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-CompliancePart

		// Content changing function(s) associated with production(s) of syntax rule MC-CompliancePart

		//
		// Content changing function associated with following production(s)
		// MC-CompliancePart -> MC-Compliances

		//

		public void change(MC_Compliances p_MC_Compliances)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_CompliancePart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MC_Compliances = p_MC_Compliances;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MC-CompliancePart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_CompliancePart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-CompliancePart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_MC_Compliances != null) && m_MC_Compliances.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-CompliancePart

		//
		// emit production tree node associated with any production of syntax rule MC-CompliancePart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_CompliancePart_1:
					// emit syntax tree node associated with production
					// MC-CompliancePart: MC-Compliances

					s += m_MC_Compliances.Emit (depth - 1);
				break;
				case production_kind.g_MC_CompliancePart_2:
					// emit syntax tree node associated with production
					// MC-CompliancePart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-CompliancePart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_CompliancePart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_CompliancePart_1:
					// emit syntax tree node associated with production
					// MC-CompliancePart: MC-Compliances

					s += m_MC_Compliances.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MC_CompliancePart_2:
					// emit syntax tree node associated with production
					// MC-CompliancePart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-CompliancePart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-CompliancePart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_CompliancePart.production_kind kind = (MC_CompliancePart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_CompliancePart.production_kind.g_MC_CompliancePart_1:
					// traverse syntax tree node associated with production
					// MC-CompliancePart: MC-Compliances

						m_MC_Compliances.Visit (visitor, appData);
				break;
				case MC_CompliancePart.production_kind.g_MC_CompliancePart_2:
					// traverse syntax tree node associated with production
					// MC-CompliancePart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_MC_Compliances?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MC-CompliancePart
		//

		public void _init ()
		{
			m_MC_Compliances = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-CompliancePart

		// counter of all nodes associated with syntax rule MC-CompliancePart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-CompliancePart
		[DataMember (Name = "m_MC_Compliances")] public MC_Compliances m_MC_Compliances { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-CompliancePart

		// delegate function (callback) prototype associated with syntax rule MC-CompliancePart
		public delegate bool MC_CompliancePart_Callback (SyntaxTreeCallbackReason reason, MC_CompliancePart.production_kind kind, MC_CompliancePart p_MC_CompliancePart);

		// event associated with syntax rule MC-CompliancePart
		public event MC_CompliancePart_Callback MC_CompliancePart_Event;

		// event trigger associated with syntax rule MC-CompliancePart
		public bool Raise_MC_CompliancePart_Event (SyntaxTreeCallbackReason reason, MC_CompliancePart.production_kind kind, MC_CompliancePart p_MC_CompliancePart)
		{
			bool? status = MC_CompliancePart_Event?.Invoke (reason, kind, p_MC_CompliancePart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-CompliancePart
		//
		// traverse syntax tree node associated with any production of syntax rule MC-CompliancePart
		//

		public void Traverse (MC_CompliancePart p_MC_CompliancePart)
		{
			if (p_MC_CompliancePart.isLocked())
				return;
			p_MC_CompliancePart.dolock();
			MC_CompliancePart.production_kind kind = (MC_CompliancePart.production_kind) p_MC_CompliancePart.kind;
			p_MC_CompliancePart.turn_reset ();
			if (Raise_MC_CompliancePart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_CompliancePart))
			switch (kind)
			{
				case MC_CompliancePart.production_kind.g_MC_CompliancePart_1:
					// traverse syntax tree node associated with production
					// MC-CompliancePart: MC-Compliances

					if (Raise_MC_CompliancePart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_CompliancePart))
						Traverse (p_MC_CompliancePart.m_MC_Compliances);
					p_MC_CompliancePart.turn_inc ();
					Raise_MC_CompliancePart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_CompliancePart);
				break;
				case MC_CompliancePart.production_kind.g_MC_CompliancePart_2:
					// traverse syntax tree node associated with production
					// MC-CompliancePart: %empty

				break;
			}
			Raise_MC_CompliancePart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_CompliancePart);
			p_MC_CompliancePart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-CompliancePart
		//

		public void TraverseCommon (MC_CompliancePart p_MC_CompliancePart)
		{
			MC_CompliancePart.production_kind kind = (MC_CompliancePart.production_kind) p_MC_CompliancePart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_CompliancePart))
			switch (kind)
			{
				case MC_CompliancePart.production_kind.g_MC_CompliancePart_1:
					// traverse syntax tree node associated with production
					// MC-CompliancePart: MC-Compliances

						TraverseCommon (p_MC_CompliancePart.m_MC_Compliances);
				break;
				case MC_CompliancePart.production_kind.g_MC_CompliancePart_2:
					// traverse syntax tree node associated with production
					// MC-CompliancePart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_CompliancePart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-CompliancePart

		//
		// create syntax tree node associated with production
		// MC-CompliancePart: MC-Compliances

		//

		public MC_CompliancePart MC_CompliancePart_1 (MC_Compliances p_MC_Compliances)
		{
			MC_CompliancePart p_MC_CompliancePart_ref = new MC_CompliancePart(p_MC_Compliances);
			p_MC_Compliances.parent = p_MC_CompliancePart_ref;
			Raise_MC_CompliancePart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_CompliancePart.production_kind.g_MC_CompliancePart_1, p_MC_CompliancePart_ref);
			return p_MC_CompliancePart_ref;
		}

		//
		// create syntax tree node associated with production
		// MC-CompliancePart: %empty

		//

		public MC_CompliancePart MC_CompliancePart_2 ()
		{
			MC_CompliancePart p_MC_CompliancePart_ref = new MC_CompliancePart();
			Raise_MC_CompliancePart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_CompliancePart.production_kind.g_MC_CompliancePart_2, p_MC_CompliancePart_ref);
			return p_MC_CompliancePart_ref;
		}
		#endregion
	};
}
