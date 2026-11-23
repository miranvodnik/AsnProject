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
	// class associated with syntax rule ObjectDefn
	//

	[DataContract]
	public class	ObjectDefn : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectDefn
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectDefn
		{
			g_ObjectDefn_1 = 1,	// DefaultSyntax

			g_ObjectDefn_2 = 2,	// DefinedSyntax

		};
		#endregion
		#region production markers associated with the syntax rule ObjectDefn

		// markers associated with production: ObjectDefn -> DefaultSyntax

		public enum production_marker_1 : ushort
		{
			m_DefaultSyntax,
			final
		};

		// markers associated with production: ObjectDefn -> DefinedSyntax

		public enum production_marker_2 : ushort
		{
			m_DefinedSyntax,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectDefn

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectDefn

		//
		// Constructor associated with the following production(s)
		// ObjectDefn -> DefaultSyntax

		//

		public ObjectDefn (DefaultSyntax p_DefaultSyntax) : base ((uint) ProductionID._ObjectDefn_ID, (uint) production_kind.g_ObjectDefn_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefaultSyntax = p_DefaultSyntax;
		}

		//
		// Constructor associated with the following production(s)
		// ObjectDefn -> DefinedSyntax

		//

		public ObjectDefn (DefinedSyntax p_DefinedSyntax) : base ((uint) ProductionID._ObjectDefn_ID, (uint) production_kind.g_ObjectDefn_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedSyntax = p_DefinedSyntax;
		}

		public ObjectDefn () { }

		// Copy constructor

		public ObjectDefn (ObjectDefn p_ObjectDefn) : base (p_ObjectDefn.id, p_ObjectDefn.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectDefn.appInfo;
			switch ((production_kind) p_ObjectDefn.kind)
			{
				case production_kind.g_ObjectDefn_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefaultSyntax = (p_ObjectDefn.m_DefaultSyntax != null) ? new DefaultSyntax (p_ObjectDefn.m_DefaultSyntax) : null) != null) m_DefaultSyntax.parent = this;
					break;
				case production_kind.g_ObjectDefn_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedSyntax = (p_ObjectDefn.m_DefinedSyntax != null) ? new DefinedSyntax (p_ObjectDefn.m_DefinedSyntax) : null) != null) m_DefinedSyntax.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectDefn" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectDefn (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DefaultSyntax?.Dispose ();
			m_DefinedSyntax?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectDefn

		// Content changing function(s) associated with production(s) of syntax rule ObjectDefn

		//
		// Content changing function associated with following production(s)
		// ObjectDefn -> DefaultSyntax

		//

		public void change(DefaultSyntax p_DefaultSyntax)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectDefn_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefaultSyntax = p_DefaultSyntax;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ObjectDefn -> DefinedSyntax

		//

		public void change(DefinedSyntax p_DefinedSyntax)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectDefn_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedSyntax = p_DefinedSyntax;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectDefn
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DefaultSyntax != null) && m_DefaultSyntax.checkInclusion (element) ||
				(m_DefinedSyntax != null) && m_DefinedSyntax.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectDefn

		//
		// emit production tree node associated with any production of syntax rule ObjectDefn
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectDefn_1:
					// emit syntax tree node associated with production
					// ObjectDefn: DefaultSyntax

					s += m_DefaultSyntax.Emit (depth - 1);
				break;
				case production_kind.g_ObjectDefn_2:
					// emit syntax tree node associated with production
					// ObjectDefn: DefinedSyntax

					s += m_DefinedSyntax.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectDefn
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectDefn (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectDefn_1:
					// emit syntax tree node associated with production
					// ObjectDefn: DefaultSyntax

					s += m_DefaultSyntax.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ObjectDefn_2:
					// emit syntax tree node associated with production
					// ObjectDefn: DefinedSyntax

					s += m_DefinedSyntax.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectDefn

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectDefn with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectDefn.production_kind kind = (ObjectDefn.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectDefn.production_kind.g_ObjectDefn_1:
					// traverse syntax tree node associated with production
					// ObjectDefn: DefaultSyntax

						m_DefaultSyntax.Visit (visitor, appData);
				break;
				case ObjectDefn.production_kind.g_ObjectDefn_2:
					// traverse syntax tree node associated with production
					// ObjectDefn: DefinedSyntax

						m_DefinedSyntax.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DefaultSyntax?.reparent (this);
			m_DefinedSyntax?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectDefn
		//

		public void _init ()
		{
			m_DefaultSyntax = null;
			m_DefinedSyntax = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectDefn

		// counter of all nodes associated with syntax rule ObjectDefn
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectDefn
		[DataMember (Name = "m_DefaultSyntax")] public DefaultSyntax m_DefaultSyntax { get; private set; }
		[DataMember (Name = "m_DefinedSyntax")] public DefinedSyntax m_DefinedSyntax { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectDefn

		// delegate function (callback) prototype associated with syntax rule ObjectDefn
		public delegate bool ObjectDefn_Callback (SyntaxTreeCallbackReason reason, ObjectDefn.production_kind kind, ObjectDefn p_ObjectDefn);

		// event associated with syntax rule ObjectDefn
		public event ObjectDefn_Callback ObjectDefn_Event;

		// event trigger associated with syntax rule ObjectDefn
		public bool Raise_ObjectDefn_Event (SyntaxTreeCallbackReason reason, ObjectDefn.production_kind kind, ObjectDefn p_ObjectDefn)
		{
			bool? status = ObjectDefn_Event?.Invoke (reason, kind, p_ObjectDefn);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectDefn
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectDefn
		//

		public void Traverse (ObjectDefn p_ObjectDefn)
		{
			if (p_ObjectDefn.isLocked())
				return;
			p_ObjectDefn.dolock();
			ObjectDefn.production_kind kind = (ObjectDefn.production_kind) p_ObjectDefn.kind;
			p_ObjectDefn.turn_reset ();
			if (Raise_ObjectDefn_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectDefn))
			switch (kind)
			{
				case ObjectDefn.production_kind.g_ObjectDefn_1:
					// traverse syntax tree node associated with production
					// ObjectDefn: DefaultSyntax

					if (Raise_ObjectDefn_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectDefn))
						Traverse (p_ObjectDefn.m_DefaultSyntax);
					p_ObjectDefn.turn_inc ();
					Raise_ObjectDefn_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectDefn);
				break;
				case ObjectDefn.production_kind.g_ObjectDefn_2:
					// traverse syntax tree node associated with production
					// ObjectDefn: DefinedSyntax

					if (Raise_ObjectDefn_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectDefn))
						Traverse (p_ObjectDefn.m_DefinedSyntax);
					p_ObjectDefn.turn_inc ();
					Raise_ObjectDefn_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectDefn);
				break;
			}
			Raise_ObjectDefn_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectDefn);
			p_ObjectDefn.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectDefn
		//

		public void TraverseCommon (ObjectDefn p_ObjectDefn)
		{
			ObjectDefn.production_kind kind = (ObjectDefn.production_kind) p_ObjectDefn.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectDefn))
			switch (kind)
			{
				case ObjectDefn.production_kind.g_ObjectDefn_1:
					// traverse syntax tree node associated with production
					// ObjectDefn: DefaultSyntax

						TraverseCommon (p_ObjectDefn.m_DefaultSyntax);
				break;
				case ObjectDefn.production_kind.g_ObjectDefn_2:
					// traverse syntax tree node associated with production
					// ObjectDefn: DefinedSyntax

						TraverseCommon (p_ObjectDefn.m_DefinedSyntax);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectDefn);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectDefn

		//
		// create syntax tree node associated with production
		// ObjectDefn: DefaultSyntax

		//

		public ObjectDefn ObjectDefn_1 (DefaultSyntax p_DefaultSyntax)
		{
			ObjectDefn p_ObjectDefn_ref = new ObjectDefn(p_DefaultSyntax);
			p_DefaultSyntax.parent = p_ObjectDefn_ref;
			Raise_ObjectDefn_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectDefn.production_kind.g_ObjectDefn_1, p_ObjectDefn_ref);
			return p_ObjectDefn_ref;
		}

		//
		// create syntax tree node associated with production
		// ObjectDefn: DefinedSyntax

		//

		public ObjectDefn ObjectDefn_2 (DefinedSyntax p_DefinedSyntax)
		{
			ObjectDefn p_ObjectDefn_ref = new ObjectDefn(p_DefinedSyntax);
			p_DefinedSyntax.parent = p_ObjectDefn_ref;
			Raise_ObjectDefn_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectDefn.production_kind.g_ObjectDefn_2, p_ObjectDefn_ref);
			return p_ObjectDefn_ref;
		}
		#endregion
	};
}
