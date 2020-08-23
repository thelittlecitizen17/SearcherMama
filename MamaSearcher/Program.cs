using System;
using System.Collections.Generic;

namespace MamaSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, string> FirstAction = Output;
            Action<int, string> SecondAction = MagicFound;

            Dictionary<string, Action<int,string>> stock = new Dictionary<string, Action<int,string>>() { { "yasha", SecondAction },{ "b", FirstAction } };

            MamaSearcher mamaSearcher = new MamaSearcher(stock);

            mamaSearcher.PerformSearch("my name is yasha");
            mamaSearcher.PerformSearch("my name is bob");

        }
        public static void Output(int index, string pattern)
        {
            Console.WriteLine($"Pattern {pattern} found at index {index}");
        }
        public static void MagicFound(int index, string pattern)
        {
            Console.WriteLine($"{pattern} WAS FOUND !!!! KULULULU");
        }

    }
}
