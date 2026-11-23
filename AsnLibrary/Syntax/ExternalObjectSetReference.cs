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
	// class associated with syntax rule ExternalObjectSetReference
	//

	[DataContract]
	public class	ExternalObjectSetReference : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExternalObjectSetReference
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExternalObjectSetReference
		{
			g_ExternalObjectSetReference_1 = 1,	// modulereference-token "." objectsetreference-token

		};
		#endregion
		#region production markers associated with the syntax rule ExternalObjectSetReference

		// markers associated with production: ExternalObjectSetReference -> modulereference-token "." objectsetreference-token

		public enum production_marker_1 : ushort
		{
			m_modulereference_token,
			m_objectsetreference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExternalObjectSetReference

		// Constructor declaration(s) associated with production(s) of syntax rule ExternalObjectSetReference

		//
		// Constructor associated with the following production(s)
		// ExternalObjectSetReference -> modulereference-token "." objectsetreference-token

		//

		public ExternalObjectSetReference (modulereference_token p_modulereference_token, SyntaxTreeToken p_token, objectsetreference_token p_objectsetreference_token) : base ((uint) ProductionID._ExternalObjectSetReference_ID, (uint) production_kind.g_ExternalObjectSetReference_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_modulereference_token = p_modulereference_token;
			children[1] = m_dot = p_token;
			children[2] = m_objectsetreference_token = p_objectsetreference_token;
		}

		public ExternalObjectSetReference () { }

		// Copy constructor

		public ExternalObjectSetReference (ExternalObjectSetReference p_ExternalObjectSetReference) : base (p_ExternalObjectSetReference.id, p_ExternalObjectSetReference.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExternalObjectSetReference.appInfo;
			switch ((production_kind) p_ExternalObjectSetReference.kind)
			{
				case production_kind.g_ExternalObjectSetReference_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_modulereference_token = (p_ExternalObjectSetReference.m_modulereference_token != null) ? new modulereference_token (p_ExternalObjectSetReference.m_modulereference_token) : null) != null) m_modulereference_token.parent = this;
					if ((children [1] = m_dot = (p_ExternalObjectSetReference.m_dot != null) ? new SyntaxTreeToken (p_ExternalObjectSetReference.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_objectsetreference_token = (p_ExternalObjectSetReference.m_objectsetreference_token != null) ? new objectsetreference_token (p_ExternalObjectSetReference.m_objectsetreference_token) : null) != null) m_objectsetreference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExternalObjectSetReference" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExternalObjectSetReference (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_modulereference_token?.Dispose ();
			m_dot?.Dispose ();
			m_objectsetreference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExternalObjectSetReference

		// Content changing function(s) associated with production(s) of syntax rule ExternalObjectSetReference

		//
		// Content changing function associated with following production(s)
		// ExternalObjectSetReference -> modulereference-token "." objectsetreference-token

		//

		public void change(modulereference_token p_modulereference_token, SyntaxTreeToken p_token, objectsetreference_token p_objectsetreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExternalObjectSetReference_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_modulereference_token = p_modulereference_token;
			children [1] = m_dot = p_token;
			children [2] = m_objectsetreference_token = p_objectsetreference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExternalObjectSetReference
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_modulereference_token != null) && m_modulereference_token.checkInclusion (element) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_objectsetreference_token != null) && m_objectsetreference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExternalObjectSetReference

		//
		// emit production tree node associated with any production of syntax rule ExternalObjectSetReference
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExternalObjectSetReference_1:
					// emit syntax tree node associated with production
					// ExternalObjectSetReference: modulereference-token "." objectsetreference-token

					s += m_modulereference_token.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_objectsetreference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExternalObjectSetReference
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExternalObjectSetReference (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExternalObjectSetReference_1:
					// emit syntax tree node associated with production
					// ExternalObjectSetReference: modulereference-token "." objectsetreference-token

					s += m_modulereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "dot";
					s += ' ';
					s += m_objectsetreference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExternalObjectSetReference

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalObjectSetReference with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExternalObjectSetReference.production_kind kind = (ExternalObjectSetReference.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExternalObjectSetReference.production_kind.g_ExternalObjectSetReference_1:
					// traverse syntax tree node associated with production
					// ExternalObjectSetReference: modulereference-token "." objectsetreference-token

						m_modulereference_token.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_objectsetreference_token.Visit (visitor, appData);
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
			m_objectsetreference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExternalObjectSetReference
		//

		public void _init ()
		{
			m_modulereference_token = null;
			m_dot = null;
			m_objectsetreference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExternalObjectSetReference

		// counter of all nodes associated with syntax rule ExternalObjectSetReference
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExternalObjectSetReference
		[DataMember (Name = "m_modulereference_token")] public modulereference_token m_modulereference_token { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_objectsetreference_token")] public objectsetreference_token m_objectsetreference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExternalObjectSetReference

		// delegate function (callback) prototype associated with syntax rule ExternalObjectSetReference
		public delegate bool ExternalObjectSetReference_Callback (SyntaxTreeCallbackReason reason, ExternalObjectSetReference.production_kind kind, ExternalObjectSetReference p_ExternalObjectSetReference);

		// event associated with syntax rule ExternalObjectSetReference
		public event ExternalObjectSetReference_Callback ExternalObjectSetReference_Event;

		// event trigger associated with syntax rule ExternalObjectSetReference
		public bool Raise_ExternalObjectSetReference_Event (SyntaxTreeCallbackReason reason, ExternalObjectSetReference.production_kind kind, ExternalObjectSetReference p_ExternalObjectSetReference)
		{
			bool? status = ExternalObjectSetReference_Event?.Invoke (reason, kind, p_ExternalObjectSetReference);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExternalObjectSetReference
		//
		// traverse syntax tree node associated with any production of syntax rule ExternalObjectSetReference
		//

		public void Traverse (ExternalObjectSetReference p_ExternalObjectSetReference)
		{
			if (p_ExternalObjectSetReference.isLocked())
				return;
			p_ExternalObjectSetReference.dolock();
			ExternalObjectSetReference.production_kind kind = (ExternalObjectSetReference.production_kind) p_ExternalObjectSetReference.kind;
			p_ExternalObjectSetReference.turn_reset ();
			if (Raise_ExternalObjectSetReference_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExternalObjectSetReference))
			switch (kind)
			{
				case ExternalObjectSetReference.production_kind.g_ExternalObjectSetReference_1:
					// traverse syntax tree node associated with production
					// ExternalObjectSetReference: modulereference-token "." objectsetreference-token

					if (Raise_ExternalObjectSetReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalObjectSetReference))
						Traverse (p_ExternalObjectSetReference.m_modulereference_token);
					p_ExternalObjectSetReference.turn_inc ();
					if (Raise_ExternalObjectSetReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalObjectSetReference))
						Traverse (p_ExternalObjectSetReference.m_objectsetreference_token);
					p_ExternalObjectSetReference.turn_inc ();
					Raise_ExternalObjectSetReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalObjectSetReference);
				break;
			}
			Raise_ExternalObjectSetReference_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExternalObjectSetReference);
			p_ExternalObjectSetReference.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalObjectSetReference
		//

		public void TraverseCommon (ExternalObjectSetReference p_ExternalObjectSetReference)
		{
			ExternalObjectSetReference.production_kind kind = (ExternalObjectSetReference.production_kind) p_ExternalObjectSetReference.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExternalObjectSetReference))
			switch (kind)
			{
				case ExternalObjectSetReference.production_kind.g_ExternalObjectSetReference_1:
					// traverse syntax tree node associated with production
					// ExternalObjectSetReference: modulereference-token "." objectsetreference-token

						TraverseCommon (p_ExternalObjectSetReference.m_modulereference_token);
						TraverseCommon (p_ExternalObjectSetReference.m_dot);
						TraverseCommon (p_ExternalObjectSetReference.m_objectsetreference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExternalObjectSetReference);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExternalObjectSetReference

		//
		// create syntax tree node associated with production
		// ExternalObjectSetReference: modulereference-token "." objectsetreference-token

		//

		public ExternalObjectSetReference ExternalObjectSetReference_1 (modulereference_token p_modulereference_token, SyntaxTreeToken p_token, objectsetreference_token p_objectsetreference_token)
		{
			ExternalObjectSetReference p_ExternalObjectSetReference_ref = new ExternalObjectSetReference(p_modulereference_token, p_token, p_objectsetreference_token);
			p_modulereference_token.parent = p_ExternalObjectSetReference_ref;
			p_token.parent = p_ExternalObjectSetReference_ref;
			p_objectsetreference_token.parent = p_ExternalObjectSetReference_ref;
			Raise_ExternalObjectSetReference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExternalObjectSetReference.production_kind.g_ExternalObjectSetReference_1, p_ExternalObjectSetReference_ref);
			return p_ExternalObjectSetReference_ref;
		}
		#endregion
	};
}
