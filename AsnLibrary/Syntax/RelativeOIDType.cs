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
	// class associated with syntax rule RelativeOIDType
	//

	[DataContract]
	public class	RelativeOIDType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RelativeOIDType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RelativeOIDType
		{
			g_RelativeOIDType_1 = 1,	// RELATIVE-OID

		};
		#endregion
		#region production markers associated with the syntax rule RelativeOIDType

		// markers associated with production: RelativeOIDType -> RELATIVE-OID

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RelativeOIDType

		// Constructor declaration(s) associated with production(s) of syntax rule RelativeOIDType

		//
		// Constructor associated with the following production(s)
		// RelativeOIDType -> RELATIVE-OID

		//

		public RelativeOIDType (SyntaxTreeToken p_token) : base ((uint) ProductionID._RelativeOIDType_ID, (uint) production_kind.g_RelativeOIDType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RELATIVE_OID = p_token;
		}

		public RelativeOIDType () { }

		// Copy constructor

		public RelativeOIDType (RelativeOIDType p_RelativeOIDType) : base (p_RelativeOIDType.id, p_RelativeOIDType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RelativeOIDType.appInfo;
			switch ((production_kind) p_RelativeOIDType.kind)
			{
				case production_kind.g_RelativeOIDType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RELATIVE_OID = (p_RelativeOIDType.m_RELATIVE_OID != null) ? new SyntaxTreeToken (p_RelativeOIDType.m_RELATIVE_OID) : null) != null) m_RELATIVE_OID.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RelativeOIDType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RelativeOIDType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_RELATIVE_OID?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RelativeOIDType

		// Content changing function(s) associated with production(s) of syntax rule RelativeOIDType

		//
		// Content changing function associated with following production(s)
		// RelativeOIDType -> RELATIVE-OID

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_RelativeOIDType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RELATIVE_OID = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RelativeOIDType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_RELATIVE_OID != null) && m_RELATIVE_OID.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RelativeOIDType

		//
		// emit production tree node associated with any production of syntax rule RelativeOIDType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RelativeOIDType_1:
					// emit syntax tree node associated with production
					// RelativeOIDType: RELATIVE-OID

					s += m_RELATIVE_OID.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RelativeOIDType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RelativeOIDType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RelativeOIDType_1:
					// emit syntax tree node associated with production
					// RelativeOIDType: RELATIVE-OID

					s += "RELATIVE_OID";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RelativeOIDType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RelativeOIDType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RelativeOIDType.production_kind kind = (RelativeOIDType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RelativeOIDType.production_kind.g_RelativeOIDType_1:
					// traverse syntax tree node associated with production
					// RelativeOIDType: RELATIVE-OID

						m_RELATIVE_OID.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_RELATIVE_OID?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RelativeOIDType
		//

		public void _init ()
		{
			m_RELATIVE_OID = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RelativeOIDType

		// counter of all nodes associated with syntax rule RelativeOIDType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RelativeOIDType
		[DataMember (Name = "m_RELATIVE_OID")] public SyntaxTreeToken m_RELATIVE_OID { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RelativeOIDType

		// delegate function (callback) prototype associated with syntax rule RelativeOIDType
		public delegate bool RelativeOIDType_Callback (SyntaxTreeCallbackReason reason, RelativeOIDType.production_kind kind, RelativeOIDType p_RelativeOIDType);

		// event associated with syntax rule RelativeOIDType
		public event RelativeOIDType_Callback RelativeOIDType_Event;

		// event trigger associated with syntax rule RelativeOIDType
		public bool Raise_RelativeOIDType_Event (SyntaxTreeCallbackReason reason, RelativeOIDType.production_kind kind, RelativeOIDType p_RelativeOIDType)
		{
			bool? status = RelativeOIDType_Event?.Invoke (reason, kind, p_RelativeOIDType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RelativeOIDType
		//
		// traverse syntax tree node associated with any production of syntax rule RelativeOIDType
		//

		public void Traverse (RelativeOIDType p_RelativeOIDType)
		{
			if (p_RelativeOIDType.isLocked())
				return;
			p_RelativeOIDType.dolock();
			RelativeOIDType.production_kind kind = (RelativeOIDType.production_kind) p_RelativeOIDType.kind;
			p_RelativeOIDType.turn_reset ();
			if (Raise_RelativeOIDType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RelativeOIDType))
			switch (kind)
			{
				case RelativeOIDType.production_kind.g_RelativeOIDType_1:
					// traverse syntax tree node associated with production
					// RelativeOIDType: RELATIVE-OID

				break;
			}
			Raise_RelativeOIDType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RelativeOIDType);
			p_RelativeOIDType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RelativeOIDType
		//

		public void TraverseCommon (RelativeOIDType p_RelativeOIDType)
		{
			RelativeOIDType.production_kind kind = (RelativeOIDType.production_kind) p_RelativeOIDType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RelativeOIDType))
			switch (kind)
			{
				case RelativeOIDType.production_kind.g_RelativeOIDType_1:
					// traverse syntax tree node associated with production
					// RelativeOIDType: RELATIVE-OID

						TraverseCommon (p_RelativeOIDType.m_RELATIVE_OID);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RelativeOIDType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RelativeOIDType

		//
		// create syntax tree node associated with production
		// RelativeOIDType: RELATIVE-OID

		//

		public RelativeOIDType RelativeOIDType_1 (SyntaxTreeToken p_token)
		{
			RelativeOIDType p_RelativeOIDType_ref = new RelativeOIDType(p_token);
			p_token.parent = p_RelativeOIDType_ref;
			Raise_RelativeOIDType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RelativeOIDType.production_kind.g_RelativeOIDType_1, p_RelativeOIDType_ref);
			return p_RelativeOIDType_ref;
		}
		#endregion
	};
}
