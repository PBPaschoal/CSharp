using System;
using System.Collections.Generic;
using System.Text;

namespace HiraganaV01 {
    internal class HiraganaK {

        private ErroOpcoes msgErro = new ErroOpcoes();
        public void hiraganak() {
            Console.WriteLine("---------------------");
            Console.WriteLine("NIVEL 2");
            Console.WriteLine();
            hiraganak01();
        }
        public void hiraganak01() {
            Console.WriteLine("06) Os seguintes hiraganas け e き são:");
            Console.WriteLine("\n1 - け = ki e き = ku\n2 - け = ka e き = ki\n3 - け = ke e き = ku\n4 - け = ke e き = ki");
            Console.Write(">> ");
            int meaning = int.Parse(Console.ReadLine());
            if (meaning == 4) {
                Console.WriteLine(">> ACERTOU!");
                Console.WriteLine("AGUARDE...");
                Thread.Sleep(1500);
            } else {
                msgErro.erroResposta();
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganak01();
                } else {
                    Console.WriteLine("PULANDO... Vamos para o próximo!");
                    hiraganak02();
                }
            }
        }
        public void hiraganak02() {
            Console.WriteLine("こ é KO? 1 = SIM / 2 = NÃO");
            Console.WriteLine(">> ");
            int meaning = int.Parse(Console.ReadLine());
            if (meaning == 1) {
                Console.WriteLine(">> ACERTOU!");
                Console.WriteLine("AGUARDE...");
                Thread.Sleep(1500);
            } else {
                msgErro.erroResposta();
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganak02();
                } else {
                    Console.WriteLine("PULANDO... Vamos para o próximo!");
                }
            }
        }
    }
}
