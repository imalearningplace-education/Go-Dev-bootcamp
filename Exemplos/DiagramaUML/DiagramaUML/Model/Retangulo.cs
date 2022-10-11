using DiagramaUML.Model.Enum;
using DigramaUML;

namespace DiagramaUML.Model {
    public class Retangulo {

        private double _comprimento;
        private double _altura;

        public Cor Cor { get; set; }

        public Retangulo(double comprimento, double altura, Cor cor) {
            _comprimento = comprimento;
            _altura = altura;
            Cor = cor;
        }

        public Retangulo(double lado, Cor cor) {
            _comprimento = lado;
            _altura = lado;
            Cor = cor;
        }

        public double Base {
            get { return _comprimento; }
            set { _comprimento = value > 0 ? value : _comprimento; }
        }

        public double Altura {
            get { return _altura; }
            set { _altura = value > 0 ? value : _altura; }
        }

        public double Perimetro() {
            return 2*(_altura + _comprimento);
        }

        public double Diagonal() {
            return Math.Sqrt(_altura*_altura + _comprimento*_comprimento);
        }

        public double Area() {
            return _comprimento * _altura;
        }

    }
}
