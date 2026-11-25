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
	// class associated with syntax rule DefinitiveIdentification
	//

	[DataContract]
	public class	DefinitiveIdentification : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule DefinitiveIdentification
		public enum production_kind : ushort	// enumerated production(s) of syntax rule DefinitiveIdentification
		{
			g_DefinitiveIdentification_1 = 1,	// DefinitiveOID

			g_DefinitiveIdentification_2 = 2,	// DefinitiveOIDandIRI

			g_DefinitiveIdentification_3 = 3,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule DefinitiveIdentification

		// markers associated with production: DefinitiveIdentification -> DefinitiveOID

		public enum production_marker_1 : ushort
		{
			m_DefinitiveOID,
			final
		};

		// markers associated with production: DefinitiveIdentification -> DefinitiveOIDandIRI

		public enum production_marker_2 : ushort
		{
			m_DefinitiveOIDandIRI,
			final
		};

		// markers associated with production: DefinitiveIdentification -> %empty

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule DefinitiveIdentification

		// Constructor declaration(s) associated with production(s) of syntax rule DefinitiveIdentification

		//
		// Constructor associated with the following production(s)
		// DefinitiveIdentification -> DefinitiveOID

		//

		public DefinitiveIdentification (DefinitiveOID p_DefinitiveOID) : base ((uint) ProductionID._DefinitiveIdentification_ID, (uint) production_kind.g_DefinitiveIdentification_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinitiveOID = p_DefinitiveOID;
		}

		//
		// Constructor associated with the following production(s)
		// DefinitiveIdentification -> DefinitiveOIDandIRI

		//

		public DefinitiveIdentification (DefinitiveOIDandIRI p_DefinitiveOIDandIRI) : base ((uint) ProductionID._DefinitiveIdentification_ID, (uint) production_kind.g_DefinitiveIdentification_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DefinitiveOIDandIRI = p_DefinitiveOIDandIRI;
		}

		//
		// Constructor associated with the following production(s)
		// DefinitiveIdentification -> %empty

		//

		public DefinitiveIdentification () : base ((uint) ProductionID._DefinitiveIdentification_ID, (uint) production_kind.g_DefinitiveIdentification_3)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public DefinitiveIdentification (DefinitiveIdentification p_DefinitiveIdentification) : base (p_DefinitiveIdentification.id, p_DefinitiveIdentification.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_DefinitiveIdentification.appInfo;
			switch ((production_kind) p_DefinitiveIdentification.kind)
			{
				case production_kind.g_DefinitiveIdentification_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinitiveOID = (p_DefinitiveIdentification.m_DefinitiveOID != null) ? new DefinitiveOID (p_DefinitiveIdentification.m_DefinitiveOID) : null) != null) m_DefinitiveOID.parent = this;
					break;
				case production_kind.g_DefinitiveIdentification_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DefinitiveOIDandIRI = (p_DefinitiveIdentification.m_DefinitiveOIDandIRI != null) ? new DefinitiveOIDandIRI (p_DefinitiveIdentification.m_DefinitiveOIDandIRI) : null) != null) m_DefinitiveOIDandIRI.parent = this;
					break;
				case production_kind.g_DefinitiveIdentification_3:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "DefinitiveIdentification" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new DefinitiveIdentification (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_DefinitiveOID?.Dispose ();
			m_DefinitiveOIDandIRI?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule DefinitiveIdentification

		// Content changing function(s) associated with production(s) of syntax rule DefinitiveIdentification

		//
		// Content changing function associated with following production(s)
		// DefinitiveIdentification -> DefinitiveOID

		//

		public void change(DefinitiveOID p_DefinitiveOID)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitiveIdentification_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinitiveOID = p_DefinitiveOID;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinitiveIdentification -> DefinitiveOIDandIRI

		//

		public void change(DefinitiveOIDandIRI p_DefinitiveOIDandIRI)
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitiveIdentification_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DefinitiveOIDandIRI = p_DefinitiveOIDandIRI;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// DefinitiveIdentification -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_DefinitiveIdentification_3;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule DefinitiveIdentification
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_DefinitiveOID != null) && m_DefinitiveOID.checkInclusion (element) ||
				(m_DefinitiveOIDandIRI != null) && m_DefinitiveOIDandIRI.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule DefinitiveIdentification

		//
		// emit production tree node associated with any production of syntax rule DefinitiveIdentification
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_DefinitiveIdentification_1:
					// emit syntax tree node associated with production
					// DefinitiveIdentification: DefinitiveOID

					s += m_DefinitiveOID.Emit (depth - 1);
				break;
				case production_kind.g_DefinitiveIdentification_2:
					// emit syntax tree node associated with production
					// DefinitiveIdentification: DefinitiveOIDandIRI

					s += m_DefinitiveOIDandIRI.Emit (depth - 1);
				break;
				case production_kind.g_DefinitiveIdentification_3:
					// emit syntax tree node associated with production
					// DefinitiveIdentification: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule DefinitiveIdentification
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "DefinitiveIdentification (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_DefinitiveIdentification_1:
					// emit syntax tree node associated with production
					// DefinitiveIdentification: DefinitiveOID

					s += m_DefinitiveOID.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinitiveIdentification_2:
					// emit syntax tree node associated with production
					// DefinitiveIdentification: DefinitiveOIDandIRI

					s += m_DefinitiveOIDandIRI.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_DefinitiveIdentification_3:
					// emit syntax tree node associated with production
					// DefinitiveIdentification: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule DefinitiveIdentification

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveIdentification with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			DefinitiveIdentification.production_kind kind = (DefinitiveIdentification.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case DefinitiveIdentification.production_kind.g_DefinitiveIdentification_1:
					// traverse syntax tree node associated with production
					// DefinitiveIdentification: DefinitiveOID

						m_DefinitiveOID.Visit (visitor, appData);
				break;
				case DefinitiveIdentification.production_kind.g_DefinitiveIdentification_2:
					// traverse syntax tree node associated with production
					// DefinitiveIdentification: DefinitiveOIDandIRI

						m_DefinitiveOIDandIRI.Visit (visitor, appData);
				break;
				case DefinitiveIdentification.production_kind.g_DefinitiveIdentification_3:
					// traverse syntax tree node associated with production
					// DefinitiveIdentification: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_DefinitiveOID?.reparent (this);
			m_DefinitiveOIDandIRI?.reparent (this);
		}

		//
		// initialize object associated with syntax rule DefinitiveIdentification
		//

		public void _init ()
		{
			m_DefinitiveOID = null;
			m_DefinitiveOIDandIRI = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule DefinitiveIdentification

		// counter of all nodes associated with syntax rule DefinitiveIdentification
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule DefinitiveIdentification
		[DataMember (Name = "m_DefinitiveOID")] public DefinitiveOID m_DefinitiveOID { get; private set; }
		[DataMember (Name = "m_DefinitiveOIDandIRI")] public DefinitiveOIDandIRI m_DefinitiveOIDandIRI { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule DefinitiveIdentification

		// delegate function (callback) prototype associated with syntax rule DefinitiveIdentification
		public delegate bool DefinitiveIdentification_Callback (SyntaxTreeCallbackReason reason, DefinitiveIdentification.production_kind kind, DefinitiveIdentification p_DefinitiveIdentification);

		// event associated with syntax rule DefinitiveIdentification
		public event DefinitiveIdentification_Callback DefinitiveIdentification_Event;

		// event trigger associated with syntax rule DefinitiveIdentification
		public bool Raise_DefinitiveIdentification_Event (SyntaxTreeCallbackReason reason, DefinitiveIdentification.production_kind kind, DefinitiveIdentification p_DefinitiveIdentification)
		{
			bool? status = DefinitiveIdentification_Event?.Invoke (reason, kind, p_DefinitiveIdentification);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule DefinitiveIdentification
		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveIdentification
		//

		public void Traverse (DefinitiveIdentification p_DefinitiveIdentification)
		{
			if (p_DefinitiveIdentification.isLocked())
				return;
			p_DefinitiveIdentification.dolock();
			DefinitiveIdentification.production_kind kind = (DefinitiveIdentification.production_kind) p_DefinitiveIdentification.kind;
			p_DefinitiveIdentification.turn_reset ();
			if (Raise_DefinitiveIdentification_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_DefinitiveIdentification))
			switch (kind)
			{
				case DefinitiveIdentification.production_kind.g_DefinitiveIdentification_1:
					// traverse syntax tree node associated with production
					// DefinitiveIdentification: DefinitiveOID

					if (Raise_DefinitiveIdentification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveIdentification))
						Traverse (p_DefinitiveIdentification.m_DefinitiveOID);
					p_DefinitiveIdentification.turn_inc ();
					Raise_DefinitiveIdentification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveIdentification);
				break;
				case DefinitiveIdentification.production_kind.g_DefinitiveIdentification_2:
					// traverse syntax tree node associated with production
					// DefinitiveIdentification: DefinitiveOIDandIRI

					if (Raise_DefinitiveIdentification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveIdentification))
						Traverse (p_DefinitiveIdentification.m_DefinitiveOIDandIRI);
					p_DefinitiveIdentification.turn_inc ();
					Raise_DefinitiveIdentification_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_DefinitiveIdentification);
				break;
				case DefinitiveIdentification.production_kind.g_DefinitiveIdentification_3:
					// traverse syntax tree node associated with production
					// DefinitiveIdentification: %empty

				break;
			}
			Raise_DefinitiveIdentification_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_DefinitiveIdentification);
			p_DefinitiveIdentification.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule DefinitiveIdentification
		//

		public void TraverseCommon (DefinitiveIdentification p_DefinitiveIdentification)
		{
			DefinitiveIdentification.production_kind kind = (DefinitiveIdentification.production_kind) p_DefinitiveIdentification.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_DefinitiveIdentification))
			switch (kind)
			{
				case DefinitiveIdentification.production_kind.g_DefinitiveIdentification_1:
					// traverse syntax tree node associated with production
					// DefinitiveIdentification: DefinitiveOID

						TraverseCommon (p_DefinitiveIdentification.m_DefinitiveOID);
				break;
				case DefinitiveIdentification.production_kind.g_DefinitiveIdentification_2:
					// traverse syntax tree node associated with production
					// DefinitiveIdentification: DefinitiveOIDandIRI

						TraverseCommon (p_DefinitiveIdentification.m_DefinitiveOIDandIRI);
				break;
				case DefinitiveIdentification.production_kind.g_DefinitiveIdentification_3:
					// traverse syntax tree node associated with production
					// DefinitiveIdentification: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_DefinitiveIdentification);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule DefinitiveIdentification

		//
		// create syntax tree node associated with production
		// DefinitiveIdentification: DefinitiveOID

		//

		public DefinitiveIdentification DefinitiveIdentification_1 (DefinitiveOID p_DefinitiveOID)
		{
			DefinitiveIdentification p_DefinitiveIdentification_ref = new DefinitiveIdentification(p_DefinitiveOID);
			p_DefinitiveOID.parent = p_DefinitiveIdentification_ref;
			Raise_DefinitiveIdentification_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitiveIdentification.production_kind.g_DefinitiveIdentification_1, p_DefinitiveIdentification_ref);
			return p_DefinitiveIdentification_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinitiveIdentification: DefinitiveOIDandIRI

		//

		public DefinitiveIdentification DefinitiveIdentification_2 (DefinitiveOIDandIRI p_DefinitiveOIDandIRI)
		{
			DefinitiveIdentification p_DefinitiveIdentification_ref = new DefinitiveIdentification(p_DefinitiveOIDandIRI);
			p_DefinitiveOIDandIRI.parent = p_DefinitiveIdentification_ref;
			Raise_DefinitiveIdentification_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitiveIdentification.production_kind.g_DefinitiveIdentification_2, p_DefinitiveIdentification_ref);
			return p_DefinitiveIdentification_ref;
		}

		//
		// create syntax tree node associated with production
		// DefinitiveIdentification: %empty

		//

		public DefinitiveIdentification DefinitiveIdentification_3 ()
		{
			DefinitiveIdentification p_DefinitiveIdentification_ref = new DefinitiveIdentification();
			Raise_DefinitiveIdentification_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, DefinitiveIdentification.production_kind.g_DefinitiveIdentification_3, p_DefinitiveIdentification_ref);
			return p_DefinitiveIdentification_ref;
		}
		#endregion
	};
}
