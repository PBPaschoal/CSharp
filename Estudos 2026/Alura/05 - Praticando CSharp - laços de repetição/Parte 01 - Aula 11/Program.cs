/* Imagine que você trabalha em uma agência de atendimento ao cliente, como um banco ou uma loja de serviços. 
Sua tarefa é criar um sistema de senhas para organizar o atendimento dos clientes. 
O sistema deve permitir que novas senhas sejam geradas quando um cliente chega e que as senhas sejam chamadas quando um atendente está disponível. 
O desafio é garantir que o sistema funcione de forma eficiente, mantendo o controle das senhas geradas e das senhas já atendidas, proporcionando uma experiência organizada e justa para todos os clientes.

Crie um programa que:

    Exiba um menu com as opções: Gerar nova senha, Chamar próxima senha e Sair.
    Para a opção Gerar nova senha, o sistema deve gerar uma nova senha sequencial (por exemplo, 001, 002, 003, etc.).
    Para a opção Chamar próxima senha, o sistema deve chamar a próxima senha disponível na fila, seguindo a ordem de chegada.
    O menu deve ser exibido repetidamente até que o usuário escolha a opção Sair.

Dica: Você pode utilizar o método ToString("D3") para formatar a saída no formato: 001, 002, 003. Por exemplo:

Console.WriteLine("Senha gerada: " + senhaGerada.ToString("D3"));

Exemplo de entrada:

1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 1

Saída esperada:

1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 1
Senha gerada: 001
 
1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 1
Senha gerada: 002
 
1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 2
Senha chamada: 001
 
1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 2
Senha chamada: 002


1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 4
Opção inválida.
 
1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 3
Encerrando sistema. */

int senhaGerada = 0;
int senhaAtual = 0;
int opcao;
 
do {
Console.WriteLine("1 - Gerar nova senha");
Console.WriteLine("2 - Chamar próxima senha");
Console.WriteLine("3 - Sair");
Console.Write("Escolha uma opção: ");
opcao = int.Parse(Console.ReadLine());

    switch (opcao) {
        case 1:
            senhaGerada++;
            Console.WriteLine("Senha gerada: " + senhaGerada.ToString("D3"));
            break;
        case 2:
            senhaAtual++;
            Console.WriteLine("Senha chamada: " + senhaAtual.ToString("D3"));
            break;
        case 3:
            Console.WriteLine("Encerrando sistema.");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
} while (opcao != 3);

