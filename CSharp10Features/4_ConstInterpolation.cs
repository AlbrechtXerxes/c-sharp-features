namespace CSharp10Features
{
    public class ConstInterpolation
    {
        //Before C# 10
        public const string MY_VAR_OLD1 = "old_1";
        public const string MY_VAR_OLD2 = "old_2";
        //C# 10 enables modifying const
        public const string MY_VAR2 = $"Now we can combine strings in 'const': {MY_VAR_OLD1} and " + MY_VAR_OLD2;
    }
}
