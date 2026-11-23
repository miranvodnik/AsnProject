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
	// class associated with syntax rule ModuleBody
	//

	[DataContract]
	public class	ModuleBody : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ModuleBody
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ModuleBody
		{
			g_ModuleBody_1 = 1,	// Exports Imports AssignmentList

			g_ModuleBody_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule ModuleBody

		// markers associated with production: ModuleBody -> Exports Imports AssignmentList

		public enum production_marker_1 : ushort
		{
			m_Exports,
			m_Imports,
			m_AssignmentList,
			final
		};

		// markers associated with production: ModuleBody -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ModuleBody

		// Constructor declaration(s) associated with production(s) of syntax rule ModuleBody

		//
		// Constructor associated with the following production(s)
		// ModuleBody -> Exports Imports AssignmentList

		//

		public ModuleBody (Exports p_Exports, Imports p_Imports, AssignmentList p_AssignmentList) : base ((uint) ProductionID._ModuleBody_ID, (uint) production_kind.g_ModuleBody_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_Exports = p_Exports;
			children[1] = m_Imports = p_Imports;
			children[2] = m_AssignmentList = p_AssignmentList;
		}

		//
		// Constructor associated with the following production(s)
		// ModuleBody -> %empty

		//

		public ModuleBody () : base ((uint) ProductionID._ModuleBody_ID, (uint) production_kind.g_ModuleBody_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public ModuleBody (ModuleBody p_ModuleBody) : base (p_ModuleBody.id, p_ModuleBody.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ModuleBody.appInfo;
			switch ((production_kind) p_ModuleBody.kind)
			{
				case production_kind.g_ModuleBody_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_Exports = (p_ModuleBody.m_Exports != null) ? new Exports (p_ModuleBody.m_Exports) : null) != null) m_Exports.parent = this;
					if ((children [1] = m_Imports = (p_ModuleBody.m_Imports != null) ? new Imports (p_ModuleBody.m_Imports) : null) != null) m_Imports.parent = this;
					if ((children [2] = m_AssignmentList = (p_ModuleBody.m_AssignmentList != null) ? new AssignmentList (p_ModuleBody.m_AssignmentList) : null) != null) m_AssignmentList.parent = this;
					break;
				case production_kind.g_ModuleBody_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "ModuleBody" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ModuleBody (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_Exports?.Dispose ();
			m_Imports?.Dispose ();
			m_AssignmentList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ModuleBody

		// Content changing function(s) associated with production(s) of syntax rule ModuleBody

		//
		// Content changing function associated with following production(s)
		// ModuleBody -> Exports Imports AssignmentList

		//

		public void change(Exports p_Exports, Imports p_Imports, AssignmentList p_AssignmentList)
		{
			_init ();
			this.kind = (uint) production_kind.g_ModuleBody_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_Exports = p_Exports;
			children [1] = m_Imports = p_Imports;
			children [2] = m_AssignmentList = p_AssignmentList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ModuleBody -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_ModuleBody_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ModuleBody
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_Exports != null) && m_Exports.checkInclusion (element) ||
				(m_Imports != null) && m_Imports.checkInclusion (element) ||
				(m_AssignmentList != null) && m_AssignmentList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ModuleBody

		//
		// emit production tree node associated with any production of syntax rule ModuleBody
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ModuleBody_1:
					// emit syntax tree node associated with production
					// ModuleBody: Exports Imports AssignmentList

					s += m_Exports.Emit (depth - 1);
					s += " ";
					s += m_Imports.Emit (depth - 1);
					s += " ";
					s += m_AssignmentList.Emit (depth - 1);
				break;
				case production_kind.g_ModuleBody_2:
					// emit syntax tree node associated with production
					// ModuleBody: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ModuleBody
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ModuleBody (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ModuleBody_1:
					// emit syntax tree node associated with production
					// ModuleBody: Exports Imports AssignmentList

					s += m_Exports.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Imports.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_AssignmentList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ModuleBody_2:
					// emit syntax tree node associated with production
					// ModuleBody: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ModuleBody

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ModuleBody with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ModuleBody.production_kind kind = (ModuleBody.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ModuleBody.production_kind.g_ModuleBody_1:
					// traverse syntax tree node associated with production
					// ModuleBody: Exports Imports AssignmentList

						m_Exports.Visit (visitor, appData);
						m_Imports.Visit (visitor, appData);
						m_AssignmentList.Visit (visitor, appData);
				break;
				case ModuleBody.production_kind.g_ModuleBody_2:
					// traverse syntax tree node associated with production
					// ModuleBody: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_Exports?.reparent (this);
			m_Imports?.reparent (this);
			m_AssignmentList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ModuleBody
		//

		public void _init ()
		{
			m_Exports = null;
			m_Imports = null;
			m_AssignmentList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ModuleBody

		// counter of all nodes associated with syntax rule ModuleBody
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ModuleBody
		[DataMember (Name = "m_Exports")] public Exports m_Exports { get; private set; }
		[DataMember (Name = "m_Imports")] public Imports m_Imports { get; private set; }
		[DataMember (Name = "m_AssignmentList")] public AssignmentList m_AssignmentList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ModuleBody

		// delegate function (callback) prototype associated with syntax rule ModuleBody
		public delegate bool ModuleBody_Callback (SyntaxTreeCallbackReason reason, ModuleBody.production_kind kind, ModuleBody p_ModuleBody);

		// event associated with syntax rule ModuleBody
		public event ModuleBody_Callback ModuleBody_Event;

		// event trigger associated with syntax rule ModuleBody
		public bool Raise_ModuleBody_Event (SyntaxTreeCallbackReason reason, ModuleBody.production_kind kind, ModuleBody p_ModuleBody)
		{
			bool? status = ModuleBody_Event?.Invoke (reason, kind, p_ModuleBody);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ModuleBody
		//
		// traverse syntax tree node associated with any production of syntax rule ModuleBody
		//

		public void Traverse (ModuleBody p_ModuleBody)
		{
			if (p_ModuleBody.isLocked())
				return;
			p_ModuleBody.dolock();
			ModuleBody.production_kind kind = (ModuleBody.production_kind) p_ModuleBody.kind;
			p_ModuleBody.turn_reset ();
			if (Raise_ModuleBody_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ModuleBody))
			switch (kind)
			{
				case ModuleBody.production_kind.g_ModuleBody_1:
					// traverse syntax tree node associated with production
					// ModuleBody: Exports Imports AssignmentList

					if (Raise_ModuleBody_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleBody))
						Traverse (p_ModuleBody.m_Exports);
					p_ModuleBody.turn_inc ();
					if (Raise_ModuleBody_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleBody))
						Traverse (p_ModuleBody.m_Imports);
					p_ModuleBody.turn_inc ();
					if (Raise_ModuleBody_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleBody))
						Traverse (p_ModuleBody.m_AssignmentList);
					p_ModuleBody.turn_inc ();
					Raise_ModuleBody_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleBody);
				break;
				case ModuleBody.production_kind.g_ModuleBody_2:
					// traverse syntax tree node associated with production
					// ModuleBody: %empty

				break;
			}
			Raise_ModuleBody_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ModuleBody);
			p_ModuleBody.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ModuleBody
		//

		public void TraverseCommon (ModuleBody p_ModuleBody)
		{
			ModuleBody.production_kind kind = (ModuleBody.production_kind) p_ModuleBody.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ModuleBody))
			switch (kind)
			{
				case ModuleBody.production_kind.g_ModuleBody_1:
					// traverse syntax tree node associated with production
					// ModuleBody: Exports Imports AssignmentList

						TraverseCommon (p_ModuleBody.m_Exports);
						TraverseCommon (p_ModuleBody.m_Imports);
						TraverseCommon (p_ModuleBody.m_AssignmentList);
				break;
				case ModuleBody.production_kind.g_ModuleBody_2:
					// traverse syntax tree node associated with production
					// ModuleBody: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ModuleBody);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ModuleBody

		//
		// create syntax tree node associated with production
		// ModuleBody: Exports Imports AssignmentList

		//

		public ModuleBody ModuleBody_1 (Exports p_Exports, Imports p_Imports, AssignmentList p_AssignmentList)
		{
			ModuleBody p_ModuleBody_ref = new ModuleBody(p_Exports, p_Imports, p_AssignmentList);
			p_Exports.parent = p_ModuleBody_ref;
			p_Imports.parent = p_ModuleBody_ref;
			p_AssignmentList.parent = p_ModuleBody_ref;
			Raise_ModuleBody_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ModuleBody.production_kind.g_ModuleBody_1, p_ModuleBody_ref);
			return p_ModuleBody_ref;
		}

		//
		// create syntax tree node associated with production
		// ModuleBody: %empty

		//

		public ModuleBody ModuleBody_2 ()
		{
			ModuleBody p_ModuleBody_ref = new ModuleBody();
			Raise_ModuleBody_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ModuleBody.production_kind.g_ModuleBody_2, p_ModuleBody_ref);
			return p_ModuleBody_ref;
		}
		#endregion
	};
}
