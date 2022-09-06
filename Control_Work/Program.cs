using System;

namespace Control_Work
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача: Написать программу, которая из имеющегося массива строк 
            // формирует новый массив из строк, длина которых меньше, либо равна 
            // 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
            // задать на старте выполнения алгоритма. При решении не рекомендуется 
            // пользоваться коллекциями, лучше обойтись исключительно массивами.
            // Примеры:
            // ["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
            // ["1234", "1567", "-2", "computer science"] → [“-2”]
            // ["Russia", "Denmark", "Kazan"] → []

            string[] Words = {"Hello", "2", "world", ":-)"};



            string[] ModifiedWords(string[] words)
            {   
                // string[] tempWords = new string[words.Length];
                // int count = 0;
                // for(int i = 0; i<words.Length; i++)
                //     {
                //         if(words[i].Length <=3)
                //         {
                //             tempWords[i] = words[i];
                //             count++;
                //         }
                //         else
                //         {
                //             tempWords[i] = String.Empty;
                //         }
                //         Console.WriteLine(count);
                //     }
                // Console.WriteLine('[' + String.Join(", ", tempWords) + ']');
                // Console.WriteLine(tempWords.Length);
                // Console.WriteLine(count);

                // string[] newWords = new string[count];
                // int j = 0;
                // if(j < tempWords.Length)
                // {   
                //     if(tempWords[j]==String.Empty) j++;
                //     else 
                //     {
                //         for(int k = 0; k <= count; k++)
                //         {
                //             newWords[k] = tempWords[j];
                //             j++;
                //             Console.WriteLine(j);
                //         }
                //     }
                // }
                
                int count=0;
                int m=0;
                for(int i = 0; i<words.Length; i++)
                {    
                    if (words[i].Length <=3) {
                        count++;
                    }
                }

                string[] newWords = new string[count];

                for(int i = 0; i<words.Length; i++)
                {    
                    if (words[i].Length <=3) {
                        newWords[m] = words[i];
                        m++;
                    }                    
                }

                return newWords;
            }

            // string[] ModifiedWords(string[] words)
            // {
            //     int Num = words.Length;
            //     string[] tempWords = new string[Num];
            //     for(int i = 0; i<words.Length; i++)
            //     {
            //         if(words[i].Length<=3)
            //         {
            //             int k = 1;
            //             tempWords[i] = words[i];
            //             string[] newWords = new string[k];
            //             for(int j = 0; j<k; j++)
            //             {
            //                 newWords[j] = tempWords[i]; 
            //                 Console.WriteLine('[' + String.Join(", ", newWords) + ']')
            //             }
            //             k++;
            //         }
            //         else tempWords[i] = String.Empty;
            //     }
            //     return newWords;
            // }
            


            Console.WriteLine('[' + String.Join(", ", ModifiedWords(Words)) + ']');
        }
    }
}
