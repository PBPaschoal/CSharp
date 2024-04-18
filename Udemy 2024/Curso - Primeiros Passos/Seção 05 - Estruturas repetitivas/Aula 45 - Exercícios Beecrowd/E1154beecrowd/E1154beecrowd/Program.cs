/* Aula 45 Exercício 1154 Beecrowd - Idade
 * Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. 
 * O último dado, que não entrará nos cálculos, contém o valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos.
 * 
 * Entrada
 * A entrada contém um número indeterminado de inteiros. A entrada será encerrada quando um valor negativo for lido.
 * 
 * Saída
 * A saída contém um valor correspondente à média de idade dos indivíduos.
 * 
 * A média deve ser impressa com dois dígitos após o ponto decimal.
 * 
 * Exemplo de Entrada	                Exemplo de Saída
 * 34                                   39.25
 * 56
 * 44
 * 23
 * -2 */

using System;
using System.Globalization;

namespace Program { 
    internal class Program {  
        static void Main(string[] args) {
            double mediaIdade; 
            double soma = 0.0;
            int quantidade = 0;
            int idade = int.Parse(Console.ReadLine());
            while(idade >= 0) {
                quantidade++;
                soma += idade;
                idade = int.Parse(Console.ReadLine());
            }
            mediaIdade = (double) soma / quantidade;
            Console.WriteLine(mediaIdade.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}