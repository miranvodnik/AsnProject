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
	// class associated with syntax rule WithSyntaxSpec-optional
	//

	[DataContract]
	public class	WithSyntaxSpec_optional : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule WithSyntaxSpec-optional
		public enum production_kind : ushort	// enumerated production(s) of syntax rule WithSyntaxSpec-optional
		{
			g_WithSyntaxSpec_optional_1 = 1,	// %empty

			g_WithSyntaxSpec_optional_2 = 2,	// WithSyntaxSpec

		};
		#endregion
		#region production markers associated with the syntax rule WithSyntaxSpec-optional

		// markers associated with production: WithSyntaxSpec-optional -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: WithSyntaxSpec-optional -> WithSyntaxSpec

		public enum production_marker_2 : ushort
		{
			m_WithSyntaxSpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule WithSyntaxSpec-optional

		// Constructor declaration(s) associated with production(s) of syntax rule WithSyntaxSpec-optional

		//
		// Constructor associated with the following production(s)
		// WithSyntaxSpec-optional -> %empty

		//

		public WithSyntaxSpec_optional () : base ((uint) ProductionID._WithSyntaxSpec_optional_ID, (uint) production_kind.g_WithSyntaxSpec_optional_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// WithSyntaxSpec-optional -> WithSyntaxSpec

		//

		public WithSyntaxSpec_optional (WithSyntaxSpec p_WithSyntaxSpec) : base ((uint) ProductionID._WithSyntaxSpec_optional_ID, (uint) production_kind.g_WithSyntaxSpec_optional_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_WithSyntaxSpec = p_WithSyntaxSpec;
		}

		// Copy constructor

		public WithSyntaxSpec_optional (WithSyntaxSpec_optional p_WithSyntaxSpec_optional) : base (p_WithSyntaxSpec_optional.id, p_WithSyntaxSpec_optional.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_WithSyntaxSpec_optional.appInfo;
			switch ((production_kind) p_WithSyntaxSpec_optional.kind)
			{
				case production_kind.g_WithSyntaxSpec_optional_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_WithSyntaxSpec_optional_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_WithSyntaxSpec = (p_WithSyntaxSpec_optional.m_WithSyntaxSpec != null) ? new WithSyntaxSpec (p_WithSyntaxSpec_optional.m_WithSyntaxSpec) : null) != null) m_WithSyntaxSpec.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "WithSyntaxSpec_optional" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new WithSyntaxSpec_optional (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_WithSyntaxSpec?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule WithSyntaxSpec-optional

		// Content changing function(s) associated with production(s) of syntax rule WithSyntaxSpec-optional

		//
		// Content changing function associated with following production(s)
		// WithSyntaxSpec-optional -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_WithSyntaxSpec_optional_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// WithSyntaxSpec-optional -> WithSyntaxSpec

		//

		public void change(WithSyntaxSpec p_WithSyntaxSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_WithSyntaxSpec_optional_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_WithSyntaxSpec = p_WithSyntaxSpec;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule WithSyntaxSpec-optional
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_WithSyntaxSpec != null) && m_WithSyntaxSpec.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule WithSyntaxSpec-optional

		//
		// emit production tree node associated with any production of syntax rule WithSyntaxSpec-optional
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_WithSyntaxSpec_optional_1:
					// emit syntax tree node associated with production
					// WithSyntaxSpec-optional: %empty

				break;
				case production_kind.g_WithSyntaxSpec_optional_2:
					// emit syntax tree node associated with production
					// WithSyntaxSpec-optional: WithSyntaxSpec

					s += m_WithSyntaxSpec.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule WithSyntaxSpec-optional
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "WithSyntaxSpec_optional (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_WithSyntaxSpec_optional_1:
					// emit syntax tree node associated with production
					// WithSyntaxSpec-optional: %empty

				break;
				case production_kind.g_WithSyntaxSpec_optional_2:
					// emit syntax tree node associated with production
					// WithSyntaxSpec-optional: WithSyntaxSpec

					s += m_WithSyntaxSpec.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule WithSyntaxSpec-optional

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule WithSyntaxSpec-optional with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			WithSyntaxSpec_optional.production_kind kind = (WithSyntaxSpec_optional.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case WithSyntaxSpec_optional.production_kind.g_WithSyntaxSpec_optional_1:
					// traverse syntax tree node associated with production
					// WithSyntaxSpec-optional: %empty

				break;
				case WithSyntaxSpec_optional.production_kind.g_WithSyntaxSpec_optional_2:
					// traverse syntax tree node associated with production
					// WithSyntaxSpec-optional: WithSyntaxSpec

						m_WithSyntaxSpec.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_WithSyntaxSpec?.reparent (this);
		}

		//
		// initialize object associated with syntax rule WithSyntaxSpec-optional
		//

		public void _init ()
		{
			m_WithSyntaxSpec = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule WithSyntaxSpec-optional

		// counter of all nodes associated with syntax rule WithSyntaxSpec-optional
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule WithSyntaxSpec-optional
		[DataMember (Name = "m_WithSyntaxSpec")] public WithSyntaxSpec m_WithSyntaxSpec { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule WithSyntaxSpec-optional

		// delegate function (callback) prototype associated with syntax rule WithSyntaxSpec-optional
		public delegate bool WithSyntaxSpec_optional_Callback (SyntaxTreeCallbackReason reason, WithSyntaxSpec_optional.production_kind kind, WithSyntaxSpec_optional p_WithSyntaxSpec_optional);

		// event associated with syntax rule WithSyntaxSpec-optional
		public event WithSyntaxSpec_optional_Callback WithSyntaxSpec_optional_Event;

		// event trigger associated with syntax rule WithSyntaxSpec-optional
		public bool Raise_WithSyntaxSpec_optional_Event (SyntaxTreeCallbackReason reason, WithSyntaxSpec_optional.production_kind kind, WithSyntaxSpec_optional p_WithSyntaxSpec_optional)
		{
			bool? status = WithSyntaxSpec_optional_Event?.Invoke (reason, kind, p_WithSyntaxSpec_optional);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule WithSyntaxSpec-optional
		//
		// traverse syntax tree node associated with any production of syntax rule WithSyntaxSpec-optional
		//

		public void Traverse (WithSyntaxSpec_optional p_WithSyntaxSpec_optional)
		{
			if (p_WithSyntaxSpec_optional.isLocked())
				return;
			p_WithSyntaxSpec_optional.dolock();
			WithSyntaxSpec_optional.production_kind kind = (WithSyntaxSpec_optional.production_kind) p_WithSyntaxSpec_optional.kind;
			p_WithSyntaxSpec_optional.turn_reset ();
			if (Raise_WithSyntaxSpec_optional_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_WithSyntaxSpec_optional))
			switch (kind)
			{
				case WithSyntaxSpec_optional.production_kind.g_WithSyntaxSpec_optional_1:
					// traverse syntax tree node associated with production
					// WithSyntaxSpec-optional: %empty

				break;
				case WithSyntaxSpec_optional.production_kind.g_WithSyntaxSpec_optional_2:
					// traverse syntax tree node associated with production
					// WithSyntaxSpec-optional: WithSyntaxSpec

					if (Raise_WithSyntaxSpec_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_WithSyntaxSpec_optional))
						Traverse (p_WithSyntaxSpec_optional.m_WithSyntaxSpec);
					p_WithSyntaxSpec_optional.turn_inc ();
					Raise_WithSyntaxSpec_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_WithSyntaxSpec_optional);
				break;
			}
			Raise_WithSyntaxSpec_optional_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_WithSyntaxSpec_optional);
			p_WithSyntaxSpec_optional.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule WithSyntaxSpec-optional
		//

		public void TraverseCommon (WithSyntaxSpec_optional p_WithSyntaxSpec_optional)
		{
			WithSyntaxSpec_optional.production_kind kind = (WithSyntaxSpec_optional.production_kind) p_WithSyntaxSpec_optional.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_WithSyntaxSpec_optional))
			switch (kind)
			{
				case WithSyntaxSpec_optional.production_kind.g_WithSyntaxSpec_optional_1:
					// traverse syntax tree node associated with production
					// WithSyntaxSpec-optional: %empty

				break;
				case WithSyntaxSpec_optional.production_kind.g_WithSyntaxSpec_optional_2:
					// traverse syntax tree node associated with production
					// WithSyntaxSpec-optional: WithSyntaxSpec

						TraverseCommon (p_WithSyntaxSpec_optional.m_WithSyntaxSpec);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_WithSyntaxSpec_optional);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule WithSyntaxSpec-optional

		//
		// create syntax tree node associated with production
		// WithSyntaxSpec-optional: %empty

		//

		public WithSyntaxSpec_optional WithSyntaxSpec_optional_1 ()
		{
			WithSyntaxSpec_optional p_WithSyntaxSpec_optional_ref = new WithSyntaxSpec_optional();
			Raise_WithSyntaxSpec_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, WithSyntaxSpec_optional.production_kind.g_WithSyntaxSpec_optional_1, p_WithSyntaxSpec_optional_ref);
			return p_WithSyntaxSpec_optional_ref;
		}

		//
		// create syntax tree node associated with production
		// WithSyntaxSpec-optional: WithSyntaxSpec

		//

		public WithSyntaxSpec_optional WithSyntaxSpec_optional_2 (WithSyntaxSpec p_WithSyntaxSpec)
		{
			WithSyntaxSpec_optional p_WithSyntaxSpec_optional_ref = new WithSyntaxSpec_optional(p_WithSyntaxSpec);
			p_WithSyntaxSpec.parent = p_WithSyntaxSpec_optional_ref;
			Raise_WithSyntaxSpec_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, WithSyntaxSpec_optional.production_kind.g_WithSyntaxSpec_optional_2, p_WithSyntaxSpec_optional_ref);
			return p_WithSyntaxSpec_optional_ref;
		}
		#endregion
	};
}
