using Geometria.Entity;
using Geometria.Entity.Enums;

namespace Geometria {

    public class Program {

        public static void Main() {

            List<FormaGeometrica> formas = new List<FormaGeometrica>();

            formas.Add(new Circulo(3.2, Cor.VERMELHO, 8));
            formas.Add(new Retangulo(3.2, Cor.VERMELHO, 8, 4));
            formas.Add(new Circulo(3.2, Cor.VERMELHO, 8));
            formas.Add(new Retangulo(3.2, Cor.VERMELHO, 8, 4));
            formas.Add(new Retangulo(3.2, Cor.VERMELHO, 8, 4));
            formas.Add(new Circulo(3.2, Cor.VERMELHO, 8));
            formas.Add(new Retangulo(3.2, Cor.VERMELHO, 8, 4));


            formas
                .Where(forma => forma is Circulo)
                .ToList()
                .ForEach(elemento => Console.WriteLine(elemento));

        }

    }

}