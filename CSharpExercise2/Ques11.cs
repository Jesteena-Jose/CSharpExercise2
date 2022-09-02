using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise2
{
    internal class Ques11
    {
        public static void Main1()
        {
            int num, i;
            Console.Write("Input number of terms: ");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                Console.WriteLine("Number is : {0} and cube of the {1} is :{2}", i, i,Math.Pow(i,3));
            }
            Console.ReadKey();
        }
    }
}
