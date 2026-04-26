/* Você é responsável por implementar o sistema de autenticação de um aplicativo corporativo. 
O sistema precisa diferenciar entre administradores, usuários cadastrados e visitantes, garantindo o acesso adequado a cada perfil.

Crie um programa que:

Solicite que o usuário digite seu nome
Verifique se o nome corresponde ao do administrador (ex: "Admin")
Caso não seja o administrador, exibir uma mensagem de "Usuário não cadastrado" e apresentar um menu com opções:
Cadastrar novo usuário
Acessar como convidado
Sair do sistema
Exemplo de entrada:

Sistema de Autenticação
-----------------------
Digite seu nome de usuário: Arthur Dent

Saída esperada:

Caso a opção escolhida seja cadastrar novo usuário:

Usuário não cadastrado.
Opções disponíveis:
[1] Cadastrar novo usuário
[2] Acessar como convidado
[3] Sair
1
Novo usuário 'Arthur Dent' cadastrado com sucesso!

Caso a opção escolhida seja entrar como convidado:

Usuário não cadastrado.
Opções disponíveis:
[1] Cadastrar novo usuário
[2] Acessar como convidado
[3] Sair
2
Acesso concedido como convidado.

Caso o usuário esteja cadastrado:

Bem-vindo, Arthur Dent! */

Console.WriteLine("Sistema de Autenticação\n-----------------------\nDigite seu nome de usuário:");
string digitarNome = Console.ReadLine();
string usuarioCadastrado = "Paulo Bruno";
if(digitarNome == usuarioCadastrado) {
    Console.WriteLine($"Bem-vindo, {usuarioCadastrado}!");
} else {
    Console.WriteLine("Usuário não cadastrado.\nOpções disponíveis:\n[1] Cadastrar novo usuário\n[2] Acessar como convidado\n[3] Sair");
    byte opcao = Byte.Parse(Console.ReadLine());
    switch(opcao){
        case 1:
            Console.WriteLine($"Novo usuário '{digitarNome}' cadastrado com sucesso!");
            break;
        case 2:
            Console.WriteLine("Acesso concedido como convidado.");
            break;
        case 3:
            Console.WriteLine("Programa encerrado.");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}