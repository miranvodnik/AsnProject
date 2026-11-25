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
	// class associated with syntax rule identifier-token
	//

	[DataContract]
	public class	identifier_token : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule identifier-token
		public enum production_kind : ushort	// enumerated production(s) of syntax rule identifier-token
		{
			g_identifier_token_1 = 1,	// identifier

		};
		#endregion
		#region production markers associated with the syntax rule identifier-token

		// markers associated with production: identifier-token -> identifier

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule identifier-token

		// Constructor declaration(s) associated with production(s) of syntax rule identifier-token

		//
		// Constructor associated with the following production(s)
		// identifier-token -> identifier

		//

		public identifier_token (SyntaxTreeToken p_token) : base ((uint) ProductionID._identifier_token_ID, (uint) production_kind.g_identifier_token_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier = p_token;
		}

		public identifier_token () { }

		// Copy constructor

		public identifier_token (identifier_token p_identifier_token) : base (p_identifier_token.id, p_identifier_token.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_identifier_token.appInfo;
			switch ((production_kind) p_identifier_token.kind)
			{
				case production_kind.g_identifier_token_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier = (p_identifier_token.m_identifier != null) ? new SyntaxTreeToken (p_identifier_token.m_identifier) : null) != null) m_identifier.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "identifier_token" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new identifier_token (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule identifier-token

		// Content changing function(s) associated with production(s) of syntax rule identifier-token

		//
		// Content changing function associated with following production(s)
		// identifier-token -> identifier

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_identifier_token_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule identifier-token
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier != null) && m_identifier.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule identifier-token

		//
		// emit production tree node associated with any production of syntax rule identifier-token
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_identifier_token_1:
					// emit syntax tree node associated with production
					// identifier-token: identifier

					s += m_identifier.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule identifier-token
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "identifier_token (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_identifier_token_1:
					// emit syntax tree node associated with production
					// identifier-token: identifier

					s += "identifier";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule identifier-token

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule identifier-token with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			identifier_token.production_kind kind = (identifier_token.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case identifier_token.production_kind.g_identifier_token_1:
					// traverse syntax tree node associated with production
					// identifier-token: identifier

						m_identifier.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier?.reparent (this);
		}

		//
		// initialize object associated with syntax rule identifier-token
		//

		public void _init ()
		{
			m_identifier = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule identifier-token

		// counter of all nodes associated with syntax rule identifier-token
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule identifier-token
		[DataMember (Name = "m_identifier")] public SyntaxTreeToken m_identifier { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule identifier-token

		// delegate function (callback) prototype associated with syntax rule identifier-token
		public delegate bool identifier_token_Callback (SyntaxTreeCallbackReason reason, identifier_token.production_kind kind, identifier_token p_identifier_token);

		// event associated with syntax rule identifier-token
		public event identifier_token_Callback identifier_token_Event;

		// event trigger associated with syntax rule identifier-token
		public bool Raise_identifier_token_Event (SyntaxTreeCallbackReason reason, identifier_token.production_kind kind, identifier_token p_identifier_token)
		{
			bool? status = identifier_token_Event?.Invoke (reason, kind, p_identifier_token);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule identifier-token
		//
		// traverse syntax tree node associated with any production of syntax rule identifier-token
		//

		public void Traverse (identifier_token p_identifier_token)
		{
			if (p_identifier_token.isLocked())
				return;
			p_identifier_token.dolock();
			identifier_token.production_kind kind = (identifier_token.production_kind) p_identifier_token.kind;
			p_identifier_token.turn_reset ();
			if (Raise_identifier_token_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_identifier_token))
			switch (kind)
			{
				case identifier_token.production_kind.g_identifier_token_1:
					// traverse syntax tree node associated with production
					// identifier-token: identifier

				break;
			}
			Raise_identifier_token_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_identifier_token);
			p_identifier_token.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule identifier-token
		//

		public void TraverseCommon (identifier_token p_identifier_token)
		{
			identifier_token.production_kind kind = (identifier_token.production_kind) p_identifier_token.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_identifier_token))
			switch (kind)
			{
				case identifier_token.production_kind.g_identifier_token_1:
					// traverse syntax tree node associated with production
					// identifier-token: identifier

						TraverseCommon (p_identifier_token.m_identifier);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_identifier_token);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule identifier-token

		//
		// create syntax tree node associated with production
		// identifier-token: identifier

		//

		public identifier_token identifier_token_1 (SyntaxTreeToken p_token)
		{
			identifier_token p_identifier_token_ref = new identifier_token(p_token);
			p_token.parent = p_identifier_token_ref;
			Raise_identifier_token_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, identifier_token.production_kind.g_identifier_token_1, p_identifier_token_ref);
			return p_identifier_token_ref;
		}
		#endregion
	};
}
