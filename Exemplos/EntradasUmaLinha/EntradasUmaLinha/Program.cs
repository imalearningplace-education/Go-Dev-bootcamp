namespace EntradasUmaLinha {

    public class Program {

        public static void Main() {

            string[] linha = Console.ReadLine().Split(" ");
         
            // realizar leitura

            // atribuir as variaveis
            string nome = linha[0];
            int idade = int.Parse(linha[1]);
            double altura = double.Parse(linha[2]);

            // regras de negocio
            for (int i = 0; i < linha.Length; i++) {
                Console.WriteLine(linha[i] );
            }

            Console.WriteLine($"Nome: {nome} | Idade: {idade} | Altura: {altura}");

        }

    }

}