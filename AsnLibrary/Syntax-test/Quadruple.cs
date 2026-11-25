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
	// class associated with syntax rule Quadruple
	//

	[DataContract]
	public class	Quadruple : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Quadruple
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Quadruple
		{
			g_Quadruple_1 = 1,	// "{" Group "," Plane "," Row "," Cell "}"

		};
		#endregion
		#region production markers associated with the syntax rule Quadruple

		// markers associated with production: Quadruple -> "{" Group "," Plane "," Row "," Cell "}"

		public enum production_marker_1 : ushort
		{
			m_Group,
			m_Plane,
			m_Row,
			m_Cell,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Quadruple

		// Constructor declaration(s) associated with production(s) of syntax rule Quadruple

		//
		// Constructor associated with the following production(s)
		// Quadruple -> "{" Group "," Plane "," Row "," Cell "}"

		//

		public Quadruple (SyntaxTreeToken p_token, Group p_Group, SyntaxTreeToken p_token_1, Plane p_Plane, SyntaxTreeToken p_token_2, Row p_Row, SyntaxTreeToken p_token_3, Cell p_Cell, SyntaxTreeToken p_token_4) : base ((uint) ProductionID._Quadruple_ID, (uint) production_kind.g_Quadruple_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 9);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_Group = p_Group;
			children[2] = m_comma = p_token_1;
			children[3] = m_Plane = p_Plane;
			children[4] = m_comma_1 = p_token_2;
			children[5] = m_Row = p_Row;
			children[6] = m_comma_2 = p_token_3;
			children[7] = m_Cell = p_Cell;
			children[8] = m_right_curly_bracket = p_token_4;
		}

		public Quadruple () { }

		// Copy constructor

		public Quadruple (Quadruple p_Quadruple) : base (p_Quadruple.id, p_Quadruple.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Quadruple.appInfo;
			switch ((production_kind) p_Quadruple.kind)
			{
				case production_kind.g_Quadruple_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 9);
					if ((children [0] = m_left_curly_bracket = (p_Quadruple.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_Quadruple.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_Group = (p_Quadruple.m_Group != null) ? new Group (p_Quadruple.m_Group) : null) != null) m_Group.parent = this;
					if ((children [2] = m_comma = (p_Quadruple.m_comma != null) ? new SyntaxTreeToken (p_Quadruple.m_comma) : null) != null) m_comma.parent = this;
					if ((children [3] = m_Plane = (p_Quadruple.m_Plane != null) ? new Plane (p_Quadruple.m_Plane) : null) != null) m_Plane.parent = this;
					if ((children [4] = m_comma_1 = (p_Quadruple.m_comma_1 != null) ? new SyntaxTreeToken (p_Quadruple.m_comma_1) : null) != null) m_comma_1.parent = this;
					if ((children [5] = m_Row = (p_Quadruple.m_Row != null) ? new Row (p_Quadruple.m_Row) : null) != null) m_Row.parent = this;
					if ((children [6] = m_comma_2 = (p_Quadruple.m_comma_2 != null) ? new SyntaxTreeToken (p_Quadruple.m_comma_2) : null) != null) m_comma_2.parent = this;
					if ((children [7] = m_Cell = (p_Quadruple.m_Cell != null) ? new Cell (p_Quadruple.m_Cell) : null) != null) m_Cell.parent = this;
					if ((children [8] = m_right_curly_bracket = (p_Quadruple.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_Quadruple.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Quadruple" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Quadruple (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_Group?.Dispose ();
			m_comma?.Dispose ();
			m_comma_1?.Dispose ();
			m_comma_2?.Dispose ();
			m_Plane?.Dispose ();
			m_Row?.Dispose ();
			m_Cell?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Quadruple

		// Content changing function(s) associated with production(s) of syntax rule Quadruple

		//
		// Content changing function associated with following production(s)
		// Quadruple -> "{" Group "," Plane "," Row "," Cell "}"

		//

		public void change(SyntaxTreeToken p_token, Group p_Group, SyntaxTreeToken p_token_1, Plane p_Plane, SyntaxTreeToken p_token_2, Row p_Row, SyntaxTreeToken p_token_3, Cell p_Cell, SyntaxTreeToken p_token_4)
		{
			_init ();
			this.kind = (uint) production_kind.g_Quadruple_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 9);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_Group = p_Group;
			children [2] = m_comma = p_token_1;
			children [3] = m_Plane = p_Plane;
			children [4] = m_comma_1 = p_token_2;
			children [5] = m_Row = p_Row;
			children [6] = m_comma_2 = p_token_3;
			children [7] = m_Cell = p_Cell;
			children [8] = m_right_curly_bracket = p_token_4;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Quadruple
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_Group != null) && m_Group.checkInclusion (element) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				(m_comma_1 != null) && m_comma_1.checkInclusion (element) ||
				(m_comma_2 != null) && m_comma_2.checkInclusion (element) ||
				(m_Plane != null) && m_Plane.checkInclusion (element) ||
				(m_Row != null) && m_Row.checkInclusion (element) ||
				(m_Cell != null) && m_Cell.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Quadruple

		//
		// emit production tree node associated with any production of syntax rule Quadruple
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Quadruple_1:
					// emit syntax tree node associated with production
					// Quadruple: "{" Group "," Plane "," Row "," Cell "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_Group.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_Plane.Emit (depth - 1);
					s += " ";
					s += m_comma_1.Emit (depth - 1);
					s += " ";
					s += m_Row.Emit (depth - 1);
					s += " ";
					s += m_comma_2.Emit (depth - 1);
					s += " ";
					s += m_Cell.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Quadruple
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Quadruple (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Quadruple_1:
					// emit syntax tree node associated with production
					// Quadruple: "{" Group "," Plane "," Row "," Cell "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_Group.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += m_Plane.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += m_Row.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += m_Cell.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Quadruple

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Quadruple with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Quadruple.production_kind kind = (Quadruple.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Quadruple.production_kind.g_Quadruple_1:
					// traverse syntax tree node associated with production
					// Quadruple: "{" Group "," Plane "," Row "," Cell "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_Group.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
						m_Plane.Visit (visitor, appData);
						m_comma_1.Visit (visitor, appData);
						m_Row.Visit (visitor, appData);
						m_comma_2.Visit (visitor, appData);
						m_Cell.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_left_curly_bracket?.reparent (this);
			m_Group?.reparent (this);
			m_comma?.reparent (this);
			m_comma_1?.reparent (this);

			m_comma_2?.reparent (this);

			m_Plane?.reparent (this);
			m_Row?.reparent (this);
			m_Cell?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Quadruple
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_Group = null;
			m_comma = null;
			m_comma_1 = null;
			m_comma_2 = null;
			m_Plane = null;
			m_Row = null;
			m_Cell = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Quadruple

		// counter of all nodes associated with syntax rule Quadruple
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Quadruple
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_Group")] public Group m_Group { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		[DataMember (Name = "m_comma_1")] public SyntaxTreeToken m_comma_1 { get; private set; }
		[DataMember (Name = "m_comma_2")] public SyntaxTreeToken m_comma_2 { get; private set; }
		[DataMember (Name = "m_Plane")] public Plane m_Plane { get; private set; }
		[DataMember (Name = "m_Row")] public Row m_Row { get; private set; }
		[DataMember (Name = "m_Cell")] public Cell m_Cell { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Quadruple

		// delegate function (callback) prototype associated with syntax rule Quadruple
		public delegate bool Quadruple_Callback (SyntaxTreeCallbackReason reason, Quadruple.production_kind kind, Quadruple p_Quadruple);

		// event associated with syntax rule Quadruple
		public event Quadruple_Callback Quadruple_Event;

		// event trigger associated with syntax rule Quadruple
		public bool Raise_Quadruple_Event (SyntaxTreeCallbackReason reason, Quadruple.production_kind kind, Quadruple p_Quadruple)
		{
			bool? status = Quadruple_Event?.Invoke (reason, kind, p_Quadruple);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Quadruple
		//
		// traverse syntax tree node associated with any production of syntax rule Quadruple
		//

		public void Traverse (Quadruple p_Quadruple)
		{
			if (p_Quadruple.isLocked())
				return;
			p_Quadruple.dolock();
			Quadruple.production_kind kind = (Quadruple.production_kind) p_Quadruple.kind;
			p_Quadruple.turn_reset ();
			if (Raise_Quadruple_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Quadruple))
			switch (kind)
			{
				case Quadruple.production_kind.g_Quadruple_1:
					// traverse syntax tree node associated with production
					// Quadruple: "{" Group "," Plane "," Row "," Cell "}"

					if (Raise_Quadruple_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Quadruple))
						Traverse (p_Quadruple.m_Group);
					p_Quadruple.turn_inc ();
					if (Raise_Quadruple_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Quadruple))
						Traverse (p_Quadruple.m_Plane);
					p_Quadruple.turn_inc ();
					if (Raise_Quadruple_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Quadruple))
						Traverse (p_Quadruple.m_Row);
					p_Quadruple.turn_inc ();
					if (Raise_Quadruple_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Quadruple))
						Traverse (p_Quadruple.m_Cell);
					p_Quadruple.turn_inc ();
					Raise_Quadruple_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Quadruple);
				break;
			}
			Raise_Quadruple_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Quadruple);
			p_Quadruple.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Quadruple
		//

		public void TraverseCommon (Quadruple p_Quadruple)
		{
			Quadruple.production_kind kind = (Quadruple.production_kind) p_Quadruple.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Quadruple))
			switch (kind)
			{
				case Quadruple.production_kind.g_Quadruple_1:
					// traverse syntax tree node associated with production
					// Quadruple: "{" Group "," Plane "," Row "," Cell "}"

						TraverseCommon (p_Quadruple.m_left_curly_bracket);
						TraverseCommon (p_Quadruple.m_Group);
						TraverseCommon (p_Quadruple.m_comma);
						TraverseCommon (p_Quadruple.m_Plane);
						TraverseCommon (p_Quadruple.m_comma_1);
						TraverseCommon (p_Quadruple.m_Row);
						TraverseCommon (p_Quadruple.m_comma_2);
						TraverseCommon (p_Quadruple.m_Cell);
						TraverseCommon (p_Quadruple.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Quadruple);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Quadruple

		//
		// create syntax tree node associated with production
		// Quadruple: "{" Group "," Plane "," Row "," Cell "}"

		//

		public Quadruple Quadruple_1 (SyntaxTreeToken p_token, Group p_Group, SyntaxTreeToken p_token_1, Plane p_Plane, SyntaxTreeToken p_token_2, Row p_Row, SyntaxTreeToken p_token_3, Cell p_Cell, SyntaxTreeToken p_token_4)
		{
			Quadruple p_Quadruple_ref = new Quadruple(p_token, p_Group, p_token_1, p_Plane, p_token_2, p_Row, p_token_3, p_Cell, p_token_4);
			p_token.parent = p_Quadruple_ref;
			p_Group.parent = p_Quadruple_ref;
			p_token_1.parent = p_Quadruple_ref;
			p_Plane.parent = p_Quadruple_ref;
			p_token_2.parent = p_Quadruple_ref;
			p_Row.parent = p_Quadruple_ref;
			p_token_3.parent = p_Quadruple_ref;
			p_Cell.parent = p_Quadruple_ref;
			p_token_4.parent = p_Quadruple_ref;
			Raise_Quadruple_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Quadruple.production_kind.g_Quadruple_1, p_Quadruple_ref);
			return p_Quadruple_ref;
		}
		#endregion
	};
}
