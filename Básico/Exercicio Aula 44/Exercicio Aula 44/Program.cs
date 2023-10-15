//Faça um programa para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo.
//O último dado, que não entrará nos cálculos, contém um valor de idade negativa.
//Calcular e imprimir a idade, média deste grupo de indivíduos. Se for entrado um valor negativo na primeira vez,
//mostrar a mensagem "impossível calcular".
//Exemplos:
//Entrada:
//31
//27
//46
//-5
//Saída:
//34.67
//Entrada:
//-10
//Saída:
//impossível calcular

using System;
using System.Globalization;

namespace Exercicio_Aula_44
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, media;
            int cont;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = 0.0;
            cont = 0;
            while (idade >= 0) {
                soma = soma + idade;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (cont == 0) {
                Console.WriteLine("Impossivel calcular");
            }
            else { 
            media = soma / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
