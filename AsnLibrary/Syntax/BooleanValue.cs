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
	// class associated with syntax rule BooleanValue
	//

	[DataContract]
	public class	BooleanValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule BooleanValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule BooleanValue
		{
			g_BooleanValue_1 = 1,	// TRUE

			g_BooleanValue_2 = 2,	// FALSE

		};
		#endregion
		#region production markers associated with the syntax rule BooleanValue

		// markers associated with production: BooleanValue -> TRUE

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: BooleanValue -> FALSE

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule BooleanValue

		// Constructor declaration(s) associated with production(s) of syntax rule BooleanValue

		//
		// Constructor associated with the following production(s)
		// BooleanValue -> TRUE

		// BooleanValue -> FALSE

		//

		public BooleanValue (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._BooleanValue_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_BooleanValue_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_TRUE = p_token;
				break;
			case production_kind.g_BooleanValue_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_FALSE = p_token;
				break;
			default:
				{
					string[] args = new string[] { "BooleanValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public BooleanValue () { }

		// Copy constructor

		public BooleanValue (BooleanValue p_BooleanValue) : base (p_BooleanValue.id, p_BooleanValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_BooleanValue.appInfo;
			switch ((production_kind) p_BooleanValue.kind)
			{
				case production_kind.g_BooleanValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TRUE = (p_BooleanValue.m_TRUE != null) ? new SyntaxTreeToken (p_BooleanValue.m_TRUE) : null) != null) m_TRUE.parent = this;
					break;
				case production_kind.g_BooleanValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_FALSE = (p_BooleanValue.m_FALSE != null) ? new SyntaxTreeToken (p_BooleanValue.m_FALSE) : null) != null) m_FALSE.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "BooleanValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new BooleanValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_TRUE?.Dispose ();
			m_FALSE?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule BooleanValue

		// Content changing function(s) associated with production(s) of syntax rule BooleanValue

		//
		// Content changing function associated with following production(s)
		// BooleanValue -> TRUE

		// BooleanValue -> FALSE

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_BooleanValue_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_TRUE = p_token;
				break;
			case production_kind.g_BooleanValue_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_FALSE = p_token;
				break;
			default:
				{
					string[] args = new string[] { "BooleanValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule BooleanValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_TRUE != null) && m_TRUE.checkInclusion (element) ||
				(m_FALSE != null) && m_FALSE.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule BooleanValue

		//
		// emit production tree node associated with any production of syntax rule BooleanValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_BooleanValue_1:
					// emit syntax tree node associated with production
					// BooleanValue: TRUE

					s += m_TRUE.Emit (depth - 1);
				break;
				case production_kind.g_BooleanValue_2:
					// emit syntax tree node associated with production
					// BooleanValue: FALSE

					s += m_FALSE.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule BooleanValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "BooleanValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_BooleanValue_1:
					// emit syntax tree node associated with production
					// BooleanValue: TRUE

					s += "TRUE";
				break;
				case production_kind.g_BooleanValue_2:
					// emit syntax tree node associated with production
					// BooleanValue: FALSE

					s += "FALSE";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule BooleanValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule BooleanValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			BooleanValue.production_kind kind = (BooleanValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case BooleanValue.production_kind.g_BooleanValue_1:
					// traverse syntax tree node associated with production
					// BooleanValue: TRUE

						m_TRUE.Visit (visitor, appData);
				break;
				case BooleanValue.production_kind.g_BooleanValue_2:
					// traverse syntax tree node associated with production
					// BooleanValue: FALSE

						m_FALSE.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_TRUE?.reparent (this);
			m_FALSE?.reparent (this);
		}

		//
		// initialize object associated with syntax rule BooleanValue
		//

		public void _init ()
		{
			m_TRUE = null;
			m_FALSE = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule BooleanValue

		// counter of all nodes associated with syntax rule BooleanValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule BooleanValue
		[DataMember (Name = "m_TRUE")] public SyntaxTreeToken m_TRUE { get; private set; }
		[DataMember (Name = "m_FALSE")] public SyntaxTreeToken m_FALSE { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule BooleanValue

		// delegate function (callback) prototype associated with syntax rule BooleanValue
		public delegate bool BooleanValue_Callback (SyntaxTreeCallbackReason reason, BooleanValue.production_kind kind, BooleanValue p_BooleanValue);

		// event associated with syntax rule BooleanValue
		public event BooleanValue_Callback BooleanValue_Event;

		// event trigger associated with syntax rule BooleanValue
		public bool Raise_BooleanValue_Event (SyntaxTreeCallbackReason reason, BooleanValue.production_kind kind, BooleanValue p_BooleanValue)
		{
			bool? status = BooleanValue_Event?.Invoke (reason, kind, p_BooleanValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule BooleanValue
		//
		// traverse syntax tree node associated with any production of syntax rule BooleanValue
		//

		public void Traverse (BooleanValue p_BooleanValue)
		{
			if (p_BooleanValue.isLocked())
				return;
			p_BooleanValue.dolock();
			BooleanValue.production_kind kind = (BooleanValue.production_kind) p_BooleanValue.kind;
			p_BooleanValue.turn_reset ();
			if (Raise_BooleanValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_BooleanValue))
			switch (kind)
			{
				case BooleanValue.production_kind.g_BooleanValue_1:
					// traverse syntax tree node associated with production
					// BooleanValue: TRUE

				break;
				case BooleanValue.production_kind.g_BooleanValue_2:
					// traverse syntax tree node associated with production
					// BooleanValue: FALSE

				break;
			}
			Raise_BooleanValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_BooleanValue);
			p_BooleanValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule BooleanValue
		//

		public void TraverseCommon (BooleanValue p_BooleanValue)
		{
			BooleanValue.production_kind kind = (BooleanValue.production_kind) p_BooleanValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_BooleanValue))
			switch (kind)
			{
				case BooleanValue.production_kind.g_BooleanValue_1:
					// traverse syntax tree node associated with production
					// BooleanValue: TRUE

						TraverseCommon (p_BooleanValue.m_TRUE);
				break;
				case BooleanValue.production_kind.g_BooleanValue_2:
					// traverse syntax tree node associated with production
					// BooleanValue: FALSE

						TraverseCommon (p_BooleanValue.m_FALSE);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_BooleanValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule BooleanValue

		//
		// create syntax tree node associated with production
		// BooleanValue: TRUE

		//

		public BooleanValue BooleanValue_1 (SyntaxTreeToken p_token)
		{
			BooleanValue p_BooleanValue_ref = new BooleanValue(p_token, 1);
			p_token.parent = p_BooleanValue_ref;
			Raise_BooleanValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BooleanValue.production_kind.g_BooleanValue_1, p_BooleanValue_ref);
			return p_BooleanValue_ref;
		}

		//
		// create syntax tree node associated with production
		// BooleanValue: FALSE

		//

		public BooleanValue BooleanValue_2 (SyntaxTreeToken p_token)
		{
			BooleanValue p_BooleanValue_ref = new BooleanValue(p_token, 2);
			p_token.parent = p_BooleanValue_ref;
			Raise_BooleanValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, BooleanValue.production_kind.g_BooleanValue_2, p_BooleanValue_ref);
			return p_BooleanValue_ref;
		}
		#endregion
	};
}
