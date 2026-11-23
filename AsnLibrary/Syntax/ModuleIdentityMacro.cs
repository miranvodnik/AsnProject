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
	// class associated with syntax rule ModuleIdentityMacro
	//

	[DataContract]
	public class	ModuleIdentityMacro : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ModuleIdentityMacro
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ModuleIdentityMacro
		{
			g_ModuleIdentityMacro_1 = 1,	// MODULE-IDENTITY LAST-UPDATED cstring ORGANIZATION cstring CONTACT-INFO cstring DESCRIPTION cstring MI-RevisionPart

		};
		#endregion
		#region production markers associated with the syntax rule ModuleIdentityMacro

		// markers associated with production: ModuleIdentityMacro -> MODULE-IDENTITY LAST-UPDATED cstring ORGANIZATION cstring CONTACT-INFO cstring DESCRIPTION cstring MI-RevisionPart

		public enum production_marker_1 : ushort
		{
			m_MI_RevisionPart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ModuleIdentityMacro

		// Constructor declaration(s) associated with production(s) of syntax rule ModuleIdentityMacro

		//
		// Constructor associated with the following production(s)
		// ModuleIdentityMacro -> MODULE-IDENTITY LAST-UPDATED cstring ORGANIZATION cstring CONTACT-INFO cstring DESCRIPTION cstring MI-RevisionPart

		//

		public ModuleIdentityMacro (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, SyntaxTreeToken p_token_5, SyntaxTreeToken p_token_6, SyntaxTreeToken p_token_7, SyntaxTreeToken p_token_8, MI_RevisionPart p_MI_RevisionPart) : base ((uint) ProductionID._ModuleIdentityMacro_ID, (uint) production_kind.g_ModuleIdentityMacro_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 10);
			children[0] = m_MODULE_IDENTITY = p_token;
			children[1] = m_LAST_UPDATED = p_token_1;
			children[2] = m_cstring = p_token_2;
			children[3] = m_ORGANIZATION = p_token_3;
			children[4] = m_cstring_1 = p_token_4;
			children[5] = m_CONTACT_INFO = p_token_5;
			children[6] = m_cstring_2 = p_token_6;
			children[7] = m_DESCRIPTION = p_token_7;
			children[8] = m_cstring_3 = p_token_8;
			children[9] = m_MI_RevisionPart = p_MI_RevisionPart;
		}

		public ModuleIdentityMacro () { }

		// Copy constructor

		public ModuleIdentityMacro (ModuleIdentityMacro p_ModuleIdentityMacro) : base (p_ModuleIdentityMacro.id, p_ModuleIdentityMacro.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ModuleIdentityMacro.appInfo;
			switch ((production_kind) p_ModuleIdentityMacro.kind)
			{
				case production_kind.g_ModuleIdentityMacro_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 10);
					if ((children [0] = m_MODULE_IDENTITY = (p_ModuleIdentityMacro.m_MODULE_IDENTITY != null) ? new SyntaxTreeToken (p_ModuleIdentityMacro.m_MODULE_IDENTITY) : null) != null) m_MODULE_IDENTITY.parent = this;
					if ((children [1] = m_LAST_UPDATED = (p_ModuleIdentityMacro.m_LAST_UPDATED != null) ? new SyntaxTreeToken (p_ModuleIdentityMacro.m_LAST_UPDATED) : null) != null) m_LAST_UPDATED.parent = this;
					if ((children [2] = m_cstring = (p_ModuleIdentityMacro.m_cstring != null) ? new SyntaxTreeToken (p_ModuleIdentityMacro.m_cstring) : null) != null) m_cstring.parent = this;
					if ((children [3] = m_ORGANIZATION = (p_ModuleIdentityMacro.m_ORGANIZATION != null) ? new SyntaxTreeToken (p_ModuleIdentityMacro.m_ORGANIZATION) : null) != null) m_ORGANIZATION.parent = this;
					if ((children [4] = m_cstring_1 = (p_ModuleIdentityMacro.m_cstring_1 != null) ? new SyntaxTreeToken (p_ModuleIdentityMacro.m_cstring_1) : null) != null) m_cstring_1.parent = this;
					if ((children [5] = m_CONTACT_INFO = (p_ModuleIdentityMacro.m_CONTACT_INFO != null) ? new SyntaxTreeToken (p_ModuleIdentityMacro.m_CONTACT_INFO) : null) != null) m_CONTACT_INFO.parent = this;
					if ((children [6] = m_cstring_2 = (p_ModuleIdentityMacro.m_cstring_2 != null) ? new SyntaxTreeToken (p_ModuleIdentityMacro.m_cstring_2) : null) != null) m_cstring_2.parent = this;
					if ((children [7] = m_DESCRIPTION = (p_ModuleIdentityMacro.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_ModuleIdentityMacro.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [8] = m_cstring_3 = (p_ModuleIdentityMacro.m_cstring_3 != null) ? new SyntaxTreeToken (p_ModuleIdentityMacro.m_cstring_3) : null) != null) m_cstring_3.parent = this;
					if ((children [9] = m_MI_RevisionPart = (p_ModuleIdentityMacro.m_MI_RevisionPart != null) ? new MI_RevisionPart (p_ModuleIdentityMacro.m_MI_RevisionPart) : null) != null) m_MI_RevisionPart.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ModuleIdentityMacro" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ModuleIdentityMacro (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_MODULE_IDENTITY?.Dispose ();
			m_LAST_UPDATED?.Dispose ();
			m_cstring?.Dispose ();
			m_cstring_1?.Dispose ();
			m_cstring_2?.Dispose ();
			m_cstring_3?.Dispose ();
			m_ORGANIZATION?.Dispose ();
			m_CONTACT_INFO?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_MI_RevisionPart?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ModuleIdentityMacro

		// Content changing function(s) associated with production(s) of syntax rule ModuleIdentityMacro

		//
		// Content changing function associated with following production(s)
		// ModuleIdentityMacro -> MODULE-IDENTITY LAST-UPDATED cstring ORGANIZATION cstring CONTACT-INFO cstring DESCRIPTION cstring MI-RevisionPart

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, SyntaxTreeToken p_token_5, SyntaxTreeToken p_token_6, SyntaxTreeToken p_token_7, SyntaxTreeToken p_token_8, MI_RevisionPart p_MI_RevisionPart)
		{
			_init ();
			this.kind = (uint) production_kind.g_ModuleIdentityMacro_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 10);
			children [0] = m_MODULE_IDENTITY = p_token;
			children [1] = m_LAST_UPDATED = p_token_1;
			children [2] = m_cstring = p_token_2;
			children [3] = m_ORGANIZATION = p_token_3;
			children [4] = m_cstring_1 = p_token_4;
			children [5] = m_CONTACT_INFO = p_token_5;
			children [6] = m_cstring_2 = p_token_6;
			children [7] = m_DESCRIPTION = p_token_7;
			children [8] = m_cstring_3 = p_token_8;
			children [9] = m_MI_RevisionPart = p_MI_RevisionPart;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ModuleIdentityMacro
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_MODULE_IDENTITY != null) && m_MODULE_IDENTITY.checkInclusion (element) ||
				(m_LAST_UPDATED != null) && m_LAST_UPDATED.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				(m_cstring_1 != null) && m_cstring_1.checkInclusion (element) ||
				(m_cstring_2 != null) && m_cstring_2.checkInclusion (element) ||
				(m_cstring_3 != null) && m_cstring_3.checkInclusion (element) ||
				(m_ORGANIZATION != null) && m_ORGANIZATION.checkInclusion (element) ||
				(m_CONTACT_INFO != null) && m_CONTACT_INFO.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_MI_RevisionPart != null) && m_MI_RevisionPart.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ModuleIdentityMacro

		//
		// emit production tree node associated with any production of syntax rule ModuleIdentityMacro
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ModuleIdentityMacro_1:
					// emit syntax tree node associated with production
					// ModuleIdentityMacro: MODULE-IDENTITY LAST-UPDATED cstring ORGANIZATION cstring CONTACT-INFO cstring DESCRIPTION cstring MI-RevisionPart

					s += m_MODULE_IDENTITY.Emit (depth - 1);
					s += " ";
					s += m_LAST_UPDATED.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
					s += " ";
					s += m_ORGANIZATION.Emit (depth - 1);
					s += " ";
					s += m_cstring_1.Emit (depth - 1);
					s += " ";
					s += m_CONTACT_INFO.Emit (depth - 1);
					s += " ";
					s += m_cstring_2.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring_3.Emit (depth - 1);
					s += " ";
					s += m_MI_RevisionPart.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ModuleIdentityMacro
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ModuleIdentityMacro (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ModuleIdentityMacro_1:
					// emit syntax tree node associated with production
					// ModuleIdentityMacro: MODULE-IDENTITY LAST-UPDATED cstring ORGANIZATION cstring CONTACT-INFO cstring DESCRIPTION cstring MI-RevisionPart

					s += "MODULE_IDENTITY";
					s += ' ';
					s += "LAST_UPDATED";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += "ORGANIZATION";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += "CONTACT_INFO";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += "DESCRIPTION";
					s += ' ';
					s += "cstring";
					s += ' ';
					s += m_MI_RevisionPart.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ModuleIdentityMacro

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ModuleIdentityMacro with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ModuleIdentityMacro.production_kind kind = (ModuleIdentityMacro.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ModuleIdentityMacro.production_kind.g_ModuleIdentityMacro_1:
					// traverse syntax tree node associated with production
					// ModuleIdentityMacro: MODULE-IDENTITY LAST-UPDATED cstring ORGANIZATION cstring CONTACT-INFO cstring DESCRIPTION cstring MI-RevisionPart

						m_MODULE_IDENTITY.Visit (visitor, appData);
						m_LAST_UPDATED.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
						m_ORGANIZATION.Visit (visitor, appData);
						m_cstring_1.Visit (visitor, appData);
						m_CONTACT_INFO.Visit (visitor, appData);
						m_cstring_2.Visit (visitor, appData);
						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring_3.Visit (visitor, appData);
						m_MI_RevisionPart.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_MODULE_IDENTITY?.reparent (this);
			m_LAST_UPDATED?.reparent (this);
			m_cstring?.reparent (this);
			m_cstring_1?.reparent (this);

			m_cstring_2?.reparent (this);

			m_cstring_3?.reparent (this);

			m_ORGANIZATION?.reparent (this);
			m_CONTACT_INFO?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_MI_RevisionPart?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ModuleIdentityMacro
		//

		public void _init ()
		{
			m_MODULE_IDENTITY = null;
			m_LAST_UPDATED = null;
			m_cstring = null;
			m_cstring_1 = null;
			m_cstring_2 = null;
			m_cstring_3 = null;
			m_ORGANIZATION = null;
			m_CONTACT_INFO = null;
			m_DESCRIPTION = null;
			m_MI_RevisionPart = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ModuleIdentityMacro

		// counter of all nodes associated with syntax rule ModuleIdentityMacro
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ModuleIdentityMacro
		[DataMember (Name = "m_MODULE_IDENTITY")] public SyntaxTreeToken m_MODULE_IDENTITY { get; private set; }
		[DataMember (Name = "m_LAST_UPDATED")] public SyntaxTreeToken m_LAST_UPDATED { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		[DataMember (Name = "m_cstring_1")] public SyntaxTreeToken m_cstring_1 { get; private set; }
		[DataMember (Name = "m_cstring_2")] public SyntaxTreeToken m_cstring_2 { get; private set; }
		[DataMember (Name = "m_cstring_3")] public SyntaxTreeToken m_cstring_3 { get; private set; }
		[DataMember (Name = "m_ORGANIZATION")] public SyntaxTreeToken m_ORGANIZATION { get; private set; }
		[DataMember (Name = "m_CONTACT_INFO")] public SyntaxTreeToken m_CONTACT_INFO { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_MI_RevisionPart")] public MI_RevisionPart m_MI_RevisionPart { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ModuleIdentityMacro

		// delegate function (callback) prototype associated with syntax rule ModuleIdentityMacro
		public delegate bool ModuleIdentityMacro_Callback (SyntaxTreeCallbackReason reason, ModuleIdentityMacro.production_kind kind, ModuleIdentityMacro p_ModuleIdentityMacro);

		// event associated with syntax rule ModuleIdentityMacro
		public event ModuleIdentityMacro_Callback ModuleIdentityMacro_Event;

		// event trigger associated with syntax rule ModuleIdentityMacro
		public bool Raise_ModuleIdentityMacro_Event (SyntaxTreeCallbackReason reason, ModuleIdentityMacro.production_kind kind, ModuleIdentityMacro p_ModuleIdentityMacro)
		{
			bool? status = ModuleIdentityMacro_Event?.Invoke (reason, kind, p_ModuleIdentityMacro);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ModuleIdentityMacro
		//
		// traverse syntax tree node associated with any production of syntax rule ModuleIdentityMacro
		//

		public void Traverse (ModuleIdentityMacro p_ModuleIdentityMacro)
		{
			if (p_ModuleIdentityMacro.isLocked())
				return;
			p_ModuleIdentityMacro.dolock();
			ModuleIdentityMacro.production_kind kind = (ModuleIdentityMacro.production_kind) p_ModuleIdentityMacro.kind;
			p_ModuleIdentityMacro.turn_reset ();
			if (Raise_ModuleIdentityMacro_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ModuleIdentityMacro))
			switch (kind)
			{
				case ModuleIdentityMacro.production_kind.g_ModuleIdentityMacro_1:
					// traverse syntax tree node associated with production
					// ModuleIdentityMacro: MODULE-IDENTITY LAST-UPDATED cstring ORGANIZATION cstring CONTACT-INFO cstring DESCRIPTION cstring MI-RevisionPart

					if (Raise_ModuleIdentityMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleIdentityMacro))
						Traverse (p_ModuleIdentityMacro.m_MI_RevisionPart);
					p_ModuleIdentityMacro.turn_inc ();
					Raise_ModuleIdentityMacro_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleIdentityMacro);
				break;
			}
			Raise_ModuleIdentityMacro_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ModuleIdentityMacro);
			p_ModuleIdentityMacro.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ModuleIdentityMacro
		//

		public void TraverseCommon (ModuleIdentityMacro p_ModuleIdentityMacro)
		{
			ModuleIdentityMacro.production_kind kind = (ModuleIdentityMacro.production_kind) p_ModuleIdentityMacro.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ModuleIdentityMacro))
			switch (kind)
			{
				case ModuleIdentityMacro.production_kind.g_ModuleIdentityMacro_1:
					// traverse syntax tree node associated with production
					// ModuleIdentityMacro: MODULE-IDENTITY LAST-UPDATED cstring ORGANIZATION cstring CONTACT-INFO cstring DESCRIPTION cstring MI-RevisionPart

						TraverseCommon (p_ModuleIdentityMacro.m_MODULE_IDENTITY);
						TraverseCommon (p_ModuleIdentityMacro.m_LAST_UPDATED);
						TraverseCommon (p_ModuleIdentityMacro.m_cstring);
						TraverseCommon (p_ModuleIdentityMacro.m_ORGANIZATION);
						TraverseCommon (p_ModuleIdentityMacro.m_cstring_1);
						TraverseCommon (p_ModuleIdentityMacro.m_CONTACT_INFO);
						TraverseCommon (p_ModuleIdentityMacro.m_cstring_2);
						TraverseCommon (p_ModuleIdentityMacro.m_DESCRIPTION);
						TraverseCommon (p_ModuleIdentityMacro.m_cstring_3);
						TraverseCommon (p_ModuleIdentityMacro.m_MI_RevisionPart);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ModuleIdentityMacro);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ModuleIdentityMacro

		//
		// create syntax tree node associated with production
		// ModuleIdentityMacro: MODULE-IDENTITY LAST-UPDATED cstring ORGANIZATION cstring CONTACT-INFO cstring DESCRIPTION cstring MI-RevisionPart

		//

		public ModuleIdentityMacro ModuleIdentityMacro_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2, SyntaxTreeToken p_token_3, SyntaxTreeToken p_token_4, SyntaxTreeToken p_token_5, SyntaxTreeToken p_token_6, SyntaxTreeToken p_token_7, SyntaxTreeToken p_token_8, MI_RevisionPart p_MI_RevisionPart)
		{
			ModuleIdentityMacro p_ModuleIdentityMacro_ref = new ModuleIdentityMacro(p_token, p_token_1, p_token_2, p_token_3, p_token_4, p_token_5, p_token_6, p_token_7, p_token_8, p_MI_RevisionPart);
			p_token.parent = p_ModuleIdentityMacro_ref;
			p_token_1.parent = p_ModuleIdentityMacro_ref;
			p_token_2.parent = p_ModuleIdentityMacro_ref;
			p_token_3.parent = p_ModuleIdentityMacro_ref;
			p_token_4.parent = p_ModuleIdentityMacro_ref;
			p_token_5.parent = p_ModuleIdentityMacro_ref;
			p_token_6.parent = p_ModuleIdentityMacro_ref;
			p_token_7.parent = p_ModuleIdentityMacro_ref;
			p_token_8.parent = p_ModuleIdentityMacro_ref;
			p_MI_RevisionPart.parent = p_ModuleIdentityMacro_ref;
			Raise_ModuleIdentityMacro_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ModuleIdentityMacro.production_kind.g_ModuleIdentityMacro_1, p_ModuleIdentityMacro_ref);
			return p_ModuleIdentityMacro_ref;
		}
		#endregion
	};
}
