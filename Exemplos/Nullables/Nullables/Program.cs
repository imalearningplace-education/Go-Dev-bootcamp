using Nullables.Model;

namespace Nullables {

    public class Program {

        public static void Main() {

            Aluno pedro = new(null);

            Console.WriteLine(pedro.Nome);
            Console.WriteLine(pedro.Nota);

            pedro.FazerProva(6);

            Console.WriteLine(pedro.Nota);

            pedro.FazerProva(9);

            Console.WriteLine(pedro.Nota);
            
        }

    }

}