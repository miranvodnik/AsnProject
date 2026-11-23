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
	// class associated with syntax rule AC-VariationPart
	//

	[DataContract]
	public class	AC_VariationPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-VariationPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-VariationPart
		{
			g_AC_VariationPart_1 = 1,	// AC-Variations

			g_AC_VariationPart_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule AC-VariationPart

		// markers associated with production: AC-VariationPart -> AC-Variations

		public enum production_marker_1 : ushort
		{
			m_AC_Variations,
			final
		};

		// markers associated with production: AC-VariationPart -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-VariationPart

		// Constructor declaration(s) associated with production(s) of syntax rule AC-VariationPart

		//
		// Constructor associated with the following production(s)
		// AC-VariationPart -> AC-Variations

		//

		public AC_VariationPart (AC_Variations p_AC_Variations) : base ((uint) ProductionID._AC_VariationPart_ID, (uint) production_kind.g_AC_VariationPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AC_Variations = p_AC_Variations;
		}

		//
		// Constructor associated with the following production(s)
		// AC-VariationPart -> %empty

		//

		public AC_VariationPart () : base ((uint) ProductionID._AC_VariationPart_ID, (uint) production_kind.g_AC_VariationPart_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public AC_VariationPart (AC_VariationPart p_AC_VariationPart) : base (p_AC_VariationPart.id, p_AC_VariationPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_VariationPart.appInfo;
			switch ((production_kind) p_AC_VariationPart.kind)
			{
				case production_kind.g_AC_VariationPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AC_Variations = (p_AC_VariationPart.m_AC_Variations != null) ? new AC_Variations (p_AC_VariationPart.m_AC_Variations) : null) != null) m_AC_Variations.parent = this;
					break;
				case production_kind.g_AC_VariationPart_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "AC_VariationPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_VariationPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_AC_Variations?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-VariationPart

		// Content changing function(s) associated with production(s) of syntax rule AC-VariationPart

		//
		// Content changing function associated with following production(s)
		// AC-VariationPart -> AC-Variations

		//

		public void change(AC_Variations p_AC_Variations)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_VariationPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AC_Variations = p_AC_Variations;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-VariationPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_VariationPart_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-VariationPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_AC_Variations != null) && m_AC_Variations.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-VariationPart

		//
		// emit production tree node associated with any production of syntax rule AC-VariationPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_VariationPart_1:
					// emit syntax tree node associated with production
					// AC-VariationPart: AC-Variations

					s += m_AC_Variations.Emit (depth - 1);
				break;
				case production_kind.g_AC_VariationPart_2:
					// emit syntax tree node associated with production
					// AC-VariationPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-VariationPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_VariationPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_VariationPart_1:
					// emit syntax tree node associated with production
					// AC-VariationPart: AC-Variations

					s += m_AC_Variations.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AC_VariationPart_2:
					// emit syntax tree node associated with production
					// AC-VariationPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-VariationPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-VariationPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_VariationPart.production_kind kind = (AC_VariationPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_VariationPart.production_kind.g_AC_VariationPart_1:
					// traverse syntax tree node associated with production
					// AC-VariationPart: AC-Variations

						m_AC_Variations.Visit (visitor, appData);
				break;
				case AC_VariationPart.production_kind.g_AC_VariationPart_2:
					// traverse syntax tree node associated with production
					// AC-VariationPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_AC_Variations?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-VariationPart
		//

		public void _init ()
		{
			m_AC_Variations = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-VariationPart

		// counter of all nodes associated with syntax rule AC-VariationPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-VariationPart
		[DataMember (Name = "m_AC_Variations")] public AC_Variations m_AC_Variations { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-VariationPart

		// delegate function (callback) prototype associated with syntax rule AC-VariationPart
		public delegate bool AC_VariationPart_Callback (SyntaxTreeCallbackReason reason, AC_VariationPart.production_kind kind, AC_VariationPart p_AC_VariationPart);

		// event associated with syntax rule AC-VariationPart
		public event AC_VariationPart_Callback AC_VariationPart_Event;

		// event trigger associated with syntax rule AC-VariationPart
		public bool Raise_AC_VariationPart_Event (SyntaxTreeCallbackReason reason, AC_VariationPart.production_kind kind, AC_VariationPart p_AC_VariationPart)
		{
			bool? status = AC_VariationPart_Event?.Invoke (reason, kind, p_AC_VariationPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-VariationPart
		//
		// traverse syntax tree node associated with any production of syntax rule AC-VariationPart
		//

		public void Traverse (AC_VariationPart p_AC_VariationPart)
		{
			if (p_AC_VariationPart.isLocked())
				return;
			p_AC_VariationPart.dolock();
			AC_VariationPart.production_kind kind = (AC_VariationPart.production_kind) p_AC_VariationPart.kind;
			p_AC_VariationPart.turn_reset ();
			if (Raise_AC_VariationPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_VariationPart))
			switch (kind)
			{
				case AC_VariationPart.production_kind.g_AC_VariationPart_1:
					// traverse syntax tree node associated with production
					// AC-VariationPart: AC-Variations

					if (Raise_AC_VariationPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_VariationPart))
						Traverse (p_AC_VariationPart.m_AC_Variations);
					p_AC_VariationPart.turn_inc ();
					Raise_AC_VariationPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_VariationPart);
				break;
				case AC_VariationPart.production_kind.g_AC_VariationPart_2:
					// traverse syntax tree node associated with production
					// AC-VariationPart: %empty

				break;
			}
			Raise_AC_VariationPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_VariationPart);
			p_AC_VariationPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-VariationPart
		//

		public void TraverseCommon (AC_VariationPart p_AC_VariationPart)
		{
			AC_VariationPart.production_kind kind = (AC_VariationPart.production_kind) p_AC_VariationPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_VariationPart))
			switch (kind)
			{
				case AC_VariationPart.production_kind.g_AC_VariationPart_1:
					// traverse syntax tree node associated with production
					// AC-VariationPart: AC-Variations

						TraverseCommon (p_AC_VariationPart.m_AC_Variations);
				break;
				case AC_VariationPart.production_kind.g_AC_VariationPart_2:
					// traverse syntax tree node associated with production
					// AC-VariationPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_VariationPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-VariationPart

		//
		// create syntax tree node associated with production
		// AC-VariationPart: AC-Variations

		//

		public AC_VariationPart AC_VariationPart_1 (AC_Variations p_AC_Variations)
		{
			AC_VariationPart p_AC_VariationPart_ref = new AC_VariationPart(p_AC_Variations);
			p_AC_Variations.parent = p_AC_VariationPart_ref;
			Raise_AC_VariationPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_VariationPart.production_kind.g_AC_VariationPart_1, p_AC_VariationPart_ref);
			return p_AC_VariationPart_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-VariationPart: %empty

		//

		public AC_VariationPart AC_VariationPart_2 ()
		{
			AC_VariationPart p_AC_VariationPart_ref = new AC_VariationPart();
			Raise_AC_VariationPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_VariationPart.production_kind.g_AC_VariationPart_2, p_AC_VariationPart_ref);
			return p_AC_VariationPart_ref;
		}
		#endregion
	};
}
