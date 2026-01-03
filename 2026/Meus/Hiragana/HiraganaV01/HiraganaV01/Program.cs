using System;
using System.Text;

namespace HiraganaV01 {
    internal class HiraganaV02 {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Vamos aprender Hiragana!");
            Console.WriteLine();
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1 - COMEÇAR \n2 - SAIR");
            Console.Write(">> ");
            int startHiragana = int.Parse(Console.ReadLine());
            if (startHiragana == 1) {
                var obj = new hiragana();

                obj.EstudandoHiragana();
            } else {
                Console.WriteLine("PROGRAMA ENCERRADO!");
            }
        }
    }
}