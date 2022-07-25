using System;

namespace Example003_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumA = new Random().Next(0,21); // 0, 1, 2, ..., 20
            Console.WriteLine(NumA);
            int NumB = new Random().Next(0,21); 
            Console.WriteLine(NumB);
            Console.WriteLine(NumA+NumB);
        }
    }
}
