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
	// class associated with syntax rule TrapTypeMacro
	//

	[DataContract]
	public class	TrapTypeMacro : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TrapTypeMacro
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TrapTypeMacro
		{
			g_TrapTypeMacro_1 = 1,	// TRAP-TYPE ENTERPRISE Value TT-VarPart TT-DescrPart TT-ReferPart

		};
		#endregion
		#region production markers associated with the syntax rule TrapTypeMacro

		// markers associated with production: TrapTypeMacro -> TRAP-TYPE ENTERPRISE Value TT-VarPart TT-DescrPart TT-ReferPart

		public enum production_marker_1 : ushort
		{
			m_Value,
			m_TT_VarPart,
			m_TT_DescrPart,
			m_TT_ReferPart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TrapTypeMacro

		// Constructor declaration(s) associated with production(s) of syntax rule TrapTypeMacro

		//
		// Constructor associated with the following production(s)
		// TrapTypeMacro -> TRAP-TYPE ENTERPRISE Value TT-VarPart TT-DescrPart TT-ReferPart

		//

		public TrapTypeMacro (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Value p_Value, TT_VarPart p_TT_VarPart, TT_DescrPart p_TT_DescrPart, TT_ReferPart p_TT_ReferPart) : base ((uint) ProductionID._TrapTypeMacro_ID, (uint) production_kind.g_TrapTypeMacro_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
			children[0] = m_TRAP_TYPE = p_token;
			children[1] = m_ENTERPRISE = p_token_1;
			children[2] = m_Value = p_Value;
			children[3] = m_TT_VarPart = p_TT_VarPart;
			children[4] = m_TT_DescrPart = p_TT_DescrPart;
			children[5] = m_TT_ReferPart = p_TT_ReferPart;
		}

		public TrapTypeMacro () { }

		// Copy constructor

		public TrapTypeMacro (TrapTypeMacro p_TrapTypeMacro) : base (p_TrapTypeMacro.id, p_TrapTypeMacro.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TrapTypeMacro.appInfo;
			switch ((production_kind) p_TrapTypeMacro.kind)
			{
				case production_kind.g_TrapTypeMacro_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
					if ((children [0] = m_TRAP_TYPE = (p_TrapTypeMacro.m_TRAP_TYPE != null) ? new SyntaxTreeToken (p_TrapTypeMacro.m_TRAP_TYPE) : null) != null) m_TRAP_TYPE.parent = this;
					if ((children [1] = m_ENTERPRISE = (p_TrapTypeMacro.m_ENTERPRISE != null) ? new SyntaxTreeToken (p_TrapTypeMacro.m_ENTERPRISE) : null) != null) m_ENTERPRISE.parent = this;
					if ((children [2] = m_Value = (p_TrapTypeMacro.m_Value != null) ? new Value (p_TrapTypeMacro.m_Value) : null) != null) m_Value.parent = this;
					if ((children [3] = m_TT_VarPart = (p_TrapTypeMacro.m_TT_VarPart != null) ? new TT_VarPart (p_TrapTypeMacro.m_TT_VarPart) : null) != null) m_TT_VarPart.parent = this;
					if ((children [4] = m_TT_DescrPart = (p_TrapTypeMacro.m_TT_DescrPart != null) ? new TT_DescrPart (p_TrapTypeMacro.m_TT_DescrPart) : null) != null) m_TT_DescrPart.parent = this;
					if ((children [5] = m_TT_ReferPart = (p_TrapTypeMacro.m_TT_ReferPart != null) ? new TT_ReferPart (p_TrapTypeMacro.m_TT_ReferPart) : null) != null) m_TT_ReferPart.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TrapTypeMacro" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TrapTypeMacro (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_TRAP_TYPE?.Dispose ();
			m_ENTERPRISE?.Dispose ();
			m_Value?.Dispose ();
			m_TT_VarPart?.Dispose ();
			m_TT_DescrPart?.Dispose ();
			m_TT_ReferPart?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TrapTypeMacro

		// Content changing function(s) associated with production(s) of syntax rule TrapTypeMacro

		//
		// Content changing function associated with following production(s)
		// TrapTypeMacro -> TRAP-TYPE ENTERPRISE Value TT-VarPart TT-DescrPart TT-ReferPart

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Value p_Value, TT_VarPart p_TT_VarPart, TT_DescrPart p_TT_DescrPart, TT_ReferPart p_TT_ReferPart)
		{
			_init ();
			this.kind = (uint) production_kind.g_TrapTypeMacro_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
			children [0] = m_TRAP_TYPE = p_token;
			children [1] = m_ENTERPRISE = p_token_1;
			children [2] = m_Value = p_Value;
			children [3] = m_TT_VarPart = p_TT_VarPart;
			children [4] = m_TT_DescrPart = p_TT_DescrPart;
			children [5] = m_TT_ReferPart = p_TT_ReferPart;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TrapTypeMacro
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_TRAP_TYPE != null) && m_TRAP_TYPE.checkInclusion (element) ||
				(m_ENTERPRISE != null) && m_ENTERPRISE.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_TT_VarPart != null) && m_TT_VarPart.checkInclusion (element) ||
				(m_TT_DescrPart != null) && m_TT_DescrPart.checkInclusion (element) ||
				(m_TT_ReferPart != null) && m_TT_ReferPart.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TrapTypeMacro

		//
		// emit production tree node associated with any production of syntax rule TrapTypeMacro
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TrapTypeMacro_1:
					// emit syntax tree node associated with production
					// TrapTypeMacro: TRAP-TYPE ENTERPRISE Value TT-VarPart TT-DescrPart TT-ReferPart

					s += m_TRAP_TYPE.Emit (depth - 1);
					s += " ";
					s += m_ENTERPRISE.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
					s += " ";
					s += m_TT_VarPart.Emit (depth - 1);
					s += " ";
					s += m_TT_DescrPart.Emit (depth - 1);
					s += " ";
					s += m_TT_ReferPart.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TrapTypeMacro
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TrapTypeMacro (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TrapTypeMacro_1:
					// emit syntax tree node associated with production
					// TrapTypeMacro: TRAP-TYPE ENTERPRISE Value TT-VarPart TT-DescrPart TT-ReferPart

					s += "TRAP_TYPE";
					s += ' ';
					s += "ENTERPRISE";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_TT_VarPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_TT_DescrPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_TT_ReferPart.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TrapTypeMacro

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TrapTypeMacro with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TrapTypeMacro.production_kind kind = (TrapTypeMacro.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TrapTypeMacro.production_kind.g_TrapTypeMacro_1:
					// traverse syntax tree node associated with production
					// TrapTypeMacro: TRAP-TYPE ENTERPRISE Value TT-VarPart TT-DescrPart TT-ReferPart

						m_TRAP_TYPE.Visit (visitor, appData);
						m_ENTERPRISE.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
						m_TT_VarPart.Visit (visitor, appData);
						m_TT_DescrPart.Visit (visitor, appData);
						m_TT_ReferPart.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_TRAP_TYPE?.reparent (this);
			m_ENTERPRISE?.reparent (this);
			m_Value?.reparent (this);
			m_TT_VarPart?.reparent (this);
			m_TT_DescrPart?.reparent (this);
			m_TT_ReferPart?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TrapTypeMacro
		//

		public void _init ()
		{
			m_TRAP_TYPE = null;
			m_ENTERPRISE = null;
			m_Value = null;
			m_TT_VarPart = null;
			m_TT_DescrPart = null;
			m_TT_ReferPart = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TrapTypeMacro

		// counter of all nodes associated with syntax rule TrapTypeMacro
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TrapTypeMacro
		[DataMember (Name = "m_TRAP_TYPE")] public SyntaxTreeToken m_TRAP_TYPE { get; private set; }
		[DataMember (Name = "m_ENTERPRISE")] public SyntaxTreeToken m_ENTERPRISE { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_TT_VarPart")] public TT_VarPart m_TT_VarPart { get; private set; }
		[DataMember (Name = "m_TT_DescrPart")] public TT_DescrPart m_TT_DescrPart { get; private set; }
		[DataMember (Name = "m_TT_ReferPart")] public TT_ReferPart m_TT_ReferPart { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TrapTypeMacro

		// delegate function (callback) prototype associated with syntax rule TrapTypeMacro
		public delegate bool TrapTypeMacro_Callback (SyntaxTreeCallbackReason reason, TrapTypeMacro.production_kind kind, TrapTypeMacro p_TrapTypeMacro);

		// event associated with syntax rule TrapTypeMacro
		public event TrapTypeMacro_Callback TrapTypeMacro_Event;

		// event trigger associated with syntax rule TrapTypeMacro
		public bool Raise_TrapTypeMacro_Event (SyntaxTreeCallbackReason reason, TrapTypeMacro.production_kind kind, TrapTypeMacro p_TrapTypeMacro)
		{
			bool? status = TrapTypeMacro_Event?.Invoke (reason, kind, p_TrapTypeMacro);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TrapTypeMacro
		//
		// traverse syntax tree node associated with any production of syntax rule TrapTypeMacro
		//

		public void Traverse (TrapTypeMacro p_TrapTypeMacro)
		{
			if (p_TrapTypeMacro.isLocked())
				return;
			p_TrapTypeMacro.dolock();
			TrapTypeMacro.production_kind kind = (TrapTypeMacro.production_kind) p_TrapTypeMacro.kind;
			p_TrapTypeMacro.turn_reset ();
			if (Raise_TrapTypeMacro_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TrapTypeMacro))
			switch (kind)
			{
				case TrapTypeMacro.production_kind.g_TrapTypeMacro_1:
					// traverse syntax tree node associated with production
					// TrapTypeMacro: TRAP-TYPE ENTERPRISE Value TT-VarPart TT-DescrPart TT-ReferPart

					if (Raise_TrapTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TrapTypeMacro))
						Traverse (p_TrapTypeMacro.m_Value);
					p_TrapTypeMacro.turn_inc ();
					if (Raise_TrapTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TrapTypeMacro))
						Traverse (p_TrapTypeMacro.m_TT_VarPart);
					p_TrapTypeMacro.turn_inc ();
					if (Raise_TrapTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TrapTypeMacro))
						Traverse (p_TrapTypeMacro.m_TT_DescrPart);
					p_TrapTypeMacro.turn_inc ();
					if (Raise_TrapTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TrapTypeMacro))
						Traverse (p_TrapTypeMacro.m_TT_ReferPart);
					p_TrapTypeMacro.turn_inc ();
					Raise_TrapTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_TrapTypeMacro);
				break;
			}
			Raise_TrapTypeMacro_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TrapTypeMacro);
			p_TrapTypeMacro.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TrapTypeMacro
		//

		public void TraverseCommon (TrapTypeMacro p_TrapTypeMacro)
		{
			TrapTypeMacro.production_kind kind = (TrapTypeMacro.production_kind) p_TrapTypeMacro.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TrapTypeMacro))
			switch (kind)
			{
				case TrapTypeMacro.production_kind.g_TrapTypeMacro_1:
					// traverse syntax tree node associated with production
					// TrapTypeMacro: TRAP-TYPE ENTERPRISE Value TT-VarPart TT-DescrPart TT-ReferPart

						TraverseCommon (p_TrapTypeMacro.m_TRAP_TYPE);
						TraverseCommon (p_TrapTypeMacro.m_ENTERPRISE);
						TraverseCommon (p_TrapTypeMacro.m_Value);
						TraverseCommon (p_TrapTypeMacro.m_TT_VarPart);
						TraverseCommon (p_TrapTypeMacro.m_TT_DescrPart);
						TraverseCommon (p_TrapTypeMacro.m_TT_ReferPart);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TrapTypeMacro);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TrapTypeMacro

		//
		// create syntax tree node associated with production
		// TrapTypeMacro: TRAP-TYPE ENTERPRISE Value TT-VarPart TT-DescrPart TT-ReferPart

		//

		public TrapTypeMacro TrapTypeMacro_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, Value p_Value, TT_VarPart p_TT_VarPart, TT_DescrPart p_TT_DescrPart, TT_ReferPart p_TT_ReferPart)
		{
			TrapTypeMacro p_TrapTypeMacro_ref = new TrapTypeMacro(p_token, p_token_1, p_Value, p_TT_VarPart, p_TT_DescrPart, p_TT_ReferPart);
			p_token.parent = p_TrapTypeMacro_ref;
			p_token_1.parent = p_TrapTypeMacro_ref;
			p_Value.parent = p_TrapTypeMacro_ref;
			p_TT_VarPart.parent = p_TrapTypeMacro_ref;
			p_TT_DescrPart.parent = p_TrapTypeMacro_ref;
			p_TT_ReferPart.parent = p_TrapTypeMacro_ref;
			Raise_TrapTypeMacro_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TrapTypeMacro.production_kind.g_TrapTypeMacro_1, p_TrapTypeMacro_ref);
			return p_TrapTypeMacro_ref;
		}
		#endregion
	};
}
