using System;
using System.Collections.Generic;
using System.Text;

namespace HiraganaV01 {
    internal class hiraganaAIUEO {
        public void EstudandoHiragana() {
            Console.WriteLine("''''''''''''''''''''''111111111111111111111111111111''''");
            Console.WriteLine("BEM-VINDO(A) AO PROGRAMA APRENDENDO HIRAGANA COM CSHARP!");
            Console.WriteLine("Desenvolvido por: Paulo Bruno Paschoal");
            Console.WriteLine("\nVamos começar a estudar!");
            Console.WriteLine();
            hiraganaA();
        }
        public void hiraganaA() {
            Console.WriteLine("1) あ significa:");
            Console.WriteLine("1: あ = a \n2: あ = i \n3: あ = o");
            Console.Write(">> ");
            int meaning = int.Parse(Console.ReadLine());
            if (meaning == 1)
            {
                Console.WriteLine(">> ACERTOU!\n");
                hiraganaO();
            }
            else
            {
                erroResposta();
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaA();
                } else {
                    hiraganaO();
                }
            }
        }
        public void hiraganaO() {
            Console.WriteLine("\n2) お significa o\n1 - CORRETO\n2 - ERRADO");
            Console.Write(">> ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1) {
                Console.WriteLine(">> ACERTOU!\n");
                hiraganaI();
            } else {
                erroResposta();
                choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaO();
                } else {
                    hiraganaI();
                }
            }
        }
        public void hiraganaI() {
            Console.WriteLine("\n3) i significa い em Hiragana!\n1 - VERDADEIRO\n2 - FALSO");
            Console.Write(">> ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1) {
                Console.WriteLine(">> ACERTOU!\n");
                hiraganaU();
            } else {
                erroResposta();
                choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaI();
                }
            }
        }

        public void hiraganaU() {
            Console.WriteLine("\n4) う em hiragana significa ka?\n1 - VERDADEIRO\n2 - FALSO: Significa sa\n3 - FALSO: Significa u\n4 - FALSO: Significa e");
            Console.Write(">> ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 3) {
                Console.WriteLine(">> ACERTOU!\n");
                hiraganaE();
            } else {
                erroResposta();
                choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaU();
                }
            }
        }
        public void hiraganaE() {
            Console.WriteLine("\n5) e = え em japonês?\n1 - VERDADEIRO\n2 - FALSO: Significa o\n3 - FALSO: Significa a");
            Console.Write(">> ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1) {
                Console.WriteLine(">> ACERTOU!\n");
            } else {
                erroResposta();
                choose = int.Parse(Console.ReadLine());
                if (choose == 1) {
                    hiraganaE();
                }
            }
            Console.WriteLine("Vamos para o próximo nível!");
        }

        public void erroResposta() {
            Console.WriteLine(">> VOCÊ ERROU!");
            Console.WriteLine("\nDeseja tentar novamente ou pular para o próximo?");
            Console.WriteLine("1 - TENTAR NOVAMENTE \n2 - PULAR PARA O PRÓXIMO.");
            Console.Write(">> ");
        }
    }
}
