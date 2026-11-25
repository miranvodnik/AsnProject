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
	// class associated with syntax rule OctetStringValue
	//

	[DataContract]
	public class	OctetStringValue : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OctetStringValue
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OctetStringValue
		{
			g_OctetStringValue_1 = 1,	// bstring

			g_OctetStringValue_2 = 2,	// hstring

			g_OctetStringValue_3 = 3,	// CONTAINING Value

		};
		#endregion
		#region production markers associated with the syntax rule OctetStringValue

		// markers associated with production: OctetStringValue -> bstring

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: OctetStringValue -> hstring

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: OctetStringValue -> CONTAINING Value

		public enum production_marker_3 : ushort
		{
			m_Value,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OctetStringValue

		// Constructor declaration(s) associated with production(s) of syntax rule OctetStringValue

		//
		// Constructor associated with the following production(s)
		// OctetStringValue -> bstring

		// OctetStringValue -> hstring

		//

		public OctetStringValue (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._OctetStringValue_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_OctetStringValue_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_bstring = p_token;
				break;
			case production_kind.g_OctetStringValue_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_hstring = p_token;
				break;
			default:
				{
					string[] args = new string[] { "OctetStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		//
		// Constructor associated with the following production(s)
		// OctetStringValue -> CONTAINING Value

		//

		public OctetStringValue (SyntaxTreeToken p_token, Value p_Value) : base ((uint) ProductionID._OctetStringValue_ID, (uint) production_kind.g_OctetStringValue_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_CONTAINING = p_token;
			children[1] = m_Value = p_Value;
		}

		public OctetStringValue () { }

		// Copy constructor

		public OctetStringValue (OctetStringValue p_OctetStringValue) : base (p_OctetStringValue.id, p_OctetStringValue.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OctetStringValue.appInfo;
			switch ((production_kind) p_OctetStringValue.kind)
			{
				case production_kind.g_OctetStringValue_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_bstring = (p_OctetStringValue.m_bstring != null) ? new SyntaxTreeToken (p_OctetStringValue.m_bstring) : null) != null) m_bstring.parent = this;
					break;
				case production_kind.g_OctetStringValue_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_hstring = (p_OctetStringValue.m_hstring != null) ? new SyntaxTreeToken (p_OctetStringValue.m_hstring) : null) != null) m_hstring.parent = this;
					break;
				case production_kind.g_OctetStringValue_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_CONTAINING = (p_OctetStringValue.m_CONTAINING != null) ? new SyntaxTreeToken (p_OctetStringValue.m_CONTAINING) : null) != null) m_CONTAINING.parent = this;
					if ((children [1] = m_Value = (p_OctetStringValue.m_Value != null) ? new Value (p_OctetStringValue.m_Value) : null) != null) m_Value.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OctetStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OctetStringValue (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_bstring?.Dispose ();
			m_hstring?.Dispose ();
			m_CONTAINING?.Dispose ();
			m_Value?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OctetStringValue

		// Content changing function(s) associated with production(s) of syntax rule OctetStringValue

		//
		// Content changing function associated with following production(s)
		// OctetStringValue -> bstring

		// OctetStringValue -> hstring

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_OctetStringValue_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_bstring = p_token;
				break;
			case production_kind.g_OctetStringValue_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_hstring = p_token;
				break;
			default:
				{
					string[] args = new string[] { "OctetStringValue" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OctetStringValue -> CONTAINING Value

		//

		public void change(SyntaxTreeToken p_token, Value p_Value)
		{
			_init ();
			this.kind = (uint) production_kind.g_OctetStringValue_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_CONTAINING = p_token;
			children [1] = m_Value = p_Value;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OctetStringValue
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_bstring != null) && m_bstring.checkInclusion (element) ||
				(m_hstring != null) && m_hstring.checkInclusion (element) ||
				(m_CONTAINING != null) && m_CONTAINING.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OctetStringValue

		//
		// emit production tree node associated with any production of syntax rule OctetStringValue
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_OctetStringValue_1:
					// emit syntax tree node associated with production
					// OctetStringValue: bstring

					s += m_bstring.Emit (depth - 1);
				break;
				case production_kind.g_OctetStringValue_2:
					// emit syntax tree node associated with production
					// OctetStringValue: hstring

					s += m_hstring.Emit (depth - 1);
				break;
				case production_kind.g_OctetStringValue_3:
					// emit syntax tree node associated with production
					// OctetStringValue: CONTAINING Value

					s += m_CONTAINING.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OctetStringValue
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "OctetStringValue (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_OctetStringValue_1:
					// emit syntax tree node associated with production
					// OctetStringValue: bstring

					s += "bstring";
				break;
				case production_kind.g_OctetStringValue_2:
					// emit syntax tree node associated with production
					// OctetStringValue: hstring

					s += "hstring";
				break;
				case production_kind.g_OctetStringValue_3:
					// emit syntax tree node associated with production
					// OctetStringValue: CONTAINING Value

					s += "CONTAINING";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OctetStringValue

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OctetStringValue with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			OctetStringValue.production_kind kind = (OctetStringValue.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case OctetStringValue.production_kind.g_OctetStringValue_1:
					// traverse syntax tree node associated with production
					// OctetStringValue: bstring

						m_bstring.Visit (visitor, appData);
				break;
				case OctetStringValue.production_kind.g_OctetStringValue_2:
					// traverse syntax tree node associated with production
					// OctetStringValue: hstring

						m_hstring.Visit (visitor, appData);
				break;
				case OctetStringValue.production_kind.g_OctetStringValue_3:
					// traverse syntax tree node associated with production
					// OctetStringValue: CONTAINING Value

						m_CONTAINING.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_bstring?.reparent (this);
			m_hstring?.reparent (this);
			m_CONTAINING?.reparent (this);
			m_Value?.reparent (this);
		}

		//
		// initialize object associated with syntax rule OctetStringValue
		//

		public void _init ()
		{
			m_bstring = null;
			m_hstring = null;
			m_CONTAINING = null;
			m_Value = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OctetStringValue

		// counter of all nodes associated with syntax rule OctetStringValue
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OctetStringValue
		[DataMember (Name = "m_bstring")] public SyntaxTreeToken m_bstring { get; private set; }
		[DataMember (Name = "m_hstring")] public SyntaxTreeToken m_hstring { get; private set; }
		[DataMember (Name = "m_CONTAINING")] public SyntaxTreeToken m_CONTAINING { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OctetStringValue

		// delegate function (callback) prototype associated with syntax rule OctetStringValue
		public delegate bool OctetStringValue_Callback (SyntaxTreeCallbackReason reason, OctetStringValue.production_kind kind, OctetStringValue p_OctetStringValue);

		// event associated with syntax rule OctetStringValue
		public event OctetStringValue_Callback OctetStringValue_Event;

		// event trigger associated with syntax rule OctetStringValue
		public bool Raise_OctetStringValue_Event (SyntaxTreeCallbackReason reason, OctetStringValue.production_kind kind, OctetStringValue p_OctetStringValue)
		{
			bool? status = OctetStringValue_Event?.Invoke (reason, kind, p_OctetStringValue);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OctetStringValue
		//
		// traverse syntax tree node associated with any production of syntax rule OctetStringValue
		//

		public void Traverse (OctetStringValue p_OctetStringValue)
		{
			if (p_OctetStringValue.isLocked())
				return;
			p_OctetStringValue.dolock();
			OctetStringValue.production_kind kind = (OctetStringValue.production_kind) p_OctetStringValue.kind;
			p_OctetStringValue.turn_reset ();
			if (Raise_OctetStringValue_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_OctetStringValue))
			switch (kind)
			{
				case OctetStringValue.production_kind.g_OctetStringValue_1:
					// traverse syntax tree node associated with production
					// OctetStringValue: bstring

				break;
				case OctetStringValue.production_kind.g_OctetStringValue_2:
					// traverse syntax tree node associated with production
					// OctetStringValue: hstring

				break;
				case OctetStringValue.production_kind.g_OctetStringValue_3:
					// traverse syntax tree node associated with production
					// OctetStringValue: CONTAINING Value

					if (Raise_OctetStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OctetStringValue))
						Traverse (p_OctetStringValue.m_Value);
					p_OctetStringValue.turn_inc ();
					Raise_OctetStringValue_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_OctetStringValue);
				break;
			}
			Raise_OctetStringValue_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_OctetStringValue);
			p_OctetStringValue.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OctetStringValue
		//

		public void TraverseCommon (OctetStringValue p_OctetStringValue)
		{
			OctetStringValue.production_kind kind = (OctetStringValue.production_kind) p_OctetStringValue.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_OctetStringValue))
			switch (kind)
			{
				case OctetStringValue.production_kind.g_OctetStringValue_1:
					// traverse syntax tree node associated with production
					// OctetStringValue: bstring

						TraverseCommon (p_OctetStringValue.m_bstring);
				break;
				case OctetStringValue.production_kind.g_OctetStringValue_2:
					// traverse syntax tree node associated with production
					// OctetStringValue: hstring

						TraverseCommon (p_OctetStringValue.m_hstring);
				break;
				case OctetStringValue.production_kind.g_OctetStringValue_3:
					// traverse syntax tree node associated with production
					// OctetStringValue: CONTAINING Value

						TraverseCommon (p_OctetStringValue.m_CONTAINING);
						TraverseCommon (p_OctetStringValue.m_Value);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_OctetStringValue);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OctetStringValue

		//
		// create syntax tree node associated with production
		// OctetStringValue: bstring

		//

		public OctetStringValue OctetStringValue_1 (SyntaxTreeToken p_token)
		{
			OctetStringValue p_OctetStringValue_ref = new OctetStringValue(p_token, 1);
			p_token.parent = p_OctetStringValue_ref;
			Raise_OctetStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OctetStringValue.production_kind.g_OctetStringValue_1, p_OctetStringValue_ref);
			return p_OctetStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// OctetStringValue: hstring

		//

		public OctetStringValue OctetStringValue_2 (SyntaxTreeToken p_token)
		{
			OctetStringValue p_OctetStringValue_ref = new OctetStringValue(p_token, 2);
			p_token.parent = p_OctetStringValue_ref;
			Raise_OctetStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OctetStringValue.production_kind.g_OctetStringValue_2, p_OctetStringValue_ref);
			return p_OctetStringValue_ref;
		}

		//
		// create syntax tree node associated with production
		// OctetStringValue: CONTAINING Value

		//

		public OctetStringValue OctetStringValue_3 (SyntaxTreeToken p_token, Value p_Value)
		{
			OctetStringValue p_OctetStringValue_ref = new OctetStringValue(p_token, p_Value);
			p_token.parent = p_OctetStringValue_ref;
			p_Value.parent = p_OctetStringValue_ref;
			Raise_OctetStringValue_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OctetStringValue.production_kind.g_OctetStringValue_3, p_OctetStringValue_ref);
			return p_OctetStringValue_ref;
		}
		#endregion
	};
}
