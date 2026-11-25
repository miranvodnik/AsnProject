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
	// class associated with syntax rule ValueSetOptionalitySpec
	//

	[DataContract]
	public class	ValueSetOptionalitySpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ValueSetOptionalitySpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ValueSetOptionalitySpec
		{
			g_ValueSetOptionalitySpec_1 = 1,	// OPTIONAL

			g_ValueSetOptionalitySpec_2 = 2,	// DEFAULT ValueSet

		};
		#endregion
		#region production markers associated with the syntax rule ValueSetOptionalitySpec

		// markers associated with production: ValueSetOptionalitySpec -> OPTIONAL

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: ValueSetOptionalitySpec -> DEFAULT ValueSet

		public enum production_marker_2 : ushort
		{
			m_ValueSet,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ValueSetOptionalitySpec

		// Constructor declaration(s) associated with production(s) of syntax rule ValueSetOptionalitySpec

		//
		// Constructor associated with the following production(s)
		// ValueSetOptionalitySpec -> OPTIONAL

		//

		public ValueSetOptionalitySpec (SyntaxTreeToken p_token) : base ((uint) ProductionID._ValueSetOptionalitySpec_ID, (uint) production_kind.g_ValueSetOptionalitySpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OPTIONAL = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// ValueSetOptionalitySpec -> DEFAULT ValueSet

		//

		public ValueSetOptionalitySpec (SyntaxTreeToken p_token, ValueSet p_ValueSet) : base ((uint) ProductionID._ValueSetOptionalitySpec_ID, (uint) production_kind.g_ValueSetOptionalitySpec_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DEFAULT = p_token;
			children[1] = m_ValueSet = p_ValueSet;
		}

		public ValueSetOptionalitySpec () { }

		// Copy constructor

		public ValueSetOptionalitySpec (ValueSetOptionalitySpec p_ValueSetOptionalitySpec) : base (p_ValueSetOptionalitySpec.id, p_ValueSetOptionalitySpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ValueSetOptionalitySpec.appInfo;
			switch ((production_kind) p_ValueSetOptionalitySpec.kind)
			{
				case production_kind.g_ValueSetOptionalitySpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OPTIONAL = (p_ValueSetOptionalitySpec.m_OPTIONAL != null) ? new SyntaxTreeToken (p_ValueSetOptionalitySpec.m_OPTIONAL) : null) != null) m_OPTIONAL.parent = this;
					break;
				case production_kind.g_ValueSetOptionalitySpec_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DEFAULT = (p_ValueSetOptionalitySpec.m_DEFAULT != null) ? new SyntaxTreeToken (p_ValueSetOptionalitySpec.m_DEFAULT) : null) != null) m_DEFAULT.parent = this;
					if ((children [1] = m_ValueSet = (p_ValueSetOptionalitySpec.m_ValueSet != null) ? new ValueSet (p_ValueSetOptionalitySpec.m_ValueSet) : null) != null) m_ValueSet.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ValueSetOptionalitySpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ValueSetOptionalitySpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OPTIONAL?.Dispose ();
			m_DEFAULT?.Dispose ();
			m_ValueSet?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ValueSetOptionalitySpec

		// Content changing function(s) associated with production(s) of syntax rule ValueSetOptionalitySpec

		//
		// Content changing function associated with following production(s)
		// ValueSetOptionalitySpec -> OPTIONAL

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueSetOptionalitySpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OPTIONAL = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ValueSetOptionalitySpec -> DEFAULT ValueSet

		//

		public void change(SyntaxTreeToken p_token, ValueSet p_ValueSet)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueSetOptionalitySpec_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DEFAULT = p_token;
			children [1] = m_ValueSet = p_ValueSet;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ValueSetOptionalitySpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OPTIONAL != null) && m_OPTIONAL.checkInclusion (element) ||
				(m_DEFAULT != null) && m_DEFAULT.checkInclusion (element) ||
				(m_ValueSet != null) && m_ValueSet.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ValueSetOptionalitySpec

		//
		// emit production tree node associated with any production of syntax rule ValueSetOptionalitySpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ValueSetOptionalitySpec_1:
					// emit syntax tree node associated with production
					// ValueSetOptionalitySpec: OPTIONAL

					s += m_OPTIONAL.Emit (depth - 1);
				break;
				case production_kind.g_ValueSetOptionalitySpec_2:
					// emit syntax tree node associated with production
					// ValueSetOptionalitySpec: DEFAULT ValueSet

					s += m_DEFAULT.Emit (depth - 1);
					s += " ";
					s += m_ValueSet.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ValueSetOptionalitySpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ValueSetOptionalitySpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ValueSetOptionalitySpec_1:
					// emit syntax tree node associated with production
					// ValueSetOptionalitySpec: OPTIONAL

					s += "OPTIONAL";
				break;
				case production_kind.g_ValueSetOptionalitySpec_2:
					// emit syntax tree node associated with production
					// ValueSetOptionalitySpec: DEFAULT ValueSet

					s += "DEFAULT";
					s += ' ';
					s += m_ValueSet.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ValueSetOptionalitySpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ValueSetOptionalitySpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ValueSetOptionalitySpec.production_kind kind = (ValueSetOptionalitySpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ValueSetOptionalitySpec.production_kind.g_ValueSetOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// ValueSetOptionalitySpec: OPTIONAL

						m_OPTIONAL.Visit (visitor, appData);
				break;
				case ValueSetOptionalitySpec.production_kind.g_ValueSetOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// ValueSetOptionalitySpec: DEFAULT ValueSet

						m_DEFAULT.Visit (visitor, appData);
						m_ValueSet.Visit (visitor, appData);
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
			m_ValueSet?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ValueSetOptionalitySpec
		//

		public void _init ()
		{
			m_OPTIONAL = null;
			m_DEFAULT = null;
			m_ValueSet = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ValueSetOptionalitySpec

		// counter of all nodes associated with syntax rule ValueSetOptionalitySpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ValueSetOptionalitySpec
		[DataMember (Name = "m_OPTIONAL")] public SyntaxTreeToken m_OPTIONAL { get; private set; }
		[DataMember (Name = "m_DEFAULT")] public SyntaxTreeToken m_DEFAULT { get; private set; }
		[DataMember (Name = "m_ValueSet")] public ValueSet m_ValueSet { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ValueSetOptionalitySpec

		// delegate function (callback) prototype associated with syntax rule ValueSetOptionalitySpec
		public delegate bool ValueSetOptionalitySpec_Callback (SyntaxTreeCallbackReason reason, ValueSetOptionalitySpec.production_kind kind, ValueSetOptionalitySpec p_ValueSetOptionalitySpec);

		// event associated with syntax rule ValueSetOptionalitySpec
		public event ValueSetOptionalitySpec_Callback ValueSetOptionalitySpec_Event;

		// event trigger associated with syntax rule ValueSetOptionalitySpec
		public bool Raise_ValueSetOptionalitySpec_Event (SyntaxTreeCallbackReason reason, ValueSetOptionalitySpec.production_kind kind, ValueSetOptionalitySpec p_ValueSetOptionalitySpec)
		{
			bool? status = ValueSetOptionalitySpec_Event?.Invoke (reason, kind, p_ValueSetOptionalitySpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ValueSetOptionalitySpec
		//
		// traverse syntax tree node associated with any production of syntax rule ValueSetOptionalitySpec
		//

		public void Traverse (ValueSetOptionalitySpec p_ValueSetOptionalitySpec)
		{
			if (p_ValueSetOptionalitySpec.isLocked())
				return;
			p_ValueSetOptionalitySpec.dolock();
			ValueSetOptionalitySpec.production_kind kind = (ValueSetOptionalitySpec.production_kind) p_ValueSetOptionalitySpec.kind;
			p_ValueSetOptionalitySpec.turn_reset ();
			if (Raise_ValueSetOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ValueSetOptionalitySpec))
			switch (kind)
			{
				case ValueSetOptionalitySpec.production_kind.g_ValueSetOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// ValueSetOptionalitySpec: OPTIONAL

				break;
				case ValueSetOptionalitySpec.production_kind.g_ValueSetOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// ValueSetOptionalitySpec: DEFAULT ValueSet

					if (Raise_ValueSetOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueSetOptionalitySpec))
						Traverse (p_ValueSetOptionalitySpec.m_ValueSet);
					p_ValueSetOptionalitySpec.turn_inc ();
					Raise_ValueSetOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueSetOptionalitySpec);
				break;
			}
			Raise_ValueSetOptionalitySpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ValueSetOptionalitySpec);
			p_ValueSetOptionalitySpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ValueSetOptionalitySpec
		//

		public void TraverseCommon (ValueSetOptionalitySpec p_ValueSetOptionalitySpec)
		{
			ValueSetOptionalitySpec.production_kind kind = (ValueSetOptionalitySpec.production_kind) p_ValueSetOptionalitySpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ValueSetOptionalitySpec))
			switch (kind)
			{
				case ValueSetOptionalitySpec.production_kind.g_ValueSetOptionalitySpec_1:
					// traverse syntax tree node associated with production
					// ValueSetOptionalitySpec: OPTIONAL

						TraverseCommon (p_ValueSetOptionalitySpec.m_OPTIONAL);
				break;
				case ValueSetOptionalitySpec.production_kind.g_ValueSetOptionalitySpec_2:
					// traverse syntax tree node associated with production
					// ValueSetOptionalitySpec: DEFAULT ValueSet

						TraverseCommon (p_ValueSetOptionalitySpec.m_DEFAULT);
						TraverseCommon (p_ValueSetOptionalitySpec.m_ValueSet);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ValueSetOptionalitySpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ValueSetOptionalitySpec

		//
		// create syntax tree node associated with production
		// ValueSetOptionalitySpec: OPTIONAL

		//

		public ValueSetOptionalitySpec ValueSetOptionalitySpec_1 (SyntaxTreeToken p_token)
		{
			ValueSetOptionalitySpec p_ValueSetOptionalitySpec_ref = new ValueSetOptionalitySpec(p_token);
			p_token.parent = p_ValueSetOptionalitySpec_ref;
			Raise_ValueSetOptionalitySpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueSetOptionalitySpec.production_kind.g_ValueSetOptionalitySpec_1, p_ValueSetOptionalitySpec_ref);
			return p_ValueSetOptionalitySpec_ref;
		}

		//
		// create syntax tree node associated with production
		// ValueSetOptionalitySpec: DEFAULT ValueSet

		//

		public ValueSetOptionalitySpec ValueSetOptionalitySpec_2 (SyntaxTreeToken p_token, ValueSet p_ValueSet)
		{
			ValueSetOptionalitySpec p_ValueSetOptionalitySpec_ref = new ValueSetOptionalitySpec(p_token, p_ValueSet);
			p_token.parent = p_ValueSetOptionalitySpec_ref;
			p_ValueSet.parent = p_ValueSetOptionalitySpec_ref;
			Raise_ValueSetOptionalitySpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueSetOptionalitySpec.production_kind.g_ValueSetOptionalitySpec_2, p_ValueSetOptionalitySpec_ref);
			return p_ValueSetOptionalitySpec_ref;
		}
		#endregion
	};
}
