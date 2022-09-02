using System;

namespace CSharpExercise2
{
    internal class Ques6
    {
        public static void Main1()
        {
            int m, n;
            Console.Write("Enter value of m: ");
            m = int.Parse(Console.ReadLine());
            if (m < 0)
            {
                n = -1;
            }
            else if (m == 0)
            {
                n = 0;
            }
            else
            {
                n = 1;
            }
            Console.WriteLine("The value of n = {0}", n);
            Console.ReadKey();
        }
    }
}
