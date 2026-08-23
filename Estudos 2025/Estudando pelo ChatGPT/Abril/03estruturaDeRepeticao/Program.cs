using System;

namespace Program {

    internal class Program {

        static void Main(string[] args) {

            Console.Write("Informe um valor: ");
            int valor = int.Parse(Console.ReadLine());
            for (int i = 0; i <= valor; i++) { 
                Console.WriteLine("Contando: " + i);
            }

            Console.Write("Informe outro valor: ");
            int segundo_valor = int.Parse(Console.ReadLine());
            while (segundo_valor <= 10) {
                Console.WriteLine(segundo_valor);
                segundo_valor++;
            }

            Console.Write("Informe mais um valor: ");
            int terceiro_valor = int.Parse(Console.ReadLine());
            do { 
                Console.WriteLine(terceiro_valor);
                terceiro_valor++;
            } while (terceiro_valor < 5);

            Console.WriteLine("Foreach");
            int[] numeros = { 99, 100, 104, 110, 128 };

            foreach (int numero in numeros) { 
                Console.WriteLine(numero);
            }
        }
    }
}