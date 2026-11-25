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
	// class associated with syntax rule DefinedSyntaxToken
	//

	[DataContract]
	public class	DefinedSyntaxToken : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinedSyntaxToken
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinedSyntaxToken
		{
			g_DefinedSyntaxToken_1 = 1,	// Literal

			g_DefinedSyntaxToken_2 = 2,	// Setting

		};
		#endregion
		#region production markers associated with the syntax rule DefinedSyntaxToken

		// markers associated with production: DefinedSyntaxToken -> Literal

		public enum production_marker_1 : ushort
		{
			m_Literal,
			final
		};

		// markers associated with production: DefinedSyntaxToken -> Setting

		public enum production_marker_2 : ushort
		{
			m_Setting,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinedSyntaxToken

		// Constructor declaration(s) associated with production(s) of syntax rule DefinedSyntaxToken

		//
		// Constructor associated with the following production(s)
		// DefinedSyntaxToken -> Literal

		//

		public DefinedSyntaxToken (Literal p_Literal) : base ((uint) ProductionID._DefinedSyntaxToken_ID, (uint) production_kind.g_DefinedSyntaxToken_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Literal = p_Literal;
		}

		//
		// Constructor associated with the following production(s)
		// DefinedSyntaxToken -> Setting

		//

		public DefinedSyntaxToken (Setting p_Setting) : base ((uint) ProductionID._DefinedSyntaxToken_ID, (uint) production_kind.g_DefinedSyntaxToken_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Setting = p_Setting;
		}

		public DefinedSyntaxToken () { }

		// Copy constructor

		public DefinedSyntaxToken (DefinedSyntaxToken p_DefinedSyntaxToken) : base (p_DefinedSyntaxToken.id, p_DefinedSyntaxToken.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinedSyntaxToken.appInfo;
			switch ((production_kind) p_DefinedSyntaxToken.kind)
			{
				case production_kind.g_DefinedSyntaxToken_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Literal = (p_DefinedSyntaxToken.m_Literal != null) ? new Literal (p_DefinedSyntaxToken.m_Literal) : null) != null) m_Literal.parent = this;
					break;
				case production_kind.g_DefinedSyntaxToken_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Setting = (p_DefinedSyntaxToken.m_Setting != null) ? new Setting (p_DefinedSyntaxToken.m_Setting) : null) != null) m_Setting.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinedSyntaxToken" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinedSyntaxToken (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Literal?.Dispose ();
			m_Setting?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinedSyntaxToken

		// Content changing function(s) associated with production(s) of syntax rule DefinedSyntaxToken

		//
		// Content changing function associated with following production(s)
		// DefinedSyntaxToken -> Literal

		//

		public void change(Literal p_Literal)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedSyntaxToken_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Literal = p_Literal;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinedSyntaxToken -> Setting

		//

		public void change(Setting p_Setting)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedSyntaxToken_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Setting = p_Setting;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinedSyntaxToken
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Literal != null) && m_Literal.checkInclusion (element) ||
				(m_Setting != null) && m_Setting.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinedSyntaxToken

		//
		// emit production tree node associated with any production of syntax rule DefinedSyntaxToken
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinedSyntaxToken_1:
					// emit syntax tree node associated with production
					// DefinedSyntaxToken: Literal

					s += m_Literal.Emit (depth - 1);
				break;
				case production_kind.g_DefinedSyntaxToken_2:
					// emit syntax tree node associated with production
					// DefinedSyntaxToken: Setting

					s += m_Setting.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinedSyntaxToken
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinedSyntaxToken (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinedSyntaxToken_1:
					// emit syntax tree node associated with production
					// DefinedSyntaxToken: Literal

					s += m_Literal.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinedSyntaxToken_2:
					// emit syntax tree node associated with production
					// DefinedSyntaxToken: Setting

					s += m_Setting.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinedSyntaxToken

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedSyntaxToken with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinedSyntaxToken.production_kind kind = (DefinedSyntaxToken.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinedSyntaxToken.production_kind.g_DefinedSyntaxToken_1:
					// traverse syntax tree node associated with production
					// DefinedSyntaxToken: Literal

						m_Literal.Visit (visitor, appData);
				break;
				case DefinedSyntaxToken.production_kind.g_DefinedSyntaxToken_2:
					// traverse syntax tree node associated with production
					// DefinedSyntaxToken: Setting

						m_Setting.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Literal?.reparent (this);
			m_Setting?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefinedSyntaxToken
		//

		public void _init ()
		{
			m_Literal = null;
			m_Setting = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinedSyntaxToken

		// counter of all nodes associated with syntax rule DefinedSyntaxToken
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinedSyntaxToken
		[DataMember (Name = "m_Literal")] public Literal m_Literal { get; private set; }
		[DataMember (Name = "m_Setting")] public Setting m_Setting { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinedSyntaxToken

		// delegate function (callback) prototype associated with syntax rule DefinedSyntaxToken
		public delegate bool DefinedSyntaxToken_Callback (SyntaxTreeCallbackReason reason, DefinedSyntaxToken.production_kind kind, DefinedSyntaxToken p_DefinedSyntaxToken);

		// event associated with syntax rule DefinedSyntaxToken
		public event DefinedSyntaxToken_Callback DefinedSyntaxToken_Event;

		// event trigger associated with syntax rule DefinedSyntaxToken
		public bool Raise_DefinedSyntaxToken_Event (SyntaxTreeCallbackReason reason, DefinedSyntaxToken.production_kind kind, DefinedSyntaxToken p_DefinedSyntaxToken)
		{
			bool? status = DefinedSyntaxToken_Event?.Invoke (reason, kind, p_DefinedSyntaxToken);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinedSyntaxToken
		//
		// traverse syntax tree node associated with any production of syntax rule DefinedSyntaxToken
		//

		public void Traverse (DefinedSyntaxToken p_DefinedSyntaxToken)
		{
			if (p_DefinedSyntaxToken.isLocked())
				return;
			p_DefinedSyntaxToken.dolock();
			DefinedSyntaxToken.production_kind kind = (DefinedSyntaxToken.production_kind) p_DefinedSyntaxToken.kind;
			p_DefinedSyntaxToken.turn_reset ();
			if (Raise_DefinedSyntaxToken_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinedSyntaxToken))
			switch (kind)
			{
				case DefinedSyntaxToken.production_kind.g_DefinedSyntaxToken_1:
					// traverse syntax tree node associated with production
					// DefinedSyntaxToken: Literal

					if (Raise_DefinedSyntaxToken_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedSyntaxToken))
						Traverse (p_DefinedSyntaxToken.m_Literal);
					p_DefinedSyntaxToken.turn_inc ();
					Raise_DefinedSyntaxToken_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedSyntaxToken);
				break;
				case DefinedSyntaxToken.production_kind.g_DefinedSyntaxToken_2:
					// traverse syntax tree node associated with production
					// DefinedSyntaxToken: Setting

					if (Raise_DefinedSyntaxToken_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedSyntaxToken))
						Traverse (p_DefinedSyntaxToken.m_Setting);
					p_DefinedSyntaxToken.turn_inc ();
					Raise_DefinedSyntaxToken_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedSyntaxToken);
				break;
			}
			Raise_DefinedSyntaxToken_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinedSyntaxToken);
			p_DefinedSyntaxToken.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedSyntaxToken
		//

		public void TraverseCommon (DefinedSyntaxToken p_DefinedSyntaxToken)
		{
			DefinedSyntaxToken.production_kind kind = (DefinedSyntaxToken.production_kind) p_DefinedSyntaxToken.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinedSyntaxToken))
			switch (kind)
			{
				case DefinedSyntaxToken.production_kind.g_DefinedSyntaxToken_1:
					// traverse syntax tree node associated with production
					// DefinedSyntaxToken: Literal

						TraverseCommon (p_DefinedSyntaxToken.m_Literal);
				break;
				case DefinedSyntaxToken.production_kind.g_DefinedSyntaxToken_2:
					// traverse syntax tree node associated with production
					// DefinedSyntaxToken: Setting

						TraverseCommon (p_DefinedSyntaxToken.m_Setting);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinedSyntaxToken);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinedSyntaxToken

		//
		// create syntax tree node associated with production
		// DefinedSyntaxToken: Literal

		//

		public DefinedSyntaxToken DefinedSyntaxToken_1 (Literal p_Literal)
		{
			DefinedSyntaxToken p_DefinedSyntaxToken_ref = new DefinedSyntaxToken(p_Literal);
			p_Literal.parent = p_DefinedSyntaxToken_ref;
			Raise_DefinedSyntaxToken_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedSyntaxToken.production_kind.g_DefinedSyntaxToken_1, p_DefinedSyntaxToken_ref);
			return p_DefinedSyntaxToken_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinedSyntaxToken: Setting

		//

		public DefinedSyntaxToken DefinedSyntaxToken_2 (Setting p_Setting)
		{
			DefinedSyntaxToken p_DefinedSyntaxToken_ref = new DefinedSyntaxToken(p_Setting);
			p_Setting.parent = p_DefinedSyntaxToken_ref;
			Raise_DefinedSyntaxToken_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedSyntaxToken.production_kind.g_DefinedSyntaxToken_2, p_DefinedSyntaxToken_ref);
			return p_DefinedSyntaxToken_ref;
		}
		#endregion
	};
}
