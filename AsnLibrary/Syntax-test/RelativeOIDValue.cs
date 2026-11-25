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
	// class associated with syntax rule RelativeOIDValue
	//

	[DataContract]
	public class	RelativeOIDValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RelativeOIDValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RelativeOIDValue
		{
			g_RelativeOIDValue_1 = 1,	// "{" RelativeOIDComponentsList "}"

		};
		#endregion
		#region production markers associated with the syntax rule RelativeOIDValue

		// markers associated with production: RelativeOIDValue -> "{" RelativeOIDComponentsList "}"

		public enum production_marker_1 : ushort
		{
			m_RelativeOIDComponentsList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RelativeOIDValue

		// Constructor declaration(s) associated with production(s) of syntax rule RelativeOIDValue

		//
		// Constructor associated with the following production(s)
		// RelativeOIDValue -> "{" RelativeOIDComponentsList "}"

		//

		public RelativeOIDValue (SyntaxTreeToken p_token, RelativeOIDComponentsList p_RelativeOIDComponentsList, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._RelativeOIDValue_ID, (uint) production_kind.g_RelativeOIDValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_RelativeOIDComponentsList = p_RelativeOIDComponentsList;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public RelativeOIDValue () { }

		// Copy constructor

		public RelativeOIDValue (RelativeOIDValue p_RelativeOIDValue) : base (p_RelativeOIDValue.id, p_RelativeOIDValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RelativeOIDValue.appInfo;
			switch ((production_kind) p_RelativeOIDValue.kind)
			{
				case production_kind.g_RelativeOIDValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_RelativeOIDValue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_RelativeOIDValue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_RelativeOIDComponentsList = (p_RelativeOIDValue.m_RelativeOIDComponentsList != null) ? new RelativeOIDComponentsList (p_RelativeOIDValue.m_RelativeOIDComponentsList) : null) != null) m_RelativeOIDComponentsList.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_RelativeOIDValue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_RelativeOIDValue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RelativeOIDValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RelativeOIDValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_RelativeOIDComponentsList?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RelativeOIDValue

		// Content changing function(s) associated with production(s) of syntax rule RelativeOIDValue

		//
		// Content changing function associated with following production(s)
		// RelativeOIDValue -> "{" RelativeOIDComponentsList "}"

		//

		public void change(SyntaxTreeToken p_token, RelativeOIDComponentsList p_RelativeOIDComponentsList, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_RelativeOIDValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_RelativeOIDComponentsList = p_RelativeOIDComponentsList;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RelativeOIDValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_RelativeOIDComponentsList != null) && m_RelativeOIDComponentsList.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RelativeOIDValue

		//
		// emit production tree node associated with any production of syntax rule RelativeOIDValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RelativeOIDValue_1:
					// emit syntax tree node associated with production
					// RelativeOIDValue: "{" RelativeOIDComponentsList "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_RelativeOIDComponentsList.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RelativeOIDValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RelativeOIDValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RelativeOIDValue_1:
					// emit syntax tree node associated with production
					// RelativeOIDValue: "{" RelativeOIDComponentsList "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_RelativeOIDComponentsList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RelativeOIDValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RelativeOIDValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RelativeOIDValue.production_kind kind = (RelativeOIDValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RelativeOIDValue.production_kind.g_RelativeOIDValue_1:
					// traverse syntax tree node associated with production
					// RelativeOIDValue: "{" RelativeOIDComponentsList "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_RelativeOIDComponentsList.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_left_curly_bracket?.reparent (this);
			m_RelativeOIDComponentsList?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RelativeOIDValue
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_RelativeOIDComponentsList = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RelativeOIDValue

		// counter of all nodes associated with syntax rule RelativeOIDValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RelativeOIDValue
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_RelativeOIDComponentsList")] public RelativeOIDComponentsList m_RelativeOIDComponentsList { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RelativeOIDValue

		// delegate function (callback) prototype associated with syntax rule RelativeOIDValue
		public delegate bool RelativeOIDValue_Callback (SyntaxTreeCallbackReason reason, RelativeOIDValue.production_kind kind, RelativeOIDValue p_RelativeOIDValue);

		// event associated with syntax rule RelativeOIDValue
		public event RelativeOIDValue_Callback RelativeOIDValue_Event;

		// event trigger associated with syntax rule RelativeOIDValue
		public bool Raise_RelativeOIDValue_Event (SyntaxTreeCallbackReason reason, RelativeOIDValue.production_kind kind, RelativeOIDValue p_RelativeOIDValue)
		{
			bool? status = RelativeOIDValue_Event?.Invoke (reason, kind, p_RelativeOIDValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RelativeOIDValue
		//
		// traverse syntax tree node associated with any production of syntax rule RelativeOIDValue
		//

		public void Traverse (RelativeOIDValue p_RelativeOIDValue)
		{
			if (p_RelativeOIDValue.isLocked())
				return;
			p_RelativeOIDValue.dolock();
			RelativeOIDValue.production_kind kind = (RelativeOIDValue.production_kind) p_RelativeOIDValue.kind;
			p_RelativeOIDValue.turn_reset ();
			if (Raise_RelativeOIDValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RelativeOIDValue))
			switch (kind)
			{
				case RelativeOIDValue.production_kind.g_RelativeOIDValue_1:
					// traverse syntax tree node associated with production
					// RelativeOIDValue: "{" RelativeOIDComponentsList "}"

					if (Raise_RelativeOIDValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RelativeOIDValue))
						Traverse (p_RelativeOIDValue.m_RelativeOIDComponentsList);
					p_RelativeOIDValue.turn_inc ();
					Raise_RelativeOIDValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RelativeOIDValue);
				break;
			}
			Raise_RelativeOIDValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RelativeOIDValue);
			p_RelativeOIDValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RelativeOIDValue
		//

		public void TraverseCommon (RelativeOIDValue p_RelativeOIDValue)
		{
			RelativeOIDValue.production_kind kind = (RelativeOIDValue.production_kind) p_RelativeOIDValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RelativeOIDValue))
			switch (kind)
			{
				case RelativeOIDValue.production_kind.g_RelativeOIDValue_1:
					// traverse syntax tree node associated with production
					// RelativeOIDValue: "{" RelativeOIDComponentsList "}"

						TraverseCommon (p_RelativeOIDValue.m_left_curly_bracket);
						TraverseCommon (p_RelativeOIDValue.m_RelativeOIDComponentsList);
						TraverseCommon (p_RelativeOIDValue.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RelativeOIDValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RelativeOIDValue

		//
		// create syntax tree node associated with production
		// RelativeOIDValue: "{" RelativeOIDComponentsList "}"

		//

		public RelativeOIDValue RelativeOIDValue_1 (SyntaxTreeToken p_token, RelativeOIDComponentsList p_RelativeOIDComponentsList, SyntaxTreeToken p_token_1)
		{
			RelativeOIDValue p_RelativeOIDValue_ref = new RelativeOIDValue(p_token, p_RelativeOIDComponentsList, p_token_1);
			p_token.parent = p_RelativeOIDValue_ref;
			p_RelativeOIDComponentsList.parent = p_RelativeOIDValue_ref;
			p_token_1.parent = p_RelativeOIDValue_ref;
			Raise_RelativeOIDValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RelativeOIDValue.production_kind.g_RelativeOIDValue_1, p_RelativeOIDValue_ref);
			return p_RelativeOIDValue_ref;
		}
		#endregion
	};
}
