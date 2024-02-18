using System.Globalization;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.WriteLine("Olá mundo");
            Console.Write("Bom dia!");

            Console.WriteLine(x);

            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4")); //Vai imprimir com virgula ao inves de ponto

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); //Vai imprimir com ponto ao inves de virgula

            Console.WriteLine("RESULTADO = " + x);

            Console.WriteLine("O valor do troco é " + x + " reais");

            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
        }
    }
}