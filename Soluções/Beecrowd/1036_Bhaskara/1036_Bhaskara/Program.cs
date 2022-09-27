namespace Bhaskara_1036 {

    public class Program {

        public static void Main() {

            string[] linha = Console.ReadLine().Split(' ');

            double a = double.Parse(linha[0]);
            double b = double.Parse(linha[1]);
            double c = double.Parse(linha[2]);

            if ( a == 0 ) {
                Console.WriteLine("Impossivel calcular");
                return; // pausamos o programa
            }

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if ( delta < 0 ) {
                Console.WriteLine("Impossivel calcular");
                return; // pausamos o programa
            }

            double r1 = (- b + Math.Sqrt(delta) ) / (2*a);
            double r2 = (- b - Math.Sqrt(delta) ) / (2*a);

            Console.WriteLine($"R1 = {r1:F5}");
            Console.WriteLine($"R2 = {r2:F5}");

            //  sem uso do return 

            /*if (a == 0) {
                Console.WriteLine("Impossivel calcular");
                // pausamos o programa
            } else {

                double delta = Math.Pow(b, 2) - 4 * a * c;

                if (delta < 0) {
                    Console.WriteLine("Impossivel calcular");
                    // pausamos o programa
                } else {
                    double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double r2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine($"R1 = {r1:F5}");
                    Console.WriteLine($"R2 = {r2:F5}");
                }
            }*/
        }

    }

}