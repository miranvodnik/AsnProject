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
	// class associated with syntax rule SESizeConstraint
	//

	[DataContract]
	public class	SESizeConstraint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SESizeConstraint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SESizeConstraint
		{
			g_SESizeConstraint_1 = 1,	// SizeConstraint

		};
		#endregion
		#region production markers associated with the syntax rule SESizeConstraint

		// markers associated with production: SESizeConstraint -> SizeConstraint

		public enum production_marker_1 : ushort
		{
			m_SizeConstraint,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SESizeConstraint

		// Constructor declaration(s) associated with production(s) of syntax rule SESizeConstraint

		//
		// Constructor associated with the following production(s)
		// SESizeConstraint -> SizeConstraint

		//

		public SESizeConstraint (SizeConstraint p_SizeConstraint) : base ((uint) ProductionID._SESizeConstraint_ID, (uint) production_kind.g_SESizeConstraint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SizeConstraint = p_SizeConstraint;
		}

		public SESizeConstraint () { }

		// Copy constructor

		public SESizeConstraint (SESizeConstraint p_SESizeConstraint) : base (p_SESizeConstraint.id, p_SESizeConstraint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SESizeConstraint.appInfo;
			switch ((production_kind) p_SESizeConstraint.kind)
			{
				case production_kind.g_SESizeConstraint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SizeConstraint = (p_SESizeConstraint.m_SizeConstraint != null) ? new SizeConstraint (p_SESizeConstraint.m_SizeConstraint) : null) != null) m_SizeConstraint.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SESizeConstraint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SESizeConstraint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SizeConstraint?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SESizeConstraint

		// Content changing function(s) associated with production(s) of syntax rule SESizeConstraint

		//
		// Content changing function associated with following production(s)
		// SESizeConstraint -> SizeConstraint

		//

		public void change(SizeConstraint p_SizeConstraint)
		{
			_init ();
			this.kind = (uint) production_kind.g_SESizeConstraint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SizeConstraint = p_SizeConstraint;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SESizeConstraint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SizeConstraint != null) && m_SizeConstraint.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SESizeConstraint

		//
		// emit production tree node associated with any production of syntax rule SESizeConstraint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SESizeConstraint_1:
					// emit syntax tree node associated with production
					// SESizeConstraint: SizeConstraint

					s += m_SizeConstraint.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SESizeConstraint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SESizeConstraint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SESizeConstraint_1:
					// emit syntax tree node associated with production
					// SESizeConstraint: SizeConstraint

					s += m_SizeConstraint.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SESizeConstraint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SESizeConstraint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SESizeConstraint.production_kind kind = (SESizeConstraint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SESizeConstraint.production_kind.g_SESizeConstraint_1:
					// traverse syntax tree node associated with production
					// SESizeConstraint: SizeConstraint

						m_SizeConstraint.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SizeConstraint?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SESizeConstraint
		//

		public void _init ()
		{
			m_SizeConstraint = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SESizeConstraint

		// counter of all nodes associated with syntax rule SESizeConstraint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SESizeConstraint
		[DataMember (Name = "m_SizeConstraint")] public SizeConstraint m_SizeConstraint { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SESizeConstraint

		// delegate function (callback) prototype associated with syntax rule SESizeConstraint
		public delegate bool SESizeConstraint_Callback (SyntaxTreeCallbackReason reason, SESizeConstraint.production_kind kind, SESizeConstraint p_SESizeConstraint);

		// event associated with syntax rule SESizeConstraint
		public event SESizeConstraint_Callback SESizeConstraint_Event;

		// event trigger associated with syntax rule SESizeConstraint
		public bool Raise_SESizeConstraint_Event (SyntaxTreeCallbackReason reason, SESizeConstraint.production_kind kind, SESizeConstraint p_SESizeConstraint)
		{
			bool? status = SESizeConstraint_Event?.Invoke (reason, kind, p_SESizeConstraint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SESizeConstraint
		//
		// traverse syntax tree node associated with any production of syntax rule SESizeConstraint
		//

		public void Traverse (SESizeConstraint p_SESizeConstraint)
		{
			if (p_SESizeConstraint.isLocked())
				return;
			p_SESizeConstraint.dolock();
			SESizeConstraint.production_kind kind = (SESizeConstraint.production_kind) p_SESizeConstraint.kind;
			p_SESizeConstraint.turn_reset ();
			if (Raise_SESizeConstraint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SESizeConstraint))
			switch (kind)
			{
				case SESizeConstraint.production_kind.g_SESizeConstraint_1:
					// traverse syntax tree node associated with production
					// SESizeConstraint: SizeConstraint

					if (Raise_SESizeConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SESizeConstraint))
						Traverse (p_SESizeConstraint.m_SizeConstraint);
					p_SESizeConstraint.turn_inc ();
					Raise_SESizeConstraint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SESizeConstraint);
				break;
			}
			Raise_SESizeConstraint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SESizeConstraint);
			p_SESizeConstraint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SESizeConstraint
		//

		public void TraverseCommon (SESizeConstraint p_SESizeConstraint)
		{
			SESizeConstraint.production_kind kind = (SESizeConstraint.production_kind) p_SESizeConstraint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SESizeConstraint))
			switch (kind)
			{
				case SESizeConstraint.production_kind.g_SESizeConstraint_1:
					// traverse syntax tree node associated with production
					// SESizeConstraint: SizeConstraint

						TraverseCommon (p_SESizeConstraint.m_SizeConstraint);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SESizeConstraint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SESizeConstraint

		//
		// create syntax tree node associated with production
		// SESizeConstraint: SizeConstraint

		//

		public SESizeConstraint SESizeConstraint_1 (SizeConstraint p_SizeConstraint)
		{
			SESizeConstraint p_SESizeConstraint_ref = new SESizeConstraint(p_SizeConstraint);
			p_SizeConstraint.parent = p_SESizeConstraint_ref;
			Raise_SESizeConstraint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SESizeConstraint.production_kind.g_SESizeConstraint_1, p_SESizeConstraint_ref);
			return p_SESizeConstraint_ref;
		}
		#endregion
	};
}
