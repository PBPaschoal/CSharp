using System;
using System.Globalization;

namespace Program {

    public class Program {

        public static void Main(string[] args)
        {
            string[] product01 = Console.ReadLine().Split(' ');
            // Primeira peça
            int partCode01 = int.Parse(product01[0]); // Código da peça 01
            int quantityOfPieces01 = int.Parse(product01[1]); // Quantidade da peça 01
            double unitPricePerPiece01 = double.Parse(product01[2], CultureInfo.InvariantCulture); // Valor unitário 01

            string[] product02 = Console.ReadLine().Split(' ');
            // Segunda Peça
            int partCode02 = int.Parse(product02[0]); // Código da peça 02
            int quantityOfPieces02 = int.Parse(product02[1]); // Quantidade da peça 02
            double unitPricePerPiece02 = double.Parse(product02[2], CultureInfo.InvariantCulture); // Valor unitário 02

            double amountToPay = (quantityOfPieces01 * unitPricePerPiece01) + (quantityOfPieces02 * unitPricePerPiece02); // Valor total a pagar

            Console.WriteLine("VALOR A PAGAR: R$ " + amountToPay.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}