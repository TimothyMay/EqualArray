using System;
using System.Linq;

namespace EqualArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter int array (space delimited i.e 1 2 3");

            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(FindEvenIndex(array));
            Console.ReadLine();
        }

        public static int FindEvenIndex(int[] arr)
        {
            for (int n = 0; n < arr.Length; n++)
            {
                if (arr.Take(n).Sum() == arr.Skip(n + 1).Sum())
                {
                    return n;
                }
            }
            return -1;
        }
    }
}
