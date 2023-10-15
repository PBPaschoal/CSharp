/* Revisando básico if e else
 * Rio de Janeiro 09-01-2021
 * Aula 32 Estrutura condicional */

using System;

namespace Estrutura_Condicional_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;

            Console.Write("Quantas horas? ");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horas < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }

            Console.ReadLine();
        }
    }
}
