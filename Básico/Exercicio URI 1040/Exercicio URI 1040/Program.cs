/* Rio de Janeiro, dia 03-02-2020: Quinta-feira.
 * Exercício URI 1040
 * www.urionlinejudge.com.br
 * Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".
 * No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame) apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.
 * 
 * Entrada
 * A entrada contém quatro números de ponto flutuante correspondentes as notas dos alunos.
 * 
 * Saída
 * Todas as respostas devem ser apresentadas com uma casa decimal. As mensagens devem ser impressas conforme a descrição do problema. Não esqueça de imprimir o enter após o final de cada linha, caso contrário obterá "Presentation Error".
 * 
 * Exemplo de Entrada
 * 2.0 4.0 7.5 8.0
 * 6.4
 * 
 * Exemplo de Saída
 * Media: 5.4
 * Aluno em exame.
 * Nota do exame: 6.4
 * Aluno aprovado.
 * Media final: 5.9
 * 
 * Exemplo de Entrada
 * 2.0 6.5 4.0 9.0
 * 
 * Exemplo de Saída
 * Media: 4.8
 * Aluno reprovado.
 * 
 * Exemplo de Entrada
 * 9.0 4.0 8.5 9.0
 * 
 * Exemplo de Saída
 * Media: 7.3
 * Aluno aprovado.
 */

using System;
using System.Globalization;

namespace Exercicio_URI_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] n = Console.ReadLine().Split(' ');
            double N1 = double.Parse(n[0], CultureInfo.InvariantCulture);
            double N2 = double.Parse(n[1], CultureInfo.InvariantCulture);
            double N3 = double.Parse(n[2], CultureInfo.InvariantCulture);
            double N4 = double.Parse(n[3], CultureInfo.InvariantCulture);

            double Media = (N1 + N2 + N3 + N4) * 2.0 * 3.0 * 4.0 * 1.0 / 100.0;

            if (Media >= 7.0)
            {
                Console.WriteLine("Media: " + Media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }

            else if (Media < 5.0) {
                Console.WriteLine("Media: " + Media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }

            else
            {
                double N5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Media: " + Media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine("Nota do exame: " + N5.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
                double Final = (N1 + N2 + N3 + N4 + N5) * 2.0 * 3.0 * 4.0 * 1.0 / 100.0;
                Console.WriteLine("Media final: " + Final.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
