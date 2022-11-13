using Xunit;
namespace CSharp10Features.Test
{
    public class DeconstructTest
    {
        [Fact]
        public void Run()
        {
            var class1 = new MyClassDeconstructTest()
            {
                A = 1,
                B = 2
            };
            var something = class1;
            //C# 9 example1
            int x1, y1;
            (x1, y1) = class1;
            //C# 9 example2
            (int x, var y) = class1;

            //C# 10
            //Possible mix without-and-with new declaration variable
            int xx = 0;
            (xx, var yy) = class1;
        }
    }

    public class MyClassDeconstructTest
    {
        public int A { get; set; }
        public int B { get; set; }
        public void Deconstruct(out int a, out int b)
        {
            a = A;
            b = 10;
        }
    }
}
