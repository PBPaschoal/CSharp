using System;
using System.Collections.Generic;
using System.Text;

namespace HiraganaV01 {
    internal class erroOpcoes {
        public void erroResposta() {
            Console.WriteLine(">> VOCÊ ERROU!");
            Console.WriteLine("\nDeseja tentar novamente ou pular para o próximo?");
            Console.WriteLine("1 - TENTAR NOVAMENTE \n2 - PULAR PARA O PRÓXIMO.");
            Console.Write(">> ");
        }
    }
}
