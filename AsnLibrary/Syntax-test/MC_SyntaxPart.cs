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
	// class associated with syntax rule MC-SyntaxPart
	//

	[DataContract]
	public class	MC_SyntaxPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-SyntaxPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-SyntaxPart
		{
			g_MC_SyntaxPart_1 = 1,	// SYNTAX MC-Syntax

			g_MC_SyntaxPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule MC-SyntaxPart

		// markers associated with production: MC-SyntaxPart -> SYNTAX MC-Syntax

		public enum production_marker_1 : ushort
		{
			m_MC_Syntax,
			final
		};

		// markers associated with production: MC-SyntaxPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-SyntaxPart

		// Constructor declaration(s) associated with production(s) of syntax rule MC-SyntaxPart

		//
		// Constructor associated with the following production(s)
		// MC-SyntaxPart -> SYNTAX MC-Syntax

		//

		public MC_SyntaxPart (SyntaxTreeToken p_token, MC_Syntax p_MC_Syntax) : base ((uint) ProductionID._MC_SyntaxPart_ID, (uint) production_kind.g_MC_SyntaxPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_SYNTAX = p_token;
			children[1] = m_MC_Syntax = p_MC_Syntax;
		}

		//
		// Constructor associated with the following production(s)
		// MC-SyntaxPart -> %empty

		//

		public MC_SyntaxPart () : base ((uint) ProductionID._MC_SyntaxPart_ID, (uint) production_kind.g_MC_SyntaxPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public MC_SyntaxPart (MC_SyntaxPart p_MC_SyntaxPart) : base (p_MC_SyntaxPart.id, p_MC_SyntaxPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_SyntaxPart.appInfo;
			switch ((production_kind) p_MC_SyntaxPart.kind)
			{
				case production_kind.g_MC_SyntaxPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_SYNTAX = (p_MC_SyntaxPart.m_SYNTAX != null) ? new SyntaxTreeToken (p_MC_SyntaxPart.m_SYNTAX) : null) != null) m_SYNTAX.parent = this;
					if ((children [1] = m_MC_Syntax = (p_MC_SyntaxPart.m_MC_Syntax != null) ? new MC_Syntax (p_MC_SyntaxPart.m_MC_Syntax) : null) != null) m_MC_Syntax.parent = this;
					break;
				case production_kind.g_MC_SyntaxPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "MC_SyntaxPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_SyntaxPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SYNTAX?.Dispose ();
			m_MC_Syntax?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-SyntaxPart

		// Content changing function(s) associated with production(s) of syntax rule MC-SyntaxPart

		//
		// Content changing function associated with following production(s)
		// MC-SyntaxPart -> SYNTAX MC-Syntax

		//

		public void change(SyntaxTreeToken p_token, MC_Syntax p_MC_Syntax)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_SyntaxPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_SYNTAX = p_token;
			children [1] = m_MC_Syntax = p_MC_Syntax;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MC-SyntaxPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_SyntaxPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-SyntaxPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SYNTAX != null) && m_SYNTAX.checkInclusion (element) ||
				(m_MC_Syntax != null) && m_MC_Syntax.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-SyntaxPart

		//
		// emit production tree node associated with any production of syntax rule MC-SyntaxPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_SyntaxPart_1:
					// emit syntax tree node associated with production
					// MC-SyntaxPart: SYNTAX MC-Syntax

					s += m_SYNTAX.Emit (depth - 1);
					s += " ";
					s += m_MC_Syntax.Emit (depth - 1);
				break;
				case production_kind.g_MC_SyntaxPart_2:
					// emit syntax tree node associated with production
					// MC-SyntaxPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-SyntaxPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_SyntaxPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_SyntaxPart_1:
					// emit syntax tree node associated with production
					// MC-SyntaxPart: SYNTAX MC-Syntax

					s += "SYNTAX";
					s += ' ';
					s += m_MC_Syntax.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MC_SyntaxPart_2:
					// emit syntax tree node associated with production
					// MC-SyntaxPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-SyntaxPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-SyntaxPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_SyntaxPart.production_kind kind = (MC_SyntaxPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_SyntaxPart.production_kind.g_MC_SyntaxPart_1:
					// traverse syntax tree node associated with production
					// MC-SyntaxPart: SYNTAX MC-Syntax

						m_SYNTAX.Visit (visitor, appData);
						m_MC_Syntax.Visit (visitor, appData);
				break;
				case MC_SyntaxPart.production_kind.g_MC_SyntaxPart_2:
					// traverse syntax tree node associated with production
					// MC-SyntaxPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SYNTAX?.reparent (this);
			m_MC_Syntax?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MC-SyntaxPart
		//

		public void _init ()
		{
			m_SYNTAX = null;
			m_MC_Syntax = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-SyntaxPart

		// counter of all nodes associated with syntax rule MC-SyntaxPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-SyntaxPart
		[DataMember (Name = "m_SYNTAX")] public SyntaxTreeToken m_SYNTAX { get; private set; }
		[DataMember (Name = "m_MC_Syntax")] public MC_Syntax m_MC_Syntax { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-SyntaxPart

		// delegate function (callback) prototype associated with syntax rule MC-SyntaxPart
		public delegate bool MC_SyntaxPart_Callback (SyntaxTreeCallbackReason reason, MC_SyntaxPart.production_kind kind, MC_SyntaxPart p_MC_SyntaxPart);

		// event associated with syntax rule MC-SyntaxPart
		public event MC_SyntaxPart_Callback MC_SyntaxPart_Event;

		// event trigger associated with syntax rule MC-SyntaxPart
		public bool Raise_MC_SyntaxPart_Event (SyntaxTreeCallbackReason reason, MC_SyntaxPart.production_kind kind, MC_SyntaxPart p_MC_SyntaxPart)
		{
			bool? status = MC_SyntaxPart_Event?.Invoke (reason, kind, p_MC_SyntaxPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-SyntaxPart
		//
		// traverse syntax tree node associated with any production of syntax rule MC-SyntaxPart
		//

		public void Traverse (MC_SyntaxPart p_MC_SyntaxPart)
		{
			if (p_MC_SyntaxPart.isLocked())
				return;
			p_MC_SyntaxPart.dolock();
			MC_SyntaxPart.production_kind kind = (MC_SyntaxPart.production_kind) p_MC_SyntaxPart.kind;
			p_MC_SyntaxPart.turn_reset ();
			if (Raise_MC_SyntaxPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_SyntaxPart))
			switch (kind)
			{
				case MC_SyntaxPart.production_kind.g_MC_SyntaxPart_1:
					// traverse syntax tree node associated with production
					// MC-SyntaxPart: SYNTAX MC-Syntax

					if (Raise_MC_SyntaxPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_SyntaxPart))
						Traverse (p_MC_SyntaxPart.m_MC_Syntax);
					p_MC_SyntaxPart.turn_inc ();
					Raise_MC_SyntaxPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_SyntaxPart);
				break;
				case MC_SyntaxPart.production_kind.g_MC_SyntaxPart_2:
					// traverse syntax tree node associated with production
					// MC-SyntaxPart: %empty

				break;
			}
			Raise_MC_SyntaxPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_SyntaxPart);
			p_MC_SyntaxPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-SyntaxPart
		//

		public void TraverseCommon (MC_SyntaxPart p_MC_SyntaxPart)
		{
			MC_SyntaxPart.production_kind kind = (MC_SyntaxPart.production_kind) p_MC_SyntaxPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_SyntaxPart))
			switch (kind)
			{
				case MC_SyntaxPart.production_kind.g_MC_SyntaxPart_1:
					// traverse syntax tree node associated with production
					// MC-SyntaxPart: SYNTAX MC-Syntax

						TraverseCommon (p_MC_SyntaxPart.m_SYNTAX);
						TraverseCommon (p_MC_SyntaxPart.m_MC_Syntax);
				break;
				case MC_SyntaxPart.production_kind.g_MC_SyntaxPart_2:
					// traverse syntax tree node associated with production
					// MC-SyntaxPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_SyntaxPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-SyntaxPart

		//
		// create syntax tree node associated with production
		// MC-SyntaxPart: SYNTAX MC-Syntax

		//

		public MC_SyntaxPart MC_SyntaxPart_1 (SyntaxTreeToken p_token, MC_Syntax p_MC_Syntax)
		{
			MC_SyntaxPart p_MC_SyntaxPart_ref = new MC_SyntaxPart(p_token, p_MC_Syntax);
			p_token.parent = p_MC_SyntaxPart_ref;
			p_MC_Syntax.parent = p_MC_SyntaxPart_ref;
			Raise_MC_SyntaxPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_SyntaxPart.production_kind.g_MC_SyntaxPart_1, p_MC_SyntaxPart_ref);
			return p_MC_SyntaxPart_ref;
		}

		//
		// create syntax tree node associated with production
		// MC-SyntaxPart: %empty

		//

		public MC_SyntaxPart MC_SyntaxPart_2 ()
		{
			MC_SyntaxPart p_MC_SyntaxPart_ref = new MC_SyntaxPart();
			Raise_MC_SyntaxPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_SyntaxPart.production_kind.g_MC_SyntaxPart_2, p_MC_SyntaxPart_ref);
			return p_MC_SyntaxPart_ref;
		}
		#endregion
	};
}
