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
	// class associated with syntax rule IntegerValue
	//

	[DataContract]
	public class	IntegerValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule IntegerValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule IntegerValue
		{
			g_IntegerValue_1 = 1,	// SignedNumber

			g_IntegerValue_2 = 2,	// identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule IntegerValue

		// markers associated with production: IntegerValue -> SignedNumber

		public enum production_marker_1 : ushort
		{
			m_SignedNumber,
			final
		};

		// markers associated with production: IntegerValue -> identifier-token

		public enum production_marker_2 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule IntegerValue

		// Constructor declaration(s) associated with production(s) of syntax rule IntegerValue

		//
		// Constructor associated with the following production(s)
		// IntegerValue -> SignedNumber

		//

		public IntegerValue (SignedNumber p_SignedNumber) : base ((uint) ProductionID._IntegerValue_ID, (uint) production_kind.g_IntegerValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_SignedNumber = p_SignedNumber;
		}

		//
		// Constructor associated with the following production(s)
		// IntegerValue -> identifier-token

		//

		public IntegerValue (identifier_token p_identifier_token) : base ((uint) ProductionID._IntegerValue_ID, (uint) production_kind.g_IntegerValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		public IntegerValue () { }

		// Copy constructor

		public IntegerValue (IntegerValue p_IntegerValue) : base (p_IntegerValue.id, p_IntegerValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_IntegerValue.appInfo;
			switch ((production_kind) p_IntegerValue.kind)
			{
				case production_kind.g_IntegerValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_SignedNumber = (p_IntegerValue.m_SignedNumber != null) ? new SignedNumber (p_IntegerValue.m_SignedNumber) : null) != null) m_SignedNumber.parent = this;
					break;
				case production_kind.g_IntegerValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_IntegerValue.m_identifier_token != null) ? new identifier_token (p_IntegerValue.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "IntegerValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new IntegerValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SignedNumber?.Dispose ();
			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule IntegerValue

		// Content changing function(s) associated with production(s) of syntax rule IntegerValue

		//
		// Content changing function associated with following production(s)
		// IntegerValue -> SignedNumber

		//

		public void change(SignedNumber p_SignedNumber)
		{
			_init ();
			this.kind = (uint) production_kind.g_IntegerValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_SignedNumber = p_SignedNumber;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// IntegerValue -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_IntegerValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule IntegerValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SignedNumber != null) && m_SignedNumber.checkInclusion (element) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule IntegerValue

		//
		// emit production tree node associated with any production of syntax rule IntegerValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_IntegerValue_1:
					// emit syntax tree node associated with production
					// IntegerValue: SignedNumber

					s += m_SignedNumber.Emit (depth - 1);
				break;
				case production_kind.g_IntegerValue_2:
					// emit syntax tree node associated with production
					// IntegerValue: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule IntegerValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "IntegerValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_IntegerValue_1:
					// emit syntax tree node associated with production
					// IntegerValue: SignedNumber

					s += m_SignedNumber.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_IntegerValue_2:
					// emit syntax tree node associated with production
					// IntegerValue: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule IntegerValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule IntegerValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			IntegerValue.production_kind kind = (IntegerValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case IntegerValue.production_kind.g_IntegerValue_1:
					// traverse syntax tree node associated with production
					// IntegerValue: SignedNumber

						m_SignedNumber.Visit (visitor, appData);
				break;
				case IntegerValue.production_kind.g_IntegerValue_2:
					// traverse syntax tree node associated with production
					// IntegerValue: identifier-token

						m_identifier_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SignedNumber?.reparent (this);
			m_identifier_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule IntegerValue
		//

		public void _init ()
		{
			m_SignedNumber = null;
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule IntegerValue

		// counter of all nodes associated with syntax rule IntegerValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule IntegerValue
		[DataMember (Name = "m_SignedNumber")] public SignedNumber m_SignedNumber { get; private set; }
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule IntegerValue

		// delegate function (callback) prototype associated with syntax rule IntegerValue
		public delegate bool IntegerValue_Callback (SyntaxTreeCallbackReason reason, IntegerValue.production_kind kind, IntegerValue p_IntegerValue);

		// event associated with syntax rule IntegerValue
		public event IntegerValue_Callback IntegerValue_Event;

		// event trigger associated with syntax rule IntegerValue
		public bool Raise_IntegerValue_Event (SyntaxTreeCallbackReason reason, IntegerValue.production_kind kind, IntegerValue p_IntegerValue)
		{
			bool? status = IntegerValue_Event?.Invoke (reason, kind, p_IntegerValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule IntegerValue
		//
		// traverse syntax tree node associated with any production of syntax rule IntegerValue
		//

		public void Traverse (IntegerValue p_IntegerValue)
		{
			if (p_IntegerValue.isLocked())
				return;
			p_IntegerValue.dolock();
			IntegerValue.production_kind kind = (IntegerValue.production_kind) p_IntegerValue.kind;
			p_IntegerValue.turn_reset ();
			if (Raise_IntegerValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_IntegerValue))
			switch (kind)
			{
				case IntegerValue.production_kind.g_IntegerValue_1:
					// traverse syntax tree node associated with production
					// IntegerValue: SignedNumber

					if (Raise_IntegerValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_IntegerValue))
						Traverse (p_IntegerValue.m_SignedNumber);
					p_IntegerValue.turn_inc ();
					Raise_IntegerValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_IntegerValue);
				break;
				case IntegerValue.production_kind.g_IntegerValue_2:
					// traverse syntax tree node associated with production
					// IntegerValue: identifier-token

					if (Raise_IntegerValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_IntegerValue))
						Traverse (p_IntegerValue.m_identifier_token);
					p_IntegerValue.turn_inc ();
					Raise_IntegerValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_IntegerValue);
				break;
			}
			Raise_IntegerValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_IntegerValue);
			p_IntegerValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule IntegerValue
		//

		public void TraverseCommon (IntegerValue p_IntegerValue)
		{
			IntegerValue.production_kind kind = (IntegerValue.production_kind) p_IntegerValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_IntegerValue))
			switch (kind)
			{
				case IntegerValue.production_kind.g_IntegerValue_1:
					// traverse syntax tree node associated with production
					// IntegerValue: SignedNumber

						TraverseCommon (p_IntegerValue.m_SignedNumber);
				break;
				case IntegerValue.production_kind.g_IntegerValue_2:
					// traverse syntax tree node associated with production
					// IntegerValue: identifier-token

						TraverseCommon (p_IntegerValue.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_IntegerValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule IntegerValue

		//
		// create syntax tree node associated with production
		// IntegerValue: SignedNumber

		//

		public IntegerValue IntegerValue_1 (SignedNumber p_SignedNumber)
		{
			IntegerValue p_IntegerValue_ref = new IntegerValue(p_SignedNumber);
			p_SignedNumber.parent = p_IntegerValue_ref;
			Raise_IntegerValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, IntegerValue.production_kind.g_IntegerValue_1, p_IntegerValue_ref);
			return p_IntegerValue_ref;
		}

		//
		// create syntax tree node associated with production
		// IntegerValue: identifier-token

		//

		public IntegerValue IntegerValue_2 (identifier_token p_identifier_token)
		{
			IntegerValue p_IntegerValue_ref = new IntegerValue(p_identifier_token);
			p_identifier_token.parent = p_IntegerValue_ref;
			Raise_IntegerValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, IntegerValue.production_kind.g_IntegerValue_2, p_IntegerValue_ref);
			return p_IntegerValue_ref;
		}
		#endregion
	};
}
