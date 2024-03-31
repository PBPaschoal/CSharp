/* Aula 38 Exercício 1049 Beecrowd - Animal
 * 
 * Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  
 * Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.
 * Entrada
 * A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.
 * 
 * Saída
 * Imprima o nome do animal correspondente à entrada fornecida.
 * 
 * Exemplos de Entrada	                Exemplos de Saída
 * vertebrado                           homem
 * mamifero
 * onivoro
 * 
 * 
 * vertebrado                           aguia
 * ave
 * carnivoro
 * 
 * invertebrado                         minhoca
 * anelideo
 * onivoro
 */

using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1, word2, word3;

            word1 = Console.ReadLine();
            word2 = Console.ReadLine();
            word3 = Console.ReadLine();

            if (word1 == "vertebrado")
            {
                if (word2 == "ave")
                {
                    if (word3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (word3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (word2 == "mamifero")
                {
                    if (word3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (word3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (word1 == "invertebrado")
            {
                if (word2 == "inseto")
                {
                    if (word3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (word3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (word2 == "anelideo")
                {
                    if (word3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (word3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}