using System;
using System.Collections.Generic;
using System.Text;

namespace HiraganaV01 {
    internal class HiraganaAIUEO {

        private ErroOpcoes msgErro = new ErroOpcoes();
        public void EstudandoHiragana() {
            Console.WriteLine("\nVamos começar a estudar!");
            Console.WriteLine();
            Console.WriteLine("NIVEL 1");
            hiraganaA();
        }
        public void hiraganaA() {
            Console.WriteLine("01) あ significa:");
            Console.WriteLine("\n1: あ = a \n2: あ = i \n3: あ = o");
            Console.Write(">> ");
            int meaning = int.Parse(Console.ReadLine());
            if (meaning == 1) {
                Console.WriteLine(">> ACERTOU!");
                Console.WriteLine("AGUARDE...");
                Thread.Sleep(1500);
                hiraganaO();
            } else {
                msgErro.erroResposta();
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaA();
                } else {
                    Console.WriteLine("PULANDO... Vamos para o próximo!");
                    hiraganaO();
                }
            }
        }
        public void hiraganaO() {
            Console.Clear();
            Console.WriteLine("\n02) お significa o\n1 - CORRETO\n2 - ERRADO");
            Console.Write(">> ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1) {
                Console.WriteLine(">> ACERTOU!");
                Console.WriteLine("AGUARDE...");
                Thread.Sleep(1500);
                hiraganaI();
            } else {
                msgErro.erroResposta();
                choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaO();
                } else {
                    Console.WriteLine("PULANDO... Vamos para o próximo!");
                    hiraganaI();
                }
            }
        }
        public void hiraganaI() {
            Console.Clear();
            Console.WriteLine("\n03) i significa い em Hiragana!\n1 - VERDADEIRO\n2 - FALSO");
            Console.Write(">> ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1) {
                Console.WriteLine(">> ACERTOU!");
                Console.WriteLine("AGUARDE...");
                Thread.Sleep(1500);
                hiraganaU();
            } else {
                msgErro.erroResposta();
                choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaI();
                } else {
                    Console.WriteLine("PULANDO... Vamos para o próximo!");
                    hiraganaU();
                }
            }
        }

        public void hiraganaU() {
            Console.Clear();
            Console.WriteLine("\n04) う em hiragana significa ka?\n1 - VERDADEIRO\n2 - FALSO: Significa sa\n3 - FALSO: Significa u\n4 - FALSO: Significa e");
            Console.Write(">> ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 3) {
                Console.WriteLine(">> ACERTOU!");
                Console.WriteLine("AGUARDE...");
                Thread.Sleep(1500);
                hiraganaE();
            } else {
                msgErro.erroResposta();
                choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaU();
                } else {
                    Console.WriteLine("PULANDO... Vamos para o próximo!");
                    hiraganaE();
                }
            }
        }
        public void hiraganaE() {
            var obj = new HiraganaK();
            Console.Clear();
            Console.WriteLine("\n05) e = え em japonês?\n1 - VERDADEIRO\n2 - FALSO: Significa o\n3 - FALSO: Significa a");
            Console.Write(">> ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1) {
                Console.WriteLine(">> ACERTOU!");
                Console.WriteLine("AGUARDE...");
                Thread.Sleep(1500);
            } else {
                msgErro.erroResposta();
                choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaE();
                } else {
                    Console.WriteLine("PULANDO... Vamos para o próximo!");
                    obj.hiraganak();
                }
            }  
            obj.hiraganak();
        }
    }
}
