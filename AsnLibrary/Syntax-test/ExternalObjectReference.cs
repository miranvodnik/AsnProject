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
	// class associated with syntax rule ExternalObjectReference
	//

	[DataContract]
	public class	ExternalObjectReference : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExternalObjectReference
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExternalObjectReference
		{
			g_ExternalObjectReference_1 = 1,	// modulereference-token "." objectreference-token

		};
		#endregion
		#region production markers associated with the syntax rule ExternalObjectReference

		// markers associated with production: ExternalObjectReference -> modulereference-token "." objectreference-token

		public enum production_marker_1 : ushort
		{
			m_modulereference_token,
			m_objectreference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExternalObjectReference

		// Constructor declaration(s) associated with production(s) of syntax rule ExternalObjectReference

		//
		// Constructor associated with the following production(s)
		// ExternalObjectReference -> modulereference-token "." objectreference-token

		//

		public ExternalObjectReference (modulereference_token p_modulereference_token, SyntaxTreeToken p_token, objectreference_token p_objectreference_token) : base ((uint) ProductionID._ExternalObjectReference_ID, (uint) production_kind.g_ExternalObjectReference_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_modulereference_token = p_modulereference_token;
			children[1] = m_dot = p_token;
			children[2] = m_objectreference_token = p_objectreference_token;
		}

		public ExternalObjectReference () { }

		// Copy constructor

		public ExternalObjectReference (ExternalObjectReference p_ExternalObjectReference) : base (p_ExternalObjectReference.id, p_ExternalObjectReference.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExternalObjectReference.appInfo;
			switch ((production_kind) p_ExternalObjectReference.kind)
			{
				case production_kind.g_ExternalObjectReference_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_modulereference_token = (p_ExternalObjectReference.m_modulereference_token != null) ? new modulereference_token (p_ExternalObjectReference.m_modulereference_token) : null) != null) m_modulereference_token.parent = this;
					if ((children [1] = m_dot = (p_ExternalObjectReference.m_dot != null) ? new SyntaxTreeToken (p_ExternalObjectReference.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_objectreference_token = (p_ExternalObjectReference.m_objectreference_token != null) ? new objectreference_token (p_ExternalObjectReference.m_objectreference_token) : null) != null) m_objectreference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExternalObjectReference" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExternalObjectReference (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_modulereference_token?.Dispose ();
			m_dot?.Dispose ();
			m_objectreference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExternalObjectReference

		// Content changing function(s) associated with production(s) of syntax rule ExternalObjectReference

		//
		// Content changing function associated with following production(s)
		// ExternalObjectReference -> modulereference-token "." objectreference-token

		//

		public void change(modulereference_token p_modulereference_token, SyntaxTreeToken p_token, objectreference_token p_objectreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExternalObjectReference_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_modulereference_token = p_modulereference_token;
			children [1] = m_dot = p_token;
			children [2] = m_objectreference_token = p_objectreference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExternalObjectReference
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_modulereference_token != null) && m_modulereference_token.checkInclusion (element) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_objectreference_token != null) && m_objectreference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExternalObjectReference

		//
		// emit production tree node associated with any production of syntax rule ExternalObjectReference
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExternalObjectReference_1:
					// emit syntax tree node associated with production
					// ExternalObjectReference: modulereference-token "." objectreference-token

					s += m_modulereference_token.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_objectreference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExternalObjectReference
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExternalObjectReference (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExternalObjectReference_1:
					// emit syntax tree node associated with production
					// ExternalObjectReference: modulereference-token "." objectreference-token

					s += m_modulereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "dot";
					s += ' ';
					s += m_objectreference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExternalObjectReference

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalObjectReference with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExternalObjectReference.production_kind kind = (ExternalObjectReference.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExternalObjectReference.production_kind.g_ExternalObjectReference_1:
					// traverse syntax tree node associated with production
					// ExternalObjectReference: modulereference-token "." objectreference-token

						m_modulereference_token.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_objectreference_token.Visit (visitor, appData);
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
			m_objectreference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExternalObjectReference
		//

		public void _init ()
		{
			m_modulereference_token = null;
			m_dot = null;
			m_objectreference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExternalObjectReference

		// counter of all nodes associated with syntax rule ExternalObjectReference
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExternalObjectReference
		[DataMember (Name = "m_modulereference_token")] public modulereference_token m_modulereference_token { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_objectreference_token")] public objectreference_token m_objectreference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExternalObjectReference

		// delegate function (callback) prototype associated with syntax rule ExternalObjectReference
		public delegate bool ExternalObjectReference_Callback (SyntaxTreeCallbackReason reason, ExternalObjectReference.production_kind kind, ExternalObjectReference p_ExternalObjectReference);

		// event associated with syntax rule ExternalObjectReference
		public event ExternalObjectReference_Callback ExternalObjectReference_Event;

		// event trigger associated with syntax rule ExternalObjectReference
		public bool Raise_ExternalObjectReference_Event (SyntaxTreeCallbackReason reason, ExternalObjectReference.production_kind kind, ExternalObjectReference p_ExternalObjectReference)
		{
			bool? status = ExternalObjectReference_Event?.Invoke (reason, kind, p_ExternalObjectReference);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExternalObjectReference
		//
		// traverse syntax tree node associated with any production of syntax rule ExternalObjectReference
		//

		public void Traverse (ExternalObjectReference p_ExternalObjectReference)
		{
			if (p_ExternalObjectReference.isLocked())
				return;
			p_ExternalObjectReference.dolock();
			ExternalObjectReference.production_kind kind = (ExternalObjectReference.production_kind) p_ExternalObjectReference.kind;
			p_ExternalObjectReference.turn_reset ();
			if (Raise_ExternalObjectReference_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExternalObjectReference))
			switch (kind)
			{
				case ExternalObjectReference.production_kind.g_ExternalObjectReference_1:
					// traverse syntax tree node associated with production
					// ExternalObjectReference: modulereference-token "." objectreference-token

					if (Raise_ExternalObjectReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalObjectReference))
						Traverse (p_ExternalObjectReference.m_modulereference_token);
					p_ExternalObjectReference.turn_inc ();
					if (Raise_ExternalObjectReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalObjectReference))
						Traverse (p_ExternalObjectReference.m_objectreference_token);
					p_ExternalObjectReference.turn_inc ();
					Raise_ExternalObjectReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalObjectReference);
				break;
			}
			Raise_ExternalObjectReference_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExternalObjectReference);
			p_ExternalObjectReference.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalObjectReference
		//

		public void TraverseCommon (ExternalObjectReference p_ExternalObjectReference)
		{
			ExternalObjectReference.production_kind kind = (ExternalObjectReference.production_kind) p_ExternalObjectReference.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExternalObjectReference))
			switch (kind)
			{
				case ExternalObjectReference.production_kind.g_ExternalObjectReference_1:
					// traverse syntax tree node associated with production
					// ExternalObjectReference: modulereference-token "." objectreference-token

						TraverseCommon (p_ExternalObjectReference.m_modulereference_token);
						TraverseCommon (p_ExternalObjectReference.m_dot);
						TraverseCommon (p_ExternalObjectReference.m_objectreference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExternalObjectReference);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExternalObjectReference

		//
		// create syntax tree node associated with production
		// ExternalObjectReference: modulereference-token "." objectreference-token

		//

		public ExternalObjectReference ExternalObjectReference_1 (modulereference_token p_modulereference_token, SyntaxTreeToken p_token, objectreference_token p_objectreference_token)
		{
			ExternalObjectReference p_ExternalObjectReference_ref = new ExternalObjectReference(p_modulereference_token, p_token, p_objectreference_token);
			p_modulereference_token.parent = p_ExternalObjectReference_ref;
			p_token.parent = p_ExternalObjectReference_ref;
			p_objectreference_token.parent = p_ExternalObjectReference_ref;
			Raise_ExternalObjectReference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExternalObjectReference.production_kind.g_ExternalObjectReference_1, p_ExternalObjectReference_ref);
			return p_ExternalObjectReference_ref;
		}
		#endregion
	};
}
