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
	// class associated with syntax rule TC-Status
	//

	[DataContract]
	public class	TC_Status : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TC-Status
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TC-Status
		{
			g_TC_Status_1 = 1,	// identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule TC-Status

		// markers associated with production: TC-Status -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TC-Status

		// Constructor declaration(s) associated with production(s) of syntax rule TC-Status

		//
		// Constructor associated with the following production(s)
		// TC-Status -> identifier-token

		//

		public TC_Status (identifier_token p_identifier_token) : base ((uint) ProductionID._TC_Status_ID, (uint) production_kind.g_TC_Status_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		public TC_Status () { }

		// Copy constructor

		public TC_Status (TC_Status p_TC_Status) : base (p_TC_Status.id, p_TC_Status.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TC_Status.appInfo;
			switch ((production_kind) p_TC_Status.kind)
			{
				case production_kind.g_TC_Status_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_TC_Status.m_identifier_token != null) ? new identifier_token (p_TC_Status.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TC_Status" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TC_Status (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TC-Status

		// Content changing function(s) associated with production(s) of syntax rule TC-Status

		//
		// Content changing function associated with following production(s)
		// TC-Status -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_TC_Status_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TC-Status
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TC-Status

		//
		// emit production tree node associated with any production of syntax rule TC-Status
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TC_Status_1:
					// emit syntax tree node associated with production
					// TC-Status: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TC-Status
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TC_Status (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TC_Status_1:
					// emit syntax tree node associated with production
					// TC-Status: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TC-Status

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TC-Status with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TC_Status.production_kind kind = (TC_Status.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TC_Status.production_kind.g_TC_Status_1:
					// traverse syntax tree node associated with production
					// TC-Status: identifier-token

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
		// initialize object associated with syntax rule TC-Status
		//

		public void _init ()
		{
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TC-Status

		// counter of all nodes associated with syntax rule TC-Status
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TC-Status
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TC-Status

		// delegate function (callback) prototype associated with syntax rule TC-Status
		public delegate bool TC_Status_Callback (SyntaxTreeCallbackReason reason, TC_Status.production_kind kind, TC_Status p_TC_Status);

		// event associated with syntax rule TC-Status
		public event TC_Status_Callback TC_Status_Event;

		// event trigger associated with syntax rule TC-Status
		public bool Raise_TC_Status_Event (SyntaxTreeCallbackReason reason, TC_Status.production_kind kind, TC_Status p_TC_Status)
		{
			bool? status = TC_Status_Event?.Invoke (reason, kind, p_TC_Status);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TC-Status
		//
		// traverse syntax tree node associated with any production of syntax rule TC-Status
		//

		public void Traverse (TC_Status p_TC_Status)
		{
			if (p_TC_Status.isLocked())
				return;
			p_TC_Status.dolock();
			TC_Status.production_kind kind = (TC_Status.production_kind) p_TC_Status.kind;
			p_TC_Status.turn_reset ();
			if (Raise_TC_Status_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TC_Status))
			switch (kind)
			{
				case TC_Status.production_kind.g_TC_Status_1:
					// traverse syntax tree node associated with production
					// TC-Status: identifier-token

					if (Raise_TC_Status_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TC_Status))
						Traverse (p_TC_Status.m_identifier_token);
					p_TC_Status.turn_inc ();
					Raise_TC_Status_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TC_Status);
				break;
			}
			Raise_TC_Status_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TC_Status);
			p_TC_Status.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TC-Status
		//

		public void TraverseCommon (TC_Status p_TC_Status)
		{
			TC_Status.production_kind kind = (TC_Status.production_kind) p_TC_Status.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TC_Status))
			switch (kind)
			{
				case TC_Status.production_kind.g_TC_Status_1:
					// traverse syntax tree node associated with production
					// TC-Status: identifier-token

						TraverseCommon (p_TC_Status.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TC_Status);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TC-Status

		//
		// create syntax tree node associated with production
		// TC-Status: identifier-token

		//

		public TC_Status TC_Status_1 (identifier_token p_identifier_token)
		{
			TC_Status p_TC_Status_ref = new TC_Status(p_identifier_token);
			p_identifier_token.parent = p_TC_Status_ref;
			Raise_TC_Status_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TC_Status.production_kind.g_TC_Status_1, p_TC_Status_ref);
			return p_TC_Status_ref;
		}
		#endregion
	};
}
