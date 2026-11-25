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
	// class associated with syntax rule DefinitiveOIDandIRI
	//

	[DataContract]
	public class	DefinitiveOIDandIRI : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinitiveOIDandIRI
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinitiveOIDandIRI
		{
			g_DefinitiveOIDandIRI_1 = 1,	// DefinitiveOID IRIValue

		};
		#endregion
		#region production markers associated with the syntax rule DefinitiveOIDandIRI

		// markers associated with production: DefinitiveOIDandIRI -> DefinitiveOID IRIValue

		public enum production_marker_1 : ushort
		{
			m_DefinitiveOID,
			m_IRIValue,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinitiveOIDandIRI

		// Constructor declaration(s) associated with production(s) of syntax rule DefinitiveOIDandIRI

		//
		// Constructor associated with the following production(s)
		// DefinitiveOIDandIRI -> DefinitiveOID IRIValue

		//

		public DefinitiveOIDandIRI (DefinitiveOID p_DefinitiveOID, IRIValue p_IRIValue) : base ((uint) ProductionID._DefinitiveOIDandIRI_ID, (uint) production_kind.g_DefinitiveOIDandIRI_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_DefinitiveOID = p_DefinitiveOID;
			children[1] = m_IRIValue = p_IRIValue;
		}

		public DefinitiveOIDandIRI () { }

		// Copy constructor

		public DefinitiveOIDandIRI (DefinitiveOIDandIRI p_DefinitiveOIDandIRI) : base (p_DefinitiveOIDandIRI.id, p_DefinitiveOIDandIRI.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinitiveOIDandIRI.appInfo;
			switch ((production_kind) p_DefinitiveOIDandIRI.kind)
			{
				case production_kind.g_DefinitiveOIDandIRI_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_DefinitiveOID = (p_DefinitiveOIDandIRI.m_DefinitiveOID != null) ? new DefinitiveOID (p_DefinitiveOIDandIRI.m_DefinitiveOID) : null) != null) m_DefinitiveOID.parent = this;
					if ((children [1] = m_IRIValue = (p_DefinitiveOIDandIRI.m_IRIValue != null) ? new IRIValue (p_DefinitiveOIDandIRI.m_IRIValue) : null) != null) m_IRIValue.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "DefinitiveOIDandIRI" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinitiveOIDandIRI (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DefinitiveOID?.Dispose ();
			m_IRIValue?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinitiveOIDandIRI

		// Content changing function(s) associated with production(s) of syntax rule DefinitiveOIDandIRI

		//
		// Content changing function associated with following production(s)
		// DefinitiveOIDandIRI -> DefinitiveOID IRIValue

		//

		public void change(DefinitiveOID p_DefinitiveOID, IRIValue p_IRIValue)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitiveOIDandIRI_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_DefinitiveOID = p_DefinitiveOID;
			children [1] = m_IRIValue = p_IRIValue;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinitiveOIDandIRI
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DefinitiveOID != null) && m_DefinitiveOID.checkInclusion (element) ||
				(m_IRIValue != null) && m_IRIValue.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinitiveOIDandIRI

		//
		// emit production tree node associated with any production of syntax rule DefinitiveOIDandIRI
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinitiveOIDandIRI_1:
					// emit syntax tree node associated with production
					// DefinitiveOIDandIRI: DefinitiveOID IRIValue

					s += m_DefinitiveOID.Emit (depth - 1);
					s += " ";
					s += m_IRIValue.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinitiveOIDandIRI
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinitiveOIDandIRI (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinitiveOIDandIRI_1:
					// emit syntax tree node associated with production
					// DefinitiveOIDandIRI: DefinitiveOID IRIValue

					s += m_DefinitiveOID.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_IRIValue.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinitiveOIDandIRI

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveOIDandIRI with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinitiveOIDandIRI.production_kind kind = (DefinitiveOIDandIRI.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinitiveOIDandIRI.production_kind.g_DefinitiveOIDandIRI_1:
					// traverse syntax tree node associated with production
					// DefinitiveOIDandIRI: DefinitiveOID IRIValue

						m_DefinitiveOID.Visit (visitor, appData);
						m_IRIValue.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DefinitiveOID?.reparent (this);
			m_IRIValue?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefinitiveOIDandIRI
		//

		public void _init ()
		{
			m_DefinitiveOID = null;
			m_IRIValue = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinitiveOIDandIRI

		// counter of all nodes associated with syntax rule DefinitiveOIDandIRI
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinitiveOIDandIRI
		[DataMember (Name = "m_DefinitiveOID")] public DefinitiveOID m_DefinitiveOID { get; private set; }
		[DataMember (Name = "m_IRIValue")] public IRIValue m_IRIValue { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinitiveOIDandIRI

		// delegate function (callback) prototype associated with syntax rule DefinitiveOIDandIRI
		public delegate bool DefinitiveOIDandIRI_Callback (SyntaxTreeCallbackReason reason, DefinitiveOIDandIRI.production_kind kind, DefinitiveOIDandIRI p_DefinitiveOIDandIRI);

		// event associated with syntax rule DefinitiveOIDandIRI
		public event DefinitiveOIDandIRI_Callback DefinitiveOIDandIRI_Event;

		// event trigger associated with syntax rule DefinitiveOIDandIRI
		public bool Raise_DefinitiveOIDandIRI_Event (SyntaxTreeCallbackReason reason, DefinitiveOIDandIRI.production_kind kind, DefinitiveOIDandIRI p_DefinitiveOIDandIRI)
		{
			bool? status = DefinitiveOIDandIRI_Event?.Invoke (reason, kind, p_DefinitiveOIDandIRI);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinitiveOIDandIRI
		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveOIDandIRI
		//

		public void Traverse (DefinitiveOIDandIRI p_DefinitiveOIDandIRI)
		{
			if (p_DefinitiveOIDandIRI.isLocked())
				return;
			p_DefinitiveOIDandIRI.dolock();
			DefinitiveOIDandIRI.production_kind kind = (DefinitiveOIDandIRI.production_kind) p_DefinitiveOIDandIRI.kind;
			p_DefinitiveOIDandIRI.turn_reset ();
			if (Raise_DefinitiveOIDandIRI_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinitiveOIDandIRI))
			switch (kind)
			{
				case DefinitiveOIDandIRI.production_kind.g_DefinitiveOIDandIRI_1:
					// traverse syntax tree node associated with production
					// DefinitiveOIDandIRI: DefinitiveOID IRIValue

					if (Raise_DefinitiveOIDandIRI_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveOIDandIRI))
						Traverse (p_DefinitiveOIDandIRI.m_DefinitiveOID);
					p_DefinitiveOIDandIRI.turn_inc ();
					if (Raise_DefinitiveOIDandIRI_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveOIDandIRI))
						Traverse (p_DefinitiveOIDandIRI.m_IRIValue);
					p_DefinitiveOIDandIRI.turn_inc ();
					Raise_DefinitiveOIDandIRI_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveOIDandIRI);
				break;
			}
			Raise_DefinitiveOIDandIRI_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinitiveOIDandIRI);
			p_DefinitiveOIDandIRI.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveOIDandIRI
		//

		public void TraverseCommon (DefinitiveOIDandIRI p_DefinitiveOIDandIRI)
		{
			DefinitiveOIDandIRI.production_kind kind = (DefinitiveOIDandIRI.production_kind) p_DefinitiveOIDandIRI.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinitiveOIDandIRI))
			switch (kind)
			{
				case DefinitiveOIDandIRI.production_kind.g_DefinitiveOIDandIRI_1:
					// traverse syntax tree node associated with production
					// DefinitiveOIDandIRI: DefinitiveOID IRIValue

						TraverseCommon (p_DefinitiveOIDandIRI.m_DefinitiveOID);
						TraverseCommon (p_DefinitiveOIDandIRI.m_IRIValue);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinitiveOIDandIRI);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinitiveOIDandIRI

		//
		// create syntax tree node associated with production
		// DefinitiveOIDandIRI: DefinitiveOID IRIValue

		//

		public DefinitiveOIDandIRI DefinitiveOIDandIRI_1 (DefinitiveOID p_DefinitiveOID, IRIValue p_IRIValue)
		{
			DefinitiveOIDandIRI p_DefinitiveOIDandIRI_ref = new DefinitiveOIDandIRI(p_DefinitiveOID, p_IRIValue);
			p_DefinitiveOID.parent = p_DefinitiveOIDandIRI_ref;
			p_IRIValue.parent = p_DefinitiveOIDandIRI_ref;
			Raise_DefinitiveOIDandIRI_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitiveOIDandIRI.production_kind.g_DefinitiveOIDandIRI_1, p_DefinitiveOIDandIRI_ref);
			return p_DefinitiveOIDandIRI_ref;
		}
		#endregion
	};
}
