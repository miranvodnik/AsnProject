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
	// class associated with syntax rule RestrictedCharacterStringValue
	//

	[DataContract]
	public class	RestrictedCharacterStringValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule RestrictedCharacterStringValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule RestrictedCharacterStringValue
		{
			g_RestrictedCharacterStringValue_1 = 1,	// cstring

			g_RestrictedCharacterStringValue_2 = 2,	// CharacterStringList

			g_RestrictedCharacterStringValue_3 = 3,	// Quadruple

			g_RestrictedCharacterStringValue_4 = 4,	// Tuple

		};
		#endregion
		#region production markers associated with the syntax rule RestrictedCharacterStringValue

		// markers associated with production: RestrictedCharacterStringValue -> cstring

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: RestrictedCharacterStringValue -> CharacterStringList

		public enum production_marker_2 : ushort
		{
			m_CharacterStringList,
			final
		};

		// markers associated with production: RestrictedCharacterStringValue -> Quadruple

		public enum production_marker_3 : ushort
		{
			m_Quadruple,
			final
		};

		// markers associated with production: RestrictedCharacterStringValue -> Tuple

		public enum production_marker_4 : ushort
		{
			m_Tuple,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule RestrictedCharacterStringValue

		// Constructor declaration(s) associated with production(s) of syntax rule RestrictedCharacterStringValue

		//
		// Constructor associated with the following production(s)
		// RestrictedCharacterStringValue -> cstring

		//

		public RestrictedCharacterStringValue (SyntaxTreeToken p_token) : base ((uint) ProductionID._RestrictedCharacterStringValue_ID, (uint) production_kind.g_RestrictedCharacterStringValue_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_cstring = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// RestrictedCharacterStringValue -> CharacterStringList

		//

		public RestrictedCharacterStringValue (CharacterStringList p_CharacterStringList) : base ((uint) ProductionID._RestrictedCharacterStringValue_ID, (uint) production_kind.g_RestrictedCharacterStringValue_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_CharacterStringList = p_CharacterStringList;
		}

		//
		// Constructor associated with the following production(s)
		// RestrictedCharacterStringValue -> Quadruple

		//

		public RestrictedCharacterStringValue (Quadruple p_Quadruple) : base ((uint) ProductionID._RestrictedCharacterStringValue_ID, (uint) production_kind.g_RestrictedCharacterStringValue_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Quadruple = p_Quadruple;
		}

		//
		// Constructor associated with the following production(s)
		// RestrictedCharacterStringValue -> Tuple

		//

		public RestrictedCharacterStringValue (Tuple p_Tuple) : base ((uint) ProductionID._RestrictedCharacterStringValue_ID, (uint) production_kind.g_RestrictedCharacterStringValue_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_Tuple = p_Tuple;
		}

		public RestrictedCharacterStringValue () { }

		// Copy constructor

		public RestrictedCharacterStringValue (RestrictedCharacterStringValue p_RestrictedCharacterStringValue) : base (p_RestrictedCharacterStringValue.id, p_RestrictedCharacterStringValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_RestrictedCharacterStringValue.appInfo;
			switch ((production_kind) p_RestrictedCharacterStringValue.kind)
			{
				case production_kind.g_RestrictedCharacterStringValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_cstring = (p_RestrictedCharacterStringValue.m_cstring != null) ? new SyntaxTreeToken (p_RestrictedCharacterStringValue.m_cstring) : null) != null) m_cstring.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_CharacterStringList = (p_RestrictedCharacterStringValue.m_CharacterStringList != null) ? new CharacterStringList (p_RestrictedCharacterStringValue.m_CharacterStringList) : null) != null) m_CharacterStringList.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringValue_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Quadruple = (p_RestrictedCharacterStringValue.m_Quadruple != null) ? new Quadruple (p_RestrictedCharacterStringValue.m_Quadruple) : null) != null) m_Quadruple.parent = this;
					break;
				case production_kind.g_RestrictedCharacterStringValue_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_Tuple = (p_RestrictedCharacterStringValue.m_Tuple != null) ? new Tuple (p_RestrictedCharacterStringValue.m_Tuple) : null) != null) m_Tuple.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "RestrictedCharacterStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new RestrictedCharacterStringValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_cstring?.Dispose ();
			m_CharacterStringList?.Dispose ();
			m_Quadruple?.Dispose ();
			m_Tuple?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule RestrictedCharacterStringValue

		// Content changing function(s) associated with production(s) of syntax rule RestrictedCharacterStringValue

		//
		// Content changing function associated with following production(s)
		// RestrictedCharacterStringValue -> cstring

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_RestrictedCharacterStringValue_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_cstring = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// RestrictedCharacterStringValue -> CharacterStringList

		//

		public void change(CharacterStringList p_CharacterStringList)
		{
			_init ();
			this.kind = (uint) production_kind.g_RestrictedCharacterStringValue_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_CharacterStringList = p_CharacterStringList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// RestrictedCharacterStringValue -> Quadruple

		//

		public void change(Quadruple p_Quadruple)
		{
			_init ();
			this.kind = (uint) production_kind.g_RestrictedCharacterStringValue_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Quadruple = p_Quadruple;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// RestrictedCharacterStringValue -> Tuple

		//

		public void change(Tuple p_Tuple)
		{
			_init ();
			this.kind = (uint) production_kind.g_RestrictedCharacterStringValue_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_Tuple = p_Tuple;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule RestrictedCharacterStringValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				(m_CharacterStringList != null) && m_CharacterStringList.checkInclusion (element) ||
				(m_Quadruple != null) && m_Quadruple.checkInclusion (element) ||
				(m_Tuple != null) && m_Tuple.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule RestrictedCharacterStringValue

		//
		// emit production tree node associated with any production of syntax rule RestrictedCharacterStringValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_RestrictedCharacterStringValue_1:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringValue: cstring

					s += m_cstring.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringValue_2:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringValue: CharacterStringList

					s += m_CharacterStringList.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringValue_3:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringValue: Quadruple

					s += m_Quadruple.Emit (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringValue_4:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringValue: Tuple

					s += m_Tuple.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule RestrictedCharacterStringValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "RestrictedCharacterStringValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_RestrictedCharacterStringValue_1:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringValue: cstring

					s += "cstring";
				break;
				case production_kind.g_RestrictedCharacterStringValue_2:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringValue: CharacterStringList

					s += m_CharacterStringList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringValue_3:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringValue: Quadruple

					s += m_Quadruple.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_RestrictedCharacterStringValue_4:
					// emit syntax tree node associated with production
					// RestrictedCharacterStringValue: Tuple

					s += m_Tuple.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule RestrictedCharacterStringValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule RestrictedCharacterStringValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			RestrictedCharacterStringValue.production_kind kind = (RestrictedCharacterStringValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringValue: cstring

						m_cstring.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_2:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringValue: CharacterStringList

						m_CharacterStringList.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_3:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringValue: Quadruple

						m_Quadruple.Visit (visitor, appData);
				break;
				case RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_4:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringValue: Tuple

						m_Tuple.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_cstring?.reparent (this);
			m_CharacterStringList?.reparent (this);
			m_Quadruple?.reparent (this);
			m_Tuple?.reparent (this);
		}

		//
		// initialize object associated with syntax rule RestrictedCharacterStringValue
		//

		public void _init ()
		{
			m_cstring = null;
			m_CharacterStringList = null;
			m_Quadruple = null;
			m_Tuple = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule RestrictedCharacterStringValue

		// counter of all nodes associated with syntax rule RestrictedCharacterStringValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule RestrictedCharacterStringValue
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		[DataMember (Name = "m_CharacterStringList")] public CharacterStringList m_CharacterStringList { get; private set; }
		[DataMember (Name = "m_Quadruple")] public Quadruple m_Quadruple { get; private set; }
		[DataMember (Name = "m_Tuple")] public Tuple m_Tuple { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule RestrictedCharacterStringValue

		// delegate function (callback) prototype associated with syntax rule RestrictedCharacterStringValue
		public delegate bool RestrictedCharacterStringValue_Callback (SyntaxTreeCallbackReason reason, RestrictedCharacterStringValue.production_kind kind, RestrictedCharacterStringValue p_RestrictedCharacterStringValue);

		// event associated with syntax rule RestrictedCharacterStringValue
		public event RestrictedCharacterStringValue_Callback RestrictedCharacterStringValue_Event;

		// event trigger associated with syntax rule RestrictedCharacterStringValue
		public bool Raise_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason reason, RestrictedCharacterStringValue.production_kind kind, RestrictedCharacterStringValue p_RestrictedCharacterStringValue)
		{
			bool? status = RestrictedCharacterStringValue_Event?.Invoke (reason, kind, p_RestrictedCharacterStringValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule RestrictedCharacterStringValue
		//
		// traverse syntax tree node associated with any production of syntax rule RestrictedCharacterStringValue
		//

		public void Traverse (RestrictedCharacterStringValue p_RestrictedCharacterStringValue)
		{
			if (p_RestrictedCharacterStringValue.isLocked())
				return;
			p_RestrictedCharacterStringValue.dolock();
			RestrictedCharacterStringValue.production_kind kind = (RestrictedCharacterStringValue.production_kind) p_RestrictedCharacterStringValue.kind;
			p_RestrictedCharacterStringValue.turn_reset ();
			if (Raise_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_RestrictedCharacterStringValue))
			switch (kind)
			{
				case RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringValue: cstring

				break;
				case RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_2:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringValue: CharacterStringList

					if (Raise_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RestrictedCharacterStringValue))
						Traverse (p_RestrictedCharacterStringValue.m_CharacterStringList);
					p_RestrictedCharacterStringValue.turn_inc ();
					Raise_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RestrictedCharacterStringValue);
				break;
				case RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_3:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringValue: Quadruple

					if (Raise_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RestrictedCharacterStringValue))
						Traverse (p_RestrictedCharacterStringValue.m_Quadruple);
					p_RestrictedCharacterStringValue.turn_inc ();
					Raise_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RestrictedCharacterStringValue);
				break;
				case RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_4:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringValue: Tuple

					if (Raise_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RestrictedCharacterStringValue))
						Traverse (p_RestrictedCharacterStringValue.m_Tuple);
					p_RestrictedCharacterStringValue.turn_inc ();
					Raise_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_RestrictedCharacterStringValue);
				break;
			}
			Raise_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_RestrictedCharacterStringValue);
			p_RestrictedCharacterStringValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule RestrictedCharacterStringValue
		//

		public void TraverseCommon (RestrictedCharacterStringValue p_RestrictedCharacterStringValue)
		{
			RestrictedCharacterStringValue.production_kind kind = (RestrictedCharacterStringValue.production_kind) p_RestrictedCharacterStringValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_RestrictedCharacterStringValue))
			switch (kind)
			{
				case RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_1:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringValue: cstring

						TraverseCommon (p_RestrictedCharacterStringValue.m_cstring);
				break;
				case RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_2:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringValue: CharacterStringList

						TraverseCommon (p_RestrictedCharacterStringValue.m_CharacterStringList);
				break;
				case RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_3:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringValue: Quadruple

						TraverseCommon (p_RestrictedCharacterStringValue.m_Quadruple);
				break;
				case RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_4:
					// traverse syntax tree node associated with production
					// RestrictedCharacterStringValue: Tuple

						TraverseCommon (p_RestrictedCharacterStringValue.m_Tuple);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_RestrictedCharacterStringValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule RestrictedCharacterStringValue

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringValue: cstring

		//

		public RestrictedCharacterStringValue RestrictedCharacterStringValue_1 (SyntaxTreeToken p_token)
		{
			RestrictedCharacterStringValue p_RestrictedCharacterStringValue_ref = new RestrictedCharacterStringValue(p_token);
			p_token.parent = p_RestrictedCharacterStringValue_ref;
			Raise_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_1, p_RestrictedCharacterStringValue_ref);
			return p_RestrictedCharacterStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringValue: CharacterStringList

		//

		public RestrictedCharacterStringValue RestrictedCharacterStringValue_2 (CharacterStringList p_CharacterStringList)
		{
			RestrictedCharacterStringValue p_RestrictedCharacterStringValue_ref = new RestrictedCharacterStringValue(p_CharacterStringList);
			p_CharacterStringList.parent = p_RestrictedCharacterStringValue_ref;
			Raise_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_2, p_RestrictedCharacterStringValue_ref);
			return p_RestrictedCharacterStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringValue: Quadruple

		//

		public RestrictedCharacterStringValue RestrictedCharacterStringValue_3 (Quadruple p_Quadruple)
		{
			RestrictedCharacterStringValue p_RestrictedCharacterStringValue_ref = new RestrictedCharacterStringValue(p_Quadruple);
			p_Quadruple.parent = p_RestrictedCharacterStringValue_ref;
			Raise_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_3, p_RestrictedCharacterStringValue_ref);
			return p_RestrictedCharacterStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// RestrictedCharacterStringValue: Tuple

		//

		public RestrictedCharacterStringValue RestrictedCharacterStringValue_4 (Tuple p_Tuple)
		{
			RestrictedCharacterStringValue p_RestrictedCharacterStringValue_ref = new RestrictedCharacterStringValue(p_Tuple);
			p_Tuple.parent = p_RestrictedCharacterStringValue_ref;
			Raise_RestrictedCharacterStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, RestrictedCharacterStringValue.production_kind.g_RestrictedCharacterStringValue_4, p_RestrictedCharacterStringValue_ref);
			return p_RestrictedCharacterStringValue_ref;
		}
		#endregion
	};
}
