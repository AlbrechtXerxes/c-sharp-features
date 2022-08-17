namespace YTCSharpFeatures
{
    public class DefaultInterfaceMethods : ISomeValue
    {
        public int GetInerfaceValue()
        {
            return ((ISomeValue)this).GetSomeValue();
        }

        //if we comment then we don't override
        public int GetSomeValue()
        {
            return 20;
        }
    }

    public interface ISomeValue
    {
        public int GetSomeValue()
        {
            return 10;
        }

        public static int GetSomeValueStatic()
        {
            return 30;
        }
    }
}
