/* Aula 45 Exercício 1117 Validação de Nota - Beecrowd
 * Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a média semestral. 
 * Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). 
 * Cada nota deve ser validada separadamente.
 * 
 * Entrada
 * A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.
 * 
 * Saída
 * Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
 * Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. 
 * O valor deve ser apresentado com duas casas após o ponto decimal.
 * 
 * Exemplo de Entrada	            Exemplo de Saída
 * -3.5                             nota invalida
 * 3.5                              nota invalida
 * 11.0                             media = 6.7
 * 10.0 */

using System;
using System.Globalization;

namespace Program {

    internal class Program {

        static void Main(string[] args) {
            double nota1 = 0, nota2 = 0;
            int notasValidas = 0;

            while (notasValidas < 2) {
                double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota < 0.0 || nota > 10.0) {
                    Console.WriteLine("nota invalida");
                } else {
                    if (notasValidas == 0) {
                        nota1 = nota;
                    } else {
                        nota2 = nota;
                    }
                    notasValidas++;
                }
            }
            double media = (nota1 + nota2) / 2.0;
            Console.WriteLine("media = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
