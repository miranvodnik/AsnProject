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
	// class associated with syntax rule OT-BitNames
	//

	[DataContract]
	public class	OT_BitNames : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule OT-BitNames
		public enum production_kind : ushort	// enumerated production(s) of syntax rule OT-BitNames
		{
			g_OT_BitNames_1 = 1,	// OT-BitName

			g_OT_BitNames_2 = 2,	// OT-BitNames "," OT-BitName

		};
		#endregion
		#region production markers associated with the syntax rule OT-BitNames

		// markers associated with production: OT-BitNames -> OT-BitName

		public enum production_marker_1 : ushort
		{
			m_OT_BitName,
			final
		};

		// markers associated with production: OT-BitNames -> OT-BitNames "," OT-BitName

		public enum production_marker_2 : ushort
		{
			m_OT_BitNames,
			m_OT_BitName,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule OT-BitNames

		// Constructor declaration(s) associated with production(s) of syntax rule OT-BitNames

		//
		// Constructor associated with the following production(s)
		// OT-BitNames -> OT-BitName

		//

		public OT_BitNames (OT_BitName p_OT_BitName) : base ((uint) ProductionID._OT_BitNames_ID, (uint) production_kind.g_OT_BitNames_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_OT_BitName = p_OT_BitName;
		}

		//
		// Constructor associated with the following production(s)
		// OT-BitNames -> OT-BitNames "," OT-BitName

		//

		public OT_BitNames (OT_BitNames p_OT_BitNames, SyntaxTreeToken p_token, OT_BitName p_OT_BitName) : base ((uint) ProductionID._OT_BitNames_ID, (uint) production_kind.g_OT_BitNames_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_OT_BitNames = p_OT_BitNames;
			children[1] = m_comma = p_token;
			children[2] = m_OT_BitName = p_OT_BitName;
		}

		public OT_BitNames () { }

		// Copy constructor

		public OT_BitNames (OT_BitNames p_OT_BitNames) : base (p_OT_BitNames.id, p_OT_BitNames.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_OT_BitNames.appInfo;
			switch ((production_kind) p_OT_BitNames.kind)
			{
				case production_kind.g_OT_BitNames_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_OT_BitName = (p_OT_BitNames.m_OT_BitName != null) ? new OT_BitName (p_OT_BitNames.m_OT_BitName) : null) != null) m_OT_BitName.parent = this;
					break;
				case production_kind.g_OT_BitNames_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_OT_BitNames = (p_OT_BitNames.m_OT_BitNames != null) ? new OT_BitNames (p_OT_BitNames.m_OT_BitNames) : null) != null) m_OT_BitNames.parent = this;
					if ((children [1] = m_comma = (p_OT_BitNames.m_comma != null) ? new SyntaxTreeToken (p_OT_BitNames.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_OT_BitName = (p_OT_BitNames.m_OT_BitName != null) ? new OT_BitName (p_OT_BitNames.m_OT_BitName) : null) != null) m_OT_BitName.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "OT_BitNames" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new OT_BitNames (this); }

		// Destructor

		public new void Dispose ()
		{
			Iterate (null, (node, appData) =>
			{
				--g_counter;

				node.m_OT_BitName?.Dispose ();
				node.m_comma?.Dispose ();

				node._init ();

				return null;
			});
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule OT-BitNames

		// Content changing function(s) associated with production(s) of syntax rule OT-BitNames

		//
		// Content changing function associated with following production(s)
		// OT-BitNames -> OT-BitName

		//

		public void change(OT_BitName p_OT_BitName)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_BitNames_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_OT_BitName = p_OT_BitName;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// OT-BitNames -> OT-BitNames "," OT-BitName

		//

		public void change(OT_BitNames p_OT_BitNames, SyntaxTreeToken p_token, OT_BitName p_OT_BitName)
		{
			_init ();
			this.kind = (uint) production_kind.g_OT_BitNames_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_OT_BitNames = p_OT_BitNames;
			children [1] = m_comma = p_token;
			children [2] = m_OT_BitName = p_OT_BitName;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule OT-BitNames
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return (element == this) || (bool) Iterate (false, (node, appData) =>
			{
				return
					(bool) appData ||
					(node.m_OT_BitName != null) && node.m_OT_BitName.checkInclusion (element) ||
					(node.m_comma != null) && node.m_comma.checkInclusion (element) ||
					false;
			});
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule OT-BitNames

		//
		// emit production tree node associated with any production of syntax rule OT-BitNames
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
				Iterate (null, (node, appData) =>
				{
					switch ((production_kind) node.kind)
					{
					case production_kind.g_OT_BitNames_1:
						// emit syntax tree node associated with production
						// OT-BitNames: OT-BitName

						s += " " + node.m_OT_BitName.Emit (depth - 1);
						break;
					case production_kind.g_OT_BitNames_2:
						// emit syntax tree node associated with production
						// OT-BitNames: OT-BitNames "," OT-BitName

						s += " " + node.m_comma.Emit (depth - 1);
						s += " " + node.m_OT_BitName.Emit (depth - 1);
						break;
					}
					return null;
				});
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule OT-BitNames
		//

		public override string EmitProductionTree (int depth)
		{
			return (depth != 0) ?
				(string) Iterate ("", (node, appData) =>
				{
					string str = "OT_BitNames (" + (string) appData;
					switch ((production_kind) node.kind)
					{
					case production_kind.g_OT_BitNames_1:
						// emit syntax tree node associated with production
						// OT-BitNames: OT-BitName

						str += node.m_OT_BitName.EmitProductionTree (depth - 1);
						break;
					case production_kind.g_OT_BitNames_2:
						// emit syntax tree node associated with production
						// OT-BitNames: OT-BitNames "," OT-BitName

						str += ' ';
						str += "comma";
						str += ' ';
						str += node.m_OT_BitName.EmitProductionTree (depth - 1);
						break;
					}
					return str + ")";
				}) : "";
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule OT-BitNames

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule OT-BitNames with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			if (visitor (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) this.kind, this, appData))
				Iterate (null, (node, data) =>
				{
					OT_BitNames.production_kind kind = (OT_BitNames.production_kind) node.kind;
					if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node, appData))
						switch (kind)
						{
						case OT_BitNames.production_kind.g_OT_BitNames_1:
							// traverse syntax tree node associated with production
							// OT-BitNames: OT-BitName

							node.m_OT_BitName.Visit (visitor, appData);
							break;
						case OT_BitNames.production_kind.g_OT_BitNames_2:
							// traverse syntax tree node associated with production
							// OT-BitNames: OT-BitNames "," OT-BitName

							node.m_comma.Visit (visitor, appData);
							node.m_OT_BitName.Visit (visitor, appData);
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
			for (OT_BitNames node = this; node != null; node = node.m_OT_BitNames)
			{
				node.parent = parent;
				node.m_OT_BitName?.reparent (parent);
				node.m_comma?.reparent (parent);
				parent = node;
			}
		}

		//
		// initialize object associated with syntax rule OT-BitNames
		//

		public void _init ()
		{
			m_OT_BitName = null;
			m_OT_BitNames = null;
			m_comma = null;
		}

		public delegate object IteratorDelegate (OT_BitNames p_OT_BitNames, object appData);

		public object Iterate (object appData, IteratorDelegate iteratorDelegate)
		{
			Stack<OT_BitNames> stack = new Stack<OT_BitNames> ();
			OT_BitNames p_OT_BitNames;
			for (p_OT_BitNames = this; p_OT_BitNames != null; p_OT_BitNames = p_OT_BitNames.m_OT_BitNames)
				stack.Push (p_OT_BitNames);
			foreach (var node in stack)
				appData = iteratorDelegate (node, appData);
			return appData;
		}
		#endregion
		#region Fields and properties associated with the syntax rule OT-BitNames

		// counter of all nodes associated with syntax rule OT-BitNames
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule OT-BitNames
		[DataMember (Name = "m_OT_BitName")] public OT_BitName m_OT_BitName { get; private set; }
		[DataMember (Name = "m_OT_BitNames")] public OT_BitNames m_OT_BitNames { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule OT-BitNames

		// delegate function (callback) prototype associated with syntax rule OT-BitNames
		public delegate bool OT_BitNames_Callback (SyntaxTreeCallbackReason reason, OT_BitNames.production_kind kind, OT_BitNames p_OT_BitNames);

		// event associated with syntax rule OT-BitNames
		public event OT_BitNames_Callback OT_BitNames_Event;

		// event trigger associated with syntax rule OT-BitNames
		public bool Raise_OT_BitNames_Event (SyntaxTreeCallbackReason reason, OT_BitNames.production_kind kind, OT_BitNames p_OT_BitNames)
		{
			bool? status = OT_BitNames_Event?.Invoke (reason, kind, p_OT_BitNames);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule OT-BitNames
		//
		// traverse syntax tree node associated with any production of syntax rule OT-BitNames
		//

		public void Traverse (OT_BitNames p_OT_BitNames)
		{
			if (p_OT_BitNames.isLocked())
				return;
			if (Raise_OT_BitNames_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (OT_BitNames.production_kind) p_OT_BitNames.kind, p_OT_BitNames))
				p_OT_BitNames.Iterate (null, (node, appData) =>
				{
					if (node.isLocked())
						return null;
					node.dolock();
					OT_BitNames.production_kind kind = (OT_BitNames.production_kind) node.kind;
					node.turn_reset ();
					if (Raise_OT_BitNames_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, node))
						switch (kind)
						{
							case OT_BitNames.production_kind.g_OT_BitNames_1:
								// traverse syntax tree node associated with production
								// OT-BitNames: OT-BitName

								if (Raise_OT_BitNames_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_OT_BitName);
								node.turn_inc ();
								Raise_OT_BitNames_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
							case OT_BitNames.production_kind.g_OT_BitNames_2:
								// traverse syntax tree node associated with production
								// OT-BitNames: OT-BitNames "," OT-BitName

								if (Raise_OT_BitNames_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									;
								node.turn_inc ();
								if (Raise_OT_BitNames_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node))
									Traverse (node.m_OT_BitName);
								node.turn_inc ();
								Raise_OT_BitNames_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, node);
							break;
						}
					Raise_OT_BitNames_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, node);
					node.unlock();
					return null;
				});
			Raise_OT_BitNames_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (OT_BitNames.production_kind) p_OT_BitNames.kind, p_OT_BitNames);
		}

		//
		// traverse syntax tree node associated with any production of syntax rule OT-BitNames
		//

		public void TraverseCommon (OT_BitNames p_OT_BitNames)
		{
			if (Raise_Common_Event (SyntaxTreeCallbackReason.IterationPrologueCallbackReason, (int) p_OT_BitNames.kind, p_OT_BitNames))
				p_OT_BitNames.Iterate (null, (node, appData) =>
				{
					OT_BitNames.production_kind kind = (OT_BitNames.production_kind) node.kind;
					if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, node))
						switch (kind)
						{
						case OT_BitNames.production_kind.g_OT_BitNames_1:
							// traverse syntax tree node associated with production
							// OT-BitNames: OT-BitName

							TraverseCommon (node.m_OT_BitName);
							break;
						case OT_BitNames.production_kind.g_OT_BitNames_2:
							// traverse syntax tree node associated with production
							// OT-BitNames: OT-BitNames "," OT-BitName

							TraverseCommon (node.m_comma);
							TraverseCommon (node.m_OT_BitName);
							break;
						}
					Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, node);
					return null;
				});
			Raise_Common_Event (SyntaxTreeCallbackReason.IterationEpilogueCallbackReason, (int) p_OT_BitNames.kind, p_OT_BitNames);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule OT-BitNames

		//
		// create syntax tree node associated with production
		// OT-BitNames: OT-BitName

		//

		public OT_BitNames OT_BitNames_1 (OT_BitName p_OT_BitName)
		{
			OT_BitNames p_OT_BitNames_ref = new OT_BitNames(p_OT_BitName);
			p_OT_BitName.parent = p_OT_BitNames_ref;
			Raise_OT_BitNames_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_BitNames.production_kind.g_OT_BitNames_1, p_OT_BitNames_ref);
			return p_OT_BitNames_ref;
		}

		//
		// create syntax tree node associated with production
		// OT-BitNames: OT-BitNames "," OT-BitName

		//

		public OT_BitNames OT_BitNames_2 (OT_BitNames p_OT_BitNames, SyntaxTreeToken p_token, OT_BitName p_OT_BitName)
		{
			OT_BitNames p_OT_BitNames_ref = new OT_BitNames(p_OT_BitNames, p_token, p_OT_BitName);
			p_OT_BitNames.parent = p_OT_BitNames_ref;
			p_token.parent = p_OT_BitNames_ref;
			p_OT_BitName.parent = p_OT_BitNames_ref;
			Raise_OT_BitNames_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, OT_BitNames.production_kind.g_OT_BitNames_2, p_OT_BitNames_ref);
			return p_OT_BitNames_ref;
		}
		#endregion
	};
}
