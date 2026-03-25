/* Imagine que você está desenvolvendo um sistema de controle de acesso para um laboratório de pesquisa altamente seguro. 
Sua tarefa é criar um programa que valide as credenciais de quem tenta entrar, garantindo que apenas pessoas autorizadas tenham acesso.

Crie um programa que:

Receba uma senha.
Receba um nível de acesso.
Verifique se:
A senha está correta (Considere a senha como 42).
O nível de acesso é igual ou superior a 5.
Exiba “Acesso liberado” se ambos os critérios forem atendidos, ou “Acesso negado” caso contrário.
Exemplo de entrada:

Digite a senha:
1234
Digite o nível de acesso:
6

Saída esperada:

Acesso negado. */
Console.Write("Digite a senha: ");
int senha = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o nível de acesso: ");
int nivel = int.Parse(Console.ReadLine());
if (senha == 42 && nivel >= 5) {
    Console.WriteLine("Acesso autorizado.");
} else {
    Console.WriteLine("Acesso negado.");
}