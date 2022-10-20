namespace Foreach.Model {
    public class Escola {

        // tem vários
        public Aluno[] Alunos { get; set; }

        public Escola(int quantidaDeAlunos) {
            Alunos = new Aluno[quantidaDeAlunos];
        }

    }
}
