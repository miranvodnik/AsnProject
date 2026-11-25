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
	// class associated with syntax rule ArcIdentifier
	//

	[DataContract]
	public class	ArcIdentifier : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ArcIdentifier
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ArcIdentifier
		{
			g_ArcIdentifier_1 = 1,	// integerUnicodeLabel

			g_ArcIdentifier_2 = 2,	// non-integerUnicodeLabel

		};
		#endregion
		#region production markers associated with the syntax rule ArcIdentifier

		// markers associated with production: ArcIdentifier -> integerUnicodeLabel

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: ArcIdentifier -> non-integerUnicodeLabel

		public enum production_marker_2 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ArcIdentifier

		// Constructor declaration(s) associated with production(s) of syntax rule ArcIdentifier

		//
		// Constructor associated with the following production(s)
		// ArcIdentifier -> integerUnicodeLabel

		// ArcIdentifier -> non-integerUnicodeLabel

		//

		public ArcIdentifier (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._ArcIdentifier_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_ArcIdentifier_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_integerUnicodeLabel = p_token;
				break;
			case production_kind.g_ArcIdentifier_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_non_integerUnicodeLabel = p_token;
				break;
			default:
				{
					string[] args = new string[] { "ArcIdentifier" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		public ArcIdentifier () { }

		// Copy constructor

		public ArcIdentifier (ArcIdentifier p_ArcIdentifier) : base (p_ArcIdentifier.id, p_ArcIdentifier.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ArcIdentifier.appInfo;
			switch ((production_kind) p_ArcIdentifier.kind)
			{
				case production_kind.g_ArcIdentifier_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_integerUnicodeLabel = (p_ArcIdentifier.m_integerUnicodeLabel != null) ? new SyntaxTreeToken (p_ArcIdentifier.m_integerUnicodeLabel) : null) != null) m_integerUnicodeLabel.parent = this;
					break;
				case production_kind.g_ArcIdentifier_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_non_integerUnicodeLabel = (p_ArcIdentifier.m_non_integerUnicodeLabel != null) ? new SyntaxTreeToken (p_ArcIdentifier.m_non_integerUnicodeLabel) : null) != null) m_non_integerUnicodeLabel.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ArcIdentifier" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ArcIdentifier (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_integerUnicodeLabel?.Dispose ();
			m_non_integerUnicodeLabel?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ArcIdentifier

		// Content changing function(s) associated with production(s) of syntax rule ArcIdentifier

		//
		// Content changing function associated with following production(s)
		// ArcIdentifier -> integerUnicodeLabel

		// ArcIdentifier -> non-integerUnicodeLabel

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_ArcIdentifier_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_integerUnicodeLabel = p_token;
				break;
			case production_kind.g_ArcIdentifier_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_non_integerUnicodeLabel = p_token;
				break;
			default:
				{
					string[] args = new string[] { "ArcIdentifier" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ArcIdentifier
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_integerUnicodeLabel != null) && m_integerUnicodeLabel.checkInclusion (element) ||
				(m_non_integerUnicodeLabel != null) && m_non_integerUnicodeLabel.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ArcIdentifier

		//
		// emit production tree node associated with any production of syntax rule ArcIdentifier
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ArcIdentifier_1:
					// emit syntax tree node associated with production
					// ArcIdentifier: integerUnicodeLabel

					s += m_integerUnicodeLabel.Emit (depth - 1);
				break;
				case production_kind.g_ArcIdentifier_2:
					// emit syntax tree node associated with production
					// ArcIdentifier: non-integerUnicodeLabel

					s += m_non_integerUnicodeLabel.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ArcIdentifier
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ArcIdentifier (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ArcIdentifier_1:
					// emit syntax tree node associated with production
					// ArcIdentifier: integerUnicodeLabel

					s += "integerUnicodeLabel";
				break;
				case production_kind.g_ArcIdentifier_2:
					// emit syntax tree node associated with production
					// ArcIdentifier: non-integerUnicodeLabel

					s += "non_integerUnicodeLabel";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ArcIdentifier

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ArcIdentifier with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ArcIdentifier.production_kind kind = (ArcIdentifier.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ArcIdentifier.production_kind.g_ArcIdentifier_1:
					// traverse syntax tree node associated with production
					// ArcIdentifier: integerUnicodeLabel

						m_integerUnicodeLabel.Visit (visitor, appData);
				break;
				case ArcIdentifier.production_kind.g_ArcIdentifier_2:
					// traverse syntax tree node associated with production
					// ArcIdentifier: non-integerUnicodeLabel

						m_non_integerUnicodeLabel.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_integerUnicodeLabel?.reparent (this);
			m_non_integerUnicodeLabel?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ArcIdentifier
		//

		public void _init ()
		{
			m_integerUnicodeLabel = null;
			m_non_integerUnicodeLabel = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ArcIdentifier

		// counter of all nodes associated with syntax rule ArcIdentifier
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ArcIdentifier
		[DataMember (Name = "m_integerUnicodeLabel")] public SyntaxTreeToken m_integerUnicodeLabel { get; private set; }
		[DataMember (Name = "m_non_integerUnicodeLabel")] public SyntaxTreeToken m_non_integerUnicodeLabel { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ArcIdentifier

		// delegate function (callback) prototype associated with syntax rule ArcIdentifier
		public delegate bool ArcIdentifier_Callback (SyntaxTreeCallbackReason reason, ArcIdentifier.production_kind kind, ArcIdentifier p_ArcIdentifier);

		// event associated with syntax rule ArcIdentifier
		public event ArcIdentifier_Callback ArcIdentifier_Event;

		// event trigger associated with syntax rule ArcIdentifier
		public bool Raise_ArcIdentifier_Event (SyntaxTreeCallbackReason reason, ArcIdentifier.production_kind kind, ArcIdentifier p_ArcIdentifier)
		{
			bool? status = ArcIdentifier_Event?.Invoke (reason, kind, p_ArcIdentifier);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ArcIdentifier
		//
		// traverse syntax tree node associated with any production of syntax rule ArcIdentifier
		//

		public void Traverse (ArcIdentifier p_ArcIdentifier)
		{
			if (p_ArcIdentifier.isLocked())
				return;
			p_ArcIdentifier.dolock();
			ArcIdentifier.production_kind kind = (ArcIdentifier.production_kind) p_ArcIdentifier.kind;
			p_ArcIdentifier.turn_reset ();
			if (Raise_ArcIdentifier_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ArcIdentifier))
			switch (kind)
			{
				case ArcIdentifier.production_kind.g_ArcIdentifier_1:
					// traverse syntax tree node associated with production
					// ArcIdentifier: integerUnicodeLabel

				break;
				case ArcIdentifier.production_kind.g_ArcIdentifier_2:
					// traverse syntax tree node associated with production
					// ArcIdentifier: non-integerUnicodeLabel

				break;
			}
			Raise_ArcIdentifier_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ArcIdentifier);
			p_ArcIdentifier.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ArcIdentifier
		//

		public void TraverseCommon (ArcIdentifier p_ArcIdentifier)
		{
			ArcIdentifier.production_kind kind = (ArcIdentifier.production_kind) p_ArcIdentifier.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ArcIdentifier))
			switch (kind)
			{
				case ArcIdentifier.production_kind.g_ArcIdentifier_1:
					// traverse syntax tree node associated with production
					// ArcIdentifier: integerUnicodeLabel

						TraverseCommon (p_ArcIdentifier.m_integerUnicodeLabel);
				break;
				case ArcIdentifier.production_kind.g_ArcIdentifier_2:
					// traverse syntax tree node associated with production
					// ArcIdentifier: non-integerUnicodeLabel

						TraverseCommon (p_ArcIdentifier.m_non_integerUnicodeLabel);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ArcIdentifier);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ArcIdentifier

		//
		// create syntax tree node associated with production
		// ArcIdentifier: integerUnicodeLabel

		//

		public ArcIdentifier ArcIdentifier_1 (SyntaxTreeToken p_token)
		{
			ArcIdentifier p_ArcIdentifier_ref = new ArcIdentifier(p_token, 1);
			p_token.parent = p_ArcIdentifier_ref;
			Raise_ArcIdentifier_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ArcIdentifier.production_kind.g_ArcIdentifier_1, p_ArcIdentifier_ref);
			return p_ArcIdentifier_ref;
		}

		//
		// create syntax tree node associated with production
		// ArcIdentifier: non-integerUnicodeLabel

		//

		public ArcIdentifier ArcIdentifier_2 (SyntaxTreeToken p_token)
		{
			ArcIdentifier p_ArcIdentifier_ref = new ArcIdentifier(p_token, 2);
			p_token.parent = p_ArcIdentifier_ref;
			Raise_ArcIdentifier_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ArcIdentifier.production_kind.g_ArcIdentifier_2, p_ArcIdentifier_ref);
			return p_ArcIdentifier_ref;
		}
		#endregion
	};
}
