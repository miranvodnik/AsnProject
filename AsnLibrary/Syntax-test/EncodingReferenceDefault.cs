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
	// class associated with syntax rule EncodingReferenceDefault
	//

	[DataContract]
	public class	EncodingReferenceDefault : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EncodingReferenceDefault
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EncodingReferenceDefault
		{
			g_EncodingReferenceDefault_1 = 1,	// encodingreference-token INSTRUCTIONS

			g_EncodingReferenceDefault_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule EncodingReferenceDefault

		// markers associated with production: EncodingReferenceDefault -> encodingreference-token INSTRUCTIONS

		public enum production_marker_1 : ushort
		{
			m_encodingreference_token,
			final
		};

		// markers associated with production: EncodingReferenceDefault -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EncodingReferenceDefault

		// Constructor declaration(s) associated with production(s) of syntax rule EncodingReferenceDefault

		//
		// Constructor associated with the following production(s)
		// EncodingReferenceDefault -> encodingreference-token INSTRUCTIONS

		//

		public EncodingReferenceDefault (encodingreference_token p_encodingreference_token, SyntaxTreeToken p_token) : base ((uint) ProductionID._EncodingReferenceDefault_ID, (uint) production_kind.g_EncodingReferenceDefault_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_encodingreference_token = p_encodingreference_token;
			children[1] = m_INSTRUCTIONS = p_token;
		}

		//
		// Constructor associated with the following production(s)
		// EncodingReferenceDefault -> %empty

		//

		public EncodingReferenceDefault () : base ((uint) ProductionID._EncodingReferenceDefault_ID, (uint) production_kind.g_EncodingReferenceDefault_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public EncodingReferenceDefault (EncodingReferenceDefault p_EncodingReferenceDefault) : base (p_EncodingReferenceDefault.id, p_EncodingReferenceDefault.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EncodingReferenceDefault.appInfo;
			switch ((production_kind) p_EncodingReferenceDefault.kind)
			{
				case production_kind.g_EncodingReferenceDefault_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_encodingreference_token = (p_EncodingReferenceDefault.m_encodingreference_token != null) ? new encodingreference_token (p_EncodingReferenceDefault.m_encodingreference_token) : null) != null) m_encodingreference_token.parent = this;
					if ((children [1] = m_INSTRUCTIONS = (p_EncodingReferenceDefault.m_INSTRUCTIONS != null) ? new SyntaxTreeToken (p_EncodingReferenceDefault.m_INSTRUCTIONS) : null) != null) m_INSTRUCTIONS.parent = this;
					break;
				case production_kind.g_EncodingReferenceDefault_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "EncodingReferenceDefault" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EncodingReferenceDefault (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_encodingreference_token?.Dispose ();
			m_INSTRUCTIONS?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EncodingReferenceDefault

		// Content changing function(s) associated with production(s) of syntax rule EncodingReferenceDefault

		//
		// Content changing function associated with following production(s)
		// EncodingReferenceDefault -> encodingreference-token INSTRUCTIONS

		//

		public void change(encodingreference_token p_encodingreference_token, SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_EncodingReferenceDefault_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_encodingreference_token = p_encodingreference_token;
			children [1] = m_INSTRUCTIONS = p_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// EncodingReferenceDefault -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_EncodingReferenceDefault_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EncodingReferenceDefault
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_encodingreference_token != null) && m_encodingreference_token.checkInclusion (element) ||
				(m_INSTRUCTIONS != null) && m_INSTRUCTIONS.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EncodingReferenceDefault

		//
		// emit production tree node associated with any production of syntax rule EncodingReferenceDefault
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EncodingReferenceDefault_1:
					// emit syntax tree node associated with production
					// EncodingReferenceDefault: encodingreference-token INSTRUCTIONS

					s += m_encodingreference_token.Emit (depth - 1);
					s += " ";
					s += m_INSTRUCTIONS.Emit (depth - 1);
				break;
				case production_kind.g_EncodingReferenceDefault_2:
					// emit syntax tree node associated with production
					// EncodingReferenceDefault: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EncodingReferenceDefault
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EncodingReferenceDefault (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EncodingReferenceDefault_1:
					// emit syntax tree node associated with production
					// EncodingReferenceDefault: encodingreference-token INSTRUCTIONS

					s += m_encodingreference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += "INSTRUCTIONS";
				break;
				case production_kind.g_EncodingReferenceDefault_2:
					// emit syntax tree node associated with production
					// EncodingReferenceDefault: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EncodingReferenceDefault

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EncodingReferenceDefault with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EncodingReferenceDefault.production_kind kind = (EncodingReferenceDefault.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EncodingReferenceDefault.production_kind.g_EncodingReferenceDefault_1:
					// traverse syntax tree node associated with production
					// EncodingReferenceDefault: encodingreference-token INSTRUCTIONS

						m_encodingreference_token.Visit (visitor, appData);
						m_INSTRUCTIONS.Visit (visitor, appData);
				break;
				case EncodingReferenceDefault.production_kind.g_EncodingReferenceDefault_2:
					// traverse syntax tree node associated with production
					// EncodingReferenceDefault: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_encodingreference_token?.reparent (this);
			m_INSTRUCTIONS?.reparent (this);
		}

		//
		// initialize object associated with syntax rule EncodingReferenceDefault
		//

		public void _init ()
		{
			m_encodingreference_token = null;
			m_INSTRUCTIONS = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EncodingReferenceDefault

		// counter of all nodes associated with syntax rule EncodingReferenceDefault
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EncodingReferenceDefault
		[DataMember (Name = "m_encodingreference_token")] public encodingreference_token m_encodingreference_token { get; private set; }
		[DataMember (Name = "m_INSTRUCTIONS")] public SyntaxTreeToken m_INSTRUCTIONS { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EncodingReferenceDefault

		// delegate function (callback) prototype associated with syntax rule EncodingReferenceDefault
		public delegate bool EncodingReferenceDefault_Callback (SyntaxTreeCallbackReason reason, EncodingReferenceDefault.production_kind kind, EncodingReferenceDefault p_EncodingReferenceDefault);

		// event associated with syntax rule EncodingReferenceDefault
		public event EncodingReferenceDefault_Callback EncodingReferenceDefault_Event;

		// event trigger associated with syntax rule EncodingReferenceDefault
		public bool Raise_EncodingReferenceDefault_Event (SyntaxTreeCallbackReason reason, EncodingReferenceDefault.production_kind kind, EncodingReferenceDefault p_EncodingReferenceDefault)
		{
			bool? status = EncodingReferenceDefault_Event?.Invoke (reason, kind, p_EncodingReferenceDefault);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EncodingReferenceDefault
		//
		// traverse syntax tree node associated with any production of syntax rule EncodingReferenceDefault
		//

		public void Traverse (EncodingReferenceDefault p_EncodingReferenceDefault)
		{
			if (p_EncodingReferenceDefault.isLocked())
				return;
			p_EncodingReferenceDefault.dolock();
			EncodingReferenceDefault.production_kind kind = (EncodingReferenceDefault.production_kind) p_EncodingReferenceDefault.kind;
			p_EncodingReferenceDefault.turn_reset ();
			if (Raise_EncodingReferenceDefault_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EncodingReferenceDefault))
			switch (kind)
			{
				case EncodingReferenceDefault.production_kind.g_EncodingReferenceDefault_1:
					// traverse syntax tree node associated with production
					// EncodingReferenceDefault: encodingreference-token INSTRUCTIONS

					if (Raise_EncodingReferenceDefault_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EncodingReferenceDefault))
						Traverse (p_EncodingReferenceDefault.m_encodingreference_token);
					p_EncodingReferenceDefault.turn_inc ();
					Raise_EncodingReferenceDefault_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EncodingReferenceDefault);
				break;
				case EncodingReferenceDefault.production_kind.g_EncodingReferenceDefault_2:
					// traverse syntax tree node associated with production
					// EncodingReferenceDefault: %empty

				break;
			}
			Raise_EncodingReferenceDefault_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EncodingReferenceDefault);
			p_EncodingReferenceDefault.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EncodingReferenceDefault
		//

		public void TraverseCommon (EncodingReferenceDefault p_EncodingReferenceDefault)
		{
			EncodingReferenceDefault.production_kind kind = (EncodingReferenceDefault.production_kind) p_EncodingReferenceDefault.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EncodingReferenceDefault))
			switch (kind)
			{
				case EncodingReferenceDefault.production_kind.g_EncodingReferenceDefault_1:
					// traverse syntax tree node associated with production
					// EncodingReferenceDefault: encodingreference-token INSTRUCTIONS

						TraverseCommon (p_EncodingReferenceDefault.m_encodingreference_token);
						TraverseCommon (p_EncodingReferenceDefault.m_INSTRUCTIONS);
				break;
				case EncodingReferenceDefault.production_kind.g_EncodingReferenceDefault_2:
					// traverse syntax tree node associated with production
					// EncodingReferenceDefault: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EncodingReferenceDefault);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EncodingReferenceDefault

		//
		// create syntax tree node associated with production
		// EncodingReferenceDefault: encodingreference-token INSTRUCTIONS

		//

		public EncodingReferenceDefault EncodingReferenceDefault_1 (encodingreference_token p_encodingreference_token, SyntaxTreeToken p_token)
		{
			EncodingReferenceDefault p_EncodingReferenceDefault_ref = new EncodingReferenceDefault(p_encodingreference_token, p_token);
			p_encodingreference_token.parent = p_EncodingReferenceDefault_ref;
			p_token.parent = p_EncodingReferenceDefault_ref;
			Raise_EncodingReferenceDefault_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EncodingReferenceDefault.production_kind.g_EncodingReferenceDefault_1, p_EncodingReferenceDefault_ref);
			return p_EncodingReferenceDefault_ref;
		}

		//
		// create syntax tree node associated with production
		// EncodingReferenceDefault: %empty

		//

		public EncodingReferenceDefault EncodingReferenceDefault_2 ()
		{
			EncodingReferenceDefault p_EncodingReferenceDefault_ref = new EncodingReferenceDefault();
			Raise_EncodingReferenceDefault_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EncodingReferenceDefault.production_kind.g_EncodingReferenceDefault_2, p_EncodingReferenceDefault_ref);
			return p_EncodingReferenceDefault_ref;
		}
		#endregion
	};
}
