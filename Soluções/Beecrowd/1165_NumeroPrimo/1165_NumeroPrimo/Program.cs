namespace NumeroPrimo_1165 { 
    
    public class Program {

        static bool isPrime(int x) {

            if (x == 1) {
                return false;
            }

            for (int i = 2; i < x; i++) {
                if (x % i == 0 ) {
                    return false;
                }
            }

            return true;
        }

        public static void Main () {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                int x = int.Parse(Console.ReadLine());

                string resposta = isPrime(x) ? $"{x} " : $"{x} nao ";
                resposta += "eh primo";

                Console.WriteLine(resposta);
            }

        }
    }

}