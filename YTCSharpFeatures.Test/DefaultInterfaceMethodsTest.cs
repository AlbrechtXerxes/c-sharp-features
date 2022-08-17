using Xunit;

namespace YTCSharpFeatures.Test
{
    public class DefaultInterfaceMethodsTest
    {
        [Fact]
        public void RunClassThenInterface()
        {
            var instanceClass = new DefaultInterfaceMethods();
            var value = instanceClass.GetInerfaceValue();
        }

        [Fact]
        public void RunInterfaceMethodDirectly()
        {
            ISomeValue instanceInteface = new DefaultInterfaceMethods();
            var value = instanceInteface.GetSomeValue();
        }

        [Fact]
        public void RunInterfaceStaticMethodDirectly()
        {
            var value = ISomeValue.GetSomeValueStatic();
        }
    }
}