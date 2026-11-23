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
	// class associated with syntax rule ModuleIdentifier
	//

	[DataContract]
	public class	ModuleIdentifier : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ModuleIdentifier
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ModuleIdentifier
		{
			g_ModuleIdentifier_1 = 1,	// modulereference-token DefinitiveIdentification

		};
		#endregion
		#region production markers associated with the syntax rule ModuleIdentifier

		// markers associated with production: ModuleIdentifier -> modulereference-token DefinitiveIdentification

		public enum production_marker_1 : ushort
		{
			m_modulereference_token,
			m_DefinitiveIdentification,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ModuleIdentifier

		// Constructor declaration(s) associated with production(s) of syntax rule ModuleIdentifier

		//
		// Constructor associated with the following production(s)
		// ModuleIdentifier -> modulereference-token DefinitiveIdentification

		//

		public ModuleIdentifier (modulereference_token p_modulereference_token, DefinitiveIdentification p_DefinitiveIdentification) : base ((uint) ProductionID._ModuleIdentifier_ID, (uint) production_kind.g_ModuleIdentifier_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_modulereference_token = p_modulereference_token;
			children[1] = m_DefinitiveIdentification = p_DefinitiveIdentification;
		}

		public ModuleIdentifier () { }

		// Copy constructor

		public ModuleIdentifier (ModuleIdentifier p_ModuleIdentifier) : base (p_ModuleIdentifier.id, p_ModuleIdentifier.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ModuleIdentifier.appInfo;
			switch ((production_kind) p_ModuleIdentifier.kind)
			{
				case production_kind.g_ModuleIdentifier_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_modulereference_token = (p_ModuleIdentifier.m_modulereference_token != null) ? new modulereference_token (p_ModuleIdentifier.m_modulereference_token) : null) != null) m_modulereference_token.parent = this;
					if ((children [1] = m_DefinitiveIdentification = (p_ModuleIdentifier.m_DefinitiveIdentification != null) ? new DefinitiveIdentification (p_ModuleIdentifier.m_DefinitiveIdentification) : null) != null) m_DefinitiveIdentification.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ModuleIdentifier" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ModuleIdentifier (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_modulereference_token?.Dispose ();
			m_DefinitiveIdentification?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ModuleIdentifier

		// Content changing function(s) associated with production(s) of syntax rule ModuleIdentifier

		//
		// Content changing function associated with following production(s)
		// ModuleIdentifier -> modulereference-token DefinitiveIdentification

		//

		public void change(modulereference_token p_modulereference_token, DefinitiveIdentification p_DefinitiveIdentification)
		{
			_init ();
			this.kind = (uint) production_kind.g_ModuleIdentifier_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_modulereference_token = p_modulereference_token;
			children [1] = m_DefinitiveIdentification = p_DefinitiveIdentification;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ModuleIdentifier
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_modulereference_token != null) && m_modulereference_token.checkInclusion (element) ||
				(m_DefinitiveIdentification != null) && m_DefinitiveIdentification.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ModuleIdentifier

		//
		// emit production tree node associated with any production of syntax rule ModuleIdentifier
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ModuleIdentifier_1:
					// emit syntax tree node associated with production
					// ModuleIdentifier: modulereference-token DefinitiveIdentification

					s += m_modulereference_token.Emit (depth - 1);
					s += " ";
					s += m_DefinitiveIdentification.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ModuleIdentifier
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ModuleIdentifier (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ModuleIdentifier_1:
					// emit syntax tree node associated with production
					// ModuleIdentifier: modulereference-token DefinitiveIdentification

					s += m_modulereference_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_DefinitiveIdentification.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ModuleIdentifier

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ModuleIdentifier with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ModuleIdentifier.production_kind kind = (ModuleIdentifier.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ModuleIdentifier.production_kind.g_ModuleIdentifier_1:
					// traverse syntax tree node associated with production
					// ModuleIdentifier: modulereference-token DefinitiveIdentification

						m_modulereference_token.Visit (visitor, appData);
						m_DefinitiveIdentification.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_modulereference_token?.reparent (this);
			m_DefinitiveIdentification?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ModuleIdentifier
		//

		public void _init ()
		{
			m_modulereference_token = null;
			m_DefinitiveIdentification = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ModuleIdentifier

		// counter of all nodes associated with syntax rule ModuleIdentifier
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ModuleIdentifier
		[DataMember (Name = "m_modulereference_token")] public modulereference_token m_modulereference_token { get; private set; }
		[DataMember (Name = "m_DefinitiveIdentification")] public DefinitiveIdentification m_DefinitiveIdentification { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ModuleIdentifier

		// delegate function (callback) prototype associated with syntax rule ModuleIdentifier
		public delegate bool ModuleIdentifier_Callback (SyntaxTreeCallbackReason reason, ModuleIdentifier.production_kind kind, ModuleIdentifier p_ModuleIdentifier);

		// event associated with syntax rule ModuleIdentifier
		public event ModuleIdentifier_Callback ModuleIdentifier_Event;

		// event trigger associated with syntax rule ModuleIdentifier
		public bool Raise_ModuleIdentifier_Event (SyntaxTreeCallbackReason reason, ModuleIdentifier.production_kind kind, ModuleIdentifier p_ModuleIdentifier)
		{
			bool? status = ModuleIdentifier_Event?.Invoke (reason, kind, p_ModuleIdentifier);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ModuleIdentifier
		//
		// traverse syntax tree node associated with any production of syntax rule ModuleIdentifier
		//

		public void Traverse (ModuleIdentifier p_ModuleIdentifier)
		{
			if (p_ModuleIdentifier.isLocked())
				return;
			p_ModuleIdentifier.dolock();
			ModuleIdentifier.production_kind kind = (ModuleIdentifier.production_kind) p_ModuleIdentifier.kind;
			p_ModuleIdentifier.turn_reset ();
			if (Raise_ModuleIdentifier_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ModuleIdentifier))
			switch (kind)
			{
				case ModuleIdentifier.production_kind.g_ModuleIdentifier_1:
					// traverse syntax tree node associated with production
					// ModuleIdentifier: modulereference-token DefinitiveIdentification

					if (Raise_ModuleIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleIdentifier))
						Traverse (p_ModuleIdentifier.m_modulereference_token);
					p_ModuleIdentifier.turn_inc ();
					if (Raise_ModuleIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleIdentifier))
						Traverse (p_ModuleIdentifier.m_DefinitiveIdentification);
					p_ModuleIdentifier.turn_inc ();
					Raise_ModuleIdentifier_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleIdentifier);
				break;
			}
			Raise_ModuleIdentifier_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ModuleIdentifier);
			p_ModuleIdentifier.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ModuleIdentifier
		//

		public void TraverseCommon (ModuleIdentifier p_ModuleIdentifier)
		{
			ModuleIdentifier.production_kind kind = (ModuleIdentifier.production_kind) p_ModuleIdentifier.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ModuleIdentifier))
			switch (kind)
			{
				case ModuleIdentifier.production_kind.g_ModuleIdentifier_1:
					// traverse syntax tree node associated with production
					// ModuleIdentifier: modulereference-token DefinitiveIdentification

						TraverseCommon (p_ModuleIdentifier.m_modulereference_token);
						TraverseCommon (p_ModuleIdentifier.m_DefinitiveIdentification);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ModuleIdentifier);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ModuleIdentifier

		//
		// create syntax tree node associated with production
		// ModuleIdentifier: modulereference-token DefinitiveIdentification

		//

		public ModuleIdentifier ModuleIdentifier_1 (modulereference_token p_modulereference_token, DefinitiveIdentification p_DefinitiveIdentification)
		{
			ModuleIdentifier p_ModuleIdentifier_ref = new ModuleIdentifier(p_modulereference_token, p_DefinitiveIdentification);
			p_modulereference_token.parent = p_ModuleIdentifier_ref;
			p_DefinitiveIdentification.parent = p_ModuleIdentifier_ref;
			Raise_ModuleIdentifier_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ModuleIdentifier.production_kind.g_ModuleIdentifier_1, p_ModuleIdentifier_ref);
			return p_ModuleIdentifier_ref;
		}
		#endregion
	};
}
