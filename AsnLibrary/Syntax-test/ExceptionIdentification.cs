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
	// class associated with syntax rule ExceptionIdentification
	//

	[DataContract]
	public class	ExceptionIdentification : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExceptionIdentification
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExceptionIdentification
		{
			g_ExceptionIdentification_1 = 1,	// SignedNumber

			g_ExceptionIdentification_2 = 2,	// DefinedValue

			g_ExceptionIdentification_3 = 3,	// Type ":" Value

		};
		#endregion
		#region production markers associated with the syntax rule ExceptionIdentification

		// markers associated with production: ExceptionIdentification -> SignedNumber

		public enum production_marker_1 : ushort
		{
			m_SignedNumber,
			final
		};

		// markers associated with production: ExceptionIdentification -> DefinedValue

		public enum production_marker_2 : ushort
		{
			m_DefinedValue,
			final
		};

		// markers associated with production: ExceptionIdentification -> Type ":" Value

		public enum production_marker_3 : ushort
		{
			m_Type,
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExceptionIdentification

		// Constructor declaration(s) associated with production(s) of syntax rule ExceptionIdentification

		//
		// Constructor associated with the following production(s)
		// ExceptionIdentification -> SignedNumber

		//

		public ExceptionIdentification (SignedNumber p_SignedNumber) : base ((uint) ProductionID._ExceptionIdentification_ID, (uint) production_kind.g_ExceptionIdentification_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SignedNumber = p_SignedNumber;
		}

		//
		// Constructor associated with the following production(s)
		// ExceptionIdentification -> DefinedValue

		//

		public ExceptionIdentification (DefinedValue p_DefinedValue) : base ((uint) ProductionID._ExceptionIdentification_ID, (uint) production_kind.g_ExceptionIdentification_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedValue = p_DefinedValue;
		}

		//
		// Constructor associated with the following production(s)
		// ExceptionIdentification -> Type ":" Value

		//

		public ExceptionIdentification (Type p_Type, SyntaxTreeToken p_token, Value p_Value) : base ((uint) ProductionID._ExceptionIdentification_ID, (uint) production_kind.g_ExceptionIdentification_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_Type = p_Type;
			children[1] = m_colon = p_token;
			children[2] = m_Value = p_Value;
		}

		public ExceptionIdentification () { }

		// Copy constructor

		public ExceptionIdentification (ExceptionIdentification p_ExceptionIdentification) : base (p_ExceptionIdentification.id, p_ExceptionIdentification.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExceptionIdentification.appInfo;
			switch ((production_kind) p_ExceptionIdentification.kind)
			{
				case production_kind.g_ExceptionIdentification_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SignedNumber = (p_ExceptionIdentification.m_SignedNumber != null) ? new SignedNumber (p_ExceptionIdentification.m_SignedNumber) : null) != null) m_SignedNumber.parent = this;
					break;
				case production_kind.g_ExceptionIdentification_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedValue = (p_ExceptionIdentification.m_DefinedValue != null) ? new DefinedValue (p_ExceptionIdentification.m_DefinedValue) : null) != null) m_DefinedValue.parent = this;
					break;
				case production_kind.g_ExceptionIdentification_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_Type = (p_ExceptionIdentification.m_Type != null) ? new Type (p_ExceptionIdentification.m_Type) : null) != null) m_Type.parent = this;
					if ((children [1] = m_colon = (p_ExceptionIdentification.m_colon != null) ? new SyntaxTreeToken (p_ExceptionIdentification.m_colon) : null) != null) m_colon.parent = this;
					if ((children [2] = m_Value = (p_ExceptionIdentification.m_Value != null) ? new Value (p_ExceptionIdentification.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExceptionIdentification" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExceptionIdentification (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SignedNumber?.Dispose ();
			m_DefinedValue?.Dispose ();
			m_Type?.Dispose ();
			m_colon?.Dispose ();
			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExceptionIdentification

		// Content changing function(s) associated with production(s) of syntax rule ExceptionIdentification

		//
		// Content changing function associated with following production(s)
		// ExceptionIdentification -> SignedNumber

		//

		public void change(SignedNumber p_SignedNumber)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExceptionIdentification_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SignedNumber = p_SignedNumber;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ExceptionIdentification -> DefinedValue

		//

		public void change(DefinedValue p_DefinedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExceptionIdentification_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedValue = p_DefinedValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ExceptionIdentification -> Type ":" Value

		//

		public void change(Type p_Type, SyntaxTreeToken p_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExceptionIdentification_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_Type = p_Type;
			children [1] = m_colon = p_token;
			children [2] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExceptionIdentification
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SignedNumber != null) && m_SignedNumber.checkInclusion (element) ||
				(m_DefinedValue != null) && m_DefinedValue.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				(m_colon != null) && m_colon.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExceptionIdentification

		//
		// emit production tree node associated with any production of syntax rule ExceptionIdentification
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExceptionIdentification_1:
					// emit syntax tree node associated with production
					// ExceptionIdentification: SignedNumber

					s += m_SignedNumber.Emit (depth - 1);
				break;
				case production_kind.g_ExceptionIdentification_2:
					// emit syntax tree node associated with production
					// ExceptionIdentification: DefinedValue

					s += m_DefinedValue.Emit (depth - 1);
				break;
				case production_kind.g_ExceptionIdentification_3:
					// emit syntax tree node associated with production
					// ExceptionIdentification: Type ":" Value

					s += m_Type.Emit (depth - 1);
					s += " ";
					s += m_colon.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExceptionIdentification
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExceptionIdentification (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExceptionIdentification_1:
					// emit syntax tree node associated with production
					// ExceptionIdentification: SignedNumber

					s += m_SignedNumber.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ExceptionIdentification_2:
					// emit syntax tree node associated with production
					// ExceptionIdentification: DefinedValue

					s += m_DefinedValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ExceptionIdentification_3:
					// emit syntax tree node associated with production
					// ExceptionIdentification: Type ":" Value

					s += m_Type.EmitProductionTree (depth - 1);
					s += ' ';
					s += "colon";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExceptionIdentification

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExceptionIdentification with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExceptionIdentification.production_kind kind = (ExceptionIdentification.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExceptionIdentification.production_kind.g_ExceptionIdentification_1:
					// traverse syntax tree node associated with production
					// ExceptionIdentification: SignedNumber

						m_SignedNumber.Visit (visitor, appData);
				break;
				case ExceptionIdentification.production_kind.g_ExceptionIdentification_2:
					// traverse syntax tree node associated with production
					// ExceptionIdentification: DefinedValue

						m_DefinedValue.Visit (visitor, appData);
				break;
				case ExceptionIdentification.production_kind.g_ExceptionIdentification_3:
					// traverse syntax tree node associated with production
					// ExceptionIdentification: Type ":" Value

						m_Type.Visit (visitor, appData);
						m_colon.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SignedNumber?.reparent (this);
			m_DefinedValue?.reparent (this);
			m_Type?.reparent (this);
			m_colon?.reparent (this);
			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExceptionIdentification
		//

		public void _init ()
		{
			m_SignedNumber = null;
			m_DefinedValue = null;
			m_Type = null;
			m_colon = null;
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExceptionIdentification

		// counter of all nodes associated with syntax rule ExceptionIdentification
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExceptionIdentification
		[DataMember (Name = "m_SignedNumber")] public SignedNumber m_SignedNumber { get; private set; }
		[DataMember (Name = "m_DefinedValue")] public DefinedValue m_DefinedValue { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		[DataMember (Name = "m_colon")] public SyntaxTreeToken m_colon { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }

		public enum __p3_markers
		{
			m1 = 1,
			m2 = 2,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExceptionIdentification

		// delegate function (callback) prototype associated with syntax rule ExceptionIdentification
		public delegate bool ExceptionIdentification_Callback (SyntaxTreeCallbackReason reason, ExceptionIdentification.production_kind kind, ExceptionIdentification p_ExceptionIdentification);

		// event associated with syntax rule ExceptionIdentification
		public event ExceptionIdentification_Callback ExceptionIdentification_Event;

		// event trigger associated with syntax rule ExceptionIdentification
		public bool Raise_ExceptionIdentification_Event (SyntaxTreeCallbackReason reason, ExceptionIdentification.production_kind kind, ExceptionIdentification p_ExceptionIdentification)
		{
			bool? status = ExceptionIdentification_Event?.Invoke (reason, kind, p_ExceptionIdentification);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExceptionIdentification
		//
		// traverse syntax tree node associated with any production of syntax rule ExceptionIdentification
		//

		public void Traverse (ExceptionIdentification p_ExceptionIdentification)
		{
			if (p_ExceptionIdentification.isLocked())
				return;
			p_ExceptionIdentification.dolock();
			ExceptionIdentification.production_kind kind = (ExceptionIdentification.production_kind) p_ExceptionIdentification.kind;
			p_ExceptionIdentification.turn_reset ();
			if (Raise_ExceptionIdentification_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExceptionIdentification))
			switch (kind)
			{
				case ExceptionIdentification.production_kind.g_ExceptionIdentification_1:
					// traverse syntax tree node associated with production
					// ExceptionIdentification: SignedNumber

					if (Raise_ExceptionIdentification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExceptionIdentification))
						Traverse (p_ExceptionIdentification.m_SignedNumber);
					p_ExceptionIdentification.turn_inc ();
					Raise_ExceptionIdentification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExceptionIdentification);
				break;
				case ExceptionIdentification.production_kind.g_ExceptionIdentification_2:
					// traverse syntax tree node associated with production
					// ExceptionIdentification: DefinedValue

					if (Raise_ExceptionIdentification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExceptionIdentification))
						Traverse (p_ExceptionIdentification.m_DefinedValue);
					p_ExceptionIdentification.turn_inc ();
					Raise_ExceptionIdentification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExceptionIdentification);
				break;
				case ExceptionIdentification.production_kind.g_ExceptionIdentification_3:
					// traverse syntax tree node associated with production
					// ExceptionIdentification: Type ":" Value

					if (Raise_ExceptionIdentification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExceptionIdentification))
						Traverse (p_ExceptionIdentification.m_Type);
					p_ExceptionIdentification.turn_inc ();
					if (Raise_ExceptionIdentification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExceptionIdentification))
						Traverse (p_ExceptionIdentification.m_Value);
					p_ExceptionIdentification.turn_inc ();
					Raise_ExceptionIdentification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExceptionIdentification);
				break;
			}
			Raise_ExceptionIdentification_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExceptionIdentification);
			p_ExceptionIdentification.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExceptionIdentification
		//

		public void TraverseCommon (ExceptionIdentification p_ExceptionIdentification)
		{
			ExceptionIdentification.production_kind kind = (ExceptionIdentification.production_kind) p_ExceptionIdentification.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExceptionIdentification))
			switch (kind)
			{
				case ExceptionIdentification.production_kind.g_ExceptionIdentification_1:
					// traverse syntax tree node associated with production
					// ExceptionIdentification: SignedNumber

						TraverseCommon (p_ExceptionIdentification.m_SignedNumber);
				break;
				case ExceptionIdentification.production_kind.g_ExceptionIdentification_2:
					// traverse syntax tree node associated with production
					// ExceptionIdentification: DefinedValue

						TraverseCommon (p_ExceptionIdentification.m_DefinedValue);
				break;
				case ExceptionIdentification.production_kind.g_ExceptionIdentification_3:
					// traverse syntax tree node associated with production
					// ExceptionIdentification: Type ":" Value

						TraverseCommon (p_ExceptionIdentification.m_Type);
						TraverseCommon (p_ExceptionIdentification.m_colon);
						TraverseCommon (p_ExceptionIdentification.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExceptionIdentification);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExceptionIdentification

		//
		// create syntax tree node associated with production
		// ExceptionIdentification: SignedNumber

		//

		public ExceptionIdentification ExceptionIdentification_1 (SignedNumber p_SignedNumber)
		{
			ExceptionIdentification p_ExceptionIdentification_ref = new ExceptionIdentification(p_SignedNumber);
			p_SignedNumber.parent = p_ExceptionIdentification_ref;
			Raise_ExceptionIdentification_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExceptionIdentification.production_kind.g_ExceptionIdentification_1, p_ExceptionIdentification_ref);
			return p_ExceptionIdentification_ref;
		}

		//
		// create syntax tree node associated with production
		// ExceptionIdentification: DefinedValue

		//

		public ExceptionIdentification ExceptionIdentification_2 (DefinedValue p_DefinedValue)
		{
			ExceptionIdentification p_ExceptionIdentification_ref = new ExceptionIdentification(p_DefinedValue);
			p_DefinedValue.parent = p_ExceptionIdentification_ref;
			Raise_ExceptionIdentification_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExceptionIdentification.production_kind.g_ExceptionIdentification_2, p_ExceptionIdentification_ref);
			return p_ExceptionIdentification_ref;
		}

		//
		// create syntax tree node associated with production
		// ExceptionIdentification: Type ":" Value

		//

		public ExceptionIdentification ExceptionIdentification_3 (Type p_Type, SyntaxTreeToken p_token, Value p_Value)
		{
			ExceptionIdentification p_ExceptionIdentification_ref = new ExceptionIdentification(p_Type, p_token, p_Value);
			p_Type.parent = p_ExceptionIdentification_ref;
			p_token.parent = p_ExceptionIdentification_ref;
			p_Value.parent = p_ExceptionIdentification_ref;
			Raise_ExceptionIdentification_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExceptionIdentification.production_kind.g_ExceptionIdentification_3, p_ExceptionIdentification_ref);
			return p_ExceptionIdentification_ref;
		}
		#endregion
	};
}
