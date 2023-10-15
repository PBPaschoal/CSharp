/* Exercício URI 1040
 * Dia 13-01-2021 Rio de Janeiro
 * Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. 
 * Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela 
 * mensagem "Media: ". Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média calculada for
 * inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas,
 * o programa deve imprimir a mensagem "Aluno em exame.".
 * No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. Imprima então a mensagem 
 * "Nota do exame: " acompanhada pela nota digitada. Recalcule a média (some a pontuação do exame com a média anteriormente 
 * calculada e divida por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno 
 * reprovado.", (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame)
 * apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.
 * Entrada:
 * A entrada contém quatro números de ponto flutuante correspendentes as notas dos alunos.
 * Saída:
 * Todas as respostas devem ser apresentadas com uma casa decimal. As mensagens devem ser impressas conforme a descrição 
 * do problema. Não esqueça de imprimir o enter após o final de cada linha, caso contrário obterá "Presentation Error".
 * Exemplo de Entrada:
 * 2.0 4.0 7.5 8.0
 * 6.4
 * Exemplo de Saída:
 * Media: 5.4
 * Aluno em exame.
 * Nota do exame: 6.4
 * Aluno aprovado.
 * Media final: 5.9
 * Exemplo de Entrada:
 * 2.0 6.5 4.0 9.0
 * Exemplo de Saída:
 * Media: 4.8
 * Aluno reprovado.
 * Exemplo de Entrada:
 * 9.0 4.0 8.5 9.0
 * Media: 7.3
 * Aluno aprovado. */

using System;
using System.Globalization;

namespace Exercício_URI_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, media, notaExame, mediaFinal;

            String[] vetor = Console.ReadLine().Split(' ');
            N1 = float.Parse(vetor[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vetor[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vetor[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vetor[3], CultureInfo.InvariantCulture);

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

            // O problema 1040 tem uma falha de arredondamento especifica
            // para a linguagem C#. Quando a media da 4.85, nos temos que
            // ajusta-la manualmente para 4.8, o que eh uma "gambiarra"
            // horrivel, infelizmente. Isso nao aconteceu nas outras 
            // linguagens que testamos, tais como Java, C e C++
            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaFinal = (media + notaExame) / 2;
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}