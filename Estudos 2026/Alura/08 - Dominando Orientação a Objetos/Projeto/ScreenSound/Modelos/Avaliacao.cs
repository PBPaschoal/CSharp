using System.Xml;

namespace ScreenSound.Modelos;
internal class Avaliacao {
    public Avaliacao(int nota) {
        Nota = nota;
    }

    public int Nota { get; }
}