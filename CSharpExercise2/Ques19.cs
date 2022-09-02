using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise2
{
    internal class Ques19
    {
        public static void Main1()
        {
            int k = 1,num;
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for(int m = num-i; m > 0; m--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ",k++);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
