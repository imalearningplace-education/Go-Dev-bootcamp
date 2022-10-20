using Geometria.Entity.Enums;
using Geometria.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Entity {
    public abstract class FormaGeometrica : IFiguraPlana {

        public double Espessura { get; set; }
        public Cor Cor { get; set; }

        public FormaGeometrica(double espessura, Cor cor) {
            Espessura = espessura;
            Cor = cor;
        }

        public abstract double Area();
        public abstract double Perimetro();

        /*      
            // assinatura
            public abstract double Perimetro();
            public abstract double Area();
        */

    }
}
