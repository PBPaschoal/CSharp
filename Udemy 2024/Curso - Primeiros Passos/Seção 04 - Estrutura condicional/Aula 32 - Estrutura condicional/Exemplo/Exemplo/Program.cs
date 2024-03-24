using System;

namespace Program { 
    internal class Program {
        static void Main(string[] args) {

            int x = 5;
            int horas, horas2;

            Console.WriteLine("Teste 01");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine();


            Console.WriteLine("Teste 02");
            Console.WriteLine("Bom dia!");

            if(x < 0) { 
                Console.WriteLine("Boa tarde!");
            }

            Console.WriteLine("Boa noite!");

            Console.WriteLine("Teste 03");
            Console.WriteLine("OBS: Só bom dia e boa tarde");
            horas = int.Parse(Console.ReadLine());
            if (horas < 12) {
                Console.WriteLine("Bom dia!");
            } else {
                Console.WriteLine("Boa tarde!");
            }

            Console.WriteLine("Teste 04");
            horas2 = int.Parse(Console.ReadLine());
            if(horas2 >= 0 && horas2 < 12) {
                Console.WriteLine("Bom dia!");
            } else if (horas2 < 18) {
                Console.WriteLine("Boa tarde!");
            } else {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}