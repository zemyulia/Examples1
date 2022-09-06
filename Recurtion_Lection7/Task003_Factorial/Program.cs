using System;

namespace Task003_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int FactorialRec(int n)
            {
                if(n == 0) return 1;
                else if(n == 1) return 1;
                else return n * FactorialRec(n-1);
            }

            Console.WriteLine(FactorialRec(10));
        }
    }
}
