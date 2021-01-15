﻿using System;
using System.Linq;

namespace Task03_Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                //numbers[i] = double.Parse(numbersLikeString[i]);
                Console.WriteLine($"{Convert.ToDecimal(numbers[i])} => {Convert.ToDecimal(Math.Round(numbers[i], MidpointRounding.AwayFromZero))}");
            }
        }
    }
}
