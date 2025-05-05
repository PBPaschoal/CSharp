using System;

namespace Program {

    internal class Program {

        public static void Main(string[] args) {

            Console.Write("Informe o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Que dia da semana é hoje? ");
            int dia = int.Parse(Console.ReadLine());

            if (dia <= 7 && dia >= 1)
            {
                Console.Write("Então hoje é ");
            }

            switch (dia) {
                case 1:
                    Console.WriteLine("Domingo!");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira!");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira!");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira!");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira!");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira!");
                    break;
                case 7:
                    Console.WriteLine("Sábado!");
                    break;
                default:
                    Console.WriteLine("Dia invalido!");
                    break;
            }

            bool confereIdade;
            if (confereIdade = idade >= 18) {
                Console.WriteLine("Como você é maior de idade, já pode ir ao mercado de carro.");
            }
            else {
                Console.WriteLine("Você ainda não pode dirigir o proprio carro por ser menor de idade.");
            }

            int ano = 2025 - idade;
            Console.WriteLine("Você nasceu em " + ano);
            Console.WriteLine("Você deseja contar até quanto? ");
            int contagem = int.Parse(Console.ReadLine());
            for (int i = 0; i <= contagem; i++) {
                Console.Write(i + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("Agora vou contar ao contrario:");
            while (contagem >= 0) {
                Console.Write(contagem-- + ", ");
            }

            Console.WriteLine("");
            Console.WriteLine("Vou chamar meu cachorro! Billy!!!");
            MeuCachorro();
            nomeGato("Kabeça!");
            int resultado = idadeFutura(idade, 30);
            Console.WriteLine("Daqui a 30 anos, você terá " + resultado + " de idade.");

            Console.WriteLine("E agora, números aleatorios:");
            int[] numeros = new int[3];

            numeros[0] = 100;
            numeros[1] = 200;
            numeros[2] = 500;

            for (int i = 0; i < numeros.Length; i++) {
                Console.WriteLine(i + ": " + numeros[i]);
            }

            string[] names = { "Belinha", "Fred", "Jenna" };

            foreach (string name in names) {
                Console.WriteLine("Descanse em paz: " + name);
            }

            static void MeuCachorro() {
                Console.WriteLine("Billy: - Au! Au!");
            }

            List<string> meusGatos = new List<string>();
            meusGatos.Add("Kabeça");
            meusGatos.Add("Lola");
            meusGatos.Add("Pepê Antonio");
            meusGatos.Add("Pandora");
            meusGatos.Add("Simon");

            foreach (string gatos in meusGatos){
                Console.WriteLine("Gato(a): " + gatos);
            }

            static void nomeGato(string nomeGato) { 
                Console.WriteLine("Meu gato se chama " + nomeGato + "!");
            }

            static int idadeFutura(int idade, int tempo){
                return idade + tempo;
            }
        }
    }
}