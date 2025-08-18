using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Deinindo os tipos das variáveis
            String nome1, nome2;
            int idade1, idade2;

            //Pedindo os dados do aluno 1
            Console.WriteLine("Digite o nome do primeiro aluno:"); // Nome
            nome1 = Console.ReadLine(); // Coleta o nome digitado no console
            Console.WriteLine("Digite a Idade do primeiro aluno:"); // Idade
            idade1 = int.Parse(Console.ReadLine()); // Coleta e converte a idade digitada no console

            //Pedindo os dados do aluno 2
            Console.WriteLine("Digite o nome do segundo aluno:"); // Nome
            nome2 = Console.ReadLine(); // Coleta o nome digitado no console
            Console.WriteLine("Digite a Idade do segundo aluno:"); // Idade
            idade2 = int.Parse(Console.ReadLine()); // Coleta e converte a idade digitada no console

            //Operações lógicas para comparar as idades e exibir o resultado
            if (idade1 > idade2) // Compara se a idade do aluno 1 é maior que a do aluno 2
            {
                Console.WriteLine("O primeiro aluno de nome: " + nome1 + " que tem: " + idade1 + " é mais velho que o segundo aluno de nome: " + nome2 + " que tem: " + idade2 + "."); // Exibe o resultado no console
            }
            if (idade1 < idade2) // Compara se a idade do aluno 2 é maior que a do aluno 1
            {
                Console.WriteLine("O segundo aluno de nome: " + nome2 + " que tem: " + idade2 + " é mais velho que o primeiro aluno de nome: " + nome1 + " que tem: " + idade1 + "."); // Exibe o resultado no console
            }
            if (idade1 == idade2) // Compara se as idades dos dois alunos são iguais
            {
                Console.WriteLine("Os alunos de nomes: " + nome1 + " e " + nome2 + " têm a mesma idade: " + idade1 + "."); // Exibe o resultado no console
            }
        }
    }
}