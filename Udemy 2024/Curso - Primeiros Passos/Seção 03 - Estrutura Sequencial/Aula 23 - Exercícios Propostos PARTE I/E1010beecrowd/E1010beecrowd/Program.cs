/* Exercício 1010 Cálculo Simples - Beecrowd 
 * Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
 * o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.
 * 
 * Entrada
 * O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e 
 * um valor com 2 casas decimais.
 * 
 * Saída
 * A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e 
 * um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
 * 
 * Exemplos de Entrada	                    Exemplos de Saída
 * 12 1 5.30                                VALOR A PAGAR: R$ 15.50
 * 16 2 5.10
 * 
 * 13 2 15.30                               VALOR A PAGAR: R$ 51.40       
 * 161 4 5.20                             
 * 
 * 1 1 15.10                                VALOR A PAGAR: R$ 30.20
 * 2 1 15.10 */

using System;
using System.Globalization;
using System.Numerics;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {

            string[] dados = Console.ReadLine().Split(' ');

            int codigoPeca1 = int.Parse(dados[0]);
            int quantidadePeca1 = int.Parse(dados[1]);
            double valorPeca1 = double.Parse(dados[2], CultureInfo.InvariantCulture);

            string[] dados2 = Console.ReadLine().Split(' ');

            int codigoPeca2 = int.Parse(dados2[0]);
            int quantidadePeca2 = int.Parse(dados2[1]);
            double valorPeca2 = double.Parse(dados2[2], CultureInfo.InvariantCulture);

            double total = (quantidadePeca1 * valorPeca1) + (quantidadePeca2 * valorPeca2);
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}