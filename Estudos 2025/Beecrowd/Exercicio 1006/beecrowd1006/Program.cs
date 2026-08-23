using System;
using System.Globalization;

namespace Program {

    public class Program {

        public static void Main(string[] args) {

            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double MEDIA = ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5);

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}