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
	// class associated with syntax rule ContainedSubtype
	//

	[DataContract]
	public class	ContainedSubtype : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ContainedSubtype
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ContainedSubtype
		{
			g_ContainedSubtype_1 = 1,	// Includes Type

		};
		#endregion
		#region production markers associated with the syntax rule ContainedSubtype

		// markers associated with production: ContainedSubtype -> Includes Type

		public enum production_marker_1 : ushort
		{
			m_Includes,
			m_Type,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ContainedSubtype

		// Constructor declaration(s) associated with production(s) of syntax rule ContainedSubtype

		//
		// Constructor associated with the following production(s)
		// ContainedSubtype -> Includes Type

		//

		public ContainedSubtype (Includes p_Includes, Type p_Type) : base ((uint) ProductionID._ContainedSubtype_ID, (uint) production_kind.g_ContainedSubtype_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_Includes = p_Includes;
			children[1] = m_Type = p_Type;
		}

		public ContainedSubtype () { }

		// Copy constructor

		public ContainedSubtype (ContainedSubtype p_ContainedSubtype) : base (p_ContainedSubtype.id, p_ContainedSubtype.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ContainedSubtype.appInfo;
			switch ((production_kind) p_ContainedSubtype.kind)
			{
				case production_kind.g_ContainedSubtype_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_Includes = (p_ContainedSubtype.m_Includes != null) ? new Includes (p_ContainedSubtype.m_Includes) : null) != null) m_Includes.parent = this;
					if ((children [1] = m_Type = (p_ContainedSubtype.m_Type != null) ? new Type (p_ContainedSubtype.m_Type) : null) != null) m_Type.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ContainedSubtype" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ContainedSubtype (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Includes?.Dispose ();
			m_Type?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ContainedSubtype

		// Content changing function(s) associated with production(s) of syntax rule ContainedSubtype

		//
		// Content changing function associated with following production(s)
		// ContainedSubtype -> Includes Type

		//

		public void change(Includes p_Includes, Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_ContainedSubtype_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_Includes = p_Includes;
			children [1] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ContainedSubtype
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Includes != null) && m_Includes.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ContainedSubtype

		//
		// emit production tree node associated with any production of syntax rule ContainedSubtype
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ContainedSubtype_1:
					// emit syntax tree node associated with production
					// ContainedSubtype: Includes Type

					s += m_Includes.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ContainedSubtype
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ContainedSubtype (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ContainedSubtype_1:
					// emit syntax tree node associated with production
					// ContainedSubtype: Includes Type

					s += m_Includes.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ContainedSubtype

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ContainedSubtype with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ContainedSubtype.production_kind kind = (ContainedSubtype.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ContainedSubtype.production_kind.g_ContainedSubtype_1:
					// traverse syntax tree node associated with production
					// ContainedSubtype: Includes Type

						m_Includes.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Includes?.reparent (this);
			m_Type?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ContainedSubtype
		//

		public void _init ()
		{
			m_Includes = null;
			m_Type = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ContainedSubtype

		// counter of all nodes associated with syntax rule ContainedSubtype
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ContainedSubtype
		[DataMember (Name = "m_Includes")] public Includes m_Includes { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ContainedSubtype

		// delegate function (callback) prototype associated with syntax rule ContainedSubtype
		public delegate bool ContainedSubtype_Callback (SyntaxTreeCallbackReason reason, ContainedSubtype.production_kind kind, ContainedSubtype p_ContainedSubtype);

		// event associated with syntax rule ContainedSubtype
		public event ContainedSubtype_Callback ContainedSubtype_Event;

		// event trigger associated with syntax rule ContainedSubtype
		public bool Raise_ContainedSubtype_Event (SyntaxTreeCallbackReason reason, ContainedSubtype.production_kind kind, ContainedSubtype p_ContainedSubtype)
		{
			bool? status = ContainedSubtype_Event?.Invoke (reason, kind, p_ContainedSubtype);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ContainedSubtype
		//
		// traverse syntax tree node associated with any production of syntax rule ContainedSubtype
		//

		public void Traverse (ContainedSubtype p_ContainedSubtype)
		{
			if (p_ContainedSubtype.isLocked())
				return;
			p_ContainedSubtype.dolock();
			ContainedSubtype.production_kind kind = (ContainedSubtype.production_kind) p_ContainedSubtype.kind;
			p_ContainedSubtype.turn_reset ();
			if (Raise_ContainedSubtype_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ContainedSubtype))
			switch (kind)
			{
				case ContainedSubtype.production_kind.g_ContainedSubtype_1:
					// traverse syntax tree node associated with production
					// ContainedSubtype: Includes Type

					if (Raise_ContainedSubtype_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ContainedSubtype))
						Traverse (p_ContainedSubtype.m_Includes);
					p_ContainedSubtype.turn_inc ();
					if (Raise_ContainedSubtype_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ContainedSubtype))
						Traverse (p_ContainedSubtype.m_Type);
					p_ContainedSubtype.turn_inc ();
					Raise_ContainedSubtype_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ContainedSubtype);
				break;
			}
			Raise_ContainedSubtype_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ContainedSubtype);
			p_ContainedSubtype.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ContainedSubtype
		//

		public void TraverseCommon (ContainedSubtype p_ContainedSubtype)
		{
			ContainedSubtype.production_kind kind = (ContainedSubtype.production_kind) p_ContainedSubtype.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ContainedSubtype))
			switch (kind)
			{
				case ContainedSubtype.production_kind.g_ContainedSubtype_1:
					// traverse syntax tree node associated with production
					// ContainedSubtype: Includes Type

						TraverseCommon (p_ContainedSubtype.m_Includes);
						TraverseCommon (p_ContainedSubtype.m_Type);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ContainedSubtype);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ContainedSubtype

		//
		// create syntax tree node associated with production
		// ContainedSubtype: Includes Type

		//

		public ContainedSubtype ContainedSubtype_1 (Includes p_Includes, Type p_Type)
		{
			ContainedSubtype p_ContainedSubtype_ref = new ContainedSubtype(p_Includes, p_Type);
			p_Includes.parent = p_ContainedSubtype_ref;
			p_Type.parent = p_ContainedSubtype_ref;
			Raise_ContainedSubtype_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ContainedSubtype.production_kind.g_ContainedSubtype_1, p_ContainedSubtype_ref);
			return p_ContainedSubtype_ref;
		}
		#endregion
	};
}
