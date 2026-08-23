/* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. 
 * 
 * A seguir, calcule e mostre o valor da conta a pagar.
 * 
 * CODIGO		ESPECIFICAÇÃO		PREÇO
 * 1    		Cachorro Quente		R$ 4.00
 * 2	    	X-Salada		    R$ 4.50
 * 3		    X-Bacon			    R$ 5.00
 * 4		    Torrada simples		R$ 2.00
 * 5		    Refrigerante		R$ 1.50
 * 
 * Entrada
 * O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item 
 * conforme tabela acima.
 * 
 * Saída
 * O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o 
 * ponto decimal.
 * 
 * Exemplo de Entrada	    Exemplo de Saída
 * 3 2                      Total: R$ 10.00
 * 4 3                      Total: R$ 6.00
 * 2 3                      Total: R$ 13.50 */

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {
        string[] vetor = Console.ReadLine().Split(' ');
        int a = int.Parse(vetor[0]);
        int b = int.Parse(vetor[1]);
        double valor_total = 0;
        if (a == 1) {
            valor_total = b * 4.0;
        } else if (a == 2) {
            valor_total = b * 4.5;
        } else if (a == 3) {
            valor_total = b * 5.0;
        } else if (a == 4) {
            valor_total = b * 2.0;
        } else {
            valor_total = b * 1.5;
        }
        Console.WriteLine($"Total: R$ {valor_total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}