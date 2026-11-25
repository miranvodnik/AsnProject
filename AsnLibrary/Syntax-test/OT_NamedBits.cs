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
	// class associated with syntax rule OT-NamedBits
	//

	[DataContract]
	public class	OT_NamedBits : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OT-NamedBits
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OT-NamedBits
		{
			g_OT_NamedBits_1 = 1,	// OT-NamedBit

			g_OT_NamedBits_2 = 2,	// OT-NamedBits "," OT-NamedBit Left

		};
		#endregion
		#region production markers associated with the syntax rule OT-NamedBits

		// markers associated with production: OT-NamedBits -> OT-NamedBit

		public enum production_marker_1 : ushort
		{
			m_OT_NamedBit,
			final
		};

		// markers associated with production: OT-NamedBits -> OT-NamedBits "," OT-NamedBit Left

		public enum production_marker_2 : ushort
		{
			m_OT_NamedBits,
			m_OT_NamedBit,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OT-NamedBits

		// Constructor declaration(s) associated with production(s) of syntax rule OT-NamedBits

		//
		// Constructor associated with the following production(s)
		// OT-NamedBits -> OT-NamedBit

		//

		public OT_NamedBits (OT_NamedBit p_OT_NamedBit) : base ((uint) ProductionID._OT_NamedBits_ID, (uint) production_kind.g_OT_NamedBits_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OT_NamedBit = p_OT_NamedBit;
		}

		//
		// Constructor associated with the following production(s)
		// OT-NamedBits -> OT-NamedBits "," OT-NamedBit Left

		//

		public OT_NamedBits (OT_NamedBits p_OT_NamedBits, SyntaxTreeToken p_token, OT_NamedBit p_OT_NamedBit) : base ((uint) ProductionID._OT_NamedBits_ID, (uint) production_kind.g_OT_NamedBits_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_OT_NamedBits = p_OT_NamedBits;
			children[1] = m_comma = p_token;
			children[2] = m_OT_NamedBit = p_OT_NamedBit;
		}

		public OT_NamedBits () { }

		// Copy constructor

		public OT_NamedBits (OT_NamedBits p_OT_NamedBits) : base (p_OT_NamedBits.id, p_OT_NamedBits.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OT_NamedBits.appInfo;
			switch ((production_kind) p_OT_NamedBits.kind)
			{
				case production_kind.g_OT_NamedBits_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OT_NamedBit = (p_OT_NamedBits.m_OT_NamedBit != null) ? new OT_NamedBit (p_OT_NamedBits.m_OT_NamedBit) : null) != null) m_OT_NamedBit.parent = this;
					break;
				case production_kind.g_OT_NamedBits_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_OT_NamedBits = (p_OT_NamedBits.m_OT_NamedBits != null) ? new OT_NamedBits (p_OT_NamedBits.m_OT_NamedBits) : null) != null) m_OT_NamedBits.parent = this;
					if ((children [1] = m_comma = (p_OT_NamedBits.m_comma != null) ? new SyntaxTreeToken (p_OT_NamedBits.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_OT_NamedBit = (p_OT_NamedBits.m_OT_NamedBit != null) ? new OT_NamedBit (p_OT_NamedBits.m_OT_NamedBit) : null) != null) m_OT_NamedBit.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OT_NamedBits" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OT_NamedBits (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_OT_NamedBit?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OT-NamedBits

		// Content changing function(s) associated with production(s) of syntax rule OT-NamedBits

		//
		// Content changing function associated with following production(s)
		// OT-NamedBits -> OT-NamedBit

		//

		public void change(OT_NamedBit p_OT_NamedBit)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_NamedBits_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OT_NamedBit = p_OT_NamedBit;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OT-NamedBits -> OT-NamedBits "," OT-NamedBit Left

		//

		public void change(OT_NamedBits p_OT_NamedBits, SyntaxTreeToken p_token, OT_NamedBit p_OT_NamedBit)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_NamedBits_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_OT_NamedBits = p_OT_NamedBits;
			children [1] = m_comma = p_token;
			children [2] = m_OT_NamedBit = p_OT_NamedBit;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OT-NamedBits
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_OT_NamedBit != null) && node.m_OT_NamedBit.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OT-NamedBits

		//
		// emit production tree node associated with any production of syntax rule OT-NamedBits
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_OT_NamedBits_1:
						// emit syntax tree node associated with production
						// OT-NamedBits: OT-NamedBit

						s += " " + node.m_OT_NamedBit.Emit (depth - 1);
						break;
					case production_kind.g_OT_NamedBits_2:
						// emit syntax tree node associated with production
						// OT-NamedBits: OT-NamedBits "," OT-NamedBit Left

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_OT_NamedBit.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OT-NamedBits
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "OT_NamedBits (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_OT_NamedBits_1:
						// emit syntax tree node associated with production
						// OT-NamedBits: OT-NamedBit

						str += node.m_OT_NamedBit.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_OT_NamedBits_2:
						// emit syntax tree node associated with production
						// OT-NamedBits: OT-NamedBits "," OT-NamedBit Left

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_OT_NamedBit.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OT-NamedBits

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OT-NamedBits with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					OT_NamedBits.production_kind kind = (OT_NamedBits.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case OT_NamedBits.production_kind.g_OT_NamedBits_1:
							// traverse syntax tree node associated with production
							// OT-NamedBits: OT-NamedBit

							node.m_OT_NamedBit.Visit (visitor, appData);
							break;
						case OT_NamedBits.production_kind.g_OT_NamedBits_2:
							// traverse syntax tree node associated with production
							// OT-NamedBits: OT-NamedBits "," OT-NamedBit Left

							node.m_comma.Visit (visitor, appData);
							node.m_OT_NamedBit.Visit (visitor, appData);
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
			for (OT_NamedBits node = this; node != null; node = node.m_OT_NamedBits)
			{
				node.parent = parent;
				node.m_OT_NamedBit?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule OT-NamedBits
		//

		public void _init ()
		{
			m_OT_NamedBit = null;
			m_OT_NamedBits = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (OT_NamedBits p_OT_NamedBits, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<OT_NamedBits> stack = new Stack<OT_NamedBits> ();
			OT_NamedBits p_OT_NamedBits;
			for (p_OT_NamedBits = this; p_OT_NamedBits != null; p_OT_NamedBits = p_OT_NamedBits.m_OT_NamedBits)
				stack.Push (p_OT_NamedBits);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OT-NamedBits

		// counter of all nodes associated with syntax rule OT-NamedBits
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OT-NamedBits
		[DataMember (Name = "m_OT_NamedBit")] public OT_NamedBit m_OT_NamedBit { get; private set; }
		[DataMember (Name = "m_OT_NamedBits")] public OT_NamedBits m_OT_NamedBits { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OT-NamedBits

		// delegate function (callback) prototype associated with syntax rule OT-NamedBits
		public delegate bool OT_NamedBits_Callback (SyntaxTreeCallbackReason reason, OT_NamedBits.production_kind kind, OT_NamedBits p_OT_NamedBits);

		// event associated with syntax rule OT-NamedBits
		public event OT_NamedBits_Callback OT_NamedBits_Event;

		// event trigger associated with syntax rule OT-NamedBits
		public bool Raise_OT_NamedBits_Event (SyntaxTreeCallbackReason reason, OT_NamedBits.production_kind kind, OT_NamedBits p_OT_NamedBits)
		{
			bool? status = OT_NamedBits_Event?.Invoke (reason, kind, p_OT_NamedBits);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OT-NamedBits
		//
		// traverse syntax tree node associated with any production of syntax rule OT-NamedBits
		//

		public void Traverse (OT_NamedBits p_OT_NamedBits)
		{
			if (p_OT_NamedBits.isLocked())
				return;
			if (Raise_OT_NamedBits_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (OT_NamedBits.production_kind) p_OT_NamedBits.kind, p_OT_NamedBits))
				p_OT_NamedBits.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					OT_NamedBits.production_kind kind = (OT_NamedBits.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_OT_NamedBits_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case OT_NamedBits.production_kind.g_OT_NamedBits_1:
								// traverse syntax tree node associated with production
								// OT-NamedBits: OT-NamedBit

								if (Raise_OT_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_OT_NamedBit);
								node.turn_inc ();
								Raise_OT_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case OT_NamedBits.production_kind.g_OT_NamedBits_2:
								// traverse syntax tree node associated with production
								// OT-NamedBits: OT-NamedBits "," OT-NamedBit Left

								if (Raise_OT_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_OT_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_OT_NamedBit);
								node.turn_inc ();
								Raise_OT_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_OT_NamedBits_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_OT_NamedBits_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (OT_NamedBits.production_kind) p_OT_NamedBits.kind, p_OT_NamedBits);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OT-NamedBits
		//

		public void TraverseCommon (OT_NamedBits p_OT_NamedBits)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_OT_NamedBits.kind, p_OT_NamedBits))
				p_OT_NamedBits.Iterate (null, (node, appData) =>
				{
					OT_NamedBits.production_kind kind = (OT_NamedBits.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case OT_NamedBits.production_kind.g_OT_NamedBits_1:
							// traverse syntax tree node associated with production
							// OT-NamedBits: OT-NamedBit

							TraverseCommon (node.m_OT_NamedBit);
							break;
						case OT_NamedBits.production_kind.g_OT_NamedBits_2:
							// traverse syntax tree node associated with production
							// OT-NamedBits: OT-NamedBits "," OT-NamedBit Left

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_OT_NamedBit);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_OT_NamedBits.kind, p_OT_NamedBits);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OT-NamedBits

		//
		// create syntax tree node associated with production
		// OT-NamedBits: OT-NamedBit

		//

		public OT_NamedBits OT_NamedBits_1 (OT_NamedBit p_OT_NamedBit)
		{
			OT_NamedBits p_OT_NamedBits_ref = new OT_NamedBits(p_OT_NamedBit);
			p_OT_NamedBit.parent = p_OT_NamedBits_ref;
			Raise_OT_NamedBits_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_NamedBits.production_kind.g_OT_NamedBits_1, p_OT_NamedBits_ref);
			return p_OT_NamedBits_ref;
		}

		//
		// create syntax tree node associated with production
		// OT-NamedBits: OT-NamedBits "," OT-NamedBit Left

		//

		public OT_NamedBits OT_NamedBits_2 (OT_NamedBits p_OT_NamedBits, SyntaxTreeToken p_token, OT_NamedBit p_OT_NamedBit)
		{
			OT_NamedBits p_OT_NamedBits_ref = new OT_NamedBits(p_OT_NamedBits, p_token, p_OT_NamedBit);
			p_OT_NamedBits.parent = p_OT_NamedBits_ref;
			p_token.parent = p_OT_NamedBits_ref;
			p_OT_NamedBit.parent = p_OT_NamedBits_ref;
			Raise_OT_NamedBits_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_NamedBits.production_kind.g_OT_NamedBits_2, p_OT_NamedBits_ref);
			return p_OT_NamedBits_ref;
		}
		#endregion
	};
}
