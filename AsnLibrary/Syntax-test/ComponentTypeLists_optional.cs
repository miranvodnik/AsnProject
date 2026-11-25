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
	// class associated with syntax rule ComponentTypeLists-optional
	//

	[DataContract]
	public class	ComponentTypeLists_optional : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ComponentTypeLists-optional
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ComponentTypeLists-optional
		{
			g_ComponentTypeLists_optional_1 = 1,	// %empty

			g_ComponentTypeLists_optional_2 = 2,	// ComponentTypeLists

		};
		#endregion
		#region production markers associated with the syntax rule ComponentTypeLists-optional

		// markers associated with production: ComponentTypeLists-optional -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: ComponentTypeLists-optional -> ComponentTypeLists

		public enum production_marker_2 : ushort
		{
			m_ComponentTypeLists,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ComponentTypeLists-optional

		// Constructor declaration(s) associated with production(s) of syntax rule ComponentTypeLists-optional

		//
		// Constructor associated with the following production(s)
		// ComponentTypeLists-optional -> %empty

		//

		public ComponentTypeLists_optional () : base ((uint) ProductionID._ComponentTypeLists_optional_ID, (uint) production_kind.g_ComponentTypeLists_optional_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// ComponentTypeLists-optional -> ComponentTypeLists

		//

		public ComponentTypeLists_optional (ComponentTypeLists p_ComponentTypeLists) : base ((uint) ProductionID._ComponentTypeLists_optional_ID, (uint) production_kind.g_ComponentTypeLists_optional_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ComponentTypeLists = p_ComponentTypeLists;
		}

		// Copy constructor

		public ComponentTypeLists_optional (ComponentTypeLists_optional p_ComponentTypeLists_optional) : base (p_ComponentTypeLists_optional.id, p_ComponentTypeLists_optional.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ComponentTypeLists_optional.appInfo;
			switch ((production_kind) p_ComponentTypeLists_optional.kind)
			{
				case production_kind.g_ComponentTypeLists_optional_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_ComponentTypeLists_optional_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ComponentTypeLists = (p_ComponentTypeLists_optional.m_ComponentTypeLists != null) ? new ComponentTypeLists (p_ComponentTypeLists_optional.m_ComponentTypeLists) : null) != null) m_ComponentTypeLists.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ComponentTypeLists_optional" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ComponentTypeLists_optional (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ComponentTypeLists?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ComponentTypeLists-optional

		// Content changing function(s) associated with production(s) of syntax rule ComponentTypeLists-optional

		//
		// Content changing function associated with following production(s)
		// ComponentTypeLists-optional -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentTypeLists_optional_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ComponentTypeLists-optional -> ComponentTypeLists

		//

		public void change(ComponentTypeLists p_ComponentTypeLists)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentTypeLists_optional_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ComponentTypeLists = p_ComponentTypeLists;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ComponentTypeLists-optional
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ComponentTypeLists != null) && m_ComponentTypeLists.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ComponentTypeLists-optional

		//
		// emit production tree node associated with any production of syntax rule ComponentTypeLists-optional
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ComponentTypeLists_optional_1:
					// emit syntax tree node associated with production
					// ComponentTypeLists-optional: %empty

				break;
				case production_kind.g_ComponentTypeLists_optional_2:
					// emit syntax tree node associated with production
					// ComponentTypeLists-optional: ComponentTypeLists

					s += m_ComponentTypeLists.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ComponentTypeLists-optional
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ComponentTypeLists_optional (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ComponentTypeLists_optional_1:
					// emit syntax tree node associated with production
					// ComponentTypeLists-optional: %empty

				break;
				case production_kind.g_ComponentTypeLists_optional_2:
					// emit syntax tree node associated with production
					// ComponentTypeLists-optional: ComponentTypeLists

					s += m_ComponentTypeLists.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ComponentTypeLists-optional

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentTypeLists-optional with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ComponentTypeLists_optional.production_kind kind = (ComponentTypeLists_optional.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ComponentTypeLists_optional.production_kind.g_ComponentTypeLists_optional_1:
					// traverse syntax tree node associated with production
					// ComponentTypeLists-optional: %empty

				break;
				case ComponentTypeLists_optional.production_kind.g_ComponentTypeLists_optional_2:
					// traverse syntax tree node associated with production
					// ComponentTypeLists-optional: ComponentTypeLists

						m_ComponentTypeLists.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ComponentTypeLists?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ComponentTypeLists-optional
		//

		public void _init ()
		{
			m_ComponentTypeLists = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ComponentTypeLists-optional

		// counter of all nodes associated with syntax rule ComponentTypeLists-optional
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ComponentTypeLists-optional
		[DataMember (Name = "m_ComponentTypeLists")] public ComponentTypeLists m_ComponentTypeLists { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ComponentTypeLists-optional

		// delegate function (callback) prototype associated with syntax rule ComponentTypeLists-optional
		public delegate bool ComponentTypeLists_optional_Callback (SyntaxTreeCallbackReason reason, ComponentTypeLists_optional.production_kind kind, ComponentTypeLists_optional p_ComponentTypeLists_optional);

		// event associated with syntax rule ComponentTypeLists-optional
		public event ComponentTypeLists_optional_Callback ComponentTypeLists_optional_Event;

		// event trigger associated with syntax rule ComponentTypeLists-optional
		public bool Raise_ComponentTypeLists_optional_Event (SyntaxTreeCallbackReason reason, ComponentTypeLists_optional.production_kind kind, ComponentTypeLists_optional p_ComponentTypeLists_optional)
		{
			bool? status = ComponentTypeLists_optional_Event?.Invoke (reason, kind, p_ComponentTypeLists_optional);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ComponentTypeLists-optional
		//
		// traverse syntax tree node associated with any production of syntax rule ComponentTypeLists-optional
		//

		public void Traverse (ComponentTypeLists_optional p_ComponentTypeLists_optional)
		{
			if (p_ComponentTypeLists_optional.isLocked())
				return;
			p_ComponentTypeLists_optional.dolock();
			ComponentTypeLists_optional.production_kind kind = (ComponentTypeLists_optional.production_kind) p_ComponentTypeLists_optional.kind;
			p_ComponentTypeLists_optional.turn_reset ();
			if (Raise_ComponentTypeLists_optional_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ComponentTypeLists_optional))
			switch (kind)
			{
				case ComponentTypeLists_optional.production_kind.g_ComponentTypeLists_optional_1:
					// traverse syntax tree node associated with production
					// ComponentTypeLists-optional: %empty

				break;
				case ComponentTypeLists_optional.production_kind.g_ComponentTypeLists_optional_2:
					// traverse syntax tree node associated with production
					// ComponentTypeLists-optional: ComponentTypeLists

					if (Raise_ComponentTypeLists_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists_optional))
						Traverse (p_ComponentTypeLists_optional.m_ComponentTypeLists);
					p_ComponentTypeLists_optional.turn_inc ();
					Raise_ComponentTypeLists_optional_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists_optional);
				break;
			}
			Raise_ComponentTypeLists_optional_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ComponentTypeLists_optional);
			p_ComponentTypeLists_optional.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentTypeLists-optional
		//

		public void TraverseCommon (ComponentTypeLists_optional p_ComponentTypeLists_optional)
		{
			ComponentTypeLists_optional.production_kind kind = (ComponentTypeLists_optional.production_kind) p_ComponentTypeLists_optional.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ComponentTypeLists_optional))
			switch (kind)
			{
				case ComponentTypeLists_optional.production_kind.g_ComponentTypeLists_optional_1:
					// traverse syntax tree node associated with production
					// ComponentTypeLists-optional: %empty

				break;
				case ComponentTypeLists_optional.production_kind.g_ComponentTypeLists_optional_2:
					// traverse syntax tree node associated with production
					// ComponentTypeLists-optional: ComponentTypeLists

						TraverseCommon (p_ComponentTypeLists_optional.m_ComponentTypeLists);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ComponentTypeLists_optional);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ComponentTypeLists-optional

		//
		// create syntax tree node associated with production
		// ComponentTypeLists-optional: %empty

		//

		public ComponentTypeLists_optional ComponentTypeLists_optional_1 ()
		{
			ComponentTypeLists_optional p_ComponentTypeLists_optional_ref = new ComponentTypeLists_optional();
			Raise_ComponentTypeLists_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentTypeLists_optional.production_kind.g_ComponentTypeLists_optional_1, p_ComponentTypeLists_optional_ref);
			return p_ComponentTypeLists_optional_ref;
		}

		//
		// create syntax tree node associated with production
		// ComponentTypeLists-optional: ComponentTypeLists

		//

		public ComponentTypeLists_optional ComponentTypeLists_optional_2 (ComponentTypeLists p_ComponentTypeLists)
		{
			ComponentTypeLists_optional p_ComponentTypeLists_optional_ref = new ComponentTypeLists_optional(p_ComponentTypeLists);
			p_ComponentTypeLists.parent = p_ComponentTypeLists_optional_ref;
			Raise_ComponentTypeLists_optional_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentTypeLists_optional.production_kind.g_ComponentTypeLists_optional_2, p_ComponentTypeLists_optional_ref);
			return p_ComponentTypeLists_optional_ref;
		}
		#endregion
	};
}
