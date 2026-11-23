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
	// class associated with syntax rule ParameterizedAssignment
	//

	[DataContract]
	public class	ParameterizedAssignment : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedAssignment
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedAssignment
		{
			g_ParameterizedAssignment_1 = 1,	// ParameterizedTypeAssignment

			g_ParameterizedAssignment_2 = 2,	// ParameterizedValueAssignment

			g_ParameterizedAssignment_3 = 3,	// ParameterizedValueSetTypeAssignment

			g_ParameterizedAssignment_4 = 4,	// ParameterizedObjectClassAssignment

			g_ParameterizedAssignment_5 = 5,	// ParameterizedObjectAssignment

			g_ParameterizedAssignment_6 = 6,	// ParameterizedObjectSetAssignment

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedAssignment

		// markers associated with production: ParameterizedAssignment -> ParameterizedTypeAssignment

		public enum production_marker_1 : ushort
		{
			m_ParameterizedTypeAssignment,
			final
		};

		// markers associated with production: ParameterizedAssignment -> ParameterizedValueAssignment

		public enum production_marker_2 : ushort
		{
			m_ParameterizedValueAssignment,
			final
		};

		// markers associated with production: ParameterizedAssignment -> ParameterizedValueSetTypeAssignment

		public enum production_marker_3 : ushort
		{
			m_ParameterizedValueSetTypeAssignment,
			final
		};

		// markers associated with production: ParameterizedAssignment -> ParameterizedObjectClassAssignment

		public enum production_marker_4 : ushort
		{
			m_ParameterizedObjectClassAssignment,
			final
		};

		// markers associated with production: ParameterizedAssignment -> ParameterizedObjectAssignment

		public enum production_marker_5 : ushort
		{
			m_ParameterizedObjectAssignment,
			final
		};

		// markers associated with production: ParameterizedAssignment -> ParameterizedObjectSetAssignment

		public enum production_marker_6 : ushort
		{
			m_ParameterizedObjectSetAssignment,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedAssignment

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedAssignment

		//
		// Constructor associated with the following production(s)
		// ParameterizedAssignment -> ParameterizedTypeAssignment

		//

		public ParameterizedAssignment (ParameterizedTypeAssignment p_ParameterizedTypeAssignment) : base ((uint) ProductionID._ParameterizedAssignment_ID, (uint) production_kind.g_ParameterizedAssignment_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedTypeAssignment = p_ParameterizedTypeAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// ParameterizedAssignment -> ParameterizedValueAssignment

		//

		public ParameterizedAssignment (ParameterizedValueAssignment p_ParameterizedValueAssignment) : base ((uint) ProductionID._ParameterizedAssignment_ID, (uint) production_kind.g_ParameterizedAssignment_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedValueAssignment = p_ParameterizedValueAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// ParameterizedAssignment -> ParameterizedValueSetTypeAssignment

		//

		public ParameterizedAssignment (ParameterizedValueSetTypeAssignment p_ParameterizedValueSetTypeAssignment) : base ((uint) ProductionID._ParameterizedAssignment_ID, (uint) production_kind.g_ParameterizedAssignment_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedValueSetTypeAssignment = p_ParameterizedValueSetTypeAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// ParameterizedAssignment -> ParameterizedObjectClassAssignment

		//

		public ParameterizedAssignment (ParameterizedObjectClassAssignment p_ParameterizedObjectClassAssignment) : base ((uint) ProductionID._ParameterizedAssignment_ID, (uint) production_kind.g_ParameterizedAssignment_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedObjectClassAssignment = p_ParameterizedObjectClassAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// ParameterizedAssignment -> ParameterizedObjectAssignment

		//

		public ParameterizedAssignment (ParameterizedObjectAssignment p_ParameterizedObjectAssignment) : base ((uint) ProductionID._ParameterizedAssignment_ID, (uint) production_kind.g_ParameterizedAssignment_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedObjectAssignment = p_ParameterizedObjectAssignment;
		}

		//
		// Constructor associated with the following production(s)
		// ParameterizedAssignment -> ParameterizedObjectSetAssignment

		//

		public ParameterizedAssignment (ParameterizedObjectSetAssignment p_ParameterizedObjectSetAssignment) : base ((uint) ProductionID._ParameterizedAssignment_ID, (uint) production_kind.g_ParameterizedAssignment_6)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedObjectSetAssignment = p_ParameterizedObjectSetAssignment;
		}

		public ParameterizedAssignment () { }

		// Copy constructor

		public ParameterizedAssignment (ParameterizedAssignment p_ParameterizedAssignment) : base (p_ParameterizedAssignment.id, p_ParameterizedAssignment.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedAssignment.appInfo;
			switch ((production_kind) p_ParameterizedAssignment.kind)
			{
				case production_kind.g_ParameterizedAssignment_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedTypeAssignment = (p_ParameterizedAssignment.m_ParameterizedTypeAssignment != null) ? new ParameterizedTypeAssignment (p_ParameterizedAssignment.m_ParameterizedTypeAssignment) : null) != null) m_ParameterizedTypeAssignment.parent = this;
					break;
				case production_kind.g_ParameterizedAssignment_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedValueAssignment = (p_ParameterizedAssignment.m_ParameterizedValueAssignment != null) ? new ParameterizedValueAssignment (p_ParameterizedAssignment.m_ParameterizedValueAssignment) : null) != null) m_ParameterizedValueAssignment.parent = this;
					break;
				case production_kind.g_ParameterizedAssignment_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedValueSetTypeAssignment = (p_ParameterizedAssignment.m_ParameterizedValueSetTypeAssignment != null) ? new ParameterizedValueSetTypeAssignment (p_ParameterizedAssignment.m_ParameterizedValueSetTypeAssignment) : null) != null) m_ParameterizedValueSetTypeAssignment.parent = this;
					break;
				case production_kind.g_ParameterizedAssignment_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedObjectClassAssignment = (p_ParameterizedAssignment.m_ParameterizedObjectClassAssignment != null) ? new ParameterizedObjectClassAssignment (p_ParameterizedAssignment.m_ParameterizedObjectClassAssignment) : null) != null) m_ParameterizedObjectClassAssignment.parent = this;
					break;
				case production_kind.g_ParameterizedAssignment_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedObjectAssignment = (p_ParameterizedAssignment.m_ParameterizedObjectAssignment != null) ? new ParameterizedObjectAssignment (p_ParameterizedAssignment.m_ParameterizedObjectAssignment) : null) != null) m_ParameterizedObjectAssignment.parent = this;
					break;
				case production_kind.g_ParameterizedAssignment_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedObjectSetAssignment = (p_ParameterizedAssignment.m_ParameterizedObjectSetAssignment != null) ? new ParameterizedObjectSetAssignment (p_ParameterizedAssignment.m_ParameterizedObjectSetAssignment) : null) != null) m_ParameterizedObjectSetAssignment.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedAssignment" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedAssignment (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ParameterizedTypeAssignment?.Dispose ();
			m_ParameterizedValueAssignment?.Dispose ();
			m_ParameterizedValueSetTypeAssignment?.Dispose ();
			m_ParameterizedObjectClassAssignment?.Dispose ();
			m_ParameterizedObjectAssignment?.Dispose ();
			m_ParameterizedObjectSetAssignment?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedAssignment

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedAssignment

		//
		// Content changing function associated with following production(s)
		// ParameterizedAssignment -> ParameterizedTypeAssignment

		//

		public void change(ParameterizedTypeAssignment p_ParameterizedTypeAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedAssignment_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedTypeAssignment = p_ParameterizedTypeAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ParameterizedAssignment -> ParameterizedValueAssignment

		//

		public void change(ParameterizedValueAssignment p_ParameterizedValueAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedAssignment_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedValueAssignment = p_ParameterizedValueAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ParameterizedAssignment -> ParameterizedValueSetTypeAssignment

		//

		public void change(ParameterizedValueSetTypeAssignment p_ParameterizedValueSetTypeAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedAssignment_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedValueSetTypeAssignment = p_ParameterizedValueSetTypeAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ParameterizedAssignment -> ParameterizedObjectClassAssignment

		//

		public void change(ParameterizedObjectClassAssignment p_ParameterizedObjectClassAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedAssignment_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedObjectClassAssignment = p_ParameterizedObjectClassAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ParameterizedAssignment -> ParameterizedObjectAssignment

		//

		public void change(ParameterizedObjectAssignment p_ParameterizedObjectAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedAssignment_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedObjectAssignment = p_ParameterizedObjectAssignment;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ParameterizedAssignment -> ParameterizedObjectSetAssignment

		//

		public void change(ParameterizedObjectSetAssignment p_ParameterizedObjectSetAssignment)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedAssignment_6;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedObjectSetAssignment = p_ParameterizedObjectSetAssignment;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedAssignment
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ParameterizedTypeAssignment != null) && m_ParameterizedTypeAssignment.checkInclusion (element) ||
				(m_ParameterizedValueAssignment != null) && m_ParameterizedValueAssignment.checkInclusion (element) ||
				(m_ParameterizedValueSetTypeAssignment != null) && m_ParameterizedValueSetTypeAssignment.checkInclusion (element) ||
				(m_ParameterizedObjectClassAssignment != null) && m_ParameterizedObjectClassAssignment.checkInclusion (element) ||
				(m_ParameterizedObjectAssignment != null) && m_ParameterizedObjectAssignment.checkInclusion (element) ||
				(m_ParameterizedObjectSetAssignment != null) && m_ParameterizedObjectSetAssignment.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterizedAssignment

		//
		// emit production tree node associated with any production of syntax rule ParameterizedAssignment
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedTypeAssignment

					s += m_ParameterizedTypeAssignment.Emit (depth - 1);
				break;
				case production_kind.g_ParameterizedAssignment_2:
					// emit syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedValueAssignment

					s += m_ParameterizedValueAssignment.Emit (depth - 1);
				break;
				case production_kind.g_ParameterizedAssignment_3:
					// emit syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedValueSetTypeAssignment

					s += m_ParameterizedValueSetTypeAssignment.Emit (depth - 1);
				break;
				case production_kind.g_ParameterizedAssignment_4:
					// emit syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectClassAssignment

					s += m_ParameterizedObjectClassAssignment.Emit (depth - 1);
				break;
				case production_kind.g_ParameterizedAssignment_5:
					// emit syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectAssignment

					s += m_ParameterizedObjectAssignment.Emit (depth - 1);
				break;
				case production_kind.g_ParameterizedAssignment_6:
					// emit syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectSetAssignment

					s += m_ParameterizedObjectSetAssignment.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParameterizedAssignment
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedAssignment (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedAssignment_1:
					// emit syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedTypeAssignment

					s += m_ParameterizedTypeAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ParameterizedAssignment_2:
					// emit syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedValueAssignment

					s += m_ParameterizedValueAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ParameterizedAssignment_3:
					// emit syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedValueSetTypeAssignment

					s += m_ParameterizedValueSetTypeAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ParameterizedAssignment_4:
					// emit syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectClassAssignment

					s += m_ParameterizedObjectClassAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ParameterizedAssignment_5:
					// emit syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectAssignment

					s += m_ParameterizedObjectAssignment.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ParameterizedAssignment_6:
					// emit syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectSetAssignment

					s += m_ParameterizedObjectSetAssignment.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedAssignment

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedAssignment with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedAssignment.production_kind kind = (ParameterizedAssignment.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedTypeAssignment

						m_ParameterizedTypeAssignment.Visit (visitor, appData);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_2:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedValueAssignment

						m_ParameterizedValueAssignment.Visit (visitor, appData);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_3:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedValueSetTypeAssignment

						m_ParameterizedValueSetTypeAssignment.Visit (visitor, appData);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_4:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectClassAssignment

						m_ParameterizedObjectClassAssignment.Visit (visitor, appData);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_5:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectAssignment

						m_ParameterizedObjectAssignment.Visit (visitor, appData);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_6:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectSetAssignment

						m_ParameterizedObjectSetAssignment.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ParameterizedTypeAssignment?.reparent (this);
			m_ParameterizedValueAssignment?.reparent (this);
			m_ParameterizedValueSetTypeAssignment?.reparent (this);
			m_ParameterizedObjectClassAssignment?.reparent (this);
			m_ParameterizedObjectAssignment?.reparent (this);
			m_ParameterizedObjectSetAssignment?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterizedAssignment
		//

		public void _init ()
		{
			m_ParameterizedTypeAssignment = null;
			m_ParameterizedValueAssignment = null;
			m_ParameterizedValueSetTypeAssignment = null;
			m_ParameterizedObjectClassAssignment = null;
			m_ParameterizedObjectAssignment = null;
			m_ParameterizedObjectSetAssignment = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedAssignment

		// counter of all nodes associated with syntax rule ParameterizedAssignment
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedAssignment
		[DataMember (Name = "m_ParameterizedTypeAssignment")] public ParameterizedTypeAssignment m_ParameterizedTypeAssignment { get; private set; }
		[DataMember (Name = "m_ParameterizedValueAssignment")] public ParameterizedValueAssignment m_ParameterizedValueAssignment { get; private set; }
		[DataMember (Name = "m_ParameterizedValueSetTypeAssignment")] public ParameterizedValueSetTypeAssignment m_ParameterizedValueSetTypeAssignment { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectClassAssignment")] public ParameterizedObjectClassAssignment m_ParameterizedObjectClassAssignment { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectAssignment")] public ParameterizedObjectAssignment m_ParameterizedObjectAssignment { get; private set; }
		[DataMember (Name = "m_ParameterizedObjectSetAssignment")] public ParameterizedObjectSetAssignment m_ParameterizedObjectSetAssignment { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedAssignment

		// delegate function (callback) prototype associated with syntax rule ParameterizedAssignment
		public delegate bool ParameterizedAssignment_Callback (SyntaxTreeCallbackReason reason, ParameterizedAssignment.production_kind kind, ParameterizedAssignment p_ParameterizedAssignment);

		// event associated with syntax rule ParameterizedAssignment
		public event ParameterizedAssignment_Callback ParameterizedAssignment_Event;

		// event trigger associated with syntax rule ParameterizedAssignment
		public bool Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason reason, ParameterizedAssignment.production_kind kind, ParameterizedAssignment p_ParameterizedAssignment)
		{
			bool? status = ParameterizedAssignment_Event?.Invoke (reason, kind, p_ParameterizedAssignment);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedAssignment
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedAssignment
		//

		public void Traverse (ParameterizedAssignment p_ParameterizedAssignment)
		{
			if (p_ParameterizedAssignment.isLocked())
				return;
			p_ParameterizedAssignment.dolock();
			ParameterizedAssignment.production_kind kind = (ParameterizedAssignment.production_kind) p_ParameterizedAssignment.kind;
			p_ParameterizedAssignment.turn_reset ();
			if (Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedAssignment))
			switch (kind)
			{
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedTypeAssignment

					if (Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedAssignment))
						Traverse (p_ParameterizedAssignment.m_ParameterizedTypeAssignment);
					p_ParameterizedAssignment.turn_inc ();
					Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedAssignment);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_2:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedValueAssignment

					if (Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedAssignment))
						Traverse (p_ParameterizedAssignment.m_ParameterizedValueAssignment);
					p_ParameterizedAssignment.turn_inc ();
					Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedAssignment);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_3:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedValueSetTypeAssignment

					if (Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedAssignment))
						Traverse (p_ParameterizedAssignment.m_ParameterizedValueSetTypeAssignment);
					p_ParameterizedAssignment.turn_inc ();
					Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedAssignment);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_4:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectClassAssignment

					if (Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedAssignment))
						Traverse (p_ParameterizedAssignment.m_ParameterizedObjectClassAssignment);
					p_ParameterizedAssignment.turn_inc ();
					Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedAssignment);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_5:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectAssignment

					if (Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedAssignment))
						Traverse (p_ParameterizedAssignment.m_ParameterizedObjectAssignment);
					p_ParameterizedAssignment.turn_inc ();
					Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedAssignment);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_6:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectSetAssignment

					if (Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedAssignment))
						Traverse (p_ParameterizedAssignment.m_ParameterizedObjectSetAssignment);
					p_ParameterizedAssignment.turn_inc ();
					Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedAssignment);
				break;
			}
			Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedAssignment);
			p_ParameterizedAssignment.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedAssignment
		//

		public void TraverseCommon (ParameterizedAssignment p_ParameterizedAssignment)
		{
			ParameterizedAssignment.production_kind kind = (ParameterizedAssignment.production_kind) p_ParameterizedAssignment.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedAssignment))
			switch (kind)
			{
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_1:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedTypeAssignment

						TraverseCommon (p_ParameterizedAssignment.m_ParameterizedTypeAssignment);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_2:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedValueAssignment

						TraverseCommon (p_ParameterizedAssignment.m_ParameterizedValueAssignment);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_3:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedValueSetTypeAssignment

						TraverseCommon (p_ParameterizedAssignment.m_ParameterizedValueSetTypeAssignment);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_4:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectClassAssignment

						TraverseCommon (p_ParameterizedAssignment.m_ParameterizedObjectClassAssignment);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_5:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectAssignment

						TraverseCommon (p_ParameterizedAssignment.m_ParameterizedObjectAssignment);
				break;
				case ParameterizedAssignment.production_kind.g_ParameterizedAssignment_6:
					// traverse syntax tree node associated with production
					// ParameterizedAssignment: ParameterizedObjectSetAssignment

						TraverseCommon (p_ParameterizedAssignment.m_ParameterizedObjectSetAssignment);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedAssignment);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedAssignment

		//
		// create syntax tree node associated with production
		// ParameterizedAssignment: ParameterizedTypeAssignment

		//

		public ParameterizedAssignment ParameterizedAssignment_1 (ParameterizedTypeAssignment p_ParameterizedTypeAssignment)
		{
			ParameterizedAssignment p_ParameterizedAssignment_ref = new ParameterizedAssignment(p_ParameterizedTypeAssignment);
			p_ParameterizedTypeAssignment.parent = p_ParameterizedAssignment_ref;
			Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedAssignment.production_kind.g_ParameterizedAssignment_1, p_ParameterizedAssignment_ref);
			return p_ParameterizedAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// ParameterizedAssignment: ParameterizedValueAssignment

		//

		public ParameterizedAssignment ParameterizedAssignment_2 (ParameterizedValueAssignment p_ParameterizedValueAssignment)
		{
			ParameterizedAssignment p_ParameterizedAssignment_ref = new ParameterizedAssignment(p_ParameterizedValueAssignment);
			p_ParameterizedValueAssignment.parent = p_ParameterizedAssignment_ref;
			Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedAssignment.production_kind.g_ParameterizedAssignment_2, p_ParameterizedAssignment_ref);
			return p_ParameterizedAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// ParameterizedAssignment: ParameterizedValueSetTypeAssignment

		//

		public ParameterizedAssignment ParameterizedAssignment_3 (ParameterizedValueSetTypeAssignment p_ParameterizedValueSetTypeAssignment)
		{
			ParameterizedAssignment p_ParameterizedAssignment_ref = new ParameterizedAssignment(p_ParameterizedValueSetTypeAssignment);
			p_ParameterizedValueSetTypeAssignment.parent = p_ParameterizedAssignment_ref;
			Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedAssignment.production_kind.g_ParameterizedAssignment_3, p_ParameterizedAssignment_ref);
			return p_ParameterizedAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// ParameterizedAssignment: ParameterizedObjectClassAssignment

		//

		public ParameterizedAssignment ParameterizedAssignment_4 (ParameterizedObjectClassAssignment p_ParameterizedObjectClassAssignment)
		{
			ParameterizedAssignment p_ParameterizedAssignment_ref = new ParameterizedAssignment(p_ParameterizedObjectClassAssignment);
			p_ParameterizedObjectClassAssignment.parent = p_ParameterizedAssignment_ref;
			Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedAssignment.production_kind.g_ParameterizedAssignment_4, p_ParameterizedAssignment_ref);
			return p_ParameterizedAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// ParameterizedAssignment: ParameterizedObjectAssignment

		//

		public ParameterizedAssignment ParameterizedAssignment_5 (ParameterizedObjectAssignment p_ParameterizedObjectAssignment)
		{
			ParameterizedAssignment p_ParameterizedAssignment_ref = new ParameterizedAssignment(p_ParameterizedObjectAssignment);
			p_ParameterizedObjectAssignment.parent = p_ParameterizedAssignment_ref;
			Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedAssignment.production_kind.g_ParameterizedAssignment_5, p_ParameterizedAssignment_ref);
			return p_ParameterizedAssignment_ref;
		}

		//
		// create syntax tree node associated with production
		// ParameterizedAssignment: ParameterizedObjectSetAssignment

		//

		public ParameterizedAssignment ParameterizedAssignment_6 (ParameterizedObjectSetAssignment p_ParameterizedObjectSetAssignment)
		{
			ParameterizedAssignment p_ParameterizedAssignment_ref = new ParameterizedAssignment(p_ParameterizedObjectSetAssignment);
			p_ParameterizedObjectSetAssignment.parent = p_ParameterizedAssignment_ref;
			Raise_ParameterizedAssignment_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedAssignment.production_kind.g_ParameterizedAssignment_6, p_ParameterizedAssignment_ref);
			return p_ParameterizedAssignment_ref;
		}
		#endregion
	};
}
