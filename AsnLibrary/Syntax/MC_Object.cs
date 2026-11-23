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
	// class associated with syntax rule MC-Object
	//

	[DataContract]
	public class	MC_Object : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-Object
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-Object
		{
			g_MC_Object_1 = 1,	// OBJECT Value MC-SyntaxPart MC-WriteSyntaxPart MC-AccessPart DESCRIPTION cstring

		};
		#endregion
		#region production markers associated with the syntax rule MC-Object

		// markers associated with production: MC-Object -> OBJECT Value MC-SyntaxPart MC-WriteSyntaxPart MC-AccessPart DESCRIPTION cstring

		public enum production_marker_1 : ushort
		{
			m_Value,
			m_MC_SyntaxPart,
			m_MC_WriteSyntaxPart,
			m_MC_AccessPart,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-Object

		// Constructor declaration(s) associated with production(s) of syntax rule MC-Object

		//
		// Constructor associated with the following production(s)
		// MC-Object -> OBJECT Value MC-SyntaxPart MC-WriteSyntaxPart MC-AccessPart DESCRIPTION cstring

		//

		public MC_Object (SyntaxTreeToken p_token, Value p_Value, MC_SyntaxPart p_MC_SyntaxPart, MC_WriteSyntaxPart p_MC_WriteSyntaxPart, MC_AccessPart p_MC_AccessPart, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2) : base ((uint) ProductionID._MC_Object_ID, (uint) production_kind.g_MC_Object_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children[0] = m_OBJECT = p_token;
			children[1] = m_Value = p_Value;
			children[2] = m_MC_SyntaxPart = p_MC_SyntaxPart;
			children[3] = m_MC_WriteSyntaxPart = p_MC_WriteSyntaxPart;
			children[4] = m_MC_AccessPart = p_MC_AccessPart;
			children[5] = m_DESCRIPTION = p_token_1;
			children[6] = m_cstring = p_token_2;
		}

		public MC_Object () { }

		// Copy constructor

		public MC_Object (MC_Object p_MC_Object) : base (p_MC_Object.id, p_MC_Object.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_Object.appInfo;
			switch ((production_kind) p_MC_Object.kind)
			{
				case production_kind.g_MC_Object_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_OBJECT = (p_MC_Object.m_OBJECT != null) ? new SyntaxTreeToken (p_MC_Object.m_OBJECT) : null) != null) m_OBJECT.parent = this;
					if ((children [1] = m_Value = (p_MC_Object.m_Value != null) ? new Value (p_MC_Object.m_Value) : null) != null) m_Value.parent = this;
					if ((children [2] = m_MC_SyntaxPart = (p_MC_Object.m_MC_SyntaxPart != null) ? new MC_SyntaxPart (p_MC_Object.m_MC_SyntaxPart) : null) != null) m_MC_SyntaxPart.parent = this;
					if ((children [3] = m_MC_WriteSyntaxPart = (p_MC_Object.m_MC_WriteSyntaxPart != null) ? new MC_WriteSyntaxPart (p_MC_Object.m_MC_WriteSyntaxPart) : null) != null) m_MC_WriteSyntaxPart.parent = this;
					if ((children [4] = m_MC_AccessPart = (p_MC_Object.m_MC_AccessPart != null) ? new MC_AccessPart (p_MC_Object.m_MC_AccessPart) : null) != null) m_MC_AccessPart.parent = this;
					if ((children [5] = m_DESCRIPTION = (p_MC_Object.m_DESCRIPTION != null) ? new SyntaxTreeToken (p_MC_Object.m_DESCRIPTION) : null) != null) m_DESCRIPTION.parent = this;
					if ((children [6] = m_cstring = (p_MC_Object.m_cstring != null) ? new SyntaxTreeToken (p_MC_Object.m_cstring) : null) != null) m_cstring.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MC_Object" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_Object (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_OBJECT?.Dispose ();
			m_Value?.Dispose ();
			m_MC_SyntaxPart?.Dispose ();
			m_MC_WriteSyntaxPart?.Dispose ();
			m_MC_AccessPart?.Dispose ();
			m_DESCRIPTION?.Dispose ();
			m_cstring?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-Object

		// Content changing function(s) associated with production(s) of syntax rule MC-Object

		//
		// Content changing function associated with following production(s)
		// MC-Object -> OBJECT Value MC-SyntaxPart MC-WriteSyntaxPart MC-AccessPart DESCRIPTION cstring

		//

		public void change(SyntaxTreeToken p_token, Value p_Value, MC_SyntaxPart p_MC_SyntaxPart, MC_WriteSyntaxPart p_MC_WriteSyntaxPart, MC_AccessPart p_MC_AccessPart, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_Object_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children [0] = m_OBJECT = p_token;
			children [1] = m_Value = p_Value;
			children [2] = m_MC_SyntaxPart = p_MC_SyntaxPart;
			children [3] = m_MC_WriteSyntaxPart = p_MC_WriteSyntaxPart;
			children [4] = m_MC_AccessPart = p_MC_AccessPart;
			children [5] = m_DESCRIPTION = p_token_1;
			children [6] = m_cstring = p_token_2;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-Object
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_OBJECT != null) && m_OBJECT.checkInclusion (element) ||
				(m_Value != null) && m_Value.checkInclusion (element) ||
				(m_MC_SyntaxPart != null) && m_MC_SyntaxPart.checkInclusion (element) ||
				(m_MC_WriteSyntaxPart != null) && m_MC_WriteSyntaxPart.checkInclusion (element) ||
				(m_MC_AccessPart != null) && m_MC_AccessPart.checkInclusion (element) ||
				(m_DESCRIPTION != null) && m_DESCRIPTION.checkInclusion (element) ||
				(m_cstring != null) && m_cstring.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-Object

		//
		// emit production tree node associated with any production of syntax rule MC-Object
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_MC_Object_1:
					// emit syntax tree node associated with production
					// MC-Object: OBJECT Value MC-SyntaxPart MC-WriteSyntaxPart MC-AccessPart DESCRIPTION cstring

					s += m_OBJECT.Emit (depth - 1);
					s += " ";
					s += m_Value.Emit (depth - 1);
					s += " ";
					s += m_MC_SyntaxPart.Emit (depth - 1);
					s += " ";
					s += m_MC_WriteSyntaxPart.Emit (depth - 1);
					s += " ";
					s += m_MC_AccessPart.Emit (depth - 1);
					s += " ";
					s += m_DESCRIPTION.Emit (depth - 1);
					s += " ";
					s += m_cstring.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-Object
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "MC_Object (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_MC_Object_1:
					// emit syntax tree node associated with production
					// MC-Object: OBJECT Value MC-SyntaxPart MC-WriteSyntaxPart MC-AccessPart DESCRIPTION cstring

					s += "OBJECT";
					s += ' ';
					s += m_Value.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_MC_SyntaxPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_MC_WriteSyntaxPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_MC_AccessPart.EmitProductionTree (depth - 1);
					s += ' ';
					s += "DESCRIPTION";
					s += ' ';
					s += "cstring";
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-Object

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Object with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			MC_Object.production_kind kind = (MC_Object.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case MC_Object.production_kind.g_MC_Object_1:
					// traverse syntax tree node associated with production
					// MC-Object: OBJECT Value MC-SyntaxPart MC-WriteSyntaxPart MC-AccessPart DESCRIPTION cstring

						m_OBJECT.Visit (visitor, appData);
						m_Value.Visit (visitor, appData);
						m_MC_SyntaxPart.Visit (visitor, appData);
						m_MC_WriteSyntaxPart.Visit (visitor, appData);
						m_MC_AccessPart.Visit (visitor, appData);
						m_DESCRIPTION.Visit (visitor, appData);
						m_cstring.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_OBJECT?.reparent (this);
			m_Value?.reparent (this);
			m_MC_SyntaxPart?.reparent (this);
			m_MC_WriteSyntaxPart?.reparent (this);
			m_MC_AccessPart?.reparent (this);
			m_DESCRIPTION?.reparent (this);
			m_cstring?.reparent (this);
		}

		//
		// initialize object associated with syntax rule MC-Object
		//

		public void _init ()
		{
			m_OBJECT = null;
			m_Value = null;
			m_MC_SyntaxPart = null;
			m_MC_WriteSyntaxPart = null;
			m_MC_AccessPart = null;
			m_DESCRIPTION = null;
			m_cstring = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-Object

		// counter of all nodes associated with syntax rule MC-Object
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-Object
		[DataMember (Name = "m_OBJECT")] public SyntaxTreeToken m_OBJECT { get; private set; }
		[DataMember (Name = "m_Value")] public Value m_Value { get; private set; }
		[DataMember (Name = "m_MC_SyntaxPart")] public MC_SyntaxPart m_MC_SyntaxPart { get; private set; }
		[DataMember (Name = "m_MC_WriteSyntaxPart")] public MC_WriteSyntaxPart m_MC_WriteSyntaxPart { get; private set; }
		[DataMember (Name = "m_MC_AccessPart")] public MC_AccessPart m_MC_AccessPart { get; private set; }
		[DataMember (Name = "m_DESCRIPTION")] public SyntaxTreeToken m_DESCRIPTION { get; private set; }
		[DataMember (Name = "m_cstring")] public SyntaxTreeToken m_cstring { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-Object

		// delegate function (callback) prototype associated with syntax rule MC-Object
		public delegate bool MC_Object_Callback (SyntaxTreeCallbackReason reason, MC_Object.production_kind kind, MC_Object p_MC_Object);

		// event associated with syntax rule MC-Object
		public event MC_Object_Callback MC_Object_Event;

		// event trigger associated with syntax rule MC-Object
		public bool Raise_MC_Object_Event (SyntaxTreeCallbackReason reason, MC_Object.production_kind kind, MC_Object p_MC_Object)
		{
			bool? status = MC_Object_Event?.Invoke (reason, kind, p_MC_Object);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-Object
		//
		// traverse syntax tree node associated with any production of syntax rule MC-Object
		//

		public void Traverse (MC_Object p_MC_Object)
		{
			if (p_MC_Object.isLocked())
				return;
			p_MC_Object.dolock();
			MC_Object.production_kind kind = (MC_Object.production_kind) p_MC_Object.kind;
			p_MC_Object.turn_reset ();
			if (Raise_MC_Object_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_MC_Object))
			switch (kind)
			{
				case MC_Object.production_kind.g_MC_Object_1:
					// traverse syntax tree node associated with production
					// MC-Object: OBJECT Value MC-SyntaxPart MC-WriteSyntaxPart MC-AccessPart DESCRIPTION cstring

					if (Raise_MC_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Object))
						Traverse (p_MC_Object.m_Value);
					p_MC_Object.turn_inc ();
					if (Raise_MC_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Object))
						Traverse (p_MC_Object.m_MC_SyntaxPart);
					p_MC_Object.turn_inc ();
					if (Raise_MC_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Object))
						Traverse (p_MC_Object.m_MC_WriteSyntaxPart);
					p_MC_Object.turn_inc ();
					if (Raise_MC_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Object))
						Traverse (p_MC_Object.m_MC_AccessPart);
					p_MC_Object.turn_inc ();
					Raise_MC_Object_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_MC_Object);
				break;
			}
			Raise_MC_Object_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_MC_Object);
			p_MC_Object.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-Object
		//

		public void TraverseCommon (MC_Object p_MC_Object)
		{
			MC_Object.production_kind kind = (MC_Object.production_kind) p_MC_Object.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_MC_Object))
			switch (kind)
			{
				case MC_Object.production_kind.g_MC_Object_1:
					// traverse syntax tree node associated with production
					// MC-Object: OBJECT Value MC-SyntaxPart MC-WriteSyntaxPart MC-AccessPart DESCRIPTION cstring

						TraverseCommon (p_MC_Object.m_OBJECT);
						TraverseCommon (p_MC_Object.m_Value);
						TraverseCommon (p_MC_Object.m_MC_SyntaxPart);
						TraverseCommon (p_MC_Object.m_MC_WriteSyntaxPart);
						TraverseCommon (p_MC_Object.m_MC_AccessPart);
						TraverseCommon (p_MC_Object.m_DESCRIPTION);
						TraverseCommon (p_MC_Object.m_cstring);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_MC_Object);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-Object

		//
		// create syntax tree node associated with production
		// MC-Object: OBJECT Value MC-SyntaxPart MC-WriteSyntaxPart MC-AccessPart DESCRIPTION cstring

		//

		public MC_Object MC_Object_1 (SyntaxTreeToken p_token, Value p_Value, MC_SyntaxPart p_MC_SyntaxPart, MC_WriteSyntaxPart p_MC_WriteSyntaxPart, MC_AccessPart p_MC_AccessPart, SyntaxTreeToken p_token_1, SyntaxTreeToken p_token_2)
		{
			MC_Object p_MC_Object_ref = new MC_Object(p_token, p_Value, p_MC_SyntaxPart, p_MC_WriteSyntaxPart, p_MC_AccessPart, p_token_1, p_token_2);
			p_token.parent = p_MC_Object_ref;
			p_Value.parent = p_MC_Object_ref;
			p_MC_SyntaxPart.parent = p_MC_Object_ref;
			p_MC_WriteSyntaxPart.parent = p_MC_Object_ref;
			p_MC_AccessPart.parent = p_MC_Object_ref;
			p_token_1.parent = p_MC_Object_ref;
			p_token_2.parent = p_MC_Object_ref;
			Raise_MC_Object_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_Object.production_kind.g_MC_Object_1, p_MC_Object_ref);
			return p_MC_Object_ref;
		}
		#endregion
	};
}
