using Xunit;
namespace CSharp9Features.Test
{
    public class InitFeature
    {
        public class SomeClass
        {
            public int MyProperty1 { get; set; }
            public int MyProperty2 { get; init; }
        }

        [Fact]
        public void InitFeatureWithClass()
        {
            var myClass = new SomeClass()
            {
                MyProperty1 = 1,
                MyProperty2 = 1
            };

            myClass.MyProperty1 = 2;
            //We cannot change it, because it is 'init'
            //myClass.MyProperty2 = 2;
        }
    }
}
