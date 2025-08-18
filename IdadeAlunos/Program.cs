using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2;

            Console.WriteLine("Digite a Idade do primeiro aluno:");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Idade do segundo aluno:");
            idade2 = int.Parse(Console.ReadLine());

            if(idade1 > idade2)
            {
                Console.WriteLine("O primeiro aluno que tem: " + idade1 + " é mais velho que o segundo aluno que tem: " + idade2 + ".");
            }
            if (idade1 < idade2)
            {
                Console.WriteLine("O segundo aluno que tem: " + idade2 + " é mais velho que o primeiro aluno que tem: " + idade1 + ".");
            }
            if (idade1 == idade2)
            {
                Console.WriteLine("Os dois alunos têm a mesma idade que é: " + idade1 + ".");
            }
        }
    }
}