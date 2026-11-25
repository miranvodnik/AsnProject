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
	// class associated with syntax rule NT-Status
	//

	[DataContract]
	public class	NT_Status : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NT-Status
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NT-Status
		{
			g_NT_Status_1 = 1,	// identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule NT-Status

		// markers associated with production: NT-Status -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NT-Status

		// Constructor declaration(s) associated with production(s) of syntax rule NT-Status

		//
		// Constructor associated with the following production(s)
		// NT-Status -> identifier-token

		//

		public NT_Status (identifier_token p_identifier_token) : base ((uint) ProductionID._NT_Status_ID, (uint) production_kind.g_NT_Status_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		public NT_Status () { }

		// Copy constructor

		public NT_Status (NT_Status p_NT_Status) : base (p_NT_Status.id, p_NT_Status.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NT_Status.appInfo;
			switch ((production_kind) p_NT_Status.kind)
			{
				case production_kind.g_NT_Status_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_NT_Status.m_identifier_token != null) ? new identifier_token (p_NT_Status.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NT_Status" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NT_Status (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NT-Status

		// Content changing function(s) associated with production(s) of syntax rule NT-Status

		//
		// Content changing function associated with following production(s)
		// NT-Status -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_NT_Status_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NT-Status
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NT-Status

		//
		// emit production tree node associated with any production of syntax rule NT-Status
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NT_Status_1:
					// emit syntax tree node associated with production
					// NT-Status: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NT-Status
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NT_Status (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NT_Status_1:
					// emit syntax tree node associated with production
					// NT-Status: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NT-Status

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NT-Status with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NT_Status.production_kind kind = (NT_Status.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NT_Status.production_kind.g_NT_Status_1:
					// traverse syntax tree node associated with production
					// NT-Status: identifier-token

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
		// initialize object associated with syntax rule NT-Status
		//

		public void _init ()
		{
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NT-Status

		// counter of all nodes associated with syntax rule NT-Status
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NT-Status
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NT-Status

		// delegate function (callback) prototype associated with syntax rule NT-Status
		public delegate bool NT_Status_Callback (SyntaxTreeCallbackReason reason, NT_Status.production_kind kind, NT_Status p_NT_Status);

		// event associated with syntax rule NT-Status
		public event NT_Status_Callback NT_Status_Event;

		// event trigger associated with syntax rule NT-Status
		public bool Raise_NT_Status_Event (SyntaxTreeCallbackReason reason, NT_Status.production_kind kind, NT_Status p_NT_Status)
		{
			bool? status = NT_Status_Event?.Invoke (reason, kind, p_NT_Status);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NT-Status
		//
		// traverse syntax tree node associated with any production of syntax rule NT-Status
		//

		public void Traverse (NT_Status p_NT_Status)
		{
			if (p_NT_Status.isLocked())
				return;
			p_NT_Status.dolock();
			NT_Status.production_kind kind = (NT_Status.production_kind) p_NT_Status.kind;
			p_NT_Status.turn_reset ();
			if (Raise_NT_Status_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NT_Status))
			switch (kind)
			{
				case NT_Status.production_kind.g_NT_Status_1:
					// traverse syntax tree node associated with production
					// NT-Status: identifier-token

					if (Raise_NT_Status_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NT_Status))
						Traverse (p_NT_Status.m_identifier_token);
					p_NT_Status.turn_inc ();
					Raise_NT_Status_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NT_Status);
				break;
			}
			Raise_NT_Status_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NT_Status);
			p_NT_Status.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NT-Status
		//

		public void TraverseCommon (NT_Status p_NT_Status)
		{
			NT_Status.production_kind kind = (NT_Status.production_kind) p_NT_Status.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NT_Status))
			switch (kind)
			{
				case NT_Status.production_kind.g_NT_Status_1:
					// traverse syntax tree node associated with production
					// NT-Status: identifier-token

						TraverseCommon (p_NT_Status.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NT_Status);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NT-Status

		//
		// create syntax tree node associated with production
		// NT-Status: identifier-token

		//

		public NT_Status NT_Status_1 (identifier_token p_identifier_token)
		{
			NT_Status p_NT_Status_ref = new NT_Status(p_identifier_token);
			p_identifier_token.parent = p_NT_Status_ref;
			Raise_NT_Status_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NT_Status.production_kind.g_NT_Status_1, p_NT_Status_ref);
			return p_NT_Status_ref;
		}
		#endregion
	};
}
