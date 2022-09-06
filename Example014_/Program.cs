using System;

namespace Example014_
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fibonacci(int n)
            {
                if (n==1 || n==2) return 1;
                else return Fibonacci(n-1) + Fibonacci(n-2);
            }

            for (int i = 0; i<10; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}
