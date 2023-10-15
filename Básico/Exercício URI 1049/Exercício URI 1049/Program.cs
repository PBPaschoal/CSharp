/* Exercício URI 1049
 * Rio de Janeiro dia 16/01/2021
 * Animal
 * Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da 
 * esquerda para a direita.  Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras 
 * fornecidas.
 * Entrada:
 * A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as 
 * letras minúsculas.
 * Saída:
 * Imprima o nome do animal correspondente à entrada fornecida.
 * Exemplos de Entrada:
 * vertebrado
 * mamifero
 * onivoro
 * Exemplos de Saída:
 * homem
 * Exemplos de Entrada:
 * vertebrado
 * ave
 * carnivoro
 * Exemplos de Saída:
 * aguia
 * Exemplos de Entrada:
 * invertebrado
 * anelideo
 * onivoro
 * Exemplos de Saída:
 * minhoca */

using System;

namespace Exercício_URI_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();

            if (palavra1 == "vertebrado")
            {
                if (palavra2 == "ave")
                {
                    if (palavra3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (palavra3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (palavra2 == "inseto")
                {
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("largata");
                    }
                }
                else
                {
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}