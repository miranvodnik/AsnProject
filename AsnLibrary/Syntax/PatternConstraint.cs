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
	// class associated with syntax rule PatternConstraint
	//

	[DataContract]
	public class	PatternConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule PatternConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule PatternConstraint
		{
			g_PatternConstraint_1 = 1,	// PATTERN Value

		};
		#endregion
		#region production markers associated with the syntax rule PatternConstraint

		// markers associated with production: PatternConstraint -> PATTERN Value

		public enum production_marker_1 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule PatternConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule PatternConstraint

		//
		// Constructor associated with the following production(s)
		// PatternConstraint -> PATTERN Value

		//

		public PatternConstraint (SyntaxTreeToken p_token, Value p_Value) : base ((uint) ProductionID._PatternConstraint_ID, (uint) production_kind.g_PatternConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_PATTERN = p_token;
			children[1] = m_Value = p_Value;
		}

		public PatternConstraint () { }

		// Copy constructor

		public PatternConstraint (PatternConstraint p_PatternConstraint) : base (p_PatternConstraint.id, p_PatternConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_PatternConstraint.appInfo;
			switch ((production_kind) p_PatternConstraint.kind)
			{
				case production_kind.g_PatternConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_PATTERN = (p_PatternConstraint.m_PATTERN != null) ? new SyntaxTreeToken (p_PatternConstraint.m_PATTERN) : null) != null) m_PATTERN.parent = this;
					if ((children [1] = m_Value = (p_PatternConstraint.m_Value != null) ? new Value (p_PatternConstraint.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "PatternConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new PatternConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_PATTERN?.Dispose ();
			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule PatternConstraint

		// Content changing function(s) associated with production(s) of syntax rule PatternConstraint

		//
		// Content changing function associated with following production(s)
		// PatternConstraint -> PATTERN Value

		//

		public void change(SyntaxTreeToken p_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_PatternConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_PATTERN = p_token;
			children [1] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule PatternConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_PATTERN != null) && m_PATTERN.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule PatternConstraint

		//
		// emit production tree node associated with any production of syntax rule PatternConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_PatternConstraint_1:
					// emit syntax tree node associated with production
					// PatternConstraint: PATTERN Value

					s += m_PATTERN.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule PatternConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "PatternConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_PatternConstraint_1:
					// emit syntax tree node associated with production
					// PatternConstraint: PATTERN Value

					s += "PATTERN";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule PatternConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule PatternConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			PatternConstraint.production_kind kind = (PatternConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case PatternConstraint.production_kind.g_PatternConstraint_1:
					// traverse syntax tree node associated with production
					// PatternConstraint: PATTERN Value

						m_PATTERN.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_PATTERN?.reparent (this);
			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule PatternConstraint
		//

		public void _init ()
		{
			m_PATTERN = null;
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule PatternConstraint

		// counter of all nodes associated with syntax rule PatternConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule PatternConstraint
		[DataMember (Name = "m_PATTERN")] public SyntaxTreeToken m_PATTERN { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule PatternConstraint

		// delegate function (callback) prototype associated with syntax rule PatternConstraint
		public delegate bool PatternConstraint_Callback (SyntaxTreeCallbackReason reason, PatternConstraint.production_kind kind, PatternConstraint p_PatternConstraint);

		// event associated with syntax rule PatternConstraint
		public event PatternConstraint_Callback PatternConstraint_Event;

		// event trigger associated with syntax rule PatternConstraint
		public bool Raise_PatternConstraint_Event (SyntaxTreeCallbackReason reason, PatternConstraint.production_kind kind, PatternConstraint p_PatternConstraint)
		{
			bool? status = PatternConstraint_Event?.Invoke (reason, kind, p_PatternConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule PatternConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule PatternConstraint
		//

		public void Traverse (PatternConstraint p_PatternConstraint)
		{
			if (p_PatternConstraint.isLocked())
				return;
			p_PatternConstraint.dolock();
			PatternConstraint.production_kind kind = (PatternConstraint.production_kind) p_PatternConstraint.kind;
			p_PatternConstraint.turn_reset ();
			if (Raise_PatternConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_PatternConstraint))
			switch (kind)
			{
				case PatternConstraint.production_kind.g_PatternConstraint_1:
					// traverse syntax tree node associated with production
					// PatternConstraint: PATTERN Value

					if (Raise_PatternConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PatternConstraint))
						Traverse (p_PatternConstraint.m_Value);
					p_PatternConstraint.turn_inc ();
					Raise_PatternConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PatternConstraint);
				break;
			}
			Raise_PatternConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_PatternConstraint);
			p_PatternConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule PatternConstraint
		//

		public void TraverseCommon (PatternConstraint p_PatternConstraint)
		{
			PatternConstraint.production_kind kind = (PatternConstraint.production_kind) p_PatternConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_PatternConstraint))
			switch (kind)
			{
				case PatternConstraint.production_kind.g_PatternConstraint_1:
					// traverse syntax tree node associated with production
					// PatternConstraint: PATTERN Value

						TraverseCommon (p_PatternConstraint.m_PATTERN);
						TraverseCommon (p_PatternConstraint.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_PatternConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule PatternConstraint

		//
		// create syntax tree node associated with production
		// PatternConstraint: PATTERN Value

		//

		public PatternConstraint PatternConstraint_1 (SyntaxTreeToken p_token, Value p_Value)
		{
			PatternConstraint p_PatternConstraint_ref = new PatternConstraint(p_token, p_Value);
			p_token.parent = p_PatternConstraint_ref;
			p_Value.parent = p_PatternConstraint_ref;
			Raise_PatternConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PatternConstraint.production_kind.g_PatternConstraint_1, p_PatternConstraint_ref);
			return p_PatternConstraint_ref;
		}
		#endregion
	};
}
