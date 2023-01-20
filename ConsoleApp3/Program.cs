using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            int antal = int.Parse(Console.ReadLine());
            string[] heltal = new string[antal];

            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("Skriv in ditt heltal här");
                heltal[i] = Console.ReadLine();
            }
            Console.WriteLine("Talen du skrev in är:");

            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine($"Tal {i + 1}: {heltal[i]}");
            }

        }
    }
}
