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
	// class associated with syntax rule ExtensionAdditionAlternativesGroup
	//

	[DataContract]
	public class	ExtensionAdditionAlternativesGroup : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExtensionAdditionAlternativesGroup
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExtensionAdditionAlternativesGroup
		{
			g_ExtensionAdditionAlternativesGroup_1 = 1,	// "[" "[" VersionNumber AlternativeTypeList "]" "]"

		};
		#endregion
		#region production markers associated with the syntax rule ExtensionAdditionAlternativesGroup

		// markers associated with production: ExtensionAdditionAlternativesGroup -> "[" "[" VersionNumber AlternativeTypeList "]" "]"

		public enum production_marker_1 : ushort
		{
			m_VersionNumber,
			m_AlternativeTypeList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExtensionAdditionAlternativesGroup

		// Constructor declaration(s) associated with production(s) of syntax rule ExtensionAdditionAlternativesGroup

		//
		// Constructor associated with the following production(s)
		// ExtensionAdditionAlternativesGroup -> "[" "[" VersionNumber AlternativeTypeList "]" "]"

		//

		public ExtensionAdditionAlternativesGroup (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, VersionNumber p_VersionNumber, AlternativeTypeList p_AlternativeTypeList, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._ExtensionAdditionAlternativesGroup_ID, (uint) production_kind.g_ExtensionAdditionAlternativesGroup_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
			children[0] = m_left_square_bracket = p_token;
			children[1] = m_left_square_bracket_1 = p_token_1;
			children[2] = m_VersionNumber = p_VersionNumber;
			children[3] = m_AlternativeTypeList = p_AlternativeTypeList;
			children[4] = m_right_square_bracket = p_token_2;
			children[5] = m_right_square_bracket_1 = p_token_3;
		}

		public ExtensionAdditionAlternativesGroup () { }

		// Copy constructor

		public ExtensionAdditionAlternativesGroup (ExtensionAdditionAlternativesGroup p_ExtensionAdditionAlternativesGroup) : base (p_ExtensionAdditionAlternativesGroup.id, p_ExtensionAdditionAlternativesGroup.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExtensionAdditionAlternativesGroup.appInfo;
			switch ((production_kind) p_ExtensionAdditionAlternativesGroup.kind)
			{
				case production_kind.g_ExtensionAdditionAlternativesGroup_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
					if ((children [0] = m_left_square_bracket = (p_ExtensionAdditionAlternativesGroup.m_left_square_bracket != null) ? new SyntaxTreeToken (p_ExtensionAdditionAlternativesGroup.m_left_square_bracket) : null) != null) m_left_square_bracket.parent = this;
					if ((children [1] = m_left_square_bracket_1 = (p_ExtensionAdditionAlternativesGroup.m_left_square_bracket_1 != null) ? new SyntaxTreeToken (p_ExtensionAdditionAlternativesGroup.m_left_square_bracket_1) : null) != null) m_left_square_bracket_1.parent = this;
					if ((children [2] = m_VersionNumber = (p_ExtensionAdditionAlternativesGroup.m_VersionNumber != null) ? new VersionNumber (p_ExtensionAdditionAlternativesGroup.m_VersionNumber) : null) != null) m_VersionNumber.parent = this;
					if ((children [3] = m_AlternativeTypeList = (p_ExtensionAdditionAlternativesGroup.m_AlternativeTypeList != null) ? new AlternativeTypeList (p_ExtensionAdditionAlternativesGroup.m_AlternativeTypeList) : null) != null) m_AlternativeTypeList.parent = this;
					if ((children [4] = m_right_square_bracket = (p_ExtensionAdditionAlternativesGroup.m_right_square_bracket != null) ? new SyntaxTreeToken (p_ExtensionAdditionAlternativesGroup.m_right_square_bracket) : null) != null) m_right_square_bracket.parent = this;
					if ((children [5] = m_right_square_bracket_1 = (p_ExtensionAdditionAlternativesGroup.m_right_square_bracket_1 != null) ? new SyntaxTreeToken (p_ExtensionAdditionAlternativesGroup.m_right_square_bracket_1) : null) != null) m_right_square_bracket_1.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExtensionAdditionAlternativesGroup" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExtensionAdditionAlternativesGroup (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_square_bracket?.Dispose ();
			m_left_square_bracket_1?.Dispose ();
			m_VersionNumber?.Dispose ();
			m_AlternativeTypeList?.Dispose ();
			m_right_square_bracket?.Dispose ();
			m_right_square_bracket_1?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExtensionAdditionAlternativesGroup

		// Content changing function(s) associated with production(s) of syntax rule ExtensionAdditionAlternativesGroup

		//
		// Content changing function associated with following production(s)
		// ExtensionAdditionAlternativesGroup -> "[" "[" VersionNumber AlternativeTypeList "]" "]"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, VersionNumber p_VersionNumber, AlternativeTypeList p_AlternativeTypeList, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAdditionAlternativesGroup_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
			children [0] = m_left_square_bracket = p_token;
			children [1] = m_left_square_bracket_1 = p_token_1;
			children [2] = m_VersionNumber = p_VersionNumber;
			children [3] = m_AlternativeTypeList = p_AlternativeTypeList;
			children [4] = m_right_square_bracket = p_token_2;
			children [5] = m_right_square_bracket_1 = p_token_3;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExtensionAdditionAlternativesGroup
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_square_bracket != null) && m_left_square_bracket.checkInclusion (element) ||
				(m_left_square_bracket_1 != null) && m_left_square_bracket_1.checkInclusion (element) ||
				(m_VersionNumber != null) && m_VersionNumber.checkInclusion (element) ||
				(m_AlternativeTypeList != null) && m_AlternativeTypeList.checkInclusion (element) ||
				(m_right_square_bracket != null) && m_right_square_bracket.checkInclusion (element) ||
				(m_right_square_bracket_1 != null) && m_right_square_bracket_1.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExtensionAdditionAlternativesGroup

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditionAlternativesGroup
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExtensionAdditionAlternativesGroup_1:
					// emit syntax tree node associated with production
					// ExtensionAdditionAlternativesGroup: "[" "[" VersionNumber AlternativeTypeList "]" "]"

					s += m_left_square_bracket.Emit (depth - 1);
					s += " ";
					s += m_left_square_bracket_1.Emit (depth - 1);
					s += " ";
					s += m_VersionNumber.Emit (depth - 1);
					s += " ";
					s += m_AlternativeTypeList.Emit (depth - 1);
					s += " ";
					s += m_right_square_bracket.Emit (depth - 1);
					s += " ";
					s += m_right_square_bracket_1.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditionAlternativesGroup
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExtensionAdditionAlternativesGroup (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExtensionAdditionAlternativesGroup_1:
					// emit syntax tree node associated with production
					// ExtensionAdditionAlternativesGroup: "[" "[" VersionNumber AlternativeTypeList "]" "]"

					s += "left_square_bracket";
					s += ' ';
					s += "left_square_bracket";
					s += ' ';
					s += m_VersionNumber.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_AlternativeTypeList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_square_bracket";
					s += ' ';
					s += "right_square_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExtensionAdditionAlternativesGroup

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionAlternativesGroup with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExtensionAdditionAlternativesGroup.production_kind kind = (ExtensionAdditionAlternativesGroup.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExtensionAdditionAlternativesGroup.production_kind.g_ExtensionAdditionAlternativesGroup_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternativesGroup: "[" "[" VersionNumber AlternativeTypeList "]" "]"

						m_left_square_bracket.Visit (visitor, appData);
						m_left_square_bracket_1.Visit (visitor, appData);
						m_VersionNumber.Visit (visitor, appData);
						m_AlternativeTypeList.Visit (visitor, appData);
						m_right_square_bracket.Visit (visitor, appData);
						m_right_square_bracket_1.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_left_square_bracket?.reparent (this);
			m_left_square_bracket_1?.reparent (this);

			m_VersionNumber?.reparent (this);
			m_AlternativeTypeList?.reparent (this);
			m_right_square_bracket?.reparent (this);
			m_right_square_bracket_1?.reparent (this);

		}

		//
		// initialize object associated with syntax rule ExtensionAdditionAlternativesGroup
		//

		public void _init ()
		{
			m_left_square_bracket = null;
			m_left_square_bracket_1 = null;
			m_VersionNumber = null;
			m_AlternativeTypeList = null;
			m_right_square_bracket = null;
			m_right_square_bracket_1 = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExtensionAdditionAlternativesGroup

		// counter of all nodes associated with syntax rule ExtensionAdditionAlternativesGroup
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExtensionAdditionAlternativesGroup
		[DataMember (Name = "m_left_square_bracket")] public SyntaxTreeToken m_left_square_bracket { get; private set; }
		[DataMember (Name = "m_left_square_bracket_1")] public SyntaxTreeToken m_left_square_bracket_1 { get; private set; }
		[DataMember (Name = "m_VersionNumber")] public VersionNumber m_VersionNumber { get; private set; }
		[DataMember (Name = "m_AlternativeTypeList")] public AlternativeTypeList m_AlternativeTypeList { get; private set; }
		[DataMember (Name = "m_right_square_bracket")] public SyntaxTreeToken m_right_square_bracket { get; private set; }
		[DataMember (Name = "m_right_square_bracket_1")] public SyntaxTreeToken m_right_square_bracket_1 { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExtensionAdditionAlternativesGroup

		// delegate function (callback) prototype associated with syntax rule ExtensionAdditionAlternativesGroup
		public delegate bool ExtensionAdditionAlternativesGroup_Callback (SyntaxTreeCallbackReason reason, ExtensionAdditionAlternativesGroup.production_kind kind, ExtensionAdditionAlternativesGroup p_ExtensionAdditionAlternativesGroup);

		// event associated with syntax rule ExtensionAdditionAlternativesGroup
		public event ExtensionAdditionAlternativesGroup_Callback ExtensionAdditionAlternativesGroup_Event;

		// event trigger associated with syntax rule ExtensionAdditionAlternativesGroup
		public bool Raise_ExtensionAdditionAlternativesGroup_Event (SyntaxTreeCallbackReason reason, ExtensionAdditionAlternativesGroup.production_kind kind, ExtensionAdditionAlternativesGroup p_ExtensionAdditionAlternativesGroup)
		{
			bool? status = ExtensionAdditionAlternativesGroup_Event?.Invoke (reason, kind, p_ExtensionAdditionAlternativesGroup);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExtensionAdditionAlternativesGroup
		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionAlternativesGroup
		//

		public void Traverse (ExtensionAdditionAlternativesGroup p_ExtensionAdditionAlternativesGroup)
		{
			if (p_ExtensionAdditionAlternativesGroup.isLocked())
				return;
			p_ExtensionAdditionAlternativesGroup.dolock();
			ExtensionAdditionAlternativesGroup.production_kind kind = (ExtensionAdditionAlternativesGroup.production_kind) p_ExtensionAdditionAlternativesGroup.kind;
			p_ExtensionAdditionAlternativesGroup.turn_reset ();
			if (Raise_ExtensionAdditionAlternativesGroup_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExtensionAdditionAlternativesGroup))
			switch (kind)
			{
				case ExtensionAdditionAlternativesGroup.production_kind.g_ExtensionAdditionAlternativesGroup_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternativesGroup: "[" "[" VersionNumber AlternativeTypeList "]" "]"

					if (Raise_ExtensionAdditionAlternativesGroup_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditionAlternativesGroup))
						Traverse (p_ExtensionAdditionAlternativesGroup.m_VersionNumber);
					p_ExtensionAdditionAlternativesGroup.turn_inc ();
					if (Raise_ExtensionAdditionAlternativesGroup_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditionAlternativesGroup))
						Traverse (p_ExtensionAdditionAlternativesGroup.m_AlternativeTypeList);
					p_ExtensionAdditionAlternativesGroup.turn_inc ();
					Raise_ExtensionAdditionAlternativesGroup_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditionAlternativesGroup);
				break;
			}
			Raise_ExtensionAdditionAlternativesGroup_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExtensionAdditionAlternativesGroup);
			p_ExtensionAdditionAlternativesGroup.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionAlternativesGroup
		//

		public void TraverseCommon (ExtensionAdditionAlternativesGroup p_ExtensionAdditionAlternativesGroup)
		{
			ExtensionAdditionAlternativesGroup.production_kind kind = (ExtensionAdditionAlternativesGroup.production_kind) p_ExtensionAdditionAlternativesGroup.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExtensionAdditionAlternativesGroup))
			switch (kind)
			{
				case ExtensionAdditionAlternativesGroup.production_kind.g_ExtensionAdditionAlternativesGroup_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternativesGroup: "[" "[" VersionNumber AlternativeTypeList "]" "]"

						TraverseCommon (p_ExtensionAdditionAlternativesGroup.m_left_square_bracket);
						TraverseCommon (p_ExtensionAdditionAlternativesGroup.m_left_square_bracket_1);
						TraverseCommon (p_ExtensionAdditionAlternativesGroup.m_VersionNumber);
						TraverseCommon (p_ExtensionAdditionAlternativesGroup.m_AlternativeTypeList);
						TraverseCommon (p_ExtensionAdditionAlternativesGroup.m_right_square_bracket);
						TraverseCommon (p_ExtensionAdditionAlternativesGroup.m_right_square_bracket_1);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExtensionAdditionAlternativesGroup);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExtensionAdditionAlternativesGroup

		//
		// create syntax tree node associated with production
		// ExtensionAdditionAlternativesGroup: "[" "[" VersionNumber AlternativeTypeList "]" "]"

		//

		public ExtensionAdditionAlternativesGroup ExtensionAdditionAlternativesGroup_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, VersionNumber p_VersionNumber, AlternativeTypeList p_AlternativeTypeList, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			ExtensionAdditionAlternativesGroup p_ExtensionAdditionAlternativesGroup_ref = new ExtensionAdditionAlternativesGroup(p_token, p_token_1, p_VersionNumber, p_AlternativeTypeList, p_token_2, p_token_3);
			p_token.parent = p_ExtensionAdditionAlternativesGroup_ref;
			p_token_1.parent = p_ExtensionAdditionAlternativesGroup_ref;
			p_VersionNumber.parent = p_ExtensionAdditionAlternativesGroup_ref;
			p_AlternativeTypeList.parent = p_ExtensionAdditionAlternativesGroup_ref;
			p_token_2.parent = p_ExtensionAdditionAlternativesGroup_ref;
			p_token_3.parent = p_ExtensionAdditionAlternativesGroup_ref;
			Raise_ExtensionAdditionAlternativesGroup_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAdditionAlternativesGroup.production_kind.g_ExtensionAdditionAlternativesGroup_1, p_ExtensionAdditionAlternativesGroup_ref);
			return p_ExtensionAdditionAlternativesGroup_ref;
		}
		#endregion
	};
}
