using System;

namespace _Task01_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDay = new string[8];
            weekDay[1] = "Monday";
            weekDay[2] = "Tuesday";
            weekDay[3] = "Wednesday";
            weekDay[4] = "Thursday";
            weekDay[5] = "Friday";
            weekDay[6] = "Saturday";
            weekDay[7] = "Sunday";

            int day = int.Parse(Console.ReadLine());

            if(day < 1 || day > 7)
                {
                    Console.WriteLine("Invalid day!");
                }
            else
                {
                    Console.WriteLine(weekDay[day]);
                }
        }
    }
}
