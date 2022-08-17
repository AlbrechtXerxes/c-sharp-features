using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace YTCSharpFeatures
{
    //versions
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version
    class Program
    {
        static async Task Main()
        {
            await RunClassThenInterfaceAsync();
        }

        public static async Task RunClassThenInterfaceAsync()
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

        public static async IAsyncEnumerable<int> GetBigResultsAsync()
        {
            await foreach (var result in GenerateSequence())
            {
                if (result > 5) yield return result;
            }
        }

        public static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 15; i++)
            {
                await Task.Delay(500);
                yield return i;
            }
        }
    }
}
