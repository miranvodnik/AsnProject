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
	// class associated with syntax rule ExtensionAndException
	//

	[DataContract]
	public class	ExtensionAndException : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExtensionAndException
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExtensionAndException
		{
			g_ExtensionAndException_1 = 1,	// "." "." "." ExceptionSpec

		};
		#endregion
		#region production markers associated with the syntax rule ExtensionAndException

		// markers associated with production: ExtensionAndException -> "." "." "." ExceptionSpec

		public enum production_marker_1 : ushort
		{
			m_ExceptionSpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExtensionAndException

		// Constructor declaration(s) associated with production(s) of syntax rule ExtensionAndException

		//
		// Constructor associated with the following production(s)
		// ExtensionAndException -> "." "." "." ExceptionSpec

		//

		public ExtensionAndException (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, ExceptionSpec p_ExceptionSpec) : base ((uint) ProductionID._ExtensionAndException_ID, (uint) production_kind.g_ExtensionAndException_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_dot = p_token;
			children[1] = m_dot_1 = p_token_1;
			children[2] = m_dot_2 = p_token_2;
			children[3] = m_ExceptionSpec = p_ExceptionSpec;
		}

		public ExtensionAndException () { }

		// Copy constructor

		public ExtensionAndException (ExtensionAndException p_ExtensionAndException) : base (p_ExtensionAndException.id, p_ExtensionAndException.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExtensionAndException.appInfo;
			switch ((production_kind) p_ExtensionAndException.kind)
			{
				case production_kind.g_ExtensionAndException_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_dot = (p_ExtensionAndException.m_dot != null) ? new SyntaxTreeToken (p_ExtensionAndException.m_dot) : null) != null) m_dot.parent = this;
					if ((children [1] = m_dot_1 = (p_ExtensionAndException.m_dot_1 != null) ? new SyntaxTreeToken (p_ExtensionAndException.m_dot_1) : null) != null) m_dot_1.parent = this;
					if ((children [2] = m_dot_2 = (p_ExtensionAndException.m_dot_2 != null) ? new SyntaxTreeToken (p_ExtensionAndException.m_dot_2) : null) != null) m_dot_2.parent = this;
					if ((children [3] = m_ExceptionSpec = (p_ExtensionAndException.m_ExceptionSpec != null) ? new ExceptionSpec (p_ExtensionAndException.m_ExceptionSpec) : null) != null) m_ExceptionSpec.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ExtensionAndException" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExtensionAndException (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_dot?.Dispose ();
			m_dot_1?.Dispose ();
			m_dot_2?.Dispose ();
			m_ExceptionSpec?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExtensionAndException

		// Content changing function(s) associated with production(s) of syntax rule ExtensionAndException

		//
		// Content changing function associated with following production(s)
		// ExtensionAndException -> "." "." "." ExceptionSpec

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, ExceptionSpec p_ExceptionSpec)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionAndException_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_dot = p_token;
			children [1] = m_dot_1 = p_token_1;
			children [2] = m_dot_2 = p_token_2;
			children [3] = m_ExceptionSpec = p_ExceptionSpec;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExtensionAndException
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_dot != null) && m_dot.checkInclusion (element) ||
				(m_dot_1 != null) && m_dot_1.checkInclusion (element) ||
				(m_dot_2 != null) && m_dot_2.checkInclusion (element) ||
				(m_ExceptionSpec != null) && m_ExceptionSpec.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExtensionAndException

		//
		// emit production tree node associated with any production of syntax rule ExtensionAndException
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExtensionAndException_1:
					// emit syntax tree node associated with production
					// ExtensionAndException: "." "." "." ExceptionSpec

					s += m_dot.Emit (depth - 1);
					s += " ";
					s += m_dot_1.Emit (depth - 1);
					s += " ";
					s += m_dot_2.Emit (depth - 1);
					s += " ";
					s += m_ExceptionSpec.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExtensionAndException
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExtensionAndException (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExtensionAndException_1:
					// emit syntax tree node associated with production
					// ExtensionAndException: "." "." "." ExceptionSpec

					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += "dot";
					s += ' ';
					s += m_ExceptionSpec.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExtensionAndException

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAndException with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExtensionAndException.production_kind kind = (ExtensionAndException.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExtensionAndException.production_kind.g_ExtensionAndException_1:
					// traverse syntax tree node associated with production
					// ExtensionAndException: "." "." "." ExceptionSpec

						m_dot.Visit (visitor, appData);
						m_dot_1.Visit (visitor, appData);
						m_dot_2.Visit (visitor, appData);
						m_ExceptionSpec.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_dot?.reparent (this);
			m_dot_1?.reparent (this);

			m_dot_2?.reparent (this);

			m_ExceptionSpec?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExtensionAndException
		//

		public void _init ()
		{
			m_dot = null;
			m_dot_1 = null;
			m_dot_2 = null;
			m_ExceptionSpec = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExtensionAndException

		// counter of all nodes associated with syntax rule ExtensionAndException
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExtensionAndException
		[DataMember (Name = "m_dot")] public SyntaxTreeToken m_dot { get; private set; }
		[DataMember (Name = "m_dot_1")] public SyntaxTreeToken m_dot_1 { get; private set; }
		[DataMember (Name = "m_dot_2")] public SyntaxTreeToken m_dot_2 { get; private set; }
		[DataMember (Name = "m_ExceptionSpec")] public ExceptionSpec m_ExceptionSpec { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExtensionAndException

		// delegate function (callback) prototype associated with syntax rule ExtensionAndException
		public delegate bool ExtensionAndException_Callback (SyntaxTreeCallbackReason reason, ExtensionAndException.production_kind kind, ExtensionAndException p_ExtensionAndException);

		// event associated with syntax rule ExtensionAndException
		public event ExtensionAndException_Callback ExtensionAndException_Event;

		// event trigger associated with syntax rule ExtensionAndException
		public bool Raise_ExtensionAndException_Event (SyntaxTreeCallbackReason reason, ExtensionAndException.production_kind kind, ExtensionAndException p_ExtensionAndException)
		{
			bool? status = ExtensionAndException_Event?.Invoke (reason, kind, p_ExtensionAndException);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExtensionAndException
		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAndException
		//

		public void Traverse (ExtensionAndException p_ExtensionAndException)
		{
			if (p_ExtensionAndException.isLocked())
				return;
			p_ExtensionAndException.dolock();
			ExtensionAndException.production_kind kind = (ExtensionAndException.production_kind) p_ExtensionAndException.kind;
			p_ExtensionAndException.turn_reset ();
			if (Raise_ExtensionAndException_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExtensionAndException))
			switch (kind)
			{
				case ExtensionAndException.production_kind.g_ExtensionAndException_1:
					// traverse syntax tree node associated with production
					// ExtensionAndException: "." "." "." ExceptionSpec

					if (Raise_ExtensionAndException_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAndException))
						Traverse (p_ExtensionAndException.m_ExceptionSpec);
					p_ExtensionAndException.turn_inc ();
					Raise_ExtensionAndException_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ExtensionAndException);
				break;
			}
			Raise_ExtensionAndException_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExtensionAndException);
			p_ExtensionAndException.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionAndException
		//

		public void TraverseCommon (ExtensionAndException p_ExtensionAndException)
		{
			ExtensionAndException.production_kind kind = (ExtensionAndException.production_kind) p_ExtensionAndException.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExtensionAndException))
			switch (kind)
			{
				case ExtensionAndException.production_kind.g_ExtensionAndException_1:
					// traverse syntax tree node associated with production
					// ExtensionAndException: "." "." "." ExceptionSpec

						TraverseCommon (p_ExtensionAndException.m_dot);
						TraverseCommon (p_ExtensionAndException.m_dot_1);
						TraverseCommon (p_ExtensionAndException.m_dot_2);
						TraverseCommon (p_ExtensionAndException.m_ExceptionSpec);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExtensionAndException);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExtensionAndException

		//
		// create syntax tree node associated with production
		// ExtensionAndException: "." "." "." ExceptionSpec

		//

		public ExtensionAndException ExtensionAndException_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, ExceptionSpec p_ExceptionSpec)
		{
			ExtensionAndException p_ExtensionAndException_ref = new ExtensionAndException(p_token, p_token_1, p_token_2, p_ExceptionSpec);
			p_token.parent = p_ExtensionAndException_ref;
			p_token_1.parent = p_ExtensionAndException_ref;
			p_token_2.parent = p_ExtensionAndException_ref;
			p_ExceptionSpec.parent = p_ExtensionAndException_ref;
			Raise_ExtensionAndException_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionAndException.production_kind.g_ExtensionAndException_1, p_ExtensionAndException_ref);
			return p_ExtensionAndException_ref;
		}
		#endregion
	};
}
