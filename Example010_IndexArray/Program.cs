using System;

namespace Example010_IndexArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {10, 82, 19, 36, 4, 25, 64, 7, 82, 19};
            int n = array.Length;
            int find = 19; 

            int index = 0;

            while (index < n)
            {
                
                if(array[index] == find)
                {
                    Console.WriteLine(index);
                    break;
                }

            index++;
            }
        }
    }
}
