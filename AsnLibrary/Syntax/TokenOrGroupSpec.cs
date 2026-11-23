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
	// class associated with syntax rule TokenOrGroupSpec
	//

	[DataContract]
	public class	TokenOrGroupSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TokenOrGroupSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TokenOrGroupSpec
		{
			g_TokenOrGroupSpec_1 = 1,	// RequiredToken

			g_TokenOrGroupSpec_2 = 2,	// OptionalGroup

		};
		#endregion
		#region production markers associated with the syntax rule TokenOrGroupSpec

		// markers associated with production: TokenOrGroupSpec -> RequiredToken

		public enum production_marker_1 : ushort
		{
			m_RequiredToken,
			final
		};

		// markers associated with production: TokenOrGroupSpec -> OptionalGroup

		public enum production_marker_2 : ushort
		{
			m_OptionalGroup,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TokenOrGroupSpec

		// Constructor declaration(s) associated with production(s) of syntax rule TokenOrGroupSpec

		//
		// Constructor associated with the following production(s)
		// TokenOrGroupSpec -> RequiredToken

		//

		public TokenOrGroupSpec (RequiredToken p_RequiredToken) : base ((uint) ProductionID._TokenOrGroupSpec_ID, (uint) production_kind.g_TokenOrGroupSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RequiredToken = p_RequiredToken;
		}

		//
		// Constructor associated with the following production(s)
		// TokenOrGroupSpec -> OptionalGroup

		//

		public TokenOrGroupSpec (OptionalGroup p_OptionalGroup) : base ((uint) ProductionID._TokenOrGroupSpec_ID, (uint) production_kind.g_TokenOrGroupSpec_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OptionalGroup = p_OptionalGroup;
		}

		public TokenOrGroupSpec () { }

		// Copy constructor

		public TokenOrGroupSpec (TokenOrGroupSpec p_TokenOrGroupSpec) : base (p_TokenOrGroupSpec.id, p_TokenOrGroupSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TokenOrGroupSpec.appInfo;
			switch ((production_kind) p_TokenOrGroupSpec.kind)
			{
				case production_kind.g_TokenOrGroupSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RequiredToken = (p_TokenOrGroupSpec.m_RequiredToken != null) ? new RequiredToken (p_TokenOrGroupSpec.m_RequiredToken) : null) != null) m_RequiredToken.parent = this;
					break;
				case production_kind.g_TokenOrGroupSpec_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OptionalGroup = (p_TokenOrGroupSpec.m_OptionalGroup != null) ? new OptionalGroup (p_TokenOrGroupSpec.m_OptionalGroup) : null) != null) m_OptionalGroup.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TokenOrGroupSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TokenOrGroupSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_RequiredToken?.Dispose ();
			m_OptionalGroup?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TokenOrGroupSpec

		// Content changing function(s) associated with production(s) of syntax rule TokenOrGroupSpec

		//
		// Content changing function associated with following production(s)
		// TokenOrGroupSpec -> RequiredToken

		//

		public void change(RequiredToken p_RequiredToken)
		{
			_init ();
			this.kind = (uint) production_kind.g_TokenOrGroupSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RequiredToken = p_RequiredToken;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TokenOrGroupSpec -> OptionalGroup

		//

		public void change(OptionalGroup p_OptionalGroup)
		{
			_init ();
			this.kind = (uint) production_kind.g_TokenOrGroupSpec_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OptionalGroup = p_OptionalGroup;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TokenOrGroupSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_RequiredToken != null) && m_RequiredToken.checkInclusion (element) ||
				(m_OptionalGroup != null) && m_OptionalGroup.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TokenOrGroupSpec

		//
		// emit production tree node associated with any production of syntax rule TokenOrGroupSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TokenOrGroupSpec_1:
					// emit syntax tree node associated with production
					// TokenOrGroupSpec: RequiredToken

					s += m_RequiredToken.Emit (depth - 1);
				break;
				case production_kind.g_TokenOrGroupSpec_2:
					// emit syntax tree node associated with production
					// TokenOrGroupSpec: OptionalGroup

					s += m_OptionalGroup.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TokenOrGroupSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TokenOrGroupSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TokenOrGroupSpec_1:
					// emit syntax tree node associated with production
					// TokenOrGroupSpec: RequiredToken

					s += m_RequiredToken.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TokenOrGroupSpec_2:
					// emit syntax tree node associated with production
					// TokenOrGroupSpec: OptionalGroup

					s += m_OptionalGroup.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TokenOrGroupSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TokenOrGroupSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TokenOrGroupSpec.production_kind kind = (TokenOrGroupSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TokenOrGroupSpec.production_kind.g_TokenOrGroupSpec_1:
					// traverse syntax tree node associated with production
					// TokenOrGroupSpec: RequiredToken

						m_RequiredToken.Visit (visitor, appData);
				break;
				case TokenOrGroupSpec.production_kind.g_TokenOrGroupSpec_2:
					// traverse syntax tree node associated with production
					// TokenOrGroupSpec: OptionalGroup

						m_OptionalGroup.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_RequiredToken?.reparent (this);
			m_OptionalGroup?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TokenOrGroupSpec
		//

		public void _init ()
		{
			m_RequiredToken = null;
			m_OptionalGroup = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TokenOrGroupSpec

		// counter of all nodes associated with syntax rule TokenOrGroupSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TokenOrGroupSpec
		[DataMember (Name = "m_RequiredToken")] public RequiredToken m_RequiredToken { get; private set; }
		[DataMember (Name = "m_OptionalGroup")] public OptionalGroup m_OptionalGroup { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TokenOrGroupSpec

		// delegate function (callback) prototype associated with syntax rule TokenOrGroupSpec
		public delegate bool TokenOrGroupSpec_Callback (SyntaxTreeCallbackReason reason, TokenOrGroupSpec.production_kind kind, TokenOrGroupSpec p_TokenOrGroupSpec);

		// event associated with syntax rule TokenOrGroupSpec
		public event TokenOrGroupSpec_Callback TokenOrGroupSpec_Event;

		// event trigger associated with syntax rule TokenOrGroupSpec
		public bool Raise_TokenOrGroupSpec_Event (SyntaxTreeCallbackReason reason, TokenOrGroupSpec.production_kind kind, TokenOrGroupSpec p_TokenOrGroupSpec)
		{
			bool? status = TokenOrGroupSpec_Event?.Invoke (reason, kind, p_TokenOrGroupSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TokenOrGroupSpec
		//
		// traverse syntax tree node associated with any production of syntax rule TokenOrGroupSpec
		//

		public void Traverse (TokenOrGroupSpec p_TokenOrGroupSpec)
		{
			if (p_TokenOrGroupSpec.isLocked())
				return;
			p_TokenOrGroupSpec.dolock();
			TokenOrGroupSpec.production_kind kind = (TokenOrGroupSpec.production_kind) p_TokenOrGroupSpec.kind;
			p_TokenOrGroupSpec.turn_reset ();
			if (Raise_TokenOrGroupSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TokenOrGroupSpec))
			switch (kind)
			{
				case TokenOrGroupSpec.production_kind.g_TokenOrGroupSpec_1:
					// traverse syntax tree node associated with production
					// TokenOrGroupSpec: RequiredToken

					if (Raise_TokenOrGroupSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TokenOrGroupSpec))
						Traverse (p_TokenOrGroupSpec.m_RequiredToken);
					p_TokenOrGroupSpec.turn_inc ();
					Raise_TokenOrGroupSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TokenOrGroupSpec);
				break;
				case TokenOrGroupSpec.production_kind.g_TokenOrGroupSpec_2:
					// traverse syntax tree node associated with production
					// TokenOrGroupSpec: OptionalGroup

					if (Raise_TokenOrGroupSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TokenOrGroupSpec))
						Traverse (p_TokenOrGroupSpec.m_OptionalGroup);
					p_TokenOrGroupSpec.turn_inc ();
					Raise_TokenOrGroupSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TokenOrGroupSpec);
				break;
			}
			Raise_TokenOrGroupSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TokenOrGroupSpec);
			p_TokenOrGroupSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TokenOrGroupSpec
		//

		public void TraverseCommon (TokenOrGroupSpec p_TokenOrGroupSpec)
		{
			TokenOrGroupSpec.production_kind kind = (TokenOrGroupSpec.production_kind) p_TokenOrGroupSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TokenOrGroupSpec))
			switch (kind)
			{
				case TokenOrGroupSpec.production_kind.g_TokenOrGroupSpec_1:
					// traverse syntax tree node associated with production
					// TokenOrGroupSpec: RequiredToken

						TraverseCommon (p_TokenOrGroupSpec.m_RequiredToken);
				break;
				case TokenOrGroupSpec.production_kind.g_TokenOrGroupSpec_2:
					// traverse syntax tree node associated with production
					// TokenOrGroupSpec: OptionalGroup

						TraverseCommon (p_TokenOrGroupSpec.m_OptionalGroup);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TokenOrGroupSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TokenOrGroupSpec

		//
		// create syntax tree node associated with production
		// TokenOrGroupSpec: RequiredToken

		//

		public TokenOrGroupSpec TokenOrGroupSpec_1 (RequiredToken p_RequiredToken)
		{
			TokenOrGroupSpec p_TokenOrGroupSpec_ref = new TokenOrGroupSpec(p_RequiredToken);
			p_RequiredToken.parent = p_TokenOrGroupSpec_ref;
			Raise_TokenOrGroupSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TokenOrGroupSpec.production_kind.g_TokenOrGroupSpec_1, p_TokenOrGroupSpec_ref);
			return p_TokenOrGroupSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// TokenOrGroupSpec: OptionalGroup

		//

		public TokenOrGroupSpec TokenOrGroupSpec_2 (OptionalGroup p_OptionalGroup)
		{
			TokenOrGroupSpec p_TokenOrGroupSpec_ref = new TokenOrGroupSpec(p_OptionalGroup);
			p_OptionalGroup.parent = p_TokenOrGroupSpec_ref;
			Raise_TokenOrGroupSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TokenOrGroupSpec.production_kind.g_TokenOrGroupSpec_2, p_TokenOrGroupSpec_ref);
			return p_TokenOrGroupSpec_ref;
		}
		#endregion
	};
}
