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
	// class associated with syntax rule objectsetfieldreference-token
	//

	[DataContract]
	public class	objectsetfieldreference_token : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule objectsetfieldreference-token
		public enum production_kind : ushort	// enumerated production(s) of syntax rule objectsetfieldreference-token
		{
			g_objectsetfieldreference_token_1 = 1,	// "&" typereference-token

		};
		#endregion
		#region production markers associated with the syntax rule objectsetfieldreference-token

		// markers associated with production: objectsetfieldreference-token -> "&" typereference-token

		public enum production_marker_1 : ushort
		{
			m_typereference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule objectsetfieldreference-token

		// Constructor declaration(s) associated with production(s) of syntax rule objectsetfieldreference-token

		//
		// Constructor associated with the following production(s)
		// objectsetfieldreference-token -> "&" typereference-token

		//

		public objectsetfieldreference_token (SyntaxTreeToken p_token, typereference_token p_typereference_token) : base ((uint) ProductionID._objectsetfieldreference_token_ID, (uint) production_kind.g_objectsetfieldreference_token_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ampersand = p_token;
			children[1] = m_typereference_token = p_typereference_token;
		}

		public objectsetfieldreference_token () { }

		// Copy constructor

		public objectsetfieldreference_token (objectsetfieldreference_token p_objectsetfieldreference_token) : base (p_objectsetfieldreference_token.id, p_objectsetfieldreference_token.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_objectsetfieldreference_token.appInfo;
			switch ((production_kind) p_objectsetfieldreference_token.kind)
			{
				case production_kind.g_objectsetfieldreference_token_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ampersand = (p_objectsetfieldreference_token.m_ampersand != null) ? new SyntaxTreeToken (p_objectsetfieldreference_token.m_ampersand) : null) != null) m_ampersand.parent = this;
					if ((children [1] = m_typereference_token = (p_objectsetfieldreference_token.m_typereference_token != null) ? new typereference_token (p_objectsetfieldreference_token.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "objectsetfieldreference_token" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new objectsetfieldreference_token (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ampersand?.Dispose ();
			m_typereference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule objectsetfieldreference-token

		// Content changing function(s) associated with production(s) of syntax rule objectsetfieldreference-token

		//
		// Content changing function associated with following production(s)
		// objectsetfieldreference-token -> "&" typereference-token

		//

		public void change(SyntaxTreeToken p_token, typereference_token p_typereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_objectsetfieldreference_token_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ampersand = p_token;
			children [1] = m_typereference_token = p_typereference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule objectsetfieldreference-token
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ampersand != null) && m_ampersand.checkInclusion (element) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule objectsetfieldreference-token

		//
		// emit production tree node associated with any production of syntax rule objectsetfieldreference-token
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_objectsetfieldreference_token_1:
					// emit syntax tree node associated with production
					// objectsetfieldreference-token: "&" typereference-token

					s += m_ampersand.Emit (depth - 1);
					s += " ";
					s += m_typereference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule objectsetfieldreference-token
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "objectsetfieldreference_token (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_objectsetfieldreference_token_1:
					// emit syntax tree node associated with production
					// objectsetfieldreference-token: "&" typereference-token

					s += "ampersand";
					s += ' ';
					s += m_typereference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule objectsetfieldreference-token

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule objectsetfieldreference-token with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			objectsetfieldreference_token.production_kind kind = (objectsetfieldreference_token.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case objectsetfieldreference_token.production_kind.g_objectsetfieldreference_token_1:
					// traverse syntax tree node associated with production
					// objectsetfieldreference-token: "&" typereference-token

						m_ampersand.Visit (visitor, appData);
						m_typereference_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ampersand?.reparent (this);
			m_typereference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule objectsetfieldreference-token
		//

		public void _init ()
		{
			m_ampersand = null;
			m_typereference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule objectsetfieldreference-token

		// counter of all nodes associated with syntax rule objectsetfieldreference-token
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule objectsetfieldreference-token
		[DataMember (Name = "m_ampersand")] public SyntaxTreeToken m_ampersand { get; private set; }
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule objectsetfieldreference-token

		// delegate function (callback) prototype associated with syntax rule objectsetfieldreference-token
		public delegate bool objectsetfieldreference_token_Callback (SyntaxTreeCallbackReason reason, objectsetfieldreference_token.production_kind kind, objectsetfieldreference_token p_objectsetfieldreference_token);

		// event associated with syntax rule objectsetfieldreference-token
		public event objectsetfieldreference_token_Callback objectsetfieldreference_token_Event;

		// event trigger associated with syntax rule objectsetfieldreference-token
		public bool Raise_objectsetfieldreference_token_Event (SyntaxTreeCallbackReason reason, objectsetfieldreference_token.production_kind kind, objectsetfieldreference_token p_objectsetfieldreference_token)
		{
			bool? status = objectsetfieldreference_token_Event?.Invoke (reason, kind, p_objectsetfieldreference_token);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule objectsetfieldreference-token
		//
		// traverse syntax tree node associated with any production of syntax rule objectsetfieldreference-token
		//

		public void Traverse (objectsetfieldreference_token p_objectsetfieldreference_token)
		{
			if (p_objectsetfieldreference_token.isLocked())
				return;
			p_objectsetfieldreference_token.dolock();
			objectsetfieldreference_token.production_kind kind = (objectsetfieldreference_token.production_kind) p_objectsetfieldreference_token.kind;
			p_objectsetfieldreference_token.turn_reset ();
			if (Raise_objectsetfieldreference_token_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_objectsetfieldreference_token))
			switch (kind)
			{
				case objectsetfieldreference_token.production_kind.g_objectsetfieldreference_token_1:
					// traverse syntax tree node associated with production
					// objectsetfieldreference-token: "&" typereference-token

					if (Raise_objectsetfieldreference_token_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_objectsetfieldreference_token))
						Traverse (p_objectsetfieldreference_token.m_typereference_token);
					p_objectsetfieldreference_token.turn_inc ();
					Raise_objectsetfieldreference_token_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_objectsetfieldreference_token);
				break;
			}
			Raise_objectsetfieldreference_token_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_objectsetfieldreference_token);
			p_objectsetfieldreference_token.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule objectsetfieldreference-token
		//

		public void TraverseCommon (objectsetfieldreference_token p_objectsetfieldreference_token)
		{
			objectsetfieldreference_token.production_kind kind = (objectsetfieldreference_token.production_kind) p_objectsetfieldreference_token.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_objectsetfieldreference_token))
			switch (kind)
			{
				case objectsetfieldreference_token.production_kind.g_objectsetfieldreference_token_1:
					// traverse syntax tree node associated with production
					// objectsetfieldreference-token: "&" typereference-token

						TraverseCommon (p_objectsetfieldreference_token.m_ampersand);
						TraverseCommon (p_objectsetfieldreference_token.m_typereference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_objectsetfieldreference_token);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule objectsetfieldreference-token

		//
		// create syntax tree node associated with production
		// objectsetfieldreference-token: "&" typereference-token

		//

		public objectsetfieldreference_token objectsetfieldreference_token_1 (SyntaxTreeToken p_token, typereference_token p_typereference_token)
		{
			objectsetfieldreference_token p_objectsetfieldreference_token_ref = new objectsetfieldreference_token(p_token, p_typereference_token);
			p_token.parent = p_objectsetfieldreference_token_ref;
			p_typereference_token.parent = p_objectsetfieldreference_token_ref;
			Raise_objectsetfieldreference_token_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, objectsetfieldreference_token.production_kind.g_objectsetfieldreference_token_1, p_objectsetfieldreference_token_ref);
			return p_objectsetfieldreference_token_ref;
		}
		#endregion
	};
}
