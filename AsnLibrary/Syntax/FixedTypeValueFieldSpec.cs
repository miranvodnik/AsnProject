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
	// class associated with syntax rule FixedTypeValueFieldSpec
	//

	[DataContract]
	public class	FixedTypeValueFieldSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule FixedTypeValueFieldSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule FixedTypeValueFieldSpec
		{
			g_FixedTypeValueFieldSpec_1 = 1,	// valuefieldreference-token Type UNIQUE-optional ValueOptionalitySpec-optional

		};
		#endregion
		#region production markers associated with the syntax rule FixedTypeValueFieldSpec

		// markers associated with production: FixedTypeValueFieldSpec -> valuefieldreference-token Type UNIQUE-optional ValueOptionalitySpec-optional

		public enum production_marker_1 : ushort
		{
			m_valuefieldreference_token,
			m_Type,
			m_UNIQUE_optional,
			m_ValueOptionalitySpec_optional,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule FixedTypeValueFieldSpec

		// Constructor declaration(s) associated with production(s) of syntax rule FixedTypeValueFieldSpec

		//
		// Constructor associated with the following production(s)
		// FixedTypeValueFieldSpec -> valuefieldreference-token Type UNIQUE-optional ValueOptionalitySpec-optional

		//

		public FixedTypeValueFieldSpec (valuefieldreference_token p_valuefieldreference_token, Type p_Type, UNIQUE_optional p_UNIQUE_optional, ValueOptionalitySpec_optional p_ValueOptionalitySpec_optional) : base ((uint) ProductionID._FixedTypeValueFieldSpec_ID, (uint) production_kind.g_FixedTypeValueFieldSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_valuefieldreference_token = p_valuefieldreference_token;
			children[1] = m_Type = p_Type;
			children[2] = m_UNIQUE_optional = p_UNIQUE_optional;
			children[3] = m_ValueOptionalitySpec_optional = p_ValueOptionalitySpec_optional;
		}

		public FixedTypeValueFieldSpec () { }

		// Copy constructor

		public FixedTypeValueFieldSpec (FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec) : base (p_FixedTypeValueFieldSpec.id, p_FixedTypeValueFieldSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_FixedTypeValueFieldSpec.appInfo;
			switch ((production_kind) p_FixedTypeValueFieldSpec.kind)
			{
				case production_kind.g_FixedTypeValueFieldSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_valuefieldreference_token = (p_FixedTypeValueFieldSpec.m_valuefieldreference_token != null) ? new valuefieldreference_token (p_FixedTypeValueFieldSpec.m_valuefieldreference_token) : null) != null) m_valuefieldreference_token.parent = this;
					if ((children [1] = m_Type = (p_FixedTypeValueFieldSpec.m_Type != null) ? new Type (p_FixedTypeValueFieldSpec.m_Type) : null) != null) m_Type.parent = this;
					if ((children [2] = m_UNIQUE_optional = (p_FixedTypeValueFieldSpec.m_UNIQUE_optional != null) ? new UNIQUE_optional (p_FixedTypeValueFieldSpec.m_UNIQUE_optional) : null) != null) m_UNIQUE_optional.parent = this;
					if ((children [3] = m_ValueOptionalitySpec_optional = (p_FixedTypeValueFieldSpec.m_ValueOptionalitySpec_optional != null) ? new ValueOptionalitySpec_optional (p_FixedTypeValueFieldSpec.m_ValueOptionalitySpec_optional) : null) != null) m_ValueOptionalitySpec_optional.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "FixedTypeValueFieldSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new FixedTypeValueFieldSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_valuefieldreference_token?.Dispose ();
			m_Type?.Dispose ();
			m_UNIQUE_optional?.Dispose ();
			m_ValueOptionalitySpec_optional?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule FixedTypeValueFieldSpec

		// Content changing function(s) associated with production(s) of syntax rule FixedTypeValueFieldSpec

		//
		// Content changing function associated with following production(s)
		// FixedTypeValueFieldSpec -> valuefieldreference-token Type UNIQUE-optional ValueOptionalitySpec-optional

		//

		public void change(valuefieldreference_token p_valuefieldreference_token, Type p_Type, UNIQUE_optional p_UNIQUE_optional, ValueOptionalitySpec_optional p_ValueOptionalitySpec_optional)
		{
			_init ();
			this.kind = (uint) production_kind.g_FixedTypeValueFieldSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_valuefieldreference_token = p_valuefieldreference_token;
			children [1] = m_Type = p_Type;
			children [2] = m_UNIQUE_optional = p_UNIQUE_optional;
			children [3] = m_ValueOptionalitySpec_optional = p_ValueOptionalitySpec_optional;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule FixedTypeValueFieldSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_valuefieldreference_token != null) && m_valuefieldreference_token.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_UNIQUE_optional != null) && m_UNIQUE_optional.checkInclusion (element) ||
				(m_ValueOptionalitySpec_optional != null) && m_ValueOptionalitySpec_optional.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule FixedTypeValueFieldSpec

		//
		// emit production tree node associated with any production of syntax rule FixedTypeValueFieldSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_FixedTypeValueFieldSpec_1:
					// emit syntax tree node associated with production
					// FixedTypeValueFieldSpec: valuefieldreference-token Type UNIQUE-optional ValueOptionalitySpec-optional

					s += m_valuefieldreference_token.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
					s += " ";
					s += m_UNIQUE_optional.Emit (depth - 1);
					s += " ";
					s += m_ValueOptionalitySpec_optional.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule FixedTypeValueFieldSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "FixedTypeValueFieldSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_FixedTypeValueFieldSpec_1:
					// emit syntax tree node associated with production
					// FixedTypeValueFieldSpec: valuefieldreference-token Type UNIQUE-optional ValueOptionalitySpec-optional

					s += m_valuefieldreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_UNIQUE_optional.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ValueOptionalitySpec_optional.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule FixedTypeValueFieldSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule FixedTypeValueFieldSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			FixedTypeValueFieldSpec.production_kind kind = (FixedTypeValueFieldSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case FixedTypeValueFieldSpec.production_kind.g_FixedTypeValueFieldSpec_1:
					// traverse syntax tree node associated with production
					// FixedTypeValueFieldSpec: valuefieldreference-token Type UNIQUE-optional ValueOptionalitySpec-optional

						m_valuefieldreference_token.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
						m_UNIQUE_optional.Visit (visitor, appData);
						m_ValueOptionalitySpec_optional.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_valuefieldreference_token?.reparent (this);
			m_Type?.reparent (this);
			m_UNIQUE_optional?.reparent (this);
			m_ValueOptionalitySpec_optional?.reparent (this);
		}

		//
		// initialize object associated with syntax rule FixedTypeValueFieldSpec
		//

		public void _init ()
		{
			m_valuefieldreference_token = null;
			m_Type = null;
			m_UNIQUE_optional = null;
			m_ValueOptionalitySpec_optional = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule FixedTypeValueFieldSpec

		// counter of all nodes associated with syntax rule FixedTypeValueFieldSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule FixedTypeValueFieldSpec
		[DataMember (Name = "m_valuefieldreference_token")] public valuefieldreference_token m_valuefieldreference_token { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_UNIQUE_optional")] public UNIQUE_optional m_UNIQUE_optional { get; private set; }
		[DataMember (Name = "m_ValueOptionalitySpec_optional")] public ValueOptionalitySpec_optional m_ValueOptionalitySpec_optional { get; private set; }

		public enum __field_markers
		{
			push_governor = 3,
			pop_governor = 4,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule FixedTypeValueFieldSpec

		// delegate function (callback) prototype associated with syntax rule FixedTypeValueFieldSpec
		public delegate bool FixedTypeValueFieldSpec_Callback (SyntaxTreeCallbackReason reason, FixedTypeValueFieldSpec.production_kind kind, FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec);

		// event associated with syntax rule FixedTypeValueFieldSpec
		public event FixedTypeValueFieldSpec_Callback FixedTypeValueFieldSpec_Event;

		// event trigger associated with syntax rule FixedTypeValueFieldSpec
		public bool Raise_FixedTypeValueFieldSpec_Event (SyntaxTreeCallbackReason reason, FixedTypeValueFieldSpec.production_kind kind, FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec)
		{
			bool? status = FixedTypeValueFieldSpec_Event?.Invoke (reason, kind, p_FixedTypeValueFieldSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule FixedTypeValueFieldSpec
		//
		// traverse syntax tree node associated with any production of syntax rule FixedTypeValueFieldSpec
		//

		public void Traverse (FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec)
		{
			if (p_FixedTypeValueFieldSpec.isLocked())
				return;
			p_FixedTypeValueFieldSpec.dolock();
			FixedTypeValueFieldSpec.production_kind kind = (FixedTypeValueFieldSpec.production_kind) p_FixedTypeValueFieldSpec.kind;
			p_FixedTypeValueFieldSpec.turn_reset ();
			if (Raise_FixedTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_FixedTypeValueFieldSpec))
			switch (kind)
			{
				case FixedTypeValueFieldSpec.production_kind.g_FixedTypeValueFieldSpec_1:
					// traverse syntax tree node associated with production
					// FixedTypeValueFieldSpec: valuefieldreference-token Type UNIQUE-optional ValueOptionalitySpec-optional

					if (Raise_FixedTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FixedTypeValueFieldSpec))
						Traverse (p_FixedTypeValueFieldSpec.m_valuefieldreference_token);
					p_FixedTypeValueFieldSpec.turn_inc ();
					if (Raise_FixedTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FixedTypeValueFieldSpec))
						Traverse (p_FixedTypeValueFieldSpec.m_Type);
					p_FixedTypeValueFieldSpec.turn_inc ();
					if (Raise_FixedTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FixedTypeValueFieldSpec))
						Traverse (p_FixedTypeValueFieldSpec.m_UNIQUE_optional);
					p_FixedTypeValueFieldSpec.turn_inc ();
					if (Raise_FixedTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FixedTypeValueFieldSpec))
						Traverse (p_FixedTypeValueFieldSpec.m_ValueOptionalitySpec_optional);
					p_FixedTypeValueFieldSpec.turn_inc ();
					Raise_FixedTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FixedTypeValueFieldSpec);
				break;
			}
			Raise_FixedTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_FixedTypeValueFieldSpec);
			p_FixedTypeValueFieldSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule FixedTypeValueFieldSpec
		//

		public void TraverseCommon (FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec)
		{
			FixedTypeValueFieldSpec.production_kind kind = (FixedTypeValueFieldSpec.production_kind) p_FixedTypeValueFieldSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_FixedTypeValueFieldSpec))
			switch (kind)
			{
				case FixedTypeValueFieldSpec.production_kind.g_FixedTypeValueFieldSpec_1:
					// traverse syntax tree node associated with production
					// FixedTypeValueFieldSpec: valuefieldreference-token Type UNIQUE-optional ValueOptionalitySpec-optional

						TraverseCommon (p_FixedTypeValueFieldSpec.m_valuefieldreference_token);
						TraverseCommon (p_FixedTypeValueFieldSpec.m_Type);
						TraverseCommon (p_FixedTypeValueFieldSpec.m_UNIQUE_optional);
						TraverseCommon (p_FixedTypeValueFieldSpec.m_ValueOptionalitySpec_optional);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_FixedTypeValueFieldSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule FixedTypeValueFieldSpec

		//
		// create syntax tree node associated with production
		// FixedTypeValueFieldSpec: valuefieldreference-token Type UNIQUE-optional ValueOptionalitySpec-optional

		//

		public FixedTypeValueFieldSpec FixedTypeValueFieldSpec_1 (valuefieldreference_token p_valuefieldreference_token, Type p_Type, UNIQUE_optional p_UNIQUE_optional, ValueOptionalitySpec_optional p_ValueOptionalitySpec_optional)
		{
			FixedTypeValueFieldSpec p_FixedTypeValueFieldSpec_ref = new FixedTypeValueFieldSpec(p_valuefieldreference_token, p_Type, p_UNIQUE_optional, p_ValueOptionalitySpec_optional);
			p_valuefieldreference_token.parent = p_FixedTypeValueFieldSpec_ref;
			p_Type.parent = p_FixedTypeValueFieldSpec_ref;
			p_UNIQUE_optional.parent = p_FixedTypeValueFieldSpec_ref;
			p_ValueOptionalitySpec_optional.parent = p_FixedTypeValueFieldSpec_ref;
			Raise_FixedTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FixedTypeValueFieldSpec.production_kind.g_FixedTypeValueFieldSpec_1, p_FixedTypeValueFieldSpec_ref);
			return p_FixedTypeValueFieldSpec_ref;
		}
		#endregion
	};
}
