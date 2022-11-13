using Banco.Entities;
using Banco.Exception;

namespace Banco {

    public class Program {

        public static void Main() {

            Conta acc1 = new Conta("Pedro");
            Conta acc2 = new Conta("Joao");

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);

            try { 
                acc1.Depositar(200.0);
                acc1.Sacar(175.0);
                acc1.Sacar(100.0);
                acc1.Depositar(200.0);
                acc1.Transferir(150.0, acc2);
                return;
            } catch (SaldoInsuficienteException myException) {
                Console.WriteLine(myException.Message);
            } 

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
            
            Console.WriteLine("aqui");

        }

    }

}