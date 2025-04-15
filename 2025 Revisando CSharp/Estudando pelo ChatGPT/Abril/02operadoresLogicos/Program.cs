using System;

namespace Program {

    internal class Program {

        static void Main(string[] args) {

            int idade = 20;
            bool temCarteira = true;

            bool podeDirigir = idade >= 18 && temCarteira;
            Console.WriteLine(podeDirigir); 

            bool liberado = idade >= 18 || temCarteira;
            Console.WriteLine(liberado);

            Console.WriteLine(!temCarteira);
        } 
    }
}