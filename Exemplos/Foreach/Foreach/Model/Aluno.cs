namespace Foreach.Model {
    public class Aluno {

        public string Nome { get; set; }

        // criação de um tipo nullable
        public int? Nota { get; set; }

        public Aluno(string? nome) {
            // checando se o argumento é nulo
            // se sim => Nome = "undefined"
            // senão => Nome = nome
            Nome = nome ?? "pedro";
        }

        public void FazerProva(int nota) {
            // Nota = Nota ?? nota
            Nota ??= nota;
        }

        public int Soma(int a, int b) => a + b;

        public double Soma(double a, double b) => a + b;

       public override string ToString() {
            return $"Nome: {Nome} || Nota : {Nota} ";
       }

    }
}
