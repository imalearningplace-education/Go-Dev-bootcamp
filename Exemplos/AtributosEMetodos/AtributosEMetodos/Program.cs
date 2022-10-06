namespace AtributosEMetodos {

    class Pessoa {

        // atributos
        public string Nome;
        public int Idade;
        public double Altura;

        // métodos
        public void DizerOi() {
            Console.WriteLine("Hello World!");
        }

        public void FazerAniversario() {
            Idade++;
        }

    }

    public class Program {

        public static void Main() {

            Pessoa joao = new Pessoa();

            joao.Nome = "Joao da Silva";
            joao.Idade = 23;
            joao.Altura = 1.9;

            joao.DizerOi();
            joao.FazerAniversario();

            Console.WriteLine($"Idade = {joao.Idade}");
           
        }

    }

}