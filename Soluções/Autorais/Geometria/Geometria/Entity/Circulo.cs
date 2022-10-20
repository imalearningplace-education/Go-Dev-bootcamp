using Geometria.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Entity {
    public class Circulo : FormaGeometrica {

        public static readonly double PI = 3.14159265;

        public double Raio { get; set; }

        public Circulo(double espessura, Cor cor) 
            : base(espessura, cor) {
        }

        public Circulo(double espessura, Cor cor, double raio)
           : this(espessura, cor) {
            Raio = raio;
        }

        public override string? ToString() {
            return base.ToString();
        }

        public override double Perimetro() {
            return 2 * PI * Raio;
        }

        public override double Area() {
            return PI * Raio * Raio;
        }
    }
}
