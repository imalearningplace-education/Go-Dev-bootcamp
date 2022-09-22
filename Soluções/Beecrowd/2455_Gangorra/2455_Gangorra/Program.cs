namespace Gangorra_2455 {
    public class Program {
        public static void Main () {

            int p1, c1, p2, c2;

            p1 = int.Parse(Console.ReadLine());
            c1 = int.Parse(Console.ReadLine()); 
            
            p2 = int.Parse(Console.ReadLine());
            c2 = int.Parse(Console.ReadLine());

            int resultado1 = p1 * c1;
            int resultado2 = p2 * c2;

            if (resultado1 == resultado2) {
                Console.WriteLine("0");
            } else if ( resultado1 > resultado2 ) {
                Console.WriteLine("-1");
            } else {
                Console.WriteLine("1");
            }

        }
    }
}