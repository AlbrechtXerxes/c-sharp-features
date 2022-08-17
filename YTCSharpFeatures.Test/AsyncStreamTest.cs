using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace YTCSharpFeatures.Test
{
    public class AsyncStreamTest
    {
        [Fact]
        public async Task RunClassThenInterfaceAsync()
        {
            var resultList = new List<int>();
            IAsyncEnumerator<int> e = GetBigResultsAsync().GetAsyncEnumerator();
            try
            {
                while (await e.MoveNextAsync())
                {
                    resultList.Add(e.Current);
                    Console.WriteLine(e.Current);
                }
            }
            finally { if (e != null) await e.DisposeAsync(); }

        }

        public async IAsyncEnumerable<int> GetBigResultsAsync()
        {
            await foreach (var result in GenerateSequence())
            {
                if (result > 5) yield return result;
            }
        }

        public static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
    }
}
