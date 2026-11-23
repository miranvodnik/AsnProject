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
	// class associated with syntax rule SequenceOfType
	//

	[DataContract]
	public class	SequenceOfType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SequenceOfType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SequenceOfType
		{
			g_SequenceOfType_1 = 1,	// SEQUENCE OF Type

			g_SequenceOfType_2 = 2,	// SEQUENCE OF NamedType

		};
		#endregion
		#region production markers associated with the syntax rule SequenceOfType

		// markers associated with production: SequenceOfType -> SEQUENCE OF Type

		public enum production_marker_1 : ushort
		{
			m_Type,
			final
		};

		// markers associated with production: SequenceOfType -> SEQUENCE OF NamedType

		public enum production_marker_2 : ushort
		{
			m_NamedType,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SequenceOfType

		// Constructor declaration(s) associated with production(s) of syntax rule SequenceOfType

		//
		// Constructor associated with the following production(s)
		// SequenceOfType -> SEQUENCE OF Type

		//

		public SequenceOfType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Type p_Type) : base ((uint) ProductionID._SequenceOfType_ID, (uint) production_kind.g_SequenceOfType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_SEQUENCE = p_token;
			children[1] = m_OF = p_token_1;
			children[2] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// SequenceOfType -> SEQUENCE OF NamedType

		//

		public SequenceOfType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NamedType p_NamedType) : base ((uint) ProductionID._SequenceOfType_ID, (uint) production_kind.g_SequenceOfType_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_SEQUENCE = p_token;
			children[1] = m_OF = p_token_1;
			children[2] = m_NamedType = p_NamedType;
		}

		public SequenceOfType () { }

		// Copy constructor

		public SequenceOfType (SequenceOfType p_SequenceOfType) : base (p_SequenceOfType.id, p_SequenceOfType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SequenceOfType.appInfo;
			switch ((production_kind) p_SequenceOfType.kind)
			{
				case production_kind.g_SequenceOfType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_SEQUENCE = (p_SequenceOfType.m_SEQUENCE != null) ? new SyntaxTreeToken (p_SequenceOfType.m_SEQUENCE) : null) != null) m_SEQUENCE.parent = this;
					if ((children [1] = m_OF = (p_SequenceOfType.m_OF != null) ? new SyntaxTreeToken (p_SequenceOfType.m_OF) : null) != null) m_OF.parent = this;
					if ((children [2] = m_Type = (p_SequenceOfType.m_Type != null) ? new Type (p_SequenceOfType.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_SequenceOfType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_SEQUENCE = (p_SequenceOfType.m_SEQUENCE != null) ? new SyntaxTreeToken (p_SequenceOfType.m_SEQUENCE) : null) != null) m_SEQUENCE.parent = this;
					if ((children [1] = m_OF = (p_SequenceOfType.m_OF != null) ? new SyntaxTreeToken (p_SequenceOfType.m_OF) : null) != null) m_OF.parent = this;
					if ((children [2] = m_NamedType = (p_SequenceOfType.m_NamedType != null) ? new NamedType (p_SequenceOfType.m_NamedType) : null) != null) m_NamedType.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SequenceOfType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SequenceOfType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SEQUENCE?.Dispose ();
			m_OF?.Dispose ();
			m_Type?.Dispose ();
			m_NamedType?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SequenceOfType

		// Content changing function(s) associated with production(s) of syntax rule SequenceOfType

		//
		// Content changing function associated with following production(s)
		// SequenceOfType -> SEQUENCE OF Type

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_SequenceOfType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_SEQUENCE = p_token;
			children [1] = m_OF = p_token_1;
			children [2] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SequenceOfType -> SEQUENCE OF NamedType

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NamedType p_NamedType)
		{
			_init ();
			this.kind = (uint) production_kind.g_SequenceOfType_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_SEQUENCE = p_token;
			children [1] = m_OF = p_token_1;
			children [2] = m_NamedType = p_NamedType;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SequenceOfType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SEQUENCE != null) && m_SEQUENCE.checkInclusion (element) ||
				(m_OF != null) && m_OF.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_NamedType != null) && m_NamedType.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SequenceOfType

		//
		// emit production tree node associated with any production of syntax rule SequenceOfType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SequenceOfType_1:
					// emit syntax tree node associated with production
					// SequenceOfType: SEQUENCE OF Type

					s += m_SEQUENCE.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_SequenceOfType_2:
					// emit syntax tree node associated with production
					// SequenceOfType: SEQUENCE OF NamedType

					s += m_SEQUENCE.Emit (depth - 1);
					s += " ";
					s += m_OF.Emit (depth - 1);
					s += " ";
					s += m_NamedType.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SequenceOfType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SequenceOfType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SequenceOfType_1:
					// emit syntax tree node associated with production
					// SequenceOfType: SEQUENCE OF Type

					s += "SEQUENCE";
					s += ' ';
					s += "OF";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SequenceOfType_2:
					// emit syntax tree node associated with production
					// SequenceOfType: SEQUENCE OF NamedType

					s += "SEQUENCE";
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
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SequenceOfType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SequenceOfType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SequenceOfType.production_kind kind = (SequenceOfType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SequenceOfType.production_kind.g_SequenceOfType_1:
					// traverse syntax tree node associated with production
					// SequenceOfType: SEQUENCE OF Type

						m_SEQUENCE.Visit (visitor, appData);
						m_OF.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
				case SequenceOfType.production_kind.g_SequenceOfType_2:
					// traverse syntax tree node associated with production
					// SequenceOfType: SEQUENCE OF NamedType

						m_SEQUENCE.Visit (visitor, appData);
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

			m_SEQUENCE?.reparent (this);
			m_OF?.reparent (this);
			m_Type?.reparent (this);
			m_NamedType?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SequenceOfType
		//

		public void _init ()
		{
			m_SEQUENCE = null;
			m_OF = null;
			m_Type = null;
			m_NamedType = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SequenceOfType

		// counter of all nodes associated with syntax rule SequenceOfType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SequenceOfType
		[DataMember (Name = "m_SEQUENCE")] public SyntaxTreeToken m_SEQUENCE { get; private set; }
		[DataMember (Name = "m_OF")] public SyntaxTreeToken m_OF { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_NamedType")] public NamedType m_NamedType { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SequenceOfType

		// delegate function (callback) prototype associated with syntax rule SequenceOfType
		public delegate bool SequenceOfType_Callback (SyntaxTreeCallbackReason reason, SequenceOfType.production_kind kind, SequenceOfType p_SequenceOfType);

		// event associated with syntax rule SequenceOfType
		public event SequenceOfType_Callback SequenceOfType_Event;

		// event trigger associated with syntax rule SequenceOfType
		public bool Raise_SequenceOfType_Event (SyntaxTreeCallbackReason reason, SequenceOfType.production_kind kind, SequenceOfType p_SequenceOfType)
		{
			bool? status = SequenceOfType_Event?.Invoke (reason, kind, p_SequenceOfType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SequenceOfType
		//
		// traverse syntax tree node associated with any production of syntax rule SequenceOfType
		//

		public void Traverse (SequenceOfType p_SequenceOfType)
		{
			if (p_SequenceOfType.isLocked())
				return;
			p_SequenceOfType.dolock();
			SequenceOfType.production_kind kind = (SequenceOfType.production_kind) p_SequenceOfType.kind;
			p_SequenceOfType.turn_reset ();
			if (Raise_SequenceOfType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SequenceOfType))
			switch (kind)
			{
				case SequenceOfType.production_kind.g_SequenceOfType_1:
					// traverse syntax tree node associated with production
					// SequenceOfType: SEQUENCE OF Type

					if (Raise_SequenceOfType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SequenceOfType))
						Traverse (p_SequenceOfType.m_Type);
					p_SequenceOfType.turn_inc ();
					Raise_SequenceOfType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SequenceOfType);
				break;
				case SequenceOfType.production_kind.g_SequenceOfType_2:
					// traverse syntax tree node associated with production
					// SequenceOfType: SEQUENCE OF NamedType

					if (Raise_SequenceOfType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SequenceOfType))
						Traverse (p_SequenceOfType.m_NamedType);
					p_SequenceOfType.turn_inc ();
					Raise_SequenceOfType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SequenceOfType);
				break;
			}
			Raise_SequenceOfType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SequenceOfType);
			p_SequenceOfType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SequenceOfType
		//

		public void TraverseCommon (SequenceOfType p_SequenceOfType)
		{
			SequenceOfType.production_kind kind = (SequenceOfType.production_kind) p_SequenceOfType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SequenceOfType))
			switch (kind)
			{
				case SequenceOfType.production_kind.g_SequenceOfType_1:
					// traverse syntax tree node associated with production
					// SequenceOfType: SEQUENCE OF Type

						TraverseCommon (p_SequenceOfType.m_SEQUENCE);
						TraverseCommon (p_SequenceOfType.m_OF);
						TraverseCommon (p_SequenceOfType.m_Type);
				break;
				case SequenceOfType.production_kind.g_SequenceOfType_2:
					// traverse syntax tree node associated with production
					// SequenceOfType: SEQUENCE OF NamedType

						TraverseCommon (p_SequenceOfType.m_SEQUENCE);
						TraverseCommon (p_SequenceOfType.m_OF);
						TraverseCommon (p_SequenceOfType.m_NamedType);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SequenceOfType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SequenceOfType

		//
		// create syntax tree node associated with production
		// SequenceOfType: SEQUENCE OF Type

		//

		public SequenceOfType SequenceOfType_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Type p_Type)
		{
			SequenceOfType p_SequenceOfType_ref = new SequenceOfType(p_token, p_token_1, p_Type);
			p_token.parent = p_SequenceOfType_ref;
			p_token_1.parent = p_SequenceOfType_ref;
			p_Type.parent = p_SequenceOfType_ref;
			Raise_SequenceOfType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SequenceOfType.production_kind.g_SequenceOfType_1, p_SequenceOfType_ref);
			return p_SequenceOfType_ref;
		}

		//
		// create syntax tree node associated with production
		// SequenceOfType: SEQUENCE OF NamedType

		//

		public SequenceOfType SequenceOfType_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, NamedType p_NamedType)
		{
			SequenceOfType p_SequenceOfType_ref = new SequenceOfType(p_token, p_token_1, p_NamedType);
			p_token.parent = p_SequenceOfType_ref;
			p_token_1.parent = p_SequenceOfType_ref;
			p_NamedType.parent = p_SequenceOfType_ref;
			Raise_SequenceOfType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SequenceOfType.production_kind.g_SequenceOfType_2, p_SequenceOfType_ref);
			return p_SequenceOfType_ref;
		}
		#endregion
	};
}
