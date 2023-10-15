/* Exercício URI 1047
 * Rio de Janeiro dia 16-01-2021
 * Tempo de Jogo com Minutos
 * Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.
 * Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.
 * Entrada:
 * Quatro números inteiros representando a hora de início e fim do jogo.
 * Saída:
 * Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” .
 * Exemplo de Entrada:
 * 7 8 9 10
 * Exemplo de Saída
 * O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)
 * Exemplo de Entrada:
 * 7 7 7 7
 * Exemplo de Saída:
 * O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)
 * Exemplo de Entrada:
 * 7 10 8 9
 * Exemplo de Saída:
 * O JOGO DUROU 0 HORA(S) E 59 MINUTO(S) */


using System;

namespace Exercício_URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int HoraInicial, MinutoInicial, HoraFinal, MinutoFinal, HR, MT;

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int minutoInicial = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);

            int instanteInicial = horaInicial * 60 + minutoInicial;
            int instanteFinal = horaFinal * 60 + minutoFinal;

            int duracao;
            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}