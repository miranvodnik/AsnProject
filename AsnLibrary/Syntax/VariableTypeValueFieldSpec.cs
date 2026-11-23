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
	// class associated with syntax rule VariableTypeValueFieldSpec
	//

	[DataContract]
	public class	VariableTypeValueFieldSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule VariableTypeValueFieldSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule VariableTypeValueFieldSpec
		{
			g_VariableTypeValueFieldSpec_1 = 1,	// valuefieldreference-token FieldName ValueOptionalitySpec-optional

		};
		#endregion
		#region production markers associated with the syntax rule VariableTypeValueFieldSpec

		// markers associated with production: VariableTypeValueFieldSpec -> valuefieldreference-token FieldName ValueOptionalitySpec-optional

		public enum production_marker_1 : ushort
		{
			m_valuefieldreference_token,
			m_FieldName,
			m_ValueOptionalitySpec_optional,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule VariableTypeValueFieldSpec

		// Constructor declaration(s) associated with production(s) of syntax rule VariableTypeValueFieldSpec

		//
		// Constructor associated with the following production(s)
		// VariableTypeValueFieldSpec -> valuefieldreference-token FieldName ValueOptionalitySpec-optional

		//

		public VariableTypeValueFieldSpec (valuefieldreference_token p_valuefieldreference_token, FieldName p_FieldName, ValueOptionalitySpec_optional p_ValueOptionalitySpec_optional) : base ((uint) ProductionID._VariableTypeValueFieldSpec_ID, (uint) production_kind.g_VariableTypeValueFieldSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_valuefieldreference_token = p_valuefieldreference_token;
			children[1] = m_FieldName = p_FieldName;
			children[2] = m_ValueOptionalitySpec_optional = p_ValueOptionalitySpec_optional;
		}

		public VariableTypeValueFieldSpec () { }

		// Copy constructor

		public VariableTypeValueFieldSpec (VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec) : base (p_VariableTypeValueFieldSpec.id, p_VariableTypeValueFieldSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_VariableTypeValueFieldSpec.appInfo;
			switch ((production_kind) p_VariableTypeValueFieldSpec.kind)
			{
				case production_kind.g_VariableTypeValueFieldSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_valuefieldreference_token = (p_VariableTypeValueFieldSpec.m_valuefieldreference_token != null) ? new valuefieldreference_token (p_VariableTypeValueFieldSpec.m_valuefieldreference_token) : null) != null) m_valuefieldreference_token.parent = this;
					if ((children [1] = m_FieldName = (p_VariableTypeValueFieldSpec.m_FieldName != null) ? new FieldName (p_VariableTypeValueFieldSpec.m_FieldName) : null) != null) m_FieldName.parent = this;
					if ((children [2] = m_ValueOptionalitySpec_optional = (p_VariableTypeValueFieldSpec.m_ValueOptionalitySpec_optional != null) ? new ValueOptionalitySpec_optional (p_VariableTypeValueFieldSpec.m_ValueOptionalitySpec_optional) : null) != null) m_ValueOptionalitySpec_optional.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "VariableTypeValueFieldSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new VariableTypeValueFieldSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_valuefieldreference_token?.Dispose ();
			m_FieldName?.Dispose ();
			m_ValueOptionalitySpec_optional?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule VariableTypeValueFieldSpec

		// Content changing function(s) associated with production(s) of syntax rule VariableTypeValueFieldSpec

		//
		// Content changing function associated with following production(s)
		// VariableTypeValueFieldSpec -> valuefieldreference-token FieldName ValueOptionalitySpec-optional

		//

		public void change(valuefieldreference_token p_valuefieldreference_token, FieldName p_FieldName, ValueOptionalitySpec_optional p_ValueOptionalitySpec_optional)
		{
			_init ();
			this.kind = (uint) production_kind.g_VariableTypeValueFieldSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_valuefieldreference_token = p_valuefieldreference_token;
			children [1] = m_FieldName = p_FieldName;
			children [2] = m_ValueOptionalitySpec_optional = p_ValueOptionalitySpec_optional;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule VariableTypeValueFieldSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_valuefieldreference_token != null) && m_valuefieldreference_token.checkInclusion (element) ||
				(m_FieldName != null) && m_FieldName.checkInclusion (element) ||
				(m_ValueOptionalitySpec_optional != null) && m_ValueOptionalitySpec_optional.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule VariableTypeValueFieldSpec

		//
		// emit production tree node associated with any production of syntax rule VariableTypeValueFieldSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_VariableTypeValueFieldSpec_1:
					// emit syntax tree node associated with production
					// VariableTypeValueFieldSpec: valuefieldreference-token FieldName ValueOptionalitySpec-optional

					s += m_valuefieldreference_token.Emit (depth - 1);
					s += " ";
					s += m_FieldName.Emit (depth - 1);
					s += " ";
					s += m_ValueOptionalitySpec_optional.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule VariableTypeValueFieldSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "VariableTypeValueFieldSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_VariableTypeValueFieldSpec_1:
					// emit syntax tree node associated with production
					// VariableTypeValueFieldSpec: valuefieldreference-token FieldName ValueOptionalitySpec-optional

					s += m_valuefieldreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_FieldName.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ValueOptionalitySpec_optional.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule VariableTypeValueFieldSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule VariableTypeValueFieldSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			VariableTypeValueFieldSpec.production_kind kind = (VariableTypeValueFieldSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case VariableTypeValueFieldSpec.production_kind.g_VariableTypeValueFieldSpec_1:
					// traverse syntax tree node associated with production
					// VariableTypeValueFieldSpec: valuefieldreference-token FieldName ValueOptionalitySpec-optional

						m_valuefieldreference_token.Visit (visitor, appData);
						m_FieldName.Visit (visitor, appData);
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
			m_FieldName?.reparent (this);
			m_ValueOptionalitySpec_optional?.reparent (this);
		}

		//
		// initialize object associated with syntax rule VariableTypeValueFieldSpec
		//

		public void _init ()
		{
			m_valuefieldreference_token = null;
			m_FieldName = null;
			m_ValueOptionalitySpec_optional = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule VariableTypeValueFieldSpec

		// counter of all nodes associated with syntax rule VariableTypeValueFieldSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule VariableTypeValueFieldSpec
		[DataMember (Name = "m_valuefieldreference_token")] public valuefieldreference_token m_valuefieldreference_token { get; private set; }
		[DataMember (Name = "m_FieldName")] public FieldName m_FieldName { get; private set; }
		[DataMember (Name = "m_ValueOptionalitySpec_optional")] public ValueOptionalitySpec_optional m_ValueOptionalitySpec_optional { get; private set; }

		public enum __p1_markers
		{
			m1 = 1,
			m2 = 2,
			m3 = 3,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule VariableTypeValueFieldSpec

		// delegate function (callback) prototype associated with syntax rule VariableTypeValueFieldSpec
		public delegate bool VariableTypeValueFieldSpec_Callback (SyntaxTreeCallbackReason reason, VariableTypeValueFieldSpec.production_kind kind, VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec);

		// event associated with syntax rule VariableTypeValueFieldSpec
		public event VariableTypeValueFieldSpec_Callback VariableTypeValueFieldSpec_Event;

		// event trigger associated with syntax rule VariableTypeValueFieldSpec
		public bool Raise_VariableTypeValueFieldSpec_Event (SyntaxTreeCallbackReason reason, VariableTypeValueFieldSpec.production_kind kind, VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec)
		{
			bool? status = VariableTypeValueFieldSpec_Event?.Invoke (reason, kind, p_VariableTypeValueFieldSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule VariableTypeValueFieldSpec
		//
		// traverse syntax tree node associated with any production of syntax rule VariableTypeValueFieldSpec
		//

		public void Traverse (VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec)
		{
			if (p_VariableTypeValueFieldSpec.isLocked())
				return;
			p_VariableTypeValueFieldSpec.dolock();
			VariableTypeValueFieldSpec.production_kind kind = (VariableTypeValueFieldSpec.production_kind) p_VariableTypeValueFieldSpec.kind;
			p_VariableTypeValueFieldSpec.turn_reset ();
			if (Raise_VariableTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_VariableTypeValueFieldSpec))
			switch (kind)
			{
				case VariableTypeValueFieldSpec.production_kind.g_VariableTypeValueFieldSpec_1:
					// traverse syntax tree node associated with production
					// VariableTypeValueFieldSpec: valuefieldreference-token FieldName ValueOptionalitySpec-optional

					if (Raise_VariableTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_VariableTypeValueFieldSpec))
						Traverse (p_VariableTypeValueFieldSpec.m_valuefieldreference_token);
					p_VariableTypeValueFieldSpec.turn_inc ();
					if (Raise_VariableTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_VariableTypeValueFieldSpec))
						Traverse (p_VariableTypeValueFieldSpec.m_FieldName);
					p_VariableTypeValueFieldSpec.turn_inc ();
					if (Raise_VariableTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_VariableTypeValueFieldSpec))
						Traverse (p_VariableTypeValueFieldSpec.m_ValueOptionalitySpec_optional);
					p_VariableTypeValueFieldSpec.turn_inc ();
					Raise_VariableTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_VariableTypeValueFieldSpec);
				break;
			}
			Raise_VariableTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_VariableTypeValueFieldSpec);
			p_VariableTypeValueFieldSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule VariableTypeValueFieldSpec
		//

		public void TraverseCommon (VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec)
		{
			VariableTypeValueFieldSpec.production_kind kind = (VariableTypeValueFieldSpec.production_kind) p_VariableTypeValueFieldSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_VariableTypeValueFieldSpec))
			switch (kind)
			{
				case VariableTypeValueFieldSpec.production_kind.g_VariableTypeValueFieldSpec_1:
					// traverse syntax tree node associated with production
					// VariableTypeValueFieldSpec: valuefieldreference-token FieldName ValueOptionalitySpec-optional

						TraverseCommon (p_VariableTypeValueFieldSpec.m_valuefieldreference_token);
						TraverseCommon (p_VariableTypeValueFieldSpec.m_FieldName);
						TraverseCommon (p_VariableTypeValueFieldSpec.m_ValueOptionalitySpec_optional);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_VariableTypeValueFieldSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule VariableTypeValueFieldSpec

		//
		// create syntax tree node associated with production
		// VariableTypeValueFieldSpec: valuefieldreference-token FieldName ValueOptionalitySpec-optional

		//

		public VariableTypeValueFieldSpec VariableTypeValueFieldSpec_1 (valuefieldreference_token p_valuefieldreference_token, FieldName p_FieldName, ValueOptionalitySpec_optional p_ValueOptionalitySpec_optional)
		{
			VariableTypeValueFieldSpec p_VariableTypeValueFieldSpec_ref = new VariableTypeValueFieldSpec(p_valuefieldreference_token, p_FieldName, p_ValueOptionalitySpec_optional);
			p_valuefieldreference_token.parent = p_VariableTypeValueFieldSpec_ref;
			p_FieldName.parent = p_VariableTypeValueFieldSpec_ref;
			p_ValueOptionalitySpec_optional.parent = p_VariableTypeValueFieldSpec_ref;
			Raise_VariableTypeValueFieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, VariableTypeValueFieldSpec.production_kind.g_VariableTypeValueFieldSpec_1, p_VariableTypeValueFieldSpec_ref);
			return p_VariableTypeValueFieldSpec_ref;
		}
		#endregion
	};
}
