using System;

namespace Task001
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Создать строку с числами от а до b, причем a<=b
            string NumbersRec(int a, int b)
            {
                if (a<b) return $"{a} " + NumbersRec(a+1, b);
                else return $"{a} ";
            }

            Console.WriteLine(NumbersRec(1,10));
        }

    }
}
