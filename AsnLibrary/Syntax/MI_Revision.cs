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
	// class associated with syntax rule MI-Revision
	//

	[DataContract]
	public class	MI_Revision : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MI-Revision
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MI-Revision
		{
			g_MI_Revision_1 = 1,	// REVISION cstring DESCRIPTION cstring

		};
		#endregion
		#region production markers associated with the syntax rule MI-Revision

		// markers associated with production: MI-Revision -> REVISION cstring DESCRIPTION cstring

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MI-Revision

		// Constructor declaration(s) associated with production(s) of syntax rule MI-Revision

		//
		// Constructor associated with the following production(s)
		// MI-Revision -> REVISION cstring DESCRIPTION cstring

		//

		public MI_Revision (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._MI_Revision_ID, (uint) production_kind.g_MI_Revision_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_REVISION = p_token;
			children[1] = m_cstring = p_token_1;
			children[2] = m_DESCRIPTION = p_token_2;
			children[3] = m_cstring_1 = p_token_3;
		}

		public MI_Revision () { }

		// Copy constructor

		public MI_Revision (MI_Revision p_MI_Revision) : base (p_MI_Revision.id, p_MI_Revision.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MI_Revision.appInfo;
			switch ((production_kind) p_MI_Revision.kind)
			{
				case production_kind.g_MI_Revision_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_REVISION = (p_MI_Revision.m_REVISION != null) ? new SyntaxTreeToken (p_MI_Revision.m_REVISION) : null) != null) m_REVISION.parent = this;
					if ((children [1] = m_cstring = (p_MI_Revision.m_cstring != null) ? new SyntaxTreeToken (p_MI_Revision.m_cstring) : null) != null) m_cstring.parent = this;
					if ((children [2] = m_DESCRIPTION = (p_MI_Revision.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_MI_Revision.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [3] = m_cstring_1 = (p_MI_Revision.m_cstring_1 != null) ? new SyntaxTreeToken (p_MI_Revision.m_cstring_1) : null) != null) m_cstring_1.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MI_Revision" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MI_Revision (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_REVISION?.Dispose ();
			m_cstring?.Dispose ();
			m_cstring_1?.Dispose ();
			m_DESCRIPTION?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MI-Revision

		// Content changing function(s) associated with production(s) of syntax rule MI-Revision

		//
		// Content changing function associated with following production(s)
		// MI-Revision -> REVISION cstring DESCRIPTION cstring

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_MI_Revision_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_REVISION = p_token;
			children [1] = m_cstring = p_token_1;
			children [2] = m_DESCRIPTION = p_token_2;
			children [3] = m_cstring_1 = p_token_3;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MI-Revision
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_REVISION != null) && m_REVISION.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				(m_cstring_1 != null) && m_cstring_1.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MI-Revision

		//
		// emit production tree node associated with any production of syntax rule MI-Revision
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MI_Revision_1:
					// emit syntax tree node associated with production
					// MI-Revision: REVISION cstring DESCRIPTION cstring

					s += m_REVISION.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring_1.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MI-Revision
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MI_Revision (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MI_Revision_1:
					// emit syntax tree node associated with production
					// MI-Revision: REVISION cstring DESCRIPTION cstring

					s += "REVISION";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += "DESCRIPTION";
					s += ' ';
					s += "cstring";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MI-Revision

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MI-Revision with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MI_Revision.production_kind kind = (MI_Revision.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MI_Revision.production_kind.g_MI_Revision_1:
					// traverse syntax tree node associated with production
					// MI-Revision: REVISION cstring DESCRIPTION cstring

						m_REVISION.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring_1.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_REVISION?.reparent (this);
			m_cstring?.reparent (this);
			m_cstring_1?.reparent (this);

			m_DESCRIPTION?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MI-Revision
		//

		public void _init ()
		{
			m_REVISION = null;
			m_cstring = null;
			m_cstring_1 = null;
			m_DESCRIPTION = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MI-Revision

		// counter of all nodes associated with syntax rule MI-Revision
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MI-Revision
		[DataMember (Name = "m_REVISION")] public SyntaxTreeToken m_REVISION { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		[DataMember (Name = "m_cstring_1")] public SyntaxTreeToken m_cstring_1 { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MI-Revision

		// delegate function (callback) prototype associated with syntax rule MI-Revision
		public delegate bool MI_Revision_Callback (SyntaxTreeCallbackReason reason, MI_Revision.production_kind kind, MI_Revision p_MI_Revision);

		// event associated with syntax rule MI-Revision
		public event MI_Revision_Callback MI_Revision_Event;

		// event trigger associated with syntax rule MI-Revision
		public bool Raise_MI_Revision_Event (SyntaxTreeCallbackReason reason, MI_Revision.production_kind kind, MI_Revision p_MI_Revision)
		{
			bool? status = MI_Revision_Event?.Invoke (reason, kind, p_MI_Revision);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MI-Revision
		//
		// traverse syntax tree node associated with any production of syntax rule MI-Revision
		//

		public void Traverse (MI_Revision p_MI_Revision)
		{
			if (p_MI_Revision.isLocked())
				return;
			p_MI_Revision.dolock();
			MI_Revision.production_kind kind = (MI_Revision.production_kind) p_MI_Revision.kind;
			p_MI_Revision.turn_reset ();
			if (Raise_MI_Revision_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MI_Revision))
			switch (kind)
			{
				case MI_Revision.production_kind.g_MI_Revision_1:
					// traverse syntax tree node associated with production
					// MI-Revision: REVISION cstring DESCRIPTION cstring

				break;
			}
			Raise_MI_Revision_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MI_Revision);
			p_MI_Revision.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MI-Revision
		//

		public void TraverseCommon (MI_Revision p_MI_Revision)
		{
			MI_Revision.production_kind kind = (MI_Revision.production_kind) p_MI_Revision.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MI_Revision))
			switch (kind)
			{
				case MI_Revision.production_kind.g_MI_Revision_1:
					// traverse syntax tree node associated with production
					// MI-Revision: REVISION cstring DESCRIPTION cstring

						TraverseCommon (p_MI_Revision.m_REVISION);
						TraverseCommon (p_MI_Revision.m_cstring);
						TraverseCommon (p_MI_Revision.m_DESCRIPTION);
						TraverseCommon (p_MI_Revision.m_cstring_1);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MI_Revision);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MI-Revision

		//
		// create syntax tree node associated with production
		// MI-Revision: REVISION cstring DESCRIPTION cstring

		//

		public MI_Revision MI_Revision_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			MI_Revision p_MI_Revision_ref = new MI_Revision(p_token, p_token_1, p_token_2, p_token_3);
			p_token.parent = p_MI_Revision_ref;
			p_token_1.parent = p_MI_Revision_ref;
			p_token_2.parent = p_MI_Revision_ref;
			p_token_3.parent = p_MI_Revision_ref;
			Raise_MI_Revision_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MI_Revision.production_kind.g_MI_Revision_1, p_MI_Revision_ref);
			return p_MI_Revision_ref;
		}
		#endregion
	};
}
