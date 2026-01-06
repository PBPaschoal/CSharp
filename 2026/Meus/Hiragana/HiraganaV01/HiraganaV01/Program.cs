using System;
using System.Text;

namespace HiraganaV01 {
    internal class HiraganaV02 {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\n/////////////////////////////////////////////////////////////");
            var obj = new boasVindas();
            obj.inicioProgram();
            var hiragana = new boasVindas();
            hiragana.inicioHiragana();
        }
    }
}