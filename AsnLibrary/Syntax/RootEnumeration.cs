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
	// class associated with syntax rule RootEnumeration
	//

	[DataContract]
	public class	RootEnumeration : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RootEnumeration
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RootEnumeration
		{
			g_RootEnumeration_1 = 1,	// Enumeration

		};
		#endregion
		#region production markers associated with the syntax rule RootEnumeration

		// markers associated with production: RootEnumeration -> Enumeration

		public enum production_marker_1 : ushort
		{
			m_Enumeration,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RootEnumeration

		// Constructor declaration(s) associated with production(s) of syntax rule RootEnumeration

		//
		// Constructor associated with the following production(s)
		// RootEnumeration -> Enumeration

		//

		public RootEnumeration (Enumeration p_Enumeration) : base ((uint) ProductionID._RootEnumeration_ID, (uint) production_kind.g_RootEnumeration_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Enumeration = p_Enumeration;
		}

		public RootEnumeration () { }

		// Copy constructor

		public RootEnumeration (RootEnumeration p_RootEnumeration) : base (p_RootEnumeration.id, p_RootEnumeration.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RootEnumeration.appInfo;
			switch ((production_kind) p_RootEnumeration.kind)
			{
				case production_kind.g_RootEnumeration_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Enumeration = (p_RootEnumeration.m_Enumeration != null) ? new Enumeration (p_RootEnumeration.m_Enumeration) : null) != null) m_Enumeration.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RootEnumeration" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RootEnumeration (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Enumeration?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RootEnumeration

		// Content changing function(s) associated with production(s) of syntax rule RootEnumeration

		//
		// Content changing function associated with following production(s)
		// RootEnumeration -> Enumeration

		//

		public void change(Enumeration p_Enumeration)
		{
			_init ();
			this.kind = (uint) production_kind.g_RootEnumeration_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Enumeration = p_Enumeration;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RootEnumeration
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Enumeration != null) && m_Enumeration.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RootEnumeration

		//
		// emit production tree node associated with any production of syntax rule RootEnumeration
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RootEnumeration_1:
					// emit syntax tree node associated with production
					// RootEnumeration: Enumeration

					s += m_Enumeration.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RootEnumeration
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RootEnumeration (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RootEnumeration_1:
					// emit syntax tree node associated with production
					// RootEnumeration: Enumeration

					s += m_Enumeration.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RootEnumeration

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RootEnumeration with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RootEnumeration.production_kind kind = (RootEnumeration.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RootEnumeration.production_kind.g_RootEnumeration_1:
					// traverse syntax tree node associated with production
					// RootEnumeration: Enumeration

						m_Enumeration.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Enumeration?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RootEnumeration
		//

		public void _init ()
		{
			m_Enumeration = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RootEnumeration

		// counter of all nodes associated with syntax rule RootEnumeration
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RootEnumeration
		[DataMember (Name = "m_Enumeration")] public Enumeration m_Enumeration { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RootEnumeration

		// delegate function (callback) prototype associated with syntax rule RootEnumeration
		public delegate bool RootEnumeration_Callback (SyntaxTreeCallbackReason reason, RootEnumeration.production_kind kind, RootEnumeration p_RootEnumeration);

		// event associated with syntax rule RootEnumeration
		public event RootEnumeration_Callback RootEnumeration_Event;

		// event trigger associated with syntax rule RootEnumeration
		public bool Raise_RootEnumeration_Event (SyntaxTreeCallbackReason reason, RootEnumeration.production_kind kind, RootEnumeration p_RootEnumeration)
		{
			bool? status = RootEnumeration_Event?.Invoke (reason, kind, p_RootEnumeration);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RootEnumeration
		//
		// traverse syntax tree node associated with any production of syntax rule RootEnumeration
		//

		public void Traverse (RootEnumeration p_RootEnumeration)
		{
			if (p_RootEnumeration.isLocked())
				return;
			p_RootEnumeration.dolock();
			RootEnumeration.production_kind kind = (RootEnumeration.production_kind) p_RootEnumeration.kind;
			p_RootEnumeration.turn_reset ();
			if (Raise_RootEnumeration_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RootEnumeration))
			switch (kind)
			{
				case RootEnumeration.production_kind.g_RootEnumeration_1:
					// traverse syntax tree node associated with production
					// RootEnumeration: Enumeration

					if (Raise_RootEnumeration_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RootEnumeration))
						Traverse (p_RootEnumeration.m_Enumeration);
					p_RootEnumeration.turn_inc ();
					Raise_RootEnumeration_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RootEnumeration);
				break;
			}
			Raise_RootEnumeration_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RootEnumeration);
			p_RootEnumeration.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RootEnumeration
		//

		public void TraverseCommon (RootEnumeration p_RootEnumeration)
		{
			RootEnumeration.production_kind kind = (RootEnumeration.production_kind) p_RootEnumeration.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RootEnumeration))
			switch (kind)
			{
				case RootEnumeration.production_kind.g_RootEnumeration_1:
					// traverse syntax tree node associated with production
					// RootEnumeration: Enumeration

						TraverseCommon (p_RootEnumeration.m_Enumeration);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RootEnumeration);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RootEnumeration

		//
		// create syntax tree node associated with production
		// RootEnumeration: Enumeration

		//

		public RootEnumeration RootEnumeration_1 (Enumeration p_Enumeration)
		{
			RootEnumeration p_RootEnumeration_ref = new RootEnumeration(p_Enumeration);
			p_Enumeration.parent = p_RootEnumeration_ref;
			Raise_RootEnumeration_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RootEnumeration.production_kind.g_RootEnumeration_1, p_RootEnumeration_ref);
			return p_RootEnumeration_ref;
		}
		#endregion
	};
}
