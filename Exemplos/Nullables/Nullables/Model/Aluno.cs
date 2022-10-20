using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables.Model {
    public class Aluno {
 
        public string Nome { get; set; }

        // criação de um tipo nullable
        public int? Nota { get; set; }

        public Aluno(string? nome) {
            // checando se o argumento é nulo
            // se sim => Nome = "undefined"
            // senão => Nome = nome
            Nome = nome ?? "undefined";
        }

        public void FazerProva(int nota) {
            // Nota = Nota ?? nota
            Nota ??= nota;
        }

        public double Soma(int a, int b) => a + b;

    }
}
