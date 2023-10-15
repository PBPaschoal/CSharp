//Rio de Janeiro Dia 14-07-2021
//Salário com Bônus
//Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro).
//Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.
//Entrada:
//O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais, representando o salário
//fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.
//Saída:
//Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.
//Exemplos de Entrada:                                  Exemplos de Saída:
//JOAO                                                  TOTAL = R$ 684.54
//500.00
//1230.30

using System;
using System.Globalization;

namespace URI1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string vendedor;
            double salarioFixo, totalvendas, totalsalario;

            vendedor = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalvendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalsalario = totalvendas * 15.0 / 100 + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + totalsalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
