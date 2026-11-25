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
	// class associated with syntax rule WithSyntaxSpec
	//

	[DataContract]
	public class	WithSyntaxSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule WithSyntaxSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule WithSyntaxSpec
		{
			g_WithSyntaxSpec_1 = 1,	// WITH SYNTAX SyntaxList

		};
		#endregion
		#region production markers associated with the syntax rule WithSyntaxSpec

		// markers associated with production: WithSyntaxSpec -> WITH SYNTAX SyntaxList

		public enum production_marker_1 : ushort
		{
			m_SyntaxList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule WithSyntaxSpec

		// Constructor declaration(s) associated with production(s) of syntax rule WithSyntaxSpec

		//
		// Constructor associated with the following production(s)
		// WithSyntaxSpec -> WITH SYNTAX SyntaxList

		//

		public WithSyntaxSpec (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxList p_SyntaxList) : base ((uint) ProductionID._WithSyntaxSpec_ID, (uint) production_kind.g_WithSyntaxSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_WITH = p_token;
			children[1] = m_SYNTAX = p_token_1;
			children[2] = m_SyntaxList = p_SyntaxList;
		}

		public WithSyntaxSpec () { }

		// Copy constructor

		public WithSyntaxSpec (WithSyntaxSpec p_WithSyntaxSpec) : base (p_WithSyntaxSpec.id, p_WithSyntaxSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_WithSyntaxSpec.appInfo;
			switch ((production_kind) p_WithSyntaxSpec.kind)
			{
				case production_kind.g_WithSyntaxSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_WITH = (p_WithSyntaxSpec.m_WITH != null) ? new SyntaxTreeToken (p_WithSyntaxSpec.m_WITH) : null) != null) m_WITH.parent = this;
					if ((children [1] = m_SYNTAX = (p_WithSyntaxSpec.m_SYNTAX != null) ? new SyntaxTreeToken (p_WithSyntaxSpec.m_SYNTAX) : null) != null) m_SYNTAX.parent = this;
					if ((children [2] = m_SyntaxList = (p_WithSyntaxSpec.m_SyntaxList != null) ? new SyntaxList (p_WithSyntaxSpec.m_SyntaxList) : null) != null) m_SyntaxList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "WithSyntaxSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new WithSyntaxSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_WITH?.Dispose ();
			m_SYNTAX?.Dispose ();
			m_SyntaxList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule WithSyntaxSpec

		// Content changing function(s) associated with production(s) of syntax rule WithSyntaxSpec

		//
		// Content changing function associated with following production(s)
		// WithSyntaxSpec -> WITH SYNTAX SyntaxList

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxList p_SyntaxList)
		{
			_init ();
			this.kind = (uint) production_kind.g_WithSyntaxSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_WITH = p_token;
			children [1] = m_SYNTAX = p_token_1;
			children [2] = m_SyntaxList = p_SyntaxList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule WithSyntaxSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_WITH != null) && m_WITH.checkInclusion (element) ||
				(m_SYNTAX != null) && m_SYNTAX.checkInclusion (element) ||
				(m_SyntaxList != null) && m_SyntaxList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule WithSyntaxSpec

		//
		// emit production tree node associated with any production of syntax rule WithSyntaxSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_WithSyntaxSpec_1:
					// emit syntax tree node associated with production
					// WithSyntaxSpec: WITH SYNTAX SyntaxList

					s += m_WITH.Emit (depth - 1);
					s += " ";
					s += m_SYNTAX.Emit (depth - 1);
					s += " ";
					s += m_SyntaxList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule WithSyntaxSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "WithSyntaxSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_WithSyntaxSpec_1:
					// emit syntax tree node associated with production
					// WithSyntaxSpec: WITH SYNTAX SyntaxList

					s += "WITH";
					s += ' ';
					s += "SYNTAX";
					s += ' ';
					s += m_SyntaxList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule WithSyntaxSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule WithSyntaxSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			WithSyntaxSpec.production_kind kind = (WithSyntaxSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case WithSyntaxSpec.production_kind.g_WithSyntaxSpec_1:
					// traverse syntax tree node associated with production
					// WithSyntaxSpec: WITH SYNTAX SyntaxList

						m_WITH.Visit (visitor, appData);
						m_SYNTAX.Visit (visitor, appData);
						m_SyntaxList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_WITH?.reparent (this);
			m_SYNTAX?.reparent (this);
			m_SyntaxList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule WithSyntaxSpec
		//

		public void _init ()
		{
			m_WITH = null;
			m_SYNTAX = null;
			m_SyntaxList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule WithSyntaxSpec

		// counter of all nodes associated with syntax rule WithSyntaxSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule WithSyntaxSpec
		[DataMember (Name = "m_WITH")] public SyntaxTreeToken m_WITH { get; private set; }
		[DataMember (Name = "m_SYNTAX")] public SyntaxTreeToken m_SYNTAX { get; private set; }
		[DataMember (Name = "m_SyntaxList")] public SyntaxList m_SyntaxList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule WithSyntaxSpec

		// delegate function (callback) prototype associated with syntax rule WithSyntaxSpec
		public delegate bool WithSyntaxSpec_Callback (SyntaxTreeCallbackReason reason, WithSyntaxSpec.production_kind kind, WithSyntaxSpec p_WithSyntaxSpec);

		// event associated with syntax rule WithSyntaxSpec
		public event WithSyntaxSpec_Callback WithSyntaxSpec_Event;

		// event trigger associated with syntax rule WithSyntaxSpec
		public bool Raise_WithSyntaxSpec_Event (SyntaxTreeCallbackReason reason, WithSyntaxSpec.production_kind kind, WithSyntaxSpec p_WithSyntaxSpec)
		{
			bool? status = WithSyntaxSpec_Event?.Invoke (reason, kind, p_WithSyntaxSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule WithSyntaxSpec
		//
		// traverse syntax tree node associated with any production of syntax rule WithSyntaxSpec
		//

		public void Traverse (WithSyntaxSpec p_WithSyntaxSpec)
		{
			if (p_WithSyntaxSpec.isLocked())
				return;
			p_WithSyntaxSpec.dolock();
			WithSyntaxSpec.production_kind kind = (WithSyntaxSpec.production_kind) p_WithSyntaxSpec.kind;
			p_WithSyntaxSpec.turn_reset ();
			if (Raise_WithSyntaxSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_WithSyntaxSpec))
			switch (kind)
			{
				case WithSyntaxSpec.production_kind.g_WithSyntaxSpec_1:
					// traverse syntax tree node associated with production
					// WithSyntaxSpec: WITH SYNTAX SyntaxList

					if (Raise_WithSyntaxSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_WithSyntaxSpec))
						Traverse (p_WithSyntaxSpec.m_SyntaxList);
					p_WithSyntaxSpec.turn_inc ();
					Raise_WithSyntaxSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_WithSyntaxSpec);
				break;
			}
			Raise_WithSyntaxSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_WithSyntaxSpec);
			p_WithSyntaxSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule WithSyntaxSpec
		//

		public void TraverseCommon (WithSyntaxSpec p_WithSyntaxSpec)
		{
			WithSyntaxSpec.production_kind kind = (WithSyntaxSpec.production_kind) p_WithSyntaxSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_WithSyntaxSpec))
			switch (kind)
			{
				case WithSyntaxSpec.production_kind.g_WithSyntaxSpec_1:
					// traverse syntax tree node associated with production
					// WithSyntaxSpec: WITH SYNTAX SyntaxList

						TraverseCommon (p_WithSyntaxSpec.m_WITH);
						TraverseCommon (p_WithSyntaxSpec.m_SYNTAX);
						TraverseCommon (p_WithSyntaxSpec.m_SyntaxList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_WithSyntaxSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule WithSyntaxSpec

		//
		// create syntax tree node associated with production
		// WithSyntaxSpec: WITH SYNTAX SyntaxList

		//

		public WithSyntaxSpec WithSyntaxSpec_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxList p_SyntaxList)
		{
			WithSyntaxSpec p_WithSyntaxSpec_ref = new WithSyntaxSpec(p_token, p_token_1, p_SyntaxList);
			p_token.parent = p_WithSyntaxSpec_ref;
			p_token_1.parent = p_WithSyntaxSpec_ref;
			p_SyntaxList.parent = p_WithSyntaxSpec_ref;
			Raise_WithSyntaxSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, WithSyntaxSpec.production_kind.g_WithSyntaxSpec_1, p_WithSyntaxSpec_ref);
			return p_WithSyntaxSpec_ref;
		}
		#endregion
	};
}
