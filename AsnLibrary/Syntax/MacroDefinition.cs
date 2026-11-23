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
	// class associated with syntax rule MacroDefinition
	//

	[DataContract]
	public class	MacroDefinition : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MacroDefinition
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MacroDefinition
		{
			g_MacroDefinition_1 = 1,	// MacroIdentifier MACRO "::=" BEGIN END

		};
		#endregion
		#region production markers associated with the syntax rule MacroDefinition

		// markers associated with production: MacroDefinition -> MacroIdentifier MACRO "::=" BEGIN END

		public enum production_marker_1 : ushort
		{
			m_MacroIdentifier,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MacroDefinition

		// Constructor declaration(s) associated with production(s) of syntax rule MacroDefinition

		//
		// Constructor associated with the following production(s)
		// MacroDefinition -> MacroIdentifier MACRO "::=" BEGIN END

		//

		public MacroDefinition (MacroIdentifier p_MacroIdentifier, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._MacroDefinition_ID, (uint) production_kind.g_MacroDefinition_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_MacroIdentifier = p_MacroIdentifier;
			children[1] = m_MACRO = p_token;
			children[2] = m_assignment_sign = p_token_1;
			children[3] = m_BEGIN = p_token_2;
			children[4] = m_END = p_token_3;
		}

		public MacroDefinition () { }

		// Copy constructor

		public MacroDefinition (MacroDefinition p_MacroDefinition) : base (p_MacroDefinition.id, p_MacroDefinition.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MacroDefinition.appInfo;
			switch ((production_kind) p_MacroDefinition.kind)
			{
				case production_kind.g_MacroDefinition_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_MacroIdentifier = (p_MacroDefinition.m_MacroIdentifier != null) ? new MacroIdentifier (p_MacroDefinition.m_MacroIdentifier) : null) != null) m_MacroIdentifier.parent = this;
					if ((children [1] = m_MACRO = (p_MacroDefinition.m_MACRO != null) ? new SyntaxTreeToken (p_MacroDefinition.m_MACRO) : null) != null) m_MACRO.parent = this;
					if ((children [2] = m_assignment_sign = (p_MacroDefinition.m_assignment_sign != null) ? new SyntaxTreeToken (p_MacroDefinition.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [3] = m_BEGIN = (p_MacroDefinition.m_BEGIN != null) ? new SyntaxTreeToken (p_MacroDefinition.m_BEGIN) : null) != null) m_BEGIN.parent = this;
					if ((children [4] = m_END = (p_MacroDefinition.m_END != null) ? new SyntaxTreeToken (p_MacroDefinition.m_END) : null) != null) m_END.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MacroDefinition" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MacroDefinition (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_MacroIdentifier?.Dispose ();
			m_MACRO?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_BEGIN?.Dispose ();
			m_END?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MacroDefinition

		// Content changing function(s) associated with production(s) of syntax rule MacroDefinition

		//
		// Content changing function associated with following production(s)
		// MacroDefinition -> MacroIdentifier MACRO "::=" BEGIN END

		//

		public void change(MacroIdentifier p_MacroIdentifier, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroDefinition_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_MacroIdentifier = p_MacroIdentifier;
			children [1] = m_MACRO = p_token;
			children [2] = m_assignment_sign = p_token_1;
			children [3] = m_BEGIN = p_token_2;
			children [4] = m_END = p_token_3;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MacroDefinition
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_MacroIdentifier != null) && m_MacroIdentifier.checkInclusion (element) ||
				(m_MACRO != null) && m_MACRO.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_BEGIN != null) && m_BEGIN.checkInclusion (element) ||
				(m_END != null) && m_END.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MacroDefinition

		//
		// emit production tree node associated with any production of syntax rule MacroDefinition
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MacroDefinition_1:
					// emit syntax tree node associated with production
					// MacroDefinition: MacroIdentifier MACRO "::=" BEGIN END

					s += m_MacroIdentifier.Emit (depth - 1);
					s += " ";
					s += m_MACRO.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_BEGIN.Emit (depth - 1);
					s += " ";
					s += m_END.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MacroDefinition
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MacroDefinition (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MacroDefinition_1:
					// emit syntax tree node associated with production
					// MacroDefinition: MacroIdentifier MACRO "::=" BEGIN END

					s += m_MacroIdentifier.EmitProductionTree (depth - 1);
					s += ' ';
					s += "MACRO";
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += "BEGIN";
					s += ' ';
					s += "END";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MacroDefinition

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MacroDefinition with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MacroDefinition.production_kind kind = (MacroDefinition.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MacroDefinition.production_kind.g_MacroDefinition_1:
					// traverse syntax tree node associated with production
					// MacroDefinition: MacroIdentifier MACRO "::=" BEGIN END

						m_MacroIdentifier.Visit (visitor, appData);
						m_MACRO.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_BEGIN.Visit (visitor, appData);
						m_END.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_MacroIdentifier?.reparent (this);
			m_MACRO?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_BEGIN?.reparent (this);
			m_END?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MacroDefinition
		//

		public void _init ()
		{
			m_MacroIdentifier = null;
			m_MACRO = null;
			m_assignment_sign = null;
			m_BEGIN = null;
			m_END = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MacroDefinition

		// counter of all nodes associated with syntax rule MacroDefinition
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MacroDefinition
		[DataMember (Name = "m_MacroIdentifier")] public MacroIdentifier m_MacroIdentifier { get; private set; }
		[DataMember (Name = "m_MACRO")] public SyntaxTreeToken m_MACRO { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_BEGIN")] public SyntaxTreeToken m_BEGIN { get; private set; }
		[DataMember (Name = "m_END")] public SyntaxTreeToken m_END { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MacroDefinition

		// delegate function (callback) prototype associated with syntax rule MacroDefinition
		public delegate bool MacroDefinition_Callback (SyntaxTreeCallbackReason reason, MacroDefinition.production_kind kind, MacroDefinition p_MacroDefinition);

		// event associated with syntax rule MacroDefinition
		public event MacroDefinition_Callback MacroDefinition_Event;

		// event trigger associated with syntax rule MacroDefinition
		public bool Raise_MacroDefinition_Event (SyntaxTreeCallbackReason reason, MacroDefinition.production_kind kind, MacroDefinition p_MacroDefinition)
		{
			bool? status = MacroDefinition_Event?.Invoke (reason, kind, p_MacroDefinition);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MacroDefinition
		//
		// traverse syntax tree node associated with any production of syntax rule MacroDefinition
		//

		public void Traverse (MacroDefinition p_MacroDefinition)
		{
			if (p_MacroDefinition.isLocked())
				return;
			p_MacroDefinition.dolock();
			MacroDefinition.production_kind kind = (MacroDefinition.production_kind) p_MacroDefinition.kind;
			p_MacroDefinition.turn_reset ();
			if (Raise_MacroDefinition_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MacroDefinition))
			switch (kind)
			{
				case MacroDefinition.production_kind.g_MacroDefinition_1:
					// traverse syntax tree node associated with production
					// MacroDefinition: MacroIdentifier MACRO "::=" BEGIN END

					if (Raise_MacroDefinition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroDefinition))
						Traverse (p_MacroDefinition.m_MacroIdentifier);
					p_MacroDefinition.turn_inc ();
					Raise_MacroDefinition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroDefinition);
				break;
			}
			Raise_MacroDefinition_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MacroDefinition);
			p_MacroDefinition.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MacroDefinition
		//

		public void TraverseCommon (MacroDefinition p_MacroDefinition)
		{
			MacroDefinition.production_kind kind = (MacroDefinition.production_kind) p_MacroDefinition.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MacroDefinition))
			switch (kind)
			{
				case MacroDefinition.production_kind.g_MacroDefinition_1:
					// traverse syntax tree node associated with production
					// MacroDefinition: MacroIdentifier MACRO "::=" BEGIN END

						TraverseCommon (p_MacroDefinition.m_MacroIdentifier);
						TraverseCommon (p_MacroDefinition.m_MACRO);
						TraverseCommon (p_MacroDefinition.m_assignment_sign);
						TraverseCommon (p_MacroDefinition.m_BEGIN);
						TraverseCommon (p_MacroDefinition.m_END);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MacroDefinition);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MacroDefinition

		//
		// create syntax tree node associated with production
		// MacroDefinition: MacroIdentifier MACRO "::=" BEGIN END

		//

		public MacroDefinition MacroDefinition_1 (MacroIdentifier p_MacroIdentifier, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			MacroDefinition p_MacroDefinition_ref = new MacroDefinition(p_MacroIdentifier, p_token, p_token_1, p_token_2, p_token_3);
			p_MacroIdentifier.parent = p_MacroDefinition_ref;
			p_token.parent = p_MacroDefinition_ref;
			p_token_1.parent = p_MacroDefinition_ref;
			p_token_2.parent = p_MacroDefinition_ref;
			p_token_3.parent = p_MacroDefinition_ref;
			Raise_MacroDefinition_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroDefinition.production_kind.g_MacroDefinition_1, p_MacroDefinition_ref);
			return p_MacroDefinition_ref;
		}
		#endregion
	};
}
