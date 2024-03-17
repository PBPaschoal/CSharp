/* Exercício 1061 Tempo de um Evento - Beecrowd 
 * Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. 
 * O problema é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.
 * 
 * Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.
 * 
 * Entrada
 * Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do mês no qual o evento vai começar. 
 * Na linha seguinte, será informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. 
 * Na terceira e quarta linha de entrada haverá outra informação no mesmo formato das duas primeiras linhas, indicando o término do evento.
 * 
 * Saída
 * Na saída, deve ser apresentada a duração do evento, no seguinte formato:
 * 
 * W dia(s)
 * X hora(s)
 * Y minuto(s)
 * Z segundo(s)
 * 
 * Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.
 * 
 * Exemplo de Entrada	                    Exemplo de Saída
 * Dia 5                                    3 dia(s)
 * 08 : 12 : 23                             22 hora(s)
 * Dia 9                                    1 minuto(s)
 * 06 : 13 : 23                             0 segundo(s)  */

/* Exercício 1061 Tempo de um Evento - Beecrowd 
 * Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. 
 * O problema é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.
 * 
 * Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.
 * 
 * Entrada
 * Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do mês no qual o evento vai começar. 
 * Na linha seguinte, será informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. 
 * Na terceira e quarta linha de entrada haverá outra informação no mesmo formato das duas primeiras linhas, indicando o término do evento.
 * 
 * Saída
 * Na saída, deve ser apresentada a duração do evento, no seguinte formato:
 * 
 * W dia(s)
 * X hora(s)
 * Y minuto(s)
 * Z segundo(s)
 * 
 * Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.
 * 
 * Exemplo de Entrada	                    Exemplo de Saída
 * Dia 5                                    3 dia(s)
 * 08 : 12 : 23                             22 hora(s)
 * Dia 9                                    1 minuto(s)
 * 06 : 13 : 23                             0 segundo(s)  */

using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaInicio, diaFim, horaInicio, minutoInicio, segundoInicio, horaFim, minutoFim, segundoFim;
            int resultadoDia, resultadoHora, resultadoMinuto, resultadoSegundo;

            Console.Write("Dia ");
            diaInicio = int.Parse(Console.ReadLine());

            string[] dados1 = Console.ReadLine().Split(' ');
            horaInicio = int.Parse(dados1[0]);
            minutoInicio = int.Parse(dados1[1]);
            segundoInicio = int.Parse(dados1[2]);

            Console.Write("Dia ");
            diaFim = int.Parse(Console.ReadLine());

            string[] dados2 = Console.ReadLine().Split(' ');
            horaFim = int.Parse(dados2[0]);
            minutoFim = int.Parse(dados2[1]);
            segundoFim = int.Parse(dados2[2]);

            // Inicializa os resultados com a diferença dos dias
            resultadoDia = diaFim - diaInicio;

            // Calcula a diferença de horas, minutos e segundos
            resultadoHora = horaFim - horaInicio;
            resultadoMinuto = minutoFim - minutoInicio;
            resultadoSegundo = segundoFim - segundoInicio;

            // Ajusta os valores negativos
            if (resultadoSegundo < 0)
            {
                resultadoSegundo += 60;
                resultadoMinuto--;
            }
            if (resultadoMinuto < 0)
            {
                resultadoMinuto += 60;
                resultadoHora--;
            }
            if (resultadoHora < 0)
            {
                resultadoHora += 24;
                resultadoDia--;
            }

            // Ajusta para o caso de o evento terminar no dia seguinte
            if (horaInicio > horaFim || (horaInicio == horaFim && minutoInicio > minutoFim) || (horaInicio == horaFim && minutoInicio == minutoFim && segundoInicio > segundoFim))
            {
                resultadoDia--;
                resultadoHora += 24;
            }

            Console.WriteLine(resultadoDia + " dia(s)");
            Console.WriteLine(resultadoHora + " hora(s)");
            Console.WriteLine(resultadoMinuto + " minuto(s)");
            Console.WriteLine(resultadoSegundo + " segundo(s)");
        }
    }
}
