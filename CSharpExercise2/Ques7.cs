using System;

namespace CSharpExercise2
{
    internal class Ques7
    {
        public static void Main1()
        {
            float height;
            Console.Write("Enter the height in centimeter: ");
            height = float.Parse(Console.ReadLine());
            if (height < 150)
            {
                Console.WriteLine("The person is Dwarf.");
            }
            else if(height>=150 && height <= 165)
            {
                Console.WriteLine("The person is average heighted");
            }
            else if(height>165 && height <= 195)
            {
                Console.WriteLine("The person is taller");
            }
            else
            {
                Console.WriteLine("Abnormal height");
            }
            Console.ReadKey();
        }
    }
}
