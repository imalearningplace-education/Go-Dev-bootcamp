namespace Repeticoes2 {

    public class Program {

        public static void Main() {  

            for (int i = 0; i < 10; i++) {

                if (i % 2 == 0) {
                    Console.WriteLine("devemos pular esse...");
                    continue;
                }

                if (i == 8) {
                    Console.WriteLine("Valor nao permitido!");
                    break;
                }

                Console.WriteLine($"pressao = {i}");
            }

            Console.WriteLine("Fim do programa");

        }

    }

}