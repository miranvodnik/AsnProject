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
	// class associated with syntax rule SignedNumber
	//

	[DataContract]
	public class	SignedNumber : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule SignedNumber
		public enum production_kind : ushort	// enumerated production(s) of syntax rule SignedNumber
		{
			g_SignedNumber_1 = 1,	// number

			g_SignedNumber_2 = 2,	// "-" number

		};
		#endregion
		#region production markers associated with the syntax rule SignedNumber

		// markers associated with production: SignedNumber -> number

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: SignedNumber -> "-" number

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule SignedNumber

		// Constructor declaration(s) associated with production(s) of syntax rule SignedNumber

		//
		// Constructor associated with the following production(s)
		// SignedNumber -> number

		//

		public SignedNumber (SyntaxTreeToken p_token) : base ((uint) ProductionID._SignedNumber_ID, (uint) production_kind.g_SignedNumber_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_number = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// SignedNumber -> "-" number

		//

		public SignedNumber (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._SignedNumber_ID, (uint) production_kind.g_SignedNumber_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_minus_sign = p_token;
			children[1] = m_number = p_token_1;
		}

		public SignedNumber () { }

		// Copy constructor

		public SignedNumber (SignedNumber p_SignedNumber) : base (p_SignedNumber.id, p_SignedNumber.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_SignedNumber.appInfo;
			switch ((production_kind) p_SignedNumber.kind)
			{
				case production_kind.g_SignedNumber_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_number = (p_SignedNumber.m_number != null) ? new SyntaxTreeToken (p_SignedNumber.m_number) : null) != null) m_number.parent = this;
					break;
				case production_kind.g_SignedNumber_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_minus_sign = (p_SignedNumber.m_minus_sign != null) ? new SyntaxTreeToken (p_SignedNumber.m_minus_sign) : null) != null) m_minus_sign.parent = this;
					if ((children [1] = m_number = (p_SignedNumber.m_number != null) ? new SyntaxTreeToken (p_SignedNumber.m_number) : null) != null) m_number.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "SignedNumber" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new SignedNumber (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_number?.Dispose ();
			m_minus_sign?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule SignedNumber

		// Content changing function(s) associated with production(s) of syntax rule SignedNumber

		//
		// Content changing function associated with following production(s)
		// SignedNumber -> number

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_SignedNumber_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_number = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// SignedNumber -> "-" number

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_SignedNumber_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_minus_sign = p_token;
			children [1] = m_number = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule SignedNumber
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				(m_minus_sign != null) && m_minus_sign.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule SignedNumber

		//
		// emit production tree node associated with any production of syntax rule SignedNumber
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_SignedNumber_1:
					// emit syntax tree node associated with production
					// SignedNumber: number

					s += m_number.Emit (depth - 1);
				break;
				case production_kind.g_SignedNumber_2:
					// emit syntax tree node associated with production
					// SignedNumber: "-" number

					s += m_minus_sign.Emit (depth - 1);
					s += " ";
					s += m_number.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule SignedNumber
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "SignedNumber (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_SignedNumber_1:
					// emit syntax tree node associated with production
					// SignedNumber: number

					s += "number";
				break;
				case production_kind.g_SignedNumber_2:
					// emit syntax tree node associated with production
					// SignedNumber: "-" number

					s += "minus_sign";
					s += ' ';
					s += "number";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule SignedNumber

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule SignedNumber with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			SignedNumber.production_kind kind = (SignedNumber.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case SignedNumber.production_kind.g_SignedNumber_1:
					// traverse syntax tree node associated with production
					// SignedNumber: number

						m_number.Visit (visitor, appData);
				break;
				case SignedNumber.production_kind.g_SignedNumber_2:
					// traverse syntax tree node associated with production
					// SignedNumber: "-" number

						m_minus_sign.Visit (visitor, appData);
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
			m_minus_sign?.reparent (this);
		}

		//
		// initialize object associated with syntax rule SignedNumber
		//

		public void _init ()
		{
			m_number = null;
			m_minus_sign = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule SignedNumber

		// counter of all nodes associated with syntax rule SignedNumber
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule SignedNumber
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		[DataMember (Name = "m_minus_sign")] public SyntaxTreeToken m_minus_sign { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule SignedNumber

		// delegate function (callback) prototype associated with syntax rule SignedNumber
		public delegate bool SignedNumber_Callback (SyntaxTreeCallbackReason reason, SignedNumber.production_kind kind, SignedNumber p_SignedNumber);

		// event associated with syntax rule SignedNumber
		public event SignedNumber_Callback SignedNumber_Event;

		// event trigger associated with syntax rule SignedNumber
		public bool Raise_SignedNumber_Event (SyntaxTreeCallbackReason reason, SignedNumber.production_kind kind, SignedNumber p_SignedNumber)
		{
			bool? status = SignedNumber_Event?.Invoke (reason, kind, p_SignedNumber);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule SignedNumber
		//
		// traverse syntax tree node associated with any production of syntax rule SignedNumber
		//

		public void Traverse (SignedNumber p_SignedNumber)
		{
			if (p_SignedNumber.isLocked())
				return;
			p_SignedNumber.dolock();
			SignedNumber.production_kind kind = (SignedNumber.production_kind) p_SignedNumber.kind;
			p_SignedNumber.turn_reset ();
			if (Raise_SignedNumber_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_SignedNumber))
			switch (kind)
			{
				case SignedNumber.production_kind.g_SignedNumber_1:
					// traverse syntax tree node associated with production
					// SignedNumber: number

				break;
				case SignedNumber.production_kind.g_SignedNumber_2:
					// traverse syntax tree node associated with production
					// SignedNumber: "-" number

				break;
			}
			Raise_SignedNumber_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_SignedNumber);
			p_SignedNumber.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule SignedNumber
		//

		public void TraverseCommon (SignedNumber p_SignedNumber)
		{
			SignedNumber.production_kind kind = (SignedNumber.production_kind) p_SignedNumber.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_SignedNumber))
			switch (kind)
			{
				case SignedNumber.production_kind.g_SignedNumber_1:
					// traverse syntax tree node associated with production
					// SignedNumber: number

						TraverseCommon (p_SignedNumber.m_number);
				break;
				case SignedNumber.production_kind.g_SignedNumber_2:
					// traverse syntax tree node associated with production
					// SignedNumber: "-" number

						TraverseCommon (p_SignedNumber.m_minus_sign);
						TraverseCommon (p_SignedNumber.m_number);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_SignedNumber);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule SignedNumber

		//
		// create syntax tree node associated with production
		// SignedNumber: number

		//

		public SignedNumber SignedNumber_1 (SyntaxTreeToken p_token)
		{
			SignedNumber p_SignedNumber_ref = new SignedNumber(p_token);
			p_token.parent = p_SignedNumber_ref;
			Raise_SignedNumber_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SignedNumber.production_kind.g_SignedNumber_1, p_SignedNumber_ref);
			return p_SignedNumber_ref;
		}

		//
		// create syntax tree node associated with production
		// SignedNumber: "-" number

		//

		public SignedNumber SignedNumber_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			SignedNumber p_SignedNumber_ref = new SignedNumber(p_token, p_token_1);
			p_token.parent = p_SignedNumber_ref;
			p_token_1.parent = p_SignedNumber_ref;
			Raise_SignedNumber_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, SignedNumber.production_kind.g_SignedNumber_2, p_SignedNumber_ref);
			return p_SignedNumber_ref;
		}
		#endregion
	};
}
