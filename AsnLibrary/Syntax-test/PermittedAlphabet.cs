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
	// class associated with syntax rule PermittedAlphabet
	//

	[DataContract]
	public class	PermittedAlphabet : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule PermittedAlphabet
		public enum production_kind : ushort	// enumerated production(s) of syntax rule PermittedAlphabet
		{
			g_PermittedAlphabet_1 = 1,	// FROM Constraint

		};
		#endregion
		#region production markers associated with the syntax rule PermittedAlphabet

		// markers associated with production: PermittedAlphabet -> FROM Constraint

		public enum production_marker_1 : ushort
		{
			m_Constraint,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule PermittedAlphabet

		// Constructor declaration(s) associated with production(s) of syntax rule PermittedAlphabet

		//
		// Constructor associated with the following production(s)
		// PermittedAlphabet -> FROM Constraint

		//

		public PermittedAlphabet (SyntaxTreeToken p_token, Constraint p_Constraint) : base ((uint) ProductionID._PermittedAlphabet_ID, (uint) production_kind.g_PermittedAlphabet_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_FROM = p_token;
			children[1] = m_Constraint = p_Constraint;
		}

		public PermittedAlphabet () { }

		// Copy constructor

		public PermittedAlphabet (PermittedAlphabet p_PermittedAlphabet) : base (p_PermittedAlphabet.id, p_PermittedAlphabet.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_PermittedAlphabet.appInfo;
			switch ((production_kind) p_PermittedAlphabet.kind)
			{
				case production_kind.g_PermittedAlphabet_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_FROM = (p_PermittedAlphabet.m_FROM != null) ? new SyntaxTreeToken (p_PermittedAlphabet.m_FROM) : null) != null) m_FROM.parent = this;
					if ((children [1] = m_Constraint = (p_PermittedAlphabet.m_Constraint != null) ? new Constraint (p_PermittedAlphabet.m_Constraint) : null) != null) m_Constraint.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "PermittedAlphabet" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new PermittedAlphabet (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_FROM?.Dispose ();
			m_Constraint?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule PermittedAlphabet

		// Content changing function(s) associated with production(s) of syntax rule PermittedAlphabet

		//
		// Content changing function associated with following production(s)
		// PermittedAlphabet -> FROM Constraint

		//

		public void change(SyntaxTreeToken p_token, Constraint p_Constraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_PermittedAlphabet_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_FROM = p_token;
			children [1] = m_Constraint = p_Constraint;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule PermittedAlphabet
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_FROM != null) && m_FROM.checkInclusion (element) ||
				(m_Constraint != null) && m_Constraint.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule PermittedAlphabet

		//
		// emit production tree node associated with any production of syntax rule PermittedAlphabet
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_PermittedAlphabet_1:
					// emit syntax tree node associated with production
					// PermittedAlphabet: FROM Constraint

					s += m_FROM.Emit (depth - 1);
					s += " ";
					s += m_Constraint.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule PermittedAlphabet
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "PermittedAlphabet (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_PermittedAlphabet_1:
					// emit syntax tree node associated with production
					// PermittedAlphabet: FROM Constraint

					s += "FROM";
					s += ' ';
					s += m_Constraint.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule PermittedAlphabet

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule PermittedAlphabet with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			PermittedAlphabet.production_kind kind = (PermittedAlphabet.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case PermittedAlphabet.production_kind.g_PermittedAlphabet_1:
					// traverse syntax tree node associated with production
					// PermittedAlphabet: FROM Constraint

						m_FROM.Visit (visitor, appData);
						m_Constraint.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_FROM?.reparent (this);
			m_Constraint?.reparent (this);
		}

		//
		// initialize object associated with syntax rule PermittedAlphabet
		//

		public void _init ()
		{
			m_FROM = null;
			m_Constraint = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule PermittedAlphabet

		// counter of all nodes associated with syntax rule PermittedAlphabet
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule PermittedAlphabet
		[DataMember (Name = "m_FROM")] public SyntaxTreeToken m_FROM { get; private set; }
		[DataMember (Name = "m_Constraint")] public Constraint m_Constraint { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule PermittedAlphabet

		// delegate function (callback) prototype associated with syntax rule PermittedAlphabet
		public delegate bool PermittedAlphabet_Callback (SyntaxTreeCallbackReason reason, PermittedAlphabet.production_kind kind, PermittedAlphabet p_PermittedAlphabet);

		// event associated with syntax rule PermittedAlphabet
		public event PermittedAlphabet_Callback PermittedAlphabet_Event;

		// event trigger associated with syntax rule PermittedAlphabet
		public bool Raise_PermittedAlphabet_Event (SyntaxTreeCallbackReason reason, PermittedAlphabet.production_kind kind, PermittedAlphabet p_PermittedAlphabet)
		{
			bool? status = PermittedAlphabet_Event?.Invoke (reason, kind, p_PermittedAlphabet);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule PermittedAlphabet
		//
		// traverse syntax tree node associated with any production of syntax rule PermittedAlphabet
		//

		public void Traverse (PermittedAlphabet p_PermittedAlphabet)
		{
			if (p_PermittedAlphabet.isLocked())
				return;
			p_PermittedAlphabet.dolock();
			PermittedAlphabet.production_kind kind = (PermittedAlphabet.production_kind) p_PermittedAlphabet.kind;
			p_PermittedAlphabet.turn_reset ();
			if (Raise_PermittedAlphabet_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_PermittedAlphabet))
			switch (kind)
			{
				case PermittedAlphabet.production_kind.g_PermittedAlphabet_1:
					// traverse syntax tree node associated with production
					// PermittedAlphabet: FROM Constraint

					if (Raise_PermittedAlphabet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PermittedAlphabet))
						Traverse (p_PermittedAlphabet.m_Constraint);
					p_PermittedAlphabet.turn_inc ();
					Raise_PermittedAlphabet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PermittedAlphabet);
				break;
			}
			Raise_PermittedAlphabet_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_PermittedAlphabet);
			p_PermittedAlphabet.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule PermittedAlphabet
		//

		public void TraverseCommon (PermittedAlphabet p_PermittedAlphabet)
		{
			PermittedAlphabet.production_kind kind = (PermittedAlphabet.production_kind) p_PermittedAlphabet.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_PermittedAlphabet))
			switch (kind)
			{
				case PermittedAlphabet.production_kind.g_PermittedAlphabet_1:
					// traverse syntax tree node associated with production
					// PermittedAlphabet: FROM Constraint

						TraverseCommon (p_PermittedAlphabet.m_FROM);
						TraverseCommon (p_PermittedAlphabet.m_Constraint);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_PermittedAlphabet);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule PermittedAlphabet

		//
		// create syntax tree node associated with production
		// PermittedAlphabet: FROM Constraint

		//

		public PermittedAlphabet PermittedAlphabet_1 (SyntaxTreeToken p_token, Constraint p_Constraint)
		{
			PermittedAlphabet p_PermittedAlphabet_ref = new PermittedAlphabet(p_token, p_Constraint);
			p_token.parent = p_PermittedAlphabet_ref;
			p_Constraint.parent = p_PermittedAlphabet_ref;
			Raise_PermittedAlphabet_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PermittedAlphabet.production_kind.g_PermittedAlphabet_1, p_PermittedAlphabet_ref);
			return p_PermittedAlphabet_ref;
		}
		#endregion
	};
}
