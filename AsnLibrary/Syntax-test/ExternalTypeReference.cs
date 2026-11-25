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
	// class associated with syntax rule ExternalTypeReference
	//

	[DataContract]
	public class	ExternalTypeReference : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExternalTypeReference
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExternalTypeReference
		{
			g_ExternalTypeReference_1 = 1,	// modulereference-token "." typereference-token

		};
		#endregion
		#region production markers associated with the syntax rule ExternalTypeReference

		// markers associated with production: ExternalTypeReference -> modulereference-token "." typereference-token

		public enum production_marker_1 : ushort
		{
			m_modulereference_token,
			m_typereference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExternalTypeReference

		// Constructor declaration(s) associated with production(s) of syntax rule ExternalTypeReference

		//
		// Constructor associated with the following production(s)
		// ExternalTypeReference -> modulereference-token "." typereference-token

		//

		public ExternalTypeReference (modulereference_token p_modulereference_token, SyntaxTreeToken p_token, typereference_token p_typereference_token) : base ((uint) ProductionID._ExternalTypeReference_ID, (uint) production_kind.g_ExternalTypeReference_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_modulereference_token = p_modulereference_token;
			children[1] = m_dot = p_token;
			children[2] = m_typereference_token = p_typereference_token;
		}

		public ExternalTypeReference () { }

		// Copy constructor

		public ExternalTypeReference (ExternalTypeReference p_ExternalTypeReference) : base (p_ExternalTypeReference.id, p_ExternalTypeReference.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExternalTypeReference.appInfo;
			switch ((production_kind) p_ExternalTypeReference.kind)
			{
				case production_kind.g_ExternalTypeReference_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_modulereference_token = (p_ExternalTypeReference.m_modulereference_token != null) ? new modulereference_token (p_ExternalTypeReference.m_modulereference_token) : null) != null) m_modulereference_token.parent = this;
					if ((children [1] = m_dot = (p_ExternalTypeReference.m_dot != null) ? new SyntaxTreeToken (p_ExternalTypeReference.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_typereference_token = (p_ExternalTypeReference.m_typereference_token != null) ? new typereference_token (p_ExternalTypeReference.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExternalTypeReference" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExternalTypeReference (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_modulereference_token?.Dispose ();
			m_dot?.Dispose ();
			m_typereference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExternalTypeReference

		// Content changing function(s) associated with production(s) of syntax rule ExternalTypeReference

		//
		// Content changing function associated with following production(s)
		// ExternalTypeReference -> modulereference-token "." typereference-token

		//

		public void change(modulereference_token p_modulereference_token, SyntaxTreeToken p_token, typereference_token p_typereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExternalTypeReference_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_modulereference_token = p_modulereference_token;
			children [1] = m_dot = p_token;
			children [2] = m_typereference_token = p_typereference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExternalTypeReference
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_modulereference_token != null) && m_modulereference_token.checkInclusion (element) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExternalTypeReference

		//
		// emit production tree node associated with any production of syntax rule ExternalTypeReference
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExternalTypeReference_1:
					// emit syntax tree node associated with production
					// ExternalTypeReference: modulereference-token "." typereference-token

					s += m_modulereference_token.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_typereference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExternalTypeReference
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExternalTypeReference (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExternalTypeReference_1:
					// emit syntax tree node associated with production
					// ExternalTypeReference: modulereference-token "." typereference-token

					s += m_modulereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "dot";
					s += ' ';
					s += m_typereference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExternalTypeReference

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalTypeReference with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExternalTypeReference.production_kind kind = (ExternalTypeReference.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExternalTypeReference.production_kind.g_ExternalTypeReference_1:
					// traverse syntax tree node associated with production
					// ExternalTypeReference: modulereference-token "." typereference-token

						m_modulereference_token.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_typereference_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_modulereference_token?.reparent (this);
			m_dot?.reparent (this);
			m_typereference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExternalTypeReference
		//

		public void _init ()
		{
			m_modulereference_token = null;
			m_dot = null;
			m_typereference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExternalTypeReference

		// counter of all nodes associated with syntax rule ExternalTypeReference
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExternalTypeReference
		[DataMember (Name = "m_modulereference_token")] public modulereference_token m_modulereference_token { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExternalTypeReference

		// delegate function (callback) prototype associated with syntax rule ExternalTypeReference
		public delegate bool ExternalTypeReference_Callback (SyntaxTreeCallbackReason reason, ExternalTypeReference.production_kind kind, ExternalTypeReference p_ExternalTypeReference);

		// event associated with syntax rule ExternalTypeReference
		public event ExternalTypeReference_Callback ExternalTypeReference_Event;

		// event trigger associated with syntax rule ExternalTypeReference
		public bool Raise_ExternalTypeReference_Event (SyntaxTreeCallbackReason reason, ExternalTypeReference.production_kind kind, ExternalTypeReference p_ExternalTypeReference)
		{
			bool? status = ExternalTypeReference_Event?.Invoke (reason, kind, p_ExternalTypeReference);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExternalTypeReference
		//
		// traverse syntax tree node associated with any production of syntax rule ExternalTypeReference
		//

		public void Traverse (ExternalTypeReference p_ExternalTypeReference)
		{
			if (p_ExternalTypeReference.isLocked())
				return;
			p_ExternalTypeReference.dolock();
			ExternalTypeReference.production_kind kind = (ExternalTypeReference.production_kind) p_ExternalTypeReference.kind;
			p_ExternalTypeReference.turn_reset ();
			if (Raise_ExternalTypeReference_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExternalTypeReference))
			switch (kind)
			{
				case ExternalTypeReference.production_kind.g_ExternalTypeReference_1:
					// traverse syntax tree node associated with production
					// ExternalTypeReference: modulereference-token "." typereference-token

					if (Raise_ExternalTypeReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalTypeReference))
						Traverse (p_ExternalTypeReference.m_modulereference_token);
					p_ExternalTypeReference.turn_inc ();
					if (Raise_ExternalTypeReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalTypeReference))
						Traverse (p_ExternalTypeReference.m_typereference_token);
					p_ExternalTypeReference.turn_inc ();
					Raise_ExternalTypeReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalTypeReference);
				break;
			}
			Raise_ExternalTypeReference_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExternalTypeReference);
			p_ExternalTypeReference.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalTypeReference
		//

		public void TraverseCommon (ExternalTypeReference p_ExternalTypeReference)
		{
			ExternalTypeReference.production_kind kind = (ExternalTypeReference.production_kind) p_ExternalTypeReference.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExternalTypeReference))
			switch (kind)
			{
				case ExternalTypeReference.production_kind.g_ExternalTypeReference_1:
					// traverse syntax tree node associated with production
					// ExternalTypeReference: modulereference-token "." typereference-token

						TraverseCommon (p_ExternalTypeReference.m_modulereference_token);
						TraverseCommon (p_ExternalTypeReference.m_dot);
						TraverseCommon (p_ExternalTypeReference.m_typereference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExternalTypeReference);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExternalTypeReference

		//
		// create syntax tree node associated with production
		// ExternalTypeReference: modulereference-token "." typereference-token

		//

		public ExternalTypeReference ExternalTypeReference_1 (modulereference_token p_modulereference_token, SyntaxTreeToken p_token, typereference_token p_typereference_token)
		{
			ExternalTypeReference p_ExternalTypeReference_ref = new ExternalTypeReference(p_modulereference_token, p_token, p_typereference_token);
			p_modulereference_token.parent = p_ExternalTypeReference_ref;
			p_token.parent = p_ExternalTypeReference_ref;
			p_typereference_token.parent = p_ExternalTypeReference_ref;
			Raise_ExternalTypeReference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExternalTypeReference.production_kind.g_ExternalTypeReference_1, p_ExternalTypeReference_ref);
			return p_ExternalTypeReference_ref;
		}
		#endregion
	};
}
