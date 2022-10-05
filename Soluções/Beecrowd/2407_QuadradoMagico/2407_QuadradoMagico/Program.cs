using System.Security.AccessControl;

namespace QuadradoMagico_2407 {

    public class Program {

        public static void Main() {

            int n = int.Parse(Console.ReadLine());

            int[,] quadrado = new int[n, n];
            bool[] tabelaDeUtilizados = new bool[n * n + 1];

            // lendo a matriz quadrada
            for (int i = 0; i < n; i++) {
                string[] linha = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) { 
                    int valor = int.Parse(linha[j]);

                    bool invalidaIntervalo = (valor < 1 || valor > n * n);

                    if (invalidaIntervalo) {
                        Console.WriteLine("0");
                        return;
                    }

                    bool indisponibilidade = (tabelaDeUtilizados[valor]);

                    if (indisponibilidade) {
                        Console.WriteLine("0");
                        return;
                    } else {
                        quadrado[i, j] = valor;
                        tabelaDeUtilizados[valor] = true;
                    }

                }
            }

            // OK! criar um valor para testes com a diag princp

            int mestre = 0;

            for (int i = 0; i < n; i++) {
                mestre += quadrado[i, i];
            }

            // OK! verificar se funciona para diag sec

            int diagSec = 0;

            for(int i=0; i<n; i++) {
                diagSec += quadrado[i, n - i - 1];
            }

            if(diagSec != mestre) {
                Console.WriteLine("0");
                return;
            }

            // TODO verificar se confere dentre as linhas

            for(int i=0; i<n; i++) {

                int totalLinha = 0;

                for(int j = 0; j < n; j++) {
                    totalLinha += quadrado[i, j];
                }

                if (totalLinha != mestre) {
                    Console.WriteLine("0");
                    return;
                }
            }

            // TODO verificar se confere dentre as colunas


            for (int i = 0; i < n; i++) {

                int totalColuna = 0;

                for (int j = 0; j < n; j++) {
                    totalColuna += quadrado[j, i];
                }

                if (totalColuna != mestre) {
                    Console.WriteLine("0");
                    return;
                }
            }

            Console.WriteLine(mestre);

        }

    }

}