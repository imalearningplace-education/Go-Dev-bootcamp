namespace Vetores {

    public class Program {

        public static void Main () {

            // vetor: bloco contiguo de memória
            int[] sequencia = new int[12];
            // n elementos: posições 0 -> n-1

            sequencia[0] = 6;
            sequencia[1] = 5;
            sequencia[2] = 4;
            sequencia[3] = 3;

            for (int i = 0; i < sequencia.Length; i++) { 
                Console.WriteLine($"elemento {i} : {sequencia[i]}");
            }

            Console.WriteLine("------------------");

        }

    }

}