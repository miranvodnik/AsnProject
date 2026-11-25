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
	// class associated with syntax rule RealType
	//

	[DataContract]
	public class	RealType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RealType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RealType
		{
			g_RealType_1 = 1,	// REAL

		};
		#endregion
		#region production markers associated with the syntax rule RealType

		// markers associated with production: RealType -> REAL

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RealType

		// Constructor declaration(s) associated with production(s) of syntax rule RealType

		//
		// Constructor associated with the following production(s)
		// RealType -> REAL

		//

		public RealType (SyntaxTreeToken p_token) : base ((uint) ProductionID._RealType_ID, (uint) production_kind.g_RealType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_REAL = p_token;
		}

		public RealType () { }

		// Copy constructor

		public RealType (RealType p_RealType) : base (p_RealType.id, p_RealType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RealType.appInfo;
			switch ((production_kind) p_RealType.kind)
			{
				case production_kind.g_RealType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_REAL = (p_RealType.m_REAL != null) ? new SyntaxTreeToken (p_RealType.m_REAL) : null) != null) m_REAL.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RealType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RealType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_REAL?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RealType

		// Content changing function(s) associated with production(s) of syntax rule RealType

		//
		// Content changing function associated with following production(s)
		// RealType -> REAL

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_RealType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_REAL = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RealType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_REAL != null) && m_REAL.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RealType

		//
		// emit production tree node associated with any production of syntax rule RealType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RealType_1:
					// emit syntax tree node associated with production
					// RealType: REAL

					s += m_REAL.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RealType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RealType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RealType_1:
					// emit syntax tree node associated with production
					// RealType: REAL

					s += "REAL";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RealType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RealType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RealType.production_kind kind = (RealType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RealType.production_kind.g_RealType_1:
					// traverse syntax tree node associated with production
					// RealType: REAL

						m_REAL.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_REAL?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RealType
		//

		public void _init ()
		{
			m_REAL = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RealType

		// counter of all nodes associated with syntax rule RealType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RealType
		[DataMember (Name = "m_REAL")] public SyntaxTreeToken m_REAL { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RealType

		// delegate function (callback) prototype associated with syntax rule RealType
		public delegate bool RealType_Callback (SyntaxTreeCallbackReason reason, RealType.production_kind kind, RealType p_RealType);

		// event associated with syntax rule RealType
		public event RealType_Callback RealType_Event;

		// event trigger associated with syntax rule RealType
		public bool Raise_RealType_Event (SyntaxTreeCallbackReason reason, RealType.production_kind kind, RealType p_RealType)
		{
			bool? status = RealType_Event?.Invoke (reason, kind, p_RealType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RealType
		//
		// traverse syntax tree node associated with any production of syntax rule RealType
		//

		public void Traverse (RealType p_RealType)
		{
			if (p_RealType.isLocked())
				return;
			p_RealType.dolock();
			RealType.production_kind kind = (RealType.production_kind) p_RealType.kind;
			p_RealType.turn_reset ();
			if (Raise_RealType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RealType))
			switch (kind)
			{
				case RealType.production_kind.g_RealType_1:
					// traverse syntax tree node associated with production
					// RealType: REAL

				break;
			}
			Raise_RealType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RealType);
			p_RealType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RealType
		//

		public void TraverseCommon (RealType p_RealType)
		{
			RealType.production_kind kind = (RealType.production_kind) p_RealType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RealType))
			switch (kind)
			{
				case RealType.production_kind.g_RealType_1:
					// traverse syntax tree node associated with production
					// RealType: REAL

						TraverseCommon (p_RealType.m_REAL);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RealType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RealType

		//
		// create syntax tree node associated with production
		// RealType: REAL

		//

		public RealType RealType_1 (SyntaxTreeToken p_token)
		{
			RealType p_RealType_ref = new RealType(p_token);
			p_token.parent = p_RealType_ref;
			Raise_RealType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RealType.production_kind.g_RealType_1, p_RealType_ref);
			return p_RealType_ref;
		}
		#endregion
	};
}
