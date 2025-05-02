using System;
using System.Globalization;

namespace Program {

    public class Program {

        public static void Main(string[] args) {

            string name = Console.ReadLine();
            double fixedSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalSales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalReceivableAtTheEndOfTheMonth = fixedSalary + (totalSales * 0.15);

            Console.WriteLine("TOTAL = R$ " + totalReceivableAtTheEndOfTheMonth.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}