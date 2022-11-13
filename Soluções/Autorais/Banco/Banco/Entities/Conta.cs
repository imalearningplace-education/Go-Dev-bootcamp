using Banco.Exception;

namespace Banco.Entities {

    public class Conta {

        // auto properties
        private static long _contadorID = 1L;

        public long ID { get; private set; }
        public double Saldo { get; private set; }

        // atributos
        private string _nome;

        // construtor e sobrecargas
        public Conta(string nome) {
            ID = _contadorID++;
            _nome = nome;
            Saldo = 0.0;
        }

        // Propridades
        public string Nome {
            get { return _nome; }
            set { _nome = (value != null && value != "") ? value : _nome; }
        }

        // métodos
        // 1. 
        public void Depositar(double quantia) {
            Saldo += quantia;
        }

        // 2. sacar
        public bool Sacar(double quantia) {

            if (Saldo >= quantia) {
                Saldo -= quantia;
                return true;
            }

            string errorMessage = $"Não foi possível sacar a quantia de R${quantia:F2}";
            throw new SaldoInsuficienteException(errorMessage);
        }

        // 3. transferir
        public bool Transferir(double quantia, Conta destino) {
            if(Saldo >= quantia) {
                Saldo -= quantia;
                destino.Saldo += quantia;
                return true;
            }

            string errorMessage = $"Não foi possível transferir a quantia de R${quantia:F2}";
            throw new SaldoInsuficienteException(errorMessage);
        }


        public override string ToString() {
            return $"Saldo final conta ({ID}) do(a) {Nome} = R${Saldo:F2}";
        }

    }

}
