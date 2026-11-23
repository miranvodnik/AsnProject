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
	// class associated with syntax rule EnumeratedType
	//

	[DataContract]
	public class	EnumeratedType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EnumeratedType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EnumeratedType
		{
			g_EnumeratedType_1 = 1,	// ENUMERATED "{" Enumerations "}"

		};
		#endregion
		#region production markers associated with the syntax rule EnumeratedType

		// markers associated with production: EnumeratedType -> ENUMERATED "{" Enumerations "}"

		public enum production_marker_1 : ushort
		{
			m_Enumerations,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EnumeratedType

		// Constructor declaration(s) associated with production(s) of syntax rule EnumeratedType

		//
		// Constructor associated with the following production(s)
		// EnumeratedType -> ENUMERATED "{" Enumerations "}"

		//

		public EnumeratedType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Enumerations p_Enumerations, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._EnumeratedType_ID, (uint) production_kind.g_EnumeratedType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_ENUMERATED = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_Enumerations = p_Enumerations;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		public EnumeratedType () { }

		// Copy constructor

		public EnumeratedType (EnumeratedType p_EnumeratedType) : base (p_EnumeratedType.id, p_EnumeratedType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EnumeratedType.appInfo;
			switch ((production_kind) p_EnumeratedType.kind)
			{
				case production_kind.g_EnumeratedType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_ENUMERATED = (p_EnumeratedType.m_ENUMERATED != null) ? new SyntaxTreeToken (p_EnumeratedType.m_ENUMERATED) : null) != null) m_ENUMERATED.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_EnumeratedType.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_EnumeratedType.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_Enumerations = (p_EnumeratedType.m_Enumerations != null) ? new Enumerations (p_EnumeratedType.m_Enumerations) : null) != null) m_Enumerations.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_EnumeratedType.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_EnumeratedType.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EnumeratedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EnumeratedType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ENUMERATED?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_Enumerations?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EnumeratedType

		// Content changing function(s) associated with production(s) of syntax rule EnumeratedType

		//
		// Content changing function associated with following production(s)
		// EnumeratedType -> ENUMERATED "{" Enumerations "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Enumerations p_Enumerations, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_EnumeratedType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_ENUMERATED = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_Enumerations = p_Enumerations;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EnumeratedType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ENUMERATED != null) && m_ENUMERATED.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_Enumerations != null) && m_Enumerations.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EnumeratedType

		//
		// emit production tree node associated with any production of syntax rule EnumeratedType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EnumeratedType_1:
					// emit syntax tree node associated with production
					// EnumeratedType: ENUMERATED "{" Enumerations "}"

					s += m_ENUMERATED.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_Enumerations.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EnumeratedType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EnumeratedType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EnumeratedType_1:
					// emit syntax tree node associated with production
					// EnumeratedType: ENUMERATED "{" Enumerations "}"

					s += "ENUMERATED";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_Enumerations.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EnumeratedType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EnumeratedType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EnumeratedType.production_kind kind = (EnumeratedType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EnumeratedType.production_kind.g_EnumeratedType_1:
					// traverse syntax tree node associated with production
					// EnumeratedType: ENUMERATED "{" Enumerations "}"

						m_ENUMERATED.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_Enumerations.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ENUMERATED?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_Enumerations?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule EnumeratedType
		//

		public void _init ()
		{
			m_ENUMERATED = null;
			m_left_curly_bracket = null;
			m_Enumerations = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EnumeratedType

		// counter of all nodes associated with syntax rule EnumeratedType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EnumeratedType
		[DataMember (Name = "m_ENUMERATED")] public SyntaxTreeToken m_ENUMERATED { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_Enumerations")] public Enumerations m_Enumerations { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EnumeratedType

		// delegate function (callback) prototype associated with syntax rule EnumeratedType
		public delegate bool EnumeratedType_Callback (SyntaxTreeCallbackReason reason, EnumeratedType.production_kind kind, EnumeratedType p_EnumeratedType);

		// event associated with syntax rule EnumeratedType
		public event EnumeratedType_Callback EnumeratedType_Event;

		// event trigger associated with syntax rule EnumeratedType
		public bool Raise_EnumeratedType_Event (SyntaxTreeCallbackReason reason, EnumeratedType.production_kind kind, EnumeratedType p_EnumeratedType)
		{
			bool? status = EnumeratedType_Event?.Invoke (reason, kind, p_EnumeratedType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EnumeratedType
		//
		// traverse syntax tree node associated with any production of syntax rule EnumeratedType
		//

		public void Traverse (EnumeratedType p_EnumeratedType)
		{
			if (p_EnumeratedType.isLocked())
				return;
			p_EnumeratedType.dolock();
			EnumeratedType.production_kind kind = (EnumeratedType.production_kind) p_EnumeratedType.kind;
			p_EnumeratedType.turn_reset ();
			if (Raise_EnumeratedType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EnumeratedType))
			switch (kind)
			{
				case EnumeratedType.production_kind.g_EnumeratedType_1:
					// traverse syntax tree node associated with production
					// EnumeratedType: ENUMERATED "{" Enumerations "}"

					if (Raise_EnumeratedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EnumeratedType))
						Traverse (p_EnumeratedType.m_Enumerations);
					p_EnumeratedType.turn_inc ();
					Raise_EnumeratedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EnumeratedType);
				break;
			}
			Raise_EnumeratedType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EnumeratedType);
			p_EnumeratedType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EnumeratedType
		//

		public void TraverseCommon (EnumeratedType p_EnumeratedType)
		{
			EnumeratedType.production_kind kind = (EnumeratedType.production_kind) p_EnumeratedType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EnumeratedType))
			switch (kind)
			{
				case EnumeratedType.production_kind.g_EnumeratedType_1:
					// traverse syntax tree node associated with production
					// EnumeratedType: ENUMERATED "{" Enumerations "}"

						TraverseCommon (p_EnumeratedType.m_ENUMERATED);
						TraverseCommon (p_EnumeratedType.m_left_curly_bracket);
						TraverseCommon (p_EnumeratedType.m_Enumerations);
						TraverseCommon (p_EnumeratedType.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EnumeratedType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EnumeratedType

		//
		// create syntax tree node associated with production
		// EnumeratedType: ENUMERATED "{" Enumerations "}"

		//

		public EnumeratedType EnumeratedType_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Enumerations p_Enumerations, SyntaxTreeToken p_token_2)
		{
			EnumeratedType p_EnumeratedType_ref = new EnumeratedType(p_token, p_token_1, p_Enumerations, p_token_2);
			p_token.parent = p_EnumeratedType_ref;
			p_token_1.parent = p_EnumeratedType_ref;
			p_Enumerations.parent = p_EnumeratedType_ref;
			p_token_2.parent = p_EnumeratedType_ref;
			Raise_EnumeratedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EnumeratedType.production_kind.g_EnumeratedType_1, p_EnumeratedType_ref);
			return p_EnumeratedType_ref;
		}
		#endregion
	};
}
