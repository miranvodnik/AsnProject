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
	// class associated with syntax rule defined-identifier-token
	//

	[DataContract]
	public class	defined_identifier_token : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule defined-identifier-token
		public enum production_kind : ushort	// enumerated production(s) of syntax rule defined-identifier-token
		{
			g_defined_identifier_token_1 = 1,	// identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule defined-identifier-token

		// markers associated with production: defined-identifier-token -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule defined-identifier-token

		// Constructor declaration(s) associated with production(s) of syntax rule defined-identifier-token

		//
		// Constructor associated with the following production(s)
		// defined-identifier-token -> identifier-token

		//

		public defined_identifier_token (identifier_token p_identifier_token) : base ((uint) ProductionID._defined_identifier_token_ID, (uint) production_kind.g_defined_identifier_token_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		public defined_identifier_token () { }

		// Copy constructor

		public defined_identifier_token (defined_identifier_token p_defined_identifier_token) : base (p_defined_identifier_token.id, p_defined_identifier_token.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_defined_identifier_token.appInfo;
			switch ((production_kind) p_defined_identifier_token.kind)
			{
				case production_kind.g_defined_identifier_token_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_defined_identifier_token.m_identifier_token != null) ? new identifier_token (p_defined_identifier_token.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "defined_identifier_token" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new defined_identifier_token (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule defined-identifier-token

		// Content changing function(s) associated with production(s) of syntax rule defined-identifier-token

		//
		// Content changing function associated with following production(s)
		// defined-identifier-token -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_defined_identifier_token_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule defined-identifier-token
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule defined-identifier-token

		//
		// emit production tree node associated with any production of syntax rule defined-identifier-token
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_defined_identifier_token_1:
					// emit syntax tree node associated with production
					// defined-identifier-token: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule defined-identifier-token
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "defined_identifier_token (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_defined_identifier_token_1:
					// emit syntax tree node associated with production
					// defined-identifier-token: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule defined-identifier-token

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule defined-identifier-token with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			defined_identifier_token.production_kind kind = (defined_identifier_token.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case defined_identifier_token.production_kind.g_defined_identifier_token_1:
					// traverse syntax tree node associated with production
					// defined-identifier-token: identifier-token

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
		// initialize object associated with syntax rule defined-identifier-token
		//

		public void _init ()
		{
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule defined-identifier-token

		// counter of all nodes associated with syntax rule defined-identifier-token
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule defined-identifier-token
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule defined-identifier-token

		// delegate function (callback) prototype associated with syntax rule defined-identifier-token
		public delegate bool defined_identifier_token_Callback (SyntaxTreeCallbackReason reason, defined_identifier_token.production_kind kind, defined_identifier_token p_defined_identifier_token);

		// event associated with syntax rule defined-identifier-token
		public event defined_identifier_token_Callback defined_identifier_token_Event;

		// event trigger associated with syntax rule defined-identifier-token
		public bool Raise_defined_identifier_token_Event (SyntaxTreeCallbackReason reason, defined_identifier_token.production_kind kind, defined_identifier_token p_defined_identifier_token)
		{
			bool? status = defined_identifier_token_Event?.Invoke (reason, kind, p_defined_identifier_token);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule defined-identifier-token
		//
		// traverse syntax tree node associated with any production of syntax rule defined-identifier-token
		//

		public void Traverse (defined_identifier_token p_defined_identifier_token)
		{
			if (p_defined_identifier_token.isLocked())
				return;
			p_defined_identifier_token.dolock();
			defined_identifier_token.production_kind kind = (defined_identifier_token.production_kind) p_defined_identifier_token.kind;
			p_defined_identifier_token.turn_reset ();
			if (Raise_defined_identifier_token_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_defined_identifier_token))
			switch (kind)
			{
				case defined_identifier_token.production_kind.g_defined_identifier_token_1:
					// traverse syntax tree node associated with production
					// defined-identifier-token: identifier-token

					if (Raise_defined_identifier_token_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_defined_identifier_token))
						Traverse (p_defined_identifier_token.m_identifier_token);
					p_defined_identifier_token.turn_inc ();
					Raise_defined_identifier_token_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_defined_identifier_token);
				break;
			}
			Raise_defined_identifier_token_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_defined_identifier_token);
			p_defined_identifier_token.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule defined-identifier-token
		//

		public void TraverseCommon (defined_identifier_token p_defined_identifier_token)
		{
			defined_identifier_token.production_kind kind = (defined_identifier_token.production_kind) p_defined_identifier_token.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_defined_identifier_token))
			switch (kind)
			{
				case defined_identifier_token.production_kind.g_defined_identifier_token_1:
					// traverse syntax tree node associated with production
					// defined-identifier-token: identifier-token

						TraverseCommon (p_defined_identifier_token.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_defined_identifier_token);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule defined-identifier-token

		//
		// create syntax tree node associated with production
		// defined-identifier-token: identifier-token

		//

		public defined_identifier_token defined_identifier_token_1 (identifier_token p_identifier_token)
		{
			defined_identifier_token p_defined_identifier_token_ref = new defined_identifier_token(p_identifier_token);
			p_identifier_token.parent = p_defined_identifier_token_ref;
			Raise_defined_identifier_token_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, defined_identifier_token.production_kind.g_defined_identifier_token_1, p_defined_identifier_token_ref);
			return p_defined_identifier_token_ref;
		}
		#endregion
	};
}
