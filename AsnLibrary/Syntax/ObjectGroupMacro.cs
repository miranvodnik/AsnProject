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
	// class associated with syntax rule ObjectGroupMacro
	//

	[DataContract]
	public class	ObjectGroupMacro : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectGroupMacro
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectGroupMacro
		{
			g_ObjectGroupMacro_1 = 1,	// OBJECT-GROUP OG-ObjectsPart STATUS OG-Status DESCRIPTION cstring OG-ReferPart

		};
		#endregion
		#region production markers associated with the syntax rule ObjectGroupMacro

		// markers associated with production: ObjectGroupMacro -> OBJECT-GROUP OG-ObjectsPart STATUS OG-Status DESCRIPTION cstring OG-ReferPart

		public enum production_marker_1 : ushort
		{
			m_OG_ObjectsPart,
			m_OG_Status,
			m_OG_ReferPart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectGroupMacro

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectGroupMacro

		//
		// Constructor associated with the following production(s)
		// ObjectGroupMacro -> OBJECT-GROUP OG-ObjectsPart STATUS OG-Status DESCRIPTION cstring OG-ReferPart

		//

		public ObjectGroupMacro (SyntaxTreeToken p_token, OG_ObjectsPart p_OG_ObjectsPart, SyntaxTreeToken p_token_1, OG_Status p_OG_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, OG_ReferPart p_OG_ReferPart) : base ((uint) ProductionID._ObjectGroupMacro_ID, (uint) production_kind.g_ObjectGroupMacro_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children[0] = m_OBJECT_GROUP = p_token;
			children[1] = m_OG_ObjectsPart = p_OG_ObjectsPart;
			children[2] = m_STATUS = p_token_1;
			children[3] = m_OG_Status = p_OG_Status;
			children[4] = m_DESCRIPTION = p_token_2;
			children[5] = m_cstring = p_token_3;
			children[6] = m_OG_ReferPart = p_OG_ReferPart;
		}

		public ObjectGroupMacro () { }

		// Copy constructor

		public ObjectGroupMacro (ObjectGroupMacro p_ObjectGroupMacro) : base (p_ObjectGroupMacro.id, p_ObjectGroupMacro.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectGroupMacro.appInfo;
			switch ((production_kind) p_ObjectGroupMacro.kind)
			{
				case production_kind.g_ObjectGroupMacro_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_OBJECT_GROUP = (p_ObjectGroupMacro.m_OBJECT_GROUP != null) ? new SyntaxTreeToken (p_ObjectGroupMacro.m_OBJECT_GROUP) : null) != null) m_OBJECT_GROUP.parent = this;
					if ((children [1] = m_OG_ObjectsPart = (p_ObjectGroupMacro.m_OG_ObjectsPart != null) ? new OG_ObjectsPart (p_ObjectGroupMacro.m_OG_ObjectsPart) : null) != null) m_OG_ObjectsPart.parent = this;
					if ((children [2] = m_STATUS = (p_ObjectGroupMacro.m_STATUS != null) ? new SyntaxTreeToken (p_ObjectGroupMacro.m_STATUS) : null) != null) m_STATUS.parent = this;
					if ((children [3] = m_OG_Status = (p_ObjectGroupMacro.m_OG_Status != null) ? new OG_Status (p_ObjectGroupMacro.m_OG_Status) : null) != null) m_OG_Status.parent = this;
					if ((children [4] = m_DESCRIPTION = (p_ObjectGroupMacro.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_ObjectGroupMacro.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [5] = m_cstring = (p_ObjectGroupMacro.m_cstring != null) ? new SyntaxTreeToken (p_ObjectGroupMacro.m_cstring) : null) != null) m_cstring.parent = this;
					if ((children [6] = m_OG_ReferPart = (p_ObjectGroupMacro.m_OG_ReferPart != null) ? new OG_ReferPart (p_ObjectGroupMacro.m_OG_ReferPart) : null) != null) m_OG_ReferPart.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectGroupMacro" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectGroupMacro (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OBJECT_GROUP?.Dispose ();
			m_OG_ObjectsPart?.Dispose ();
			m_STATUS?.Dispose ();
			m_OG_Status?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_cstring?.Dispose ();
			m_OG_ReferPart?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectGroupMacro

		// Content changing function(s) associated with production(s) of syntax rule ObjectGroupMacro

		//
		// Content changing function associated with following production(s)
		// ObjectGroupMacro -> OBJECT-GROUP OG-ObjectsPart STATUS OG-Status DESCRIPTION cstring OG-ReferPart

		//

		public void change(SyntaxTreeToken p_token, OG_ObjectsPart p_OG_ObjectsPart, SyntaxTreeToken p_token_1, OG_Status p_OG_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, OG_ReferPart p_OG_ReferPart)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectGroupMacro_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children [0] = m_OBJECT_GROUP = p_token;
			children [1] = m_OG_ObjectsPart = p_OG_ObjectsPart;
			children [2] = m_STATUS = p_token_1;
			children [3] = m_OG_Status = p_OG_Status;
			children [4] = m_DESCRIPTION = p_token_2;
			children [5] = m_cstring = p_token_3;
			children [6] = m_OG_ReferPart = p_OG_ReferPart;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectGroupMacro
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OBJECT_GROUP != null) && m_OBJECT_GROUP.checkInclusion (element) ||
				(m_OG_ObjectsPart != null) && m_OG_ObjectsPart.checkInclusion (element) ||
				(m_STATUS != null) && m_STATUS.checkInclusion (element) ||
				(m_OG_Status != null) && m_OG_Status.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				(m_OG_ReferPart != null) && m_OG_ReferPart.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectGroupMacro

		//
		// emit production tree node associated with any production of syntax rule ObjectGroupMacro
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectGroupMacro_1:
					// emit syntax tree node associated with production
					// ObjectGroupMacro: OBJECT-GROUP OG-ObjectsPart STATUS OG-Status DESCRIPTION cstring OG-ReferPart

					s += m_OBJECT_GROUP.Emit (depth - 1);
					s += " ";
					s += m_OG_ObjectsPart.Emit (depth - 1);
					s += " ";
					s += m_STATUS.Emit (depth - 1);
					s += " ";
					s += m_OG_Status.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
					s += " ";
					s += m_OG_ReferPart.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectGroupMacro
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectGroupMacro (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectGroupMacro_1:
					// emit syntax tree node associated with production
					// ObjectGroupMacro: OBJECT-GROUP OG-ObjectsPart STATUS OG-Status DESCRIPTION cstring OG-ReferPart

					s += "OBJECT_GROUP";
					s += ' ';
					s += m_OG_ObjectsPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += "STATUS";
					s += ' ';
					s += m_OG_Status.EmitProductionTree (depth - 1);
					s += ' ';
					s += "DESCRIPTION";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += m_OG_ReferPart.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectGroupMacro

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectGroupMacro with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectGroupMacro.production_kind kind = (ObjectGroupMacro.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectGroupMacro.production_kind.g_ObjectGroupMacro_1:
					// traverse syntax tree node associated with production
					// ObjectGroupMacro: OBJECT-GROUP OG-ObjectsPart STATUS OG-Status DESCRIPTION cstring OG-ReferPart

						m_OBJECT_GROUP.Visit (visitor, appData);
						m_OG_ObjectsPart.Visit (visitor, appData);
						m_STATUS.Visit (visitor, appData);
						m_OG_Status.Visit (visitor, appData);
						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
						m_OG_ReferPart.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_OBJECT_GROUP?.reparent (this);
			m_OG_ObjectsPart?.reparent (this);
			m_STATUS?.reparent (this);
			m_OG_Status?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_cstring?.reparent (this);
			m_OG_ReferPart?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectGroupMacro
		//

		public void _init ()
		{
			m_OBJECT_GROUP = null;
			m_OG_ObjectsPart = null;
			m_STATUS = null;
			m_OG_Status = null;
			m_DESCRIPTION = null;
			m_cstring = null;
			m_OG_ReferPart = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectGroupMacro

		// counter of all nodes associated with syntax rule ObjectGroupMacro
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectGroupMacro
		[DataMember (Name = "m_OBJECT_GROUP")] public SyntaxTreeToken m_OBJECT_GROUP { get; private set; }
		[DataMember (Name = "m_OG_ObjectsPart")] public OG_ObjectsPart m_OG_ObjectsPart { get; private set; }
		[DataMember (Name = "m_STATUS")] public SyntaxTreeToken m_STATUS { get; private set; }
		[DataMember (Name = "m_OG_Status")] public OG_Status m_OG_Status { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		[DataMember (Name = "m_OG_ReferPart")] public OG_ReferPart m_OG_ReferPart { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectGroupMacro

		// delegate function (callback) prototype associated with syntax rule ObjectGroupMacro
		public delegate bool ObjectGroupMacro_Callback (SyntaxTreeCallbackReason reason, ObjectGroupMacro.production_kind kind, ObjectGroupMacro p_ObjectGroupMacro);

		// event associated with syntax rule ObjectGroupMacro
		public event ObjectGroupMacro_Callback ObjectGroupMacro_Event;

		// event trigger associated with syntax rule ObjectGroupMacro
		public bool Raise_ObjectGroupMacro_Event (SyntaxTreeCallbackReason reason, ObjectGroupMacro.production_kind kind, ObjectGroupMacro p_ObjectGroupMacro)
		{
			bool? status = ObjectGroupMacro_Event?.Invoke (reason, kind, p_ObjectGroupMacro);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectGroupMacro
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectGroupMacro
		//

		public void Traverse (ObjectGroupMacro p_ObjectGroupMacro)
		{
			if (p_ObjectGroupMacro.isLocked())
				return;
			p_ObjectGroupMacro.dolock();
			ObjectGroupMacro.production_kind kind = (ObjectGroupMacro.production_kind) p_ObjectGroupMacro.kind;
			p_ObjectGroupMacro.turn_reset ();
			if (Raise_ObjectGroupMacro_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectGroupMacro))
			switch (kind)
			{
				case ObjectGroupMacro.production_kind.g_ObjectGroupMacro_1:
					// traverse syntax tree node associated with production
					// ObjectGroupMacro: OBJECT-GROUP OG-ObjectsPart STATUS OG-Status DESCRIPTION cstring OG-ReferPart

					if (Raise_ObjectGroupMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectGroupMacro))
						Traverse (p_ObjectGroupMacro.m_OG_ObjectsPart);
					p_ObjectGroupMacro.turn_inc ();
					if (Raise_ObjectGroupMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectGroupMacro))
						Traverse (p_ObjectGroupMacro.m_OG_Status);
					p_ObjectGroupMacro.turn_inc ();
					if (Raise_ObjectGroupMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectGroupMacro))
						Traverse (p_ObjectGroupMacro.m_OG_ReferPart);
					p_ObjectGroupMacro.turn_inc ();
					Raise_ObjectGroupMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectGroupMacro);
				break;
			}
			Raise_ObjectGroupMacro_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectGroupMacro);
			p_ObjectGroupMacro.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectGroupMacro
		//

		public void TraverseCommon (ObjectGroupMacro p_ObjectGroupMacro)
		{
			ObjectGroupMacro.production_kind kind = (ObjectGroupMacro.production_kind) p_ObjectGroupMacro.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectGroupMacro))
			switch (kind)
			{
				case ObjectGroupMacro.production_kind.g_ObjectGroupMacro_1:
					// traverse syntax tree node associated with production
					// ObjectGroupMacro: OBJECT-GROUP OG-ObjectsPart STATUS OG-Status DESCRIPTION cstring OG-ReferPart

						TraverseCommon (p_ObjectGroupMacro.m_OBJECT_GROUP);
						TraverseCommon (p_ObjectGroupMacro.m_OG_ObjectsPart);
						TraverseCommon (p_ObjectGroupMacro.m_STATUS);
						TraverseCommon (p_ObjectGroupMacro.m_OG_Status);
						TraverseCommon (p_ObjectGroupMacro.m_DESCRIPTION);
						TraverseCommon (p_ObjectGroupMacro.m_cstring);
						TraverseCommon (p_ObjectGroupMacro.m_OG_ReferPart);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectGroupMacro);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectGroupMacro

		//
		// create syntax tree node associated with production
		// ObjectGroupMacro: OBJECT-GROUP OG-ObjectsPart STATUS OG-Status DESCRIPTION cstring OG-ReferPart

		//

		public ObjectGroupMacro ObjectGroupMacro_1 (SyntaxTreeToken p_token, OG_ObjectsPart p_OG_ObjectsPart, SyntaxTreeToken p_token_1, OG_Status p_OG_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, OG_ReferPart p_OG_ReferPart)
		{
			ObjectGroupMacro p_ObjectGroupMacro_ref = new ObjectGroupMacro(p_token, p_OG_ObjectsPart, p_token_1, p_OG_Status, p_token_2, p_token_3, p_OG_ReferPart);
			p_token.parent = p_ObjectGroupMacro_ref;
			p_OG_ObjectsPart.parent = p_ObjectGroupMacro_ref;
			p_token_1.parent = p_ObjectGroupMacro_ref;
			p_OG_Status.parent = p_ObjectGroupMacro_ref;
			p_token_2.parent = p_ObjectGroupMacro_ref;
			p_token_3.parent = p_ObjectGroupMacro_ref;
			p_OG_ReferPart.parent = p_ObjectGroupMacro_ref;
			Raise_ObjectGroupMacro_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectGroupMacro.production_kind.g_ObjectGroupMacro_1, p_ObjectGroupMacro_ref);
			return p_ObjectGroupMacro_ref;
		}
		#endregion
	};
}
