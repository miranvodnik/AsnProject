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
	// class associated with syntax rule ExceptionSpec
	//

	[DataContract]
	public class	ExceptionSpec : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExceptionSpec
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExceptionSpec
		{
			g_ExceptionSpec_1 = 1,	// "!" ExceptionIdentification

			g_ExceptionSpec_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule ExceptionSpec

		// markers associated with production: ExceptionSpec -> "!" ExceptionIdentification

		public enum production_marker_1 : ushort
		{
			m_ExceptionIdentification,
			final
		};

		// markers associated with production: ExceptionSpec -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExceptionSpec

		// Constructor declaration(s) associated with production(s) of syntax rule ExceptionSpec

		//
		// Constructor associated with the following production(s)
		// ExceptionSpec -> "!" ExceptionIdentification

		//

		public ExceptionSpec (SyntaxTreeToken p_token, ExceptionIdentification p_ExceptionIdentification) : base ((uint) ProductionID._ExceptionSpec_ID, (uint) production_kind.g_ExceptionSpec_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_exclamation_mark = p_token;
			children[1] = m_ExceptionIdentification = p_ExceptionIdentification;
		}

		//
		// Constructor associated with the following production(s)
		// ExceptionSpec -> %empty

		//

		public ExceptionSpec () : base ((uint) ProductionID._ExceptionSpec_ID, (uint) production_kind.g_ExceptionSpec_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public ExceptionSpec (ExceptionSpec p_ExceptionSpec) : base (p_ExceptionSpec.id, p_ExceptionSpec.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExceptionSpec.appInfo;
			switch ((production_kind) p_ExceptionSpec.kind)
			{
				case production_kind.g_ExceptionSpec_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_exclamation_mark = (p_ExceptionSpec.m_exclamation_mark != null) ? new SyntaxTreeToken (p_ExceptionSpec.m_exclamation_mark) : null) != null) m_exclamation_mark.parent = this;
					if ((children [1] = m_ExceptionIdentification = (p_ExceptionSpec.m_ExceptionIdentification != null) ? new ExceptionIdentification (p_ExceptionSpec.m_ExceptionIdentification) : null) != null) m_ExceptionIdentification.parent = this;
					break;
				case production_kind.g_ExceptionSpec_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "ExceptionSpec" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExceptionSpec (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_exclamation_mark?.Dispose ();
			m_ExceptionIdentification?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExceptionSpec

		// Content changing function(s) associated with production(s) of syntax rule ExceptionSpec

		//
		// Content changing function associated with following production(s)
		// ExceptionSpec -> "!" ExceptionIdentification

		//

		public void change(SyntaxTreeToken p_token, ExceptionIdentification p_ExceptionIdentification)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExceptionSpec_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_exclamation_mark = p_token;
			children [1] = m_ExceptionIdentification = p_ExceptionIdentification;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ExceptionSpec -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_ExceptionSpec_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExceptionSpec
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_exclamation_mark != null) && m_exclamation_mark.checkInclusion (element) ||
				(m_ExceptionIdentification != null) && m_ExceptionIdentification.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExceptionSpec

		//
		// emit production tree node associated with any production of syntax rule ExceptionSpec
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExceptionSpec_1:
					// emit syntax tree node associated with production
					// ExceptionSpec: "!" ExceptionIdentification

					s += m_exclamation_mark.Emit (depth - 1);
					s += " ";
					s += m_ExceptionIdentification.Emit (depth - 1);
				break;
				case production_kind.g_ExceptionSpec_2:
					// emit syntax tree node associated with production
					// ExceptionSpec: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExceptionSpec
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExceptionSpec (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExceptionSpec_1:
					// emit syntax tree node associated with production
					// ExceptionSpec: "!" ExceptionIdentification

					s += "exclamation_mark";
					s += ' ';
					s += m_ExceptionIdentification.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ExceptionSpec_2:
					// emit syntax tree node associated with production
					// ExceptionSpec: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExceptionSpec

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExceptionSpec with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExceptionSpec.production_kind kind = (ExceptionSpec.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExceptionSpec.production_kind.g_ExceptionSpec_1:
					// traverse syntax tree node associated with production
					// ExceptionSpec: "!" ExceptionIdentification

						m_exclamation_mark.Visit (visitor, appData);
						m_ExceptionIdentification.Visit (visitor, appData);
				break;
				case ExceptionSpec.production_kind.g_ExceptionSpec_2:
					// traverse syntax tree node associated with production
					// ExceptionSpec: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_exclamation_mark?.reparent (this);
			m_ExceptionIdentification?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExceptionSpec
		//

		public void _init ()
		{
			m_exclamation_mark = null;
			m_ExceptionIdentification = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExceptionSpec

		// counter of all nodes associated with syntax rule ExceptionSpec
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExceptionSpec
		[DataMember (Name = "m_exclamation_mark")] public SyntaxTreeToken m_exclamation_mark { get; private set; }
		[DataMember (Name = "m_ExceptionIdentification")] public ExceptionIdentification m_ExceptionIdentification { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExceptionSpec

		// delegate function (callback) prototype associated with syntax rule ExceptionSpec
		public delegate bool ExceptionSpec_Callback (SyntaxTreeCallbackReason reason, ExceptionSpec.production_kind kind, ExceptionSpec p_ExceptionSpec);

		// event associated with syntax rule ExceptionSpec
		public event ExceptionSpec_Callback ExceptionSpec_Event;

		// event trigger associated with syntax rule ExceptionSpec
		public bool Raise_ExceptionSpec_Event (SyntaxTreeCallbackReason reason, ExceptionSpec.production_kind kind, ExceptionSpec p_ExceptionSpec)
		{
			bool? status = ExceptionSpec_Event?.Invoke (reason, kind, p_ExceptionSpec);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExceptionSpec
		//
		// traverse syntax tree node associated with any production of syntax rule ExceptionSpec
		//

		public void Traverse (ExceptionSpec p_ExceptionSpec)
		{
			if (p_ExceptionSpec.isLocked())
				return;
			p_ExceptionSpec.dolock();
			ExceptionSpec.production_kind kind = (ExceptionSpec.production_kind) p_ExceptionSpec.kind;
			p_ExceptionSpec.turn_reset ();
			if (Raise_ExceptionSpec_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExceptionSpec))
			switch (kind)
			{
				case ExceptionSpec.production_kind.g_ExceptionSpec_1:
					// traverse syntax tree node associated with production
					// ExceptionSpec: "!" ExceptionIdentification

					if (Raise_ExceptionSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExceptionSpec))
						Traverse (p_ExceptionSpec.m_ExceptionIdentification);
					p_ExceptionSpec.turn_inc ();
					Raise_ExceptionSpec_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExceptionSpec);
				break;
				case ExceptionSpec.production_kind.g_ExceptionSpec_2:
					// traverse syntax tree node associated with production
					// ExceptionSpec: %empty

				break;
			}
			Raise_ExceptionSpec_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExceptionSpec);
			p_ExceptionSpec.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExceptionSpec
		//

		public void TraverseCommon (ExceptionSpec p_ExceptionSpec)
		{
			ExceptionSpec.production_kind kind = (ExceptionSpec.production_kind) p_ExceptionSpec.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExceptionSpec))
			switch (kind)
			{
				case ExceptionSpec.production_kind.g_ExceptionSpec_1:
					// traverse syntax tree node associated with production
					// ExceptionSpec: "!" ExceptionIdentification

						TraverseCommon (p_ExceptionSpec.m_exclamation_mark);
						TraverseCommon (p_ExceptionSpec.m_ExceptionIdentification);
				break;
				case ExceptionSpec.production_kind.g_ExceptionSpec_2:
					// traverse syntax tree node associated with production
					// ExceptionSpec: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExceptionSpec);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExceptionSpec

		//
		// create syntax tree node associated with production
		// ExceptionSpec: "!" ExceptionIdentification

		//

		public ExceptionSpec ExceptionSpec_1 (SyntaxTreeToken p_token, ExceptionIdentification p_ExceptionIdentification)
		{
			ExceptionSpec p_ExceptionSpec_ref = new ExceptionSpec(p_token, p_ExceptionIdentification);
			p_token.parent = p_ExceptionSpec_ref;
			p_ExceptionIdentification.parent = p_ExceptionSpec_ref;
			Raise_ExceptionSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExceptionSpec.production_kind.g_ExceptionSpec_1, p_ExceptionSpec_ref);
			return p_ExceptionSpec_ref;
		}

		//
		// create syntax tree node associated with production
		// ExceptionSpec: %empty

		//

		public ExceptionSpec ExceptionSpec_2 ()
		{
			ExceptionSpec p_ExceptionSpec_ref = new ExceptionSpec();
			Raise_ExceptionSpec_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExceptionSpec.production_kind.g_ExceptionSpec_2, p_ExceptionSpec_ref);
			return p_ExceptionSpec_ref;
		}
		#endregion
	};
}
