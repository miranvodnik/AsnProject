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
	// class associated with syntax rule DefinitionsDefault
	//

	[DataContract]
	public class	DefinitionsDefault : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinitionsDefault
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinitionsDefault
		{
			g_DefinitionsDefault_1 = 1,	// DEFINITIONS

			g_DefinitionsDefault_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule DefinitionsDefault

		// markers associated with production: DefinitionsDefault -> DEFINITIONS

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: DefinitionsDefault -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinitionsDefault

		// Constructor declaration(s) associated with production(s) of syntax rule DefinitionsDefault

		//
		// Constructor associated with the following production(s)
		// DefinitionsDefault -> DEFINITIONS

		//

		public DefinitionsDefault (SyntaxTreeToken p_token) : base ((uint) ProductionID._DefinitionsDefault_ID, (uint) production_kind.g_DefinitionsDefault_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DEFINITIONS = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// DefinitionsDefault -> %empty

		//

		public DefinitionsDefault () : base ((uint) ProductionID._DefinitionsDefault_ID, (uint) production_kind.g_DefinitionsDefault_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public DefinitionsDefault (DefinitionsDefault p_DefinitionsDefault) : base (p_DefinitionsDefault.id, p_DefinitionsDefault.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinitionsDefault.appInfo;
			switch ((production_kind) p_DefinitionsDefault.kind)
			{
				case production_kind.g_DefinitionsDefault_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DEFINITIONS = (p_DefinitionsDefault.m_DEFINITIONS != null) ? new SyntaxTreeToken (p_DefinitionsDefault.m_DEFINITIONS) : null) != null) m_DEFINITIONS.parent = this;
					break;
				case production_kind.g_DefinitionsDefault_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "DefinitionsDefault" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinitionsDefault (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DEFINITIONS?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinitionsDefault

		// Content changing function(s) associated with production(s) of syntax rule DefinitionsDefault

		//
		// Content changing function associated with following production(s)
		// DefinitionsDefault -> DEFINITIONS

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitionsDefault_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DEFINITIONS = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinitionsDefault -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitionsDefault_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinitionsDefault
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DEFINITIONS != null) && m_DEFINITIONS.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinitionsDefault

		//
		// emit production tree node associated with any production of syntax rule DefinitionsDefault
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinitionsDefault_1:
					// emit syntax tree node associated with production
					// DefinitionsDefault: DEFINITIONS

					s += m_DEFINITIONS.Emit (depth - 1);
				break;
				case production_kind.g_DefinitionsDefault_2:
					// emit syntax tree node associated with production
					// DefinitionsDefault: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinitionsDefault
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinitionsDefault (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinitionsDefault_1:
					// emit syntax tree node associated with production
					// DefinitionsDefault: DEFINITIONS

					s += "DEFINITIONS";
				break;
				case production_kind.g_DefinitionsDefault_2:
					// emit syntax tree node associated with production
					// DefinitionsDefault: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinitionsDefault

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitionsDefault with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinitionsDefault.production_kind kind = (DefinitionsDefault.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinitionsDefault.production_kind.g_DefinitionsDefault_1:
					// traverse syntax tree node associated with production
					// DefinitionsDefault: DEFINITIONS

						m_DEFINITIONS.Visit (visitor, appData);
				break;
				case DefinitionsDefault.production_kind.g_DefinitionsDefault_2:
					// traverse syntax tree node associated with production
					// DefinitionsDefault: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DEFINITIONS?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefinitionsDefault
		//

		public void _init ()
		{
			m_DEFINITIONS = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinitionsDefault

		// counter of all nodes associated with syntax rule DefinitionsDefault
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinitionsDefault
		[DataMember (Name = "m_DEFINITIONS")] public SyntaxTreeToken m_DEFINITIONS { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinitionsDefault

		// delegate function (callback) prototype associated with syntax rule DefinitionsDefault
		public delegate bool DefinitionsDefault_Callback (SyntaxTreeCallbackReason reason, DefinitionsDefault.production_kind kind, DefinitionsDefault p_DefinitionsDefault);

		// event associated with syntax rule DefinitionsDefault
		public event DefinitionsDefault_Callback DefinitionsDefault_Event;

		// event trigger associated with syntax rule DefinitionsDefault
		public bool Raise_DefinitionsDefault_Event (SyntaxTreeCallbackReason reason, DefinitionsDefault.production_kind kind, DefinitionsDefault p_DefinitionsDefault)
		{
			bool? status = DefinitionsDefault_Event?.Invoke (reason, kind, p_DefinitionsDefault);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinitionsDefault
		//
		// traverse syntax tree node associated with any production of syntax rule DefinitionsDefault
		//

		public void Traverse (DefinitionsDefault p_DefinitionsDefault)
		{
			if (p_DefinitionsDefault.isLocked())
				return;
			p_DefinitionsDefault.dolock();
			DefinitionsDefault.production_kind kind = (DefinitionsDefault.production_kind) p_DefinitionsDefault.kind;
			p_DefinitionsDefault.turn_reset ();
			if (Raise_DefinitionsDefault_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinitionsDefault))
			switch (kind)
			{
				case DefinitionsDefault.production_kind.g_DefinitionsDefault_1:
					// traverse syntax tree node associated with production
					// DefinitionsDefault: DEFINITIONS

				break;
				case DefinitionsDefault.production_kind.g_DefinitionsDefault_2:
					// traverse syntax tree node associated with production
					// DefinitionsDefault: %empty

				break;
			}
			Raise_DefinitionsDefault_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinitionsDefault);
			p_DefinitionsDefault.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitionsDefault
		//

		public void TraverseCommon (DefinitionsDefault p_DefinitionsDefault)
		{
			DefinitionsDefault.production_kind kind = (DefinitionsDefault.production_kind) p_DefinitionsDefault.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinitionsDefault))
			switch (kind)
			{
				case DefinitionsDefault.production_kind.g_DefinitionsDefault_1:
					// traverse syntax tree node associated with production
					// DefinitionsDefault: DEFINITIONS

						TraverseCommon (p_DefinitionsDefault.m_DEFINITIONS);
				break;
				case DefinitionsDefault.production_kind.g_DefinitionsDefault_2:
					// traverse syntax tree node associated with production
					// DefinitionsDefault: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinitionsDefault);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinitionsDefault

		//
		// create syntax tree node associated with production
		// DefinitionsDefault: DEFINITIONS

		//

		public DefinitionsDefault DefinitionsDefault_1 (SyntaxTreeToken p_token)
		{
			DefinitionsDefault p_DefinitionsDefault_ref = new DefinitionsDefault(p_token);
			p_token.parent = p_DefinitionsDefault_ref;
			Raise_DefinitionsDefault_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitionsDefault.production_kind.g_DefinitionsDefault_1, p_DefinitionsDefault_ref);
			return p_DefinitionsDefault_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinitionsDefault: %empty

		//

		public DefinitionsDefault DefinitionsDefault_2 ()
		{
			DefinitionsDefault p_DefinitionsDefault_ref = new DefinitionsDefault();
			Raise_DefinitionsDefault_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitionsDefault.production_kind.g_DefinitionsDefault_2, p_DefinitionsDefault_ref);
			return p_DefinitionsDefault_ref;
		}
		#endregion
	};
}
