/* Converter dolar em real e real em dolar 
 * Rio de Janeiro, dia 10.09.2020 às 20:25hrs
 */

using System;
using System.Globalization;

namespace Cotaçãoifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int Opcao;
            float Cotacao, Dolar, ParaREAL, Real, ParaDolar;

            Console.Write("Informe o valor da cotação: ");
            Cotacao = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Opção [1]: DOLAR EM REAL");
            Console.WriteLine("Opção [2]: REAL EM DOLAR");
            Opcao = int.Parse(Console.ReadLine());

            if (Opcao == 1)
            {
                Console.Write("Informe os valores: US$ ");
                Dolar = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ParaREAL = Dolar * Cotacao;
                Console.WriteLine("R$ " + ParaREAL.ToString("F2", CultureInfo.InvariantCulture) + " REAIS." );
            } else
            {
                Console.Write("Informe os valores: R$ ");
                Real = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ParaDolar = Real / Cotacao;
                Console.WriteLine("US$ " + ParaDolar.ToString("F2", CultureInfo.InvariantCulture) + " Dolares.");
            }

            Console.ReadLine();

        }
    }
}
