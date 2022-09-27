namespace Lampadas {

    public class Program {
        
        public static void Main() {

            int n = int.Parse(Console.ReadLine());
            int total1 = 0, total2 = 0;
            string[] linha = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++) {
                int valor = int.Parse(linha[i]);
                _ = (valor == 1) ? total1++ : total2++;                
            }

            int a = (total1 + total2) % 2;
            int b = (total2) % 2;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }

    }

}