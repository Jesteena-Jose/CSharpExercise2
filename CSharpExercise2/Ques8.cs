using System;

namespace CSharpExercise2
{
    internal class Ques8
    {
        public static void Main1()
        {
            int num1, num2, num3;
            Console.Write("Input the 1st number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the 2nd number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Input the 3rd number: ");
            num3 = int.Parse(Console.ReadLine());

            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine("The 1st Number is the greatest among three");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three");
            }
            Console.ReadKey();

        }
    }
}
