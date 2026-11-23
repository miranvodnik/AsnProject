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
	// class associated with syntax rule AC-ModuleName
	//

	[DataContract]
	public class	AC_ModuleName : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-ModuleName
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-ModuleName
		{
			g_AC_ModuleName_1 = 1,	// identifier-token AC-ModuleIdentifier

		};
		#endregion
		#region production markers associated with the syntax rule AC-ModuleName

		// markers associated with production: AC-ModuleName -> identifier-token AC-ModuleIdentifier

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			m_AC_ModuleIdentifier,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-ModuleName

		// Constructor declaration(s) associated with production(s) of syntax rule AC-ModuleName

		//
		// Constructor associated with the following production(s)
		// AC-ModuleName -> identifier-token AC-ModuleIdentifier

		//

		public AC_ModuleName (identifier_token p_identifier_token, AC_ModuleIdentifier p_AC_ModuleIdentifier) : base ((uint) ProductionID._AC_ModuleName_ID, (uint) production_kind.g_AC_ModuleName_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_AC_ModuleIdentifier = p_AC_ModuleIdentifier;
		}

		public AC_ModuleName () { }

		// Copy constructor

		public AC_ModuleName (AC_ModuleName p_AC_ModuleName) : base (p_AC_ModuleName.id, p_AC_ModuleName.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_ModuleName.appInfo;
			switch ((production_kind) p_AC_ModuleName.kind)
			{
				case production_kind.g_AC_ModuleName_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_identifier_token = (p_AC_ModuleName.m_identifier_token != null) ? new identifier_token (p_AC_ModuleName.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_AC_ModuleIdentifier = (p_AC_ModuleName.m_AC_ModuleIdentifier != null) ? new AC_ModuleIdentifier (p_AC_ModuleName.m_AC_ModuleIdentifier) : null) != null) m_AC_ModuleIdentifier.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_ModuleName" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_ModuleName (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_AC_ModuleIdentifier?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-ModuleName

		// Content changing function(s) associated with production(s) of syntax rule AC-ModuleName

		//
		// Content changing function associated with following production(s)
		// AC-ModuleName -> identifier-token AC-ModuleIdentifier

		//

		public void change(identifier_token p_identifier_token, AC_ModuleIdentifier p_AC_ModuleIdentifier)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_ModuleName_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_AC_ModuleIdentifier = p_AC_ModuleIdentifier;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-ModuleName
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_AC_ModuleIdentifier != null) && m_AC_ModuleIdentifier.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-ModuleName

		//
		// emit production tree node associated with any production of syntax rule AC-ModuleName
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_ModuleName_1:
					// emit syntax tree node associated with production
					// AC-ModuleName: identifier-token AC-ModuleIdentifier

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_AC_ModuleIdentifier.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-ModuleName
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_ModuleName (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_ModuleName_1:
					// emit syntax tree node associated with production
					// AC-ModuleName: identifier-token AC-ModuleIdentifier

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_AC_ModuleIdentifier.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-ModuleName

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-ModuleName with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_ModuleName.production_kind kind = (AC_ModuleName.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_ModuleName.production_kind.g_AC_ModuleName_1:
					// traverse syntax tree node associated with production
					// AC-ModuleName: identifier-token AC-ModuleIdentifier

						m_identifier_token.Visit (visitor, appData);
						m_AC_ModuleIdentifier.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier_token?.reparent (this);
			m_AC_ModuleIdentifier?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-ModuleName
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_AC_ModuleIdentifier = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-ModuleName

		// counter of all nodes associated with syntax rule AC-ModuleName
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-ModuleName
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_AC_ModuleIdentifier")] public AC_ModuleIdentifier m_AC_ModuleIdentifier { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-ModuleName

		// delegate function (callback) prototype associated with syntax rule AC-ModuleName
		public delegate bool AC_ModuleName_Callback (SyntaxTreeCallbackReason reason, AC_ModuleName.production_kind kind, AC_ModuleName p_AC_ModuleName);

		// event associated with syntax rule AC-ModuleName
		public event AC_ModuleName_Callback AC_ModuleName_Event;

		// event trigger associated with syntax rule AC-ModuleName
		public bool Raise_AC_ModuleName_Event (SyntaxTreeCallbackReason reason, AC_ModuleName.production_kind kind, AC_ModuleName p_AC_ModuleName)
		{
			bool? status = AC_ModuleName_Event?.Invoke (reason, kind, p_AC_ModuleName);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-ModuleName
		//
		// traverse syntax tree node associated with any production of syntax rule AC-ModuleName
		//

		public void Traverse (AC_ModuleName p_AC_ModuleName)
		{
			if (p_AC_ModuleName.isLocked())
				return;
			p_AC_ModuleName.dolock();
			AC_ModuleName.production_kind kind = (AC_ModuleName.production_kind) p_AC_ModuleName.kind;
			p_AC_ModuleName.turn_reset ();
			if (Raise_AC_ModuleName_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_ModuleName))
			switch (kind)
			{
				case AC_ModuleName.production_kind.g_AC_ModuleName_1:
					// traverse syntax tree node associated with production
					// AC-ModuleName: identifier-token AC-ModuleIdentifier

					if (Raise_AC_ModuleName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ModuleName))
						Traverse (p_AC_ModuleName.m_identifier_token);
					p_AC_ModuleName.turn_inc ();
					if (Raise_AC_ModuleName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ModuleName))
						Traverse (p_AC_ModuleName.m_AC_ModuleIdentifier);
					p_AC_ModuleName.turn_inc ();
					Raise_AC_ModuleName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_ModuleName);
				break;
			}
			Raise_AC_ModuleName_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_ModuleName);
			p_AC_ModuleName.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-ModuleName
		//

		public void TraverseCommon (AC_ModuleName p_AC_ModuleName)
		{
			AC_ModuleName.production_kind kind = (AC_ModuleName.production_kind) p_AC_ModuleName.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_ModuleName))
			switch (kind)
			{
				case AC_ModuleName.production_kind.g_AC_ModuleName_1:
					// traverse syntax tree node associated with production
					// AC-ModuleName: identifier-token AC-ModuleIdentifier

						TraverseCommon (p_AC_ModuleName.m_identifier_token);
						TraverseCommon (p_AC_ModuleName.m_AC_ModuleIdentifier);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_ModuleName);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-ModuleName

		//
		// create syntax tree node associated with production
		// AC-ModuleName: identifier-token AC-ModuleIdentifier

		//

		public AC_ModuleName AC_ModuleName_1 (identifier_token p_identifier_token, AC_ModuleIdentifier p_AC_ModuleIdentifier)
		{
			AC_ModuleName p_AC_ModuleName_ref = new AC_ModuleName(p_identifier_token, p_AC_ModuleIdentifier);
			p_identifier_token.parent = p_AC_ModuleName_ref;
			p_AC_ModuleIdentifier.parent = p_AC_ModuleName_ref;
			Raise_AC_ModuleName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_ModuleName.production_kind.g_AC_ModuleName_1, p_AC_ModuleName_ref);
			return p_AC_ModuleName_ref;
		}
		#endregion
	};
}
