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
	// class associated with syntax rule ObjectIdentifierValue
	//

	[DataContract]
	public class	ObjectIdentifierValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectIdentifierValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectIdentifierValue
		{
			g_ObjectIdentifierValue_1 = 1,	// "{" ObjIdComponentsList "}"

		};
		#endregion
		#region production markers associated with the syntax rule ObjectIdentifierValue

		// markers associated with production: ObjectIdentifierValue -> "{" ObjIdComponentsList "}"

		public enum production_marker_1 : ushort
		{
			m_ObjIdComponentsList,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectIdentifierValue

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectIdentifierValue

		//
		// Constructor associated with the following production(s)
		// ObjectIdentifierValue -> "{" ObjIdComponentsList "}"

		//

		public ObjectIdentifierValue (SyntaxTreeToken p_token, ObjIdComponentsList p_ObjIdComponentsList, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._ObjectIdentifierValue_ID, (uint) production_kind.g_ObjectIdentifierValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_ObjIdComponentsList = p_ObjIdComponentsList;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public ObjectIdentifierValue () { }

		// Copy constructor

		public ObjectIdentifierValue (ObjectIdentifierValue p_ObjectIdentifierValue) : base (p_ObjectIdentifierValue.id, p_ObjectIdentifierValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectIdentifierValue.appInfo;
			switch ((production_kind) p_ObjectIdentifierValue.kind)
			{
				case production_kind.g_ObjectIdentifierValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_ObjectIdentifierValue.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_ObjectIdentifierValue.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_ObjIdComponentsList = (p_ObjectIdentifierValue.m_ObjIdComponentsList != null) ? new ObjIdComponentsList (p_ObjectIdentifierValue.m_ObjIdComponentsList) : null) != null) m_ObjIdComponentsList.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_ObjectIdentifierValue.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_ObjectIdentifierValue.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectIdentifierValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectIdentifierValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_ObjIdComponentsList?.Dispose ();
			m_right_curly_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectIdentifierValue

		// Content changing function(s) associated with production(s) of syntax rule ObjectIdentifierValue

		//
		// Content changing function associated with following production(s)
		// ObjectIdentifierValue -> "{" ObjIdComponentsList "}"

		//

		public void change(SyntaxTreeToken p_token, ObjIdComponentsList p_ObjIdComponentsList, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectIdentifierValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_ObjIdComponentsList = p_ObjIdComponentsList;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectIdentifierValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_ObjIdComponentsList != null) && m_ObjIdComponentsList.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectIdentifierValue

		//
		// emit production tree node associated with any production of syntax rule ObjectIdentifierValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectIdentifierValue_1:
					// emit syntax tree node associated with production
					// ObjectIdentifierValue: "{" ObjIdComponentsList "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_ObjIdComponentsList.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectIdentifierValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectIdentifierValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectIdentifierValue_1:
					// emit syntax tree node associated with production
					// ObjectIdentifierValue: "{" ObjIdComponentsList "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_ObjIdComponentsList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectIdentifierValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectIdentifierValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectIdentifierValue.production_kind kind = (ObjectIdentifierValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectIdentifierValue.production_kind.g_ObjectIdentifierValue_1:
					// traverse syntax tree node associated with production
					// ObjectIdentifierValue: "{" ObjIdComponentsList "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_ObjIdComponentsList.Visit (visitor, appData);
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
			m_ObjIdComponentsList?.reparent (this);
			m_right_curly_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectIdentifierValue
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_ObjIdComponentsList = null;
			m_right_curly_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectIdentifierValue

		// counter of all nodes associated with syntax rule ObjectIdentifierValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectIdentifierValue
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_ObjIdComponentsList")] public ObjIdComponentsList m_ObjIdComponentsList { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectIdentifierValue

		// delegate function (callback) prototype associated with syntax rule ObjectIdentifierValue
		public delegate bool ObjectIdentifierValue_Callback (SyntaxTreeCallbackReason reason, ObjectIdentifierValue.production_kind kind, ObjectIdentifierValue p_ObjectIdentifierValue);

		// event associated with syntax rule ObjectIdentifierValue
		public event ObjectIdentifierValue_Callback ObjectIdentifierValue_Event;

		// event trigger associated with syntax rule ObjectIdentifierValue
		public bool Raise_ObjectIdentifierValue_Event (SyntaxTreeCallbackReason reason, ObjectIdentifierValue.production_kind kind, ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			bool? status = ObjectIdentifierValue_Event?.Invoke (reason, kind, p_ObjectIdentifierValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectIdentifierValue
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectIdentifierValue
		//

		public void Traverse (ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			if (p_ObjectIdentifierValue.isLocked())
				return;
			p_ObjectIdentifierValue.dolock();
			ObjectIdentifierValue.production_kind kind = (ObjectIdentifierValue.production_kind) p_ObjectIdentifierValue.kind;
			p_ObjectIdentifierValue.turn_reset ();
			if (Raise_ObjectIdentifierValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectIdentifierValue))
			switch (kind)
			{
				case ObjectIdentifierValue.production_kind.g_ObjectIdentifierValue_1:
					// traverse syntax tree node associated with production
					// ObjectIdentifierValue: "{" ObjIdComponentsList "}"

					if (Raise_ObjectIdentifierValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectIdentifierValue))
						Traverse (p_ObjectIdentifierValue.m_ObjIdComponentsList);
					p_ObjectIdentifierValue.turn_inc ();
					Raise_ObjectIdentifierValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectIdentifierValue);
				break;
			}
			Raise_ObjectIdentifierValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectIdentifierValue);
			p_ObjectIdentifierValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectIdentifierValue
		//

		public void TraverseCommon (ObjectIdentifierValue p_ObjectIdentifierValue)
		{
			ObjectIdentifierValue.production_kind kind = (ObjectIdentifierValue.production_kind) p_ObjectIdentifierValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectIdentifierValue))
			switch (kind)
			{
				case ObjectIdentifierValue.production_kind.g_ObjectIdentifierValue_1:
					// traverse syntax tree node associated with production
					// ObjectIdentifierValue: "{" ObjIdComponentsList "}"

						TraverseCommon (p_ObjectIdentifierValue.m_left_curly_bracket);
						TraverseCommon (p_ObjectIdentifierValue.m_ObjIdComponentsList);
						TraverseCommon (p_ObjectIdentifierValue.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectIdentifierValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectIdentifierValue

		//
		// create syntax tree node associated with production
		// ObjectIdentifierValue: "{" ObjIdComponentsList "}"

		//

		public ObjectIdentifierValue ObjectIdentifierValue_1 (SyntaxTreeToken p_token, ObjIdComponentsList p_ObjIdComponentsList, SyntaxTreeToken p_token_1)
		{
			ObjectIdentifierValue p_ObjectIdentifierValue_ref = new ObjectIdentifierValue(p_token, p_ObjIdComponentsList, p_token_1);
			p_token.parent = p_ObjectIdentifierValue_ref;
			p_ObjIdComponentsList.parent = p_ObjectIdentifierValue_ref;
			p_token_1.parent = p_ObjectIdentifierValue_ref;
			Raise_ObjectIdentifierValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectIdentifierValue.production_kind.g_ObjectIdentifierValue_1, p_ObjectIdentifierValue_ref);
			return p_ObjectIdentifierValue_ref;
		}
		#endregion
	};
}
