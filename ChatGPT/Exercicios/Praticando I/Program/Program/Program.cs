using System.Globalization;

int numero, soma = 0;

Console.WriteLine("Quantas vezes deseja repetir?");
byte repetir = byte.Parse(Console.ReadLine());

for (int i = 0; i < repetir; i++) {
    Console.WriteLine("Digite um numero inteiro positivo: ");
    numero = int.Parse(Console.ReadLine());
    soma += numero;
}

Console.WriteLine("Resultado da soma dos numeros digitados: " + soma);

if (soma % 2 == 0) {
    Console.WriteLine(soma + " é um número par.");
} else {
    Console.WriteLine(soma + " é um número ímpar.");
}

Console.WriteLine("\nInforme a base do triangulo: ");
double baseTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Informe a altura do triangulo: ");
double alturaTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
Console.WriteLine("A area do triangulo é = " + areaTriangulo.ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine();
Console.Write("Informe uma palavra: ");
string textoOriginal = Console.ReadLine();

textoOriginal = textoOriginal.Replace(" ", "").ToLower();

char[] charArray = textoOriginal.ToCharArray();
Array.Reverse(charArray);
string textoReverso = new string(charArray);

if (textoReverso == textoOriginal) {
    Console.WriteLine("É um Palíndromo.");
} else {
    Console.WriteLine("Não é um Palíndromo.");
}
