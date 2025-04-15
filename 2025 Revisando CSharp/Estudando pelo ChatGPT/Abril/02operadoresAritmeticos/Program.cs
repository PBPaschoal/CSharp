using System.Globalization;

Console.Write("Informe um valor: ");
double primeiroValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Informe outro valor: ");
double segundoValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine(primeiroValor + " + " + segundoValor + " = " + (primeiroValor + segundoValor));
Console.WriteLine(primeiroValor + " - " + segundoValor + " = " + (primeiroValor - segundoValor));
Console.WriteLine(primeiroValor + " * " + segundoValor + " = " + (primeiroValor * segundoValor));
Console.WriteLine(primeiroValor + " / " + segundoValor + " = " + (primeiroValor / segundoValor));
Console.WriteLine(primeiroValor + " % " + segundoValor + " = " + (primeiroValor % segundoValor));
