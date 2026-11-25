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
	// class associated with syntax rule UsefulObjectClassReference
	//

	[DataContract]
	public class	UsefulObjectClassReference : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule UsefulObjectClassReference
		public enum production_kind : ushort	// enumerated production(s) of syntax rule UsefulObjectClassReference
		{
			g_UsefulObjectClassReference_1 = 1,	// TYPE-IDENTIFIER

			g_UsefulObjectClassReference_2 = 2,	// ABSTRACT-SYNTAX

		};
		#endregion
		#region production markers associated with the syntax rule UsefulObjectClassReference

		// markers associated with production: UsefulObjectClassReference -> TYPE-IDENTIFIER

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: UsefulObjectClassReference -> ABSTRACT-SYNTAX

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule UsefulObjectClassReference

		// Constructor declaration(s) associated with production(s) of syntax rule UsefulObjectClassReference

		//
		// Constructor associated with the following production(s)
		// UsefulObjectClassReference -> TYPE-IDENTIFIER

		// UsefulObjectClassReference -> ABSTRACT-SYNTAX

		//

		public UsefulObjectClassReference (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._UsefulObjectClassReference_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_UsefulObjectClassReference_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TYPE_IDENTIFIER = p_token;
				break;
			case production_kind.g_UsefulObjectClassReference_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_ABSTRACT_SYNTAX = p_token;
				break;
			default:
				{
					string[] args = new string[] { "UsefulObjectClassReference" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public UsefulObjectClassReference () { }

		// Copy constructor

		public UsefulObjectClassReference (UsefulObjectClassReference p_UsefulObjectClassReference) : base (p_UsefulObjectClassReference.id, p_UsefulObjectClassReference.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_UsefulObjectClassReference.appInfo;
			switch ((production_kind) p_UsefulObjectClassReference.kind)
			{
				case production_kind.g_UsefulObjectClassReference_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TYPE_IDENTIFIER = (p_UsefulObjectClassReference.m_TYPE_IDENTIFIER != null) ? new SyntaxTreeToken (p_UsefulObjectClassReference.m_TYPE_IDENTIFIER) : null) != null) m_TYPE_IDENTIFIER.parent = this;
					break;
				case production_kind.g_UsefulObjectClassReference_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ABSTRACT_SYNTAX = (p_UsefulObjectClassReference.m_ABSTRACT_SYNTAX != null) ? new SyntaxTreeToken (p_UsefulObjectClassReference.m_ABSTRACT_SYNTAX) : null) != null) m_ABSTRACT_SYNTAX.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "UsefulObjectClassReference" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new UsefulObjectClassReference (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_TYPE_IDENTIFIER?.Dispose ();
			m_ABSTRACT_SYNTAX?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule UsefulObjectClassReference

		// Content changing function(s) associated with production(s) of syntax rule UsefulObjectClassReference

		//
		// Content changing function associated with following production(s)
		// UsefulObjectClassReference -> TYPE-IDENTIFIER

		// UsefulObjectClassReference -> ABSTRACT-SYNTAX

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_UsefulObjectClassReference_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TYPE_IDENTIFIER = p_token;
				break;
			case production_kind.g_UsefulObjectClassReference_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_ABSTRACT_SYNTAX = p_token;
				break;
			default:
				{
					string[] args = new string[] { "UsefulObjectClassReference" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule UsefulObjectClassReference
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_TYPE_IDENTIFIER != null) && m_TYPE_IDENTIFIER.checkInclusion (element) ||
				(m_ABSTRACT_SYNTAX != null) && m_ABSTRACT_SYNTAX.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule UsefulObjectClassReference

		//
		// emit production tree node associated with any production of syntax rule UsefulObjectClassReference
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_UsefulObjectClassReference_1:
					// emit syntax tree node associated with production
					// UsefulObjectClassReference: TYPE-IDENTIFIER

					s += m_TYPE_IDENTIFIER.Emit (depth - 1);
				break;
				case production_kind.g_UsefulObjectClassReference_2:
					// emit syntax tree node associated with production
					// UsefulObjectClassReference: ABSTRACT-SYNTAX

					s += m_ABSTRACT_SYNTAX.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule UsefulObjectClassReference
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "UsefulObjectClassReference (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_UsefulObjectClassReference_1:
					// emit syntax tree node associated with production
					// UsefulObjectClassReference: TYPE-IDENTIFIER

					s += "TYPE_IDENTIFIER";
				break;
				case production_kind.g_UsefulObjectClassReference_2:
					// emit syntax tree node associated with production
					// UsefulObjectClassReference: ABSTRACT-SYNTAX

					s += "ABSTRACT_SYNTAX";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule UsefulObjectClassReference

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule UsefulObjectClassReference with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			UsefulObjectClassReference.production_kind kind = (UsefulObjectClassReference.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case UsefulObjectClassReference.production_kind.g_UsefulObjectClassReference_1:
					// traverse syntax tree node associated with production
					// UsefulObjectClassReference: TYPE-IDENTIFIER

						m_TYPE_IDENTIFIER.Visit (visitor, appData);
				break;
				case UsefulObjectClassReference.production_kind.g_UsefulObjectClassReference_2:
					// traverse syntax tree node associated with production
					// UsefulObjectClassReference: ABSTRACT-SYNTAX

						m_ABSTRACT_SYNTAX.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_TYPE_IDENTIFIER?.reparent (this);
			m_ABSTRACT_SYNTAX?.reparent (this);
		}

		//
		// initialize object associated with syntax rule UsefulObjectClassReference
		//

		public void _init ()
		{
			m_TYPE_IDENTIFIER = null;
			m_ABSTRACT_SYNTAX = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule UsefulObjectClassReference

		// counter of all nodes associated with syntax rule UsefulObjectClassReference
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule UsefulObjectClassReference
		[DataMember (Name = "m_TYPE_IDENTIFIER")] public SyntaxTreeToken m_TYPE_IDENTIFIER { get; private set; }
		[DataMember (Name = "m_ABSTRACT_SYNTAX")] public SyntaxTreeToken m_ABSTRACT_SYNTAX { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule UsefulObjectClassReference

		// delegate function (callback) prototype associated with syntax rule UsefulObjectClassReference
		public delegate bool UsefulObjectClassReference_Callback (SyntaxTreeCallbackReason reason, UsefulObjectClassReference.production_kind kind, UsefulObjectClassReference p_UsefulObjectClassReference);

		// event associated with syntax rule UsefulObjectClassReference
		public event UsefulObjectClassReference_Callback UsefulObjectClassReference_Event;

		// event trigger associated with syntax rule UsefulObjectClassReference
		public bool Raise_UsefulObjectClassReference_Event (SyntaxTreeCallbackReason reason, UsefulObjectClassReference.production_kind kind, UsefulObjectClassReference p_UsefulObjectClassReference)
		{
			bool? status = UsefulObjectClassReference_Event?.Invoke (reason, kind, p_UsefulObjectClassReference);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule UsefulObjectClassReference
		//
		// traverse syntax tree node associated with any production of syntax rule UsefulObjectClassReference
		//

		public void Traverse (UsefulObjectClassReference p_UsefulObjectClassReference)
		{
			if (p_UsefulObjectClassReference.isLocked())
				return;
			p_UsefulObjectClassReference.dolock();
			UsefulObjectClassReference.production_kind kind = (UsefulObjectClassReference.production_kind) p_UsefulObjectClassReference.kind;
			p_UsefulObjectClassReference.turn_reset ();
			if (Raise_UsefulObjectClassReference_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_UsefulObjectClassReference))
			switch (kind)
			{
				case UsefulObjectClassReference.production_kind.g_UsefulObjectClassReference_1:
					// traverse syntax tree node associated with production
					// UsefulObjectClassReference: TYPE-IDENTIFIER

				break;
				case UsefulObjectClassReference.production_kind.g_UsefulObjectClassReference_2:
					// traverse syntax tree node associated with production
					// UsefulObjectClassReference: ABSTRACT-SYNTAX

				break;
			}
			Raise_UsefulObjectClassReference_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_UsefulObjectClassReference);
			p_UsefulObjectClassReference.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule UsefulObjectClassReference
		//

		public void TraverseCommon (UsefulObjectClassReference p_UsefulObjectClassReference)
		{
			UsefulObjectClassReference.production_kind kind = (UsefulObjectClassReference.production_kind) p_UsefulObjectClassReference.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_UsefulObjectClassReference))
			switch (kind)
			{
				case UsefulObjectClassReference.production_kind.g_UsefulObjectClassReference_1:
					// traverse syntax tree node associated with production
					// UsefulObjectClassReference: TYPE-IDENTIFIER

						TraverseCommon (p_UsefulObjectClassReference.m_TYPE_IDENTIFIER);
				break;
				case UsefulObjectClassReference.production_kind.g_UsefulObjectClassReference_2:
					// traverse syntax tree node associated with production
					// UsefulObjectClassReference: ABSTRACT-SYNTAX

						TraverseCommon (p_UsefulObjectClassReference.m_ABSTRACT_SYNTAX);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_UsefulObjectClassReference);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule UsefulObjectClassReference

		//
		// create syntax tree node associated with production
		// UsefulObjectClassReference: TYPE-IDENTIFIER

		//

		public UsefulObjectClassReference UsefulObjectClassReference_1 (SyntaxTreeToken p_token)
		{
			UsefulObjectClassReference p_UsefulObjectClassReference_ref = new UsefulObjectClassReference(p_token, 1);
			p_token.parent = p_UsefulObjectClassReference_ref;
			Raise_UsefulObjectClassReference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulObjectClassReference.production_kind.g_UsefulObjectClassReference_1, p_UsefulObjectClassReference_ref);
			return p_UsefulObjectClassReference_ref;
		}

		//
		// create syntax tree node associated with production
		// UsefulObjectClassReference: ABSTRACT-SYNTAX

		//

		public UsefulObjectClassReference UsefulObjectClassReference_2 (SyntaxTreeToken p_token)
		{
			UsefulObjectClassReference p_UsefulObjectClassReference_ref = new UsefulObjectClassReference(p_token, 2);
			p_token.parent = p_UsefulObjectClassReference_ref;
			Raise_UsefulObjectClassReference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UsefulObjectClassReference.production_kind.g_UsefulObjectClassReference_2, p_UsefulObjectClassReference_ref);
			return p_UsefulObjectClassReference_ref;
		}
		#endregion
	};
}
