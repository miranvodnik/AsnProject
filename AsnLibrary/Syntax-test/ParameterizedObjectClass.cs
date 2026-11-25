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
	// class associated with syntax rule ParameterizedObjectClass
	//

	[DataContract]
	public class	ParameterizedObjectClass : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedObjectClass
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedObjectClass
		{
			g_ParameterizedObjectClass_1 = 1,	// DefinedObjectClass ActualParameterList

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedObjectClass

		// markers associated with production: ParameterizedObjectClass -> DefinedObjectClass ActualParameterList

		public enum production_marker_1 : ushort
		{
			m_DefinedObjectClass,
			m_ActualParameterList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedObjectClass

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedObjectClass

		//
		// Constructor associated with the following production(s)
		// ParameterizedObjectClass -> DefinedObjectClass ActualParameterList

		//

		public ParameterizedObjectClass (DefinedObjectClass p_DefinedObjectClass, ActualParameterList p_ActualParameterList) : base ((uint) ProductionID._ParameterizedObjectClass_ID, (uint) production_kind.g_ParameterizedObjectClass_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DefinedObjectClass = p_DefinedObjectClass;
			children[1] = m_ActualParameterList = p_ActualParameterList;
		}

		public ParameterizedObjectClass () { }

		// Copy constructor

		public ParameterizedObjectClass (ParameterizedObjectClass p_ParameterizedObjectClass) : base (p_ParameterizedObjectClass.id, p_ParameterizedObjectClass.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedObjectClass.appInfo;
			switch ((production_kind) p_ParameterizedObjectClass.kind)
			{
				case production_kind.g_ParameterizedObjectClass_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DefinedObjectClass = (p_ParameterizedObjectClass.m_DefinedObjectClass != null) ? new DefinedObjectClass (p_ParameterizedObjectClass.m_DefinedObjectClass) : null) != null) m_DefinedObjectClass.parent = this;
					if ((children [1] = m_ActualParameterList = (p_ParameterizedObjectClass.m_ActualParameterList != null) ? new ActualParameterList (p_ParameterizedObjectClass.m_ActualParameterList) : null) != null) m_ActualParameterList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedObjectClass" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedObjectClass (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DefinedObjectClass?.Dispose ();
			m_ActualParameterList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedObjectClass

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedObjectClass

		//
		// Content changing function associated with following production(s)
		// ParameterizedObjectClass -> DefinedObjectClass ActualParameterList

		//

		public void change(DefinedObjectClass p_DefinedObjectClass, ActualParameterList p_ActualParameterList)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedObjectClass_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DefinedObjectClass = p_DefinedObjectClass;
			children [1] = m_ActualParameterList = p_ActualParameterList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedObjectClass
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DefinedObjectClass != null) && m_DefinedObjectClass.checkInclusion (element) ||
				(m_ActualParameterList != null) && m_ActualParameterList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterizedObjectClass

		//
		// emit production tree node associated with any production of syntax rule ParameterizedObjectClass
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedObjectClass_1:
					// emit syntax tree node associated with production
					// ParameterizedObjectClass: DefinedObjectClass ActualParameterList

					s += m_DefinedObjectClass.Emit (depth - 1);
					s += " ";
					s += m_ActualParameterList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParameterizedObjectClass
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedObjectClass (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedObjectClass_1:
					// emit syntax tree node associated with production
					// ParameterizedObjectClass: DefinedObjectClass ActualParameterList

					s += m_DefinedObjectClass.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ActualParameterList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedObjectClass

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectClass with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedObjectClass.production_kind kind = (ParameterizedObjectClass.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedObjectClass.production_kind.g_ParameterizedObjectClass_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectClass: DefinedObjectClass ActualParameterList

						m_DefinedObjectClass.Visit (visitor, appData);
						m_ActualParameterList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DefinedObjectClass?.reparent (this);
			m_ActualParameterList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterizedObjectClass
		//

		public void _init ()
		{
			m_DefinedObjectClass = null;
			m_ActualParameterList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedObjectClass

		// counter of all nodes associated with syntax rule ParameterizedObjectClass
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedObjectClass
		[DataMember (Name = "m_DefinedObjectClass")] public DefinedObjectClass m_DefinedObjectClass { get; private set; }
		[DataMember (Name = "m_ActualParameterList")] public ActualParameterList m_ActualParameterList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedObjectClass

		// delegate function (callback) prototype associated with syntax rule ParameterizedObjectClass
		public delegate bool ParameterizedObjectClass_Callback (SyntaxTreeCallbackReason reason, ParameterizedObjectClass.production_kind kind, ParameterizedObjectClass p_ParameterizedObjectClass);

		// event associated with syntax rule ParameterizedObjectClass
		public event ParameterizedObjectClass_Callback ParameterizedObjectClass_Event;

		// event trigger associated with syntax rule ParameterizedObjectClass
		public bool Raise_ParameterizedObjectClass_Event (SyntaxTreeCallbackReason reason, ParameterizedObjectClass.production_kind kind, ParameterizedObjectClass p_ParameterizedObjectClass)
		{
			bool? status = ParameterizedObjectClass_Event?.Invoke (reason, kind, p_ParameterizedObjectClass);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedObjectClass
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectClass
		//

		public void Traverse (ParameterizedObjectClass p_ParameterizedObjectClass)
		{
			if (p_ParameterizedObjectClass.isLocked())
				return;
			p_ParameterizedObjectClass.dolock();
			ParameterizedObjectClass.production_kind kind = (ParameterizedObjectClass.production_kind) p_ParameterizedObjectClass.kind;
			p_ParameterizedObjectClass.turn_reset ();
			if (Raise_ParameterizedObjectClass_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedObjectClass))
			switch (kind)
			{
				case ParameterizedObjectClass.production_kind.g_ParameterizedObjectClass_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectClass: DefinedObjectClass ActualParameterList

					if (Raise_ParameterizedObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectClass))
						Traverse (p_ParameterizedObjectClass.m_DefinedObjectClass);
					p_ParameterizedObjectClass.turn_inc ();
					if (Raise_ParameterizedObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectClass))
						Traverse (p_ParameterizedObjectClass.m_ActualParameterList);
					p_ParameterizedObjectClass.turn_inc ();
					Raise_ParameterizedObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedObjectClass);
				break;
			}
			Raise_ParameterizedObjectClass_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedObjectClass);
			p_ParameterizedObjectClass.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedObjectClass
		//

		public void TraverseCommon (ParameterizedObjectClass p_ParameterizedObjectClass)
		{
			ParameterizedObjectClass.production_kind kind = (ParameterizedObjectClass.production_kind) p_ParameterizedObjectClass.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedObjectClass))
			switch (kind)
			{
				case ParameterizedObjectClass.production_kind.g_ParameterizedObjectClass_1:
					// traverse syntax tree node associated with production
					// ParameterizedObjectClass: DefinedObjectClass ActualParameterList

						TraverseCommon (p_ParameterizedObjectClass.m_DefinedObjectClass);
						TraverseCommon (p_ParameterizedObjectClass.m_ActualParameterList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedObjectClass);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedObjectClass

		//
		// create syntax tree node associated with production
		// ParameterizedObjectClass: DefinedObjectClass ActualParameterList

		//

		public ParameterizedObjectClass ParameterizedObjectClass_1 (DefinedObjectClass p_DefinedObjectClass, ActualParameterList p_ActualParameterList)
		{
			ParameterizedObjectClass p_ParameterizedObjectClass_ref = new ParameterizedObjectClass(p_DefinedObjectClass, p_ActualParameterList);
			p_DefinedObjectClass.parent = p_ParameterizedObjectClass_ref;
			p_ActualParameterList.parent = p_ParameterizedObjectClass_ref;
			Raise_ParameterizedObjectClass_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedObjectClass.production_kind.g_ParameterizedObjectClass_1, p_ParameterizedObjectClass_ref);
			return p_ParameterizedObjectClass_ref;
		}
		#endregion
	};
}
