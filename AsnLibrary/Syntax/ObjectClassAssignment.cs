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
	// class associated with syntax rule ObjectClassAssignment
	//

	[DataContract]
	public class	ObjectClassAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectClassAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectClassAssignment
		{
			g_ObjectClassAssignment_1 = 1,	// objectclassreference-token "::=" ObjectClass

		};
		#endregion
		#region production markers associated with the syntax rule ObjectClassAssignment

		// markers associated with production: ObjectClassAssignment -> objectclassreference-token "::=" ObjectClass

		public enum production_marker_1 : ushort
		{
			m_objectclassreference_token,
			m_ObjectClass,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectClassAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectClassAssignment

		//
		// Constructor associated with the following production(s)
		// ObjectClassAssignment -> objectclassreference-token "::=" ObjectClass

		//

		public ObjectClassAssignment (objectclassreference_token p_objectclassreference_token, SyntaxTreeToken p_token, ObjectClass p_ObjectClass) : base ((uint) ProductionID._ObjectClassAssignment_ID, (uint) production_kind.g_ObjectClassAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_objectclassreference_token = p_objectclassreference_token;
			children[1] = m_assignment_sign = p_token;
			children[2] = m_ObjectClass = p_ObjectClass;
		}

		public ObjectClassAssignment () { }

		// Copy constructor

		public ObjectClassAssignment (ObjectClassAssignment p_ObjectClassAssignment) : base (p_ObjectClassAssignment.id, p_ObjectClassAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectClassAssignment.appInfo;
			switch ((production_kind) p_ObjectClassAssignment.kind)
			{
				case production_kind.g_ObjectClassAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_objectclassreference_token = (p_ObjectClassAssignment.m_objectclassreference_token != null) ? new objectclassreference_token (p_ObjectClassAssignment.m_objectclassreference_token) : null) != null) m_objectclassreference_token.parent = this;
					if ((children [1] = m_assignment_sign = (p_ObjectClassAssignment.m_assignment_sign != null) ? new SyntaxTreeToken (p_ObjectClassAssignment.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [2] = m_ObjectClass = (p_ObjectClassAssignment.m_ObjectClass != null) ? new ObjectClass (p_ObjectClassAssignment.m_ObjectClass) : null) != null) m_ObjectClass.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectClassAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectClassAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_objectclassreference_token?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_ObjectClass?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectClassAssignment

		// Content changing function(s) associated with production(s) of syntax rule ObjectClassAssignment

		//
		// Content changing function associated with following production(s)
		// ObjectClassAssignment -> objectclassreference-token "::=" ObjectClass

		//

		public void change(objectclassreference_token p_objectclassreference_token, SyntaxTreeToken p_token, ObjectClass p_ObjectClass)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectClassAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_objectclassreference_token = p_objectclassreference_token;
			children [1] = m_assignment_sign = p_token;
			children [2] = m_ObjectClass = p_ObjectClass;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectClassAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_objectclassreference_token != null) && m_objectclassreference_token.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_ObjectClass != null) && m_ObjectClass.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectClassAssignment

		//
		// emit production tree node associated with any production of syntax rule ObjectClassAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectClassAssignment_1:
					// emit syntax tree node associated with production
					// ObjectClassAssignment: objectclassreference-token "::=" ObjectClass

					s += m_objectclassreference_token.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_ObjectClass.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectClassAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectClassAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectClassAssignment_1:
					// emit syntax tree node associated with production
					// ObjectClassAssignment: objectclassreference-token "::=" ObjectClass

					s += m_objectclassreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += m_ObjectClass.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectClassAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectClassAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectClassAssignment.production_kind kind = (ObjectClassAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectClassAssignment.production_kind.g_ObjectClassAssignment_1:
					// traverse syntax tree node associated with production
					// ObjectClassAssignment: objectclassreference-token "::=" ObjectClass

						m_objectclassreference_token.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_ObjectClass.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_objectclassreference_token?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_ObjectClass?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectClassAssignment
		//

		public void _init ()
		{
			m_objectclassreference_token = null;
			m_assignment_sign = null;
			m_ObjectClass = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectClassAssignment

		// counter of all nodes associated with syntax rule ObjectClassAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectClassAssignment
		[DataMember (Name = "m_objectclassreference_token")] public objectclassreference_token m_objectclassreference_token { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_ObjectClass")] public ObjectClass m_ObjectClass { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectClassAssignment

		// delegate function (callback) prototype associated with syntax rule ObjectClassAssignment
		public delegate bool ObjectClassAssignment_Callback (SyntaxTreeCallbackReason reason, ObjectClassAssignment.production_kind kind, ObjectClassAssignment p_ObjectClassAssignment);

		// event associated with syntax rule ObjectClassAssignment
		public event ObjectClassAssignment_Callback ObjectClassAssignment_Event;

		// event trigger associated with syntax rule ObjectClassAssignment
		public bool Raise_ObjectClassAssignment_Event (SyntaxTreeCallbackReason reason, ObjectClassAssignment.production_kind kind, ObjectClassAssignment p_ObjectClassAssignment)
		{
			bool? status = ObjectClassAssignment_Event?.Invoke (reason, kind, p_ObjectClassAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectClassAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectClassAssignment
		//

		public void Traverse (ObjectClassAssignment p_ObjectClassAssignment)
		{
			if (p_ObjectClassAssignment.isLocked())
				return;
			p_ObjectClassAssignment.dolock();
			ObjectClassAssignment.production_kind kind = (ObjectClassAssignment.production_kind) p_ObjectClassAssignment.kind;
			p_ObjectClassAssignment.turn_reset ();
			if (Raise_ObjectClassAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectClassAssignment))
			switch (kind)
			{
				case ObjectClassAssignment.production_kind.g_ObjectClassAssignment_1:
					// traverse syntax tree node associated with production
					// ObjectClassAssignment: objectclassreference-token "::=" ObjectClass

					if (Raise_ObjectClassAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClassAssignment))
						Traverse (p_ObjectClassAssignment.m_objectclassreference_token);
					p_ObjectClassAssignment.turn_inc ();
					if (Raise_ObjectClassAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClassAssignment))
						Traverse (p_ObjectClassAssignment.m_ObjectClass);
					p_ObjectClassAssignment.turn_inc ();
					Raise_ObjectClassAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClassAssignment);
				break;
			}
			Raise_ObjectClassAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectClassAssignment);
			p_ObjectClassAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectClassAssignment
		//

		public void TraverseCommon (ObjectClassAssignment p_ObjectClassAssignment)
		{
			ObjectClassAssignment.production_kind kind = (ObjectClassAssignment.production_kind) p_ObjectClassAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectClassAssignment))
			switch (kind)
			{
				case ObjectClassAssignment.production_kind.g_ObjectClassAssignment_1:
					// traverse syntax tree node associated with production
					// ObjectClassAssignment: objectclassreference-token "::=" ObjectClass

						TraverseCommon (p_ObjectClassAssignment.m_objectclassreference_token);
						TraverseCommon (p_ObjectClassAssignment.m_assignment_sign);
						TraverseCommon (p_ObjectClassAssignment.m_ObjectClass);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectClassAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectClassAssignment

		//
		// create syntax tree node associated with production
		// ObjectClassAssignment: objectclassreference-token "::=" ObjectClass

		//

		public ObjectClassAssignment ObjectClassAssignment_1 (objectclassreference_token p_objectclassreference_token, SyntaxTreeToken p_token, ObjectClass p_ObjectClass)
		{
			ObjectClassAssignment p_ObjectClassAssignment_ref = new ObjectClassAssignment(p_objectclassreference_token, p_token, p_ObjectClass);
			p_objectclassreference_token.parent = p_ObjectClassAssignment_ref;
			p_token.parent = p_ObjectClassAssignment_ref;
			p_ObjectClass.parent = p_ObjectClassAssignment_ref;
			Raise_ObjectClassAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectClassAssignment.production_kind.g_ObjectClassAssignment_1, p_ObjectClassAssignment_ref);
			return p_ObjectClassAssignment_ref;
		}
		#endregion
	};
}
