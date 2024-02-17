using System;
using System.Globalization;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo");
            Console.Write("Bom dia!");

            double x = 10.35784;

            Console.WriteLine(x);

            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4")); //Vai imprimir com virgula ao inves de ponto

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); //Vai imprimir com ponto ao inves de virgula

            Console.WriteLine("RESULTADO = " + x);

            Console.WriteLine("O valor do troco é " + x + " reais");

            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
        }
    }
}