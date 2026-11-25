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
	// class associated with syntax rule ParameterizedObject
	//

	[DataContract]
	public class	ParameterizedObject : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedObject
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedObject
		{
			g_ParameterizedObject_1 = 1,	// DefinedObject ActualParameterList

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedObject

		// markers associated with production: ParameterizedObject -> DefinedObject ActualParameterList

		public enum production_marker_1 : ushort
		{
			m_DefinedObject,
			m_ActualParameterList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedObject

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedObject

		//
		// Constructor associated with the following production(s)
		// ParameterizedObject -> DefinedObject ActualParameterList

		//

		public ParameterizedObject (DefinedObject p_DefinedObject, ActualParameterList p_ActualParameterList) : base ((uint) ProductionID._ParameterizedObject_ID, (uint) production_kind.g_ParameterizedObject_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DefinedObject = p_DefinedObject;
			children[1] = m_ActualParameterList = p_ActualParameterList;
		}

		public ParameterizedObject () { }

		// Copy constructor

		public ParameterizedObject (ParameterizedObject p_ParameterizedObject) : base (p_ParameterizedObject.id, p_ParameterizedObject.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedObject.appInfo;
			switch ((production_kind) p_ParameterizedObject.kind)
			{
				case production_kind.g_ParameterizedObject_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DefinedObject = (p_ParameterizedObject.m_DefinedObject != null) ? new DefinedObject (p_ParameterizedObject.m_DefinedObject) : null) != null) m_DefinedObject.parent = this;
					if ((children [1] = m_ActualParameterList = (p_ParameterizedObject.m_ActualParameterList != null) ? new ActualParameterList (p_ParameterizedObject.m_ActualParameterList) : null) != null) m_ActualParameterList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedObject" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedObject (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DefinedObject?.Dispose ();
			m_ActualParameterList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedObject

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedObject

		//
		// Content changing function associated with following production(s)
		// ParameterizedObject -> DefinedObject ActualParameterList

		//

		public void change(DefinedObject p_DefinedObject, ActualParameterList p_ActualParameterList)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedObject_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DefinedObject = p_DefinedObject;
			children [1] = m_ActualParameterList = p_ActualParameterList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedObject
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DefinedObject != null) && m_DefinedObject.checkInclusion (element) ||
				(m_ActualParameterList != null) && m_ActualParameterList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterizedObject

		//
		// emit production tree node associated with any production of syntax rule ParameterizedObject
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedObject_1:
					// emit syntax tree node associated with production
					// ParameterizedObject: DefinedObject ActualParameterList

					s += m_DefinedObject.Emit (depth - 1);
					s += " ";
					s += m_ActualParameterList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParameterizedObject
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedObject (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedObject_1:
					// emit syntax tree node associated with production
					// ParameterizedObject: DefinedObject ActualParameterList

					s += m_DefinedObject.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ActualParameterList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedObject

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObject with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedObject.production_kind kind = (ParameterizedObject.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedObject.production_kind.g_ParameterizedObject_1:
					// traverse syntax tree node associated with production
					// ParameterizedObject: DefinedObject ActualParameterList

						m_DefinedObject.Visit (visitor, appData);
						m_ActualParameterList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DefinedObject?.reparent (this);
			m_ActualParameterList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterizedObject
		//

		public void _init ()
		{
			m_DefinedObject = null;
			m_ActualParameterList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedObject

		// counter of all nodes associated with syntax rule ParameterizedObject
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedObject
		[DataMember (Name = "m_DefinedObject")] public DefinedObject m_DefinedObject { get; private set; }
		[DataMember (Name = "m_ActualParameterList")] public ActualParameterList m_ActualParameterList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedObject

		// delegate function (callback) prototype associated with syntax rule ParameterizedObject
		public delegate bool ParameterizedObject_Callback (SyntaxTreeCallbackReason reason, ParameterizedObject.production_kind kind, ParameterizedObject p_ParameterizedObject);

		// event associated with syntax rule ParameterizedObject
		public event ParameterizedObject_Callback ParameterizedObject_Event;

		// event trigger associated with syntax rule ParameterizedObject
		public bool Raise_ParameterizedObject_Event (SyntaxTreeCallbackReason reason, ParameterizedObject.production_kind kind, ParameterizedObject p_ParameterizedObject)
		{
			bool? status = ParameterizedObject_Event?.Invoke (reason, kind, p_ParameterizedObject);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedObject
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObject
		//

		public void Traverse (ParameterizedObject p_ParameterizedObject)
		{
			if (p_ParameterizedObject.isLocked())
				return;
			p_ParameterizedObject.dolock();
			ParameterizedObject.production_kind kind = (ParameterizedObject.production_kind) p_ParameterizedObject.kind;
			p_ParameterizedObject.turn_reset ();
			if (Raise_ParameterizedObject_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedObject))
			switch (kind)
			{
				case ParameterizedObject.production_kind.g_ParameterizedObject_1:
					// traverse syntax tree node associated with production
					// ParameterizedObject: DefinedObject ActualParameterList

					if (Raise_ParameterizedObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObject))
						Traverse (p_ParameterizedObject.m_DefinedObject);
					p_ParameterizedObject.turn_inc ();
					if (Raise_ParameterizedObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObject))
						Traverse (p_ParameterizedObject.m_ActualParameterList);
					p_ParameterizedObject.turn_inc ();
					Raise_ParameterizedObject_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObject);
				break;
			}
			Raise_ParameterizedObject_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedObject);
			p_ParameterizedObject.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObject
		//

		public void TraverseCommon (ParameterizedObject p_ParameterizedObject)
		{
			ParameterizedObject.production_kind kind = (ParameterizedObject.production_kind) p_ParameterizedObject.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedObject))
			switch (kind)
			{
				case ParameterizedObject.production_kind.g_ParameterizedObject_1:
					// traverse syntax tree node associated with production
					// ParameterizedObject: DefinedObject ActualParameterList

						TraverseCommon (p_ParameterizedObject.m_DefinedObject);
						TraverseCommon (p_ParameterizedObject.m_ActualParameterList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedObject);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedObject

		//
		// create syntax tree node associated with production
		// ParameterizedObject: DefinedObject ActualParameterList

		//

		public ParameterizedObject ParameterizedObject_1 (DefinedObject p_DefinedObject, ActualParameterList p_ActualParameterList)
		{
			ParameterizedObject p_ParameterizedObject_ref = new ParameterizedObject(p_DefinedObject, p_ActualParameterList);
			p_DefinedObject.parent = p_ParameterizedObject_ref;
			p_ActualParameterList.parent = p_ParameterizedObject_ref;
			Raise_ParameterizedObject_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedObject.production_kind.g_ParameterizedObject_1, p_ParameterizedObject_ref);
			return p_ParameterizedObject_ref;
		}
		#endregion
	};
}
