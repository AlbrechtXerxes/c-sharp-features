using Xunit;

namespace CSharp10Features.Test
{
    public class RecordStructsTest
    {
        [Fact]
        public void RunRecordStructsTest()
        {
            var r1 = new Product1(1);
            var r2 = new Product2(1);
            var r3 = new Product3(1);

            //Record class by default is immutable, but struct isn't.
            //We can change it writing a code.
            //r1.A = 1;
            r3.A = 1;
        }
    }

    interface ISomething { void DoSomething() { } }

    //We can inherit interface in both types
    //record class
    public record class Product1(int A) : ISomething;
    //record class
    public record Product2(int A) : Product1(A), ISomething;
    //record struct
    public record struct Product3(int A) : ISomething;
    //Cannot inherit struct to struct
    //public record struct Product4(int A) : Product3(A);
}
