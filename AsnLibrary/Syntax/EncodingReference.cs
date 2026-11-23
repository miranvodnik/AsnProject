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
	// class associated with syntax rule EncodingReference
	//

	[DataContract]
	public class	EncodingReference : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EncodingReference
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EncodingReference
		{
			g_EncodingReference_1 = 1,	// encodingreference-token ":"

			g_EncodingReference_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule EncodingReference

		// markers associated with production: EncodingReference -> encodingreference-token ":"

		public enum production_marker_1 : ushort
		{
			m_encodingreference_token,
			final
		};

		// markers associated with production: EncodingReference -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EncodingReference

		// Constructor declaration(s) associated with production(s) of syntax rule EncodingReference

		//
		// Constructor associated with the following production(s)
		// EncodingReference -> encodingreference-token ":"

		//

		public EncodingReference (encodingreference_token p_encodingreference_token, SyntaxTreeToken p_token) : base ((uint) ProductionID._EncodingReference_ID, (uint) production_kind.g_EncodingReference_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_encodingreference_token = p_encodingreference_token;
			children[1] = m_colon = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// EncodingReference -> %empty

		//

		public EncodingReference () : base ((uint) ProductionID._EncodingReference_ID, (uint) production_kind.g_EncodingReference_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public EncodingReference (EncodingReference p_EncodingReference) : base (p_EncodingReference.id, p_EncodingReference.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EncodingReference.appInfo;
			switch ((production_kind) p_EncodingReference.kind)
			{
				case production_kind.g_EncodingReference_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_encodingreference_token = (p_EncodingReference.m_encodingreference_token != null) ? new encodingreference_token (p_EncodingReference.m_encodingreference_token) : null) != null) m_encodingreference_token.parent = this;
					if ((children [1] = m_colon = (p_EncodingReference.m_colon != null) ? new SyntaxTreeToken (p_EncodingReference.m_colon) : null) != null) m_colon.parent = this;
					break;
				case production_kind.g_EncodingReference_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "EncodingReference" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EncodingReference (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_encodingreference_token?.Dispose ();
			m_colon?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EncodingReference

		// Content changing function(s) associated with production(s) of syntax rule EncodingReference

		//
		// Content changing function associated with following production(s)
		// EncodingReference -> encodingreference-token ":"

		//

		public void change(encodingreference_token p_encodingreference_token, SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_EncodingReference_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_encodingreference_token = p_encodingreference_token;
			children [1] = m_colon = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// EncodingReference -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_EncodingReference_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EncodingReference
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_encodingreference_token != null) && m_encodingreference_token.checkInclusion (element) ||
				(m_colon != null) && m_colon.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EncodingReference

		//
		// emit production tree node associated with any production of syntax rule EncodingReference
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EncodingReference_1:
					// emit syntax tree node associated with production
					// EncodingReference: encodingreference-token ":"

					s += m_encodingreference_token.Emit (depth - 1);
					s += " ";
					s += m_colon.Emit (depth - 1);
				break;
				case production_kind.g_EncodingReference_2:
					// emit syntax tree node associated with production
					// EncodingReference: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EncodingReference
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EncodingReference (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EncodingReference_1:
					// emit syntax tree node associated with production
					// EncodingReference: encodingreference-token ":"

					s += m_encodingreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "colon";
				break;
				case production_kind.g_EncodingReference_2:
					// emit syntax tree node associated with production
					// EncodingReference: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EncodingReference

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EncodingReference with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EncodingReference.production_kind kind = (EncodingReference.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EncodingReference.production_kind.g_EncodingReference_1:
					// traverse syntax tree node associated with production
					// EncodingReference: encodingreference-token ":"

						m_encodingreference_token.Visit (visitor, appData);
						m_colon.Visit (visitor, appData);
				break;
				case EncodingReference.production_kind.g_EncodingReference_2:
					// traverse syntax tree node associated with production
					// EncodingReference: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_encodingreference_token?.reparent (this);
			m_colon?.reparent (this);
		}

		//
		// initialize object associated with syntax rule EncodingReference
		//

		public void _init ()
		{
			m_encodingreference_token = null;
			m_colon = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EncodingReference

		// counter of all nodes associated with syntax rule EncodingReference
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EncodingReference
		[DataMember (Name = "m_encodingreference_token")] public encodingreference_token m_encodingreference_token { get; private set; }
		[DataMember (Name = "m_colon")] public SyntaxTreeToken m_colon { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EncodingReference

		// delegate function (callback) prototype associated with syntax rule EncodingReference
		public delegate bool EncodingReference_Callback (SyntaxTreeCallbackReason reason, EncodingReference.production_kind kind, EncodingReference p_EncodingReference);

		// event associated with syntax rule EncodingReference
		public event EncodingReference_Callback EncodingReference_Event;

		// event trigger associated with syntax rule EncodingReference
		public bool Raise_EncodingReference_Event (SyntaxTreeCallbackReason reason, EncodingReference.production_kind kind, EncodingReference p_EncodingReference)
		{
			bool? status = EncodingReference_Event?.Invoke (reason, kind, p_EncodingReference);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EncodingReference
		//
		// traverse syntax tree node associated with any production of syntax rule EncodingReference
		//

		public void Traverse (EncodingReference p_EncodingReference)
		{
			if (p_EncodingReference.isLocked())
				return;
			p_EncodingReference.dolock();
			EncodingReference.production_kind kind = (EncodingReference.production_kind) p_EncodingReference.kind;
			p_EncodingReference.turn_reset ();
			if (Raise_EncodingReference_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EncodingReference))
			switch (kind)
			{
				case EncodingReference.production_kind.g_EncodingReference_1:
					// traverse syntax tree node associated with production
					// EncodingReference: encodingreference-token ":"

					if (Raise_EncodingReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EncodingReference))
						Traverse (p_EncodingReference.m_encodingreference_token);
					p_EncodingReference.turn_inc ();
					Raise_EncodingReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EncodingReference);
				break;
				case EncodingReference.production_kind.g_EncodingReference_2:
					// traverse syntax tree node associated with production
					// EncodingReference: %empty

				break;
			}
			Raise_EncodingReference_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EncodingReference);
			p_EncodingReference.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EncodingReference
		//

		public void TraverseCommon (EncodingReference p_EncodingReference)
		{
			EncodingReference.production_kind kind = (EncodingReference.production_kind) p_EncodingReference.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EncodingReference))
			switch (kind)
			{
				case EncodingReference.production_kind.g_EncodingReference_1:
					// traverse syntax tree node associated with production
					// EncodingReference: encodingreference-token ":"

						TraverseCommon (p_EncodingReference.m_encodingreference_token);
						TraverseCommon (p_EncodingReference.m_colon);
				break;
				case EncodingReference.production_kind.g_EncodingReference_2:
					// traverse syntax tree node associated with production
					// EncodingReference: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EncodingReference);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EncodingReference

		//
		// create syntax tree node associated with production
		// EncodingReference: encodingreference-token ":"

		//

		public EncodingReference EncodingReference_1 (encodingreference_token p_encodingreference_token, SyntaxTreeToken p_token)
		{
			EncodingReference p_EncodingReference_ref = new EncodingReference(p_encodingreference_token, p_token);
			p_encodingreference_token.parent = p_EncodingReference_ref;
			p_token.parent = p_EncodingReference_ref;
			Raise_EncodingReference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EncodingReference.production_kind.g_EncodingReference_1, p_EncodingReference_ref);
			return p_EncodingReference_ref;
		}

		//
		// create syntax tree node associated with production
		// EncodingReference: %empty

		//

		public EncodingReference EncodingReference_2 ()
		{
			EncodingReference p_EncodingReference_ref = new EncodingReference();
			Raise_EncodingReference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EncodingReference.production_kind.g_EncodingReference_2, p_EncodingReference_ref);
			return p_EncodingReference_ref;
		}
		#endregion
	};
}
