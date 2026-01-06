using System;
using System.Collections.Generic;
using System.Text;

namespace HiraganaV01 {
    internal class boasVindas {
        public void inicioProgram() {
            Console.WriteLine(@"
██╗░░██╗██╗██████╗░░█████╗░░██████╗░░█████╗░███╗░░██╗░█████╗░
██║░░██║██║██╔══██╗██╔══██╗██╔════╝░██╔══██╗████╗░██║██╔══██╗
███████║██║██████╔╝███████║██║░░██╗░███████║██╔██╗██║███████║
██╔══██║██║██╔══██╗██╔══██║██║░░╚██╗██╔══██║██║╚████║██╔══██║
██║░░██║██║██║░░██║██║░░██║╚██████╔╝██║░░██║██║░╚███║██║░░██║
╚═╝░░╚═╝╚═╝╚═╝░░╚═╝╚═╝░░╚═╝░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝");
            Console.WriteLine("🄳🄴🅂🄴🄽🅅🄾🄻🅅🄸🄳🄾 🄿🄾🅁 🄿🄱🄿🄰🅂🄲🄷🄾🄰🄻");
        }

        public void inicioHiragana() {

            Console.WriteLine("\n/////////////////////////////////////////////////////////////");
            Console.WriteLine("\nVamos aprender Hiragana!");
            Console.WriteLine("1 - COMEÇAR \n2 - SAIR");
            Console.Write(">> ");
            int startHiragana = int.Parse(Console.ReadLine());
            if (startHiragana == 1) {
                var obj = new hiraganaAIUEO();

                obj.EstudandoHiragana();
            } else {
                Console.WriteLine(@"
█▀█ █▀█ █▀█ █▀▀ █▀█ ▄▀█ █▀▄▀█ ▄▀█   █▀▀ █▄░█ █▀▀ █▀▀ █▀█ █▀█ ▄▀█ █▀▄ █▀█ █
█▀▀ █▀▄ █▄█ █▄█ █▀▄ █▀█ █░▀░█ █▀█   ██▄ █░▀█ █▄▄ ██▄ █▀▄ █▀▄ █▀█ █▄▀ █▄█ ▄");
            }
        }
    }
}
