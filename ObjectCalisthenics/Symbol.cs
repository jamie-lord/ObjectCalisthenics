namespace ObjectCalisthenics
{
    public class Symbol
    {
        private ArabicNumber _number;
        private string _value;

        public Symbol(ArabicNumber number, string value)
        {
            _number = number;
            _value = value;
        }

        public ArabicNumber GetArabicNumber()
        {
            return _number;
        }

        public string GetValue()
        {
            return _value;
        }
    }
}