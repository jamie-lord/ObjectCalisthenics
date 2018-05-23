using System.Text;

namespace ObjectCalisthenics
{
    public static class RomanNumerator
    {
        public static string Convert(int arabic)
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in SymbolDictionaries.GetRomanSymbols())
            {
                string symbol = ProcessSymbol(ref arabic, item.Key, item.Value);
                result.Append(symbol);
            }
            return result.ToString();
        }

        private static string ProcessSymbol(ref int arabic, int value, string symbol)
        {
            string result = string.Empty;
            while (arabic >= value)
            {
                result += symbol;
                arabic -= value;
            }
            return result;
        }
    }
}