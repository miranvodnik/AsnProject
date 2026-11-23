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
	// class associated with syntax rule DefinedObjectClass
	//

	[DataContract]
	public class	DefinedObjectClass : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinedObjectClass
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinedObjectClass
		{
			g_DefinedObjectClass_1 = 1,	// ExternalObjectClassReference

			g_DefinedObjectClass_2 = 2,	// objectclassreference-token

			g_DefinedObjectClass_3 = 3,	// UsefulObjectClassReference

		};
		#endregion
		#region production markers associated with the syntax rule DefinedObjectClass

		// markers associated with production: DefinedObjectClass -> ExternalObjectClassReference

		public enum production_marker_1 : ushort
		{
			m_ExternalObjectClassReference,
			final
		};

		// markers associated with production: DefinedObjectClass -> objectclassreference-token

		public enum production_marker_2 : ushort
		{
			m_objectclassreference_token,
			final
		};

		// markers associated with production: DefinedObjectClass -> UsefulObjectClassReference

		public enum production_marker_3 : ushort
		{
			m_UsefulObjectClassReference,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinedObjectClass

		// Constructor declaration(s) associated with production(s) of syntax rule DefinedObjectClass

		//
		// Constructor associated with the following production(s)
		// DefinedObjectClass -> ExternalObjectClassReference

		//

		public DefinedObjectClass (ExternalObjectClassReference p_ExternalObjectClassReference) : base ((uint) ProductionID._DefinedObjectClass_ID, (uint) production_kind.g_DefinedObjectClass_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExternalObjectClassReference = p_ExternalObjectClassReference;
		}

		//
		// Constructor associated with the following production(s)
		// DefinedObjectClass -> objectclassreference-token

		//

		public DefinedObjectClass (objectclassreference_token p_objectclassreference_token) : base ((uint) ProductionID._DefinedObjectClass_ID, (uint) production_kind.g_DefinedObjectClass_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_objectclassreference_token = p_objectclassreference_token;
		}

		//
		// Constructor associated with the following production(s)
		// DefinedObjectClass -> UsefulObjectClassReference

		//

		public DefinedObjectClass (UsefulObjectClassReference p_UsefulObjectClassReference) : base ((uint) ProductionID._DefinedObjectClass_ID, (uint) production_kind.g_DefinedObjectClass_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_UsefulObjectClassReference = p_UsefulObjectClassReference;
		}

		public DefinedObjectClass () { }

		// Copy constructor

		public DefinedObjectClass (DefinedObjectClass p_DefinedObjectClass) : base (p_DefinedObjectClass.id, p_DefinedObjectClass.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinedObjectClass.appInfo;
			switch ((production_kind) p_DefinedObjectClass.kind)
			{
				case production_kind.g_DefinedObjectClass_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExternalObjectClassReference = (p_DefinedObjectClass.m_ExternalObjectClassReference != null) ? new ExternalObjectClassReference (p_DefinedObjectClass.m_ExternalObjectClassReference) : null) != null) m_ExternalObjectClassReference.parent = this;
					break;
				case production_kind.g_DefinedObjectClass_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_objectclassreference_token = (p_DefinedObjectClass.m_objectclassreference_token != null) ? new objectclassreference_token (p_DefinedObjectClass.m_objectclassreference_token) : null) != null) m_objectclassreference_token.parent = this;
					break;
				case production_kind.g_DefinedObjectClass_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UsefulObjectClassReference = (p_DefinedObjectClass.m_UsefulObjectClassReference != null) ? new UsefulObjectClassReference (p_DefinedObjectClass.m_UsefulObjectClassReference) : null) != null) m_UsefulObjectClassReference.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinedObjectClass" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinedObjectClass (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ExternalObjectClassReference?.Dispose ();
			m_objectclassreference_token?.Dispose ();
			m_UsefulObjectClassReference?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinedObjectClass

		// Content changing function(s) associated with production(s) of syntax rule DefinedObjectClass

		//
		// Content changing function associated with following production(s)
		// DefinedObjectClass -> ExternalObjectClassReference

		//

		public void change(ExternalObjectClassReference p_ExternalObjectClassReference)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedObjectClass_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExternalObjectClassReference = p_ExternalObjectClassReference;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinedObjectClass -> objectclassreference-token

		//

		public void change(objectclassreference_token p_objectclassreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedObjectClass_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_objectclassreference_token = p_objectclassreference_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinedObjectClass -> UsefulObjectClassReference

		//

		public void change(UsefulObjectClassReference p_UsefulObjectClassReference)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedObjectClass_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_UsefulObjectClassReference = p_UsefulObjectClassReference;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinedObjectClass
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ExternalObjectClassReference != null) && m_ExternalObjectClassReference.checkInclusion (element) ||
				(m_objectclassreference_token != null) && m_objectclassreference_token.checkInclusion (element) ||
				(m_UsefulObjectClassReference != null) && m_UsefulObjectClassReference.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinedObjectClass

		//
		// emit production tree node associated with any production of syntax rule DefinedObjectClass
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinedObjectClass_1:
					// emit syntax tree node associated with production
					// DefinedObjectClass: ExternalObjectClassReference

					s += m_ExternalObjectClassReference.Emit (depth - 1);
				break;
				case production_kind.g_DefinedObjectClass_2:
					// emit syntax tree node associated with production
					// DefinedObjectClass: objectclassreference-token

					s += m_objectclassreference_token.Emit (depth - 1);
				break;
				case production_kind.g_DefinedObjectClass_3:
					// emit syntax tree node associated with production
					// DefinedObjectClass: UsefulObjectClassReference

					s += m_UsefulObjectClassReference.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinedObjectClass
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinedObjectClass (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinedObjectClass_1:
					// emit syntax tree node associated with production
					// DefinedObjectClass: ExternalObjectClassReference

					s += m_ExternalObjectClassReference.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinedObjectClass_2:
					// emit syntax tree node associated with production
					// DefinedObjectClass: objectclassreference-token

					s += m_objectclassreference_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinedObjectClass_3:
					// emit syntax tree node associated with production
					// DefinedObjectClass: UsefulObjectClassReference

					s += m_UsefulObjectClassReference.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinedObjectClass

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedObjectClass with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinedObjectClass.production_kind kind = (DefinedObjectClass.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinedObjectClass.production_kind.g_DefinedObjectClass_1:
					// traverse syntax tree node associated with production
					// DefinedObjectClass: ExternalObjectClassReference

						m_ExternalObjectClassReference.Visit (visitor, appData);
				break;
				case DefinedObjectClass.production_kind.g_DefinedObjectClass_2:
					// traverse syntax tree node associated with production
					// DefinedObjectClass: objectclassreference-token

						m_objectclassreference_token.Visit (visitor, appData);
				break;
				case DefinedObjectClass.production_kind.g_DefinedObjectClass_3:
					// traverse syntax tree node associated with production
					// DefinedObjectClass: UsefulObjectClassReference

						m_UsefulObjectClassReference.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ExternalObjectClassReference?.reparent (this);
			m_objectclassreference_token?.reparent (this);
			m_UsefulObjectClassReference?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefinedObjectClass
		//

		public void _init ()
		{
			m_ExternalObjectClassReference = null;
			m_objectclassreference_token = null;
			m_UsefulObjectClassReference = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinedObjectClass

		// counter of all nodes associated with syntax rule DefinedObjectClass
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinedObjectClass
		[DataMember (Name = "m_ExternalObjectClassReference")] public ExternalObjectClassReference m_ExternalObjectClassReference { get; private set; }
		[DataMember (Name = "m_objectclassreference_token")] public objectclassreference_token m_objectclassreference_token { get; private set; }
		[DataMember (Name = "m_UsefulObjectClassReference")] public UsefulObjectClassReference m_UsefulObjectClassReference { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinedObjectClass

		// delegate function (callback) prototype associated with syntax rule DefinedObjectClass
		public delegate bool DefinedObjectClass_Callback (SyntaxTreeCallbackReason reason, DefinedObjectClass.production_kind kind, DefinedObjectClass p_DefinedObjectClass);

		// event associated with syntax rule DefinedObjectClass
		public event DefinedObjectClass_Callback DefinedObjectClass_Event;

		// event trigger associated with syntax rule DefinedObjectClass
		public bool Raise_DefinedObjectClass_Event (SyntaxTreeCallbackReason reason, DefinedObjectClass.production_kind kind, DefinedObjectClass p_DefinedObjectClass)
		{
			bool? status = DefinedObjectClass_Event?.Invoke (reason, kind, p_DefinedObjectClass);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinedObjectClass
		//
		// traverse syntax tree node associated with any production of syntax rule DefinedObjectClass
		//

		public void Traverse (DefinedObjectClass p_DefinedObjectClass)
		{
			if (p_DefinedObjectClass.isLocked())
				return;
			p_DefinedObjectClass.dolock();
			DefinedObjectClass.production_kind kind = (DefinedObjectClass.production_kind) p_DefinedObjectClass.kind;
			p_DefinedObjectClass.turn_reset ();
			if (Raise_DefinedObjectClass_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinedObjectClass))
			switch (kind)
			{
				case DefinedObjectClass.production_kind.g_DefinedObjectClass_1:
					// traverse syntax tree node associated with production
					// DefinedObjectClass: ExternalObjectClassReference

					if (Raise_DefinedObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObjectClass))
						Traverse (p_DefinedObjectClass.m_ExternalObjectClassReference);
					p_DefinedObjectClass.turn_inc ();
					Raise_DefinedObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObjectClass);
				break;
				case DefinedObjectClass.production_kind.g_DefinedObjectClass_2:
					// traverse syntax tree node associated with production
					// DefinedObjectClass: objectclassreference-token

					if (Raise_DefinedObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObjectClass))
						Traverse (p_DefinedObjectClass.m_objectclassreference_token);
					p_DefinedObjectClass.turn_inc ();
					Raise_DefinedObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObjectClass);
				break;
				case DefinedObjectClass.production_kind.g_DefinedObjectClass_3:
					// traverse syntax tree node associated with production
					// DefinedObjectClass: UsefulObjectClassReference

					if (Raise_DefinedObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObjectClass))
						Traverse (p_DefinedObjectClass.m_UsefulObjectClassReference);
					p_DefinedObjectClass.turn_inc ();
					Raise_DefinedObjectClass_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedObjectClass);
				break;
			}
			Raise_DefinedObjectClass_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinedObjectClass);
			p_DefinedObjectClass.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedObjectClass
		//

		public void TraverseCommon (DefinedObjectClass p_DefinedObjectClass)
		{
			DefinedObjectClass.production_kind kind = (DefinedObjectClass.production_kind) p_DefinedObjectClass.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinedObjectClass))
			switch (kind)
			{
				case DefinedObjectClass.production_kind.g_DefinedObjectClass_1:
					// traverse syntax tree node associated with production
					// DefinedObjectClass: ExternalObjectClassReference

						TraverseCommon (p_DefinedObjectClass.m_ExternalObjectClassReference);
				break;
				case DefinedObjectClass.production_kind.g_DefinedObjectClass_2:
					// traverse syntax tree node associated with production
					// DefinedObjectClass: objectclassreference-token

						TraverseCommon (p_DefinedObjectClass.m_objectclassreference_token);
				break;
				case DefinedObjectClass.production_kind.g_DefinedObjectClass_3:
					// traverse syntax tree node associated with production
					// DefinedObjectClass: UsefulObjectClassReference

						TraverseCommon (p_DefinedObjectClass.m_UsefulObjectClassReference);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinedObjectClass);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinedObjectClass

		//
		// create syntax tree node associated with production
		// DefinedObjectClass: ExternalObjectClassReference

		//

		public DefinedObjectClass DefinedObjectClass_1 (ExternalObjectClassReference p_ExternalObjectClassReference)
		{
			DefinedObjectClass p_DefinedObjectClass_ref = new DefinedObjectClass(p_ExternalObjectClassReference);
			p_ExternalObjectClassReference.parent = p_DefinedObjectClass_ref;
			Raise_DefinedObjectClass_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedObjectClass.production_kind.g_DefinedObjectClass_1, p_DefinedObjectClass_ref);
			return p_DefinedObjectClass_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinedObjectClass: objectclassreference-token

		//

		public DefinedObjectClass DefinedObjectClass_2 (objectclassreference_token p_objectclassreference_token)
		{
			DefinedObjectClass p_DefinedObjectClass_ref = new DefinedObjectClass(p_objectclassreference_token);
			p_objectclassreference_token.parent = p_DefinedObjectClass_ref;
			Raise_DefinedObjectClass_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedObjectClass.production_kind.g_DefinedObjectClass_2, p_DefinedObjectClass_ref);
			return p_DefinedObjectClass_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinedObjectClass: UsefulObjectClassReference

		//

		public DefinedObjectClass DefinedObjectClass_3 (UsefulObjectClassReference p_UsefulObjectClassReference)
		{
			DefinedObjectClass p_DefinedObjectClass_ref = new DefinedObjectClass(p_UsefulObjectClassReference);
			p_UsefulObjectClassReference.parent = p_DefinedObjectClass_ref;
			Raise_DefinedObjectClass_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedObjectClass.production_kind.g_DefinedObjectClass_3, p_DefinedObjectClass_ref);
			return p_DefinedObjectClass_ref;
		}
		#endregion
	};
}
