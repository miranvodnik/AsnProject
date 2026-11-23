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
	// class associated with syntax rule TagDefault
	//

	[DataContract]
	public class	TagDefault : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TagDefault
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TagDefault
		{
			g_TagDefault_1 = 1,	// EXPLICIT TAGS

			g_TagDefault_2 = 2,	// IMPLICIT TAGS

			g_TagDefault_3 = 3,	// AUTOMATIC TAGS

			g_TagDefault_4 = 4,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule TagDefault

		// markers associated with production: TagDefault -> EXPLICIT TAGS

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: TagDefault -> IMPLICIT TAGS

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: TagDefault -> AUTOMATIC TAGS

		public enum production_marker_3 : ushort
		{
			final
		};

		// markers associated with production: TagDefault -> %empty

		public enum production_marker_4 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TagDefault

		// Constructor declaration(s) associated with production(s) of syntax rule TagDefault

		//
		// Constructor associated with the following production(s)
		// TagDefault -> EXPLICIT TAGS

		// TagDefault -> IMPLICIT TAGS

		// TagDefault -> AUTOMATIC TAGS

		//

		public TagDefault (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, int kind) : base ((uint) ProductionID._TagDefault_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TagDefault_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
				children[0] = m_EXPLICIT = p_token;
				children[1] = m_TAGS = p_token_1;
				break;
			case production_kind.g_TagDefault_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
				children[0] = m_IMPLICIT = p_token;
				children[1] = m_TAGS = p_token_1;
				break;
			case production_kind.g_TagDefault_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
				children[0] = m_AUTOMATIC = p_token;
				children[1] = m_TAGS = p_token_1;
				break;
			default:
				{
					string[] args = new string[] { "TagDefault" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		//
		// Constructor associated with the following production(s)
		// TagDefault -> %empty

		//

		public TagDefault () : base ((uint) ProductionID._TagDefault_ID, (uint) production_kind.g_TagDefault_4)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public TagDefault (TagDefault p_TagDefault) : base (p_TagDefault.id, p_TagDefault.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TagDefault.appInfo;
			switch ((production_kind) p_TagDefault.kind)
			{
				case production_kind.g_TagDefault_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_EXPLICIT = (p_TagDefault.m_EXPLICIT != null) ? new SyntaxTreeToken (p_TagDefault.m_EXPLICIT) : null) != null) m_EXPLICIT.parent = this;
					if ((children [1] = m_TAGS = (p_TagDefault.m_TAGS != null) ? new SyntaxTreeToken (p_TagDefault.m_TAGS) : null) != null) m_TAGS.parent = this;
					break;
				case production_kind.g_TagDefault_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_IMPLICIT = (p_TagDefault.m_IMPLICIT != null) ? new SyntaxTreeToken (p_TagDefault.m_IMPLICIT) : null) != null) m_IMPLICIT.parent = this;
					if ((children [1] = m_TAGS = (p_TagDefault.m_TAGS != null) ? new SyntaxTreeToken (p_TagDefault.m_TAGS) : null) != null) m_TAGS.parent = this;
					break;
				case production_kind.g_TagDefault_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_AUTOMATIC = (p_TagDefault.m_AUTOMATIC != null) ? new SyntaxTreeToken (p_TagDefault.m_AUTOMATIC) : null) != null) m_AUTOMATIC.parent = this;
					if ((children [1] = m_TAGS = (p_TagDefault.m_TAGS != null) ? new SyntaxTreeToken (p_TagDefault.m_TAGS) : null) != null) m_TAGS.parent = this;
					break;
				case production_kind.g_TagDefault_4:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "TagDefault" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TagDefault (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_EXPLICIT?.Dispose ();
			m_TAGS?.Dispose ();
			m_IMPLICIT?.Dispose ();
			m_AUTOMATIC?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TagDefault

		// Content changing function(s) associated with production(s) of syntax rule TagDefault

		//
		// Content changing function associated with following production(s)
		// TagDefault -> EXPLICIT TAGS

		// TagDefault -> IMPLICIT TAGS

		// TagDefault -> AUTOMATIC TAGS

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_TagDefault_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
				children [0] = m_EXPLICIT = p_token;
				children [1] = m_TAGS = p_token_1;
				break;
			case production_kind.g_TagDefault_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
				children [0] = m_IMPLICIT = p_token;
				children [1] = m_TAGS = p_token_1;
				break;
			case production_kind.g_TagDefault_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
				children [0] = m_AUTOMATIC = p_token;
				children [1] = m_TAGS = p_token_1;
				break;
			default:
				{
					string[] args = new string[] { "TagDefault" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TagDefault -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_TagDefault_4;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TagDefault
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_EXPLICIT != null) && m_EXPLICIT.checkInclusion (element) ||
				(m_TAGS != null) && m_TAGS.checkInclusion (element) ||
				(m_IMPLICIT != null) && m_IMPLICIT.checkInclusion (element) ||
				(m_AUTOMATIC != null) && m_AUTOMATIC.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TagDefault

		//
		// emit production tree node associated with any production of syntax rule TagDefault
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TagDefault_1:
					// emit syntax tree node associated with production
					// TagDefault: EXPLICIT TAGS

					s += m_EXPLICIT.Emit (depth - 1);
					s += " ";
					s += m_TAGS.Emit (depth - 1);
				break;
				case production_kind.g_TagDefault_2:
					// emit syntax tree node associated with production
					// TagDefault: IMPLICIT TAGS

					s += m_IMPLICIT.Emit (depth - 1);
					s += " ";
					s += m_TAGS.Emit (depth - 1);
				break;
				case production_kind.g_TagDefault_3:
					// emit syntax tree node associated with production
					// TagDefault: AUTOMATIC TAGS

					s += m_AUTOMATIC.Emit (depth - 1);
					s += " ";
					s += m_TAGS.Emit (depth - 1);
				break;
				case production_kind.g_TagDefault_4:
					// emit syntax tree node associated with production
					// TagDefault: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TagDefault
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TagDefault (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TagDefault_1:
					// emit syntax tree node associated with production
					// TagDefault: EXPLICIT TAGS

					s += "EXPLICIT";
					s += ' ';
					s += "TAGS";
				break;
				case production_kind.g_TagDefault_2:
					// emit syntax tree node associated with production
					// TagDefault: IMPLICIT TAGS

					s += "IMPLICIT";
					s += ' ';
					s += "TAGS";
				break;
				case production_kind.g_TagDefault_3:
					// emit syntax tree node associated with production
					// TagDefault: AUTOMATIC TAGS

					s += "AUTOMATIC";
					s += ' ';
					s += "TAGS";
				break;
				case production_kind.g_TagDefault_4:
					// emit syntax tree node associated with production
					// TagDefault: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TagDefault

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TagDefault with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TagDefault.production_kind kind = (TagDefault.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TagDefault.production_kind.g_TagDefault_1:
					// traverse syntax tree node associated with production
					// TagDefault: EXPLICIT TAGS

						m_EXPLICIT.Visit (visitor, appData);
						m_TAGS.Visit (visitor, appData);
				break;
				case TagDefault.production_kind.g_TagDefault_2:
					// traverse syntax tree node associated with production
					// TagDefault: IMPLICIT TAGS

						m_IMPLICIT.Visit (visitor, appData);
						m_TAGS.Visit (visitor, appData);
				break;
				case TagDefault.production_kind.g_TagDefault_3:
					// traverse syntax tree node associated with production
					// TagDefault: AUTOMATIC TAGS

						m_AUTOMATIC.Visit (visitor, appData);
						m_TAGS.Visit (visitor, appData);
				break;
				case TagDefault.production_kind.g_TagDefault_4:
					// traverse syntax tree node associated with production
					// TagDefault: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_EXPLICIT?.reparent (this);
			m_TAGS?.reparent (this);
			m_IMPLICIT?.reparent (this);
			m_AUTOMATIC?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TagDefault
		//

		public void _init ()
		{
			m_EXPLICIT = null;
			m_TAGS = null;
			m_IMPLICIT = null;
			m_AUTOMATIC = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TagDefault

		// counter of all nodes associated with syntax rule TagDefault
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TagDefault
		[DataMember (Name = "m_EXPLICIT")] public SyntaxTreeToken m_EXPLICIT { get; private set; }
		[DataMember (Name = "m_TAGS")] public SyntaxTreeToken m_TAGS { get; private set; }
		[DataMember (Name = "m_IMPLICIT")] public SyntaxTreeToken m_IMPLICIT { get; private set; }
		[DataMember (Name = "m_AUTOMATIC")] public SyntaxTreeToken m_AUTOMATIC { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TagDefault

		// delegate function (callback) prototype associated with syntax rule TagDefault
		public delegate bool TagDefault_Callback (SyntaxTreeCallbackReason reason, TagDefault.production_kind kind, TagDefault p_TagDefault);

		// event associated with syntax rule TagDefault
		public event TagDefault_Callback TagDefault_Event;

		// event trigger associated with syntax rule TagDefault
		public bool Raise_TagDefault_Event (SyntaxTreeCallbackReason reason, TagDefault.production_kind kind, TagDefault p_TagDefault)
		{
			bool? status = TagDefault_Event?.Invoke (reason, kind, p_TagDefault);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TagDefault
		//
		// traverse syntax tree node associated with any production of syntax rule TagDefault
		//

		public void Traverse (TagDefault p_TagDefault)
		{
			if (p_TagDefault.isLocked())
				return;
			p_TagDefault.dolock();
			TagDefault.production_kind kind = (TagDefault.production_kind) p_TagDefault.kind;
			p_TagDefault.turn_reset ();
			if (Raise_TagDefault_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TagDefault))
			switch (kind)
			{
				case TagDefault.production_kind.g_TagDefault_1:
					// traverse syntax tree node associated with production
					// TagDefault: EXPLICIT TAGS

				break;
				case TagDefault.production_kind.g_TagDefault_2:
					// traverse syntax tree node associated with production
					// TagDefault: IMPLICIT TAGS

				break;
				case TagDefault.production_kind.g_TagDefault_3:
					// traverse syntax tree node associated with production
					// TagDefault: AUTOMATIC TAGS

				break;
				case TagDefault.production_kind.g_TagDefault_4:
					// traverse syntax tree node associated with production
					// TagDefault: %empty

				break;
			}
			Raise_TagDefault_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TagDefault);
			p_TagDefault.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TagDefault
		//

		public void TraverseCommon (TagDefault p_TagDefault)
		{
			TagDefault.production_kind kind = (TagDefault.production_kind) p_TagDefault.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TagDefault))
			switch (kind)
			{
				case TagDefault.production_kind.g_TagDefault_1:
					// traverse syntax tree node associated with production
					// TagDefault: EXPLICIT TAGS

						TraverseCommon (p_TagDefault.m_EXPLICIT);
						TraverseCommon (p_TagDefault.m_TAGS);
				break;
				case TagDefault.production_kind.g_TagDefault_2:
					// traverse syntax tree node associated with production
					// TagDefault: IMPLICIT TAGS

						TraverseCommon (p_TagDefault.m_IMPLICIT);
						TraverseCommon (p_TagDefault.m_TAGS);
				break;
				case TagDefault.production_kind.g_TagDefault_3:
					// traverse syntax tree node associated with production
					// TagDefault: AUTOMATIC TAGS

						TraverseCommon (p_TagDefault.m_AUTOMATIC);
						TraverseCommon (p_TagDefault.m_TAGS);
				break;
				case TagDefault.production_kind.g_TagDefault_4:
					// traverse syntax tree node associated with production
					// TagDefault: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TagDefault);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TagDefault

		//
		// create syntax tree node associated with production
		// TagDefault: EXPLICIT TAGS

		//

		public TagDefault TagDefault_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			TagDefault p_TagDefault_ref = new TagDefault(p_token, p_token_1, 1);
			p_token.parent = p_TagDefault_ref;
			p_token_1.parent = p_TagDefault_ref;
			Raise_TagDefault_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TagDefault.production_kind.g_TagDefault_1, p_TagDefault_ref);
			return p_TagDefault_ref;
		}

		//
		// create syntax tree node associated with production
		// TagDefault: IMPLICIT TAGS

		//

		public TagDefault TagDefault_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			TagDefault p_TagDefault_ref = new TagDefault(p_token, p_token_1, 2);
			p_token.parent = p_TagDefault_ref;
			p_token_1.parent = p_TagDefault_ref;
			Raise_TagDefault_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TagDefault.production_kind.g_TagDefault_2, p_TagDefault_ref);
			return p_TagDefault_ref;
		}

		//
		// create syntax tree node associated with production
		// TagDefault: AUTOMATIC TAGS

		//

		public TagDefault TagDefault_3 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			TagDefault p_TagDefault_ref = new TagDefault(p_token, p_token_1, 3);
			p_token.parent = p_TagDefault_ref;
			p_token_1.parent = p_TagDefault_ref;
			Raise_TagDefault_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TagDefault.production_kind.g_TagDefault_3, p_TagDefault_ref);
			return p_TagDefault_ref;
		}

		//
		// create syntax tree node associated with production
		// TagDefault: %empty

		//

		public TagDefault TagDefault_4 ()
		{
			TagDefault p_TagDefault_ref = new TagDefault();
			Raise_TagDefault_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TagDefault.production_kind.g_TagDefault_4, p_TagDefault_ref);
			return p_TagDefault_ref;
		}
		#endregion
	};
}
