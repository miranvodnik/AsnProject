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
	// class associated with syntax rule LowerEndpoint
	//

	[DataContract]
	public class	LowerEndpoint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule LowerEndpoint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule LowerEndpoint
		{
			g_LowerEndpoint_1 = 1,	// LowerEndValue

			g_LowerEndpoint_2 = 2,	// LowerEndValue "<"

		};
		#endregion
		#region production markers associated with the syntax rule LowerEndpoint

		// markers associated with production: LowerEndpoint -> LowerEndValue

		public enum production_marker_1 : ushort
		{
			m_LowerEndValue,
			final
		};

		// markers associated with production: LowerEndpoint -> LowerEndValue "<"

		public enum production_marker_2 : ushort
		{
			m_LowerEndValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule LowerEndpoint

		// Constructor declaration(s) associated with production(s) of syntax rule LowerEndpoint

		//
		// Constructor associated with the following production(s)
		// LowerEndpoint -> LowerEndValue

		//

		public LowerEndpoint (LowerEndValue p_LowerEndValue) : base ((uint) ProductionID._LowerEndpoint_ID, (uint) production_kind.g_LowerEndpoint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_LowerEndValue = p_LowerEndValue;
		}

		//
		// Constructor associated with the following production(s)
		// LowerEndpoint -> LowerEndValue "<"

		//

		public LowerEndpoint (LowerEndValue p_LowerEndValue, SyntaxTreeToken p_token) : base ((uint) ProductionID._LowerEndpoint_ID, (uint) production_kind.g_LowerEndpoint_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_LowerEndValue = p_LowerEndValue;
			children[1] = m_less_sign = p_token;
		}

		public LowerEndpoint () { }

		// Copy constructor

		public LowerEndpoint (LowerEndpoint p_LowerEndpoint) : base (p_LowerEndpoint.id, p_LowerEndpoint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_LowerEndpoint.appInfo;
			switch ((production_kind) p_LowerEndpoint.kind)
			{
				case production_kind.g_LowerEndpoint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_LowerEndValue = (p_LowerEndpoint.m_LowerEndValue != null) ? new LowerEndValue (p_LowerEndpoint.m_LowerEndValue) : null) != null) m_LowerEndValue.parent = this;
					break;
				case production_kind.g_LowerEndpoint_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_LowerEndValue = (p_LowerEndpoint.m_LowerEndValue != null) ? new LowerEndValue (p_LowerEndpoint.m_LowerEndValue) : null) != null) m_LowerEndValue.parent = this;
					if ((children [1] = m_less_sign = (p_LowerEndpoint.m_less_sign != null) ? new SyntaxTreeToken (p_LowerEndpoint.m_less_sign) : null) != null) m_less_sign.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "LowerEndpoint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new LowerEndpoint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_LowerEndValue?.Dispose ();
			m_less_sign?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule LowerEndpoint

		// Content changing function(s) associated with production(s) of syntax rule LowerEndpoint

		//
		// Content changing function associated with following production(s)
		// LowerEndpoint -> LowerEndValue

		//

		public void change(LowerEndValue p_LowerEndValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_LowerEndpoint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_LowerEndValue = p_LowerEndValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// LowerEndpoint -> LowerEndValue "<"

		//

		public void change(LowerEndValue p_LowerEndValue, SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_LowerEndpoint_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_LowerEndValue = p_LowerEndValue;
			children [1] = m_less_sign = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule LowerEndpoint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_LowerEndValue != null) && m_LowerEndValue.checkInclusion (element) ||
				(m_less_sign != null) && m_less_sign.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule LowerEndpoint

		//
		// emit production tree node associated with any production of syntax rule LowerEndpoint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_LowerEndpoint_1:
					// emit syntax tree node associated with production
					// LowerEndpoint: LowerEndValue

					s += m_LowerEndValue.Emit (depth - 1);
				break;
				case production_kind.g_LowerEndpoint_2:
					// emit syntax tree node associated with production
					// LowerEndpoint: LowerEndValue "<"

					s += m_LowerEndValue.Emit (depth - 1);
					s += " ";
					s += m_less_sign.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule LowerEndpoint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "LowerEndpoint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_LowerEndpoint_1:
					// emit syntax tree node associated with production
					// LowerEndpoint: LowerEndValue

					s += m_LowerEndValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_LowerEndpoint_2:
					// emit syntax tree node associated with production
					// LowerEndpoint: LowerEndValue "<"

					s += m_LowerEndValue.EmitProductionTree (depth - 1);
					s += ' ';
					s += "less_sign";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule LowerEndpoint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule LowerEndpoint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			LowerEndpoint.production_kind kind = (LowerEndpoint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case LowerEndpoint.production_kind.g_LowerEndpoint_1:
					// traverse syntax tree node associated with production
					// LowerEndpoint: LowerEndValue

						m_LowerEndValue.Visit (visitor, appData);
				break;
				case LowerEndpoint.production_kind.g_LowerEndpoint_2:
					// traverse syntax tree node associated with production
					// LowerEndpoint: LowerEndValue "<"

						m_LowerEndValue.Visit (visitor, appData);
						m_less_sign.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_LowerEndValue?.reparent (this);
			m_less_sign?.reparent (this);
		}

		//
		// initialize object associated with syntax rule LowerEndpoint
		//

		public void _init ()
		{
			m_LowerEndValue = null;
			m_less_sign = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule LowerEndpoint

		// counter of all nodes associated with syntax rule LowerEndpoint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule LowerEndpoint
		[DataMember (Name = "m_LowerEndValue")] public LowerEndValue m_LowerEndValue { get; private set; }
		[DataMember (Name = "m_less_sign")] public SyntaxTreeToken m_less_sign { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule LowerEndpoint

		// delegate function (callback) prototype associated with syntax rule LowerEndpoint
		public delegate bool LowerEndpoint_Callback (SyntaxTreeCallbackReason reason, LowerEndpoint.production_kind kind, LowerEndpoint p_LowerEndpoint);

		// event associated with syntax rule LowerEndpoint
		public event LowerEndpoint_Callback LowerEndpoint_Event;

		// event trigger associated with syntax rule LowerEndpoint
		public bool Raise_LowerEndpoint_Event (SyntaxTreeCallbackReason reason, LowerEndpoint.production_kind kind, LowerEndpoint p_LowerEndpoint)
		{
			bool? status = LowerEndpoint_Event?.Invoke (reason, kind, p_LowerEndpoint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule LowerEndpoint
		//
		// traverse syntax tree node associated with any production of syntax rule LowerEndpoint
		//

		public void Traverse (LowerEndpoint p_LowerEndpoint)
		{
			if (p_LowerEndpoint.isLocked())
				return;
			p_LowerEndpoint.dolock();
			LowerEndpoint.production_kind kind = (LowerEndpoint.production_kind) p_LowerEndpoint.kind;
			p_LowerEndpoint.turn_reset ();
			if (Raise_LowerEndpoint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_LowerEndpoint))
			switch (kind)
			{
				case LowerEndpoint.production_kind.g_LowerEndpoint_1:
					// traverse syntax tree node associated with production
					// LowerEndpoint: LowerEndValue

					if (Raise_LowerEndpoint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_LowerEndpoint))
						Traverse (p_LowerEndpoint.m_LowerEndValue);
					p_LowerEndpoint.turn_inc ();
					Raise_LowerEndpoint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_LowerEndpoint);
				break;
				case LowerEndpoint.production_kind.g_LowerEndpoint_2:
					// traverse syntax tree node associated with production
					// LowerEndpoint: LowerEndValue "<"

					if (Raise_LowerEndpoint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_LowerEndpoint))
						Traverse (p_LowerEndpoint.m_LowerEndValue);
					p_LowerEndpoint.turn_inc ();
					Raise_LowerEndpoint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_LowerEndpoint);
				break;
			}
			Raise_LowerEndpoint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_LowerEndpoint);
			p_LowerEndpoint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule LowerEndpoint
		//

		public void TraverseCommon (LowerEndpoint p_LowerEndpoint)
		{
			LowerEndpoint.production_kind kind = (LowerEndpoint.production_kind) p_LowerEndpoint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_LowerEndpoint))
			switch (kind)
			{
				case LowerEndpoint.production_kind.g_LowerEndpoint_1:
					// traverse syntax tree node associated with production
					// LowerEndpoint: LowerEndValue

						TraverseCommon (p_LowerEndpoint.m_LowerEndValue);
				break;
				case LowerEndpoint.production_kind.g_LowerEndpoint_2:
					// traverse syntax tree node associated with production
					// LowerEndpoint: LowerEndValue "<"

						TraverseCommon (p_LowerEndpoint.m_LowerEndValue);
						TraverseCommon (p_LowerEndpoint.m_less_sign);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_LowerEndpoint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule LowerEndpoint

		//
		// create syntax tree node associated with production
		// LowerEndpoint: LowerEndValue

		//

		public LowerEndpoint LowerEndpoint_1 (LowerEndValue p_LowerEndValue)
		{
			LowerEndpoint p_LowerEndpoint_ref = new LowerEndpoint(p_LowerEndValue);
			p_LowerEndValue.parent = p_LowerEndpoint_ref;
			Raise_LowerEndpoint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, LowerEndpoint.production_kind.g_LowerEndpoint_1, p_LowerEndpoint_ref);
			return p_LowerEndpoint_ref;
		}

		//
		// create syntax tree node associated with production
		// LowerEndpoint: LowerEndValue "<"

		//

		public LowerEndpoint LowerEndpoint_2 (LowerEndValue p_LowerEndValue, SyntaxTreeToken p_token)
		{
			LowerEndpoint p_LowerEndpoint_ref = new LowerEndpoint(p_LowerEndValue, p_token);
			p_LowerEndValue.parent = p_LowerEndpoint_ref;
			p_token.parent = p_LowerEndpoint_ref;
			Raise_LowerEndpoint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, LowerEndpoint.production_kind.g_LowerEndpoint_2, p_LowerEndpoint_ref);
			return p_LowerEndpoint_ref;
		}
		#endregion
	};
}
