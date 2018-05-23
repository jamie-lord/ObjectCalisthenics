using System;
using ObjectCalisthenics;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test()
        {
            int arabic = 1;
            string result = RomanNumerator.Convert(arabic);

            Assert.Equal("I", result);
        }
    }
}
