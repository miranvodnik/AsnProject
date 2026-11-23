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
	// class associated with syntax rule Arc
	//

	[DataContract]
	public class	Arc : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Arc
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Arc
		{
			g_Arc_1 = 1,	// "/" ArcIdentifier

		};
		#endregion
		#region production markers associated with the syntax rule Arc

		// markers associated with production: Arc -> "/" ArcIdentifier

		public enum production_marker_1 : ushort
		{
			m_ArcIdentifier,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Arc

		// Constructor declaration(s) associated with production(s) of syntax rule Arc

		//
		// Constructor associated with the following production(s)
		// Arc -> "/" ArcIdentifier

		//

		public Arc (SyntaxTreeToken p_token, ArcIdentifier p_ArcIdentifier) : base ((uint) ProductionID._Arc_ID, (uint) production_kind.g_Arc_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_forward_slash = p_token;
			children[1] = m_ArcIdentifier = p_ArcIdentifier;
		}

		public Arc () { }

		// Copy constructor

		public Arc (Arc p_Arc) : base (p_Arc.id, p_Arc.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Arc.appInfo;
			switch ((production_kind) p_Arc.kind)
			{
				case production_kind.g_Arc_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_forward_slash = (p_Arc.m_forward_slash != null) ? new SyntaxTreeToken (p_Arc.m_forward_slash) : null) != null) m_forward_slash.parent = this;
					if ((children [1] = m_ArcIdentifier = (p_Arc.m_ArcIdentifier != null) ? new ArcIdentifier (p_Arc.m_ArcIdentifier) : null) != null) m_ArcIdentifier.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Arc" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Arc (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_forward_slash?.Dispose ();
			m_ArcIdentifier?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Arc

		// Content changing function(s) associated with production(s) of syntax rule Arc

		//
		// Content changing function associated with following production(s)
		// Arc -> "/" ArcIdentifier

		//

		public void change(SyntaxTreeToken p_token, ArcIdentifier p_ArcIdentifier)
		{
			_init ();
			this.kind = (uint) production_kind.g_Arc_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_forward_slash = p_token;
			children [1] = m_ArcIdentifier = p_ArcIdentifier;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Arc
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_forward_slash != null) && m_forward_slash.checkInclusion (element) ||
				(m_ArcIdentifier != null) && m_ArcIdentifier.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Arc

		//
		// emit production tree node associated with any production of syntax rule Arc
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Arc_1:
					// emit syntax tree node associated with production
					// Arc: "/" ArcIdentifier

					s += m_forward_slash.Emit (depth - 1);
					s += " ";
					s += m_ArcIdentifier.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Arc
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Arc (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Arc_1:
					// emit syntax tree node associated with production
					// Arc: "/" ArcIdentifier

					s += "forward_slash";
					s += ' ';
					s += m_ArcIdentifier.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Arc

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Arc with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Arc.production_kind kind = (Arc.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Arc.production_kind.g_Arc_1:
					// traverse syntax tree node associated with production
					// Arc: "/" ArcIdentifier

						m_forward_slash.Visit (visitor, appData);
						m_ArcIdentifier.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_forward_slash?.reparent (this);
			m_ArcIdentifier?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Arc
		//

		public void _init ()
		{
			m_forward_slash = null;
			m_ArcIdentifier = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Arc

		// counter of all nodes associated with syntax rule Arc
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Arc
		[DataMember (Name = "m_forward_slash")] public SyntaxTreeToken m_forward_slash { get; private set; }
		[DataMember (Name = "m_ArcIdentifier")] public ArcIdentifier m_ArcIdentifier { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Arc

		// delegate function (callback) prototype associated with syntax rule Arc
		public delegate bool Arc_Callback (SyntaxTreeCallbackReason reason, Arc.production_kind kind, Arc p_Arc);

		// event associated with syntax rule Arc
		public event Arc_Callback Arc_Event;

		// event trigger associated with syntax rule Arc
		public bool Raise_Arc_Event (SyntaxTreeCallbackReason reason, Arc.production_kind kind, Arc p_Arc)
		{
			bool? status = Arc_Event?.Invoke (reason, kind, p_Arc);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Arc
		//
		// traverse syntax tree node associated with any production of syntax rule Arc
		//

		public void Traverse (Arc p_Arc)
		{
			if (p_Arc.isLocked())
				return;
			p_Arc.dolock();
			Arc.production_kind kind = (Arc.production_kind) p_Arc.kind;
			p_Arc.turn_reset ();
			if (Raise_Arc_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Arc))
			switch (kind)
			{
				case Arc.production_kind.g_Arc_1:
					// traverse syntax tree node associated with production
					// Arc: "/" ArcIdentifier

					if (Raise_Arc_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Arc))
						Traverse (p_Arc.m_ArcIdentifier);
					p_Arc.turn_inc ();
					Raise_Arc_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Arc);
				break;
			}
			Raise_Arc_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Arc);
			p_Arc.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Arc
		//

		public void TraverseCommon (Arc p_Arc)
		{
			Arc.production_kind kind = (Arc.production_kind) p_Arc.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Arc))
			switch (kind)
			{
				case Arc.production_kind.g_Arc_1:
					// traverse syntax tree node associated with production
					// Arc: "/" ArcIdentifier

						TraverseCommon (p_Arc.m_forward_slash);
						TraverseCommon (p_Arc.m_ArcIdentifier);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Arc);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Arc

		//
		// create syntax tree node associated with production
		// Arc: "/" ArcIdentifier

		//

		public Arc Arc_1 (SyntaxTreeToken p_token, ArcIdentifier p_ArcIdentifier)
		{
			Arc p_Arc_ref = new Arc(p_token, p_ArcIdentifier);
			p_token.parent = p_Arc_ref;
			p_ArcIdentifier.parent = p_Arc_ref;
			Raise_Arc_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Arc.production_kind.g_Arc_1, p_Arc_ref);
			return p_Arc_ref;
		}
		#endregion
	};
}
