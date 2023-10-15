using System;
using System.Globalization;

namespace URIExercicio1008
{
    class URIJudge1008
    {
        static void Main(string[] args)
        {
            int idfun, hrs;
            double vlh, salario;

            idfun = int.Parse(Console.ReadLine());
            hrs = int.Parse(Console.ReadLine());
            vlh = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = hrs * vlh;

            Console.WriteLine("NUMBER = " + idfun);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
