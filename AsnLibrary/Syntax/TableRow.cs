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
	// class associated with syntax rule TableRow
	//

	[DataContract]
	public class	TableRow : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TableRow
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TableRow
		{
			g_TableRow_1 = 1,	// number

		};
		#endregion
		#region production markers associated with the syntax rule TableRow

		// markers associated with production: TableRow -> number

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TableRow

		// Constructor declaration(s) associated with production(s) of syntax rule TableRow

		//
		// Constructor associated with the following production(s)
		// TableRow -> number

		//

		public TableRow (SyntaxTreeToken p_token) : base ((uint) ProductionID._TableRow_ID, (uint) production_kind.g_TableRow_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_number = p_token;
		}

		public TableRow () { }

		// Copy constructor

		public TableRow (TableRow p_TableRow) : base (p_TableRow.id, p_TableRow.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TableRow.appInfo;
			switch ((production_kind) p_TableRow.kind)
			{
				case production_kind.g_TableRow_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_number = (p_TableRow.m_number != null) ? new SyntaxTreeToken (p_TableRow.m_number) : null) != null) m_number.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TableRow" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TableRow (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_number?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TableRow

		// Content changing function(s) associated with production(s) of syntax rule TableRow

		//
		// Content changing function associated with following production(s)
		// TableRow -> number

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_TableRow_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_number = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TableRow
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TableRow

		//
		// emit production tree node associated with any production of syntax rule TableRow
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TableRow_1:
					// emit syntax tree node associated with production
					// TableRow: number

					s += m_number.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TableRow
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TableRow (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TableRow_1:
					// emit syntax tree node associated with production
					// TableRow: number

					s += "number";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TableRow

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TableRow with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TableRow.production_kind kind = (TableRow.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TableRow.production_kind.g_TableRow_1:
					// traverse syntax tree node associated with production
					// TableRow: number

						m_number.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_number?.reparent (this);
		}

		//
		// initialize object associated with syntax rule TableRow
		//

		public void _init ()
		{
			m_number = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TableRow

		// counter of all nodes associated with syntax rule TableRow
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TableRow
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TableRow

		// delegate function (callback) prototype associated with syntax rule TableRow
		public delegate bool TableRow_Callback (SyntaxTreeCallbackReason reason, TableRow.production_kind kind, TableRow p_TableRow);

		// event associated with syntax rule TableRow
		public event TableRow_Callback TableRow_Event;

		// event trigger associated with syntax rule TableRow
		public bool Raise_TableRow_Event (SyntaxTreeCallbackReason reason, TableRow.production_kind kind, TableRow p_TableRow)
		{
			bool? status = TableRow_Event?.Invoke (reason, kind, p_TableRow);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TableRow
		//
		// traverse syntax tree node associated with any production of syntax rule TableRow
		//

		public void Traverse (TableRow p_TableRow)
		{
			if (p_TableRow.isLocked())
				return;
			p_TableRow.dolock();
			TableRow.production_kind kind = (TableRow.production_kind) p_TableRow.kind;
			p_TableRow.turn_reset ();
			if (Raise_TableRow_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TableRow))
			switch (kind)
			{
				case TableRow.production_kind.g_TableRow_1:
					// traverse syntax tree node associated with production
					// TableRow: number

				break;
			}
			Raise_TableRow_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TableRow);
			p_TableRow.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TableRow
		//

		public void TraverseCommon (TableRow p_TableRow)
		{
			TableRow.production_kind kind = (TableRow.production_kind) p_TableRow.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TableRow))
			switch (kind)
			{
				case TableRow.production_kind.g_TableRow_1:
					// traverse syntax tree node associated with production
					// TableRow: number

						TraverseCommon (p_TableRow.m_number);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TableRow);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TableRow

		//
		// create syntax tree node associated with production
		// TableRow: number

		//

		public TableRow TableRow_1 (SyntaxTreeToken p_token)
		{
			TableRow p_TableRow_ref = new TableRow(p_token);
			p_token.parent = p_TableRow_ref;
			Raise_TableRow_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TableRow.production_kind.g_TableRow_1, p_TableRow_ref);
			return p_TableRow_ref;
		}
		#endregion
	};
}
