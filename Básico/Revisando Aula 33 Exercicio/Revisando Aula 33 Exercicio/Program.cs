/* Revisando Exercício Aula 33
 * Rio de Janeiro dia 10-01-2021
 * Fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestre de uma disciplina anual.
 * Em seguida, mostrar a nota final que o aluno obteve no ano juntamente com um texto explicativo. Caso a nota final do aluno
 * seja inferior a 60.00, mostrar a mensagem "REPROVADO", conforme exemplos. Todos os valores devem ter uma casa decimal.
 * Exemplos:
 * Entrada:
 * 45.5
 * 31.3
 * Saída:
 * NOTA FINAL = 76.8
 * Estrutura condicional simples */

using System;
using System.Globalization;

namespace Revisando_Aula_33_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, resultado;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + resultado.ToString("F1", CultureInfo.InvariantCulture));

            if (resultado < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }

        }
    }
}