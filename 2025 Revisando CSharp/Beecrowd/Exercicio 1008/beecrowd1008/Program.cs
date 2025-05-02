using System;
using System.Globalization;

namespace Program {

    public class Program {

        public static void Main(string[] args) {

            int idEmployee = int.Parse(Console.ReadLine()); // Número de identificação do funcionario
            int hoursWorkedEmployee = int.Parse(Console.ReadLine()); // Número de horas trabalhadas pelo funcionario
            double hourlyRateEmployee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Salário por hora

            double wageEmployee = (double)hoursWorkedEmployee * hourlyRateEmployee; 
            // Calculando valor por hora pela hora trabalhada para saber o salario total do funcionario

            Console.WriteLine("NUMBER = " + idEmployee);
            Console.WriteLine("SALARY = U$ " + wageEmployee.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}