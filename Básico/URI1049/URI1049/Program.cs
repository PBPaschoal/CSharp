//Rio de Janeiro Dia 19-10-2021
//Animal
//Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.
//Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.
//https://www.urionlinejudge.com.br/judge/pt/problems/view/1049
//Entrada
//A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras 
//minúsculas.
//Saída
//Imprima o nome do animal correspondente à entrada fornecida.
//Exemplos de Entrada:                                    Exemplos de Saída:
//vertebrado                                              homem
//mamifero
//onivoro
//Exemplos de Entrada:                                    Exemplos de Saída:
//vertebrado                                              aguia
//ave
//carnivoro
//Exemplos de Entrada:                                    Exemplos de Saída:
//invertebrado                                            minhoca
//anelideo
//onivoro


using System;

namespace URI1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada1 = Console.ReadLine();
            string Entrada2 = Console.ReadLine();
            string Entrada3 = Console.ReadLine();

            if(Entrada1 == "vertebrado")
            {
                if(Entrada2 == "ave")
                {
                    if(Entrada3 == "carnivoro")
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
                    if (Entrada3 == "onivoro")
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
                if(Entrada2 == "inseto")
                {
                    if(Entrada3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if(Entrada3 == "hematofago")
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
