using System;
using System.Linq;

namespace Task08_Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = numbers.Length;

            while(length > 1)
            {
                int[] condensed = new int[length - 1];
                for (int i = 0; i < length - 1; i++)
                    {
                        condensed[i] = numbers[i] + numbers[i + 1];
                    }
                for (int i = 0; i < length - 1; i++)
                {
                    numbers[i] = condensed[i];
                }

                length -= 1;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
