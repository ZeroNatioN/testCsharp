using System;

namespace TestC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Podaj imię:");
            string imie = "Michal";
            imie = Console.ReadLine();
            Console.WriteLine("Witaj! "+imie);
        }
    }
}
