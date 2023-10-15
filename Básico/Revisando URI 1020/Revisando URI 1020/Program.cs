/* Revisando URI 1020
 * Rio de Janeiro dia 08-01-2021
 * Idade em Dias
 * Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias.
 * Obs: Apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias.
 * Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um
 * exercício com objetivo de testar raciocínio matemático simples.
 * Entrada:
 * O arquivo de entrada contém um valor inteiro.
 * Saída:
 * Imprima a saída conforme exemplo fornecido.
 * Exemplo de Entrada:
 * 400
 * Exemplo de Saída:
 * 1 ano(s)
 * 1 mes(es)
 * 5 dia(s)
 */


using System;

namespace Revisando_URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int V, ano, mes, dia, resto;

            V = int.Parse(Console.ReadLine());

            ano = V / 365;
            resto = V % 365;
            mes = resto / 30;
            dia = resto % 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");

        }
    }
}
