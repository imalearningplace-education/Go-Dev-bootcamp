namespace DiagramaUML.Model {
    public class Circle {

        public static readonly double PI = 3.14159265;

        public double Raio { get; set; }

        public Circle(double raio) {
            Raio = raio;
        }

        public double Perimetro() {
            return 2 * PI * Raio;
        }

        public double Area() {
            return PI * Raio * Raio;
        }
    }
}
