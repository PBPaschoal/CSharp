//Programa para teste de vetor, for, if e else

using System;

namespace ProgramaTeste01
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
            string paIs, estado;

            Console.Write("Quantas vezes deseja repetir? ");
            quantidade = int.Parse(Console.ReadLine());

            for (int i=0; i<quantidade; i++) {
                Console.WriteLine("\nEm qual país e estado você nasceu?");
                Console.WriteLine("OBS: Responda apenas o pais e o estado");
                Console.WriteLine("EXEMPLO: Brasil RJ\n");
                string[] s1 = Console.ReadLine().Split(' ');
                paIs = (s1[0]);
                estado = (s1[1]);

                if (paIs == "Brasil" && estado == "RJ")
                {
                    Console.WriteLine("Olá carioca!");
                }
                else if (paIs == "Brasil" && estado == "SP")
                {
                    Console.WriteLine("Olá paulista");
                }
                else if (paIs == "Brasil" && estado == "AC")
                {
                    Console.WriteLine("Olá acriano(a)");
                }
                else if (paIs == "Brasil" && estado == "AL")
                {
                    Console.WriteLine("Olá alagoano(a)");
                }
                else if (paIs == "Brasil" && estado == "AP")
                {
                    Console.WriteLine("Olá amapaense");
                }
                else if (paIs == "Brasil" && estado == "AM")
                {
                    Console.WriteLine("Olá amazonense");
                }
                else if (paIs == "Brasil" && estado == "BA")
                {
                    Console.WriteLine("Olá bahiano(a)");
                }
                else if (paIs == "Brasil" && estado == "CE")
                {
                    Console.WriteLine("Olá cearense");
                }
                else if (paIs == "Brasil" && estado == "ES")
                {
                    Console.WriteLine("Olá capixaba");
                }
                else if (paIs == "Brasil" && estado == "GO")
                {
                    Console.WriteLine("Olá goiano(a)");
                }
                else if (paIs == "Brasil" && estado == "MA")
                {
                    Console.WriteLine("Olá maranhense");
                }
                else if (paIs == "Brasil" && estado == "MT")
                {
                    Console.WriteLine("Olá mato-grossense");
                }
                else if (paIs == "Brasil" && estado == "MS")
                {
                    Console.WriteLine("Olá mato-grossense-do-sul");
                }
                else if (paIs == "Brasil" && estado == "MG")
                {
                    Console.WriteLine("Olá mineiro(a)");
                }
                else if (paIs == "Brasil" && estado == "PA")
                {
                    Console.WriteLine("Olá paraense");
                }
                else if (paIs == "Brasil" && estado == "PB")
                {
                    Console.WriteLine("Olá paraibano(a)");
                }
                else if (paIs == "Brasil" && estado == "PR")
                {
                    Console.WriteLine("Olá paranaense");
                }
                else if (paIs == "Brasil" && estado == "PE")
                {
                    Console.WriteLine("Olá Pernambucano(a)");
                }
                else if (paIs == "Brasil" && estado == "PI")
                {
                    Console.WriteLine("Olá piauiense");
                }
                else if (paIs == "Brasil" && estado == "RN")
                {
                    Console.WriteLine("Olá potiguar");
                }
                else if (paIs == "Brasil" && estado == "RS")
                {
                    Console.WriteLine("Olá gaúcho(a)");
                }
                else if (paIs == "Brasil" && estado == "RO")
                {
                    Console.WriteLine("Olá rondoniense");
                }
                else if (paIs == "Brasil" && estado == "RR")
                {
                    Console.WriteLine("Olá roraimense");
                }
                else if (paIs == "Brasil" && estado == "SC")
                {
                    Console.WriteLine("Olá catarinense");
                }
                else if (paIs == "Brasil" && estado == "SE")
                {
                    Console.WriteLine("Olá nordestino(a)");
                }
                else if (paIs == "Brasil" && estado == "TO")
                {
                    Console.WriteLine("Olá tocantinense");
                }
                else if (paIs == "Brasil" && estado == "DF")
                {
                    Console.WriteLine("Olá brasiliense");
                }
                else
                {
                    Console.WriteLine("Você não é Brasileiro.");
                }
            }

            Console.WriteLine("\n\n|*|*|*|*|*| E N C E R R A D O ! |*|*|*|*|*|\n\n");
        }
    }
}


/*using System;

namespace ProgramaTeste01
{
    class Program
    {
        static void Main(string[] args)
        {
            char M, N;

            string[] s1 = Console.ReadLine().Split(' ');
            M = char.Parse(s1[0]);
            N = char.Parse(s1[1]);

            if (M == 's' || N == 'm')
            {
                Console.WriteLine("Certo");
            }
            else
            {
                Console.WriteLine("Errado");
            }
        }
    }
}*/
