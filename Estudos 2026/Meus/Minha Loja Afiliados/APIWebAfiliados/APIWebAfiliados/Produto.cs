namespace APIWebAfiliados {
    internal class Produto {
        public static void Main(string[] args) {
            List<Produto> listaDeProdutos = new List<Produto>();
            string continuar = "s"; // Usando string para usarmos ToLower

            while (continuar.ToLower() == "s") {
                Console.WriteLine("\n/// CADASTRAR NOVO PRODUTO ///");
                Console.Write("ID do produto: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();
            }
        }
    }
}
