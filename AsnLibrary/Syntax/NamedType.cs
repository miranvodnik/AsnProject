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
	// class associated with syntax rule NamedType
	//

	[DataContract]
	public class	NamedType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NamedType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NamedType
		{
			g_NamedType_1 = 1,	// identifier-token Type

			g_NamedType_2 = 2,	// identifier-token Type DEFINED BY defined-identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule NamedType

		// markers associated with production: NamedType -> identifier-token Type

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			m_Type,
			final
		};

		// markers associated with production: NamedType -> identifier-token Type DEFINED BY defined-identifier-token

		public enum production_marker_2 : ushort
		{
			m_identifier_token,
			m_Type,
			m_defined_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NamedType

		// Constructor declaration(s) associated with production(s) of syntax rule NamedType

		//
		// Constructor associated with the following production(s)
		// NamedType -> identifier-token Type

		//

		public NamedType (identifier_token p_identifier_token, Type p_Type) : base ((uint) ProductionID._NamedType_ID, (uint) production_kind.g_NamedType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// NamedType -> identifier-token Type DEFINED BY defined-identifier-token

		//

		public NamedType (identifier_token p_identifier_token, Type p_Type, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, defined_identifier_token p_defined_identifier_token) : base ((uint) ProductionID._NamedType_ID, (uint) production_kind.g_NamedType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_Type = p_Type;
			children[2] = m_DEFINED = p_token;
			children[3] = m_BY = p_token_1;
			children[4] = m_defined_identifier_token = p_defined_identifier_token;
		}

		public NamedType () { }

		// Copy constructor

		public NamedType (NamedType p_NamedType) : base (p_NamedType.id, p_NamedType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NamedType.appInfo;
			switch ((production_kind) p_NamedType.kind)
			{
				case production_kind.g_NamedType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_identifier_token = (p_NamedType.m_identifier_token != null) ? new identifier_token (p_NamedType.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_Type = (p_NamedType.m_Type != null) ? new Type (p_NamedType.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_NamedType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_identifier_token = (p_NamedType.m_identifier_token != null) ? new identifier_token (p_NamedType.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_Type = (p_NamedType.m_Type != null) ? new Type (p_NamedType.m_Type) : null) != null) m_Type.parent = this;
					if ((children [2] = m_DEFINED = (p_NamedType.m_DEFINED != null) ? new SyntaxTreeToken (p_NamedType.m_DEFINED) : null) != null) m_DEFINED.parent = this;
					if ((children [3] = m_BY = (p_NamedType.m_BY != null) ? new SyntaxTreeToken (p_NamedType.m_BY) : null) != null) m_BY.parent = this;
					if ((children [4] = m_defined_identifier_token = (p_NamedType.m_defined_identifier_token != null) ? new defined_identifier_token (p_NamedType.m_defined_identifier_token) : null) != null) m_defined_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NamedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NamedType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_Type?.Dispose ();
			m_DEFINED?.Dispose ();
			m_BY?.Dispose ();
			m_defined_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NamedType

		// Content changing function(s) associated with production(s) of syntax rule NamedType

		//
		// Content changing function associated with following production(s)
		// NamedType -> identifier-token Type

		//

		public void change(identifier_token p_identifier_token, Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NamedType -> identifier-token Type DEFINED BY defined-identifier-token

		//

		public void change(identifier_token p_identifier_token, Type p_Type, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, defined_identifier_token p_defined_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_NamedType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_Type = p_Type;
			children [2] = m_DEFINED = p_token;
			children [3] = m_BY = p_token_1;
			children [4] = m_defined_identifier_token = p_defined_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NamedType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_DEFINED != null) && m_DEFINED.checkInclusion (element) ||
				(m_BY != null) && m_BY.checkInclusion (element) ||
				(m_defined_identifier_token != null) && m_defined_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NamedType

		//
		// emit production tree node associated with any production of syntax rule NamedType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NamedType_1:
					// emit syntax tree node associated with production
					// NamedType: identifier-token Type

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_NamedType_2:
					// emit syntax tree node associated with production
					// NamedType: identifier-token Type DEFINED BY defined-identifier-token

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
					s += " ";
					s += m_DEFINED.Emit (depth - 1);
					s += " ";
					s += m_BY.Emit (depth - 1);
					s += " ";
					s += m_defined_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NamedType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NamedType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NamedType_1:
					// emit syntax tree node associated with production
					// NamedType: identifier-token Type

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_NamedType_2:
					// emit syntax tree node associated with production
					// NamedType: identifier-token Type DEFINED BY defined-identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
					s += ' ';
					s += "DEFINED";
					s += ' ';
					s += "BY";
					s += ' ';
					s += m_defined_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NamedType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NamedType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NamedType.production_kind kind = (NamedType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NamedType.production_kind.g_NamedType_1:
					// traverse syntax tree node associated with production
					// NamedType: identifier-token Type

						m_identifier_token.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
				case NamedType.production_kind.g_NamedType_2:
					// traverse syntax tree node associated with production
					// NamedType: identifier-token Type DEFINED BY defined-identifier-token

						m_identifier_token.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
						m_DEFINED.Visit (visitor, appData);
						m_BY.Visit (visitor, appData);
						m_defined_identifier_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier_token?.reparent (this);
			m_Type?.reparent (this);
			m_DEFINED?.reparent (this);
			m_BY?.reparent (this);
			m_defined_identifier_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NamedType
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_Type = null;
			m_DEFINED = null;
			m_BY = null;
			m_defined_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NamedType

		// counter of all nodes associated with syntax rule NamedType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NamedType
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_DEFINED")] public SyntaxTreeToken m_DEFINED { get; private set; }
		[DataMember (Name = "m_BY")] public SyntaxTreeToken m_BY { get; private set; }
		[DataMember (Name = "m_defined_identifier_token")] public defined_identifier_token m_defined_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NamedType

		// delegate function (callback) prototype associated with syntax rule NamedType
		public delegate bool NamedType_Callback (SyntaxTreeCallbackReason reason, NamedType.production_kind kind, NamedType p_NamedType);

		// event associated with syntax rule NamedType
		public event NamedType_Callback NamedType_Event;

		// event trigger associated with syntax rule NamedType
		public bool Raise_NamedType_Event (SyntaxTreeCallbackReason reason, NamedType.production_kind kind, NamedType p_NamedType)
		{
			bool? status = NamedType_Event?.Invoke (reason, kind, p_NamedType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NamedType
		//
		// traverse syntax tree node associated with any production of syntax rule NamedType
		//

		public void Traverse (NamedType p_NamedType)
		{
			if (p_NamedType.isLocked())
				return;
			p_NamedType.dolock();
			NamedType.production_kind kind = (NamedType.production_kind) p_NamedType.kind;
			p_NamedType.turn_reset ();
			if (Raise_NamedType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NamedType))
			switch (kind)
			{
				case NamedType.production_kind.g_NamedType_1:
					// traverse syntax tree node associated with production
					// NamedType: identifier-token Type

					if (Raise_NamedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedType))
						Traverse (p_NamedType.m_identifier_token);
					p_NamedType.turn_inc ();
					if (Raise_NamedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedType))
						Traverse (p_NamedType.m_Type);
					p_NamedType.turn_inc ();
					Raise_NamedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedType);
				break;
				case NamedType.production_kind.g_NamedType_2:
					// traverse syntax tree node associated with production
					// NamedType: identifier-token Type DEFINED BY defined-identifier-token

					if (Raise_NamedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedType))
						Traverse (p_NamedType.m_identifier_token);
					p_NamedType.turn_inc ();
					if (Raise_NamedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedType))
						Traverse (p_NamedType.m_Type);
					p_NamedType.turn_inc ();
					if (Raise_NamedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedType))
						Traverse (p_NamedType.m_defined_identifier_token);
					p_NamedType.turn_inc ();
					Raise_NamedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NamedType);
				break;
			}
			Raise_NamedType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NamedType);
			p_NamedType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NamedType
		//

		public void TraverseCommon (NamedType p_NamedType)
		{
			NamedType.production_kind kind = (NamedType.production_kind) p_NamedType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NamedType))
			switch (kind)
			{
				case NamedType.production_kind.g_NamedType_1:
					// traverse syntax tree node associated with production
					// NamedType: identifier-token Type

						TraverseCommon (p_NamedType.m_identifier_token);
						TraverseCommon (p_NamedType.m_Type);
				break;
				case NamedType.production_kind.g_NamedType_2:
					// traverse syntax tree node associated with production
					// NamedType: identifier-token Type DEFINED BY defined-identifier-token

						TraverseCommon (p_NamedType.m_identifier_token);
						TraverseCommon (p_NamedType.m_Type);
						TraverseCommon (p_NamedType.m_DEFINED);
						TraverseCommon (p_NamedType.m_BY);
						TraverseCommon (p_NamedType.m_defined_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NamedType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NamedType

		//
		// create syntax tree node associated with production
		// NamedType: identifier-token Type

		//

		public NamedType NamedType_1 (identifier_token p_identifier_token, Type p_Type)
		{
			NamedType p_NamedType_ref = new NamedType(p_identifier_token, p_Type);
			p_identifier_token.parent = p_NamedType_ref;
			p_Type.parent = p_NamedType_ref;
			Raise_NamedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedType.production_kind.g_NamedType_1, p_NamedType_ref);
			return p_NamedType_ref;
		}

		//
		// create syntax tree node associated with production
		// NamedType: identifier-token Type DEFINED BY defined-identifier-token

		//

		public NamedType NamedType_2 (identifier_token p_identifier_token, Type p_Type, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, defined_identifier_token p_defined_identifier_token)
		{
			NamedType p_NamedType_ref = new NamedType(p_identifier_token, p_Type, p_token, p_token_1, p_defined_identifier_token);
			p_identifier_token.parent = p_NamedType_ref;
			p_Type.parent = p_NamedType_ref;
			p_token.parent = p_NamedType_ref;
			p_token_1.parent = p_NamedType_ref;
			p_defined_identifier_token.parent = p_NamedType_ref;
			Raise_NamedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NamedType.production_kind.g_NamedType_2, p_NamedType_ref);
			return p_NamedType_ref;
		}
		#endregion
	};
}
