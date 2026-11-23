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
	// class associated with syntax rule ComponentTypeLists
	//

	[DataContract]
	public class	ComponentTypeLists : SyntaxTreeBase
	{
		#region enumerated production(s) of syntax rule ComponentTypeLists
		public enum production_kind : ushort	// enumerated production(s) of syntax rule ComponentTypeLists
		{
			g_ComponentTypeLists_1 = 1,	// RootComponentTypeList

			g_ComponentTypeLists_2 = 2,	// RootComponentTypeList "," ExtensionAndException ExtensionAdditions OptionalExtensionMarker

			g_ComponentTypeLists_3 = 3,	// RootComponentTypeList "," ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

			g_ComponentTypeLists_4 = 4,	// ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

			g_ComponentTypeLists_5 = 5,	// ExtensionAndException ExtensionAdditions OptionalExtensionMarker

			g_ComponentTypeLists_6 = 6,	// ExtensionAndException OptionalExtensionMarker

		};
		#endregion
		#region production markers associated with the syntax rule ComponentTypeLists

		// markers associated with production: ComponentTypeLists -> RootComponentTypeList

		public enum production_marker_1 : ushort
		{
			m_RootComponentTypeList,
			final
		};

		// markers associated with production: ComponentTypeLists -> RootComponentTypeList "," ExtensionAndException ExtensionAdditions OptionalExtensionMarker

		public enum production_marker_2 : ushort
		{
			m_RootComponentTypeList,
			m_ExtensionAndException,
			m_ExtensionAdditions,
			m_OptionalExtensionMarker,
			final
		};

		// markers associated with production: ComponentTypeLists -> RootComponentTypeList "," ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

		public enum production_marker_3 : ushort
		{
			m_RootComponentTypeList,
			m_ExtensionAndException,
			m_ExtensionAdditions,
			m_ExtensionEndMarker,
			m_RootComponentTypeList_1,
			final
		};

		// markers associated with production: ComponentTypeLists -> ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

		public enum production_marker_4 : ushort
		{
			m_ExtensionAndException,
			m_ExtensionAdditions,
			m_ExtensionEndMarker,
			m_RootComponentTypeList,
			final
		};

		// markers associated with production: ComponentTypeLists -> ExtensionAndException ExtensionAdditions OptionalExtensionMarker

		public enum production_marker_5 : ushort
		{
			m_ExtensionAndException,
			m_ExtensionAdditions,
			m_OptionalExtensionMarker,
			final
		};

		// markers associated with production: ComponentTypeLists -> ExtensionAndException OptionalExtensionMarker

		public enum production_marker_6 : ushort
		{
			m_ExtensionAndException,
			m_OptionalExtensionMarker,
			final
		};
		#endregion
		#region Constructors and destructors associated with the syntax rule ComponentTypeLists

		// Constructor declaration(s) associated with production(s) of syntax rule ComponentTypeLists

		//
		// Constructor associated with the following production(s)
		// ComponentTypeLists -> RootComponentTypeList

		//

		public ComponentTypeLists (RootComponentTypeList p_RootComponentTypeList) : base ((uint) ProductionID._ComponentTypeLists_ID, (uint) production_kind.g_ComponentTypeLists_1)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children[0] = m_RootComponentTypeList = p_RootComponentTypeList;
		}

		//
		// Constructor associated with the following production(s)
		// ComponentTypeLists -> RootComponentTypeList "," ExtensionAndException ExtensionAdditions OptionalExtensionMarker

		//

		public ComponentTypeLists (RootComponentTypeList p_RootComponentTypeList, SyntaxTreeToken p_token, ExtensionAndException p_ExtensionAndException, ExtensionAdditions p_ExtensionAdditions, OptionalExtensionMarker p_OptionalExtensionMarker) : base ((uint) ProductionID._ComponentTypeLists_ID, (uint) production_kind.g_ComponentTypeLists_2)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_RootComponentTypeList = p_RootComponentTypeList;
			children[1] = m_comma = p_token;
			children[2] = m_ExtensionAndException = p_ExtensionAndException;
			children[3] = m_ExtensionAdditions = p_ExtensionAdditions;
			children[4] = m_OptionalExtensionMarker = p_OptionalExtensionMarker;
		}

		//
		// Constructor associated with the following production(s)
		// ComponentTypeLists -> RootComponentTypeList "," ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

		//

		public ComponentTypeLists (RootComponentTypeList p_RootComponentTypeList, SyntaxTreeToken p_token, ExtensionAndException p_ExtensionAndException, ExtensionAdditions p_ExtensionAdditions, ExtensionEndMarker p_ExtensionEndMarker, SyntaxTreeToken p_token_1, RootComponentTypeList p_RootComponentTypeList_1) : base ((uint) ProductionID._ComponentTypeLists_ID, (uint) production_kind.g_ComponentTypeLists_3)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children[0] = m_RootComponentTypeList = p_RootComponentTypeList;
			children[1] = m_comma = p_token;
			children[2] = m_ExtensionAndException = p_ExtensionAndException;
			children[3] = m_ExtensionAdditions = p_ExtensionAdditions;
			children[4] = m_ExtensionEndMarker = p_ExtensionEndMarker;
			children[5] = m_comma_1 = p_token_1;
			children[6] = m_RootComponentTypeList_1 = p_RootComponentTypeList_1;
		}

		//
		// Constructor associated with the following production(s)
		// ComponentTypeLists -> ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

		//

		public ComponentTypeLists (ExtensionAndException p_ExtensionAndException, ExtensionAdditions p_ExtensionAdditions, ExtensionEndMarker p_ExtensionEndMarker, SyntaxTreeToken p_token, RootComponentTypeList p_RootComponentTypeList) : base ((uint) ProductionID._ComponentTypeLists_ID, (uint) production_kind.g_ComponentTypeLists_4)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children[0] = m_ExtensionAndException = p_ExtensionAndException;
			children[1] = m_ExtensionAdditions = p_ExtensionAdditions;
			children[2] = m_ExtensionEndMarker = p_ExtensionEndMarker;
			children[3] = m_comma = p_token;
			children[4] = m_RootComponentTypeList = p_RootComponentTypeList;
		}

		//
		// Constructor associated with the following production(s)
		// ComponentTypeLists -> ExtensionAndException ExtensionAdditions OptionalExtensionMarker

		//

		public ComponentTypeLists (ExtensionAndException p_ExtensionAndException, ExtensionAdditions p_ExtensionAdditions, OptionalExtensionMarker p_OptionalExtensionMarker) : base ((uint) ProductionID._ComponentTypeLists_ID, (uint) production_kind.g_ComponentTypeLists_5)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children[0] = m_ExtensionAndException = p_ExtensionAndException;
			children[1] = m_ExtensionAdditions = p_ExtensionAdditions;
			children[2] = m_OptionalExtensionMarker = p_OptionalExtensionMarker;
		}

		//
		// Constructor associated with the following production(s)
		// ComponentTypeLists -> ExtensionAndException OptionalExtensionMarker

		//

		public ComponentTypeLists (ExtensionAndException p_ExtensionAndException, OptionalExtensionMarker p_OptionalExtensionMarker) : base ((uint) ProductionID._ComponentTypeLists_ID, (uint) production_kind.g_ComponentTypeLists_6)
		{
			++g_counter;
			_init ();
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children[0] = m_ExtensionAndException = p_ExtensionAndException;
			children[1] = m_OptionalExtensionMarker = p_OptionalExtensionMarker;
		}

		public ComponentTypeLists () { }

		// Copy constructor

		public ComponentTypeLists (ComponentTypeLists p_ComponentTypeLists) : base (p_ComponentTypeLists.id, p_ComponentTypeLists.kind)
		{
			++g_counter;
			_init ();
			appInfo = p_ComponentTypeLists.appInfo;
			switch ((production_kind) p_ComponentTypeLists.kind)
			{
				case production_kind.g_ComponentTypeLists_1:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
					if ((children [0] = m_RootComponentTypeList = (p_ComponentTypeLists.m_RootComponentTypeList != null) ? new RootComponentTypeList (p_ComponentTypeLists.m_RootComponentTypeList) : null) != null) m_RootComponentTypeList.parent = this;
					break;
				case production_kind.g_ComponentTypeLists_2:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_RootComponentTypeList = (p_ComponentTypeLists.m_RootComponentTypeList != null) ? new RootComponentTypeList (p_ComponentTypeLists.m_RootComponentTypeList) : null) != null) m_RootComponentTypeList.parent = this;
					if ((children [1] = m_comma = (p_ComponentTypeLists.m_comma != null) ? new SyntaxTreeToken (p_ComponentTypeLists.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_ExtensionAndException = (p_ComponentTypeLists.m_ExtensionAndException != null) ? new ExtensionAndException (p_ComponentTypeLists.m_ExtensionAndException) : null) != null) m_ExtensionAndException.parent = this;
					if ((children [3] = m_ExtensionAdditions = (p_ComponentTypeLists.m_ExtensionAdditions != null) ? new ExtensionAdditions (p_ComponentTypeLists.m_ExtensionAdditions) : null) != null) m_ExtensionAdditions.parent = this;
					if ((children [4] = m_OptionalExtensionMarker = (p_ComponentTypeLists.m_OptionalExtensionMarker != null) ? new OptionalExtensionMarker (p_ComponentTypeLists.m_OptionalExtensionMarker) : null) != null) m_OptionalExtensionMarker.parent = this;
					break;
				case production_kind.g_ComponentTypeLists_3:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
					if ((children [0] = m_RootComponentTypeList = (p_ComponentTypeLists.m_RootComponentTypeList != null) ? new RootComponentTypeList (p_ComponentTypeLists.m_RootComponentTypeList) : null) != null) m_RootComponentTypeList.parent = this;
					if ((children [1] = m_comma = (p_ComponentTypeLists.m_comma != null) ? new SyntaxTreeToken (p_ComponentTypeLists.m_comma) : null) != null) m_comma.parent = this;
					if ((children [2] = m_ExtensionAndException = (p_ComponentTypeLists.m_ExtensionAndException != null) ? new ExtensionAndException (p_ComponentTypeLists.m_ExtensionAndException) : null) != null) m_ExtensionAndException.parent = this;
					if ((children [3] = m_ExtensionAdditions = (p_ComponentTypeLists.m_ExtensionAdditions != null) ? new ExtensionAdditions (p_ComponentTypeLists.m_ExtensionAdditions) : null) != null) m_ExtensionAdditions.parent = this;
					if ((children [4] = m_ExtensionEndMarker = (p_ComponentTypeLists.m_ExtensionEndMarker != null) ? new ExtensionEndMarker (p_ComponentTypeLists.m_ExtensionEndMarker) : null) != null) m_ExtensionEndMarker.parent = this;
					if ((children [5] = m_comma_1 = (p_ComponentTypeLists.m_comma_1 != null) ? new SyntaxTreeToken (p_ComponentTypeLists.m_comma_1) : null) != null) m_comma_1.parent = this;
					if ((children [6] = m_RootComponentTypeList_1 = (p_ComponentTypeLists.m_RootComponentTypeList_1 != null) ? new RootComponentTypeList (p_ComponentTypeLists.m_RootComponentTypeList_1) : null) != null) m_RootComponentTypeList_1.parent = this;
					break;
				case production_kind.g_ComponentTypeLists_4:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
					if ((children [0] = m_ExtensionAndException = (p_ComponentTypeLists.m_ExtensionAndException != null) ? new ExtensionAndException (p_ComponentTypeLists.m_ExtensionAndException) : null) != null) m_ExtensionAndException.parent = this;
					if ((children [1] = m_ExtensionAdditions = (p_ComponentTypeLists.m_ExtensionAdditions != null) ? new ExtensionAdditions (p_ComponentTypeLists.m_ExtensionAdditions) : null) != null) m_ExtensionAdditions.parent = this;
					if ((children [2] = m_ExtensionEndMarker = (p_ComponentTypeLists.m_ExtensionEndMarker != null) ? new ExtensionEndMarker (p_ComponentTypeLists.m_ExtensionEndMarker) : null) != null) m_ExtensionEndMarker.parent = this;
					if ((children [3] = m_comma = (p_ComponentTypeLists.m_comma != null) ? new SyntaxTreeToken (p_ComponentTypeLists.m_comma) : null) != null) m_comma.parent = this;
					if ((children [4] = m_RootComponentTypeList = (p_ComponentTypeLists.m_RootComponentTypeList != null) ? new RootComponentTypeList (p_ComponentTypeLists.m_RootComponentTypeList) : null) != null) m_RootComponentTypeList.parent = this;
					break;
				case production_kind.g_ComponentTypeLists_5:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
					if ((children [0] = m_ExtensionAndException = (p_ComponentTypeLists.m_ExtensionAndException != null) ? new ExtensionAndException (p_ComponentTypeLists.m_ExtensionAndException) : null) != null) m_ExtensionAndException.parent = this;
					if ((children [1] = m_ExtensionAdditions = (p_ComponentTypeLists.m_ExtensionAdditions != null) ? new ExtensionAdditions (p_ComponentTypeLists.m_ExtensionAdditions) : null) != null) m_ExtensionAdditions.parent = this;
					if ((children [2] = m_OptionalExtensionMarker = (p_ComponentTypeLists.m_OptionalExtensionMarker != null) ? new OptionalExtensionMarker (p_ComponentTypeLists.m_OptionalExtensionMarker) : null) != null) m_OptionalExtensionMarker.parent = this;
					break;
				case production_kind.g_ComponentTypeLists_6:
					children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
					if ((children [0] = m_ExtensionAndException = (p_ComponentTypeLists.m_ExtensionAndException != null) ? new ExtensionAndException (p_ComponentTypeLists.m_ExtensionAndException) : null) != null) m_ExtensionAndException.parent = this;
					if ((children [1] = m_OptionalExtensionMarker = (p_ComponentTypeLists.m_OptionalExtensionMarker != null) ? new OptionalExtensionMarker (p_ComponentTypeLists.m_OptionalExtensionMarker) : null) != null) m_OptionalExtensionMarker.parent = this;
					break;
				default:
				{
					string[] args = new string[] { "ComponentTypeLists" };
					throw new SyntaxTreeError (SyntaxTreeError.InvalidKindError, args);
				}
			}
		}

		// Clone node - wrapper of copy constructor

		public override SyntaxTreeBase Clone () { return (SyntaxTreeBase) new ComponentTypeLists (this); }

		// Destructor

		public new void Dispose ()
		{
			base.Dispose ();
			--g_counter;

			m_RootComponentTypeList?.Dispose ();
			m_RootComponentTypeList_1?.Dispose ();
			m_comma?.Dispose ();
			m_comma_1?.Dispose ();
			m_ExtensionAndException?.Dispose ();
			m_ExtensionAdditions?.Dispose ();
			m_OptionalExtensionMarker?.Dispose ();
			m_ExtensionEndMarker?.Dispose ();

			_init ();
		}
		#endregion
		#region Content changing and inclusion checking methods associated with the syntax rule ComponentTypeLists

		// Content changing function(s) associated with production(s) of syntax rule ComponentTypeLists

		//
		// Content changing function associated with following production(s)
		// ComponentTypeLists -> RootComponentTypeList

		//

		public void change(RootComponentTypeList p_RootComponentTypeList)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentTypeLists_1;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 1);
			children [0] = m_RootComponentTypeList = p_RootComponentTypeList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ComponentTypeLists -> RootComponentTypeList "," ExtensionAndException ExtensionAdditions OptionalExtensionMarker

		//

		public void change(RootComponentTypeList p_RootComponentTypeList, SyntaxTreeToken p_token, ExtensionAndException p_ExtensionAndException, ExtensionAdditions p_ExtensionAdditions, OptionalExtensionMarker p_OptionalExtensionMarker)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentTypeLists_2;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_RootComponentTypeList = p_RootComponentTypeList;
			children [1] = m_comma = p_token;
			children [2] = m_ExtensionAndException = p_ExtensionAndException;
			children [3] = m_ExtensionAdditions = p_ExtensionAdditions;
			children [4] = m_OptionalExtensionMarker = p_OptionalExtensionMarker;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ComponentTypeLists -> RootComponentTypeList "," ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

		//

		public void change(RootComponentTypeList p_RootComponentTypeList, SyntaxTreeToken p_token, ExtensionAndException p_ExtensionAndException, ExtensionAdditions p_ExtensionAdditions, ExtensionEndMarker p_ExtensionEndMarker, SyntaxTreeToken p_token_1, RootComponentTypeList p_RootComponentTypeList_1)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentTypeLists_3;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 7);
			children [0] = m_RootComponentTypeList = p_RootComponentTypeList;
			children [1] = m_comma = p_token;
			children [2] = m_ExtensionAndException = p_ExtensionAndException;
			children [3] = m_ExtensionAdditions = p_ExtensionAdditions;
			children [4] = m_ExtensionEndMarker = p_ExtensionEndMarker;
			children [5] = m_comma_1 = p_token_1;
			children [6] = m_RootComponentTypeList_1 = p_RootComponentTypeList_1;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ComponentTypeLists -> ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

		//

		public void change(ExtensionAndException p_ExtensionAndException, ExtensionAdditions p_ExtensionAdditions, ExtensionEndMarker p_ExtensionEndMarker, SyntaxTreeToken p_token, RootComponentTypeList p_RootComponentTypeList)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentTypeLists_4;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 5);
			children [0] = m_ExtensionAndException = p_ExtensionAndException;
			children [1] = m_ExtensionAdditions = p_ExtensionAdditions;
			children [2] = m_ExtensionEndMarker = p_ExtensionEndMarker;
			children [3] = m_comma = p_token;
			children [4] = m_RootComponentTypeList = p_RootComponentTypeList;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ComponentTypeLists -> ExtensionAndException ExtensionAdditions OptionalExtensionMarker

		//

		public void change(ExtensionAndException p_ExtensionAndException, ExtensionAdditions p_ExtensionAdditions, OptionalExtensionMarker p_OptionalExtensionMarker)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentTypeLists_5;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 3);
			children [0] = m_ExtensionAndException = p_ExtensionAndException;
			children [1] = m_ExtensionAdditions = p_ExtensionAdditions;
			children [2] = m_OptionalExtensionMarker = p_OptionalExtensionMarker;
			reparent (parent);
		}

		//
		// Content changing function associated with following production(s)
		// ComponentTypeLists -> ExtensionAndException OptionalExtensionMarker

		//

		public void change(ExtensionAndException p_ExtensionAndException, OptionalExtensionMarker p_OptionalExtensionMarker)
		{
			_init ();
			this.kind = (uint) production_kind.g_ComponentTypeLists_6;
			children = (SyntaxTreeBase []) Array.CreateInstance (typeof (SyntaxTreeBase), 2);
			children [0] = m_ExtensionAndException = p_ExtensionAndException;
			children [1] = m_OptionalExtensionMarker = p_OptionalExtensionMarker;
			reparent (parent);
		}

		//
		// check if node 'element' is included within syntax tree associated with syntax rule ComponentTypeLists
		//

		public new bool checkInclusion (SyntaxTreeBase element)
		{
			return
				(element == this) ||
				(m_RootComponentTypeList != null) && m_RootComponentTypeList.checkInclusion (element) ||
				(m_RootComponentTypeList_1 != null) && m_RootComponentTypeList_1.checkInclusion (element) ||
				(m_comma != null) && m_comma.checkInclusion (element) ||
				(m_comma_1 != null) && m_comma_1.checkInclusion (element) ||
				(m_ExtensionAndException != null) && m_ExtensionAndException.checkInclusion (element) ||
				(m_ExtensionAdditions != null) && m_ExtensionAdditions.checkInclusion (element) ||
				(m_OptionalExtensionMarker != null) && m_OptionalExtensionMarker.checkInclusion (element) ||
				(m_ExtensionEndMarker != null) && m_ExtensionEndMarker.checkInclusion (element) ||
				false;
		}
		#endregion
		#region Syntax tree emit methods associated with the syntax rule ComponentTypeLists

		//
		// emit production tree node associated with any production of syntax rule ComponentTypeLists
		//

		public override string Emit (int depth)
		{
			string s = "";
			if (depth != 0)
			switch ((production_kind) kind)
			{
				case production_kind.g_ComponentTypeLists_1:
					// emit syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList

					s += m_RootComponentTypeList.Emit (depth - 1);
				break;
				case production_kind.g_ComponentTypeLists_2:
					// emit syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList "," ExtensionAndException ExtensionAdditions OptionalExtensionMarker

					s += m_RootComponentTypeList.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_ExtensionAndException.Emit (depth - 1);
					s += " ";
					s += m_ExtensionAdditions.Emit (depth - 1);
					s += " ";
					s += m_OptionalExtensionMarker.Emit (depth - 1);
				break;
				case production_kind.g_ComponentTypeLists_3:
					// emit syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList "," ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

					s += m_RootComponentTypeList.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_ExtensionAndException.Emit (depth - 1);
					s += " ";
					s += m_ExtensionAdditions.Emit (depth - 1);
					s += " ";
					s += m_ExtensionEndMarker.Emit (depth - 1);
					s += " ";
					s += m_comma_1.Emit (depth - 1);
					s += " ";
					s += m_RootComponentTypeList_1.Emit (depth - 1);
				break;
				case production_kind.g_ComponentTypeLists_4:
					// emit syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

					s += m_ExtensionAndException.Emit (depth - 1);
					s += " ";
					s += m_ExtensionAdditions.Emit (depth - 1);
					s += " ";
					s += m_ExtensionEndMarker.Emit (depth - 1);
					s += " ";
					s += m_comma.Emit (depth - 1);
					s += " ";
					s += m_RootComponentTypeList.Emit (depth - 1);
				break;
				case production_kind.g_ComponentTypeLists_5:
					// emit syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException ExtensionAdditions OptionalExtensionMarker

					s += m_ExtensionAndException.Emit (depth - 1);
					s += " ";
					s += m_ExtensionAdditions.Emit (depth - 1);
					s += " ";
					s += m_OptionalExtensionMarker.Emit (depth - 1);
				break;
				case production_kind.g_ComponentTypeLists_6:
					// emit syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException OptionalExtensionMarker

					s += m_ExtensionAndException.Emit (depth - 1);
					s += " ";
					s += m_OptionalExtensionMarker.Emit (depth - 1);
				break;
			}
			return s.Trim ();
		}

		//
		// emit production tree node associated with any production of syntax rule ComponentTypeLists
		//

		public override string EmitProductionTree (int depth)
		{
			string s = "ComponentTypeLists (";
			if (depth != 0)
				switch ((production_kind) kind)
				{
				case production_kind.g_ComponentTypeLists_1:
					// emit syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList

					s += m_RootComponentTypeList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ComponentTypeLists_2:
					// emit syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList "," ExtensionAndException ExtensionAdditions OptionalExtensionMarker

					s += m_RootComponentTypeList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += m_ExtensionAndException.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ExtensionAdditions.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_OptionalExtensionMarker.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ComponentTypeLists_3:
					// emit syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList "," ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

					s += m_RootComponentTypeList.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += m_ExtensionAndException.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ExtensionAdditions.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ExtensionEndMarker.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += m_RootComponentTypeList_1.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ComponentTypeLists_4:
					// emit syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

					s += m_ExtensionAndException.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ExtensionAdditions.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ExtensionEndMarker.EmitProductionTree (depth - 1);
					s += ' ';
					s += "comma";
					s += ' ';
					s += m_RootComponentTypeList.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ComponentTypeLists_5:
					// emit syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException ExtensionAdditions OptionalExtensionMarker

					s += m_ExtensionAndException.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_ExtensionAdditions.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_OptionalExtensionMarker.EmitProductionTree (depth - 1);
				break;
				case production_kind.g_ComponentTypeLists_6:
					// emit syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException OptionalExtensionMarker

					s += m_ExtensionAndException.EmitProductionTree (depth - 1);
					s += ' ';
					s += m_OptionalExtensionMarker.EmitProductionTree (depth - 1);
				break;
			}
			s += ")";
			return s;
		}
		#endregion
		#region Syntax tree traversal,  reperrent, init and iterator methods associated with the syntax rule ComponentTypeLists

		//
		// traverse sub-tree rooted in this node using selected syntax tree walker
		//

		public override void InvokeTraverse (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).Traverse (this);
		public override void InvokeTraverseCommon (SyntaxTreeWalkerCore syntaxTreeWalker) => ((SyntaxTreeWalker) syntaxTreeWalker).TraverseCommon (this);

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentTypeLists with specified delegate
		//

		public override void Visit (Func<SyntaxTreeCallbackReason, int, SyntaxTreeBase, object, bool> visitor, object appData)
		{
			ComponentTypeLists.production_kind kind = (ComponentTypeLists.production_kind) this.kind;
			if (visitor (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, this, appData))
			switch (kind)
			{
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_1:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList

						m_RootComponentTypeList.Visit (visitor, appData);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_2:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList "," ExtensionAndException ExtensionAdditions OptionalExtensionMarker

						m_RootComponentTypeList.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
						m_ExtensionAndException.Visit (visitor, appData);
						m_ExtensionAdditions.Visit (visitor, appData);
						m_OptionalExtensionMarker.Visit (visitor, appData);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_3:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList "," ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

						m_RootComponentTypeList.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
						m_ExtensionAndException.Visit (visitor, appData);
						m_ExtensionAdditions.Visit (visitor, appData);
						m_ExtensionEndMarker.Visit (visitor, appData);
						m_comma_1.Visit (visitor, appData);
						m_RootComponentTypeList_1.Visit (visitor, appData);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_4:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

						m_ExtensionAndException.Visit (visitor, appData);
						m_ExtensionAdditions.Visit (visitor, appData);
						m_ExtensionEndMarker.Visit (visitor, appData);
						m_comma.Visit (visitor, appData);
						m_RootComponentTypeList.Visit (visitor, appData);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_5:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException ExtensionAdditions OptionalExtensionMarker

						m_ExtensionAndException.Visit (visitor, appData);
						m_ExtensionAdditions.Visit (visitor, appData);
						m_OptionalExtensionMarker.Visit (visitor, appData);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_6:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException OptionalExtensionMarker

						m_ExtensionAndException.Visit (visitor, appData);
						m_OptionalExtensionMarker.Visit (visitor, appData);
				break;
			}
			visitor (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, this, appData);
		}

		// reparent sub-tree

		public override void reparent (SyntaxTreeBase parent)
		{
			this.parent = parent;

			m_RootComponentTypeList?.reparent (this);
			m_RootComponentTypeList_1?.reparent (this);

			m_comma?.reparent (this);
			m_comma_1?.reparent (this);

			m_ExtensionAndException?.reparent (this);
			m_ExtensionAdditions?.reparent (this);
			m_OptionalExtensionMarker?.reparent (this);
			m_ExtensionEndMarker?.reparent (this);
		}

		//
		// initialize object associated with syntax rule ComponentTypeLists
		//

		public void _init ()
		{
			m_RootComponentTypeList = null;
			m_RootComponentTypeList_1 = null;
			m_comma = null;
			m_comma_1 = null;
			m_ExtensionAndException = null;
			m_ExtensionAdditions = null;
			m_OptionalExtensionMarker = null;
			m_ExtensionEndMarker = null;
		}
		#endregion
		#region Fields and properties associated with the syntax rule ComponentTypeLists

		// counter of all nodes associated with syntax rule ComponentTypeLists
		public static int g_counter;

		// objects associated with terminal and non-terminal symbols within production(s) of syntax rule ComponentTypeLists
		[DataMember (Name = "m_RootComponentTypeList")] public RootComponentTypeList m_RootComponentTypeList { get; private set; }
		[DataMember (Name = "m_RootComponentTypeList_1")] public RootComponentTypeList m_RootComponentTypeList_1 { get; private set; }
		[DataMember (Name = "m_comma")] public SyntaxTreeToken m_comma { get; private set; }
		[DataMember (Name = "m_comma_1")] public SyntaxTreeToken m_comma_1 { get; private set; }
		[DataMember (Name = "m_ExtensionAndException")] public ExtensionAndException m_ExtensionAndException { get; private set; }
		[DataMember (Name = "m_ExtensionAdditions")] public ExtensionAdditions m_ExtensionAdditions { get; private set; }
		[DataMember (Name = "m_OptionalExtensionMarker")] public OptionalExtensionMarker m_OptionalExtensionMarker { get; private set; }
		[DataMember (Name = "m_ExtensionEndMarker")] public ExtensionEndMarker m_ExtensionEndMarker { get; private set; }

		public enum __p2_markers
		{
			m1 = 1,
		};

		public enum __p3_markers
		{
			m1 = 1,
			m2 = 4,
		};

		public enum __p4_markers
		{
			m1 = 3,
		};
		#endregion

	};

	public partial class SyntaxTreeWalker
	{
		#region delegates and events associated with the syntax rule ComponentTypeLists

		// delegate function (callback) prototype associated with syntax rule ComponentTypeLists
		public delegate bool ComponentTypeLists_Callback (SyntaxTreeCallbackReason reason, ComponentTypeLists.production_kind kind, ComponentTypeLists p_ComponentTypeLists);

		// event associated with syntax rule ComponentTypeLists
		public event ComponentTypeLists_Callback ComponentTypeLists_Event;

		// event trigger associated with syntax rule ComponentTypeLists
		public bool Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason reason, ComponentTypeLists.production_kind kind, ComponentTypeLists p_ComponentTypeLists)
		{
			bool? status = ComponentTypeLists_Event?.Invoke (reason, kind, p_ComponentTypeLists);
			return (status == null) || status.Value;
		}
		#endregion
		#region syntax tree traversal methods associated with the syntax rule ComponentTypeLists
		//
		// traverse syntax tree node associated with any production of syntax rule ComponentTypeLists
		//

		public void Traverse (ComponentTypeLists p_ComponentTypeLists)
		{
			if (p_ComponentTypeLists.isLocked())
				return;
			p_ComponentTypeLists.dolock();
			ComponentTypeLists.production_kind kind = (ComponentTypeLists.production_kind) p_ComponentTypeLists.kind;
			p_ComponentTypeLists.turn_reset ();
			if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, kind, p_ComponentTypeLists))
			switch (kind)
			{
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_1:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList

					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_RootComponentTypeList);
					p_ComponentTypeLists.turn_inc ();
					Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_2:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList "," ExtensionAndException ExtensionAdditions OptionalExtensionMarker

					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_RootComponentTypeList);
					p_ComponentTypeLists.turn_inc ();
					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_ExtensionAndException);
					p_ComponentTypeLists.turn_inc ();
					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_ExtensionAdditions);
					p_ComponentTypeLists.turn_inc ();
					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_OptionalExtensionMarker);
					p_ComponentTypeLists.turn_inc ();
					Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_3:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList "," ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_RootComponentTypeList);
					p_ComponentTypeLists.turn_inc ();
					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_ExtensionAndException);
					p_ComponentTypeLists.turn_inc ();
					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_ExtensionAdditions);
					p_ComponentTypeLists.turn_inc ();
					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_ExtensionEndMarker);
					p_ComponentTypeLists.turn_inc ();
					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_RootComponentTypeList_1);
					p_ComponentTypeLists.turn_inc ();
					Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_4:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_ExtensionAndException);
					p_ComponentTypeLists.turn_inc ();
					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_ExtensionAdditions);
					p_ComponentTypeLists.turn_inc ();
					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_ExtensionEndMarker);
					p_ComponentTypeLists.turn_inc ();
					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_RootComponentTypeList);
					p_ComponentTypeLists.turn_inc ();
					Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_5:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException ExtensionAdditions OptionalExtensionMarker

					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_ExtensionAndException);
					p_ComponentTypeLists.turn_inc ();
					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_ExtensionAdditions);
					p_ComponentTypeLists.turn_inc ();
					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_OptionalExtensionMarker);
					p_ComponentTypeLists.turn_inc ();
					Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_6:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException OptionalExtensionMarker

					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_ExtensionAndException);
					p_ComponentTypeLists.turn_inc ();
					if (Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists))
						Traverse (p_ComponentTypeLists.m_OptionalExtensionMarker);
					p_ComponentTypeLists.turn_inc ();
					Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalMidTermCallbackReason, kind, p_ComponentTypeLists);
				break;
			}
			Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, kind, p_ComponentTypeLists);
			p_ComponentTypeLists.unlock();
		}

		//
		// traverse syntax tree node associated with any production of syntax rule ComponentTypeLists
		//

		public void TraverseCommon (ComponentTypeLists p_ComponentTypeLists)
		{
			ComponentTypeLists.production_kind kind = (ComponentTypeLists.production_kind) p_ComponentTypeLists.kind;
			if (Raise_Common_Event (SyntaxTreeCallbackReason.TraversalPrologueCallbackReason, (int) kind, p_ComponentTypeLists))
			switch (kind)
			{
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_1:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList

						TraverseCommon (p_ComponentTypeLists.m_RootComponentTypeList);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_2:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList "," ExtensionAndException ExtensionAdditions OptionalExtensionMarker

						TraverseCommon (p_ComponentTypeLists.m_RootComponentTypeList);
						TraverseCommon (p_ComponentTypeLists.m_comma);
						TraverseCommon (p_ComponentTypeLists.m_ExtensionAndException);
						TraverseCommon (p_ComponentTypeLists.m_ExtensionAdditions);
						TraverseCommon (p_ComponentTypeLists.m_OptionalExtensionMarker);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_3:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: RootComponentTypeList "," ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

						TraverseCommon (p_ComponentTypeLists.m_RootComponentTypeList);
						TraverseCommon (p_ComponentTypeLists.m_comma);
						TraverseCommon (p_ComponentTypeLists.m_ExtensionAndException);
						TraverseCommon (p_ComponentTypeLists.m_ExtensionAdditions);
						TraverseCommon (p_ComponentTypeLists.m_ExtensionEndMarker);
						TraverseCommon (p_ComponentTypeLists.m_comma_1);
						TraverseCommon (p_ComponentTypeLists.m_RootComponentTypeList_1);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_4:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

						TraverseCommon (p_ComponentTypeLists.m_ExtensionAndException);
						TraverseCommon (p_ComponentTypeLists.m_ExtensionAdditions);
						TraverseCommon (p_ComponentTypeLists.m_ExtensionEndMarker);
						TraverseCommon (p_ComponentTypeLists.m_comma);
						TraverseCommon (p_ComponentTypeLists.m_RootComponentTypeList);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_5:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException ExtensionAdditions OptionalExtensionMarker

						TraverseCommon (p_ComponentTypeLists.m_ExtensionAndException);
						TraverseCommon (p_ComponentTypeLists.m_ExtensionAdditions);
						TraverseCommon (p_ComponentTypeLists.m_OptionalExtensionMarker);
				break;
				case ComponentTypeLists.production_kind.g_ComponentTypeLists_6:
					// traverse syntax tree node associated with production
					// ComponentTypeLists: ExtensionAndException OptionalExtensionMarker

						TraverseCommon (p_ComponentTypeLists.m_ExtensionAndException);
						TraverseCommon (p_ComponentTypeLists.m_OptionalExtensionMarker);
				break;
			}
			Raise_Common_Event (SyntaxTreeCallbackReason.TraversalEpilogueCallbackReason, (int) kind, p_ComponentTypeLists);
		}
	};
		#endregion

	public partial class SyntaxTreeBuilder : SyntaxTreeWalker
	{
		#region syntax tree builder methods associated with the syntax rule ComponentTypeLists

		//
		// create syntax tree node associated with production
		// ComponentTypeLists: RootComponentTypeList

		//

		public ComponentTypeLists ComponentTypeLists_1 (RootComponentTypeList p_RootComponentTypeList)
		{
			ComponentTypeLists p_ComponentTypeLists_ref = new ComponentTypeLists(p_RootComponentTypeList);
			p_RootComponentTypeList.parent = p_ComponentTypeLists_ref;
			Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentTypeLists.production_kind.g_ComponentTypeLists_1, p_ComponentTypeLists_ref);
			return p_ComponentTypeLists_ref;
		}

		//
		// create syntax tree node associated with production
		// ComponentTypeLists: RootComponentTypeList "," ExtensionAndException ExtensionAdditions OptionalExtensionMarker

		//

		public ComponentTypeLists ComponentTypeLists_2 (RootComponentTypeList p_RootComponentTypeList, SyntaxTreeToken p_token, ExtensionAndException p_ExtensionAndException, ExtensionAdditions p_ExtensionAdditions, OptionalExtensionMarker p_OptionalExtensionMarker)
		{
			ComponentTypeLists p_ComponentTypeLists_ref = new ComponentTypeLists(p_RootComponentTypeList, p_token, p_ExtensionAndException, p_ExtensionAdditions, p_OptionalExtensionMarker);
			p_RootComponentTypeList.parent = p_ComponentTypeLists_ref;
			p_token.parent = p_ComponentTypeLists_ref;
			p_ExtensionAndException.parent = p_ComponentTypeLists_ref;
			p_ExtensionAdditions.parent = p_ComponentTypeLists_ref;
			p_OptionalExtensionMarker.parent = p_ComponentTypeLists_ref;
			Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentTypeLists.production_kind.g_ComponentTypeLists_2, p_ComponentTypeLists_ref);
			return p_ComponentTypeLists_ref;
		}

		//
		// create syntax tree node associated with production
		// ComponentTypeLists: RootComponentTypeList "," ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

		//

		public ComponentTypeLists ComponentTypeLists_3 (RootComponentTypeList p_RootComponentTypeList, SyntaxTreeToken p_token, ExtensionAndException p_ExtensionAndException, ExtensionAdditions p_ExtensionAdditions, ExtensionEndMarker p_ExtensionEndMarker, SyntaxTreeToken p_token_1, RootComponentTypeList p_RootComponentTypeList_1)
		{
			ComponentTypeLists p_ComponentTypeLists_ref = new ComponentTypeLists(p_RootComponentTypeList, p_token, p_ExtensionAndException, p_ExtensionAdditions, p_ExtensionEndMarker, p_token_1, p_RootComponentTypeList_1);
			p_RootComponentTypeList.parent = p_ComponentTypeLists_ref;
			p_token.parent = p_ComponentTypeLists_ref;
			p_ExtensionAndException.parent = p_ComponentTypeLists_ref;
			p_ExtensionAdditions.parent = p_ComponentTypeLists_ref;
			p_ExtensionEndMarker.parent = p_ComponentTypeLists_ref;
			p_token_1.parent = p_ComponentTypeLists_ref;
			p_RootComponentTypeList_1.parent = p_ComponentTypeLists_ref;
			Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentTypeLists.production_kind.g_ComponentTypeLists_3, p_ComponentTypeLists_ref);
			return p_ComponentTypeLists_ref;
		}

		//
		// create syntax tree node associated with production
		// ComponentTypeLists: ExtensionAndException ExtensionAdditions ExtensionEndMarker "," RootComponentTypeList

		//

		public ComponentTypeLists ComponentTypeLists_4 (ExtensionAndException p_ExtensionAndException, ExtensionAdditions p_ExtensionAdditions, ExtensionEndMarker p_ExtensionEndMarker, SyntaxTreeToken p_token, RootComponentTypeList p_RootComponentTypeList)
		{
			ComponentTypeLists p_ComponentTypeLists_ref = new ComponentTypeLists(p_ExtensionAndException, p_ExtensionAdditions, p_ExtensionEndMarker, p_token, p_RootComponentTypeList);
			p_ExtensionAndException.parent = p_ComponentTypeLists_ref;
			p_ExtensionAdditions.parent = p_ComponentTypeLists_ref;
			p_ExtensionEndMarker.parent = p_ComponentTypeLists_ref;
			p_token.parent = p_ComponentTypeLists_ref;
			p_RootComponentTypeList.parent = p_ComponentTypeLists_ref;
			Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentTypeLists.production_kind.g_ComponentTypeLists_4, p_ComponentTypeLists_ref);
			return p_ComponentTypeLists_ref;
		}

		//
		// create syntax tree node associated with production
		// ComponentTypeLists: ExtensionAndException ExtensionAdditions OptionalExtensionMarker

		//

		public ComponentTypeLists ComponentTypeLists_5 (ExtensionAndException p_ExtensionAndException, ExtensionAdditions p_ExtensionAdditions, OptionalExtensionMarker p_OptionalExtensionMarker)
		{
			ComponentTypeLists p_ComponentTypeLists_ref = new ComponentTypeLists(p_ExtensionAndException, p_ExtensionAdditions, p_OptionalExtensionMarker);
			p_ExtensionAndException.parent = p_ComponentTypeLists_ref;
			p_ExtensionAdditions.parent = p_ComponentTypeLists_ref;
			p_OptionalExtensionMarker.parent = p_ComponentTypeLists_ref;
			Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentTypeLists.production_kind.g_ComponentTypeLists_5, p_ComponentTypeLists_ref);
			return p_ComponentTypeLists_ref;
		}

		//
		// create syntax tree node associated with production
		// ComponentTypeLists: ExtensionAndException OptionalExtensionMarker

		//

		public ComponentTypeLists ComponentTypeLists_6 (ExtensionAndException p_ExtensionAndException, OptionalExtensionMarker p_OptionalExtensionMarker)
		{
			ComponentTypeLists p_ComponentTypeLists_ref = new ComponentTypeLists(p_ExtensionAndException, p_OptionalExtensionMarker);
			p_ExtensionAndException.parent = p_ComponentTypeLists_ref;
			p_OptionalExtensionMarker.parent = p_ComponentTypeLists_ref;
			Raise_ComponentTypeLists_Event (SyntaxTreeCallbackReason.BuilderCallbackReason, ComponentTypeLists.production_kind.g_ComponentTypeLists_6, p_ComponentTypeLists_ref);
			return p_ComponentTypeLists_ref;
		}
		#endregion
	};
}
