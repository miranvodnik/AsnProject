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
	// class associated with syntax rule FieldSetting
	//

	[DataContract]
	public class	FieldSetting : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule FieldSetting
		public enum production_kind : ushort	// enumerated production(s) of syntax rule FieldSetting
		{
			g_FieldSetting_1 = 1,	// PrimitiveFieldName Setting

		};
		#endregion
		#region production markers associated with the syntax rule FieldSetting

		// markers associated with production: FieldSetting -> PrimitiveFieldName Setting

		public enum production_marker_1 : ushort
		{
			m_PrimitiveFieldName,
			m_Setting,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule FieldSetting

		// Constructor declaration(s) associated with production(s) of syntax rule FieldSetting

		//
		// Constructor associated with the following production(s)
		// FieldSetting -> PrimitiveFieldName Setting

		//

		public FieldSetting (PrimitiveFieldName p_PrimitiveFieldName, Setting p_Setting) : base ((uint) ProductionID._FieldSetting_ID, (uint) production_kind.g_FieldSetting_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_PrimitiveFieldName = p_PrimitiveFieldName;
			children[1] = m_Setting = p_Setting;
		}

		public FieldSetting () { }

		// Copy constructor

		public FieldSetting (FieldSetting p_FieldSetting) : base (p_FieldSetting.id, p_FieldSetting.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_FieldSetting.appInfo;
			switch ((production_kind) p_FieldSetting.kind)
			{
				case production_kind.g_FieldSetting_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_PrimitiveFieldName = (p_FieldSetting.m_PrimitiveFieldName != null) ? new PrimitiveFieldName (p_FieldSetting.m_PrimitiveFieldName) : null) != null) m_PrimitiveFieldName.parent = this;
					if ((children [1] = m_Setting = (p_FieldSetting.m_Setting != null) ? new Setting (p_FieldSetting.m_Setting) : null) != null) m_Setting.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "FieldSetting" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new FieldSetting (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_PrimitiveFieldName?.Dispose ();
			m_Setting?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule FieldSetting

		// Content changing function(s) associated with production(s) of syntax rule FieldSetting

		//
		// Content changing function associated with following production(s)
		// FieldSetting -> PrimitiveFieldName Setting

		//

		public void change(PrimitiveFieldName p_PrimitiveFieldName, Setting p_Setting)
		{
			_init ();
			this.kind = (uint) production_kind.g_FieldSetting_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_PrimitiveFieldName = p_PrimitiveFieldName;
			children [1] = m_Setting = p_Setting;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule FieldSetting
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_PrimitiveFieldName != null) && m_PrimitiveFieldName.checkInclusion (element) ||
				(m_Setting != null) && m_Setting.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule FieldSetting

		//
		// emit production tree node associated with any production of syntax rule FieldSetting
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_FieldSetting_1:
					// emit syntax tree node associated with production
					// FieldSetting: PrimitiveFieldName Setting

					s += m_PrimitiveFieldName.Emit (depth - 1);
					s += " ";
					s += m_Setting.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule FieldSetting
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "FieldSetting (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_FieldSetting_1:
					// emit syntax tree node associated with production
					// FieldSetting: PrimitiveFieldName Setting

					s += m_PrimitiveFieldName.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Setting.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule FieldSetting

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule FieldSetting with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			FieldSetting.production_kind kind = (FieldSetting.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case FieldSetting.production_kind.g_FieldSetting_1:
					// traverse syntax tree node associated with production
					// FieldSetting: PrimitiveFieldName Setting

						m_PrimitiveFieldName.Visit (visitor, appData);
						m_Setting.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_PrimitiveFieldName?.reparent (this);
			m_Setting?.reparent (this);
		}

		//
		// initialize object associated with syntax rule FieldSetting
		//

		public void _init ()
		{
			m_PrimitiveFieldName = null;
			m_Setting = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule FieldSetting

		// counter of all nodes associated with syntax rule FieldSetting
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule FieldSetting
		[DataMember (Name = "m_PrimitiveFieldName")] public PrimitiveFieldName m_PrimitiveFieldName { get; private set; }
		[DataMember (Name = "m_Setting")] public Setting m_Setting { get; private set; }

		public enum __field_markers
		{
			push_governor = 1,
			pop_governor = 2,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule FieldSetting

		// delegate function (callback) prototype associated with syntax rule FieldSetting
		public delegate bool FieldSetting_Callback (SyntaxTreeCallbackReason reason, FieldSetting.production_kind kind, FieldSetting p_FieldSetting);

		// event associated with syntax rule FieldSetting
		public event FieldSetting_Callback FieldSetting_Event;

		// event trigger associated with syntax rule FieldSetting
		public bool Raise_FieldSetting_Event (SyntaxTreeCallbackReason reason, FieldSetting.production_kind kind, FieldSetting p_FieldSetting)
		{
			bool? status = FieldSetting_Event?.Invoke (reason, kind, p_FieldSetting);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule FieldSetting
		//
		// traverse syntax tree node associated with any production of syntax rule FieldSetting
		//

		public void Traverse (FieldSetting p_FieldSetting)
		{
			if (p_FieldSetting.isLocked())
				return;
			p_FieldSetting.dolock();
			FieldSetting.production_kind kind = (FieldSetting.production_kind) p_FieldSetting.kind;
			p_FieldSetting.turn_reset ();
			if (Raise_FieldSetting_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_FieldSetting))
			switch (kind)
			{
				case FieldSetting.production_kind.g_FieldSetting_1:
					// traverse syntax tree node associated with production
					// FieldSetting: PrimitiveFieldName Setting

					if (Raise_FieldSetting_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSetting))
						Traverse (p_FieldSetting.m_PrimitiveFieldName);
					p_FieldSetting.turn_inc ();
					if (Raise_FieldSetting_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSetting))
						Traverse (p_FieldSetting.m_Setting);
					p_FieldSetting.turn_inc ();
					Raise_FieldSetting_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_FieldSetting);
				break;
			}
			Raise_FieldSetting_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_FieldSetting);
			p_FieldSetting.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule FieldSetting
		//

		public void TraverseCommon (FieldSetting p_FieldSetting)
		{
			FieldSetting.production_kind kind = (FieldSetting.production_kind) p_FieldSetting.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_FieldSetting))
			switch (kind)
			{
				case FieldSetting.production_kind.g_FieldSetting_1:
					// traverse syntax tree node associated with production
					// FieldSetting: PrimitiveFieldName Setting

						TraverseCommon (p_FieldSetting.m_PrimitiveFieldName);
						TraverseCommon (p_FieldSetting.m_Setting);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_FieldSetting);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule FieldSetting

		//
		// create syntax tree node associated with production
		// FieldSetting: PrimitiveFieldName Setting

		//

		public FieldSetting FieldSetting_1 (PrimitiveFieldName p_PrimitiveFieldName, Setting p_Setting)
		{
			FieldSetting p_FieldSetting_ref = new FieldSetting(p_PrimitiveFieldName, p_Setting);
			p_PrimitiveFieldName.parent = p_FieldSetting_ref;
			p_Setting.parent = p_FieldSetting_ref;
			Raise_FieldSetting_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, FieldSetting.production_kind.g_FieldSetting_1, p_FieldSetting_ref);
			return p_FieldSetting_ref;
		}
		#endregion
	};
}
