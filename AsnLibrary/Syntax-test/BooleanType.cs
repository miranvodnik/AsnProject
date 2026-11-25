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
	// class associated with syntax rule BooleanType
	//

	[DataContract]
	public class	BooleanType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule BooleanType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule BooleanType
		{
			g_BooleanType_1 = 1,	// BOOLEAN

		};
		#endregion
		#region production markers associated with the syntax rule BooleanType

		// markers associated with production: BooleanType -> BOOLEAN

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule BooleanType

		// Constructor declaration(s) associated with production(s) of syntax rule BooleanType

		//
		// Constructor associated with the following production(s)
		// BooleanType -> BOOLEAN

		//

		public BooleanType (SyntaxTreeToken p_token) : base ((uint) ProductionID._BooleanType_ID, (uint) production_kind.g_BooleanType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_BOOLEAN = p_token;
		}

		public BooleanType () { }

		// Copy constructor

		public BooleanType (BooleanType p_BooleanType) : base (p_BooleanType.id, p_BooleanType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_BooleanType.appInfo;
			switch ((production_kind) p_BooleanType.kind)
			{
				case production_kind.g_BooleanType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_BOOLEAN = (p_BooleanType.m_BOOLEAN != null) ? new SyntaxTreeToken (p_BooleanType.m_BOOLEAN) : null) != null) m_BOOLEAN.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "BooleanType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new BooleanType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_BOOLEAN?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule BooleanType

		// Content changing function(s) associated with production(s) of syntax rule BooleanType

		//
		// Content changing function associated with following production(s)
		// BooleanType -> BOOLEAN

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_BooleanType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_BOOLEAN = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule BooleanType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_BOOLEAN != null) && m_BOOLEAN.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule BooleanType

		//
		// emit production tree node associated with any production of syntax rule BooleanType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_BooleanType_1:
					// emit syntax tree node associated with production
					// BooleanType: BOOLEAN

					s += m_BOOLEAN.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule BooleanType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "BooleanType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_BooleanType_1:
					// emit syntax tree node associated with production
					// BooleanType: BOOLEAN

					s += "BOOLEAN";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule BooleanType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule BooleanType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			BooleanType.production_kind kind = (BooleanType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case BooleanType.production_kind.g_BooleanType_1:
					// traverse syntax tree node associated with production
					// BooleanType: BOOLEAN

						m_BOOLEAN.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_BOOLEAN?.reparent (this);
		}

		//
		// initialize object associated with syntax rule BooleanType
		//

		public void _init ()
		{
			m_BOOLEAN = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule BooleanType

		// counter of all nodes associated with syntax rule BooleanType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule BooleanType
		[DataMember (Name = "m_BOOLEAN")] public SyntaxTreeToken m_BOOLEAN { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule BooleanType

		// delegate function (callback) prototype associated with syntax rule BooleanType
		public delegate bool BooleanType_Callback (SyntaxTreeCallbackReason reason, BooleanType.production_kind kind, BooleanType p_BooleanType);

		// event associated with syntax rule BooleanType
		public event BooleanType_Callback BooleanType_Event;

		// event trigger associated with syntax rule BooleanType
		public bool Raise_BooleanType_Event (SyntaxTreeCallbackReason reason, BooleanType.production_kind kind, BooleanType p_BooleanType)
		{
			bool? status = BooleanType_Event?.Invoke (reason, kind, p_BooleanType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule BooleanType
		//
		// traverse syntax tree node associated with any production of syntax rule BooleanType
		//

		public void Traverse (BooleanType p_BooleanType)
		{
			if (p_BooleanType.isLocked())
				return;
			p_BooleanType.dolock();
			BooleanType.production_kind kind = (BooleanType.production_kind) p_BooleanType.kind;
			p_BooleanType.turn_reset ();
			if (Raise_BooleanType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_BooleanType))
			switch (kind)
			{
				case BooleanType.production_kind.g_BooleanType_1:
					// traverse syntax tree node associated with production
					// BooleanType: BOOLEAN

				break;
			}
			Raise_BooleanType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_BooleanType);
			p_BooleanType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule BooleanType
		//

		public void TraverseCommon (BooleanType p_BooleanType)
		{
			BooleanType.production_kind kind = (BooleanType.production_kind) p_BooleanType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_BooleanType))
			switch (kind)
			{
				case BooleanType.production_kind.g_BooleanType_1:
					// traverse syntax tree node associated with production
					// BooleanType: BOOLEAN

						TraverseCommon (p_BooleanType.m_BOOLEAN);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_BooleanType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule BooleanType

		//
		// create syntax tree node associated with production
		// BooleanType: BOOLEAN

		//

		public BooleanType BooleanType_1 (SyntaxTreeToken p_token)
		{
			BooleanType p_BooleanType_ref = new BooleanType(p_token);
			p_token.parent = p_BooleanType_ref;
			Raise_BooleanType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BooleanType.production_kind.g_BooleanType_1, p_BooleanType_ref);
			return p_BooleanType_ref;
		}
		#endregion
	};
}
