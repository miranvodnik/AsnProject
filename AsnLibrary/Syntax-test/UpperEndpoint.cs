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
	// class associated with syntax rule UpperEndpoint
	//

	[DataContract]
	public class	UpperEndpoint : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule UpperEndpoint
		public enum production_kind : ushort	// enumerated production(s) of syntax rule UpperEndpoint
		{
			g_UpperEndpoint_1 = 1,	// UpperEndValue

			g_UpperEndpoint_2 = 2,	// "<" UpperEndValue

		};
		#endregion
		#region production markers associated with the syntax rule UpperEndpoint

		// markers associated with production: UpperEndpoint -> UpperEndValue

		public enum production_marker_1 : ushort
		{
			m_UpperEndValue,
			final
		};

		// markers associated with production: UpperEndpoint -> "<" UpperEndValue

		public enum production_marker_2 : ushort
		{
			m_UpperEndValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule UpperEndpoint

		// Constructor declaration(s) associated with production(s) of syntax rule UpperEndpoint

		//
		// Constructor associated with the following production(s)
		// UpperEndpoint -> UpperEndValue

		//

		public UpperEndpoint (UpperEndValue p_UpperEndValue) : base ((uint) ProductionID._UpperEndpoint_ID, (uint) production_kind.g_UpperEndpoint_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_UpperEndValue = p_UpperEndValue;
		}

		//
		// Constructor associated with the following production(s)
		// UpperEndpoint -> "<" UpperEndValue

		//

		public UpperEndpoint (SyntaxTreeToken p_token, UpperEndValue p_UpperEndValue) : base ((uint) ProductionID._UpperEndpoint_ID, (uint) production_kind.g_UpperEndpoint_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_less_sign = p_token;
			children[1] = m_UpperEndValue = p_UpperEndValue;
		}

		public UpperEndpoint () { }

		// Copy constructor

		public UpperEndpoint (UpperEndpoint p_UpperEndpoint) : base (p_UpperEndpoint.id, p_UpperEndpoint.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_UpperEndpoint.appInfo;
			switch ((production_kind) p_UpperEndpoint.kind)
			{
				case production_kind.g_UpperEndpoint_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UpperEndValue = (p_UpperEndpoint.m_UpperEndValue != null) ? new UpperEndValue (p_UpperEndpoint.m_UpperEndValue) : null) != null) m_UpperEndValue.parent = this;
					break;
				case production_kind.g_UpperEndpoint_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_less_sign = (p_UpperEndpoint.m_less_sign != null) ? new SyntaxTreeToken (p_UpperEndpoint.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_UpperEndValue = (p_UpperEndpoint.m_UpperEndValue != null) ? new UpperEndValue (p_UpperEndpoint.m_UpperEndValue) : null) != null) m_UpperEndValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "UpperEndpoint" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new UpperEndpoint (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_UpperEndValue?.Dispose ();
			m_less_sign?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule UpperEndpoint

		// Content changing function(s) associated with production(s) of syntax rule UpperEndpoint

		//
		// Content changing function associated with following production(s)
		// UpperEndpoint -> UpperEndValue

		//

		public void change(UpperEndValue p_UpperEndValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_UpperEndpoint_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_UpperEndValue = p_UpperEndValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// UpperEndpoint -> "<" UpperEndValue

		//

		public void change(SyntaxTreeToken p_token, UpperEndValue p_UpperEndValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_UpperEndpoint_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_less_sign = p_token;
			children [1] = m_UpperEndValue = p_UpperEndValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule UpperEndpoint
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_UpperEndValue != null) && m_UpperEndValue.checkInclusion (element) ||
				(m_less_sign != null) && m_less_sign.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule UpperEndpoint

		//
		// emit production tree node associated with any production of syntax rule UpperEndpoint
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_UpperEndpoint_1:
					// emit syntax tree node associated with production
					// UpperEndpoint: UpperEndValue

					s += m_UpperEndValue.Emit (depth - 1);
				break;
				case production_kind.g_UpperEndpoint_2:
					// emit syntax tree node associated with production
					// UpperEndpoint: "<" UpperEndValue

					s += m_less_sign.Emit (depth - 1);
					s += " ";
					s += m_UpperEndValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule UpperEndpoint
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "UpperEndpoint (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_UpperEndpoint_1:
					// emit syntax tree node associated with production
					// UpperEndpoint: UpperEndValue

					s += m_UpperEndValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_UpperEndpoint_2:
					// emit syntax tree node associated with production
					// UpperEndpoint: "<" UpperEndValue

					s += "less_sign";
					s += ' ';
					s += m_UpperEndValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule UpperEndpoint

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule UpperEndpoint with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			UpperEndpoint.production_kind kind = (UpperEndpoint.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case UpperEndpoint.production_kind.g_UpperEndpoint_1:
					// traverse syntax tree node associated with production
					// UpperEndpoint: UpperEndValue

						m_UpperEndValue.Visit (visitor, appData);
				break;
				case UpperEndpoint.production_kind.g_UpperEndpoint_2:
					// traverse syntax tree node associated with production
					// UpperEndpoint: "<" UpperEndValue

						m_less_sign.Visit (visitor, appData);
						m_UpperEndValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_UpperEndValue?.reparent (this);
			m_less_sign?.reparent (this);
		}

		//
		// initialize object associated with syntax rule UpperEndpoint
		//

		public void _init ()
		{
			m_UpperEndValue = null;
			m_less_sign = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule UpperEndpoint

		// counter of all nodes associated with syntax rule UpperEndpoint
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule UpperEndpoint
		[DataMember (Name = "m_UpperEndValue")] public UpperEndValue m_UpperEndValue { get; private set; }
		[DataMember (Name = "m_less_sign")] public SyntaxTreeToken m_less_sign { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule UpperEndpoint

		// delegate function (callback) prototype associated with syntax rule UpperEndpoint
		public delegate bool UpperEndpoint_Callback (SyntaxTreeCallbackReason reason, UpperEndpoint.production_kind kind, UpperEndpoint p_UpperEndpoint);

		// event associated with syntax rule UpperEndpoint
		public event UpperEndpoint_Callback UpperEndpoint_Event;

		// event trigger associated with syntax rule UpperEndpoint
		public bool Raise_UpperEndpoint_Event (SyntaxTreeCallbackReason reason, UpperEndpoint.production_kind kind, UpperEndpoint p_UpperEndpoint)
		{
			bool? status = UpperEndpoint_Event?.Invoke (reason, kind, p_UpperEndpoint);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule UpperEndpoint
		//
		// traverse syntax tree node associated with any production of syntax rule UpperEndpoint
		//

		public void Traverse (UpperEndpoint p_UpperEndpoint)
		{
			if (p_UpperEndpoint.isLocked())
				return;
			p_UpperEndpoint.dolock();
			UpperEndpoint.production_kind kind = (UpperEndpoint.production_kind) p_UpperEndpoint.kind;
			p_UpperEndpoint.turn_reset ();
			if (Raise_UpperEndpoint_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_UpperEndpoint))
			switch (kind)
			{
				case UpperEndpoint.production_kind.g_UpperEndpoint_1:
					// traverse syntax tree node associated with production
					// UpperEndpoint: UpperEndValue

					if (Raise_UpperEndpoint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UpperEndpoint))
						Traverse (p_UpperEndpoint.m_UpperEndValue);
					p_UpperEndpoint.turn_inc ();
					Raise_UpperEndpoint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UpperEndpoint);
				break;
				case UpperEndpoint.production_kind.g_UpperEndpoint_2:
					// traverse syntax tree node associated with production
					// UpperEndpoint: "<" UpperEndValue

					if (Raise_UpperEndpoint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UpperEndpoint))
						Traverse (p_UpperEndpoint.m_UpperEndValue);
					p_UpperEndpoint.turn_inc ();
					Raise_UpperEndpoint_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_UpperEndpoint);
				break;
			}
			Raise_UpperEndpoint_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_UpperEndpoint);
			p_UpperEndpoint.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule UpperEndpoint
		//

		public void TraverseCommon (UpperEndpoint p_UpperEndpoint)
		{
			UpperEndpoint.production_kind kind = (UpperEndpoint.production_kind) p_UpperEndpoint.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_UpperEndpoint))
			switch (kind)
			{
				case UpperEndpoint.production_kind.g_UpperEndpoint_1:
					// traverse syntax tree node associated with production
					// UpperEndpoint: UpperEndValue

						TraverseCommon (p_UpperEndpoint.m_UpperEndValue);
				break;
				case UpperEndpoint.production_kind.g_UpperEndpoint_2:
					// traverse syntax tree node associated with production
					// UpperEndpoint: "<" UpperEndValue

						TraverseCommon (p_UpperEndpoint.m_less_sign);
						TraverseCommon (p_UpperEndpoint.m_UpperEndValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_UpperEndpoint);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule UpperEndpoint

		//
		// create syntax tree node associated with production
		// UpperEndpoint: UpperEndValue

		//

		public UpperEndpoint UpperEndpoint_1 (UpperEndValue p_UpperEndValue)
		{
			UpperEndpoint p_UpperEndpoint_ref = new UpperEndpoint(p_UpperEndValue);
			p_UpperEndValue.parent = p_UpperEndpoint_ref;
			Raise_UpperEndpoint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UpperEndpoint.production_kind.g_UpperEndpoint_1, p_UpperEndpoint_ref);
			return p_UpperEndpoint_ref;
		}

		//
		// create syntax tree node associated with production
		// UpperEndpoint: "<" UpperEndValue

		//

		public UpperEndpoint UpperEndpoint_2 (SyntaxTreeToken p_token, UpperEndValue p_UpperEndValue)
		{
			UpperEndpoint p_UpperEndpoint_ref = new UpperEndpoint(p_token, p_UpperEndValue);
			p_token.parent = p_UpperEndpoint_ref;
			p_UpperEndValue.parent = p_UpperEndpoint_ref;
			Raise_UpperEndpoint_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UpperEndpoint.production_kind.g_UpperEndpoint_2, p_UpperEndpoint_ref);
			return p_UpperEndpoint_ref;
		}
		#endregion
	};
}
