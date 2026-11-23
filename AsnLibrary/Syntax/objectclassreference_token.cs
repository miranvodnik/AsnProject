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
	// class associated with syntax rule objectclassreference-token
	//

	[DataContract]
	public class	objectclassreference_token : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule objectclassreference-token
		public enum production_kind : ushort	// enumerated production(s) of syntax rule objectclassreference-token
		{
			g_objectclassreference_token_1 = 1,	// typereference-token

		};
		#endregion
		#region production markers associated with the syntax rule objectclassreference-token

		// markers associated with production: objectclassreference-token -> typereference-token

		public enum production_marker_1 : ushort
		{
			m_typereference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule objectclassreference-token

		// Constructor declaration(s) associated with production(s) of syntax rule objectclassreference-token

		//
		// Constructor associated with the following production(s)
		// objectclassreference-token -> typereference-token

		//

		public objectclassreference_token (typereference_token p_typereference_token) : base ((uint) ProductionID._objectclassreference_token_ID, (uint) production_kind.g_objectclassreference_token_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_typereference_token = p_typereference_token;
		}

		public objectclassreference_token () { }

		// Copy constructor

		public objectclassreference_token (objectclassreference_token p_objectclassreference_token) : base (p_objectclassreference_token.id, p_objectclassreference_token.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_objectclassreference_token.appInfo;
			switch ((production_kind) p_objectclassreference_token.kind)
			{
				case production_kind.g_objectclassreference_token_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_typereference_token = (p_objectclassreference_token.m_typereference_token != null) ? new typereference_token (p_objectclassreference_token.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "objectclassreference_token" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new objectclassreference_token (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_typereference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule objectclassreference-token

		// Content changing function(s) associated with production(s) of syntax rule objectclassreference-token

		//
		// Content changing function associated with following production(s)
		// objectclassreference-token -> typereference-token

		//

		public void change(typereference_token p_typereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_objectclassreference_token_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_typereference_token = p_typereference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule objectclassreference-token
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule objectclassreference-token

		//
		// emit production tree node associated with any production of syntax rule objectclassreference-token
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_objectclassreference_token_1:
					// emit syntax tree node associated with production
					// objectclassreference-token: typereference-token

					s += m_typereference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule objectclassreference-token
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "objectclassreference_token (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_objectclassreference_token_1:
					// emit syntax tree node associated with production
					// objectclassreference-token: typereference-token

					s += m_typereference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule objectclassreference-token

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule objectclassreference-token with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			objectclassreference_token.production_kind kind = (objectclassreference_token.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case objectclassreference_token.production_kind.g_objectclassreference_token_1:
					// traverse syntax tree node associated with production
					// objectclassreference-token: typereference-token

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
		// initialize object associated with syntax rule objectclassreference-token
		//

		public void _init ()
		{
			m_typereference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule objectclassreference-token

		// counter of all nodes associated with syntax rule objectclassreference-token
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule objectclassreference-token
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule objectclassreference-token

		// delegate function (callback) prototype associated with syntax rule objectclassreference-token
		public delegate bool objectclassreference_token_Callback (SyntaxTreeCallbackReason reason, objectclassreference_token.production_kind kind, objectclassreference_token p_objectclassreference_token);

		// event associated with syntax rule objectclassreference-token
		public event objectclassreference_token_Callback objectclassreference_token_Event;

		// event trigger associated with syntax rule objectclassreference-token
		public bool Raise_objectclassreference_token_Event (SyntaxTreeCallbackReason reason, objectclassreference_token.production_kind kind, objectclassreference_token p_objectclassreference_token)
		{
			bool? status = objectclassreference_token_Event?.Invoke (reason, kind, p_objectclassreference_token);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule objectclassreference-token
		//
		// traverse syntax tree node associated with any production of syntax rule objectclassreference-token
		//

		public void Traverse (objectclassreference_token p_objectclassreference_token)
		{
			if (p_objectclassreference_token.isLocked())
				return;
			p_objectclassreference_token.dolock();
			objectclassreference_token.production_kind kind = (objectclassreference_token.production_kind) p_objectclassreference_token.kind;
			p_objectclassreference_token.turn_reset ();
			if (Raise_objectclassreference_token_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_objectclassreference_token))
			switch (kind)
			{
				case objectclassreference_token.production_kind.g_objectclassreference_token_1:
					// traverse syntax tree node associated with production
					// objectclassreference-token: typereference-token

					if (Raise_objectclassreference_token_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_objectclassreference_token))
						Traverse (p_objectclassreference_token.m_typereference_token);
					p_objectclassreference_token.turn_inc ();
					Raise_objectclassreference_token_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_objectclassreference_token);
				break;
			}
			Raise_objectclassreference_token_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_objectclassreference_token);
			p_objectclassreference_token.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule objectclassreference-token
		//

		public void TraverseCommon (objectclassreference_token p_objectclassreference_token)
		{
			objectclassreference_token.production_kind kind = (objectclassreference_token.production_kind) p_objectclassreference_token.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_objectclassreference_token))
			switch (kind)
			{
				case objectclassreference_token.production_kind.g_objectclassreference_token_1:
					// traverse syntax tree node associated with production
					// objectclassreference-token: typereference-token

						TraverseCommon (p_objectclassreference_token.m_typereference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_objectclassreference_token);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule objectclassreference-token

		//
		// create syntax tree node associated with production
		// objectclassreference-token: typereference-token

		//

		public objectclassreference_token objectclassreference_token_1 (typereference_token p_typereference_token)
		{
			objectclassreference_token p_objectclassreference_token_ref = new objectclassreference_token(p_typereference_token);
			p_typereference_token.parent = p_objectclassreference_token_ref;
			Raise_objectclassreference_token_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, objectclassreference_token.production_kind.g_objectclassreference_token_1, p_objectclassreference_token_ref);
			return p_objectclassreference_token_ref;
		}
		#endregion
	};
}
