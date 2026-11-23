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
	// class associated with syntax rule Reference
	//

	[DataContract]
	public class	Reference : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Reference
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Reference
		{
			g_Reference_1 = 1,	// typereference-token

			g_Reference_2 = 2,	// valuereference-token

			g_Reference_3 = 3,	// objectclassreference-token

			g_Reference_4 = 4,	// objectreference-token

			g_Reference_5 = 5,	// objectsetreference-token

		};
		#endregion
		#region production markers associated with the syntax rule Reference

		// markers associated with production: Reference -> typereference-token

		public enum production_marker_1 : ushort
		{
			m_typereference_token,
			final
		};

		// markers associated with production: Reference -> valuereference-token

		public enum production_marker_2 : ushort
		{
			m_valuereference_token,
			final
		};

		// markers associated with production: Reference -> objectclassreference-token

		public enum production_marker_3 : ushort
		{
			m_objectclassreference_token,
			final
		};

		// markers associated with production: Reference -> objectreference-token

		public enum production_marker_4 : ushort
		{
			m_objectreference_token,
			final
		};

		// markers associated with production: Reference -> objectsetreference-token

		public enum production_marker_5 : ushort
		{
			m_objectsetreference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Reference

		// Constructor declaration(s) associated with production(s) of syntax rule Reference

		//
		// Constructor associated with the following production(s)
		// Reference -> typereference-token

		//

		public Reference (typereference_token p_typereference_token) : base ((uint) ProductionID._Reference_ID, (uint) production_kind.g_Reference_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_typereference_token = p_typereference_token;
		}

		//
		// Constructor associated with the following production(s)
		// Reference -> valuereference-token

		//

		public Reference (valuereference_token p_valuereference_token) : base ((uint) ProductionID._Reference_ID, (uint) production_kind.g_Reference_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_valuereference_token = p_valuereference_token;
		}

		//
		// Constructor associated with the following production(s)
		// Reference -> objectclassreference-token

		//

		public Reference (objectclassreference_token p_objectclassreference_token) : base ((uint) ProductionID._Reference_ID, (uint) production_kind.g_Reference_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_objectclassreference_token = p_objectclassreference_token;
		}

		//
		// Constructor associated with the following production(s)
		// Reference -> objectreference-token

		//

		public Reference (objectreference_token p_objectreference_token) : base ((uint) ProductionID._Reference_ID, (uint) production_kind.g_Reference_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_objectreference_token = p_objectreference_token;
		}

		//
		// Constructor associated with the following production(s)
		// Reference -> objectsetreference-token

		//

		public Reference (objectsetreference_token p_objectsetreference_token) : base ((uint) ProductionID._Reference_ID, (uint) production_kind.g_Reference_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_objectsetreference_token = p_objectsetreference_token;
		}

		public Reference () { }

		// Copy constructor

		public Reference (Reference p_Reference) : base (p_Reference.id, p_Reference.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Reference.appInfo;
			switch ((production_kind) p_Reference.kind)
			{
				case production_kind.g_Reference_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_typereference_token = (p_Reference.m_typereference_token != null) ? new typereference_token (p_Reference.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					break;
				case production_kind.g_Reference_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_valuereference_token = (p_Reference.m_valuereference_token != null) ? new valuereference_token (p_Reference.m_valuereference_token) : null) != null) m_valuereference_token.parent = this;
					break;
				case production_kind.g_Reference_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_objectclassreference_token = (p_Reference.m_objectclassreference_token != null) ? new objectclassreference_token (p_Reference.m_objectclassreference_token) : null) != null) m_objectclassreference_token.parent = this;
					break;
				case production_kind.g_Reference_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_objectreference_token = (p_Reference.m_objectreference_token != null) ? new objectreference_token (p_Reference.m_objectreference_token) : null) != null) m_objectreference_token.parent = this;
					break;
				case production_kind.g_Reference_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_objectsetreference_token = (p_Reference.m_objectsetreference_token != null) ? new objectsetreference_token (p_Reference.m_objectsetreference_token) : null) != null) m_objectsetreference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Reference" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Reference (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_typereference_token?.Dispose ();
			m_valuereference_token?.Dispose ();
			m_objectclassreference_token?.Dispose ();
			m_objectreference_token?.Dispose ();
			m_objectsetreference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Reference

		// Content changing function(s) associated with production(s) of syntax rule Reference

		//
		// Content changing function associated with following production(s)
		// Reference -> typereference-token

		//

		public void change(typereference_token p_typereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Reference_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_typereference_token = p_typereference_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Reference -> valuereference-token

		//

		public void change(valuereference_token p_valuereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Reference_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_valuereference_token = p_valuereference_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Reference -> objectclassreference-token

		//

		public void change(objectclassreference_token p_objectclassreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Reference_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_objectclassreference_token = p_objectclassreference_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Reference -> objectreference-token

		//

		public void change(objectreference_token p_objectreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Reference_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_objectreference_token = p_objectreference_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Reference -> objectsetreference-token

		//

		public void change(objectsetreference_token p_objectsetreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Reference_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_objectsetreference_token = p_objectsetreference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Reference
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				(m_valuereference_token != null) && m_valuereference_token.checkInclusion (element) ||
				(m_objectclassreference_token != null) && m_objectclassreference_token.checkInclusion (element) ||
				(m_objectreference_token != null) && m_objectreference_token.checkInclusion (element) ||
				(m_objectsetreference_token != null) && m_objectsetreference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Reference

		//
		// emit production tree node associated with any production of syntax rule Reference
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Reference_1:
					// emit syntax tree node associated with production
					// Reference: typereference-token

					s += m_typereference_token.Emit (depth - 1);
				break;
				case production_kind.g_Reference_2:
					// emit syntax tree node associated with production
					// Reference: valuereference-token

					s += m_valuereference_token.Emit (depth - 1);
				break;
				case production_kind.g_Reference_3:
					// emit syntax tree node associated with production
					// Reference: objectclassreference-token

					s += m_objectclassreference_token.Emit (depth - 1);
				break;
				case production_kind.g_Reference_4:
					// emit syntax tree node associated with production
					// Reference: objectreference-token

					s += m_objectreference_token.Emit (depth - 1);
				break;
				case production_kind.g_Reference_5:
					// emit syntax tree node associated with production
					// Reference: objectsetreference-token

					s += m_objectsetreference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Reference
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Reference (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Reference_1:
					// emit syntax tree node associated with production
					// Reference: typereference-token

					s += m_typereference_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Reference_2:
					// emit syntax tree node associated with production
					// Reference: valuereference-token

					s += m_valuereference_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Reference_3:
					// emit syntax tree node associated with production
					// Reference: objectclassreference-token

					s += m_objectclassreference_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Reference_4:
					// emit syntax tree node associated with production
					// Reference: objectreference-token

					s += m_objectreference_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Reference_5:
					// emit syntax tree node associated with production
					// Reference: objectsetreference-token

					s += m_objectsetreference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Reference

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Reference with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Reference.production_kind kind = (Reference.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Reference.production_kind.g_Reference_1:
					// traverse syntax tree node associated with production
					// Reference: typereference-token

						m_typereference_token.Visit (visitor, appData);
				break;
				case Reference.production_kind.g_Reference_2:
					// traverse syntax tree node associated with production
					// Reference: valuereference-token

						m_valuereference_token.Visit (visitor, appData);
				break;
				case Reference.production_kind.g_Reference_3:
					// traverse syntax tree node associated with production
					// Reference: objectclassreference-token

						m_objectclassreference_token.Visit (visitor, appData);
				break;
				case Reference.production_kind.g_Reference_4:
					// traverse syntax tree node associated with production
					// Reference: objectreference-token

						m_objectreference_token.Visit (visitor, appData);
				break;
				case Reference.production_kind.g_Reference_5:
					// traverse syntax tree node associated with production
					// Reference: objectsetreference-token

						m_objectsetreference_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_typereference_token?.reparent (this);
			m_valuereference_token?.reparent (this);
			m_objectclassreference_token?.reparent (this);
			m_objectreference_token?.reparent (this);
			m_objectsetreference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Reference
		//

		public void _init ()
		{
			m_typereference_token = null;
			m_valuereference_token = null;
			m_objectclassreference_token = null;
			m_objectreference_token = null;
			m_objectsetreference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Reference

		// counter of all nodes associated with syntax rule Reference
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Reference
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		[DataMember (Name = "m_valuereference_token")] public valuereference_token m_valuereference_token { get; private set; }
		[DataMember (Name = "m_objectclassreference_token")] public objectclassreference_token m_objectclassreference_token { get; private set; }
		[DataMember (Name = "m_objectreference_token")] public objectreference_token m_objectreference_token { get; private set; }
		[DataMember (Name = "m_objectsetreference_token")] public objectsetreference_token m_objectsetreference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Reference

		// delegate function (callback) prototype associated with syntax rule Reference
		public delegate bool Reference_Callback (SyntaxTreeCallbackReason reason, Reference.production_kind kind, Reference p_Reference);

		// event associated with syntax rule Reference
		public event Reference_Callback Reference_Event;

		// event trigger associated with syntax rule Reference
		public bool Raise_Reference_Event (SyntaxTreeCallbackReason reason, Reference.production_kind kind, Reference p_Reference)
		{
			bool? status = Reference_Event?.Invoke (reason, kind, p_Reference);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Reference
		//
		// traverse syntax tree node associated with any production of syntax rule Reference
		//

		public void Traverse (Reference p_Reference)
		{
			if (p_Reference.isLocked())
				return;
			p_Reference.dolock();
			Reference.production_kind kind = (Reference.production_kind) p_Reference.kind;
			p_Reference.turn_reset ();
			if (Raise_Reference_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Reference))
			switch (kind)
			{
				case Reference.production_kind.g_Reference_1:
					// traverse syntax tree node associated with production
					// Reference: typereference-token

					if (Raise_Reference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Reference))
						Traverse (p_Reference.m_typereference_token);
					p_Reference.turn_inc ();
					Raise_Reference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Reference);
				break;
				case Reference.production_kind.g_Reference_2:
					// traverse syntax tree node associated with production
					// Reference: valuereference-token

					if (Raise_Reference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Reference))
						Traverse (p_Reference.m_valuereference_token);
					p_Reference.turn_inc ();
					Raise_Reference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Reference);
				break;
				case Reference.production_kind.g_Reference_3:
					// traverse syntax tree node associated with production
					// Reference: objectclassreference-token

					if (Raise_Reference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Reference))
						Traverse (p_Reference.m_objectclassreference_token);
					p_Reference.turn_inc ();
					Raise_Reference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Reference);
				break;
				case Reference.production_kind.g_Reference_4:
					// traverse syntax tree node associated with production
					// Reference: objectreference-token

					if (Raise_Reference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Reference))
						Traverse (p_Reference.m_objectreference_token);
					p_Reference.turn_inc ();
					Raise_Reference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Reference);
				break;
				case Reference.production_kind.g_Reference_5:
					// traverse syntax tree node associated with production
					// Reference: objectsetreference-token

					if (Raise_Reference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Reference))
						Traverse (p_Reference.m_objectsetreference_token);
					p_Reference.turn_inc ();
					Raise_Reference_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Reference);
				break;
			}
			Raise_Reference_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Reference);
			p_Reference.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Reference
		//

		public void TraverseCommon (Reference p_Reference)
		{
			Reference.production_kind kind = (Reference.production_kind) p_Reference.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Reference))
			switch (kind)
			{
				case Reference.production_kind.g_Reference_1:
					// traverse syntax tree node associated with production
					// Reference: typereference-token

						TraverseCommon (p_Reference.m_typereference_token);
				break;
				case Reference.production_kind.g_Reference_2:
					// traverse syntax tree node associated with production
					// Reference: valuereference-token

						TraverseCommon (p_Reference.m_valuereference_token);
				break;
				case Reference.production_kind.g_Reference_3:
					// traverse syntax tree node associated with production
					// Reference: objectclassreference-token

						TraverseCommon (p_Reference.m_objectclassreference_token);
				break;
				case Reference.production_kind.g_Reference_4:
					// traverse syntax tree node associated with production
					// Reference: objectreference-token

						TraverseCommon (p_Reference.m_objectreference_token);
				break;
				case Reference.production_kind.g_Reference_5:
					// traverse syntax tree node associated with production
					// Reference: objectsetreference-token

						TraverseCommon (p_Reference.m_objectsetreference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Reference);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Reference

		//
		// create syntax tree node associated with production
		// Reference: typereference-token

		//

		public Reference Reference_1 (typereference_token p_typereference_token)
		{
			Reference p_Reference_ref = new Reference(p_typereference_token);
			p_typereference_token.parent = p_Reference_ref;
			Raise_Reference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Reference.production_kind.g_Reference_1, p_Reference_ref);
			return p_Reference_ref;
		}

		//
		// create syntax tree node associated with production
		// Reference: valuereference-token

		//

		public Reference Reference_2 (valuereference_token p_valuereference_token)
		{
			Reference p_Reference_ref = new Reference(p_valuereference_token);
			p_valuereference_token.parent = p_Reference_ref;
			Raise_Reference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Reference.production_kind.g_Reference_2, p_Reference_ref);
			return p_Reference_ref;
		}

		//
		// create syntax tree node associated with production
		// Reference: objectclassreference-token

		//

		public Reference Reference_3 (objectclassreference_token p_objectclassreference_token)
		{
			Reference p_Reference_ref = new Reference(p_objectclassreference_token);
			p_objectclassreference_token.parent = p_Reference_ref;
			Raise_Reference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Reference.production_kind.g_Reference_3, p_Reference_ref);
			return p_Reference_ref;
		}

		//
		// create syntax tree node associated with production
		// Reference: objectreference-token

		//

		public Reference Reference_4 (objectreference_token p_objectreference_token)
		{
			Reference p_Reference_ref = new Reference(p_objectreference_token);
			p_objectreference_token.parent = p_Reference_ref;
			Raise_Reference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Reference.production_kind.g_Reference_4, p_Reference_ref);
			return p_Reference_ref;
		}

		//
		// create syntax tree node associated with production
		// Reference: objectsetreference-token

		//

		public Reference Reference_5 (objectsetreference_token p_objectsetreference_token)
		{
			Reference p_Reference_ref = new Reference(p_objectsetreference_token);
			p_objectsetreference_token.parent = p_Reference_ref;
			Raise_Reference_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Reference.production_kind.g_Reference_5, p_Reference_ref);
			return p_Reference_ref;
		}
		#endregion
	};
}
