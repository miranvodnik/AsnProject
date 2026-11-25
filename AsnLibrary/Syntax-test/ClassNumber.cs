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
	// class associated with syntax rule ClassNumber
	//

	[DataContract]
	public class	ClassNumber : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ClassNumber
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ClassNumber
		{
			g_ClassNumber_1 = 1,	// number

			g_ClassNumber_2 = 2,	// DefinedValue

		};
		#endregion
		#region production markers associated with the syntax rule ClassNumber

		// markers associated with production: ClassNumber -> number

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: ClassNumber -> DefinedValue

		public enum production_marker_2 : ushort
		{
			m_DefinedValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ClassNumber

		// Constructor declaration(s) associated with production(s) of syntax rule ClassNumber

		//
		// Constructor associated with the following production(s)
		// ClassNumber -> number

		//

		public ClassNumber (SyntaxTreeToken p_token) : base ((uint) ProductionID._ClassNumber_ID, (uint) production_kind.g_ClassNumber_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_number = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// ClassNumber -> DefinedValue

		//

		public ClassNumber (DefinedValue p_DefinedValue) : base ((uint) ProductionID._ClassNumber_ID, (uint) production_kind.g_ClassNumber_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinedValue = p_DefinedValue;
		}

		public ClassNumber () { }

		// Copy constructor

		public ClassNumber (ClassNumber p_ClassNumber) : base (p_ClassNumber.id, p_ClassNumber.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ClassNumber.appInfo;
			switch ((production_kind) p_ClassNumber.kind)
			{
				case production_kind.g_ClassNumber_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_number = (p_ClassNumber.m_number != null) ? new SyntaxTreeToken (p_ClassNumber.m_number) : null) != null) m_number.parent = this;
					break;
				case production_kind.g_ClassNumber_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinedValue = (p_ClassNumber.m_DefinedValue != null) ? new DefinedValue (p_ClassNumber.m_DefinedValue) : null) != null) m_DefinedValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ClassNumber" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ClassNumber (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_number?.Dispose ();
			m_DefinedValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ClassNumber

		// Content changing function(s) associated with production(s) of syntax rule ClassNumber

		//
		// Content changing function associated with following production(s)
		// ClassNumber -> number

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_ClassNumber_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_number = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ClassNumber -> DefinedValue

		//

		public void change(DefinedValue p_DefinedValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_ClassNumber_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinedValue = p_DefinedValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ClassNumber
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				(m_DefinedValue != null) && m_DefinedValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ClassNumber

		//
		// emit production tree node associated with any production of syntax rule ClassNumber
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ClassNumber_1:
					// emit syntax tree node associated with production
					// ClassNumber: number

					s += m_number.Emit (depth - 1);
				break;
				case production_kind.g_ClassNumber_2:
					// emit syntax tree node associated with production
					// ClassNumber: DefinedValue

					s += m_DefinedValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ClassNumber
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ClassNumber (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ClassNumber_1:
					// emit syntax tree node associated with production
					// ClassNumber: number

					s += "number";
				break;
				case production_kind.g_ClassNumber_2:
					// emit syntax tree node associated with production
					// ClassNumber: DefinedValue

					s += m_DefinedValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ClassNumber

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ClassNumber with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ClassNumber.production_kind kind = (ClassNumber.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ClassNumber.production_kind.g_ClassNumber_1:
					// traverse syntax tree node associated with production
					// ClassNumber: number

						m_number.Visit (visitor, appData);
				break;
				case ClassNumber.production_kind.g_ClassNumber_2:
					// traverse syntax tree node associated with production
					// ClassNumber: DefinedValue

						m_DefinedValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_number?.reparent (this);
			m_DefinedValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ClassNumber
		//

		public void _init ()
		{
			m_number = null;
			m_DefinedValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ClassNumber

		// counter of all nodes associated with syntax rule ClassNumber
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ClassNumber
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		[DataMember (Name = "m_DefinedValue")] public DefinedValue m_DefinedValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ClassNumber

		// delegate function (callback) prototype associated with syntax rule ClassNumber
		public delegate bool ClassNumber_Callback (SyntaxTreeCallbackReason reason, ClassNumber.production_kind kind, ClassNumber p_ClassNumber);

		// event associated with syntax rule ClassNumber
		public event ClassNumber_Callback ClassNumber_Event;

		// event trigger associated with syntax rule ClassNumber
		public bool Raise_ClassNumber_Event (SyntaxTreeCallbackReason reason, ClassNumber.production_kind kind, ClassNumber p_ClassNumber)
		{
			bool? status = ClassNumber_Event?.Invoke (reason, kind, p_ClassNumber);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ClassNumber
		//
		// traverse syntax tree node associated with any production of syntax rule ClassNumber
		//

		public void Traverse (ClassNumber p_ClassNumber)
		{
			if (p_ClassNumber.isLocked())
				return;
			p_ClassNumber.dolock();
			ClassNumber.production_kind kind = (ClassNumber.production_kind) p_ClassNumber.kind;
			p_ClassNumber.turn_reset ();
			if (Raise_ClassNumber_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ClassNumber))
			switch (kind)
			{
				case ClassNumber.production_kind.g_ClassNumber_1:
					// traverse syntax tree node associated with production
					// ClassNumber: number

				break;
				case ClassNumber.production_kind.g_ClassNumber_2:
					// traverse syntax tree node associated with production
					// ClassNumber: DefinedValue

					if (Raise_ClassNumber_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ClassNumber))
						Traverse (p_ClassNumber.m_DefinedValue);
					p_ClassNumber.turn_inc ();
					Raise_ClassNumber_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ClassNumber);
				break;
			}
			Raise_ClassNumber_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ClassNumber);
			p_ClassNumber.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ClassNumber
		//

		public void TraverseCommon (ClassNumber p_ClassNumber)
		{
			ClassNumber.production_kind kind = (ClassNumber.production_kind) p_ClassNumber.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ClassNumber))
			switch (kind)
			{
				case ClassNumber.production_kind.g_ClassNumber_1:
					// traverse syntax tree node associated with production
					// ClassNumber: number

						TraverseCommon (p_ClassNumber.m_number);
				break;
				case ClassNumber.production_kind.g_ClassNumber_2:
					// traverse syntax tree node associated with production
					// ClassNumber: DefinedValue

						TraverseCommon (p_ClassNumber.m_DefinedValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ClassNumber);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ClassNumber

		//
		// create syntax tree node associated with production
		// ClassNumber: number

		//

		public ClassNumber ClassNumber_1 (SyntaxTreeToken p_token)
		{
			ClassNumber p_ClassNumber_ref = new ClassNumber(p_token);
			p_token.parent = p_ClassNumber_ref;
			Raise_ClassNumber_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ClassNumber.production_kind.g_ClassNumber_1, p_ClassNumber_ref);
			return p_ClassNumber_ref;
		}

		//
		// create syntax tree node associated with production
		// ClassNumber: DefinedValue

		//

		public ClassNumber ClassNumber_2 (DefinedValue p_DefinedValue)
		{
			ClassNumber p_ClassNumber_ref = new ClassNumber(p_DefinedValue);
			p_DefinedValue.parent = p_ClassNumber_ref;
			Raise_ClassNumber_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ClassNumber.production_kind.g_ClassNumber_2, p_ClassNumber_ref);
			return p_ClassNumber_ref;
		}
		#endregion
	};
}
