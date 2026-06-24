// Se a compra for maior que 100 reais, recebe 10% de desconto, se for igual ou menor, não recebe desconto.
using System.Globalization;

double valorAPagar= 0;
Console.Write("Informe o valor da compra: R$ ");
double valorDaCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
if(valorDaCompra > 100.00) {
    valorAPagar = valorDaCompra - (valorDaCompra * (10.00 / 100.00));
} else {
    valorAPagar = valorDaCompra;
}
Console.WriteLine("Total a pagar R$ " + valorAPagar.ToString("F2", CultureInfo.InvariantCulture));