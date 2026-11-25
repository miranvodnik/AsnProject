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
	// class associated with syntax rule Governor
	//

	[DataContract]
	public class	Governor : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Governor
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Governor
		{
			g_Governor_1 = 1,	// Type

			g_Governor_2 = 2,	// DefinedObjectClass

		};
		#endregion
		#region production markers associated with the syntax rule Governor

		// markers associated with production: Governor -> Type

		public enum production_marker_1 : ushort
		{
			m_Type,
			final
		};

		// markers associated with production: Governor -> DefinedObjectClass

		public enum production_marker_2 : ushort
		{
			m_DefinedObjectClass,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Governor

		// Constructor declaration(s) associated with production(s) of syntax rule Governor

		//
		// Constructor associated with the following production(s)
		// Governor -> Type

		//

		public Governor (Type p_Type) : base ((uint) ProductionID._Governor_ID, (uint) production_kind.g_Governor_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// Governor -> DefinedObjectClass

		//

		public Governor (DefinedObjectClass p_DefinedObjectClass) : base ((uint) ProductionID._Governor_ID, (uint) production_kind.g_Governor_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedObjectClass = p_DefinedObjectClass;
		}

		public Governor () { }

		// Copy constructor

		public Governor (Governor p_Governor) : base (p_Governor.id, p_Governor.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Governor.appInfo;
			switch ((production_kind) p_Governor.kind)
			{
				case production_kind.g_Governor_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Type = (p_Governor.m_Type != null) ? new Type (p_Governor.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_Governor_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedObjectClass = (p_Governor.m_DefinedObjectClass != null) ? new DefinedObjectClass (p_Governor.m_DefinedObjectClass) : null) != null) m_DefinedObjectClass.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Governor" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Governor (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Type?.Dispose ();
			m_DefinedObjectClass?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Governor

		// Content changing function(s) associated with production(s) of syntax rule Governor

		//
		// Content changing function associated with following production(s)
		// Governor -> Type

		//

		public void change(Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_Governor_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Governor -> DefinedObjectClass

		//

		public void change(DefinedObjectClass p_DefinedObjectClass)
		{
			_init ();
			this.kind = (uint) production_kind.g_Governor_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedObjectClass = p_DefinedObjectClass;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Governor
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_DefinedObjectClass != null) && m_DefinedObjectClass.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Governor

		//
		// emit production tree node associated with any production of syntax rule Governor
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Governor_1:
					// emit syntax tree node associated with production
					// Governor: Type

					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_Governor_2:
					// emit syntax tree node associated with production
					// Governor: DefinedObjectClass

					s += m_DefinedObjectClass.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Governor
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Governor (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Governor_1:
					// emit syntax tree node associated with production
					// Governor: Type

					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Governor_2:
					// emit syntax tree node associated with production
					// Governor: DefinedObjectClass

					s += m_DefinedObjectClass.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Governor

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Governor with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Governor.production_kind kind = (Governor.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Governor.production_kind.g_Governor_1:
					// traverse syntax tree node associated with production
					// Governor: Type

						m_Type.Visit (visitor, appData);
				break;
				case Governor.production_kind.g_Governor_2:
					// traverse syntax tree node associated with production
					// Governor: DefinedObjectClass

						m_DefinedObjectClass.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Type?.reparent (this);
			m_DefinedObjectClass?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Governor
		//

		public void _init ()
		{
			m_Type = null;
			m_DefinedObjectClass = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Governor

		// counter of all nodes associated with syntax rule Governor
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Governor
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_DefinedObjectClass")] public DefinedObjectClass m_DefinedObjectClass { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Governor

		// delegate function (callback) prototype associated with syntax rule Governor
		public delegate bool Governor_Callback (SyntaxTreeCallbackReason reason, Governor.production_kind kind, Governor p_Governor);

		// event associated with syntax rule Governor
		public event Governor_Callback Governor_Event;

		// event trigger associated with syntax rule Governor
		public bool Raise_Governor_Event (SyntaxTreeCallbackReason reason, Governor.production_kind kind, Governor p_Governor)
		{
			bool? status = Governor_Event?.Invoke (reason, kind, p_Governor);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Governor
		//
		// traverse syntax tree node associated with any production of syntax rule Governor
		//

		public void Traverse (Governor p_Governor)
		{
			if (p_Governor.isLocked())
				return;
			p_Governor.dolock();
			Governor.production_kind kind = (Governor.production_kind) p_Governor.kind;
			p_Governor.turn_reset ();
			if (Raise_Governor_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Governor))
			switch (kind)
			{
				case Governor.production_kind.g_Governor_1:
					// traverse syntax tree node associated with production
					// Governor: Type

					if (Raise_Governor_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Governor))
						Traverse (p_Governor.m_Type);
					p_Governor.turn_inc ();
					Raise_Governor_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Governor);
				break;
				case Governor.production_kind.g_Governor_2:
					// traverse syntax tree node associated with production
					// Governor: DefinedObjectClass

					if (Raise_Governor_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Governor))
						Traverse (p_Governor.m_DefinedObjectClass);
					p_Governor.turn_inc ();
					Raise_Governor_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Governor);
				break;
			}
			Raise_Governor_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Governor);
			p_Governor.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Governor
		//

		public void TraverseCommon (Governor p_Governor)
		{
			Governor.production_kind kind = (Governor.production_kind) p_Governor.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Governor))
			switch (kind)
			{
				case Governor.production_kind.g_Governor_1:
					// traverse syntax tree node associated with production
					// Governor: Type

						TraverseCommon (p_Governor.m_Type);
				break;
				case Governor.production_kind.g_Governor_2:
					// traverse syntax tree node associated with production
					// Governor: DefinedObjectClass

						TraverseCommon (p_Governor.m_DefinedObjectClass);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Governor);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Governor

		//
		// create syntax tree node associated with production
		// Governor: Type

		//

		public Governor Governor_1 (Type p_Type)
		{
			Governor p_Governor_ref = new Governor(p_Type);
			p_Type.parent = p_Governor_ref;
			Raise_Governor_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Governor.production_kind.g_Governor_1, p_Governor_ref);
			return p_Governor_ref;
		}

		//
		// create syntax tree node associated with production
		// Governor: DefinedObjectClass

		//

		public Governor Governor_2 (DefinedObjectClass p_DefinedObjectClass)
		{
			Governor p_Governor_ref = new Governor(p_DefinedObjectClass);
			p_DefinedObjectClass.parent = p_Governor_ref;
			Raise_Governor_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Governor.production_kind.g_Governor_2, p_Governor_ref);
			return p_Governor_ref;
		}
		#endregion
	};
}
