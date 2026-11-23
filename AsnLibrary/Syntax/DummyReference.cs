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
	// class associated with syntax rule DummyReference
	//

	[DataContract]
	public class	DummyReference : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DummyReference
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DummyReference
		{
			g_DummyReference_1 = 1,	// Reference

		};
		#endregion
		#region production markers associated with the syntax rule DummyReference

		// markers associated with production: DummyReference -> Reference

		public enum production_marker_1 : ushort
		{
			m_Reference,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DummyReference

		// Constructor declaration(s) associated with production(s) of syntax rule DummyReference

		//
		// Constructor associated with the following production(s)
		// DummyReference -> Reference

		//

		public DummyReference (Reference p_Reference) : base ((uint) ProductionID._DummyReference_ID, (uint) production_kind.g_DummyReference_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Reference = p_Reference;
		}

		public DummyReference () { }

		// Copy constructor

		public DummyReference (DummyReference p_DummyReference) : base (p_DummyReference.id, p_DummyReference.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DummyReference.appInfo;
			switch ((production_kind) p_DummyReference.kind)
			{
				case production_kind.g_DummyReference_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Reference = (p_DummyReference.m_Reference != null) ? new Reference (p_DummyReference.m_Reference) : null) != null) m_Reference.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DummyReference" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DummyReference (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Reference?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DummyReference

		// Content changing function(s) associated with production(s) of syntax rule DummyReference

		//
		// Content changing function associated with following production(s)
		// DummyReference -> Reference

		//

		public void change(Reference p_Reference)
		{
			_init ();
			this.kind = (uint) production_kind.g_DummyReference_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Reference = p_Reference;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DummyReference
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Reference != null) && m_Reference.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DummyReference

		//
		// emit production tree node associated with any production of syntax rule DummyReference
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DummyReference_1:
					// emit syntax tree node associated with production
					// DummyReference: Reference

					s += m_Reference.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DummyReference
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DummyReference (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DummyReference_1:
					// emit syntax tree node associated with production
					// DummyReference: Reference

					s += m_Reference.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DummyReference

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DummyReference with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DummyReference.production_kind kind = (DummyReference.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DummyReference.production_kind.g_DummyReference_1:
					// traverse syntax tree node associated with production
					// DummyReference: Reference

						m_Reference.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Reference?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DummyReference
		//

		public void _init ()
		{
			m_Reference = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DummyReference

		// counter of all nodes associated with syntax rule DummyReference
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DummyReference
		[DataMember (Name = "m_Reference")] public Reference m_Reference { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DummyReference

		// delegate function (callback) prototype associated with syntax rule DummyReference
		public delegate bool DummyReference_Callback (SyntaxTreeCallbackReason reason, DummyReference.production_kind kind, DummyReference p_DummyReference);

		// event associated with syntax rule DummyReference
		public event DummyReference_Callback DummyReference_Event;

		// event trigger associated with syntax rule DummyReference
		public bool Raise_DummyReference_Event (SyntaxTreeCallbackReason reason, DummyReference.production_kind kind, DummyReference p_DummyReference)
		{
			bool? status = DummyReference_Event?.Invoke (reason, kind, p_DummyReference);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DummyReference
		//
		// traverse syntax tree node associated with any production of syntax rule DummyReference
		//

		public void Traverse (DummyReference p_DummyReference)
		{
			if (p_DummyReference.isLocked())
				return;
			p_DummyReference.dolock();
			DummyReference.production_kind kind = (DummyReference.production_kind) p_DummyReference.kind;
			p_DummyReference.turn_reset ();
			if (Raise_DummyReference_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DummyReference))
			switch (kind)
			{
				case DummyReference.production_kind.g_DummyReference_1:
					// traverse syntax tree node associated with production
					// DummyReference: Reference

					if (Raise_DummyReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DummyReference))
						Traverse (p_DummyReference.m_Reference);
					p_DummyReference.turn_inc ();
					Raise_DummyReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DummyReference);
				break;
			}
			Raise_DummyReference_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DummyReference);
			p_DummyReference.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DummyReference
		//

		public void TraverseCommon (DummyReference p_DummyReference)
		{
			DummyReference.production_kind kind = (DummyReference.production_kind) p_DummyReference.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DummyReference))
			switch (kind)
			{
				case DummyReference.production_kind.g_DummyReference_1:
					// traverse syntax tree node associated with production
					// DummyReference: Reference

						TraverseCommon (p_DummyReference.m_Reference);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DummyReference);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DummyReference

		//
		// create syntax tree node associated with production
		// DummyReference: Reference

		//

		public DummyReference DummyReference_1 (Reference p_Reference)
		{
			DummyReference p_DummyReference_ref = new DummyReference(p_Reference);
			p_Reference.parent = p_DummyReference_ref;
			Raise_DummyReference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DummyReference.production_kind.g_DummyReference_1, p_DummyReference_ref);
			return p_DummyReference_ref;
		}
		#endregion
	};
}
