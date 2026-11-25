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
	// class associated with syntax rule AC-Variation
	//

	[DataContract]
	public class	AC_Variation : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-Variation
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-Variation
		{
			g_AC_Variation_1 = 1,	// AC-ObjectVariation

			g_AC_Variation_2 = 2,	// AC-NotificationVariation

		};
		#endregion
		#region production markers associated with the syntax rule AC-Variation

		// markers associated with production: AC-Variation -> AC-ObjectVariation

		public enum production_marker_1 : ushort
		{
			m_AC_ObjectVariation,
			final
		};

		// markers associated with production: AC-Variation -> AC-NotificationVariation

		public enum production_marker_2 : ushort
		{
			m_AC_NotificationVariation,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-Variation

		// Constructor declaration(s) associated with production(s) of syntax rule AC-Variation

		//
		// Constructor associated with the following production(s)
		// AC-Variation -> AC-ObjectVariation

		//

		public AC_Variation (AC_ObjectVariation p_AC_ObjectVariation) : base ((uint) ProductionID._AC_Variation_ID, (uint) production_kind.g_AC_Variation_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AC_ObjectVariation = p_AC_ObjectVariation;
		}

		//
		// Constructor associated with the following production(s)
		// AC-Variation -> AC-NotificationVariation

		//

		public AC_Variation (AC_NotificationVariation p_AC_NotificationVariation) : base ((uint) ProductionID._AC_Variation_ID, (uint) production_kind.g_AC_Variation_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AC_NotificationVariation = p_AC_NotificationVariation;
		}

		public AC_Variation () { }

		// Copy constructor

		public AC_Variation (AC_Variation p_AC_Variation) : base (p_AC_Variation.id, p_AC_Variation.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_Variation.appInfo;
			switch ((production_kind) p_AC_Variation.kind)
			{
				case production_kind.g_AC_Variation_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AC_ObjectVariation = (p_AC_Variation.m_AC_ObjectVariation != null) ? new AC_ObjectVariation (p_AC_Variation.m_AC_ObjectVariation) : null) != null) m_AC_ObjectVariation.parent = this;
					break;
				case production_kind.g_AC_Variation_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AC_NotificationVariation = (p_AC_Variation.m_AC_NotificationVariation != null) ? new AC_NotificationVariation (p_AC_Variation.m_AC_NotificationVariation) : null) != null) m_AC_NotificationVariation.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_Variation" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_Variation (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_AC_ObjectVariation?.Dispose ();
			m_AC_NotificationVariation?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-Variation

		// Content changing function(s) associated with production(s) of syntax rule AC-Variation

		//
		// Content changing function associated with following production(s)
		// AC-Variation -> AC-ObjectVariation

		//

		public void change(AC_ObjectVariation p_AC_ObjectVariation)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Variation_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AC_ObjectVariation = p_AC_ObjectVariation;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-Variation -> AC-NotificationVariation

		//

		public void change(AC_NotificationVariation p_AC_NotificationVariation)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_Variation_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AC_NotificationVariation = p_AC_NotificationVariation;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-Variation
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_AC_ObjectVariation != null) && m_AC_ObjectVariation.checkInclusion (element) ||
				(m_AC_NotificationVariation != null) && m_AC_NotificationVariation.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-Variation

		//
		// emit production tree node associated with any production of syntax rule AC-Variation
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_Variation_1:
					// emit syntax tree node associated with production
					// AC-Variation: AC-ObjectVariation

					s += m_AC_ObjectVariation.Emit (depth - 1);
				break;
				case production_kind.g_AC_Variation_2:
					// emit syntax tree node associated with production
					// AC-Variation: AC-NotificationVariation

					s += m_AC_NotificationVariation.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-Variation
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_Variation (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_Variation_1:
					// emit syntax tree node associated with production
					// AC-Variation: AC-ObjectVariation

					s += m_AC_ObjectVariation.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AC_Variation_2:
					// emit syntax tree node associated with production
					// AC-Variation: AC-NotificationVariation

					s += m_AC_NotificationVariation.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-Variation

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Variation with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_Variation.production_kind kind = (AC_Variation.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_Variation.production_kind.g_AC_Variation_1:
					// traverse syntax tree node associated with production
					// AC-Variation: AC-ObjectVariation

						m_AC_ObjectVariation.Visit (visitor, appData);
				break;
				case AC_Variation.production_kind.g_AC_Variation_2:
					// traverse syntax tree node associated with production
					// AC-Variation: AC-NotificationVariation

						m_AC_NotificationVariation.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_AC_ObjectVariation?.reparent (this);
			m_AC_NotificationVariation?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-Variation
		//

		public void _init ()
		{
			m_AC_ObjectVariation = null;
			m_AC_NotificationVariation = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-Variation

		// counter of all nodes associated with syntax rule AC-Variation
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-Variation
		[DataMember (Name = "m_AC_ObjectVariation")] public AC_ObjectVariation m_AC_ObjectVariation { get; private set; }
		[DataMember (Name = "m_AC_NotificationVariation")] public AC_NotificationVariation m_AC_NotificationVariation { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-Variation

		// delegate function (callback) prototype associated with syntax rule AC-Variation
		public delegate bool AC_Variation_Callback (SyntaxTreeCallbackReason reason, AC_Variation.production_kind kind, AC_Variation p_AC_Variation);

		// event associated with syntax rule AC-Variation
		public event AC_Variation_Callback AC_Variation_Event;

		// event trigger associated with syntax rule AC-Variation
		public bool Raise_AC_Variation_Event (SyntaxTreeCallbackReason reason, AC_Variation.production_kind kind, AC_Variation p_AC_Variation)
		{
			bool? status = AC_Variation_Event?.Invoke (reason, kind, p_AC_Variation);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-Variation
		//
		// traverse syntax tree node associated with any production of syntax rule AC-Variation
		//

		public void Traverse (AC_Variation p_AC_Variation)
		{
			if (p_AC_Variation.isLocked())
				return;
			p_AC_Variation.dolock();
			AC_Variation.production_kind kind = (AC_Variation.production_kind) p_AC_Variation.kind;
			p_AC_Variation.turn_reset ();
			if (Raise_AC_Variation_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_Variation))
			switch (kind)
			{
				case AC_Variation.production_kind.g_AC_Variation_1:
					// traverse syntax tree node associated with production
					// AC-Variation: AC-ObjectVariation

					if (Raise_AC_Variation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Variation))
						Traverse (p_AC_Variation.m_AC_ObjectVariation);
					p_AC_Variation.turn_inc ();
					Raise_AC_Variation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Variation);
				break;
				case AC_Variation.production_kind.g_AC_Variation_2:
					// traverse syntax tree node associated with production
					// AC-Variation: AC-NotificationVariation

					if (Raise_AC_Variation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Variation))
						Traverse (p_AC_Variation.m_AC_NotificationVariation);
					p_AC_Variation.turn_inc ();
					Raise_AC_Variation_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_Variation);
				break;
			}
			Raise_AC_Variation_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_Variation);
			p_AC_Variation.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-Variation
		//

		public void TraverseCommon (AC_Variation p_AC_Variation)
		{
			AC_Variation.production_kind kind = (AC_Variation.production_kind) p_AC_Variation.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_Variation))
			switch (kind)
			{
				case AC_Variation.production_kind.g_AC_Variation_1:
					// traverse syntax tree node associated with production
					// AC-Variation: AC-ObjectVariation

						TraverseCommon (p_AC_Variation.m_AC_ObjectVariation);
				break;
				case AC_Variation.production_kind.g_AC_Variation_2:
					// traverse syntax tree node associated with production
					// AC-Variation: AC-NotificationVariation

						TraverseCommon (p_AC_Variation.m_AC_NotificationVariation);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_Variation);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-Variation

		//
		// create syntax tree node associated with production
		// AC-Variation: AC-ObjectVariation

		//

		public AC_Variation AC_Variation_1 (AC_ObjectVariation p_AC_ObjectVariation)
		{
			AC_Variation p_AC_Variation_ref = new AC_Variation(p_AC_ObjectVariation);
			p_AC_ObjectVariation.parent = p_AC_Variation_ref;
			Raise_AC_Variation_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Variation.production_kind.g_AC_Variation_1, p_AC_Variation_ref);
			return p_AC_Variation_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-Variation: AC-NotificationVariation

		//

		public AC_Variation AC_Variation_2 (AC_NotificationVariation p_AC_NotificationVariation)
		{
			AC_Variation p_AC_Variation_ref = new AC_Variation(p_AC_NotificationVariation);
			p_AC_NotificationVariation.parent = p_AC_Variation_ref;
			Raise_AC_Variation_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_Variation.production_kind.g_AC_Variation_2, p_AC_Variation_ref);
			return p_AC_Variation_ref;
		}
		#endregion
	};
}
