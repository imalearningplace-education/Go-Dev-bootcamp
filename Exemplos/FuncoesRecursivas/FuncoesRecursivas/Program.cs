namespace FuncoesRecursivas {

    public class Program {

        static int somarIntervalo(int inicio, int fim) {

            // Console.WriteLine($"Inicio = {inicio} || Fim = {fim}");

            // caso base
            if (inicio == fim) {
                return inicio;
            }

            // caso recursivo
            //int subproblema = somarIntervalo(inicio, fim - 1);

            //Console.WriteLine($"Encerrando o processo terminado em {fim}");

            return fim + somarIntervalo(inicio, fim - 1);
        }

        static int fibonacci(int n) {

            if (n == 0) {
                return 0;
            }

            if(n == 1) {
                return 1;
            }

            Console.WriteLine($"recursiva... {n}");

            return fibonacci(n - 1) + fibonacci(n - 2);
        }


        public static void Main() {

            Console.WriteLine(fibonacci(10));

            int n = int.Parse(Console.ReadLine());

            int[] fib = new int[n + 1];

            // bottom
            fib[0] = 0;
            fib[1] = 1;

            // up
            for (int i = 2; i <= n; i++) {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            for (int i = 0; i < fib.Length; i++) {
                Console.WriteLine($"FIB[{i}] = {fib[i]}");
            }

        }

    }

}