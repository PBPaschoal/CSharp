/*Praticando entrada de dados em C#
 *Na variável 'frase' iremos digitar por exemplo: Bom dia!
 *Na variável 'x' digitamos por exemplo: Verde
 *Na variável 'y' digitamos por exemplo: Azul
 *Na variável 'z' Digitamos por exemplo: Rosa
 *Por ultumi digitamos 3 palavras juntas (na mesma linha) e separar nas variaveis.
 *Ler um texto até a quebra de linha e armazenar em uma variável.
 *Ler três palavras, uma em cada linha, armazenando cada uma em uma variável.
 *Ler três palavras na mesma linha, separadas por espaço, armazenando cada uma em uma variável.
 */


using System;

namespace Vetores01
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
