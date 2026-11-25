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
	// class associated with syntax rule SimpleDefinedType
	//

	[DataContract]
	public class	SimpleDefinedType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SimpleDefinedType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SimpleDefinedType
		{
			g_SimpleDefinedType_1 = 1,	// ExternalTypeReference

			g_SimpleDefinedType_2 = 2,	// typereference-token

		};
		#endregion
		#region production markers associated with the syntax rule SimpleDefinedType

		// markers associated with production: SimpleDefinedType -> ExternalTypeReference

		public enum production_marker_1 : ushort
		{
			m_ExternalTypeReference,
			final
		};

		// markers associated with production: SimpleDefinedType -> typereference-token

		public enum production_marker_2 : ushort
		{
			m_typereference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SimpleDefinedType

		// Constructor declaration(s) associated with production(s) of syntax rule SimpleDefinedType

		//
		// Constructor associated with the following production(s)
		// SimpleDefinedType -> ExternalTypeReference

		//

		public SimpleDefinedType (ExternalTypeReference p_ExternalTypeReference) : base ((uint) ProductionID._SimpleDefinedType_ID, (uint) production_kind.g_SimpleDefinedType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExternalTypeReference = p_ExternalTypeReference;
		}

		//
		// Constructor associated with the following production(s)
		// SimpleDefinedType -> typereference-token

		//

		public SimpleDefinedType (typereference_token p_typereference_token) : base ((uint) ProductionID._SimpleDefinedType_ID, (uint) production_kind.g_SimpleDefinedType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_typereference_token = p_typereference_token;
		}

		public SimpleDefinedType () { }

		// Copy constructor

		public SimpleDefinedType (SimpleDefinedType p_SimpleDefinedType) : base (p_SimpleDefinedType.id, p_SimpleDefinedType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SimpleDefinedType.appInfo;
			switch ((production_kind) p_SimpleDefinedType.kind)
			{
				case production_kind.g_SimpleDefinedType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExternalTypeReference = (p_SimpleDefinedType.m_ExternalTypeReference != null) ? new ExternalTypeReference (p_SimpleDefinedType.m_ExternalTypeReference) : null) != null) m_ExternalTypeReference.parent = this;
					break;
				case production_kind.g_SimpleDefinedType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_typereference_token = (p_SimpleDefinedType.m_typereference_token != null) ? new typereference_token (p_SimpleDefinedType.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SimpleDefinedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SimpleDefinedType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ExternalTypeReference?.Dispose ();
			m_typereference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SimpleDefinedType

		// Content changing function(s) associated with production(s) of syntax rule SimpleDefinedType

		//
		// Content changing function associated with following production(s)
		// SimpleDefinedType -> ExternalTypeReference

		//

		public void change(ExternalTypeReference p_ExternalTypeReference)
		{
			_init ();
			this.kind = (uint) production_kind.g_SimpleDefinedType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExternalTypeReference = p_ExternalTypeReference;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SimpleDefinedType -> typereference-token

		//

		public void change(typereference_token p_typereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_SimpleDefinedType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_typereference_token = p_typereference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SimpleDefinedType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ExternalTypeReference != null) && m_ExternalTypeReference.checkInclusion (element) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SimpleDefinedType

		//
		// emit production tree node associated with any production of syntax rule SimpleDefinedType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SimpleDefinedType_1:
					// emit syntax tree node associated with production
					// SimpleDefinedType: ExternalTypeReference

					s += m_ExternalTypeReference.Emit (depth - 1);
				break;
				case production_kind.g_SimpleDefinedType_2:
					// emit syntax tree node associated with production
					// SimpleDefinedType: typereference-token

					s += m_typereference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SimpleDefinedType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SimpleDefinedType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SimpleDefinedType_1:
					// emit syntax tree node associated with production
					// SimpleDefinedType: ExternalTypeReference

					s += m_ExternalTypeReference.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SimpleDefinedType_2:
					// emit syntax tree node associated with production
					// SimpleDefinedType: typereference-token

					s += m_typereference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SimpleDefinedType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SimpleDefinedType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SimpleDefinedType.production_kind kind = (SimpleDefinedType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SimpleDefinedType.production_kind.g_SimpleDefinedType_1:
					// traverse syntax tree node associated with production
					// SimpleDefinedType: ExternalTypeReference

						m_ExternalTypeReference.Visit (visitor, appData);
				break;
				case SimpleDefinedType.production_kind.g_SimpleDefinedType_2:
					// traverse syntax tree node associated with production
					// SimpleDefinedType: typereference-token

						m_typereference_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ExternalTypeReference?.reparent (this);
			m_typereference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SimpleDefinedType
		//

		public void _init ()
		{
			m_ExternalTypeReference = null;
			m_typereference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SimpleDefinedType

		// counter of all nodes associated with syntax rule SimpleDefinedType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SimpleDefinedType
		[DataMember (Name = "m_ExternalTypeReference")] public ExternalTypeReference m_ExternalTypeReference { get; private set; }
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SimpleDefinedType

		// delegate function (callback) prototype associated with syntax rule SimpleDefinedType
		public delegate bool SimpleDefinedType_Callback (SyntaxTreeCallbackReason reason, SimpleDefinedType.production_kind kind, SimpleDefinedType p_SimpleDefinedType);

		// event associated with syntax rule SimpleDefinedType
		public event SimpleDefinedType_Callback SimpleDefinedType_Event;

		// event trigger associated with syntax rule SimpleDefinedType
		public bool Raise_SimpleDefinedType_Event (SyntaxTreeCallbackReason reason, SimpleDefinedType.production_kind kind, SimpleDefinedType p_SimpleDefinedType)
		{
			bool? status = SimpleDefinedType_Event?.Invoke (reason, kind, p_SimpleDefinedType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SimpleDefinedType
		//
		// traverse syntax tree node associated with any production of syntax rule SimpleDefinedType
		//

		public void Traverse (SimpleDefinedType p_SimpleDefinedType)
		{
			if (p_SimpleDefinedType.isLocked())
				return;
			p_SimpleDefinedType.dolock();
			SimpleDefinedType.production_kind kind = (SimpleDefinedType.production_kind) p_SimpleDefinedType.kind;
			p_SimpleDefinedType.turn_reset ();
			if (Raise_SimpleDefinedType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SimpleDefinedType))
			switch (kind)
			{
				case SimpleDefinedType.production_kind.g_SimpleDefinedType_1:
					// traverse syntax tree node associated with production
					// SimpleDefinedType: ExternalTypeReference

					if (Raise_SimpleDefinedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SimpleDefinedType))
						Traverse (p_SimpleDefinedType.m_ExternalTypeReference);
					p_SimpleDefinedType.turn_inc ();
					Raise_SimpleDefinedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SimpleDefinedType);
				break;
				case SimpleDefinedType.production_kind.g_SimpleDefinedType_2:
					// traverse syntax tree node associated with production
					// SimpleDefinedType: typereference-token

					if (Raise_SimpleDefinedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SimpleDefinedType))
						Traverse (p_SimpleDefinedType.m_typereference_token);
					p_SimpleDefinedType.turn_inc ();
					Raise_SimpleDefinedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SimpleDefinedType);
				break;
			}
			Raise_SimpleDefinedType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SimpleDefinedType);
			p_SimpleDefinedType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SimpleDefinedType
		//

		public void TraverseCommon (SimpleDefinedType p_SimpleDefinedType)
		{
			SimpleDefinedType.production_kind kind = (SimpleDefinedType.production_kind) p_SimpleDefinedType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SimpleDefinedType))
			switch (kind)
			{
				case SimpleDefinedType.production_kind.g_SimpleDefinedType_1:
					// traverse syntax tree node associated with production
					// SimpleDefinedType: ExternalTypeReference

						TraverseCommon (p_SimpleDefinedType.m_ExternalTypeReference);
				break;
				case SimpleDefinedType.production_kind.g_SimpleDefinedType_2:
					// traverse syntax tree node associated with production
					// SimpleDefinedType: typereference-token

						TraverseCommon (p_SimpleDefinedType.m_typereference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SimpleDefinedType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SimpleDefinedType

		//
		// create syntax tree node associated with production
		// SimpleDefinedType: ExternalTypeReference

		//

		public SimpleDefinedType SimpleDefinedType_1 (ExternalTypeReference p_ExternalTypeReference)
		{
			SimpleDefinedType p_SimpleDefinedType_ref = new SimpleDefinedType(p_ExternalTypeReference);
			p_ExternalTypeReference.parent = p_SimpleDefinedType_ref;
			Raise_SimpleDefinedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SimpleDefinedType.production_kind.g_SimpleDefinedType_1, p_SimpleDefinedType_ref);
			return p_SimpleDefinedType_ref;
		}

		//
		// create syntax tree node associated with production
		// SimpleDefinedType: typereference-token

		//

		public SimpleDefinedType SimpleDefinedType_2 (typereference_token p_typereference_token)
		{
			SimpleDefinedType p_SimpleDefinedType_ref = new SimpleDefinedType(p_typereference_token);
			p_typereference_token.parent = p_SimpleDefinedType_ref;
			Raise_SimpleDefinedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SimpleDefinedType.production_kind.g_SimpleDefinedType_2, p_SimpleDefinedType_ref);
			return p_SimpleDefinedType_ref;
		}
		#endregion
	};
}
