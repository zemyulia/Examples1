using System;

namespace Task004_PowerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Возведение числа в степень.

            int PowerRec(int a, int n)
            {
                //return n == 0 ? 1 : PowerRec(a, n-1) * a; // альтернативный способ решения
                if(n == 0) return 1;
                else return PowerRec(a, n-1) * a;
            }

            Console.WriteLine(PowerRec(2,10));
        }
    }
}
