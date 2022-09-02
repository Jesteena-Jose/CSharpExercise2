using System;

namespace CSharpExercise2
{
    internal class Ques9
    {
        public static void Main1()
        {
            int x, y;
            Console.Write("Input the value for X coordinate: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Input the value for Y coordinate: ");
            y = int.Parse(Console.ReadLine());
            if(x > 0 && y > 0)
            {
                Console.WriteLine("The coordinate point ({0},{1}) lies in the First quadrant.", x, y);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The coordinate point ({0},{1}) lies in the Second quadrant.", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinate point ({0},{1}) lies in the Third quadrant.", x, y);
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("The coordinate point ({0},{1}) lies in the Fourth quadrant.", x, y);
            }
            Console.ReadKey();
        }
    }
}
