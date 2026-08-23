using System;
using System.Globalization;

namespace Program {

    public class Program {

        public static void Main(string[] args) {

            double pi = 3.14159;
            double ray = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double volume = (4.0 / 3.0) * pi * Math.Pow(ray, 3.0);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}