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
	// class associated with syntax rule AC-BitsValue
	//

	[DataContract]
	public class	AC_BitsValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule AC-BitsValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule AC-BitsValue
		{
			g_AC_BitsValue_1 = 1,	// AC-BitNames

			g_AC_BitsValue_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule AC-BitsValue

		// markers associated with production: AC-BitsValue -> AC-BitNames

		public enum production_marker_1 : ushort
		{
			m_AC_BitNames,
			final
		};

		// markers associated with production: AC-BitsValue -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule AC-BitsValue

		// Constructor declaration(s) associated with production(s) of syntax rule AC-BitsValue

		//
		// Constructor associated with the following production(s)
		// AC-BitsValue -> AC-BitNames

		//

		public AC_BitsValue (AC_BitNames p_AC_BitNames) : base ((uint) ProductionID._AC_BitsValue_ID, (uint) production_kind.g_AC_BitsValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_AC_BitNames = p_AC_BitNames;
		}

		//
		// Constructor associated with the following production(s)
		// AC-BitsValue -> %empty

		//

		public AC_BitsValue () : base ((uint) ProductionID._AC_BitsValue_ID, (uint) production_kind.g_AC_BitsValue_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public AC_BitsValue (AC_BitsValue p_AC_BitsValue) : base (p_AC_BitsValue.id, p_AC_BitsValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_AC_BitsValue.appInfo;
			switch ((production_kind) p_AC_BitsValue.kind)
			{
				case production_kind.g_AC_BitsValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_AC_BitNames = (p_AC_BitsValue.m_AC_BitNames != null) ? new AC_BitNames (p_AC_BitsValue.m_AC_BitNames) : null) != null) m_AC_BitNames.parent = this;
					break;
				case production_kind.g_AC_BitsValue_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "AC_BitsValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new AC_BitsValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_AC_BitNames?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule AC-BitsValue

		// Content changing function(s) associated with production(s) of syntax rule AC-BitsValue

		//
		// Content changing function associated with following production(s)
		// AC-BitsValue -> AC-BitNames

		//

		public void change(AC_BitNames p_AC_BitNames)
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_BitsValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_AC_BitNames = p_AC_BitNames;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// AC-BitsValue -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_AC_BitsValue_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule AC-BitsValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_AC_BitNames != null) && m_AC_BitNames.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule AC-BitsValue

		//
		// emit production tree node associated with any production of syntax rule AC-BitsValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_AC_BitsValue_1:
					// emit syntax tree node associated with production
					// AC-BitsValue: AC-BitNames

					s += m_AC_BitNames.Emit (depth - 1);
				break;
				case production_kind.g_AC_BitsValue_2:
					// emit syntax tree node associated with production
					// AC-BitsValue: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule AC-BitsValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "AC_BitsValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_AC_BitsValue_1:
					// emit syntax tree node associated with production
					// AC-BitsValue: AC-BitNames

					s += m_AC_BitNames.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_AC_BitsValue_2:
					// emit syntax tree node associated with production
					// AC-BitsValue: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule AC-BitsValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule AC-BitsValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			AC_BitsValue.production_kind kind = (AC_BitsValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case AC_BitsValue.production_kind.g_AC_BitsValue_1:
					// traverse syntax tree node associated with production
					// AC-BitsValue: AC-BitNames

						m_AC_BitNames.Visit (visitor, appData);
				break;
				case AC_BitsValue.production_kind.g_AC_BitsValue_2:
					// traverse syntax tree node associated with production
					// AC-BitsValue: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_AC_BitNames?.reparent (this);
		}

		//
		// initialize object associated with syntax rule AC-BitsValue
		//

		public void _init ()
		{
			m_AC_BitNames = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule AC-BitsValue

		// counter of all nodes associated with syntax rule AC-BitsValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule AC-BitsValue
		[DataMember (Name = "m_AC_BitNames")] public AC_BitNames m_AC_BitNames { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule AC-BitsValue

		// delegate function (callback) prototype associated with syntax rule AC-BitsValue
		public delegate bool AC_BitsValue_Callback (SyntaxTreeCallbackReason reason, AC_BitsValue.production_kind kind, AC_BitsValue p_AC_BitsValue);

		// event associated with syntax rule AC-BitsValue
		public event AC_BitsValue_Callback AC_BitsValue_Event;

		// event trigger associated with syntax rule AC-BitsValue
		public bool Raise_AC_BitsValue_Event (SyntaxTreeCallbackReason reason, AC_BitsValue.production_kind kind, AC_BitsValue p_AC_BitsValue)
		{
			bool? status = AC_BitsValue_Event?.Invoke (reason, kind, p_AC_BitsValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule AC-BitsValue
		//
		// traverse syntax tree node associated with any production of syntax rule AC-BitsValue
		//

		public void Traverse (AC_BitsValue p_AC_BitsValue)
		{
			if (p_AC_BitsValue.isLocked())
				return;
			p_AC_BitsValue.dolock();
			AC_BitsValue.production_kind kind = (AC_BitsValue.production_kind) p_AC_BitsValue.kind;
			p_AC_BitsValue.turn_reset ();
			if (Raise_AC_BitsValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_AC_BitsValue))
			switch (kind)
			{
				case AC_BitsValue.production_kind.g_AC_BitsValue_1:
					// traverse syntax tree node associated with production
					// AC-BitsValue: AC-BitNames

					if (Raise_AC_BitsValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_BitsValue))
						Traverse (p_AC_BitsValue.m_AC_BitNames);
					p_AC_BitsValue.turn_inc ();
					Raise_AC_BitsValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_AC_BitsValue);
				break;
				case AC_BitsValue.production_kind.g_AC_BitsValue_2:
					// traverse syntax tree node associated with production
					// AC-BitsValue: %empty

				break;
			}
			Raise_AC_BitsValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_AC_BitsValue);
			p_AC_BitsValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule AC-BitsValue
		//

		public void TraverseCommon (AC_BitsValue p_AC_BitsValue)
		{
			AC_BitsValue.production_kind kind = (AC_BitsValue.production_kind) p_AC_BitsValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_AC_BitsValue))
			switch (kind)
			{
				case AC_BitsValue.production_kind.g_AC_BitsValue_1:
					// traverse syntax tree node associated with production
					// AC-BitsValue: AC-BitNames

						TraverseCommon (p_AC_BitsValue.m_AC_BitNames);
				break;
				case AC_BitsValue.production_kind.g_AC_BitsValue_2:
					// traverse syntax tree node associated with production
					// AC-BitsValue: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_AC_BitsValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule AC-BitsValue

		//
		// create syntax tree node associated with production
		// AC-BitsValue: AC-BitNames

		//

		public AC_BitsValue AC_BitsValue_1 (AC_BitNames p_AC_BitNames)
		{
			AC_BitsValue p_AC_BitsValue_ref = new AC_BitsValue(p_AC_BitNames);
			p_AC_BitNames.parent = p_AC_BitsValue_ref;
			Raise_AC_BitsValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_BitsValue.production_kind.g_AC_BitsValue_1, p_AC_BitsValue_ref);
			return p_AC_BitsValue_ref;
		}

		//
		// create syntax tree node associated with production
		// AC-BitsValue: %empty

		//

		public AC_BitsValue AC_BitsValue_2 ()
		{
			AC_BitsValue p_AC_BitsValue_ref = new AC_BitsValue();
			Raise_AC_BitsValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, AC_BitsValue.production_kind.g_AC_BitsValue_2, p_AC_BitsValue_ref);
			return p_AC_BitsValue_ref;
		}
		#endregion
	};
}
