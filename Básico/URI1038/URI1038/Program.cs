//Rio de Janeiro Dia 15-08-2021
//URI 1038
//Com base na tabela abaixo, escreva um programa que leia o código de uma item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.
//  Codigo      Especificacao       Preco
//  1           Cachorro Quente     R$ 4.00
//  2           X-Salada            R$ 4.50
//  3           X-Bacon             R$ 5.00
//  4           Torrada simples     R$ 2.00
//  5           Refrigerante        R$ 1.50
//Entrada
//O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.
//Saída
//O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.
//Exemplo de Entrada:                           Exemplo de Saída:
//3 2                                           Total: R$ 10.00
//Exemplo de Entrada:                           Exemplo de Saída:
//4 3                                           Total: R$ 6.00
using System;
using System.Globalization;

namespace URI1038
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            String[] X = Console.ReadLine().Split(' ');

            int codigo = int.Parse(X[0]);
            int quantidade = int.Parse(X[1]);

            switch (codigo)
            {
                case 1:
                    resultado = (double)quantidade * 4.00;
                    Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    resultado = (double)quantidade * 4.50;
                    Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    resultado = (double)quantidade * 5.00;
                    Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    resultado = (double)quantidade * 2.00;
                    Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    resultado = (double)quantidade * 1.50;
                    Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }
            
            Console.ReadLine();
        }
    }
}


/** OUUUUUUUUUUUUUUUUUUUU
 * using System;
using System.Globalization;

namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;
            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
} */