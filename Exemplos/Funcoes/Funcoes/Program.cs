namespace Funcoes {
    public class Program {

        static double funcao(double entrada) {
            return entrada + 2;
        }

        static string dizer_ola(string nome, string statusDia) {
            return $"Ola, {nome}! Poxa hoje esta {statusDia}";
        }

        static string dizer_ola(string nome) {
            return $"Olá, {nome}!";
        }

        static string dizer_ola() {
            return "Olá!";
        }

        static void menu() {
            Console.WriteLine("1 - Para dizer ola");
            Console.WriteLine("2 - Para testar a funcao");
            Console.WriteLine("0 - Para encerrar o programa");
        }

        public static void Main() {

            int opcao;

            // proximas interações
            do {
                menu();
                Console.Write("Digite uma operacao: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1) {
                    Console.WriteLine( dizer_ola("joao", "esta ensolarado") );
                } else if (opcao == 2) {
                    Console.WriteLine(funcao(5));
                } else if (opcao != 0) {
                    Console.WriteLine("Por favor digite uma opcao valida!");
                }

            } while (opcao != 0);

        }

    }
}