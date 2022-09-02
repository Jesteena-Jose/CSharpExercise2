using System;

namespace CSharpExercise2
{
    internal class Ques2
    {
        public static void Main1()
        {
            int num, rem;
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            rem = num % 2;
            if (rem == 0)
            {
                Console.WriteLine("{0} is an even integer", num);
            }
            else
            {
                Console.WriteLine("{0} is an odd integer", num);
            }
            Console.ReadKey();
        }
    }
}
