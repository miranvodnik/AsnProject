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
	// class associated with syntax rule Plane
	//

	[DataContract]
	public class	Plane : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Plane
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Plane
		{
			g_Plane_1 = 1,	// number

		};
		#endregion
		#region production markers associated with the syntax rule Plane

		// markers associated with production: Plane -> number

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Plane

		// Constructor declaration(s) associated with production(s) of syntax rule Plane

		//
		// Constructor associated with the following production(s)
		// Plane -> number

		//

		public Plane (SyntaxTreeToken p_token) : base ((uint) ProductionID._Plane_ID, (uint) production_kind.g_Plane_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_number = p_token;
		}

		public Plane () { }

		// Copy constructor

		public Plane (Plane p_Plane) : base (p_Plane.id, p_Plane.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Plane.appInfo;
			switch ((production_kind) p_Plane.kind)
			{
				case production_kind.g_Plane_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_number = (p_Plane.m_number != null) ? new SyntaxTreeToken (p_Plane.m_number) : null) != null) m_number.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "Plane" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Plane (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_number?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Plane

		// Content changing function(s) associated with production(s) of syntax rule Plane

		//
		// Content changing function associated with following production(s)
		// Plane -> number

		//

		public void change(SyntaxTreeToken p_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_Plane_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_number = p_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Plane
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_number != null) && m_number.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Plane

		//
		// emit production tree node associated with any production of syntax rule Plane
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Plane_1:
					// emit syntax tree node associated with production
					// Plane: number

					s += m_number.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Plane
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Plane (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Plane_1:
					// emit syntax tree node associated with production
					// Plane: number

					s += "number";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Plane

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Plane with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Plane.production_kind kind = (Plane.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Plane.production_kind.g_Plane_1:
					// traverse syntax tree node associated with production
					// Plane: number

						m_number.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_number?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Plane
		//

		public void _init ()
		{
			m_number = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Plane

		// counter of all nodes associated with syntax rule Plane
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Plane
		[DataMember (Name = "m_number")] public SyntaxTreeToken m_number { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Plane

		// delegate function (callback) prototype associated with syntax rule Plane
		public delegate bool Plane_Callback (SyntaxTreeCallbackReason reason, Plane.production_kind kind, Plane p_Plane);

		// event associated with syntax rule Plane
		public event Plane_Callback Plane_Event;

		// event trigger associated with syntax rule Plane
		public bool Raise_Plane_Event (SyntaxTreeCallbackReason reason, Plane.production_kind kind, Plane p_Plane)
		{
			bool? status = Plane_Event?.Invoke (reason, kind, p_Plane);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Plane
		//
		// traverse syntax tree node associated with any production of syntax rule Plane
		//

		public void Traverse (Plane p_Plane)
		{
			if (p_Plane.isLocked())
				return;
			p_Plane.dolock();
			Plane.production_kind kind = (Plane.production_kind) p_Plane.kind;
			p_Plane.turn_reset ();
			if (Raise_Plane_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Plane))
			switch (kind)
			{
				case Plane.production_kind.g_Plane_1:
					// traverse syntax tree node associated with production
					// Plane: number

				break;
			}
			Raise_Plane_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Plane);
			p_Plane.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Plane
		//

		public void TraverseCommon (Plane p_Plane)
		{
			Plane.production_kind kind = (Plane.production_kind) p_Plane.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Plane))
			switch (kind)
			{
				case Plane.production_kind.g_Plane_1:
					// traverse syntax tree node associated with production
					// Plane: number

						TraverseCommon (p_Plane.m_number);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Plane);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Plane

		//
		// create syntax tree node associated with production
		// Plane: number

		//

		public Plane Plane_1 (SyntaxTreeToken p_token)
		{
			Plane p_Plane_ref = new Plane(p_token);
			p_token.parent = p_Plane_ref;
			Raise_Plane_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Plane.production_kind.g_Plane_1, p_Plane_ref);
			return p_Plane_ref;
		}
		#endregion
	};
}
