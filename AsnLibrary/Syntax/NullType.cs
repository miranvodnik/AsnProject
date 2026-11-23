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
	// class associated with syntax rule NullType
	//

	[DataContract]
	public class	NullType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NullType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NullType
		{
			g_NullType_1 = 1,	// NULL

		};
		#endregion
		#region production markers associated with the syntax rule NullType

		// markers associated with production: NullType -> NULL

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NullType

		// Constructor declaration(s) associated with production(s) of syntax rule NullType

		//
		// Constructor associated with the following production(s)
		// NullType -> NULL

		//

		public NullType (SyntaxTreeToken p_token) : base ((uint) ProductionID._NullType_ID, (uint) production_kind.g_NullType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_NULL = p_token;
		}

		public NullType () { }

		// Copy constructor

		public NullType (NullType p_NullType) : base (p_NullType.id, p_NullType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NullType.appInfo;
			switch ((production_kind) p_NullType.kind)
			{
				case production_kind.g_NullType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_NULL = (p_NullType.m_NULL != null) ? new SyntaxTreeToken (p_NullType.m_NULL) : null) != null) m_NULL.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NullType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NullType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_NULL?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NullType

		// Content changing function(s) associated with production(s) of syntax rule NullType

		//
		// Content changing function associated with following production(s)
		// NullType -> NULL

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_NullType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_NULL = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NullType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_NULL != null) && m_NULL.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NullType

		//
		// emit production tree node associated with any production of syntax rule NullType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NullType_1:
					// emit syntax tree node associated with production
					// NullType: NULL

					s += m_NULL.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NullType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NullType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NullType_1:
					// emit syntax tree node associated with production
					// NullType: NULL

					s += "NULL";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NullType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NullType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NullType.production_kind kind = (NullType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NullType.production_kind.g_NullType_1:
					// traverse syntax tree node associated with production
					// NullType: NULL

						m_NULL.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_NULL?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NullType
		//

		public void _init ()
		{
			m_NULL = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NullType

		// counter of all nodes associated with syntax rule NullType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NullType
		[DataMember (Name = "m_NULL")] public SyntaxTreeToken m_NULL { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NullType

		// delegate function (callback) prototype associated with syntax rule NullType
		public delegate bool NullType_Callback (SyntaxTreeCallbackReason reason, NullType.production_kind kind, NullType p_NullType);

		// event associated with syntax rule NullType
		public event NullType_Callback NullType_Event;

		// event trigger associated with syntax rule NullType
		public bool Raise_NullType_Event (SyntaxTreeCallbackReason reason, NullType.production_kind kind, NullType p_NullType)
		{
			bool? status = NullType_Event?.Invoke (reason, kind, p_NullType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NullType
		//
		// traverse syntax tree node associated with any production of syntax rule NullType
		//

		public void Traverse (NullType p_NullType)
		{
			if (p_NullType.isLocked())
				return;
			p_NullType.dolock();
			NullType.production_kind kind = (NullType.production_kind) p_NullType.kind;
			p_NullType.turn_reset ();
			if (Raise_NullType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NullType))
			switch (kind)
			{
				case NullType.production_kind.g_NullType_1:
					// traverse syntax tree node associated with production
					// NullType: NULL

				break;
			}
			Raise_NullType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NullType);
			p_NullType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NullType
		//

		public void TraverseCommon (NullType p_NullType)
		{
			NullType.production_kind kind = (NullType.production_kind) p_NullType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NullType))
			switch (kind)
			{
				case NullType.production_kind.g_NullType_1:
					// traverse syntax tree node associated with production
					// NullType: NULL

						TraverseCommon (p_NullType.m_NULL);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NullType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NullType

		//
		// create syntax tree node associated with production
		// NullType: NULL

		//

		public NullType NullType_1 (SyntaxTreeToken p_token)
		{
			NullType p_NullType_ref = new NullType(p_token);
			p_token.parent = p_NullType_ref;
			Raise_NullType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NullType.production_kind.g_NullType_1, p_NullType_ref);
			return p_NullType_ref;
		}
		#endregion
	};
}
