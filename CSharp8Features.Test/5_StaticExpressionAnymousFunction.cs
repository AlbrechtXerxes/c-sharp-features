using System;
using Xunit;
namespace CSharp9Features.Test
{
    public class StaticExpressionAnonymousFunction
    {
        public class SomeClass
        {
            public const string templateString = "{0} - static property that we can reuse";
            public string DisplayText(Func<string, string> func)
            {
                return func("My input value");
            }
        }

        [Fact]
        public void StaticExpressionTest()
        {
            var someClass = new SomeClass();
            //Here we use 'static text' to reduce memory alocation
            //Anonymous Function creates demands extra memory
            //Thank to this feature we can reuse resources
            //This operation may have sense for bigger objects
            var result = someClass.DisplayText(static text => string.Format(SomeClass.templateString, text));
        }
    }
}
