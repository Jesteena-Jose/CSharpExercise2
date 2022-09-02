using System;

namespace CSharpExercise2
{
    internal class Ques3
    {
        public static void Main1()
        {
            int num;
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("{0} is a negatve number", num);
            }
            else if (num > 0)
            {
                Console.WriteLine("{0} is a positive number", num);
            }
            else
            {
                Console.WriteLine("{0} is neither positive nor negative number", num);
            }
            Console.ReadKey();
        }
    }
}
