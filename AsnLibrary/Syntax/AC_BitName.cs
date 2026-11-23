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
	// class associated with syntax rule AC-BitName
	//

	[DataContract]
	public class	AC_BitName : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-BitName
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-BitName
		{
			g_AC_BitName_1 = 1,	// identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule AC-BitName

		// markers associated with production: AC-BitName -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-BitName

		// Constructor declaration(s) associated with production(s) of syntax rule AC-BitName

		//
		// Constructor associated with the following production(s)
		// AC-BitName -> identifier-token

		//

		public AC_BitName (identifier_token p_identifier_token) : base ((uint) ProductionID._AC_BitName_ID, (uint) production_kind.g_AC_BitName_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		public AC_BitName () { }

		// Copy constructor

		public AC_BitName (AC_BitName p_AC_BitName) : base (p_AC_BitName.id, p_AC_BitName.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_BitName.appInfo;
			switch ((production_kind) p_AC_BitName.kind)
			{
				case production_kind.g_AC_BitName_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_AC_BitName.m_identifier_token != null) ? new identifier_token (p_AC_BitName.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "AC_BitName" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_BitName (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-BitName

		// Content changing function(s) associated with production(s) of syntax rule AC-BitName

		//
		// Content changing function associated with following production(s)
		// AC-BitName -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_BitName_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-BitName
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-BitName

		//
		// emit production tree node associated with any production of syntax rule AC-BitName
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_BitName_1:
					// emit syntax tree node associated with production
					// AC-BitName: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-BitName
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_BitName (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_BitName_1:
					// emit syntax tree node associated with production
					// AC-BitName: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-BitName

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-BitName with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_BitName.production_kind kind = (AC_BitName.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_BitName.production_kind.g_AC_BitName_1:
					// traverse syntax tree node associated with production
					// AC-BitName: identifier-token

						m_identifier_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-BitName
		//

		public void _init ()
		{
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-BitName

		// counter of all nodes associated with syntax rule AC-BitName
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-BitName
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-BitName

		// delegate function (callback) prototype associated with syntax rule AC-BitName
		public delegate bool AC_BitName_Callback (SyntaxTreeCallbackReason reason, AC_BitName.production_kind kind, AC_BitName p_AC_BitName);

		// event associated with syntax rule AC-BitName
		public event AC_BitName_Callback AC_BitName_Event;

		// event trigger associated with syntax rule AC-BitName
		public bool Raise_AC_BitName_Event (SyntaxTreeCallbackReason reason, AC_BitName.production_kind kind, AC_BitName p_AC_BitName)
		{
			bool? status = AC_BitName_Event?.Invoke (reason, kind, p_AC_BitName);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-BitName
		//
		// traverse syntax tree node associated with any production of syntax rule AC-BitName
		//

		public void Traverse (AC_BitName p_AC_BitName)
		{
			if (p_AC_BitName.isLocked())
				return;
			p_AC_BitName.dolock();
			AC_BitName.production_kind kind = (AC_BitName.production_kind) p_AC_BitName.kind;
			p_AC_BitName.turn_reset ();
			if (Raise_AC_BitName_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_BitName))
			switch (kind)
			{
				case AC_BitName.production_kind.g_AC_BitName_1:
					// traverse syntax tree node associated with production
					// AC-BitName: identifier-token

					if (Raise_AC_BitName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_BitName))
						Traverse (p_AC_BitName.m_identifier_token);
					p_AC_BitName.turn_inc ();
					Raise_AC_BitName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_BitName);
				break;
			}
			Raise_AC_BitName_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_BitName);
			p_AC_BitName.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-BitName
		//

		public void TraverseCommon (AC_BitName p_AC_BitName)
		{
			AC_BitName.production_kind kind = (AC_BitName.production_kind) p_AC_BitName.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_BitName))
			switch (kind)
			{
				case AC_BitName.production_kind.g_AC_BitName_1:
					// traverse syntax tree node associated with production
					// AC-BitName: identifier-token

						TraverseCommon (p_AC_BitName.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_BitName);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-BitName

		//
		// create syntax tree node associated with production
		// AC-BitName: identifier-token

		//

		public AC_BitName AC_BitName_1 (identifier_token p_identifier_token)
		{
			AC_BitName p_AC_BitName_ref = new AC_BitName(p_identifier_token);
			p_identifier_token.parent = p_AC_BitName_ref;
			Raise_AC_BitName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_BitName.production_kind.g_AC_BitName_1, p_AC_BitName_ref);
			return p_AC_BitName_ref;
		}
		#endregion
	};
}
