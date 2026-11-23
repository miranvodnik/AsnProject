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
	// class associated with syntax rule GlobalModuleReference
	//

	[DataContract]
	public class	GlobalModuleReference : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule GlobalModuleReference
		public enum production_kind : ushort	// enumerated production(s) of syntax rule GlobalModuleReference
		{
			g_GlobalModuleReference_1 = 1,	// modulereference-token AssignedIdentifier

		};
		#endregion
		#region production markers associated with the syntax rule GlobalModuleReference

		// markers associated with production: GlobalModuleReference -> modulereference-token AssignedIdentifier

		public enum production_marker_1 : ushort
		{
			m_modulereference_token,
			m_AssignedIdentifier,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule GlobalModuleReference

		// Constructor declaration(s) associated with production(s) of syntax rule GlobalModuleReference

		//
		// Constructor associated with the following production(s)
		// GlobalModuleReference -> modulereference-token AssignedIdentifier

		//

		public GlobalModuleReference (modulereference_token p_modulereference_token, AssignedIdentifier p_AssignedIdentifier) : base ((uint) ProductionID._GlobalModuleReference_ID, (uint) production_kind.g_GlobalModuleReference_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_modulereference_token = p_modulereference_token;
			children[1] = m_AssignedIdentifier = p_AssignedIdentifier;
		}

		public GlobalModuleReference () { }

		// Copy constructor

		public GlobalModuleReference (GlobalModuleReference p_GlobalModuleReference) : base (p_GlobalModuleReference.id, p_GlobalModuleReference.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_GlobalModuleReference.appInfo;
			switch ((production_kind) p_GlobalModuleReference.kind)
			{
				case production_kind.g_GlobalModuleReference_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_modulereference_token = (p_GlobalModuleReference.m_modulereference_token != null) ? new modulereference_token (p_GlobalModuleReference.m_modulereference_token) : null) != null) m_modulereference_token.parent = this;
					if ((children [1] = m_AssignedIdentifier = (p_GlobalModuleReference.m_AssignedIdentifier != null) ? new AssignedIdentifier (p_GlobalModuleReference.m_AssignedIdentifier) : null) != null) m_AssignedIdentifier.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "GlobalModuleReference" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new GlobalModuleReference (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_modulereference_token?.Dispose ();
			m_AssignedIdentifier?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule GlobalModuleReference

		// Content changing function(s) associated with production(s) of syntax rule GlobalModuleReference

		//
		// Content changing function associated with following production(s)
		// GlobalModuleReference -> modulereference-token AssignedIdentifier

		//

		public void change(modulereference_token p_modulereference_token, AssignedIdentifier p_AssignedIdentifier)
		{
			_init ();
			this.kind = (uint) production_kind.g_GlobalModuleReference_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_modulereference_token = p_modulereference_token;
			children [1] = m_AssignedIdentifier = p_AssignedIdentifier;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule GlobalModuleReference
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_modulereference_token != null) && m_modulereference_token.checkInclusion (element) ||
				(m_AssignedIdentifier != null) && m_AssignedIdentifier.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule GlobalModuleReference

		//
		// emit production tree node associated with any production of syntax rule GlobalModuleReference
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_GlobalModuleReference_1:
					// emit syntax tree node associated with production
					// GlobalModuleReference: modulereference-token AssignedIdentifier

					s += m_modulereference_token.Emit (depth - 1);
					s += " ";
					s += m_AssignedIdentifier.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule GlobalModuleReference
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "GlobalModuleReference (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_GlobalModuleReference_1:
					// emit syntax tree node associated with production
					// GlobalModuleReference: modulereference-token AssignedIdentifier

					s += m_modulereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_AssignedIdentifier.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule GlobalModuleReference

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule GlobalModuleReference with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			GlobalModuleReference.production_kind kind = (GlobalModuleReference.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case GlobalModuleReference.production_kind.g_GlobalModuleReference_1:
					// traverse syntax tree node associated with production
					// GlobalModuleReference: modulereference-token AssignedIdentifier

						m_modulereference_token.Visit (visitor, appData);
						m_AssignedIdentifier.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_modulereference_token?.reparent (this);
			m_AssignedIdentifier?.reparent (this);
		}

		//
		// initialize object associated with syntax rule GlobalModuleReference
		//

		public void _init ()
		{
			m_modulereference_token = null;
			m_AssignedIdentifier = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule GlobalModuleReference

		// counter of all nodes associated with syntax rule GlobalModuleReference
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule GlobalModuleReference
		[DataMember (Name = "m_modulereference_token")] public modulereference_token m_modulereference_token { get; private set; }
		[DataMember (Name = "m_AssignedIdentifier")] public AssignedIdentifier m_AssignedIdentifier { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule GlobalModuleReference

		// delegate function (callback) prototype associated with syntax rule GlobalModuleReference
		public delegate bool GlobalModuleReference_Callback (SyntaxTreeCallbackReason reason, GlobalModuleReference.production_kind kind, GlobalModuleReference p_GlobalModuleReference);

		// event associated with syntax rule GlobalModuleReference
		public event GlobalModuleReference_Callback GlobalModuleReference_Event;

		// event trigger associated with syntax rule GlobalModuleReference
		public bool Raise_GlobalModuleReference_Event (SyntaxTreeCallbackReason reason, GlobalModuleReference.production_kind kind, GlobalModuleReference p_GlobalModuleReference)
		{
			bool? status = GlobalModuleReference_Event?.Invoke (reason, kind, p_GlobalModuleReference);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule GlobalModuleReference
		//
		// traverse syntax tree node associated with any production of syntax rule GlobalModuleReference
		//

		public void Traverse (GlobalModuleReference p_GlobalModuleReference)
		{
			if (p_GlobalModuleReference.isLocked())
				return;
			p_GlobalModuleReference.dolock();
			GlobalModuleReference.production_kind kind = (GlobalModuleReference.production_kind) p_GlobalModuleReference.kind;
			p_GlobalModuleReference.turn_reset ();
			if (Raise_GlobalModuleReference_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_GlobalModuleReference))
			switch (kind)
			{
				case GlobalModuleReference.production_kind.g_GlobalModuleReference_1:
					// traverse syntax tree node associated with production
					// GlobalModuleReference: modulereference-token AssignedIdentifier

					if (Raise_GlobalModuleReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_GlobalModuleReference))
						Traverse (p_GlobalModuleReference.m_modulereference_token);
					p_GlobalModuleReference.turn_inc ();
					if (Raise_GlobalModuleReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_GlobalModuleReference))
						Traverse (p_GlobalModuleReference.m_AssignedIdentifier);
					p_GlobalModuleReference.turn_inc ();
					Raise_GlobalModuleReference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_GlobalModuleReference);
				break;
			}
			Raise_GlobalModuleReference_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_GlobalModuleReference);
			p_GlobalModuleReference.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule GlobalModuleReference
		//

		public void TraverseCommon (GlobalModuleReference p_GlobalModuleReference)
		{
			GlobalModuleReference.production_kind kind = (GlobalModuleReference.production_kind) p_GlobalModuleReference.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_GlobalModuleReference))
			switch (kind)
			{
				case GlobalModuleReference.production_kind.g_GlobalModuleReference_1:
					// traverse syntax tree node associated with production
					// GlobalModuleReference: modulereference-token AssignedIdentifier

						TraverseCommon (p_GlobalModuleReference.m_modulereference_token);
						TraverseCommon (p_GlobalModuleReference.m_AssignedIdentifier);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_GlobalModuleReference);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule GlobalModuleReference

		//
		// create syntax tree node associated with production
		// GlobalModuleReference: modulereference-token AssignedIdentifier

		//

		public GlobalModuleReference GlobalModuleReference_1 (modulereference_token p_modulereference_token, AssignedIdentifier p_AssignedIdentifier)
		{
			GlobalModuleReference p_GlobalModuleReference_ref = new GlobalModuleReference(p_modulereference_token, p_AssignedIdentifier);
			p_modulereference_token.parent = p_GlobalModuleReference_ref;
			p_AssignedIdentifier.parent = p_GlobalModuleReference_ref;
			Raise_GlobalModuleReference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, GlobalModuleReference.production_kind.g_GlobalModuleReference_1, p_GlobalModuleReference_ref);
			return p_GlobalModuleReference_ref;
		}
		#endregion
	};
}
