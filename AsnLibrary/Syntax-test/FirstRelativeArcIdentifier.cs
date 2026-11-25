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
	// class associated with syntax rule FirstRelativeArcIdentifier
	//

	[DataContract]
	public class	FirstRelativeArcIdentifier : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule FirstRelativeArcIdentifier
		public enum production_kind : ushort	// enumerated production(s) of syntax rule FirstRelativeArcIdentifier
		{
			g_FirstRelativeArcIdentifier_1 = 1,	// ArcIdentifier

		};
		#endregion
		#region production markers associated with the syntax rule FirstRelativeArcIdentifier

		// markers associated with production: FirstRelativeArcIdentifier -> ArcIdentifier

		public enum production_marker_1 : ushort
		{
			m_ArcIdentifier,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule FirstRelativeArcIdentifier

		// Constructor declaration(s) associated with production(s) of syntax rule FirstRelativeArcIdentifier

		//
		// Constructor associated with the following production(s)
		// FirstRelativeArcIdentifier -> ArcIdentifier

		//

		public FirstRelativeArcIdentifier (ArcIdentifier p_ArcIdentifier) : base ((uint) ProductionID._FirstRelativeArcIdentifier_ID, (uint) production_kind.g_FirstRelativeArcIdentifier_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ArcIdentifier = p_ArcIdentifier;
		}

		public FirstRelativeArcIdentifier () { }

		// Copy constructor

		public FirstRelativeArcIdentifier (FirstRelativeArcIdentifier p_FirstRelativeArcIdentifier) : base (p_FirstRelativeArcIdentifier.id, p_FirstRelativeArcIdentifier.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_FirstRelativeArcIdentifier.appInfo;
			switch ((production_kind) p_FirstRelativeArcIdentifier.kind)
			{
				case production_kind.g_FirstRelativeArcIdentifier_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ArcIdentifier = (p_FirstRelativeArcIdentifier.m_ArcIdentifier != null) ? new ArcIdentifier (p_FirstRelativeArcIdentifier.m_ArcIdentifier) : null) != null) m_ArcIdentifier.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "FirstRelativeArcIdentifier" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new FirstRelativeArcIdentifier (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ArcIdentifier?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule FirstRelativeArcIdentifier

		// Content changing function(s) associated with production(s) of syntax rule FirstRelativeArcIdentifier

		//
		// Content changing function associated with following production(s)
		// FirstRelativeArcIdentifier -> ArcIdentifier

		//

		public void change(ArcIdentifier p_ArcIdentifier)
		{
			_init ();
			this.kind = (uint) production_kind.g_FirstRelativeArcIdentifier_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ArcIdentifier = p_ArcIdentifier;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule FirstRelativeArcIdentifier
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ArcIdentifier != null) && m_ArcIdentifier.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule FirstRelativeArcIdentifier

		//
		// emit production tree node associated with any production of syntax rule FirstRelativeArcIdentifier
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_FirstRelativeArcIdentifier_1:
					// emit syntax tree node associated with production
					// FirstRelativeArcIdentifier: ArcIdentifier

					s += m_ArcIdentifier.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule FirstRelativeArcIdentifier
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "FirstRelativeArcIdentifier (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_FirstRelativeArcIdentifier_1:
					// emit syntax tree node associated with production
					// FirstRelativeArcIdentifier: ArcIdentifier

					s += m_ArcIdentifier.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule FirstRelativeArcIdentifier

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule FirstRelativeArcIdentifier with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			FirstRelativeArcIdentifier.production_kind kind = (FirstRelativeArcIdentifier.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case FirstRelativeArcIdentifier.production_kind.g_FirstRelativeArcIdentifier_1:
					// traverse syntax tree node associated with production
					// FirstRelativeArcIdentifier: ArcIdentifier

						m_ArcIdentifier.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ArcIdentifier?.reparent (this);
		}

		//
		// initialize object associated with syntax rule FirstRelativeArcIdentifier
		//

		public void _init ()
		{
			m_ArcIdentifier = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule FirstRelativeArcIdentifier

		// counter of all nodes associated with syntax rule FirstRelativeArcIdentifier
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule FirstRelativeArcIdentifier
		[DataMember (Name = "m_ArcIdentifier")] public ArcIdentifier m_ArcIdentifier { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule FirstRelativeArcIdentifier

		// delegate function (callback) prototype associated with syntax rule FirstRelativeArcIdentifier
		public delegate bool FirstRelativeArcIdentifier_Callback (SyntaxTreeCallbackReason reason, FirstRelativeArcIdentifier.production_kind kind, FirstRelativeArcIdentifier p_FirstRelativeArcIdentifier);

		// event associated with syntax rule FirstRelativeArcIdentifier
		public event FirstRelativeArcIdentifier_Callback FirstRelativeArcIdentifier_Event;

		// event trigger associated with syntax rule FirstRelativeArcIdentifier
		public bool Raise_FirstRelativeArcIdentifier_Event (SyntaxTreeCallbackReason reason, FirstRelativeArcIdentifier.production_kind kind, FirstRelativeArcIdentifier p_FirstRelativeArcIdentifier)
		{
			bool? status = FirstRelativeArcIdentifier_Event?.Invoke (reason, kind, p_FirstRelativeArcIdentifier);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule FirstRelativeArcIdentifier
		//
		// traverse syntax tree node associated with any production of syntax rule FirstRelativeArcIdentifier
		//

		public void Traverse (FirstRelativeArcIdentifier p_FirstRelativeArcIdentifier)
		{
			if (p_FirstRelativeArcIdentifier.isLocked())
				return;
			p_FirstRelativeArcIdentifier.dolock();
			FirstRelativeArcIdentifier.production_kind kind = (FirstRelativeArcIdentifier.production_kind) p_FirstRelativeArcIdentifier.kind;
			p_FirstRelativeArcIdentifier.turn_reset ();
			if (Raise_FirstRelativeArcIdentifier_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_FirstRelativeArcIdentifier))
			switch (kind)
			{
				case FirstRelativeArcIdentifier.production_kind.g_FirstRelativeArcIdentifier_1:
					// traverse syntax tree node associated with production
					// FirstRelativeArcIdentifier: ArcIdentifier

					if (Raise_FirstRelativeArcIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FirstRelativeArcIdentifier))
						Traverse (p_FirstRelativeArcIdentifier.m_ArcIdentifier);
					p_FirstRelativeArcIdentifier.turn_inc ();
					Raise_FirstRelativeArcIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FirstRelativeArcIdentifier);
				break;
			}
			Raise_FirstRelativeArcIdentifier_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_FirstRelativeArcIdentifier);
			p_FirstRelativeArcIdentifier.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule FirstRelativeArcIdentifier
		//

		public void TraverseCommon (FirstRelativeArcIdentifier p_FirstRelativeArcIdentifier)
		{
			FirstRelativeArcIdentifier.production_kind kind = (FirstRelativeArcIdentifier.production_kind) p_FirstRelativeArcIdentifier.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_FirstRelativeArcIdentifier))
			switch (kind)
			{
				case FirstRelativeArcIdentifier.production_kind.g_FirstRelativeArcIdentifier_1:
					// traverse syntax tree node associated with production
					// FirstRelativeArcIdentifier: ArcIdentifier

						TraverseCommon (p_FirstRelativeArcIdentifier.m_ArcIdentifier);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_FirstRelativeArcIdentifier);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule FirstRelativeArcIdentifier

		//
		// create syntax tree node associated with production
		// FirstRelativeArcIdentifier: ArcIdentifier

		//

		public FirstRelativeArcIdentifier FirstRelativeArcIdentifier_1 (ArcIdentifier p_ArcIdentifier)
		{
			FirstRelativeArcIdentifier p_FirstRelativeArcIdentifier_ref = new FirstRelativeArcIdentifier(p_ArcIdentifier);
			p_ArcIdentifier.parent = p_FirstRelativeArcIdentifier_ref;
			Raise_FirstRelativeArcIdentifier_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FirstRelativeArcIdentifier.production_kind.g_FirstRelativeArcIdentifier_1, p_FirstRelativeArcIdentifier_ref);
			return p_FirstRelativeArcIdentifier_ref;
		}
		#endregion
	};
}
