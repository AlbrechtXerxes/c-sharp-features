using Xunit;

namespace CSharp10Features.Test
{
    public class ExtendedPropertyPatternTest
    {
        [Fact]
        public void IfStatementTest()
        {
            var myClass = new MyClass()
            {
                MyNestedClass = new MyNestedClass()
                {
                    MyProperty = 10
                }
            };

            //C# 9
            if (myClass is MyClass { MyNestedClass: { MyProperty: > 5 } })
            {
            }
            //C# 10, the more nested expression, the more benefits
            //Usage: comparing nested types
            if (myClass is MyClass { MyNestedClass.MyProperty: > 5 })
            {
            }
        }
    }

    public class MyClass
    {
        public MyNestedClass MyNestedClass { get; set; }
    }

    public class MyNestedClass
    {
        public int MyProperty { get; set; }
    }
}
