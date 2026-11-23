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
	// class associated with syntax rule TC-NamedBits
	//

	[DataContract]
	public class	TC_NamedBits : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule TC-NamedBits
		public enum production_kind : ushort	// enumerated production(s) of syntax rule TC-NamedBits
		{
			g_TC_NamedBits_1 = 1,	// TC-NamedBit

			g_TC_NamedBits_2 = 2,	// TC-NamedBits "," TC-NamedBit

		};
		#endregion
		#region production markers associated with the syntax rule TC-NamedBits

		// markers associated with production: TC-NamedBits -> TC-NamedBit

		public enum production_marker_1 : ushort
		{
			m_TC_NamedBit,
			final
		};

		// markers associated with production: TC-NamedBits -> TC-NamedBits "," TC-NamedBit

		public enum production_marker_2 : ushort
		{
			m_TC_NamedBits,
			m_TC_NamedBit,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule TC-NamedBits

		// Constructor declaration(s) associated with production(s) of syntax rule TC-NamedBits

		//
		// Constructor associated with the following production(s)
		// TC-NamedBits -> TC-NamedBit

		//

		public TC_NamedBits (TC_NamedBit p_TC_NamedBit) : base ((uint) ProductionID._TC_NamedBits_ID, (uint) production_kind.g_TC_NamedBits_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_TC_NamedBit = p_TC_NamedBit;
		}

		//
		// Constructor associated with the following production(s)
		// TC-NamedBits -> TC-NamedBits "," TC-NamedBit

		//

		public TC_NamedBits (TC_NamedBits p_TC_NamedBits, SyntaxTreeToken p_token, TC_NamedBit p_TC_NamedBit) : base ((uint) ProductionID._TC_NamedBits_ID, (uint) production_kind.g_TC_NamedBits_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_TC_NamedBits = p_TC_NamedBits;
			children[1] = m_comma = p_token;
			children[2] = m_TC_NamedBit = p_TC_NamedBit;
		}

		public TC_NamedBits () { }

		// Copy constructor

		public TC_NamedBits (TC_NamedBits p_TC_NamedBits) : base (p_TC_NamedBits.id, p_TC_NamedBits.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_TC_NamedBits.appInfo;
			switch ((production_kind) p_TC_NamedBits.kind)
			{
				case production_kind.g_TC_NamedBits_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_TC_NamedBit = (p_TC_NamedBits.m_TC_NamedBit != null) ? new TC_NamedBit (p_TC_NamedBits.m_TC_NamedBit) : null) != null) m_TC_NamedBit.parent = this;
					break;
				case production_kind.g_TC_NamedBits_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_TC_NamedBits = (p_TC_NamedBits.m_TC_NamedBits != null) ? new TC_NamedBits (p_TC_NamedBits.m_TC_NamedBits) : null) != null) m_TC_NamedBits.parent = this;
					if ((children [1] = m_comma = (p_TC_NamedBits.m_comma != null) ? new SyntaxTreeToken (p_TC_NamedBits.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_TC_NamedBit = (p_TC_NamedBits.m_TC_NamedBit != null) ? new TC_NamedBit (p_TC_NamedBits.m_TC_NamedBit) : null) != null) m_TC_NamedBit.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "TC_NamedBits" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new TC_NamedBits (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_TC_NamedBit?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule TC-NamedBits

		// Content changing function(s) associated with production(s) of syntax rule TC-NamedBits

		//
		// Content changing function associated with following production(s)
		// TC-NamedBits -> TC-NamedBit

		//

		public void change(TC_NamedBit p_TC_NamedBit)
		{
			_init ();
			this.kind = (uint) production_kind.g_TC_NamedBits_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_TC_NamedBit = p_TC_NamedBit;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// TC-NamedBits -> TC-NamedBits "," TC-NamedBit

		//

		public void change(TC_NamedBits p_TC_NamedBits, SyntaxTreeToken p_token, TC_NamedBit p_TC_NamedBit)
		{
			_init ();
			this.kind = (uint) production_kind.g_TC_NamedBits_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_TC_NamedBits = p_TC_NamedBits;
			children [1] = m_comma = p_token;
			children [2] = m_TC_NamedBit = p_TC_NamedBit;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule TC-NamedBits
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_TC_NamedBit != null) && node.m_TC_NamedBit.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule TC-NamedBits

		//
		// emit production tree node associated with any production of syntax rule TC-NamedBits
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_TC_NamedBits_1:
						// emit syntax tree node associated with production
						// TC-NamedBits: TC-NamedBit

						s += " " + node.m_TC_NamedBit.Emit (depth - 1);
						break;
					case production_kind.g_TC_NamedBits_2:
						// emit syntax tree node associated with production
						// TC-NamedBits: TC-NamedBits "," TC-NamedBit

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_TC_NamedBit.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule TC-NamedBits
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "TC_NamedBits (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_TC_NamedBits_1:
						// emit syntax tree node associated with production
						// TC-NamedBits: TC-NamedBit

						str += node.m_TC_NamedBit.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_TC_NamedBits_2:
						// emit syntax tree node associated with production
						// TC-NamedBits: TC-NamedBits "," TC-NamedBit

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_TC_NamedBit.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule TC-NamedBits

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule TC-NamedBits with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					TC_NamedBits.production_kind kind = (TC_NamedBits.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case TC_NamedBits.production_kind.g_TC_NamedBits_1:
							// traverse syntax tree node associated with production
							// TC-NamedBits: TC-NamedBit

							node.m_TC_NamedBit.Visit (visitor, appData);
							break;
						case TC_NamedBits.production_kind.g_TC_NamedBits_2:
							// traverse syntax tree node associated with production
							// TC-NamedBits: TC-NamedBits "," TC-NamedBit

							node.m_comma.Visit (visitor, appData);
							node.m_TC_NamedBit.Visit (visitor, appData);
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
			for (TC_NamedBits node = this; node != null; node = node.m_TC_NamedBits)
			{
				node.parent = parent;
				node.m_TC_NamedBit?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule TC-NamedBits
		//

		public void _init ()
		{
			m_TC_NamedBit = null;
			m_TC_NamedBits = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (TC_NamedBits p_TC_NamedBits, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<TC_NamedBits> stack = new Stack<TC_NamedBits> ();
			TC_NamedBits p_TC_NamedBits;
			for (p_TC_NamedBits = this; p_TC_NamedBits != null; p_TC_NamedBits = p_TC_NamedBits.m_TC_NamedBits)
				stack.Push (p_TC_NamedBits);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule TC-NamedBits

		// counter of all nodes associated with syntax rule TC-NamedBits
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule TC-NamedBits
		[DataMember (Name = "m_TC_NamedBit")] public TC_NamedBit m_TC_NamedBit { get; private set; }
		[DataMember (Name = "m_TC_NamedBits")] public TC_NamedBits m_TC_NamedBits { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule TC-NamedBits

		// delegate function (callback) prototype associated with syntax rule TC-NamedBits
		public delegate bool TC_NamedBits_Callback (SyntaxTreeCallbackReason reason, TC_NamedBits.production_kind kind, TC_NamedBits p_TC_NamedBits);

		// event associated with syntax rule TC-NamedBits
		public event TC_NamedBits_Callback TC_NamedBits_Event;

		// event trigger associated with syntax rule TC-NamedBits
		public bool Raise_TC_NamedBits_Event (SyntaxTreeCallbackReason reason, TC_NamedBits.production_kind kind, TC_NamedBits p_TC_NamedBits)
		{
			bool? status = TC_NamedBits_Event?.Invoke (reason, kind, p_TC_NamedBits);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule TC-NamedBits
		//
		// traverse syntax tree node associated with any production of syntax rule TC-NamedBits
		//

		public void Traverse (TC_NamedBits p_TC_NamedBits)
		{
			if (p_TC_NamedBits.isLocked())
				return;
			if (Raise_TC_NamedBits_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (TC_NamedBits.production_kind) p_TC_NamedBits.kind, p_TC_NamedBits))
				p_TC_NamedBits.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					TC_NamedBits.production_kind kind = (TC_NamedBits.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_TC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case TC_NamedBits.production_kind.g_TC_NamedBits_1:
								// traverse syntax tree node associated with production
								// TC-NamedBits: TC-NamedBit

								if (Raise_TC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_TC_NamedBit);
								node.turn_inc ();
								Raise_TC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case TC_NamedBits.production_kind.g_TC_NamedBits_2:
								// traverse syntax tree node associated with production
								// TC-NamedBits: TC-NamedBits "," TC-NamedBit

								if (Raise_TC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_TC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_TC_NamedBit);
								node.turn_inc ();
								Raise_TC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_TC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_TC_NamedBits_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (TC_NamedBits.production_kind) p_TC_NamedBits.kind, p_TC_NamedBits);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule TC-NamedBits
		//

		public void TraverseCommon (TC_NamedBits p_TC_NamedBits)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_TC_NamedBits.kind, p_TC_NamedBits))
				p_TC_NamedBits.Iterate (null, (node, appData) =>
				{
					TC_NamedBits.production_kind kind = (TC_NamedBits.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case TC_NamedBits.production_kind.g_TC_NamedBits_1:
							// traverse syntax tree node associated with production
							// TC-NamedBits: TC-NamedBit

							TraverseCommon (node.m_TC_NamedBit);
							break;
						case TC_NamedBits.production_kind.g_TC_NamedBits_2:
							// traverse syntax tree node associated with production
							// TC-NamedBits: TC-NamedBits "," TC-NamedBit

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_TC_NamedBit);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_TC_NamedBits.kind, p_TC_NamedBits);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule TC-NamedBits

		//
		// create syntax tree node associated with production
		// TC-NamedBits: TC-NamedBit

		//

		public TC_NamedBits TC_NamedBits_1 (TC_NamedBit p_TC_NamedBit)
		{
			TC_NamedBits p_TC_NamedBits_ref = new TC_NamedBits(p_TC_NamedBit);
			p_TC_NamedBit.parent = p_TC_NamedBits_ref;
			Raise_TC_NamedBits_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TC_NamedBits.production_kind.g_TC_NamedBits_1, p_TC_NamedBits_ref);
			return p_TC_NamedBits_ref;
		}

		//
		// create syntax tree node associated with production
		// TC-NamedBits: TC-NamedBits "," TC-NamedBit

		//

		public TC_NamedBits TC_NamedBits_2 (TC_NamedBits p_TC_NamedBits, SyntaxTreeToken p_token, TC_NamedBit p_TC_NamedBit)
		{
			TC_NamedBits p_TC_NamedBits_ref = new TC_NamedBits(p_TC_NamedBits, p_token, p_TC_NamedBit);
			p_TC_NamedBits.parent = p_TC_NamedBits_ref;
			p_token.parent = p_TC_NamedBits_ref;
			p_TC_NamedBit.parent = p_TC_NamedBits_ref;
			Raise_TC_NamedBits_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, TC_NamedBits.production_kind.g_TC_NamedBits_2, p_TC_NamedBits_ref);
			return p_TC_NamedBits_ref;
		}
		#endregion
	};
}
