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
	// class associated with syntax rule OG-Objects
	//

	[DataContract]
	public class	OG_Objects : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OG-Objects
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OG-Objects
		{
			g_OG_Objects_1 = 1,	// OG-Object

			g_OG_Objects_2 = 2,	// OG-Objects "," OG-Object Left

		};
		#endregion
		#region production markers associated with the syntax rule OG-Objects

		// markers associated with production: OG-Objects -> OG-Object

		public enum production_marker_1 : ushort
		{
			m_OG_Object,
			final
		};

		// markers associated with production: OG-Objects -> OG-Objects "," OG-Object Left

		public enum production_marker_2 : ushort
		{
			m_OG_Objects,
			m_OG_Object,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OG-Objects

		// Constructor declaration(s) associated with production(s) of syntax rule OG-Objects

		//
		// Constructor associated with the following production(s)
		// OG-Objects -> OG-Object

		//

		public OG_Objects (OG_Object p_OG_Object) : base ((uint) ProductionID._OG_Objects_ID, (uint) production_kind.g_OG_Objects_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OG_Object = p_OG_Object;
		}

		//
		// Constructor associated with the following production(s)
		// OG-Objects -> OG-Objects "," OG-Object Left

		//

		public OG_Objects (OG_Objects p_OG_Objects, SyntaxTreeToken p_token, OG_Object p_OG_Object) : base ((uint) ProductionID._OG_Objects_ID, (uint) production_kind.g_OG_Objects_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_OG_Objects = p_OG_Objects;
			children[1] = m_comma = p_token;
			children[2] = m_OG_Object = p_OG_Object;
		}

		public OG_Objects () { }

		// Copy constructor

		public OG_Objects (OG_Objects p_OG_Objects) : base (p_OG_Objects.id, p_OG_Objects.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OG_Objects.appInfo;
			switch ((production_kind) p_OG_Objects.kind)
			{
				case production_kind.g_OG_Objects_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OG_Object = (p_OG_Objects.m_OG_Object != null) ? new OG_Object (p_OG_Objects.m_OG_Object) : null) != null) m_OG_Object.parent = this;
					break;
				case production_kind.g_OG_Objects_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_OG_Objects = (p_OG_Objects.m_OG_Objects != null) ? new OG_Objects (p_OG_Objects.m_OG_Objects) : null) != null) m_OG_Objects.parent = this;
					if ((children [1] = m_comma = (p_OG_Objects.m_comma != null) ? new SyntaxTreeToken (p_OG_Objects.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_OG_Object = (p_OG_Objects.m_OG_Object != null) ? new OG_Object (p_OG_Objects.m_OG_Object) : null) != null) m_OG_Object.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OG_Objects" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OG_Objects (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_OG_Object?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OG-Objects

		// Content changing function(s) associated with production(s) of syntax rule OG-Objects

		//
		// Content changing function associated with following production(s)
		// OG-Objects -> OG-Object

		//

		public void change(OG_Object p_OG_Object)
		{
			_init ();
			this.kind = (uint) production_kind.g_OG_Objects_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OG_Object = p_OG_Object;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OG-Objects -> OG-Objects "," OG-Object Left

		//

		public void change(OG_Objects p_OG_Objects, SyntaxTreeToken p_token, OG_Object p_OG_Object)
		{
			_init ();
			this.kind = (uint) production_kind.g_OG_Objects_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_OG_Objects = p_OG_Objects;
			children [1] = m_comma = p_token;
			children [2] = m_OG_Object = p_OG_Object;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OG-Objects
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_OG_Object != null) && node.m_OG_Object.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OG-Objects

		//
		// emit production tree node associated with any production of syntax rule OG-Objects
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_OG_Objects_1:
						// emit syntax tree node associated with production
						// OG-Objects: OG-Object

						s += " " + node.m_OG_Object.Emit (depth - 1);
						break;
					case production_kind.g_OG_Objects_2:
						// emit syntax tree node associated with production
						// OG-Objects: OG-Objects "," OG-Object Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_OG_Object.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OG-Objects
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "OG_Objects (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_OG_Objects_1:
						// emit syntax tree node associated with production
						// OG-Objects: OG-Object

						str += node.m_OG_Object.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_OG_Objects_2:
						// emit syntax tree node associated with production
						// OG-Objects: OG-Objects "," OG-Object Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_OG_Object.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OG-Objects

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OG-Objects with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					OG_Objects.production_kind kind = (OG_Objects.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case OG_Objects.production_kind.g_OG_Objects_1:
							// traverse syntax tree node associated with production
							// OG-Objects: OG-Object

							node.m_OG_Object.Visit (visitor, appData);
							break;
						case OG_Objects.production_kind.g_OG_Objects_2:
							// traverse syntax tree node associated with production
							// OG-Objects: OG-Objects "," OG-Object Left

							node.m_comma.Visit (visitor, appData);
							node.m_OG_Object.Visit (visitor, appData);
							break;
						}
					visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node, appData);
					return null;
				});
			visitor (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) this.kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			for (OG_Objects node = this; node != null; node = node.m_OG_Objects)
			{
				node.parent = parent;
				node.m_OG_Object?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule OG-Objects
		//

		public void _init ()
		{
			m_OG_Object = null;
			m_OG_Objects = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (OG_Objects p_OG_Objects, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<OG_Objects> stack = new Stack<OG_Objects> ();
			OG_Objects p_OG_Objects;
			for (p_OG_Objects = this; p_OG_Objects != null; p_OG_Objects = p_OG_Objects.m_OG_Objects)
				stack.Push (p_OG_Objects);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OG-Objects

		// counter of all nodes associated with syntax rule OG-Objects
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OG-Objects
		[DataMember (Name = "m_OG_Object")] public OG_Object m_OG_Object { get; private set; }
		[DataMember (Name = "m_OG_Objects")] public OG_Objects m_OG_Objects { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OG-Objects

		// delegate function (callback) prototype associated with syntax rule OG-Objects
		public delegate bool OG_Objects_Callback (SyntaxTreeCallbackReason reason, OG_Objects.production_kind kind, OG_Objects p_OG_Objects);

		// event associated with syntax rule OG-Objects
		public event OG_Objects_Callback OG_Objects_Event;

		// event trigger associated with syntax rule OG-Objects
		public bool Raise_OG_Objects_Event (SyntaxTreeCallbackReason reason, OG_Objects.production_kind kind, OG_Objects p_OG_Objects)
		{
			bool? status = OG_Objects_Event?.Invoke (reason, kind, p_OG_Objects);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OG-Objects
		//
		// traverse syntax tree node associated with any production of syntax rule OG-Objects
		//

		public void Traverse (OG_Objects p_OG_Objects)
		{
			if (p_OG_Objects.isLocked())
				return;
			if (Raise_OG_Objects_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (OG_Objects.production_kind) p_OG_Objects.kind, p_OG_Objects))
				p_OG_Objects.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					OG_Objects.production_kind kind = (OG_Objects.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_OG_Objects_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case OG_Objects.production_kind.g_OG_Objects_1:
								// traverse syntax tree node associated with production
								// OG-Objects: OG-Object

								if (Raise_OG_Objects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_OG_Object);
								node.turn_inc ();
								Raise_OG_Objects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case OG_Objects.production_kind.g_OG_Objects_2:
								// traverse syntax tree node associated with production
								// OG-Objects: OG-Objects "," OG-Object Left

								if (Raise_OG_Objects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_OG_Objects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_OG_Object);
								node.turn_inc ();
								Raise_OG_Objects_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_OG_Objects_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_OG_Objects_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (OG_Objects.production_kind) p_OG_Objects.kind, p_OG_Objects);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OG-Objects
		//

		public void TraverseCommon (OG_Objects p_OG_Objects)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_OG_Objects.kind, p_OG_Objects))
				p_OG_Objects.Iterate (null, (node, appData) =>
				{
					OG_Objects.production_kind kind = (OG_Objects.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case OG_Objects.production_kind.g_OG_Objects_1:
							// traverse syntax tree node associated with production
							// OG-Objects: OG-Object

							TraverseCommon (node.m_OG_Object);
							break;
						case OG_Objects.production_kind.g_OG_Objects_2:
							// traverse syntax tree node associated with production
							// OG-Objects: OG-Objects "," OG-Object Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_OG_Object);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_OG_Objects.kind, p_OG_Objects);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OG-Objects

		//
		// create syntax tree node associated with production
		// OG-Objects: OG-Object

		//

		public OG_Objects OG_Objects_1 (OG_Object p_OG_Object)
		{
			OG_Objects p_OG_Objects_ref = new OG_Objects(p_OG_Object);
			p_OG_Object.parent = p_OG_Objects_ref;
			Raise_OG_Objects_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OG_Objects.production_kind.g_OG_Objects_1, p_OG_Objects_ref);
			return p_OG_Objects_ref;
		}

		//
		// create syntax tree node associated with production
		// OG-Objects: OG-Objects "," OG-Object Left

		//

		public OG_Objects OG_Objects_2 (OG_Objects p_OG_Objects, SyntaxTreeToken p_token, OG_Object p_OG_Object)
		{
			OG_Objects p_OG_Objects_ref = new OG_Objects(p_OG_Objects, p_token, p_OG_Object);
			p_OG_Objects.parent = p_OG_Objects_ref;
			p_token.parent = p_OG_Objects_ref;
			p_OG_Object.parent = p_OG_Objects_ref;
			Raise_OG_Objects_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OG_Objects.production_kind.g_OG_Objects_2, p_OG_Objects_ref);
			return p_OG_Objects_ref;
		}
		#endregion
	};
}
