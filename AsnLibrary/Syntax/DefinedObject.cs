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
	// class associated with syntax rule DefinedObject
	//

	[DataContract]
	public class	DefinedObject : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinedObject
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinedObject
		{
			g_DefinedObject_1 = 1,	// ExternalObjectReference

			g_DefinedObject_2 = 2,	// objectreference-token

		};
		#endregion
		#region production markers associated with the syntax rule DefinedObject

		// markers associated with production: DefinedObject -> ExternalObjectReference

		public enum production_marker_1 : ushort
		{
			m_ExternalObjectReference,
			final
		};

		// markers associated with production: DefinedObject -> objectreference-token

		public enum production_marker_2 : ushort
		{
			m_objectreference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinedObject

		// Constructor declaration(s) associated with production(s) of syntax rule DefinedObject

		//
		// Constructor associated with the following production(s)
		// DefinedObject -> ExternalObjectReference

		//

		public DefinedObject (ExternalObjectReference p_ExternalObjectReference) : base ((uint) ProductionID._DefinedObject_ID, (uint) production_kind.g_DefinedObject_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExternalObjectReference = p_ExternalObjectReference;
		}

		//
		// Constructor associated with the following production(s)
		// DefinedObject -> objectreference-token

		//

		public DefinedObject (objectreference_token p_objectreference_token) : base ((uint) ProductionID._DefinedObject_ID, (uint) production_kind.g_DefinedObject_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_objectreference_token = p_objectreference_token;
		}

		public DefinedObject () { }

		// Copy constructor

		public DefinedObject (DefinedObject p_DefinedObject) : base (p_DefinedObject.id, p_DefinedObject.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinedObject.appInfo;
			switch ((production_kind) p_DefinedObject.kind)
			{
				case production_kind.g_DefinedObject_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExternalObjectReference = (p_DefinedObject.m_ExternalObjectReference != null) ? new ExternalObjectReference (p_DefinedObject.m_ExternalObjectReference) : null) != null) m_ExternalObjectReference.parent = this;
					break;
				case production_kind.g_DefinedObject_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_objectreference_token = (p_DefinedObject.m_objectreference_token != null) ? new objectreference_token (p_DefinedObject.m_objectreference_token) : null) != null) m_objectreference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinedObject" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinedObject (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ExternalObjectReference?.Dispose ();
			m_objectreference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinedObject

		// Content changing function(s) associated with production(s) of syntax rule DefinedObject

		//
		// Content changing function associated with following production(s)
		// DefinedObject -> ExternalObjectReference

		//

		public void change(ExternalObjectReference p_ExternalObjectReference)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedObject_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExternalObjectReference = p_ExternalObjectReference;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinedObject -> objectreference-token

		//

		public void change(objectreference_token p_objectreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedObject_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_objectreference_token = p_objectreference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinedObject
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ExternalObjectReference != null) && m_ExternalObjectReference.checkInclusion (element) ||
				(m_objectreference_token != null) && m_objectreference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinedObject

		//
		// emit production tree node associated with any production of syntax rule DefinedObject
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinedObject_1:
					// emit syntax tree node associated with production
					// DefinedObject: ExternalObjectReference

					s += m_ExternalObjectReference.Emit (depth - 1);
				break;
				case production_kind.g_DefinedObject_2:
					// emit syntax tree node associated with production
					// DefinedObject: objectreference-token

					s += m_objectreference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinedObject
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinedObject (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinedObject_1:
					// emit syntax tree node associated with production
					// DefinedObject: ExternalObjectReference

					s += m_ExternalObjectReference.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinedObject_2:
					// emit syntax tree node associated with production
					// DefinedObject: objectreference-token

					s += m_objectreference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinedObject

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedObject with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinedObject.production_kind kind = (DefinedObject.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinedObject.production_kind.g_DefinedObject_1:
					// traverse syntax tree node associated with production
					// DefinedObject: ExternalObjectReference

						m_ExternalObjectReference.Visit (visitor, appData);
				break;
				case DefinedObject.production_kind.g_DefinedObject_2:
					// traverse syntax tree node associated with production
					// DefinedObject: objectreference-token

						m_objectreference_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ExternalObjectReference?.reparent (this);
			m_objectreference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefinedObject
		//

		public void _init ()
		{
			m_ExternalObjectReference = null;
			m_objectreference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinedObject

		// counter of all nodes associated with syntax rule DefinedObject
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinedObject
		[DataMember (Name = "m_ExternalObjectReference")] public ExternalObjectReference m_ExternalObjectReference { get; private set; }
		[DataMember (Name = "m_objectreference_token")] public objectreference_token m_objectreference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinedObject

		// delegate function (callback) prototype associated with syntax rule DefinedObject
		public delegate bool DefinedObject_Callback (SyntaxTreeCallbackReason reason, DefinedObject.production_kind kind, DefinedObject p_DefinedObject);

		// event associated with syntax rule DefinedObject
		public event DefinedObject_Callback DefinedObject_Event;

		// event trigger associated with syntax rule DefinedObject
		public bool Raise_DefinedObject_Event (SyntaxTreeCallbackReason reason, DefinedObject.production_kind kind, DefinedObject p_DefinedObject)
		{
			bool? status = DefinedObject_Event?.Invoke (reason, kind, p_DefinedObject);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinedObject
		//
		// traverse syntax tree node associated with any production of syntax rule DefinedObject
		//

		public void Traverse (DefinedObject p_DefinedObject)
		{
			if (p_DefinedObject.isLocked())
				return;
			p_DefinedObject.dolock();
			DefinedObject.production_kind kind = (DefinedObject.production_kind) p_DefinedObject.kind;
			p_DefinedObject.turn_reset ();
			if (Raise_DefinedObject_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinedObject))
			switch (kind)
			{
				case DefinedObject.production_kind.g_DefinedObject_1:
					// traverse syntax tree node associated with production
					// DefinedObject: ExternalObjectReference

					if (Raise_DefinedObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObject))
						Traverse (p_DefinedObject.m_ExternalObjectReference);
					p_DefinedObject.turn_inc ();
					Raise_DefinedObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObject);
				break;
				case DefinedObject.production_kind.g_DefinedObject_2:
					// traverse syntax tree node associated with production
					// DefinedObject: objectreference-token

					if (Raise_DefinedObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObject))
						Traverse (p_DefinedObject.m_objectreference_token);
					p_DefinedObject.turn_inc ();
					Raise_DefinedObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObject);
				break;
			}
			Raise_DefinedObject_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinedObject);
			p_DefinedObject.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedObject
		//

		public void TraverseCommon (DefinedObject p_DefinedObject)
		{
			DefinedObject.production_kind kind = (DefinedObject.production_kind) p_DefinedObject.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinedObject))
			switch (kind)
			{
				case DefinedObject.production_kind.g_DefinedObject_1:
					// traverse syntax tree node associated with production
					// DefinedObject: ExternalObjectReference

						TraverseCommon (p_DefinedObject.m_ExternalObjectReference);
				break;
				case DefinedObject.production_kind.g_DefinedObject_2:
					// traverse syntax tree node associated with production
					// DefinedObject: objectreference-token

						TraverseCommon (p_DefinedObject.m_objectreference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinedObject);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinedObject

		//
		// create syntax tree node associated with production
		// DefinedObject: ExternalObjectReference

		//

		public DefinedObject DefinedObject_1 (ExternalObjectReference p_ExternalObjectReference)
		{
			DefinedObject p_DefinedObject_ref = new DefinedObject(p_ExternalObjectReference);
			p_ExternalObjectReference.parent = p_DefinedObject_ref;
			Raise_DefinedObject_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedObject.production_kind.g_DefinedObject_1, p_DefinedObject_ref);
			return p_DefinedObject_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinedObject: objectreference-token

		//

		public DefinedObject DefinedObject_2 (objectreference_token p_objectreference_token)
		{
			DefinedObject p_DefinedObject_ref = new DefinedObject(p_objectreference_token);
			p_objectreference_token.parent = p_DefinedObject_ref;
			Raise_DefinedObject_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedObject.production_kind.g_DefinedObject_2, p_DefinedObject_ref);
			return p_DefinedObject_ref;
		}
		#endregion
	};
}
