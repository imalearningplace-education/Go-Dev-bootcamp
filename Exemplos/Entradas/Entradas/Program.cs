namespace Entradas {
    public class Program {
        public static void Main() {

            // declarando variáveis
            string nome;
            int idade;
            double altura;
            bool estaNaSala = false;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite a sua altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Voce esta na sala? (y/n):  ");
            string estaNaSalaInput = Console.ReadLine();

            if (estaNaSalaInput == "y") {
                estaNaSala = true;
            }

            if (estaNaSalaInput == "n") {
                estaNaSala = false;
            }

            Console.WriteLine($"nome = {nome} || idade = {idade} || altura = {altura:F2}");

            if (estaNaSala == true) 
                Console.WriteLine("O aluno esta na sala");
            else 
                Console.WriteLine("O aluno nao esta na sala");


        }
    }
}