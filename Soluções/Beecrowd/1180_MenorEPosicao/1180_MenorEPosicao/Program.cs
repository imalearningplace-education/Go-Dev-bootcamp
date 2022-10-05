namespace MenorEPosicao_1180{

    public class Program {

        public static void Main() {

            int n = int.Parse(Console.ReadLine());

            string[] valores = Console.ReadLine().Split(' ');

            // suposto (e com certeza falso) menor
            int posMenor = 0;

            for(int i = 1; i < n; i++) {

                int valorAtual = int.Parse(valores[i]);
                int valorMenor = int.Parse(valores[posMenor]);

                if (valorAtual < valorMenor) {
                    posMenor = i;
                }

            }

            Console.WriteLine($"Menor valor: {valores[posMenor]}");
            Console.WriteLine($"Posicao: {posMenor}");

        }

    }

}