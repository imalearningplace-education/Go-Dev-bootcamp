namespace Referencias {

    public class Program {

        static Random random = new Random();

        public static void Troca(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void produzirAmostra1(ref int a) {
            a = random.Next(0, 10);
        }

        public static void produzirAmostra2(out int a) {
            a = random.Next(0, 10);
        }

        public static void AumentarSaldo(Conta conta) {
            conta.Saldo += 200.0;
        }

        public static void Main () {

            produzirAmostra2(out int x);

            Conta joao = new Conta();
            joao.Saldo = 0.0;

            AumentarSaldo(joao);

            Console.WriteLine(joao.Saldo);
        }

    }

}