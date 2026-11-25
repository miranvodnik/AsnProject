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
	// class associated with syntax rule ExtensionEndMarker
	//

	[DataContract]
	public class	ExtensionEndMarker : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExtensionEndMarker
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExtensionEndMarker
		{
			g_ExtensionEndMarker_1 = 1,	// "," "." "." "."

		};
		#endregion
		#region production markers associated with the syntax rule ExtensionEndMarker

		// markers associated with production: ExtensionEndMarker -> "," "." "." "."

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExtensionEndMarker

		// Constructor declaration(s) associated with production(s) of syntax rule ExtensionEndMarker

		//
		// Constructor associated with the following production(s)
		// ExtensionEndMarker -> "," "." "." "."

		//

		public ExtensionEndMarker (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3) : base ((uint) ProductionID._ExtensionEndMarker_ID, (uint) production_kind.g_ExtensionEndMarker_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_comma = p_token;
			children[1] = m_dot = p_token_1;
			children[2] = m_dot_1 = p_token_2;
			children[3] = m_dot_2 = p_token_3;
		}

		public ExtensionEndMarker () { }

		// Copy constructor

		public ExtensionEndMarker (ExtensionEndMarker p_ExtensionEndMarker) : base (p_ExtensionEndMarker.id, p_ExtensionEndMarker.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExtensionEndMarker.appInfo;
			switch ((production_kind) p_ExtensionEndMarker.kind)
			{
				case production_kind.g_ExtensionEndMarker_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_comma = (p_ExtensionEndMarker.m_comma != null) ? new SyntaxTreeToken (p_ExtensionEndMarker.m_comma) : null) != null) m_comma.parent = this;
					if ((children [1] = m_dot = (p_ExtensionEndMarker.m_dot != null) ? new SyntaxTreeToken (p_ExtensionEndMarker.m_dot) : null) != null) m_dot.parent = this;
					if ((children [2] = m_dot_1 = (p_ExtensionEndMarker.m_dot_1 != null) ? new SyntaxTreeToken (p_ExtensionEndMarker.m_dot_1) : null) != null) m_dot_1.parent = this;
					if ((children [3] = m_dot_2 = (p_ExtensionEndMarker.m_dot_2 != null) ? new SyntaxTreeToken (p_ExtensionEndMarker.m_dot_2) : null) != null) m_dot_2.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExtensionEndMarker" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExtensionEndMarker (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_comma?.Dispose ();
			m_dot?.Dispose ();
			m_dot_1?.Dispose ();
			m_dot_2?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExtensionEndMarker

		// Content changing function(s) associated with production(s) of syntax rule ExtensionEndMarker

		//
		// Content changing function associated with following production(s)
		// ExtensionEndMarker -> "," "." "." "."

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionEndMarker_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_comma = p_token;
			children [1] = m_dot = p_token_1;
			children [2] = m_dot_1 = p_token_2;
			children [3] = m_dot_2 = p_token_3;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExtensionEndMarker
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_dot_1 != null) && m_dot_1.checkInclusion (element) ||
				(m_dot_2 != null) && m_dot_2.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExtensionEndMarker

		//
		// emit production tree node associated with any production of syntax rule ExtensionEndMarker
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExtensionEndMarker_1:
					// emit syntax tree node associated with production
					// ExtensionEndMarker: "," "." "." "."

					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_dot_1.Emit (depth - 1);
					s += " ";
					s += m_dot_2.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExtensionEndMarker
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExtensionEndMarker (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExtensionEndMarker_1:
					// emit syntax tree node associated with production
					// ExtensionEndMarker: "," "." "." "."

					s += "comma";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExtensionEndMarker

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionEndMarker with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExtensionEndMarker.production_kind kind = (ExtensionEndMarker.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExtensionEndMarker.production_kind.g_ExtensionEndMarker_1:
					// traverse syntax tree node associated with production
					// ExtensionEndMarker: "," "." "." "."

						m_comma.Visit (visitor, appData);
						m_dot.Visit (visitor, appData);
						m_dot_1.Visit (visitor, appData);
						m_dot_2.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_comma?.reparent (this);
			m_dot?.reparent (this);
			m_dot_1?.reparent (this);

			m_dot_2?.reparent (this);

		}

		//
		// initialize object associated with syntax rule ExtensionEndMarker
		//

		public void _init ()
		{
			m_comma = null;
			m_dot = null;
			m_dot_1 = null;
			m_dot_2 = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExtensionEndMarker

		// counter of all nodes associated with syntax rule ExtensionEndMarker
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExtensionEndMarker
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_dot_1")] public SyntaxTreeToken m_dot_1 { get; private set; }
		[DataMember (Name = "m_dot_2")] public SyntaxTreeToken m_dot_2 { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExtensionEndMarker

		// delegate function (callback) prototype associated with syntax rule ExtensionEndMarker
		public delegate bool ExtensionEndMarker_Callback (SyntaxTreeCallbackReason reason, ExtensionEndMarker.production_kind kind, ExtensionEndMarker p_ExtensionEndMarker);

		// event associated with syntax rule ExtensionEndMarker
		public event ExtensionEndMarker_Callback ExtensionEndMarker_Event;

		// event trigger associated with syntax rule ExtensionEndMarker
		public bool Raise_ExtensionEndMarker_Event (SyntaxTreeCallbackReason reason, ExtensionEndMarker.production_kind kind, ExtensionEndMarker p_ExtensionEndMarker)
		{
			bool? status = ExtensionEndMarker_Event?.Invoke (reason, kind, p_ExtensionEndMarker);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExtensionEndMarker
		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionEndMarker
		//

		public void Traverse (ExtensionEndMarker p_ExtensionEndMarker)
		{
			if (p_ExtensionEndMarker.isLocked())
				return;
			p_ExtensionEndMarker.dolock();
			ExtensionEndMarker.production_kind kind = (ExtensionEndMarker.production_kind) p_ExtensionEndMarker.kind;
			p_ExtensionEndMarker.turn_reset ();
			if (Raise_ExtensionEndMarker_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExtensionEndMarker))
			switch (kind)
			{
				case ExtensionEndMarker.production_kind.g_ExtensionEndMarker_1:
					// traverse syntax tree node associated with production
					// ExtensionEndMarker: "," "." "." "."

				break;
			}
			Raise_ExtensionEndMarker_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExtensionEndMarker);
			p_ExtensionEndMarker.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionEndMarker
		//

		public void TraverseCommon (ExtensionEndMarker p_ExtensionEndMarker)
		{
			ExtensionEndMarker.production_kind kind = (ExtensionEndMarker.production_kind) p_ExtensionEndMarker.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExtensionEndMarker))
			switch (kind)
			{
				case ExtensionEndMarker.production_kind.g_ExtensionEndMarker_1:
					// traverse syntax tree node associated with production
					// ExtensionEndMarker: "," "." "." "."

						TraverseCommon (p_ExtensionEndMarker.m_comma);
						TraverseCommon (p_ExtensionEndMarker.m_dot);
						TraverseCommon (p_ExtensionEndMarker.m_dot_1);
						TraverseCommon (p_ExtensionEndMarker.m_dot_2);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExtensionEndMarker);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExtensionEndMarker

		//
		// create syntax tree node associated with production
		// ExtensionEndMarker: "," "." "." "."

		//

		public ExtensionEndMarker ExtensionEndMarker_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3)
		{
			ExtensionEndMarker p_ExtensionEndMarker_ref = new ExtensionEndMarker(p_token, p_token_1, p_token_2, p_token_3);
			p_token.parent = p_ExtensionEndMarker_ref;
			p_token_1.parent = p_ExtensionEndMarker_ref;
			p_token_2.parent = p_ExtensionEndMarker_ref;
			p_token_3.parent = p_ExtensionEndMarker_ref;
			Raise_ExtensionEndMarker_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionEndMarker.production_kind.g_ExtensionEndMarker_1, p_ExtensionEndMarker_ref);
			return p_ExtensionEndMarker_ref;
		}
		#endregion
	};
}
