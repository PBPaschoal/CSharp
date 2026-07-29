/* Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

Saída
Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.

Exemplo de Entrada	Exemplo de Saída
576

576
5 nota(s) de R$ 100,00
1 nota(s) de R$ 50,00
1 nota(s) de R$ 20,00
0 nota(s) de R$ 10,00
1 nota(s) de R$ 5,00
0 nota(s) de R$ 2,00
1 nota(s) de R$ 1,00

11257

11257
112 nota(s) de R$ 100,00
1 nota(s) de R$ 50,00
0 nota(s) de R$ 20,00
0 nota(s) de R$ 10,00
1 nota(s) de R$ 5,00
1 nota(s) de R$ 2,00
0 nota(s) de R$ 1,00

503

503
5 nota(s) de R$ 100,00
0 nota(s) de R$ 50,00
0 nota(s) de R$ 20,00
0 nota(s) de R$ 10,00
0 nota(s) de R$ 5,00
1 nota(s) de R$ 2,00
1 nota(s) de R$ 1,00 */

using System;
class Program {
    static void Main(string[] args) {
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine(numero);

        int quant100 = numero / 100;
        numero = numero % 100;
        Console.WriteLine($"{quant100} nota(s) de R$ 100,00");
        int quant50 = numero / 50;
        numero = numero % 50;
        Console.WriteLine($"{quant50} nota(s) de R$ 50,00");
        int quant20 = numero / 20;
        numero = numero % 20;
        Console.WriteLine($"{quant20} nota(s) de R$ 20,00");
        int quant10 = numero / 10;
        numero = numero % 10;
        Console.WriteLine($"{quant10} nota(s) de R$ 10,00");
        int quant5 = numero / 5;
        numero = numero % 5;
        Console.WriteLine($"{quant5} nota(s) de R$ 5,00");
        int quant2 = numero / 2;
        numero = numero % 2;
        Console.WriteLine($"{quant2} nota(s) de R$ 2,00");
        Console.WriteLine($"{numero} nota(s) de R$ 1,00");
    }
}