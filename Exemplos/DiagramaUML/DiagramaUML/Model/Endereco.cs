namespace DiagramaUML.Model {
    public class Endereco {

        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }

        public Endereco() {
        }

        public Endereco(string estado, string cidade, string rua, int numero) {
            Estado = estado;
            Cidade = cidade;
            Rua = rua;
            Numero = numero;
        }
    }
}

