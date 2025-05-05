/* Exercício Beecrowd - 1006 Média 2
 * Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. 
 * A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. 
 * Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
 * 
 * Entrada
 * O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).
 * 
 * Saída
 * Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um 
 * espaço em branco antes e depois da igualdade. Assim como todos os problemas, não esqueça de imprimir o fim de linha 
 * após o resultado, caso contrário, você receberá "Presentation Error".
 * 
 * Exemplos de Entrada	                Exemplos de Saída
 * 5.0                                  MEDIA = 6.3
 * 6.0
 * 7.0
 * 
 * 5.0                                  MEDIA = 9.0
 * 10.0
 * 10.0
 * 
 * 10.0                                 MEDIA = 7.5
 * 10.0
 * 5.0 */

using System;
using System.Globalization;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            double A, B, C, MEDIA;
            double pesoA = 2.0;
            double pesoB = 3.0;
            double pesoC = 5.0;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            MEDIA = (A * pesoA + B * pesoB + C * pesoC) / (pesoA + pesoB + pesoC);
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}