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
	// class associated with syntax rule Row
	//

	[DataContract]
	public class	Row : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Row
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Row
		{
			g_Row_1 = 1,	// number

		};
		#endregion
		#region production markers associated with the syntax rule Row

		// markers associated with production: Row -> number

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Row

		// Constructor declaration(s) associated with production(s) of syntax rule Row

		//
		// Constructor associated with the following production(s)
		// Row -> number

		//

		public Row (SyntaxTreeToken p_token) : base ((uint) ProductionID._Row_ID, (uint) production_kind.g_Row_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_number = p_token;
		}

		public Row () { }

		// Copy constructor

		public Row (Row p_Row) : base (p_Row.id, p_Row.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Row.appInfo;
			switch ((production_kind) p_Row.kind)
			{
				case production_kind.g_Row_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_number = (p_Row.m_number != null) ? new SyntaxTreeToken (p_Row.m_number) : null) != null) m_number.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Row" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Row (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_number?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Row

		// Content changing function(s) associated with production(s) of syntax rule Row

		//
		// Content changing function associated with following production(s)
		// Row -> number

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Row_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_number = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Row
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Row

		//
		// emit production tree node associated with any production of syntax rule Row
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Row_1:
					// emit syntax tree node associated with production
					// Row: number

					s += m_number.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Row
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Row (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Row_1:
					// emit syntax tree node associated with production
					// Row: number

					s += "number";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Row

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Row with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Row.production_kind kind = (Row.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Row.production_kind.g_Row_1:
					// traverse syntax tree node associated with production
					// Row: number

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
		// initialize object associated with syntax rule Row
		//

		public void _init ()
		{
			m_number = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Row

		// counter of all nodes associated with syntax rule Row
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Row
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Row

		// delegate function (callback) prototype associated with syntax rule Row
		public delegate bool Row_Callback (SyntaxTreeCallbackReason reason, Row.production_kind kind, Row p_Row);

		// event associated with syntax rule Row
		public event Row_Callback Row_Event;

		// event trigger associated with syntax rule Row
		public bool Raise_Row_Event (SyntaxTreeCallbackReason reason, Row.production_kind kind, Row p_Row)
		{
			bool? status = Row_Event?.Invoke (reason, kind, p_Row);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Row
		//
		// traverse syntax tree node associated with any production of syntax rule Row
		//

		public void Traverse (Row p_Row)
		{
			if (p_Row.isLocked())
				return;
			p_Row.dolock();
			Row.production_kind kind = (Row.production_kind) p_Row.kind;
			p_Row.turn_reset ();
			if (Raise_Row_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Row))
			switch (kind)
			{
				case Row.production_kind.g_Row_1:
					// traverse syntax tree node associated with production
					// Row: number

				break;
			}
			Raise_Row_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Row);
			p_Row.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Row
		//

		public void TraverseCommon (Row p_Row)
		{
			Row.production_kind kind = (Row.production_kind) p_Row.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Row))
			switch (kind)
			{
				case Row.production_kind.g_Row_1:
					// traverse syntax tree node associated with production
					// Row: number

						TraverseCommon (p_Row.m_number);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Row);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Row

		//
		// create syntax tree node associated with production
		// Row: number

		//

		public Row Row_1 (SyntaxTreeToken p_token)
		{
			Row p_Row_ref = new Row(p_token);
			p_token.parent = p_Row_ref;
			Raise_Row_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Row.production_kind.g_Row_1, p_Row_ref);
			return p_Row_ref;
		}
		#endregion
	};
}
