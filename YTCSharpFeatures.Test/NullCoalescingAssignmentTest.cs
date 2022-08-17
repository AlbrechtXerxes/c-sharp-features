using Xunit;

namespace YTCSharpFeatures.Test
{
    public class NullCoalescingTest
    {
        [Fact]
        public void NullCoalescingAssignmentTest()
        {
            int? i = null;
            i ??= 17;//here adds 17
            i ??= 20;//here keps 17
        }
    }
}
