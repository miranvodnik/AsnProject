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
	// class associated with syntax rule valuefieldreference-token
	//

	[DataContract]
	public class	valuefieldreference_token : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule valuefieldreference-token
		public enum production_kind : ushort	// enumerated production(s) of syntax rule valuefieldreference-token
		{
			g_valuefieldreference_token_1 = 1,	// "&" identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule valuefieldreference-token

		// markers associated with production: valuefieldreference-token -> "&" identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule valuefieldreference-token

		// Constructor declaration(s) associated with production(s) of syntax rule valuefieldreference-token

		//
		// Constructor associated with the following production(s)
		// valuefieldreference-token -> "&" identifier-token

		//

		public valuefieldreference_token (SyntaxTreeToken p_token, identifier_token p_identifier_token) : base ((uint) ProductionID._valuefieldreference_token_ID, (uint) production_kind.g_valuefieldreference_token_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ampersand = p_token;
			children[1] = m_identifier_token = p_identifier_token;
		}

		public valuefieldreference_token () { }

		// Copy constructor

		public valuefieldreference_token (valuefieldreference_token p_valuefieldreference_token) : base (p_valuefieldreference_token.id, p_valuefieldreference_token.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_valuefieldreference_token.appInfo;
			switch ((production_kind) p_valuefieldreference_token.kind)
			{
				case production_kind.g_valuefieldreference_token_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ampersand = (p_valuefieldreference_token.m_ampersand != null) ? new SyntaxTreeToken (p_valuefieldreference_token.m_ampersand) : null) != null) m_ampersand.parent = this;
					if ((children [1] = m_identifier_token = (p_valuefieldreference_token.m_identifier_token != null) ? new identifier_token (p_valuefieldreference_token.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "valuefieldreference_token" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new valuefieldreference_token (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ampersand?.Dispose ();
			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule valuefieldreference-token

		// Content changing function(s) associated with production(s) of syntax rule valuefieldreference-token

		//
		// Content changing function associated with following production(s)
		// valuefieldreference-token -> "&" identifier-token

		//

		public void change(SyntaxTreeToken p_token, identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_valuefieldreference_token_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ampersand = p_token;
			children [1] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule valuefieldreference-token
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ampersand != null) && m_ampersand.checkInclusion (element) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule valuefieldreference-token

		//
		// emit production tree node associated with any production of syntax rule valuefieldreference-token
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_valuefieldreference_token_1:
					// emit syntax tree node associated with production
					// valuefieldreference-token: "&" identifier-token

					s += m_ampersand.Emit (depth - 1);
					s += " ";
					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule valuefieldreference-token
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "valuefieldreference_token (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_valuefieldreference_token_1:
					// emit syntax tree node associated with production
					// valuefieldreference-token: "&" identifier-token

					s += "ampersand";
					s += ' ';
					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule valuefieldreference-token

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule valuefieldreference-token with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			valuefieldreference_token.production_kind kind = (valuefieldreference_token.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case valuefieldreference_token.production_kind.g_valuefieldreference_token_1:
					// traverse syntax tree node associated with production
					// valuefieldreference-token: "&" identifier-token

						m_ampersand.Visit (visitor, appData);
						m_identifier_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ampersand?.reparent (this);
			m_identifier_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule valuefieldreference-token
		//

		public void _init ()
		{
			m_ampersand = null;
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule valuefieldreference-token

		// counter of all nodes associated with syntax rule valuefieldreference-token
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule valuefieldreference-token
		[DataMember (Name = "m_ampersand")] public SyntaxTreeToken m_ampersand { get; private set; }
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule valuefieldreference-token

		// delegate function (callback) prototype associated with syntax rule valuefieldreference-token
		public delegate bool valuefieldreference_token_Callback (SyntaxTreeCallbackReason reason, valuefieldreference_token.production_kind kind, valuefieldreference_token p_valuefieldreference_token);

		// event associated with syntax rule valuefieldreference-token
		public event valuefieldreference_token_Callback valuefieldreference_token_Event;

		// event trigger associated with syntax rule valuefieldreference-token
		public bool Raise_valuefieldreference_token_Event (SyntaxTreeCallbackReason reason, valuefieldreference_token.production_kind kind, valuefieldreference_token p_valuefieldreference_token)
		{
			bool? status = valuefieldreference_token_Event?.Invoke (reason, kind, p_valuefieldreference_token);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule valuefieldreference-token
		//
		// traverse syntax tree node associated with any production of syntax rule valuefieldreference-token
		//

		public void Traverse (valuefieldreference_token p_valuefieldreference_token)
		{
			if (p_valuefieldreference_token.isLocked())
				return;
			p_valuefieldreference_token.dolock();
			valuefieldreference_token.production_kind kind = (valuefieldreference_token.production_kind) p_valuefieldreference_token.kind;
			p_valuefieldreference_token.turn_reset ();
			if (Raise_valuefieldreference_token_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_valuefieldreference_token))
			switch (kind)
			{
				case valuefieldreference_token.production_kind.g_valuefieldreference_token_1:
					// traverse syntax tree node associated with production
					// valuefieldreference-token: "&" identifier-token

					if (Raise_valuefieldreference_token_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_valuefieldreference_token))
						Traverse (p_valuefieldreference_token.m_identifier_token);
					p_valuefieldreference_token.turn_inc ();
					Raise_valuefieldreference_token_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_valuefieldreference_token);
				break;
			}
			Raise_valuefieldreference_token_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_valuefieldreference_token);
			p_valuefieldreference_token.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule valuefieldreference-token
		//

		public void TraverseCommon (valuefieldreference_token p_valuefieldreference_token)
		{
			valuefieldreference_token.production_kind kind = (valuefieldreference_token.production_kind) p_valuefieldreference_token.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_valuefieldreference_token))
			switch (kind)
			{
				case valuefieldreference_token.production_kind.g_valuefieldreference_token_1:
					// traverse syntax tree node associated with production
					// valuefieldreference-token: "&" identifier-token

						TraverseCommon (p_valuefieldreference_token.m_ampersand);
						TraverseCommon (p_valuefieldreference_token.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_valuefieldreference_token);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule valuefieldreference-token

		//
		// create syntax tree node associated with production
		// valuefieldreference-token: "&" identifier-token

		//

		public valuefieldreference_token valuefieldreference_token_1 (SyntaxTreeToken p_token, identifier_token p_identifier_token)
		{
			valuefieldreference_token p_valuefieldreference_token_ref = new valuefieldreference_token(p_token, p_identifier_token);
			p_token.parent = p_valuefieldreference_token_ref;
			p_identifier_token.parent = p_valuefieldreference_token_ref;
			Raise_valuefieldreference_token_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, valuefieldreference_token.production_kind.g_valuefieldreference_token_1, p_valuefieldreference_token_ref);
			return p_valuefieldreference_token_ref;
		}
		#endregion
	};
}
