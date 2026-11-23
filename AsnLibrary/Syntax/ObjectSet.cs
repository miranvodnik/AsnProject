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
	// class associated with syntax rule ObjectSet
	//

	[DataContract]
	public class	ObjectSet : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectSet
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectSet
		{
			g_ObjectSet_1 = 1,	// "{" ObjectSetSpec "}"

		};
		#endregion
		#region production markers associated with the syntax rule ObjectSet

		// markers associated with production: ObjectSet -> "{" ObjectSetSpec "}"

		public enum production_marker_1 : ushort
		{
			m_ObjectSetSpec,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectSet

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectSet

		//
		// Constructor associated with the following production(s)
		// ObjectSet -> "{" ObjectSetSpec "}"

		//

		public ObjectSet (SyntaxTreeToken p_token, ObjectSetSpec p_ObjectSetSpec, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._ObjectSet_ID, (uint) production_kind.g_ObjectSet_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_ObjectSetSpec = p_ObjectSetSpec;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public ObjectSet () { }

		// Copy constructor

		public ObjectSet (ObjectSet p_ObjectSet) : base (p_ObjectSet.id, p_ObjectSet.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectSet.appInfo;
			switch ((production_kind) p_ObjectSet.kind)
			{
				case production_kind.g_ObjectSet_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_ObjectSet.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_ObjectSet.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_ObjectSetSpec = (p_ObjectSet.m_ObjectSetSpec != null) ? new ObjectSetSpec (p_ObjectSet.m_ObjectSetSpec) : null) != null) m_ObjectSetSpec.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_ObjectSet.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_ObjectSet.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectSet" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectSet (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_ObjectSetSpec?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectSet

		// Content changing function(s) associated with production(s) of syntax rule ObjectSet

		//
		// Content changing function associated with following production(s)
		// ObjectSet -> "{" ObjectSetSpec "}"

		//

		public void change(SyntaxTreeToken p_token, ObjectSetSpec p_ObjectSetSpec, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectSet_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_ObjectSetSpec = p_ObjectSetSpec;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectSet
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_ObjectSetSpec != null) && m_ObjectSetSpec.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectSet

		//
		// emit production tree node associated with any production of syntax rule ObjectSet
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectSet_1:
					// emit syntax tree node associated with production
					// ObjectSet: "{" ObjectSetSpec "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_ObjectSetSpec.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectSet
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectSet (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectSet_1:
					// emit syntax tree node associated with production
					// ObjectSet: "{" ObjectSetSpec "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_ObjectSetSpec.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectSet

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSet with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectSet.production_kind kind = (ObjectSet.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectSet.production_kind.g_ObjectSet_1:
					// traverse syntax tree node associated with production
					// ObjectSet: "{" ObjectSetSpec "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_ObjectSetSpec.Visit (visitor, appData);
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
			m_ObjectSetSpec?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectSet
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_ObjectSetSpec = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectSet

		// counter of all nodes associated with syntax rule ObjectSet
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectSet
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_ObjectSetSpec")] public ObjectSetSpec m_ObjectSetSpec { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectSet

		// delegate function (callback) prototype associated with syntax rule ObjectSet
		public delegate bool ObjectSet_Callback (SyntaxTreeCallbackReason reason, ObjectSet.production_kind kind, ObjectSet p_ObjectSet);

		// event associated with syntax rule ObjectSet
		public event ObjectSet_Callback ObjectSet_Event;

		// event trigger associated with syntax rule ObjectSet
		public bool Raise_ObjectSet_Event (SyntaxTreeCallbackReason reason, ObjectSet.production_kind kind, ObjectSet p_ObjectSet)
		{
			bool? status = ObjectSet_Event?.Invoke (reason, kind, p_ObjectSet);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectSet
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSet
		//

		public void Traverse (ObjectSet p_ObjectSet)
		{
			if (p_ObjectSet.isLocked())
				return;
			p_ObjectSet.dolock();
			ObjectSet.production_kind kind = (ObjectSet.production_kind) p_ObjectSet.kind;
			p_ObjectSet.turn_reset ();
			if (Raise_ObjectSet_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectSet))
			switch (kind)
			{
				case ObjectSet.production_kind.g_ObjectSet_1:
					// traverse syntax tree node associated with production
					// ObjectSet: "{" ObjectSetSpec "}"

					if (Raise_ObjectSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSet))
						Traverse (p_ObjectSet.m_ObjectSetSpec);
					p_ObjectSet.turn_inc ();
					Raise_ObjectSet_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectSet);
				break;
			}
			Raise_ObjectSet_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectSet);
			p_ObjectSet.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectSet
		//

		public void TraverseCommon (ObjectSet p_ObjectSet)
		{
			ObjectSet.production_kind kind = (ObjectSet.production_kind) p_ObjectSet.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectSet))
			switch (kind)
			{
				case ObjectSet.production_kind.g_ObjectSet_1:
					// traverse syntax tree node associated with production
					// ObjectSet: "{" ObjectSetSpec "}"

						TraverseCommon (p_ObjectSet.m_left_curly_bracket);
						TraverseCommon (p_ObjectSet.m_ObjectSetSpec);
						TraverseCommon (p_ObjectSet.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectSet);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectSet

		//
		// create syntax tree node associated with production
		// ObjectSet: "{" ObjectSetSpec "}"

		//

		public ObjectSet ObjectSet_1 (SyntaxTreeToken p_token, ObjectSetSpec p_ObjectSetSpec, SyntaxTreeToken p_token_1)
		{
			ObjectSet p_ObjectSet_ref = new ObjectSet(p_token, p_ObjectSetSpec, p_token_1);
			p_token.parent = p_ObjectSet_ref;
			p_ObjectSetSpec.parent = p_ObjectSet_ref;
			p_token_1.parent = p_ObjectSet_ref;
			Raise_ObjectSet_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectSet.production_kind.g_ObjectSet_1, p_ObjectSet_ref);
			return p_ObjectSet_ref;
		}
		#endregion
	};
}
