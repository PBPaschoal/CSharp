using System;
using System.Globalization;

namespace Program {

    public class Program {

        public static void Main(string[] args) {

            double pi = 3.14159;

            string[] values = Console.ReadLine().Split(' ');

            double valueA = double.Parse(values[0], CultureInfo.InvariantCulture);
            double valueB = double.Parse(values[1], CultureInfo.InvariantCulture);
            double valueC = double.Parse(values[2], CultureInfo.InvariantCulture);

            double areaOfARightTriangleWithBaseAandHeightC = (valueA * valueC / 2.0);
            double areaOfCircleOfRadiusC = pi * Math.Pow(valueC, 2);
            double areaOfTheTrapezoidThatHasAandBAsNasesAndCAsHeight = ((valueA + valueB) * valueC) / 2.0;
            double areaOfTheSquareWithSideB = Math.Pow(valueB, 2.0);
            double areaOfTheRectangleThatHasSidesAandB = valueA * valueB;

            Console.WriteLine("TRIANGULO: " + areaOfARightTriangleWithBaseAandHeightC.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaOfCircleOfRadiusC.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaOfTheTrapezoidThatHasAandBAsNasesAndCAsHeight.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaOfTheSquareWithSideB.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaOfTheRectangleThatHasSidesAandB.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}