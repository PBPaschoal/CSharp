/* Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada
O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

Saída
A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.

Exemplos de Entrada	Exemplos de Saída
12 1 5.30
16 2 5.10

VALOR A PAGAR: R$ 15.50

13 2 15.30
161 4 5.20

VALOR A PAGAR: R$ 51.40

1 1 15.10
2 1 15.10

VALOR A PAGAR: R$ 30.20 */

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {
        string[] dados1 = Console.ReadLine().Split(' ');
        int codPeca1 = int.Parse(dados1[0]);
        int numeroPecas1 = int.Parse(dados1[1]);
        double valorUnitarioPeca1 = double.Parse(dados1[2], CultureInfo.InvariantCulture);

        string[] dados2 = Console.ReadLine().Split(' ');
        int codPeca2 = int.Parse(dados2[0]);
        int numeroPecas2 = int.Parse(dados2[1]);
        double valorUnitarioPeca2 = double.Parse(dados2[2], CultureInfo.InvariantCulture);
        double valorTotalAPaga = (double)(numeroPecas1 * valorUnitarioPeca1) + (numeroPecas2 * valorUnitarioPeca2);

        Console.WriteLine($"VALOR A PAGAR: R$ {valorTotalAPaga.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}