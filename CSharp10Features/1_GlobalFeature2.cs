namespace CSharp10Features
{
    //Here we don't have using 'ModelNamespace' even we use 'SomeGlobalModel'.
    //This works because we have global using in another file.
    internal class Feature2
    {
        public void SomeMethod()
        {
            SomeGlobalModel someModel = new();
        }
    }
}
