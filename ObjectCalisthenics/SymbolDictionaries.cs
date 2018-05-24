using System.Collections.Generic;

namespace ObjectCalisthenics
{
    public static class SymbolDictionaries
    {
        private static readonly Dictionary<ArabicNumber, string> _romanSymbols = new Dictionary<ArabicNumber, string>
        {
            { new ArabicNumber(1000), "M" },
            { new ArabicNumber(900), "CM" },
            { new ArabicNumber(500), "D" },
            { new ArabicNumber(400), "CD" },
            { new ArabicNumber(100), "C" },
            { new ArabicNumber(90), "XC" },
            { new ArabicNumber(50), "L" },
            { new ArabicNumber(40), "XL" },
            { new ArabicNumber(10), "X" },
            { new ArabicNumber(9), "IX" },
            { new ArabicNumber(5), "V" },
            { new ArabicNumber(4), "IV" },
            { new ArabicNumber(1), "I" },
        };

        public static IEnumerable<KeyValuePair<ArabicNumber, string>> GetRomanSymbols()
        {
            return _romanSymbols;
        }
    }
}
