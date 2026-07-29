/* Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

Exemplo de Entrada	Exemplo de Saída
556

0:9:16

1

0:0:1

140153

38:55:53 */

using System;
class Program {
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine());
        int horas = N / 3600;
        N = N % 3600;
        int minutos = N / 60;
        N = N % 60;
        int segundos = N;
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}