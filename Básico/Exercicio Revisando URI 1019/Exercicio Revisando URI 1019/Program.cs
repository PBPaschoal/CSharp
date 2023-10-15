/* Revisando URI 1019
 * Rio de Janeiro dia 07-01-2020
 * Conversão de Tempo
 * Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso
 * no formato horas:minutos:segundos.
 * Entrada:
 * O arquivo de entrada contém um valor inteiro N.
 * Saída:
 * Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido. 
 * Exemplo de Entrada:
 * 556
 * Exemplo de Saída:
 * 0:9:16 
 * Análise: 1 minuto = 60 segundos
 * 1 hora = 60 minutos = 3600 segundos
 * 140153 segundos contém quantas horas? 
 * 140153 dividido por 3600 = 38 (sobrando 136800. 140153 - 136800 resto = 3353)
 * 3353 dividido por 60 = 55 (sobrando 3300. 3353 - 3300 = 53) */

using System;

namespace Exercicio_Revisando_URI_1019
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

            Console.WriteLine(horas + ":" + minutos + ":" + segundos );

            Console.ReadLine();
        }
    }
}
