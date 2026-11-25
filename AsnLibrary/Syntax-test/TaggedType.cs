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
	// class associated with syntax rule TaggedType
	//

	[DataContract]
	public class	TaggedType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TaggedType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TaggedType
		{
			g_TaggedType_1 = 1,	// Tag Type

			g_TaggedType_2 = 2,	// Tag IMPLICIT Type

			g_TaggedType_3 = 3,	// Tag EXPLICIT Type

		};
		#endregion
		#region production markers associated with the syntax rule TaggedType

		// markers associated with production: TaggedType -> Tag Type

		public enum production_marker_1 : ushort
		{
			m_Tag,
			m_Type,
			final
		};

		// markers associated with production: TaggedType -> Tag IMPLICIT Type

		public enum production_marker_2 : ushort
		{
			m_Tag,
			m_Type,
			final
		};

		// markers associated with production: TaggedType -> Tag EXPLICIT Type

		public enum production_marker_3 : ushort
		{
			m_Tag,
			m_Type,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TaggedType

		// Constructor declaration(s) associated with production(s) of syntax rule TaggedType

		//
		// Constructor associated with the following production(s)
		// TaggedType -> Tag Type

		//

		public TaggedType (Tag p_Tag, Type p_Type) : base ((uint) ProductionID._TaggedType_ID, (uint) production_kind.g_TaggedType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_Tag = p_Tag;
			children[1] = m_Type = p_Type;
		}

		//
		// Constructor associated with the following production(s)
		// TaggedType -> Tag IMPLICIT Type

		// TaggedType -> Tag EXPLICIT Type

		//

		public TaggedType (Tag p_Tag, SyntaxTreeToken p_token, Type p_Type, int kind) : base ((uint) ProductionID._TaggedType_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TaggedType_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children[0] = m_Tag = p_Tag;
				children[1] = m_IMPLICIT = p_token;
				children[2] = m_Type = p_Type;
				break;
			case production_kind.g_TaggedType_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children[0] = m_Tag = p_Tag;
				children[1] = m_EXPLICIT = p_token;
				children[2] = m_Type = p_Type;
				break;
			default:
				{
					string[] args = new string[] { "TaggedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public TaggedType () { }

		// Copy constructor

		public TaggedType (TaggedType p_TaggedType) : base (p_TaggedType.id, p_TaggedType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TaggedType.appInfo;
			switch ((production_kind) p_TaggedType.kind)
			{
				case production_kind.g_TaggedType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_Tag = (p_TaggedType.m_Tag != null) ? new Tag (p_TaggedType.m_Tag) : null) != null) m_Tag.parent = this;
					if ((children [1] = m_Type = (p_TaggedType.m_Type != null) ? new Type (p_TaggedType.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_TaggedType_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_Tag = (p_TaggedType.m_Tag != null) ? new Tag (p_TaggedType.m_Tag) : null) != null) m_Tag.parent = this;
					if ((children [1] = m_IMPLICIT = (p_TaggedType.m_IMPLICIT != null) ? new SyntaxTreeToken (p_TaggedType.m_IMPLICIT) : null) != null) m_IMPLICIT.parent = this;
					if ((children [2] = m_Type = (p_TaggedType.m_Type != null) ? new Type (p_TaggedType.m_Type) : null) != null) m_Type.parent = this;
					break;
				case production_kind.g_TaggedType_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_Tag = (p_TaggedType.m_Tag != null) ? new Tag (p_TaggedType.m_Tag) : null) != null) m_Tag.parent = this;
					if ((children [1] = m_EXPLICIT = (p_TaggedType.m_EXPLICIT != null) ? new SyntaxTreeToken (p_TaggedType.m_EXPLICIT) : null) != null) m_EXPLICIT.parent = this;
					if ((children [2] = m_Type = (p_TaggedType.m_Type != null) ? new Type (p_TaggedType.m_Type) : null) != null) m_Type.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TaggedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TaggedType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Tag?.Dispose ();
			m_Type?.Dispose ();
			m_IMPLICIT?.Dispose ();
			m_EXPLICIT?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TaggedType

		// Content changing function(s) associated with production(s) of syntax rule TaggedType

		//
		// Content changing function associated with following production(s)
		// TaggedType -> Tag Type

		//

		public void change(Tag p_Tag, Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_TaggedType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_Tag = p_Tag;
			children [1] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TaggedType -> Tag IMPLICIT Type

		// TaggedType -> Tag EXPLICIT Type

		//

		public void change(Tag p_Tag, SyntaxTreeToken p_token, Type p_Type, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TaggedType_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children [0] = m_Tag = p_Tag;
				children [1] = m_IMPLICIT = p_token;
				children [2] = m_Type = p_Type;
				break;
			case production_kind.g_TaggedType_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children [0] = m_Tag = p_Tag;
				children [1] = m_EXPLICIT = p_token;
				children [2] = m_Type = p_Type;
				break;
			default:
				{
					string[] args = new string[] { "TaggedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TaggedType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Tag != null) && m_Tag.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_IMPLICIT != null) && m_IMPLICIT.checkInclusion (element) ||
				(m_EXPLICIT != null) && m_EXPLICIT.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TaggedType

		//
		// emit production tree node associated with any production of syntax rule TaggedType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TaggedType_1:
					// emit syntax tree node associated with production
					// TaggedType: Tag Type

					s += m_Tag.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_TaggedType_2:
					// emit syntax tree node associated with production
					// TaggedType: Tag IMPLICIT Type

					s += m_Tag.Emit (depth - 1);
					s += " ";
					s += m_IMPLICIT.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
				case production_kind.g_TaggedType_3:
					// emit syntax tree node associated with production
					// TaggedType: Tag EXPLICIT Type

					s += m_Tag.Emit (depth - 1);
					s += " ";
					s += m_EXPLICIT.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TaggedType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TaggedType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TaggedType_1:
					// emit syntax tree node associated with production
					// TaggedType: Tag Type

					s += m_Tag.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TaggedType_2:
					// emit syntax tree node associated with production
					// TaggedType: Tag IMPLICIT Type

					s += m_Tag.EmitProductionTree (depth - 1);
					s += ' ';
					s += "IMPLICIT";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_TaggedType_3:
					// emit syntax tree node associated with production
					// TaggedType: Tag EXPLICIT Type

					s += m_Tag.EmitProductionTree (depth - 1);
					s += ' ';
					s += "EXPLICIT";
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TaggedType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TaggedType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TaggedType.production_kind kind = (TaggedType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TaggedType.production_kind.g_TaggedType_1:
					// traverse syntax tree node associated with production
					// TaggedType: Tag Type

						m_Tag.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
				case TaggedType.production_kind.g_TaggedType_2:
					// traverse syntax tree node associated with production
					// TaggedType: Tag IMPLICIT Type

						m_Tag.Visit (visitor, appData);
						m_IMPLICIT.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
				case TaggedType.production_kind.g_TaggedType_3:
					// traverse syntax tree node associated with production
					// TaggedType: Tag EXPLICIT Type

						m_Tag.Visit (visitor, appData);
						m_EXPLICIT.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Tag?.reparent (this);
			m_Type?.reparent (this);
			m_IMPLICIT?.reparent (this);
			m_EXPLICIT?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TaggedType
		//

		public void _init ()
		{
			m_Tag = null;
			m_Type = null;
			m_IMPLICIT = null;
			m_EXPLICIT = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TaggedType

		// counter of all nodes associated with syntax rule TaggedType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TaggedType
		[DataMember (Name = "m_Tag")] public Tag m_Tag { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_IMPLICIT")] public SyntaxTreeToken m_IMPLICIT { get; private set; }
		[DataMember (Name = "m_EXPLICIT")] public SyntaxTreeToken m_EXPLICIT { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TaggedType

		// delegate function (callback) prototype associated with syntax rule TaggedType
		public delegate bool TaggedType_Callback (SyntaxTreeCallbackReason reason, TaggedType.production_kind kind, TaggedType p_TaggedType);

		// event associated with syntax rule TaggedType
		public event TaggedType_Callback TaggedType_Event;

		// event trigger associated with syntax rule TaggedType
		public bool Raise_TaggedType_Event (SyntaxTreeCallbackReason reason, TaggedType.production_kind kind, TaggedType p_TaggedType)
		{
			bool? status = TaggedType_Event?.Invoke (reason, kind, p_TaggedType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TaggedType
		//
		// traverse syntax tree node associated with any production of syntax rule TaggedType
		//

		public void Traverse (TaggedType p_TaggedType)
		{
			if (p_TaggedType.isLocked())
				return;
			p_TaggedType.dolock();
			TaggedType.production_kind kind = (TaggedType.production_kind) p_TaggedType.kind;
			p_TaggedType.turn_reset ();
			if (Raise_TaggedType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TaggedType))
			switch (kind)
			{
				case TaggedType.production_kind.g_TaggedType_1:
					// traverse syntax tree node associated with production
					// TaggedType: Tag Type

					if (Raise_TaggedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TaggedType))
						Traverse (p_TaggedType.m_Tag);
					p_TaggedType.turn_inc ();
					if (Raise_TaggedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TaggedType))
						Traverse (p_TaggedType.m_Type);
					p_TaggedType.turn_inc ();
					Raise_TaggedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TaggedType);
				break;
				case TaggedType.production_kind.g_TaggedType_2:
					// traverse syntax tree node associated with production
					// TaggedType: Tag IMPLICIT Type

					if (Raise_TaggedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TaggedType))
						Traverse (p_TaggedType.m_Tag);
					p_TaggedType.turn_inc ();
					if (Raise_TaggedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TaggedType))
						Traverse (p_TaggedType.m_Type);
					p_TaggedType.turn_inc ();
					Raise_TaggedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TaggedType);
				break;
				case TaggedType.production_kind.g_TaggedType_3:
					// traverse syntax tree node associated with production
					// TaggedType: Tag EXPLICIT Type

					if (Raise_TaggedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TaggedType))
						Traverse (p_TaggedType.m_Tag);
					p_TaggedType.turn_inc ();
					if (Raise_TaggedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TaggedType))
						Traverse (p_TaggedType.m_Type);
					p_TaggedType.turn_inc ();
					Raise_TaggedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TaggedType);
				break;
			}
			Raise_TaggedType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TaggedType);
			p_TaggedType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TaggedType
		//

		public void TraverseCommon (TaggedType p_TaggedType)
		{
			TaggedType.production_kind kind = (TaggedType.production_kind) p_TaggedType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TaggedType))
			switch (kind)
			{
				case TaggedType.production_kind.g_TaggedType_1:
					// traverse syntax tree node associated with production
					// TaggedType: Tag Type

						TraverseCommon (p_TaggedType.m_Tag);
						TraverseCommon (p_TaggedType.m_Type);
				break;
				case TaggedType.production_kind.g_TaggedType_2:
					// traverse syntax tree node associated with production
					// TaggedType: Tag IMPLICIT Type

						TraverseCommon (p_TaggedType.m_Tag);
						TraverseCommon (p_TaggedType.m_IMPLICIT);
						TraverseCommon (p_TaggedType.m_Type);
				break;
				case TaggedType.production_kind.g_TaggedType_3:
					// traverse syntax tree node associated with production
					// TaggedType: Tag EXPLICIT Type

						TraverseCommon (p_TaggedType.m_Tag);
						TraverseCommon (p_TaggedType.m_EXPLICIT);
						TraverseCommon (p_TaggedType.m_Type);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TaggedType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TaggedType

		//
		// create syntax tree node associated with production
		// TaggedType: Tag Type

		//

		public TaggedType TaggedType_1 (Tag p_Tag, Type p_Type)
		{
			TaggedType p_TaggedType_ref = new TaggedType(p_Tag, p_Type);
			p_Tag.parent = p_TaggedType_ref;
			p_Type.parent = p_TaggedType_ref;
			Raise_TaggedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TaggedType.production_kind.g_TaggedType_1, p_TaggedType_ref);
			return p_TaggedType_ref;
		}

		//
		// create syntax tree node associated with production
		// TaggedType: Tag IMPLICIT Type

		//

		public TaggedType TaggedType_2 (Tag p_Tag, SyntaxTreeToken p_token, Type p_Type)
		{
			TaggedType p_TaggedType_ref = new TaggedType(p_Tag, p_token, p_Type, 2);
			p_Tag.parent = p_TaggedType_ref;
			p_token.parent = p_TaggedType_ref;
			p_Type.parent = p_TaggedType_ref;
			Raise_TaggedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TaggedType.production_kind.g_TaggedType_2, p_TaggedType_ref);
			return p_TaggedType_ref;
		}

		//
		// create syntax tree node associated with production
		// TaggedType: Tag EXPLICIT Type

		//

		public TaggedType TaggedType_3 (Tag p_Tag, SyntaxTreeToken p_token, Type p_Type)
		{
			TaggedType p_TaggedType_ref = new TaggedType(p_Tag, p_token, p_Type, 3);
			p_Tag.parent = p_TaggedType_ref;
			p_token.parent = p_TaggedType_ref;
			p_Type.parent = p_TaggedType_ref;
			Raise_TaggedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TaggedType.production_kind.g_TaggedType_3, p_TaggedType_ref);
			return p_TaggedType_ref;
		}
		#endregion
	};
}
