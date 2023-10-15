using System;
using System.Globalization;

namespace URIExercicio02Basico
{
    class URIJudge1002
    {
        static void Main(string[] args)
        {
            double area, pi, raio;
            pi = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
