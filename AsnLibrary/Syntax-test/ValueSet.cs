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
	// class associated with syntax rule ValueSet
	//

	[DataContract]
	public class	ValueSet : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ValueSet
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ValueSet
		{
			g_ValueSet_1 = 1,	// "{" VSElementSetSpecs "}"

		};
		#endregion
		#region production markers associated with the syntax rule ValueSet

		// markers associated with production: ValueSet -> "{" VSElementSetSpecs "}"

		public enum production_marker_1 : ushort
		{
			m_VSElementSetSpecs,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ValueSet

		// Constructor declaration(s) associated with production(s) of syntax rule ValueSet

		//
		// Constructor associated with the following production(s)
		// ValueSet -> "{" VSElementSetSpecs "}"

		//

		public ValueSet (SyntaxTreeToken p_token, VSElementSetSpecs p_VSElementSetSpecs, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._ValueSet_ID, (uint) production_kind.g_ValueSet_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_VSElementSetSpecs = p_VSElementSetSpecs;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public ValueSet () { }

		// Copy constructor

		public ValueSet (ValueSet p_ValueSet) : base (p_ValueSet.id, p_ValueSet.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ValueSet.appInfo;
			switch ((production_kind) p_ValueSet.kind)
			{
				case production_kind.g_ValueSet_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_ValueSet.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_ValueSet.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_VSElementSetSpecs = (p_ValueSet.m_VSElementSetSpecs != null) ? new VSElementSetSpecs (p_ValueSet.m_VSElementSetSpecs) : null) != null) m_VSElementSetSpecs.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_ValueSet.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_ValueSet.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ValueSet" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ValueSet (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_VSElementSetSpecs?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ValueSet

		// Content changing function(s) associated with production(s) of syntax rule ValueSet

		//
		// Content changing function associated with following production(s)
		// ValueSet -> "{" VSElementSetSpecs "}"

		//

		public void change(SyntaxTreeToken p_token, VSElementSetSpecs p_VSElementSetSpecs, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_ValueSet_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_VSElementSetSpecs = p_VSElementSetSpecs;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ValueSet
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_VSElementSetSpecs != null) && m_VSElementSetSpecs.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ValueSet

		//
		// emit production tree node associated with any production of syntax rule ValueSet
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ValueSet_1:
					// emit syntax tree node associated with production
					// ValueSet: "{" VSElementSetSpecs "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_VSElementSetSpecs.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ValueSet
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ValueSet (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ValueSet_1:
					// emit syntax tree node associated with production
					// ValueSet: "{" VSElementSetSpecs "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_VSElementSetSpecs.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ValueSet

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ValueSet with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ValueSet.production_kind kind = (ValueSet.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ValueSet.production_kind.g_ValueSet_1:
					// traverse syntax tree node associated with production
					// ValueSet: "{" VSElementSetSpecs "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_VSElementSetSpecs.Visit (visitor, appData);
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
			m_VSElementSetSpecs?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ValueSet
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_VSElementSetSpecs = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ValueSet

		// counter of all nodes associated with syntax rule ValueSet
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ValueSet
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_VSElementSetSpecs")] public VSElementSetSpecs m_VSElementSetSpecs { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ValueSet

		// delegate function (callback) prototype associated with syntax rule ValueSet
		public delegate bool ValueSet_Callback (SyntaxTreeCallbackReason reason, ValueSet.production_kind kind, ValueSet p_ValueSet);

		// event associated with syntax rule ValueSet
		public event ValueSet_Callback ValueSet_Event;

		// event trigger associated with syntax rule ValueSet
		public bool Raise_ValueSet_Event (SyntaxTreeCallbackReason reason, ValueSet.production_kind kind, ValueSet p_ValueSet)
		{
			bool? status = ValueSet_Event?.Invoke (reason, kind, p_ValueSet);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ValueSet
		//
		// traverse syntax tree node associated with any production of syntax rule ValueSet
		//

		public void Traverse (ValueSet p_ValueSet)
		{
			if (p_ValueSet.isLocked())
				return;
			p_ValueSet.dolock();
			ValueSet.production_kind kind = (ValueSet.production_kind) p_ValueSet.kind;
			p_ValueSet.turn_reset ();
			if (Raise_ValueSet_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ValueSet))
			switch (kind)
			{
				case ValueSet.production_kind.g_ValueSet_1:
					// traverse syntax tree node associated with production
					// ValueSet: "{" VSElementSetSpecs "}"

					if (Raise_ValueSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueSet))
						Traverse (p_ValueSet.m_VSElementSetSpecs);
					p_ValueSet.turn_inc ();
					Raise_ValueSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ValueSet);
				break;
			}
			Raise_ValueSet_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ValueSet);
			p_ValueSet.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ValueSet
		//

		public void TraverseCommon (ValueSet p_ValueSet)
		{
			ValueSet.production_kind kind = (ValueSet.production_kind) p_ValueSet.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ValueSet))
			switch (kind)
			{
				case ValueSet.production_kind.g_ValueSet_1:
					// traverse syntax tree node associated with production
					// ValueSet: "{" VSElementSetSpecs "}"

						TraverseCommon (p_ValueSet.m_left_curly_bracket);
						TraverseCommon (p_ValueSet.m_VSElementSetSpecs);
						TraverseCommon (p_ValueSet.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ValueSet);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ValueSet

		//
		// create syntax tree node associated with production
		// ValueSet: "{" VSElementSetSpecs "}"

		//

		public ValueSet ValueSet_1 (SyntaxTreeToken p_token, VSElementSetSpecs p_VSElementSetSpecs, SyntaxTreeToken p_token_1)
		{
			ValueSet p_ValueSet_ref = new ValueSet(p_token, p_VSElementSetSpecs, p_token_1);
			p_token.parent = p_ValueSet_ref;
			p_VSElementSetSpecs.parent = p_ValueSet_ref;
			p_token_1.parent = p_ValueSet_ref;
			Raise_ValueSet_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ValueSet.production_kind.g_ValueSet_1, p_ValueSet_ref);
			return p_ValueSet_ref;
		}
		#endregion
	};
}
