using System;
using System.Globalization;

namespace Revisao1010T
{
    class Revisao1010T
    {
        static void Main(string[] args)
        {
            int cod1, cod2, amount1, amount2;
            double vvalue1, vvalue2, total;

            string[] vetorr = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vetorr[0]);
            amount1 = int.Parse(vetorr[1]);
            vvalue1 = double.Parse(vetorr[2], CultureInfo.InvariantCulture);

            vetorr = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vetorr[0]);
            amount2 = int.Parse(vetorr[1]);
            vvalue2 = double.Parse(vetorr[2], CultureInfo.InvariantCulture);

            total = amount1 * vvalue1 + amount2 * vvalue2;

            Console.WriteLine("AMOUNT TO PAY: $ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
