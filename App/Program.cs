using System;
using FinalTask;

namespace App
{
    static class ArrayExtension
    {
        public static void Print<T>(this T[] arr)
        {
            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                var arr = Console.ReadLine().Split(' ');
                StringFilter.FilterByLength(arr).Print();
            }
            else
            {
                StringFilter.FilterByLength(args).Print();
            }
        }
    }
}
