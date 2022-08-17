using System;
using System.Collections.Generic;
using Xunit;

namespace YTCSharpFeatures.Test
{
    public class IndexRangesTest
    {
        [Fact]
        public void IndexListTest()
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var newElement = list[^1];//7
        }

        [Fact]
        public void IndexTest()
        {
            Index i1 = 2; // number 2 from beginning counting from 0
            Index i2 = ^4; // number 4 from end
            //array not list
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var val1 = a[i1];//2
            var val2 = a[i2];//6
        }

        [Fact]
        public void RangeTest()
        {
            var range = 0..5;
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var slice1 = array[0..5];
            var slice2 = array[..];
            var slice3 = array[6..];
            var slice4 = array[..3];
            var slice5 = array[^2..^0];
        }
    }
}
