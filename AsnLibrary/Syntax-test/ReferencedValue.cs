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
	// class associated with syntax rule ReferencedValue
	//

	[DataContract]
	public class	ReferencedValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ReferencedValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ReferencedValue
		{
			g_ReferencedValue_1 = 1,	// DefinedValue

			g_ReferencedValue_2 = 2,	// ValueFromObject

		};
		#endregion
		#region production markers associated with the syntax rule ReferencedValue

		// markers associated with production: ReferencedValue -> DefinedValue

		public enum production_marker_1 : ushort
		{
			m_DefinedValue,
			final
		};

		// markers associated with production: ReferencedValue -> ValueFromObject

		public enum production_marker_2 : ushort
		{
			m_ValueFromObject,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ReferencedValue

		// Constructor declaration(s) associated with production(s) of syntax rule ReferencedValue

		//
		// Constructor associated with the following production(s)
		// ReferencedValue -> DefinedValue

		//

		public ReferencedValue (DefinedValue p_DefinedValue) : base ((uint) ProductionID._ReferencedValue_ID, (uint) production_kind.g_ReferencedValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedValue = p_DefinedValue;
		}

		//
		// Constructor associated with the following production(s)
		// ReferencedValue -> ValueFromObject

		//

		public ReferencedValue (ValueFromObject p_ValueFromObject) : base ((uint) ProductionID._ReferencedValue_ID, (uint) production_kind.g_ReferencedValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ValueFromObject = p_ValueFromObject;
		}

		public ReferencedValue () { }

		// Copy constructor

		public ReferencedValue (ReferencedValue p_ReferencedValue) : base (p_ReferencedValue.id, p_ReferencedValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ReferencedValue.appInfo;
			switch ((production_kind) p_ReferencedValue.kind)
			{
				case production_kind.g_ReferencedValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedValue = (p_ReferencedValue.m_DefinedValue != null) ? new DefinedValue (p_ReferencedValue.m_DefinedValue) : null) != null) m_DefinedValue.parent = this;
					break;
				case production_kind.g_ReferencedValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ValueFromObject = (p_ReferencedValue.m_ValueFromObject != null) ? new ValueFromObject (p_ReferencedValue.m_ValueFromObject) : null) != null) m_ValueFromObject.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ReferencedValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ReferencedValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DefinedValue?.Dispose ();
			m_ValueFromObject?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ReferencedValue

		// Content changing function(s) associated with production(s) of syntax rule ReferencedValue

		//
		// Content changing function associated with following production(s)
		// ReferencedValue -> DefinedValue

		//

		public void change(DefinedValue p_DefinedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_ReferencedValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedValue = p_DefinedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ReferencedValue -> ValueFromObject

		//

		public void change(ValueFromObject p_ValueFromObject)
		{
			_init ();
			this.kind = (uint) production_kind.g_ReferencedValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ValueFromObject = p_ValueFromObject;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ReferencedValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DefinedValue != null) && m_DefinedValue.checkInclusion (element) ||
				(m_ValueFromObject != null) && m_ValueFromObject.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ReferencedValue

		//
		// emit production tree node associated with any production of syntax rule ReferencedValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ReferencedValue_1:
					// emit syntax tree node associated with production
					// ReferencedValue: DefinedValue

					s += m_DefinedValue.Emit (depth - 1);
				break;
				case production_kind.g_ReferencedValue_2:
					// emit syntax tree node associated with production
					// ReferencedValue: ValueFromObject

					s += m_ValueFromObject.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ReferencedValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ReferencedValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ReferencedValue_1:
					// emit syntax tree node associated with production
					// ReferencedValue: DefinedValue

					s += m_DefinedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ReferencedValue_2:
					// emit syntax tree node associated with production
					// ReferencedValue: ValueFromObject

					s += m_ValueFromObject.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ReferencedValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ReferencedValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ReferencedValue.production_kind kind = (ReferencedValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ReferencedValue.production_kind.g_ReferencedValue_1:
					// traverse syntax tree node associated with production
					// ReferencedValue: DefinedValue

						m_DefinedValue.Visit (visitor, appData);
				break;
				case ReferencedValue.production_kind.g_ReferencedValue_2:
					// traverse syntax tree node associated with production
					// ReferencedValue: ValueFromObject

						m_ValueFromObject.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DefinedValue?.reparent (this);
			m_ValueFromObject?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ReferencedValue
		//

		public void _init ()
		{
			m_DefinedValue = null;
			m_ValueFromObject = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ReferencedValue

		// counter of all nodes associated with syntax rule ReferencedValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ReferencedValue
		[DataMember (Name = "m_DefinedValue")] public DefinedValue m_DefinedValue { get; private set; }
		[DataMember (Name = "m_ValueFromObject")] public ValueFromObject m_ValueFromObject { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ReferencedValue

		// delegate function (callback) prototype associated with syntax rule ReferencedValue
		public delegate bool ReferencedValue_Callback (SyntaxTreeCallbackReason reason, ReferencedValue.production_kind kind, ReferencedValue p_ReferencedValue);

		// event associated with syntax rule ReferencedValue
		public event ReferencedValue_Callback ReferencedValue_Event;

		// event trigger associated with syntax rule ReferencedValue
		public bool Raise_ReferencedValue_Event (SyntaxTreeCallbackReason reason, ReferencedValue.production_kind kind, ReferencedValue p_ReferencedValue)
		{
			bool? status = ReferencedValue_Event?.Invoke (reason, kind, p_ReferencedValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ReferencedValue
		//
		// traverse syntax tree node associated with any production of syntax rule ReferencedValue
		//

		public void Traverse (ReferencedValue p_ReferencedValue)
		{
			if (p_ReferencedValue.isLocked())
				return;
			p_ReferencedValue.dolock();
			ReferencedValue.production_kind kind = (ReferencedValue.production_kind) p_ReferencedValue.kind;
			p_ReferencedValue.turn_reset ();
			if (Raise_ReferencedValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ReferencedValue))
			switch (kind)
			{
				case ReferencedValue.production_kind.g_ReferencedValue_1:
					// traverse syntax tree node associated with production
					// ReferencedValue: DefinedValue

					if (Raise_ReferencedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedValue))
						Traverse (p_ReferencedValue.m_DefinedValue);
					p_ReferencedValue.turn_inc ();
					Raise_ReferencedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedValue);
				break;
				case ReferencedValue.production_kind.g_ReferencedValue_2:
					// traverse syntax tree node associated with production
					// ReferencedValue: ValueFromObject

					if (Raise_ReferencedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedValue))
						Traverse (p_ReferencedValue.m_ValueFromObject);
					p_ReferencedValue.turn_inc ();
					Raise_ReferencedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ReferencedValue);
				break;
			}
			Raise_ReferencedValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ReferencedValue);
			p_ReferencedValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ReferencedValue
		//

		public void TraverseCommon (ReferencedValue p_ReferencedValue)
		{
			ReferencedValue.production_kind kind = (ReferencedValue.production_kind) p_ReferencedValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ReferencedValue))
			switch (kind)
			{
				case ReferencedValue.production_kind.g_ReferencedValue_1:
					// traverse syntax tree node associated with production
					// ReferencedValue: DefinedValue

						TraverseCommon (p_ReferencedValue.m_DefinedValue);
				break;
				case ReferencedValue.production_kind.g_ReferencedValue_2:
					// traverse syntax tree node associated with production
					// ReferencedValue: ValueFromObject

						TraverseCommon (p_ReferencedValue.m_ValueFromObject);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ReferencedValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ReferencedValue

		//
		// create syntax tree node associated with production
		// ReferencedValue: DefinedValue

		//

		public ReferencedValue ReferencedValue_1 (DefinedValue p_DefinedValue)
		{
			ReferencedValue p_ReferencedValue_ref = new ReferencedValue(p_DefinedValue);
			p_DefinedValue.parent = p_ReferencedValue_ref;
			Raise_ReferencedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ReferencedValue.production_kind.g_ReferencedValue_1, p_ReferencedValue_ref);
			return p_ReferencedValue_ref;
		}

		//
		// create syntax tree node associated with production
		// ReferencedValue: ValueFromObject

		//

		public ReferencedValue ReferencedValue_2 (ValueFromObject p_ValueFromObject)
		{
			ReferencedValue p_ReferencedValue_ref = new ReferencedValue(p_ValueFromObject);
			p_ValueFromObject.parent = p_ReferencedValue_ref;
			Raise_ReferencedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ReferencedValue.production_kind.g_ReferencedValue_2, p_ReferencedValue_ref);
			return p_ReferencedValue_ref;
		}
		#endregion
	};
}
