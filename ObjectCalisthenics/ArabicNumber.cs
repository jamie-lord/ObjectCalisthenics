namespace ObjectCalisthenics
{
    public class ArabicNumber
    {
        private int _arabicNumber;
        public ArabicNumber(int value)
        {
            _arabicNumber = value;
        }

        public int ToInt()
        {
            return _arabicNumber;
        }

        public bool GreaterThanOrEqualTo(Symbol symbol)
        {
            ArabicNumber number = symbol.GetArabicNumber();
            return _arabicNumber >= number.ToInt();
        }

        public void SubtractFrom(Symbol symbol)
        {
            ArabicNumber number = symbol.GetArabicNumber();
            _arabicNumber -= number.ToInt();
        }
    }
}