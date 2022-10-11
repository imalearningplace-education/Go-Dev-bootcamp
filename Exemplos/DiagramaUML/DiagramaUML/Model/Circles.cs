namespace DiagramaUML.Model {
    public class Circles {

        public static double CalcArea(double raio) {
            return raio * raio * Circle.PI;
        }

        public static double CalcPerimetro(double raio) {
            return raio * Circle.PI * 2;
        }

    }
}
