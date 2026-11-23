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
	// class associated with syntax rule ExtensionDefault
	//

	[DataContract]
	public class	ExtensionDefault : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ExtensionDefault
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ExtensionDefault
		{
			g_ExtensionDefault_1 = 1,	// EXTENSIBILITY IMPLIED

			g_ExtensionDefault_2 = 2,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule ExtensionDefault

		// markers associated with production: ExtensionDefault -> EXTENSIBILITY IMPLIED

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: ExtensionDefault -> %empty

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ExtensionDefault

		// Constructor declaration(s) associated with production(s) of syntax rule ExtensionDefault

		//
		// Constructor associated with the following production(s)
		// ExtensionDefault -> EXTENSIBILITY IMPLIED

		//

		public ExtensionDefault (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._ExtensionDefault_ID, (uint) production_kind.g_ExtensionDefault_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_EXTENSIBILITY = p_token;
			children[1] = m_IMPLIED = p_token_1;
		}

		//
		// Constructor associated with the following production(s)
		// ExtensionDefault -> %empty

		//

		public ExtensionDefault () : base ((uint) ProductionID._ExtensionDefault_ID, (uint) production_kind.g_ExtensionDefault_2)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public ExtensionDefault (ExtensionDefault p_ExtensionDefault) : base (p_ExtensionDefault.id, p_ExtensionDefault.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ExtensionDefault.appInfo;
			switch ((production_kind) p_ExtensionDefault.kind)
			{
				case production_kind.g_ExtensionDefault_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_EXTENSIBILITY = (p_ExtensionDefault.m_EXTENSIBILITY != null) ? new SyntaxTreeToken (p_ExtensionDefault.m_EXTENSIBILITY) : null) != null) m_EXTENSIBILITY.parent = this;
					if ((children [1] = m_IMPLIED = (p_ExtensionDefault.m_IMPLIED != null) ? new SyntaxTreeToken (p_ExtensionDefault.m_IMPLIED) : null) != null) m_IMPLIED.parent = this;
					break;
				case production_kind.g_ExtensionDefault_2:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "ExtensionDefault" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ExtensionDefault (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_EXTENSIBILITY?.Dispose ();
			m_IMPLIED?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ExtensionDefault

		// Content changing function(s) associated with production(s) of syntax rule ExtensionDefault

		//
		// Content changing function associated with following production(s)
		// ExtensionDefault -> EXTENSIBILITY IMPLIED

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionDefault_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_EXTENSIBILITY = p_token;
			children [1] = m_IMPLIED = p_token_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ExtensionDefault -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_ExtensionDefault_2;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ExtensionDefault
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_EXTENSIBILITY != null) && m_EXTENSIBILITY.checkInclusion (element) ||
				(m_IMPLIED != null) && m_IMPLIED.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ExtensionDefault

		//
		// emit production tree node associated with any production of syntax rule ExtensionDefault
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ExtensionDefault_1:
					// emit syntax tree node associated with production
					// ExtensionDefault: EXTENSIBILITY IMPLIED

					s += m_EXTENSIBILITY.Emit (depth - 1);
					s += " ";
					s += m_IMPLIED.Emit (depth - 1);
				break;
				case production_kind.g_ExtensionDefault_2:
					// emit syntax tree node associated with production
					// ExtensionDefault: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ExtensionDefault
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ExtensionDefault (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ExtensionDefault_1:
					// emit syntax tree node associated with production
					// ExtensionDefault: EXTENSIBILITY IMPLIED

					s += "EXTENSIBILITY";
					s += ' ';
					s += "IMPLIED";
				break;
				case production_kind.g_ExtensionDefault_2:
					// emit syntax tree node associated with production
					// ExtensionDefault: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ExtensionDefault

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionDefault with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ExtensionDefault.production_kind kind = (ExtensionDefault.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ExtensionDefault.production_kind.g_ExtensionDefault_1:
					// traverse syntax tree node associated with production
					// ExtensionDefault: EXTENSIBILITY IMPLIED

						m_EXTENSIBILITY.Visit (visitor, appData);
						m_IMPLIED.Visit (visitor, appData);
				break;
				case ExtensionDefault.production_kind.g_ExtensionDefault_2:
					// traverse syntax tree node associated with production
					// ExtensionDefault: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_EXTENSIBILITY?.reparent (this);
			m_IMPLIED?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ExtensionDefault
		//

		public void _init ()
		{
			m_EXTENSIBILITY = null;
			m_IMPLIED = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ExtensionDefault

		// counter of all nodes associated with syntax rule ExtensionDefault
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ExtensionDefault
		[DataMember (Name = "m_EXTENSIBILITY")] public SyntaxTreeToken m_EXTENSIBILITY { get; private set; }
		[DataMember (Name = "m_IMPLIED")] public SyntaxTreeToken m_IMPLIED { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ExtensionDefault

		// delegate function (callback) prototype associated with syntax rule ExtensionDefault
		public delegate bool ExtensionDefault_Callback (SyntaxTreeCallbackReason reason, ExtensionDefault.production_kind kind, ExtensionDefault p_ExtensionDefault);

		// event associated with syntax rule ExtensionDefault
		public event ExtensionDefault_Callback ExtensionDefault_Event;

		// event trigger associated with syntax rule ExtensionDefault
		public bool Raise_ExtensionDefault_Event (SyntaxTreeCallbackReason reason, ExtensionDefault.production_kind kind, ExtensionDefault p_ExtensionDefault)
		{
			bool? status = ExtensionDefault_Event?.Invoke (reason, kind, p_ExtensionDefault);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ExtensionDefault
		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionDefault
		//

		public void Traverse (ExtensionDefault p_ExtensionDefault)
		{
			if (p_ExtensionDefault.isLocked())
				return;
			p_ExtensionDefault.dolock();
			ExtensionDefault.production_kind kind = (ExtensionDefault.production_kind) p_ExtensionDefault.kind;
			p_ExtensionDefault.turn_reset ();
			if (Raise_ExtensionDefault_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ExtensionDefault))
			switch (kind)
			{
				case ExtensionDefault.production_kind.g_ExtensionDefault_1:
					// traverse syntax tree node associated with production
					// ExtensionDefault: EXTENSIBILITY IMPLIED

				break;
				case ExtensionDefault.production_kind.g_ExtensionDefault_2:
					// traverse syntax tree node associated with production
					// ExtensionDefault: %empty

				break;
			}
			Raise_ExtensionDefault_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ExtensionDefault);
			p_ExtensionDefault.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ExtensionDefault
		//

		public void TraverseCommon (ExtensionDefault p_ExtensionDefault)
		{
			ExtensionDefault.production_kind kind = (ExtensionDefault.production_kind) p_ExtensionDefault.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ExtensionDefault))
			switch (kind)
			{
				case ExtensionDefault.production_kind.g_ExtensionDefault_1:
					// traverse syntax tree node associated with production
					// ExtensionDefault: EXTENSIBILITY IMPLIED

						TraverseCommon (p_ExtensionDefault.m_EXTENSIBILITY);
						TraverseCommon (p_ExtensionDefault.m_IMPLIED);
				break;
				case ExtensionDefault.production_kind.g_ExtensionDefault_2:
					// traverse syntax tree node associated with production
					// ExtensionDefault: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ExtensionDefault);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ExtensionDefault

		//
		// create syntax tree node associated with production
		// ExtensionDefault: EXTENSIBILITY IMPLIED

		//

		public ExtensionDefault ExtensionDefault_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			ExtensionDefault p_ExtensionDefault_ref = new ExtensionDefault(p_token, p_token_1);
			p_token.parent = p_ExtensionDefault_ref;
			p_token_1.parent = p_ExtensionDefault_ref;
			Raise_ExtensionDefault_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionDefault.production_kind.g_ExtensionDefault_1, p_ExtensionDefault_ref);
			return p_ExtensionDefault_ref;
		}

		//
		// create syntax tree node associated with production
		// ExtensionDefault: %empty

		//

		public ExtensionDefault ExtensionDefault_2 ()
		{
			ExtensionDefault p_ExtensionDefault_ref = new ExtensionDefault();
			Raise_ExtensionDefault_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ExtensionDefault.production_kind.g_ExtensionDefault_2, p_ExtensionDefault_ref);
			return p_ExtensionDefault_ref;
		}
		#endregion
	};
}
