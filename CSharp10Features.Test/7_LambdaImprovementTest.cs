using Xunit;

namespace CSharp10Features.Test
{
    public class LambdaImprovementTest
    {
        [Fact]
        public void FuncImprovementTest()
        {
            //C# 9
            Func<string> f1 = () => "abc";
            //C# 10 has shorter
            var f2 = () => "abc";

            //C# 9
            Func<int, object> f3 = object (int a) => a + "a";
            //C# 10 has shorter
            var f4 = object (int a) => a + "a";

            //result is: 10 + "a" = "10a"
            var someResult = f4(10);
        }

        [Fact]
        public void ActionImprovementTest()
        {
            //C# 9
            Action<string> f5 = (string a) => ActionMethod(a);
            //C# 10 has shorter
            var f6 = (string a) => ActionMethod(a);
            f6("123");
        }

        public static void ActionMethod(string arg)
        {
            Console.WriteLine("Hello Word");
        }
    }
}
