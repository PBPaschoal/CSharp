using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace ExercicioAula20
{
    class ExercicioAula20
    {
        static void Main(string[] args)
        {
            double area, preco, largura, compr, novpreco;
            compr = 10.0;
            largura = 30.0;
            area = compr * largura;

            preco = 200.00;
            novpreco = preco * area;
            Console.WriteLine(compr.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(largura.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + novpreco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
