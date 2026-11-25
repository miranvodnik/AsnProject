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
	// class associated with syntax rule DefinedValue
	//

	[DataContract]
	public class	DefinedValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinedValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinedValue
		{
			g_DefinedValue_1 = 1,	// ExternalValueReference

			g_DefinedValue_2 = 2,	// valuereference-token

			g_DefinedValue_3 = 3,	// ParameterizedValue

		};
		#endregion
		#region production markers associated with the syntax rule DefinedValue

		// markers associated with production: DefinedValue -> ExternalValueReference

		public enum production_marker_1 : ushort
		{
			m_ExternalValueReference,
			final
		};

		// markers associated with production: DefinedValue -> valuereference-token

		public enum production_marker_2 : ushort
		{
			m_valuereference_token,
			final
		};

		// markers associated with production: DefinedValue -> ParameterizedValue

		public enum production_marker_3 : ushort
		{
			m_ParameterizedValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinedValue

		// Constructor declaration(s) associated with production(s) of syntax rule DefinedValue

		//
		// Constructor associated with the following production(s)
		// DefinedValue -> ExternalValueReference

		//

		public DefinedValue (ExternalValueReference p_ExternalValueReference) : base ((uint) ProductionID._DefinedValue_ID, (uint) production_kind.g_DefinedValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExternalValueReference = p_ExternalValueReference;
		}

		//
		// Constructor associated with the following production(s)
		// DefinedValue -> valuereference-token

		//

		public DefinedValue (valuereference_token p_valuereference_token) : base ((uint) ProductionID._DefinedValue_ID, (uint) production_kind.g_DefinedValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_valuereference_token = p_valuereference_token;
		}

		//
		// Constructor associated with the following production(s)
		// DefinedValue -> ParameterizedValue

		//

		public DefinedValue (ParameterizedValue p_ParameterizedValue) : base ((uint) ProductionID._DefinedValue_ID, (uint) production_kind.g_DefinedValue_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ParameterizedValue = p_ParameterizedValue;
		}

		public DefinedValue () { }

		// Copy constructor

		public DefinedValue (DefinedValue p_DefinedValue) : base (p_DefinedValue.id, p_DefinedValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinedValue.appInfo;
			switch ((production_kind) p_DefinedValue.kind)
			{
				case production_kind.g_DefinedValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExternalValueReference = (p_DefinedValue.m_ExternalValueReference != null) ? new ExternalValueReference (p_DefinedValue.m_ExternalValueReference) : null) != null) m_ExternalValueReference.parent = this;
					break;
				case production_kind.g_DefinedValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_valuereference_token = (p_DefinedValue.m_valuereference_token != null) ? new valuereference_token (p_DefinedValue.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					break;
				case production_kind.g_DefinedValue_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ParameterizedValue = (p_DefinedValue.m_ParameterizedValue != null) ? new ParameterizedValue (p_DefinedValue.m_ParameterizedValue) : null) != null) m_ParameterizedValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinedValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinedValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ExternalValueReference?.Dispose ();
			m_valuereference_token?.Dispose ();
			m_ParameterizedValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinedValue

		// Content changing function(s) associated with production(s) of syntax rule DefinedValue

		//
		// Content changing function associated with following production(s)
		// DefinedValue -> ExternalValueReference

		//

		public void change(ExternalValueReference p_ExternalValueReference)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExternalValueReference = p_ExternalValueReference;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinedValue -> valuereference-token

		//

		public void change(valuereference_token p_valuereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_valuereference_token = p_valuereference_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinedValue -> ParameterizedValue

		//

		public void change(ParameterizedValue p_ParameterizedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinedValue_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ParameterizedValue = p_ParameterizedValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinedValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ExternalValueReference != null) && m_ExternalValueReference.checkInclusion (element) ||
				(m_valuereference_token != null) && m_valuereference_token.checkInclusion (element) ||
				(m_ParameterizedValue != null) && m_ParameterizedValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinedValue

		//
		// emit production tree node associated with any production of syntax rule DefinedValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinedValue_1:
					// emit syntax tree node associated with production
					// DefinedValue: ExternalValueReference

					s += m_ExternalValueReference.Emit (depth - 1);
				break;
				case production_kind.g_DefinedValue_2:
					// emit syntax tree node associated with production
					// DefinedValue: valuereference-token

					s += m_valuereference_token.Emit (depth - 1);
				break;
				case production_kind.g_DefinedValue_3:
					// emit syntax tree node associated with production
					// DefinedValue: ParameterizedValue

					s += m_ParameterizedValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinedValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinedValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinedValue_1:
					// emit syntax tree node associated with production
					// DefinedValue: ExternalValueReference

					s += m_ExternalValueReference.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinedValue_2:
					// emit syntax tree node associated with production
					// DefinedValue: valuereference-token

					s += m_valuereference_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinedValue_3:
					// emit syntax tree node associated with production
					// DefinedValue: ParameterizedValue

					s += m_ParameterizedValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinedValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinedValue.production_kind kind = (DefinedValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinedValue.production_kind.g_DefinedValue_1:
					// traverse syntax tree node associated with production
					// DefinedValue: ExternalValueReference

						m_ExternalValueReference.Visit (visitor, appData);
				break;
				case DefinedValue.production_kind.g_DefinedValue_2:
					// traverse syntax tree node associated with production
					// DefinedValue: valuereference-token

						m_valuereference_token.Visit (visitor, appData);
				break;
				case DefinedValue.production_kind.g_DefinedValue_3:
					// traverse syntax tree node associated with production
					// DefinedValue: ParameterizedValue

						m_ParameterizedValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ExternalValueReference?.reparent (this);
			m_valuereference_token?.reparent (this);
			m_ParameterizedValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefinedValue
		//

		public void _init ()
		{
			m_ExternalValueReference = null;
			m_valuereference_token = null;
			m_ParameterizedValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinedValue

		// counter of all nodes associated with syntax rule DefinedValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinedValue
		[DataMember (Name = "m_ExternalValueReference")] public ExternalValueReference m_ExternalValueReference { get; private set; }
		[DataMember (Name = "m_valuereference_token")] public valuereference_token m_valuereference_token { get; private set; }
		[DataMember (Name = "m_ParameterizedValue")] public ParameterizedValue m_ParameterizedValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinedValue

		// delegate function (callback) prototype associated with syntax rule DefinedValue
		public delegate bool DefinedValue_Callback (SyntaxTreeCallbackReason reason, DefinedValue.production_kind kind, DefinedValue p_DefinedValue);

		// event associated with syntax rule DefinedValue
		public event DefinedValue_Callback DefinedValue_Event;

		// event trigger associated with syntax rule DefinedValue
		public bool Raise_DefinedValue_Event (SyntaxTreeCallbackReason reason, DefinedValue.production_kind kind, DefinedValue p_DefinedValue)
		{
			bool? status = DefinedValue_Event?.Invoke (reason, kind, p_DefinedValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinedValue
		//
		// traverse syntax tree node associated with any production of syntax rule DefinedValue
		//

		public void Traverse (DefinedValue p_DefinedValue)
		{
			if (p_DefinedValue.isLocked())
				return;
			p_DefinedValue.dolock();
			DefinedValue.production_kind kind = (DefinedValue.production_kind) p_DefinedValue.kind;
			p_DefinedValue.turn_reset ();
			if (Raise_DefinedValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinedValue))
			switch (kind)
			{
				case DefinedValue.production_kind.g_DefinedValue_1:
					// traverse syntax tree node associated with production
					// DefinedValue: ExternalValueReference

					if (Raise_DefinedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedValue))
						Traverse (p_DefinedValue.m_ExternalValueReference);
					p_DefinedValue.turn_inc ();
					Raise_DefinedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedValue);
				break;
				case DefinedValue.production_kind.g_DefinedValue_2:
					// traverse syntax tree node associated with production
					// DefinedValue: valuereference-token

					if (Raise_DefinedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedValue))
						Traverse (p_DefinedValue.m_valuereference_token);
					p_DefinedValue.turn_inc ();
					Raise_DefinedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedValue);
				break;
				case DefinedValue.production_kind.g_DefinedValue_3:
					// traverse syntax tree node associated with production
					// DefinedValue: ParameterizedValue

					if (Raise_DefinedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedValue))
						Traverse (p_DefinedValue.m_ParameterizedValue);
					p_DefinedValue.turn_inc ();
					Raise_DefinedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinedValue);
				break;
			}
			Raise_DefinedValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinedValue);
			p_DefinedValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinedValue
		//

		public void TraverseCommon (DefinedValue p_DefinedValue)
		{
			DefinedValue.production_kind kind = (DefinedValue.production_kind) p_DefinedValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinedValue))
			switch (kind)
			{
				case DefinedValue.production_kind.g_DefinedValue_1:
					// traverse syntax tree node associated with production
					// DefinedValue: ExternalValueReference

						TraverseCommon (p_DefinedValue.m_ExternalValueReference);
				break;
				case DefinedValue.production_kind.g_DefinedValue_2:
					// traverse syntax tree node associated with production
					// DefinedValue: valuereference-token

						TraverseCommon (p_DefinedValue.m_valuereference_token);
				break;
				case DefinedValue.production_kind.g_DefinedValue_3:
					// traverse syntax tree node associated with production
					// DefinedValue: ParameterizedValue

						TraverseCommon (p_DefinedValue.m_ParameterizedValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinedValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinedValue

		//
		// create syntax tree node associated with production
		// DefinedValue: ExternalValueReference

		//

		public DefinedValue DefinedValue_1 (ExternalValueReference p_ExternalValueReference)
		{
			DefinedValue p_DefinedValue_ref = new DefinedValue(p_ExternalValueReference);
			p_ExternalValueReference.parent = p_DefinedValue_ref;
			Raise_DefinedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedValue.production_kind.g_DefinedValue_1, p_DefinedValue_ref);
			return p_DefinedValue_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinedValue: valuereference-token

		//

		public DefinedValue DefinedValue_2 (valuereference_token p_valuereference_token)
		{
			DefinedValue p_DefinedValue_ref = new DefinedValue(p_valuereference_token);
			p_valuereference_token.parent = p_DefinedValue_ref;
			Raise_DefinedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedValue.production_kind.g_DefinedValue_2, p_DefinedValue_ref);
			return p_DefinedValue_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinedValue: ParameterizedValue

		//

		public DefinedValue DefinedValue_3 (ParameterizedValue p_ParameterizedValue)
		{
			DefinedValue p_DefinedValue_ref = new DefinedValue(p_ParameterizedValue);
			p_ParameterizedValue.parent = p_DefinedValue_ref;
			Raise_DefinedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinedValue.production_kind.g_DefinedValue_3, p_DefinedValue_ref);
			return p_DefinedValue_ref;
		}
		#endregion
	};
}
