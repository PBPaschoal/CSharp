using System;
using System.Collections.Generic;
using System.Text;

namespace HiraganaV01 {
    internal class HiraganaS {

        private ErroOpcoes msgErro = new ErroOpcoes();
        public void hiraganas() {
            Console.Clear();
            Console.WriteLine("---------------------");
            Console.WriteLine("NIVEL 3");
            Console.WriteLine();
            hiraganas01();
        }
        public void hiraganas01() {
            Console.WriteLine("O Hiragana SE significa:\n1 = す\n2 = せ \n3 = ち\n4 = き\n5 = な\n");
            Console.Write(">> ");
            int meaning = int.Parse(Console.ReadLine());
            if (meaning == 2) {
                Console.WriteLine(">> ACERTOU!");
                Console.WriteLine("AGUARDE...");
                Thread.Sleep(1500);
            } else {
                msgErro.erroResposta();
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganas01();
                } else {
                    //Console.WriteLine("PULANDO... Vamos para o próximo!");
                    Console.WriteLine("Em desenvolvimento...");
                }
            }
            var obj = new FimDeJogo();
            obj.Fim(); //Por enquanto
        }
    }
}
