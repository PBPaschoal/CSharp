class InformacaoTecnica { 

    public int TamanhoMB { get; set; }
    public string SistemaOperacional { get; set; }

    public InformacaoTecnica(int tamanhoMB, string so) { 
        this.TamanhoMB = tamanhoMB;
        this.SistemaOperacional = so;
    }
}