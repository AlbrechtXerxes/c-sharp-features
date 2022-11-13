using Xunit;
namespace CSharp10Features.Test
{
    public class NullCheckFeatureTest
    {
        [Fact]
        public void Run()
        {
            string someVar = null;
            SomeMethod(someVar);
        }

        public void SomeMethod(string value)
        {
            //Old approach
            if (value == null)
            {
                throw new ArgumentNullException(value);
            }

            //New shorter version
            ArgumentNullException.ThrowIfNull(value);
        }
    }
}
