/* Exercício URI 1051
 * Rio de Janeiro dia 16-01-2021
 * Imposto de Renda
 * Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele 
 * não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. 
 * A moeda deste país é o Rombus, cujo símbolo é o R$.
 * Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o 
 * valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
 * Renda                                Imposto de Renda
 * de 0.00 a R$ 2000.00                      Isento
 * de R$ 2000.01 até R$ 3000.00                8%
 * de R$ 3000.01 até R$ 4500.00               18%
 * acima de R$ 4500.00                        28%
 * Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que 
 * fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 
 * 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas decimais.
 * Entrada:
 * A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.
 * SAÍDA:
 * Imprima o texto "R$" seguido de um espaço e do valor total devido de Imposto de Renda, com duas casas após o ponto. 
 * Se o valor de entrada for menor ou igual a 2000, deverá ser impressa a mensagem "Isento".
 * Exemplos de Entrada:
 * 3002.00
 * Exemplos de Saída:
 * R$ 80.36
 * Exemplos de Entrada:
 * 1701.12
 * Exemplos de Saída:
 * Isento
 * Exemplos de Entrada:
 * 4520.00
 * Exemplos de Saída:
 * R$ 355.60 */


using System;
using System.Globalization;

namespace Exercício_URI_1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}