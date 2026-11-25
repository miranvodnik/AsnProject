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
	// class associated with syntax rule ExternalType
	//

	[DataContract]
	public class	ExternalType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExternalType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExternalType
		{
			g_ExternalType_1 = 1,	// EXTERNAL

		};
		#endregion
		#region production markers associated with the syntax rule ExternalType

		// markers associated with production: ExternalType -> EXTERNAL

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExternalType

		// Constructor declaration(s) associated with production(s) of syntax rule ExternalType

		//
		// Constructor associated with the following production(s)
		// ExternalType -> EXTERNAL

		//

		public ExternalType (SyntaxTreeToken p_token) : base ((uint) ProductionID._ExternalType_ID, (uint) production_kind.g_ExternalType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_EXTERNAL = p_token;
		}

		public ExternalType () { }

		// Copy constructor

		public ExternalType (ExternalType p_ExternalType) : base (p_ExternalType.id, p_ExternalType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExternalType.appInfo;
			switch ((production_kind) p_ExternalType.kind)
			{
				case production_kind.g_ExternalType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_EXTERNAL = (p_ExternalType.m_EXTERNAL != null) ? new SyntaxTreeToken (p_ExternalType.m_EXTERNAL) : null) != null) m_EXTERNAL.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExternalType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExternalType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_EXTERNAL?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExternalType

		// Content changing function(s) associated with production(s) of syntax rule ExternalType

		//
		// Content changing function associated with following production(s)
		// ExternalType -> EXTERNAL

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExternalType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_EXTERNAL = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExternalType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_EXTERNAL != null) && m_EXTERNAL.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExternalType

		//
		// emit production tree node associated with any production of syntax rule ExternalType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExternalType_1:
					// emit syntax tree node associated with production
					// ExternalType: EXTERNAL

					s += m_EXTERNAL.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExternalType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExternalType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExternalType_1:
					// emit syntax tree node associated with production
					// ExternalType: EXTERNAL

					s += "EXTERNAL";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExternalType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExternalType.production_kind kind = (ExternalType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExternalType.production_kind.g_ExternalType_1:
					// traverse syntax tree node associated with production
					// ExternalType: EXTERNAL

						m_EXTERNAL.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_EXTERNAL?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExternalType
		//

		public void _init ()
		{
			m_EXTERNAL = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExternalType

		// counter of all nodes associated with syntax rule ExternalType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExternalType
		[DataMember (Name = "m_EXTERNAL")] public SyntaxTreeToken m_EXTERNAL { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExternalType

		// delegate function (callback) prototype associated with syntax rule ExternalType
		public delegate bool ExternalType_Callback (SyntaxTreeCallbackReason reason, ExternalType.production_kind kind, ExternalType p_ExternalType);

		// event associated with syntax rule ExternalType
		public event ExternalType_Callback ExternalType_Event;

		// event trigger associated with syntax rule ExternalType
		public bool Raise_ExternalType_Event (SyntaxTreeCallbackReason reason, ExternalType.production_kind kind, ExternalType p_ExternalType)
		{
			bool? status = ExternalType_Event?.Invoke (reason, kind, p_ExternalType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExternalType
		//
		// traverse syntax tree node associated with any production of syntax rule ExternalType
		//

		public void Traverse (ExternalType p_ExternalType)
		{
			if (p_ExternalType.isLocked())
				return;
			p_ExternalType.dolock();
			ExternalType.production_kind kind = (ExternalType.production_kind) p_ExternalType.kind;
			p_ExternalType.turn_reset ();
			if (Raise_ExternalType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExternalType))
			switch (kind)
			{
				case ExternalType.production_kind.g_ExternalType_1:
					// traverse syntax tree node associated with production
					// ExternalType: EXTERNAL

				break;
			}
			Raise_ExternalType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExternalType);
			p_ExternalType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalType
		//

		public void TraverseCommon (ExternalType p_ExternalType)
		{
			ExternalType.production_kind kind = (ExternalType.production_kind) p_ExternalType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExternalType))
			switch (kind)
			{
				case ExternalType.production_kind.g_ExternalType_1:
					// traverse syntax tree node associated with production
					// ExternalType: EXTERNAL

						TraverseCommon (p_ExternalType.m_EXTERNAL);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExternalType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExternalType

		//
		// create syntax tree node associated with production
		// ExternalType: EXTERNAL

		//

		public ExternalType ExternalType_1 (SyntaxTreeToken p_token)
		{
			ExternalType p_ExternalType_ref = new ExternalType(p_token);
			p_token.parent = p_ExternalType_ref;
			Raise_ExternalType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExternalType.production_kind.g_ExternalType_1, p_ExternalType_ref);
			return p_ExternalType_ref;
		}
		#endregion
	};
}
