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
	// class associated with syntax rule OT-BitName
	//

	[DataContract]
	public class	OT_BitName : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OT-BitName
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OT-BitName
		{
			g_OT_BitName_1 = 1,	// identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule OT-BitName

		// markers associated with production: OT-BitName -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OT-BitName

		// Constructor declaration(s) associated with production(s) of syntax rule OT-BitName

		//
		// Constructor associated with the following production(s)
		// OT-BitName -> identifier-token

		//

		public OT_BitName (identifier_token p_identifier_token) : base ((uint) ProductionID._OT_BitName_ID, (uint) production_kind.g_OT_BitName_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		public OT_BitName () { }

		// Copy constructor

		public OT_BitName (OT_BitName p_OT_BitName) : base (p_OT_BitName.id, p_OT_BitName.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OT_BitName.appInfo;
			switch ((production_kind) p_OT_BitName.kind)
			{
				case production_kind.g_OT_BitName_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_OT_BitName.m_identifier_token != null) ? new identifier_token (p_OT_BitName.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OT_BitName" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OT_BitName (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OT-BitName

		// Content changing function(s) associated with production(s) of syntax rule OT-BitName

		//
		// Content changing function associated with following production(s)
		// OT-BitName -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_BitName_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OT-BitName
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OT-BitName

		//
		// emit production tree node associated with any production of syntax rule OT-BitName
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OT_BitName_1:
					// emit syntax tree node associated with production
					// OT-BitName: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OT-BitName
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OT_BitName (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OT_BitName_1:
					// emit syntax tree node associated with production
					// OT-BitName: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OT-BitName

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OT-BitName with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OT_BitName.production_kind kind = (OT_BitName.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OT_BitName.production_kind.g_OT_BitName_1:
					// traverse syntax tree node associated with production
					// OT-BitName: identifier-token

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
		// initialize object associated with syntax rule OT-BitName
		//

		public void _init ()
		{
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OT-BitName

		// counter of all nodes associated with syntax rule OT-BitName
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OT-BitName
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OT-BitName

		// delegate function (callback) prototype associated with syntax rule OT-BitName
		public delegate bool OT_BitName_Callback (SyntaxTreeCallbackReason reason, OT_BitName.production_kind kind, OT_BitName p_OT_BitName);

		// event associated with syntax rule OT-BitName
		public event OT_BitName_Callback OT_BitName_Event;

		// event trigger associated with syntax rule OT-BitName
		public bool Raise_OT_BitName_Event (SyntaxTreeCallbackReason reason, OT_BitName.production_kind kind, OT_BitName p_OT_BitName)
		{
			bool? status = OT_BitName_Event?.Invoke (reason, kind, p_OT_BitName);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OT-BitName
		//
		// traverse syntax tree node associated with any production of syntax rule OT-BitName
		//

		public void Traverse (OT_BitName p_OT_BitName)
		{
			if (p_OT_BitName.isLocked())
				return;
			p_OT_BitName.dolock();
			OT_BitName.production_kind kind = (OT_BitName.production_kind) p_OT_BitName.kind;
			p_OT_BitName.turn_reset ();
			if (Raise_OT_BitName_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OT_BitName))
			switch (kind)
			{
				case OT_BitName.production_kind.g_OT_BitName_1:
					// traverse syntax tree node associated with production
					// OT-BitName: identifier-token

					if (Raise_OT_BitName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_BitName))
						Traverse (p_OT_BitName.m_identifier_token);
					p_OT_BitName.turn_inc ();
					Raise_OT_BitName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_BitName);
				break;
			}
			Raise_OT_BitName_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OT_BitName);
			p_OT_BitName.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OT-BitName
		//

		public void TraverseCommon (OT_BitName p_OT_BitName)
		{
			OT_BitName.production_kind kind = (OT_BitName.production_kind) p_OT_BitName.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OT_BitName))
			switch (kind)
			{
				case OT_BitName.production_kind.g_OT_BitName_1:
					// traverse syntax tree node associated with production
					// OT-BitName: identifier-token

						TraverseCommon (p_OT_BitName.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OT_BitName);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OT-BitName

		//
		// create syntax tree node associated with production
		// OT-BitName: identifier-token

		//

		public OT_BitName OT_BitName_1 (identifier_token p_identifier_token)
		{
			OT_BitName p_OT_BitName_ref = new OT_BitName(p_identifier_token);
			p_identifier_token.parent = p_OT_BitName_ref;
			Raise_OT_BitName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_BitName.production_kind.g_OT_BitName_1, p_OT_BitName_ref);
			return p_OT_BitName_ref;
		}
		#endregion
	};
}
