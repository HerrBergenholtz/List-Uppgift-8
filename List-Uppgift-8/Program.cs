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
            char[] messageC = new char[message.Length];
            char[] resultat = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                messageC[i] = messageC[i];
            }
            
            for (int i = 0; i < messageC.Length; i++)
            {
                foreach (char c in map.Keys)
                {
                    if (c == messageC[i]) 
                    {
                        resultat[i] = map[c];
                    }
                }
            }

            return resultat.ToString();
        }
    }
}