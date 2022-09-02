using System;

namespace CSharpExercise2
{
    internal class Ques1
    {
        public static void Main1()
        {
            int a, b;
            Console.Write("Input 1st number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("{0} and {1} are equal", a, b);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal", a, b);
            }
            Console.ReadKey();
        }
    }
}
