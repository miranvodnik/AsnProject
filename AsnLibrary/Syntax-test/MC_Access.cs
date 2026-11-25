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
	// class associated with syntax rule MC-Access
	//

	[DataContract]
	public class	MC_Access : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-Access
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-Access
		{
			g_MC_Access_1 = 1,	// identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule MC-Access

		// markers associated with production: MC-Access -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-Access

		// Constructor declaration(s) associated with production(s) of syntax rule MC-Access

		//
		// Constructor associated with the following production(s)
		// MC-Access -> identifier-token

		//

		public MC_Access (identifier_token p_identifier_token) : base ((uint) ProductionID._MC_Access_ID, (uint) production_kind.g_MC_Access_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		public MC_Access () { }

		// Copy constructor

		public MC_Access (MC_Access p_MC_Access) : base (p_MC_Access.id, p_MC_Access.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_Access.appInfo;
			switch ((production_kind) p_MC_Access.kind)
			{
				case production_kind.g_MC_Access_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_MC_Access.m_identifier_token != null) ? new identifier_token (p_MC_Access.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MC_Access" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_Access (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-Access

		// Content changing function(s) associated with production(s) of syntax rule MC-Access

		//
		// Content changing function associated with following production(s)
		// MC-Access -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Access_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-Access
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-Access

		//
		// emit production tree node associated with any production of syntax rule MC-Access
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_Access_1:
					// emit syntax tree node associated with production
					// MC-Access: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-Access
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_Access (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_Access_1:
					// emit syntax tree node associated with production
					// MC-Access: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-Access

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Access with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_Access.production_kind kind = (MC_Access.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_Access.production_kind.g_MC_Access_1:
					// traverse syntax tree node associated with production
					// MC-Access: identifier-token

						m_identifier_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MC-Access
		//

		public void _init ()
		{
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-Access

		// counter of all nodes associated with syntax rule MC-Access
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-Access
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-Access

		// delegate function (callback) prototype associated with syntax rule MC-Access
		public delegate bool MC_Access_Callback (SyntaxTreeCallbackReason reason, MC_Access.production_kind kind, MC_Access p_MC_Access);

		// event associated with syntax rule MC-Access
		public event MC_Access_Callback MC_Access_Event;

		// event trigger associated with syntax rule MC-Access
		public bool Raise_MC_Access_Event (SyntaxTreeCallbackReason reason, MC_Access.production_kind kind, MC_Access p_MC_Access)
		{
			bool? status = MC_Access_Event?.Invoke (reason, kind, p_MC_Access);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-Access
		//
		// traverse syntax tree node associated with any production of syntax rule MC-Access
		//

		public void Traverse (MC_Access p_MC_Access)
		{
			if (p_MC_Access.isLocked())
				return;
			p_MC_Access.dolock();
			MC_Access.production_kind kind = (MC_Access.production_kind) p_MC_Access.kind;
			p_MC_Access.turn_reset ();
			if (Raise_MC_Access_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_Access))
			switch (kind)
			{
				case MC_Access.production_kind.g_MC_Access_1:
					// traverse syntax tree node associated with production
					// MC-Access: identifier-token

					if (Raise_MC_Access_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Access))
						Traverse (p_MC_Access.m_identifier_token);
					p_MC_Access.turn_inc ();
					Raise_MC_Access_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Access);
				break;
			}
			Raise_MC_Access_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_Access);
			p_MC_Access.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Access
		//

		public void TraverseCommon (MC_Access p_MC_Access)
		{
			MC_Access.production_kind kind = (MC_Access.production_kind) p_MC_Access.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_Access))
			switch (kind)
			{
				case MC_Access.production_kind.g_MC_Access_1:
					// traverse syntax tree node associated with production
					// MC-Access: identifier-token

						TraverseCommon (p_MC_Access.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_Access);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-Access

		//
		// create syntax tree node associated with production
		// MC-Access: identifier-token

		//

		public MC_Access MC_Access_1 (identifier_token p_identifier_token)
		{
			MC_Access p_MC_Access_ref = new MC_Access(p_identifier_token);
			p_identifier_token.parent = p_MC_Access_ref;
			Raise_MC_Access_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Access.production_kind.g_MC_Access_1, p_MC_Access_ref);
			return p_MC_Access_ref;
		}
		#endregion
	};
}
