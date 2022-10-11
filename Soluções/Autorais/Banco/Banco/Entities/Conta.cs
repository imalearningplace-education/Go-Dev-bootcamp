namespace Banco.Entities {

    public class Conta {

        // auto properties
        public string ID { get; private set; }
        public double Saldo { get; private set; }

        // atributos
        private string _nome;

        // construtor e sobrecargas
        public Conta(string id, string nome, double saldo) {
            ID = id;
            _nome = nome;
            Saldo = saldo;
        }

        public Conta(string iD, string nome) {
            ID = iD;
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

            return false;
        }

        // 3. transferir
        public bool Transferir(double quantia, Conta destino) {
            if(Saldo >= quantia) {
                Saldo -= quantia;
                destino.Saldo += quantia;
                return true;
            }

            return false;
        }

    }

}
