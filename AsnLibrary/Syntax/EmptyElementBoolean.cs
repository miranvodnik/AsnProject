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
	// class associated with syntax rule EmptyElementBoolean
	//

	[DataContract]
	public class	EmptyElementBoolean : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EmptyElementBoolean
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EmptyElementBoolean
		{
			g_EmptyElementBoolean_1 = 1,	// "<" "true" "/>"

			g_EmptyElementBoolean_2 = 2,	// "<" "false" "/>"

		};
		#endregion
		#region production markers associated with the syntax rule EmptyElementBoolean

		// markers associated with production: EmptyElementBoolean -> "<" "true" "/>"

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: EmptyElementBoolean -> "<" "false" "/>"

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EmptyElementBoolean

		// Constructor declaration(s) associated with production(s) of syntax rule EmptyElementBoolean

		//
		// Constructor associated with the following production(s)
		// EmptyElementBoolean -> "<" "true" "/>"

		// EmptyElementBoolean -> "<" "false" "/>"

		//

		public EmptyElementBoolean (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, int kind) : base ((uint) ProductionID._EmptyElementBoolean_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_EmptyElementBoolean_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children[0] = m_less_sign = p_token;
				children[1] = m_xml_boolean_true_item = p_token_1;
				children[2] = m_xml_single_tag_end_item = p_token_2;
				break;
			case production_kind.g_EmptyElementBoolean_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children[0] = m_less_sign = p_token;
				children[1] = m_xml_boolean_false_item = p_token_1;
				children[2] = m_xml_single_tag_end_item = p_token_2;
				break;
			default:
				{
					string[] args = new string[] { "EmptyElementBoolean" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public EmptyElementBoolean () { }

		// Copy constructor

		public EmptyElementBoolean (EmptyElementBoolean p_EmptyElementBoolean) : base (p_EmptyElementBoolean.id, p_EmptyElementBoolean.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EmptyElementBoolean.appInfo;
			switch ((production_kind) p_EmptyElementBoolean.kind)
			{
				case production_kind.g_EmptyElementBoolean_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_less_sign = (p_EmptyElementBoolean.m_less_sign != null) ? new SyntaxTreeToken (p_EmptyElementBoolean.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_xml_boolean_true_item = (p_EmptyElementBoolean.m_xml_boolean_true_item != null) ? new SyntaxTreeToken (p_EmptyElementBoolean.m_xml_boolean_true_item) : null) != null) m_xml_boolean_true_item.parent = this;
					if ((children [2] = m_xml_single_tag_end_item = (p_EmptyElementBoolean.m_xml_single_tag_end_item != null) ? new SyntaxTreeToken (p_EmptyElementBoolean.m_xml_single_tag_end_item) : null) != null) m_xml_single_tag_end_item.parent = this;
					break;
				case production_kind.g_EmptyElementBoolean_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_less_sign = (p_EmptyElementBoolean.m_less_sign != null) ? new SyntaxTreeToken (p_EmptyElementBoolean.m_less_sign) : null) != null) m_less_sign.parent = this;
					if ((children [1] = m_xml_boolean_false_item = (p_EmptyElementBoolean.m_xml_boolean_false_item != null) ? new SyntaxTreeToken (p_EmptyElementBoolean.m_xml_boolean_false_item) : null) != null) m_xml_boolean_false_item.parent = this;
					if ((children [2] = m_xml_single_tag_end_item = (p_EmptyElementBoolean.m_xml_single_tag_end_item != null) ? new SyntaxTreeToken (p_EmptyElementBoolean.m_xml_single_tag_end_item) : null) != null) m_xml_single_tag_end_item.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EmptyElementBoolean" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EmptyElementBoolean (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_less_sign?.Dispose ();
			m_xml_boolean_true_item?.Dispose ();
			m_xml_single_tag_end_item?.Dispose ();
			m_xml_boolean_false_item?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EmptyElementBoolean

		// Content changing function(s) associated with production(s) of syntax rule EmptyElementBoolean

		//
		// Content changing function associated with following production(s)
		// EmptyElementBoolean -> "<" "true" "/>"

		// EmptyElementBoolean -> "<" "false" "/>"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_EmptyElementBoolean_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children [0] = m_less_sign = p_token;
				children [1] = m_xml_boolean_true_item = p_token_1;
				children [2] = m_xml_single_tag_end_item = p_token_2;
				break;
			case production_kind.g_EmptyElementBoolean_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
				children [0] = m_less_sign = p_token;
				children [1] = m_xml_boolean_false_item = p_token_1;
				children [2] = m_xml_single_tag_end_item = p_token_2;
				break;
			default:
				{
					string[] args = new string[] { "EmptyElementBoolean" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EmptyElementBoolean
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_less_sign != null) && m_less_sign.checkInclusion (element) ||
				(m_xml_boolean_true_item != null) && m_xml_boolean_true_item.checkInclusion (element) ||
				(m_xml_single_tag_end_item != null) && m_xml_single_tag_end_item.checkInclusion (element) ||
				(m_xml_boolean_false_item != null) && m_xml_boolean_false_item.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EmptyElementBoolean

		//
		// emit production tree node associated with any production of syntax rule EmptyElementBoolean
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EmptyElementBoolean_1:
					// emit syntax tree node associated with production
					// EmptyElementBoolean: "<" "true" "/>"

					s += m_less_sign.Emit (depth - 1);
					s += " ";
					s += m_xml_boolean_true_item.Emit (depth - 1);
					s += " ";
					s += m_xml_single_tag_end_item.Emit (depth - 1);
				break;
				case production_kind.g_EmptyElementBoolean_2:
					// emit syntax tree node associated with production
					// EmptyElementBoolean: "<" "false" "/>"

					s += m_less_sign.Emit (depth - 1);
					s += " ";
					s += m_xml_boolean_false_item.Emit (depth - 1);
					s += " ";
					s += m_xml_single_tag_end_item.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EmptyElementBoolean
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EmptyElementBoolean (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EmptyElementBoolean_1:
					// emit syntax tree node associated with production
					// EmptyElementBoolean: "<" "true" "/>"

					s += "less_sign";
					s += ' ';
					s += "xml_boolean_true_item";
					s += ' ';
					s += "xml_single_tag_end_item";
				break;
				case production_kind.g_EmptyElementBoolean_2:
					// emit syntax tree node associated with production
					// EmptyElementBoolean: "<" "false" "/>"

					s += "less_sign";
					s += ' ';
					s += "xml_boolean_false_item";
					s += ' ';
					s += "xml_single_tag_end_item";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EmptyElementBoolean

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementBoolean with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EmptyElementBoolean.production_kind kind = (EmptyElementBoolean.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EmptyElementBoolean.production_kind.g_EmptyElementBoolean_1:
					// traverse syntax tree node associated with production
					// EmptyElementBoolean: "<" "true" "/>"

						m_less_sign.Visit (visitor, appData);
						m_xml_boolean_true_item.Visit (visitor, appData);
						m_xml_single_tag_end_item.Visit (visitor, appData);
				break;
				case EmptyElementBoolean.production_kind.g_EmptyElementBoolean_2:
					// traverse syntax tree node associated with production
					// EmptyElementBoolean: "<" "false" "/>"

						m_less_sign.Visit (visitor, appData);
						m_xml_boolean_false_item.Visit (visitor, appData);
						m_xml_single_tag_end_item.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_less_sign?.reparent (this);
			m_xml_boolean_true_item?.reparent (this);
			m_xml_single_tag_end_item?.reparent (this);
			m_xml_boolean_false_item?.reparent (this);
		}

		//
		// initialize object associated with syntax rule EmptyElementBoolean
		//

		public void _init ()
		{
			m_less_sign = null;
			m_xml_boolean_true_item = null;
			m_xml_single_tag_end_item = null;
			m_xml_boolean_false_item = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EmptyElementBoolean

		// counter of all nodes associated with syntax rule EmptyElementBoolean
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EmptyElementBoolean
		[DataMember (Name = "m_less_sign")] public SyntaxTreeToken m_less_sign { get; private set; }
		[DataMember (Name = "m_xml_boolean_true_item")] public SyntaxTreeToken m_xml_boolean_true_item { get; private set; }
		[DataMember (Name = "m_xml_single_tag_end_item")] public SyntaxTreeToken m_xml_single_tag_end_item { get; private set; }
		[DataMember (Name = "m_xml_boolean_false_item")] public SyntaxTreeToken m_xml_boolean_false_item { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EmptyElementBoolean

		// delegate function (callback) prototype associated with syntax rule EmptyElementBoolean
		public delegate bool EmptyElementBoolean_Callback (SyntaxTreeCallbackReason reason, EmptyElementBoolean.production_kind kind, EmptyElementBoolean p_EmptyElementBoolean);

		// event associated with syntax rule EmptyElementBoolean
		public event EmptyElementBoolean_Callback EmptyElementBoolean_Event;

		// event trigger associated with syntax rule EmptyElementBoolean
		public bool Raise_EmptyElementBoolean_Event (SyntaxTreeCallbackReason reason, EmptyElementBoolean.production_kind kind, EmptyElementBoolean p_EmptyElementBoolean)
		{
			bool? status = EmptyElementBoolean_Event?.Invoke (reason, kind, p_EmptyElementBoolean);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EmptyElementBoolean
		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementBoolean
		//

		public void Traverse (EmptyElementBoolean p_EmptyElementBoolean)
		{
			if (p_EmptyElementBoolean.isLocked())
				return;
			p_EmptyElementBoolean.dolock();
			EmptyElementBoolean.production_kind kind = (EmptyElementBoolean.production_kind) p_EmptyElementBoolean.kind;
			p_EmptyElementBoolean.turn_reset ();
			if (Raise_EmptyElementBoolean_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EmptyElementBoolean))
			switch (kind)
			{
				case EmptyElementBoolean.production_kind.g_EmptyElementBoolean_1:
					// traverse syntax tree node associated with production
					// EmptyElementBoolean: "<" "true" "/>"

				break;
				case EmptyElementBoolean.production_kind.g_EmptyElementBoolean_2:
					// traverse syntax tree node associated with production
					// EmptyElementBoolean: "<" "false" "/>"

				break;
			}
			Raise_EmptyElementBoolean_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EmptyElementBoolean);
			p_EmptyElementBoolean.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EmptyElementBoolean
		//

		public void TraverseCommon (EmptyElementBoolean p_EmptyElementBoolean)
		{
			EmptyElementBoolean.production_kind kind = (EmptyElementBoolean.production_kind) p_EmptyElementBoolean.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EmptyElementBoolean))
			switch (kind)
			{
				case EmptyElementBoolean.production_kind.g_EmptyElementBoolean_1:
					// traverse syntax tree node associated with production
					// EmptyElementBoolean: "<" "true" "/>"

						TraverseCommon (p_EmptyElementBoolean.m_less_sign);
						TraverseCommon (p_EmptyElementBoolean.m_xml_boolean_true_item);
						TraverseCommon (p_EmptyElementBoolean.m_xml_single_tag_end_item);
				break;
				case EmptyElementBoolean.production_kind.g_EmptyElementBoolean_2:
					// traverse syntax tree node associated with production
					// EmptyElementBoolean: "<" "false" "/>"

						TraverseCommon (p_EmptyElementBoolean.m_less_sign);
						TraverseCommon (p_EmptyElementBoolean.m_xml_boolean_false_item);
						TraverseCommon (p_EmptyElementBoolean.m_xml_single_tag_end_item);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EmptyElementBoolean);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EmptyElementBoolean

		//
		// create syntax tree node associated with production
		// EmptyElementBoolean: "<" "true" "/>"

		//

		public EmptyElementBoolean EmptyElementBoolean_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			EmptyElementBoolean p_EmptyElementBoolean_ref = new EmptyElementBoolean(p_token, p_token_1, p_token_2, 1);
			p_token.parent = p_EmptyElementBoolean_ref;
			p_token_1.parent = p_EmptyElementBoolean_ref;
			p_token_2.parent = p_EmptyElementBoolean_ref;
			Raise_EmptyElementBoolean_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EmptyElementBoolean.production_kind.g_EmptyElementBoolean_1, p_EmptyElementBoolean_ref);
			return p_EmptyElementBoolean_ref;
		}

		//
		// create syntax tree node associated with production
		// EmptyElementBoolean: "<" "false" "/>"

		//

		public EmptyElementBoolean EmptyElementBoolean_2 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			EmptyElementBoolean p_EmptyElementBoolean_ref = new EmptyElementBoolean(p_token, p_token_1, p_token_2, 2);
			p_token.parent = p_EmptyElementBoolean_ref;
			p_token_1.parent = p_EmptyElementBoolean_ref;
			p_token_2.parent = p_EmptyElementBoolean_ref;
			Raise_EmptyElementBoolean_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EmptyElementBoolean.production_kind.g_EmptyElementBoolean_2, p_EmptyElementBoolean_ref);
			return p_EmptyElementBoolean_ref;
		}
		#endregion
	};
}
