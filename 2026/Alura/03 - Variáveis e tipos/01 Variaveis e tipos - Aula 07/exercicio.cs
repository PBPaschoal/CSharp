/* Imagine que você está desenvolvendo um sistema para um cadastro de usuários. 
Uma das funcionalidades desse sistema é calcular a idade do usuário para oferecer conteúdo e serviços adequados à sua faixa etária.

Escreva um programa em C# que, a partir do ano de nascimento de uma pessoa, calcule a idade com base no ano atual.

Exemplo de entrada:
int anoNascimento = 1997; 
Saída esperada:
Supondo que o ano atual seja 2025.
Sua idade é: 28 anos */

int anoNascimento = 1992;
int anoAtual = 2026;
int calculandoIdade = anoAtual - anoNascimento;
Console.WriteLine("Sua idade é: " + calculandoIdade + " anos");