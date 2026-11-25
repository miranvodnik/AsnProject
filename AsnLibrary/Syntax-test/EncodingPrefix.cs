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
	// class associated with syntax rule EncodingPrefix
	//

	[DataContract]
	public class	EncodingPrefix : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EncodingPrefix
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EncodingPrefix
		{
			g_EncodingPrefix_1 = 1,	// "[" EncodingReference EncodingInstruction "]"

		};
		#endregion
		#region production markers associated with the syntax rule EncodingPrefix

		// markers associated with production: EncodingPrefix -> "[" EncodingReference EncodingInstruction "]"

		public enum production_marker_1 : ushort
		{
			m_EncodingReference,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EncodingPrefix

		// Constructor declaration(s) associated with production(s) of syntax rule EncodingPrefix

		//
		// Constructor associated with the following production(s)
		// EncodingPrefix -> "[" EncodingReference EncodingInstruction "]"

		//

		public EncodingPrefix (SyntaxTreeToken p_token, EncodingReference p_EncodingReference, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._EncodingPrefix_ID, (uint) production_kind.g_EncodingPrefix_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children[0] = m_left_square_bracket = p_token;
			children[1] = m_EncodingReference = p_EncodingReference;
			children[2] = m_EncodingInstruction = p_token_1;
			children[3] = m_right_square_bracket = p_token_2;
		}

		public EncodingPrefix () { }

		// Copy constructor

		public EncodingPrefix (EncodingPrefix p_EncodingPrefix) : base (p_EncodingPrefix.id, p_EncodingPrefix.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EncodingPrefix.appInfo;
			switch ((production_kind) p_EncodingPrefix.kind)
			{
				case production_kind.g_EncodingPrefix_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
					if ((children [0] = m_left_square_bracket = (p_EncodingPrefix.m_left_square_bracket != null) ? new SyntaxTreeToken (p_EncodingPrefix.m_left_square_bracket) : null) != null) m_left_square_bracket.parent = this;
					if ((children [1] = m_EncodingReference = (p_EncodingPrefix.m_EncodingReference != null) ? new EncodingReference (p_EncodingPrefix.m_EncodingReference) : null) != null) m_EncodingReference.parent = this;
					if ((children [2] = m_EncodingInstruction = (p_EncodingPrefix.m_EncodingInstruction != null) ? new SyntaxTreeToken (p_EncodingPrefix.m_EncodingInstruction) : null) != null) m_EncodingInstruction.parent = this;
					if ((children [3] = m_right_square_bracket = (p_EncodingPrefix.m_right_square_bracket != null) ? new SyntaxTreeToken (p_EncodingPrefix.m_right_square_bracket) : null) != null) m_right_square_bracket.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EncodingPrefix" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EncodingPrefix (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_left_square_bracket?.Dispose ();
			m_EncodingReference?.Dispose ();
			m_EncodingInstruction?.Dispose ();
			m_right_square_bracket?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EncodingPrefix

		// Content changing function(s) associated with production(s) of syntax rule EncodingPrefix

		//
		// Content changing function associated with following production(s)
		// EncodingPrefix -> "[" EncodingReference EncodingInstruction "]"

		//

		public void change(SyntaxTreeToken p_token, EncodingReference p_EncodingReference, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_EncodingPrefix_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 4);
			children [0] = m_left_square_bracket = p_token;
			children [1] = m_EncodingReference = p_EncodingReference;
			children [2] = m_EncodingInstruction = p_token_1;
			children [3] = m_right_square_bracket = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EncodingPrefix
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_left_square_bracket != null) && m_left_square_bracket.checkInclusion (element) ||
				(m_EncodingReference != null) && m_EncodingReference.checkInclusion (element) ||
				(m_EncodingInstruction != null) && m_EncodingInstruction.checkInclusion (element) ||
				(m_right_square_bracket != null) && m_right_square_bracket.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EncodingPrefix

		//
		// emit production tree node associated with any production of syntax rule EncodingPrefix
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EncodingPrefix_1:
					// emit syntax tree node associated with production
					// EncodingPrefix: "[" EncodingReference EncodingInstruction "]"

					s += m_left_square_bracket.Emit (depth - 1);
					s += " ";
					s += m_EncodingReference.Emit (depth - 1);
					s += " ";
					s += m_EncodingInstruction.Emit (depth - 1);
					s += " ";
					s += m_right_square_bracket.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EncodingPrefix
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EncodingPrefix (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EncodingPrefix_1:
					// emit syntax tree node associated with production
					// EncodingPrefix: "[" EncodingReference EncodingInstruction "]"

					s += "left_square_bracket";
					s += ' ';
					s += m_EncodingReference.EmitProductionTree (depth - 1);
					s += ' ';
					s += "EncodingInstruction";
					s += ' ';
					s += "right_square_bracket";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EncodingPrefix

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EncodingPrefix with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EncodingPrefix.production_kind kind = (EncodingPrefix.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EncodingPrefix.production_kind.g_EncodingPrefix_1:
					// traverse syntax tree node associated with production
					// EncodingPrefix: "[" EncodingReference EncodingInstruction "]"

						m_left_square_bracket.Visit (visitor, appData);
						m_EncodingReference.Visit (visitor, appData);
						m_EncodingInstruction.Visit (visitor, appData);
						m_right_square_bracket.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_left_square_bracket?.reparent (this);
			m_EncodingReference?.reparent (this);
			m_EncodingInstruction?.reparent (this);
			m_right_square_bracket?.reparent (this);
		}

		//
		// initialize object associated with syntax rule EncodingPrefix
		//

		public void _init ()
		{
			m_left_square_bracket = null;
			m_EncodingReference = null;
			m_EncodingInstruction = null;
			m_right_square_bracket = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EncodingPrefix

		// counter of all nodes associated with syntax rule EncodingPrefix
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EncodingPrefix
		[DataMember (Name = "m_left_square_bracket")] public SyntaxTreeToken m_left_square_bracket { get; private set; }
		[DataMember (Name = "m_EncodingReference")] public EncodingReference m_EncodingReference { get; private set; }
		[DataMember (Name = "m_EncodingInstruction")] public SyntaxTreeToken m_EncodingInstruction { get; private set; }
		[DataMember (Name = "m_right_square_bracket")] public SyntaxTreeToken m_right_square_bracket { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EncodingPrefix

		// delegate function (callback) prototype associated with syntax rule EncodingPrefix
		public delegate bool EncodingPrefix_Callback (SyntaxTreeCallbackReason reason, EncodingPrefix.production_kind kind, EncodingPrefix p_EncodingPrefix);

		// event associated with syntax rule EncodingPrefix
		public event EncodingPrefix_Callback EncodingPrefix_Event;

		// event trigger associated with syntax rule EncodingPrefix
		public bool Raise_EncodingPrefix_Event (SyntaxTreeCallbackReason reason, EncodingPrefix.production_kind kind, EncodingPrefix p_EncodingPrefix)
		{
			bool? status = EncodingPrefix_Event?.Invoke (reason, kind, p_EncodingPrefix);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EncodingPrefix
		//
		// traverse syntax tree node associated with any production of syntax rule EncodingPrefix
		//

		public void Traverse (EncodingPrefix p_EncodingPrefix)
		{
			if (p_EncodingPrefix.isLocked())
				return;
			p_EncodingPrefix.dolock();
			EncodingPrefix.production_kind kind = (EncodingPrefix.production_kind) p_EncodingPrefix.kind;
			p_EncodingPrefix.turn_reset ();
			if (Raise_EncodingPrefix_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EncodingPrefix))
			switch (kind)
			{
				case EncodingPrefix.production_kind.g_EncodingPrefix_1:
					// traverse syntax tree node associated with production
					// EncodingPrefix: "[" EncodingReference EncodingInstruction "]"

					if (Raise_EncodingPrefix_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EncodingPrefix))
						Traverse (p_EncodingPrefix.m_EncodingReference);
					p_EncodingPrefix.turn_inc ();
					Raise_EncodingPrefix_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EncodingPrefix);
				break;
			}
			Raise_EncodingPrefix_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EncodingPrefix);
			p_EncodingPrefix.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EncodingPrefix
		//

		public void TraverseCommon (EncodingPrefix p_EncodingPrefix)
		{
			EncodingPrefix.production_kind kind = (EncodingPrefix.production_kind) p_EncodingPrefix.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EncodingPrefix))
			switch (kind)
			{
				case EncodingPrefix.production_kind.g_EncodingPrefix_1:
					// traverse syntax tree node associated with production
					// EncodingPrefix: "[" EncodingReference EncodingInstruction "]"

						TraverseCommon (p_EncodingPrefix.m_left_square_bracket);
						TraverseCommon (p_EncodingPrefix.m_EncodingReference);
						TraverseCommon (p_EncodingPrefix.m_EncodingInstruction);
						TraverseCommon (p_EncodingPrefix.m_right_square_bracket);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EncodingPrefix);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EncodingPrefix

		//
		// create syntax tree node associated with production
		// EncodingPrefix: "[" EncodingReference EncodingInstruction "]"

		//

		public EncodingPrefix EncodingPrefix_1 (SyntaxTreeToken p_token, EncodingReference p_EncodingReference, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			EncodingPrefix p_EncodingPrefix_ref = new EncodingPrefix(p_token, p_EncodingReference, p_token_1, p_token_2);
			p_token.parent = p_EncodingPrefix_ref;
			p_EncodingReference.parent = p_EncodingPrefix_ref;
			p_token_1.parent = p_EncodingPrefix_ref;
			p_token_2.parent = p_EncodingPrefix_ref;
			Raise_EncodingPrefix_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EncodingPrefix.production_kind.g_EncodingPrefix_1, p_EncodingPrefix_ref);
			return p_EncodingPrefix_ref;
		}
		#endregion
	};
}
