using System;

namespace CSharpExercise2
{
    internal class Ques5
    {
        public static void Main1()
        {
            int age;
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("Sorry! You are not eligible for casting your vote.");
            }
            Console.ReadKey();
        }
    }
}
