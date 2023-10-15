using System;
using System.Globalization;

namespace URIJudge1017
{
    class URIJudge1017
    {
        static void Main(string[] args)
        {
            int temp, vel, dist;
            double litrs;

            temp = int.Parse(Console.ReadLine());
            vel = int.Parse(Console.ReadLine());

            dist = temp * vel;

            litrs = dist / 12.0;

            Console.WriteLine(litrs.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
