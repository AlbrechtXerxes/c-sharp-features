using Xunit;
namespace CSharp10Features.Test
{
    public class StructImprovementsTest
    {
        [Fact]
        public void RunStructImprovementsTest()
        {
            var s1 = new MyStruct1();
            var s2 = new MyStruct2();
        }
    }
    public struct MyStruct1
    {
        //With C# 10
        public MyStruct1()
        {
        }
    }

    public struct MyStruct2
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; init; }

        //With C# 10
        public MyStruct2()
        {
            MyProperty1 = 1;
            MyProperty2 = 2;
        }
    }
}
