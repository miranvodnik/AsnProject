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
	// class associated with syntax rule <generated-rule-4>
	//

	[DataContract]
	public class	_generated_rule_4_ : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule <generated-rule-4>
		public enum production_kind : ushort	// enumerated production(s) of syntax rule <generated-rule-4>
		{
			g__generated_rule_4__1 = 1,	// %empty

			g__generated_rule_4__2 = 2,	// <generated-rule-4> ","

		};
		#endregion
		#region production markers associated with the syntax rule <generated-rule-4>

		// markers associated with production: <generated-rule-4> -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: <generated-rule-4> -> <generated-rule-4> ","

		public enum production_marker_2 : ushort
		{
			m__generated_rule_4_,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule <generated-rule-4>

		// Constructor declaration(s) associated with production(s) of syntax rule <generated-rule-4>

		//
		// Constructor associated with the following production(s)
		// <generated-rule-4> -> %empty

		//

		public _generated_rule_4_ () : base ((uint) ProductionID.__generated_rule_4__ID, (uint) production_kind.g__generated_rule_4__1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// <generated-rule-4> -> <generated-rule-4> ","

		//

		public _generated_rule_4_ (_generated_rule_4_ p__generated_rule_4_, SyntaxTreeToken p_token) : base ((uint) ProductionID.__generated_rule_4__ID, (uint) production_kind.g__generated_rule_4__2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m__generated_rule_4_ = p__generated_rule_4_;
			children[1] = m_comma = p_token;
		}

		// Copy constructor

		public _generated_rule_4_ (_generated_rule_4_ p__generated_rule_4_) : base (p__generated_rule_4_.id, p__generated_rule_4_.kind)
		{
			++g_counter;
			_init ();
			appInfo = p__generated_rule_4_.appInfo;
			switch ((production_kind) p__generated_rule_4_.kind)
			{
				case production_kind.g__generated_rule_4__1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g__generated_rule_4__2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m__generated_rule_4_ = (p__generated_rule_4_.m__generated_rule_4_ != null) ? new _generated_rule_4_ (p__generated_rule_4_.m__generated_rule_4_) : null) != null) m__generated_rule_4_.parent = this;
					if ((children [1] = m_comma = (p__generated_rule_4_.m_comma != null) ? new SyntaxTreeToken (p__generated_rule_4_.m_comma) : null) != null) m_comma.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "_generated_rule_4_" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new _generated_rule_4_ (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m__generated_rule_4_?.Dispose ();
			m_comma?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule <generated-rule-4>

		// Content changing function(s) associated with production(s) of syntax rule <generated-rule-4>

		//
		// Content changing function associated with following production(s)
		// <generated-rule-4> -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g__generated_rule_4__1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// <generated-rule-4> -> <generated-rule-4> ","

		//

		public void change(_generated_rule_4_ p__generated_rule_4_, SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g__generated_rule_4__2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m__generated_rule_4_ = p__generated_rule_4_;
			children [1] = m_comma = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule <generated-rule-4>
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m__generated_rule_4_ != null) && m__generated_rule_4_.checkInclusion (element) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule <generated-rule-4>

		//
		// emit production tree node associated with any production of syntax rule <generated-rule-4>
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g__generated_rule_4__1:
					// emit syntax tree node associated with production
					// <generated-rule-4>: %empty

				break;
				case production_kind.g__generated_rule_4__2:
					// emit syntax tree node associated with production
					// <generated-rule-4>: <generated-rule-4> ","

					s += m__generated_rule_4_.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule <generated-rule-4>
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "_generated_rule_4_ (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g__generated_rule_4__1:
					// emit syntax tree node associated with production
					// <generated-rule-4>: %empty

				break;
				case production_kind.g__generated_rule_4__2:
					// emit syntax tree node associated with production
					// <generated-rule-4>: <generated-rule-4> ","

					s += m__generated_rule_4_.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule <generated-rule-4>

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule <generated-rule-4> with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			_generated_rule_4_.production_kind kind = (_generated_rule_4_.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case _generated_rule_4_.production_kind.g__generated_rule_4__1:
					// traverse syntax tree node associated with production
					// <generated-rule-4>: %empty

				break;
				case _generated_rule_4_.production_kind.g__generated_rule_4__2:
					// traverse syntax tree node associated with production
					// <generated-rule-4>: <generated-rule-4> ","

						m__generated_rule_4_.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m__generated_rule_4_?.reparent (this);
			m_comma?.reparent (this);
		}

		//
		// initialize object associated with syntax rule <generated-rule-4>
		//

		public void _init ()
		{
			m__generated_rule_4_ = null;
			m_comma = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule <generated-rule-4>

		// counter of all nodes associated with syntax rule <generated-rule-4>
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule <generated-rule-4>
		[DataMember (Name = "m__generated_rule_4_")] public _generated_rule_4_ m__generated_rule_4_ { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule <generated-rule-4>

		// delegate function (callback) prototype associated with syntax rule <generated-rule-4>
		public delegate bool _generated_rule_4__Callback (SyntaxTreeCallbackReason reason, _generated_rule_4_.production_kind kind, _generated_rule_4_ p__generated_rule_4_);

		// event associated with syntax rule <generated-rule-4>
		public event _generated_rule_4__Callback _generated_rule_4__Event;

		// event trigger associated with syntax rule <generated-rule-4>
		public bool Raise__generated_rule_4__Event (SyntaxTreeCallbackReason reason, _generated_rule_4_.production_kind kind, _generated_rule_4_ p__generated_rule_4_)
		{
			bool? status = _generated_rule_4__Event?.Invoke (reason, kind, p__generated_rule_4_);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule <generated-rule-4>
		//
		// traverse syntax tree node associated with any production of syntax rule <generated-rule-4>
		//

		public void Traverse (_generated_rule_4_ p__generated_rule_4_)
		{
			if (p__generated_rule_4_.isLocked())
				return;
			p__generated_rule_4_.dolock();
			_generated_rule_4_.production_kind kind = (_generated_rule_4_.production_kind) p__generated_rule_4_.kind;
			p__generated_rule_4_.turn_reset ();
			if (Raise__generated_rule_4__Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p__generated_rule_4_))
			switch (kind)
			{
				case _generated_rule_4_.production_kind.g__generated_rule_4__1:
					// traverse syntax tree node associated with production
					// <generated-rule-4>: %empty

				break;
				case _generated_rule_4_.production_kind.g__generated_rule_4__2:
					// traverse syntax tree node associated with production
					// <generated-rule-4>: <generated-rule-4> ","

					if (Raise__generated_rule_4__Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p__generated_rule_4_))
						Traverse (p__generated_rule_4_.m__generated_rule_4_);
					p__generated_rule_4_.turn_inc ();
					Raise__generated_rule_4__Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p__generated_rule_4_);
				break;
			}
			Raise__generated_rule_4__Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p__generated_rule_4_);
			p__generated_rule_4_.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule <generated-rule-4>
		//

		public void TraverseCommon (_generated_rule_4_ p__generated_rule_4_)
		{
			_generated_rule_4_.production_kind kind = (_generated_rule_4_.production_kind) p__generated_rule_4_.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p__generated_rule_4_))
			switch (kind)
			{
				case _generated_rule_4_.production_kind.g__generated_rule_4__1:
					// traverse syntax tree node associated with production
					// <generated-rule-4>: %empty

				break;
				case _generated_rule_4_.production_kind.g__generated_rule_4__2:
					// traverse syntax tree node associated with production
					// <generated-rule-4>: <generated-rule-4> ","

						TraverseCommon (p__generated_rule_4_.m__generated_rule_4_);
						TraverseCommon (p__generated_rule_4_.m_comma);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p__generated_rule_4_);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule <generated-rule-4>

		//
		// create syntax tree node associated with production
		// <generated-rule-4>: %empty

		//

		public _generated_rule_4_ _generated_rule_4__1 ()
		{
			_generated_rule_4_ p__generated_rule_4__ref = new _generated_rule_4_();
			Raise__generated_rule_4__Event (SyntaxTreeCallbackReason.BuilderCallbackReason, _generated_rule_4_.production_kind.g__generated_rule_4__1, p__generated_rule_4__ref);
			return p__generated_rule_4__ref;
		}

		//
		// create syntax tree node associated with production
		// <generated-rule-4>: <generated-rule-4> ","

		//

		public _generated_rule_4_ _generated_rule_4__2 (_generated_rule_4_ p__generated_rule_4_, SyntaxTreeToken p_token)
		{
			_generated_rule_4_ p__generated_rule_4__ref = new _generated_rule_4_(p__generated_rule_4_, p_token);
			p__generated_rule_4_.parent = p__generated_rule_4__ref;
			p_token.parent = p__generated_rule_4__ref;
			Raise__generated_rule_4__Event (SyntaxTreeCallbackReason.BuilderCallbackReason, _generated_rule_4_.production_kind.g__generated_rule_4__2, p__generated_rule_4__ref);
			return p__generated_rule_4__ref;
		}
		#endregion
	};
}
