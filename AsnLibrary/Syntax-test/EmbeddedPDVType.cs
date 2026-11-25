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
	// class associated with syntax rule EmbeddedPDVType
	//

	[DataContract]
	public class	EmbeddedPDVType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EmbeddedPDVType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EmbeddedPDVType
		{
			g_EmbeddedPDVType_1 = 1,	// EMBEDDED PDV

		};
		#endregion
		#region production markers associated with the syntax rule EmbeddedPDVType

		// markers associated with production: EmbeddedPDVType -> EMBEDDED PDV

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EmbeddedPDVType

		// Constructor declaration(s) associated with production(s) of syntax rule EmbeddedPDVType

		//
		// Constructor associated with the following production(s)
		// EmbeddedPDVType -> EMBEDDED PDV

		//

		public EmbeddedPDVType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._EmbeddedPDVType_ID, (uint) production_kind.g_EmbeddedPDVType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_EMBEDDED = p_token;
			children[1] = m_PDV = p_token_1;
		}

		public EmbeddedPDVType () { }

		// Copy constructor

		public EmbeddedPDVType (EmbeddedPDVType p_EmbeddedPDVType) : base (p_EmbeddedPDVType.id, p_EmbeddedPDVType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EmbeddedPDVType.appInfo;
			switch ((production_kind) p_EmbeddedPDVType.kind)
			{
				case production_kind.g_EmbeddedPDVType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_EMBEDDED = (p_EmbeddedPDVType.m_EMBEDDED != null) ? new SyntaxTreeToken (p_EmbeddedPDVType.m_EMBEDDED) : null) != null) m_EMBEDDED.parent = this;
					if ((children [1] = m_PDV = (p_EmbeddedPDVType.m_PDV != null) ? new SyntaxTreeToken (p_EmbeddedPDVType.m_PDV) : null) != null) m_PDV.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EmbeddedPDVType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EmbeddedPDVType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_EMBEDDED?.Dispose ();
			m_PDV?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EmbeddedPDVType

		// Content changing function(s) associated with production(s) of syntax rule EmbeddedPDVType

		//
		// Content changing function associated with following production(s)
		// EmbeddedPDVType -> EMBEDDED PDV

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_EmbeddedPDVType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_EMBEDDED = p_token;
			children [1] = m_PDV = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EmbeddedPDVType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_EMBEDDED != null) && m_EMBEDDED.checkInclusion (element) ||
				(m_PDV != null) && m_PDV.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EmbeddedPDVType

		//
		// emit production tree node associated with any production of syntax rule EmbeddedPDVType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EmbeddedPDVType_1:
					// emit syntax tree node associated with production
					// EmbeddedPDVType: EMBEDDED PDV

					s += m_EMBEDDED.Emit (depth - 1);
					s += " ";
					s += m_PDV.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EmbeddedPDVType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EmbeddedPDVType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EmbeddedPDVType_1:
					// emit syntax tree node associated with production
					// EmbeddedPDVType: EMBEDDED PDV

					s += "EMBEDDED";
					s += ' ';
					s += "PDV";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EmbeddedPDVType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EmbeddedPDVType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EmbeddedPDVType.production_kind kind = (EmbeddedPDVType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EmbeddedPDVType.production_kind.g_EmbeddedPDVType_1:
					// traverse syntax tree node associated with production
					// EmbeddedPDVType: EMBEDDED PDV

						m_EMBEDDED.Visit (visitor, appData);
						m_PDV.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_EMBEDDED?.reparent (this);
			m_PDV?.reparent (this);
		}

		//
		// initialize object associated with syntax rule EmbeddedPDVType
		//

		public void _init ()
		{
			m_EMBEDDED = null;
			m_PDV = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EmbeddedPDVType

		// counter of all nodes associated with syntax rule EmbeddedPDVType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EmbeddedPDVType
		[DataMember (Name = "m_EMBEDDED")] public SyntaxTreeToken m_EMBEDDED { get; private set; }
		[DataMember (Name = "m_PDV")] public SyntaxTreeToken m_PDV { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EmbeddedPDVType

		// delegate function (callback) prototype associated with syntax rule EmbeddedPDVType
		public delegate bool EmbeddedPDVType_Callback (SyntaxTreeCallbackReason reason, EmbeddedPDVType.production_kind kind, EmbeddedPDVType p_EmbeddedPDVType);

		// event associated with syntax rule EmbeddedPDVType
		public event EmbeddedPDVType_Callback EmbeddedPDVType_Event;

		// event trigger associated with syntax rule EmbeddedPDVType
		public bool Raise_EmbeddedPDVType_Event (SyntaxTreeCallbackReason reason, EmbeddedPDVType.production_kind kind, EmbeddedPDVType p_EmbeddedPDVType)
		{
			bool? status = EmbeddedPDVType_Event?.Invoke (reason, kind, p_EmbeddedPDVType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EmbeddedPDVType
		//
		// traverse syntax tree node associated with any production of syntax rule EmbeddedPDVType
		//

		public void Traverse (EmbeddedPDVType p_EmbeddedPDVType)
		{
			if (p_EmbeddedPDVType.isLocked())
				return;
			p_EmbeddedPDVType.dolock();
			EmbeddedPDVType.production_kind kind = (EmbeddedPDVType.production_kind) p_EmbeddedPDVType.kind;
			p_EmbeddedPDVType.turn_reset ();
			if (Raise_EmbeddedPDVType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EmbeddedPDVType))
			switch (kind)
			{
				case EmbeddedPDVType.production_kind.g_EmbeddedPDVType_1:
					// traverse syntax tree node associated with production
					// EmbeddedPDVType: EMBEDDED PDV

				break;
			}
			Raise_EmbeddedPDVType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EmbeddedPDVType);
			p_EmbeddedPDVType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EmbeddedPDVType
		//

		public void TraverseCommon (EmbeddedPDVType p_EmbeddedPDVType)
		{
			EmbeddedPDVType.production_kind kind = (EmbeddedPDVType.production_kind) p_EmbeddedPDVType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EmbeddedPDVType))
			switch (kind)
			{
				case EmbeddedPDVType.production_kind.g_EmbeddedPDVType_1:
					// traverse syntax tree node associated with production
					// EmbeddedPDVType: EMBEDDED PDV

						TraverseCommon (p_EmbeddedPDVType.m_EMBEDDED);
						TraverseCommon (p_EmbeddedPDVType.m_PDV);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EmbeddedPDVType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EmbeddedPDVType

		//
		// create syntax tree node associated with production
		// EmbeddedPDVType: EMBEDDED PDV

		//

		public EmbeddedPDVType EmbeddedPDVType_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			EmbeddedPDVType p_EmbeddedPDVType_ref = new EmbeddedPDVType(p_token, p_token_1);
			p_token.parent = p_EmbeddedPDVType_ref;
			p_token_1.parent = p_EmbeddedPDVType_ref;
			Raise_EmbeddedPDVType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EmbeddedPDVType.production_kind.g_EmbeddedPDVType_1, p_EmbeddedPDVType_ref);
			return p_EmbeddedPDVType_ref;
		}
		#endregion
	};
}
