using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise2
{
    internal class Ques13
    {
        public static void Main1()
        {
            int num;
            Console.Write("Input upto the table number starting from 1 : ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Multiplication table from 1 to {0}", num);
            for(int i=1; i <= 10; i++)
            {
                for(int j = 1; j <= num; j++)
                {
                    Console.Write("{0} * {1} = {2}", j, i, i * j);
                    if (j != num)
                    {
                        Console.Write(",  ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
