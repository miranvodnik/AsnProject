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
	// class associated with syntax rule ObjectTypeMacro
	//

	[DataContract]
	public class	ObjectTypeMacro : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectTypeMacro
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectTypeMacro
		{
			g_ObjectTypeMacro_1 = 1,	// OBJECT-TYPE SYNTAX OT-Syntax OT-UnitsPart access-token OT-Access STATUS OT-Status DESCRIPTION cstring OT-ReferPart OT-IndexPart OT-DefValPart

		};
		#endregion
		#region production markers associated with the syntax rule ObjectTypeMacro

		// markers associated with production: ObjectTypeMacro -> OBJECT-TYPE SYNTAX OT-Syntax OT-UnitsPart access-token OT-Access STATUS OT-Status DESCRIPTION cstring OT-ReferPart OT-IndexPart OT-DefValPart

		public enum production_marker_1 : ushort
		{
			m_OT_Syntax,
			m_OT_UnitsPart,
			m_access_token,
			m_OT_Access,
			m_OT_Status,
			m_OT_ReferPart,
			m_OT_IndexPart,
			m_OT_DefValPart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectTypeMacro

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectTypeMacro

		//
		// Constructor associated with the following production(s)
		// ObjectTypeMacro -> OBJECT-TYPE SYNTAX OT-Syntax OT-UnitsPart access-token OT-Access STATUS OT-Status DESCRIPTION cstring OT-ReferPart OT-IndexPart OT-DefValPart

		//

		public ObjectTypeMacro (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OT_Syntax p_OT_Syntax, OT_UnitsPart p_OT_UnitsPart, access_token p_access_token, OT_Access p_OT_Access, SyntaxTreeToken p_token_2, OT_Status p_OT_Status, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, OT_ReferPart p_OT_ReferPart, OT_IndexPart p_OT_IndexPart, OT_DefValPart p_OT_DefValPart) : base ((uint) ProductionID._ObjectTypeMacro_ID, (uint) production_kind.g_ObjectTypeMacro_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 13);
			children[0] = m_OBJECT_TYPE = p_token;
			children[1] = m_SYNTAX = p_token_1;
			children[2] = m_OT_Syntax = p_OT_Syntax;
			children[3] = m_OT_UnitsPart = p_OT_UnitsPart;
			children[4] = m_access_token = p_access_token;
			children[5] = m_OT_Access = p_OT_Access;
			children[6] = m_STATUS = p_token_2;
			children[7] = m_OT_Status = p_OT_Status;
			children[8] = m_DESCRIPTION = p_token_3;
			children[9] = m_cstring = p_token_4;
			children[10] = m_OT_ReferPart = p_OT_ReferPart;
			children[11] = m_OT_IndexPart = p_OT_IndexPart;
			children[12] = m_OT_DefValPart = p_OT_DefValPart;
		}

		public ObjectTypeMacro () { }

		// Copy constructor

		public ObjectTypeMacro (ObjectTypeMacro p_ObjectTypeMacro) : base (p_ObjectTypeMacro.id, p_ObjectTypeMacro.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectTypeMacro.appInfo;
			switch ((production_kind) p_ObjectTypeMacro.kind)
			{
				case production_kind.g_ObjectTypeMacro_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 13);
					if ((children [0] = m_OBJECT_TYPE = (p_ObjectTypeMacro.m_OBJECT_TYPE != null) ? new SyntaxTreeToken (p_ObjectTypeMacro.m_OBJECT_TYPE) : null) != null) m_OBJECT_TYPE.parent = this;
					if ((children [1] = m_SYNTAX = (p_ObjectTypeMacro.m_SYNTAX != null) ? new SyntaxTreeToken (p_ObjectTypeMacro.m_SYNTAX) : null) != null) m_SYNTAX.parent = this;
					if ((children [2] = m_OT_Syntax = (p_ObjectTypeMacro.m_OT_Syntax != null) ? new OT_Syntax (p_ObjectTypeMacro.m_OT_Syntax) : null) != null) m_OT_Syntax.parent = this;
					if ((children [3] = m_OT_UnitsPart = (p_ObjectTypeMacro.m_OT_UnitsPart != null) ? new OT_UnitsPart (p_ObjectTypeMacro.m_OT_UnitsPart) : null) != null) m_OT_UnitsPart.parent = this;
					if ((children [4] = m_access_token = (p_ObjectTypeMacro.m_access_token != null) ? new access_token (p_ObjectTypeMacro.m_access_token) : null) != null) m_access_token.parent = this;
					if ((children [5] = m_OT_Access = (p_ObjectTypeMacro.m_OT_Access != null) ? new OT_Access (p_ObjectTypeMacro.m_OT_Access) : null) != null) m_OT_Access.parent = this;
					if ((children [6] = m_STATUS = (p_ObjectTypeMacro.m_STATUS != null) ? new SyntaxTreeToken (p_ObjectTypeMacro.m_STATUS) : null) != null) m_STATUS.parent = this;
					if ((children [7] = m_OT_Status = (p_ObjectTypeMacro.m_OT_Status != null) ? new OT_Status (p_ObjectTypeMacro.m_OT_Status) : null) != null) m_OT_Status.parent = this;
					if ((children [8] = m_DESCRIPTION = (p_ObjectTypeMacro.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_ObjectTypeMacro.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [9] = m_cstring = (p_ObjectTypeMacro.m_cstring != null) ? new SyntaxTreeToken (p_ObjectTypeMacro.m_cstring) : null) != null) m_cstring.parent = this;
					if ((children [10] = m_OT_ReferPart = (p_ObjectTypeMacro.m_OT_ReferPart != null) ? new OT_ReferPart (p_ObjectTypeMacro.m_OT_ReferPart) : null) != null) m_OT_ReferPart.parent = this;
					if ((children [11] = m_OT_IndexPart = (p_ObjectTypeMacro.m_OT_IndexPart != null) ? new OT_IndexPart (p_ObjectTypeMacro.m_OT_IndexPart) : null) != null) m_OT_IndexPart.parent = this;
					if ((children [12] = m_OT_DefValPart = (p_ObjectTypeMacro.m_OT_DefValPart != null) ? new OT_DefValPart (p_ObjectTypeMacro.m_OT_DefValPart) : null) != null) m_OT_DefValPart.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectTypeMacro" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectTypeMacro (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OBJECT_TYPE?.Dispose ();
			m_SYNTAX?.Dispose ();
			m_OT_Syntax?.Dispose ();
			m_OT_UnitsPart?.Dispose ();
			m_access_token?.Dispose ();
			m_OT_Access?.Dispose ();
			m_STATUS?.Dispose ();
			m_OT_Status?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_cstring?.Dispose ();
			m_OT_ReferPart?.Dispose ();
			m_OT_IndexPart?.Dispose ();
			m_OT_DefValPart?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectTypeMacro

		// Content changing function(s) associated with production(s) of syntax rule ObjectTypeMacro

		//
		// Content changing function associated with following production(s)
		// ObjectTypeMacro -> OBJECT-TYPE SYNTAX OT-Syntax OT-UnitsPart access-token OT-Access STATUS OT-Status DESCRIPTION cstring OT-ReferPart OT-IndexPart OT-DefValPart

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OT_Syntax p_OT_Syntax, OT_UnitsPart p_OT_UnitsPart, access_token p_access_token, OT_Access p_OT_Access, SyntaxTreeToken p_token_2, OT_Status p_OT_Status, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, OT_ReferPart p_OT_ReferPart, OT_IndexPart p_OT_IndexPart, OT_DefValPart p_OT_DefValPart)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectTypeMacro_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 13);
			children [0] = m_OBJECT_TYPE = p_token;
			children [1] = m_SYNTAX = p_token_1;
			children [2] = m_OT_Syntax = p_OT_Syntax;
			children [3] = m_OT_UnitsPart = p_OT_UnitsPart;
			children [4] = m_access_token = p_access_token;
			children [5] = m_OT_Access = p_OT_Access;
			children [6] = m_STATUS = p_token_2;
			children [7] = m_OT_Status = p_OT_Status;
			children [8] = m_DESCRIPTION = p_token_3;
			children [9] = m_cstring = p_token_4;
			children [10] = m_OT_ReferPart = p_OT_ReferPart;
			children [11] = m_OT_IndexPart = p_OT_IndexPart;
			children [12] = m_OT_DefValPart = p_OT_DefValPart;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectTypeMacro
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OBJECT_TYPE != null) && m_OBJECT_TYPE.checkInclusion (element) ||
				(m_SYNTAX != null) && m_SYNTAX.checkInclusion (element) ||
				(m_OT_Syntax != null) && m_OT_Syntax.checkInclusion (element) ||
				(m_OT_UnitsPart != null) && m_OT_UnitsPart.checkInclusion (element) ||
				(m_access_token != null) && m_access_token.checkInclusion (element) ||
				(m_OT_Access != null) && m_OT_Access.checkInclusion (element) ||
				(m_STATUS != null) && m_STATUS.checkInclusion (element) ||
				(m_OT_Status != null) && m_OT_Status.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				(m_OT_ReferPart != null) && m_OT_ReferPart.checkInclusion (element) ||
				(m_OT_IndexPart != null) && m_OT_IndexPart.checkInclusion (element) ||
				(m_OT_DefValPart != null) && m_OT_DefValPart.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectTypeMacro

		//
		// emit production tree node associated with any production of syntax rule ObjectTypeMacro
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectTypeMacro_1:
					// emit syntax tree node associated with production
					// ObjectTypeMacro: OBJECT-TYPE SYNTAX OT-Syntax OT-UnitsPart access-token OT-Access STATUS OT-Status DESCRIPTION cstring OT-ReferPart OT-IndexPart OT-DefValPart

					s += m_OBJECT_TYPE.Emit (depth - 1);
					s += " ";
					s += m_SYNTAX.Emit (depth - 1);
					s += " ";
					s += m_OT_Syntax.Emit (depth - 1);
					s += " ";
					s += m_OT_UnitsPart.Emit (depth - 1);
					s += " ";
					s += m_access_token.Emit (depth - 1);
					s += " ";
					s += m_OT_Access.Emit (depth - 1);
					s += " ";
					s += m_STATUS.Emit (depth - 1);
					s += " ";
					s += m_OT_Status.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
					s += " ";
					s += m_OT_ReferPart.Emit (depth - 1);
					s += " ";
					s += m_OT_IndexPart.Emit (depth - 1);
					s += " ";
					s += m_OT_DefValPart.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectTypeMacro
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectTypeMacro (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectTypeMacro_1:
					// emit syntax tree node associated with production
					// ObjectTypeMacro: OBJECT-TYPE SYNTAX OT-Syntax OT-UnitsPart access-token OT-Access STATUS OT-Status DESCRIPTION cstring OT-ReferPart OT-IndexPart OT-DefValPart

					s += "OBJECT_TYPE";
					s += ' ';
					s += "SYNTAX";
					s += ' ';
					s += m_OT_Syntax.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_OT_UnitsPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_access_token.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_OT_Access.EmitProductionTree (depth - 1);
					s += ' ';
					s += "STATUS";
					s += ' ';
					s += m_OT_Status.EmitProductionTree (depth - 1);
					s += ' ';
					s += "DESCRIPTION";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += m_OT_ReferPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_OT_IndexPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_OT_DefValPart.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectTypeMacro

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectTypeMacro with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectTypeMacro.production_kind kind = (ObjectTypeMacro.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectTypeMacro.production_kind.g_ObjectTypeMacro_1:
					// traverse syntax tree node associated with production
					// ObjectTypeMacro: OBJECT-TYPE SYNTAX OT-Syntax OT-UnitsPart access-token OT-Access STATUS OT-Status DESCRIPTION cstring OT-ReferPart OT-IndexPart OT-DefValPart

						m_OBJECT_TYPE.Visit (visitor, appData);
						m_SYNTAX.Visit (visitor, appData);
						m_OT_Syntax.Visit (visitor, appData);
						m_OT_UnitsPart.Visit (visitor, appData);
						m_access_token.Visit (visitor, appData);
						m_OT_Access.Visit (visitor, appData);
						m_STATUS.Visit (visitor, appData);
						m_OT_Status.Visit (visitor, appData);
						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
						m_OT_ReferPart.Visit (visitor, appData);
						m_OT_IndexPart.Visit (visitor, appData);
						m_OT_DefValPart.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_OBJECT_TYPE?.reparent (this);
			m_SYNTAX?.reparent (this);
			m_OT_Syntax?.reparent (this);
			m_OT_UnitsPart?.reparent (this);
			m_access_token?.reparent (this);
			m_OT_Access?.reparent (this);
			m_STATUS?.reparent (this);
			m_OT_Status?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_cstring?.reparent (this);
			m_OT_ReferPart?.reparent (this);
			m_OT_IndexPart?.reparent (this);
			m_OT_DefValPart?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectTypeMacro
		//

		public void _init ()
		{
			m_OBJECT_TYPE = null;
			m_SYNTAX = null;
			m_OT_Syntax = null;
			m_OT_UnitsPart = null;
			m_access_token = null;
			m_OT_Access = null;
			m_STATUS = null;
			m_OT_Status = null;
			m_DESCRIPTION = null;
			m_cstring = null;
			m_OT_ReferPart = null;
			m_OT_IndexPart = null;
			m_OT_DefValPart = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectTypeMacro

		// counter of all nodes associated with syntax rule ObjectTypeMacro
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectTypeMacro
		[DataMember (Name = "m_OBJECT_TYPE")] public SyntaxTreeToken m_OBJECT_TYPE { get; private set; }
		[DataMember (Name = "m_SYNTAX")] public SyntaxTreeToken m_SYNTAX { get; private set; }
		[DataMember (Name = "m_OT_Syntax")] public OT_Syntax m_OT_Syntax { get; private set; }
		[DataMember (Name = "m_OT_UnitsPart")] public OT_UnitsPart m_OT_UnitsPart { get; private set; }
		[DataMember (Name = "m_access_token")] public access_token m_access_token { get; private set; }
		[DataMember (Name = "m_OT_Access")] public OT_Access m_OT_Access { get; private set; }
		[DataMember (Name = "m_STATUS")] public SyntaxTreeToken m_STATUS { get; private set; }
		[DataMember (Name = "m_OT_Status")] public OT_Status m_OT_Status { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		[DataMember (Name = "m_OT_ReferPart")] public OT_ReferPart m_OT_ReferPart { get; private set; }
		[DataMember (Name = "m_OT_IndexPart")] public OT_IndexPart m_OT_IndexPart { get; private set; }
		[DataMember (Name = "m_OT_DefValPart")] public OT_DefValPart m_OT_DefValPart { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectTypeMacro

		// delegate function (callback) prototype associated with syntax rule ObjectTypeMacro
		public delegate bool ObjectTypeMacro_Callback (SyntaxTreeCallbackReason reason, ObjectTypeMacro.production_kind kind, ObjectTypeMacro p_ObjectTypeMacro);

		// event associated with syntax rule ObjectTypeMacro
		public event ObjectTypeMacro_Callback ObjectTypeMacro_Event;

		// event trigger associated with syntax rule ObjectTypeMacro
		public bool Raise_ObjectTypeMacro_Event (SyntaxTreeCallbackReason reason, ObjectTypeMacro.production_kind kind, ObjectTypeMacro p_ObjectTypeMacro)
		{
			bool? status = ObjectTypeMacro_Event?.Invoke (reason, kind, p_ObjectTypeMacro);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectTypeMacro
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectTypeMacro
		//

		public void Traverse (ObjectTypeMacro p_ObjectTypeMacro)
		{
			if (p_ObjectTypeMacro.isLocked())
				return;
			p_ObjectTypeMacro.dolock();
			ObjectTypeMacro.production_kind kind = (ObjectTypeMacro.production_kind) p_ObjectTypeMacro.kind;
			p_ObjectTypeMacro.turn_reset ();
			if (Raise_ObjectTypeMacro_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectTypeMacro))
			switch (kind)
			{
				case ObjectTypeMacro.production_kind.g_ObjectTypeMacro_1:
					// traverse syntax tree node associated with production
					// ObjectTypeMacro: OBJECT-TYPE SYNTAX OT-Syntax OT-UnitsPart access-token OT-Access STATUS OT-Status DESCRIPTION cstring OT-ReferPart OT-IndexPart OT-DefValPart

					if (Raise_ObjectTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectTypeMacro))
						Traverse (p_ObjectTypeMacro.m_OT_Syntax);
					p_ObjectTypeMacro.turn_inc ();
					if (Raise_ObjectTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectTypeMacro))
						Traverse (p_ObjectTypeMacro.m_OT_UnitsPart);
					p_ObjectTypeMacro.turn_inc ();
					if (Raise_ObjectTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectTypeMacro))
						Traverse (p_ObjectTypeMacro.m_access_token);
					p_ObjectTypeMacro.turn_inc ();
					if (Raise_ObjectTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectTypeMacro))
						Traverse (p_ObjectTypeMacro.m_OT_Access);
					p_ObjectTypeMacro.turn_inc ();
					if (Raise_ObjectTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectTypeMacro))
						Traverse (p_ObjectTypeMacro.m_OT_Status);
					p_ObjectTypeMacro.turn_inc ();
					if (Raise_ObjectTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectTypeMacro))
						Traverse (p_ObjectTypeMacro.m_OT_ReferPart);
					p_ObjectTypeMacro.turn_inc ();
					if (Raise_ObjectTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectTypeMacro))
						Traverse (p_ObjectTypeMacro.m_OT_IndexPart);
					p_ObjectTypeMacro.turn_inc ();
					if (Raise_ObjectTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectTypeMacro))
						Traverse (p_ObjectTypeMacro.m_OT_DefValPart);
					p_ObjectTypeMacro.turn_inc ();
					Raise_ObjectTypeMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectTypeMacro);
				break;
			}
			Raise_ObjectTypeMacro_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectTypeMacro);
			p_ObjectTypeMacro.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectTypeMacro
		//

		public void TraverseCommon (ObjectTypeMacro p_ObjectTypeMacro)
		{
			ObjectTypeMacro.production_kind kind = (ObjectTypeMacro.production_kind) p_ObjectTypeMacro.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectTypeMacro))
			switch (kind)
			{
				case ObjectTypeMacro.production_kind.g_ObjectTypeMacro_1:
					// traverse syntax tree node associated with production
					// ObjectTypeMacro: OBJECT-TYPE SYNTAX OT-Syntax OT-UnitsPart access-token OT-Access STATUS OT-Status DESCRIPTION cstring OT-ReferPart OT-IndexPart OT-DefValPart

						TraverseCommon (p_ObjectTypeMacro.m_OBJECT_TYPE);
						TraverseCommon (p_ObjectTypeMacro.m_SYNTAX);
						TraverseCommon (p_ObjectTypeMacro.m_OT_Syntax);
						TraverseCommon (p_ObjectTypeMacro.m_OT_UnitsPart);
						TraverseCommon (p_ObjectTypeMacro.m_access_token);
						TraverseCommon (p_ObjectTypeMacro.m_OT_Access);
						TraverseCommon (p_ObjectTypeMacro.m_STATUS);
						TraverseCommon (p_ObjectTypeMacro.m_OT_Status);
						TraverseCommon (p_ObjectTypeMacro.m_DESCRIPTION);
						TraverseCommon (p_ObjectTypeMacro.m_cstring);
						TraverseCommon (p_ObjectTypeMacro.m_OT_ReferPart);
						TraverseCommon (p_ObjectTypeMacro.m_OT_IndexPart);
						TraverseCommon (p_ObjectTypeMacro.m_OT_DefValPart);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectTypeMacro);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectTypeMacro

		//
		// create syntax tree node associated with production
		// ObjectTypeMacro: OBJECT-TYPE SYNTAX OT-Syntax OT-UnitsPart access-token OT-Access STATUS OT-Status DESCRIPTION cstring OT-ReferPart OT-IndexPart OT-DefValPart

		//

		public ObjectTypeMacro ObjectTypeMacro_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OT_Syntax p_OT_Syntax, OT_UnitsPart p_OT_UnitsPart, access_token p_access_token, OT_Access p_OT_Access, SyntaxTreeToken p_token_2, OT_Status p_OT_Status, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, OT_ReferPart p_OT_ReferPart, OT_IndexPart p_OT_IndexPart, OT_DefValPart p_OT_DefValPart)
		{
			ObjectTypeMacro p_ObjectTypeMacro_ref = new ObjectTypeMacro(p_token, p_token_1, p_OT_Syntax, p_OT_UnitsPart, p_access_token, p_OT_Access, p_token_2, p_OT_Status, p_token_3, p_token_4, p_OT_ReferPart, p_OT_IndexPart, p_OT_DefValPart);
			p_token.parent = p_ObjectTypeMacro_ref;
			p_token_1.parent = p_ObjectTypeMacro_ref;
			p_OT_Syntax.parent = p_ObjectTypeMacro_ref;
			p_OT_UnitsPart.parent = p_ObjectTypeMacro_ref;
			p_access_token.parent = p_ObjectTypeMacro_ref;
			p_OT_Access.parent = p_ObjectTypeMacro_ref;
			p_token_2.parent = p_ObjectTypeMacro_ref;
			p_OT_Status.parent = p_ObjectTypeMacro_ref;
			p_token_3.parent = p_ObjectTypeMacro_ref;
			p_token_4.parent = p_ObjectTypeMacro_ref;
			p_OT_ReferPart.parent = p_ObjectTypeMacro_ref;
			p_OT_IndexPart.parent = p_ObjectTypeMacro_ref;
			p_OT_DefValPart.parent = p_ObjectTypeMacro_ref;
			Raise_ObjectTypeMacro_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectTypeMacro.production_kind.g_ObjectTypeMacro_1, p_ObjectTypeMacro_ref);
			return p_ObjectTypeMacro_ref;
		}
		#endregion
	};
}
