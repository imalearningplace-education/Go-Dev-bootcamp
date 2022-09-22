namespace Repeticoes {

    public class Program {

        public static void Main () {

            /*
                // inicialização
                int contador = 0;

                // verificação
                while ( contador < 10 ) {
                    Console.WriteLine($"Contador = {contador}");

                    // atualização
                    contador++;
                }
            */

            int estoque;

            estoque = int.Parse(Console.ReadLine());

            while (estoque != 0) {
                    estoque -= 2;
                if (estoque > 0) {
                    Console.WriteLine($"Estou vendendendo... Novo estoque = {estoque}");
                } else {
                    estoque += 5;
                    Console.WriteLine($"Estou comprando... Novo estoque = {estoque}");
                }
            }

            for(int i = 1; i <= 10; i++) {
                Console.WriteLine($"Imprimindo... numero = {i}");
            }

        }

    }

}