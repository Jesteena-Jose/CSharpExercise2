using System;

namespace CSharpExercise2
{
    internal class Ques10
    {
        public static void Main1()
        {
            int maths, phy, chem, total1,total2;
            Console.Write("Input the marks obtained in Physics: ");
            phy = int.Parse(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry: ");
            chem = int.Parse(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics: ");
            maths = int.Parse(Console.ReadLine());
            total1 = maths + phy + chem;
            total2 = maths + phy;
            if(maths>=65 && phy>=55 && chem>=50 && (total1 >= 180 || total2>=140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.ReadKey();
        }
    }
}
