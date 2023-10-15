using System;

namespace Exercicio04LivrodeLogica
{
    class Exercicio04LivroLogica
    {
        static void Main(string[] args)
        {
            string nome, sexo;
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sexo(M ou F): ");
            sexo = Console.ReadLine();

            Console.WriteLine("O seu nome é " + nome + " e o seu sexo é " + sexo);

        }
    }
}
