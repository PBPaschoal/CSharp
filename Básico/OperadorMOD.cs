//Vídeo Aula 27
using System;

namespace URIExercicio1019
{
    class OperadorMOD
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
