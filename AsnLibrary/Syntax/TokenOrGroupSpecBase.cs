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
	// class associated with syntax rule TokenOrGroupSpecBase
	//

	[DataContract]
	public class	TokenOrGroupSpecBase : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TokenOrGroupSpecBase
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TokenOrGroupSpecBase
		{
			g_TokenOrGroupSpecBase_1 = 1,	// TokenOrGroupSpec

			g_TokenOrGroupSpecBase_2 = 2,	// TokenOrGroupSpec ","

		};
		#endregion
		#region production markers associated with the syntax rule TokenOrGroupSpecBase

		// markers associated with production: TokenOrGroupSpecBase -> TokenOrGroupSpec

		public enum production_marker_1 : ushort
		{
			m_TokenOrGroupSpec,
			final
		};

		// markers associated with production: TokenOrGroupSpecBase -> TokenOrGroupSpec ","

		public enum production_marker_2 : ushort
		{
			m_TokenOrGroupSpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TokenOrGroupSpecBase

		// Constructor declaration(s) associated with production(s) of syntax rule TokenOrGroupSpecBase

		//
		// Constructor associated with the following production(s)
		// TokenOrGroupSpecBase -> TokenOrGroupSpec

		//

		public TokenOrGroupSpecBase (TokenOrGroupSpec p_TokenOrGroupSpec) : base ((uint) ProductionID._TokenOrGroupSpecBase_ID, (uint) production_kind.g_TokenOrGroupSpecBase_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TokenOrGroupSpec = p_TokenOrGroupSpec;
		}

		//
		// Constructor associated with the following production(s)
		// TokenOrGroupSpecBase -> TokenOrGroupSpec ","

		//

		public TokenOrGroupSpecBase (TokenOrGroupSpec p_TokenOrGroupSpec, SyntaxTreeToken p_token) : base ((uint) ProductionID._TokenOrGroupSpecBase_ID, (uint) production_kind.g_TokenOrGroupSpecBase_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_TokenOrGroupSpec = p_TokenOrGroupSpec;
			children[1] = m_comma = p_token;
		}

		public TokenOrGroupSpecBase () { }

		// Copy constructor

		public TokenOrGroupSpecBase (TokenOrGroupSpecBase p_TokenOrGroupSpecBase) : base (p_TokenOrGroupSpecBase.id, p_TokenOrGroupSpecBase.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TokenOrGroupSpecBase.appInfo;
			switch ((production_kind) p_TokenOrGroupSpecBase.kind)
			{
				case production_kind.g_TokenOrGroupSpecBase_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TokenOrGroupSpec = (p_TokenOrGroupSpecBase.m_TokenOrGroupSpec != null) ? new TokenOrGroupSpec (p_TokenOrGroupSpecBase.m_TokenOrGroupSpec) : null) != null) m_TokenOrGroupSpec.parent = this;
					break;
				case production_kind.g_TokenOrGroupSpecBase_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_TokenOrGroupSpec = (p_TokenOrGroupSpecBase.m_TokenOrGroupSpec != null) ? new TokenOrGroupSpec (p_TokenOrGroupSpecBase.m_TokenOrGroupSpec) : null) != null) m_TokenOrGroupSpec.parent = this;
					if ((children [1] = m_comma = (p_TokenOrGroupSpecBase.m_comma != null) ? new SyntaxTreeToken (p_TokenOrGroupSpecBase.m_comma) : null) != null) m_comma.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TokenOrGroupSpecBase" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TokenOrGroupSpecBase (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_TokenOrGroupSpec?.Dispose ();
			m_comma?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TokenOrGroupSpecBase

		// Content changing function(s) associated with production(s) of syntax rule TokenOrGroupSpecBase

		//
		// Content changing function associated with following production(s)
		// TokenOrGroupSpecBase -> TokenOrGroupSpec

		//

		public void change(TokenOrGroupSpec p_TokenOrGroupSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_TokenOrGroupSpecBase_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TokenOrGroupSpec = p_TokenOrGroupSpec;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TokenOrGroupSpecBase -> TokenOrGroupSpec ","

		//

		public void change(TokenOrGroupSpec p_TokenOrGroupSpec, SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_TokenOrGroupSpecBase_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_TokenOrGroupSpec = p_TokenOrGroupSpec;
			children [1] = m_comma = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TokenOrGroupSpecBase
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_TokenOrGroupSpec != null) && m_TokenOrGroupSpec.checkInclusion (element) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TokenOrGroupSpecBase

		//
		// emit production tree node associated with any production of syntax rule TokenOrGroupSpecBase
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TokenOrGroupSpecBase_1:
					// emit syntax tree node associated with production
					// TokenOrGroupSpecBase: TokenOrGroupSpec

					s += m_TokenOrGroupSpec.Emit (depth - 1);
				break;
				case production_kind.g_TokenOrGroupSpecBase_2:
					// emit syntax tree node associated with production
					// TokenOrGroupSpecBase: TokenOrGroupSpec ","

					s += m_TokenOrGroupSpec.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TokenOrGroupSpecBase
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TokenOrGroupSpecBase (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TokenOrGroupSpecBase_1:
					// emit syntax tree node associated with production
					// TokenOrGroupSpecBase: TokenOrGroupSpec

					s += m_TokenOrGroupSpec.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TokenOrGroupSpecBase_2:
					// emit syntax tree node associated with production
					// TokenOrGroupSpecBase: TokenOrGroupSpec ","

					s += m_TokenOrGroupSpec.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TokenOrGroupSpecBase

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TokenOrGroupSpecBase with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TokenOrGroupSpecBase.production_kind kind = (TokenOrGroupSpecBase.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TokenOrGroupSpecBase.production_kind.g_TokenOrGroupSpecBase_1:
					// traverse syntax tree node associated with production
					// TokenOrGroupSpecBase: TokenOrGroupSpec

						m_TokenOrGroupSpec.Visit (visitor, appData);
				break;
				case TokenOrGroupSpecBase.production_kind.g_TokenOrGroupSpecBase_2:
					// traverse syntax tree node associated with production
					// TokenOrGroupSpecBase: TokenOrGroupSpec ","

						m_TokenOrGroupSpec.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_TokenOrGroupSpec?.reparent (this);
			m_comma?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TokenOrGroupSpecBase
		//

		public void _init ()
		{
			m_TokenOrGroupSpec = null;
			m_comma = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TokenOrGroupSpecBase

		// counter of all nodes associated with syntax rule TokenOrGroupSpecBase
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TokenOrGroupSpecBase
		[DataMember (Name = "m_TokenOrGroupSpec")] public TokenOrGroupSpec m_TokenOrGroupSpec { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TokenOrGroupSpecBase

		// delegate function (callback) prototype associated with syntax rule TokenOrGroupSpecBase
		public delegate bool TokenOrGroupSpecBase_Callback (SyntaxTreeCallbackReason reason, TokenOrGroupSpecBase.production_kind kind, TokenOrGroupSpecBase p_TokenOrGroupSpecBase);

		// event associated with syntax rule TokenOrGroupSpecBase
		public event TokenOrGroupSpecBase_Callback TokenOrGroupSpecBase_Event;

		// event trigger associated with syntax rule TokenOrGroupSpecBase
		public bool Raise_TokenOrGroupSpecBase_Event (SyntaxTreeCallbackReason reason, TokenOrGroupSpecBase.production_kind kind, TokenOrGroupSpecBase p_TokenOrGroupSpecBase)
		{
			bool? status = TokenOrGroupSpecBase_Event?.Invoke (reason, kind, p_TokenOrGroupSpecBase);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TokenOrGroupSpecBase
		//
		// traverse syntax tree node associated with any production of syntax rule TokenOrGroupSpecBase
		//

		public void Traverse (TokenOrGroupSpecBase p_TokenOrGroupSpecBase)
		{
			if (p_TokenOrGroupSpecBase.isLocked())
				return;
			p_TokenOrGroupSpecBase.dolock();
			TokenOrGroupSpecBase.production_kind kind = (TokenOrGroupSpecBase.production_kind) p_TokenOrGroupSpecBase.kind;
			p_TokenOrGroupSpecBase.turn_reset ();
			if (Raise_TokenOrGroupSpecBase_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TokenOrGroupSpecBase))
			switch (kind)
			{
				case TokenOrGroupSpecBase.production_kind.g_TokenOrGroupSpecBase_1:
					// traverse syntax tree node associated with production
					// TokenOrGroupSpecBase: TokenOrGroupSpec

					if (Raise_TokenOrGroupSpecBase_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TokenOrGroupSpecBase))
						Traverse (p_TokenOrGroupSpecBase.m_TokenOrGroupSpec);
					p_TokenOrGroupSpecBase.turn_inc ();
					Raise_TokenOrGroupSpecBase_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TokenOrGroupSpecBase);
				break;
				case TokenOrGroupSpecBase.production_kind.g_TokenOrGroupSpecBase_2:
					// traverse syntax tree node associated with production
					// TokenOrGroupSpecBase: TokenOrGroupSpec ","

					if (Raise_TokenOrGroupSpecBase_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TokenOrGroupSpecBase))
						Traverse (p_TokenOrGroupSpecBase.m_TokenOrGroupSpec);
					p_TokenOrGroupSpecBase.turn_inc ();
					Raise_TokenOrGroupSpecBase_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TokenOrGroupSpecBase);
				break;
			}
			Raise_TokenOrGroupSpecBase_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TokenOrGroupSpecBase);
			p_TokenOrGroupSpecBase.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TokenOrGroupSpecBase
		//

		public void TraverseCommon (TokenOrGroupSpecBase p_TokenOrGroupSpecBase)
		{
			TokenOrGroupSpecBase.production_kind kind = (TokenOrGroupSpecBase.production_kind) p_TokenOrGroupSpecBase.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TokenOrGroupSpecBase))
			switch (kind)
			{
				case TokenOrGroupSpecBase.production_kind.g_TokenOrGroupSpecBase_1:
					// traverse syntax tree node associated with production
					// TokenOrGroupSpecBase: TokenOrGroupSpec

						TraverseCommon (p_TokenOrGroupSpecBase.m_TokenOrGroupSpec);
				break;
				case TokenOrGroupSpecBase.production_kind.g_TokenOrGroupSpecBase_2:
					// traverse syntax tree node associated with production
					// TokenOrGroupSpecBase: TokenOrGroupSpec ","

						TraverseCommon (p_TokenOrGroupSpecBase.m_TokenOrGroupSpec);
						TraverseCommon (p_TokenOrGroupSpecBase.m_comma);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TokenOrGroupSpecBase);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TokenOrGroupSpecBase

		//
		// create syntax tree node associated with production
		// TokenOrGroupSpecBase: TokenOrGroupSpec

		//

		public TokenOrGroupSpecBase TokenOrGroupSpecBase_1 (TokenOrGroupSpec p_TokenOrGroupSpec)
		{
			TokenOrGroupSpecBase p_TokenOrGroupSpecBase_ref = new TokenOrGroupSpecBase(p_TokenOrGroupSpec);
			p_TokenOrGroupSpec.parent = p_TokenOrGroupSpecBase_ref;
			Raise_TokenOrGroupSpecBase_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TokenOrGroupSpecBase.production_kind.g_TokenOrGroupSpecBase_1, p_TokenOrGroupSpecBase_ref);
			return p_TokenOrGroupSpecBase_ref;
		}

		//
		// create syntax tree node associated with production
		// TokenOrGroupSpecBase: TokenOrGroupSpec ","

		//

		public TokenOrGroupSpecBase TokenOrGroupSpecBase_2 (TokenOrGroupSpec p_TokenOrGroupSpec, SyntaxTreeToken p_token)
		{
			TokenOrGroupSpecBase p_TokenOrGroupSpecBase_ref = new TokenOrGroupSpecBase(p_TokenOrGroupSpec, p_token);
			p_TokenOrGroupSpec.parent = p_TokenOrGroupSpecBase_ref;
			p_token.parent = p_TokenOrGroupSpecBase_ref;
			Raise_TokenOrGroupSpecBase_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TokenOrGroupSpecBase.production_kind.g_TokenOrGroupSpecBase_2, p_TokenOrGroupSpecBase_ref);
			return p_TokenOrGroupSpecBase_ref;
		}
		#endregion
	};
}
