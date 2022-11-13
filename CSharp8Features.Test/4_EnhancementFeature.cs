using System.Collections.Generic;
using Xunit;
namespace CSharp9Features.Test
{
    public class EnhancementFeature
    {
        [Fact]
        public void EnhancementTest()
        {
            var @char = 'a';
            var result1 = @char is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
            var result2 = @char is 'z' or 'w';
            var result3 = @char is 'z' or 'a';

            int number = 1;
            var result4 = number is 5 and < 10;
            var result5 = number is > -10 and < 10;
            var result6 = number is > 5 or 1;
            var result7 = number is (> 5 and 1 or < 2) or 0;

            string x = null;
            if (x is not null)
            {
            }
        }
    }
}
