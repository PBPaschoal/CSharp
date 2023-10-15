//Rio de Janeiro Dia 16-08-2021
//URI1046 Tempo de Jogo
//Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em
//outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
//Entrada:
//A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.
//Saída:
//Apresente a duração do jogo conforme exemplo abaixo.
//Exemplo de Entrada:                               Exemplo de Saída:
//16 2                                              O JOGO DUROU 10 HORA (S)
//Exemplo de Entrada:                               Exemplo de Saída:
//0 0                                               O JOGO DUROU 24 HORA (S)
//Exemplo de Entrada:                               Exemplo de Saída:
//2 16                                              O JOGO DUROU 14 HORA (S)

using System;

namespace URI1046
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vetor = Console.ReadLine().Split(' ');
            int A = int.Parse(vetor[0]);
            int B = int.Parse(vetor[1]);

            if (A >= B)
            {
                Console.WriteLine("O JOGO DUROU " + ((24 - A) + B) + " HORA (S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + (B - A) + " HORA (S)");
            }
                
        }
    }
}
