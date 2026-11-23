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
	// class associated with syntax rule ValueOptionalitySpec-optional
	//

	[DataContract]
	public class	ValueOptionalitySpec_optional : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ValueOptionalitySpec-optional
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ValueOptionalitySpec-optional
		{
			g_ValueOptionalitySpec_optional_1 = 1,	// %empty

			g_ValueOptionalitySpec_optional_2 = 2,	// ValueOptionalitySpec

		};
		#endregion
		#region production markers associated with the syntax rule ValueOptionalitySpec-optional

		// markers associated with production: ValueOptionalitySpec-optional -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: ValueOptionalitySpec-optional -> ValueOptionalitySpec

		public enum production_marker_2 : ushort
		{
			m_ValueOptionalitySpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ValueOptionalitySpec-optional

		// Constructor declaration(s) associated with production(s) of syntax rule ValueOptionalitySpec-optional

		//
		// Constructor associated with the following production(s)
		// ValueOptionalitySpec-optional -> %empty

		//

		public ValueOptionalitySpec_optional () : base ((uint) ProductionID._ValueOptionalitySpec_optional_ID, (uint) production_kind.g_ValueOptionalitySpec_optional_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// ValueOptionalitySpec-optional -> ValueOptionalitySpec

		//

		public ValueOptionalitySpec_optional (ValueOptionalitySpec p_ValueOptionalitySpec) : base ((uint) ProductionID._ValueOptionalitySpec_optional_ID, (uint) production_kind.g_ValueOptionalitySpec_optional_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ValueOptionalitySpec = p_ValueOptionalitySpec;
		}

		// Copy constructor

		public ValueOptionalitySpec_optional (ValueOptionalitySpec_optional p_ValueOptionalitySpec_optional) : base (p_ValueOptionalitySpec_optional.id, p_ValueOptionalitySpec_optional.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ValueOptionalitySpec_optional.appInfo;
			switch ((production_kind) p_ValueOptionalitySpec_optional.kind)
			{
				case production_kind.g_ValueOptionalitySpec_optional_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_ValueOptionalitySpec_optional_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ValueOptionalitySpec = (p_ValueOptionalitySpec_optional.m_ValueOptionalitySpec != null) ? new ValueOptionalitySpec (p_ValueOptionalitySpec_optional.m_ValueOptionalitySpec) : null) != null) m_ValueOptionalitySpec.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ValueOptionalitySpec_optional" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ValueOptionalitySpec_optional (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ValueOptionalitySpec?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ValueOptionalitySpec-optional

		// Content changing function(s) associated with production(s) of syntax rule ValueOptionalitySpec-optional

		//
		// Content changing function associated with following production(s)
		// ValueOptionalitySpec-optional -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueOptionalitySpec_optional_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ValueOptionalitySpec-optional -> ValueOptionalitySpec

		//

		public void change(ValueOptionalitySpec p_ValueOptionalitySpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueOptionalitySpec_optional_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ValueOptionalitySpec = p_ValueOptionalitySpec;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ValueOptionalitySpec-optional
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ValueOptionalitySpec != null) && m_ValueOptionalitySpec.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ValueOptionalitySpec-optional

		//
		// emit production tree node associated with any production of syntax rule ValueOptionalitySpec-optional
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ValueOptionalitySpec_optional_1:
					// emit syntax tree node associated with production
					// ValueOptionalitySpec-optional: %empty

				break;
				case production_kind.g_ValueOptionalitySpec_optional_2:
					// emit syntax tree node associated with production
					// ValueOptionalitySpec-optional: ValueOptionalitySpec

					s += m_ValueOptionalitySpec.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ValueOptionalitySpec-optional
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ValueOptionalitySpec_optional (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ValueOptionalitySpec_optional_1:
					// emit syntax tree node associated with production
					// ValueOptionalitySpec-optional: %empty

				break;
				case production_kind.g_ValueOptionalitySpec_optional_2:
					// emit syntax tree node associated with production
					// ValueOptionalitySpec-optional: ValueOptionalitySpec

					s += m_ValueOptionalitySpec.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ValueOptionalitySpec-optional

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ValueOptionalitySpec-optional with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ValueOptionalitySpec_optional.production_kind kind = (ValueOptionalitySpec_optional.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ValueOptionalitySpec_optional.production_kind.g_ValueOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// ValueOptionalitySpec-optional: %empty

				break;
				case ValueOptionalitySpec_optional.production_kind.g_ValueOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// ValueOptionalitySpec-optional: ValueOptionalitySpec

						m_ValueOptionalitySpec.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ValueOptionalitySpec?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ValueOptionalitySpec-optional
		//

		public void _init ()
		{
			m_ValueOptionalitySpec = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ValueOptionalitySpec-optional

		// counter of all nodes associated with syntax rule ValueOptionalitySpec-optional
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ValueOptionalitySpec-optional
		[DataMember (Name = "m_ValueOptionalitySpec")] public ValueOptionalitySpec m_ValueOptionalitySpec { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ValueOptionalitySpec-optional

		// delegate function (callback) prototype associated with syntax rule ValueOptionalitySpec-optional
		public delegate bool ValueOptionalitySpec_optional_Callback (SyntaxTreeCallbackReason reason, ValueOptionalitySpec_optional.production_kind kind, ValueOptionalitySpec_optional p_ValueOptionalitySpec_optional);

		// event associated with syntax rule ValueOptionalitySpec-optional
		public event ValueOptionalitySpec_optional_Callback ValueOptionalitySpec_optional_Event;

		// event trigger associated with syntax rule ValueOptionalitySpec-optional
		public bool Raise_ValueOptionalitySpec_optional_Event (SyntaxTreeCallbackReason reason, ValueOptionalitySpec_optional.production_kind kind, ValueOptionalitySpec_optional p_ValueOptionalitySpec_optional)
		{
			bool? status = ValueOptionalitySpec_optional_Event?.Invoke (reason, kind, p_ValueOptionalitySpec_optional);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ValueOptionalitySpec-optional
		//
		// traverse syntax tree node associated with any production of syntax rule ValueOptionalitySpec-optional
		//

		public void Traverse (ValueOptionalitySpec_optional p_ValueOptionalitySpec_optional)
		{
			if (p_ValueOptionalitySpec_optional.isLocked())
				return;
			p_ValueOptionalitySpec_optional.dolock();
			ValueOptionalitySpec_optional.production_kind kind = (ValueOptionalitySpec_optional.production_kind) p_ValueOptionalitySpec_optional.kind;
			p_ValueOptionalitySpec_optional.turn_reset ();
			if (Raise_ValueOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ValueOptionalitySpec_optional))
			switch (kind)
			{
				case ValueOptionalitySpec_optional.production_kind.g_ValueOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// ValueOptionalitySpec-optional: %empty

				break;
				case ValueOptionalitySpec_optional.production_kind.g_ValueOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// ValueOptionalitySpec-optional: ValueOptionalitySpec

					if (Raise_ValueOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueOptionalitySpec_optional))
						Traverse (p_ValueOptionalitySpec_optional.m_ValueOptionalitySpec);
					p_ValueOptionalitySpec_optional.turn_inc ();
					Raise_ValueOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueOptionalitySpec_optional);
				break;
			}
			Raise_ValueOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ValueOptionalitySpec_optional);
			p_ValueOptionalitySpec_optional.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ValueOptionalitySpec-optional
		//

		public void TraverseCommon (ValueOptionalitySpec_optional p_ValueOptionalitySpec_optional)
		{
			ValueOptionalitySpec_optional.production_kind kind = (ValueOptionalitySpec_optional.production_kind) p_ValueOptionalitySpec_optional.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ValueOptionalitySpec_optional))
			switch (kind)
			{
				case ValueOptionalitySpec_optional.production_kind.g_ValueOptionalitySpec_optional_1:
					// traverse syntax tree node associated with production
					// ValueOptionalitySpec-optional: %empty

				break;
				case ValueOptionalitySpec_optional.production_kind.g_ValueOptionalitySpec_optional_2:
					// traverse syntax tree node associated with production
					// ValueOptionalitySpec-optional: ValueOptionalitySpec

						TraverseCommon (p_ValueOptionalitySpec_optional.m_ValueOptionalitySpec);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ValueOptionalitySpec_optional);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ValueOptionalitySpec-optional

		//
		// create syntax tree node associated with production
		// ValueOptionalitySpec-optional: %empty

		//

		public ValueOptionalitySpec_optional ValueOptionalitySpec_optional_1 ()
		{
			ValueOptionalitySpec_optional p_ValueOptionalitySpec_optional_ref = new ValueOptionalitySpec_optional();
			Raise_ValueOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueOptionalitySpec_optional.production_kind.g_ValueOptionalitySpec_optional_1, p_ValueOptionalitySpec_optional_ref);
			return p_ValueOptionalitySpec_optional_ref;
		}

		//
		// create syntax tree node associated with production
		// ValueOptionalitySpec-optional: ValueOptionalitySpec

		//

		public ValueOptionalitySpec_optional ValueOptionalitySpec_optional_2 (ValueOptionalitySpec p_ValueOptionalitySpec)
		{
			ValueOptionalitySpec_optional p_ValueOptionalitySpec_optional_ref = new ValueOptionalitySpec_optional(p_ValueOptionalitySpec);
			p_ValueOptionalitySpec.parent = p_ValueOptionalitySpec_optional_ref;
			Raise_ValueOptionalitySpec_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueOptionalitySpec_optional.production_kind.g_ValueOptionalitySpec_optional_2, p_ValueOptionalitySpec_optional_ref);
			return p_ValueOptionalitySpec_optional_ref;
		}
		#endregion
	};
}
