using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio {
    internal class Consulta {
        public Pet Animal { get; set; }
        public Dono DonoAnimal { get; set; }
        public Medico Veterinario { get; set; }
        public string DataConsulta { get; set; }

        public Consulta(Pet animal, Dono donoAnimal, Medico veterinario, string dataConsulta) {
            Animal = animal;
            DonoAnimal = donoAnimal;
            Veterinario = veterinario;
            DataConsulta = dataConsulta;
        }
    }
}
