namespace DiagramaUML.Model {

    public class Funcionario {

        public string Nome { get; set; }
        public double SalarioBruto { get; private set; }
        public double Imposto { get; private set; }
        public Endereco Endereco { get; set; }

        public Funcionario(string nome, double salarioBruto, double imposto) {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public Funcionario(string nome, double salarioBruto, double imposto, Endereco endereco) 
            : this(nome, salarioBruto, imposto) {
            Endereco = endereco;
        }

        public double SalarioLiquido {
            get { return SalarioBruto - Imposto;  }
        }

        public void AumentarSalario(double porcentagem) {
            if (porcentagem > 1 || porcentagem < 0) return;
            SalarioBruto *= (1 + porcentagem);
        } 
    }

}
