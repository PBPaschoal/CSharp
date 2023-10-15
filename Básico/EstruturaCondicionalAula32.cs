using System;

namespace EstruturaCondicionalAula32
{
    class EstruturaCondicionalAula32
    {
        static void Main(string[] args)
        {
            int horas;

            Console.Write("Quantas horas? ");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia!");
            } else
            {
                if(horas < 18)
                {
                    Console.WriteLine("Boa tarde!");
                } else
                {
                    Console.WriteLine("Boa noite!");
                }
            }
            Console.ReadLine();
        }
    }
}
