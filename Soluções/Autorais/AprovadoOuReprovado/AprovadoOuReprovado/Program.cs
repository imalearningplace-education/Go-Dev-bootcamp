namespace AprovadoOuReprovado {
    public class Program {
        public static void Main() {

            double nota;

            Console.Write("Digite a sua nota: ");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 7.0) {
                Console.WriteLine("Aprovado!");
            } else if (nota >= 4.0) {
                Console.WriteLine("Recuperação");
            } else {
                Console.WriteLine("Reprovado!");
            }


            // 4 <= nota < 7 : Recuperação
            // < 4 : Reprovado

        }
    }
}