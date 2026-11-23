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
	// class associated with syntax rule AC-ObjectVariation
	//

	[DataContract]
	public class	AC_ObjectVariation : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-ObjectVariation
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-ObjectVariation
		{
			g_AC_ObjectVariation_1 = 1,	// VARIATION Value AC-SyntaxPart AC-WriteSyntaxPart AC-AccessPart AC-CreationPart AC-DefValPart DESCRIPTION cstring

		};
		#endregion
		#region production markers associated with the syntax rule AC-ObjectVariation

		// markers associated with production: AC-ObjectVariation -> VARIATION Value AC-SyntaxPart AC-WriteSyntaxPart AC-AccessPart AC-CreationPart AC-DefValPart DESCRIPTION cstring

		public enum production_marker_1 : ushort
		{
			m_Value,
			m_AC_SyntaxPart,
			m_AC_WriteSyntaxPart,
			m_AC_AccessPart,
			m_AC_CreationPart,
			m_AC_DefValPart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-ObjectVariation

		// Constructor declaration(s) associated with production(s) of syntax rule AC-ObjectVariation

		//
		// Constructor associated with the following production(s)
		// AC-ObjectVariation -> VARIATION Value AC-SyntaxPart AC-WriteSyntaxPart AC-AccessPart AC-CreationPart AC-DefValPart DESCRIPTION cstring

		//

		public AC_ObjectVariation (SyntaxTreeToken p_token, Value p_Value, AC_SyntaxPart p_AC_SyntaxPart, AC_WriteSyntaxPart p_AC_WriteSyntaxPart, AC_AccessPart p_AC_AccessPart, AC_CreationPart p_AC_CreationPart, AC_DefValPart p_AC_DefValPart, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._AC_ObjectVariation_ID, (uint) production_kind.g_AC_ObjectVariation_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 9);
			children[0] = m_VARIATION = p_token;
			children[1] = m_Value = p_Value;
			children[2] = m_AC_SyntaxPart = p_AC_SyntaxPart;
			children[3] = m_AC_WriteSyntaxPart = p_AC_WriteSyntaxPart;
			children[4] = m_AC_AccessPart = p_AC_AccessPart;
			children[5] = m_AC_CreationPart = p_AC_CreationPart;
			children[6] = m_AC_DefValPart = p_AC_DefValPart;
			children[7] = m_DESCRIPTION = p_token_1;
			children[8] = m_cstring = p_token_2;
		}

		public AC_ObjectVariation () { }

		// Copy constructor

		public AC_ObjectVariation (AC_ObjectVariation p_AC_ObjectVariation) : base (p_AC_ObjectVariation.id, p_AC_ObjectVariation.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_ObjectVariation.appInfo;
			switch ((production_kind) p_AC_ObjectVariation.kind)
			{
				case production_kind.g_AC_ObjectVariation_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 9);
					if ((children [0] = m_VARIATION = (p_AC_ObjectVariation.m_VARIATION != null) ? new SyntaxTreeToken (p_AC_ObjectVariation.m_VARIATION) : null) != null) m_VARIATION.parent = this;
					if ((children [1] = m_Value = (p_AC_ObjectVariation.m_Value != null) ? new Value (p_AC_ObjectVariation.m_Value) : null) != null) m_Value.parent = this;
					if ((children [2] = m_AC_SyntaxPart = (p_AC_ObjectVariation.m_AC_SyntaxPart != null) ? new AC_SyntaxPart (p_AC_ObjectVariation.m_AC_SyntaxPart) : null) != null) m_AC_SyntaxPart.parent = this;
					if ((children [3] = m_AC_WriteSyntaxPart = (p_AC_ObjectVariation.m_AC_WriteSyntaxPart != null) ? new AC_WriteSyntaxPart (p_AC_ObjectVariation.m_AC_WriteSyntaxPart) : null) != null) m_AC_WriteSyntaxPart.parent = this;
					if ((children [4] = m_AC_AccessPart = (p_AC_ObjectVariation.m_AC_AccessPart != null) ? new AC_AccessPart (p_AC_ObjectVariation.m_AC_AccessPart) : null) != null) m_AC_AccessPart.parent = this;
					if ((children [5] = m_AC_CreationPart = (p_AC_ObjectVariation.m_AC_CreationPart != null) ? new AC_CreationPart (p_AC_ObjectVariation.m_AC_CreationPart) : null) != null) m_AC_CreationPart.parent = this;
					if ((children [6] = m_AC_DefValPart = (p_AC_ObjectVariation.m_AC_DefValPart != null) ? new AC_DefValPart (p_AC_ObjectVariation.m_AC_DefValPart) : null) != null) m_AC_DefValPart.parent = this;
					if ((children [7] = m_DESCRIPTION = (p_AC_ObjectVariation.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_AC_ObjectVariation.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [8] = m_cstring = (p_AC_ObjectVariation.m_cstring != null) ? new SyntaxTreeToken (p_AC_ObjectVariation.m_cstring) : null) != null) m_cstring.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_ObjectVariation" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_ObjectVariation (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_VARIATION?.Dispose ();
			m_Value?.Dispose ();
			m_AC_SyntaxPart?.Dispose ();
			m_AC_WriteSyntaxPart?.Dispose ();
			m_AC_AccessPart?.Dispose ();
			m_AC_CreationPart?.Dispose ();
			m_AC_DefValPart?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_cstring?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-ObjectVariation

		// Content changing function(s) associated with production(s) of syntax rule AC-ObjectVariation

		//
		// Content changing function associated with following production(s)
		// AC-ObjectVariation -> VARIATION Value AC-SyntaxPart AC-WriteSyntaxPart AC-AccessPart AC-CreationPart AC-DefValPart DESCRIPTION cstring

		//

		public void change(SyntaxTreeToken p_token, Value p_Value, AC_SyntaxPart p_AC_SyntaxPart, AC_WriteSyntaxPart p_AC_WriteSyntaxPart, AC_AccessPart p_AC_AccessPart, AC_CreationPart p_AC_CreationPart, AC_DefValPart p_AC_DefValPart, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_ObjectVariation_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 9);
			children [0] = m_VARIATION = p_token;
			children [1] = m_Value = p_Value;
			children [2] = m_AC_SyntaxPart = p_AC_SyntaxPart;
			children [3] = m_AC_WriteSyntaxPart = p_AC_WriteSyntaxPart;
			children [4] = m_AC_AccessPart = p_AC_AccessPart;
			children [5] = m_AC_CreationPart = p_AC_CreationPart;
			children [6] = m_AC_DefValPart = p_AC_DefValPart;
			children [7] = m_DESCRIPTION = p_token_1;
			children [8] = m_cstring = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-ObjectVariation
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_VARIATION != null) && m_VARIATION.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_AC_SyntaxPart != null) && m_AC_SyntaxPart.checkInclusion (element) ||
				(m_AC_WriteSyntaxPart != null) && m_AC_WriteSyntaxPart.checkInclusion (element) ||
				(m_AC_AccessPart != null) && m_AC_AccessPart.checkInclusion (element) ||
				(m_AC_CreationPart != null) && m_AC_CreationPart.checkInclusion (element) ||
				(m_AC_DefValPart != null) && m_AC_DefValPart.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-ObjectVariation

		//
		// emit production tree node associated with any production of syntax rule AC-ObjectVariation
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_ObjectVariation_1:
					// emit syntax tree node associated with production
					// AC-ObjectVariation: VARIATION Value AC-SyntaxPart AC-WriteSyntaxPart AC-AccessPart AC-CreationPart AC-DefValPart DESCRIPTION cstring

					s += m_VARIATION.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
					s += " ";
					s += m_AC_SyntaxPart.Emit (depth - 1);
					s += " ";
					s += m_AC_WriteSyntaxPart.Emit (depth - 1);
					s += " ";
					s += m_AC_AccessPart.Emit (depth - 1);
					s += " ";
					s += m_AC_CreationPart.Emit (depth - 1);
					s += " ";
					s += m_AC_DefValPart.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-ObjectVariation
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_ObjectVariation (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_ObjectVariation_1:
					// emit syntax tree node associated with production
					// AC-ObjectVariation: VARIATION Value AC-SyntaxPart AC-WriteSyntaxPart AC-AccessPart AC-CreationPart AC-DefValPart DESCRIPTION cstring

					s += "VARIATION";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_AC_SyntaxPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_AC_WriteSyntaxPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_AC_AccessPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_AC_CreationPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_AC_DefValPart.EmitProductionTree (depth - 1);
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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-ObjectVariation

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-ObjectVariation with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_ObjectVariation.production_kind kind = (AC_ObjectVariation.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_ObjectVariation.production_kind.g_AC_ObjectVariation_1:
					// traverse syntax tree node associated with production
					// AC-ObjectVariation: VARIATION Value AC-SyntaxPart AC-WriteSyntaxPart AC-AccessPart AC-CreationPart AC-DefValPart DESCRIPTION cstring

						m_VARIATION.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
						m_AC_SyntaxPart.Visit (visitor, appData);
						m_AC_WriteSyntaxPart.Visit (visitor, appData);
						m_AC_AccessPart.Visit (visitor, appData);
						m_AC_CreationPart.Visit (visitor, appData);
						m_AC_DefValPart.Visit (visitor, appData);
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
			m_AC_SyntaxPart?.reparent (this);
			m_AC_WriteSyntaxPart?.reparent (this);
			m_AC_AccessPart?.reparent (this);
			m_AC_CreationPart?.reparent (this);
			m_AC_DefValPart?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_cstring?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-ObjectVariation
		//

		public void _init ()
		{
			m_VARIATION = null;
			m_Value = null;
			m_AC_SyntaxPart = null;
			m_AC_WriteSyntaxPart = null;
			m_AC_AccessPart = null;
			m_AC_CreationPart = null;
			m_AC_DefValPart = null;
			m_DESCRIPTION = null;
			m_cstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-ObjectVariation

		// counter of all nodes associated with syntax rule AC-ObjectVariation
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-ObjectVariation
		[DataMember (Name = "m_VARIATION")] public SyntaxTreeToken m_VARIATION { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_AC_SyntaxPart")] public AC_SyntaxPart m_AC_SyntaxPart { get; private set; }
		[DataMember (Name = "m_AC_WriteSyntaxPart")] public AC_WriteSyntaxPart m_AC_WriteSyntaxPart { get; private set; }
		[DataMember (Name = "m_AC_AccessPart")] public AC_AccessPart m_AC_AccessPart { get; private set; }
		[DataMember (Name = "m_AC_CreationPart")] public AC_CreationPart m_AC_CreationPart { get; private set; }
		[DataMember (Name = "m_AC_DefValPart")] public AC_DefValPart m_AC_DefValPart { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-ObjectVariation

		// delegate function (callback) prototype associated with syntax rule AC-ObjectVariation
		public delegate bool AC_ObjectVariation_Callback (SyntaxTreeCallbackReason reason, AC_ObjectVariation.production_kind kind, AC_ObjectVariation p_AC_ObjectVariation);

		// event associated with syntax rule AC-ObjectVariation
		public event AC_ObjectVariation_Callback AC_ObjectVariation_Event;

		// event trigger associated with syntax rule AC-ObjectVariation
		public bool Raise_AC_ObjectVariation_Event (SyntaxTreeCallbackReason reason, AC_ObjectVariation.production_kind kind, AC_ObjectVariation p_AC_ObjectVariation)
		{
			bool? status = AC_ObjectVariation_Event?.Invoke (reason, kind, p_AC_ObjectVariation);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-ObjectVariation
		//
		// traverse syntax tree node associated with any production of syntax rule AC-ObjectVariation
		//

		public void Traverse (AC_ObjectVariation p_AC_ObjectVariation)
		{
			if (p_AC_ObjectVariation.isLocked())
				return;
			p_AC_ObjectVariation.dolock();
			AC_ObjectVariation.production_kind kind = (AC_ObjectVariation.production_kind) p_AC_ObjectVariation.kind;
			p_AC_ObjectVariation.turn_reset ();
			if (Raise_AC_ObjectVariation_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_ObjectVariation))
			switch (kind)
			{
				case AC_ObjectVariation.production_kind.g_AC_ObjectVariation_1:
					// traverse syntax tree node associated with production
					// AC-ObjectVariation: VARIATION Value AC-SyntaxPart AC-WriteSyntaxPart AC-AccessPart AC-CreationPart AC-DefValPart DESCRIPTION cstring

					if (Raise_AC_ObjectVariation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ObjectVariation))
						Traverse (p_AC_ObjectVariation.m_Value);
					p_AC_ObjectVariation.turn_inc ();
					if (Raise_AC_ObjectVariation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ObjectVariation))
						Traverse (p_AC_ObjectVariation.m_AC_SyntaxPart);
					p_AC_ObjectVariation.turn_inc ();
					if (Raise_AC_ObjectVariation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ObjectVariation))
						Traverse (p_AC_ObjectVariation.m_AC_WriteSyntaxPart);
					p_AC_ObjectVariation.turn_inc ();
					if (Raise_AC_ObjectVariation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ObjectVariation))
						Traverse (p_AC_ObjectVariation.m_AC_AccessPart);
					p_AC_ObjectVariation.turn_inc ();
					if (Raise_AC_ObjectVariation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ObjectVariation))
						Traverse (p_AC_ObjectVariation.m_AC_CreationPart);
					p_AC_ObjectVariation.turn_inc ();
					if (Raise_AC_ObjectVariation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ObjectVariation))
						Traverse (p_AC_ObjectVariation.m_AC_DefValPart);
					p_AC_ObjectVariation.turn_inc ();
					Raise_AC_ObjectVariation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ObjectVariation);
				break;
			}
			Raise_AC_ObjectVariation_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_ObjectVariation);
			p_AC_ObjectVariation.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-ObjectVariation
		//

		public void TraverseCommon (AC_ObjectVariation p_AC_ObjectVariation)
		{
			AC_ObjectVariation.production_kind kind = (AC_ObjectVariation.production_kind) p_AC_ObjectVariation.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_ObjectVariation))
			switch (kind)
			{
				case AC_ObjectVariation.production_kind.g_AC_ObjectVariation_1:
					// traverse syntax tree node associated with production
					// AC-ObjectVariation: VARIATION Value AC-SyntaxPart AC-WriteSyntaxPart AC-AccessPart AC-CreationPart AC-DefValPart DESCRIPTION cstring

						TraverseCommon (p_AC_ObjectVariation.m_VARIATION);
						TraverseCommon (p_AC_ObjectVariation.m_Value);
						TraverseCommon (p_AC_ObjectVariation.m_AC_SyntaxPart);
						TraverseCommon (p_AC_ObjectVariation.m_AC_WriteSyntaxPart);
						TraverseCommon (p_AC_ObjectVariation.m_AC_AccessPart);
						TraverseCommon (p_AC_ObjectVariation.m_AC_CreationPart);
						TraverseCommon (p_AC_ObjectVariation.m_AC_DefValPart);
						TraverseCommon (p_AC_ObjectVariation.m_DESCRIPTION);
						TraverseCommon (p_AC_ObjectVariation.m_cstring);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_ObjectVariation);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-ObjectVariation

		//
		// create syntax tree node associated with production
		// AC-ObjectVariation: VARIATION Value AC-SyntaxPart AC-WriteSyntaxPart AC-AccessPart AC-CreationPart AC-DefValPart DESCRIPTION cstring

		//

		public AC_ObjectVariation AC_ObjectVariation_1 (SyntaxTreeToken p_token, Value p_Value, AC_SyntaxPart p_AC_SyntaxPart, AC_WriteSyntaxPart p_AC_WriteSyntaxPart, AC_AccessPart p_AC_AccessPart, AC_CreationPart p_AC_CreationPart, AC_DefValPart p_AC_DefValPart, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			AC_ObjectVariation p_AC_ObjectVariation_ref = new AC_ObjectVariation(p_token, p_Value, p_AC_SyntaxPart, p_AC_WriteSyntaxPart, p_AC_AccessPart, p_AC_CreationPart, p_AC_DefValPart, p_token_1, p_token_2);
			p_token.parent = p_AC_ObjectVariation_ref;
			p_Value.parent = p_AC_ObjectVariation_ref;
			p_AC_SyntaxPart.parent = p_AC_ObjectVariation_ref;
			p_AC_WriteSyntaxPart.parent = p_AC_ObjectVariation_ref;
			p_AC_AccessPart.parent = p_AC_ObjectVariation_ref;
			p_AC_CreationPart.parent = p_AC_ObjectVariation_ref;
			p_AC_DefValPart.parent = p_AC_ObjectVariation_ref;
			p_token_1.parent = p_AC_ObjectVariation_ref;
			p_token_2.parent = p_AC_ObjectVariation_ref;
			Raise_AC_ObjectVariation_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_ObjectVariation.production_kind.g_AC_ObjectVariation_1, p_AC_ObjectVariation_ref);
			return p_AC_ObjectVariation_ref;
		}
		#endregion
	};
}
