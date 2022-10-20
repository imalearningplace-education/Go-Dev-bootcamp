using Geometria.Entity.Enums;

namespace Geometria.Entity {
    public class Retangulo : FormaGeometrica {
        public double Altura { get; set; }
        public double Comprimento { get; set; }

        public Retangulo(double espessura, Cor cor, double altura, double comprimento) 
            : base(espessura, cor) {
            this.Altura = altura;
            this.Comprimento = comprimento;
        }

        public override double Perimetro() {
            return 2 * (Altura + Comprimento);
        }

        public override double Area() {
            return Altura * Comprimento;
        }
    }
}
