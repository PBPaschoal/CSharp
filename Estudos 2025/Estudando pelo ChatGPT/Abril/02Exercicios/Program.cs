Console.Write("Digite o primeiro número: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int n2 = int.Parse(Console.ReadLine());

int soma = n1 + n2;
Console.WriteLine($"A soma é: {soma}");

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
    Console.WriteLine("Você é maior de idade.");
else
    Console.WriteLine("Você é menor de idade.");

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
    Console.WriteLine("O número é par.");
else
    Console.WriteLine("O número é ímpar.");

string loginCorreto = "admin";
string senhaCorreta = "1234";

Console.Write("Login: ");
string login = Console.ReadLine();

Console.Write("Senha: ");
string senha = Console.ReadLine();

if (login == loginCorreto && senha == senhaCorreta)
    Console.WriteLine("Login realizado com sucesso!");
else
    Console.WriteLine("Login ou senha incorretos.");
