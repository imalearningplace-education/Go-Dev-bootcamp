using LINQ2.Entities;

namespace LINQ2 {

    public class Program {

        static void Print <T> (string mensagem, IEnumerable<T> conteudo) {
            Console.WriteLine(mensagem);

            foreach(T elemento in conteudo) {
                Console.WriteLine(elemento);
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }

        public static void Main(string[] args) {

            Categoria c1 = new Categoria() { Id = 1, Nome = "Tools", Ranking = 2 };
            Categoria c2 = new Categoria() { Id = 2, Nome = "Computers", Ranking = 1 };
            Categoria c3 = new Categoria() { Id = 3, Nome = "Electronics", Ranking = 1 };

            List<Produto> produtos = new List<Produto>() {
                new Produto() { Id = 1, Nome = "Computer", Preco = 1100.0, Categoria = c2 },
                new Produto() { Id = 2, Nome = "Hammer", Preco = 90.0, Categoria = c1 },
                new Produto() { Id = 3, Nome = "TV", Preco = 1700.0, Categoria = c3 },
                new Produto() { Id = 4, Nome = "Notebook", Preco = 1300.0, Categoria = c2 },
                new Produto() { Id = 5, Nome = "Saw", Preco = 80.0, Categoria = c1 },
                new Produto() { Id = 6, Nome = "Tablet", Preco = 700.0, Categoria = c2 },
                new Produto() { Id = 7, Nome = "Camera", Preco = 700.0, Categoria = c3 },
                new Produto() { Id = 8, Nome = "Printer", Preco = 350.0, Categoria = c3 },
                new Produto() { Id = 9, Nome = "MacBook", Preco = 1800.0, Categoria = c2 },
                new Produto() { Id = 10, Nome = "Sound Bar", Preco = 700.0, Categoria = c3 },
                new Produto() { Id = 11, Nome = "Level", Preco = 70.0, Categoria = c1 }
            };


            var r1 = produtos
                .Where(p => p.Categoria.Ranking == 1 && p.Preco <= 500.0);

            Print("Produtos filtados com ranking 1 e preco menor que 500", r1);

            var r2 = produtos
                .Where(p => p.Categoria.Nome == "Tools")
                .Select(p => p.Nome);

            Print("Nome dos produtos da categoria de ferramentas", r2);


            var r3 = produtos
                .Where(p => p.Categoria.Nome == "Tools")
                .Select(p => new {p.Nome, PrecoFinal = p.Preco*1.1, p.Categoria.Ranking});

            Print("Apresentando objetos anonimos filtrados pela Caregoria ferramentas", r3);

            var r4 = produtos
                .Where(p => p.Categoria.Ranking == 1)
                .OrderBy(p => p.Preco)
                .ThenBy(p => p.Nome);

            Print("Apresentando Ranking 1 ordenados pro preco e depois por Nome", r4);

            var r5 = produtos
                .Skip(3)
                .Take(5);

            Print("Pulando os 3 primeiros produtos e pegando os proximos 5", r5);

            var r6 = produtos
                .FirstOrDefault();
            Console.WriteLine($"Primeiro ou valor padrao {r6}");

            var r7 = produtos
                .Where(p => p.Preco >= 3000)
                .FirstOrDefault();
            Console.WriteLine($"Primeiro ou valor padrao {r7}");

            var r8 = produtos.Max(p => p.Preco);
            Console.WriteLine($"Preco maximo = {r8}");

            var r9 = produtos
                .OrderByDescending(p => p.Preco)
                .FirstOrDefault();
            Console.WriteLine($"Produto com preco maximo = {r9}");

            var r10 = produtos
                .Where(p => p.Categoria.Ranking == 1)
                .Select(p => p.Preco)
                .Aggregate(0.0, (valorInicial, preco) => valorInicial + preco);

            Console.WriteLine($"Soma dos preços dos produtos com ranking 1: {r10}");

            var r11 = produtos
               .Where(p => p.Categoria.Ranking == 1)
               .Aggregate(0.0, (inicial, p) => inicial + p.Preco);

            Console.WriteLine($"Soma dos preços dos produtos com ranking 1: {r10}");

            var r12 = 


        }
    }
}