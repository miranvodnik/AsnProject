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
	// class associated with syntax rule ObjectClassDefn
	//

	[DataContract]
	public class	ObjectClassDefn : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectClassDefn
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectClassDefn
		{
			g_ObjectClassDefn_1 = 1,	// CLASS "{" FieldSpec-set "}" WithSyntaxSpec-optional

		};
		#endregion
		#region production markers associated with the syntax rule ObjectClassDefn

		// markers associated with production: ObjectClassDefn -> CLASS "{" FieldSpec-set "}" WithSyntaxSpec-optional

		public enum production_marker_1 : ushort
		{
			m_FieldSpec_set,
			m_WithSyntaxSpec_optional,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectClassDefn

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectClassDefn

		//
		// Constructor associated with the following production(s)
		// ObjectClassDefn -> CLASS "{" FieldSpec-set "}" WithSyntaxSpec-optional

		//

		public ObjectClassDefn (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, FieldSpec_set p_FieldSpec_set, SyntaxTreeToken p_token_2, WithSyntaxSpec_optional p_WithSyntaxSpec_optional) : base ((uint) ProductionID._ObjectClassDefn_ID, (uint) production_kind.g_ObjectClassDefn_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_CLASS = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_FieldSpec_set = p_FieldSpec_set;
			children[3] = m_right_curly_bracket = p_token_2;
			children[4] = m_WithSyntaxSpec_optional = p_WithSyntaxSpec_optional;
		}

		public ObjectClassDefn () { }

		// Copy constructor

		public ObjectClassDefn (ObjectClassDefn p_ObjectClassDefn) : base (p_ObjectClassDefn.id, p_ObjectClassDefn.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectClassDefn.appInfo;
			switch ((production_kind) p_ObjectClassDefn.kind)
			{
				case production_kind.g_ObjectClassDefn_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_CLASS = (p_ObjectClassDefn.m_CLASS != null) ? new SyntaxTreeToken (p_ObjectClassDefn.m_CLASS) : null) != null) m_CLASS.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_ObjectClassDefn.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_ObjectClassDefn.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_FieldSpec_set = (p_ObjectClassDefn.m_FieldSpec_set != null) ? new FieldSpec_set (p_ObjectClassDefn.m_FieldSpec_set) : null) != null) m_FieldSpec_set.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_ObjectClassDefn.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_ObjectClassDefn.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					if ((children [4] = m_WithSyntaxSpec_optional = (p_ObjectClassDefn.m_WithSyntaxSpec_optional != null) ? new WithSyntaxSpec_optional (p_ObjectClassDefn.m_WithSyntaxSpec_optional) : null) != null) m_WithSyntaxSpec_optional.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectClassDefn" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectClassDefn (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_CLASS?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_FieldSpec_set?.Dispose ();
			m_right_curly_bracket?.Dispose ();
			m_WithSyntaxSpec_optional?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectClassDefn

		// Content changing function(s) associated with production(s) of syntax rule ObjectClassDefn

		//
		// Content changing function associated with following production(s)
		// ObjectClassDefn -> CLASS "{" FieldSpec-set "}" WithSyntaxSpec-optional

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, FieldSpec_set p_FieldSpec_set, SyntaxTreeToken p_token_2, WithSyntaxSpec_optional p_WithSyntaxSpec_optional)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectClassDefn_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_CLASS = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_FieldSpec_set = p_FieldSpec_set;
			children [3] = m_right_curly_bracket = p_token_2;
			children [4] = m_WithSyntaxSpec_optional = p_WithSyntaxSpec_optional;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectClassDefn
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_CLASS != null) && m_CLASS.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_FieldSpec_set != null) && m_FieldSpec_set.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				(m_WithSyntaxSpec_optional != null) && m_WithSyntaxSpec_optional.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectClassDefn

		//
		// emit production tree node associated with any production of syntax rule ObjectClassDefn
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectClassDefn_1:
					// emit syntax tree node associated with production
					// ObjectClassDefn: CLASS "{" FieldSpec-set "}" WithSyntaxSpec-optional

					s += m_CLASS.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_FieldSpec_set.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_WithSyntaxSpec_optional.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectClassDefn
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectClassDefn (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectClassDefn_1:
					// emit syntax tree node associated with production
					// ObjectClassDefn: CLASS "{" FieldSpec-set "}" WithSyntaxSpec-optional

					s += "CLASS";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_FieldSpec_set.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
					s += ' ';
					s += m_WithSyntaxSpec_optional.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectClassDefn

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectClassDefn with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectClassDefn.production_kind kind = (ObjectClassDefn.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectClassDefn.production_kind.g_ObjectClassDefn_1:
					// traverse syntax tree node associated with production
					// ObjectClassDefn: CLASS "{" FieldSpec-set "}" WithSyntaxSpec-optional

						m_CLASS.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_FieldSpec_set.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
						m_WithSyntaxSpec_optional.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_CLASS?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_FieldSpec_set?.reparent (this);
			m_right_curly_bracket?.reparent (this);
			m_WithSyntaxSpec_optional?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectClassDefn
		//

		public void _init ()
		{
			m_CLASS = null;
			m_left_curly_bracket = null;
			m_FieldSpec_set = null;
			m_right_curly_bracket = null;
			m_WithSyntaxSpec_optional = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectClassDefn

		// counter of all nodes associated with syntax rule ObjectClassDefn
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectClassDefn
		[DataMember (Name = "m_CLASS")] public SyntaxTreeToken m_CLASS { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_FieldSpec_set")] public FieldSpec_set m_FieldSpec_set { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		[DataMember (Name = "m_WithSyntaxSpec_optional")] public WithSyntaxSpec_optional m_WithSyntaxSpec_optional { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectClassDefn

		// delegate function (callback) prototype associated with syntax rule ObjectClassDefn
		public delegate bool ObjectClassDefn_Callback (SyntaxTreeCallbackReason reason, ObjectClassDefn.production_kind kind, ObjectClassDefn p_ObjectClassDefn);

		// event associated with syntax rule ObjectClassDefn
		public event ObjectClassDefn_Callback ObjectClassDefn_Event;

		// event trigger associated with syntax rule ObjectClassDefn
		public bool Raise_ObjectClassDefn_Event (SyntaxTreeCallbackReason reason, ObjectClassDefn.production_kind kind, ObjectClassDefn p_ObjectClassDefn)
		{
			bool? status = ObjectClassDefn_Event?.Invoke (reason, kind, p_ObjectClassDefn);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectClassDefn
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectClassDefn
		//

		public void Traverse (ObjectClassDefn p_ObjectClassDefn)
		{
			if (p_ObjectClassDefn.isLocked())
				return;
			p_ObjectClassDefn.dolock();
			ObjectClassDefn.production_kind kind = (ObjectClassDefn.production_kind) p_ObjectClassDefn.kind;
			p_ObjectClassDefn.turn_reset ();
			if (Raise_ObjectClassDefn_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectClassDefn))
			switch (kind)
			{
				case ObjectClassDefn.production_kind.g_ObjectClassDefn_1:
					// traverse syntax tree node associated with production
					// ObjectClassDefn: CLASS "{" FieldSpec-set "}" WithSyntaxSpec-optional

					if (Raise_ObjectClassDefn_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClassDefn))
						Traverse (p_ObjectClassDefn.m_FieldSpec_set);
					p_ObjectClassDefn.turn_inc ();
					if (Raise_ObjectClassDefn_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClassDefn))
						Traverse (p_ObjectClassDefn.m_WithSyntaxSpec_optional);
					p_ObjectClassDefn.turn_inc ();
					Raise_ObjectClassDefn_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClassDefn);
				break;
			}
			Raise_ObjectClassDefn_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectClassDefn);
			p_ObjectClassDefn.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectClassDefn
		//

		public void TraverseCommon (ObjectClassDefn p_ObjectClassDefn)
		{
			ObjectClassDefn.production_kind kind = (ObjectClassDefn.production_kind) p_ObjectClassDefn.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectClassDefn))
			switch (kind)
			{
				case ObjectClassDefn.production_kind.g_ObjectClassDefn_1:
					// traverse syntax tree node associated with production
					// ObjectClassDefn: CLASS "{" FieldSpec-set "}" WithSyntaxSpec-optional

						TraverseCommon (p_ObjectClassDefn.m_CLASS);
						TraverseCommon (p_ObjectClassDefn.m_left_curly_bracket);
						TraverseCommon (p_ObjectClassDefn.m_FieldSpec_set);
						TraverseCommon (p_ObjectClassDefn.m_right_curly_bracket);
						TraverseCommon (p_ObjectClassDefn.m_WithSyntaxSpec_optional);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectClassDefn);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectClassDefn

		//
		// create syntax tree node associated with production
		// ObjectClassDefn: CLASS "{" FieldSpec-set "}" WithSyntaxSpec-optional

		//

		public ObjectClassDefn ObjectClassDefn_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, FieldSpec_set p_FieldSpec_set, SyntaxTreeToken p_token_2, WithSyntaxSpec_optional p_WithSyntaxSpec_optional)
		{
			ObjectClassDefn p_ObjectClassDefn_ref = new ObjectClassDefn(p_token, p_token_1, p_FieldSpec_set, p_token_2, p_WithSyntaxSpec_optional);
			p_token.parent = p_ObjectClassDefn_ref;
			p_token_1.parent = p_ObjectClassDefn_ref;
			p_FieldSpec_set.parent = p_ObjectClassDefn_ref;
			p_token_2.parent = p_ObjectClassDefn_ref;
			p_WithSyntaxSpec_optional.parent = p_ObjectClassDefn_ref;
			Raise_ObjectClassDefn_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectClassDefn.production_kind.g_ObjectClassDefn_1, p_ObjectClassDefn_ref);
			return p_ObjectClassDefn_ref;
		}
		#endregion
	};
}
