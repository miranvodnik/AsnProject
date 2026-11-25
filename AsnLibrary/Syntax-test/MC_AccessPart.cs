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
	// class associated with syntax rule MC-AccessPart
	//

	[DataContract]
	public class	MC_AccessPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-AccessPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-AccessPart
		{
			g_MC_AccessPart_1 = 1,	// MIN-ACCESS MC-Access

			g_MC_AccessPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule MC-AccessPart

		// markers associated with production: MC-AccessPart -> MIN-ACCESS MC-Access

		public enum production_marker_1 : ushort
		{
			m_MC_Access,
			final
		};

		// markers associated with production: MC-AccessPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-AccessPart

		// Constructor declaration(s) associated with production(s) of syntax rule MC-AccessPart

		//
		// Constructor associated with the following production(s)
		// MC-AccessPart -> MIN-ACCESS MC-Access

		//

		public MC_AccessPart (SyntaxTreeToken p_token, MC_Access p_MC_Access) : base ((uint) ProductionID._MC_AccessPart_ID, (uint) production_kind.g_MC_AccessPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_MIN_ACCESS = p_token;
			children[1] = m_MC_Access = p_MC_Access;
		}

		//
		// Constructor associated with the following production(s)
		// MC-AccessPart -> %empty

		//

		public MC_AccessPart () : base ((uint) ProductionID._MC_AccessPart_ID, (uint) production_kind.g_MC_AccessPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public MC_AccessPart (MC_AccessPart p_MC_AccessPart) : base (p_MC_AccessPart.id, p_MC_AccessPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_AccessPart.appInfo;
			switch ((production_kind) p_MC_AccessPart.kind)
			{
				case production_kind.g_MC_AccessPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_MIN_ACCESS = (p_MC_AccessPart.m_MIN_ACCESS != null) ? new SyntaxTreeToken (p_MC_AccessPart.m_MIN_ACCESS) : null) != null) m_MIN_ACCESS.parent = this;
					if ((children [1] = m_MC_Access = (p_MC_AccessPart.m_MC_Access != null) ? new MC_Access (p_MC_AccessPart.m_MC_Access) : null) != null) m_MC_Access.parent = this;
					break;
				case production_kind.g_MC_AccessPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "MC_AccessPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_AccessPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_MIN_ACCESS?.Dispose ();
			m_MC_Access?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-AccessPart

		// Content changing function(s) associated with production(s) of syntax rule MC-AccessPart

		//
		// Content changing function associated with following production(s)
		// MC-AccessPart -> MIN-ACCESS MC-Access

		//

		public void change(SyntaxTreeToken p_token, MC_Access p_MC_Access)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_AccessPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_MIN_ACCESS = p_token;
			children [1] = m_MC_Access = p_MC_Access;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MC-AccessPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_AccessPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-AccessPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_MIN_ACCESS != null) && m_MIN_ACCESS.checkInclusion (element) ||
				(m_MC_Access != null) && m_MC_Access.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-AccessPart

		//
		// emit production tree node associated with any production of syntax rule MC-AccessPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_AccessPart_1:
					// emit syntax tree node associated with production
					// MC-AccessPart: MIN-ACCESS MC-Access

					s += m_MIN_ACCESS.Emit (depth - 1);
					s += " ";
					s += m_MC_Access.Emit (depth - 1);
				break;
				case production_kind.g_MC_AccessPart_2:
					// emit syntax tree node associated with production
					// MC-AccessPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-AccessPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_AccessPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_AccessPart_1:
					// emit syntax tree node associated with production
					// MC-AccessPart: MIN-ACCESS MC-Access

					s += "MIN_ACCESS";
					s += ' ';
					s += m_MC_Access.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MC_AccessPart_2:
					// emit syntax tree node associated with production
					// MC-AccessPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-AccessPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-AccessPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_AccessPart.production_kind kind = (MC_AccessPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_AccessPart.production_kind.g_MC_AccessPart_1:
					// traverse syntax tree node associated with production
					// MC-AccessPart: MIN-ACCESS MC-Access

						m_MIN_ACCESS.Visit (visitor, appData);
						m_MC_Access.Visit (visitor, appData);
				break;
				case MC_AccessPart.production_kind.g_MC_AccessPart_2:
					// traverse syntax tree node associated with production
					// MC-AccessPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_MIN_ACCESS?.reparent (this);
			m_MC_Access?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MC-AccessPart
		//

		public void _init ()
		{
			m_MIN_ACCESS = null;
			m_MC_Access = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-AccessPart

		// counter of all nodes associated with syntax rule MC-AccessPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-AccessPart
		[DataMember (Name = "m_MIN_ACCESS")] public SyntaxTreeToken m_MIN_ACCESS { get; private set; }
		[DataMember (Name = "m_MC_Access")] public MC_Access m_MC_Access { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-AccessPart

		// delegate function (callback) prototype associated with syntax rule MC-AccessPart
		public delegate bool MC_AccessPart_Callback (SyntaxTreeCallbackReason reason, MC_AccessPart.production_kind kind, MC_AccessPart p_MC_AccessPart);

		// event associated with syntax rule MC-AccessPart
		public event MC_AccessPart_Callback MC_AccessPart_Event;

		// event trigger associated with syntax rule MC-AccessPart
		public bool Raise_MC_AccessPart_Event (SyntaxTreeCallbackReason reason, MC_AccessPart.production_kind kind, MC_AccessPart p_MC_AccessPart)
		{
			bool? status = MC_AccessPart_Event?.Invoke (reason, kind, p_MC_AccessPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-AccessPart
		//
		// traverse syntax tree node associated with any production of syntax rule MC-AccessPart
		//

		public void Traverse (MC_AccessPart p_MC_AccessPart)
		{
			if (p_MC_AccessPart.isLocked())
				return;
			p_MC_AccessPart.dolock();
			MC_AccessPart.production_kind kind = (MC_AccessPart.production_kind) p_MC_AccessPart.kind;
			p_MC_AccessPart.turn_reset ();
			if (Raise_MC_AccessPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_AccessPart))
			switch (kind)
			{
				case MC_AccessPart.production_kind.g_MC_AccessPart_1:
					// traverse syntax tree node associated with production
					// MC-AccessPart: MIN-ACCESS MC-Access

					if (Raise_MC_AccessPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_AccessPart))
						Traverse (p_MC_AccessPart.m_MC_Access);
					p_MC_AccessPart.turn_inc ();
					Raise_MC_AccessPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_AccessPart);
				break;
				case MC_AccessPart.production_kind.g_MC_AccessPart_2:
					// traverse syntax tree node associated with production
					// MC-AccessPart: %empty

				break;
			}
			Raise_MC_AccessPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_AccessPart);
			p_MC_AccessPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-AccessPart
		//

		public void TraverseCommon (MC_AccessPart p_MC_AccessPart)
		{
			MC_AccessPart.production_kind kind = (MC_AccessPart.production_kind) p_MC_AccessPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_AccessPart))
			switch (kind)
			{
				case MC_AccessPart.production_kind.g_MC_AccessPart_1:
					// traverse syntax tree node associated with production
					// MC-AccessPart: MIN-ACCESS MC-Access

						TraverseCommon (p_MC_AccessPart.m_MIN_ACCESS);
						TraverseCommon (p_MC_AccessPart.m_MC_Access);
				break;
				case MC_AccessPart.production_kind.g_MC_AccessPart_2:
					// traverse syntax tree node associated with production
					// MC-AccessPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_AccessPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-AccessPart

		//
		// create syntax tree node associated with production
		// MC-AccessPart: MIN-ACCESS MC-Access

		//

		public MC_AccessPart MC_AccessPart_1 (SyntaxTreeToken p_token, MC_Access p_MC_Access)
		{
			MC_AccessPart p_MC_AccessPart_ref = new MC_AccessPart(p_token, p_MC_Access);
			p_token.parent = p_MC_AccessPart_ref;
			p_MC_Access.parent = p_MC_AccessPart_ref;
			Raise_MC_AccessPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_AccessPart.production_kind.g_MC_AccessPart_1, p_MC_AccessPart_ref);
			return p_MC_AccessPart_ref;
		}

		//
		// create syntax tree node associated with production
		// MC-AccessPart: %empty

		//

		public MC_AccessPart MC_AccessPart_2 ()
		{
			MC_AccessPart p_MC_AccessPart_ref = new MC_AccessPart();
			Raise_MC_AccessPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_AccessPart.production_kind.g_MC_AccessPart_2, p_MC_AccessPart_ref);
			return p_MC_AccessPart_ref;
		}
		#endregion
	};
}
