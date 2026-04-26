/* Imagine que você está desenvolvendo um jogo onde o jogador deve tentar adivinhar qual é o número secreto. 
O desafio é criar um programa que continue solicitando tentativas até que o jogador acerte o número, fornecendo feedback a cada tentativa.

Crie um programa que:

Declare uma variável com um inteiro para ser o número secreto.
Verifique a cada interação se o número digitado é igual ao número secreto.
Se o jogador errar, o programa informa que a tentativa está errada e solicita uma nova tentativa.
Se o jogador acertar o número, o programa exibe uma mensagem de parabéns e encerra o jogo.
Exemplo de entrada:

Tente adivinhar o número entre 1 e 10: 7

Saída esperada:

Parabéns, você acertou! */

// Primeira versão:
Random rand = new Random();
int sorteio = rand.Next(1, 11);
Console.WriteLine("JOGO SECRETO!\nTente adivinhar o número entre 1 e 10\nChute um número: ");
int chute = int.Parse(Console.ReadLine());
while(chute != sorteio) {
    if(sorteio > chute){
        Console.WriteLine($"O número secreto é maior que {chute}!");
    } else {
        Console.WriteLine($"O número secreto é menor que {chute}!");
    }
    Console.Write("Tente adivinhar o número entre 1 e 10: ");
    chute = int.Parse(Console.ReadLine());
}

Console.WriteLine("Parabéns, você acertou!");

// Segunda versão:
int deValor = 1;
int ateValor = 100;
int quantidadeTentativas = 0;
Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(deValor, ateValor);
Console.WriteLine("\n\n----------------");
Console.WriteLine(" SEGUNDA VERSÃO ");
Console.WriteLine("----------------");
Console.Write($"JOGO SECRETO!\nTENTE ADIVINHAR O NÚMERO ENTRE {deValor} e {ateValor}!\nInforme um número: ");
int meuChute = int.Parse(Console.ReadLine());
while(meuChute != numeroSecreto) {
    quantidadeTentativas++;
    if(numeroSecreto > meuChute) {
        Console.WriteLine($"{quantidadeTentativas}º Tentativa(s)!\nO número SECRETO é maior que {meuChute}.");
    } else {
        Console.WriteLine($"{quantidadeTentativas}º Tentativa(s)!\nO número SECRETO é menor que {meuChute}.");
    }
    Console.Write($"Tente adivinhar o número entre {deValor} e {ateValor}: ");
    meuChute = int.Parse(Console.ReadLine());
}
Console.Clear();
Console.WriteLine("-------------------------------------------");
Console.WriteLine($"Parabéns! Você acertou o número secreto: {numeroSecreto}\nTotal de tentativas: {quantidadeTentativas}");

// Terceira versão:
int segredo = 7;
int tentativa;
 
while (true) {
    Console.Write("Tente adivinhar o número entre 1 e 10: ");
    tentativa = int.Parse(Console.ReadLine());
 
    if (tentativa == segredo) {
        Console.WriteLine("Parabéns, você acertou!");
        break;
    }
    Console.WriteLine("Errado! Tente novamente.");
}