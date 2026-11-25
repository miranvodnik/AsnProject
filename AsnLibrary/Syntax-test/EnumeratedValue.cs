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
	// class associated with syntax rule EnumeratedValue
	//

	[DataContract]
	public class	EnumeratedValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EnumeratedValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EnumeratedValue
		{
			g_EnumeratedValue_1 = 1,	// identifier-token

		};
		#endregion
		#region production markers associated with the syntax rule EnumeratedValue

		// markers associated with production: EnumeratedValue -> identifier-token

		public enum production_marker_1 : ushort
		{
			m_identifier_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EnumeratedValue

		// Constructor declaration(s) associated with production(s) of syntax rule EnumeratedValue

		//
		// Constructor associated with the following production(s)
		// EnumeratedValue -> identifier-token

		//

		public EnumeratedValue (identifier_token p_identifier_token) : base ((uint) ProductionID._EnumeratedValue_ID, (uint) production_kind.g_EnumeratedValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_identifier_token = p_identifier_token;
		}

		public EnumeratedValue () { }

		// Copy constructor

		public EnumeratedValue (EnumeratedValue p_EnumeratedValue) : base (p_EnumeratedValue.id, p_EnumeratedValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EnumeratedValue.appInfo;
			switch ((production_kind) p_EnumeratedValue.kind)
			{
				case production_kind.g_EnumeratedValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_identifier_token = (p_EnumeratedValue.m_identifier_token != null) ? new identifier_token (p_EnumeratedValue.m_identifier_token) : null) != null) m_identifier_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EnumeratedValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EnumeratedValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_identifier_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EnumeratedValue

		// Content changing function(s) associated with production(s) of syntax rule EnumeratedValue

		//
		// Content changing function associated with following production(s)
		// EnumeratedValue -> identifier-token

		//

		public void change(identifier_token p_identifier_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_EnumeratedValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_identifier_token = p_identifier_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EnumeratedValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_identifier_token != null) && m_identifier_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EnumeratedValue

		//
		// emit production tree node associated with any production of syntax rule EnumeratedValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EnumeratedValue_1:
					// emit syntax tree node associated with production
					// EnumeratedValue: identifier-token

					s += m_identifier_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EnumeratedValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EnumeratedValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EnumeratedValue_1:
					// emit syntax tree node associated with production
					// EnumeratedValue: identifier-token

					s += m_identifier_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EnumeratedValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EnumeratedValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EnumeratedValue.production_kind kind = (EnumeratedValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EnumeratedValue.production_kind.g_EnumeratedValue_1:
					// traverse syntax tree node associated with production
					// EnumeratedValue: identifier-token

						m_identifier_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_identifier_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule EnumeratedValue
		//

		public void _init ()
		{
			m_identifier_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EnumeratedValue

		// counter of all nodes associated with syntax rule EnumeratedValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EnumeratedValue
		[DataMember (Name = "m_identifier_token")] public identifier_token m_identifier_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EnumeratedValue

		// delegate function (callback) prototype associated with syntax rule EnumeratedValue
		public delegate bool EnumeratedValue_Callback (SyntaxTreeCallbackReason reason, EnumeratedValue.production_kind kind, EnumeratedValue p_EnumeratedValue);

		// event associated with syntax rule EnumeratedValue
		public event EnumeratedValue_Callback EnumeratedValue_Event;

		// event trigger associated with syntax rule EnumeratedValue
		public bool Raise_EnumeratedValue_Event (SyntaxTreeCallbackReason reason, EnumeratedValue.production_kind kind, EnumeratedValue p_EnumeratedValue)
		{
			bool? status = EnumeratedValue_Event?.Invoke (reason, kind, p_EnumeratedValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EnumeratedValue
		//
		// traverse syntax tree node associated with any production of syntax rule EnumeratedValue
		//

		public void Traverse (EnumeratedValue p_EnumeratedValue)
		{
			if (p_EnumeratedValue.isLocked())
				return;
			p_EnumeratedValue.dolock();
			EnumeratedValue.production_kind kind = (EnumeratedValue.production_kind) p_EnumeratedValue.kind;
			p_EnumeratedValue.turn_reset ();
			if (Raise_EnumeratedValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EnumeratedValue))
			switch (kind)
			{
				case EnumeratedValue.production_kind.g_EnumeratedValue_1:
					// traverse syntax tree node associated with production
					// EnumeratedValue: identifier-token

					if (Raise_EnumeratedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EnumeratedValue))
						Traverse (p_EnumeratedValue.m_identifier_token);
					p_EnumeratedValue.turn_inc ();
					Raise_EnumeratedValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EnumeratedValue);
				break;
			}
			Raise_EnumeratedValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EnumeratedValue);
			p_EnumeratedValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EnumeratedValue
		//

		public void TraverseCommon (EnumeratedValue p_EnumeratedValue)
		{
			EnumeratedValue.production_kind kind = (EnumeratedValue.production_kind) p_EnumeratedValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EnumeratedValue))
			switch (kind)
			{
				case EnumeratedValue.production_kind.g_EnumeratedValue_1:
					// traverse syntax tree node associated with production
					// EnumeratedValue: identifier-token

						TraverseCommon (p_EnumeratedValue.m_identifier_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EnumeratedValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EnumeratedValue

		//
		// create syntax tree node associated with production
		// EnumeratedValue: identifier-token

		//

		public EnumeratedValue EnumeratedValue_1 (identifier_token p_identifier_token)
		{
			EnumeratedValue p_EnumeratedValue_ref = new EnumeratedValue(p_identifier_token);
			p_identifier_token.parent = p_EnumeratedValue_ref;
			Raise_EnumeratedValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EnumeratedValue.production_kind.g_EnumeratedValue_1, p_EnumeratedValue_ref);
			return p_EnumeratedValue_ref;
		}
		#endregion
	};
}
