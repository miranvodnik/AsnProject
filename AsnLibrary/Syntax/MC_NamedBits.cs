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
	// class associated with syntax rule MC-NamedBits
	//

	[DataContract]
	public class	MC_NamedBits : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule MC-NamedBits
		public enum production_kind : ushort	// enumerated production(s) of syntax rule MC-NamedBits
		{
			g_MC_NamedBits_1 = 1,	// MC-NamedBit

			g_MC_NamedBits_2 = 2,	// MC-NamedBits "," MC-NamedBit

		};
		#endregion
		#region production markers associated with the syntax rule MC-NamedBits

		// markers associated with production: MC-NamedBits -> MC-NamedBit

		public enum production_marker_1 : ushort
		{
			m_MC_NamedBit,
			final
		};

		// markers associated with production: MC-NamedBits -> MC-NamedBits "," MC-NamedBit

		public enum production_marker_2 : ushort
		{
			m_MC_NamedBits,
			m_MC_NamedBit,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule MC-NamedBits

		// Constructor declaration(s) associated with production(s) of syntax rule MC-NamedBits

		//
		// Constructor associated with the following production(s)
		// MC-NamedBits -> MC-NamedBit

		//

		public MC_NamedBits (MC_NamedBit p_MC_NamedBit) : base ((uint) ProductionID._MC_NamedBits_ID, (uint) production_kind.g_MC_NamedBits_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_MC_NamedBit = p_MC_NamedBit;
		}

		//
		// Constructor associated with the following production(s)
		// MC-NamedBits -> MC-NamedBits "," MC-NamedBit

		//

		public MC_NamedBits (MC_NamedBits p_MC_NamedBits, SyntaxTreeToken p_token, MC_NamedBit p_MC_NamedBit) : base ((uint) ProductionID._MC_NamedBits_ID, (uint) production_kind.g_MC_NamedBits_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_MC_NamedBits = p_MC_NamedBits;
			children[1] = m_comma = p_token;
			children[2] = m_MC_NamedBit = p_MC_NamedBit;
		}

		public MC_NamedBits () { }

		// Copy constructor

		public MC_NamedBits (MC_NamedBits p_MC_NamedBits) : base (p_MC_NamedBits.id, p_MC_NamedBits.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_MC_NamedBits.appInfo;
			switch ((production_kind) p_MC_NamedBits.kind)
			{
				case production_kind.g_MC_NamedBits_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_MC_NamedBit = (p_MC_NamedBits.m_MC_NamedBit != null) ? new MC_NamedBit (p_MC_NamedBits.m_MC_NamedBit) : null) != null) m_MC_NamedBit.parent = this;
					break;
				case production_kind.g_MC_NamedBits_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_MC_NamedBits = (p_MC_NamedBits.m_MC_NamedBits != null) ? new MC_NamedBits (p_MC_NamedBits.m_MC_NamedBits) : null) != null) m_MC_NamedBits.parent = this;
					if ((children [1] = m_comma = (p_MC_NamedBits.m_comma != null) ? new SyntaxTreeToken (p_MC_NamedBits.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_MC_NamedBit = (p_MC_NamedBits.m_MC_NamedBit != null) ? new MC_NamedBit (p_MC_NamedBits.m_MC_NamedBit) : null) != null) m_MC_NamedBit.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "MC_NamedBits" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new MC_NamedBits (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_MC_NamedBit?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule MC-NamedBits

		// Content changing function(s) associated with production(s) of syntax rule MC-NamedBits

		//
		// Content changing function associated with following production(s)
		// MC-NamedBits -> MC-NamedBit

		//

		public void change(MC_NamedBit p_MC_NamedBit)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_NamedBits_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_MC_NamedBit = p_MC_NamedBit;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// MC-NamedBits -> MC-NamedBits "," MC-NamedBit

		//

		public void change(MC_NamedBits p_MC_NamedBits, SyntaxTreeToken p_token, MC_NamedBit p_MC_NamedBit)
		{
			_init ();
			this.kind = (uint) production_kind.g_MC_NamedBits_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_MC_NamedBits = p_MC_NamedBits;
			children [1] = m_comma = p_token;
			children [2] = m_MC_NamedBit = p_MC_NamedBit;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule MC-NamedBits
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_MC_NamedBit != null) && node.m_MC_NamedBit.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule MC-NamedBits

		//
		// emit production tree node associated with any production of syntax rule MC-NamedBits
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_MC_NamedBits_1:
						// emit syntax tree node associated with production
						// MC-NamedBits: MC-NamedBit

						s += " " + node.m_MC_NamedBit.Emit (depth - 1);
						break;
					case production_kind.g_MC_NamedBits_2:
						// emit syntax tree node associated with production
						// MC-NamedBits: MC-NamedBits "," MC-NamedBit

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_MC_NamedBit.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule MC-NamedBits
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "MC_NamedBits (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_MC_NamedBits_1:
						// emit syntax tree node associated with production
						// MC-NamedBits: MC-NamedBit

						str += node.m_MC_NamedBit.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_MC_NamedBits_2:
						// emit syntax tree node associated with production
						// MC-NamedBits: MC-NamedBits "," MC-NamedBit

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_MC_NamedBit.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule MC-NamedBits

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule MC-NamedBits with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					MC_NamedBits.production_kind kind = (MC_NamedBits.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case MC_NamedBits.production_kind.g_MC_NamedBits_1:
							// traverse syntax tree node associated with production
							// MC-NamedBits: MC-NamedBit

							node.m_MC_NamedBit.Visit (visitor, appData);
							break;
						case MC_NamedBits.production_kind.g_MC_NamedBits_2:
							// traverse syntax tree node associated with production
							// MC-NamedBits: MC-NamedBits "," MC-NamedBit

							node.m_comma.Visit (visitor, appData);
							node.m_MC_NamedBit.Visit (visitor, appData);
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
			for (MC_NamedBits node = this; node != null; node = node.m_MC_NamedBits)
			{
				node.parent = parent;
				node.m_MC_NamedBit?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule MC-NamedBits
		//

		public void _init ()
		{
			m_MC_NamedBit = null;
			m_MC_NamedBits = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (MC_NamedBits p_MC_NamedBits, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<MC_NamedBits> stack = new Stack<MC_NamedBits> ();
			MC_NamedBits p_MC_NamedBits;
			for (p_MC_NamedBits = this; p_MC_NamedBits != null; p_MC_NamedBits = p_MC_NamedBits.m_MC_NamedBits)
				stack.Push (p_MC_NamedBits);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule MC-NamedBits

		// counter of all nodes associated with syntax rule MC-NamedBits
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule MC-NamedBits
		[DataMember (Name = "m_MC_NamedBit")] public MC_NamedBit m_MC_NamedBit { get; private set; }
		[DataMember (Name = "m_MC_NamedBits")] public MC_NamedBits m_MC_NamedBits { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule MC-NamedBits

		// delegate function (callback) prototype associated with syntax rule MC-NamedBits
		public delegate bool MC_NamedBits_Callback (SyntaxTreeCallbackReason reason, MC_NamedBits.production_kind kind, MC_NamedBits p_MC_NamedBits);

		// event associated with syntax rule MC-NamedBits
		public event MC_NamedBits_Callback MC_NamedBits_Event;

		// event trigger associated with syntax rule MC-NamedBits
		public bool Raise_MC_NamedBits_Event (SyntaxTreeCallbackReason reason, MC_NamedBits.production_kind kind, MC_NamedBits p_MC_NamedBits)
		{
			bool? status = MC_NamedBits_Event?.Invoke (reason, kind, p_MC_NamedBits);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule MC-NamedBits
		//
		// traverse syntax tree node associated with any production of syntax rule MC-NamedBits
		//

		public void Traverse (MC_NamedBits p_MC_NamedBits)
		{
			if (p_MC_NamedBits.isLocked())
				return;
			if (Raise_MC_NamedBits_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (MC_NamedBits.production_kind) p_MC_NamedBits.kind, p_MC_NamedBits))
				p_MC_NamedBits.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					MC_NamedBits.production_kind kind = (MC_NamedBits.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_MC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case MC_NamedBits.production_kind.g_MC_NamedBits_1:
								// traverse syntax tree node associated with production
								// MC-NamedBits: MC-NamedBit

								if (Raise_MC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_MC_NamedBit);
								node.turn_inc ();
								Raise_MC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case MC_NamedBits.production_kind.g_MC_NamedBits_2:
								// traverse syntax tree node associated with production
								// MC-NamedBits: MC-NamedBits "," MC-NamedBit

								if (Raise_MC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_MC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_MC_NamedBit);
								node.turn_inc ();
								Raise_MC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_MC_NamedBits_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_MC_NamedBits_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (MC_NamedBits.production_kind) p_MC_NamedBits.kind, p_MC_NamedBits);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule MC-NamedBits
		//

		public void TraverseCommon (MC_NamedBits p_MC_NamedBits)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_MC_NamedBits.kind, p_MC_NamedBits))
				p_MC_NamedBits.Iterate (null, (node, appData) =>
				{
					MC_NamedBits.production_kind kind = (MC_NamedBits.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case MC_NamedBits.production_kind.g_MC_NamedBits_1:
							// traverse syntax tree node associated with production
							// MC-NamedBits: MC-NamedBit

							TraverseCommon (node.m_MC_NamedBit);
							break;
						case MC_NamedBits.production_kind.g_MC_NamedBits_2:
							// traverse syntax tree node associated with production
							// MC-NamedBits: MC-NamedBits "," MC-NamedBit

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_MC_NamedBit);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_MC_NamedBits.kind, p_MC_NamedBits);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule MC-NamedBits

		//
		// create syntax tree node associated with production
		// MC-NamedBits: MC-NamedBit

		//

		public MC_NamedBits MC_NamedBits_1 (MC_NamedBit p_MC_NamedBit)
		{
			MC_NamedBits p_MC_NamedBits_ref = new MC_NamedBits(p_MC_NamedBit);
			p_MC_NamedBit.parent = p_MC_NamedBits_ref;
			Raise_MC_NamedBits_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_NamedBits.production_kind.g_MC_NamedBits_1, p_MC_NamedBits_ref);
			return p_MC_NamedBits_ref;
		}

		//
		// create syntax tree node associated with production
		// MC-NamedBits: MC-NamedBits "," MC-NamedBit

		//

		public MC_NamedBits MC_NamedBits_2 (MC_NamedBits p_MC_NamedBits, SyntaxTreeToken p_token, MC_NamedBit p_MC_NamedBit)
		{
			MC_NamedBits p_MC_NamedBits_ref = new MC_NamedBits(p_MC_NamedBits, p_token, p_MC_NamedBit);
			p_MC_NamedBits.parent = p_MC_NamedBits_ref;
			p_token.parent = p_MC_NamedBits_ref;
			p_MC_NamedBit.parent = p_MC_NamedBits_ref;
			Raise_MC_NamedBits_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, MC_NamedBits.production_kind.g_MC_NamedBits_2, p_MC_NamedBits_ref);
			return p_MC_NamedBits_ref;
		}
		#endregion
	};
}
