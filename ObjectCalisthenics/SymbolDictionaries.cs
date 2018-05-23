using System.Collections.Generic;

namespace ObjectCalisthenics
{
    public static class SymbolDictionaries
    {
        private static readonly Dictionary<int, string> _romanSymbols = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

        public static IEnumerable<KeyValuePair<int, string>> GetRomanSymbols()
        {
            return _romanSymbols;
        }
    }
}
