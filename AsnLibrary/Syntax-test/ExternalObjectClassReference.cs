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
	// class associated with syntax rule ExternalObjectClassReference
	//

	[DataContract]
	public class	ExternalObjectClassReference : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExternalObjectClassReference
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExternalObjectClassReference
		{
			g_ExternalObjectClassReference_1 = 1,	// modulereference-token "." objectclassreference-token

		};
		#endregion
		#region production markers associated with the syntax rule ExternalObjectClassReference

		// markers associated with production: ExternalObjectClassReference -> modulereference-token "." objectclassreference-token

		public enum production_marker_1 : ushort
		{
			m_modulereference_token,
			m_objectclassreference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExternalObjectClassReference

		// Constructor declaration(s) associated with production(s) of syntax rule ExternalObjectClassReference

		//
		// Constructor associated with the following production(s)
		// ExternalObjectClassReference -> modulereference-token "." objectclassreference-token

		//

		public ExternalObjectClassReference (modulereference_token p_modulereference_token, SyntaxTreeToken p_token, objectclassreference_token p_objectclassreference_token) : base ((uint) ProductionID._ExternalObjectClassReference_ID, (uint) production_kind.g_ExternalObjectClassReference_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_modulereference_token = p_modulereference_token;
			children[1] = m_dot = p_token;
			children[2] = m_objectclassreference_token = p_objectclassreference_token;
		}

		public ExternalObjectClassReference () { }

		// Copy constructor

		public ExternalObjectClassReference (ExternalObjectClassReference p_ExternalObjectClassReference) : base (p_ExternalObjectClassReference.id, p_ExternalObjectClassReference.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExternalObjectClassReference.appInfo;
			switch ((production_kind) p_ExternalObjectClassReference.kind)
			{
				case production_kind.g_ExternalObjectClassReference_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_modulereference_token = (p_ExternalObjectClassReference.m_modulereference_token != null) ? new modulereference_token (p_ExternalObjectClassReference.m_modulereference_token) : null) != null) m_modulereference_token.parent = this;
					if ((children [1] = m_dot = (p_ExternalObjectClassReference.m_dot != null) ? new SyntaxTreeToken (p_ExternalObjectClassReference.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_objectclassreference_token = (p_ExternalObjectClassReference.m_objectclassreference_token != null) ? new objectclassreference_token (p_ExternalObjectClassReference.m_objectclassreference_token) : null) != null) m_objectclassreference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExternalObjectClassReference" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExternalObjectClassReference (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_modulereference_token?.Dispose ();
			m_dot?.Dispose ();
			m_objectclassreference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExternalObjectClassReference

		// Content changing function(s) associated with production(s) of syntax rule ExternalObjectClassReference

		//
		// Content changing function associated with following production(s)
		// ExternalObjectClassReference -> modulereference-token "." objectclassreference-token

		//

		public void change(modulereference_token p_modulereference_token, SyntaxTreeToken p_token, objectclassreference_token p_objectclassreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExternalObjectClassReference_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_modulereference_token = p_modulereference_token;
			children [1] = m_dot = p_token;
			children [2] = m_objectclassreference_token = p_objectclassreference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExternalObjectClassReference
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_modulereference_token != null) && m_modulereference_token.checkInclusion (element) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_objectclassreference_token != null) && m_objectclassreference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExternalObjectClassReference

		//
		// emit production tree node associated with any production of syntax rule ExternalObjectClassReference
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExternalObjectClassReference_1:
					// emit syntax tree node associated with production
					// ExternalObjectClassReference: modulereference-token "." objectclassreference-token

					s += m_modulereference_token.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_objectclassreference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExternalObjectClassReference
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExternalObjectClassReference (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExternalObjectClassReference_1:
					// emit syntax tree node associated with production
					// ExternalObjectClassReference: modulereference-token "." objectclassreference-token

					s += m_modulereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "dot";
					s += ' ';
					s += m_objectclassreference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExternalObjectClassReference

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalObjectClassReference with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExternalObjectClassReference.production_kind kind = (ExternalObjectClassReference.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExternalObjectClassReference.production_kind.g_ExternalObjectClassReference_1:
					// traverse syntax tree node associated with production
					// ExternalObjectClassReference: modulereference-token "." objectclassreference-token

						m_modulereference_token.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_objectclassreference_token.Visit (visitor, appData);
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
			m_objectclassreference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExternalObjectClassReference
		//

		public void _init ()
		{
			m_modulereference_token = null;
			m_dot = null;
			m_objectclassreference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExternalObjectClassReference

		// counter of all nodes associated with syntax rule ExternalObjectClassReference
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExternalObjectClassReference
		[DataMember (Name = "m_modulereference_token")] public modulereference_token m_modulereference_token { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_objectclassreference_token")] public objectclassreference_token m_objectclassreference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExternalObjectClassReference

		// delegate function (callback) prototype associated with syntax rule ExternalObjectClassReference
		public delegate bool ExternalObjectClassReference_Callback (SyntaxTreeCallbackReason reason, ExternalObjectClassReference.production_kind kind, ExternalObjectClassReference p_ExternalObjectClassReference);

		// event associated with syntax rule ExternalObjectClassReference
		public event ExternalObjectClassReference_Callback ExternalObjectClassReference_Event;

		// event trigger associated with syntax rule ExternalObjectClassReference
		public bool Raise_ExternalObjectClassReference_Event (SyntaxTreeCallbackReason reason, ExternalObjectClassReference.production_kind kind, ExternalObjectClassReference p_ExternalObjectClassReference)
		{
			bool? status = ExternalObjectClassReference_Event?.Invoke (reason, kind, p_ExternalObjectClassReference);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExternalObjectClassReference
		//
		// traverse syntax tree node associated with any production of syntax rule ExternalObjectClassReference
		//

		public void Traverse (ExternalObjectClassReference p_ExternalObjectClassReference)
		{
			if (p_ExternalObjectClassReference.isLocked())
				return;
			p_ExternalObjectClassReference.dolock();
			ExternalObjectClassReference.production_kind kind = (ExternalObjectClassReference.production_kind) p_ExternalObjectClassReference.kind;
			p_ExternalObjectClassReference.turn_reset ();
			if (Raise_ExternalObjectClassReference_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExternalObjectClassReference))
			switch (kind)
			{
				case ExternalObjectClassReference.production_kind.g_ExternalObjectClassReference_1:
					// traverse syntax tree node associated with production
					// ExternalObjectClassReference: modulereference-token "." objectclassreference-token

					if (Raise_ExternalObjectClassReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalObjectClassReference))
						Traverse (p_ExternalObjectClassReference.m_modulereference_token);
					p_ExternalObjectClassReference.turn_inc ();
					if (Raise_ExternalObjectClassReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalObjectClassReference))
						Traverse (p_ExternalObjectClassReference.m_objectclassreference_token);
					p_ExternalObjectClassReference.turn_inc ();
					Raise_ExternalObjectClassReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalObjectClassReference);
				break;
			}
			Raise_ExternalObjectClassReference_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExternalObjectClassReference);
			p_ExternalObjectClassReference.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalObjectClassReference
		//

		public void TraverseCommon (ExternalObjectClassReference p_ExternalObjectClassReference)
		{
			ExternalObjectClassReference.production_kind kind = (ExternalObjectClassReference.production_kind) p_ExternalObjectClassReference.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExternalObjectClassReference))
			switch (kind)
			{
				case ExternalObjectClassReference.production_kind.g_ExternalObjectClassReference_1:
					// traverse syntax tree node associated with production
					// ExternalObjectClassReference: modulereference-token "." objectclassreference-token

						TraverseCommon (p_ExternalObjectClassReference.m_modulereference_token);
						TraverseCommon (p_ExternalObjectClassReference.m_dot);
						TraverseCommon (p_ExternalObjectClassReference.m_objectclassreference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExternalObjectClassReference);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExternalObjectClassReference

		//
		// create syntax tree node associated with production
		// ExternalObjectClassReference: modulereference-token "." objectclassreference-token

		//

		public ExternalObjectClassReference ExternalObjectClassReference_1 (modulereference_token p_modulereference_token, SyntaxTreeToken p_token, objectclassreference_token p_objectclassreference_token)
		{
			ExternalObjectClassReference p_ExternalObjectClassReference_ref = new ExternalObjectClassReference(p_modulereference_token, p_token, p_objectclassreference_token);
			p_modulereference_token.parent = p_ExternalObjectClassReference_ref;
			p_token.parent = p_ExternalObjectClassReference_ref;
			p_objectclassreference_token.parent = p_ExternalObjectClassReference_ref;
			Raise_ExternalObjectClassReference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExternalObjectClassReference.production_kind.g_ExternalObjectClassReference_1, p_ExternalObjectClassReference_ref);
			return p_ExternalObjectClassReference_ref;
		}
		#endregion
	};
}
