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
	// class associated with syntax rule SetOfType
	//

	[DataContract]
	public class	SetOfType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SetOfType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SetOfType
		{
			g_SetOfType_1 = 1,	// SET OF Type

			g_SetOfType_2 = 2,	// SET OF NamedType

		};
		#endregion
		#region production markers associated with the syntax rule SetOfType

		// markers associated with production: SetOfType -> SET OF Type

		public enum production_marker_1 : ushort
		{
			m_Type,
			final
		};

		// markers associated with production: SetOfType -> SET OF NamedType

		public enum production_marker_2 : ushort
		{
			m_NamedType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SetOfType

		// Constructor declaration(s) associated with production(s) of syntax rule SetOfType

		//
		// Constructor associated with the following production(s)
		// SetOfType -> SET OF Type

		//

		public SetOfType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Type p_Type) : base ((uint) ProductionID._SetOfType_ID, (uint) production_kind.g_SetOfType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_SET = p_token;
			children[1] = m_OF = p_token_1;
			children[2] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// SetOfType -> SET OF NamedType

		//

		public SetOfType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NamedType p_NamedType) : base ((uint) ProductionID._SetOfType_ID, (uint) production_kind.g_SetOfType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_SET = p_token;
			children[1] = m_OF = p_token_1;
			children[2] = m_NamedType = p_NamedType;
		}

		public SetOfType () { }

		// Copy constructor

		public SetOfType (SetOfType p_SetOfType) : base (p_SetOfType.id, p_SetOfType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SetOfType.appInfo;
			switch ((production_kind) p_SetOfType.kind)
			{
				case production_kind.g_SetOfType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_SET = (p_SetOfType.m_SET != null) ? new SyntaxTreeToken (p_SetOfType.m_SET) : null) != null) m_SET.parent = this;
					if ((children [1] = m_OF = (p_SetOfType.m_OF != null) ? new SyntaxTreeToken (p_SetOfType.m_OF) : null) != null) m_OF.parent = this;
					if ((children [2] = m_Type = (p_SetOfType.m_Type != null) ? new Type (p_SetOfType.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_SetOfType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_SET = (p_SetOfType.m_SET != null) ? new SyntaxTreeToken (p_SetOfType.m_SET) : null) != null) m_SET.parent = this;
					if ((children [1] = m_OF = (p_SetOfType.m_OF != null) ? new SyntaxTreeToken (p_SetOfType.m_OF) : null) != null) m_OF.parent = this;
					if ((children [2] = m_NamedType = (p_SetOfType.m_NamedType != null) ? new NamedType (p_SetOfType.m_NamedType) : null) != null) m_NamedType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SetOfType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SetOfType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SET?.Dispose ();
			m_OF?.Dispose ();
			m_Type?.Dispose ();
			m_NamedType?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SetOfType

		// Content changing function(s) associated with production(s) of syntax rule SetOfType

		//
		// Content changing function associated with following production(s)
		// SetOfType -> SET OF Type

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_SetOfType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_SET = p_token;
			children [1] = m_OF = p_token_1;
			children [2] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SetOfType -> SET OF NamedType

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NamedType p_NamedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_SetOfType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_SET = p_token;
			children [1] = m_OF = p_token_1;
			children [2] = m_NamedType = p_NamedType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SetOfType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SET != null) && m_SET.checkInclusion (element) ||
				(m_OF != null) && m_OF.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_NamedType != null) && m_NamedType.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SetOfType

		//
		// emit production tree node associated with any production of syntax rule SetOfType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SetOfType_1:
					// emit syntax tree node associated with production
					// SetOfType: SET OF Type

					s += m_SET.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_SetOfType_2:
					// emit syntax tree node associated with production
					// SetOfType: SET OF NamedType

					s += m_SET.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_NamedType.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SetOfType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SetOfType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SetOfType_1:
					// emit syntax tree node associated with production
					// SetOfType: SET OF Type

					s += "SET";
					s += ' ';
					s += "OF";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SetOfType_2:
					// emit syntax tree node associated with production
					// SetOfType: SET OF NamedType

					s += "SET";
					s += ' ';
					s += "OF";
					s += ' ';
					s += m_NamedType.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SetOfType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SetOfType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SetOfType.production_kind kind = (SetOfType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SetOfType.production_kind.g_SetOfType_1:
					// traverse syntax tree node associated with production
					// SetOfType: SET OF Type

						m_SET.Visit (visitor, appData);
						m_OF.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
				case SetOfType.production_kind.g_SetOfType_2:
					// traverse syntax tree node associated with production
					// SetOfType: SET OF NamedType

						m_SET.Visit (visitor, appData);
						m_OF.Visit (visitor, appData);
						m_NamedType.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SET?.reparent (this);
			m_OF?.reparent (this);
			m_Type?.reparent (this);
			m_NamedType?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SetOfType
		//

		public void _init ()
		{
			m_SET = null;
			m_OF = null;
			m_Type = null;
			m_NamedType = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SetOfType

		// counter of all nodes associated with syntax rule SetOfType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SetOfType
		[DataMember (Name = "m_SET")] public SyntaxTreeToken m_SET { get; private set; }
		[DataMember (Name = "m_OF")] public SyntaxTreeToken m_OF { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_NamedType")] public NamedType m_NamedType { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SetOfType

		// delegate function (callback) prototype associated with syntax rule SetOfType
		public delegate bool SetOfType_Callback (SyntaxTreeCallbackReason reason, SetOfType.production_kind kind, SetOfType p_SetOfType);

		// event associated with syntax rule SetOfType
		public event SetOfType_Callback SetOfType_Event;

		// event trigger associated with syntax rule SetOfType
		public bool Raise_SetOfType_Event (SyntaxTreeCallbackReason reason, SetOfType.production_kind kind, SetOfType p_SetOfType)
		{
			bool? status = SetOfType_Event?.Invoke (reason, kind, p_SetOfType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SetOfType
		//
		// traverse syntax tree node associated with any production of syntax rule SetOfType
		//

		public void Traverse (SetOfType p_SetOfType)
		{
			if (p_SetOfType.isLocked())
				return;
			p_SetOfType.dolock();
			SetOfType.production_kind kind = (SetOfType.production_kind) p_SetOfType.kind;
			p_SetOfType.turn_reset ();
			if (Raise_SetOfType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SetOfType))
			switch (kind)
			{
				case SetOfType.production_kind.g_SetOfType_1:
					// traverse syntax tree node associated with production
					// SetOfType: SET OF Type

					if (Raise_SetOfType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SetOfType))
						Traverse (p_SetOfType.m_Type);
					p_SetOfType.turn_inc ();
					Raise_SetOfType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SetOfType);
				break;
				case SetOfType.production_kind.g_SetOfType_2:
					// traverse syntax tree node associated with production
					// SetOfType: SET OF NamedType

					if (Raise_SetOfType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SetOfType))
						Traverse (p_SetOfType.m_NamedType);
					p_SetOfType.turn_inc ();
					Raise_SetOfType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SetOfType);
				break;
			}
			Raise_SetOfType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SetOfType);
			p_SetOfType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SetOfType
		//

		public void TraverseCommon (SetOfType p_SetOfType)
		{
			SetOfType.production_kind kind = (SetOfType.production_kind) p_SetOfType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SetOfType))
			switch (kind)
			{
				case SetOfType.production_kind.g_SetOfType_1:
					// traverse syntax tree node associated with production
					// SetOfType: SET OF Type

						TraverseCommon (p_SetOfType.m_SET);
						TraverseCommon (p_SetOfType.m_OF);
						TraverseCommon (p_SetOfType.m_Type);
				break;
				case SetOfType.production_kind.g_SetOfType_2:
					// traverse syntax tree node associated with production
					// SetOfType: SET OF NamedType

						TraverseCommon (p_SetOfType.m_SET);
						TraverseCommon (p_SetOfType.m_OF);
						TraverseCommon (p_SetOfType.m_NamedType);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SetOfType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SetOfType

		//
		// create syntax tree node associated with production
		// SetOfType: SET OF Type

		//

		public SetOfType SetOfType_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Type p_Type)
		{
			SetOfType p_SetOfType_ref = new SetOfType(p_token, p_token_1, p_Type);
			p_token.parent = p_SetOfType_ref;
			p_token_1.parent = p_SetOfType_ref;
			p_Type.parent = p_SetOfType_ref;
			Raise_SetOfType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SetOfType.production_kind.g_SetOfType_1, p_SetOfType_ref);
			return p_SetOfType_ref;
		}

		//
		// create syntax tree node associated with production
		// SetOfType: SET OF NamedType

		//

		public SetOfType SetOfType_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NamedType p_NamedType)
		{
			SetOfType p_SetOfType_ref = new SetOfType(p_token, p_token_1, p_NamedType);
			p_token.parent = p_SetOfType_ref;
			p_token_1.parent = p_SetOfType_ref;
			p_NamedType.parent = p_SetOfType_ref;
			Raise_SetOfType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SetOfType.production_kind.g_SetOfType_2, p_SetOfType_ref);
			return p_SetOfType_ref;
		}
		#endregion
	};
}
