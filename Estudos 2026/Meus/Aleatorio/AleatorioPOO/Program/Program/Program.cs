namespace Program {

    class Program {

        static void Main(string[] args) {

            Carro carro = new Carro("HB20", "Prata");
            Console.WriteLine($"Modelo do carro: {carro.Modelo} | Cor do carro: {carro.Cor}");
        }
    }
}