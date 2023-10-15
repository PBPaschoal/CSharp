using System;
using System.Globalization;

namespace Revisao01
{
    class Revisao01
    {
        static void Main(string[] args)
        {
            double pi, area, raio;
            pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
