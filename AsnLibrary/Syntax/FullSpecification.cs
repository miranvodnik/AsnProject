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
	// class associated with syntax rule FullSpecification
	//

	[DataContract]
	public class	FullSpecification : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule FullSpecification
		public enum production_kind : ushort	// enumerated production(s) of syntax rule FullSpecification
		{
			g_FullSpecification_1 = 1,	// "{" TypeConstraints "}"

		};
		#endregion
		#region production markers associated with the syntax rule FullSpecification

		// markers associated with production: FullSpecification -> "{" TypeConstraints "}"

		public enum production_marker_1 : ushort
		{
			m_TypeConstraints,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule FullSpecification

		// Constructor declaration(s) associated with production(s) of syntax rule FullSpecification

		//
		// Constructor associated with the following production(s)
		// FullSpecification -> "{" TypeConstraints "}"

		//

		public FullSpecification (SyntaxTreeToken p_token, TypeConstraints p_TypeConstraints, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._FullSpecification_ID, (uint) production_kind.g_FullSpecification_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_TypeConstraints = p_TypeConstraints;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public FullSpecification () { }

		// Copy constructor

		public FullSpecification (FullSpecification p_FullSpecification) : base (p_FullSpecification.id, p_FullSpecification.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_FullSpecification.appInfo;
			switch ((production_kind) p_FullSpecification.kind)
			{
				case production_kind.g_FullSpecification_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_FullSpecification.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_FullSpecification.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_TypeConstraints = (p_FullSpecification.m_TypeConstraints != null) ? new TypeConstraints (p_FullSpecification.m_TypeConstraints) : null) != null) m_TypeConstraints.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_FullSpecification.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_FullSpecification.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "FullSpecification" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new FullSpecification (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_TypeConstraints?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule FullSpecification

		// Content changing function(s) associated with production(s) of syntax rule FullSpecification

		//
		// Content changing function associated with following production(s)
		// FullSpecification -> "{" TypeConstraints "}"

		//

		public void change(SyntaxTreeToken p_token, TypeConstraints p_TypeConstraints, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_FullSpecification_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_TypeConstraints = p_TypeConstraints;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule FullSpecification
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_TypeConstraints != null) && m_TypeConstraints.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule FullSpecification

		//
		// emit production tree node associated with any production of syntax rule FullSpecification
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_FullSpecification_1:
					// emit syntax tree node associated with production
					// FullSpecification: "{" TypeConstraints "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_TypeConstraints.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule FullSpecification
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "FullSpecification (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_FullSpecification_1:
					// emit syntax tree node associated with production
					// FullSpecification: "{" TypeConstraints "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_TypeConstraints.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule FullSpecification

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule FullSpecification with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			FullSpecification.production_kind kind = (FullSpecification.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case FullSpecification.production_kind.g_FullSpecification_1:
					// traverse syntax tree node associated with production
					// FullSpecification: "{" TypeConstraints "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_TypeConstraints.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_left_curly_bracket?.reparent (this);
			m_TypeConstraints?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule FullSpecification
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_TypeConstraints = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule FullSpecification

		// counter of all nodes associated with syntax rule FullSpecification
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule FullSpecification
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_TypeConstraints")] public TypeConstraints m_TypeConstraints { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule FullSpecification

		// delegate function (callback) prototype associated with syntax rule FullSpecification
		public delegate bool FullSpecification_Callback (SyntaxTreeCallbackReason reason, FullSpecification.production_kind kind, FullSpecification p_FullSpecification);

		// event associated with syntax rule FullSpecification
		public event FullSpecification_Callback FullSpecification_Event;

		// event trigger associated with syntax rule FullSpecification
		public bool Raise_FullSpecification_Event (SyntaxTreeCallbackReason reason, FullSpecification.production_kind kind, FullSpecification p_FullSpecification)
		{
			bool? status = FullSpecification_Event?.Invoke (reason, kind, p_FullSpecification);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule FullSpecification
		//
		// traverse syntax tree node associated with any production of syntax rule FullSpecification
		//

		public void Traverse (FullSpecification p_FullSpecification)
		{
			if (p_FullSpecification.isLocked())
				return;
			p_FullSpecification.dolock();
			FullSpecification.production_kind kind = (FullSpecification.production_kind) p_FullSpecification.kind;
			p_FullSpecification.turn_reset ();
			if (Raise_FullSpecification_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_FullSpecification))
			switch (kind)
			{
				case FullSpecification.production_kind.g_FullSpecification_1:
					// traverse syntax tree node associated with production
					// FullSpecification: "{" TypeConstraints "}"

					if (Raise_FullSpecification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FullSpecification))
						Traverse (p_FullSpecification.m_TypeConstraints);
					p_FullSpecification.turn_inc ();
					Raise_FullSpecification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FullSpecification);
				break;
			}
			Raise_FullSpecification_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_FullSpecification);
			p_FullSpecification.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule FullSpecification
		//

		public void TraverseCommon (FullSpecification p_FullSpecification)
		{
			FullSpecification.production_kind kind = (FullSpecification.production_kind) p_FullSpecification.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_FullSpecification))
			switch (kind)
			{
				case FullSpecification.production_kind.g_FullSpecification_1:
					// traverse syntax tree node associated with production
					// FullSpecification: "{" TypeConstraints "}"

						TraverseCommon (p_FullSpecification.m_left_curly_bracket);
						TraverseCommon (p_FullSpecification.m_TypeConstraints);
						TraverseCommon (p_FullSpecification.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_FullSpecification);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule FullSpecification

		//
		// create syntax tree node associated with production
		// FullSpecification: "{" TypeConstraints "}"

		//

		public FullSpecification FullSpecification_1 (SyntaxTreeToken p_token, TypeConstraints p_TypeConstraints, SyntaxTreeToken p_token_1)
		{
			FullSpecification p_FullSpecification_ref = new FullSpecification(p_token, p_TypeConstraints, p_token_1);
			p_token.parent = p_FullSpecification_ref;
			p_TypeConstraints.parent = p_FullSpecification_ref;
			p_token_1.parent = p_FullSpecification_ref;
			Raise_FullSpecification_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FullSpecification.production_kind.g_FullSpecification_1, p_FullSpecification_ref);
			return p_FullSpecification_ref;
		}
		#endregion
	};
}
