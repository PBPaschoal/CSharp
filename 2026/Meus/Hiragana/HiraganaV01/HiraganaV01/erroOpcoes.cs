using System;
using System.Collections.Generic;
using System.Text;

namespace HiraganaV01 {
    internal class ErroOpcoes {
        public void erroResposta() {
            Console.Clear();
            Console.WriteLine(">> 𝑉𝑂𝐶𝐸̂ 𝐸𝑅𝑅𝑂𝑈!");
            Console.WriteLine("\nDeseja tentar novamente ou pular para o próximo?");
            Console.WriteLine("1 - TENTAR NOVAMENTE \n2 - PULAR PARA O PRÓXIMO.");
            Console.Write(">> ");
        }
    }
}
