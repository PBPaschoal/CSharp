using System;
using System.Collections.Generic;
using System.Text;

namespace HiraganaV01 {
    internal class hiraganaAIUEO {

        private erroOpcoes msgErro = new erroOpcoes();
        public void EstudandoHiragana() {
            Console.WriteLine("''''''''''''''''''''''111111111111111111111111111111''''");
            Console.WriteLine("BEM-VINDO(A) AO PROGRAMA APRENDENDO HIRAGANA COM CSHARP!");
            Console.WriteLine("Desenvolvido por: Paulo Bruno Paschoal");
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
            if (meaning == 1)
            {
                Console.WriteLine(">> ACERTOU!\n");
                hiraganaO();
            }
            else
            {
                msgErro.erroResposta();
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaA();
                } else {
                    hiraganaO();
                }
            }
        }
        public void hiraganaO() {
            Console.WriteLine("\n02) お significa o\n1 - CORRETO\n2 - ERRADO");
            Console.Write(">> ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1) {
                Console.WriteLine(">> ACERTOU!\n");
                hiraganaI();
            } else {
                msgErro.erroResposta();
                choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaO();
                } else {
                    hiraganaI();
                }
            }
        }
        public void hiraganaI() {
            Console.WriteLine("\n03) i significa い em Hiragana!\n1 - VERDADEIRO\n2 - FALSO");
            Console.Write(">> ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1) {
                Console.WriteLine(">> ACERTOU!\n");
                hiraganaU();
            } else {
                msgErro.erroResposta();
                choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaI();
                }
            }
        }

        public void hiraganaU() {
            Console.WriteLine("\n04) う em hiragana significa ka?\n1 - VERDADEIRO\n2 - FALSO: Significa sa\n3 - FALSO: Significa u\n4 - FALSO: Significa e");
            Console.Write(">> ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 3) {
                Console.WriteLine(">> ACERTOU!\n");
                hiraganaE();
            } else {
                msgErro.erroResposta();
                choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaU();
                }
            }
        }
        public void hiraganaE() {
            Console.WriteLine("\n05) e = え em japonês?\n1 - VERDADEIRO\n2 - FALSO: Significa o\n3 - FALSO: Significa a");
            Console.Write(">> ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1) {
                Console.WriteLine(">> ACERTOU!\n");
            } else {
                msgErro.erroResposta();
                choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaE();
                }
            }
            Console.WriteLine("Vamos para o próximo nível!");
            var obj = new hiraganaK();

            obj.hiraganak();
        }
    }
}
