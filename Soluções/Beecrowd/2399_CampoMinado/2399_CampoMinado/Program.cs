namespace CampoMinado_2399 {

    public class Program { 
        
        static bool EstaNaPrimeiraPosicao(int posicao) {
            if (posicao == 0) {
                return true;
            }

            return false;
        }

        static bool EstaNaUltimaPosicao(int posicao, int tamanho) {
            if (posicao == tamanho - 1) {
                return true;
            }

            return false;
        }

        public static void Main() {

            int n = int.Parse(Console.ReadLine());

            int[] minas = new int[n];
            int[] numeroBombas = new int[n];

            for (int i = 0; i < n; i++) {
                minas[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++) {
                int anterior = (!EstaNaPrimeiraPosicao(i)) ? minas[i - 1] : 0 ;
                int posterior = (!EstaNaUltimaPosicao(i,n)) ? minas[i + 1] : 0;

                int atual = minas[i];

                numeroBombas[i] = anterior + atual + posterior;
                Console.WriteLine( numeroBombas[i] );
            }

        }

    }
}