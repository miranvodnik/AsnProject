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
	// class associated with syntax rule DefaultSyntax
	//

	[DataContract]
	public class	DefaultSyntax : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefaultSyntax
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefaultSyntax
		{
			g_DefaultSyntax_1 = 1,	// "{" "}"

			g_DefaultSyntax_2 = 2,	// "{" FieldSetting-set "}"

		};
		#endregion
		#region production markers associated with the syntax rule DefaultSyntax

		// markers associated with production: DefaultSyntax -> "{" "}"

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: DefaultSyntax -> "{" FieldSetting-set "}"

		public enum production_marker_2 : ushort
		{
			m_FieldSetting_set,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefaultSyntax

		// Constructor declaration(s) associated with production(s) of syntax rule DefaultSyntax

		//
		// Constructor associated with the following production(s)
		// DefaultSyntax -> "{" "}"

		//

		public DefaultSyntax (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._DefaultSyntax_ID, (uint) production_kind.g_DefaultSyntax_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_right_curly_bracket = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// DefaultSyntax -> "{" FieldSetting-set "}"

		//

		public DefaultSyntax (SyntaxTreeToken p_token, FieldSetting_set p_FieldSetting_set, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._DefaultSyntax_ID, (uint) production_kind.g_DefaultSyntax_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_left_curly_bracket = p_token;
			children[1] = m_FieldSetting_set = p_FieldSetting_set;
			children[2] = m_right_curly_bracket = p_token_1;
		}

		public DefaultSyntax () { }

		// Copy constructor

		public DefaultSyntax (DefaultSyntax p_DefaultSyntax) : base (p_DefaultSyntax.id, p_DefaultSyntax.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefaultSyntax.appInfo;
			switch ((production_kind) p_DefaultSyntax.kind)
			{
				case production_kind.g_DefaultSyntax_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_left_curly_bracket = (p_DefaultSyntax.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_DefaultSyntax.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_right_curly_bracket = (p_DefaultSyntax.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_DefaultSyntax.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				case production_kind.g_DefaultSyntax_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_left_curly_bracket = (p_DefaultSyntax.m_left_curly_bracket != null) ? new SyntaxTreeToken (p_DefaultSyntax.m_left_curly_bracket) : null) != null) m_left_curly_bracket.parent = this;
					if ((children [1] = m_FieldSetting_set = (p_DefaultSyntax.m_FieldSetting_set != null) ? new FieldSetting_set (p_DefaultSyntax.m_FieldSetting_set) : null) != null) m_FieldSetting_set.parent = this;
					if ((children [2] = m_right_curly_bracket = (p_DefaultSyntax.m_right_curly_bracket != null) ? new SyntaxTreeToken (p_DefaultSyntax.m_right_curly_bracket) : null) != null) m_right_curly_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefaultSyntax" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefaultSyntax (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_curly_bracket?.Dispose ();
			m_right_curly_bracket?.Dispose ();
			m_FieldSetting_set?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefaultSyntax

		// Content changing function(s) associated with production(s) of syntax rule DefaultSyntax

		//
		// Content changing function associated with following production(s)
		// DefaultSyntax -> "{" "}"

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefaultSyntax_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefaultSyntax -> "{" FieldSetting-set "}"

		//

		public void change(SyntaxTreeToken p_token, FieldSetting_set p_FieldSetting_set, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefaultSyntax_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_left_curly_bracket = p_token;
			children [1] = m_FieldSetting_set = p_FieldSetting_set;
			children [2] = m_right_curly_bracket = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefaultSyntax
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_curly_bracket != null) && m_left_curly_bracket.checkInclusion (element) ||
				(m_right_curly_bracket != null) && m_right_curly_bracket.checkInclusion (element) ||
				(m_FieldSetting_set != null) && m_FieldSetting_set.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefaultSyntax

		//
		// emit production tree node associated with any production of syntax rule DefaultSyntax
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefaultSyntax_1:
					// emit syntax tree node associated with production
					// DefaultSyntax: "{" "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
				case production_kind.g_DefaultSyntax_2:
					// emit syntax tree node associated with production
					// DefaultSyntax: "{" FieldSetting-set "}"

					s += m_left_curly_bracket.Emit (depth - 1);
					s += " ";
					s += m_FieldSetting_set.Emit (depth - 1);
					s += " ";
					s += m_right_curly_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefaultSyntax
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefaultSyntax (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefaultSyntax_1:
					// emit syntax tree node associated with production
					// DefaultSyntax: "{" "}"

					s += "left_curly_bracket";
					s += ' ';
					s += "right_curly_bracket";
				break;
				case production_kind.g_DefaultSyntax_2:
					// emit syntax tree node associated with production
					// DefaultSyntax: "{" FieldSetting-set "}"

					s += "left_curly_bracket";
					s += ' ';
					s += m_FieldSetting_set.EmitProductionTree (depth - 1);
					s += ' ';
					s += "right_curly_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefaultSyntax

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefaultSyntax with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefaultSyntax.production_kind kind = (DefaultSyntax.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefaultSyntax.production_kind.g_DefaultSyntax_1:
					// traverse syntax tree node associated with production
					// DefaultSyntax: "{" "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_right_curly_bracket.Visit (visitor, appData);
				break;
				case DefaultSyntax.production_kind.g_DefaultSyntax_2:
					// traverse syntax tree node associated with production
					// DefaultSyntax: "{" FieldSetting-set "}"

						m_left_curly_bracket.Visit (visitor, appData);
						m_FieldSetting_set.Visit (visitor, appData);
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
			m_right_curly_bracket?.reparent (this);
			m_FieldSetting_set?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefaultSyntax
		//

		public void _init ()
		{
			m_left_curly_bracket = null;
			m_right_curly_bracket = null;
			m_FieldSetting_set = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefaultSyntax

		// counter of all nodes associated with syntax rule DefaultSyntax
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefaultSyntax
		[DataMember (Name = "m_left_curly_bracket")] public SyntaxTreeToken m_left_curly_bracket { get; private set; }
		[DataMember (Name = "m_right_curly_bracket")] public SyntaxTreeToken m_right_curly_bracket { get; private set; }
		[DataMember (Name = "m_FieldSetting_set")] public FieldSetting_set m_FieldSetting_set { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefaultSyntax

		// delegate function (callback) prototype associated with syntax rule DefaultSyntax
		public delegate bool DefaultSyntax_Callback (SyntaxTreeCallbackReason reason, DefaultSyntax.production_kind kind, DefaultSyntax p_DefaultSyntax);

		// event associated with syntax rule DefaultSyntax
		public event DefaultSyntax_Callback DefaultSyntax_Event;

		// event trigger associated with syntax rule DefaultSyntax
		public bool Raise_DefaultSyntax_Event (SyntaxTreeCallbackReason reason, DefaultSyntax.production_kind kind, DefaultSyntax p_DefaultSyntax)
		{
			bool? status = DefaultSyntax_Event?.Invoke (reason, kind, p_DefaultSyntax);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefaultSyntax
		//
		// traverse syntax tree node associated with any production of syntax rule DefaultSyntax
		//

		public void Traverse (DefaultSyntax p_DefaultSyntax)
		{
			if (p_DefaultSyntax.isLocked())
				return;
			p_DefaultSyntax.dolock();
			DefaultSyntax.production_kind kind = (DefaultSyntax.production_kind) p_DefaultSyntax.kind;
			p_DefaultSyntax.turn_reset ();
			if (Raise_DefaultSyntax_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefaultSyntax))
			switch (kind)
			{
				case DefaultSyntax.production_kind.g_DefaultSyntax_1:
					// traverse syntax tree node associated with production
					// DefaultSyntax: "{" "}"

				break;
				case DefaultSyntax.production_kind.g_DefaultSyntax_2:
					// traverse syntax tree node associated with production
					// DefaultSyntax: "{" FieldSetting-set "}"

					if (Raise_DefaultSyntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefaultSyntax))
						Traverse (p_DefaultSyntax.m_FieldSetting_set);
					p_DefaultSyntax.turn_inc ();
					Raise_DefaultSyntax_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefaultSyntax);
				break;
			}
			Raise_DefaultSyntax_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefaultSyntax);
			p_DefaultSyntax.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefaultSyntax
		//

		public void TraverseCommon (DefaultSyntax p_DefaultSyntax)
		{
			DefaultSyntax.production_kind kind = (DefaultSyntax.production_kind) p_DefaultSyntax.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefaultSyntax))
			switch (kind)
			{
				case DefaultSyntax.production_kind.g_DefaultSyntax_1:
					// traverse syntax tree node associated with production
					// DefaultSyntax: "{" "}"

						TraverseCommon (p_DefaultSyntax.m_left_curly_bracket);
						TraverseCommon (p_DefaultSyntax.m_right_curly_bracket);
				break;
				case DefaultSyntax.production_kind.g_DefaultSyntax_2:
					// traverse syntax tree node associated with production
					// DefaultSyntax: "{" FieldSetting-set "}"

						TraverseCommon (p_DefaultSyntax.m_left_curly_bracket);
						TraverseCommon (p_DefaultSyntax.m_FieldSetting_set);
						TraverseCommon (p_DefaultSyntax.m_right_curly_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefaultSyntax);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefaultSyntax

		//
		// create syntax tree node associated with production
		// DefaultSyntax: "{" "}"

		//

		public DefaultSyntax DefaultSyntax_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			DefaultSyntax p_DefaultSyntax_ref = new DefaultSyntax(p_token, p_token_1);
			p_token.parent = p_DefaultSyntax_ref;
			p_token_1.parent = p_DefaultSyntax_ref;
			Raise_DefaultSyntax_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefaultSyntax.production_kind.g_DefaultSyntax_1, p_DefaultSyntax_ref);
			return p_DefaultSyntax_ref;
		}

		//
		// create syntax tree node associated with production
		// DefaultSyntax: "{" FieldSetting-set "}"

		//

		public DefaultSyntax DefaultSyntax_2 (SyntaxTreeToken p_token, FieldSetting_set p_FieldSetting_set, SyntaxTreeToken p_token_1)
		{
			DefaultSyntax p_DefaultSyntax_ref = new DefaultSyntax(p_token, p_FieldSetting_set, p_token_1);
			p_token.parent = p_DefaultSyntax_ref;
			p_FieldSetting_set.parent = p_DefaultSyntax_ref;
			p_token_1.parent = p_DefaultSyntax_ref;
			Raise_DefaultSyntax_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefaultSyntax.production_kind.g_DefaultSyntax_2, p_DefaultSyntax_ref);
			return p_DefaultSyntax_ref;
		}
		#endregion
	};
}
