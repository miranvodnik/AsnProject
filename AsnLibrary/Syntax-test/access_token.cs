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
	// class associated with syntax rule access-token
	//

	[DataContract]
	public class	access_token : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule access-token
		public enum production_kind : ushort	// enumerated production(s) of syntax rule access-token
		{
			g_access_token_1 = 1,	// MAX-ACCESS

			g_access_token_2 = 2,	// ACCESS

		};
		#endregion
		#region production markers associated with the syntax rule access-token

		// markers associated with production: access-token -> MAX-ACCESS

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: access-token -> ACCESS

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule access-token

		// Constructor declaration(s) associated with production(s) of syntax rule access-token

		//
		// Constructor associated with the following production(s)
		// access-token -> MAX-ACCESS

		// access-token -> ACCESS

		//

		public access_token (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._access_token_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_access_token_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_MAX_ACCESS = p_token;
				break;
			case production_kind.g_access_token_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ACCESS = p_token;
				break;
			default:
				{
					string[] args = new string[] { "access_token" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public access_token () { }

		// Copy constructor

		public access_token (access_token p_access_token) : base (p_access_token.id, p_access_token.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_access_token.appInfo;
			switch ((production_kind) p_access_token.kind)
			{
				case production_kind.g_access_token_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MAX_ACCESS = (p_access_token.m_MAX_ACCESS != null) ? new SyntaxTreeToken (p_access_token.m_MAX_ACCESS) : null) != null) m_MAX_ACCESS.parent = this;
					break;
				case production_kind.g_access_token_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ACCESS = (p_access_token.m_ACCESS != null) ? new SyntaxTreeToken (p_access_token.m_ACCESS) : null) != null) m_ACCESS.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "access_token" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new access_token (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_MAX_ACCESS?.Dispose ();
			m_ACCESS?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule access-token

		// Content changing function(s) associated with production(s) of syntax rule access-token

		//
		// Content changing function associated with following production(s)
		// access-token -> MAX-ACCESS

		// access-token -> ACCESS

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_access_token_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_MAX_ACCESS = p_token;
				break;
			case production_kind.g_access_token_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ACCESS = p_token;
				break;
			default:
				{
					string[] args = new string[] { "access_token" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule access-token
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_MAX_ACCESS != null) && m_MAX_ACCESS.checkInclusion (element) ||
				(m_ACCESS != null) && m_ACCESS.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule access-token

		//
		// emit production tree node associated with any production of syntax rule access-token
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_access_token_1:
					// emit syntax tree node associated with production
					// access-token: MAX-ACCESS

					s += m_MAX_ACCESS.Emit (depth - 1);
				break;
				case production_kind.g_access_token_2:
					// emit syntax tree node associated with production
					// access-token: ACCESS

					s += m_ACCESS.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule access-token
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "access_token (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_access_token_1:
					// emit syntax tree node associated with production
					// access-token: MAX-ACCESS

					s += "MAX_ACCESS";
				break;
				case production_kind.g_access_token_2:
					// emit syntax tree node associated with production
					// access-token: ACCESS

					s += "ACCESS";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule access-token

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule access-token with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			access_token.production_kind kind = (access_token.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case access_token.production_kind.g_access_token_1:
					// traverse syntax tree node associated with production
					// access-token: MAX-ACCESS

						m_MAX_ACCESS.Visit (visitor, appData);
				break;
				case access_token.production_kind.g_access_token_2:
					// traverse syntax tree node associated with production
					// access-token: ACCESS

						m_ACCESS.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_MAX_ACCESS?.reparent (this);
			m_ACCESS?.reparent (this);
		}

		//
		// initialize object associated with syntax rule access-token
		//

		public void _init ()
		{
			m_MAX_ACCESS = null;
			m_ACCESS = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule access-token

		// counter of all nodes associated with syntax rule access-token
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule access-token
		[DataMember (Name = "m_MAX_ACCESS")] public SyntaxTreeToken m_MAX_ACCESS { get; private set; }
		[DataMember (Name = "m_ACCESS")] public SyntaxTreeToken m_ACCESS { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule access-token

		// delegate function (callback) prototype associated with syntax rule access-token
		public delegate bool access_token_Callback (SyntaxTreeCallbackReason reason, access_token.production_kind kind, access_token p_access_token);

		// event associated with syntax rule access-token
		public event access_token_Callback access_token_Event;

		// event trigger associated with syntax rule access-token
		public bool Raise_access_token_Event (SyntaxTreeCallbackReason reason, access_token.production_kind kind, access_token p_access_token)
		{
			bool? status = access_token_Event?.Invoke (reason, kind, p_access_token);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule access-token
		//
		// traverse syntax tree node associated with any production of syntax rule access-token
		//

		public void Traverse (access_token p_access_token)
		{
			if (p_access_token.isLocked())
				return;
			p_access_token.dolock();
			access_token.production_kind kind = (access_token.production_kind) p_access_token.kind;
			p_access_token.turn_reset ();
			if (Raise_access_token_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_access_token))
			switch (kind)
			{
				case access_token.production_kind.g_access_token_1:
					// traverse syntax tree node associated with production
					// access-token: MAX-ACCESS

				break;
				case access_token.production_kind.g_access_token_2:
					// traverse syntax tree node associated with production
					// access-token: ACCESS

				break;
			}
			Raise_access_token_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_access_token);
			p_access_token.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule access-token
		//

		public void TraverseCommon (access_token p_access_token)
		{
			access_token.production_kind kind = (access_token.production_kind) p_access_token.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_access_token))
			switch (kind)
			{
				case access_token.production_kind.g_access_token_1:
					// traverse syntax tree node associated with production
					// access-token: MAX-ACCESS

						TraverseCommon (p_access_token.m_MAX_ACCESS);
				break;
				case access_token.production_kind.g_access_token_2:
					// traverse syntax tree node associated with production
					// access-token: ACCESS

						TraverseCommon (p_access_token.m_ACCESS);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_access_token);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule access-token

		//
		// create syntax tree node associated with production
		// access-token: MAX-ACCESS

		//

		public access_token access_token_1 (SyntaxTreeToken p_token)
		{
			access_token p_access_token_ref = new access_token(p_token, 1);
			p_token.parent = p_access_token_ref;
			Raise_access_token_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, access_token.production_kind.g_access_token_1, p_access_token_ref);
			return p_access_token_ref;
		}

		//
		// create syntax tree node associated with production
		// access-token: ACCESS

		//

		public access_token access_token_2 (SyntaxTreeToken p_token)
		{
			access_token p_access_token_ref = new access_token(p_token, 2);
			p_token.parent = p_access_token_ref;
			Raise_access_token_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, access_token.production_kind.g_access_token_2, p_access_token_ref);
			return p_access_token_ref;
		}
		#endregion
	};
}
