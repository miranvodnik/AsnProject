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
	// class associated with syntax rule typereference-token
	//

	[DataContract]
	public class	typereference_token : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule typereference-token
		public enum production_kind : ushort	// enumerated production(s) of syntax rule typereference-token
		{
			g_typereference_token_1 = 1,	// typereference

		};
		#endregion
		#region production markers associated with the syntax rule typereference-token

		// markers associated with production: typereference-token -> typereference

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule typereference-token

		// Constructor declaration(s) associated with production(s) of syntax rule typereference-token

		//
		// Constructor associated with the following production(s)
		// typereference-token -> typereference

		//

		public typereference_token (SyntaxTreeToken p_token) : base ((uint) ProductionID._typereference_token_ID, (uint) production_kind.g_typereference_token_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_typereference = p_token;
		}

		public typereference_token () { }

		// Copy constructor

		public typereference_token (typereference_token p_typereference_token) : base (p_typereference_token.id, p_typereference_token.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_typereference_token.appInfo;
			switch ((production_kind) p_typereference_token.kind)
			{
				case production_kind.g_typereference_token_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_typereference = (p_typereference_token.m_typereference != null) ? new SyntaxTreeToken (p_typereference_token.m_typereference) : null) != null) m_typereference.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "typereference_token" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new typereference_token (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_typereference?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule typereference-token

		// Content changing function(s) associated with production(s) of syntax rule typereference-token

		//
		// Content changing function associated with following production(s)
		// typereference-token -> typereference

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_typereference_token_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_typereference = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule typereference-token
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_typereference != null) && m_typereference.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule typereference-token

		//
		// emit production tree node associated with any production of syntax rule typereference-token
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_typereference_token_1:
					// emit syntax tree node associated with production
					// typereference-token: typereference

					s += m_typereference.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule typereference-token
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "typereference_token (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_typereference_token_1:
					// emit syntax tree node associated with production
					// typereference-token: typereference

					s += "typereference";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule typereference-token

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule typereference-token with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			typereference_token.production_kind kind = (typereference_token.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case typereference_token.production_kind.g_typereference_token_1:
					// traverse syntax tree node associated with production
					// typereference-token: typereference

						m_typereference.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_typereference?.reparent (this);
		}

		//
		// initialize object associated with syntax rule typereference-token
		//

		public void _init ()
		{
			m_typereference = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule typereference-token

		// counter of all nodes associated with syntax rule typereference-token
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule typereference-token
		[DataMember (Name = "m_typereference")] public SyntaxTreeToken m_typereference { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule typereference-token

		// delegate function (callback) prototype associated with syntax rule typereference-token
		public delegate bool typereference_token_Callback (SyntaxTreeCallbackReason reason, typereference_token.production_kind kind, typereference_token p_typereference_token);

		// event associated with syntax rule typereference-token
		public event typereference_token_Callback typereference_token_Event;

		// event trigger associated with syntax rule typereference-token
		public bool Raise_typereference_token_Event (SyntaxTreeCallbackReason reason, typereference_token.production_kind kind, typereference_token p_typereference_token)
		{
			bool? status = typereference_token_Event?.Invoke (reason, kind, p_typereference_token);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule typereference-token
		//
		// traverse syntax tree node associated with any production of syntax rule typereference-token
		//

		public void Traverse (typereference_token p_typereference_token)
		{
			if (p_typereference_token.isLocked())
				return;
			p_typereference_token.dolock();
			typereference_token.production_kind kind = (typereference_token.production_kind) p_typereference_token.kind;
			p_typereference_token.turn_reset ();
			if (Raise_typereference_token_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_typereference_token))
			switch (kind)
			{
				case typereference_token.production_kind.g_typereference_token_1:
					// traverse syntax tree node associated with production
					// typereference-token: typereference

				break;
			}
			Raise_typereference_token_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_typereference_token);
			p_typereference_token.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule typereference-token
		//

		public void TraverseCommon (typereference_token p_typereference_token)
		{
			typereference_token.production_kind kind = (typereference_token.production_kind) p_typereference_token.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_typereference_token))
			switch (kind)
			{
				case typereference_token.production_kind.g_typereference_token_1:
					// traverse syntax tree node associated with production
					// typereference-token: typereference

						TraverseCommon (p_typereference_token.m_typereference);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_typereference_token);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule typereference-token

		//
		// create syntax tree node associated with production
		// typereference-token: typereference

		//

		public typereference_token typereference_token_1 (SyntaxTreeToken p_token)
		{
			typereference_token p_typereference_token_ref = new typereference_token(p_token);
			p_token.parent = p_typereference_token_ref;
			Raise_typereference_token_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, typereference_token.production_kind.g_typereference_token_1, p_typereference_token_ref);
			return p_typereference_token_ref;
		}
		#endregion
	};
}
