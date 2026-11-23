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
	// class associated with syntax rule MC-ModuleName
	//

	[DataContract]
	public class	MC_ModuleName : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-ModuleName
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-ModuleName
		{
			g_MC_ModuleName_1 = 1,	// identifier-token MC-ModuleIdentifier

			g_MC_ModuleName_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule MC-ModuleName

		// markers associated with production: MC-ModuleName -> identifier-token MC-ModuleIdentifier

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			m_MC_ModuleIdentifier,
			final
		};

		// markers associated with production: MC-ModuleName -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-ModuleName

		// Constructor declaration(s) associated with production(s) of syntax rule MC-ModuleName

		//
		// Constructor associated with the following production(s)
		// MC-ModuleName -> identifier-token MC-ModuleIdentifier

		//

		public MC_ModuleName (identifier_token p_identifier_token, MC_ModuleIdentifier p_MC_ModuleIdentifier) : base ((uint) ProductionID._MC_ModuleName_ID, (uint) production_kind.g_MC_ModuleName_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_identifier_token = p_identifier_token;
			children[1] = m_MC_ModuleIdentifier = p_MC_ModuleIdentifier;
		}

		//
		// Constructor associated with the following production(s)
		// MC-ModuleName -> %empty

		//

		public MC_ModuleName () : base ((uint) ProductionID._MC_ModuleName_ID, (uint) production_kind.g_MC_ModuleName_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public MC_ModuleName (MC_ModuleName p_MC_ModuleName) : base (p_MC_ModuleName.id, p_MC_ModuleName.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_ModuleName.appInfo;
			switch ((production_kind) p_MC_ModuleName.kind)
			{
				case production_kind.g_MC_ModuleName_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_identifier_token = (p_MC_ModuleName.m_identifier_token != null) ? new identifier_token (p_MC_ModuleName.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					if ((children [1] = m_MC_ModuleIdentifier = (p_MC_ModuleName.m_MC_ModuleIdentifier != null) ? new MC_ModuleIdentifier (p_MC_ModuleName.m_MC_ModuleIdentifier) : null) != null) m_MC_ModuleIdentifier.parent = this;
					break;
				case production_kind.g_MC_ModuleName_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "MC_ModuleName" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_ModuleName (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();
			m_MC_ModuleIdentifier?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-ModuleName

		// Content changing function(s) associated with production(s) of syntax rule MC-ModuleName

		//
		// Content changing function associated with following production(s)
		// MC-ModuleName -> identifier-token MC-ModuleIdentifier

		//

		public void change(identifier_token p_identifier_token, MC_ModuleIdentifier p_MC_ModuleIdentifier)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_ModuleName_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_identifier_token = p_identifier_token;
			children [1] = m_MC_ModuleIdentifier = p_MC_ModuleIdentifier;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MC-ModuleName -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_ModuleName_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-ModuleName
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				(m_MC_ModuleIdentifier != null) && m_MC_ModuleIdentifier.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-ModuleName

		//
		// emit production tree node associated with any production of syntax rule MC-ModuleName
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_ModuleName_1:
					// emit syntax tree node associated with production
					// MC-ModuleName: identifier-token MC-ModuleIdentifier

					s += m_identifier_token.Emit (depth - 1);
					s += " ";
					s += m_MC_ModuleIdentifier.Emit (depth - 1);
				break;
				case production_kind.g_MC_ModuleName_2:
					// emit syntax tree node associated with production
					// MC-ModuleName: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-ModuleName
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_ModuleName (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_ModuleName_1:
					// emit syntax tree node associated with production
					// MC-ModuleName: identifier-token MC-ModuleIdentifier

					s += m_identifier_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_MC_ModuleIdentifier.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_MC_ModuleName_2:
					// emit syntax tree node associated with production
					// MC-ModuleName: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-ModuleName

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-ModuleName with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_ModuleName.production_kind kind = (MC_ModuleName.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_ModuleName.production_kind.g_MC_ModuleName_1:
					// traverse syntax tree node associated with production
					// MC-ModuleName: identifier-token MC-ModuleIdentifier

						m_identifier_token.Visit (visitor, appData);
						m_MC_ModuleIdentifier.Visit (visitor, appData);
				break;
				case MC_ModuleName.production_kind.g_MC_ModuleName_2:
					// traverse syntax tree node associated with production
					// MC-ModuleName: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier_token?.reparent (this);
			m_MC_ModuleIdentifier?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MC-ModuleName
		//

		public void _init ()
		{
			m_identifier_token = null;
			m_MC_ModuleIdentifier = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-ModuleName

		// counter of all nodes associated with syntax rule MC-ModuleName
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-ModuleName
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		[DataMember (Name = "m_MC_ModuleIdentifier")] public MC_ModuleIdentifier m_MC_ModuleIdentifier { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-ModuleName

		// delegate function (callback) prototype associated with syntax rule MC-ModuleName
		public delegate bool MC_ModuleName_Callback (SyntaxTreeCallbackReason reason, MC_ModuleName.production_kind kind, MC_ModuleName p_MC_ModuleName);

		// event associated with syntax rule MC-ModuleName
		public event MC_ModuleName_Callback MC_ModuleName_Event;

		// event trigger associated with syntax rule MC-ModuleName
		public bool Raise_MC_ModuleName_Event (SyntaxTreeCallbackReason reason, MC_ModuleName.production_kind kind, MC_ModuleName p_MC_ModuleName)
		{
			bool? status = MC_ModuleName_Event?.Invoke (reason, kind, p_MC_ModuleName);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-ModuleName
		//
		// traverse syntax tree node associated with any production of syntax rule MC-ModuleName
		//

		public void Traverse (MC_ModuleName p_MC_ModuleName)
		{
			if (p_MC_ModuleName.isLocked())
				return;
			p_MC_ModuleName.dolock();
			MC_ModuleName.production_kind kind = (MC_ModuleName.production_kind) p_MC_ModuleName.kind;
			p_MC_ModuleName.turn_reset ();
			if (Raise_MC_ModuleName_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_ModuleName))
			switch (kind)
			{
				case MC_ModuleName.production_kind.g_MC_ModuleName_1:
					// traverse syntax tree node associated with production
					// MC-ModuleName: identifier-token MC-ModuleIdentifier

					if (Raise_MC_ModuleName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_ModuleName))
						Traverse (p_MC_ModuleName.m_identifier_token);
					p_MC_ModuleName.turn_inc ();
					if (Raise_MC_ModuleName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_ModuleName))
						Traverse (p_MC_ModuleName.m_MC_ModuleIdentifier);
					p_MC_ModuleName.turn_inc ();
					Raise_MC_ModuleName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_ModuleName);
				break;
				case MC_ModuleName.production_kind.g_MC_ModuleName_2:
					// traverse syntax tree node associated with production
					// MC-ModuleName: %empty

				break;
			}
			Raise_MC_ModuleName_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_ModuleName);
			p_MC_ModuleName.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-ModuleName
		//

		public void TraverseCommon (MC_ModuleName p_MC_ModuleName)
		{
			MC_ModuleName.production_kind kind = (MC_ModuleName.production_kind) p_MC_ModuleName.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_ModuleName))
			switch (kind)
			{
				case MC_ModuleName.production_kind.g_MC_ModuleName_1:
					// traverse syntax tree node associated with production
					// MC-ModuleName: identifier-token MC-ModuleIdentifier

						TraverseCommon (p_MC_ModuleName.m_identifier_token);
						TraverseCommon (p_MC_ModuleName.m_MC_ModuleIdentifier);
				break;
				case MC_ModuleName.production_kind.g_MC_ModuleName_2:
					// traverse syntax tree node associated with production
					// MC-ModuleName: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_ModuleName);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-ModuleName

		//
		// create syntax tree node associated with production
		// MC-ModuleName: identifier-token MC-ModuleIdentifier

		//

		public MC_ModuleName MC_ModuleName_1 (identifier_token p_identifier_token, MC_ModuleIdentifier p_MC_ModuleIdentifier)
		{
			MC_ModuleName p_MC_ModuleName_ref = new MC_ModuleName(p_identifier_token, p_MC_ModuleIdentifier);
			p_identifier_token.parent = p_MC_ModuleName_ref;
			p_MC_ModuleIdentifier.parent = p_MC_ModuleName_ref;
			Raise_MC_ModuleName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_ModuleName.production_kind.g_MC_ModuleName_1, p_MC_ModuleName_ref);
			return p_MC_ModuleName_ref;
		}

		//
		// create syntax tree node associated with production
		// MC-ModuleName: %empty

		//

		public MC_ModuleName MC_ModuleName_2 ()
		{
			MC_ModuleName p_MC_ModuleName_ref = new MC_ModuleName();
			Raise_MC_ModuleName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_ModuleName.production_kind.g_MC_ModuleName_2, p_MC_ModuleName_ref);
			return p_MC_ModuleName_ref;
		}
		#endregion
	};
}
