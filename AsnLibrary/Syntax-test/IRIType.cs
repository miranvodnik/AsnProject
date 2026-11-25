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
	// class associated with syntax rule IRIType
	//

	[DataContract]
	public class	IRIType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule IRIType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule IRIType
		{
			g_IRIType_1 = 1,	// OID-IRI

		};
		#endregion
		#region production markers associated with the syntax rule IRIType

		// markers associated with production: IRIType -> OID-IRI

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule IRIType

		// Constructor declaration(s) associated with production(s) of syntax rule IRIType

		//
		// Constructor associated with the following production(s)
		// IRIType -> OID-IRI

		//

		public IRIType (SyntaxTreeToken p_token) : base ((uint) ProductionID._IRIType_ID, (uint) production_kind.g_IRIType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OID_IRI = p_token;
		}

		public IRIType () { }

		// Copy constructor

		public IRIType (IRIType p_IRIType) : base (p_IRIType.id, p_IRIType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_IRIType.appInfo;
			switch ((production_kind) p_IRIType.kind)
			{
				case production_kind.g_IRIType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OID_IRI = (p_IRIType.m_OID_IRI != null) ? new SyntaxTreeToken (p_IRIType.m_OID_IRI) : null) != null) m_OID_IRI.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "IRIType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new IRIType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OID_IRI?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule IRIType

		// Content changing function(s) associated with production(s) of syntax rule IRIType

		//
		// Content changing function associated with following production(s)
		// IRIType -> OID-IRI

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_IRIType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OID_IRI = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule IRIType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OID_IRI != null) && m_OID_IRI.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule IRIType

		//
		// emit production tree node associated with any production of syntax rule IRIType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_IRIType_1:
					// emit syntax tree node associated with production
					// IRIType: OID-IRI

					s += m_OID_IRI.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule IRIType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "IRIType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_IRIType_1:
					// emit syntax tree node associated with production
					// IRIType: OID-IRI

					s += "OID_IRI";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule IRIType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule IRIType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			IRIType.production_kind kind = (IRIType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case IRIType.production_kind.g_IRIType_1:
					// traverse syntax tree node associated with production
					// IRIType: OID-IRI

						m_OID_IRI.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_OID_IRI?.reparent (this);
		}

		//
		// initialize object associated with syntax rule IRIType
		//

		public void _init ()
		{
			m_OID_IRI = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule IRIType

		// counter of all nodes associated with syntax rule IRIType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule IRIType
		[DataMember (Name = "m_OID_IRI")] public SyntaxTreeToken m_OID_IRI { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule IRIType

		// delegate function (callback) prototype associated with syntax rule IRIType
		public delegate bool IRIType_Callback (SyntaxTreeCallbackReason reason, IRIType.production_kind kind, IRIType p_IRIType);

		// event associated with syntax rule IRIType
		public event IRIType_Callback IRIType_Event;

		// event trigger associated with syntax rule IRIType
		public bool Raise_IRIType_Event (SyntaxTreeCallbackReason reason, IRIType.production_kind kind, IRIType p_IRIType)
		{
			bool? status = IRIType_Event?.Invoke (reason, kind, p_IRIType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule IRIType
		//
		// traverse syntax tree node associated with any production of syntax rule IRIType
		//

		public void Traverse (IRIType p_IRIType)
		{
			if (p_IRIType.isLocked())
				return;
			p_IRIType.dolock();
			IRIType.production_kind kind = (IRIType.production_kind) p_IRIType.kind;
			p_IRIType.turn_reset ();
			if (Raise_IRIType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_IRIType))
			switch (kind)
			{
				case IRIType.production_kind.g_IRIType_1:
					// traverse syntax tree node associated with production
					// IRIType: OID-IRI

				break;
			}
			Raise_IRIType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_IRIType);
			p_IRIType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule IRIType
		//

		public void TraverseCommon (IRIType p_IRIType)
		{
			IRIType.production_kind kind = (IRIType.production_kind) p_IRIType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_IRIType))
			switch (kind)
			{
				case IRIType.production_kind.g_IRIType_1:
					// traverse syntax tree node associated with production
					// IRIType: OID-IRI

						TraverseCommon (p_IRIType.m_OID_IRI);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_IRIType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule IRIType

		//
		// create syntax tree node associated with production
		// IRIType: OID-IRI

		//

		public IRIType IRIType_1 (SyntaxTreeToken p_token)
		{
			IRIType p_IRIType_ref = new IRIType(p_token);
			p_token.parent = p_IRIType_ref;
			Raise_IRIType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, IRIType.production_kind.g_IRIType_1, p_IRIType_ref);
			return p_IRIType_ref;
		}
		#endregion
	};
}
