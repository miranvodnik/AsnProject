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
	// class associated with syntax rule CharSyms
	//

	[DataContract]
	public class	CharSyms : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule CharSyms
		public enum production_kind : ushort	// enumerated production(s) of syntax rule CharSyms
		{
			g_CharSyms_1 = 1,	// CharsDefn

			g_CharSyms_2 = 2,	// CharSyms "," CharsDefn

		};
		#endregion
		#region production markers associated with the syntax rule CharSyms

		// markers associated with production: CharSyms -> CharsDefn

		public enum production_marker_1 : ushort
		{
			m_CharsDefn,
			final
		};

		// markers associated with production: CharSyms -> CharSyms "," CharsDefn

		public enum production_marker_2 : ushort
		{
			m_CharSyms,
			m_CharsDefn,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule CharSyms

		// Constructor declaration(s) associated with production(s) of syntax rule CharSyms

		//
		// Constructor associated with the following production(s)
		// CharSyms -> CharsDefn

		//

		public CharSyms (CharsDefn p_CharsDefn) : base ((uint) ProductionID._CharSyms_ID, (uint) production_kind.g_CharSyms_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_CharsDefn = p_CharsDefn;
		}

		//
		// Constructor associated with the following production(s)
		// CharSyms -> CharSyms "," CharsDefn

		//

		public CharSyms (CharSyms p_CharSyms, SyntaxTreeToken p_token, CharsDefn p_CharsDefn) : base ((uint) ProductionID._CharSyms_ID, (uint) production_kind.g_CharSyms_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_CharSyms = p_CharSyms;
			children[1] = m_comma = p_token;
			children[2] = m_CharsDefn = p_CharsDefn;
		}

		public CharSyms () { }

		// Copy constructor

		public CharSyms (CharSyms p_CharSyms) : base (p_CharSyms.id, p_CharSyms.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_CharSyms.appInfo;
			switch ((production_kind) p_CharSyms.kind)
			{
				case production_kind.g_CharSyms_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_CharsDefn = (p_CharSyms.m_CharsDefn != null) ? new CharsDefn (p_CharSyms.m_CharsDefn) : null) != null) m_CharsDefn.parent = this;
					break;
				case production_kind.g_CharSyms_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_CharSyms = (p_CharSyms.m_CharSyms != null) ? new CharSyms (p_CharSyms.m_CharSyms) : null) != null) m_CharSyms.parent = this;
					if ((children [1] = m_comma = (p_CharSyms.m_comma != null) ? new SyntaxTreeToken (p_CharSyms.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_CharsDefn = (p_CharSyms.m_CharsDefn != null) ? new CharsDefn (p_CharSyms.m_CharsDefn) : null) != null) m_CharsDefn.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "CharSyms" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new CharSyms (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_CharsDefn?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule CharSyms

		// Content changing function(s) associated with production(s) of syntax rule CharSyms

		//
		// Content changing function associated with following production(s)
		// CharSyms -> CharsDefn

		//

		public void change(CharsDefn p_CharsDefn)
		{
			_init ();
			this.kind = (uint) production_kind.g_CharSyms_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_CharsDefn = p_CharsDefn;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// CharSyms -> CharSyms "," CharsDefn

		//

		public void change(CharSyms p_CharSyms, SyntaxTreeToken p_token, CharsDefn p_CharsDefn)
		{
			_init ();
			this.kind = (uint) production_kind.g_CharSyms_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_CharSyms = p_CharSyms;
			children [1] = m_comma = p_token;
			children [2] = m_CharsDefn = p_CharsDefn;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule CharSyms
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_CharsDefn != null) && node.m_CharsDefn.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule CharSyms

		//
		// emit production tree node associated with any production of syntax rule CharSyms
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_CharSyms_1:
						// emit syntax tree node associated with production
						// CharSyms: CharsDefn

						s += " " + node.m_CharsDefn.Emit (depth - 1);
						break;
					case production_kind.g_CharSyms_2:
						// emit syntax tree node associated with production
						// CharSyms: CharSyms "," CharsDefn

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_CharsDefn.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule CharSyms
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "CharSyms (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_CharSyms_1:
						// emit syntax tree node associated with production
						// CharSyms: CharsDefn

						str += node.m_CharsDefn.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_CharSyms_2:
						// emit syntax tree node associated with production
						// CharSyms: CharSyms "," CharsDefn

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_CharsDefn.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule CharSyms

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule CharSyms with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					CharSyms.production_kind kind = (CharSyms.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case CharSyms.production_kind.g_CharSyms_1:
							// traverse syntax tree node associated with production
							// CharSyms: CharsDefn

							node.m_CharsDefn.Visit (visitor, appData);
							break;
						case CharSyms.production_kind.g_CharSyms_2:
							// traverse syntax tree node associated with production
							// CharSyms: CharSyms "," CharsDefn

							node.m_comma.Visit (visitor, appData);
							node.m_CharsDefn.Visit (visitor, appData);
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
			for (CharSyms node = this; node != null; node = node.m_CharSyms)
			{
				node.parent = parent;
				node.m_CharsDefn?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule CharSyms
		//

		public void _init ()
		{
			m_CharsDefn = null;
			m_CharSyms = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (CharSyms p_CharSyms, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<CharSyms> stack = new Stack<CharSyms> ();
			CharSyms p_CharSyms;
			for (p_CharSyms = this; p_CharSyms != null; p_CharSyms = p_CharSyms.m_CharSyms)
				stack.Push (p_CharSyms);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule CharSyms

		// counter of all nodes associated with syntax rule CharSyms
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule CharSyms
		[DataMember (Name = "m_CharsDefn")] public CharsDefn m_CharsDefn { get; private set; }
		[DataMember (Name = "m_CharSyms")] public CharSyms m_CharSyms { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule CharSyms

		// delegate function (callback) prototype associated with syntax rule CharSyms
		public delegate bool CharSyms_Callback (SyntaxTreeCallbackReason reason, CharSyms.production_kind kind, CharSyms p_CharSyms);

		// event associated with syntax rule CharSyms
		public event CharSyms_Callback CharSyms_Event;

		// event trigger associated with syntax rule CharSyms
		public bool Raise_CharSyms_Event (SyntaxTreeCallbackReason reason, CharSyms.production_kind kind, CharSyms p_CharSyms)
		{
			bool? status = CharSyms_Event?.Invoke (reason, kind, p_CharSyms);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule CharSyms
		//
		// traverse syntax tree node associated with any production of syntax rule CharSyms
		//

		public void Traverse (CharSyms p_CharSyms)
		{
			if (p_CharSyms.isLocked())
				return;
			if (Raise_CharSyms_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (CharSyms.production_kind) p_CharSyms.kind, p_CharSyms))
				p_CharSyms.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					CharSyms.production_kind kind = (CharSyms.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_CharSyms_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case CharSyms.production_kind.g_CharSyms_1:
								// traverse syntax tree node associated with production
								// CharSyms: CharsDefn

								if (Raise_CharSyms_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_CharsDefn);
								node.turn_inc ();
								Raise_CharSyms_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case CharSyms.production_kind.g_CharSyms_2:
								// traverse syntax tree node associated with production
								// CharSyms: CharSyms "," CharsDefn

								if (Raise_CharSyms_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_CharSyms_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_CharsDefn);
								node.turn_inc ();
								Raise_CharSyms_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_CharSyms_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_CharSyms_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (CharSyms.production_kind) p_CharSyms.kind, p_CharSyms);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule CharSyms
		//

		public void TraverseCommon (CharSyms p_CharSyms)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_CharSyms.kind, p_CharSyms))
				p_CharSyms.Iterate (null, (node, appData) =>
				{
					CharSyms.production_kind kind = (CharSyms.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case CharSyms.production_kind.g_CharSyms_1:
							// traverse syntax tree node associated with production
							// CharSyms: CharsDefn

							TraverseCommon (node.m_CharsDefn);
							break;
						case CharSyms.production_kind.g_CharSyms_2:
							// traverse syntax tree node associated with production
							// CharSyms: CharSyms "," CharsDefn

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_CharsDefn);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_CharSyms.kind, p_CharSyms);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule CharSyms

		//
		// create syntax tree node associated with production
		// CharSyms: CharsDefn

		//

		public CharSyms CharSyms_1 (CharsDefn p_CharsDefn)
		{
			CharSyms p_CharSyms_ref = new CharSyms(p_CharsDefn);
			p_CharsDefn.parent = p_CharSyms_ref;
			Raise_CharSyms_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, CharSyms.production_kind.g_CharSyms_1, p_CharSyms_ref);
			return p_CharSyms_ref;
		}

		//
		// create syntax tree node associated with production
		// CharSyms: CharSyms "," CharsDefn

		//

		public CharSyms CharSyms_2 (CharSyms p_CharSyms, SyntaxTreeToken p_token, CharsDefn p_CharsDefn)
		{
			CharSyms p_CharSyms_ref = new CharSyms(p_CharSyms, p_token, p_CharsDefn);
			p_CharSyms.parent = p_CharSyms_ref;
			p_token.parent = p_CharSyms_ref;
			p_CharsDefn.parent = p_CharSyms_ref;
			Raise_CharSyms_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, CharSyms.production_kind.g_CharSyms_2, p_CharSyms_ref);
			return p_CharSyms_ref;
		}
		#endregion
	};
}
