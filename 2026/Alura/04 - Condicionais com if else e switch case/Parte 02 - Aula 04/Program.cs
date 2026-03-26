/* Imagine que você está desenvolvendo um sistema de missões para um jogo medieval. 
Os jogadores podem resgatar cupons secretos encontrados em baús ou derrotando inimigos para obter recompensas exclusivas. 
Cada cupom desbloqueia um benefício diferente.

Crie um programa que:

Receba o cupom de recompensa inserido
Retorne uma mensagem de acordo com o cupom
Informe que “Recompensa indisponível” se o cupom for inválido
As recompensas de acordo com o cupom são:

DOBRAR: Ganhar 2x EXP por 1 hora.
CURAR: Poção de cura.
OURO: 1000 moedas de ouro.
ESPECIAL: Item lendário.
Sua tarefa é usar a sintaxe simplificada do switch-case para retornar a mensagem diretamente na atribuição da variável, tornando o código mais conciso e legível.

Exemplo de entrada:

Digite o código de recompensa (DOBRAR, CURAR, OURO, ESPECIAL):
ESPECIAL

Saída esperada:

Item lendário desbloqueado! */

Console.WriteLine("Digite o código de recompensa (DOBRAR, CURAR, OURO, ESPECIAL):");
string cupom = Console.ReadLine();

switch(cupom) {
    case "DOBRAR":
        Console.WriteLine("XP em dobro durante 1 hora ATIVADA!");
        break;
    case "CURAR":
        Console.WriteLine("Você recebeu poção de cura!");
        break;
    case "OURO":
        Console.WriteLine("Você recebeu 1000 moedas de ouro!");
        break;
    case "ESPECIAL":
        Console.WriteLine("Item lendário desbloqueado!");
        break;
    default:
        Console.WriteLine("Recompensa indisponível");
        break;
}

// Ou conforme instrutora:
Console.WriteLine("Digite o código de recompensa (DOBRAR, CURAR, OURO, ESPECIAL):");
string codigo = Console.ReadLine();
 
string mensagem = codigo switch
{
    "DOBRAR" => "Você ganhou 2x EXP por 1 hora!",
    "CURAR" => "Poção de cura adquirida!",
    "OURO" => "+1000 moedas de ouro!",
    "ESPECIAL" => "Item lendário desbloqueado!",
    _ => "Recompensa indisponível."
};
 
Console.WriteLine(mensagem);