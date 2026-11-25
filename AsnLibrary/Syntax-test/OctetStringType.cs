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
	// class associated with syntax rule OctetStringType
	//

	[DataContract]
	public class	OctetStringType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OctetStringType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OctetStringType
		{
			g_OctetStringType_1 = 1,	// OCTET STRING

		};
		#endregion
		#region production markers associated with the syntax rule OctetStringType

		// markers associated with production: OctetStringType -> OCTET STRING

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OctetStringType

		// Constructor declaration(s) associated with production(s) of syntax rule OctetStringType

		//
		// Constructor associated with the following production(s)
		// OctetStringType -> OCTET STRING

		//

		public OctetStringType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._OctetStringType_ID, (uint) production_kind.g_OctetStringType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_OCTET = p_token;
			children[1] = m_STRING = p_token_1;
		}

		public OctetStringType () { }

		// Copy constructor

		public OctetStringType (OctetStringType p_OctetStringType) : base (p_OctetStringType.id, p_OctetStringType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OctetStringType.appInfo;
			switch ((production_kind) p_OctetStringType.kind)
			{
				case production_kind.g_OctetStringType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_OCTET = (p_OctetStringType.m_OCTET != null) ? new SyntaxTreeToken (p_OctetStringType.m_OCTET) : null) != null) m_OCTET.parent = this;
					if ((children [1] = m_STRING = (p_OctetStringType.m_STRING != null) ? new SyntaxTreeToken (p_OctetStringType.m_STRING) : null) != null) m_STRING.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OctetStringType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OctetStringType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OCTET?.Dispose ();
			m_STRING?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OctetStringType

		// Content changing function(s) associated with production(s) of syntax rule OctetStringType

		//
		// Content changing function associated with following production(s)
		// OctetStringType -> OCTET STRING

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_OctetStringType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_OCTET = p_token;
			children [1] = m_STRING = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OctetStringType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OCTET != null) && m_OCTET.checkInclusion (element) ||
				(m_STRING != null) && m_STRING.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OctetStringType

		//
		// emit production tree node associated with any production of syntax rule OctetStringType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OctetStringType_1:
					// emit syntax tree node associated with production
					// OctetStringType: OCTET STRING

					s += m_OCTET.Emit (depth - 1);
					s += " ";
					s += m_STRING.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OctetStringType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OctetStringType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OctetStringType_1:
					// emit syntax tree node associated with production
					// OctetStringType: OCTET STRING

					s += "OCTET";
					s += ' ';
					s += "STRING";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OctetStringType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OctetStringType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OctetStringType.production_kind kind = (OctetStringType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OctetStringType.production_kind.g_OctetStringType_1:
					// traverse syntax tree node associated with production
					// OctetStringType: OCTET STRING

						m_OCTET.Visit (visitor, appData);
						m_STRING.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_OCTET?.reparent (this);
			m_STRING?.reparent (this);
		}

		//
		// initialize object associated with syntax rule OctetStringType
		//

		public void _init ()
		{
			m_OCTET = null;
			m_STRING = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OctetStringType

		// counter of all nodes associated with syntax rule OctetStringType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OctetStringType
		[DataMember (Name = "m_OCTET")] public SyntaxTreeToken m_OCTET { get; private set; }
		[DataMember (Name = "m_STRING")] public SyntaxTreeToken m_STRING { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OctetStringType

		// delegate function (callback) prototype associated with syntax rule OctetStringType
		public delegate bool OctetStringType_Callback (SyntaxTreeCallbackReason reason, OctetStringType.production_kind kind, OctetStringType p_OctetStringType);

		// event associated with syntax rule OctetStringType
		public event OctetStringType_Callback OctetStringType_Event;

		// event trigger associated with syntax rule OctetStringType
		public bool Raise_OctetStringType_Event (SyntaxTreeCallbackReason reason, OctetStringType.production_kind kind, OctetStringType p_OctetStringType)
		{
			bool? status = OctetStringType_Event?.Invoke (reason, kind, p_OctetStringType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OctetStringType
		//
		// traverse syntax tree node associated with any production of syntax rule OctetStringType
		//

		public void Traverse (OctetStringType p_OctetStringType)
		{
			if (p_OctetStringType.isLocked())
				return;
			p_OctetStringType.dolock();
			OctetStringType.production_kind kind = (OctetStringType.production_kind) p_OctetStringType.kind;
			p_OctetStringType.turn_reset ();
			if (Raise_OctetStringType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OctetStringType))
			switch (kind)
			{
				case OctetStringType.production_kind.g_OctetStringType_1:
					// traverse syntax tree node associated with production
					// OctetStringType: OCTET STRING

				break;
			}
			Raise_OctetStringType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OctetStringType);
			p_OctetStringType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OctetStringType
		//

		public void TraverseCommon (OctetStringType p_OctetStringType)
		{
			OctetStringType.production_kind kind = (OctetStringType.production_kind) p_OctetStringType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OctetStringType))
			switch (kind)
			{
				case OctetStringType.production_kind.g_OctetStringType_1:
					// traverse syntax tree node associated with production
					// OctetStringType: OCTET STRING

						TraverseCommon (p_OctetStringType.m_OCTET);
						TraverseCommon (p_OctetStringType.m_STRING);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OctetStringType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OctetStringType

		//
		// create syntax tree node associated with production
		// OctetStringType: OCTET STRING

		//

		public OctetStringType OctetStringType_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			OctetStringType p_OctetStringType_ref = new OctetStringType(p_token, p_token_1);
			p_token.parent = p_OctetStringType_ref;
			p_token_1.parent = p_OctetStringType_ref;
			Raise_OctetStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OctetStringType.production_kind.g_OctetStringType_1, p_OctetStringType_ref);
			return p_OctetStringType_ref;
		}
		#endregion
	};
}
