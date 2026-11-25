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
	// class associated with syntax rule TableColumn
	//

	[DataContract]
	public class	TableColumn : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TableColumn
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TableColumn
		{
			g_TableColumn_1 = 1,	// number

		};
		#endregion
		#region production markers associated with the syntax rule TableColumn

		// markers associated with production: TableColumn -> number

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TableColumn

		// Constructor declaration(s) associated with production(s) of syntax rule TableColumn

		//
		// Constructor associated with the following production(s)
		// TableColumn -> number

		//

		public TableColumn (SyntaxTreeToken p_token) : base ((uint) ProductionID._TableColumn_ID, (uint) production_kind.g_TableColumn_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_number = p_token;
		}

		public TableColumn () { }

		// Copy constructor

		public TableColumn (TableColumn p_TableColumn) : base (p_TableColumn.id, p_TableColumn.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TableColumn.appInfo;
			switch ((production_kind) p_TableColumn.kind)
			{
				case production_kind.g_TableColumn_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_number = (p_TableColumn.m_number != null) ? new SyntaxTreeToken (p_TableColumn.m_number) : null) != null) m_number.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TableColumn" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TableColumn (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_number?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TableColumn

		// Content changing function(s) associated with production(s) of syntax rule TableColumn

		//
		// Content changing function associated with following production(s)
		// TableColumn -> number

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_TableColumn_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_number = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TableColumn
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TableColumn

		//
		// emit production tree node associated with any production of syntax rule TableColumn
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_TableColumn_1:
					// emit syntax tree node associated with production
					// TableColumn: number

					s += m_number.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TableColumn
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "TableColumn (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_TableColumn_1:
					// emit syntax tree node associated with production
					// TableColumn: number

					s += "number";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TableColumn

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TableColumn with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			TableColumn.production_kind kind = (TableColumn.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case TableColumn.production_kind.g_TableColumn_1:
					// traverse syntax tree node associated with production
					// TableColumn: number

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
		// initialize object associated with syntax rule TableColumn
		//

		public void _init ()
		{
			m_number = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TableColumn

		// counter of all nodes associated with syntax rule TableColumn
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TableColumn
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TableColumn

		// delegate function (callback) prototype associated with syntax rule TableColumn
		public delegate bool TableColumn_Callback (SyntaxTreeCallbackReason reason, TableColumn.production_kind kind, TableColumn p_TableColumn);

		// event associated with syntax rule TableColumn
		public event TableColumn_Callback TableColumn_Event;

		// event trigger associated with syntax rule TableColumn
		public bool Raise_TableColumn_Event (SyntaxTreeCallbackReason reason, TableColumn.production_kind kind, TableColumn p_TableColumn)
		{
			bool? status = TableColumn_Event?.Invoke (reason, kind, p_TableColumn);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TableColumn
		//
		// traverse syntax tree node associated with any production of syntax rule TableColumn
		//

		public void Traverse (TableColumn p_TableColumn)
		{
			if (p_TableColumn.isLocked())
				return;
			p_TableColumn.dolock();
			TableColumn.production_kind kind = (TableColumn.production_kind) p_TableColumn.kind;
			p_TableColumn.turn_reset ();
			if (Raise_TableColumn_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_TableColumn))
			switch (kind)
			{
				case TableColumn.production_kind.g_TableColumn_1:
					// traverse syntax tree node associated with production
					// TableColumn: number

				break;
			}
			Raise_TableColumn_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_TableColumn);
			p_TableColumn.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TableColumn
		//

		public void TraverseCommon (TableColumn p_TableColumn)
		{
			TableColumn.production_kind kind = (TableColumn.production_kind) p_TableColumn.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_TableColumn))
			switch (kind)
			{
				case TableColumn.production_kind.g_TableColumn_1:
					// traverse syntax tree node associated with production
					// TableColumn: number

						TraverseCommon (p_TableColumn.m_number);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_TableColumn);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TableColumn

		//
		// create syntax tree node associated with production
		// TableColumn: number

		//

		public TableColumn TableColumn_1 (SyntaxTreeToken p_token)
		{
			TableColumn p_TableColumn_ref = new TableColumn(p_token);
			p_token.parent = p_TableColumn_ref;
			Raise_TableColumn_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TableColumn.production_kind.g_TableColumn_1, p_TableColumn_ref);
			return p_TableColumn_ref;
		}
		#endregion
	};
}
