/* Aula 45 Exercício Beecrowd 1159 - Soma de Pares Consecutivos
 * O programa deve ler um valor inteiro X indefinidas vezes. (O programa irá parar quando o valor de X for igual a 0). 
 * Para cada X lido, imprima a soma dos 5 pares consecutivos a partir de X, inclusive o X , se for par. Se o valor de entrada for 4, por exemplo, 
 * a saída deve ser 40, que é o resultado da operação: 4+6+8+10+12, enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, 
 * que é a soma de 12+14+16+18+20.

Entrada
O arquivo de entrada contém muitos valores inteiros. O último valor do arquivo é zero.

Saída
Imprima a saida conforme a explicação acima e o exemplo abaixo.

Exemplo de Entrada	            Exemplo de Saída
4                               40
11                              80
0  */

using System;

namespace Program {
    internal class Program {
        static void Main(string[] args) {
            int x = int.Parse(Console.ReadLine());

            while (x != 0) {
                int soma = 0;
                int quantidadePares = 0;

                // Se x for ímpar, soma-se 1 para torná-lo par
                if (x % 2 != 0) {
                    x++;
                }

                // Soma dos cinco pares consecutivos a partir de x
                while (quantidadePares < 5) {
                    soma += x;
                    x += 2; // Próximo número par
                    quantidadePares++;
                }

                Console.WriteLine(soma);

                // Lê o próximo valor de x
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}