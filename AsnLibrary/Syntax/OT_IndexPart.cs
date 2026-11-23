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
	// class associated with syntax rule OT-IndexPart
	//

	[DataContract]
	public class	OT_IndexPart : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OT-IndexPart
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OT-IndexPart
		{
			g_OT_IndexPart_1 = 1,	// INDEX "{" OT-IndexTypes "}"

			g_OT_IndexPart_2 = 2,	// AUGMENTS "{" OT-Entry "}"

			g_OT_IndexPart_3 = 3,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule OT-IndexPart

		// markers associated with production: OT-IndexPart -> INDEX "{" OT-IndexTypes "}"

		public enum production_marker_1 : ushort
		{
			m_OT_IndexTypes,
			final
		};

		// markers associated with production: OT-IndexPart -> AUGMENTS "{" OT-Entry "}"

		public enum production_marker_2 : ushort
		{
			m_OT_Entry,
			final
		};

		// markers associated with production: OT-IndexPart -> %empty

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OT-IndexPart

		// Constructor declaration(s) associated with production(s) of syntax rule OT-IndexPart

		//
		// Constructor associated with the following production(s)
		// OT-IndexPart -> INDEX "{" OT-IndexTypes "}"

		//

		public OT_IndexPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OT_IndexTypes p_OT_IndexTypes, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._OT_IndexPart_ID, (uint) production_kind.g_OT_IndexPart_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_INDEX = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_OT_IndexTypes = p_OT_IndexTypes;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		//
		// Constructor associated with the following production(s)
		// OT-IndexPart -> AUGMENTS "{" OT-Entry "}"

		//

		public OT_IndexPart (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OT_Entry p_OT_Entry, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._OT_IndexPart_ID, (uint) production_kind.g_OT_IndexPart_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_AUGMENTS = p_token;
			children[1] = m_left_curly_bracket = p_token_1;
			children[2] = m_OT_Entry = p_OT_Entry;
			children[3] = m_right_curly_bracket = p_token_2;
		}

		//
		// Constructor associated with the following production(s)
		// OT-IndexPart -> %empty

		//

		public OT_IndexPart () : base ((uint) ProductionID._OT_IndexPart_ID, (uint) production_kind.g_OT_IndexPart_3)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public OT_IndexPart (OT_IndexPart p_OT_IndexPart) : base (p_OT_IndexPart.id, p_OT_IndexPart.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OT_IndexPart.appInfo;
			switch ((production_kind) p_OT_IndexPart.kind)
			{
				case production_kind.g_OT_IndexPart_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_INDEX = (p_OT_IndexPart.m_INDEX != null) ? new SyntaxTreeToken (p_OT_IndexPart.m_INDEX) : null) != null) m_INDEX.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_OT_IndexPart.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_OT_IndexPart.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_OT_IndexTypes = (p_OT_IndexPart.m_OT_IndexTypes != null) ? new OT_IndexTypes (p_OT_IndexPart.m_OT_IndexTypes) : null) != null) m_OT_IndexTypes.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_OT_IndexPart.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_OT_IndexPart.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_OT_IndexPart_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_AUGMENTS = (p_OT_IndexPart.m_AUGMENTS != null) ? new SyntaxTreeToken (p_OT_IndexPart.m_AUGMENTS) : null) != null) m_AUGMENTS.parent = this;
					if ((children [1] = m_left_curly_bracket = (p_OT_IndexPart.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_OT_IndexPart.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [2] = m_OT_Entry = (p_OT_IndexPart.m_OT_Entry != null) ? new OT_Entry (p_OT_IndexPart.m_OT_Entry) : null) != null) m_OT_Entry.parent = this;
					if ((children [3] = m_right_curly_bracket = (p_OT_IndexPart.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_OT_IndexPart.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_OT_IndexPart_3:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "OT_IndexPart" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OT_IndexPart (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_INDEX?.Dispose ();
			m_left_curly_bracket?.Dispose ();
			m_OT_IndexTypes?.Dispose ();
			m_right_curly_bracket?.Dispose ();
			m_AUGMENTS?.Dispose ();
			m_OT_Entry?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OT-IndexPart

		// Content changing function(s) associated with production(s) of syntax rule OT-IndexPart

		//
		// Content changing function associated with following production(s)
		// OT-IndexPart -> INDEX "{" OT-IndexTypes "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OT_IndexTypes p_OT_IndexTypes, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_IndexPart_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_INDEX = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_OT_IndexTypes = p_OT_IndexTypes;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OT-IndexPart -> AUGMENTS "{" OT-Entry "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OT_Entry p_OT_Entry, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_IndexPart_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_AUGMENTS = p_token;
			children [1] = m_left_curly_bracket = p_token_1;
			children [2] = m_OT_Entry = p_OT_Entry;
			children [3] = m_right_curly_bracket = p_token_2;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OT-IndexPart -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_IndexPart_3;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OT-IndexPart
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_INDEX != null) && m_INDEX.checkInclusion (element) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_OT_IndexTypes != null) && m_OT_IndexTypes.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				(m_AUGMENTS != null) && m_AUGMENTS.checkInclusion (element) ||
				(m_OT_Entry != null) && m_OT_Entry.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OT-IndexPart

		//
		// emit production tree node associated with any production of syntax rule OT-IndexPart
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OT_IndexPart_1:
					// emit syntax tree node associated with production
					// OT-IndexPart: INDEX "{" OT-IndexTypes "}"

					s += m_INDEX.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_OT_IndexTypes.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_OT_IndexPart_2:
					// emit syntax tree node associated with production
					// OT-IndexPart: AUGMENTS "{" OT-Entry "}"

					s += m_AUGMENTS.Emit (depth - 1);
					s += " ";
					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_OT_Entry.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_OT_IndexPart_3:
					// emit syntax tree node associated with production
					// OT-IndexPart: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OT-IndexPart
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OT_IndexPart (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OT_IndexPart_1:
					// emit syntax tree node associated with production
					// OT-IndexPart: INDEX "{" OT-IndexTypes "}"

					s += "INDEX";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_OT_IndexTypes.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_OT_IndexPart_2:
					// emit syntax tree node associated with production
					// OT-IndexPart: AUGMENTS "{" OT-Entry "}"

					s += "AUGMENTS";
					s += ' ';
					s += "left_curly_bracket";
					s += ' ';
					s += m_OT_Entry.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_OT_IndexPart_3:
					// emit syntax tree node associated with production
					// OT-IndexPart: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OT-IndexPart

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OT-IndexPart with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OT_IndexPart.production_kind kind = (OT_IndexPart.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OT_IndexPart.production_kind.g_OT_IndexPart_1:
					// traverse syntax tree node associated with production
					// OT-IndexPart: INDEX "{" OT-IndexTypes "}"

						m_INDEX.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_OT_IndexTypes.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case OT_IndexPart.production_kind.g_OT_IndexPart_2:
					// traverse syntax tree node associated with production
					// OT-IndexPart: AUGMENTS "{" OT-Entry "}"

						m_AUGMENTS.Visit (visitor, appData);
						m_left_curly_bracket.Visit (visitor, appData);
						m_OT_Entry.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case OT_IndexPart.production_kind.g_OT_IndexPart_3:
					// traverse syntax tree node associated with production
					// OT-IndexPart: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_INDEX?.reparent (this);
			m_left_curly_bracket?.reparent (this);
			m_OT_IndexTypes?.reparent (this);
			m_right_curly_bracket?.reparent (this);
			m_AUGMENTS?.reparent (this);
			m_OT_Entry?.reparent (this);
		}

		//
		// initialize object associated with syntax rule OT-IndexPart
		//

		public void _init ()
		{
			m_INDEX = null;
			m_left_curly_bracket = null;
			m_OT_IndexTypes = null;
			m_right_curly_bracket = null;
			m_AUGMENTS = null;
			m_OT_Entry = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OT-IndexPart

		// counter of all nodes associated with syntax rule OT-IndexPart
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OT-IndexPart
		[DataMember (Name = "m_INDEX")] public SyntaxTreeToken m_INDEX { get; private set; }
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_OT_IndexTypes")] public OT_IndexTypes m_OT_IndexTypes { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		[DataMember (Name = "m_AUGMENTS")] public SyntaxTreeToken m_AUGMENTS { get; private set; }
		[DataMember (Name = "m_OT_Entry")] public OT_Entry m_OT_Entry { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OT-IndexPart

		// delegate function (callback) prototype associated with syntax rule OT-IndexPart
		public delegate bool OT_IndexPart_Callback (SyntaxTreeCallbackReason reason, OT_IndexPart.production_kind kind, OT_IndexPart p_OT_IndexPart);

		// event associated with syntax rule OT-IndexPart
		public event OT_IndexPart_Callback OT_IndexPart_Event;

		// event trigger associated with syntax rule OT-IndexPart
		public bool Raise_OT_IndexPart_Event (SyntaxTreeCallbackReason reason, OT_IndexPart.production_kind kind, OT_IndexPart p_OT_IndexPart)
		{
			bool? status = OT_IndexPart_Event?.Invoke (reason, kind, p_OT_IndexPart);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OT-IndexPart
		//
		// traverse syntax tree node associated with any production of syntax rule OT-IndexPart
		//

		public void Traverse (OT_IndexPart p_OT_IndexPart)
		{
			if (p_OT_IndexPart.isLocked())
				return;
			p_OT_IndexPart.dolock();
			OT_IndexPart.production_kind kind = (OT_IndexPart.production_kind) p_OT_IndexPart.kind;
			p_OT_IndexPart.turn_reset ();
			if (Raise_OT_IndexPart_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OT_IndexPart))
			switch (kind)
			{
				case OT_IndexPart.production_kind.g_OT_IndexPart_1:
					// traverse syntax tree node associated with production
					// OT-IndexPart: INDEX "{" OT-IndexTypes "}"

					if (Raise_OT_IndexPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_IndexPart))
						Traverse (p_OT_IndexPart.m_OT_IndexTypes);
					p_OT_IndexPart.turn_inc ();
					Raise_OT_IndexPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_IndexPart);
				break;
				case OT_IndexPart.production_kind.g_OT_IndexPart_2:
					// traverse syntax tree node associated with production
					// OT-IndexPart: AUGMENTS "{" OT-Entry "}"

					if (Raise_OT_IndexPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_IndexPart))
						Traverse (p_OT_IndexPart.m_OT_Entry);
					p_OT_IndexPart.turn_inc ();
					Raise_OT_IndexPart_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OT_IndexPart);
				break;
				case OT_IndexPart.production_kind.g_OT_IndexPart_3:
					// traverse syntax tree node associated with production
					// OT-IndexPart: %empty

				break;
			}
			Raise_OT_IndexPart_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OT_IndexPart);
			p_OT_IndexPart.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OT-IndexPart
		//

		public void TraverseCommon (OT_IndexPart p_OT_IndexPart)
		{
			OT_IndexPart.production_kind kind = (OT_IndexPart.production_kind) p_OT_IndexPart.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OT_IndexPart))
			switch (kind)
			{
				case OT_IndexPart.production_kind.g_OT_IndexPart_1:
					// traverse syntax tree node associated with production
					// OT-IndexPart: INDEX "{" OT-IndexTypes "}"

						TraverseCommon (p_OT_IndexPart.m_INDEX);
						TraverseCommon (p_OT_IndexPart.m_left_curly_bracket);
						TraverseCommon (p_OT_IndexPart.m_OT_IndexTypes);
						TraverseCommon (p_OT_IndexPart.m_right_curly_bracket);
				break;
				case OT_IndexPart.production_kind.g_OT_IndexPart_2:
					// traverse syntax tree node associated with production
					// OT-IndexPart: AUGMENTS "{" OT-Entry "}"

						TraverseCommon (p_OT_IndexPart.m_AUGMENTS);
						TraverseCommon (p_OT_IndexPart.m_left_curly_bracket);
						TraverseCommon (p_OT_IndexPart.m_OT_Entry);
						TraverseCommon (p_OT_IndexPart.m_right_curly_bracket);
				break;
				case OT_IndexPart.production_kind.g_OT_IndexPart_3:
					// traverse syntax tree node associated with production
					// OT-IndexPart: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OT_IndexPart);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OT-IndexPart

		//
		// create syntax tree node associated with production
		// OT-IndexPart: INDEX "{" OT-IndexTypes "}"

		//

		public OT_IndexPart OT_IndexPart_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OT_IndexTypes p_OT_IndexTypes, SyntaxTreeToken p_token_2)
		{
			OT_IndexPart p_OT_IndexPart_ref = new OT_IndexPart(p_token, p_token_1, p_OT_IndexTypes, p_token_2);
			p_token.parent = p_OT_IndexPart_ref;
			p_token_1.parent = p_OT_IndexPart_ref;
			p_OT_IndexTypes.parent = p_OT_IndexPart_ref;
			p_token_2.parent = p_OT_IndexPart_ref;
			Raise_OT_IndexPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_IndexPart.production_kind.g_OT_IndexPart_1, p_OT_IndexPart_ref);
			return p_OT_IndexPart_ref;
		}

		//
		// create syntax tree node associated with production
		// OT-IndexPart: AUGMENTS "{" OT-Entry "}"

		//

		public OT_IndexPart OT_IndexPart_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OT_Entry p_OT_Entry, SyntaxTreeToken p_token_2)
		{
			OT_IndexPart p_OT_IndexPart_ref = new OT_IndexPart(p_token, p_token_1, p_OT_Entry, p_token_2);
			p_token.parent = p_OT_IndexPart_ref;
			p_token_1.parent = p_OT_IndexPart_ref;
			p_OT_Entry.parent = p_OT_IndexPart_ref;
			p_token_2.parent = p_OT_IndexPart_ref;
			Raise_OT_IndexPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_IndexPart.production_kind.g_OT_IndexPart_2, p_OT_IndexPart_ref);
			return p_OT_IndexPart_ref;
		}

		//
		// create syntax tree node associated with production
		// OT-IndexPart: %empty

		//

		public OT_IndexPart OT_IndexPart_3 ()
		{
			OT_IndexPart p_OT_IndexPart_ref = new OT_IndexPart();
			Raise_OT_IndexPart_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_IndexPart.production_kind.g_OT_IndexPart_3, p_OT_IndexPart_ref);
			return p_OT_IndexPart_ref;
		}
		#endregion
	};
}
