namespace ObjectCalisthenics
{
    public static class RomanNumerator
    {
        public static string Convert(int value)
        {
            ArabicNumber arabic = new ArabicNumber(value);
            SymbolStringBuilder result = new SymbolStringBuilder();
            foreach (Symbol symbol in SymbolDictionaries.GetRomanSymbols())
            {
                SymbolResult symbolResult = ProcessSymbol(ref arabic, symbol);
                result.Append(symbolResult);
            }
            return result.GetValue();
        }

        private static SymbolResult ProcessSymbol(ref ArabicNumber arabic, Symbol symbol)
        {
            SymbolResult result = new SymbolResult();
            while (arabic.GreaterThanOrEqualTo(symbol))
            {
                result.AppendToResult(symbol);
                arabic.SubtractFrom(symbol);
            }
            return result;
        }
    }
}