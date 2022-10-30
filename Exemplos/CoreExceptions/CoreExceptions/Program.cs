namespace CoreExceptions {

    public class Program {


        public static void Main () {
            Divisao();

        }

        private static void Divisao() {
            Console.Write("Digite o primeiro valor: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int b = int.Parse(Console.ReadLine());

            try {
                Console.WriteLine($"O resultado da divisão é: {a / b}");
            } catch (DivideByZeroException exceptionObj) {
                Console.WriteLine(exceptionObj.Message);
            }

            Console.WriteLine("Finalizando o método!");

        }
    }

}