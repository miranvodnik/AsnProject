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
	// class associated with syntax rule MC-Status
	//

	[DataContract]
	public class	MC_Status : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-Status
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-Status
		{
			g_MC_Status_1 = 1,	// identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule MC-Status

		// markers associated with production: MC-Status -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-Status

		// Constructor declaration(s) associated with production(s) of syntax rule MC-Status

		//
		// Constructor associated with the following production(s)
		// MC-Status -> identifier-token

		//

		public MC_Status (identifier_token p_identifier_token) : base ((uint) ProductionID._MC_Status_ID, (uint) production_kind.g_MC_Status_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		public MC_Status () { }

		// Copy constructor

		public MC_Status (MC_Status p_MC_Status) : base (p_MC_Status.id, p_MC_Status.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_Status.appInfo;
			switch ((production_kind) p_MC_Status.kind)
			{
				case production_kind.g_MC_Status_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_MC_Status.m_identifier_token != null) ? new identifier_token (p_MC_Status.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MC_Status" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_Status (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-Status

		// Content changing function(s) associated with production(s) of syntax rule MC-Status

		//
		// Content changing function associated with following production(s)
		// MC-Status -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Status_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-Status
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-Status

		//
		// emit production tree node associated with any production of syntax rule MC-Status
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_Status_1:
					// emit syntax tree node associated with production
					// MC-Status: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-Status
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_Status (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_Status_1:
					// emit syntax tree node associated with production
					// MC-Status: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-Status

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Status with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_Status.production_kind kind = (MC_Status.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_Status.production_kind.g_MC_Status_1:
					// traverse syntax tree node associated with production
					// MC-Status: identifier-token

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
		// initialize object associated with syntax rule MC-Status
		//

		public void _init ()
		{
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-Status

		// counter of all nodes associated with syntax rule MC-Status
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-Status
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-Status

		// delegate function (callback) prototype associated with syntax rule MC-Status
		public delegate bool MC_Status_Callback (SyntaxTreeCallbackReason reason, MC_Status.production_kind kind, MC_Status p_MC_Status);

		// event associated with syntax rule MC-Status
		public event MC_Status_Callback MC_Status_Event;

		// event trigger associated with syntax rule MC-Status
		public bool Raise_MC_Status_Event (SyntaxTreeCallbackReason reason, MC_Status.production_kind kind, MC_Status p_MC_Status)
		{
			bool? status = MC_Status_Event?.Invoke (reason, kind, p_MC_Status);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-Status
		//
		// traverse syntax tree node associated with any production of syntax rule MC-Status
		//

		public void Traverse (MC_Status p_MC_Status)
		{
			if (p_MC_Status.isLocked())
				return;
			p_MC_Status.dolock();
			MC_Status.production_kind kind = (MC_Status.production_kind) p_MC_Status.kind;
			p_MC_Status.turn_reset ();
			if (Raise_MC_Status_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_Status))
			switch (kind)
			{
				case MC_Status.production_kind.g_MC_Status_1:
					// traverse syntax tree node associated with production
					// MC-Status: identifier-token

					if (Raise_MC_Status_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Status))
						Traverse (p_MC_Status.m_identifier_token);
					p_MC_Status.turn_inc ();
					Raise_MC_Status_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Status);
				break;
			}
			Raise_MC_Status_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_Status);
			p_MC_Status.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Status
		//

		public void TraverseCommon (MC_Status p_MC_Status)
		{
			MC_Status.production_kind kind = (MC_Status.production_kind) p_MC_Status.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_Status))
			switch (kind)
			{
				case MC_Status.production_kind.g_MC_Status_1:
					// traverse syntax tree node associated with production
					// MC-Status: identifier-token

						TraverseCommon (p_MC_Status.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_Status);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-Status

		//
		// create syntax tree node associated with production
		// MC-Status: identifier-token

		//

		public MC_Status MC_Status_1 (identifier_token p_identifier_token)
		{
			MC_Status p_MC_Status_ref = new MC_Status(p_identifier_token);
			p_identifier_token.parent = p_MC_Status_ref;
			Raise_MC_Status_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Status.production_kind.g_MC_Status_1, p_MC_Status_ref);
			return p_MC_Status_ref;
		}
		#endregion
	};
}
