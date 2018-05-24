using System.Text;

namespace ObjectCalisthenics
{
    public class SymbolStringBuilder
    {
        private StringBuilder _stringBuilder = new StringBuilder();

        public string GetValue()
        {
            return _stringBuilder.ToString();
        }

        public void Append(SymbolResult result)
        {
            var symbolValue = result.GetSymbolResult();
            _stringBuilder.Append(symbolValue);
        }
    }
}