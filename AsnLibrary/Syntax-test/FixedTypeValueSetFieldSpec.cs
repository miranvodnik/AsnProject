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
	// class associated with syntax rule FixedTypeValueSetFieldSpec
	//

	[DataContract]
	public class	FixedTypeValueSetFieldSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule FixedTypeValueSetFieldSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule FixedTypeValueSetFieldSpec
		{
			g_FixedTypeValueSetFieldSpec_1 = 1,	// valuesetfieldreference-token Type ValueSetOptionalitySpec-optional

		};
		#endregion
		#region production markers associated with the syntax rule FixedTypeValueSetFieldSpec

		// markers associated with production: FixedTypeValueSetFieldSpec -> valuesetfieldreference-token Type ValueSetOptionalitySpec-optional

		public enum production_marker_1 : ushort
		{
			m_valuesetfieldreference_token,
			m_Type,
			m_ValueSetOptionalitySpec_optional,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule FixedTypeValueSetFieldSpec

		// Constructor declaration(s) associated with production(s) of syntax rule FixedTypeValueSetFieldSpec

		//
		// Constructor associated with the following production(s)
		// FixedTypeValueSetFieldSpec -> valuesetfieldreference-token Type ValueSetOptionalitySpec-optional

		//

		public FixedTypeValueSetFieldSpec (valuesetfieldreference_token p_valuesetfieldreference_token, Type p_Type, ValueSetOptionalitySpec_optional p_ValueSetOptionalitySpec_optional) : base ((uint) ProductionID._FixedTypeValueSetFieldSpec_ID, (uint) production_kind.g_FixedTypeValueSetFieldSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_valuesetfieldreference_token = p_valuesetfieldreference_token;
			children[1] = m_Type = p_Type;
			children[2] = m_ValueSetOptionalitySpec_optional = p_ValueSetOptionalitySpec_optional;
		}

		public FixedTypeValueSetFieldSpec () { }

		// Copy constructor

		public FixedTypeValueSetFieldSpec (FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec) : base (p_FixedTypeValueSetFieldSpec.id, p_FixedTypeValueSetFieldSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_FixedTypeValueSetFieldSpec.appInfo;
			switch ((production_kind) p_FixedTypeValueSetFieldSpec.kind)
			{
				case production_kind.g_FixedTypeValueSetFieldSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_valuesetfieldreference_token = (p_FixedTypeValueSetFieldSpec.m_valuesetfieldreference_token != null) ? new valuesetfieldreference_token (p_FixedTypeValueSetFieldSpec.m_valuesetfieldreference_token) : null) != null) m_valuesetfieldreference_token.parent = this;
					if ((children [1] = m_Type = (p_FixedTypeValueSetFieldSpec.m_Type != null) ? new Type (p_FixedTypeValueSetFieldSpec.m_Type) : null) != null) m_Type.parent = this;
					if ((children [2] = m_ValueSetOptionalitySpec_optional = (p_FixedTypeValueSetFieldSpec.m_ValueSetOptionalitySpec_optional != null) ? new ValueSetOptionalitySpec_optional (p_FixedTypeValueSetFieldSpec.m_ValueSetOptionalitySpec_optional) : null) != null) m_ValueSetOptionalitySpec_optional.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "FixedTypeValueSetFieldSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new FixedTypeValueSetFieldSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_valuesetfieldreference_token?.Dispose ();
			m_Type?.Dispose ();
			m_ValueSetOptionalitySpec_optional?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule FixedTypeValueSetFieldSpec

		// Content changing function(s) associated with production(s) of syntax rule FixedTypeValueSetFieldSpec

		//
		// Content changing function associated with following production(s)
		// FixedTypeValueSetFieldSpec -> valuesetfieldreference-token Type ValueSetOptionalitySpec-optional

		//

		public void change(valuesetfieldreference_token p_valuesetfieldreference_token, Type p_Type, ValueSetOptionalitySpec_optional p_ValueSetOptionalitySpec_optional)
		{
			_init ();
			this.kind = (uint) production_kind.g_FixedTypeValueSetFieldSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_valuesetfieldreference_token = p_valuesetfieldreference_token;
			children [1] = m_Type = p_Type;
			children [2] = m_ValueSetOptionalitySpec_optional = p_ValueSetOptionalitySpec_optional;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule FixedTypeValueSetFieldSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_valuesetfieldreference_token != null) && m_valuesetfieldreference_token.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_ValueSetOptionalitySpec_optional != null) && m_ValueSetOptionalitySpec_optional.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule FixedTypeValueSetFieldSpec

		//
		// emit production tree node associated with any production of syntax rule FixedTypeValueSetFieldSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_FixedTypeValueSetFieldSpec_1:
					// emit syntax tree node associated with production
					// FixedTypeValueSetFieldSpec: valuesetfieldreference-token Type ValueSetOptionalitySpec-optional

					s += m_valuesetfieldreference_token.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
					s += " ";
					s += m_ValueSetOptionalitySpec_optional.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule FixedTypeValueSetFieldSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "FixedTypeValueSetFieldSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_FixedTypeValueSetFieldSpec_1:
					// emit syntax tree node associated with production
					// FixedTypeValueSetFieldSpec: valuesetfieldreference-token Type ValueSetOptionalitySpec-optional

					s += m_valuesetfieldreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ValueSetOptionalitySpec_optional.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule FixedTypeValueSetFieldSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule FixedTypeValueSetFieldSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			FixedTypeValueSetFieldSpec.production_kind kind = (FixedTypeValueSetFieldSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case FixedTypeValueSetFieldSpec.production_kind.g_FixedTypeValueSetFieldSpec_1:
					// traverse syntax tree node associated with production
					// FixedTypeValueSetFieldSpec: valuesetfieldreference-token Type ValueSetOptionalitySpec-optional

						m_valuesetfieldreference_token.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
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
			m_Type?.reparent (this);
			m_ValueSetOptionalitySpec_optional?.reparent (this);
		}

		//
		// initialize object associated with syntax rule FixedTypeValueSetFieldSpec
		//

		public void _init ()
		{
			m_valuesetfieldreference_token = null;
			m_Type = null;
			m_ValueSetOptionalitySpec_optional = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule FixedTypeValueSetFieldSpec

		// counter of all nodes associated with syntax rule FixedTypeValueSetFieldSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule FixedTypeValueSetFieldSpec
		[DataMember (Name = "m_valuesetfieldreference_token")] public valuesetfieldreference_token m_valuesetfieldreference_token { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_ValueSetOptionalitySpec_optional")] public ValueSetOptionalitySpec_optional m_ValueSetOptionalitySpec_optional { get; private set; }

		public enum __field_markers
		{
			push_governor = 2,
			pop_governor = 3,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule FixedTypeValueSetFieldSpec

		// delegate function (callback) prototype associated with syntax rule FixedTypeValueSetFieldSpec
		public delegate bool FixedTypeValueSetFieldSpec_Callback (SyntaxTreeCallbackReason reason, FixedTypeValueSetFieldSpec.production_kind kind, FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec);

		// event associated with syntax rule FixedTypeValueSetFieldSpec
		public event FixedTypeValueSetFieldSpec_Callback FixedTypeValueSetFieldSpec_Event;

		// event trigger associated with syntax rule FixedTypeValueSetFieldSpec
		public bool Raise_FixedTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason reason, FixedTypeValueSetFieldSpec.production_kind kind, FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec)
		{
			bool? status = FixedTypeValueSetFieldSpec_Event?.Invoke (reason, kind, p_FixedTypeValueSetFieldSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule FixedTypeValueSetFieldSpec
		//
		// traverse syntax tree node associated with any production of syntax rule FixedTypeValueSetFieldSpec
		//

		public void Traverse (FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec)
		{
			if (p_FixedTypeValueSetFieldSpec.isLocked())
				return;
			p_FixedTypeValueSetFieldSpec.dolock();
			FixedTypeValueSetFieldSpec.production_kind kind = (FixedTypeValueSetFieldSpec.production_kind) p_FixedTypeValueSetFieldSpec.kind;
			p_FixedTypeValueSetFieldSpec.turn_reset ();
			if (Raise_FixedTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_FixedTypeValueSetFieldSpec))
			switch (kind)
			{
				case FixedTypeValueSetFieldSpec.production_kind.g_FixedTypeValueSetFieldSpec_1:
					// traverse syntax tree node associated with production
					// FixedTypeValueSetFieldSpec: valuesetfieldreference-token Type ValueSetOptionalitySpec-optional

					if (Raise_FixedTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FixedTypeValueSetFieldSpec))
						Traverse (p_FixedTypeValueSetFieldSpec.m_valuesetfieldreference_token);
					p_FixedTypeValueSetFieldSpec.turn_inc ();
					if (Raise_FixedTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FixedTypeValueSetFieldSpec))
						Traverse (p_FixedTypeValueSetFieldSpec.m_Type);
					p_FixedTypeValueSetFieldSpec.turn_inc ();
					if (Raise_FixedTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FixedTypeValueSetFieldSpec))
						Traverse (p_FixedTypeValueSetFieldSpec.m_ValueSetOptionalitySpec_optional);
					p_FixedTypeValueSetFieldSpec.turn_inc ();
					Raise_FixedTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FixedTypeValueSetFieldSpec);
				break;
			}
			Raise_FixedTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_FixedTypeValueSetFieldSpec);
			p_FixedTypeValueSetFieldSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule FixedTypeValueSetFieldSpec
		//

		public void TraverseCommon (FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec)
		{
			FixedTypeValueSetFieldSpec.production_kind kind = (FixedTypeValueSetFieldSpec.production_kind) p_FixedTypeValueSetFieldSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_FixedTypeValueSetFieldSpec))
			switch (kind)
			{
				case FixedTypeValueSetFieldSpec.production_kind.g_FixedTypeValueSetFieldSpec_1:
					// traverse syntax tree node associated with production
					// FixedTypeValueSetFieldSpec: valuesetfieldreference-token Type ValueSetOptionalitySpec-optional

						TraverseCommon (p_FixedTypeValueSetFieldSpec.m_valuesetfieldreference_token);
						TraverseCommon (p_FixedTypeValueSetFieldSpec.m_Type);
						TraverseCommon (p_FixedTypeValueSetFieldSpec.m_ValueSetOptionalitySpec_optional);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_FixedTypeValueSetFieldSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule FixedTypeValueSetFieldSpec

		//
		// create syntax tree node associated with production
		// FixedTypeValueSetFieldSpec: valuesetfieldreference-token Type ValueSetOptionalitySpec-optional

		//

		public FixedTypeValueSetFieldSpec FixedTypeValueSetFieldSpec_1 (valuesetfieldreference_token p_valuesetfieldreference_token, Type p_Type, ValueSetOptionalitySpec_optional p_ValueSetOptionalitySpec_optional)
		{
			FixedTypeValueSetFieldSpec p_FixedTypeValueSetFieldSpec_ref = new FixedTypeValueSetFieldSpec(p_valuesetfieldreference_token, p_Type, p_ValueSetOptionalitySpec_optional);
			p_valuesetfieldreference_token.parent = p_FixedTypeValueSetFieldSpec_ref;
			p_Type.parent = p_FixedTypeValueSetFieldSpec_ref;
			p_ValueSetOptionalitySpec_optional.parent = p_FixedTypeValueSetFieldSpec_ref;
			Raise_FixedTypeValueSetFieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FixedTypeValueSetFieldSpec.production_kind.g_FixedTypeValueSetFieldSpec_1, p_FixedTypeValueSetFieldSpec_ref);
			return p_FixedTypeValueSetFieldSpec_ref;
		}
		#endregion
	};
}
