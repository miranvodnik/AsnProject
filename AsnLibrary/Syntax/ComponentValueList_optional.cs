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
	// class associated with syntax rule ComponentValueList-optional
	//

	[DataContract]
	public class	ComponentValueList_optional : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ComponentValueList-optional
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ComponentValueList-optional
		{
			g_ComponentValueList_optional_1 = 1,	// %empty

			g_ComponentValueList_optional_2 = 2,	// ComponentValueList

		};
		#endregion
		#region production markers associated with the syntax rule ComponentValueList-optional

		// markers associated with production: ComponentValueList-optional -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: ComponentValueList-optional -> ComponentValueList

		public enum production_marker_2 : ushort
		{
			m_ComponentValueList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ComponentValueList-optional

		// Constructor declaration(s) associated with production(s) of syntax rule ComponentValueList-optional

		//
		// Constructor associated with the following production(s)
		// ComponentValueList-optional -> %empty

		//

		public ComponentValueList_optional () : base ((uint) ProductionID._ComponentValueList_optional_ID, (uint) production_kind.g_ComponentValueList_optional_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// ComponentValueList-optional -> ComponentValueList

		//

		public ComponentValueList_optional (ComponentValueList p_ComponentValueList) : base ((uint) ProductionID._ComponentValueList_optional_ID, (uint) production_kind.g_ComponentValueList_optional_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ComponentValueList = p_ComponentValueList;
		}

		// Copy constructor

		public ComponentValueList_optional (ComponentValueList_optional p_ComponentValueList_optional) : base (p_ComponentValueList_optional.id, p_ComponentValueList_optional.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ComponentValueList_optional.appInfo;
			switch ((production_kind) p_ComponentValueList_optional.kind)
			{
				case production_kind.g_ComponentValueList_optional_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_ComponentValueList_optional_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ComponentValueList = (p_ComponentValueList_optional.m_ComponentValueList != null) ? new ComponentValueList (p_ComponentValueList_optional.m_ComponentValueList) : null) != null) m_ComponentValueList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ComponentValueList_optional" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ComponentValueList_optional (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ComponentValueList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ComponentValueList-optional

		// Content changing function(s) associated with production(s) of syntax rule ComponentValueList-optional

		//
		// Content changing function associated with following production(s)
		// ComponentValueList-optional -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentValueList_optional_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ComponentValueList-optional -> ComponentValueList

		//

		public void change(ComponentValueList p_ComponentValueList)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentValueList_optional_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ComponentValueList = p_ComponentValueList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ComponentValueList-optional
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ComponentValueList != null) && m_ComponentValueList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ComponentValueList-optional

		//
		// emit production tree node associated with any production of syntax rule ComponentValueList-optional
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ComponentValueList_optional_1:
					// emit syntax tree node associated with production
					// ComponentValueList-optional: %empty

				break;
				case production_kind.g_ComponentValueList_optional_2:
					// emit syntax tree node associated with production
					// ComponentValueList-optional: ComponentValueList

					s += m_ComponentValueList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ComponentValueList-optional
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ComponentValueList_optional (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ComponentValueList_optional_1:
					// emit syntax tree node associated with production
					// ComponentValueList-optional: %empty

				break;
				case production_kind.g_ComponentValueList_optional_2:
					// emit syntax tree node associated with production
					// ComponentValueList-optional: ComponentValueList

					s += m_ComponentValueList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ComponentValueList-optional

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentValueList-optional with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ComponentValueList_optional.production_kind kind = (ComponentValueList_optional.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ComponentValueList_optional.production_kind.g_ComponentValueList_optional_1:
					// traverse syntax tree node associated with production
					// ComponentValueList-optional: %empty

				break;
				case ComponentValueList_optional.production_kind.g_ComponentValueList_optional_2:
					// traverse syntax tree node associated with production
					// ComponentValueList-optional: ComponentValueList

						m_ComponentValueList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ComponentValueList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ComponentValueList-optional
		//

		public void _init ()
		{
			m_ComponentValueList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ComponentValueList-optional

		// counter of all nodes associated with syntax rule ComponentValueList-optional
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ComponentValueList-optional
		[DataMember (Name = "m_ComponentValueList")] public ComponentValueList m_ComponentValueList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ComponentValueList-optional

		// delegate function (callback) prototype associated with syntax rule ComponentValueList-optional
		public delegate bool ComponentValueList_optional_Callback (SyntaxTreeCallbackReason reason, ComponentValueList_optional.production_kind kind, ComponentValueList_optional p_ComponentValueList_optional);

		// event associated with syntax rule ComponentValueList-optional
		public event ComponentValueList_optional_Callback ComponentValueList_optional_Event;

		// event trigger associated with syntax rule ComponentValueList-optional
		public bool Raise_ComponentValueList_optional_Event (SyntaxTreeCallbackReason reason, ComponentValueList_optional.production_kind kind, ComponentValueList_optional p_ComponentValueList_optional)
		{
			bool? status = ComponentValueList_optional_Event?.Invoke (reason, kind, p_ComponentValueList_optional);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ComponentValueList-optional
		//
		// traverse syntax tree node associated with any production of syntax rule ComponentValueList-optional
		//

		public void Traverse (ComponentValueList_optional p_ComponentValueList_optional)
		{
			if (p_ComponentValueList_optional.isLocked())
				return;
			p_ComponentValueList_optional.dolock();
			ComponentValueList_optional.production_kind kind = (ComponentValueList_optional.production_kind) p_ComponentValueList_optional.kind;
			p_ComponentValueList_optional.turn_reset ();
			if (Raise_ComponentValueList_optional_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ComponentValueList_optional))
			switch (kind)
			{
				case ComponentValueList_optional.production_kind.g_ComponentValueList_optional_1:
					// traverse syntax tree node associated with production
					// ComponentValueList-optional: %empty

				break;
				case ComponentValueList_optional.production_kind.g_ComponentValueList_optional_2:
					// traverse syntax tree node associated with production
					// ComponentValueList-optional: ComponentValueList

					if (Raise_ComponentValueList_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentValueList_optional))
						Traverse (p_ComponentValueList_optional.m_ComponentValueList);
					p_ComponentValueList_optional.turn_inc ();
					Raise_ComponentValueList_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentValueList_optional);
				break;
			}
			Raise_ComponentValueList_optional_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ComponentValueList_optional);
			p_ComponentValueList_optional.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentValueList-optional
		//

		public void TraverseCommon (ComponentValueList_optional p_ComponentValueList_optional)
		{
			ComponentValueList_optional.production_kind kind = (ComponentValueList_optional.production_kind) p_ComponentValueList_optional.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ComponentValueList_optional))
			switch (kind)
			{
				case ComponentValueList_optional.production_kind.g_ComponentValueList_optional_1:
					// traverse syntax tree node associated with production
					// ComponentValueList-optional: %empty

				break;
				case ComponentValueList_optional.production_kind.g_ComponentValueList_optional_2:
					// traverse syntax tree node associated with production
					// ComponentValueList-optional: ComponentValueList

						TraverseCommon (p_ComponentValueList_optional.m_ComponentValueList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ComponentValueList_optional);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ComponentValueList-optional

		//
		// create syntax tree node associated with production
		// ComponentValueList-optional: %empty

		//

		public ComponentValueList_optional ComponentValueList_optional_1 ()
		{
			ComponentValueList_optional p_ComponentValueList_optional_ref = new ComponentValueList_optional();
			Raise_ComponentValueList_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentValueList_optional.production_kind.g_ComponentValueList_optional_1, p_ComponentValueList_optional_ref);
			return p_ComponentValueList_optional_ref;
		}

		//
		// create syntax tree node associated with production
		// ComponentValueList-optional: ComponentValueList

		//

		public ComponentValueList_optional ComponentValueList_optional_2 (ComponentValueList p_ComponentValueList)
		{
			ComponentValueList_optional p_ComponentValueList_optional_ref = new ComponentValueList_optional(p_ComponentValueList);
			p_ComponentValueList.parent = p_ComponentValueList_optional_ref;
			Raise_ComponentValueList_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentValueList_optional.production_kind.g_ComponentValueList_optional_2, p_ComponentValueList_optional_ref);
			return p_ComponentValueList_optional_ref;
		}
		#endregion
	};
}
