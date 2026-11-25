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
	// class associated with syntax rule RequiredToken
	//

	[DataContract]
	public class	RequiredToken : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RequiredToken
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RequiredToken
		{
			g_RequiredToken_1 = 1,	// LiteralSet PrimitiveFieldName

		};
		#endregion
		#region production markers associated with the syntax rule RequiredToken

		// markers associated with production: RequiredToken -> LiteralSet PrimitiveFieldName

		public enum production_marker_1 : ushort
		{
			m_LiteralSet,
			m_PrimitiveFieldName,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RequiredToken

		// Constructor declaration(s) associated with production(s) of syntax rule RequiredToken

		//
		// Constructor associated with the following production(s)
		// RequiredToken -> LiteralSet PrimitiveFieldName

		//

		public RequiredToken (LiteralSet p_LiteralSet, PrimitiveFieldName p_PrimitiveFieldName) : base ((uint) ProductionID._RequiredToken_ID, (uint) production_kind.g_RequiredToken_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_LiteralSet = p_LiteralSet;
			children[1] = m_PrimitiveFieldName = p_PrimitiveFieldName;
		}

		public RequiredToken () { }

		// Copy constructor

		public RequiredToken (RequiredToken p_RequiredToken) : base (p_RequiredToken.id, p_RequiredToken.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RequiredToken.appInfo;
			switch ((production_kind) p_RequiredToken.kind)
			{
				case production_kind.g_RequiredToken_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_LiteralSet = (p_RequiredToken.m_LiteralSet != null) ? new LiteralSet (p_RequiredToken.m_LiteralSet) : null) != null) m_LiteralSet.parent = this;
					if ((children [1] = m_PrimitiveFieldName = (p_RequiredToken.m_PrimitiveFieldName != null) ? new PrimitiveFieldName (p_RequiredToken.m_PrimitiveFieldName) : null) != null) m_PrimitiveFieldName.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RequiredToken" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RequiredToken (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_LiteralSet?.Dispose ();
			m_PrimitiveFieldName?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RequiredToken

		// Content changing function(s) associated with production(s) of syntax rule RequiredToken

		//
		// Content changing function associated with following production(s)
		// RequiredToken -> LiteralSet PrimitiveFieldName

		//

		public void change(LiteralSet p_LiteralSet, PrimitiveFieldName p_PrimitiveFieldName)
		{
			_init ();
			this.kind = (uint) production_kind.g_RequiredToken_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_LiteralSet = p_LiteralSet;
			children [1] = m_PrimitiveFieldName = p_PrimitiveFieldName;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RequiredToken
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_LiteralSet != null) && m_LiteralSet.checkInclusion (element) ||
				(m_PrimitiveFieldName != null) && m_PrimitiveFieldName.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RequiredToken

		//
		// emit production tree node associated with any production of syntax rule RequiredToken
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RequiredToken_1:
					// emit syntax tree node associated with production
					// RequiredToken: LiteralSet PrimitiveFieldName

					s += m_LiteralSet.Emit (depth - 1);
					s += " ";
					s += m_PrimitiveFieldName.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RequiredToken
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RequiredToken (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RequiredToken_1:
					// emit syntax tree node associated with production
					// RequiredToken: LiteralSet PrimitiveFieldName

					s += m_LiteralSet.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_PrimitiveFieldName.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RequiredToken

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RequiredToken with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RequiredToken.production_kind kind = (RequiredToken.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RequiredToken.production_kind.g_RequiredToken_1:
					// traverse syntax tree node associated with production
					// RequiredToken: LiteralSet PrimitiveFieldName

						m_LiteralSet.Visit (visitor, appData);
						m_PrimitiveFieldName.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_LiteralSet?.reparent (this);
			m_PrimitiveFieldName?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RequiredToken
		//

		public void _init ()
		{
			m_LiteralSet = null;
			m_PrimitiveFieldName = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RequiredToken

		// counter of all nodes associated with syntax rule RequiredToken
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RequiredToken
		[DataMember (Name = "m_LiteralSet")] public LiteralSet m_LiteralSet { get; private set; }
		[DataMember (Name = "m_PrimitiveFieldName")] public PrimitiveFieldName m_PrimitiveFieldName { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RequiredToken

		// delegate function (callback) prototype associated with syntax rule RequiredToken
		public delegate bool RequiredToken_Callback (SyntaxTreeCallbackReason reason, RequiredToken.production_kind kind, RequiredToken p_RequiredToken);

		// event associated with syntax rule RequiredToken
		public event RequiredToken_Callback RequiredToken_Event;

		// event trigger associated with syntax rule RequiredToken
		public bool Raise_RequiredToken_Event (SyntaxTreeCallbackReason reason, RequiredToken.production_kind kind, RequiredToken p_RequiredToken)
		{
			bool? status = RequiredToken_Event?.Invoke (reason, kind, p_RequiredToken);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RequiredToken
		//
		// traverse syntax tree node associated with any production of syntax rule RequiredToken
		//

		public void Traverse (RequiredToken p_RequiredToken)
		{
			if (p_RequiredToken.isLocked())
				return;
			p_RequiredToken.dolock();
			RequiredToken.production_kind kind = (RequiredToken.production_kind) p_RequiredToken.kind;
			p_RequiredToken.turn_reset ();
			if (Raise_RequiredToken_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RequiredToken))
			switch (kind)
			{
				case RequiredToken.production_kind.g_RequiredToken_1:
					// traverse syntax tree node associated with production
					// RequiredToken: LiteralSet PrimitiveFieldName

					if (Raise_RequiredToken_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RequiredToken))
						Traverse (p_RequiredToken.m_LiteralSet);
					p_RequiredToken.turn_inc ();
					if (Raise_RequiredToken_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RequiredToken))
						Traverse (p_RequiredToken.m_PrimitiveFieldName);
					p_RequiredToken.turn_inc ();
					Raise_RequiredToken_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RequiredToken);
				break;
			}
			Raise_RequiredToken_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RequiredToken);
			p_RequiredToken.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RequiredToken
		//

		public void TraverseCommon (RequiredToken p_RequiredToken)
		{
			RequiredToken.production_kind kind = (RequiredToken.production_kind) p_RequiredToken.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RequiredToken))
			switch (kind)
			{
				case RequiredToken.production_kind.g_RequiredToken_1:
					// traverse syntax tree node associated with production
					// RequiredToken: LiteralSet PrimitiveFieldName

						TraverseCommon (p_RequiredToken.m_LiteralSet);
						TraverseCommon (p_RequiredToken.m_PrimitiveFieldName);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RequiredToken);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RequiredToken

		//
		// create syntax tree node associated with production
		// RequiredToken: LiteralSet PrimitiveFieldName

		//

		public RequiredToken RequiredToken_1 (LiteralSet p_LiteralSet, PrimitiveFieldName p_PrimitiveFieldName)
		{
			RequiredToken p_RequiredToken_ref = new RequiredToken(p_LiteralSet, p_PrimitiveFieldName);
			p_LiteralSet.parent = p_RequiredToken_ref;
			p_PrimitiveFieldName.parent = p_RequiredToken_ref;
			Raise_RequiredToken_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RequiredToken.production_kind.g_RequiredToken_1, p_RequiredToken_ref);
			return p_RequiredToken_ref;
		}
		#endregion
	};
}
