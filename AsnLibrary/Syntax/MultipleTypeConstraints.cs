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
	// class associated with syntax rule MultipleTypeConstraints
	//

	[DataContract]
	public class	MultipleTypeConstraints : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MultipleTypeConstraints
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MultipleTypeConstraints
		{
			g_MultipleTypeConstraints_1 = 1,	// FullSpecification

			g_MultipleTypeConstraints_2 = 2,	// PartialSpecification

		};
		#endregion
		#region production markers associated with the syntax rule MultipleTypeConstraints

		// markers associated with production: MultipleTypeConstraints -> FullSpecification

		public enum production_marker_1 : ushort
		{
			m_FullSpecification,
			final
		};

		// markers associated with production: MultipleTypeConstraints -> PartialSpecification

		public enum production_marker_2 : ushort
		{
			m_PartialSpecification,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MultipleTypeConstraints

		// Constructor declaration(s) associated with production(s) of syntax rule MultipleTypeConstraints

		//
		// Constructor associated with the following production(s)
		// MultipleTypeConstraints -> FullSpecification

		//

		public MultipleTypeConstraints (FullSpecification p_FullSpecification) : base ((uint) ProductionID._MultipleTypeConstraints_ID, (uint) production_kind.g_MultipleTypeConstraints_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_FullSpecification = p_FullSpecification;
		}

		//
		// Constructor associated with the following production(s)
		// MultipleTypeConstraints -> PartialSpecification

		//

		public MultipleTypeConstraints (PartialSpecification p_PartialSpecification) : base ((uint) ProductionID._MultipleTypeConstraints_ID, (uint) production_kind.g_MultipleTypeConstraints_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_PartialSpecification = p_PartialSpecification;
		}

		public MultipleTypeConstraints () { }

		// Copy constructor

		public MultipleTypeConstraints (MultipleTypeConstraints p_MultipleTypeConstraints) : base (p_MultipleTypeConstraints.id, p_MultipleTypeConstraints.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MultipleTypeConstraints.appInfo;
			switch ((production_kind) p_MultipleTypeConstraints.kind)
			{
				case production_kind.g_MultipleTypeConstraints_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_FullSpecification = (p_MultipleTypeConstraints.m_FullSpecification != null) ? new FullSpecification (p_MultipleTypeConstraints.m_FullSpecification) : null) != null) m_FullSpecification.parent = this;
					break;
				case production_kind.g_MultipleTypeConstraints_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PartialSpecification = (p_MultipleTypeConstraints.m_PartialSpecification != null) ? new PartialSpecification (p_MultipleTypeConstraints.m_PartialSpecification) : null) != null) m_PartialSpecification.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MultipleTypeConstraints" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MultipleTypeConstraints (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_FullSpecification?.Dispose ();
			m_PartialSpecification?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MultipleTypeConstraints

		// Content changing function(s) associated with production(s) of syntax rule MultipleTypeConstraints

		//
		// Content changing function associated with following production(s)
		// MultipleTypeConstraints -> FullSpecification

		//

		public void change(FullSpecification p_FullSpecification)
		{
			_init ();
			this.kind = (uint) production_kind.g_MultipleTypeConstraints_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_FullSpecification = p_FullSpecification;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MultipleTypeConstraints -> PartialSpecification

		//

		public void change(PartialSpecification p_PartialSpecification)
		{
			_init ();
			this.kind = (uint) production_kind.g_MultipleTypeConstraints_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_PartialSpecification = p_PartialSpecification;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MultipleTypeConstraints
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_FullSpecification != null) && m_FullSpecification.checkInclusion (element) ||
				(m_PartialSpecification != null) && m_PartialSpecification.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MultipleTypeConstraints

		//
		// emit production tree node associated with any production of syntax rule MultipleTypeConstraints
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MultipleTypeConstraints_1:
					// emit syntax tree node associated with production
					// MultipleTypeConstraints: FullSpecification

					s += m_FullSpecification.Emit (depth - 1);
				break;
				case production_kind.g_MultipleTypeConstraints_2:
					// emit syntax tree node associated with production
					// MultipleTypeConstraints: PartialSpecification

					s += m_PartialSpecification.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MultipleTypeConstraints
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MultipleTypeConstraints (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MultipleTypeConstraints_1:
					// emit syntax tree node associated with production
					// MultipleTypeConstraints: FullSpecification

					s += m_FullSpecification.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MultipleTypeConstraints_2:
					// emit syntax tree node associated with production
					// MultipleTypeConstraints: PartialSpecification

					s += m_PartialSpecification.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MultipleTypeConstraints

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MultipleTypeConstraints with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MultipleTypeConstraints.production_kind kind = (MultipleTypeConstraints.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MultipleTypeConstraints.production_kind.g_MultipleTypeConstraints_1:
					// traverse syntax tree node associated with production
					// MultipleTypeConstraints: FullSpecification

						m_FullSpecification.Visit (visitor, appData);
				break;
				case MultipleTypeConstraints.production_kind.g_MultipleTypeConstraints_2:
					// traverse syntax tree node associated with production
					// MultipleTypeConstraints: PartialSpecification

						m_PartialSpecification.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_FullSpecification?.reparent (this);
			m_PartialSpecification?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MultipleTypeConstraints
		//

		public void _init ()
		{
			m_FullSpecification = null;
			m_PartialSpecification = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MultipleTypeConstraints

		// counter of all nodes associated with syntax rule MultipleTypeConstraints
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MultipleTypeConstraints
		[DataMember (Name = "m_FullSpecification")] public FullSpecification m_FullSpecification { get; private set; }
		[DataMember (Name = "m_PartialSpecification")] public PartialSpecification m_PartialSpecification { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MultipleTypeConstraints

		// delegate function (callback) prototype associated with syntax rule MultipleTypeConstraints
		public delegate bool MultipleTypeConstraints_Callback (SyntaxTreeCallbackReason reason, MultipleTypeConstraints.production_kind kind, MultipleTypeConstraints p_MultipleTypeConstraints);

		// event associated with syntax rule MultipleTypeConstraints
		public event MultipleTypeConstraints_Callback MultipleTypeConstraints_Event;

		// event trigger associated with syntax rule MultipleTypeConstraints
		public bool Raise_MultipleTypeConstraints_Event (SyntaxTreeCallbackReason reason, MultipleTypeConstraints.production_kind kind, MultipleTypeConstraints p_MultipleTypeConstraints)
		{
			bool? status = MultipleTypeConstraints_Event?.Invoke (reason, kind, p_MultipleTypeConstraints);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MultipleTypeConstraints
		//
		// traverse syntax tree node associated with any production of syntax rule MultipleTypeConstraints
		//

		public void Traverse (MultipleTypeConstraints p_MultipleTypeConstraints)
		{
			if (p_MultipleTypeConstraints.isLocked())
				return;
			p_MultipleTypeConstraints.dolock();
			MultipleTypeConstraints.production_kind kind = (MultipleTypeConstraints.production_kind) p_MultipleTypeConstraints.kind;
			p_MultipleTypeConstraints.turn_reset ();
			if (Raise_MultipleTypeConstraints_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MultipleTypeConstraints))
			switch (kind)
			{
				case MultipleTypeConstraints.production_kind.g_MultipleTypeConstraints_1:
					// traverse syntax tree node associated with production
					// MultipleTypeConstraints: FullSpecification

					if (Raise_MultipleTypeConstraints_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MultipleTypeConstraints))
						Traverse (p_MultipleTypeConstraints.m_FullSpecification);
					p_MultipleTypeConstraints.turn_inc ();
					Raise_MultipleTypeConstraints_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MultipleTypeConstraints);
				break;
				case MultipleTypeConstraints.production_kind.g_MultipleTypeConstraints_2:
					// traverse syntax tree node associated with production
					// MultipleTypeConstraints: PartialSpecification

					if (Raise_MultipleTypeConstraints_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MultipleTypeConstraints))
						Traverse (p_MultipleTypeConstraints.m_PartialSpecification);
					p_MultipleTypeConstraints.turn_inc ();
					Raise_MultipleTypeConstraints_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MultipleTypeConstraints);
				break;
			}
			Raise_MultipleTypeConstraints_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MultipleTypeConstraints);
			p_MultipleTypeConstraints.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MultipleTypeConstraints
		//

		public void TraverseCommon (MultipleTypeConstraints p_MultipleTypeConstraints)
		{
			MultipleTypeConstraints.production_kind kind = (MultipleTypeConstraints.production_kind) p_MultipleTypeConstraints.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MultipleTypeConstraints))
			switch (kind)
			{
				case MultipleTypeConstraints.production_kind.g_MultipleTypeConstraints_1:
					// traverse syntax tree node associated with production
					// MultipleTypeConstraints: FullSpecification

						TraverseCommon (p_MultipleTypeConstraints.m_FullSpecification);
				break;
				case MultipleTypeConstraints.production_kind.g_MultipleTypeConstraints_2:
					// traverse syntax tree node associated with production
					// MultipleTypeConstraints: PartialSpecification

						TraverseCommon (p_MultipleTypeConstraints.m_PartialSpecification);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MultipleTypeConstraints);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MultipleTypeConstraints

		//
		// create syntax tree node associated with production
		// MultipleTypeConstraints: FullSpecification

		//

		public MultipleTypeConstraints MultipleTypeConstraints_1 (FullSpecification p_FullSpecification)
		{
			MultipleTypeConstraints p_MultipleTypeConstraints_ref = new MultipleTypeConstraints(p_FullSpecification);
			p_FullSpecification.parent = p_MultipleTypeConstraints_ref;
			Raise_MultipleTypeConstraints_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MultipleTypeConstraints.production_kind.g_MultipleTypeConstraints_1, p_MultipleTypeConstraints_ref);
			return p_MultipleTypeConstraints_ref;
		}

		//
		// create syntax tree node associated with production
		// MultipleTypeConstraints: PartialSpecification

		//

		public MultipleTypeConstraints MultipleTypeConstraints_2 (PartialSpecification p_PartialSpecification)
		{
			MultipleTypeConstraints p_MultipleTypeConstraints_ref = new MultipleTypeConstraints(p_PartialSpecification);
			p_PartialSpecification.parent = p_MultipleTypeConstraints_ref;
			Raise_MultipleTypeConstraints_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MultipleTypeConstraints.production_kind.g_MultipleTypeConstraints_2, p_MultipleTypeConstraints_ref);
			return p_MultipleTypeConstraints_ref;
		}
		#endregion
	};
}
