using System;

namespace CSharpExercise2
{
    internal class Ques4
    {
        public static void Main1()
        {
            int year;
            Console.Write("Enter year: ");
            year = int.Parse(Console.ReadLine());
            if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }

            Console.ReadKey();
        }
    }
}
