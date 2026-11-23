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
	// class associated with syntax rule objectsetreference-token
	//

	[DataContract]
	public class	objectsetreference_token : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule objectsetreference-token
		public enum production_kind : ushort	// enumerated production(s) of syntax rule objectsetreference-token
		{
			g_objectsetreference_token_1 = 1,	// typereference-token

		};
		#endregion
		#region production markers associated with the syntax rule objectsetreference-token

		// markers associated with production: objectsetreference-token -> typereference-token

		public enum production_marker_1 : ushort
		{
			m_typereference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule objectsetreference-token

		// Constructor declaration(s) associated with production(s) of syntax rule objectsetreference-token

		//
		// Constructor associated with the following production(s)
		// objectsetreference-token -> typereference-token

		//

		public objectsetreference_token (typereference_token p_typereference_token) : base ((uint) ProductionID._objectsetreference_token_ID, (uint) production_kind.g_objectsetreference_token_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_typereference_token = p_typereference_token;
		}

		public objectsetreference_token () { }

		// Copy constructor

		public objectsetreference_token (objectsetreference_token p_objectsetreference_token) : base (p_objectsetreference_token.id, p_objectsetreference_token.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_objectsetreference_token.appInfo;
			switch ((production_kind) p_objectsetreference_token.kind)
			{
				case production_kind.g_objectsetreference_token_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_typereference_token = (p_objectsetreference_token.m_typereference_token != null) ? new typereference_token (p_objectsetreference_token.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "objectsetreference_token" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new objectsetreference_token (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_typereference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule objectsetreference-token

		// Content changing function(s) associated with production(s) of syntax rule objectsetreference-token

		//
		// Content changing function associated with following production(s)
		// objectsetreference-token -> typereference-token

		//

		public void change(typereference_token p_typereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_objectsetreference_token_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_typereference_token = p_typereference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule objectsetreference-token
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule objectsetreference-token

		//
		// emit production tree node associated with any production of syntax rule objectsetreference-token
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_objectsetreference_token_1:
					// emit syntax tree node associated with production
					// objectsetreference-token: typereference-token

					s += m_typereference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule objectsetreference-token
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "objectsetreference_token (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_objectsetreference_token_1:
					// emit syntax tree node associated with production
					// objectsetreference-token: typereference-token

					s += m_typereference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule objectsetreference-token

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule objectsetreference-token with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			objectsetreference_token.production_kind kind = (objectsetreference_token.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case objectsetreference_token.production_kind.g_objectsetreference_token_1:
					// traverse syntax tree node associated with production
					// objectsetreference-token: typereference-token

						m_typereference_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_typereference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule objectsetreference-token
		//

		public void _init ()
		{
			m_typereference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule objectsetreference-token

		// counter of all nodes associated with syntax rule objectsetreference-token
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule objectsetreference-token
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule objectsetreference-token

		// delegate function (callback) prototype associated with syntax rule objectsetreference-token
		public delegate bool objectsetreference_token_Callback (SyntaxTreeCallbackReason reason, objectsetreference_token.production_kind kind, objectsetreference_token p_objectsetreference_token);

		// event associated with syntax rule objectsetreference-token
		public event objectsetreference_token_Callback objectsetreference_token_Event;

		// event trigger associated with syntax rule objectsetreference-token
		public bool Raise_objectsetreference_token_Event (SyntaxTreeCallbackReason reason, objectsetreference_token.production_kind kind, objectsetreference_token p_objectsetreference_token)
		{
			bool? status = objectsetreference_token_Event?.Invoke (reason, kind, p_objectsetreference_token);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule objectsetreference-token
		//
		// traverse syntax tree node associated with any production of syntax rule objectsetreference-token
		//

		public void Traverse (objectsetreference_token p_objectsetreference_token)
		{
			if (p_objectsetreference_token.isLocked())
				return;
			p_objectsetreference_token.dolock();
			objectsetreference_token.production_kind kind = (objectsetreference_token.production_kind) p_objectsetreference_token.kind;
			p_objectsetreference_token.turn_reset ();
			if (Raise_objectsetreference_token_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_objectsetreference_token))
			switch (kind)
			{
				case objectsetreference_token.production_kind.g_objectsetreference_token_1:
					// traverse syntax tree node associated with production
					// objectsetreference-token: typereference-token

					if (Raise_objectsetreference_token_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_objectsetreference_token))
						Traverse (p_objectsetreference_token.m_typereference_token);
					p_objectsetreference_token.turn_inc ();
					Raise_objectsetreference_token_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_objectsetreference_token);
				break;
			}
			Raise_objectsetreference_token_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_objectsetreference_token);
			p_objectsetreference_token.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule objectsetreference-token
		//

		public void TraverseCommon (objectsetreference_token p_objectsetreference_token)
		{
			objectsetreference_token.production_kind kind = (objectsetreference_token.production_kind) p_objectsetreference_token.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_objectsetreference_token))
			switch (kind)
			{
				case objectsetreference_token.production_kind.g_objectsetreference_token_1:
					// traverse syntax tree node associated with production
					// objectsetreference-token: typereference-token

						TraverseCommon (p_objectsetreference_token.m_typereference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_objectsetreference_token);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule objectsetreference-token

		//
		// create syntax tree node associated with production
		// objectsetreference-token: typereference-token

		//

		public objectsetreference_token objectsetreference_token_1 (typereference_token p_typereference_token)
		{
			objectsetreference_token p_objectsetreference_token_ref = new objectsetreference_token(p_typereference_token);
			p_typereference_token.parent = p_objectsetreference_token_ref;
			Raise_objectsetreference_token_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, objectsetreference_token.production_kind.g_objectsetreference_token_1, p_objectsetreference_token_ref);
			return p_objectsetreference_token_ref;
		}
		#endregion
	};
}
