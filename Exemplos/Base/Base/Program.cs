namespace Base {

    public class Program {

        public static void Main() {

            string nome = "Joao da Silva";
            int idade = 20;
            double altura = 1.75;
            bool estaChovendo = false;

            // concatenação
            Console.WriteLine("Oi, meu nome é " + nome + " minha idade é " + idade);
            Console.WriteLine("Tenho " + altura + "m");

            // interpolação
            Console.WriteLine($"Oi, meu nome é {nome} minha idade é {idade}");
            Console.WriteLine($"Tenho {altura} m");
            
            // se
            if ( estaChovendo == true ) {
                Console.WriteLine("hmmm vou ficar em casa");
            } else {
                Console.WriteLine("vou sair");
            }

        }

    }

}