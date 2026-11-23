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
	// class associated with syntax rule MC-WriteSyntaxPart
	//

	[DataContract]
	public class	MC_WriteSyntaxPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-WriteSyntaxPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-WriteSyntaxPart
		{
			g_MC_WriteSyntaxPart_1 = 1,	// WRITE-SYNTAX MC-Syntax

			g_MC_WriteSyntaxPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule MC-WriteSyntaxPart

		// markers associated with production: MC-WriteSyntaxPart -> WRITE-SYNTAX MC-Syntax

		public enum production_marker_1 : ushort
		{
			m_MC_Syntax,
			final
		};

		// markers associated with production: MC-WriteSyntaxPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-WriteSyntaxPart

		// Constructor declaration(s) associated with production(s) of syntax rule MC-WriteSyntaxPart

		//
		// Constructor associated with the following production(s)
		// MC-WriteSyntaxPart -> WRITE-SYNTAX MC-Syntax

		//

		public MC_WriteSyntaxPart (SyntaxTreeToken p_token, MC_Syntax p_MC_Syntax) : base ((uint) ProductionID._MC_WriteSyntaxPart_ID, (uint) production_kind.g_MC_WriteSyntaxPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_WRITE_SYNTAX = p_token;
			children[1] = m_MC_Syntax = p_MC_Syntax;
		}

		//
		// Constructor associated with the following production(s)
		// MC-WriteSyntaxPart -> %empty

		//

		public MC_WriteSyntaxPart () : base ((uint) ProductionID._MC_WriteSyntaxPart_ID, (uint) production_kind.g_MC_WriteSyntaxPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public MC_WriteSyntaxPart (MC_WriteSyntaxPart p_MC_WriteSyntaxPart) : base (p_MC_WriteSyntaxPart.id, p_MC_WriteSyntaxPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_WriteSyntaxPart.appInfo;
			switch ((production_kind) p_MC_WriteSyntaxPart.kind)
			{
				case production_kind.g_MC_WriteSyntaxPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_WRITE_SYNTAX = (p_MC_WriteSyntaxPart.m_WRITE_SYNTAX != null) ? new SyntaxTreeToken (p_MC_WriteSyntaxPart.m_WRITE_SYNTAX) : null) != null) m_WRITE_SYNTAX.parent = this;
					if ((children [1] = m_MC_Syntax = (p_MC_WriteSyntaxPart.m_MC_Syntax != null) ? new MC_Syntax (p_MC_WriteSyntaxPart.m_MC_Syntax) : null) != null) m_MC_Syntax.parent = this;
					break;
				case production_kind.g_MC_WriteSyntaxPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "MC_WriteSyntaxPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_WriteSyntaxPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_WRITE_SYNTAX?.Dispose ();
			m_MC_Syntax?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-WriteSyntaxPart

		// Content changing function(s) associated with production(s) of syntax rule MC-WriteSyntaxPart

		//
		// Content changing function associated with following production(s)
		// MC-WriteSyntaxPart -> WRITE-SYNTAX MC-Syntax

		//

		public void change(SyntaxTreeToken p_token, MC_Syntax p_MC_Syntax)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_WriteSyntaxPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_WRITE_SYNTAX = p_token;
			children [1] = m_MC_Syntax = p_MC_Syntax;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MC-WriteSyntaxPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_WriteSyntaxPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-WriteSyntaxPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_WRITE_SYNTAX != null) && m_WRITE_SYNTAX.checkInclusion (element) ||
				(m_MC_Syntax != null) && m_MC_Syntax.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-WriteSyntaxPart

		//
		// emit production tree node associated with any production of syntax rule MC-WriteSyntaxPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_WriteSyntaxPart_1:
					// emit syntax tree node associated with production
					// MC-WriteSyntaxPart: WRITE-SYNTAX MC-Syntax

					s += m_WRITE_SYNTAX.Emit (depth - 1);
					s += " ";
					s += m_MC_Syntax.Emit (depth - 1);
				break;
				case production_kind.g_MC_WriteSyntaxPart_2:
					// emit syntax tree node associated with production
					// MC-WriteSyntaxPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-WriteSyntaxPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_WriteSyntaxPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_WriteSyntaxPart_1:
					// emit syntax tree node associated with production
					// MC-WriteSyntaxPart: WRITE-SYNTAX MC-Syntax

					s += "WRITE_SYNTAX";
					s += ' ';
					s += m_MC_Syntax.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MC_WriteSyntaxPart_2:
					// emit syntax tree node associated with production
					// MC-WriteSyntaxPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-WriteSyntaxPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-WriteSyntaxPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_WriteSyntaxPart.production_kind kind = (MC_WriteSyntaxPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_WriteSyntaxPart.production_kind.g_MC_WriteSyntaxPart_1:
					// traverse syntax tree node associated with production
					// MC-WriteSyntaxPart: WRITE-SYNTAX MC-Syntax

						m_WRITE_SYNTAX.Visit (visitor, appData);
						m_MC_Syntax.Visit (visitor, appData);
				break;
				case MC_WriteSyntaxPart.production_kind.g_MC_WriteSyntaxPart_2:
					// traverse syntax tree node associated with production
					// MC-WriteSyntaxPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_WRITE_SYNTAX?.reparent (this);
			m_MC_Syntax?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MC-WriteSyntaxPart
		//

		public void _init ()
		{
			m_WRITE_SYNTAX = null;
			m_MC_Syntax = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-WriteSyntaxPart

		// counter of all nodes associated with syntax rule MC-WriteSyntaxPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-WriteSyntaxPart
		[DataMember (Name = "m_WRITE_SYNTAX")] public SyntaxTreeToken m_WRITE_SYNTAX { get; private set; }
		[DataMember (Name = "m_MC_Syntax")] public MC_Syntax m_MC_Syntax { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-WriteSyntaxPart

		// delegate function (callback) prototype associated with syntax rule MC-WriteSyntaxPart
		public delegate bool MC_WriteSyntaxPart_Callback (SyntaxTreeCallbackReason reason, MC_WriteSyntaxPart.production_kind kind, MC_WriteSyntaxPart p_MC_WriteSyntaxPart);

		// event associated with syntax rule MC-WriteSyntaxPart
		public event MC_WriteSyntaxPart_Callback MC_WriteSyntaxPart_Event;

		// event trigger associated with syntax rule MC-WriteSyntaxPart
		public bool Raise_MC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason reason, MC_WriteSyntaxPart.production_kind kind, MC_WriteSyntaxPart p_MC_WriteSyntaxPart)
		{
			bool? status = MC_WriteSyntaxPart_Event?.Invoke (reason, kind, p_MC_WriteSyntaxPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-WriteSyntaxPart
		//
		// traverse syntax tree node associated with any production of syntax rule MC-WriteSyntaxPart
		//

		public void Traverse (MC_WriteSyntaxPart p_MC_WriteSyntaxPart)
		{
			if (p_MC_WriteSyntaxPart.isLocked())
				return;
			p_MC_WriteSyntaxPart.dolock();
			MC_WriteSyntaxPart.production_kind kind = (MC_WriteSyntaxPart.production_kind) p_MC_WriteSyntaxPart.kind;
			p_MC_WriteSyntaxPart.turn_reset ();
			if (Raise_MC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_WriteSyntaxPart))
			switch (kind)
			{
				case MC_WriteSyntaxPart.production_kind.g_MC_WriteSyntaxPart_1:
					// traverse syntax tree node associated with production
					// MC-WriteSyntaxPart: WRITE-SYNTAX MC-Syntax

					if (Raise_MC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_WriteSyntaxPart))
						Traverse (p_MC_WriteSyntaxPart.m_MC_Syntax);
					p_MC_WriteSyntaxPart.turn_inc ();
					Raise_MC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_WriteSyntaxPart);
				break;
				case MC_WriteSyntaxPart.production_kind.g_MC_WriteSyntaxPart_2:
					// traverse syntax tree node associated with production
					// MC-WriteSyntaxPart: %empty

				break;
			}
			Raise_MC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_WriteSyntaxPart);
			p_MC_WriteSyntaxPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-WriteSyntaxPart
		//

		public void TraverseCommon (MC_WriteSyntaxPart p_MC_WriteSyntaxPart)
		{
			MC_WriteSyntaxPart.production_kind kind = (MC_WriteSyntaxPart.production_kind) p_MC_WriteSyntaxPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_WriteSyntaxPart))
			switch (kind)
			{
				case MC_WriteSyntaxPart.production_kind.g_MC_WriteSyntaxPart_1:
					// traverse syntax tree node associated with production
					// MC-WriteSyntaxPart: WRITE-SYNTAX MC-Syntax

						TraverseCommon (p_MC_WriteSyntaxPart.m_WRITE_SYNTAX);
						TraverseCommon (p_MC_WriteSyntaxPart.m_MC_Syntax);
				break;
				case MC_WriteSyntaxPart.production_kind.g_MC_WriteSyntaxPart_2:
					// traverse syntax tree node associated with production
					// MC-WriteSyntaxPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_WriteSyntaxPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-WriteSyntaxPart

		//
		// create syntax tree node associated with production
		// MC-WriteSyntaxPart: WRITE-SYNTAX MC-Syntax

		//

		public MC_WriteSyntaxPart MC_WriteSyntaxPart_1 (SyntaxTreeToken p_token, MC_Syntax p_MC_Syntax)
		{
			MC_WriteSyntaxPart p_MC_WriteSyntaxPart_ref = new MC_WriteSyntaxPart(p_token, p_MC_Syntax);
			p_token.parent = p_MC_WriteSyntaxPart_ref;
			p_MC_Syntax.parent = p_MC_WriteSyntaxPart_ref;
			Raise_MC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_WriteSyntaxPart.production_kind.g_MC_WriteSyntaxPart_1, p_MC_WriteSyntaxPart_ref);
			return p_MC_WriteSyntaxPart_ref;
		}

		//
		// create syntax tree node associated with production
		// MC-WriteSyntaxPart: %empty

		//

		public MC_WriteSyntaxPart MC_WriteSyntaxPart_2 ()
		{
			MC_WriteSyntaxPart p_MC_WriteSyntaxPart_ref = new MC_WriteSyntaxPart();
			Raise_MC_WriteSyntaxPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_WriteSyntaxPart.production_kind.g_MC_WriteSyntaxPart_2, p_MC_WriteSyntaxPart_ref);
			return p_MC_WriteSyntaxPart_ref;
		}
		#endregion
	};
}
