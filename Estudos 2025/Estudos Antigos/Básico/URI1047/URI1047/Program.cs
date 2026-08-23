//Rio de Janeiro Dia 25-08-2021
//Tempo de Jogo com Minutos
//Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.
//Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.
//Entrada
//Quatro números inteiros representando a hora de início e fim do jogo.
//Saída
//Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” .
//Exemplo de Entrada:                               Exemplo de Saída:
//7 8 9 10                                          O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)
//Exemplo de Entrada:                               Exemplo de Saída:
//7 7 7 7                                           O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)


using System;

namespace URI1047
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int minutoInicial = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);
            //Quatro valores inteiros para entrada de dados na mesma linha, utilizando espaço.

            int instanteInicial = horaInicial * 60 + minutoInicial; // InstanteInicial = valor1 * 60 minutos + valor2
            int instanteFinal = horaFinal * 60 + minutoFinal; // InstateFinal = valor3 * 60 minutos + valor4

            /** EXEMPLO RESULTADO if:
             * valor1 = 6
             * valor2 = 7
             * valor3 = 9
             * valor4 = 9
             * 6 * 60 + 7 = 367 instanteInicial
             * 9 * 60 + 9 = 549 instanteFinal
             * 367 < 549 = true
             * duracao = 549 - 367 = 182
             * duracaoHoras = 182 / 60 = 3
             * duracaoMinutos = 182 % 60 = 2
             * 3 HORAS E 2 MINUTOS
             * --------------------------------------
             * EXEMPLO RESULTADO else:
             * valor1 = 9
             * valor2 = 9
             * valor3 = 6
             * valor4 = 7
             * 9 * 60 + 9 = 549 instanteInicial
             * 6 * 60 + 9 = 367 instanteFinal
             * 549 < 367 = false
             * duracao = (24 * 60 - 549) + 367 = 1.258
             * duracaoHoras = 1.258 / 60 = 20
             * duracaoMinutos = 1.258 % 60 = 58
             * 20 HORAS E 58 MINUTOS
             * */
            int duracao;
            if (instanteInicial < instanteFinal) // menor
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
