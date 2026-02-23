using System;
using System.Text.Json;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Listas - Usase quando a ordem é algo importante
            /*
            List<string> names = new List<string>();

            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");

            Console.WriteLine(names.Count);

            names.Add("David");

            Console.WriteLine(names.Count);

            names.Remove("Bob");

            Console.WriteLine(names.Count);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            if (names.Contains("Charlie"))
            {
                Console.WriteLine("Charlie is in the list.");
            }

            names.Clear();


            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            List<string> names2 = new List<string>();

            names2.Add("Eve");
            names2.Add("Frank");
            names2.Add("Grace");
            names2.Add("Heidi");
            names2.Add("Ivan");
            names2.Add("Alice");
            names2.Add("Allan");

            foreach (string name in names2)
            {
                Console.WriteLine(name);
            }

            names2.RemoveAll(name => name.StartsWith("A"));

            foreach (string name in names2)
            {
                Console.WriteLine(name);
            }
            */

            // Diccionarios

            Dictionary<string, int> dic = new Dictionary<string, int>();

            dic.Add("Alice", 30);
            dic.Add("Bob", 25);
            dic.Add("Charlie", 35);
            dic.Add("David", 28);
            dic.Add("Eve", 22);

            int idade;
            if(dic.TryGetValue("Charlie", out idade))
            {
                Console.WriteLine("Idade do Charlie: " + idade);
            } else
            {
                Console.WriteLine("Cahve não encontrada no dicionário.");
            }

            Console.WriteLine("Charlie tem " + dic["Charlie"] + " anos.");
            // Console.WriteLine("Charlie tem " + dic["charlie"] + " anos."); Dara sempre erro

            string saidajson = JsonSerializer.Serialize(dic);

            File.WriteAllText("dados.json", saidajson);
        }
    }
}