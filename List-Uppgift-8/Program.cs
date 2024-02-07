using System;

namespace Uppgift_8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hur många koder vill du skriva in?");

            int num = int.Parse(Console.ReadLine());

            Dictionary<char, char> map = new();

            Console.WriteLine("Skriv in koderna med mellanslag och tomma rader.");

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                map.Add(char.Parse(input[0]), char.Parse(input[1]));
            }

            Console.WriteLine("Vad vill du koda av?");
            Console.WriteLine(Koda(map, Console.ReadLine()));

        }

        static string Koda(Dictionary<char, char> map, string msg)
        {
            string[] message = msg.Split("");
            for (int i = 0; i < map.Count; i++)
            {
                
            }
        }
    }
}