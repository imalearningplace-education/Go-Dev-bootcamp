namespace TodosOsDivisores {

    public class Program {

        public static void Main() {

            // divisores positivos
            int n = int.Parse(Console.ReadLine());
            bool first = true;

            for (int i = 1; i <= n; i++) {

                if (n % i == 0) {
                    if ( first ) {
                        Console.WriteLine(i);
                        first = false;
                    } else {
                        Console.Write(" " + i);
                    }
                }
    
            }
        }
    }
}