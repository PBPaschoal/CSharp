//Rio de Janeiro Dia 16-08-2021
//URI 1048 Aumento de Salário
//A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
//          Salário	                        Percentual de Reajuste
//        0 - 400.00                                15%
//      400.01 - 800.00                             12%
//     800.01 - 1200.00                             10%
//    1200.01 - 2000.00                              7%
//    Acima de 2000.00                               4%
//Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.
//Entrada:
//A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.
//Saída:
//Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho, conforme exemplo abaixo.
//Exemplo de Entrada                            Exemplo de Saída
//400.00                                        Novo salario: 460.00
//                                              Reajuste ganho: 60.00
//                                              Em percentual: 15 %
//Exemplo de Entrada                            Exemplo de Saída
//800.01                                        Novo salario: 880.01
//                                              Reajuste ganho: 80.00
//                                              Em percentual: 10 %

using System;
using System.Globalization;

namespace URI1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double percentual;
            if (salario <= 400.0)
            {
                percentual = 15.0;
            }
            else if (salario <= 800.0)
            {
                percentual = 12.0;
            }
            else if (salario <= 1200.0)
            {
                percentual = 10.0;
            }
            else if (salario <= 2000.0)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }

            double reajuste = salario * percentual / 100.0;
            double novoSalario = salario + reajuste;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");
        }
    }
}
