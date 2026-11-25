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
	// class associated with syntax rule AC-NotificationVariation
	//

	[DataContract]
	public class	AC_NotificationVariation : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-NotificationVariation
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-NotificationVariation
		{
			g_AC_NotificationVariation_1 = 1,	// VARIATION Value AC-AccessPart DESCRIPTION cstring

		};
		#endregion
		#region production markers associated with the syntax rule AC-NotificationVariation

		// markers associated with production: AC-NotificationVariation -> VARIATION Value AC-AccessPart DESCRIPTION cstring

		public enum production_marker_1 : ushort
		{
			m_Value,
			m_AC_AccessPart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-NotificationVariation

		// Constructor declaration(s) associated with production(s) of syntax rule AC-NotificationVariation

		//
		// Constructor associated with the following production(s)
		// AC-NotificationVariation -> VARIATION Value AC-AccessPart DESCRIPTION cstring

		//

		public AC_NotificationVariation (SyntaxTreeToken p_token, Value p_Value, AC_AccessPart p_AC_AccessPart, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._AC_NotificationVariation_ID, (uint) production_kind.g_AC_NotificationVariation_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_VARIATION = p_token;
			children[1] = m_Value = p_Value;
			children[2] = m_AC_AccessPart = p_AC_AccessPart;
			children[3] = m_DESCRIPTION = p_token_1;
			children[4] = m_cstring = p_token_2;
		}

		public AC_NotificationVariation () { }

		// Copy constructor

		public AC_NotificationVariation (AC_NotificationVariation p_AC_NotificationVariation) : base (p_AC_NotificationVariation.id, p_AC_NotificationVariation.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_NotificationVariation.appInfo;
			switch ((production_kind) p_AC_NotificationVariation.kind)
			{
				case production_kind.g_AC_NotificationVariation_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_VARIATION = (p_AC_NotificationVariation.m_VARIATION != null) ? new SyntaxTreeToken (p_AC_NotificationVariation.m_VARIATION) : null) != null) m_VARIATION.parent = this;
					if ((children [1] = m_Value = (p_AC_NotificationVariation.m_Value != null) ? new Value (p_AC_NotificationVariation.m_Value) : null) != null) m_Value.parent = this;
					if ((children [2] = m_AC_AccessPart = (p_AC_NotificationVariation.m_AC_AccessPart != null) ? new AC_AccessPart (p_AC_NotificationVariation.m_AC_AccessPart) : null) != null) m_AC_AccessPart.parent = this;
					if ((children [3] = m_DESCRIPTION = (p_AC_NotificationVariation.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_AC_NotificationVariation.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [4] = m_cstring = (p_AC_NotificationVariation.m_cstring != null) ? new SyntaxTreeToken (p_AC_NotificationVariation.m_cstring) : null) != null) m_cstring.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_NotificationVariation" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_NotificationVariation (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_VARIATION?.Dispose ();
			m_Value?.Dispose ();
			m_AC_AccessPart?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_cstring?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-NotificationVariation

		// Content changing function(s) associated with production(s) of syntax rule AC-NotificationVariation

		//
		// Content changing function associated with following production(s)
		// AC-NotificationVariation -> VARIATION Value AC-AccessPart DESCRIPTION cstring

		//

		public void change(SyntaxTreeToken p_token, Value p_Value, AC_AccessPart p_AC_AccessPart, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_NotificationVariation_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_VARIATION = p_token;
			children [1] = m_Value = p_Value;
			children [2] = m_AC_AccessPart = p_AC_AccessPart;
			children [3] = m_DESCRIPTION = p_token_1;
			children [4] = m_cstring = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-NotificationVariation
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_VARIATION != null) && m_VARIATION.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_AC_AccessPart != null) && m_AC_AccessPart.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-NotificationVariation

		//
		// emit production tree node associated with any production of syntax rule AC-NotificationVariation
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_NotificationVariation_1:
					// emit syntax tree node associated with production
					// AC-NotificationVariation: VARIATION Value AC-AccessPart DESCRIPTION cstring

					s += m_VARIATION.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
					s += " ";
					s += m_AC_AccessPart.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-NotificationVariation
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_NotificationVariation (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_NotificationVariation_1:
					// emit syntax tree node associated with production
					// AC-NotificationVariation: VARIATION Value AC-AccessPart DESCRIPTION cstring

					s += "VARIATION";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_AC_AccessPart.EmitProductionTree (depth - 1);
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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-NotificationVariation

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-NotificationVariation with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_NotificationVariation.production_kind kind = (AC_NotificationVariation.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_NotificationVariation.production_kind.g_AC_NotificationVariation_1:
					// traverse syntax tree node associated with production
					// AC-NotificationVariation: VARIATION Value AC-AccessPart DESCRIPTION cstring

						m_VARIATION.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
						m_AC_AccessPart.Visit (visitor, appData);
						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_VARIATION?.reparent (this);
			m_Value?.reparent (this);
			m_AC_AccessPart?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_cstring?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-NotificationVariation
		//

		public void _init ()
		{
			m_VARIATION = null;
			m_Value = null;
			m_AC_AccessPart = null;
			m_DESCRIPTION = null;
			m_cstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-NotificationVariation

		// counter of all nodes associated with syntax rule AC-NotificationVariation
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-NotificationVariation
		[DataMember (Name = "m_VARIATION")] public SyntaxTreeToken m_VARIATION { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_AC_AccessPart")] public AC_AccessPart m_AC_AccessPart { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-NotificationVariation

		// delegate function (callback) prototype associated with syntax rule AC-NotificationVariation
		public delegate bool AC_NotificationVariation_Callback (SyntaxTreeCallbackReason reason, AC_NotificationVariation.production_kind kind, AC_NotificationVariation p_AC_NotificationVariation);

		// event associated with syntax rule AC-NotificationVariation
		public event AC_NotificationVariation_Callback AC_NotificationVariation_Event;

		// event trigger associated with syntax rule AC-NotificationVariation
		public bool Raise_AC_NotificationVariation_Event (SyntaxTreeCallbackReason reason, AC_NotificationVariation.production_kind kind, AC_NotificationVariation p_AC_NotificationVariation)
		{
			bool? status = AC_NotificationVariation_Event?.Invoke (reason, kind, p_AC_NotificationVariation);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-NotificationVariation
		//
		// traverse syntax tree node associated with any production of syntax rule AC-NotificationVariation
		//

		public void Traverse (AC_NotificationVariation p_AC_NotificationVariation)
		{
			if (p_AC_NotificationVariation.isLocked())
				return;
			p_AC_NotificationVariation.dolock();
			AC_NotificationVariation.production_kind kind = (AC_NotificationVariation.production_kind) p_AC_NotificationVariation.kind;
			p_AC_NotificationVariation.turn_reset ();
			if (Raise_AC_NotificationVariation_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_NotificationVariation))
			switch (kind)
			{
				case AC_NotificationVariation.production_kind.g_AC_NotificationVariation_1:
					// traverse syntax tree node associated with production
					// AC-NotificationVariation: VARIATION Value AC-AccessPart DESCRIPTION cstring

					if (Raise_AC_NotificationVariation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_NotificationVariation))
						Traverse (p_AC_NotificationVariation.m_Value);
					p_AC_NotificationVariation.turn_inc ();
					if (Raise_AC_NotificationVariation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_NotificationVariation))
						Traverse (p_AC_NotificationVariation.m_AC_AccessPart);
					p_AC_NotificationVariation.turn_inc ();
					Raise_AC_NotificationVariation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_NotificationVariation);
				break;
			}
			Raise_AC_NotificationVariation_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_NotificationVariation);
			p_AC_NotificationVariation.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-NotificationVariation
		//

		public void TraverseCommon (AC_NotificationVariation p_AC_NotificationVariation)
		{
			AC_NotificationVariation.production_kind kind = (AC_NotificationVariation.production_kind) p_AC_NotificationVariation.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_NotificationVariation))
			switch (kind)
			{
				case AC_NotificationVariation.production_kind.g_AC_NotificationVariation_1:
					// traverse syntax tree node associated with production
					// AC-NotificationVariation: VARIATION Value AC-AccessPart DESCRIPTION cstring

						TraverseCommon (p_AC_NotificationVariation.m_VARIATION);
						TraverseCommon (p_AC_NotificationVariation.m_Value);
						TraverseCommon (p_AC_NotificationVariation.m_AC_AccessPart);
						TraverseCommon (p_AC_NotificationVariation.m_DESCRIPTION);
						TraverseCommon (p_AC_NotificationVariation.m_cstring);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_NotificationVariation);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-NotificationVariation

		//
		// create syntax tree node associated with production
		// AC-NotificationVariation: VARIATION Value AC-AccessPart DESCRIPTION cstring

		//

		public AC_NotificationVariation AC_NotificationVariation_1 (SyntaxTreeToken p_token, Value p_Value, AC_AccessPart p_AC_AccessPart, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			AC_NotificationVariation p_AC_NotificationVariation_ref = new AC_NotificationVariation(p_token, p_Value, p_AC_AccessPart, p_token_1, p_token_2);
			p_token.parent = p_AC_NotificationVariation_ref;
			p_Value.parent = p_AC_NotificationVariation_ref;
			p_AC_AccessPart.parent = p_AC_NotificationVariation_ref;
			p_token_1.parent = p_AC_NotificationVariation_ref;
			p_token_2.parent = p_AC_NotificationVariation_ref;
			Raise_AC_NotificationVariation_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_NotificationVariation.production_kind.g_AC_NotificationVariation_1, p_AC_NotificationVariation_ref);
			return p_AC_NotificationVariation_ref;
		}
		#endregion
	};
}
