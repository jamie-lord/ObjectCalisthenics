using System.Collections.Generic;

namespace ObjectCalisthenics
{
    public static class SymbolDictionaries
    {
        private static readonly IEnumerable<Symbol> _romanSymbols = new List<Symbol>()
        {
            { new Symbol(new ArabicNumber(1000), "M") },
            { new Symbol(new ArabicNumber(900), "CM") },
            { new Symbol(new ArabicNumber(500), "D") },
            { new Symbol(new ArabicNumber(400), "CD") },
            { new Symbol(new ArabicNumber(100), "C") },
            { new Symbol(new ArabicNumber(90), "XC") },
            { new Symbol(new ArabicNumber(50), "L") },
            { new Symbol(new ArabicNumber(40), "XL") },
            { new Symbol(new ArabicNumber(10), "X") },
            { new Symbol(new ArabicNumber(9), "IX") },
            { new Symbol(new ArabicNumber(5), "V") },
            { new Symbol(new ArabicNumber(4), "IV") },
            { new Symbol(new ArabicNumber(1), "I") }
        };

        public static IEnumerable<Symbol> GetRomanSymbols()
        {
            return _romanSymbols;
        }
    }
}
