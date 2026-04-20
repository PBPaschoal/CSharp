class Carro {
    public string modelo;
    
    public void Frear() {
        Console.WriteLine($"\nFreiando o {this.modelo}\n");
    }

    public void Acelerar() {
        Console.WriteLine($"\nAcelerando o {this.modelo}\n");
    }

    public void Buzinar() {
        Console.WriteLine($"\nBI BI BIIIIIIIII!!!");
    }
}