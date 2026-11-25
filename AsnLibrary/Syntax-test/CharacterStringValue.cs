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
	// class associated with syntax rule CharacterStringValue
	//

	[DataContract]
	public class	CharacterStringValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule CharacterStringValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule CharacterStringValue
		{
			g_CharacterStringValue_1 = 1,	// RestrictedCharacterStringValue

			g_CharacterStringValue_2 = 2,	// UnrestrictedCharacterStringValue

		};
		#endregion
		#region production markers associated with the syntax rule CharacterStringValue

		// markers associated with production: CharacterStringValue -> RestrictedCharacterStringValue

		public enum production_marker_1 : ushort
		{
			m_RestrictedCharacterStringValue,
			final
		};

		// markers associated with production: CharacterStringValue -> UnrestrictedCharacterStringValue

		public enum production_marker_2 : ushort
		{
			m_UnrestrictedCharacterStringValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule CharacterStringValue

		// Constructor declaration(s) associated with production(s) of syntax rule CharacterStringValue

		//
		// Constructor associated with the following production(s)
		// CharacterStringValue -> RestrictedCharacterStringValue

		//

		public CharacterStringValue (RestrictedCharacterStringValue p_RestrictedCharacterStringValue) : base ((uint) ProductionID._CharacterStringValue_ID, (uint) production_kind.g_CharacterStringValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RestrictedCharacterStringValue = p_RestrictedCharacterStringValue;
		}

		//
		// Constructor associated with the following production(s)
		// CharacterStringValue -> UnrestrictedCharacterStringValue

		//

		public CharacterStringValue (UnrestrictedCharacterStringValue p_UnrestrictedCharacterStringValue) : base ((uint) ProductionID._CharacterStringValue_ID, (uint) production_kind.g_CharacterStringValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_UnrestrictedCharacterStringValue = p_UnrestrictedCharacterStringValue;
		}

		public CharacterStringValue () { }

		// Copy constructor

		public CharacterStringValue (CharacterStringValue p_CharacterStringValue) : base (p_CharacterStringValue.id, p_CharacterStringValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_CharacterStringValue.appInfo;
			switch ((production_kind) p_CharacterStringValue.kind)
			{
				case production_kind.g_CharacterStringValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RestrictedCharacterStringValue = (p_CharacterStringValue.m_RestrictedCharacterStringValue != null) ? new RestrictedCharacterStringValue (p_CharacterStringValue.m_RestrictedCharacterStringValue) : null) != null) m_RestrictedCharacterStringValue.parent = this;
					break;
				case production_kind.g_CharacterStringValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UnrestrictedCharacterStringValue = (p_CharacterStringValue.m_UnrestrictedCharacterStringValue != null) ? new UnrestrictedCharacterStringValue (p_CharacterStringValue.m_UnrestrictedCharacterStringValue) : null) != null) m_UnrestrictedCharacterStringValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "CharacterStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new CharacterStringValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_RestrictedCharacterStringValue?.Dispose ();
			m_UnrestrictedCharacterStringValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule CharacterStringValue

		// Content changing function(s) associated with production(s) of syntax rule CharacterStringValue

		//
		// Content changing function associated with following production(s)
		// CharacterStringValue -> RestrictedCharacterStringValue

		//

		public void change(RestrictedCharacterStringValue p_RestrictedCharacterStringValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_CharacterStringValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RestrictedCharacterStringValue = p_RestrictedCharacterStringValue;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// CharacterStringValue -> UnrestrictedCharacterStringValue

		//

		public void change(UnrestrictedCharacterStringValue p_UnrestrictedCharacterStringValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_CharacterStringValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_UnrestrictedCharacterStringValue = p_UnrestrictedCharacterStringValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule CharacterStringValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_RestrictedCharacterStringValue != null) && m_RestrictedCharacterStringValue.checkInclusion (element) ||
				(m_UnrestrictedCharacterStringValue != null) && m_UnrestrictedCharacterStringValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule CharacterStringValue

		//
		// emit production tree node associated with any production of syntax rule CharacterStringValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_CharacterStringValue_1:
					// emit syntax tree node associated with production
					// CharacterStringValue: RestrictedCharacterStringValue

					s += m_RestrictedCharacterStringValue.Emit (depth - 1);
				break;
				case production_kind.g_CharacterStringValue_2:
					// emit syntax tree node associated with production
					// CharacterStringValue: UnrestrictedCharacterStringValue

					s += m_UnrestrictedCharacterStringValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule CharacterStringValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "CharacterStringValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_CharacterStringValue_1:
					// emit syntax tree node associated with production
					// CharacterStringValue: RestrictedCharacterStringValue

					s += m_RestrictedCharacterStringValue.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_CharacterStringValue_2:
					// emit syntax tree node associated with production
					// CharacterStringValue: UnrestrictedCharacterStringValue

					s += m_UnrestrictedCharacterStringValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule CharacterStringValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule CharacterStringValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			CharacterStringValue.production_kind kind = (CharacterStringValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case CharacterStringValue.production_kind.g_CharacterStringValue_1:
					// traverse syntax tree node associated with production
					// CharacterStringValue: RestrictedCharacterStringValue

						m_RestrictedCharacterStringValue.Visit (visitor, appData);
				break;
				case CharacterStringValue.production_kind.g_CharacterStringValue_2:
					// traverse syntax tree node associated with production
					// CharacterStringValue: UnrestrictedCharacterStringValue

						m_UnrestrictedCharacterStringValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_RestrictedCharacterStringValue?.reparent (this);
			m_UnrestrictedCharacterStringValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule CharacterStringValue
		//

		public void _init ()
		{
			m_RestrictedCharacterStringValue = null;
			m_UnrestrictedCharacterStringValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule CharacterStringValue

		// counter of all nodes associated with syntax rule CharacterStringValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule CharacterStringValue
		[DataMember (Name = "m_RestrictedCharacterStringValue")] public RestrictedCharacterStringValue m_RestrictedCharacterStringValue { get; private set; }
		[DataMember (Name = "m_UnrestrictedCharacterStringValue")] public UnrestrictedCharacterStringValue m_UnrestrictedCharacterStringValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule CharacterStringValue

		// delegate function (callback) prototype associated with syntax rule CharacterStringValue
		public delegate bool CharacterStringValue_Callback (SyntaxTreeCallbackReason reason, CharacterStringValue.production_kind kind, CharacterStringValue p_CharacterStringValue);

		// event associated with syntax rule CharacterStringValue
		public event CharacterStringValue_Callback CharacterStringValue_Event;

		// event trigger associated with syntax rule CharacterStringValue
		public bool Raise_CharacterStringValue_Event (SyntaxTreeCallbackReason reason, CharacterStringValue.production_kind kind, CharacterStringValue p_CharacterStringValue)
		{
			bool? status = CharacterStringValue_Event?.Invoke (reason, kind, p_CharacterStringValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule CharacterStringValue
		//
		// traverse syntax tree node associated with any production of syntax rule CharacterStringValue
		//

		public void Traverse (CharacterStringValue p_CharacterStringValue)
		{
			if (p_CharacterStringValue.isLocked())
				return;
			p_CharacterStringValue.dolock();
			CharacterStringValue.production_kind kind = (CharacterStringValue.production_kind) p_CharacterStringValue.kind;
			p_CharacterStringValue.turn_reset ();
			if (Raise_CharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_CharacterStringValue))
			switch (kind)
			{
				case CharacterStringValue.production_kind.g_CharacterStringValue_1:
					// traverse syntax tree node associated with production
					// CharacterStringValue: RestrictedCharacterStringValue

					if (Raise_CharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharacterStringValue))
						Traverse (p_CharacterStringValue.m_RestrictedCharacterStringValue);
					p_CharacterStringValue.turn_inc ();
					Raise_CharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharacterStringValue);
				break;
				case CharacterStringValue.production_kind.g_CharacterStringValue_2:
					// traverse syntax tree node associated with production
					// CharacterStringValue: UnrestrictedCharacterStringValue

					if (Raise_CharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharacterStringValue))
						Traverse (p_CharacterStringValue.m_UnrestrictedCharacterStringValue);
					p_CharacterStringValue.turn_inc ();
					Raise_CharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_CharacterStringValue);
				break;
			}
			Raise_CharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_CharacterStringValue);
			p_CharacterStringValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule CharacterStringValue
		//

		public void TraverseCommon (CharacterStringValue p_CharacterStringValue)
		{
			CharacterStringValue.production_kind kind = (CharacterStringValue.production_kind) p_CharacterStringValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_CharacterStringValue))
			switch (kind)
			{
				case CharacterStringValue.production_kind.g_CharacterStringValue_1:
					// traverse syntax tree node associated with production
					// CharacterStringValue: RestrictedCharacterStringValue

						TraverseCommon (p_CharacterStringValue.m_RestrictedCharacterStringValue);
				break;
				case CharacterStringValue.production_kind.g_CharacterStringValue_2:
					// traverse syntax tree node associated with production
					// CharacterStringValue: UnrestrictedCharacterStringValue

						TraverseCommon (p_CharacterStringValue.m_UnrestrictedCharacterStringValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_CharacterStringValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule CharacterStringValue

		//
		// create syntax tree node associated with production
		// CharacterStringValue: RestrictedCharacterStringValue

		//

		public CharacterStringValue CharacterStringValue_1 (RestrictedCharacterStringValue p_RestrictedCharacterStringValue)
		{
			CharacterStringValue p_CharacterStringValue_ref = new CharacterStringValue(p_RestrictedCharacterStringValue);
			p_RestrictedCharacterStringValue.parent = p_CharacterStringValue_ref;
			Raise_CharacterStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, CharacterStringValue.production_kind.g_CharacterStringValue_1, p_CharacterStringValue_ref);
			return p_CharacterStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// CharacterStringValue: UnrestrictedCharacterStringValue

		//

		public CharacterStringValue CharacterStringValue_2 (UnrestrictedCharacterStringValue p_UnrestrictedCharacterStringValue)
		{
			CharacterStringValue p_CharacterStringValue_ref = new CharacterStringValue(p_UnrestrictedCharacterStringValue);
			p_UnrestrictedCharacterStringValue.parent = p_CharacterStringValue_ref;
			Raise_CharacterStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, CharacterStringValue.production_kind.g_CharacterStringValue_2, p_CharacterStringValue_ref);
			return p_CharacterStringValue_ref;
		}
		#endregion
	};
}
