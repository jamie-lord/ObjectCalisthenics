namespace ObjectCalisthenics
{
    public static class RomanNumerator
    {
        public static string Convert(int value)
        {
            ArabicNumber arabic = new ArabicNumber(value);
            SymbolStringBuilder result = new SymbolStringBuilder();
            foreach (var item in SymbolDictionaries.GetRomanSymbols())
            {
                SymbolResult symbol = ProcessSymbol(ref arabic, item.Key, item.Value);
                result.Append(symbol);
            }
            return result.GetValue();
        }

        private static SymbolResult ProcessSymbol(ref ArabicNumber arabic, ArabicNumber value, string symbol)
        {
            SymbolResult result = new SymbolResult();
            while (arabic.GreaterThanOrEqualTo(value))
            {
                result.AppendToResult(symbol);
                arabic.SubtractFrom(value);
            }
            return result;
        }
    }
}