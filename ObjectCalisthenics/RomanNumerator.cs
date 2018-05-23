using System.Collections.Generic;
using System.Text;

namespace ObjectCalisthenics
{
    public class RomanNumerator
    {
        private readonly Dictionary<int, string> _symbolDictionary = new Dictionary<int, string>
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

        private StringBuilder _result = new StringBuilder();

        public string Convert(int arabic)
        {
            foreach (var item in _symbolDictionary)
            {
                ProcessSymbol(ref arabic, item.Key, item.Value);
            }

            return _result.ToString();
        }

        private void ProcessSymbol(ref int arabic, int value, string symbol)
        {
            while (arabic >= value)
            {
                _result.Append(symbol);
                arabic -= value;
            }
        }
    }
}