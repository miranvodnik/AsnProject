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
	// class associated with syntax rule UnrestrictedCharacterStringType
	//

	[DataContract]
	public class	UnrestrictedCharacterStringType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule UnrestrictedCharacterStringType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule UnrestrictedCharacterStringType
		{
			g_UnrestrictedCharacterStringType_1 = 1,	// CHARACTER STRING

		};
		#endregion
		#region production markers associated with the syntax rule UnrestrictedCharacterStringType

		// markers associated with production: UnrestrictedCharacterStringType -> CHARACTER STRING

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule UnrestrictedCharacterStringType

		// Constructor declaration(s) associated with production(s) of syntax rule UnrestrictedCharacterStringType

		//
		// Constructor associated with the following production(s)
		// UnrestrictedCharacterStringType -> CHARACTER STRING

		//

		public UnrestrictedCharacterStringType (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._UnrestrictedCharacterStringType_ID, (uint) production_kind.g_UnrestrictedCharacterStringType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_CHARACTER = p_token;
			children[1] = m_STRING = p_token_1;
		}

		public UnrestrictedCharacterStringType () { }

		// Copy constructor

		public UnrestrictedCharacterStringType (UnrestrictedCharacterStringType p_UnrestrictedCharacterStringType) : base (p_UnrestrictedCharacterStringType.id, p_UnrestrictedCharacterStringType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_UnrestrictedCharacterStringType.appInfo;
			switch ((production_kind) p_UnrestrictedCharacterStringType.kind)
			{
				case production_kind.g_UnrestrictedCharacterStringType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_CHARACTER = (p_UnrestrictedCharacterStringType.m_CHARACTER != null) ? new SyntaxTreeToken (p_UnrestrictedCharacterStringType.m_CHARACTER) : null) != null) m_CHARACTER.parent = this;
					if ((children [1] = m_STRING = (p_UnrestrictedCharacterStringType.m_STRING != null) ? new SyntaxTreeToken (p_UnrestrictedCharacterStringType.m_STRING) : null) != null) m_STRING.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "UnrestrictedCharacterStringType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new UnrestrictedCharacterStringType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_CHARACTER?.Dispose ();
			m_STRING?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule UnrestrictedCharacterStringType

		// Content changing function(s) associated with production(s) of syntax rule UnrestrictedCharacterStringType

		//
		// Content changing function associated with following production(s)
		// UnrestrictedCharacterStringType -> CHARACTER STRING

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_UnrestrictedCharacterStringType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_CHARACTER = p_token;
			children [1] = m_STRING = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule UnrestrictedCharacterStringType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_CHARACTER != null) && m_CHARACTER.checkInclusion (element) ||
				(m_STRING != null) && m_STRING.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule UnrestrictedCharacterStringType

		//
		// emit production tree node associated with any production of syntax rule UnrestrictedCharacterStringType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_UnrestrictedCharacterStringType_1:
					// emit syntax tree node associated with production
					// UnrestrictedCharacterStringType: CHARACTER STRING

					s += m_CHARACTER.Emit (depth - 1);
					s += " ";
					s += m_STRING.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule UnrestrictedCharacterStringType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "UnrestrictedCharacterStringType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_UnrestrictedCharacterStringType_1:
					// emit syntax tree node associated with production
					// UnrestrictedCharacterStringType: CHARACTER STRING

					s += "CHARACTER";
					s += ' ';
					s += "STRING";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule UnrestrictedCharacterStringType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule UnrestrictedCharacterStringType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			UnrestrictedCharacterStringType.production_kind kind = (UnrestrictedCharacterStringType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case UnrestrictedCharacterStringType.production_kind.g_UnrestrictedCharacterStringType_1:
					// traverse syntax tree node associated with production
					// UnrestrictedCharacterStringType: CHARACTER STRING

						m_CHARACTER.Visit (visitor, appData);
						m_STRING.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_CHARACTER?.reparent (this);
			m_STRING?.reparent (this);
		}

		//
		// initialize object associated with syntax rule UnrestrictedCharacterStringType
		//

		public void _init ()
		{
			m_CHARACTER = null;
			m_STRING = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule UnrestrictedCharacterStringType

		// counter of all nodes associated with syntax rule UnrestrictedCharacterStringType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule UnrestrictedCharacterStringType
		[DataMember (Name = "m_CHARACTER")] public SyntaxTreeToken m_CHARACTER { get; private set; }
		[DataMember (Name = "m_STRING")] public SyntaxTreeToken m_STRING { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule UnrestrictedCharacterStringType

		// delegate function (callback) prototype associated with syntax rule UnrestrictedCharacterStringType
		public delegate bool UnrestrictedCharacterStringType_Callback (SyntaxTreeCallbackReason reason, UnrestrictedCharacterStringType.production_kind kind, UnrestrictedCharacterStringType p_UnrestrictedCharacterStringType);

		// event associated with syntax rule UnrestrictedCharacterStringType
		public event UnrestrictedCharacterStringType_Callback UnrestrictedCharacterStringType_Event;

		// event trigger associated with syntax rule UnrestrictedCharacterStringType
		public bool Raise_UnrestrictedCharacterStringType_Event (SyntaxTreeCallbackReason reason, UnrestrictedCharacterStringType.production_kind kind, UnrestrictedCharacterStringType p_UnrestrictedCharacterStringType)
		{
			bool? status = UnrestrictedCharacterStringType_Event?.Invoke (reason, kind, p_UnrestrictedCharacterStringType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule UnrestrictedCharacterStringType
		//
		// traverse syntax tree node associated with any production of syntax rule UnrestrictedCharacterStringType
		//

		public void Traverse (UnrestrictedCharacterStringType p_UnrestrictedCharacterStringType)
		{
			if (p_UnrestrictedCharacterStringType.isLocked())
				return;
			p_UnrestrictedCharacterStringType.dolock();
			UnrestrictedCharacterStringType.production_kind kind = (UnrestrictedCharacterStringType.production_kind) p_UnrestrictedCharacterStringType.kind;
			p_UnrestrictedCharacterStringType.turn_reset ();
			if (Raise_UnrestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_UnrestrictedCharacterStringType))
			switch (kind)
			{
				case UnrestrictedCharacterStringType.production_kind.g_UnrestrictedCharacterStringType_1:
					// traverse syntax tree node associated with production
					// UnrestrictedCharacterStringType: CHARACTER STRING

				break;
			}
			Raise_UnrestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_UnrestrictedCharacterStringType);
			p_UnrestrictedCharacterStringType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule UnrestrictedCharacterStringType
		//

		public void TraverseCommon (UnrestrictedCharacterStringType p_UnrestrictedCharacterStringType)
		{
			UnrestrictedCharacterStringType.production_kind kind = (UnrestrictedCharacterStringType.production_kind) p_UnrestrictedCharacterStringType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_UnrestrictedCharacterStringType))
			switch (kind)
			{
				case UnrestrictedCharacterStringType.production_kind.g_UnrestrictedCharacterStringType_1:
					// traverse syntax tree node associated with production
					// UnrestrictedCharacterStringType: CHARACTER STRING

						TraverseCommon (p_UnrestrictedCharacterStringType.m_CHARACTER);
						TraverseCommon (p_UnrestrictedCharacterStringType.m_STRING);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_UnrestrictedCharacterStringType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule UnrestrictedCharacterStringType

		//
		// create syntax tree node associated with production
		// UnrestrictedCharacterStringType: CHARACTER STRING

		//

		public UnrestrictedCharacterStringType UnrestrictedCharacterStringType_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			UnrestrictedCharacterStringType p_UnrestrictedCharacterStringType_ref = new UnrestrictedCharacterStringType(p_token, p_token_1);
			p_token.parent = p_UnrestrictedCharacterStringType_ref;
			p_token_1.parent = p_UnrestrictedCharacterStringType_ref;
			Raise_UnrestrictedCharacterStringType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, UnrestrictedCharacterStringType.production_kind.g_UnrestrictedCharacterStringType_1, p_UnrestrictedCharacterStringType_ref);
			return p_UnrestrictedCharacterStringType_ref;
		}
		#endregion
	};
}
