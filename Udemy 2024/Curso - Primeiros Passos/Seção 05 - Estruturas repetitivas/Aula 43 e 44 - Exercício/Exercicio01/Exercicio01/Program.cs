/* Faça um programa para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo.
 * O último dado, que não entrará nos cálculos, contém um valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos. 
 * Se for entrado um valor negativo na primeira vez, mostrar a mensagem "impossivel calcular".
 * 
 * Exemplos:
 * Entrada:			Saída:
 * 31				34.67
 * 27
 * 46
 * -5
 * 
 * Entrada:			Saída:
 * -10				impossivel calcular */

using System;
using System.Globalization;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            int i = 0;
            double value, media;
            double sum = 0.0;
            value = int.Parse(Console.ReadLine());
            if(value < 0) {
                Console.WriteLine("impossivel calcular");
            } else {
                while (value >= 0) {
                    i++;
                    sum += value;
                    value = int.Parse(Console.ReadLine());
                }
                media = (double) sum / i;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}