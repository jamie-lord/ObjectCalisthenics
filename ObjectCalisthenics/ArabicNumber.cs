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

        public bool GreaterThanOrEqualTo(ArabicNumber anotherNumber)
        {
            return _arabicNumber >= anotherNumber.ToInt();
        }

        public void SubtractFrom(ArabicNumber anotherNumber)
        {
            _arabicNumber -= anotherNumber.ToInt();
        }
    }
}