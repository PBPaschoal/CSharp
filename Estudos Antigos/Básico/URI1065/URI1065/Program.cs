/*Rio de Janeiro Dia 07-02-2022
 *URI 1065
 *Pares entre Cinco Números
 *Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.
 *Entrada:
 *O arquivo de entrada contém 5 valores inteiros quaisquer.
 *Saída:
 *Imprima a mensagem confirme o exemplo fornecido, indicando a quantidade de valores pares lidos.
 *Exemplo de Entrada:          Exemplo de Saída:
 *7                            3 valores pares
 *-5
 *6
 *-4
 *12  */

using System;

namespace URI1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());
            int valor4 = int.Parse(Console.ReadLine());
            int valor5 = int.Parse(Console.ReadLine());

            int cont = 0;
            if(valor1 % 2 == 0)
            {
                cont = cont + 1;
            }
            if (valor2 % 2 == 0)
            {
                cont = cont + 1;
            }
            if (valor3 % 2 == 0)
            {
                cont = cont + 1;
            }
            if (valor4 % 2 == 0)
            {
                cont = cont + 1;
            }
            if (valor5 % 2 == 0)
            {
                cont = cont + 1;
            }
            Console.WriteLine(cont + " valores pares");
        }
    }
}
