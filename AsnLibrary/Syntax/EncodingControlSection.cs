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
	// class associated with syntax rule EncodingControlSection
	//

	[DataContract]
	public class	EncodingControlSection : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EncodingControlSection
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EncodingControlSection
		{
			g_EncodingControlSection_1 = 1,	// ENCODING-CONTROL encodingreference-token EncodingInstructionAssignmentList

		};
		#endregion
		#region production markers associated with the syntax rule EncodingControlSection

		// markers associated with production: EncodingControlSection -> ENCODING-CONTROL encodingreference-token EncodingInstructionAssignmentList

		public enum production_marker_1 : ushort
		{
			m_encodingreference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EncodingControlSection

		// Constructor declaration(s) associated with production(s) of syntax rule EncodingControlSection

		//
		// Constructor associated with the following production(s)
		// EncodingControlSection -> ENCODING-CONTROL encodingreference-token EncodingInstructionAssignmentList

		//

		public EncodingControlSection (SyntaxTreeToken p_token, encodingreference_token p_encodingreference_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._EncodingControlSection_ID, (uint) production_kind.g_EncodingControlSection_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ENCODING_CONTROL = p_token;
			children[1] = m_encodingreference_token = p_encodingreference_token;
			children[2] = m_EncodingInstructionAssignmentList = p_token_1;
		}

		public EncodingControlSection () { }

		// Copy constructor

		public EncodingControlSection (EncodingControlSection p_EncodingControlSection) : base (p_EncodingControlSection.id, p_EncodingControlSection.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EncodingControlSection.appInfo;
			switch ((production_kind) p_EncodingControlSection.kind)
			{
				case production_kind.g_EncodingControlSection_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ENCODING_CONTROL = (p_EncodingControlSection.m_ENCODING_CONTROL != null) ? new SyntaxTreeToken (p_EncodingControlSection.m_ENCODING_CONTROL) : null) != null) m_ENCODING_CONTROL.parent = this;
					if ((children [1] = m_encodingreference_token = (p_EncodingControlSection.m_encodingreference_token != null) ? new encodingreference_token (p_EncodingControlSection.m_encodingreference_token) : null) != null) m_encodingreference_token.parent = this;
					if ((children [2] = m_EncodingInstructionAssignmentList = (p_EncodingControlSection.m_EncodingInstructionAssignmentList != null) ? new SyntaxTreeToken (p_EncodingControlSection.m_EncodingInstructionAssignmentList) : null) != null) m_EncodingInstructionAssignmentList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EncodingControlSection" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EncodingControlSection (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ENCODING_CONTROL?.Dispose ();
			m_encodingreference_token?.Dispose ();
			m_EncodingInstructionAssignmentList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EncodingControlSection

		// Content changing function(s) associated with production(s) of syntax rule EncodingControlSection

		//
		// Content changing function associated with following production(s)
		// EncodingControlSection -> ENCODING-CONTROL encodingreference-token EncodingInstructionAssignmentList

		//

		public void change(SyntaxTreeToken p_token, encodingreference_token p_encodingreference_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_EncodingControlSection_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ENCODING_CONTROL = p_token;
			children [1] = m_encodingreference_token = p_encodingreference_token;
			children [2] = m_EncodingInstructionAssignmentList = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EncodingControlSection
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ENCODING_CONTROL != null) && m_ENCODING_CONTROL.checkInclusion (element) ||
				(m_encodingreference_token != null) && m_encodingreference_token.checkInclusion (element) ||
				(m_EncodingInstructionAssignmentList != null) && m_EncodingInstructionAssignmentList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EncodingControlSection

		//
		// emit production tree node associated with any production of syntax rule EncodingControlSection
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EncodingControlSection_1:
					// emit syntax tree node associated with production
					// EncodingControlSection: ENCODING-CONTROL encodingreference-token EncodingInstructionAssignmentList

					s += m_ENCODING_CONTROL.Emit (depth - 1);
					s += " ";
					s += m_encodingreference_token.Emit (depth - 1);
					s += " ";
					s += m_EncodingInstructionAssignmentList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EncodingControlSection
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EncodingControlSection (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EncodingControlSection_1:
					// emit syntax tree node associated with production
					// EncodingControlSection: ENCODING-CONTROL encodingreference-token EncodingInstructionAssignmentList

					s += "ENCODING_CONTROL";
					s += ' ';
					s += m_encodingreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "EncodingInstructionAssignmentList";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EncodingControlSection

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EncodingControlSection with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EncodingControlSection.production_kind kind = (EncodingControlSection.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EncodingControlSection.production_kind.g_EncodingControlSection_1:
					// traverse syntax tree node associated with production
					// EncodingControlSection: ENCODING-CONTROL encodingreference-token EncodingInstructionAssignmentList

						m_ENCODING_CONTROL.Visit (visitor, appData);
						m_encodingreference_token.Visit (visitor, appData);
						m_EncodingInstructionAssignmentList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ENCODING_CONTROL?.reparent (this);
			m_encodingreference_token?.reparent (this);
			m_EncodingInstructionAssignmentList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule EncodingControlSection
		//

		public void _init ()
		{
			m_ENCODING_CONTROL = null;
			m_encodingreference_token = null;
			m_EncodingInstructionAssignmentList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EncodingControlSection

		// counter of all nodes associated with syntax rule EncodingControlSection
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EncodingControlSection
		[DataMember (Name = "m_ENCODING_CONTROL")] public SyntaxTreeToken m_ENCODING_CONTROL { get; private set; }
		[DataMember (Name = "m_encodingreference_token")] public encodingreference_token m_encodingreference_token { get; private set; }
		[DataMember (Name = "m_EncodingInstructionAssignmentList")] public SyntaxTreeToken m_EncodingInstructionAssignmentList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EncodingControlSection

		// delegate function (callback) prototype associated with syntax rule EncodingControlSection
		public delegate bool EncodingControlSection_Callback (SyntaxTreeCallbackReason reason, EncodingControlSection.production_kind kind, EncodingControlSection p_EncodingControlSection);

		// event associated with syntax rule EncodingControlSection
		public event EncodingControlSection_Callback EncodingControlSection_Event;

		// event trigger associated with syntax rule EncodingControlSection
		public bool Raise_EncodingControlSection_Event (SyntaxTreeCallbackReason reason, EncodingControlSection.production_kind kind, EncodingControlSection p_EncodingControlSection)
		{
			bool? status = EncodingControlSection_Event?.Invoke (reason, kind, p_EncodingControlSection);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EncodingControlSection
		//
		// traverse syntax tree node associated with any production of syntax rule EncodingControlSection
		//

		public void Traverse (EncodingControlSection p_EncodingControlSection)
		{
			if (p_EncodingControlSection.isLocked())
				return;
			p_EncodingControlSection.dolock();
			EncodingControlSection.production_kind kind = (EncodingControlSection.production_kind) p_EncodingControlSection.kind;
			p_EncodingControlSection.turn_reset ();
			if (Raise_EncodingControlSection_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EncodingControlSection))
			switch (kind)
			{
				case EncodingControlSection.production_kind.g_EncodingControlSection_1:
					// traverse syntax tree node associated with production
					// EncodingControlSection: ENCODING-CONTROL encodingreference-token EncodingInstructionAssignmentList

					if (Raise_EncodingControlSection_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EncodingControlSection))
						Traverse (p_EncodingControlSection.m_encodingreference_token);
					p_EncodingControlSection.turn_inc ();
					Raise_EncodingControlSection_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EncodingControlSection);
				break;
			}
			Raise_EncodingControlSection_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EncodingControlSection);
			p_EncodingControlSection.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EncodingControlSection
		//

		public void TraverseCommon (EncodingControlSection p_EncodingControlSection)
		{
			EncodingControlSection.production_kind kind = (EncodingControlSection.production_kind) p_EncodingControlSection.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EncodingControlSection))
			switch (kind)
			{
				case EncodingControlSection.production_kind.g_EncodingControlSection_1:
					// traverse syntax tree node associated with production
					// EncodingControlSection: ENCODING-CONTROL encodingreference-token EncodingInstructionAssignmentList

						TraverseCommon (p_EncodingControlSection.m_ENCODING_CONTROL);
						TraverseCommon (p_EncodingControlSection.m_encodingreference_token);
						TraverseCommon (p_EncodingControlSection.m_EncodingInstructionAssignmentList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EncodingControlSection);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EncodingControlSection

		//
		// create syntax tree node associated with production
		// EncodingControlSection: ENCODING-CONTROL encodingreference-token EncodingInstructionAssignmentList

		//

		public EncodingControlSection EncodingControlSection_1 (SyntaxTreeToken p_token, encodingreference_token p_encodingreference_token, SyntaxTreeToken p_token_1)
		{
			EncodingControlSection p_EncodingControlSection_ref = new EncodingControlSection(p_token, p_encodingreference_token, p_token_1);
			p_token.parent = p_EncodingControlSection_ref;
			p_encodingreference_token.parent = p_EncodingControlSection_ref;
			p_token_1.parent = p_EncodingControlSection_ref;
			Raise_EncodingControlSection_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EncodingControlSection.production_kind.g_EncodingControlSection_1, p_EncodingControlSection_ref);
			return p_EncodingControlSection_ref;
		}
		#endregion
	};
}
