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
	// class associated with syntax rule DefinedObjectSet
	//

	[DataContract]
	public class	DefinedObjectSet : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinedObjectSet
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinedObjectSet
		{
			g_DefinedObjectSet_1 = 1,	// ExternalObjectSetReference

			g_DefinedObjectSet_2 = 2,	// objectsetreference-token

		};
		#endregion
		#region production markers associated with the syntax rule DefinedObjectSet

		// markers associated with production: DefinedObjectSet -> ExternalObjectSetReference

		public enum production_marker_1 : ushort
		{
			m_ExternalObjectSetReference,
			final
		};

		// markers associated with production: DefinedObjectSet -> objectsetreference-token

		public enum production_marker_2 : ushort
		{
			m_objectsetreference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinedObjectSet

		// Constructor declaration(s) associated with production(s) of syntax rule DefinedObjectSet

		//
		// Constructor associated with the following production(s)
		// DefinedObjectSet -> ExternalObjectSetReference

		//

		public DefinedObjectSet (ExternalObjectSetReference p_ExternalObjectSetReference) : base ((uint) ProductionID._DefinedObjectSet_ID, (uint) production_kind.g_DefinedObjectSet_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExternalObjectSetReference = p_ExternalObjectSetReference;
		}

		//
		// Constructor associated with the following production(s)
		// DefinedObjectSet -> objectsetreference-token

		//

		public DefinedObjectSet (objectsetreference_token p_objectsetreference_token) : base ((uint) ProductionID._DefinedObjectSet_ID, (uint) production_kind.g_DefinedObjectSet_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_objectsetreference_token = p_objectsetreference_token;
		}

		public DefinedObjectSet () { }

		// Copy constructor

		public DefinedObjectSet (DefinedObjectSet p_DefinedObjectSet) : base (p_DefinedObjectSet.id, p_DefinedObjectSet.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinedObjectSet.appInfo;
			switch ((production_kind) p_DefinedObjectSet.kind)
			{
				case production_kind.g_DefinedObjectSet_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExternalObjectSetReference = (p_DefinedObjectSet.m_ExternalObjectSetReference != null) ? new ExternalObjectSetReference (p_DefinedObjectSet.m_ExternalObjectSetReference) : null) != null) m_ExternalObjectSetReference.parent = this;
					break;
				case production_kind.g_DefinedObjectSet_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_objectsetreference_token = (p_DefinedObjectSet.m_objectsetreference_token != null) ? new objectsetreference_token (p_DefinedObjectSet.m_objectsetreference_token) : null) != null) m_objectsetreference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinedObjectSet" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinedObjectSet (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ExternalObjectSetReference?.Dispose ();
			m_objectsetreference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinedObjectSet

		// Content changing function(s) associated with production(s) of syntax rule DefinedObjectSet

		//
		// Content changing function associated with following production(s)
		// DefinedObjectSet -> ExternalObjectSetReference

		//

		public void change(ExternalObjectSetReference p_ExternalObjectSetReference)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedObjectSet_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExternalObjectSetReference = p_ExternalObjectSetReference;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinedObjectSet -> objectsetreference-token

		//

		public void change(objectsetreference_token p_objectsetreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedObjectSet_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_objectsetreference_token = p_objectsetreference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinedObjectSet
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ExternalObjectSetReference != null) && m_ExternalObjectSetReference.checkInclusion (element) ||
				(m_objectsetreference_token != null) && m_objectsetreference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinedObjectSet

		//
		// emit production tree node associated with any production of syntax rule DefinedObjectSet
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinedObjectSet_1:
					// emit syntax tree node associated with production
					// DefinedObjectSet: ExternalObjectSetReference

					s += m_ExternalObjectSetReference.Emit (depth - 1);
				break;
				case production_kind.g_DefinedObjectSet_2:
					// emit syntax tree node associated with production
					// DefinedObjectSet: objectsetreference-token

					s += m_objectsetreference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinedObjectSet
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinedObjectSet (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinedObjectSet_1:
					// emit syntax tree node associated with production
					// DefinedObjectSet: ExternalObjectSetReference

					s += m_ExternalObjectSetReference.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinedObjectSet_2:
					// emit syntax tree node associated with production
					// DefinedObjectSet: objectsetreference-token

					s += m_objectsetreference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinedObjectSet

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedObjectSet with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinedObjectSet.production_kind kind = (DefinedObjectSet.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinedObjectSet.production_kind.g_DefinedObjectSet_1:
					// traverse syntax tree node associated with production
					// DefinedObjectSet: ExternalObjectSetReference

						m_ExternalObjectSetReference.Visit (visitor, appData);
				break;
				case DefinedObjectSet.production_kind.g_DefinedObjectSet_2:
					// traverse syntax tree node associated with production
					// DefinedObjectSet: objectsetreference-token

						m_objectsetreference_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ExternalObjectSetReference?.reparent (this);
			m_objectsetreference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefinedObjectSet
		//

		public void _init ()
		{
			m_ExternalObjectSetReference = null;
			m_objectsetreference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinedObjectSet

		// counter of all nodes associated with syntax rule DefinedObjectSet
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinedObjectSet
		[DataMember (Name = "m_ExternalObjectSetReference")] public ExternalObjectSetReference m_ExternalObjectSetReference { get; private set; }
		[DataMember (Name = "m_objectsetreference_token")] public objectsetreference_token m_objectsetreference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinedObjectSet

		// delegate function (callback) prototype associated with syntax rule DefinedObjectSet
		public delegate bool DefinedObjectSet_Callback (SyntaxTreeCallbackReason reason, DefinedObjectSet.production_kind kind, DefinedObjectSet p_DefinedObjectSet);

		// event associated with syntax rule DefinedObjectSet
		public event DefinedObjectSet_Callback DefinedObjectSet_Event;

		// event trigger associated with syntax rule DefinedObjectSet
		public bool Raise_DefinedObjectSet_Event (SyntaxTreeCallbackReason reason, DefinedObjectSet.production_kind kind, DefinedObjectSet p_DefinedObjectSet)
		{
			bool? status = DefinedObjectSet_Event?.Invoke (reason, kind, p_DefinedObjectSet);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinedObjectSet
		//
		// traverse syntax tree node associated with any production of syntax rule DefinedObjectSet
		//

		public void Traverse (DefinedObjectSet p_DefinedObjectSet)
		{
			if (p_DefinedObjectSet.isLocked())
				return;
			p_DefinedObjectSet.dolock();
			DefinedObjectSet.production_kind kind = (DefinedObjectSet.production_kind) p_DefinedObjectSet.kind;
			p_DefinedObjectSet.turn_reset ();
			if (Raise_DefinedObjectSet_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinedObjectSet))
			switch (kind)
			{
				case DefinedObjectSet.production_kind.g_DefinedObjectSet_1:
					// traverse syntax tree node associated with production
					// DefinedObjectSet: ExternalObjectSetReference

					if (Raise_DefinedObjectSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObjectSet))
						Traverse (p_DefinedObjectSet.m_ExternalObjectSetReference);
					p_DefinedObjectSet.turn_inc ();
					Raise_DefinedObjectSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObjectSet);
				break;
				case DefinedObjectSet.production_kind.g_DefinedObjectSet_2:
					// traverse syntax tree node associated with production
					// DefinedObjectSet: objectsetreference-token

					if (Raise_DefinedObjectSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObjectSet))
						Traverse (p_DefinedObjectSet.m_objectsetreference_token);
					p_DefinedObjectSet.turn_inc ();
					Raise_DefinedObjectSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObjectSet);
				break;
			}
			Raise_DefinedObjectSet_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinedObjectSet);
			p_DefinedObjectSet.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedObjectSet
		//

		public void TraverseCommon (DefinedObjectSet p_DefinedObjectSet)
		{
			DefinedObjectSet.production_kind kind = (DefinedObjectSet.production_kind) p_DefinedObjectSet.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinedObjectSet))
			switch (kind)
			{
				case DefinedObjectSet.production_kind.g_DefinedObjectSet_1:
					// traverse syntax tree node associated with production
					// DefinedObjectSet: ExternalObjectSetReference

						TraverseCommon (p_DefinedObjectSet.m_ExternalObjectSetReference);
				break;
				case DefinedObjectSet.production_kind.g_DefinedObjectSet_2:
					// traverse syntax tree node associated with production
					// DefinedObjectSet: objectsetreference-token

						TraverseCommon (p_DefinedObjectSet.m_objectsetreference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinedObjectSet);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinedObjectSet

		//
		// create syntax tree node associated with production
		// DefinedObjectSet: ExternalObjectSetReference

		//

		public DefinedObjectSet DefinedObjectSet_1 (ExternalObjectSetReference p_ExternalObjectSetReference)
		{
			DefinedObjectSet p_DefinedObjectSet_ref = new DefinedObjectSet(p_ExternalObjectSetReference);
			p_ExternalObjectSetReference.parent = p_DefinedObjectSet_ref;
			Raise_DefinedObjectSet_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedObjectSet.production_kind.g_DefinedObjectSet_1, p_DefinedObjectSet_ref);
			return p_DefinedObjectSet_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinedObjectSet: objectsetreference-token

		//

		public DefinedObjectSet DefinedObjectSet_2 (objectsetreference_token p_objectsetreference_token)
		{
			DefinedObjectSet p_DefinedObjectSet_ref = new DefinedObjectSet(p_objectsetreference_token);
			p_objectsetreference_token.parent = p_DefinedObjectSet_ref;
			Raise_DefinedObjectSet_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedObjectSet.production_kind.g_DefinedObjectSet_2, p_DefinedObjectSet_ref);
			return p_DefinedObjectSet_ref;
		}
		#endregion
	};
}
