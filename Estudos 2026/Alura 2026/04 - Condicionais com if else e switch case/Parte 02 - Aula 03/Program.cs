/* Você trabalha no desenvolvimento de Lura IA, um assistente virtual para um sistema de atendimento ao cliente. 
Ela precisa personalizar suas mensagens de acordo com o horário do dia para tornar a interação mais amigável e natural.

Para isso, você precisa de um programa que:

Pergunte ao usuário qual o momento do dia (manhã, tarde ou noite).
Solicite o nome do usuário.
Exiba uma saudação personalizada com base no momento do dia e no nome fornecido.
Exiba uma mensagem em caso de opção inválida.
Exemplo de entrada:

1 - Manhã
2 - Tarde
3 - Noite
 
Que momento do dia é agora?
2

Qual o seu nome?
Mike

Saída esperada:
Boa tarde, Mike. */

Console.WriteLine("1 - Manhã\n2 - Tarde\n3 - Noite\nQue momento do dia é agora?");
byte momentoDia = Byte.Parse(Console.ReadLine());
Console.WriteLine("\nQual o seu nome?");
string nome = Console.ReadLine();
switch(momentoDia) {
    case 1:
        Console.WriteLine($"Bom dia, {nome}.");
        break;
    case 2:
        Console.WriteLine($"Boa tarde, {nome}.");
        break;
    case 3:
        Console.WriteLine($"Boa noite, {nome}.");
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}
