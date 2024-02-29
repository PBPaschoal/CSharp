using System.Globalization;

int numero, soma = 0;
int contaemRegressiva;


Console.WriteLine("Exercício 1: Olá, Mundo!");
Console.WriteLine("Olá, Mundo!");

Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Exercício 2: Calculadora Simples");
Console.Write("Informe um número: ");
int primeiroNumero = int.Parse(Console.ReadLine());
Console.Write("Informe outro número: ");
int segundoNumero = int.Parse(Console.ReadLine());
double divisao = (double)primeiroNumero / segundoNumero;
Console.WriteLine(primeiroNumero + " + " + segundoNumero + " = " + (primeiroNumero + segundoNumero));
Console.WriteLine(primeiroNumero + " - " + segundoNumero + " = " + (primeiroNumero - segundoNumero));
Console.WriteLine(primeiroNumero + " * " + segundoNumero + " = " + (primeiroNumero * segundoNumero));
Console.WriteLine(primeiroNumero + " / " + segundoNumero + " = " + divisao);

Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Praticando aleatoriamente: ");
Console.Write("Quantas vezes deseja repetir? ");
byte repetir = byte.Parse(Console.ReadLine());

for (int i = 0; i < repetir; i++) {
    Console.Write("Digite um numero inteiro positivo: ");
    numero = int.Parse(Console.ReadLine());
    soma += numero;
}

Console.WriteLine("Resultado da soma dos numeros digitados: " + soma);

Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Exercício 3: Verificador de Número Par ou Ímpar");
if (soma % 2 == 0) {
    Console.WriteLine(soma + " é um número par.");
} else {
    Console.WriteLine(soma + " é um número ímpar.");
}

Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Exercício 4: Área do Triângulo");
Console.Write("\nInforme a base do triangulo: ");
double baseTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Informe a altura do triangulo: ");
double alturaTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
Console.WriteLine("A area do triangulo é = " + areaTriangulo.ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Exercício 5: Verificador de Palíndromo");
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

Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Exercício 6: Contagem Regressiva");
Console.Write("Informe um número inteiro positivo: ");
contaemRegressiva = int.Parse(Console.ReadLine());

for (int i = contaemRegressiva; i >= 0; i--) {
    Console.WriteLine(i);
}

Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Exercício 7: Fatorial");
Console.Write("Vamos calcular o fatorial, insira um número: ");
int numeroParaFatorial = int.Parse(Console.ReadLine());
int fatorial = 1;
for (int i = 1; i <= numeroParaFatorial; i++) {
    fatorial *= i;
}
Console.WriteLine("Fatorial de " + numeroParaFatorial + " = " + fatorial);

Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Exercício 8: Conversor de Temperatura");
Console.Write("Informe o valor da temperatura (Celsius): ");
double temperaturaCelsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double temperaduraFahrenheit = temperaturaCelsius * 1.8 + 32.0;
Console.WriteLine("Temperatura Fahrenheit = " + temperaduraFahrenheit.ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Exercício 9: Média de Notas");
Console.WriteLine("Informe três notas dos alunos: ");
double[] meuArray = new double[3];
double media = 0.0;
for(int i = 0; i < 3; i++) {
    Console.Write((i + 1) + "a nota: ");
    meuArray[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    media += meuArray[i] / 3;
}
Console.WriteLine("Media = " + media.ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Exercício 10: Verificador de Números Primos");
Console.Write("Informe um número primo: ");
int numeroPrimo = int.Parse(Console.ReadLine());

if (ÉPrimo(numeroPrimo)) {
    Console.WriteLine(numeroPrimo + " é um número primo!");
} else {
    Console.WriteLine(numeroPrimo + " não é um número primo!");
}

    static bool ÉPrimo(int numero)
{
    if (numero <= 1)
        return false;

    for (int i = 2; i <= Math.Sqrt(numero); i++)
    {
        if (numero % i == 0)
            return false;
    }

    return true;
}

Console.ReadLine();