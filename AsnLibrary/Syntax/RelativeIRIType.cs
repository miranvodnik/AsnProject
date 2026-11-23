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
	// class associated with syntax rule RelativeIRIType
	//

	[DataContract]
	public class	RelativeIRIType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RelativeIRIType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RelativeIRIType
		{
			g_RelativeIRIType_1 = 1,	// RELATIVE-OID-IRI

		};
		#endregion
		#region production markers associated with the syntax rule RelativeIRIType

		// markers associated with production: RelativeIRIType -> RELATIVE-OID-IRI

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RelativeIRIType

		// Constructor declaration(s) associated with production(s) of syntax rule RelativeIRIType

		//
		// Constructor associated with the following production(s)
		// RelativeIRIType -> RELATIVE-OID-IRI

		//

		public RelativeIRIType (SyntaxTreeToken p_token) : base ((uint) ProductionID._RelativeIRIType_ID, (uint) production_kind.g_RelativeIRIType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RELATIVE_OID_IRI = p_token;
		}

		public RelativeIRIType () { }

		// Copy constructor

		public RelativeIRIType (RelativeIRIType p_RelativeIRIType) : base (p_RelativeIRIType.id, p_RelativeIRIType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RelativeIRIType.appInfo;
			switch ((production_kind) p_RelativeIRIType.kind)
			{
				case production_kind.g_RelativeIRIType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RELATIVE_OID_IRI = (p_RelativeIRIType.m_RELATIVE_OID_IRI != null) ? new SyntaxTreeToken (p_RelativeIRIType.m_RELATIVE_OID_IRI) : null) != null) m_RELATIVE_OID_IRI.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RelativeIRIType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RelativeIRIType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_RELATIVE_OID_IRI?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RelativeIRIType

		// Content changing function(s) associated with production(s) of syntax rule RelativeIRIType

		//
		// Content changing function associated with following production(s)
		// RelativeIRIType -> RELATIVE-OID-IRI

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_RelativeIRIType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RELATIVE_OID_IRI = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RelativeIRIType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_RELATIVE_OID_IRI != null) && m_RELATIVE_OID_IRI.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RelativeIRIType

		//
		// emit production tree node associated with any production of syntax rule RelativeIRIType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RelativeIRIType_1:
					// emit syntax tree node associated with production
					// RelativeIRIType: RELATIVE-OID-IRI

					s += m_RELATIVE_OID_IRI.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RelativeIRIType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RelativeIRIType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RelativeIRIType_1:
					// emit syntax tree node associated with production
					// RelativeIRIType: RELATIVE-OID-IRI

					s += "RELATIVE_OID_IRI";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RelativeIRIType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RelativeIRIType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RelativeIRIType.production_kind kind = (RelativeIRIType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RelativeIRIType.production_kind.g_RelativeIRIType_1:
					// traverse syntax tree node associated with production
					// RelativeIRIType: RELATIVE-OID-IRI

						m_RELATIVE_OID_IRI.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_RELATIVE_OID_IRI?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RelativeIRIType
		//

		public void _init ()
		{
			m_RELATIVE_OID_IRI = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RelativeIRIType

		// counter of all nodes associated with syntax rule RelativeIRIType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RelativeIRIType
		[DataMember (Name = "m_RELATIVE_OID_IRI")] public SyntaxTreeToken m_RELATIVE_OID_IRI { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RelativeIRIType

		// delegate function (callback) prototype associated with syntax rule RelativeIRIType
		public delegate bool RelativeIRIType_Callback (SyntaxTreeCallbackReason reason, RelativeIRIType.production_kind kind, RelativeIRIType p_RelativeIRIType);

		// event associated with syntax rule RelativeIRIType
		public event RelativeIRIType_Callback RelativeIRIType_Event;

		// event trigger associated with syntax rule RelativeIRIType
		public bool Raise_RelativeIRIType_Event (SyntaxTreeCallbackReason reason, RelativeIRIType.production_kind kind, RelativeIRIType p_RelativeIRIType)
		{
			bool? status = RelativeIRIType_Event?.Invoke (reason, kind, p_RelativeIRIType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RelativeIRIType
		//
		// traverse syntax tree node associated with any production of syntax rule RelativeIRIType
		//

		public void Traverse (RelativeIRIType p_RelativeIRIType)
		{
			if (p_RelativeIRIType.isLocked())
				return;
			p_RelativeIRIType.dolock();
			RelativeIRIType.production_kind kind = (RelativeIRIType.production_kind) p_RelativeIRIType.kind;
			p_RelativeIRIType.turn_reset ();
			if (Raise_RelativeIRIType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RelativeIRIType))
			switch (kind)
			{
				case RelativeIRIType.production_kind.g_RelativeIRIType_1:
					// traverse syntax tree node associated with production
					// RelativeIRIType: RELATIVE-OID-IRI

				break;
			}
			Raise_RelativeIRIType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RelativeIRIType);
			p_RelativeIRIType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RelativeIRIType
		//

		public void TraverseCommon (RelativeIRIType p_RelativeIRIType)
		{
			RelativeIRIType.production_kind kind = (RelativeIRIType.production_kind) p_RelativeIRIType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RelativeIRIType))
			switch (kind)
			{
				case RelativeIRIType.production_kind.g_RelativeIRIType_1:
					// traverse syntax tree node associated with production
					// RelativeIRIType: RELATIVE-OID-IRI

						TraverseCommon (p_RelativeIRIType.m_RELATIVE_OID_IRI);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RelativeIRIType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RelativeIRIType

		//
		// create syntax tree node associated with production
		// RelativeIRIType: RELATIVE-OID-IRI

		//

		public RelativeIRIType RelativeIRIType_1 (SyntaxTreeToken p_token)
		{
			RelativeIRIType p_RelativeIRIType_ref = new RelativeIRIType(p_token);
			p_token.parent = p_RelativeIRIType_ref;
			Raise_RelativeIRIType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RelativeIRIType.production_kind.g_RelativeIRIType_1, p_RelativeIRIType_ref);
			return p_RelativeIRIType_ref;
		}
		#endregion
	};
}
