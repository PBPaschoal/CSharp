using System;
using System.Collections.Generic;
using System.Text;

namespace HiraganaV01 {
    internal class HiraganaK {

        private ErroOpcoes msgErro = new ErroOpcoes();
        private HiraganaS hiraganas = new HiraganaS();
        public void hiraganak() {
            Console.Clear();
            Console.WriteLine("---------------------");
            Console.WriteLine("NIVEL 2");
            Console.WriteLine();
            hiraganak01();
        }
        public void hiraganak01() {
            Console.Clear();
            Console.WriteLine("06) Os seguintes hiraganas け e き são:");
            Console.WriteLine("\n1 - け = ki e き = ku\n2 - け = ka e き = ki\n3 - け = ke e き = ku\n4 - け = ke e き = ki");
            Console.Write(">> ");
            int meaning = int.Parse(Console.ReadLine());
            if (meaning == 4) {
                Console.WriteLine(">> ACERTOU!");
                Console.WriteLine("AGUARDE...");
                Thread.Sleep(1500);
                hiraganak02();
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
            Console.Clear();
            Console.WriteLine("こ = KO?\n1 = SIM / 2 = NÃO");
            Console.Write(">> ");
            int meaning = int.Parse(Console.ReadLine());
            if (meaning == 1) {
                Console.WriteLine(">> ACERTOU!");
                Console.WriteLine("AGUARDE...");
                Thread.Sleep(1500);
                hiraganak03();
            } else {
                msgErro.erroResposta();
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganak02();
                } else {
                    Console.WriteLine("PULANDO... Vamos para o próximo!");
                    hiraganak03();
                }
            }
        }
        public void hiraganak03() {
            Console.Clear();
            Console.WriteLine("く significa KU\n1 - VERDADEIRO | 2 - FALSO");
            Console.WriteLine(">> ");
            int meaning = int.Parse(Console.ReadLine());
            if (meaning == 1) {
                Console.WriteLine(">> ACERTOU!");
                Console.WriteLine("AGUARDE...");
                Thread.Sleep(1500);
                hiraganak04();
            } else {
                msgErro.erroResposta();
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganak03();
                } else {
                    Console.WriteLine("PULANDO... Vamos para o próximo!");
                    hiraganak04();
                }
            }
        }
        public void hiraganak04() {
            Console.Clear();
            Console.WriteLine("か em Hiragana significa KA\n1 - VERDADEIRO | 2 - FALSO");
            Console.WriteLine(">> ");
            int meaning = int.Parse(Console.ReadLine());
            if (meaning == 1) {
                Console.WriteLine(">> ACERTOU!");
                Console.WriteLine("AGUARDE...");
                Thread.Sleep(1500);
                hiraganak05();
            } else {
                msgErro.erroResposta();
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganak04();
                } else {
                    Console.WriteLine("PULANDO... Vamos para o próximo!");
                    hiraganak05();
                }
            }
        }
        public void hiraganak05() {
            Console.Clear();
            Console.WriteLine("き significa [?]\n1 = KA\n2 = KE\n3 = KI\n4 = KO\n5 = KU");
            Console.WriteLine(">> ");
            int meaning = int.Parse(Console.ReadLine());
            if (meaning == 3) {
                Console.WriteLine(">> ACERTOU!");
                Console.WriteLine("AGUARDE...");
                Thread.Sleep(1500);
                hiraganas.hiraganas();
            } else {
                msgErro.erroResposta();
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganak05();
                } else {
                    Console.WriteLine("PULANDO... Vamos para o próximo!");
                    hiraganas.hiraganas();
                }
            }
        }
    }
}
