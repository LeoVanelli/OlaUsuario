using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1 - Faça um programa solicite que o usuário digite seu nome. Exiba Olá, ___! (na lacuna ___ exiba o nome digitado).

            string nome; 

            // Pergunta o nome do usuário para apresentar posteriomente.
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine(); 

            Console.WriteLine("Olá,{0}",nome); // Resolução do exercício

            Console.Write("Pressione qualquer tecla para fechar. . .");
            Console.ReadKey();
        }
    }
}
