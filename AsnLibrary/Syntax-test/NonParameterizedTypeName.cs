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
	// class associated with syntax rule NonParameterizedTypeName
	//

	[DataContract]
	public class	NonParameterizedTypeName : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule NonParameterizedTypeName
		public enum production_kind : ushort	// enumerated production(s) of syntax rule NonParameterizedTypeName
		{
			g_NonParameterizedTypeName_1 = 1,	// ExternalTypeReference

			g_NonParameterizedTypeName_2 = 2,	// typereference-token

			g_NonParameterizedTypeName_3 = 3,	// xmlasn1typename

		};
		#endregion
		#region production markers associated with the syntax rule NonParameterizedTypeName

		// markers associated with production: NonParameterizedTypeName -> ExternalTypeReference

		public enum production_marker_1 : ushort
		{
			m_ExternalTypeReference,
			final
		};

		// markers associated with production: NonParameterizedTypeName -> typereference-token

		public enum production_marker_2 : ushort
		{
			m_typereference_token,
			final
		};

		// markers associated with production: NonParameterizedTypeName -> xmlasn1typename

		public enum production_marker_3 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule NonParameterizedTypeName

		// Constructor declaration(s) associated with production(s) of syntax rule NonParameterizedTypeName

		//
		// Constructor associated with the following production(s)
		// NonParameterizedTypeName -> ExternalTypeReference

		//

		public NonParameterizedTypeName (ExternalTypeReference p_ExternalTypeReference) : base ((uint) ProductionID._NonParameterizedTypeName_ID, (uint) production_kind.g_NonParameterizedTypeName_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_ExternalTypeReference = p_ExternalTypeReference;
		}

		//
		// Constructor associated with the following production(s)
		// NonParameterizedTypeName -> typereference-token

		//

		public NonParameterizedTypeName (typereference_token p_typereference_token) : base ((uint) ProductionID._NonParameterizedTypeName_ID, (uint) production_kind.g_NonParameterizedTypeName_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_typereference_token = p_typereference_token;
		}

		//
		// Constructor associated with the following production(s)
		// NonParameterizedTypeName -> xmlasn1typename

		//

		public NonParameterizedTypeName (SyntaxTreeToken p_token) : base ((uint) ProductionID._NonParameterizedTypeName_ID, (uint) production_kind.g_NonParameterizedTypeName_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_xmlasn1typename = p_token;
		}

		public NonParameterizedTypeName () { }

		// Copy constructor

		public NonParameterizedTypeName (NonParameterizedTypeName p_NonParameterizedTypeName) : base (p_NonParameterizedTypeName.id, p_NonParameterizedTypeName.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_NonParameterizedTypeName.appInfo;
			switch ((production_kind) p_NonParameterizedTypeName.kind)
			{
				case production_kind.g_NonParameterizedTypeName_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_ExternalTypeReference = (p_NonParameterizedTypeName.m_ExternalTypeReference != null) ? new ExternalTypeReference (p_NonParameterizedTypeName.m_ExternalTypeReference) : null) != null) m_ExternalTypeReference.parent = this;
					break;
				case production_kind.g_NonParameterizedTypeName_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_typereference_token = (p_NonParameterizedTypeName.m_typereference_token != null) ? new typereference_token (p_NonParameterizedTypeName.m_typereference_token) : null) != null) m_typereference_token.parent = this;
					break;
				case production_kind.g_NonParameterizedTypeName_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_xmlasn1typename = (p_NonParameterizedTypeName.m_xmlasn1typename != null) ? new SyntaxTreeToken (p_NonParameterizedTypeName.m_xmlasn1typename) : null) != null) m_xmlasn1typename.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "NonParameterizedTypeName" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new NonParameterizedTypeName (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ExternalTypeReference?.Dispose ();
			m_typereference_token?.Dispose ();
			m_xmlasn1typename?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule NonParameterizedTypeName

		// Content changing function(s) associated with production(s) of syntax rule NonParameterizedTypeName

		//
		// Content changing function associated with following production(s)
		// NonParameterizedTypeName -> ExternalTypeReference

		//

		public void change(ExternalTypeReference p_ExternalTypeReference)
		{
			_init ();
			this.kind = (uint) production_kind.g_NonParameterizedTypeName_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_ExternalTypeReference = p_ExternalTypeReference;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NonParameterizedTypeName -> typereference-token

		//

		public void change(typereference_token p_typereference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_NonParameterizedTypeName_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_typereference_token = p_typereference_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// NonParameterizedTypeName -> xmlasn1typename

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_NonParameterizedTypeName_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_xmlasn1typename = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule NonParameterizedTypeName
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ExternalTypeReference != null) && m_ExternalTypeReference.checkInclusion (element) ||
				(m_typereference_token != null) && m_typereference_token.checkInclusion (element) ||
				(m_xmlasn1typename != null) && m_xmlasn1typename.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule NonParameterizedTypeName

		//
		// emit production tree node associated with any production of syntax rule NonParameterizedTypeName
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_NonParameterizedTypeName_1:
					// emit syntax tree node associated with production
					// NonParameterizedTypeName: ExternalTypeReference

					s += m_ExternalTypeReference.Emit (depth - 1);
				break;
				case production_kind.g_NonParameterizedTypeName_2:
					// emit syntax tree node associated with production
					// NonParameterizedTypeName: typereference-token

					s += m_typereference_token.Emit (depth - 1);
				break;
				case production_kind.g_NonParameterizedTypeName_3:
					// emit syntax tree node associated with production
					// NonParameterizedTypeName: xmlasn1typename

					s += m_xmlasn1typename.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule NonParameterizedTypeName
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "NonParameterizedTypeName (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_NonParameterizedTypeName_1:
					// emit syntax tree node associated with production
					// NonParameterizedTypeName: ExternalTypeReference

					s += m_ExternalTypeReference.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_NonParameterizedTypeName_2:
					// emit syntax tree node associated with production
					// NonParameterizedTypeName: typereference-token

					s += m_typereference_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_NonParameterizedTypeName_3:
					// emit syntax tree node associated with production
					// NonParameterizedTypeName: xmlasn1typename

					s += "xmlasn1typename";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule NonParameterizedTypeName

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule NonParameterizedTypeName with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			NonParameterizedTypeName.production_kind kind = (NonParameterizedTypeName.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case NonParameterizedTypeName.production_kind.g_NonParameterizedTypeName_1:
					// traverse syntax tree node associated with production
					// NonParameterizedTypeName: ExternalTypeReference

						m_ExternalTypeReference.Visit (visitor, appData);
				break;
				case NonParameterizedTypeName.production_kind.g_NonParameterizedTypeName_2:
					// traverse syntax tree node associated with production
					// NonParameterizedTypeName: typereference-token

						m_typereference_token.Visit (visitor, appData);
				break;
				case NonParameterizedTypeName.production_kind.g_NonParameterizedTypeName_3:
					// traverse syntax tree node associated with production
					// NonParameterizedTypeName: xmlasn1typename

						m_xmlasn1typename.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ExternalTypeReference?.reparent (this);
			m_typereference_token?.reparent (this);
			m_xmlasn1typename?.reparent (this);
		}

		//
		// initialize object associated with syntax rule NonParameterizedTypeName
		//

		public void _init ()
		{
			m_ExternalTypeReference = null;
			m_typereference_token = null;
			m_xmlasn1typename = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule NonParameterizedTypeName

		// counter of all nodes associated with syntax rule NonParameterizedTypeName
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule NonParameterizedTypeName
		[DataMember (Name = "m_ExternalTypeReference")] public ExternalTypeReference m_ExternalTypeReference { get; private set; }
		[DataMember (Name = "m_typereference_token")] public typereference_token m_typereference_token { get; private set; }
		[DataMember (Name = "m_xmlasn1typename")] public SyntaxTreeToken m_xmlasn1typename { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule NonParameterizedTypeName

		// delegate function (callback) prototype associated with syntax rule NonParameterizedTypeName
		public delegate bool NonParameterizedTypeName_Callback (SyntaxTreeCallbackReason reason, NonParameterizedTypeName.production_kind kind, NonParameterizedTypeName p_NonParameterizedTypeName);

		// event associated with syntax rule NonParameterizedTypeName
		public event NonParameterizedTypeName_Callback NonParameterizedTypeName_Event;

		// event trigger associated with syntax rule NonParameterizedTypeName
		public bool Raise_NonParameterizedTypeName_Event (SyntaxTreeCallbackReason reason, NonParameterizedTypeName.production_kind kind, NonParameterizedTypeName p_NonParameterizedTypeName)
		{
			bool? status = NonParameterizedTypeName_Event?.Invoke (reason, kind, p_NonParameterizedTypeName);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule NonParameterizedTypeName
		//
		// traverse syntax tree node associated with any production of syntax rule NonParameterizedTypeName
		//

		public void Traverse (NonParameterizedTypeName p_NonParameterizedTypeName)
		{
			if (p_NonParameterizedTypeName.isLocked())
				return;
			p_NonParameterizedTypeName.dolock();
			NonParameterizedTypeName.production_kind kind = (NonParameterizedTypeName.production_kind) p_NonParameterizedTypeName.kind;
			p_NonParameterizedTypeName.turn_reset ();
			if (Raise_NonParameterizedTypeName_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_NonParameterizedTypeName))
			switch (kind)
			{
				case NonParameterizedTypeName.production_kind.g_NonParameterizedTypeName_1:
					// traverse syntax tree node associated with production
					// NonParameterizedTypeName: ExternalTypeReference

					if (Raise_NonParameterizedTypeName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NonParameterizedTypeName))
						Traverse (p_NonParameterizedTypeName.m_ExternalTypeReference);
					p_NonParameterizedTypeName.turn_inc ();
					Raise_NonParameterizedTypeName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NonParameterizedTypeName);
				break;
				case NonParameterizedTypeName.production_kind.g_NonParameterizedTypeName_2:
					// traverse syntax tree node associated with production
					// NonParameterizedTypeName: typereference-token

					if (Raise_NonParameterizedTypeName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NonParameterizedTypeName))
						Traverse (p_NonParameterizedTypeName.m_typereference_token);
					p_NonParameterizedTypeName.turn_inc ();
					Raise_NonParameterizedTypeName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_NonParameterizedTypeName);
				break;
				case NonParameterizedTypeName.production_kind.g_NonParameterizedTypeName_3:
					// traverse syntax tree node associated with production
					// NonParameterizedTypeName: xmlasn1typename

				break;
			}
			Raise_NonParameterizedTypeName_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_NonParameterizedTypeName);
			p_NonParameterizedTypeName.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule NonParameterizedTypeName
		//

		public void TraverseCommon (NonParameterizedTypeName p_NonParameterizedTypeName)
		{
			NonParameterizedTypeName.production_kind kind = (NonParameterizedTypeName.production_kind) p_NonParameterizedTypeName.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_NonParameterizedTypeName))
			switch (kind)
			{
				case NonParameterizedTypeName.production_kind.g_NonParameterizedTypeName_1:
					// traverse syntax tree node associated with production
					// NonParameterizedTypeName: ExternalTypeReference

						TraverseCommon (p_NonParameterizedTypeName.m_ExternalTypeReference);
				break;
				case NonParameterizedTypeName.production_kind.g_NonParameterizedTypeName_2:
					// traverse syntax tree node associated with production
					// NonParameterizedTypeName: typereference-token

						TraverseCommon (p_NonParameterizedTypeName.m_typereference_token);
				break;
				case NonParameterizedTypeName.production_kind.g_NonParameterizedTypeName_3:
					// traverse syntax tree node associated with production
					// NonParameterizedTypeName: xmlasn1typename

						TraverseCommon (p_NonParameterizedTypeName.m_xmlasn1typename);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_NonParameterizedTypeName);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule NonParameterizedTypeName

		//
		// create syntax tree node associated with production
		// NonParameterizedTypeName: ExternalTypeReference

		//

		public NonParameterizedTypeName NonParameterizedTypeName_1 (ExternalTypeReference p_ExternalTypeReference)
		{
			NonParameterizedTypeName p_NonParameterizedTypeName_ref = new NonParameterizedTypeName(p_ExternalTypeReference);
			p_ExternalTypeReference.parent = p_NonParameterizedTypeName_ref;
			Raise_NonParameterizedTypeName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NonParameterizedTypeName.production_kind.g_NonParameterizedTypeName_1, p_NonParameterizedTypeName_ref);
			return p_NonParameterizedTypeName_ref;
		}

		//
		// create syntax tree node associated with production
		// NonParameterizedTypeName: typereference-token

		//

		public NonParameterizedTypeName NonParameterizedTypeName_2 (typereference_token p_typereference_token)
		{
			NonParameterizedTypeName p_NonParameterizedTypeName_ref = new NonParameterizedTypeName(p_typereference_token);
			p_typereference_token.parent = p_NonParameterizedTypeName_ref;
			Raise_NonParameterizedTypeName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NonParameterizedTypeName.production_kind.g_NonParameterizedTypeName_2, p_NonParameterizedTypeName_ref);
			return p_NonParameterizedTypeName_ref;
		}

		//
		// create syntax tree node associated with production
		// NonParameterizedTypeName: xmlasn1typename

		//

		public NonParameterizedTypeName NonParameterizedTypeName_3 (SyntaxTreeToken p_token)
		{
			NonParameterizedTypeName p_NonParameterizedTypeName_ref = new NonParameterizedTypeName(p_token);
			p_token.parent = p_NonParameterizedTypeName_ref;
			Raise_NonParameterizedTypeName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, NonParameterizedTypeName.production_kind.g_NonParameterizedTypeName_3, p_NonParameterizedTypeName_ref);
			return p_NonParameterizedTypeName_ref;
		}
		#endregion
	};
}
