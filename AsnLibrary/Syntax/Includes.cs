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
	// class associated with syntax rule Includes
	//

	[DataContract]
	public class	Includes : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Includes
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Includes
		{
			g_Includes_1 = 1,	// INCLUDES

			g_Includes_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule Includes

		// markers associated with production: Includes -> INCLUDES

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: Includes -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Includes

		// Constructor declaration(s) associated with production(s) of syntax rule Includes

		//
		// Constructor associated with the following production(s)
		// Includes -> INCLUDES

		//

		public Includes (SyntaxTreeToken p_token) : base ((uint) ProductionID._Includes_ID, (uint) production_kind.g_Includes_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_INCLUDES = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// Includes -> %empty

		//

		public Includes () : base ((uint) ProductionID._Includes_ID, (uint) production_kind.g_Includes_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public Includes (Includes p_Includes) : base (p_Includes.id, p_Includes.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Includes.appInfo;
			switch ((production_kind) p_Includes.kind)
			{
				case production_kind.g_Includes_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_INCLUDES = (p_Includes.m_INCLUDES != null) ? new SyntaxTreeToken (p_Includes.m_INCLUDES) : null) != null) m_INCLUDES.parent = this;
					break;
				case production_kind.g_Includes_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "Includes" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Includes (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_INCLUDES?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Includes

		// Content changing function(s) associated with production(s) of syntax rule Includes

		//
		// Content changing function associated with following production(s)
		// Includes -> INCLUDES

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Includes_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_INCLUDES = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Includes -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_Includes_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Includes
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_INCLUDES != null) && m_INCLUDES.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Includes

		//
		// emit production tree node associated with any production of syntax rule Includes
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Includes_1:
					// emit syntax tree node associated with production
					// Includes: INCLUDES

					s += m_INCLUDES.Emit (depth - 1);
				break;
				case production_kind.g_Includes_2:
					// emit syntax tree node associated with production
					// Includes: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Includes
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Includes (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Includes_1:
					// emit syntax tree node associated with production
					// Includes: INCLUDES

					s += "INCLUDES";
				break;
				case production_kind.g_Includes_2:
					// emit syntax tree node associated with production
					// Includes: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Includes

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Includes with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Includes.production_kind kind = (Includes.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Includes.production_kind.g_Includes_1:
					// traverse syntax tree node associated with production
					// Includes: INCLUDES

						m_INCLUDES.Visit (visitor, appData);
				break;
				case Includes.production_kind.g_Includes_2:
					// traverse syntax tree node associated with production
					// Includes: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_INCLUDES?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Includes
		//

		public void _init ()
		{
			m_INCLUDES = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Includes

		// counter of all nodes associated with syntax rule Includes
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Includes
		[DataMember (Name = "m_INCLUDES")] public SyntaxTreeToken m_INCLUDES { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Includes

		// delegate function (callback) prototype associated with syntax rule Includes
		public delegate bool Includes_Callback (SyntaxTreeCallbackReason reason, Includes.production_kind kind, Includes p_Includes);

		// event associated with syntax rule Includes
		public event Includes_Callback Includes_Event;

		// event trigger associated with syntax rule Includes
		public bool Raise_Includes_Event (SyntaxTreeCallbackReason reason, Includes.production_kind kind, Includes p_Includes)
		{
			bool? status = Includes_Event?.Invoke (reason, kind, p_Includes);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Includes
		//
		// traverse syntax tree node associated with any production of syntax rule Includes
		//

		public void Traverse (Includes p_Includes)
		{
			if (p_Includes.isLocked())
				return;
			p_Includes.dolock();
			Includes.production_kind kind = (Includes.production_kind) p_Includes.kind;
			p_Includes.turn_reset ();
			if (Raise_Includes_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Includes))
			switch (kind)
			{
				case Includes.production_kind.g_Includes_1:
					// traverse syntax tree node associated with production
					// Includes: INCLUDES

				break;
				case Includes.production_kind.g_Includes_2:
					// traverse syntax tree node associated with production
					// Includes: %empty

				break;
			}
			Raise_Includes_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Includes);
			p_Includes.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Includes
		//

		public void TraverseCommon (Includes p_Includes)
		{
			Includes.production_kind kind = (Includes.production_kind) p_Includes.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Includes))
			switch (kind)
			{
				case Includes.production_kind.g_Includes_1:
					// traverse syntax tree node associated with production
					// Includes: INCLUDES

						TraverseCommon (p_Includes.m_INCLUDES);
				break;
				case Includes.production_kind.g_Includes_2:
					// traverse syntax tree node associated with production
					// Includes: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Includes);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Includes

		//
		// create syntax tree node associated with production
		// Includes: INCLUDES

		//

		public Includes Includes_1 (SyntaxTreeToken p_token)
		{
			Includes p_Includes_ref = new Includes(p_token);
			p_token.parent = p_Includes_ref;
			Raise_Includes_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Includes.production_kind.g_Includes_1, p_Includes_ref);
			return p_Includes_ref;
		}

		//
		// create syntax tree node associated with production
		// Includes: %empty

		//

		public Includes Includes_2 ()
		{
			Includes p_Includes_ref = new Includes();
			Raise_Includes_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Includes.production_kind.g_Includes_2, p_Includes_ref);
			return p_Includes_ref;
		}
		#endregion
	};
}
