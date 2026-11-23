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
	// class associated with syntax rule ModuleDefinition
	//

	[DataContract]
	public class	ModuleDefinition : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ModuleDefinition
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ModuleDefinition
		{
			g_ModuleDefinition_1 = 1,	// ModuleIdentifier DefinitionsDefault EncodingReferenceDefault TagDefault ExtensionDefault "::=" BEGIN ModuleBody EncodingControlSections END

		};
		#endregion
		#region production markers associated with the syntax rule ModuleDefinition

		// markers associated with production: ModuleDefinition -> ModuleIdentifier DefinitionsDefault EncodingReferenceDefault TagDefault ExtensionDefault "::=" BEGIN ModuleBody EncodingControlSections END

		public enum production_marker_1 : ushort
		{
			m_ModuleIdentifier,
			m_DefinitionsDefault,
			m_EncodingReferenceDefault,
			m_TagDefault,
			m_ExtensionDefault,
			m_ModuleBody,
			m_EncodingControlSections,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ModuleDefinition

		// Constructor declaration(s) associated with production(s) of syntax rule ModuleDefinition

		//
		// Constructor associated with the following production(s)
		// ModuleDefinition -> ModuleIdentifier DefinitionsDefault EncodingReferenceDefault TagDefault ExtensionDefault "::=" BEGIN ModuleBody EncodingControlSections END

		//

		public ModuleDefinition (ModuleIdentifier p_ModuleIdentifier, DefinitionsDefault p_DefinitionsDefault, EncodingReferenceDefault p_EncodingReferenceDefault, TagDefault p_TagDefault, ExtensionDefault p_ExtensionDefault, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, ModuleBody p_ModuleBody, EncodingControlSections p_EncodingControlSections, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._ModuleDefinition_ID, (uint) production_kind.g_ModuleDefinition_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 10);
			children[0] = m_ModuleIdentifier = p_ModuleIdentifier;
			children[1] = m_DefinitionsDefault = p_DefinitionsDefault;
			children[2] = m_EncodingReferenceDefault = p_EncodingReferenceDefault;
			children[3] = m_TagDefault = p_TagDefault;
			children[4] = m_ExtensionDefault = p_ExtensionDefault;
			children[5] = m_assignment_sign = p_token;
			children[6] = m_BEGIN = p_token_1;
			children[7] = m_ModuleBody = p_ModuleBody;
			children[8] = m_EncodingControlSections = p_EncodingControlSections;
			children[9] = m_END = p_token_2;
		}

		public ModuleDefinition () { }

		// Copy constructor

		public ModuleDefinition (ModuleDefinition p_ModuleDefinition) : base (p_ModuleDefinition.id, p_ModuleDefinition.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ModuleDefinition.appInfo;
			switch ((production_kind) p_ModuleDefinition.kind)
			{
				case production_kind.g_ModuleDefinition_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 10);
					if ((children [0] = m_ModuleIdentifier = (p_ModuleDefinition.m_ModuleIdentifier != null) ? new ModuleIdentifier (p_ModuleDefinition.m_ModuleIdentifier) : null) != null) m_ModuleIdentifier.parent = this;
					if ((children [1] = m_DefinitionsDefault = (p_ModuleDefinition.m_DefinitionsDefault != null) ? new DefinitionsDefault (p_ModuleDefinition.m_DefinitionsDefault) : null) != null) m_DefinitionsDefault.parent = this;
					if ((children [2] = m_EncodingReferenceDefault = (p_ModuleDefinition.m_EncodingReferenceDefault != null) ? new EncodingReferenceDefault (p_ModuleDefinition.m_EncodingReferenceDefault) : null) != null) m_EncodingReferenceDefault.parent = this;
					if ((children [3] = m_TagDefault = (p_ModuleDefinition.m_TagDefault != null) ? new TagDefault (p_ModuleDefinition.m_TagDefault) : null) != null) m_TagDefault.parent = this;
					if ((children [4] = m_ExtensionDefault = (p_ModuleDefinition.m_ExtensionDefault != null) ? new ExtensionDefault (p_ModuleDefinition.m_ExtensionDefault) : null) != null) m_ExtensionDefault.parent = this;
					if ((children [5] = m_assignment_sign = (p_ModuleDefinition.m_assignment_sign != null) ? new SyntaxTreeToken (p_ModuleDefinition.m_assignment_sign) : null) != null) m_assignment_sign.parent = this;
					if ((children [6] = m_BEGIN = (p_ModuleDefinition.m_BEGIN != null) ? new SyntaxTreeToken (p_ModuleDefinition.m_BEGIN) : null) != null) m_BEGIN.parent = this;
					if ((children [7] = m_ModuleBody = (p_ModuleDefinition.m_ModuleBody != null) ? new ModuleBody (p_ModuleDefinition.m_ModuleBody) : null) != null) m_ModuleBody.parent = this;
					if ((children [8] = m_EncodingControlSections = (p_ModuleDefinition.m_EncodingControlSections != null) ? new EncodingControlSections (p_ModuleDefinition.m_EncodingControlSections) : null) != null) m_EncodingControlSections.parent = this;
					if ((children [9] = m_END = (p_ModuleDefinition.m_END != null) ? new SyntaxTreeToken (p_ModuleDefinition.m_END) : null) != null) m_END.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ModuleDefinition" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ModuleDefinition (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_ModuleIdentifier?.Dispose ();
			m_DefinitionsDefault?.Dispose ();
			m_EncodingReferenceDefault?.Dispose ();
			m_TagDefault?.Dispose ();
			m_ExtensionDefault?.Dispose ();
			m_assignment_sign?.Dispose ();
			m_BEGIN?.Dispose ();
			m_ModuleBody?.Dispose ();
			m_EncodingControlSections?.Dispose ();
			m_END?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ModuleDefinition

		// Content changing function(s) associated with production(s) of syntax rule ModuleDefinition

		//
		// Content changing function associated with following production(s)
		// ModuleDefinition -> ModuleIdentifier DefinitionsDefault EncodingReferenceDefault TagDefault ExtensionDefault "::=" BEGIN ModuleBody EncodingControlSections END

		//

		public void change(ModuleIdentifier p_ModuleIdentifier, DefinitionsDefault p_DefinitionsDefault, EncodingReferenceDefault p_EncodingReferenceDefault, TagDefault p_TagDefault, ExtensionDefault p_ExtensionDefault, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, ModuleBody p_ModuleBody, EncodingControlSections p_EncodingControlSections, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_ModuleDefinition_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 10);
			children [0] = m_ModuleIdentifier = p_ModuleIdentifier;
			children [1] = m_DefinitionsDefault = p_DefinitionsDefault;
			children [2] = m_EncodingReferenceDefault = p_EncodingReferenceDefault;
			children [3] = m_TagDefault = p_TagDefault;
			children [4] = m_ExtensionDefault = p_ExtensionDefault;
			children [5] = m_assignment_sign = p_token;
			children [6] = m_BEGIN = p_token_1;
			children [7] = m_ModuleBody = p_ModuleBody;
			children [8] = m_EncodingControlSections = p_EncodingControlSections;
			children [9] = m_END = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ModuleDefinition
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_ModuleIdentifier != null) && m_ModuleIdentifier.checkInclusion (element) ||
				(m_DefinitionsDefault != null) && m_DefinitionsDefault.checkInclusion (element) ||
				(m_EncodingReferenceDefault != null) && m_EncodingReferenceDefault.checkInclusion (element) ||
				(m_TagDefault != null) && m_TagDefault.checkInclusion (element) ||
				(m_ExtensionDefault != null) && m_ExtensionDefault.checkInclusion (element) ||
				(m_assignment_sign != null) && m_assignment_sign.checkInclusion (element) ||
				(m_BEGIN != null) && m_BEGIN.checkInclusion (element) ||
				(m_ModuleBody != null) && m_ModuleBody.checkInclusion (element) ||
				(m_EncodingControlSections != null) && m_EncodingControlSections.checkInclusion (element) ||
				(m_END != null) && m_END.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ModuleDefinition

		//
		// emit production tree node associated with any production of syntax rule ModuleDefinition
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ModuleDefinition_1:
					// emit syntax tree node associated with production
					// ModuleDefinition: ModuleIdentifier DefinitionsDefault EncodingReferenceDefault TagDefault ExtensionDefault "::=" BEGIN ModuleBody EncodingControlSections END

					s += m_ModuleIdentifier.Emit (depth - 1);
					s += " ";
					s += m_DefinitionsDefault.Emit (depth - 1);
					s += " ";
					s += m_EncodingReferenceDefault.Emit (depth - 1);
					s += " ";
					s += m_TagDefault.Emit (depth - 1);
					s += " ";
					s += m_ExtensionDefault.Emit (depth - 1);
					s += " ";
					s += m_assignment_sign.Emit (depth - 1);
					s += " ";
					s += m_BEGIN.Emit (depth - 1);
					s += " ";
					s += m_ModuleBody.Emit (depth - 1);
					s += " ";
					s += m_EncodingControlSections.Emit (depth - 1);
					s += " ";
					s += m_END.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ModuleDefinition
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ModuleDefinition (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ModuleDefinition_1:
					// emit syntax tree node associated with production
					// ModuleDefinition: ModuleIdentifier DefinitionsDefault EncodingReferenceDefault TagDefault ExtensionDefault "::=" BEGIN ModuleBody EncodingControlSections END

					s += m_ModuleIdentifier.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_DefinitionsDefault.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_EncodingReferenceDefault.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_TagDefault.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ExtensionDefault.EmitProductionTree (depth - 1);
					s += ' ';
					s += "assignment_sign";
					s += ' ';
					s += "BEGIN";
					s += ' ';
					s += m_ModuleBody.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_EncodingControlSections.EmitProductionTree (depth - 1);
					s += ' ';
					s += "END";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ModuleDefinition

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ModuleDefinition with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ModuleDefinition.production_kind kind = (ModuleDefinition.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ModuleDefinition.production_kind.g_ModuleDefinition_1:
					// traverse syntax tree node associated with production
					// ModuleDefinition: ModuleIdentifier DefinitionsDefault EncodingReferenceDefault TagDefault ExtensionDefault "::=" BEGIN ModuleBody EncodingControlSections END

						m_ModuleIdentifier.Visit (visitor, appData);
						m_DefinitionsDefault.Visit (visitor, appData);
						m_EncodingReferenceDefault.Visit (visitor, appData);
						m_TagDefault.Visit (visitor, appData);
						m_ExtensionDefault.Visit (visitor, appData);
						m_assignment_sign.Visit (visitor, appData);
						m_BEGIN.Visit (visitor, appData);
						m_ModuleBody.Visit (visitor, appData);
						m_EncodingControlSections.Visit (visitor, appData);
						m_END.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_ModuleIdentifier?.reparent (this);
			m_DefinitionsDefault?.reparent (this);
			m_EncodingReferenceDefault?.reparent (this);
			m_TagDefault?.reparent (this);
			m_ExtensionDefault?.reparent (this);
			m_assignment_sign?.reparent (this);
			m_BEGIN?.reparent (this);
			m_ModuleBody?.reparent (this);
			m_EncodingControlSections?.reparent (this);
			m_END?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ModuleDefinition
		//

		public void _init ()
		{
			m_ModuleIdentifier = null;
			m_DefinitionsDefault = null;
			m_EncodingReferenceDefault = null;
			m_TagDefault = null;
			m_ExtensionDefault = null;
			m_assignment_sign = null;
			m_BEGIN = null;
			m_ModuleBody = null;
			m_EncodingControlSections = null;
			m_END = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ModuleDefinition

		// counter of all nodes associated with syntax rule ModuleDefinition
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ModuleDefinition
		[DataMember (Name = "m_ModuleIdentifier")] public ModuleIdentifier m_ModuleIdentifier { get; private set; }
		[DataMember (Name = "m_DefinitionsDefault")] public DefinitionsDefault m_DefinitionsDefault { get; private set; }
		[DataMember (Name = "m_EncodingReferenceDefault")] public EncodingReferenceDefault m_EncodingReferenceDefault { get; private set; }
		[DataMember (Name = "m_TagDefault")] public TagDefault m_TagDefault { get; private set; }
		[DataMember (Name = "m_ExtensionDefault")] public ExtensionDefault m_ExtensionDefault { get; private set; }
		[DataMember (Name = "m_assignment_sign")] public SyntaxTreeToken m_assignment_sign { get; private set; }
		[DataMember (Name = "m_BEGIN")] public SyntaxTreeToken m_BEGIN { get; private set; }
		[DataMember (Name = "m_ModuleBody")] public ModuleBody m_ModuleBody { get; private set; }
		[DataMember (Name = "m_EncodingControlSections")] public EncodingControlSections m_EncodingControlSections { get; private set; }
		[DataMember (Name = "m_END")] public SyntaxTreeToken m_END { get; private set; }

		public enum __p1_markers
		{
			m1 = 5,
			m2 = 7,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ModuleDefinition

		// delegate function (callback) prototype associated with syntax rule ModuleDefinition
		public delegate bool ModuleDefinition_Callback (SyntaxTreeCallbackReason reason, ModuleDefinition.production_kind kind, ModuleDefinition p_ModuleDefinition);

		// event associated with syntax rule ModuleDefinition
		public event ModuleDefinition_Callback ModuleDefinition_Event;

		// event trigger associated with syntax rule ModuleDefinition
		public bool Raise_ModuleDefinition_Event (SyntaxTreeCallbackReason reason, ModuleDefinition.production_kind kind, ModuleDefinition p_ModuleDefinition)
		{
			bool? status = ModuleDefinition_Event?.Invoke (reason, kind, p_ModuleDefinition);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ModuleDefinition
		//
		// traverse syntax tree node associated with any production of syntax rule ModuleDefinition
		//

		public void Traverse (ModuleDefinition p_ModuleDefinition)
		{
			if (p_ModuleDefinition.isLocked())
				return;
			p_ModuleDefinition.dolock();
			ModuleDefinition.production_kind kind = (ModuleDefinition.production_kind) p_ModuleDefinition.kind;
			p_ModuleDefinition.turn_reset ();
			if (Raise_ModuleDefinition_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ModuleDefinition))
			switch (kind)
			{
				case ModuleDefinition.production_kind.g_ModuleDefinition_1:
					// traverse syntax tree node associated with production
					// ModuleDefinition: ModuleIdentifier DefinitionsDefault EncodingReferenceDefault TagDefault ExtensionDefault "::=" BEGIN ModuleBody EncodingControlSections END

					if (Raise_ModuleDefinition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleDefinition))
						Traverse (p_ModuleDefinition.m_ModuleIdentifier);
					p_ModuleDefinition.turn_inc ();
					if (Raise_ModuleDefinition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleDefinition))
						Traverse (p_ModuleDefinition.m_DefinitionsDefault);
					p_ModuleDefinition.turn_inc ();
					if (Raise_ModuleDefinition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleDefinition))
						Traverse (p_ModuleDefinition.m_EncodingReferenceDefault);
					p_ModuleDefinition.turn_inc ();
					if (Raise_ModuleDefinition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleDefinition))
						Traverse (p_ModuleDefinition.m_TagDefault);
					p_ModuleDefinition.turn_inc ();
					if (Raise_ModuleDefinition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleDefinition))
						Traverse (p_ModuleDefinition.m_ExtensionDefault);
					p_ModuleDefinition.turn_inc ();
					if (Raise_ModuleDefinition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleDefinition))
						Traverse (p_ModuleDefinition.m_ModuleBody);
					p_ModuleDefinition.turn_inc ();
					if (Raise_ModuleDefinition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleDefinition))
						Traverse (p_ModuleDefinition.m_EncodingControlSections);
					p_ModuleDefinition.turn_inc ();
					Raise_ModuleDefinition_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ModuleDefinition);
				break;
			}
			Raise_ModuleDefinition_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ModuleDefinition);
			p_ModuleDefinition.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ModuleDefinition
		//

		public void TraverseCommon (ModuleDefinition p_ModuleDefinition)
		{
			ModuleDefinition.production_kind kind = (ModuleDefinition.production_kind) p_ModuleDefinition.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ModuleDefinition))
			switch (kind)
			{
				case ModuleDefinition.production_kind.g_ModuleDefinition_1:
					// traverse syntax tree node associated with production
					// ModuleDefinition: ModuleIdentifier DefinitionsDefault EncodingReferenceDefault TagDefault ExtensionDefault "::=" BEGIN ModuleBody EncodingControlSections END

						TraverseCommon (p_ModuleDefinition.m_ModuleIdentifier);
						TraverseCommon (p_ModuleDefinition.m_DefinitionsDefault);
						TraverseCommon (p_ModuleDefinition.m_EncodingReferenceDefault);
						TraverseCommon (p_ModuleDefinition.m_TagDefault);
						TraverseCommon (p_ModuleDefinition.m_ExtensionDefault);
						TraverseCommon (p_ModuleDefinition.m_assignment_sign);
						TraverseCommon (p_ModuleDefinition.m_BEGIN);
						TraverseCommon (p_ModuleDefinition.m_ModuleBody);
						TraverseCommon (p_ModuleDefinition.m_EncodingControlSections);
						TraverseCommon (p_ModuleDefinition.m_END);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ModuleDefinition);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ModuleDefinition

		//
		// create syntax tree node associated with production
		// ModuleDefinition: ModuleIdentifier DefinitionsDefault EncodingReferenceDefault TagDefault ExtensionDefault "::=" BEGIN ModuleBody EncodingControlSections END

		//

		public ModuleDefinition ModuleDefinition_1 (ModuleIdentifier p_ModuleIdentifier, DefinitionsDefault p_DefinitionsDefault, EncodingReferenceDefault p_EncodingReferenceDefault, TagDefault p_TagDefault, ExtensionDefault p_ExtensionDefault, SyntaxTreeToken p_token, SyntaxTreeToken p_token_1, ModuleBody p_ModuleBody, EncodingControlSections p_EncodingControlSections, SyntaxTreeToken p_token_2)
		{
			ModuleDefinition p_ModuleDefinition_ref = new ModuleDefinition(p_ModuleIdentifier, p_DefinitionsDefault, p_EncodingReferenceDefault, p_TagDefault, p_ExtensionDefault, p_token, p_token_1, p_ModuleBody, p_EncodingControlSections, p_token_2);
			p_ModuleIdentifier.parent = p_ModuleDefinition_ref;
			p_DefinitionsDefault.parent = p_ModuleDefinition_ref;
			p_EncodingReferenceDefault.parent = p_ModuleDefinition_ref;
			p_TagDefault.parent = p_ModuleDefinition_ref;
			p_ExtensionDefault.parent = p_ModuleDefinition_ref;
			p_token.parent = p_ModuleDefinition_ref;
			p_token_1.parent = p_ModuleDefinition_ref;
			p_ModuleBody.parent = p_ModuleDefinition_ref;
			p_EncodingControlSections.parent = p_ModuleDefinition_ref;
			p_token_2.parent = p_ModuleDefinition_ref;
			Raise_ModuleDefinition_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ModuleDefinition.production_kind.g_ModuleDefinition_1, p_ModuleDefinition_ref);
			return p_ModuleDefinition_ref;
		}
		#endregion
	};
}
