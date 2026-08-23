/* Exercício Beecrowd - 1005 Média 1
 * Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. 
 * A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). 
 * Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
 * 
 * Entrada
 * O arquivo de entrada contém 2 valores com uma casa decimal cada um.
 * 
 * Saída
 * Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 5 dígitos após o ponto decimal e com um espaço 
 * em branco antes e depois da igualdade. Utilize variáveis de dupla precisão (double) e como todos os problemas, não esqueça de 
 * imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".
 * 
 * Exemplos de Entrada	                Exemplos de Saída
 * 5.0                                  MEDIA = 6.43182
 * 7.1 
 * 
 * 0.0                                  MEDIA = 4.84091
 * 7.1 
 * 
 * 10.0                                 MEDIA = 10.00000
 * 10.0 */

using System;
using System.Globalization;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            double A, B, MEDIA;
            double pesoA = 3.5;
            double pesoB = 7.5;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            MEDIA = (A * pesoA + B * pesoB) / (pesoA + pesoB);
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}