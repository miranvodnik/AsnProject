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
	// class associated with syntax rule Exclusions
	//

	[DataContract]
	public class	Exclusions : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Exclusions
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Exclusions
		{
			g_Exclusions_1 = 1,	// EXCEPT Elements

		};
		#endregion
		#region production markers associated with the syntax rule Exclusions

		// markers associated with production: Exclusions -> EXCEPT Elements

		public enum production_marker_1 : ushort
		{
			m_Elements,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Exclusions

		// Constructor declaration(s) associated with production(s) of syntax rule Exclusions

		//
		// Constructor associated with the following production(s)
		// Exclusions -> EXCEPT Elements

		//

		public Exclusions (SyntaxTreeToken p_token, Elements p_Elements) : base ((uint) ProductionID._Exclusions_ID, (uint) production_kind.g_Exclusions_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_EXCEPT = p_token;
			children[1] = m_Elements = p_Elements;
		}

		public Exclusions () { }

		// Copy constructor

		public Exclusions (Exclusions p_Exclusions) : base (p_Exclusions.id, p_Exclusions.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Exclusions.appInfo;
			switch ((production_kind) p_Exclusions.kind)
			{
				case production_kind.g_Exclusions_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_EXCEPT = (p_Exclusions.m_EXCEPT != null) ? new SyntaxTreeToken (p_Exclusions.m_EXCEPT) : null) != null) m_EXCEPT.parent = this;
					if ((children [1] = m_Elements = (p_Exclusions.m_Elements != null) ? new Elements (p_Exclusions.m_Elements) : null) != null) m_Elements.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Exclusions" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Exclusions (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_EXCEPT?.Dispose ();
			m_Elements?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Exclusions

		// Content changing function(s) associated with production(s) of syntax rule Exclusions

		//
		// Content changing function associated with following production(s)
		// Exclusions -> EXCEPT Elements

		//

		public void change(SyntaxTreeToken p_token, Elements p_Elements)
		{
			_init ();
			this.kind = (uint) production_kind.g_Exclusions_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_EXCEPT = p_token;
			children [1] = m_Elements = p_Elements;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Exclusions
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_EXCEPT != null) && m_EXCEPT.checkInclusion (element) ||
				(m_Elements != null) && m_Elements.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Exclusions

		//
		// emit production tree node associated with any production of syntax rule Exclusions
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Exclusions_1:
					// emit syntax tree node associated with production
					// Exclusions: EXCEPT Elements

					s += m_EXCEPT.Emit (depth - 1);
					s += " ";
					s += m_Elements.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Exclusions
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Exclusions (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Exclusions_1:
					// emit syntax tree node associated with production
					// Exclusions: EXCEPT Elements

					s += "EXCEPT";
					s += ' ';
					s += m_Elements.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Exclusions

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Exclusions with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Exclusions.production_kind kind = (Exclusions.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Exclusions.production_kind.g_Exclusions_1:
					// traverse syntax tree node associated with production
					// Exclusions: EXCEPT Elements

						m_EXCEPT.Visit (visitor, appData);
						m_Elements.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_EXCEPT?.reparent (this);
			m_Elements?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Exclusions
		//

		public void _init ()
		{
			m_EXCEPT = null;
			m_Elements = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Exclusions

		// counter of all nodes associated with syntax rule Exclusions
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Exclusions
		[DataMember (Name = "m_EXCEPT")] public SyntaxTreeToken m_EXCEPT { get; private set; }
		[DataMember (Name = "m_Elements")] public Elements m_Elements { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Exclusions

		// delegate function (callback) prototype associated with syntax rule Exclusions
		public delegate bool Exclusions_Callback (SyntaxTreeCallbackReason reason, Exclusions.production_kind kind, Exclusions p_Exclusions);

		// event associated with syntax rule Exclusions
		public event Exclusions_Callback Exclusions_Event;

		// event trigger associated with syntax rule Exclusions
		public bool Raise_Exclusions_Event (SyntaxTreeCallbackReason reason, Exclusions.production_kind kind, Exclusions p_Exclusions)
		{
			bool? status = Exclusions_Event?.Invoke (reason, kind, p_Exclusions);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Exclusions
		//
		// traverse syntax tree node associated with any production of syntax rule Exclusions
		//

		public void Traverse (Exclusions p_Exclusions)
		{
			if (p_Exclusions.isLocked())
				return;
			p_Exclusions.dolock();
			Exclusions.production_kind kind = (Exclusions.production_kind) p_Exclusions.kind;
			p_Exclusions.turn_reset ();
			if (Raise_Exclusions_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Exclusions))
			switch (kind)
			{
				case Exclusions.production_kind.g_Exclusions_1:
					// traverse syntax tree node associated with production
					// Exclusions: EXCEPT Elements

					if (Raise_Exclusions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Exclusions))
						Traverse (p_Exclusions.m_Elements);
					p_Exclusions.turn_inc ();
					Raise_Exclusions_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Exclusions);
				break;
			}
			Raise_Exclusions_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Exclusions);
			p_Exclusions.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Exclusions
		//

		public void TraverseCommon (Exclusions p_Exclusions)
		{
			Exclusions.production_kind kind = (Exclusions.production_kind) p_Exclusions.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Exclusions))
			switch (kind)
			{
				case Exclusions.production_kind.g_Exclusions_1:
					// traverse syntax tree node associated with production
					// Exclusions: EXCEPT Elements

						TraverseCommon (p_Exclusions.m_EXCEPT);
						TraverseCommon (p_Exclusions.m_Elements);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Exclusions);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Exclusions

		//
		// create syntax tree node associated with production
		// Exclusions: EXCEPT Elements

		//

		public Exclusions Exclusions_1 (SyntaxTreeToken p_token, Elements p_Elements)
		{
			Exclusions p_Exclusions_ref = new Exclusions(p_token, p_Elements);
			p_token.parent = p_Exclusions_ref;
			p_Elements.parent = p_Exclusions_ref;
			Raise_Exclusions_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Exclusions.production_kind.g_Exclusions_1, p_Exclusions_ref);
			return p_Exclusions_ref;
		}
		#endregion
	};
}
