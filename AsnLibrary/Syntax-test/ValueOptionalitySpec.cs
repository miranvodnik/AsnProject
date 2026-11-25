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
	// class associated with syntax rule ValueOptionalitySpec
	//

	[DataContract]
	public class	ValueOptionalitySpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ValueOptionalitySpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ValueOptionalitySpec
		{
			g_ValueOptionalitySpec_1 = 1,	// OPTIONAL

			g_ValueOptionalitySpec_2 = 2,	// DEFAULT Value

		};
		#endregion
		#region production markers associated with the syntax rule ValueOptionalitySpec

		// markers associated with production: ValueOptionalitySpec -> OPTIONAL

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: ValueOptionalitySpec -> DEFAULT Value

		public enum production_marker_2 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ValueOptionalitySpec

		// Constructor declaration(s) associated with production(s) of syntax rule ValueOptionalitySpec

		//
		// Constructor associated with the following production(s)
		// ValueOptionalitySpec -> OPTIONAL

		//

		public ValueOptionalitySpec (SyntaxTreeToken p_token) : base ((uint) ProductionID._ValueOptionalitySpec_ID, (uint) production_kind.g_ValueOptionalitySpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OPTIONAL = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// ValueOptionalitySpec -> DEFAULT Value

		//

		public ValueOptionalitySpec (SyntaxTreeToken p_token, Value p_Value) : base ((uint) ProductionID._ValueOptionalitySpec_ID, (uint) production_kind.g_ValueOptionalitySpec_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DEFAULT = p_token;
			children[1] = m_Value = p_Value;
		}

		public ValueOptionalitySpec () { }

		// Copy constructor

		public ValueOptionalitySpec (ValueOptionalitySpec p_ValueOptionalitySpec) : base (p_ValueOptionalitySpec.id, p_ValueOptionalitySpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ValueOptionalitySpec.appInfo;
			switch ((production_kind) p_ValueOptionalitySpec.kind)
			{
				case production_kind.g_ValueOptionalitySpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OPTIONAL = (p_ValueOptionalitySpec.m_OPTIONAL != null) ? new SyntaxTreeToken (p_ValueOptionalitySpec.m_OPTIONAL) : null) != null) m_OPTIONAL.parent = this;
					break;
				case production_kind.g_ValueOptionalitySpec_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DEFAULT = (p_ValueOptionalitySpec.m_DEFAULT != null) ? new SyntaxTreeToken (p_ValueOptionalitySpec.m_DEFAULT) : null) != null) m_DEFAULT.parent = this;
					if ((children [1] = m_Value = (p_ValueOptionalitySpec.m_Value != null) ? new Value (p_ValueOptionalitySpec.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ValueOptionalitySpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ValueOptionalitySpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OPTIONAL?.Dispose ();
			m_DEFAULT?.Dispose ();
			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ValueOptionalitySpec

		// Content changing function(s) associated with production(s) of syntax rule ValueOptionalitySpec

		//
		// Content changing function associated with following production(s)
		// ValueOptionalitySpec -> OPTIONAL

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueOptionalitySpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OPTIONAL = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ValueOptionalitySpec -> DEFAULT Value

		//

		public void change(SyntaxTreeToken p_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueOptionalitySpec_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DEFAULT = p_token;
			children [1] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ValueOptionalitySpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OPTIONAL != null) && m_OPTIONAL.checkInclusion (element) ||
				(m_DEFAULT != null) && m_DEFAULT.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ValueOptionalitySpec

		//
		// emit production tree node associated with any production of syntax rule ValueOptionalitySpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ValueOptionalitySpec_1:
					// emit syntax tree node associated with production
					// ValueOptionalitySpec: OPTIONAL

					s += m_OPTIONAL.Emit (depth - 1);
				break;
				case production_kind.g_ValueOptionalitySpec_2:
					// emit syntax tree node associated with production
					// ValueOptionalitySpec: DEFAULT Value

					s += m_DEFAULT.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ValueOptionalitySpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ValueOptionalitySpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ValueOptionalitySpec_1:
					// emit syntax tree node associated with production
					// ValueOptionalitySpec: OPTIONAL

					s += "OPTIONAL";
				break;
				case production_kind.g_ValueOptionalitySpec_2:
					// emit syntax tree node associated with production
					// ValueOptionalitySpec: DEFAULT Value

					s += "DEFAULT";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ValueOptionalitySpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ValueOptionalitySpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ValueOptionalitySpec.production_kind kind = (ValueOptionalitySpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ValueOptionalitySpec.production_kind.g_ValueOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// ValueOptionalitySpec: OPTIONAL

						m_OPTIONAL.Visit (visitor, appData);
				break;
				case ValueOptionalitySpec.production_kind.g_ValueOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// ValueOptionalitySpec: DEFAULT Value

						m_DEFAULT.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_OPTIONAL?.reparent (this);
			m_DEFAULT?.reparent (this);
			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ValueOptionalitySpec
		//

		public void _init ()
		{
			m_OPTIONAL = null;
			m_DEFAULT = null;
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ValueOptionalitySpec

		// counter of all nodes associated with syntax rule ValueOptionalitySpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ValueOptionalitySpec
		[DataMember (Name = "m_OPTIONAL")] public SyntaxTreeToken m_OPTIONAL { get; private set; }
		[DataMember (Name = "m_DEFAULT")] public SyntaxTreeToken m_DEFAULT { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ValueOptionalitySpec

		// delegate function (callback) prototype associated with syntax rule ValueOptionalitySpec
		public delegate bool ValueOptionalitySpec_Callback (SyntaxTreeCallbackReason reason, ValueOptionalitySpec.production_kind kind, ValueOptionalitySpec p_ValueOptionalitySpec);

		// event associated with syntax rule ValueOptionalitySpec
		public event ValueOptionalitySpec_Callback ValueOptionalitySpec_Event;

		// event trigger associated with syntax rule ValueOptionalitySpec
		public bool Raise_ValueOptionalitySpec_Event (SyntaxTreeCallbackReason reason, ValueOptionalitySpec.production_kind kind, ValueOptionalitySpec p_ValueOptionalitySpec)
		{
			bool? status = ValueOptionalitySpec_Event?.Invoke (reason, kind, p_ValueOptionalitySpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ValueOptionalitySpec
		//
		// traverse syntax tree node associated with any production of syntax rule ValueOptionalitySpec
		//

		public void Traverse (ValueOptionalitySpec p_ValueOptionalitySpec)
		{
			if (p_ValueOptionalitySpec.isLocked())
				return;
			p_ValueOptionalitySpec.dolock();
			ValueOptionalitySpec.production_kind kind = (ValueOptionalitySpec.production_kind) p_ValueOptionalitySpec.kind;
			p_ValueOptionalitySpec.turn_reset ();
			if (Raise_ValueOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ValueOptionalitySpec))
			switch (kind)
			{
				case ValueOptionalitySpec.production_kind.g_ValueOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// ValueOptionalitySpec: OPTIONAL

				break;
				case ValueOptionalitySpec.production_kind.g_ValueOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// ValueOptionalitySpec: DEFAULT Value

					if (Raise_ValueOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueOptionalitySpec))
						Traverse (p_ValueOptionalitySpec.m_Value);
					p_ValueOptionalitySpec.turn_inc ();
					Raise_ValueOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueOptionalitySpec);
				break;
			}
			Raise_ValueOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ValueOptionalitySpec);
			p_ValueOptionalitySpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ValueOptionalitySpec
		//

		public void TraverseCommon (ValueOptionalitySpec p_ValueOptionalitySpec)
		{
			ValueOptionalitySpec.production_kind kind = (ValueOptionalitySpec.production_kind) p_ValueOptionalitySpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ValueOptionalitySpec))
			switch (kind)
			{
				case ValueOptionalitySpec.production_kind.g_ValueOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// ValueOptionalitySpec: OPTIONAL

						TraverseCommon (p_ValueOptionalitySpec.m_OPTIONAL);
				break;
				case ValueOptionalitySpec.production_kind.g_ValueOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// ValueOptionalitySpec: DEFAULT Value

						TraverseCommon (p_ValueOptionalitySpec.m_DEFAULT);
						TraverseCommon (p_ValueOptionalitySpec.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ValueOptionalitySpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ValueOptionalitySpec

		//
		// create syntax tree node associated with production
		// ValueOptionalitySpec: OPTIONAL

		//

		public ValueOptionalitySpec ValueOptionalitySpec_1 (SyntaxTreeToken p_token)
		{
			ValueOptionalitySpec p_ValueOptionalitySpec_ref = new ValueOptionalitySpec(p_token);
			p_token.parent = p_ValueOptionalitySpec_ref;
			Raise_ValueOptionalitySpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueOptionalitySpec.production_kind.g_ValueOptionalitySpec_1, p_ValueOptionalitySpec_ref);
			return p_ValueOptionalitySpec_ref;
		}

		//
		// create syntax tree node associated with production
		// ValueOptionalitySpec: DEFAULT Value

		//

		public ValueOptionalitySpec ValueOptionalitySpec_2 (SyntaxTreeToken p_token, Value p_Value)
		{
			ValueOptionalitySpec p_ValueOptionalitySpec_ref = new ValueOptionalitySpec(p_token, p_Value);
			p_token.parent = p_ValueOptionalitySpec_ref;
			p_Value.parent = p_ValueOptionalitySpec_ref;
			Raise_ValueOptionalitySpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueOptionalitySpec.production_kind.g_ValueOptionalitySpec_2, p_ValueOptionalitySpec_ref);
			return p_ValueOptionalitySpec_ref;
		}
		#endregion
	};
}
