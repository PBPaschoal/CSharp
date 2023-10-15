using System;
using System.Globalization;

namespace URIExercicio1011
{
    class URIJudge1011
    {
        static void Main(string[] args)
        {
            double volume, raio;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = 4.0 /3.0 * 3.14159 * raio * raio * raio;

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
