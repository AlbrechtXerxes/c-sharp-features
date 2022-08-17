using System;
using Xunit;

namespace YTCSharpFeatures.Test
{
    public class UsingDeclarationTest
    {
        [Fact]
        public void UsingExpressionTest()
        {
            // Old style  
            using (var someClass1 = new SomeClass())
            {
                Console.WriteLine(someClass1.MyProperty);
            }
            //Now Dispose() is called

            //Some extra values
            Console.WriteLine();
            var a = 1 + 2;
            var b = 3;
        }

        [Fact]
        public void LessControlForDisposal()
        {
            using var someClass = new SomeClass();
            Console.WriteLine(someClass);
            someClass.Dispose();
            //we ended operations for SomeClass object, but Dispose() was not called
            //Some extra values
            Console.WriteLine();
            var a = 1 + 2;
            var b = 3;
            //Now Dispose() is called
        }
    }

    class SomeClass : IDisposable
    {
        public int MyProperty { get; set; }
        public void Dispose()
        {
            Console.WriteLine("Disposing");
        }
    }
}
