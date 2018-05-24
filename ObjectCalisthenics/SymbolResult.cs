namespace ObjectCalisthenics
{
    public class SymbolResult
    {
        private string _value = string.Empty;

        public string GetSymbolResult()
        {
            return _value;
        }

        public void AppendToResult(Symbol symbol)
        {
            _value += symbol.GetValue();
        }
    }
}