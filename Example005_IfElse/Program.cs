using System;

namespace Example005_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя:");
            string Username = Console.ReadLine();

            if (Username.ToLower() == "маша")
            {
                Console.WriteLine("Ура, это же МАША!");
            }

            else
            {
                Console.Write("Привет,");
                Console.WriteLine(Username);
            }
        }
    }
}
