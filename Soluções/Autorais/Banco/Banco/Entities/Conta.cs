namespace Banco.Entities {
    
    public class Conta {

        // atributos
        public string ID;
        public string Nome;
        public double Saldo;

        // construtor e sobrecargas
        public Conta(string id, string nome, double saldo) {
            ID = id;
            Nome = nome;
            Saldo = saldo;
        }

        public Conta(string iD, string nome) {
            ID = iD;
            Nome = nome;
            Saldo = 0.0;
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
