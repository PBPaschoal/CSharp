//Rio de Janeiro Dia 25-07-2021
//Notas e Moedas
//Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e
//moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25,
//0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.
//Entrada
//O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).
//Saída
//Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.
//Obs: Utilize ponto(.) para separar a parte decimal
//Exemplo de Entrada:                                                 Exemplo de Saída:
//576.73                                                              NOTAS:
//                                                                    5 nota(s) de R$ 100.00
//                                                                    1 nota(s) de R$ 50.00
//                                                                    1 nota(s) de R$ 20.00
//                                                                    0 nota(s) de R$ 10.00
//                                                                    1 nota(s) de R$ 5.00
//                                                                    0 nota(s) de R$ 2.00
//                                                                    MOEDAS:
//                                                                    1 moeda(s) de R$ 1.00
//                                                                    1 moeda(s) de R$ 0.50
//                                                                    0 moeda(s) de R$ 0.25
//                                                                    2 moeda(s) de R$ 0.10
//                                                                    0 moeda(s) de R$ 0.05
//                                                                    3 moeda(s) de R$ 0.01

using System;
using System.Globalization;

namespace URI1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int quociente, resto, nota, moeda;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Vamos multiplicar N por 100 e forçar a conversão para int.
            // Desse modo, por exemplo, 576.73 vai se tornar 57673

            // Vamos tambem somar 0.5 antes de converter, para assegurar 
            // que o numero seja devidamente arredondado, pois o tipo double
            // as vezes da problema de arredondamento (por exemplo: se digitarmos
            // 576.81 e multiplicarmos por 100, o resultado sera 57680.99999999,
            // dai o casting resultaria em 57680 e nao 57681 como desejado)

            resto = (int)(N * 100.0 + 0.5);

            Console.WriteLine("NOTAS:");

            // como multiplicamos o valor por 100 acima, o valor de cada nota
            // também deverá ser multiplicado por 100 a seguir

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS:");

            // o valor de cada moeda deverá ser representado em centavos

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto = resto % moeda;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");
        }
    }
}
© 2021 GitHub, Inc.
