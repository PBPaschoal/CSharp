using System;
using System.Globalization;

namespace EntradaDadosSaida02
{
    class EntradaDadosSaida
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma letra: ");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número double: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Agora, na mesma linha digeite o seu primeiro nome; Letra do sexo; Idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine("\n------------");
            Console.WriteLine("Você digitou ");
            Console.WriteLine("Numero: " + n1);
            Console.WriteLine("Letra: " + ch);
            Console.WriteLine("Double: " + n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O seu primeiro nome é: " + nome);
            Console.WriteLine("O seu sexo é: " + sexo);
            Console.WriteLine("A sua idade é: " + idade);
            Console.WriteLine("A sua altura é: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
