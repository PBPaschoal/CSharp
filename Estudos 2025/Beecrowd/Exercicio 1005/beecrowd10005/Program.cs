using System;
using System.Globalization;

namespace Program {

    public class Program {

        public static void Main(string[] args) {

            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double MEDIA = ((A * 3.5) + (B * 7.5)) / (3.5 + 7.5);
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}