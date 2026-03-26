/* Você precisa construir uma minicalculadora que realiza uma operação matemática com dois números. 
O usuário deve digitar o primeiro número, o segundo número e qual operação deseja fazer: soma (+), subtração (-), multiplicação (*) ou divisão (/). 
Com base na operação digitada, o programa deve calcular e exibir o resultado.

Crie um programa que:

Receba dois números digitados pelo usuário.
Pergunte qual a operação matemática deseja realizar (+, -, *, /).
Exiba “Operação inválida” caso a entrada seja diferente das operações acima.
Exiba o resultado de acordo com a operação escolhida.
Exemplo de entrada:

Digite o primeiro número:
5
Digite o segundo número:
5
Digite a operação (+, -, *, /):
*
Copiar código
Saída esperada:

Resultado: 25 */

Console.WriteLine("Digite o primeiro número:");
double valor1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número:");
double valor2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a operação (+, -, *, /):");
string opcao = Console.ReadLine();
double operacao = 0;

switch(opcao) {
    case "+":
        operacao = valor1 + valor2;
        break;
    case "-":
        operacao = valor1 - valor2;
        break;
    case "*":
        operacao = valor1 * valor2;
        break;
    case "/":
        operacao = valor1 / valor2;
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}

Console.WriteLine($"Resultado: {operacao}");