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
	// class associated with syntax rule MacroIdentifier
	//

	[DataContract]
	public class	MacroIdentifier : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MacroIdentifier
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MacroIdentifier
		{
			g_MacroIdentifier_1 = 1,	// MacroName

			g_MacroIdentifier_2 = 2,	// typereference-token

		};
		#endregion
		#region production markers associated with the syntax rule MacroIdentifier

		// markers associated with production: MacroIdentifier -> MacroName

		public enum production_marker_1 : ushort
		{
			m_MacroName,
			final
		};

		// markers associated with production: MacroIdentifier -> typereference-token

		public enum production_marker_2 : ushort
		{
			m_typereference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MacroIdentifier

		// Constructor declaration(s) associated with production(s) of syntax rule MacroIdentifier

		//
		// Constructor associated with the following production(s)
		// MacroIdentifier -> MacroName

		//

		public MacroIdentifier (MacroName p_MacroName) : base ((uint) ProductionID._MacroIdentifier_ID, (uint) production_kind.g_MacroIdentifier_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MacroName = p_MacroName;
		}

		//
		// Constructor associated with the following production(s)
		// MacroIdentifier -> typereference-token

		//

		public MacroIdentifier (typereference_token p_typereference_token) : base ((uint) ProductionID._MacroIdentifier_ID, (uint) production_kind.g_MacroIdentifier_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_typereference_token = p_typereference_token;
		}

		public MacroIdentifier () { }

		// Copy constructor

		public MacroIdentifier (MacroIdentifier p_MacroIdentifier) : base (p_MacroIdentifier.id, p_MacroIdentifier.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MacroIdentifier.appInfo;
			switch ((production_kind) p_MacroIdentifier.kind)
			{
				case production_kind.g_MacroIdentifier_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MacroName = (p_MacroIdentifier.m_MacroName != null) ? new MacroName (p_MacroIdentifier.m_MacroName) : null) != null) m_MacroName.parent = this;
					break;
				case production_kind.g_MacroIdentifier_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_typereference_token = (p_MacroIdentifier.m_typereference_token != null) ? new typereference_token (p_MacroIdentifier.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MacroIdentifier" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MacroIdentifier (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_MacroName?.Dispose ();
			m_typereference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MacroIdentifier

		// Content changing function(s) associated with production(s) of syntax rule MacroIdentifier

		//
		// Content changing function associated with following production(s)
		// MacroIdentifier -> MacroName

		//

		public void change(MacroName p_MacroName)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroIdentifier_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MacroName = p_MacroName;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MacroIdentifier -> typereference-token

		//

		public void change(typereference_token p_typereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_MacroIdentifier_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_typereference_token = p_typereference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MacroIdentifier
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_MacroName != null) && m_MacroName.checkInclusion (element) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MacroIdentifier

		//
		// emit production tree node associated with any production of syntax rule MacroIdentifier
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MacroIdentifier_1:
					// emit syntax tree node associated with production
					// MacroIdentifier: MacroName

					s += m_MacroName.Emit (depth - 1);
				break;
				case production_kind.g_MacroIdentifier_2:
					// emit syntax tree node associated with production
					// MacroIdentifier: typereference-token

					s += m_typereference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MacroIdentifier
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MacroIdentifier (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MacroIdentifier_1:
					// emit syntax tree node associated with production
					// MacroIdentifier: MacroName

					s += m_MacroName.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MacroIdentifier_2:
					// emit syntax tree node associated with production
					// MacroIdentifier: typereference-token

					s += m_typereference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MacroIdentifier

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MacroIdentifier with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MacroIdentifier.production_kind kind = (MacroIdentifier.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MacroIdentifier.production_kind.g_MacroIdentifier_1:
					// traverse syntax tree node associated with production
					// MacroIdentifier: MacroName

						m_MacroName.Visit (visitor, appData);
				break;
				case MacroIdentifier.production_kind.g_MacroIdentifier_2:
					// traverse syntax tree node associated with production
					// MacroIdentifier: typereference-token

						m_typereference_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_MacroName?.reparent (this);
			m_typereference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MacroIdentifier
		//

		public void _init ()
		{
			m_MacroName = null;
			m_typereference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MacroIdentifier

		// counter of all nodes associated with syntax rule MacroIdentifier
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MacroIdentifier
		[DataMember (Name = "m_MacroName")] public MacroName m_MacroName { get; private set; }
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MacroIdentifier

		// delegate function (callback) prototype associated with syntax rule MacroIdentifier
		public delegate bool MacroIdentifier_Callback (SyntaxTreeCallbackReason reason, MacroIdentifier.production_kind kind, MacroIdentifier p_MacroIdentifier);

		// event associated with syntax rule MacroIdentifier
		public event MacroIdentifier_Callback MacroIdentifier_Event;

		// event trigger associated with syntax rule MacroIdentifier
		public bool Raise_MacroIdentifier_Event (SyntaxTreeCallbackReason reason, MacroIdentifier.production_kind kind, MacroIdentifier p_MacroIdentifier)
		{
			bool? status = MacroIdentifier_Event?.Invoke (reason, kind, p_MacroIdentifier);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MacroIdentifier
		//
		// traverse syntax tree node associated with any production of syntax rule MacroIdentifier
		//

		public void Traverse (MacroIdentifier p_MacroIdentifier)
		{
			if (p_MacroIdentifier.isLocked())
				return;
			p_MacroIdentifier.dolock();
			MacroIdentifier.production_kind kind = (MacroIdentifier.production_kind) p_MacroIdentifier.kind;
			p_MacroIdentifier.turn_reset ();
			if (Raise_MacroIdentifier_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MacroIdentifier))
			switch (kind)
			{
				case MacroIdentifier.production_kind.g_MacroIdentifier_1:
					// traverse syntax tree node associated with production
					// MacroIdentifier: MacroName

					if (Raise_MacroIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroIdentifier))
						Traverse (p_MacroIdentifier.m_MacroName);
					p_MacroIdentifier.turn_inc ();
					Raise_MacroIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroIdentifier);
				break;
				case MacroIdentifier.production_kind.g_MacroIdentifier_2:
					// traverse syntax tree node associated with production
					// MacroIdentifier: typereference-token

					if (Raise_MacroIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroIdentifier))
						Traverse (p_MacroIdentifier.m_typereference_token);
					p_MacroIdentifier.turn_inc ();
					Raise_MacroIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MacroIdentifier);
				break;
			}
			Raise_MacroIdentifier_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MacroIdentifier);
			p_MacroIdentifier.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MacroIdentifier
		//

		public void TraverseCommon (MacroIdentifier p_MacroIdentifier)
		{
			MacroIdentifier.production_kind kind = (MacroIdentifier.production_kind) p_MacroIdentifier.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MacroIdentifier))
			switch (kind)
			{
				case MacroIdentifier.production_kind.g_MacroIdentifier_1:
					// traverse syntax tree node associated with production
					// MacroIdentifier: MacroName

						TraverseCommon (p_MacroIdentifier.m_MacroName);
				break;
				case MacroIdentifier.production_kind.g_MacroIdentifier_2:
					// traverse syntax tree node associated with production
					// MacroIdentifier: typereference-token

						TraverseCommon (p_MacroIdentifier.m_typereference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MacroIdentifier);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MacroIdentifier

		//
		// create syntax tree node associated with production
		// MacroIdentifier: MacroName

		//

		public MacroIdentifier MacroIdentifier_1 (MacroName p_MacroName)
		{
			MacroIdentifier p_MacroIdentifier_ref = new MacroIdentifier(p_MacroName);
			p_MacroName.parent = p_MacroIdentifier_ref;
			Raise_MacroIdentifier_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroIdentifier.production_kind.g_MacroIdentifier_1, p_MacroIdentifier_ref);
			return p_MacroIdentifier_ref;
		}

		//
		// create syntax tree node associated with production
		// MacroIdentifier: typereference-token

		//

		public MacroIdentifier MacroIdentifier_2 (typereference_token p_typereference_token)
		{
			MacroIdentifier p_MacroIdentifier_ref = new MacroIdentifier(p_typereference_token);
			p_typereference_token.parent = p_MacroIdentifier_ref;
			Raise_MacroIdentifier_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MacroIdentifier.production_kind.g_MacroIdentifier_2, p_MacroIdentifier_ref);
			return p_MacroIdentifier_ref;
		}
		#endregion
	};
}
