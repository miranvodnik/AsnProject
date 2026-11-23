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
	// class associated with syntax rule AssignedIdentifier
	//

	[DataContract]
	public class	AssignedIdentifier : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AssignedIdentifier
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AssignedIdentifier
		{
			g_AssignedIdentifier_1 = 1,	// ObjectIdentifierValue

			g_AssignedIdentifier_2 = 2,	// DefinedValue

			g_AssignedIdentifier_3 = 3,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule AssignedIdentifier

		// markers associated with production: AssignedIdentifier -> ObjectIdentifierValue

		public enum production_marker_1 : ushort
		{
			m_ObjectIdentifierValue,
			final
		};

		// markers associated with production: AssignedIdentifier -> DefinedValue

		public enum production_marker_2 : ushort
		{
			m_DefinedValue,
			final
		};

		// markers associated with production: AssignedIdentifier -> %empty

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AssignedIdentifier

		// Constructor declaration(s) associated with production(s) of syntax rule AssignedIdentifier

		//
		// Constructor associated with the following production(s)
		// AssignedIdentifier -> ObjectIdentifierValue

		//

		public AssignedIdentifier (ObjectIdentifierValue p_ObjectIdentifierValue) : base ((uint) ProductionID._AssignedIdentifier_ID, (uint) production_kind.g_AssignedIdentifier_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
		}

		//
		// Constructor associated with the following production(s)
		// AssignedIdentifier -> DefinedValue

		//

		public AssignedIdentifier (DefinedValue p_DefinedValue) : base ((uint) ProductionID._AssignedIdentifier_ID, (uint) production_kind.g_AssignedIdentifier_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedValue = p_DefinedValue;
		}

		//
		// Constructor associated with the following production(s)
		// AssignedIdentifier -> %empty

		//

		public AssignedIdentifier () : base ((uint) ProductionID._AssignedIdentifier_ID, (uint) production_kind.g_AssignedIdentifier_3)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public AssignedIdentifier (AssignedIdentifier p_AssignedIdentifier) : base (p_AssignedIdentifier.id, p_AssignedIdentifier.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AssignedIdentifier.appInfo;
			switch ((production_kind) p_AssignedIdentifier.kind)
			{
				case production_kind.g_AssignedIdentifier_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ObjectIdentifierValue = (p_AssignedIdentifier.m_ObjectIdentifierValue != null) ? new ObjectIdentifierValue (p_AssignedIdentifier.m_ObjectIdentifierValue) : null) != null) m_ObjectIdentifierValue.parent = this;
					break;
				case production_kind.g_AssignedIdentifier_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedValue = (p_AssignedIdentifier.m_DefinedValue != null) ? new DefinedValue (p_AssignedIdentifier.m_DefinedValue) : null) != null) m_DefinedValue.parent = this;
					break;
				case production_kind.g_AssignedIdentifier_3:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "AssignedIdentifier" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AssignedIdentifier (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ObjectIdentifierValue?.Dispose ();
			m_DefinedValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AssignedIdentifier

		// Content changing function(s) associated with production(s) of syntax rule AssignedIdentifier

		//
		// Content changing function associated with following production(s)
		// AssignedIdentifier -> ObjectIdentifierValue

		//

		public void change(ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_AssignedIdentifier_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ObjectIdentifierValue = p_ObjectIdentifierValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AssignedIdentifier -> DefinedValue

		//

		public void change(DefinedValue p_DefinedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_AssignedIdentifier_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedValue = p_DefinedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AssignedIdentifier -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_AssignedIdentifier_3;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AssignedIdentifier
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ObjectIdentifierValue != null) && m_ObjectIdentifierValue.checkInclusion (element) ||
				(m_DefinedValue != null) && m_DefinedValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AssignedIdentifier

		//
		// emit production tree node associated with any production of syntax rule AssignedIdentifier
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AssignedIdentifier_1:
					// emit syntax tree node associated with production
					// AssignedIdentifier: ObjectIdentifierValue

					s += m_ObjectIdentifierValue.Emit (depth - 1);
				break;
				case production_kind.g_AssignedIdentifier_2:
					// emit syntax tree node associated with production
					// AssignedIdentifier: DefinedValue

					s += m_DefinedValue.Emit (depth - 1);
				break;
				case production_kind.g_AssignedIdentifier_3:
					// emit syntax tree node associated with production
					// AssignedIdentifier: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AssignedIdentifier
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AssignedIdentifier (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AssignedIdentifier_1:
					// emit syntax tree node associated with production
					// AssignedIdentifier: ObjectIdentifierValue

					s += m_ObjectIdentifierValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AssignedIdentifier_2:
					// emit syntax tree node associated with production
					// AssignedIdentifier: DefinedValue

					s += m_DefinedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AssignedIdentifier_3:
					// emit syntax tree node associated with production
					// AssignedIdentifier: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AssignedIdentifier

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AssignedIdentifier with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AssignedIdentifier.production_kind kind = (AssignedIdentifier.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AssignedIdentifier.production_kind.g_AssignedIdentifier_1:
					// traverse syntax tree node associated with production
					// AssignedIdentifier: ObjectIdentifierValue

						m_ObjectIdentifierValue.Visit (visitor, appData);
				break;
				case AssignedIdentifier.production_kind.g_AssignedIdentifier_2:
					// traverse syntax tree node associated with production
					// AssignedIdentifier: DefinedValue

						m_DefinedValue.Visit (visitor, appData);
				break;
				case AssignedIdentifier.production_kind.g_AssignedIdentifier_3:
					// traverse syntax tree node associated with production
					// AssignedIdentifier: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ObjectIdentifierValue?.reparent (this);
			m_DefinedValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AssignedIdentifier
		//

		public void _init ()
		{
			m_ObjectIdentifierValue = null;
			m_DefinedValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AssignedIdentifier

		// counter of all nodes associated with syntax rule AssignedIdentifier
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AssignedIdentifier
		[DataMember (Name = "m_ObjectIdentifierValue")] public ObjectIdentifierValue m_ObjectIdentifierValue { get; private set; }
		[DataMember (Name = "m_DefinedValue")] public DefinedValue m_DefinedValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AssignedIdentifier

		// delegate function (callback) prototype associated with syntax rule AssignedIdentifier
		public delegate bool AssignedIdentifier_Callback (SyntaxTreeCallbackReason reason, AssignedIdentifier.production_kind kind, AssignedIdentifier p_AssignedIdentifier);

		// event associated with syntax rule AssignedIdentifier
		public event AssignedIdentifier_Callback AssignedIdentifier_Event;

		// event trigger associated with syntax rule AssignedIdentifier
		public bool Raise_AssignedIdentifier_Event (SyntaxTreeCallbackReason reason, AssignedIdentifier.production_kind kind, AssignedIdentifier p_AssignedIdentifier)
		{
			bool? status = AssignedIdentifier_Event?.Invoke (reason, kind, p_AssignedIdentifier);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AssignedIdentifier
		//
		// traverse syntax tree node associated with any production of syntax rule AssignedIdentifier
		//

		public void Traverse (AssignedIdentifier p_AssignedIdentifier)
		{
			if (p_AssignedIdentifier.isLocked())
				return;
			p_AssignedIdentifier.dolock();
			AssignedIdentifier.production_kind kind = (AssignedIdentifier.production_kind) p_AssignedIdentifier.kind;
			p_AssignedIdentifier.turn_reset ();
			if (Raise_AssignedIdentifier_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AssignedIdentifier))
			switch (kind)
			{
				case AssignedIdentifier.production_kind.g_AssignedIdentifier_1:
					// traverse syntax tree node associated with production
					// AssignedIdentifier: ObjectIdentifierValue

					if (Raise_AssignedIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AssignedIdentifier))
						Traverse (p_AssignedIdentifier.m_ObjectIdentifierValue);
					p_AssignedIdentifier.turn_inc ();
					Raise_AssignedIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AssignedIdentifier);
				break;
				case AssignedIdentifier.production_kind.g_AssignedIdentifier_2:
					// traverse syntax tree node associated with production
					// AssignedIdentifier: DefinedValue

					if (Raise_AssignedIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AssignedIdentifier))
						Traverse (p_AssignedIdentifier.m_DefinedValue);
					p_AssignedIdentifier.turn_inc ();
					Raise_AssignedIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AssignedIdentifier);
				break;
				case AssignedIdentifier.production_kind.g_AssignedIdentifier_3:
					// traverse syntax tree node associated with production
					// AssignedIdentifier: %empty

				break;
			}
			Raise_AssignedIdentifier_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AssignedIdentifier);
			p_AssignedIdentifier.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AssignedIdentifier
		//

		public void TraverseCommon (AssignedIdentifier p_AssignedIdentifier)
		{
			AssignedIdentifier.production_kind kind = (AssignedIdentifier.production_kind) p_AssignedIdentifier.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AssignedIdentifier))
			switch (kind)
			{
				case AssignedIdentifier.production_kind.g_AssignedIdentifier_1:
					// traverse syntax tree node associated with production
					// AssignedIdentifier: ObjectIdentifierValue

						TraverseCommon (p_AssignedIdentifier.m_ObjectIdentifierValue);
				break;
				case AssignedIdentifier.production_kind.g_AssignedIdentifier_2:
					// traverse syntax tree node associated with production
					// AssignedIdentifier: DefinedValue

						TraverseCommon (p_AssignedIdentifier.m_DefinedValue);
				break;
				case AssignedIdentifier.production_kind.g_AssignedIdentifier_3:
					// traverse syntax tree node associated with production
					// AssignedIdentifier: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AssignedIdentifier);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AssignedIdentifier

		//
		// create syntax tree node associated with production
		// AssignedIdentifier: ObjectIdentifierValue

		//

		public AssignedIdentifier AssignedIdentifier_1 (ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			AssignedIdentifier p_AssignedIdentifier_ref = new AssignedIdentifier(p_ObjectIdentifierValue);
			p_ObjectIdentifierValue.parent = p_AssignedIdentifier_ref;
			Raise_AssignedIdentifier_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AssignedIdentifier.production_kind.g_AssignedIdentifier_1, p_AssignedIdentifier_ref);
			return p_AssignedIdentifier_ref;
		}

		//
		// create syntax tree node associated with production
		// AssignedIdentifier: DefinedValue

		//

		public AssignedIdentifier AssignedIdentifier_2 (DefinedValue p_DefinedValue)
		{
			AssignedIdentifier p_AssignedIdentifier_ref = new AssignedIdentifier(p_DefinedValue);
			p_DefinedValue.parent = p_AssignedIdentifier_ref;
			Raise_AssignedIdentifier_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AssignedIdentifier.production_kind.g_AssignedIdentifier_2, p_AssignedIdentifier_ref);
			return p_AssignedIdentifier_ref;
		}

		//
		// create syntax tree node associated with production
		// AssignedIdentifier: %empty

		//

		public AssignedIdentifier AssignedIdentifier_3 ()
		{
			AssignedIdentifier p_AssignedIdentifier_ref = new AssignedIdentifier();
			Raise_AssignedIdentifier_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AssignedIdentifier.production_kind.g_AssignedIdentifier_3, p_AssignedIdentifier_ref);
			return p_AssignedIdentifier_ref;
		}
		#endregion
	};
}
