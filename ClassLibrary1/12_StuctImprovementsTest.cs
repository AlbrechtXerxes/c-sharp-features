using Xunit;
//We can test difference between C# 9 and C#10.
//Just go to -> SpecjalSingleTest.csproj
//And replace
//<TargetFramework>net5.0</TargetFramework> //C# 9
//with
//<TargetFramework>net6.0</TargetFramework> //C# 10
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
        public MyStruct1(int a)
        {
        }
    }

    public struct MyStruct2
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; init; }
        //public MyStruct2()
        //{
        //    MyProperty1 = 1;
        //    MyProperty2 = 2;
        //}
    }
}
