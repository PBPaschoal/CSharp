/* Exercício 1014 Consumo - Beecrowd 
 * Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total 
 * de combustível gasto (em litros).
 * 
 * Entrada
 * O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), 
 * e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.
 * 
 * Saída
 * Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".
 * 
 * Exemplo de Entrada	        Exemplo de Saída
 * 500                         14.286 km/l
 * 35.0    
 * 
 * 2254                        18.119 km/l
 * 124.4
 * 
 * 4554                        9.802 km/l
 * 464.6                                       */

using System;
using System.Globalization;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {

            int X;
            double Y, CONSUMO;
            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            CONSUMO = (double) X / Y;
            Console.WriteLine(CONSUMO.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}