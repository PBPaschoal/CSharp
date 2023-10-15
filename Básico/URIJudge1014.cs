using System;
using System.Globalization;

namespace URIJudge1014
{
    class URIJudge1014
    {
        static void Main(string[] args)
        {
            int X;
            double km, Y;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            km = X / Y;

            Console.WriteLine(km.ToString("F3", CultureInfo.InvariantCulture) + " km/l");


        }
    }
}
