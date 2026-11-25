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
	// class associated with syntax rule PrimitiveFieldName
	//

	[DataContract]
	public class	PrimitiveFieldName : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule PrimitiveFieldName
		public enum production_kind : ushort	// enumerated production(s) of syntax rule PrimitiveFieldName
		{
			g_PrimitiveFieldName_1 = 1,	// typefieldreference-token

			g_PrimitiveFieldName_2 = 2,	// valuefieldreference-token

			g_PrimitiveFieldName_3 = 3,	// valuesetfieldreference-token

			g_PrimitiveFieldName_4 = 4,	// objectfieldreference-token

			g_PrimitiveFieldName_5 = 5,	// objectsetfieldreference-token

		};
		#endregion
		#region production markers associated with the syntax rule PrimitiveFieldName

		// markers associated with production: PrimitiveFieldName -> typefieldreference-token

		public enum production_marker_1 : ushort
		{
			m_typefieldreference_token,
			final
		};

		// markers associated with production: PrimitiveFieldName -> valuefieldreference-token

		public enum production_marker_2 : ushort
		{
			m_valuefieldreference_token,
			final
		};

		// markers associated with production: PrimitiveFieldName -> valuesetfieldreference-token

		public enum production_marker_3 : ushort
		{
			m_valuesetfieldreference_token,
			final
		};

		// markers associated with production: PrimitiveFieldName -> objectfieldreference-token

		public enum production_marker_4 : ushort
		{
			m_objectfieldreference_token,
			final
		};

		// markers associated with production: PrimitiveFieldName -> objectsetfieldreference-token

		public enum production_marker_5 : ushort
		{
			m_objectsetfieldreference_token,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule PrimitiveFieldName

		// Constructor declaration(s) associated with production(s) of syntax rule PrimitiveFieldName

		//
		// Constructor associated with the following production(s)
		// PrimitiveFieldName -> typefieldreference-token

		//

		public PrimitiveFieldName (typefieldreference_token p_typefieldreference_token) : base ((uint) ProductionID._PrimitiveFieldName_ID, (uint) production_kind.g_PrimitiveFieldName_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_typefieldreference_token = p_typefieldreference_token;
		}

		//
		// Constructor associated with the following production(s)
		// PrimitiveFieldName -> valuefieldreference-token

		//

		public PrimitiveFieldName (valuefieldreference_token p_valuefieldreference_token) : base ((uint) ProductionID._PrimitiveFieldName_ID, (uint) production_kind.g_PrimitiveFieldName_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_valuefieldreference_token = p_valuefieldreference_token;
		}

		//
		// Constructor associated with the following production(s)
		// PrimitiveFieldName -> valuesetfieldreference-token

		//

		public PrimitiveFieldName (valuesetfieldreference_token p_valuesetfieldreference_token) : base ((uint) ProductionID._PrimitiveFieldName_ID, (uint) production_kind.g_PrimitiveFieldName_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_valuesetfieldreference_token = p_valuesetfieldreference_token;
		}

		//
		// Constructor associated with the following production(s)
		// PrimitiveFieldName -> objectfieldreference-token

		//

		public PrimitiveFieldName (objectfieldreference_token p_objectfieldreference_token) : base ((uint) ProductionID._PrimitiveFieldName_ID, (uint) production_kind.g_PrimitiveFieldName_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_objectfieldreference_token = p_objectfieldreference_token;
		}

		//
		// Constructor associated with the following production(s)
		// PrimitiveFieldName -> objectsetfieldreference-token

		//

		public PrimitiveFieldName (objectsetfieldreference_token p_objectsetfieldreference_token) : base ((uint) ProductionID._PrimitiveFieldName_ID, (uint) production_kind.g_PrimitiveFieldName_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_objectsetfieldreference_token = p_objectsetfieldreference_token;
		}

		public PrimitiveFieldName () { }

		// Copy constructor

		public PrimitiveFieldName (PrimitiveFieldName p_PrimitiveFieldName) : base (p_PrimitiveFieldName.id, p_PrimitiveFieldName.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_PrimitiveFieldName.appInfo;
			switch ((production_kind) p_PrimitiveFieldName.kind)
			{
				case production_kind.g_PrimitiveFieldName_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_typefieldreference_token = (p_PrimitiveFieldName.m_typefieldreference_token != null) ? new typefieldreference_token (p_PrimitiveFieldName.m_typefieldreference_token) : null) != null) m_typefieldreference_token.parent = this;
					break;
				case production_kind.g_PrimitiveFieldName_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_valuefieldreference_token = (p_PrimitiveFieldName.m_valuefieldreference_token != null) ? new valuefieldreference_token (p_PrimitiveFieldName.m_valuefieldreference_token) : null) != null) m_valuefieldreference_token.parent = this;
					break;
				case production_kind.g_PrimitiveFieldName_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_valuesetfieldreference_token = (p_PrimitiveFieldName.m_valuesetfieldreference_token != null) ? new valuesetfieldreference_token (p_PrimitiveFieldName.m_valuesetfieldreference_token) : null) != null) m_valuesetfieldreference_token.parent = this;
					break;
				case production_kind.g_PrimitiveFieldName_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_objectfieldreference_token = (p_PrimitiveFieldName.m_objectfieldreference_token != null) ? new objectfieldreference_token (p_PrimitiveFieldName.m_objectfieldreference_token) : null) != null) m_objectfieldreference_token.parent = this;
					break;
				case production_kind.g_PrimitiveFieldName_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_objectsetfieldreference_token = (p_PrimitiveFieldName.m_objectsetfieldreference_token != null) ? new objectsetfieldreference_token (p_PrimitiveFieldName.m_objectsetfieldreference_token) : null) != null) m_objectsetfieldreference_token.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "PrimitiveFieldName" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new PrimitiveFieldName (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_typefieldreference_token?.Dispose ();
			m_valuefieldreference_token?.Dispose ();
			m_valuesetfieldreference_token?.Dispose ();
			m_objectfieldreference_token?.Dispose ();
			m_objectsetfieldreference_token?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule PrimitiveFieldName

		// Content changing function(s) associated with production(s) of syntax rule PrimitiveFieldName

		//
		// Content changing function associated with following production(s)
		// PrimitiveFieldName -> typefieldreference-token

		//

		public void change(typefieldreference_token p_typefieldreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_PrimitiveFieldName_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_typefieldreference_token = p_typefieldreference_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// PrimitiveFieldName -> valuefieldreference-token

		//

		public void change(valuefieldreference_token p_valuefieldreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_PrimitiveFieldName_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_valuefieldreference_token = p_valuefieldreference_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// PrimitiveFieldName -> valuesetfieldreference-token

		//

		public void change(valuesetfieldreference_token p_valuesetfieldreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_PrimitiveFieldName_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_valuesetfieldreference_token = p_valuesetfieldreference_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// PrimitiveFieldName -> objectfieldreference-token

		//

		public void change(objectfieldreference_token p_objectfieldreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_PrimitiveFieldName_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_objectfieldreference_token = p_objectfieldreference_token;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// PrimitiveFieldName -> objectsetfieldreference-token

		//

		public void change(objectsetfieldreference_token p_objectsetfieldreference_token)
		{
			_init ();
			this.kind = (uint) production_kind.g_PrimitiveFieldName_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_objectsetfieldreference_token = p_objectsetfieldreference_token;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule PrimitiveFieldName
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_typefieldreference_token != null) && m_typefieldreference_token.checkInclusion (element) ||
				(m_valuefieldreference_token != null) && m_valuefieldreference_token.checkInclusion (element) ||
				(m_valuesetfieldreference_token != null) && m_valuesetfieldreference_token.checkInclusion (element) ||
				(m_objectfieldreference_token != null) && m_objectfieldreference_token.checkInclusion (element) ||
				(m_objectsetfieldreference_token != null) && m_objectsetfieldreference_token.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule PrimitiveFieldName

		//
		// emit production tree node associated with any production of syntax rule PrimitiveFieldName
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_PrimitiveFieldName_1:
					// emit syntax tree node associated with production
					// PrimitiveFieldName: typefieldreference-token

					s += m_typefieldreference_token.Emit (depth - 1);
				break;
				case production_kind.g_PrimitiveFieldName_2:
					// emit syntax tree node associated with production
					// PrimitiveFieldName: valuefieldreference-token

					s += m_valuefieldreference_token.Emit (depth - 1);
				break;
				case production_kind.g_PrimitiveFieldName_3:
					// emit syntax tree node associated with production
					// PrimitiveFieldName: valuesetfieldreference-token

					s += m_valuesetfieldreference_token.Emit (depth - 1);
				break;
				case production_kind.g_PrimitiveFieldName_4:
					// emit syntax tree node associated with production
					// PrimitiveFieldName: objectfieldreference-token

					s += m_objectfieldreference_token.Emit (depth - 1);
				break;
				case production_kind.g_PrimitiveFieldName_5:
					// emit syntax tree node associated with production
					// PrimitiveFieldName: objectsetfieldreference-token

					s += m_objectsetfieldreference_token.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule PrimitiveFieldName
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "PrimitiveFieldName (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_PrimitiveFieldName_1:
					// emit syntax tree node associated with production
					// PrimitiveFieldName: typefieldreference-token

					s += m_typefieldreference_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_PrimitiveFieldName_2:
					// emit syntax tree node associated with production
					// PrimitiveFieldName: valuefieldreference-token

					s += m_valuefieldreference_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_PrimitiveFieldName_3:
					// emit syntax tree node associated with production
					// PrimitiveFieldName: valuesetfieldreference-token

					s += m_valuesetfieldreference_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_PrimitiveFieldName_4:
					// emit syntax tree node associated with production
					// PrimitiveFieldName: objectfieldreference-token

					s += m_objectfieldreference_token.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_PrimitiveFieldName_5:
					// emit syntax tree node associated with production
					// PrimitiveFieldName: objectsetfieldreference-token

					s += m_objectsetfieldreference_token.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule PrimitiveFieldName

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule PrimitiveFieldName with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			PrimitiveFieldName.production_kind kind = (PrimitiveFieldName.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_1:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: typefieldreference-token

						m_typefieldreference_token.Visit (visitor, appData);
				break;
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_2:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: valuefieldreference-token

						m_valuefieldreference_token.Visit (visitor, appData);
				break;
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_3:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: valuesetfieldreference-token

						m_valuesetfieldreference_token.Visit (visitor, appData);
				break;
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_4:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: objectfieldreference-token

						m_objectfieldreference_token.Visit (visitor, appData);
				break;
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_5:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: objectsetfieldreference-token

						m_objectsetfieldreference_token.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_typefieldreference_token?.reparent (this);
			m_valuefieldreference_token?.reparent (this);
			m_valuesetfieldreference_token?.reparent (this);
			m_objectfieldreference_token?.reparent (this);
			m_objectsetfieldreference_token?.reparent (this);
		}

		//
		// initialize object associated with syntax rule PrimitiveFieldName
		//

		public void _init ()
		{
			m_typefieldreference_token = null;
			m_valuefieldreference_token = null;
			m_valuesetfieldreference_token = null;
			m_objectfieldreference_token = null;
			m_objectsetfieldreference_token = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule PrimitiveFieldName

		// counter of all nodes associated with syntax rule PrimitiveFieldName
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule PrimitiveFieldName
		[DataMember (Name = "m_typefieldreference_token")] public typefieldreference_token m_typefieldreference_token { get; private set; }
		[DataMember (Name = "m_valuefieldreference_token")] public valuefieldreference_token m_valuefieldreference_token { get; private set; }
		[DataMember (Name = "m_valuesetfieldreference_token")] public valuesetfieldreference_token m_valuesetfieldreference_token { get; private set; }
		[DataMember (Name = "m_objectfieldreference_token")] public objectfieldreference_token m_objectfieldreference_token { get; private set; }
		[DataMember (Name = "m_objectsetfieldreference_token")] public objectsetfieldreference_token m_objectsetfieldreference_token { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule PrimitiveFieldName

		// delegate function (callback) prototype associated with syntax rule PrimitiveFieldName
		public delegate bool PrimitiveFieldName_Callback (SyntaxTreeCallbackReason reason, PrimitiveFieldName.production_kind kind, PrimitiveFieldName p_PrimitiveFieldName);

		// event associated with syntax rule PrimitiveFieldName
		public event PrimitiveFieldName_Callback PrimitiveFieldName_Event;

		// event trigger associated with syntax rule PrimitiveFieldName
		public bool Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason reason, PrimitiveFieldName.production_kind kind, PrimitiveFieldName p_PrimitiveFieldName)
		{
			bool? status = PrimitiveFieldName_Event?.Invoke (reason, kind, p_PrimitiveFieldName);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule PrimitiveFieldName
		//
		// traverse syntax tree node associated with any production of syntax rule PrimitiveFieldName
		//

		public void Traverse (PrimitiveFieldName p_PrimitiveFieldName)
		{
			if (p_PrimitiveFieldName.isLocked())
				return;
			p_PrimitiveFieldName.dolock();
			PrimitiveFieldName.production_kind kind = (PrimitiveFieldName.production_kind) p_PrimitiveFieldName.kind;
			p_PrimitiveFieldName.turn_reset ();
			if (Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_PrimitiveFieldName))
			switch (kind)
			{
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_1:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: typefieldreference-token

					if (Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrimitiveFieldName))
						Traverse (p_PrimitiveFieldName.m_typefieldreference_token);
					p_PrimitiveFieldName.turn_inc ();
					Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrimitiveFieldName);
				break;
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_2:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: valuefieldreference-token

					if (Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrimitiveFieldName))
						Traverse (p_PrimitiveFieldName.m_valuefieldreference_token);
					p_PrimitiveFieldName.turn_inc ();
					Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrimitiveFieldName);
				break;
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_3:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: valuesetfieldreference-token

					if (Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrimitiveFieldName))
						Traverse (p_PrimitiveFieldName.m_valuesetfieldreference_token);
					p_PrimitiveFieldName.turn_inc ();
					Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrimitiveFieldName);
				break;
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_4:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: objectfieldreference-token

					if (Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrimitiveFieldName))
						Traverse (p_PrimitiveFieldName.m_objectfieldreference_token);
					p_PrimitiveFieldName.turn_inc ();
					Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrimitiveFieldName);
				break;
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_5:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: objectsetfieldreference-token

					if (Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrimitiveFieldName))
						Traverse (p_PrimitiveFieldName.m_objectsetfieldreference_token);
					p_PrimitiveFieldName.turn_inc ();
					Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_PrimitiveFieldName);
				break;
			}
			Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_PrimitiveFieldName);
			p_PrimitiveFieldName.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule PrimitiveFieldName
		//

		public void TraverseCommon (PrimitiveFieldName p_PrimitiveFieldName)
		{
			PrimitiveFieldName.production_kind kind = (PrimitiveFieldName.production_kind) p_PrimitiveFieldName.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_PrimitiveFieldName))
			switch (kind)
			{
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_1:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: typefieldreference-token

						TraverseCommon (p_PrimitiveFieldName.m_typefieldreference_token);
				break;
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_2:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: valuefieldreference-token

						TraverseCommon (p_PrimitiveFieldName.m_valuefieldreference_token);
				break;
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_3:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: valuesetfieldreference-token

						TraverseCommon (p_PrimitiveFieldName.m_valuesetfieldreference_token);
				break;
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_4:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: objectfieldreference-token

						TraverseCommon (p_PrimitiveFieldName.m_objectfieldreference_token);
				break;
				case PrimitiveFieldName.production_kind.g_PrimitiveFieldName_5:
					// traverse syntax tree node associated with production
					// PrimitiveFieldName: objectsetfieldreference-token

						TraverseCommon (p_PrimitiveFieldName.m_objectsetfieldreference_token);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_PrimitiveFieldName);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule PrimitiveFieldName

		//
		// create syntax tree node associated with production
		// PrimitiveFieldName: typefieldreference-token

		//

		public PrimitiveFieldName PrimitiveFieldName_1 (typefieldreference_token p_typefieldreference_token)
		{
			PrimitiveFieldName p_PrimitiveFieldName_ref = new PrimitiveFieldName(p_typefieldreference_token);
			p_typefieldreference_token.parent = p_PrimitiveFieldName_ref;
			Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PrimitiveFieldName.production_kind.g_PrimitiveFieldName_1, p_PrimitiveFieldName_ref);
			return p_PrimitiveFieldName_ref;
		}

		//
		// create syntax tree node associated with production
		// PrimitiveFieldName: valuefieldreference-token

		//

		public PrimitiveFieldName PrimitiveFieldName_2 (valuefieldreference_token p_valuefieldreference_token)
		{
			PrimitiveFieldName p_PrimitiveFieldName_ref = new PrimitiveFieldName(p_valuefieldreference_token);
			p_valuefieldreference_token.parent = p_PrimitiveFieldName_ref;
			Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PrimitiveFieldName.production_kind.g_PrimitiveFieldName_2, p_PrimitiveFieldName_ref);
			return p_PrimitiveFieldName_ref;
		}

		//
		// create syntax tree node associated with production
		// PrimitiveFieldName: valuesetfieldreference-token

		//

		public PrimitiveFieldName PrimitiveFieldName_3 (valuesetfieldreference_token p_valuesetfieldreference_token)
		{
			PrimitiveFieldName p_PrimitiveFieldName_ref = new PrimitiveFieldName(p_valuesetfieldreference_token);
			p_valuesetfieldreference_token.parent = p_PrimitiveFieldName_ref;
			Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PrimitiveFieldName.production_kind.g_PrimitiveFieldName_3, p_PrimitiveFieldName_ref);
			return p_PrimitiveFieldName_ref;
		}

		//
		// create syntax tree node associated with production
		// PrimitiveFieldName: objectfieldreference-token

		//

		public PrimitiveFieldName PrimitiveFieldName_4 (objectfieldreference_token p_objectfieldreference_token)
		{
			PrimitiveFieldName p_PrimitiveFieldName_ref = new PrimitiveFieldName(p_objectfieldreference_token);
			p_objectfieldreference_token.parent = p_PrimitiveFieldName_ref;
			Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PrimitiveFieldName.production_kind.g_PrimitiveFieldName_4, p_PrimitiveFieldName_ref);
			return p_PrimitiveFieldName_ref;
		}

		//
		// create syntax tree node associated with production
		// PrimitiveFieldName: objectsetfieldreference-token

		//

		public PrimitiveFieldName PrimitiveFieldName_5 (objectsetfieldreference_token p_objectsetfieldreference_token)
		{
			PrimitiveFieldName p_PrimitiveFieldName_ref = new PrimitiveFieldName(p_objectsetfieldreference_token);
			p_objectsetfieldreference_token.parent = p_PrimitiveFieldName_ref;
			Raise_PrimitiveFieldName_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, PrimitiveFieldName.production_kind.g_PrimitiveFieldName_5, p_PrimitiveFieldName_ref);
			return p_PrimitiveFieldName_ref;
		}
		#endregion
	};
}
