using System;

namespace CSharpExercise2
{
    internal class Ques20
    {
        public static void Main()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int m = num - i; m > 0; m--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
