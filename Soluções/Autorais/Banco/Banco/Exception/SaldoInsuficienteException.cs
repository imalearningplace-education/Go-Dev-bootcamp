namespace Banco.Exception {

    public class SaldoInsuficienteException : SystemException {
        
        public SaldoInsuficienteException() {
        }

        public SaldoInsuficienteException(string? message) : base(message) {
        }
    }

}
