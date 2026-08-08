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
        int valor = int.Parse(Console.ReadLine());
        Console.WriteLine(valor);
        int nota100 = valor / 100;
        valor %= 100;
        int nota50 = valor / 50;
        valor %= 50;
        int nota20 = valor / 20;
        valor %= 20;
        int nota10 = valor / 10;
        valor %= 10;
        int nota5 = valor / 5;
        valor %= 5;
        int nota2 = valor / 2;
        valor %= 2;
        int nota1 = valor;
        Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
        Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
        Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
        Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
        Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
        Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
        Console.WriteLine($"{nota1} nota(s) de R$ 1,00");
    }
}