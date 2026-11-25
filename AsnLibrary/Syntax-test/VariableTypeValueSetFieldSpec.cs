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
	// class associated with syntax rule VariableTypeValueSetFieldSpec
	//

	[DataContract]
	public class	VariableTypeValueSetFieldSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule VariableTypeValueSetFieldSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule VariableTypeValueSetFieldSpec
		{
			g_VariableTypeValueSetFieldSpec_1 = 1,	// valuesetfieldreference-token FieldName ValueSetOptionalitySpec-optional

		};
		#endregion
		#region production markers associated with the syntax rule VariableTypeValueSetFieldSpec

		// markers associated with production: VariableTypeValueSetFieldSpec -> valuesetfieldreference-token FieldName ValueSetOptionalitySpec-optional

		public enum production_marker_1 : ushort
		{
			m_valuesetfieldreference_token,
			m_FieldName,
			m_ValueSetOptionalitySpec_optional,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule VariableTypeValueSetFieldSpec

		// Constructor declaration(s) associated with production(s) of syntax rule VariableTypeValueSetFieldSpec

		//
		// Constructor associated with the following production(s)
		// VariableTypeValueSetFieldSpec -> valuesetfieldreference-token FieldName ValueSetOptionalitySpec-optional

		//

		public VariableTypeValueSetFieldSpec (valuesetfieldreference_token p_valuesetfieldreference_token, FieldName p_FieldName, ValueSetOptionalitySpec_optional p_ValueSetOptionalitySpec_optional) : base ((uint) ProductionID._VariableTypeValueSetFieldSpec_ID, (uint) production_kind.g_VariableTypeValueSetFieldSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_valuesetfieldreference_token = p_valuesetfieldreference_token;
			children[1] = m_FieldName = p_FieldName;
			children[2] = m_ValueSetOptionalitySpec_optional = p_ValueSetOptionalitySpec_optional;
		}

		public VariableTypeValueSetFieldSpec () { }

		// Copy constructor

		public VariableTypeValueSetFieldSpec (VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec) : base (p_VariableTypeValueSetFieldSpec.id, p_VariableTypeValueSetFieldSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_VariableTypeValueSetFieldSpec.appInfo;
			switch ((production_kind) p_VariableTypeValueSetFieldSpec.kind)
			{
				case production_kind.g_VariableTypeValueSetFieldSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_valuesetfieldreference_token = (p_VariableTypeValueSetFieldSpec.m_valuesetfieldreference_token != null) ? new valuesetfieldreference_token (p_VariableTypeValueSetFieldSpec.m_valuesetfieldreference_token) : null) != null) m_valuesetfieldreference_token.parent = this;
					if ((children [1] = m_FieldName = (p_VariableTypeValueSetFieldSpec.m_FieldName != null) ? new FieldName (p_VariableTypeValueSetFieldSpec.m_FieldName) : null) != null) m_FieldName.parent = this;
					if ((children [2] = m_ValueSetOptionalitySpec_optional = (p_VariableTypeValueSetFieldSpec.m_ValueSetOptionalitySpec_optional != null) ? new ValueSetOptionalitySpec_optional (p_VariableTypeValueSetFieldSpec.m_ValueSetOptionalitySpec_optional) : null) != null) m_ValueSetOptionalitySpec_optional.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "VariableTypeValueSetFieldSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new VariableTypeValueSetFieldSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_valuesetfieldreference_token?.Dispose ();
			m_FieldName?.Dispose ();
			m_ValueSetOptionalitySpec_optional?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule VariableTypeValueSetFieldSpec

		// Content changing function(s) associated with production(s) of syntax rule VariableTypeValueSetFieldSpec

		//
		// Content changing function associated with following production(s)
		// VariableTypeValueSetFieldSpec -> valuesetfieldreference-token FieldName ValueSetOptionalitySpec-optional

		//

		public void change(valuesetfieldreference_token p_valuesetfieldreference_token, FieldName p_FieldName, ValueSetOptionalitySpec_optional p_ValueSetOptionalitySpec_optional)
		{
			_init ();
			this.kind = (uint) production_kind.g_VariableTypeValueSetFieldSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_valuesetfieldreference_token = p_valuesetfieldreference_token;
			children [1] = m_FieldName = p_FieldName;
			children [2] = m_ValueSetOptionalitySpec_optional = p_ValueSetOptionalitySpec_optional;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule VariableTypeValueSetFieldSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_valuesetfieldreference_token != null) && m_valuesetfieldreference_token.checkInclusion (element) ||
				(m_FieldName != null) && m_FieldName.checkInclusion (element) ||
				(m_ValueSetOptionalitySpec_optional != null) && m_ValueSetOptionalitySpec_optional.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule VariableTypeValueSetFieldSpec

		//
		// emit production tree node associated with any production of syntax rule VariableTypeValueSetFieldSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_VariableTypeValueSetFieldSpec_1:
					// emit syntax tree node associated with production
					// VariableTypeValueSetFieldSpec: valuesetfieldreference-token FieldName ValueSetOptionalitySpec-optional

					s += m_valuesetfieldreference_token.Emit (depth - 1);
					s += " ";
					s += m_FieldName.Emit (depth - 1);
					s += " ";
					s += m_ValueSetOptionalitySpec_optional.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule VariableTypeValueSetFieldSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "VariableTypeValueSetFieldSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_VariableTypeValueSetFieldSpec_1:
					// emit syntax tree node associated with production
					// VariableTypeValueSetFieldSpec: valuesetfieldreference-token FieldName ValueSetOptionalitySpec-optional

					s += m_valuesetfieldreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_FieldName.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ValueSetOptionalitySpec_optional.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule VariableTypeValueSetFieldSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule VariableTypeValueSetFieldSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			VariableTypeValueSetFieldSpec.production_kind kind = (VariableTypeValueSetFieldSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case VariableTypeValueSetFieldSpec.production_kind.g_VariableTypeValueSetFieldSpec_1:
					// traverse syntax tree node associated with production
					// VariableTypeValueSetFieldSpec: valuesetfieldreference-token FieldName ValueSetOptionalitySpec-optional

						m_valuesetfieldreference_token.Visit (visitor, appData);
						m_FieldName.Visit (visitor, appData);
						m_ValueSetOptionalitySpec_optional.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_valuesetfieldreference_token?.reparent (this);
			m_FieldName?.reparent (this);
			m_ValueSetOptionalitySpec_optional?.reparent (this);
		}

		//
		// initialize object associated with syntax rule VariableTypeValueSetFieldSpec
		//

		public void _init ()
		{
			m_valuesetfieldreference_token = null;
			m_FieldName = null;
			m_ValueSetOptionalitySpec_optional = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule VariableTypeValueSetFieldSpec

		// counter of all nodes associated with syntax rule VariableTypeValueSetFieldSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule VariableTypeValueSetFieldSpec
		[DataMember (Name = "m_valuesetfieldreference_token")] public valuesetfieldreference_token m_valuesetfieldreference_token { get; private set; }
		[DataMember (Name = "m_FieldName")] public FieldName m_FieldName { get; private set; }
		[DataMember (Name = "m_ValueSetOptionalitySpec_optional")] public ValueSetOptionalitySpec_optional m_ValueSetOptionalitySpec_optional { get; private set; }

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
		#region delegates and events associated with the syntax rule VariableTypeValueSetFieldSpec

		// delegate function (callback) prototype associated with syntax rule VariableTypeValueSetFieldSpec
		public delegate bool VariableTypeValueSetFieldSpec_Callback (SyntaxTreeCallbackReason reason, VariableTypeValueSetFieldSpec.production_kind kind, VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec);

		// event associated with syntax rule VariableTypeValueSetFieldSpec
		public event VariableTypeValueSetFieldSpec_Callback VariableTypeValueSetFieldSpec_Event;

		// event trigger associated with syntax rule VariableTypeValueSetFieldSpec
		public bool Raise_VariableTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason reason, VariableTypeValueSetFieldSpec.production_kind kind, VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec)
		{
			bool? status = VariableTypeValueSetFieldSpec_Event?.Invoke (reason, kind, p_VariableTypeValueSetFieldSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule VariableTypeValueSetFieldSpec
		//
		// traverse syntax tree node associated with any production of syntax rule VariableTypeValueSetFieldSpec
		//

		public void Traverse (VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec)
		{
			if (p_VariableTypeValueSetFieldSpec.isLocked())
				return;
			p_VariableTypeValueSetFieldSpec.dolock();
			VariableTypeValueSetFieldSpec.production_kind kind = (VariableTypeValueSetFieldSpec.production_kind) p_VariableTypeValueSetFieldSpec.kind;
			p_VariableTypeValueSetFieldSpec.turn_reset ();
			if (Raise_VariableTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_VariableTypeValueSetFieldSpec))
			switch (kind)
			{
				case VariableTypeValueSetFieldSpec.production_kind.g_VariableTypeValueSetFieldSpec_1:
					// traverse syntax tree node associated with production
					// VariableTypeValueSetFieldSpec: valuesetfieldreference-token FieldName ValueSetOptionalitySpec-optional

					if (Raise_VariableTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_VariableTypeValueSetFieldSpec))
						Traverse (p_VariableTypeValueSetFieldSpec.m_valuesetfieldreference_token);
					p_VariableTypeValueSetFieldSpec.turn_inc ();
					if (Raise_VariableTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_VariableTypeValueSetFieldSpec))
						Traverse (p_VariableTypeValueSetFieldSpec.m_FieldName);
					p_VariableTypeValueSetFieldSpec.turn_inc ();
					if (Raise_VariableTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_VariableTypeValueSetFieldSpec))
						Traverse (p_VariableTypeValueSetFieldSpec.m_ValueSetOptionalitySpec_optional);
					p_VariableTypeValueSetFieldSpec.turn_inc ();
					Raise_VariableTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_VariableTypeValueSetFieldSpec);
				break;
			}
			Raise_VariableTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_VariableTypeValueSetFieldSpec);
			p_VariableTypeValueSetFieldSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule VariableTypeValueSetFieldSpec
		//

		public void TraverseCommon (VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec)
		{
			VariableTypeValueSetFieldSpec.production_kind kind = (VariableTypeValueSetFieldSpec.production_kind) p_VariableTypeValueSetFieldSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_VariableTypeValueSetFieldSpec))
			switch (kind)
			{
				case VariableTypeValueSetFieldSpec.production_kind.g_VariableTypeValueSetFieldSpec_1:
					// traverse syntax tree node associated with production
					// VariableTypeValueSetFieldSpec: valuesetfieldreference-token FieldName ValueSetOptionalitySpec-optional

						TraverseCommon (p_VariableTypeValueSetFieldSpec.m_valuesetfieldreference_token);
						TraverseCommon (p_VariableTypeValueSetFieldSpec.m_FieldName);
						TraverseCommon (p_VariableTypeValueSetFieldSpec.m_ValueSetOptionalitySpec_optional);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_VariableTypeValueSetFieldSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule VariableTypeValueSetFieldSpec

		//
		// create syntax tree node associated with production
		// VariableTypeValueSetFieldSpec: valuesetfieldreference-token FieldName ValueSetOptionalitySpec-optional

		//

		public VariableTypeValueSetFieldSpec VariableTypeValueSetFieldSpec_1 (valuesetfieldreference_token p_valuesetfieldreference_token, FieldName p_FieldName, ValueSetOptionalitySpec_optional p_ValueSetOptionalitySpec_optional)
		{
			VariableTypeValueSetFieldSpec p_VariableTypeValueSetFieldSpec_ref = new VariableTypeValueSetFieldSpec(p_valuesetfieldreference_token, p_FieldName, p_ValueSetOptionalitySpec_optional);
			p_valuesetfieldreference_token.parent = p_VariableTypeValueSetFieldSpec_ref;
			p_FieldName.parent = p_VariableTypeValueSetFieldSpec_ref;
			p_ValueSetOptionalitySpec_optional.parent = p_VariableTypeValueSetFieldSpec_ref;
			Raise_VariableTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, VariableTypeValueSetFieldSpec.production_kind.g_VariableTypeValueSetFieldSpec_1, p_VariableTypeValueSetFieldSpec_ref);
			return p_VariableTypeValueSetFieldSpec_ref;
		}
		#endregion
	};
}
