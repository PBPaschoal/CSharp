class Consulta { 

    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }

    private bool foiReagendada;

    public Consulta(string nomepaciente, string nomemedico, DateTime dataconsulta) {
        this.NomePaciente = nomepaciente;
        this.NomeMedico = nomemedico;
        this.DataConsulta = dataconsulta;
        foiReagendada = false;
    }

    public void Reagendar(DateTime novaData) { 
        DataConsulta = novaData;
        foiReagendada = true;
    }

    public void ExibirResumo() {
        Console.WriteLine($"Consulta marcada com {NomeMedico} para o(a) paciente {NomePaciente}.");
        if (foiReagendada) {
            Console.WriteLine("Nova data: " + DataConsulta.ToString("dd/MM/yyyy"));
        }
        else {
            Console.WriteLine("Data: " + DataConsulta.ToString("dd/MM/yyyy"));
        }
        Console.WriteLine();
    }

}