namespace Flipper {

    public class Program {

        public static void Main() {
            
            int p, r;

            Console.Write("Digite o valor da portinha P: ");
            p = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da portinha R: ");
            r = int.Parse(Console.ReadLine());

            if( p == 0 ) {
                Console.WriteLine("C");
            } else if( r == 0 ) {
                Console.WriteLine("B");
            } else {
                Console.WriteLine("A");
            }

        }

    }
}