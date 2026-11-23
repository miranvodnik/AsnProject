using Anglr.Parser.Core;
using Anglr.Parser.SyntaxTree;
using Anglr.Parser.Walker;
using Asn.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AsnLibrary
{
    public class AsnSymbol
    {
        public AsnSymbol (string name, AsnSymbol context, SyntaxTreeBase node)
        {
            Name = name;
            Context = context;
            Reference = null;
            Node = node;
            Flags = 0;
            Specie = SymbolSpecie.UndefinedSpecie;
        }
        public string Path => (Context != null) ? Context.Path + '.' + Name : Name;
        public AsnSymbol DefiningReference
        {
            get
            {
                if (isLoop)
                    return this;
                isLoop = true;
                AsnSymbol sym = (Reference == null) ? this : (Reference == this) ? this : Reference.DefiningReference;
                isLoop = false;
                return sym;
            }
        }
        public AsnSymbol DefiningIdentity
        {
            get
            {
                if (isLoop)
                    return this;
                isLoop = true;
                AsnSymbol sym = (Identity == null) ? this : (Identity == this) ? this : Reference.DefiningIdentity;
                isLoop = false;
                return sym;
            }
        }

        public AsnSymbol Identity { get; set; }
        public string Name { get; private set; }
        public AsnSymbol Context { get; private set; }
        public AsnSymbol Reference { get; set; }
        public SyntaxTreeBase Node { get; set; }
        public ushort Flags { get; set; }
        public SymbolSpecie Specie { get; set; }

        public const ushort Defined = (1 << 0);
        public const ushort Imported = (1 << 1);
        public const ushort Exported = (1 << 2);
        public const ushort Generated = (1 << 3);

        private bool isLoop = false;
        public enum SymbolSpecie
        {
            TypeSpecie = 1,
            ValueSpecie = 2,
            XMLValueSpecie = 3,
            ValueSetTypeSpecie = 4,
            ObjectClassSpecie = 5,
            ObjectSpecie = 6,
            ObjectSetSpecie = 7,
            ParameterizedTypeSpecie = 8,
            ParameterizedValueSpecie = 9,
            ParameterizedValueSetTypeSpecie = 10,
            ParameterizedObjectClassSpecie = 11,
            ParameterizedObjectSpecie = 12,
            ParameterizedObjectSetSpecie = 13,
            MacroVarSpecie = 14,
            MacroSpecie = 15,
            TypeFieldSpecie = 16,
            FixedTypeValueFieldSpecie = 17,
            VariableTypeValueFieldSpecie = 18,
            FixedTypeValueSetFieldSpecie = 19,
            VariableTypeValueSetFieldSpecie = 20,
            ObjectFieldSpecie = 21,
            ObjectSetFieldSpecie = 22,
            ReferenceSpecie = 23,
            ModuleSpecie = 24,
            ParameterSpecie = 25,
            ComponentSpecie = 26,
            EnumerationItemSpecie = 27,
            NamedNumberItemSpecie = 28,
            NamedBitSpecie = 29,

            UndefinedSpecie = ushort.MaxValue,
            InvalidSpecie = ushort.MaxValue - 1
        }
    }

    public class cmpsym : IEqualityComparer<AsnSymbol>
    {
        public bool Equals (AsnSymbol x, AsnSymbol y)
        {
            if (x.Name != y.Name)
                return false;
            if (x.Context != y.Context)
                return false;
            if ((x.Context == null) && (y.Context == null))
                return true;
            return Equals (x.Context, y.Context);
        }

        public int GetHashCode (AsnSymbol obj)
        {
            int hashCode = 0;
            for (; obj != null; obj = obj.Context)
                hashCode += obj.Name.GetHashCode ();
            return hashCode;
        }
    }

    public class SymbolTable : Dictionary<AsnSymbol, AsnSymbol>
    {
        public SymbolTable () : base (new cmpsym ())
        {
            add (new AsnSymbol ("joint-iso-itu-t", null, null));
        }
        public AsnSymbol find (AsnSymbol symbol) => TryGetValue (symbol, out AsnSymbol val) ? val : null;
        public void add (AsnSymbol symbol) => this [symbol] = symbol;

        public void display ()
        {
            int index = 0;
            (int counter, string comment) [] counters = new (int, string) []
            {
                (0, "undefined parameterized:"),
                (0, "undefined other:        "),
                (0, "defined parameterized:  "),
                (0, "defined other:          "),
                (0, "empty:                  ")
            };
            Console.WriteLine ($"SYMBOL TABLE:");
            foreach (AsnSymbol asnSymbol in Keys)
            {
                if (asnSymbol.Node != null)
                {
                    SyntaxTreeBase node = asnSymbol.Node;
                    if (asnSymbol.Specie == AsnSymbol.SymbolSpecie.UndefinedSpecie)
                    {
                        if (node.parent is ParameterizedAssignment)
                            ++counters [0].counter;
                        else
                            ++counters [1].counter;
                    }
                    else
                    {
                        if (node.parent is ParameterizedAssignment)
                            ++counters [2].counter;
                        else
                            ++counters [3].counter;
                    }
                    switch (asnSymbol.Specie)
                    {
                        case AsnSymbol.SymbolSpecie.TypeSpecie:
                        {
                            if (!(node is TypeAssignment))
                                break;
                            TypeAssignment typeAssignment = (TypeAssignment) node;
                            Asn.Parser.Type type = typeAssignment.m_Type;
                            if ((Asn.Parser.Type.production_kind) type.kind != Asn.Parser.Type.production_kind.g_Type_2)
                                break;
                            ReferencedType referencedType = type.m_ReferencedType;
                            ;
                        }
                        break;
                        case AsnSymbol.SymbolSpecie.ValueSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.XMLValueSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ValueSetTypeSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ObjectClassSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ObjectSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ObjectSetSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ParameterizedTypeSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ParameterizedValueSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ParameterizedValueSetTypeSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ParameterizedObjectClassSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ParameterizedObjectSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ParameterizedObjectSetSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.MacroVarSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.MacroSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.TypeFieldSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.FixedTypeValueFieldSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.VariableTypeValueFieldSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.FixedTypeValueSetFieldSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.VariableTypeValueSetFieldSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ObjectFieldSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ObjectSetFieldSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ReferenceSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ModuleSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.ParameterSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.UndefinedSpecie:
                            break;
                        case AsnSymbol.SymbolSpecie.InvalidSpecie:
                            break;
                    }
                }
                else
                    ++counters [4].counter;
                Console.Write ($"{++index,-6} ");
                if (asnSymbol.Node != null)
                    if (asnSymbol.DefiningReference.Node != null)
                        Console.WriteLine ($"{asnSymbol.Path} -- {asnSymbol.Specie} -- {asnSymbol.DefiningReference.Node.Emit (-1)}");
                    else
                        Console.WriteLine ($"{asnSymbol.Path} -- {asnSymbol.Specie} -- NO DEFINITION");
                else
                    Console.WriteLine ($"{asnSymbol.Path} -- {asnSymbol.Specie} -- NO NODE");
                while (true)
                {
                    AsnSymbol defSymbol = asnSymbol.DefiningReference;
                    SyntaxTreeBase node = defSymbol.Node;
                    if (node == null)
                        break;
                    if (node.appInfo == null)
                    {
                        //if ((asnSymbol.Specie != AsnSymbol.ModuleSpecie) && (asnSymbol.Specie != AsnSymbol.ParameterSpecie) && (asnSymbol.Specie != AsnSymbol.ReferenceSpecie))
                        Console.Error.WriteLine ($"ERROR: NODE WITHOUT APPINFO: {asnSymbol.Path} -- {asnSymbol.Specie}");
                        break;
                    }
                    if (!(node.appInfo is NodeInspector))
                        break;
                    break;
                }
            }
            Console.WriteLine ($"COUNTERS:");
            foreach ((int counter, string comment) in counters)
                Console.WriteLine ($"{comment} {counter}");
            Console.WriteLine ($"UNDEFINED PARAMETERIZED:");
            foreach (AsnSymbol asnSymbol in Keys)
            {
                if (asnSymbol.Node != null)
                {
                    SyntaxTreeBase node = asnSymbol.Node;
                    if (asnSymbol.Specie == AsnSymbol.SymbolSpecie.UndefinedSpecie)
                    {
                        if (node.parent is ParameterizedAssignment)
                            ;
                        else
                            continue;
                    }
                    else
                        continue;
                }
                else
                    continue;
                Console.WriteLine ($"{asnSymbol.Path} = {asnSymbol.Node.Emit (-1)}");
            }
            Console.WriteLine ($"UNDEFINED OTHER:");
            foreach (AsnSymbol asnSymbol in Keys)
            {
                if (asnSymbol.Node != null)
                {
                    SyntaxTreeBase node = asnSymbol.Node;
                    if (asnSymbol.Specie == AsnSymbol.SymbolSpecie.UndefinedSpecie)
                    {
                        if (node.parent is ParameterizedAssignment)
                            continue;
                        else
                            ;
                    }
                    else
                        continue;
                }
                else
                    continue;
                Console.WriteLine ($"{asnSymbol.Path} = {asnSymbol.Node.Emit (-1)}");
            }
        }
    }

    public struct ModuleDescriptor
    {
        public ModuleDescriptor (ModuleDefinition moduleDefinition, AsnSymbol moduleSymbol, string fileName)
        {
            this.moduleDefinition = moduleDefinition;
            this.moduleSymbol = moduleSymbol;
            this.fileName = fileName;
            timeSpan = TimeSpan.MinValue;
        }
        public ModuleDefinition moduleDefinition;
        public AsnSymbol moduleSymbol;
        public string fileName;
        public TimeSpan timeSpan;
    }

    public class ModuleCollection : Dictionary<string, List<ModuleDescriptor>> { }

    public class ReferenceCollection : Dictionary<AsnSymbol, AsnSymbol> { }

    public struct ParameterDescriptor
    {
        public ParameterDescriptor (ParamGovernor governor, DummyReference reference, string parName, string parValue)
        {
            this.governor = governor;
            this.reference = reference;
            this.parName = parName;
            this.parValue = parValue;
        }
        public ParamGovernor governor;
        public DummyReference reference;
        public string parName;
        public string parValue;
    }

    public class ParameterTable : List<ParameterDescriptor> { }
}
