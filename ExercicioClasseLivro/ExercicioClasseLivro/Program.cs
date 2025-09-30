using ExercicioClasseLivro;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro[] livros = new Livro[5];

            livros[0] = new Livro("1984", "George Orwell", 1949);
            livros[1] = new Livro("To Kill a Mockingbird", "Harper Lee", 1960);
            livros[2] = new Livro("The Great Gatsby", "F. Scott Fitzgerald", 1925);
            livros[3] = new Livro("One Hundred Years of Solitude", "Gabriel Garcia Marquez", 1967);
            livros[4] = new Livro("It", "Stephen King", 1986);

            for (int i = 0; i < livros.Length; i++)
            {
                Console.WriteLine($"Detalhes do Livro {i + 1}:");
                livros[i].ExibirDetalhes();
            }
        }
    }
}