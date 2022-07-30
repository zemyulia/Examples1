using System;

namespace Example011_ArrayLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            public int Digits(int num)
            {
                if (num == 0)
                    return 1;

                var result = 0;
                
                while(num > 0)
                {
                    num = num / 10;
                    result++;
                }
                
                return result;
            }
            void FillArray(int[] collection)
            {
                int length = ch;
                int index = 0;

                while(index<length)
                {
                    collection[index] = new Random().Next(1, 10);
                    index++;
                }
            }
            
            void PrintArray(int[] col)
            {
                int count = col.Length;
                int position = 0;

                while(position<count)
                {
                    Console.WriteLine(col[position]);
                    position++;
                }
            }

            int IndexOf(int[] collection, int find)
            {
                int count = collection.Length;
                int index = 0;
                int position = 0;

                while(index<count)
                {
                    if(collection[index] == find)
                    {
                        position = index;
                        break;
                    }
                    index++;
                }
                return position;
            }

            
            int[] array = new int[10];

            FillArray(array);

            array[4] = 4;
            array[6] = 4;
            PrintArray(array);

            Console.WriteLine();
            int Pos = IndexOf(array, 4);

            Console.WriteLine(Pos);
        }
    }
}
