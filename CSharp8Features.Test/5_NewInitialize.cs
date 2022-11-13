using System.Collections.Generic;
using Xunit;

namespace CSharp9Features.Test
{
    public class _5_NewInitialize
    {
        [Fact]
        public void ShortExpressionWithNewKeyword()
        {
            //Shorter initialization without keyword "PersonShortRecord"
            PersonShortRecord record2 = new("Doe", "Joe");
            //And it's the same for ex. List and Class
            List<int> myList = new();
            ClassWithComplexType class1 = new();
        }
    }
}
