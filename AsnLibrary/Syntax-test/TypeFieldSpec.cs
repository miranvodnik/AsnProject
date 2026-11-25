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
	// class associated with syntax rule TypeFieldSpec
	//

	[DataContract]
	public class	TypeFieldSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TypeFieldSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TypeFieldSpec
		{
			g_TypeFieldSpec_1 = 1,	// typefieldreference-token TypeOptionalitySpec-optional

		};
		#endregion
		#region production markers associated with the syntax rule TypeFieldSpec

		// markers associated with production: TypeFieldSpec -> typefieldreference-token TypeOptionalitySpec-optional

		public enum production_marker_1 : ushort
		{
			m_typefieldreference_token,
			m_TypeOptionalitySpec_optional,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TypeFieldSpec

		// Constructor declaration(s) associated with production(s) of syntax rule TypeFieldSpec

		//
		// Constructor associated with the following production(s)
		// TypeFieldSpec -> typefieldreference-token TypeOptionalitySpec-optional

		//

		public TypeFieldSpec (typefieldreference_token p_typefieldreference_token, TypeOptionalitySpec_optional p_TypeOptionalitySpec_optional) : base ((uint) ProductionID._TypeFieldSpec_ID, (uint) production_kind.g_TypeFieldSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_typefieldreference_token = p_typefieldreference_token;
			children[1] = m_TypeOptionalitySpec_optional = p_TypeOptionalitySpec_optional;
		}

		public TypeFieldSpec () { }

		// Copy constructor

		public TypeFieldSpec (TypeFieldSpec p_TypeFieldSpec) : base (p_TypeFieldSpec.id, p_TypeFieldSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TypeFieldSpec.appInfo;
			switch ((production_kind) p_TypeFieldSpec.kind)
			{
				case production_kind.g_TypeFieldSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_typefieldreference_token = (p_TypeFieldSpec.m_typefieldreference_token != null) ? new typefieldreference_token (p_TypeFieldSpec.m_typefieldreference_token) : null) != null) m_typefieldreference_token.parent = this;
					if ((children [1] = m_TypeOptionalitySpec_optional = (p_TypeFieldSpec.m_TypeOptionalitySpec_optional != null) ? new TypeOptionalitySpec_optional (p_TypeFieldSpec.m_TypeOptionalitySpec_optional) : null) != null) m_TypeOptionalitySpec_optional.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TypeFieldSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TypeFieldSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_typefieldreference_token?.Dispose ();
			m_TypeOptionalitySpec_optional?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TypeFieldSpec

		// Content changing function(s) associated with production(s) of syntax rule TypeFieldSpec

		//
		// Content changing function associated with following production(s)
		// TypeFieldSpec -> typefieldreference-token TypeOptionalitySpec-optional

		//

		public void change(typefieldreference_token p_typefieldreference_token, TypeOptionalitySpec_optional p_TypeOptionalitySpec_optional)
		{
			_init ();
			this.kind = (uint) production_kind.g_TypeFieldSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_typefieldreference_token = p_typefieldreference_token;
			children [1] = m_TypeOptionalitySpec_optional = p_TypeOptionalitySpec_optional;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TypeFieldSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_typefieldreference_token != null) && m_typefieldreference_token.checkInclusion (element) ||
				(m_TypeOptionalitySpec_optional != null) && m_TypeOptionalitySpec_optional.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TypeFieldSpec

		//
		// emit production tree node associated with any production of syntax rule TypeFieldSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TypeFieldSpec_1:
					// emit syntax tree node associated with production
					// TypeFieldSpec: typefieldreference-token TypeOptionalitySpec-optional

					s += m_typefieldreference_token.Emit (depth - 1);
					s += " ";
					s += m_TypeOptionalitySpec_optional.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TypeFieldSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TypeFieldSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TypeFieldSpec_1:
					// emit syntax tree node associated with production
					// TypeFieldSpec: typefieldreference-token TypeOptionalitySpec-optional

					s += m_typefieldreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_TypeOptionalitySpec_optional.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TypeFieldSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TypeFieldSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TypeFieldSpec.production_kind kind = (TypeFieldSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TypeFieldSpec.production_kind.g_TypeFieldSpec_1:
					// traverse syntax tree node associated with production
					// TypeFieldSpec: typefieldreference-token TypeOptionalitySpec-optional

						m_typefieldreference_token.Visit (visitor, appData);
						m_TypeOptionalitySpec_optional.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_typefieldreference_token?.reparent (this);
			m_TypeOptionalitySpec_optional?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TypeFieldSpec
		//

		public void _init ()
		{
			m_typefieldreference_token = null;
			m_TypeOptionalitySpec_optional = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TypeFieldSpec

		// counter of all nodes associated with syntax rule TypeFieldSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TypeFieldSpec
		[DataMember (Name = "m_typefieldreference_token")] public typefieldreference_token m_typefieldreference_token { get; private set; }
		[DataMember (Name = "m_TypeOptionalitySpec_optional")] public TypeOptionalitySpec_optional m_TypeOptionalitySpec_optional { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TypeFieldSpec

		// delegate function (callback) prototype associated with syntax rule TypeFieldSpec
		public delegate bool TypeFieldSpec_Callback (SyntaxTreeCallbackReason reason, TypeFieldSpec.production_kind kind, TypeFieldSpec p_TypeFieldSpec);

		// event associated with syntax rule TypeFieldSpec
		public event TypeFieldSpec_Callback TypeFieldSpec_Event;

		// event trigger associated with syntax rule TypeFieldSpec
		public bool Raise_TypeFieldSpec_Event (SyntaxTreeCallbackReason reason, TypeFieldSpec.production_kind kind, TypeFieldSpec p_TypeFieldSpec)
		{
			bool? status = TypeFieldSpec_Event?.Invoke (reason, kind, p_TypeFieldSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TypeFieldSpec
		//
		// traverse syntax tree node associated with any production of syntax rule TypeFieldSpec
		//

		public void Traverse (TypeFieldSpec p_TypeFieldSpec)
		{
			if (p_TypeFieldSpec.isLocked())
				return;
			p_TypeFieldSpec.dolock();
			TypeFieldSpec.production_kind kind = (TypeFieldSpec.production_kind) p_TypeFieldSpec.kind;
			p_TypeFieldSpec.turn_reset ();
			if (Raise_TypeFieldSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TypeFieldSpec))
			switch (kind)
			{
				case TypeFieldSpec.production_kind.g_TypeFieldSpec_1:
					// traverse syntax tree node associated with production
					// TypeFieldSpec: typefieldreference-token TypeOptionalitySpec-optional

					if (Raise_TypeFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeFieldSpec))
						Traverse (p_TypeFieldSpec.m_typefieldreference_token);
					p_TypeFieldSpec.turn_inc ();
					if (Raise_TypeFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeFieldSpec))
						Traverse (p_TypeFieldSpec.m_TypeOptionalitySpec_optional);
					p_TypeFieldSpec.turn_inc ();
					Raise_TypeFieldSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TypeFieldSpec);
				break;
			}
			Raise_TypeFieldSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TypeFieldSpec);
			p_TypeFieldSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TypeFieldSpec
		//

		public void TraverseCommon (TypeFieldSpec p_TypeFieldSpec)
		{
			TypeFieldSpec.production_kind kind = (TypeFieldSpec.production_kind) p_TypeFieldSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TypeFieldSpec))
			switch (kind)
			{
				case TypeFieldSpec.production_kind.g_TypeFieldSpec_1:
					// traverse syntax tree node associated with production
					// TypeFieldSpec: typefieldreference-token TypeOptionalitySpec-optional

						TraverseCommon (p_TypeFieldSpec.m_typefieldreference_token);
						TraverseCommon (p_TypeFieldSpec.m_TypeOptionalitySpec_optional);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TypeFieldSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TypeFieldSpec

		//
		// create syntax tree node associated with production
		// TypeFieldSpec: typefieldreference-token TypeOptionalitySpec-optional

		//

		public TypeFieldSpec TypeFieldSpec_1 (typefieldreference_token p_typefieldreference_token, TypeOptionalitySpec_optional p_TypeOptionalitySpec_optional)
		{
			TypeFieldSpec p_TypeFieldSpec_ref = new TypeFieldSpec(p_typefieldreference_token, p_TypeOptionalitySpec_optional);
			p_typefieldreference_token.parent = p_TypeFieldSpec_ref;
			p_TypeOptionalitySpec_optional.parent = p_TypeFieldSpec_ref;
			Raise_TypeFieldSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TypeFieldSpec.production_kind.g_TypeFieldSpec_1, p_TypeFieldSpec_ref);
			return p_TypeFieldSpec_ref;
		}
		#endregion
	};
}
