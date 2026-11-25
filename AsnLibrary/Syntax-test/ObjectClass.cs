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
	// class associated with syntax rule ObjectClass
	//

	[DataContract]
	public class	ObjectClass : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectClass
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectClass
		{
			g_ObjectClass_1 = 1,	// DefinedObjectClass

			g_ObjectClass_2 = 2,	// ObjectClassDefn

			g_ObjectClass_3 = 3,	// ParameterizedObjectClass

		};
		#endregion
		#region production markers associated with the syntax rule ObjectClass

		// markers associated with production: ObjectClass -> DefinedObjectClass

		public enum production_marker_1 : ushort
		{
			m_DefinedObjectClass,
			final
		};

		// markers associated with production: ObjectClass -> ObjectClassDefn

		public enum production_marker_2 : ushort
		{
			m_ObjectClassDefn,
			final
		};

		// markers associated with production: ObjectClass -> ParameterizedObjectClass

		public enum production_marker_3 : ushort
		{
			m_ParameterizedObjectClass,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectClass

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectClass

		//
		// Constructor associated with the following production(s)
		// ObjectClass -> DefinedObjectClass

		//

		public ObjectClass (DefinedObjectClass p_DefinedObjectClass) : base ((uint) ProductionID._ObjectClass_ID, (uint) production_kind.g_ObjectClass_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedObjectClass = p_DefinedObjectClass;
		}

		//
		// Constructor associated with the following production(s)
		// ObjectClass -> ObjectClassDefn

		//

		public ObjectClass (ObjectClassDefn p_ObjectClassDefn) : base ((uint) ProductionID._ObjectClass_ID, (uint) production_kind.g_ObjectClass_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectClassDefn = p_ObjectClassDefn;
		}

		//
		// Constructor associated with the following production(s)
		// ObjectClass -> ParameterizedObjectClass

		//

		public ObjectClass (ParameterizedObjectClass p_ParameterizedObjectClass) : base ((uint) ProductionID._ObjectClass_ID, (uint) production_kind.g_ObjectClass_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedObjectClass = p_ParameterizedObjectClass;
		}

		public ObjectClass () { }

		// Copy constructor

		public ObjectClass (ObjectClass p_ObjectClass) : base (p_ObjectClass.id, p_ObjectClass.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectClass.appInfo;
			switch ((production_kind) p_ObjectClass.kind)
			{
				case production_kind.g_ObjectClass_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedObjectClass = (p_ObjectClass.m_DefinedObjectClass != null) ? new DefinedObjectClass (p_ObjectClass.m_DefinedObjectClass) : null) != null) m_DefinedObjectClass.parent = this;
					break;
				case production_kind.g_ObjectClass_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectClassDefn = (p_ObjectClass.m_ObjectClassDefn != null) ? new ObjectClassDefn (p_ObjectClass.m_ObjectClassDefn) : null) != null) m_ObjectClassDefn.parent = this;
					break;
				case production_kind.g_ObjectClass_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedObjectClass = (p_ObjectClass.m_ParameterizedObjectClass != null) ? new ParameterizedObjectClass (p_ObjectClass.m_ParameterizedObjectClass) : null) != null) m_ParameterizedObjectClass.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectClass" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectClass (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DefinedObjectClass?.Dispose ();
			m_ObjectClassDefn?.Dispose ();
			m_ParameterizedObjectClass?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectClass

		// Content changing function(s) associated with production(s) of syntax rule ObjectClass

		//
		// Content changing function associated with following production(s)
		// ObjectClass -> DefinedObjectClass

		//

		public void change(DefinedObjectClass p_DefinedObjectClass)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectClass_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedObjectClass = p_DefinedObjectClass;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjectClass -> ObjectClassDefn

		//

		public void change(ObjectClassDefn p_ObjectClassDefn)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectClass_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectClassDefn = p_ObjectClassDefn;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjectClass -> ParameterizedObjectClass

		//

		public void change(ParameterizedObjectClass p_ParameterizedObjectClass)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectClass_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedObjectClass = p_ParameterizedObjectClass;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectClass
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DefinedObjectClass != null) && m_DefinedObjectClass.checkInclusion (element) ||
				(m_ObjectClassDefn != null) && m_ObjectClassDefn.checkInclusion (element) ||
				(m_ParameterizedObjectClass != null) && m_ParameterizedObjectClass.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectClass

		//
		// emit production tree node associated with any production of syntax rule ObjectClass
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectClass_1:
					// emit syntax tree node associated with production
					// ObjectClass: DefinedObjectClass

					s += m_DefinedObjectClass.Emit (depth - 1);
				break;
				case production_kind.g_ObjectClass_2:
					// emit syntax tree node associated with production
					// ObjectClass: ObjectClassDefn

					s += m_ObjectClassDefn.Emit (depth - 1);
				break;
				case production_kind.g_ObjectClass_3:
					// emit syntax tree node associated with production
					// ObjectClass: ParameterizedObjectClass

					s += m_ParameterizedObjectClass.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectClass
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectClass (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectClass_1:
					// emit syntax tree node associated with production
					// ObjectClass: DefinedObjectClass

					s += m_DefinedObjectClass.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ObjectClass_2:
					// emit syntax tree node associated with production
					// ObjectClass: ObjectClassDefn

					s += m_ObjectClassDefn.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ObjectClass_3:
					// emit syntax tree node associated with production
					// ObjectClass: ParameterizedObjectClass

					s += m_ParameterizedObjectClass.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectClass

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectClass with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectClass.production_kind kind = (ObjectClass.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectClass.production_kind.g_ObjectClass_1:
					// traverse syntax tree node associated with production
					// ObjectClass: DefinedObjectClass

						m_DefinedObjectClass.Visit (visitor, appData);
				break;
				case ObjectClass.production_kind.g_ObjectClass_2:
					// traverse syntax tree node associated with production
					// ObjectClass: ObjectClassDefn

						m_ObjectClassDefn.Visit (visitor, appData);
				break;
				case ObjectClass.production_kind.g_ObjectClass_3:
					// traverse syntax tree node associated with production
					// ObjectClass: ParameterizedObjectClass

						m_ParameterizedObjectClass.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DefinedObjectClass?.reparent (this);
			m_ObjectClassDefn?.reparent (this);
			m_ParameterizedObjectClass?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectClass
		//

		public void _init ()
		{
			m_DefinedObjectClass = null;
			m_ObjectClassDefn = null;
			m_ParameterizedObjectClass = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectClass

		// counter of all nodes associated with syntax rule ObjectClass
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectClass
		[DataMember (Name = "m_DefinedObjectClass")] public DefinedObjectClass m_DefinedObjectClass { get; private set; }
		[DataMember (Name = "m_ObjectClassDefn")] public ObjectClassDefn m_ObjectClassDefn { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectClass")] public ParameterizedObjectClass m_ParameterizedObjectClass { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectClass

		// delegate function (callback) prototype associated with syntax rule ObjectClass
		public delegate bool ObjectClass_Callback (SyntaxTreeCallbackReason reason, ObjectClass.production_kind kind, ObjectClass p_ObjectClass);

		// event associated with syntax rule ObjectClass
		public event ObjectClass_Callback ObjectClass_Event;

		// event trigger associated with syntax rule ObjectClass
		public bool Raise_ObjectClass_Event (SyntaxTreeCallbackReason reason, ObjectClass.production_kind kind, ObjectClass p_ObjectClass)
		{
			bool? status = ObjectClass_Event?.Invoke (reason, kind, p_ObjectClass);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectClass
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectClass
		//

		public void Traverse (ObjectClass p_ObjectClass)
		{
			if (p_ObjectClass.isLocked())
				return;
			p_ObjectClass.dolock();
			ObjectClass.production_kind kind = (ObjectClass.production_kind) p_ObjectClass.kind;
			p_ObjectClass.turn_reset ();
			if (Raise_ObjectClass_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectClass))
			switch (kind)
			{
				case ObjectClass.production_kind.g_ObjectClass_1:
					// traverse syntax tree node associated with production
					// ObjectClass: DefinedObjectClass

					if (Raise_ObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClass))
						Traverse (p_ObjectClass.m_DefinedObjectClass);
					p_ObjectClass.turn_inc ();
					Raise_ObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClass);
				break;
				case ObjectClass.production_kind.g_ObjectClass_2:
					// traverse syntax tree node associated with production
					// ObjectClass: ObjectClassDefn

					if (Raise_ObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClass))
						Traverse (p_ObjectClass.m_ObjectClassDefn);
					p_ObjectClass.turn_inc ();
					Raise_ObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClass);
				break;
				case ObjectClass.production_kind.g_ObjectClass_3:
					// traverse syntax tree node associated with production
					// ObjectClass: ParameterizedObjectClass

					if (Raise_ObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClass))
						Traverse (p_ObjectClass.m_ParameterizedObjectClass);
					p_ObjectClass.turn_inc ();
					Raise_ObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectClass);
				break;
			}
			Raise_ObjectClass_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectClass);
			p_ObjectClass.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectClass
		//

		public void TraverseCommon (ObjectClass p_ObjectClass)
		{
			ObjectClass.production_kind kind = (ObjectClass.production_kind) p_ObjectClass.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectClass))
			switch (kind)
			{
				case ObjectClass.production_kind.g_ObjectClass_1:
					// traverse syntax tree node associated with production
					// ObjectClass: DefinedObjectClass

						TraverseCommon (p_ObjectClass.m_DefinedObjectClass);
				break;
				case ObjectClass.production_kind.g_ObjectClass_2:
					// traverse syntax tree node associated with production
					// ObjectClass: ObjectClassDefn

						TraverseCommon (p_ObjectClass.m_ObjectClassDefn);
				break;
				case ObjectClass.production_kind.g_ObjectClass_3:
					// traverse syntax tree node associated with production
					// ObjectClass: ParameterizedObjectClass

						TraverseCommon (p_ObjectClass.m_ParameterizedObjectClass);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectClass);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectClass

		//
		// create syntax tree node associated with production
		// ObjectClass: DefinedObjectClass

		//

		public ObjectClass ObjectClass_1 (DefinedObjectClass p_DefinedObjectClass)
		{
			ObjectClass p_ObjectClass_ref = new ObjectClass(p_DefinedObjectClass);
			p_DefinedObjectClass.parent = p_ObjectClass_ref;
			Raise_ObjectClass_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectClass.production_kind.g_ObjectClass_1, p_ObjectClass_ref);
			return p_ObjectClass_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectClass: ObjectClassDefn

		//

		public ObjectClass ObjectClass_2 (ObjectClassDefn p_ObjectClassDefn)
		{
			ObjectClass p_ObjectClass_ref = new ObjectClass(p_ObjectClassDefn);
			p_ObjectClassDefn.parent = p_ObjectClass_ref;
			Raise_ObjectClass_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectClass.production_kind.g_ObjectClass_2, p_ObjectClass_ref);
			return p_ObjectClass_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectClass: ParameterizedObjectClass

		//

		public ObjectClass ObjectClass_3 (ParameterizedObjectClass p_ParameterizedObjectClass)
		{
			ObjectClass p_ObjectClass_ref = new ObjectClass(p_ParameterizedObjectClass);
			p_ParameterizedObjectClass.parent = p_ObjectClass_ref;
			Raise_ObjectClass_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectClass.production_kind.g_ObjectClass_3, p_ObjectClass_ref);
			return p_ObjectClass_ref;
		}
		#endregion
	};
}
