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
	// class associated with syntax rule NamedConstraint
	//

	[DataContract]
	public class	NamedConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NamedConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NamedConstraint
		{
			g_NamedConstraint_1 = 1,	// identifier-token ComponentConstraint

		};
		#endregion
		#region production markers associated with the syntax rule NamedConstraint

		// markers associated with production: NamedConstraint -> identifier-token ComponentConstraint

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			m_ComponentConstraint,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NamedConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule NamedConstraint

		//
		// Constructor associated with the following production(s)
		// NamedConstraint -> identifier-token ComponentConstraint

		//

		public NamedConstraint (identifier_token p_identifier_token, ComponentConstraint p_ComponentConstraint) : base ((uint) ProductionID._NamedConstraint_ID, (uint) production_kind.g_NamedConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_ComponentConstraint = p_ComponentConstraint;
		}

		public NamedConstraint () { }

		// Copy constructor

		public NamedConstraint (NamedConstraint p_NamedConstraint) : base (p_NamedConstraint.id, p_NamedConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NamedConstraint.appInfo;
			switch ((production_kind) p_NamedConstraint.kind)
			{
				case production_kind.g_NamedConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_identifier_token = (p_NamedConstraint.m_identifier_token != null) ? new identifier_token (p_NamedConstraint.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_ComponentConstraint = (p_NamedConstraint.m_ComponentConstraint != null) ? new ComponentConstraint (p_NamedConstraint.m_ComponentConstraint) : null) != null) m_ComponentConstraint.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NamedConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NamedConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_ComponentConstraint?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NamedConstraint

		// Content changing function(s) associated with production(s) of syntax rule NamedConstraint

		//
		// Content changing function associated with following production(s)
		// NamedConstraint -> identifier-token ComponentConstraint

		//

		public void change(identifier_token p_identifier_token, ComponentConstraint p_ComponentConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_ComponentConstraint = p_ComponentConstraint;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NamedConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_ComponentConstraint != null) && m_ComponentConstraint.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NamedConstraint

		//
		// emit production tree node associated with any production of syntax rule NamedConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NamedConstraint_1:
					// emit syntax tree node associated with production
					// NamedConstraint: identifier-token ComponentConstraint

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_ComponentConstraint.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NamedConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NamedConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NamedConstraint_1:
					// emit syntax tree node associated with production
					// NamedConstraint: identifier-token ComponentConstraint

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ComponentConstraint.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NamedConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NamedConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NamedConstraint.production_kind kind = (NamedConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NamedConstraint.production_kind.g_NamedConstraint_1:
					// traverse syntax tree node associated with production
					// NamedConstraint: identifier-token ComponentConstraint

						m_identifier_token.Visit (visitor, appData);
						m_ComponentConstraint.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier_token?.reparent (this);
			m_ComponentConstraint?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NamedConstraint
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_ComponentConstraint = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NamedConstraint

		// counter of all nodes associated with syntax rule NamedConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NamedConstraint
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_ComponentConstraint")] public ComponentConstraint m_ComponentConstraint { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NamedConstraint

		// delegate function (callback) prototype associated with syntax rule NamedConstraint
		public delegate bool NamedConstraint_Callback (SyntaxTreeCallbackReason reason, NamedConstraint.production_kind kind, NamedConstraint p_NamedConstraint);

		// event associated with syntax rule NamedConstraint
		public event NamedConstraint_Callback NamedConstraint_Event;

		// event trigger associated with syntax rule NamedConstraint
		public bool Raise_NamedConstraint_Event (SyntaxTreeCallbackReason reason, NamedConstraint.production_kind kind, NamedConstraint p_NamedConstraint)
		{
			bool? status = NamedConstraint_Event?.Invoke (reason, kind, p_NamedConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NamedConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule NamedConstraint
		//

		public void Traverse (NamedConstraint p_NamedConstraint)
		{
			if (p_NamedConstraint.isLocked())
				return;
			p_NamedConstraint.dolock();
			NamedConstraint.production_kind kind = (NamedConstraint.production_kind) p_NamedConstraint.kind;
			p_NamedConstraint.turn_reset ();
			if (Raise_NamedConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NamedConstraint))
			switch (kind)
			{
				case NamedConstraint.production_kind.g_NamedConstraint_1:
					// traverse syntax tree node associated with production
					// NamedConstraint: identifier-token ComponentConstraint

					if (Raise_NamedConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedConstraint))
						Traverse (p_NamedConstraint.m_identifier_token);
					p_NamedConstraint.turn_inc ();
					if (Raise_NamedConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedConstraint))
						Traverse (p_NamedConstraint.m_ComponentConstraint);
					p_NamedConstraint.turn_inc ();
					Raise_NamedConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedConstraint);
				break;
			}
			Raise_NamedConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NamedConstraint);
			p_NamedConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NamedConstraint
		//

		public void TraverseCommon (NamedConstraint p_NamedConstraint)
		{
			NamedConstraint.production_kind kind = (NamedConstraint.production_kind) p_NamedConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NamedConstraint))
			switch (kind)
			{
				case NamedConstraint.production_kind.g_NamedConstraint_1:
					// traverse syntax tree node associated with production
					// NamedConstraint: identifier-token ComponentConstraint

						TraverseCommon (p_NamedConstraint.m_identifier_token);
						TraverseCommon (p_NamedConstraint.m_ComponentConstraint);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NamedConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NamedConstraint

		//
		// create syntax tree node associated with production
		// NamedConstraint: identifier-token ComponentConstraint

		//

		public NamedConstraint NamedConstraint_1 (identifier_token p_identifier_token, ComponentConstraint p_ComponentConstraint)
		{
			NamedConstraint p_NamedConstraint_ref = new NamedConstraint(p_identifier_token, p_ComponentConstraint);
			p_identifier_token.parent = p_NamedConstraint_ref;
			p_ComponentConstraint.parent = p_NamedConstraint_ref;
			Raise_NamedConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedConstraint.production_kind.g_NamedConstraint_1, p_NamedConstraint_ref);
			return p_NamedConstraint_ref;
		}
		#endregion
	};
}
