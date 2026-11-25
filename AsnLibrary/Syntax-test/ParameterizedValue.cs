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
	// class associated with syntax rule ParameterizedValue
	//

	[DataContract]
	public class	ParameterizedValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ParameterizedValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ParameterizedValue
		{
			g_ParameterizedValue_1 = 1,	// SimpleDefinedValue ActualParameterList

		};
		#endregion
		#region production markers associated with the syntax rule ParameterizedValue

		// markers associated with production: ParameterizedValue -> SimpleDefinedValue ActualParameterList

		public enum production_marker_1 : ushort
		{
			m_SimpleDefinedValue,
			m_ActualParameterList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ParameterizedValue

		// Constructor declaration(s) associated with production(s) of syntax rule ParameterizedValue

		//
		// Constructor associated with the following production(s)
		// ParameterizedValue -> SimpleDefinedValue ActualParameterList

		//

		public ParameterizedValue (SimpleDefinedValue p_SimpleDefinedValue, ActualParameterList p_ActualParameterList) : base ((uint) ProductionID._ParameterizedValue_ID, (uint) production_kind.g_ParameterizedValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_SimpleDefinedValue = p_SimpleDefinedValue;
			children[1] = m_ActualParameterList = p_ActualParameterList;
		}

		public ParameterizedValue () { }

		// Copy constructor

		public ParameterizedValue (ParameterizedValue p_ParameterizedValue) : base (p_ParameterizedValue.id, p_ParameterizedValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ParameterizedValue.appInfo;
			switch ((production_kind) p_ParameterizedValue.kind)
			{
				case production_kind.g_ParameterizedValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_SimpleDefinedValue = (p_ParameterizedValue.m_SimpleDefinedValue != null) ? new SimpleDefinedValue (p_ParameterizedValue.m_SimpleDefinedValue) : null) != null) m_SimpleDefinedValue.parent = this;
					if ((children [1] = m_ActualParameterList = (p_ParameterizedValue.m_ActualParameterList != null) ? new ActualParameterList (p_ParameterizedValue.m_ActualParameterList) : null) != null) m_ActualParameterList.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ParameterizedValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ParameterizedValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SimpleDefinedValue?.Dispose ();
			m_ActualParameterList?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ParameterizedValue

		// Content changing function(s) associated with production(s) of syntax rule ParameterizedValue

		//
		// Content changing function associated with following production(s)
		// ParameterizedValue -> SimpleDefinedValue ActualParameterList

		//

		public void change(SimpleDefinedValue p_SimpleDefinedValue, ActualParameterList p_ActualParameterList)
		{
			_init ();
			this.kind = (uint) production_kind.g_ParameterizedValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_SimpleDefinedValue = p_SimpleDefinedValue;
			children [1] = m_ActualParameterList = p_ActualParameterList;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ParameterizedValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SimpleDefinedValue != null) && m_SimpleDefinedValue.checkInclusion (element) ||
				(m_ActualParameterList != null) && m_ActualParameterList.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ParameterizedValue

		//
		// emit production tree node associated with any production of syntax rule ParameterizedValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ParameterizedValue_1:
					// emit syntax tree node associated with production
					// ParameterizedValue: SimpleDefinedValue ActualParameterList

					s += m_SimpleDefinedValue.Emit (depth - 1);
					s += " ";
					s += m_ActualParameterList.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ParameterizedValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ParameterizedValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ParameterizedValue_1:
					// emit syntax tree node associated with production
					// ParameterizedValue: SimpleDefinedValue ActualParameterList

					s += m_SimpleDefinedValue.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ActualParameterList.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ParameterizedValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ParameterizedValue.production_kind kind = (ParameterizedValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ParameterizedValue.production_kind.g_ParameterizedValue_1:
					// traverse syntax tree node associated with production
					// ParameterizedValue: SimpleDefinedValue ActualParameterList

						m_SimpleDefinedValue.Visit (visitor, appData);
						m_ActualParameterList.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SimpleDefinedValue?.reparent (this);
			m_ActualParameterList?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ParameterizedValue
		//

		public void _init ()
		{
			m_SimpleDefinedValue = null;
			m_ActualParameterList = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ParameterizedValue

		// counter of all nodes associated with syntax rule ParameterizedValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ParameterizedValue
		[DataMember (Name = "m_SimpleDefinedValue")] public SimpleDefinedValue m_SimpleDefinedValue { get; private set; }
		[DataMember (Name = "m_ActualParameterList")] public ActualParameterList m_ActualParameterList { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ParameterizedValue

		// delegate function (callback) prototype associated with syntax rule ParameterizedValue
		public delegate bool ParameterizedValue_Callback (SyntaxTreeCallbackReason reason, ParameterizedValue.production_kind kind, ParameterizedValue p_ParameterizedValue);

		// event associated with syntax rule ParameterizedValue
		public event ParameterizedValue_Callback ParameterizedValue_Event;

		// event trigger associated with syntax rule ParameterizedValue
		public bool Raise_ParameterizedValue_Event (SyntaxTreeCallbackReason reason, ParameterizedValue.production_kind kind, ParameterizedValue p_ParameterizedValue)
		{
			bool? status = ParameterizedValue_Event?.Invoke (reason, kind, p_ParameterizedValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ParameterizedValue
		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedValue
		//

		public void Traverse (ParameterizedValue p_ParameterizedValue)
		{
			if (p_ParameterizedValue.isLocked())
				return;
			p_ParameterizedValue.dolock();
			ParameterizedValue.production_kind kind = (ParameterizedValue.production_kind) p_ParameterizedValue.kind;
			p_ParameterizedValue.turn_reset ();
			if (Raise_ParameterizedValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ParameterizedValue))
			switch (kind)
			{
				case ParameterizedValue.production_kind.g_ParameterizedValue_1:
					// traverse syntax tree node associated with production
					// ParameterizedValue: SimpleDefinedValue ActualParameterList

					if (Raise_ParameterizedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValue))
						Traverse (p_ParameterizedValue.m_SimpleDefinedValue);
					p_ParameterizedValue.turn_inc ();
					if (Raise_ParameterizedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValue))
						Traverse (p_ParameterizedValue.m_ActualParameterList);
					p_ParameterizedValue.turn_inc ();
					Raise_ParameterizedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ParameterizedValue);
				break;
			}
			Raise_ParameterizedValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ParameterizedValue);
			p_ParameterizedValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ParameterizedValue
		//

		public void TraverseCommon (ParameterizedValue p_ParameterizedValue)
		{
			ParameterizedValue.production_kind kind = (ParameterizedValue.production_kind) p_ParameterizedValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ParameterizedValue))
			switch (kind)
			{
				case ParameterizedValue.production_kind.g_ParameterizedValue_1:
					// traverse syntax tree node associated with production
					// ParameterizedValue: SimpleDefinedValue ActualParameterList

						TraverseCommon (p_ParameterizedValue.m_SimpleDefinedValue);
						TraverseCommon (p_ParameterizedValue.m_ActualParameterList);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ParameterizedValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ParameterizedValue

		//
		// create syntax tree node associated with production
		// ParameterizedValue: SimpleDefinedValue ActualParameterList

		//

		public ParameterizedValue ParameterizedValue_1 (SimpleDefinedValue p_SimpleDefinedValue, ActualParameterList p_ActualParameterList)
		{
			ParameterizedValue p_ParameterizedValue_ref = new ParameterizedValue(p_SimpleDefinedValue, p_ActualParameterList);
			p_SimpleDefinedValue.parent = p_ParameterizedValue_ref;
			p_ActualParameterList.parent = p_ParameterizedValue_ref;
			Raise_ParameterizedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ParameterizedValue.production_kind.g_ParameterizedValue_1, p_ParameterizedValue_ref);
			return p_ParameterizedValue_ref;
		}
		#endregion
	};
}
