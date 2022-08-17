using Xunit;

namespace YTCSharpFeatures.Test
{
    public class LocalFunctionTest
    {
        [Fact]
        public void LocalFunctionSimpleTest()
        {
            var result = MethodWithLocalFunc();
        }

        public int MethodWithLocalFunc()
        {
            int y;
            var sum = Add(1, 2);
            LocalFunction();
            return y + sum;

            void LocalFunction() => y = 10;
            static int Add(int left, int right) => left + right;
        }
    }

}
