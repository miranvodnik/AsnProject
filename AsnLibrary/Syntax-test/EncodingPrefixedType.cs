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
	// class associated with syntax rule EncodingPrefixedType
	//

	[DataContract]
	public class	EncodingPrefixedType : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule EncodingPrefixedType
		public enum production_kind : ushort	// enumerated production(s) of syntax rule EncodingPrefixedType
		{
			g_EncodingPrefixedType_1 = 1,	// EncodingPrefix Type

		};
		#endregion
		#region production markers associated with the syntax rule EncodingPrefixedType

		// markers associated with production: EncodingPrefixedType -> EncodingPrefix Type

		public enum production_marker_1 : ushort
		{
			m_EncodingPrefix,
			m_Type,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule EncodingPrefixedType

		// Constructor declaration(s) associated with production(s) of syntax rule EncodingPrefixedType

		//
		// Constructor associated with the following production(s)
		// EncodingPrefixedType -> EncodingPrefix Type

		//

		public EncodingPrefixedType (EncodingPrefix p_EncodingPrefix, Type p_Type) : base ((uint) ProductionID._EncodingPrefixedType_ID, (uint) production_kind.g_EncodingPrefixedType_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_EncodingPrefix = p_EncodingPrefix;
			children[1] = m_Type = p_Type;
		}

		public EncodingPrefixedType () { }

		// Copy constructor

		public EncodingPrefixedType (EncodingPrefixedType p_EncodingPrefixedType) : base (p_EncodingPrefixedType.id, p_EncodingPrefixedType.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_EncodingPrefixedType.appInfo;
			switch ((production_kind) p_EncodingPrefixedType.kind)
			{
				case production_kind.g_EncodingPrefixedType_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_EncodingPrefix = (p_EncodingPrefixedType.m_EncodingPrefix != null) ? new EncodingPrefix (p_EncodingPrefixedType.m_EncodingPrefix) : null) != null) m_EncodingPrefix.parent = this;
					if ((children [1] = m_Type = (p_EncodingPrefixedType.m_Type != null) ? new Type (p_EncodingPrefixedType.m_Type) : null) != null) m_Type.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "EncodingPrefixedType" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new EncodingPrefixedType (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_EncodingPrefix?.Dispose ();
			m_Type?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule EncodingPrefixedType

		// Content changing function(s) associated with production(s) of syntax rule EncodingPrefixedType

		//
		// Content changing function associated with following production(s)
		// EncodingPrefixedType -> EncodingPrefix Type

		//

		public void change(EncodingPrefix p_EncodingPrefix, Type p_Type)
		{
			_init ();
			this.kind = (uint) production_kind.g_EncodingPrefixedType_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_EncodingPrefix = p_EncodingPrefix;
			children [1] = m_Type = p_Type;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule EncodingPrefixedType
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_EncodingPrefix != null) && m_EncodingPrefix.checkInclusion (element) ||
				(m_Type != null) && m_Type.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule EncodingPrefixedType

		//
		// emit production tree node associated with any production of syntax rule EncodingPrefixedType
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_EncodingPrefixedType_1:
					// emit syntax tree node associated with production
					// EncodingPrefixedType: EncodingPrefix Type

					s += m_EncodingPrefix.Emit (depth - 1);
					s += " ";
					s += m_Type.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule EncodingPrefixedType
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "EncodingPrefixedType (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_EncodingPrefixedType_1:
					// emit syntax tree node associated with production
					// EncodingPrefixedType: EncodingPrefix Type

					s += m_EncodingPrefix.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_Type.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule EncodingPrefixedType

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule EncodingPrefixedType with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			EncodingPrefixedType.production_kind kind = (EncodingPrefixedType.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case EncodingPrefixedType.production_kind.g_EncodingPrefixedType_1:
					// traverse syntax tree node associated with production
					// EncodingPrefixedType: EncodingPrefix Type

						m_EncodingPrefix.Visit (visitor, appData);
						m_Type.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_EncodingPrefix?.reparent (this);
			m_Type?.reparent (this);
		}

		//
		// initialize object associated with syntax rule EncodingPrefixedType
		//

		public void _init ()
		{
			m_EncodingPrefix = null;
			m_Type = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule EncodingPrefixedType

		// counter of all nodes associated with syntax rule EncodingPrefixedType
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule EncodingPrefixedType
		[DataMember (Name = "m_EncodingPrefix")] public EncodingPrefix m_EncodingPrefix { get; private set; }
		[DataMember (Name = "m_Type")] public Type m_Type { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule EncodingPrefixedType

		// delegate function (callback) prototype associated with syntax rule EncodingPrefixedType
		public delegate bool EncodingPrefixedType_Callback (SyntaxTreeCallbackReason reason, EncodingPrefixedType.production_kind kind, EncodingPrefixedType p_EncodingPrefixedType);

		// event associated with syntax rule EncodingPrefixedType
		public event EncodingPrefixedType_Callback EncodingPrefixedType_Event;

		// event trigger associated with syntax rule EncodingPrefixedType
		public bool Raise_EncodingPrefixedType_Event (SyntaxTreeCallbackReason reason, EncodingPrefixedType.production_kind kind, EncodingPrefixedType p_EncodingPrefixedType)
		{
			bool? status = EncodingPrefixedType_Event?.Invoke (reason, kind, p_EncodingPrefixedType);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule EncodingPrefixedType
		//
		// traverse syntax tree node associated with any production of syntax rule EncodingPrefixedType
		//

		public void Traverse (EncodingPrefixedType p_EncodingPrefixedType)
		{
			if (p_EncodingPrefixedType.isLocked())
				return;
			p_EncodingPrefixedType.dolock();
			EncodingPrefixedType.production_kind kind = (EncodingPrefixedType.production_kind) p_EncodingPrefixedType.kind;
			p_EncodingPrefixedType.turn_reset ();
			if (Raise_EncodingPrefixedType_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_EncodingPrefixedType))
			switch (kind)
			{
				case EncodingPrefixedType.production_kind.g_EncodingPrefixedType_1:
					// traverse syntax tree node associated with production
					// EncodingPrefixedType: EncodingPrefix Type

					if (Raise_EncodingPrefixedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EncodingPrefixedType))
						Traverse (p_EncodingPrefixedType.m_EncodingPrefix);
					p_EncodingPrefixedType.turn_inc ();
					if (Raise_EncodingPrefixedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EncodingPrefixedType))
						Traverse (p_EncodingPrefixedType.m_Type);
					p_EncodingPrefixedType.turn_inc ();
					Raise_EncodingPrefixedType_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_EncodingPrefixedType);
				break;
			}
			Raise_EncodingPrefixedType_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_EncodingPrefixedType);
			p_EncodingPrefixedType.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule EncodingPrefixedType
		//

		public void TraverseCommon (EncodingPrefixedType p_EncodingPrefixedType)
		{
			EncodingPrefixedType.production_kind kind = (EncodingPrefixedType.production_kind) p_EncodingPrefixedType.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_EncodingPrefixedType))
			switch (kind)
			{
				case EncodingPrefixedType.production_kind.g_EncodingPrefixedType_1:
					// traverse syntax tree node associated with production
					// EncodingPrefixedType: EncodingPrefix Type

						TraverseCommon (p_EncodingPrefixedType.m_EncodingPrefix);
						TraverseCommon (p_EncodingPrefixedType.m_Type);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_EncodingPrefixedType);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule EncodingPrefixedType

		//
		// create syntax tree node associated with production
		// EncodingPrefixedType: EncodingPrefix Type

		//

		public EncodingPrefixedType EncodingPrefixedType_1 (EncodingPrefix p_EncodingPrefix, Type p_Type)
		{
			EncodingPrefixedType p_EncodingPrefixedType_ref = new EncodingPrefixedType(p_EncodingPrefix, p_Type);
			p_EncodingPrefix.parent = p_EncodingPrefixedType_ref;
			p_Type.parent = p_EncodingPrefixedType_ref;
			Raise_EncodingPrefixedType_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, EncodingPrefixedType.production_kind.g_EncodingPrefixedType_1, p_EncodingPrefixedType_ref);
			return p_EncodingPrefixedType_ref;
		}
		#endregion
	};
}
