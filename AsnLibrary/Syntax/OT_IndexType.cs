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
	// class associated with syntax rule OT-IndexType
	//

	[DataContract]
	public class	OT_IndexType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OT-IndexType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OT-IndexType
		{
			g_OT_IndexType_1 = 1,	// IMPLIED OT-Index

			g_OT_IndexType_2 = 2,	// OT-Index

		};
		#endregion
		#region production markers associated with the syntax rule OT-IndexType

		// markers associated with production: OT-IndexType -> IMPLIED OT-Index

		public enum production_marker_1 : ushort
		{
			m_OT_Index,
			final
		};

		// markers associated with production: OT-IndexType -> OT-Index

		public enum production_marker_2 : ushort
		{
			m_OT_Index,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OT-IndexType

		// Constructor declaration(s) associated with production(s) of syntax rule OT-IndexType

		//
		// Constructor associated with the following production(s)
		// OT-IndexType -> IMPLIED OT-Index

		//

		public OT_IndexType (SyntaxTreeToken p_token, OT_Index p_OT_Index) : base ((uint) ProductionID._OT_IndexType_ID, (uint) production_kind.g_OT_IndexType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_IMPLIED = p_token;
			children[1] = m_OT_Index = p_OT_Index;
		}

		//
		// Constructor associated with the following production(s)
		// OT-IndexType -> OT-Index

		//

		public OT_IndexType (OT_Index p_OT_Index) : base ((uint) ProductionID._OT_IndexType_ID, (uint) production_kind.g_OT_IndexType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OT_Index = p_OT_Index;
		}

		public OT_IndexType () { }

		// Copy constructor

		public OT_IndexType (OT_IndexType p_OT_IndexType) : base (p_OT_IndexType.id, p_OT_IndexType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OT_IndexType.appInfo;
			switch ((production_kind) p_OT_IndexType.kind)
			{
				case production_kind.g_OT_IndexType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_IMPLIED = (p_OT_IndexType.m_IMPLIED != null) ? new SyntaxTreeToken (p_OT_IndexType.m_IMPLIED) : null) != null) m_IMPLIED.parent = this;
					if ((children [1] = m_OT_Index = (p_OT_IndexType.m_OT_Index != null) ? new OT_Index (p_OT_IndexType.m_OT_Index) : null) != null) m_OT_Index.parent = this;
					break;
				case production_kind.g_OT_IndexType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OT_Index = (p_OT_IndexType.m_OT_Index != null) ? new OT_Index (p_OT_IndexType.m_OT_Index) : null) != null) m_OT_Index.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OT_IndexType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OT_IndexType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_IMPLIED?.Dispose ();
			m_OT_Index?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OT-IndexType

		// Content changing function(s) associated with production(s) of syntax rule OT-IndexType

		//
		// Content changing function associated with following production(s)
		// OT-IndexType -> IMPLIED OT-Index

		//

		public void change(SyntaxTreeToken p_token, OT_Index p_OT_Index)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_IndexType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_IMPLIED = p_token;
			children [1] = m_OT_Index = p_OT_Index;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OT-IndexType -> OT-Index

		//

		public void change(OT_Index p_OT_Index)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_IndexType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OT_Index = p_OT_Index;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OT-IndexType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_IMPLIED != null) && m_IMPLIED.checkInclusion (element) ||
				(m_OT_Index != null) && m_OT_Index.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OT-IndexType

		//
		// emit production tree node associated with any production of syntax rule OT-IndexType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OT_IndexType_1:
					// emit syntax tree node associated with production
					// OT-IndexType: IMPLIED OT-Index

					s += m_IMPLIED.Emit (depth - 1);
					s += " ";
					s += m_OT_Index.Emit (depth - 1);
				break;
				case production_kind.g_OT_IndexType_2:
					// emit syntax tree node associated with production
					// OT-IndexType: OT-Index

					s += m_OT_Index.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OT-IndexType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OT_IndexType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OT_IndexType_1:
					// emit syntax tree node associated with production
					// OT-IndexType: IMPLIED OT-Index

					s += "IMPLIED";
					s += ' ';
					s += m_OT_Index.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_OT_IndexType_2:
					// emit syntax tree node associated with production
					// OT-IndexType: OT-Index

					s += m_OT_Index.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OT-IndexType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OT-IndexType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OT_IndexType.production_kind kind = (OT_IndexType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OT_IndexType.production_kind.g_OT_IndexType_1:
					// traverse syntax tree node associated with production
					// OT-IndexType: IMPLIED OT-Index

						m_IMPLIED.Visit (visitor, appData);
						m_OT_Index.Visit (visitor, appData);
				break;
				case OT_IndexType.production_kind.g_OT_IndexType_2:
					// traverse syntax tree node associated with production
					// OT-IndexType: OT-Index

						m_OT_Index.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_IMPLIED?.reparent (this);
			m_OT_Index?.reparent (this);
		}

		//
		// initialize object associated with syntax rule OT-IndexType
		//

		public void _init ()
		{
			m_IMPLIED = null;
			m_OT_Index = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OT-IndexType

		// counter of all nodes associated with syntax rule OT-IndexType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OT-IndexType
		[DataMember (Name = "m_IMPLIED")] public SyntaxTreeToken m_IMPLIED { get; private set; }
		[DataMember (Name = "m_OT_Index")] public OT_Index m_OT_Index { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OT-IndexType

		// delegate function (callback) prototype associated with syntax rule OT-IndexType
		public delegate bool OT_IndexType_Callback (SyntaxTreeCallbackReason reason, OT_IndexType.production_kind kind, OT_IndexType p_OT_IndexType);

		// event associated with syntax rule OT-IndexType
		public event OT_IndexType_Callback OT_IndexType_Event;

		// event trigger associated with syntax rule OT-IndexType
		public bool Raise_OT_IndexType_Event (SyntaxTreeCallbackReason reason, OT_IndexType.production_kind kind, OT_IndexType p_OT_IndexType)
		{
			bool? status = OT_IndexType_Event?.Invoke (reason, kind, p_OT_IndexType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OT-IndexType
		//
		// traverse syntax tree node associated with any production of syntax rule OT-IndexType
		//

		public void Traverse (OT_IndexType p_OT_IndexType)
		{
			if (p_OT_IndexType.isLocked())
				return;
			p_OT_IndexType.dolock();
			OT_IndexType.production_kind kind = (OT_IndexType.production_kind) p_OT_IndexType.kind;
			p_OT_IndexType.turn_reset ();
			if (Raise_OT_IndexType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OT_IndexType))
			switch (kind)
			{
				case OT_IndexType.production_kind.g_OT_IndexType_1:
					// traverse syntax tree node associated with production
					// OT-IndexType: IMPLIED OT-Index

					if (Raise_OT_IndexType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_IndexType))
						Traverse (p_OT_IndexType.m_OT_Index);
					p_OT_IndexType.turn_inc ();
					Raise_OT_IndexType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_IndexType);
				break;
				case OT_IndexType.production_kind.g_OT_IndexType_2:
					// traverse syntax tree node associated with production
					// OT-IndexType: OT-Index

					if (Raise_OT_IndexType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_IndexType))
						Traverse (p_OT_IndexType.m_OT_Index);
					p_OT_IndexType.turn_inc ();
					Raise_OT_IndexType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_IndexType);
				break;
			}
			Raise_OT_IndexType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OT_IndexType);
			p_OT_IndexType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OT-IndexType
		//

		public void TraverseCommon (OT_IndexType p_OT_IndexType)
		{
			OT_IndexType.production_kind kind = (OT_IndexType.production_kind) p_OT_IndexType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OT_IndexType))
			switch (kind)
			{
				case OT_IndexType.production_kind.g_OT_IndexType_1:
					// traverse syntax tree node associated with production
					// OT-IndexType: IMPLIED OT-Index

						TraverseCommon (p_OT_IndexType.m_IMPLIED);
						TraverseCommon (p_OT_IndexType.m_OT_Index);
				break;
				case OT_IndexType.production_kind.g_OT_IndexType_2:
					// traverse syntax tree node associated with production
					// OT-IndexType: OT-Index

						TraverseCommon (p_OT_IndexType.m_OT_Index);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OT_IndexType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OT-IndexType

		//
		// create syntax tree node associated with production
		// OT-IndexType: IMPLIED OT-Index

		//

		public OT_IndexType OT_IndexType_1 (SyntaxTreeToken p_token, OT_Index p_OT_Index)
		{
			OT_IndexType p_OT_IndexType_ref = new OT_IndexType(p_token, p_OT_Index);
			p_token.parent = p_OT_IndexType_ref;
			p_OT_Index.parent = p_OT_IndexType_ref;
			Raise_OT_IndexType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_IndexType.production_kind.g_OT_IndexType_1, p_OT_IndexType_ref);
			return p_OT_IndexType_ref;
		}

		//
		// create syntax tree node associated with production
		// OT-IndexType: OT-Index

		//

		public OT_IndexType OT_IndexType_2 (OT_Index p_OT_Index)
		{
			OT_IndexType p_OT_IndexType_ref = new OT_IndexType(p_OT_Index);
			p_OT_Index.parent = p_OT_IndexType_ref;
			Raise_OT_IndexType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_IndexType.production_kind.g_OT_IndexType_2, p_OT_IndexType_ref);
			return p_OT_IndexType_ref;
		}
		#endregion
	};
}
