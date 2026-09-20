Random rnd = new Random();
int nSecreto = rnd.Next(0, 11);
int contagem = 0;
int maxTentativas = 10;
while (contagem != maxTentativas) {
    contagem++;
    Console.WriteLine($":::::: {contagem}º Tentativa. ::::::");
    Console.Write("Informe um número para adivinhar o número secreto: ");
    int numeroDigitado = int.Parse(Console.ReadLine());
    if (numeroDigitado == nSecreto) {
        Console.WriteLine($"\nParabéns! Você acertou!!! O NÚMERO SECRETO É [ {nSecreto} ]");
        if (contagem < maxTentativas) {
            break;
        }
    }
    if (contagem < maxTentativas) {
        Console.WriteLine("Número digitado diferente do número SECRETO!\n >> VAMOS DE NOVO! <<");
        if (nSecreto < numeroDigitado) {
            Console.WriteLine($">>> DICA: O número SECRETO é MENOR que {numeroDigitado} <<<");
        }
        else {
            Console.WriteLine($">>> DICA: O número SECRETO é MAIOR que {numeroDigitado} <<<");
        }
        Console.WriteLine("--------------------------------------------\n");
    } else if (contagem == maxTentativas && numeroDigitado != nSecreto) {
        Console.WriteLine($"\nVOCÊ PERDEU! O NÚMERO SECRETO ERA: [ {nSecreto} ]\n");
    }

}