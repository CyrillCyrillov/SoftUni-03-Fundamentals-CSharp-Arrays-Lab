using System;
using System.Linq;

namespace Task04_Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = Console.ReadLine().Split(' ').ToArray();

            for (int i = item.Length - 1; i >= 0; i--)
            {
                Console.Write($"{item[i]} ");
            }
        }
    }
}
