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
	// class associated with syntax rule SelectionType
	//

	[DataContract]
	public class	SelectionType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SelectionType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SelectionType
		{
			g_SelectionType_1 = 1,	// identifier-token "<" Type

		};
		#endregion
		#region production markers associated with the syntax rule SelectionType

		// markers associated with production: SelectionType -> identifier-token "<" Type

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			m_Type,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SelectionType

		// Constructor declaration(s) associated with production(s) of syntax rule SelectionType

		//
		// Constructor associated with the following production(s)
		// SelectionType -> identifier-token "<" Type

		//

		public SelectionType (identifier_token p_identifier_token, SyntaxTreeToken p_token, Type p_Type) : base ((uint) ProductionID._SelectionType_ID, (uint) production_kind.g_SelectionType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_less_sign = p_token;
			children[2] = m_Type = p_Type;
		}

		public SelectionType () { }

		// Copy constructor

		public SelectionType (SelectionType p_SelectionType) : base (p_SelectionType.id, p_SelectionType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SelectionType.appInfo;
			switch ((production_kind) p_SelectionType.kind)
			{
				case production_kind.g_SelectionType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_identifier_token = (p_SelectionType.m_identifier_token != null) ? new identifier_token (p_SelectionType.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_less_sign = (p_SelectionType.m_less_sign != null) ? new SyntaxTreeToken (p_SelectionType.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [2] = m_Type = (p_SelectionType.m_Type != null) ? new Type (p_SelectionType.m_Type) : null) != null) m_Type.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SelectionType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SelectionType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_less_sign?.Dispose ();
			m_Type?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SelectionType

		// Content changing function(s) associated with production(s) of syntax rule SelectionType

		//
		// Content changing function associated with following production(s)
		// SelectionType -> identifier-token "<" Type

		//

		public void change(identifier_token p_identifier_token, SyntaxTreeToken p_token, Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_SelectionType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_less_sign = p_token;
			children [2] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SelectionType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_less_sign != null) && m_less_sign.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SelectionType

		//
		// emit production tree node associated with any production of syntax rule SelectionType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SelectionType_1:
					// emit syntax tree node associated with production
					// SelectionType: identifier-token "<" Type

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_less_sign.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SelectionType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SelectionType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SelectionType_1:
					// emit syntax tree node associated with production
					// SelectionType: identifier-token "<" Type

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "less_sign";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SelectionType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SelectionType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SelectionType.production_kind kind = (SelectionType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SelectionType.production_kind.g_SelectionType_1:
					// traverse syntax tree node associated with production
					// SelectionType: identifier-token "<" Type

						m_identifier_token.Visit (visitor, appData);
						m_less_sign.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier_token?.reparent (this);
			m_less_sign?.reparent (this);
			m_Type?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SelectionType
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_less_sign = null;
			m_Type = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SelectionType

		// counter of all nodes associated with syntax rule SelectionType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SelectionType
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_less_sign")] public SyntaxTreeToken m_less_sign { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SelectionType

		// delegate function (callback) prototype associated with syntax rule SelectionType
		public delegate bool SelectionType_Callback (SyntaxTreeCallbackReason reason, SelectionType.production_kind kind, SelectionType p_SelectionType);

		// event associated with syntax rule SelectionType
		public event SelectionType_Callback SelectionType_Event;

		// event trigger associated with syntax rule SelectionType
		public bool Raise_SelectionType_Event (SyntaxTreeCallbackReason reason, SelectionType.production_kind kind, SelectionType p_SelectionType)
		{
			bool? status = SelectionType_Event?.Invoke (reason, kind, p_SelectionType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SelectionType
		//
		// traverse syntax tree node associated with any production of syntax rule SelectionType
		//

		public void Traverse (SelectionType p_SelectionType)
		{
			if (p_SelectionType.isLocked())
				return;
			p_SelectionType.dolock();
			SelectionType.production_kind kind = (SelectionType.production_kind) p_SelectionType.kind;
			p_SelectionType.turn_reset ();
			if (Raise_SelectionType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SelectionType))
			switch (kind)
			{
				case SelectionType.production_kind.g_SelectionType_1:
					// traverse syntax tree node associated with production
					// SelectionType: identifier-token "<" Type

					if (Raise_SelectionType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SelectionType))
						Traverse (p_SelectionType.m_identifier_token);
					p_SelectionType.turn_inc ();
					if (Raise_SelectionType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SelectionType))
						Traverse (p_SelectionType.m_Type);
					p_SelectionType.turn_inc ();
					Raise_SelectionType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SelectionType);
				break;
			}
			Raise_SelectionType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SelectionType);
			p_SelectionType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SelectionType
		//

		public void TraverseCommon (SelectionType p_SelectionType)
		{
			SelectionType.production_kind kind = (SelectionType.production_kind) p_SelectionType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SelectionType))
			switch (kind)
			{
				case SelectionType.production_kind.g_SelectionType_1:
					// traverse syntax tree node associated with production
					// SelectionType: identifier-token "<" Type

						TraverseCommon (p_SelectionType.m_identifier_token);
						TraverseCommon (p_SelectionType.m_less_sign);
						TraverseCommon (p_SelectionType.m_Type);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SelectionType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SelectionType

		//
		// create syntax tree node associated with production
		// SelectionType: identifier-token "<" Type

		//

		public SelectionType SelectionType_1 (identifier_token p_identifier_token, SyntaxTreeToken p_token, Type p_Type)
		{
			SelectionType p_SelectionType_ref = new SelectionType(p_identifier_token, p_token, p_Type);
			p_identifier_token.parent = p_SelectionType_ref;
			p_token.parent = p_SelectionType_ref;
			p_Type.parent = p_SelectionType_ref;
			Raise_SelectionType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SelectionType.production_kind.g_SelectionType_1, p_SelectionType_ref);
			return p_SelectionType_ref;
		}
		#endregion
	};
}
