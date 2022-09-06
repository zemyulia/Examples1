using System;

namespace Example014_RecurtionAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //string table[,] = new string[2, 5];

            // table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]  
            // table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]  

            // int[,] matrix = new int[3,4];
            // void PrintArray(int[,] matr)
            // {
            //     for(int i = 0; i < matr.GetLength(0); i++)
            //     {
            //         for(int j = 0; j < matr.GetLength(1); j++)
            //         {
            //             Console.Write($"{matr[i,j]} ");
            //         }
            //         Console.WriteLine();
            //     }
            // }
            // PrintArray(matrix);
            // Console.WriteLine();
            // FillArray(matrix);
            // PrintArray(matrix);

            // void FillArray(int[,] matr)
            // {
            //     for(int i = 0; i<matr.GetLength(0); i++)
            //     {
            //         for(int j = 0; j<matr.GetLength(1); j++)
            //         {
            //             matr[i,j] = new Random().Next(1,10); //[0,10)
            //         }
            //     }
            //}

            // double Factorial(int n)
            // {
            //     if(n == 1) return 1;
            //     else 
            //     {
            //         return n*Factorial(n-1);
            //     }
            // }
            // for (int i = 0; i<40; i++)
            //     {
            //         Console.WriteLine($"{i}! = {Factorial(i)}"); // почемуто не работает...
            //     }


            // f(n) = f(n-1) + f(n-2) - функция Фибоначи

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
