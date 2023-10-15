using System;

namespace URIJugde1020
{
    class URIJugde1020
    {
        static void Main(string[] args)
        {
            int N, anos, meses, dias, resto;

            N = int.Parse(Console.ReadLine());

            anos = N / 365;
            resto = N % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
