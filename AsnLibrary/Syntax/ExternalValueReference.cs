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
	// class associated with syntax rule ExternalValueReference
	//

	[DataContract]
	public class	ExternalValueReference : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExternalValueReference
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExternalValueReference
		{
			g_ExternalValueReference_1 = 1,	// modulereference-token "." valuereference-token

		};
		#endregion
		#region production markers associated with the syntax rule ExternalValueReference

		// markers associated with production: ExternalValueReference -> modulereference-token "." valuereference-token

		public enum production_marker_1 : ushort
		{
			m_modulereference_token,
			m_valuereference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExternalValueReference

		// Constructor declaration(s) associated with production(s) of syntax rule ExternalValueReference

		//
		// Constructor associated with the following production(s)
		// ExternalValueReference -> modulereference-token "." valuereference-token

		//

		public ExternalValueReference (modulereference_token p_modulereference_token, SyntaxTreeToken p_token, valuereference_token p_valuereference_token) : base ((uint) ProductionID._ExternalValueReference_ID, (uint) production_kind.g_ExternalValueReference_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_modulereference_token = p_modulereference_token;
			children[1] = m_dot = p_token;
			children[2] = m_valuereference_token = p_valuereference_token;
		}

		public ExternalValueReference () { }

		// Copy constructor

		public ExternalValueReference (ExternalValueReference p_ExternalValueReference) : base (p_ExternalValueReference.id, p_ExternalValueReference.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExternalValueReference.appInfo;
			switch ((production_kind) p_ExternalValueReference.kind)
			{
				case production_kind.g_ExternalValueReference_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_modulereference_token = (p_ExternalValueReference.m_modulereference_token != null) ? new modulereference_token (p_ExternalValueReference.m_modulereference_token) : null) != null) m_modulereference_token.parent = this;
					if ((children [1] = m_dot = (p_ExternalValueReference.m_dot != null) ? new SyntaxTreeToken (p_ExternalValueReference.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_valuereference_token = (p_ExternalValueReference.m_valuereference_token != null) ? new valuereference_token (p_ExternalValueReference.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExternalValueReference" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExternalValueReference (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_modulereference_token?.Dispose ();
			m_dot?.Dispose ();
			m_valuereference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExternalValueReference

		// Content changing function(s) associated with production(s) of syntax rule ExternalValueReference

		//
		// Content changing function associated with following production(s)
		// ExternalValueReference -> modulereference-token "." valuereference-token

		//

		public void change(modulereference_token p_modulereference_token, SyntaxTreeToken p_token, valuereference_token p_valuereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExternalValueReference_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_modulereference_token = p_modulereference_token;
			children [1] = m_dot = p_token;
			children [2] = m_valuereference_token = p_valuereference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExternalValueReference
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_modulereference_token != null) && m_modulereference_token.checkInclusion (element) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_valuereference_token != null) && m_valuereference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExternalValueReference

		//
		// emit production tree node associated with any production of syntax rule ExternalValueReference
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExternalValueReference_1:
					// emit syntax tree node associated with production
					// ExternalValueReference: modulereference-token "." valuereference-token

					s += m_modulereference_token.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_valuereference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExternalValueReference
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExternalValueReference (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExternalValueReference_1:
					// emit syntax tree node associated with production
					// ExternalValueReference: modulereference-token "." valuereference-token

					s += m_modulereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "dot";
					s += ' ';
					s += m_valuereference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExternalValueReference

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalValueReference with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExternalValueReference.production_kind kind = (ExternalValueReference.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExternalValueReference.production_kind.g_ExternalValueReference_1:
					// traverse syntax tree node associated with production
					// ExternalValueReference: modulereference-token "." valuereference-token

						m_modulereference_token.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_valuereference_token.Visit (visitor, appData);
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
			m_valuereference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExternalValueReference
		//

		public void _init ()
		{
			m_modulereference_token = null;
			m_dot = null;
			m_valuereference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExternalValueReference

		// counter of all nodes associated with syntax rule ExternalValueReference
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExternalValueReference
		[DataMember (Name = "m_modulereference_token")] public modulereference_token m_modulereference_token { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_valuereference_token")] public valuereference_token m_valuereference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExternalValueReference

		// delegate function (callback) prototype associated with syntax rule ExternalValueReference
		public delegate bool ExternalValueReference_Callback (SyntaxTreeCallbackReason reason, ExternalValueReference.production_kind kind, ExternalValueReference p_ExternalValueReference);

		// event associated with syntax rule ExternalValueReference
		public event ExternalValueReference_Callback ExternalValueReference_Event;

		// event trigger associated with syntax rule ExternalValueReference
		public bool Raise_ExternalValueReference_Event (SyntaxTreeCallbackReason reason, ExternalValueReference.production_kind kind, ExternalValueReference p_ExternalValueReference)
		{
			bool? status = ExternalValueReference_Event?.Invoke (reason, kind, p_ExternalValueReference);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExternalValueReference
		//
		// traverse syntax tree node associated with any production of syntax rule ExternalValueReference
		//

		public void Traverse (ExternalValueReference p_ExternalValueReference)
		{
			if (p_ExternalValueReference.isLocked())
				return;
			p_ExternalValueReference.dolock();
			ExternalValueReference.production_kind kind = (ExternalValueReference.production_kind) p_ExternalValueReference.kind;
			p_ExternalValueReference.turn_reset ();
			if (Raise_ExternalValueReference_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExternalValueReference))
			switch (kind)
			{
				case ExternalValueReference.production_kind.g_ExternalValueReference_1:
					// traverse syntax tree node associated with production
					// ExternalValueReference: modulereference-token "." valuereference-token

					if (Raise_ExternalValueReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalValueReference))
						Traverse (p_ExternalValueReference.m_modulereference_token);
					p_ExternalValueReference.turn_inc ();
					if (Raise_ExternalValueReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalValueReference))
						Traverse (p_ExternalValueReference.m_valuereference_token);
					p_ExternalValueReference.turn_inc ();
					Raise_ExternalValueReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExternalValueReference);
				break;
			}
			Raise_ExternalValueReference_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExternalValueReference);
			p_ExternalValueReference.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExternalValueReference
		//

		public void TraverseCommon (ExternalValueReference p_ExternalValueReference)
		{
			ExternalValueReference.production_kind kind = (ExternalValueReference.production_kind) p_ExternalValueReference.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExternalValueReference))
			switch (kind)
			{
				case ExternalValueReference.production_kind.g_ExternalValueReference_1:
					// traverse syntax tree node associated with production
					// ExternalValueReference: modulereference-token "." valuereference-token

						TraverseCommon (p_ExternalValueReference.m_modulereference_token);
						TraverseCommon (p_ExternalValueReference.m_dot);
						TraverseCommon (p_ExternalValueReference.m_valuereference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExternalValueReference);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExternalValueReference

		//
		// create syntax tree node associated with production
		// ExternalValueReference: modulereference-token "." valuereference-token

		//

		public ExternalValueReference ExternalValueReference_1 (modulereference_token p_modulereference_token, SyntaxTreeToken p_token, valuereference_token p_valuereference_token)
		{
			ExternalValueReference p_ExternalValueReference_ref = new ExternalValueReference(p_modulereference_token, p_token, p_valuereference_token);
			p_modulereference_token.parent = p_ExternalValueReference_ref;
			p_token.parent = p_ExternalValueReference_ref;
			p_valuereference_token.parent = p_ExternalValueReference_ref;
			Raise_ExternalValueReference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExternalValueReference.production_kind.g_ExternalValueReference_1, p_ExternalValueReference_ref);
			return p_ExternalValueReference_ref;
		}
		#endregion
	};
}
