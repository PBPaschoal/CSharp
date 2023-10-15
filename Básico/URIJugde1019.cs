using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace URIJugde1019
{
    class URIJugde1019
    {
        static void Main(string[] args)
        {
            int N, horas, resto, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}
