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
	// class associated with syntax rule ObjectIdentityMacro
	//

	[DataContract]
	public class	ObjectIdentityMacro : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ObjectIdentityMacro
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ObjectIdentityMacro
		{
			g_ObjectIdentityMacro_1 = 1,	// OBJECT-IDENTITY STATUS OI-Status DESCRIPTION cstring OI-ReferPart

		};
		#endregion
		#region production markers associated with the syntax rule ObjectIdentityMacro

		// markers associated with production: ObjectIdentityMacro -> OBJECT-IDENTITY STATUS OI-Status DESCRIPTION cstring OI-ReferPart

		public enum production_marker_1 : ushort
		{
			m_OI_Status,
			m_OI_ReferPart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ObjectIdentityMacro

		// Constructor declaration(s) associated with production(s) of syntax rule ObjectIdentityMacro

		//
		// Constructor associated with the following production(s)
		// ObjectIdentityMacro -> OBJECT-IDENTITY STATUS OI-Status DESCRIPTION cstring OI-ReferPart

		//

		public ObjectIdentityMacro (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OI_Status p_OI_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, OI_ReferPart p_OI_ReferPart) : base ((uint) ProductionID._ObjectIdentityMacro_ID, (uint) production_kind.g_ObjectIdentityMacro_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
			children[0] = m_OBJECT_IDENTITY = p_token;
			children[1] = m_STATUS = p_token_1;
			children[2] = m_OI_Status = p_OI_Status;
			children[3] = m_DESCRIPTION = p_token_2;
			children[4] = m_cstring = p_token_3;
			children[5] = m_OI_ReferPart = p_OI_ReferPart;
		}

		public ObjectIdentityMacro () { }

		// Copy constructor

		public ObjectIdentityMacro (ObjectIdentityMacro p_ObjectIdentityMacro) : base (p_ObjectIdentityMacro.id, p_ObjectIdentityMacro.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ObjectIdentityMacro.appInfo;
			switch ((production_kind) p_ObjectIdentityMacro.kind)
			{
				case production_kind.g_ObjectIdentityMacro_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
					if ((children [0] = m_OBJECT_IDENTITY = (p_ObjectIdentityMacro.m_OBJECT_IDENTITY != null) ? new SyntaxTreeToken (p_ObjectIdentityMacro.m_OBJECT_IDENTITY) : null) != null) m_OBJECT_IDENTITY.parent = this;
					if ((children [1] = m_STATUS = (p_ObjectIdentityMacro.m_STATUS != null) ? new SyntaxTreeToken (p_ObjectIdentityMacro.m_STATUS) : null) != null) m_STATUS.parent = this;
					if ((children [2] = m_OI_Status = (p_ObjectIdentityMacro.m_OI_Status != null) ? new OI_Status (p_ObjectIdentityMacro.m_OI_Status) : null) != null) m_OI_Status.parent = this;
					if ((children [3] = m_DESCRIPTION = (p_ObjectIdentityMacro.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_ObjectIdentityMacro.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [4] = m_cstring = (p_ObjectIdentityMacro.m_cstring != null) ? new SyntaxTreeToken (p_ObjectIdentityMacro.m_cstring) : null) != null) m_cstring.parent = this;
					if ((children [5] = m_OI_ReferPart = (p_ObjectIdentityMacro.m_OI_ReferPart != null) ? new OI_ReferPart (p_ObjectIdentityMacro.m_OI_ReferPart) : null) != null) m_OI_ReferPart.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ObjectIdentityMacro" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ObjectIdentityMacro (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OBJECT_IDENTITY?.Dispose ();
			m_STATUS?.Dispose ();
			m_OI_Status?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_cstring?.Dispose ();
			m_OI_ReferPart?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ObjectIdentityMacro

		// Content changing function(s) associated with production(s) of syntax rule ObjectIdentityMacro

		//
		// Content changing function associated with following production(s)
		// ObjectIdentityMacro -> OBJECT-IDENTITY STATUS OI-Status DESCRIPTION cstring OI-ReferPart

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OI_Status p_OI_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, OI_ReferPart p_OI_ReferPart)
		{
			_init ();
			this.kind = (uint) production_kind.g_ObjectIdentityMacro_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 6);
			children [0] = m_OBJECT_IDENTITY = p_token;
			children [1] = m_STATUS = p_token_1;
			children [2] = m_OI_Status = p_OI_Status;
			children [3] = m_DESCRIPTION = p_token_2;
			children [4] = m_cstring = p_token_3;
			children [5] = m_OI_ReferPart = p_OI_ReferPart;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ObjectIdentityMacro
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OBJECT_IDENTITY != null) && m_OBJECT_IDENTITY.checkInclusion (element) ||
				(m_STATUS != null) && m_STATUS.checkInclusion (element) ||
				(m_OI_Status != null) && m_OI_Status.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				(m_OI_ReferPart != null) && m_OI_ReferPart.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ObjectIdentityMacro

		//
		// emit production tree node associated with any production of syntax rule ObjectIdentityMacro
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ObjectIdentityMacro_1:
					// emit syntax tree node associated with production
					// ObjectIdentityMacro: OBJECT-IDENTITY STATUS OI-Status DESCRIPTION cstring OI-ReferPart

					s += m_OBJECT_IDENTITY.Emit (depth - 1);
					s += " ";
					s += m_STATUS.Emit (depth - 1);
					s += " ";
					s += m_OI_Status.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
					s += " ";
					s += m_OI_ReferPart.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ObjectIdentityMacro
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ObjectIdentityMacro (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ObjectIdentityMacro_1:
					// emit syntax tree node associated with production
					// ObjectIdentityMacro: OBJECT-IDENTITY STATUS OI-Status DESCRIPTION cstring OI-ReferPart

					s += "OBJECT_IDENTITY";
					s += ' ';
					s += "STATUS";
					s += ' ';
					s += m_OI_Status.EmitProductionTree (depth - 1);
					s += ' ';
					s += "DESCRIPTION";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += m_OI_ReferPart.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ObjectIdentityMacro

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectIdentityMacro with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ObjectIdentityMacro.production_kind kind = (ObjectIdentityMacro.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ObjectIdentityMacro.production_kind.g_ObjectIdentityMacro_1:
					// traverse syntax tree node associated with production
					// ObjectIdentityMacro: OBJECT-IDENTITY STATUS OI-Status DESCRIPTION cstring OI-ReferPart

						m_OBJECT_IDENTITY.Visit (visitor, appData);
						m_STATUS.Visit (visitor, appData);
						m_OI_Status.Visit (visitor, appData);
						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
						m_OI_ReferPart.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_OBJECT_IDENTITY?.reparent (this);
			m_STATUS?.reparent (this);
			m_OI_Status?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_cstring?.reparent (this);
			m_OI_ReferPart?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ObjectIdentityMacro
		//

		public void _init ()
		{
			m_OBJECT_IDENTITY = null;
			m_STATUS = null;
			m_OI_Status = null;
			m_DESCRIPTION = null;
			m_cstring = null;
			m_OI_ReferPart = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ObjectIdentityMacro

		// counter of all nodes associated with syntax rule ObjectIdentityMacro
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ObjectIdentityMacro
		[DataMember (Name = "m_OBJECT_IDENTITY")] public SyntaxTreeToken m_OBJECT_IDENTITY { get; private set; }
		[DataMember (Name = "m_STATUS")] public SyntaxTreeToken m_STATUS { get; private set; }
		[DataMember (Name = "m_OI_Status")] public OI_Status m_OI_Status { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		[DataMember (Name = "m_OI_ReferPart")] public OI_ReferPart m_OI_ReferPart { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ObjectIdentityMacro

		// delegate function (callback) prototype associated with syntax rule ObjectIdentityMacro
		public delegate bool ObjectIdentityMacro_Callback (SyntaxTreeCallbackReason reason, ObjectIdentityMacro.production_kind kind, ObjectIdentityMacro p_ObjectIdentityMacro);

		// event associated with syntax rule ObjectIdentityMacro
		public event ObjectIdentityMacro_Callback ObjectIdentityMacro_Event;

		// event trigger associated with syntax rule ObjectIdentityMacro
		public bool Raise_ObjectIdentityMacro_Event (SyntaxTreeCallbackReason reason, ObjectIdentityMacro.production_kind kind, ObjectIdentityMacro p_ObjectIdentityMacro)
		{
			bool? status = ObjectIdentityMacro_Event?.Invoke (reason, kind, p_ObjectIdentityMacro);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ObjectIdentityMacro
		//
		// traverse syntax tree node associated with any production of syntax rule ObjectIdentityMacro
		//

		public void Traverse (ObjectIdentityMacro p_ObjectIdentityMacro)
		{
			if (p_ObjectIdentityMacro.isLocked())
				return;
			p_ObjectIdentityMacro.dolock();
			ObjectIdentityMacro.production_kind kind = (ObjectIdentityMacro.production_kind) p_ObjectIdentityMacro.kind;
			p_ObjectIdentityMacro.turn_reset ();
			if (Raise_ObjectIdentityMacro_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ObjectIdentityMacro))
			switch (kind)
			{
				case ObjectIdentityMacro.production_kind.g_ObjectIdentityMacro_1:
					// traverse syntax tree node associated with production
					// ObjectIdentityMacro: OBJECT-IDENTITY STATUS OI-Status DESCRIPTION cstring OI-ReferPart

					if (Raise_ObjectIdentityMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectIdentityMacro))
						Traverse (p_ObjectIdentityMacro.m_OI_Status);
					p_ObjectIdentityMacro.turn_inc ();
					if (Raise_ObjectIdentityMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectIdentityMacro))
						Traverse (p_ObjectIdentityMacro.m_OI_ReferPart);
					p_ObjectIdentityMacro.turn_inc ();
					Raise_ObjectIdentityMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ObjectIdentityMacro);
				break;
			}
			Raise_ObjectIdentityMacro_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ObjectIdentityMacro);
			p_ObjectIdentityMacro.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ObjectIdentityMacro
		//

		public void TraverseCommon (ObjectIdentityMacro p_ObjectIdentityMacro)
		{
			ObjectIdentityMacro.production_kind kind = (ObjectIdentityMacro.production_kind) p_ObjectIdentityMacro.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ObjectIdentityMacro))
			switch (kind)
			{
				case ObjectIdentityMacro.production_kind.g_ObjectIdentityMacro_1:
					// traverse syntax tree node associated with production
					// ObjectIdentityMacro: OBJECT-IDENTITY STATUS OI-Status DESCRIPTION cstring OI-ReferPart

						TraverseCommon (p_ObjectIdentityMacro.m_OBJECT_IDENTITY);
						TraverseCommon (p_ObjectIdentityMacro.m_STATUS);
						TraverseCommon (p_ObjectIdentityMacro.m_OI_Status);
						TraverseCommon (p_ObjectIdentityMacro.m_DESCRIPTION);
						TraverseCommon (p_ObjectIdentityMacro.m_cstring);
						TraverseCommon (p_ObjectIdentityMacro.m_OI_ReferPart);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ObjectIdentityMacro);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ObjectIdentityMacro

		//
		// create syntax tree node associated with production
		// ObjectIdentityMacro: OBJECT-IDENTITY STATUS OI-Status DESCRIPTION cstring OI-ReferPart

		//

		public ObjectIdentityMacro ObjectIdentityMacro_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, OI_Status p_OI_Status, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, OI_ReferPart p_OI_ReferPart)
		{
			ObjectIdentityMacro p_ObjectIdentityMacro_ref = new ObjectIdentityMacro(p_token, p_token_1, p_OI_Status, p_token_2, p_token_3, p_OI_ReferPart);
			p_token.parent = p_ObjectIdentityMacro_ref;
			p_token_1.parent = p_ObjectIdentityMacro_ref;
			p_OI_Status.parent = p_ObjectIdentityMacro_ref;
			p_token_2.parent = p_ObjectIdentityMacro_ref;
			p_token_3.parent = p_ObjectIdentityMacro_ref;
			p_OI_ReferPart.parent = p_ObjectIdentityMacro_ref;
			Raise_ObjectIdentityMacro_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ObjectIdentityMacro.production_kind.g_ObjectIdentityMacro_1, p_ObjectIdentityMacro_ref);
			return p_ObjectIdentityMacro_ref;
		}
		#endregion
	};
}
