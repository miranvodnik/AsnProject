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
	// class associated with syntax rule Tag
	//

	[DataContract]
	public class	Tag : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Tag
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Tag
		{
			g_Tag_1 = 1,	// "[" EncodingReference Class ClassNumber "]"

		};
		#endregion
		#region production markers associated with the syntax rule Tag

		// markers associated with production: Tag -> "[" EncodingReference Class ClassNumber "]"

		public enum production_marker_1 : ushort
		{
			m_EncodingReference,
			m_Class,
			m_ClassNumber,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Tag

		// Constructor declaration(s) associated with production(s) of syntax rule Tag

		//
		// Constructor associated with the following production(s)
		// Tag -> "[" EncodingReference Class ClassNumber "]"

		//

		public Tag (SyntaxTreeToken p_token, EncodingReference p_EncodingReference, Class p_Class, ClassNumber p_ClassNumber, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._Tag_ID, (uint) production_kind.g_Tag_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_left_square_bracket = p_token;
			children[1] = m_EncodingReference = p_EncodingReference;
			children[2] = m_Class = p_Class;
			children[3] = m_ClassNumber = p_ClassNumber;
			children[4] = m_right_square_bracket = p_token_1;
		}

		public Tag () { }

		// Copy constructor

		public Tag (Tag p_Tag) : base (p_Tag.id, p_Tag.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Tag.appInfo;
			switch ((production_kind) p_Tag.kind)
			{
				case production_kind.g_Tag_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_left_square_bracket = (p_Tag.m_left_square_bracket != null) ? new SyntaxTreeToken (p_Tag.m_left_square_bracket) : null) != null) m_left_square_bracket.parent = this;
					if ((children [1] = m_EncodingReference = (p_Tag.m_EncodingReference != null) ? new EncodingReference (p_Tag.m_EncodingReference) : null) != null) m_EncodingReference.parent = this;
					if ((children [2] = m_Class = (p_Tag.m_Class != null) ? new Class (p_Tag.m_Class) : null) != null) m_Class.parent = this;
					if ((children [3] = m_ClassNumber = (p_Tag.m_ClassNumber != null) ? new ClassNumber (p_Tag.m_ClassNumber) : null) != null) m_ClassNumber.parent = this;
					if ((children [4] = m_right_square_bracket = (p_Tag.m_right_square_bracket != null) ? new SyntaxTreeToken (p_Tag.m_right_square_bracket) : null) != null) m_right_square_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Tag" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Tag (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_square_bracket?.Dispose ();
			m_EncodingReference?.Dispose ();
			m_Class?.Dispose ();
			m_ClassNumber?.Dispose ();
			m_right_square_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Tag

		// Content changing function(s) associated with production(s) of syntax rule Tag

		//
		// Content changing function associated with following production(s)
		// Tag -> "[" EncodingReference Class ClassNumber "]"

		//

		public void change(SyntaxTreeToken p_token, EncodingReference p_EncodingReference, Class p_Class, ClassNumber p_ClassNumber, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_Tag_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_left_square_bracket = p_token;
			children [1] = m_EncodingReference = p_EncodingReference;
			children [2] = m_Class = p_Class;
			children [3] = m_ClassNumber = p_ClassNumber;
			children [4] = m_right_square_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Tag
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_square_bracket != null) && m_left_square_bracket.checkInclusion (element) ||
				(m_EncodingReference != null) && m_EncodingReference.checkInclusion (element) ||
				(m_Class != null) && m_Class.checkInclusion (element) ||
				(m_ClassNumber != null) && m_ClassNumber.checkInclusion (element) ||
				(m_right_square_bracket != null) && m_right_square_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Tag

		//
		// emit production tree node associated with any production of syntax rule Tag
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Tag_1:
					// emit syntax tree node associated with production
					// Tag: "[" EncodingReference Class ClassNumber "]"

					s += m_left_square_bracket.Emit (depth - 1);
					s += " ";
					s += m_EncodingReference.Emit (depth - 1);
					s += " ";
					s += m_Class.Emit (depth - 1);
					s += " ";
					s += m_ClassNumber.Emit (depth - 1);
					s += " ";
					s += m_right_square_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Tag
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Tag (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Tag_1:
					// emit syntax tree node associated with production
					// Tag: "[" EncodingReference Class ClassNumber "]"

					s += "left_square_bracket";
					s += ' ';
					s += m_EncodingReference.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Class.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ClassNumber.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_square_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Tag

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Tag with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Tag.production_kind kind = (Tag.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Tag.production_kind.g_Tag_1:
					// traverse syntax tree node associated with production
					// Tag: "[" EncodingReference Class ClassNumber "]"

						m_left_square_bracket.Visit (visitor, appData);
						m_EncodingReference.Visit (visitor, appData);
						m_Class.Visit (visitor, appData);
						m_ClassNumber.Visit (visitor, appData);
						m_right_square_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_left_square_bracket?.reparent (this);
			m_EncodingReference?.reparent (this);
			m_Class?.reparent (this);
			m_ClassNumber?.reparent (this);
			m_right_square_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Tag
		//

		public void _init ()
		{
			m_left_square_bracket = null;
			m_EncodingReference = null;
			m_Class = null;
			m_ClassNumber = null;
			m_right_square_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Tag

		// counter of all nodes associated with syntax rule Tag
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Tag
		[DataMember (Name = "m_left_square_bracket")] public SyntaxTreeToken m_left_square_bracket { get; private set; }
		[DataMember (Name = "m_EncodingReference")] public EncodingReference m_EncodingReference { get; private set; }
		[DataMember (Name = "m_Class")] public Class m_Class { get; private set; }
		[DataMember (Name = "m_ClassNumber")] public ClassNumber m_ClassNumber { get; private set; }
		[DataMember (Name = "m_right_square_bracket")] public SyntaxTreeToken m_right_square_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Tag

		// delegate function (callback) prototype associated with syntax rule Tag
		public delegate bool Tag_Callback (SyntaxTreeCallbackReason reason, Tag.production_kind kind, Tag p_Tag);

		// event associated with syntax rule Tag
		public event Tag_Callback Tag_Event;

		// event trigger associated with syntax rule Tag
		public bool Raise_Tag_Event (SyntaxTreeCallbackReason reason, Tag.production_kind kind, Tag p_Tag)
		{
			bool? status = Tag_Event?.Invoke (reason, kind, p_Tag);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Tag
		//
		// traverse syntax tree node associated with any production of syntax rule Tag
		//

		public void Traverse (Tag p_Tag)
		{
			if (p_Tag.isLocked())
				return;
			p_Tag.dolock();
			Tag.production_kind kind = (Tag.production_kind) p_Tag.kind;
			p_Tag.turn_reset ();
			if (Raise_Tag_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Tag))
			switch (kind)
			{
				case Tag.production_kind.g_Tag_1:
					// traverse syntax tree node associated with production
					// Tag: "[" EncodingReference Class ClassNumber "]"

					if (Raise_Tag_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Tag))
						Traverse (p_Tag.m_EncodingReference);
					p_Tag.turn_inc ();
					if (Raise_Tag_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Tag))
						Traverse (p_Tag.m_Class);
					p_Tag.turn_inc ();
					if (Raise_Tag_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Tag))
						Traverse (p_Tag.m_ClassNumber);
					p_Tag.turn_inc ();
					Raise_Tag_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Tag);
				break;
			}
			Raise_Tag_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Tag);
			p_Tag.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Tag
		//

		public void TraverseCommon (Tag p_Tag)
		{
			Tag.production_kind kind = (Tag.production_kind) p_Tag.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Tag))
			switch (kind)
			{
				case Tag.production_kind.g_Tag_1:
					// traverse syntax tree node associated with production
					// Tag: "[" EncodingReference Class ClassNumber "]"

						TraverseCommon (p_Tag.m_left_square_bracket);
						TraverseCommon (p_Tag.m_EncodingReference);
						TraverseCommon (p_Tag.m_Class);
						TraverseCommon (p_Tag.m_ClassNumber);
						TraverseCommon (p_Tag.m_right_square_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Tag);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Tag

		//
		// create syntax tree node associated with production
		// Tag: "[" EncodingReference Class ClassNumber "]"

		//

		public Tag Tag_1 (SyntaxTreeToken p_token, EncodingReference p_EncodingReference, Class p_Class, ClassNumber p_ClassNumber, SyntaxTreeToken p_token_1)
		{
			Tag p_Tag_ref = new Tag(p_token, p_EncodingReference, p_Class, p_ClassNumber, p_token_1);
			p_token.parent = p_Tag_ref;
			p_EncodingReference.parent = p_Tag_ref;
			p_Class.parent = p_Tag_ref;
			p_ClassNumber.parent = p_Tag_ref;
			p_token_1.parent = p_Tag_ref;
			Raise_Tag_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Tag.production_kind.g_Tag_1, p_Tag_ref);
			return p_Tag_ref;
		}
		#endregion
	};
}
