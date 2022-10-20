using Foreach.Model;

namespace Foreach {

    public class Program {

        public static void Main () {

            Escola santoAntonio = new Escola(5);

            for(int i = 0; i < santoAntonio.Alunos.Length; i++) {
                santoAntonio.Alunos[i] = new Aluno(null);
            }

            foreach(Aluno aluno in santoAntonio.Alunos) {
                Console.WriteLine(aluno);
            }
        }

    }

}