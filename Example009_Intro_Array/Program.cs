using System;

namespace Example009_Intro_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            array[0] = 12;
            Console.WriteLine(array[0]);

            int Max(int arg1, int arg2, int arg3)
            {
                int result = arg1;
                if(arg2>result) result = arg2;
                if(arg3>result) result = arg3;
                return result;
            }

            int maximum = Max(Max(array[0], array[1], array[2]),
            Max(array[3], array[4], array[5]),
            Max(array[6], array[7], array[8])
            );
            Console.WriteLine(maximum);
        }
    }
}
