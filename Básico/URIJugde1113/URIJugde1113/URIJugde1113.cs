using System;

namespace URIJugde1113 {
    class Program {
        static void Main(string[] args) {

            int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != y) {
                if (x < y) {
                    Console.WriteLine("Crescente");
                }
                else {
                    Console.WriteLine("Descrescente");
                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
        }
    }
}
