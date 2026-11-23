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
	// class associated with syntax rule SimpleDefinedValue
	//

	[DataContract]
	public class	SimpleDefinedValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SimpleDefinedValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SimpleDefinedValue
		{
			g_SimpleDefinedValue_1 = 1,	// ExternalValueReference

			g_SimpleDefinedValue_2 = 2,	// valuereference-token

		};
		#endregion
		#region production markers associated with the syntax rule SimpleDefinedValue

		// markers associated with production: SimpleDefinedValue -> ExternalValueReference

		public enum production_marker_1 : ushort
		{
			m_ExternalValueReference,
			final
		};

		// markers associated with production: SimpleDefinedValue -> valuereference-token

		public enum production_marker_2 : ushort
		{
			m_valuereference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SimpleDefinedValue

		// Constructor declaration(s) associated with production(s) of syntax rule SimpleDefinedValue

		//
		// Constructor associated with the following production(s)
		// SimpleDefinedValue -> ExternalValueReference

		//

		public SimpleDefinedValue (ExternalValueReference p_ExternalValueReference) : base ((uint) ProductionID._SimpleDefinedValue_ID, (uint) production_kind.g_SimpleDefinedValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExternalValueReference = p_ExternalValueReference;
		}

		//
		// Constructor associated with the following production(s)
		// SimpleDefinedValue -> valuereference-token

		//

		public SimpleDefinedValue (valuereference_token p_valuereference_token) : base ((uint) ProductionID._SimpleDefinedValue_ID, (uint) production_kind.g_SimpleDefinedValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_valuereference_token = p_valuereference_token;
		}

		public SimpleDefinedValue () { }

		// Copy constructor

		public SimpleDefinedValue (SimpleDefinedValue p_SimpleDefinedValue) : base (p_SimpleDefinedValue.id, p_SimpleDefinedValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SimpleDefinedValue.appInfo;
			switch ((production_kind) p_SimpleDefinedValue.kind)
			{
				case production_kind.g_SimpleDefinedValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExternalValueReference = (p_SimpleDefinedValue.m_ExternalValueReference != null) ? new ExternalValueReference (p_SimpleDefinedValue.m_ExternalValueReference) : null) != null) m_ExternalValueReference.parent = this;
					break;
				case production_kind.g_SimpleDefinedValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_valuereference_token = (p_SimpleDefinedValue.m_valuereference_token != null) ? new valuereference_token (p_SimpleDefinedValue.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SimpleDefinedValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SimpleDefinedValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ExternalValueReference?.Dispose ();
			m_valuereference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SimpleDefinedValue

		// Content changing function(s) associated with production(s) of syntax rule SimpleDefinedValue

		//
		// Content changing function associated with following production(s)
		// SimpleDefinedValue -> ExternalValueReference

		//

		public void change(ExternalValueReference p_ExternalValueReference)
		{
			_init ();
			this.kind = (uint) production_kind.g_SimpleDefinedValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExternalValueReference = p_ExternalValueReference;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SimpleDefinedValue -> valuereference-token

		//

		public void change(valuereference_token p_valuereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_SimpleDefinedValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_valuereference_token = p_valuereference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SimpleDefinedValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ExternalValueReference != null) && m_ExternalValueReference.checkInclusion (element) ||
				(m_valuereference_token != null) && m_valuereference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SimpleDefinedValue

		//
		// emit production tree node associated with any production of syntax rule SimpleDefinedValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SimpleDefinedValue_1:
					// emit syntax tree node associated with production
					// SimpleDefinedValue: ExternalValueReference

					s += m_ExternalValueReference.Emit (depth - 1);
				break;
				case production_kind.g_SimpleDefinedValue_2:
					// emit syntax tree node associated with production
					// SimpleDefinedValue: valuereference-token

					s += m_valuereference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SimpleDefinedValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SimpleDefinedValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SimpleDefinedValue_1:
					// emit syntax tree node associated with production
					// SimpleDefinedValue: ExternalValueReference

					s += m_ExternalValueReference.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_SimpleDefinedValue_2:
					// emit syntax tree node associated with production
					// SimpleDefinedValue: valuereference-token

					s += m_valuereference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SimpleDefinedValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SimpleDefinedValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SimpleDefinedValue.production_kind kind = (SimpleDefinedValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SimpleDefinedValue.production_kind.g_SimpleDefinedValue_1:
					// traverse syntax tree node associated with production
					// SimpleDefinedValue: ExternalValueReference

						m_ExternalValueReference.Visit (visitor, appData);
				break;
				case SimpleDefinedValue.production_kind.g_SimpleDefinedValue_2:
					// traverse syntax tree node associated with production
					// SimpleDefinedValue: valuereference-token

						m_valuereference_token.Visit (visitor, appData);
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
		}

		//
		// initialize object associated with syntax rule SimpleDefinedValue
		//

		public void _init ()
		{
			m_ExternalValueReference = null;
			m_valuereference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SimpleDefinedValue

		// counter of all nodes associated with syntax rule SimpleDefinedValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SimpleDefinedValue
		[DataMember (Name = "m_ExternalValueReference")] public ExternalValueReference m_ExternalValueReference { get; private set; }
		[DataMember (Name = "m_valuereference_token")] public valuereference_token m_valuereference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SimpleDefinedValue

		// delegate function (callback) prototype associated with syntax rule SimpleDefinedValue
		public delegate bool SimpleDefinedValue_Callback (SyntaxTreeCallbackReason reason, SimpleDefinedValue.production_kind kind, SimpleDefinedValue p_SimpleDefinedValue);

		// event associated with syntax rule SimpleDefinedValue
		public event SimpleDefinedValue_Callback SimpleDefinedValue_Event;

		// event trigger associated with syntax rule SimpleDefinedValue
		public bool Raise_SimpleDefinedValue_Event (SyntaxTreeCallbackReason reason, SimpleDefinedValue.production_kind kind, SimpleDefinedValue p_SimpleDefinedValue)
		{
			bool? status = SimpleDefinedValue_Event?.Invoke (reason, kind, p_SimpleDefinedValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SimpleDefinedValue
		//
		// traverse syntax tree node associated with any production of syntax rule SimpleDefinedValue
		//

		public void Traverse (SimpleDefinedValue p_SimpleDefinedValue)
		{
			if (p_SimpleDefinedValue.isLocked())
				return;
			p_SimpleDefinedValue.dolock();
			SimpleDefinedValue.production_kind kind = (SimpleDefinedValue.production_kind) p_SimpleDefinedValue.kind;
			p_SimpleDefinedValue.turn_reset ();
			if (Raise_SimpleDefinedValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SimpleDefinedValue))
			switch (kind)
			{
				case SimpleDefinedValue.production_kind.g_SimpleDefinedValue_1:
					// traverse syntax tree node associated with production
					// SimpleDefinedValue: ExternalValueReference

					if (Raise_SimpleDefinedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SimpleDefinedValue))
						Traverse (p_SimpleDefinedValue.m_ExternalValueReference);
					p_SimpleDefinedValue.turn_inc ();
					Raise_SimpleDefinedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SimpleDefinedValue);
				break;
				case SimpleDefinedValue.production_kind.g_SimpleDefinedValue_2:
					// traverse syntax tree node associated with production
					// SimpleDefinedValue: valuereference-token

					if (Raise_SimpleDefinedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SimpleDefinedValue))
						Traverse (p_SimpleDefinedValue.m_valuereference_token);
					p_SimpleDefinedValue.turn_inc ();
					Raise_SimpleDefinedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_SimpleDefinedValue);
				break;
			}
			Raise_SimpleDefinedValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SimpleDefinedValue);
			p_SimpleDefinedValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SimpleDefinedValue
		//

		public void TraverseCommon (SimpleDefinedValue p_SimpleDefinedValue)
		{
			SimpleDefinedValue.production_kind kind = (SimpleDefinedValue.production_kind) p_SimpleDefinedValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SimpleDefinedValue))
			switch (kind)
			{
				case SimpleDefinedValue.production_kind.g_SimpleDefinedValue_1:
					// traverse syntax tree node associated with production
					// SimpleDefinedValue: ExternalValueReference

						TraverseCommon (p_SimpleDefinedValue.m_ExternalValueReference);
				break;
				case SimpleDefinedValue.production_kind.g_SimpleDefinedValue_2:
					// traverse syntax tree node associated with production
					// SimpleDefinedValue: valuereference-token

						TraverseCommon (p_SimpleDefinedValue.m_valuereference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SimpleDefinedValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SimpleDefinedValue

		//
		// create syntax tree node associated with production
		// SimpleDefinedValue: ExternalValueReference

		//

		public SimpleDefinedValue SimpleDefinedValue_1 (ExternalValueReference p_ExternalValueReference)
		{
			SimpleDefinedValue p_SimpleDefinedValue_ref = new SimpleDefinedValue(p_ExternalValueReference);
			p_ExternalValueReference.parent = p_SimpleDefinedValue_ref;
			Raise_SimpleDefinedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SimpleDefinedValue.production_kind.g_SimpleDefinedValue_1, p_SimpleDefinedValue_ref);
			return p_SimpleDefinedValue_ref;
		}

		//
		// create syntax tree node associated with production
		// SimpleDefinedValue: valuereference-token

		//

		public SimpleDefinedValue SimpleDefinedValue_2 (valuereference_token p_valuereference_token)
		{
			SimpleDefinedValue p_SimpleDefinedValue_ref = new SimpleDefinedValue(p_valuereference_token);
			p_valuereference_token.parent = p_SimpleDefinedValue_ref;
			Raise_SimpleDefinedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SimpleDefinedValue.production_kind.g_SimpleDefinedValue_2, p_SimpleDefinedValue_ref);
			return p_SimpleDefinedValue_ref;
		}
		#endregion
	};
}
