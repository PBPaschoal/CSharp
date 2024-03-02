/* Exercicios: Desafios do ChatGPT - Nivel II */


using System.Globalization;
using System.Runtime.Serialization;

Console.WriteLine("Exercício 11: Calculadora com Operações Avançadas");
/* Crie uma calculadora que permita ao usuário realizar operações básicas 
 * (adição, subtração, multiplicação e divisão) e operações avançadas (potenciação, raiz quadrada, logaritmo). */
Console.WriteLine("Escola uma opção abaixo:");
Console.WriteLine("[1] Calculadora Basica: ");
Console.WriteLine("[2] Calculadora Avançada: ");
byte opcao = byte.Parse(Console.ReadLine());

int quantidade = 0;
double soma = 0.0;
double valor = 0.0;

if (opcao == 1)
{
    Console.WriteLine("Escolha a operação desejada:");
    Console.WriteLine("[1] Adição");
    Console.WriteLine("[2] Subtração");
    Console.WriteLine("[3] Multiplicação");
    Console.WriteLine("[4] Divisão");

    opcao = byte.Parse(Console.ReadLine());

    Console.Write("Informe um valor: ");
    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Deseja repetir? [S/N]: ");
    char simOuNao1 = char.Parse(Console.ReadLine());

    while (simOuNao1 == 'S' || simOuNao1 == 's')
    {
        Console.Write("Informe outro valor: ");
        double segundoValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        switch (opcao)
        {
            case 1:
                valor += segundoValor;
                break;
            case 2:
                valor -= segundoValor;
                break;
            case 3:
                valor *= segundoValor;
                break;
            case 4:
                if (segundoValor != 0)
                {
                    valor /= segundoValor;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Opção inválida.");
                return;
        }

        Console.Write("Deseja repetir? [S/N]: ");
        simOuNao1 = char.Parse(Console.ReadLine());
        quantidade++;
    }

    if (quantidade == 0)
    {
        Console.WriteLine("Você não realizou operações.");
    }
    else
    {
        Console.WriteLine($"O resultado é: {valor.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}

Console.WriteLine("--------------------");
Console.WriteLine(" Programa Encerrado ");
Console.WriteLine("--------------------");
Console.ReadLine();