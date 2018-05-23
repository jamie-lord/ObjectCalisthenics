using System;

namespace ObjectCalisthenics
{
    public class RomanNumerator
    {
        public static string Convert(int arabic)
        {
            if (arabic < 1)
            {
                return string.Empty;
            }
            if (arabic >= 1000)
            {
                return "M" + Convert(arabic - 1000);
            }
            if (arabic >= 900)
            {
                return "CM" + Convert(arabic - 900);
            }
            if (arabic >= 500)
            {
                return "D" + Convert(arabic - 500);
            }
            if (arabic >= 400)
            {
                return "CD" + Convert(arabic - 400);
            }
            if (arabic >= 100)
            {
                return "C" + Convert(arabic - 100);
            }
            if (arabic >= 90)
            {
                return "XC" + Convert(arabic - 90);
            }
            if (arabic >= 50)
            {
                return "L" + Convert(arabic - 50);
            }
            if (arabic >= 40)
            {
                return "XL" + Convert(arabic - 40);
            }
            if (arabic >= 10)
            {
                return "X" + Convert(arabic - 10);
            }
            if (arabic >= 9)
            {
                return "IX" + Convert(arabic - 9);
            }
            if (arabic >= 5)
            {
                return "V" + Convert(arabic - 5);
            }
            if (arabic >= 4)
            {
                return "IV" + Convert(arabic - 4);
            }
            if (arabic >= 1)
            {
                return "I" + Convert(arabic - 1);
            }
            throw new ArgumentOutOfRangeException("Something went wrong");
        }
    }
}