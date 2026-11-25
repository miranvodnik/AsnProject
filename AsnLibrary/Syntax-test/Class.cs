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
	// class associated with syntax rule Class
	//

	[DataContract]
	public class	Class : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule Class
		public enum production_kind : ushort	// enumerated production(s) of syntax rule Class
		{
			g_Class_1 = 1,	// UNIVERSAL

			g_Class_2 = 2,	// APPLICATION

			g_Class_3 = 3,	// PRIVATE

			g_Class_4 = 4,	// %empty

		};
		#endregion
		#region production markers associated with the syntax rule Class

		// markers associated with production: Class -> UNIVERSAL

		public enum production_marker_1 : ushort
		{
			final
		};

		// markers associated with production: Class -> APPLICATION

		public enum production_marker_2 : ushort
		{
			final
		};

		// markers associated with production: Class -> PRIVATE

		public enum production_marker_3 : ushort
		{
			final
		};

		// markers associated with production: Class -> %empty

		public enum production_marker_4 : ushort
		{
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule Class

		// Constructor declaration(s) associated with production(s) of syntax rule Class

		//
		// Constructor associated with the following production(s)
		// Class -> UNIVERSAL

		// Class -> APPLICATION

		// Class -> PRIVATE

		//

		public Class (SyntaxTreeToken p_token, int kind) : base ((uint) ProductionID._Class_ID, (uint) kind)
		{
			++g_counter;
			_init ();
			switch ((production_kind) this.kind)
			{
			case production_kind.g_Class_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_UNIVERSAL = p_token;
				break;
			case production_kind.g_Class_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_APPLICATION = p_token;
				break;
			case production_kind.g_Class_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children[0] = m_PRIVATE = p_token;
				break;
			default:
				{
					string[] args = new string[] { "Class" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		//
		// Constructor associated with the following production(s)
		// Class -> %empty

		//

		public Class () : base ((uint) ProductionID._Class_ID, (uint) production_kind.g_Class_4)
		{
			++g_counter;
			_init ();
			children = Array.Empty <SyntaxTreeBase> ();
		}

		// Copy constructor

		public Class (Class p_Class) : base (p_Class.id, p_Class.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_Class.appInfo;
			switch ((production_kind) p_Class.kind)
			{
				case production_kind.g_Class_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_UNIVERSAL = (p_Class.m_UNIVERSAL != null) ? new SyntaxTreeToken (p_Class.m_UNIVERSAL) : null) != null) m_UNIVERSAL.parent = this;
					break;
				case production_kind.g_Class_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_APPLICATION = (p_Class.m_APPLICATION != null) ? new SyntaxTreeToken (p_Class.m_APPLICATION) : null) != null) m_APPLICATION.parent = this;
					break;
				case production_kind.g_Class_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_PRIVATE = (p_Class.m_PRIVATE != null) ? new SyntaxTreeToken (p_Class.m_PRIVATE) : null) != null) m_PRIVATE.parent = this;
					break;
				case production_kind.g_Class_4:
					children = Array.Empty <SyntaxTreeBase> ();
					break;
				default:
				{
					string[] args = new string[] { "Class" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new Class (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_UNIVERSAL?.Dispose ();
			m_APPLICATION?.Dispose ();
			m_PRIVATE?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule Class

		// Content changing function(s) associated with production(s) of syntax rule Class

		//
		// Content changing function associated with following production(s)
		// Class -> UNIVERSAL

		// Class -> APPLICATION

		// Class -> PRIVATE

		//

		public void change(SyntaxTreeToken p_token, int kind)
		{
			_init ();
			this.kind = (uint) kind;
			switch ((production_kind) this.kind)
			{
			case production_kind.g_Class_1:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_UNIVERSAL = p_token;
				break;
			case production_kind.g_Class_2:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_APPLICATION = p_token;
				break;
			case production_kind.g_Class_3:
				children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
				children [0] = m_PRIVATE = p_token;
				break;
			default:
				{
					string[] args = new string[] { "Class" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// Class -> %empty

		//

		public void change()
		{
			_init ();
			this.kind = (uint) production_kind.g_Class_4;
			children = Array.Empty <SyntaxTreeBase> ();
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule Class
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_UNIVERSAL != null) && m_UNIVERSAL.checkInclusion (element) ||
				(m_APPLICATION != null) && m_APPLICATION.checkInclusion (element) ||
				(m_PRIVATE != null) && m_PRIVATE.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule Class

		//
		// emit production tree node associated with any production of syntax rule Class
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_Class_1:
					// emit syntax tree node associated with production
					// Class: UNIVERSAL

					s += m_UNIVERSAL.Emit (depth - 1);
				break;
				case production_kind.g_Class_2:
					// emit syntax tree node associated with production
					// Class: APPLICATION

					s += m_APPLICATION.Emit (depth - 1);
				break;
				case production_kind.g_Class_3:
					// emit syntax tree node associated with production
					// Class: PRIVATE

					s += m_PRIVATE.Emit (depth - 1);
				break;
				case production_kind.g_Class_4:
					// emit syntax tree node associated with production
					// Class: %empty

				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule Class
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "Class (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_Class_1:
					// emit syntax tree node associated with production
					// Class: UNIVERSAL

					s += "UNIVERSAL";
				break;
				case production_kind.g_Class_2:
					// emit syntax tree node associated with production
					// Class: APPLICATION

					s += "APPLICATION";
				break;
				case production_kind.g_Class_3:
					// emit syntax tree node associated with production
					// Class: PRIVATE

					s += "PRIVATE";
				break;
				case production_kind.g_Class_4:
					// emit syntax tree node associated with production
					// Class: %empty

				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule Class

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule Class with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			Class.production_kind kind = (Class.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case Class.production_kind.g_Class_1:
					// traverse syntax tree node associated with production
					// Class: UNIVERSAL

						m_UNIVERSAL.Visit (visitor, appData);
				break;
				case Class.production_kind.g_Class_2:
					// traverse syntax tree node associated with production
					// Class: APPLICATION

						m_APPLICATION.Visit (visitor, appData);
				break;
				case Class.production_kind.g_Class_3:
					// traverse syntax tree node associated with production
					// Class: PRIVATE

						m_PRIVATE.Visit (visitor, appData);
				break;
				case Class.production_kind.g_Class_4:
					// traverse syntax tree node associated with production
					// Class: %empty

				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_UNIVERSAL?.reparent (this);
			m_APPLICATION?.reparent (this);
			m_PRIVATE?.reparent (this);
		}

		//
		// initialize object associated with syntax rule Class
		//

		public void _init ()
		{
			m_UNIVERSAL = null;
			m_APPLICATION = null;
			m_PRIVATE = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule Class

		// counter of all nodes associated with syntax rule Class
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule Class
		[DataMember (Name = "m_UNIVERSAL")] public SyntaxTreeToken m_UNIVERSAL { get; private set; }
		[DataMember (Name = "m_APPLICATION")] public SyntaxTreeToken m_APPLICATION { get; private set; }
		[DataMember (Name = "m_PRIVATE")] public SyntaxTreeToken m_PRIVATE { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule Class

		// delegate function (callback) prototype associated with syntax rule Class
		public delegate bool Class_Callback (SyntaxTreeCallbackReason reason, Class.production_kind kind, Class p_Class);

		// event associated with syntax rule Class
		public event Class_Callback Class_Event;

		// event trigger associated with syntax rule Class
		public bool Raise_Class_Event (SyntaxTreeCallbackReason reason, Class.production_kind kind, Class p_Class)
		{
			bool? status = Class_Event?.Invoke (reason, kind, p_Class);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule Class
		//
		// traverse syntax tree node associated with any production of syntax rule Class
		//

		public void Traverse (Class p_Class)
		{
			if (p_Class.isLocked())
				return;
			p_Class.dolock();
			Class.production_kind kind = (Class.production_kind) p_Class.kind;
			p_Class.turn_reset ();
			if (Raise_Class_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_Class))
			switch (kind)
			{
				case Class.production_kind.g_Class_1:
					// traverse syntax tree node associated with production
					// Class: UNIVERSAL

				break;
				case Class.production_kind.g_Class_2:
					// traverse syntax tree node associated with production
					// Class: APPLICATION

				break;
				case Class.production_kind.g_Class_3:
					// traverse syntax tree node associated with production
					// Class: PRIVATE

				break;
				case Class.production_kind.g_Class_4:
					// traverse syntax tree node associated with production
					// Class: %empty

				break;
			}
			Raise_Class_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_Class);
			p_Class.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule Class
		//

		public void TraverseCommon (Class p_Class)
		{
			Class.production_kind kind = (Class.production_kind) p_Class.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_Class))
			switch (kind)
			{
				case Class.production_kind.g_Class_1:
					// traverse syntax tree node associated with production
					// Class: UNIVERSAL

						TraverseCommon (p_Class.m_UNIVERSAL);
				break;
				case Class.production_kind.g_Class_2:
					// traverse syntax tree node associated with production
					// Class: APPLICATION

						TraverseCommon (p_Class.m_APPLICATION);
				break;
				case Class.production_kind.g_Class_3:
					// traverse syntax tree node associated with production
					// Class: PRIVATE

						TraverseCommon (p_Class.m_PRIVATE);
				break;
				case Class.production_kind.g_Class_4:
					// traverse syntax tree node associated with production
					// Class: %empty

				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_Class);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule Class

		//
		// create syntax tree node associated with production
		// Class: UNIVERSAL

		//

		public Class Class_1 (SyntaxTreeToken p_token)
		{
			Class p_Class_ref = new Class(p_token, 1);
			p_token.parent = p_Class_ref;
			Raise_Class_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Class.production_kind.g_Class_1, p_Class_ref);
			return p_Class_ref;
		}

		//
		// create syntax tree node associated with production
		// Class: APPLICATION

		//

		public Class Class_2 (SyntaxTreeToken p_token)
		{
			Class p_Class_ref = new Class(p_token, 2);
			p_token.parent = p_Class_ref;
			Raise_Class_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Class.production_kind.g_Class_2, p_Class_ref);
			return p_Class_ref;
		}

		//
		// create syntax tree node associated with production
		// Class: PRIVATE

		//

		public Class Class_3 (SyntaxTreeToken p_token)
		{
			Class p_Class_ref = new Class(p_token, 3);
			p_token.parent = p_Class_ref;
			Raise_Class_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Class.production_kind.g_Class_3, p_Class_ref);
			return p_Class_ref;
		}

		//
		// create syntax tree node associated with production
		// Class: %empty

		//

		public Class Class_4 ()
		{
			Class p_Class_ref = new Class();
			Raise_Class_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, Class.production_kind.g_Class_4, p_Class_ref);
			return p_Class_ref;
		}
		#endregion
	};
}
