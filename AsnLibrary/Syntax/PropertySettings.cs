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
	// class associated with syntax rule PropertySettings
	//

	[DataContract]
	public class	PropertySettings : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule PropertySettings
		public enum production_kind : ushort	// enumerated production(s) of syntax rule PropertySettings
		{
			g_PropertySettings_1 = 1,	// SETTINGS simplestring

		};
		#endregion
		#region production markers associated with the syntax rule PropertySettings

		// markers associated with production: PropertySettings -> SETTINGS simplestring

		public enum production_marker_1 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule PropertySettings

		// Constructor declaration(s) associated with production(s) of syntax rule PropertySettings

		//
		// Constructor associated with the following production(s)
		// PropertySettings -> SETTINGS simplestring

		//

		public PropertySettings (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1) : base ((uint) ProductionID._PropertySettings_ID, (uint) production_kind.g_PropertySettings_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_SETTINGS = p_token;
			children[1] = m_simplestring = p_token_1;
		}

		public PropertySettings () { }

		// Copy constructor

		public PropertySettings (PropertySettings p_PropertySettings) : base (p_PropertySettings.id, p_PropertySettings.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_PropertySettings.appInfo;
			switch ((production_kind) p_PropertySettings.kind)
			{
				case production_kind.g_PropertySettings_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_SETTINGS = (p_PropertySettings.m_SETTINGS != null) ? new SyntaxTreeToken (p_PropertySettings.m_SETTINGS) : null) != null) m_SETTINGS.parent = this;
					if ((children [1] = m_simplestring = (p_PropertySettings.m_simplestring != null) ? new SyntaxTreeToken (p_PropertySettings.m_simplestring) : null) != null) m_simplestring.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "PropertySettings" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new PropertySettings (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_SETTINGS?.Dispose ();
			m_simplestring?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule PropertySettings

		// Content changing function(s) associated with production(s) of syntax rule PropertySettings

		//
		// Content changing function associated with following production(s)
		// PropertySettings -> SETTINGS simplestring

		//

		public void change(SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_PropertySettings_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_SETTINGS = p_token;
			children [1] = m_simplestring = p_token_1;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule PropertySettings
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_SETTINGS != null) && m_SETTINGS.checkInclusion (element) ||
				(m_simplestring != null) && m_simplestring.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule PropertySettings

		//
		// emit production tree node associated with any production of syntax rule PropertySettings
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_PropertySettings_1:
					// emit syntax tree node associated with production
					// PropertySettings: SETTINGS simplestring

					s += m_SETTINGS.Emit (depth - 1);
					s += " ";
					s += m_simplestring.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule PropertySettings
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "PropertySettings (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_PropertySettings_1:
					// emit syntax tree node associated with production
					// PropertySettings: SETTINGS simplestring

					s += "SETTINGS";
					s += ' ';
					s += "simplestring";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule PropertySettings

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule PropertySettings with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			PropertySettings.production_kind kind = (PropertySettings.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case PropertySettings.production_kind.g_PropertySettings_1:
					// traverse syntax tree node associated with production
					// PropertySettings: SETTINGS simplestring

						m_SETTINGS.Visit (visitor, appData);
						m_simplestring.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_SETTINGS?.reparent (this);
			m_simplestring?.reparent (this);
		}

		//
		// initialize object associated with syntax rule PropertySettings
		//

		public void _init ()
		{
			m_SETTINGS = null;
			m_simplestring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule PropertySettings

		// counter of all nodes associated with syntax rule PropertySettings
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule PropertySettings
		[DataMember (Name = "m_SETTINGS")] public SyntaxTreeToken m_SETTINGS { get; private set; }
		[DataMember (Name = "m_simplestring")] public SyntaxTreeToken m_simplestring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule PropertySettings

		// delegate function (callback) prototype associated with syntax rule PropertySettings
		public delegate bool PropertySettings_Callback (SyntaxTreeCallbackReason reason, PropertySettings.production_kind kind, PropertySettings p_PropertySettings);

		// event associated with syntax rule PropertySettings
		public event PropertySettings_Callback PropertySettings_Event;

		// event trigger associated with syntax rule PropertySettings
		public bool Raise_PropertySettings_Event (SyntaxTreeCallbackReason reason, PropertySettings.production_kind kind, PropertySettings p_PropertySettings)
		{
			bool? status = PropertySettings_Event?.Invoke (reason, kind, p_PropertySettings);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule PropertySettings
		//
		// traverse syntax tree node associated with any production of syntax rule PropertySettings
		//

		public void Traverse (PropertySettings p_PropertySettings)
		{
			if (p_PropertySettings.isLocked())
				return;
			p_PropertySettings.dolock();
			PropertySettings.production_kind kind = (PropertySettings.production_kind) p_PropertySettings.kind;
			p_PropertySettings.turn_reset ();
			if (Raise_PropertySettings_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_PropertySettings))
			switch (kind)
			{
				case PropertySettings.production_kind.g_PropertySettings_1:
					// traverse syntax tree node associated with production
					// PropertySettings: SETTINGS simplestring

				break;
			}
			Raise_PropertySettings_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_PropertySettings);
			p_PropertySettings.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule PropertySettings
		//

		public void TraverseCommon (PropertySettings p_PropertySettings)
		{
			PropertySettings.production_kind kind = (PropertySettings.production_kind) p_PropertySettings.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_PropertySettings))
			switch (kind)
			{
				case PropertySettings.production_kind.g_PropertySettings_1:
					// traverse syntax tree node associated with production
					// PropertySettings: SETTINGS simplestring

						TraverseCommon (p_PropertySettings.m_SETTINGS);
						TraverseCommon (p_PropertySettings.m_simplestring);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_PropertySettings);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule PropertySettings

		//
		// create syntax tree node associated with production
		// PropertySettings: SETTINGS simplestring

		//

		public PropertySettings PropertySettings_1 (SyntaxTreeToken p_token, SyntaxTreeToken p_token_1)
		{
			PropertySettings p_PropertySettings_ref = new PropertySettings(p_token, p_token_1);
			p_token.parent = p_PropertySettings_ref;
			p_token_1.parent = p_PropertySettings_ref;
			Raise_PropertySettings_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PropertySettings.production_kind.g_PropertySettings_1, p_PropertySettings_ref);
			return p_PropertySettings_ref;
		}
		#endregion
	};
}
