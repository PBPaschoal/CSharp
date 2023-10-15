/* Revisando Exercício URI 1046
 * Tempo de Jogo
 * Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um 
 * dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
 * Entrada:
 * A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.
 * Saída:
 * Apresente a duração do jogo conforme exemplo abaixo.
 * Exemplo de Entrada:
 * 16 2
 * Exemplo de Saída:
 * O JOGO DUROU 10 HORA(S) */

using System;

namespace Exercicio_URI_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vetor = Console.ReadLine().Split(' ');
            int HoraInicio = int.Parse(vetor[0]);
            int HoraFinal = int.Parse(vetor[1]);

            int Jogo;
            if(HoraInicio < HoraFinal)
            {
                Jogo = HoraFinal - HoraInicio;
            }
            else
            {
                Jogo = 24 - HoraInicio + HoraFinal;
            }
            Console.WriteLine("O JOGO DUROU " + Jogo + " HORA(S)");
        }
    }
}
