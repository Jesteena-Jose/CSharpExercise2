using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise2
{
    internal class Ques14
    {
        public static void Main1()
        {
            int num, i, sum=0,j;
            Console.Write("Input number of terms : ");
            num = int.Parse(Console.ReadLine());
            Console.Write("The odd numbers are : ");
            for (i = 1,j=1; j <= num; i = i + 2, j++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine("The Sum of odd Natural Number upto {0} terms : {1}",num,sum);
            Console.ReadKey();
        }
    }
}
