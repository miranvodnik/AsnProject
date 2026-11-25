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
	// class associated with syntax rule Parameter
	//

	[DataContract]
	public class	Parameter : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Parameter
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Parameter
		{
			g_Parameter_1 = 1,	// ParamGovernor ":" DummyReference

			g_Parameter_2 = 2,	// DummyReference

		};
		#endregion
		#region production markers associated with the syntax rule Parameter

		// markers associated with production: Parameter -> ParamGovernor ":" DummyReference

		public enum production_marker_1 : ushort
		{
			m_ParamGovernor,
			m_DummyReference,
			final
		};

		// markers associated with production: Parameter -> DummyReference

		public enum production_marker_2 : ushort
		{
			m_DummyReference,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Parameter

		// Constructor declaration(s) associated with production(s) of syntax rule Parameter

		//
		// Constructor associated with the following production(s)
		// Parameter -> ParamGovernor ":" DummyReference

		//

		public Parameter (ParamGovernor p_ParamGovernor, SyntaxTreeToken p_token, DummyReference p_DummyReference) : base ((uint) ProductionID._Parameter_ID, (uint) production_kind.g_Parameter_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ParamGovernor = p_ParamGovernor;
			children[1] = m_colon = p_token;
			children[2] = m_DummyReference = p_DummyReference;
		}

		//
		// Constructor associated with the following production(s)
		// Parameter -> DummyReference

		//

		public Parameter (DummyReference p_DummyReference) : base ((uint) ProductionID._Parameter_ID, (uint) production_kind.g_Parameter_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_DummyReference = p_DummyReference;
		}

		public Parameter () { }

		// Copy constructor

		public Parameter (Parameter p_Parameter) : base (p_Parameter.id, p_Parameter.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Parameter.appInfo;
			switch ((production_kind) p_Parameter.kind)
			{
				case production_kind.g_Parameter_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ParamGovernor = (p_Parameter.m_ParamGovernor != null) ? new ParamGovernor (p_Parameter.m_ParamGovernor) : null) != null) m_ParamGovernor.parent = this;
					if ((children [1] = m_colon = (p_Parameter.m_colon != null) ? new SyntaxTreeToken (p_Parameter.m_colon) : null) != null) m_colon.parent = this;
					if ((children [2] = m_DummyReference = (p_Parameter.m_DummyReference != null) ? new DummyReference (p_Parameter.m_DummyReference) : null) != null) m_DummyReference.parent = this;
					break;
				case production_kind.g_Parameter_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_DummyReference = (p_Parameter.m_DummyReference != null) ? new DummyReference (p_Parameter.m_DummyReference) : null) != null) m_DummyReference.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Parameter" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Parameter (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ParamGovernor?.Dispose ();
			m_colon?.Dispose ();
			m_DummyReference?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Parameter

		// Content changing function(s) associated with production(s) of syntax rule Parameter

		//
		// Content changing function associated with following production(s)
		// Parameter -> ParamGovernor ":" DummyReference

		//

		public void change(ParamGovernor p_ParamGovernor, SyntaxTreeToken p_token, DummyReference p_DummyReference)
		{
			_init ();
			this.kind = (uint) production_kind.g_Parameter_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ParamGovernor = p_ParamGovernor;
			children [1] = m_colon = p_token;
			children [2] = m_DummyReference = p_DummyReference;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Parameter -> DummyReference

		//

		public void change(DummyReference p_DummyReference)
		{
			_init ();
			this.kind = (uint) production_kind.g_Parameter_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_DummyReference = p_DummyReference;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Parameter
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ParamGovernor != null) && m_ParamGovernor.checkInclusion (element) ||
				(m_colon != null) && m_colon.checkInclusion (element) ||
				(m_DummyReference != null) && m_DummyReference.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Parameter

		//
		// emit production tree node associated with any production of syntax rule Parameter
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Parameter_1:
					// emit syntax tree node associated with production
					// Parameter: ParamGovernor ":" DummyReference

					s += m_ParamGovernor.Emit (depth - 1);
					s += " ";
					s += m_colon.Emit (depth - 1);
					s += " ";
					s += m_DummyReference.Emit (depth - 1);
				break;
				case production_kind.g_Parameter_2:
					// emit syntax tree node associated with production
					// Parameter: DummyReference

					s += m_DummyReference.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Parameter
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Parameter (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Parameter_1:
					// emit syntax tree node associated with production
					// Parameter: ParamGovernor ":" DummyReference

					s += m_ParamGovernor.EmitProductionTree (depth - 1);
					s += ' ';
					s += "colon";
					s += ' ';
					s += m_DummyReference.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_Parameter_2:
					// emit syntax tree node associated with production
					// Parameter: DummyReference

					s += m_DummyReference.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Parameter

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Parameter with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Parameter.production_kind kind = (Parameter.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Parameter.production_kind.g_Parameter_1:
					// traverse syntax tree node associated with production
					// Parameter: ParamGovernor ":" DummyReference

						m_ParamGovernor.Visit (visitor, appData);
						m_colon.Visit (visitor, appData);
						m_DummyReference.Visit (visitor, appData);
				break;
				case Parameter.production_kind.g_Parameter_2:
					// traverse syntax tree node associated with production
					// Parameter: DummyReference

						m_DummyReference.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ParamGovernor?.reparent (this);
			m_colon?.reparent (this);
			m_DummyReference?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Parameter
		//

		public void _init ()
		{
			m_ParamGovernor = null;
			m_colon = null;
			m_DummyReference = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Parameter

		// counter of all nodes associated with syntax rule Parameter
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Parameter
		[DataMember (Name = "m_ParamGovernor")] public ParamGovernor m_ParamGovernor { get; private set; }
		[DataMember (Name = "m_colon")] public SyntaxTreeToken m_colon { get; private set; }
		[DataMember (Name = "m_DummyReference")] public DummyReference m_DummyReference { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Parameter

		// delegate function (callback) prototype associated with syntax rule Parameter
		public delegate bool Parameter_Callback (SyntaxTreeCallbackReason reason, Parameter.production_kind kind, Parameter p_Parameter);

		// event associated with syntax rule Parameter
		public event Parameter_Callback Parameter_Event;

		// event trigger associated with syntax rule Parameter
		public bool Raise_Parameter_Event (SyntaxTreeCallbackReason reason, Parameter.production_kind kind, Parameter p_Parameter)
		{
			bool? status = Parameter_Event?.Invoke (reason, kind, p_Parameter);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Parameter
		//
		// traverse syntax tree node associated with any production of syntax rule Parameter
		//

		public void Traverse (Parameter p_Parameter)
		{
			if (p_Parameter.isLocked())
				return;
			p_Parameter.dolock();
			Parameter.production_kind kind = (Parameter.production_kind) p_Parameter.kind;
			p_Parameter.turn_reset ();
			if (Raise_Parameter_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Parameter))
			switch (kind)
			{
				case Parameter.production_kind.g_Parameter_1:
					// traverse syntax tree node associated with production
					// Parameter: ParamGovernor ":" DummyReference

					if (Raise_Parameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Parameter))
						Traverse (p_Parameter.m_ParamGovernor);
					p_Parameter.turn_inc ();
					if (Raise_Parameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Parameter))
						Traverse (p_Parameter.m_DummyReference);
					p_Parameter.turn_inc ();
					Raise_Parameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Parameter);
				break;
				case Parameter.production_kind.g_Parameter_2:
					// traverse syntax tree node associated with production
					// Parameter: DummyReference

					if (Raise_Parameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Parameter))
						Traverse (p_Parameter.m_DummyReference);
					p_Parameter.turn_inc ();
					Raise_Parameter_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_Parameter);
				break;
			}
			Raise_Parameter_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Parameter);
			p_Parameter.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Parameter
		//

		public void TraverseCommon (Parameter p_Parameter)
		{
			Parameter.production_kind kind = (Parameter.production_kind) p_Parameter.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Parameter))
			switch (kind)
			{
				case Parameter.production_kind.g_Parameter_1:
					// traverse syntax tree node associated with production
					// Parameter: ParamGovernor ":" DummyReference

						TraverseCommon (p_Parameter.m_ParamGovernor);
						TraverseCommon (p_Parameter.m_colon);
						TraverseCommon (p_Parameter.m_DummyReference);
				break;
				case Parameter.production_kind.g_Parameter_2:
					// traverse syntax tree node associated with production
					// Parameter: DummyReference

						TraverseCommon (p_Parameter.m_DummyReference);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Parameter);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Parameter

		//
		// create syntax tree node associated with production
		// Parameter: ParamGovernor ":" DummyReference

		//

		public Parameter Parameter_1 (ParamGovernor p_ParamGovernor, SyntaxTreeToken p_token, DummyReference p_DummyReference)
		{
			Parameter p_Parameter_ref = new Parameter(p_ParamGovernor, p_token, p_DummyReference);
			p_ParamGovernor.parent = p_Parameter_ref;
			p_token.parent = p_Parameter_ref;
			p_DummyReference.parent = p_Parameter_ref;
			Raise_Parameter_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Parameter.production_kind.g_Parameter_1, p_Parameter_ref);
			return p_Parameter_ref;
		}

		//
		// create syntax tree node associated with production
		// Parameter: DummyReference

		//

		public Parameter Parameter_2 (DummyReference p_DummyReference)
		{
			Parameter p_Parameter_ref = new Parameter(p_DummyReference);
			p_DummyReference.parent = p_Parameter_ref;
			Raise_Parameter_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Parameter.production_kind.g_Parameter_2, p_Parameter_ref);
			return p_Parameter_ref;
		}
		#endregion
	};
}
