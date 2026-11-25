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
	// class associated with syntax rule VersionNumber
	//

	[DataContract]
	public class	VersionNumber : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule VersionNumber
		public enum production_kind : ushort	// enumerated production(s) of syntax rule VersionNumber
		{
			g_VersionNumber_1 = 1,	// %empty

			g_VersionNumber_2 = 2,	// number ":"

		};
		#endregion
		#region production markers associated with the syntax rule VersionNumber

		// markers associated with production: VersionNumber -> %empty

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: VersionNumber -> number ":"

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule VersionNumber

		// Constructor declaration(s) associated with production(s) of syntax rule VersionNumber

		//
		// Constructor associated with the following production(s)
		// VersionNumber -> %empty

		//

		public VersionNumber () : base ((uint) ProductionID._VersionNumber_ID, (uint) production_kind.g_VersionNumber_1)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		//
		// Constructor associated with the following production(s)
		// VersionNumber -> number ":"

		//

		public VersionNumber (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._VersionNumber_ID, (uint) production_kind.g_VersionNumber_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_number = p_token;
			children[1] = m_colon = p_token_1;
		}

		// Copy constructor

		public VersionNumber (VersionNumber p_VersionNumber) : base (p_VersionNumber.id, p_VersionNumber.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_VersionNumber.appInfo;
			switch ((production_kind) p_VersionNumber.kind)
			{
				case production_kind.g_VersionNumber_1:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				case production_kind.g_VersionNumber_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_number = (p_VersionNumber.m_number != null) ? new SyntaxTreeToken (p_VersionNumber.m_number) : null) != null) m_number.parent = this;
					if ((children [1] = m_colon = (p_VersionNumber.m_colon != null) ? new SyntaxTreeToken (p_VersionNumber.m_colon) : null) != null) m_colon.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "VersionNumber" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new VersionNumber (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_number?.Dispose ();
			m_colon?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule VersionNumber

		// Content changing function(s) associated with production(s) of syntax rule VersionNumber

		//
		// Content changing function associated with following production(s)
		// VersionNumber -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_VersionNumber_1;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// VersionNumber -> number ":"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_VersionNumber_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_number = p_token;
			children [1] = m_colon = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule VersionNumber
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				(m_colon != null) && m_colon.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule VersionNumber

		//
		// emit production tree node associated with any production of syntax rule VersionNumber
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_VersionNumber_1:
					// emit syntax tree node associated with production
					// VersionNumber: %empty

				break;
				case production_kind.g_VersionNumber_2:
					// emit syntax tree node associated with production
					// VersionNumber: number ":"

					s += m_number.Emit (depth - 1);
					s += " ";
					s += m_colon.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule VersionNumber
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "VersionNumber (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_VersionNumber_1:
					// emit syntax tree node associated with production
					// VersionNumber: %empty

				break;
				case production_kind.g_VersionNumber_2:
					// emit syntax tree node associated with production
					// VersionNumber: number ":"

					s += "number";
					s += ' ';
					s += "colon";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule VersionNumber

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule VersionNumber with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			VersionNumber.production_kind kind = (VersionNumber.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case VersionNumber.production_kind.g_VersionNumber_1:
					// traverse syntax tree node associated with production
					// VersionNumber: %empty

				break;
				case VersionNumber.production_kind.g_VersionNumber_2:
					// traverse syntax tree node associated with production
					// VersionNumber: number ":"

						m_number.Visit (visitor, appData);
						m_colon.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_number?.reparent (this);
			m_colon?.reparent (this);
		}

		//
		// initialize object associated with syntax rule VersionNumber
		//

		public void _init ()
		{
			m_number = null;
			m_colon = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule VersionNumber

		// counter of all nodes associated with syntax rule VersionNumber
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule VersionNumber
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		[DataMember (Name = "m_colon")] public SyntaxTreeToken m_colon { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule VersionNumber

		// delegate function (callback) prototype associated with syntax rule VersionNumber
		public delegate bool VersionNumber_Callback (SyntaxTreeCallbackReason reason, VersionNumber.production_kind kind, VersionNumber p_VersionNumber);

		// event associated with syntax rule VersionNumber
		public event VersionNumber_Callback VersionNumber_Event;

		// event trigger associated with syntax rule VersionNumber
		public bool Raise_VersionNumber_Event (SyntaxTreeCallbackReason reason, VersionNumber.production_kind kind, VersionNumber p_VersionNumber)
		{
			bool? status = VersionNumber_Event?.Invoke (reason, kind, p_VersionNumber);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule VersionNumber
		//
		// traverse syntax tree node associated with any production of syntax rule VersionNumber
		//

		public void Traverse (VersionNumber p_VersionNumber)
		{
			if (p_VersionNumber.isLocked())
				return;
			p_VersionNumber.dolock();
			VersionNumber.production_kind kind = (VersionNumber.production_kind) p_VersionNumber.kind;
			p_VersionNumber.turn_reset ();
			if (Raise_VersionNumber_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_VersionNumber))
			switch (kind)
			{
				case VersionNumber.production_kind.g_VersionNumber_1:
					// traverse syntax tree node associated with production
					// VersionNumber: %empty

				break;
				case VersionNumber.production_kind.g_VersionNumber_2:
					// traverse syntax tree node associated with production
					// VersionNumber: number ":"

				break;
			}
			Raise_VersionNumber_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_VersionNumber);
			p_VersionNumber.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule VersionNumber
		//

		public void TraverseCommon (VersionNumber p_VersionNumber)
		{
			VersionNumber.production_kind kind = (VersionNumber.production_kind) p_VersionNumber.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_VersionNumber))
			switch (kind)
			{
				case VersionNumber.production_kind.g_VersionNumber_1:
					// traverse syntax tree node associated with production
					// VersionNumber: %empty

				break;
				case VersionNumber.production_kind.g_VersionNumber_2:
					// traverse syntax tree node associated with production
					// VersionNumber: number ":"

						TraverseCommon (p_VersionNumber.m_number);
						TraverseCommon (p_VersionNumber.m_colon);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_VersionNumber);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule VersionNumber

		//
		// create syntax tree node associated with production
		// VersionNumber: %empty

		//

		public VersionNumber VersionNumber_1 ()
		{
			VersionNumber p_VersionNumber_ref = new VersionNumber();
			Raise_VersionNumber_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, VersionNumber.production_kind.g_VersionNumber_1, p_VersionNumber_ref);
			return p_VersionNumber_ref;
		}

		//
		// create syntax tree node associated with production
		// VersionNumber: number ":"

		//

		public VersionNumber VersionNumber_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			VersionNumber p_VersionNumber_ref = new VersionNumber(p_token, p_token_1);
			p_token.parent = p_VersionNumber_ref;
			p_token_1.parent = p_VersionNumber_ref;
			Raise_VersionNumber_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, VersionNumber.production_kind.g_VersionNumber_2, p_VersionNumber_ref);
			return p_VersionNumber_ref;
		}
		#endregion
	};
}
