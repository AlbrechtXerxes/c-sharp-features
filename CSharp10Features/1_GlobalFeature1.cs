//Here we have specified 'global' using
//Comment/uncomment to see difference
global using ModelNamespace;
//using ModelNamespace;

//Notes:
//1.We can have a separated file for it ex. "MyUsings.cs".
//2.Feature can be useful in big projects, where we have many usings.
//3.We can use it also in 'hobby-project'; if we specify everything global then we can always save a bit of time.

namespace CSharp10Features
{
    public class Feature1
    {
        public void SomeMethod()
        {
            SomeGlobalModel someModel = new SomeGlobalModel();
        }
    }
}
