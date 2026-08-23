//Rio de Janeiro Dia 21/07/2021
//Cédulas
//Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas
//são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.
//
//Entrada
//O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).
//
//Saída
//Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. Não esqueça de imprimir 
//o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
//Exemplo de Entrada:	                                Exemplo de Saída:
//576                                                   576
//                                                      5 nota(s) de R$ 100,00
//                                                      1 nota(s) de R$ 50,00
//                                                      1 nota(s) de R$ 20,00
//                                                      0 nota(s) de R$ 10,00
//                                                      1 nota(s) de R$ 5,00
//                                                      0 nota(s) de R$ 2,00
//                                                      1 nota(s) de R$ 1,00


using System;

namespace URI1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, quociente, resto, nota;

            valor = int.Parse(Console.ReadLine());
            Console.WriteLine(valor);

            resto = valor;

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            Console.WriteLine(resto + " nota(s) de R$ 1,00");
            
        }
    }
}
