using System;

namespace Program {

    internal class  Program {

        public static void Main(string[] args)
        {
            //Array (vetor fixo)

            int[] numeros = new int[3];

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;

            for (int i = 0; i < numeros.Length; i++) { 
                Console.WriteLine("Valor: " + numeros[i]);
            }

            //Array com valores direto
            string[] nomes = { "Ana", "João", "Paulo" };

            foreach (string nome in nomes) {
                Console.WriteLine("Nome: " + nome);
            }

            //Lista (flexível, pode crescer)
            List<string> frutas = new List<string>();
            frutas.Add("Maçã");
            frutas.Add("Banana");
            frutas.Add("Uva");

            foreach (string fruta in frutas) {
                Console.WriteLine("Fruta: " + fruta);
            }
        }
    }
}