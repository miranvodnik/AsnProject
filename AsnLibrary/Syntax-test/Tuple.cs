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
	// class associated with syntax rule Tuple
	//

	[DataContract]
	public class	Tuple : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Tuple
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Tuple
		{
			g_Tuple_1 = 1,	// "{" TableColumn "," TableRow "}"

		};
		#endregion
		#region production markers associated with the syntax rule Tuple

		// markers associated with production: Tuple -> "{" TableColumn "," TableRow "}"

		public enum production_marker_1 : ushort
		{
			m_TableColumn,
			m_TableRow,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Tuple

		// Constructor declaration(s) associated with production(s) of syntax rule Tuple

		//
		// Constructor associated with the following production(s)
		// Tuple -> "{" TableColumn "," TableRow "}"

		//

		public Tuple (SyntaxTreeToken p_token, TableColumn p_TableColumn, SyntaxTreeToken p_token_1, TableRow p_TableRow, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._Tuple_ID, (uint) production_kind.g_Tuple_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_TableColumn = p_TableColumn;
			children[2] = m_comma = p_token_1;
			children[3] = m_TableRow = p_TableRow;
			children[4] = m_right_curly_bracket = p_token_2;
		}

		public Tuple () { }

		// Copy constructor

		public Tuple (Tuple p_Tuple) : base (p_Tuple.id, p_Tuple.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Tuple.appInfo;
			switch ((production_kind) p_Tuple.kind)
			{
				case production_kind.g_Tuple_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_left_curly_bracket = (p_Tuple.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_Tuple.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_TableColumn = (p_Tuple.m_TableColumn != null) ? new TableColumn (p_Tuple.m_TableColumn) : null) != null) m_TableColumn.parent = this;
					if ((children [2] = m_comma = (p_Tuple.m_comma != null) ? new SyntaxTreeToken (p_Tuple.m_comma) : null) != null) m_comma.parent = this;
					if ((children [3] = m_TableRow = (p_Tuple.m_TableRow != null) ? new TableRow (p_Tuple.m_TableRow) : null) != null) m_TableRow.parent = this;
					if ((children [4] = m_right_curly_bracket = (p_Tuple.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_Tuple.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Tuple" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Tuple (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_TableColumn?.Dispose ();
			m_comma?.Dispose ();
			m_TableRow?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Tuple

		// Content changing function(s) associated with production(s) of syntax rule Tuple

		//
		// Content changing function associated with following production(s)
		// Tuple -> "{" TableColumn "," TableRow "}"

		//

		public void change(SyntaxTreeToken p_token, TableColumn p_TableColumn, SyntaxTreeToken p_token_1, TableRow p_TableRow, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_Tuple_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_TableColumn = p_TableColumn;
			children [2] = m_comma = p_token_1;
			children [3] = m_TableRow = p_TableRow;
			children [4] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Tuple
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_TableColumn != null) && m_TableColumn.checkInclusion (element) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				(m_TableRow != null) && m_TableRow.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Tuple

		//
		// emit production tree node associated with any production of syntax rule Tuple
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Tuple_1:
					// emit syntax tree node associated with production
					// Tuple: "{" TableColumn "," TableRow "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_TableColumn.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_TableRow.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Tuple
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Tuple (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Tuple_1:
					// emit syntax tree node associated with production
					// Tuple: "{" TableColumn "," TableRow "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_TableColumn.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += m_TableRow.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Tuple

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Tuple with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Tuple.production_kind kind = (Tuple.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Tuple.production_kind.g_Tuple_1:
					// traverse syntax tree node associated with production
					// Tuple: "{" TableColumn "," TableRow "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_TableColumn.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
						m_TableRow.Visit (visitor, appData);
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
			m_TableColumn?.reparent (this);
			m_comma?.reparent (this);
			m_TableRow?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Tuple
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_TableColumn = null;
			m_comma = null;
			m_TableRow = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Tuple

		// counter of all nodes associated with syntax rule Tuple
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Tuple
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_TableColumn")] public TableColumn m_TableColumn { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		[DataMember (Name = "m_TableRow")] public TableRow m_TableRow { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Tuple

		// delegate function (callback) prototype associated with syntax rule Tuple
		public delegate bool Tuple_Callback (SyntaxTreeCallbackReason reason, Tuple.production_kind kind, Tuple p_Tuple);

		// event associated with syntax rule Tuple
		public event Tuple_Callback Tuple_Event;

		// event trigger associated with syntax rule Tuple
		public bool Raise_Tuple_Event (SyntaxTreeCallbackReason reason, Tuple.production_kind kind, Tuple p_Tuple)
		{
			bool? status = Tuple_Event?.Invoke (reason, kind, p_Tuple);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Tuple
		//
		// traverse syntax tree node associated with any production of syntax rule Tuple
		//

		public void Traverse (Tuple p_Tuple)
		{
			if (p_Tuple.isLocked())
				return;
			p_Tuple.dolock();
			Tuple.production_kind kind = (Tuple.production_kind) p_Tuple.kind;
			p_Tuple.turn_reset ();
			if (Raise_Tuple_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Tuple))
			switch (kind)
			{
				case Tuple.production_kind.g_Tuple_1:
					// traverse syntax tree node associated with production
					// Tuple: "{" TableColumn "," TableRow "}"

					if (Raise_Tuple_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Tuple))
						Traverse (p_Tuple.m_TableColumn);
					p_Tuple.turn_inc ();
					if (Raise_Tuple_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Tuple))
						Traverse (p_Tuple.m_TableRow);
					p_Tuple.turn_inc ();
					Raise_Tuple_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Tuple);
				break;
			}
			Raise_Tuple_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Tuple);
			p_Tuple.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Tuple
		//

		public void TraverseCommon (Tuple p_Tuple)
		{
			Tuple.production_kind kind = (Tuple.production_kind) p_Tuple.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Tuple))
			switch (kind)
			{
				case Tuple.production_kind.g_Tuple_1:
					// traverse syntax tree node associated with production
					// Tuple: "{" TableColumn "," TableRow "}"

						TraverseCommon (p_Tuple.m_left_curly_bracket);
						TraverseCommon (p_Tuple.m_TableColumn);
						TraverseCommon (p_Tuple.m_comma);
						TraverseCommon (p_Tuple.m_TableRow);
						TraverseCommon (p_Tuple.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Tuple);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Tuple

		//
		// create syntax tree node associated with production
		// Tuple: "{" TableColumn "," TableRow "}"

		//

		public Tuple Tuple_1 (SyntaxTreeToken p_token, TableColumn p_TableColumn, SyntaxTreeToken p_token_1, TableRow p_TableRow, SyntaxTreeToken p_token_2)
		{
			Tuple p_Tuple_ref = new Tuple(p_token, p_TableColumn, p_token_1, p_TableRow, p_token_2);
			p_token.parent = p_Tuple_ref;
			p_TableColumn.parent = p_Tuple_ref;
			p_token_1.parent = p_Tuple_ref;
			p_TableRow.parent = p_Tuple_ref;
			p_token_2.parent = p_Tuple_ref;
			Raise_Tuple_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Tuple.production_kind.g_Tuple_1, p_Tuple_ref);
			return p_Tuple_ref;
		}
		#endregion
	};
}
