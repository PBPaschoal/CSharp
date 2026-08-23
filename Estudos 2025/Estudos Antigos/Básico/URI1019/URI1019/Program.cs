//Rio de Janeiro Dia 20-07-2021
//Conversão de Tempo
//Leia um valor inteiro, que é o tempo de duração em segundos de um terminado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.
//Entrada:
//O arquivo de entrada contém um valor inteiro N.
//Saída:
//Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos conforme exemplo fornecido.
//Exemplo de Entrada:                                               Exemplo de Saída:
//556                                                               0:9:16
//1                                                                 0:0:1
//140153                                                            38:55:53
//ANÁLISE:
//1 minuto = 60 segundos
//1 hora = 60 minutos = 3600 segundos

using System;

namespace URI1019
{
    class Program
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
