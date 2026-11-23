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
	// class associated with syntax rule ValueSetOptionalitySpec-optional
	//

	[DataContract]
	public class	ValueSetOptionalitySpec_optional : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ValueSetOptionalitySpec-optional
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ValueSetOptionalitySpec-optional
		{
			g_ValueSetOptionalitySpec_optional_1 = 1,	// %empty

			g_ValueSetOptionalitySpec_optional_2 = 2,	// ValueSetOptionalitySpec

		};
		#endregion
		#region production markers associated with the syntax rule ValueSetOptionalitySpec-optional

		// markers associated with production: ValueSetOptionalitySpec-optional -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: ValueSetOptionalitySpec-optional -> ValueSetOptionalitySpec

		public enum production_marker_2 : ushort
		{
			m_ValueSetOptionalitySpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ValueSetOptionalitySpec-optional

		// Constructor declaration(s) associated with production(s) of syntax rule ValueSetOptionalitySpec-optional

		//
		// Constructor associated with the following production(s)
		// ValueSetOptionalitySpec-optional -> %empty

		//

		public ValueSetOptionalitySpec_optional () : base ((uint) ProductionID._ValueSetOptionalitySpec_optional_ID, (uint) production_kind.g_ValueSetOptionalitySpec_optional_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// ValueSetOptionalitySpec-optional -> ValueSetOptionalitySpec

		//

		public ValueSetOptionalitySpec_optional (ValueSetOptionalitySpec p_ValueSetOptionalitySpec) : base ((uint) ProductionID._ValueSetOptionalitySpec_optional_ID, (uint) production_kind.g_ValueSetOptionalitySpec_optional_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ValueSetOptionalitySpec = p_ValueSetOptionalitySpec;
		}

		// Copy constructor

		public ValueSetOptionalitySpec_optional (ValueSetOptionalitySpec_optional p_ValueSetOptionalitySpec_optional) : base (p_ValueSetOptionalitySpec_optional.id, p_ValueSetOptionalitySpec_optional.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ValueSetOptionalitySpec_optional.appInfo;
			switch ((production_kind) p_ValueSetOptionalitySpec_optional.kind)
			{
				case production_kind.g_ValueSetOptionalitySpec_optional_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_ValueSetOptionalitySpec_optional_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ValueSetOptionalitySpec = (p_ValueSetOptionalitySpec_optional.m_ValueSetOptionalitySpec != null) ? new ValueSetOptionalitySpec (p_ValueSetOptionalitySpec_optional.m_ValueSetOptionalitySpec) : null) != null) m_ValueSetOptionalitySpec.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ValueSetOptionalitySpec_optional" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ValueSetOptionalitySpec_optional (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ValueSetOptionalitySpec?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ValueSetOptionalitySpec-optional

		// Content changing function(s) associated with production(s) of syntax rule ValueSetOptionalitySpec-optional

		//
		// Content changing function associated with following production(s)
		// ValueSetOptionalitySpec-optional -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueSetOptionalitySpec_optional_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ValueSetOptionalitySpec-optional -> ValueSetOptionalitySpec

		//

		public void change(ValueSetOptionalitySpec p_ValueSetOptionalitySpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueSetOptionalitySpec_optional_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ValueSetOptionalitySpec = p_ValueSetOptionalitySpec;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ValueSetOptionalitySpec-optional
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ValueSetOptionalitySpec != null) && m_ValueSetOptionalitySpec.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ValueSetOptionalitySpec-optional

		//
		// emit production tree node associated with any production of syntax rule ValueSetOptionalitySpec-optional
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ValueSetOptionalitySpec_optional_1:
					// emit syntax tree node associated with production
					// ValueSetOptionalitySpec-optional: %empty

				break;
				case production_kind.g_ValueSetOptionalitySpec_optional_2:
					// emit syntax tree node associated with production
					// ValueSetOptionalitySpec-optional: ValueSetOptionalitySpec

					s += m_ValueSetOptionalitySpec.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ValueSetOptionalitySpec-optional
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ValueSetOptionalitySpec_optional (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ValueSetOptionalitySpec_optional_1:
					// emit syntax tree node associated with production
					// ValueSetOptionalitySpec-optional: %empty

				break;
				case production_kind.g_ValueSetOptionalitySpec_optional_2:
					// emit syntax tree node associated with production
					// ValueSetOptionalitySpec-optional: ValueSetOptionalitySpec

					s += m_ValueSetOptionalitySpec.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ValueSetOptionalitySpec-optional

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ValueSetOptionalitySpec-optional with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ValueSetOptionalitySpec_optional.production_kind kind = (ValueSetOptionalitySpec_optional.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ValueSetOptionalitySpec_optional.production_kind.g_ValueSetOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// ValueSetOptionalitySpec-optional: %empty

				break;
				case ValueSetOptionalitySpec_optional.production_kind.g_ValueSetOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// ValueSetOptionalitySpec-optional: ValueSetOptionalitySpec

						m_ValueSetOptionalitySpec.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ValueSetOptionalitySpec?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ValueSetOptionalitySpec-optional
		//

		public void _init ()
		{
			m_ValueSetOptionalitySpec = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ValueSetOptionalitySpec-optional

		// counter of all nodes associated with syntax rule ValueSetOptionalitySpec-optional
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ValueSetOptionalitySpec-optional
		[DataMember (Name = "m_ValueSetOptionalitySpec")] public ValueSetOptionalitySpec m_ValueSetOptionalitySpec { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ValueSetOptionalitySpec-optional

		// delegate function (callback) prototype associated with syntax rule ValueSetOptionalitySpec-optional
		public delegate bool ValueSetOptionalitySpec_optional_Callback (SyntaxTreeCallbackReason reason, ValueSetOptionalitySpec_optional.production_kind kind, ValueSetOptionalitySpec_optional p_ValueSetOptionalitySpec_optional);

		// event associated with syntax rule ValueSetOptionalitySpec-optional
		public event ValueSetOptionalitySpec_optional_Callback ValueSetOptionalitySpec_optional_Event;

		// event trigger associated with syntax rule ValueSetOptionalitySpec-optional
		public bool Raise_ValueSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason reason, ValueSetOptionalitySpec_optional.production_kind kind, ValueSetOptionalitySpec_optional p_ValueSetOptionalitySpec_optional)
		{
			bool? status = ValueSetOptionalitySpec_optional_Event?.Invoke (reason, kind, p_ValueSetOptionalitySpec_optional);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ValueSetOptionalitySpec-optional
		//
		// traverse syntax tree node associated with any production of syntax rule ValueSetOptionalitySpec-optional
		//

		public void Traverse (ValueSetOptionalitySpec_optional p_ValueSetOptionalitySpec_optional)
		{
			if (p_ValueSetOptionalitySpec_optional.isLocked())
				return;
			p_ValueSetOptionalitySpec_optional.dolock();
			ValueSetOptionalitySpec_optional.production_kind kind = (ValueSetOptionalitySpec_optional.production_kind) p_ValueSetOptionalitySpec_optional.kind;
			p_ValueSetOptionalitySpec_optional.turn_reset ();
			if (Raise_ValueSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ValueSetOptionalitySpec_optional))
			switch (kind)
			{
				case ValueSetOptionalitySpec_optional.production_kind.g_ValueSetOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// ValueSetOptionalitySpec-optional: %empty

				break;
				case ValueSetOptionalitySpec_optional.production_kind.g_ValueSetOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// ValueSetOptionalitySpec-optional: ValueSetOptionalitySpec

					if (Raise_ValueSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueSetOptionalitySpec_optional))
						Traverse (p_ValueSetOptionalitySpec_optional.m_ValueSetOptionalitySpec);
					p_ValueSetOptionalitySpec_optional.turn_inc ();
					Raise_ValueSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueSetOptionalitySpec_optional);
				break;
			}
			Raise_ValueSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ValueSetOptionalitySpec_optional);
			p_ValueSetOptionalitySpec_optional.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ValueSetOptionalitySpec-optional
		//

		public void TraverseCommon (ValueSetOptionalitySpec_optional p_ValueSetOptionalitySpec_optional)
		{
			ValueSetOptionalitySpec_optional.production_kind kind = (ValueSetOptionalitySpec_optional.production_kind) p_ValueSetOptionalitySpec_optional.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ValueSetOptionalitySpec_optional))
			switch (kind)
			{
				case ValueSetOptionalitySpec_optional.production_kind.g_ValueSetOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// ValueSetOptionalitySpec-optional: %empty

				break;
				case ValueSetOptionalitySpec_optional.production_kind.g_ValueSetOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// ValueSetOptionalitySpec-optional: ValueSetOptionalitySpec

						TraverseCommon (p_ValueSetOptionalitySpec_optional.m_ValueSetOptionalitySpec);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ValueSetOptionalitySpec_optional);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ValueSetOptionalitySpec-optional

		//
		// create syntax tree node associated with production
		// ValueSetOptionalitySpec-optional: %empty

		//

		public ValueSetOptionalitySpec_optional ValueSetOptionalitySpec_optional_1 ()
		{
			ValueSetOptionalitySpec_optional p_ValueSetOptionalitySpec_optional_ref = new ValueSetOptionalitySpec_optional();
			Raise_ValueSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueSetOptionalitySpec_optional.production_kind.g_ValueSetOptionalitySpec_optional_1, p_ValueSetOptionalitySpec_optional_ref);
			return p_ValueSetOptionalitySpec_optional_ref;
		}

		//
		// create syntax tree node associated with production
		// ValueSetOptionalitySpec-optional: ValueSetOptionalitySpec

		//

		public ValueSetOptionalitySpec_optional ValueSetOptionalitySpec_optional_2 (ValueSetOptionalitySpec p_ValueSetOptionalitySpec)
		{
			ValueSetOptionalitySpec_optional p_ValueSetOptionalitySpec_optional_ref = new ValueSetOptionalitySpec_optional(p_ValueSetOptionalitySpec);
			p_ValueSetOptionalitySpec.parent = p_ValueSetOptionalitySpec_optional_ref;
			Raise_ValueSetOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueSetOptionalitySpec_optional.production_kind.g_ValueSetOptionalitySpec_optional_2, p_ValueSetOptionalitySpec_optional_ref);
			return p_ValueSetOptionalitySpec_optional_ref;
		}
		#endregion
	};
}
