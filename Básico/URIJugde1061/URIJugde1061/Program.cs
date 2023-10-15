/* Exercício URI 1061
 * Rio de Janeiro Dia 08-01-2021
 * Tempo de um Evento
 * Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, iniciando e terminando dentro 
 * do mês. O problema é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e 
 * quando termina o evento.
 * Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.
 * Entrada:
 * Como entrada, na primeira linha vai haver a descrição "Dia", seguido de um espaço e o dia do mês no qual o evento vai começar.
 * Na linha seguinte, será informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. Na terceira e quarta linha de
 * entrada haverá outra informação no mesmo formato das duas primeiras linhas, indicando o término do evento.
 * Saída:
 * Na saída, deve ser apresentada a duração do evento, no seguinte formato:
 * W dia(s)
 * X hora(s)
 * Y minuto(s)
 * Z segundo(s)
 * Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.
 * Exemplo de Entrada:
 * Dia 5
 * 08 : 12 : 23
 * Dia 9 
 * 06 : 13 : 23
 * Exemplo de Saída:
 * 3 dia(s) 
 * 22 hora(s)
 * 1 minuto(s)
 * 0 segundo(s) */

using System;

namespace URIJugde1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int W1, X1, Y1, Z1, W2, X2, Y2, Z2, W, X, Y, Z, inicio, fim, duracao, resto;

            // Ler a primeira linha, armazenando o valor de W (dia)
            string[] valores = Console.ReadLine().Split(' ');
            W1 = int.Parse(valores[0]);

            // Ler a segunda linha, armazenando o valor de X (hora), Y (minuto), Z (segundo)
            valores = Console.ReadLine().Split(' ');
            X1 = int.Parse(valores[0]);
            Y1 = int.Parse(valores[1]);
            Z1 = int.Parse(valores[2]);

            // Ler a terceira linha, armazenando o valor de W (dia)
            valores = Console.ReadLine().Split(' ');
            W2 = int.Parse(valores[0]);

            // Ler a segunda linha, armazenando o valor de X (hora), Y (minuto), Z (segundo)
            valores = Console.ReadLine().Split(' ');
            X2 = int.Parse(valores[0]);
            Y2 = int.Parse(valores[1]);
            Z2 = int.Parse(valores[2]);

            // Calculando o valor do inicio e fim, convertendo tudo para segundos
            inicio = (W1 - 1) * 24 * 60 * 60 + X1 * 60 * 60 + Y1 * 60 + Z1;
            fim = (W2 - 1) * 24 * 60 * 60 + X2 * 60 * 60 + Y2 * 60 + Z2;

            // Calculando a duracao em segundos
            duracao = fim - inicio;

            // Agora vamos desmembrar a duracao em segundos para dia (W), hora (X), minutos (Y) e segundos (Z) restantes
            W = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            X = resto / (60 * 60);
            resto = resto % (60 * 60);
            Y = resto / 60;
            Z = resto % 60;

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");
        }
    }
}
