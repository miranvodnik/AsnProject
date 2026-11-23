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
	// class associated with syntax rule ExtensionAdditionAlternative
	//

	[DataContract]
	public class	ExtensionAdditionAlternative : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExtensionAdditionAlternative
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExtensionAdditionAlternative
		{
			g_ExtensionAdditionAlternative_1 = 1,	// ExtensionAdditionAlternativesGroup

			g_ExtensionAdditionAlternative_2 = 2,	// NamedType

		};
		#endregion
		#region production markers associated with the syntax rule ExtensionAdditionAlternative

		// markers associated with production: ExtensionAdditionAlternative -> ExtensionAdditionAlternativesGroup

		public enum production_marker_1 : ushort
		{
			m_ExtensionAdditionAlternativesGroup,
			final
		};

		// markers associated with production: ExtensionAdditionAlternative -> NamedType

		public enum production_marker_2 : ushort
		{
			m_NamedType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExtensionAdditionAlternative

		// Constructor declaration(s) associated with production(s) of syntax rule ExtensionAdditionAlternative

		//
		// Constructor associated with the following production(s)
		// ExtensionAdditionAlternative -> ExtensionAdditionAlternativesGroup

		//

		public ExtensionAdditionAlternative (ExtensionAdditionAlternativesGroup p_ExtensionAdditionAlternativesGroup) : base ((uint) ProductionID._ExtensionAdditionAlternative_ID, (uint) production_kind.g_ExtensionAdditionAlternative_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExtensionAdditionAlternativesGroup = p_ExtensionAdditionAlternativesGroup;
		}

		//
		// Constructor associated with the following production(s)
		// ExtensionAdditionAlternative -> NamedType

		//

		public ExtensionAdditionAlternative (NamedType p_NamedType) : base ((uint) ProductionID._ExtensionAdditionAlternative_ID, (uint) production_kind.g_ExtensionAdditionAlternative_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NamedType = p_NamedType;
		}

		public ExtensionAdditionAlternative () { }

		// Copy constructor

		public ExtensionAdditionAlternative (ExtensionAdditionAlternative p_ExtensionAdditionAlternative) : base (p_ExtensionAdditionAlternative.id, p_ExtensionAdditionAlternative.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExtensionAdditionAlternative.appInfo;
			switch ((production_kind) p_ExtensionAdditionAlternative.kind)
			{
				case production_kind.g_ExtensionAdditionAlternative_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExtensionAdditionAlternativesGroup = (p_ExtensionAdditionAlternative.m_ExtensionAdditionAlternativesGroup != null) ? new ExtensionAdditionAlternativesGroup (p_ExtensionAdditionAlternative.m_ExtensionAdditionAlternativesGroup) : null) != null) m_ExtensionAdditionAlternativesGroup.parent = this;
					break;
				case production_kind.g_ExtensionAdditionAlternative_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NamedType = (p_ExtensionAdditionAlternative.m_NamedType != null) ? new NamedType (p_ExtensionAdditionAlternative.m_NamedType) : null) != null) m_NamedType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExtensionAdditionAlternative" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExtensionAdditionAlternative (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ExtensionAdditionAlternativesGroup?.Dispose ();
			m_NamedType?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExtensionAdditionAlternative

		// Content changing function(s) associated with production(s) of syntax rule ExtensionAdditionAlternative

		//
		// Content changing function associated with following production(s)
		// ExtensionAdditionAlternative -> ExtensionAdditionAlternativesGroup

		//

		public void change(ExtensionAdditionAlternativesGroup p_ExtensionAdditionAlternativesGroup)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAdditionAlternative_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExtensionAdditionAlternativesGroup = p_ExtensionAdditionAlternativesGroup;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ExtensionAdditionAlternative -> NamedType

		//

		public void change(NamedType p_NamedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAdditionAlternative_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NamedType = p_NamedType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExtensionAdditionAlternative
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ExtensionAdditionAlternativesGroup != null) && m_ExtensionAdditionAlternativesGroup.checkInclusion (element) ||
				(m_NamedType != null) && m_NamedType.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExtensionAdditionAlternative

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditionAlternative
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExtensionAdditionAlternative_1:
					// emit syntax tree node associated with production
					// ExtensionAdditionAlternative: ExtensionAdditionAlternativesGroup

					s += m_ExtensionAdditionAlternativesGroup.Emit (depth - 1);
				break;
				case production_kind.g_ExtensionAdditionAlternative_2:
					// emit syntax tree node associated with production
					// ExtensionAdditionAlternative: NamedType

					s += m_NamedType.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExtensionAdditionAlternative
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExtensionAdditionAlternative (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExtensionAdditionAlternative_1:
					// emit syntax tree node associated with production
					// ExtensionAdditionAlternative: ExtensionAdditionAlternativesGroup

					s += m_ExtensionAdditionAlternativesGroup.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ExtensionAdditionAlternative_2:
					// emit syntax tree node associated with production
					// ExtensionAdditionAlternative: NamedType

					s += m_NamedType.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExtensionAdditionAlternative

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionAlternative with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExtensionAdditionAlternative.production_kind kind = (ExtensionAdditionAlternative.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExtensionAdditionAlternative.production_kind.g_ExtensionAdditionAlternative_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternative: ExtensionAdditionAlternativesGroup

						m_ExtensionAdditionAlternativesGroup.Visit (visitor, appData);
				break;
				case ExtensionAdditionAlternative.production_kind.g_ExtensionAdditionAlternative_2:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternative: NamedType

						m_NamedType.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ExtensionAdditionAlternativesGroup?.reparent (this);
			m_NamedType?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExtensionAdditionAlternative
		//

		public void _init ()
		{
			m_ExtensionAdditionAlternativesGroup = null;
			m_NamedType = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExtensionAdditionAlternative

		// counter of all nodes associated with syntax rule ExtensionAdditionAlternative
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExtensionAdditionAlternative
		[DataMember (Name = "m_ExtensionAdditionAlternativesGroup")] public ExtensionAdditionAlternativesGroup m_ExtensionAdditionAlternativesGroup { get; private set; }
		[DataMember (Name = "m_NamedType")] public NamedType m_NamedType { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExtensionAdditionAlternative

		// delegate function (callback) prototype associated with syntax rule ExtensionAdditionAlternative
		public delegate bool ExtensionAdditionAlternative_Callback (SyntaxTreeCallbackReason reason, ExtensionAdditionAlternative.production_kind kind, ExtensionAdditionAlternative p_ExtensionAdditionAlternative);

		// event associated with syntax rule ExtensionAdditionAlternative
		public event ExtensionAdditionAlternative_Callback ExtensionAdditionAlternative_Event;

		// event trigger associated with syntax rule ExtensionAdditionAlternative
		public bool Raise_ExtensionAdditionAlternative_Event (SyntaxTreeCallbackReason reason, ExtensionAdditionAlternative.production_kind kind, ExtensionAdditionAlternative p_ExtensionAdditionAlternative)
		{
			bool? status = ExtensionAdditionAlternative_Event?.Invoke (reason, kind, p_ExtensionAdditionAlternative);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExtensionAdditionAlternative
		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionAlternative
		//

		public void Traverse (ExtensionAdditionAlternative p_ExtensionAdditionAlternative)
		{
			if (p_ExtensionAdditionAlternative.isLocked())
				return;
			p_ExtensionAdditionAlternative.dolock();
			ExtensionAdditionAlternative.production_kind kind = (ExtensionAdditionAlternative.production_kind) p_ExtensionAdditionAlternative.kind;
			p_ExtensionAdditionAlternative.turn_reset ();
			if (Raise_ExtensionAdditionAlternative_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExtensionAdditionAlternative))
			switch (kind)
			{
				case ExtensionAdditionAlternative.production_kind.g_ExtensionAdditionAlternative_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternative: ExtensionAdditionAlternativesGroup

					if (Raise_ExtensionAdditionAlternative_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditionAlternative))
						Traverse (p_ExtensionAdditionAlternative.m_ExtensionAdditionAlternativesGroup);
					p_ExtensionAdditionAlternative.turn_inc ();
					Raise_ExtensionAdditionAlternative_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditionAlternative);
				break;
				case ExtensionAdditionAlternative.production_kind.g_ExtensionAdditionAlternative_2:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternative: NamedType

					if (Raise_ExtensionAdditionAlternative_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditionAlternative))
						Traverse (p_ExtensionAdditionAlternative.m_NamedType);
					p_ExtensionAdditionAlternative.turn_inc ();
					Raise_ExtensionAdditionAlternative_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAdditionAlternative);
				break;
			}
			Raise_ExtensionAdditionAlternative_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExtensionAdditionAlternative);
			p_ExtensionAdditionAlternative.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAdditionAlternative
		//

		public void TraverseCommon (ExtensionAdditionAlternative p_ExtensionAdditionAlternative)
		{
			ExtensionAdditionAlternative.production_kind kind = (ExtensionAdditionAlternative.production_kind) p_ExtensionAdditionAlternative.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExtensionAdditionAlternative))
			switch (kind)
			{
				case ExtensionAdditionAlternative.production_kind.g_ExtensionAdditionAlternative_1:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternative: ExtensionAdditionAlternativesGroup

						TraverseCommon (p_ExtensionAdditionAlternative.m_ExtensionAdditionAlternativesGroup);
				break;
				case ExtensionAdditionAlternative.production_kind.g_ExtensionAdditionAlternative_2:
					// traverse syntax tree node associated with production
					// ExtensionAdditionAlternative: NamedType

						TraverseCommon (p_ExtensionAdditionAlternative.m_NamedType);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExtensionAdditionAlternative);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExtensionAdditionAlternative

		//
		// create syntax tree node associated with production
		// ExtensionAdditionAlternative: ExtensionAdditionAlternativesGroup

		//

		public ExtensionAdditionAlternative ExtensionAdditionAlternative_1 (ExtensionAdditionAlternativesGroup p_ExtensionAdditionAlternativesGroup)
		{
			ExtensionAdditionAlternative p_ExtensionAdditionAlternative_ref = new ExtensionAdditionAlternative(p_ExtensionAdditionAlternativesGroup);
			p_ExtensionAdditionAlternativesGroup.parent = p_ExtensionAdditionAlternative_ref;
			Raise_ExtensionAdditionAlternative_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAdditionAlternative.production_kind.g_ExtensionAdditionAlternative_1, p_ExtensionAdditionAlternative_ref);
			return p_ExtensionAdditionAlternative_ref;
		}

		//
		// create syntax tree node associated with production
		// ExtensionAdditionAlternative: NamedType

		//

		public ExtensionAdditionAlternative ExtensionAdditionAlternative_2 (NamedType p_NamedType)
		{
			ExtensionAdditionAlternative p_ExtensionAdditionAlternative_ref = new ExtensionAdditionAlternative(p_NamedType);
			p_NamedType.parent = p_ExtensionAdditionAlternative_ref;
			Raise_ExtensionAdditionAlternative_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAdditionAlternative.production_kind.g_ExtensionAdditionAlternative_2, p_ExtensionAdditionAlternative_ref);
			return p_ExtensionAdditionAlternative_ref;
		}
		#endregion
	};
}
