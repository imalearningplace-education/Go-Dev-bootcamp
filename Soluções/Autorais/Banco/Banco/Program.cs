using Banco.Entities;

namespace Banco {

    public class Program {

        public static void Main() {

            Conta acc1 = new Conta("123A", "Pedro", 200.0);
            Conta acc2 = new Conta("123B", "Joao");

            acc1.Sacar(175.0);
            acc1.Sacar(100.0);
            acc1.Depositar(200.0);
            acc1.Transferir(150.0, acc2);

            Console.WriteLine($"Saldo final conta ({acc1.ID}) do(a) {acc1.Nome} = R${acc1.Saldo:F2}");
            Console.WriteLine($"Saldo final conta ({acc2.ID}) do(a) {acc2.Nome} = R${acc2.Saldo:F2}");

        }

    }

}