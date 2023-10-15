using System;
using System.Globalization;

namespace URIJugde1036
{
    class URIJugde1036
    {
        static void Main(string[] args)
        {
            double A, B, C, delta, r1, r2;
            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(B, 2.0) - 4.0 * A * C;


            if(A == 0 || delta < 0.0){
                Console.WriteLine("Impossivel calcular");
            } else {
                r1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                r2 = (-B - Math.Sqrt(delta)) / (2.0 * A);
                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
