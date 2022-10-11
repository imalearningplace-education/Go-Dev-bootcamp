using DiagramaUML.Model;
using DiagramaUML.Model.Enum;

namespace DigramaUML {

    public class Program {

        public static void Main() {

            Retangulo ret1 = new(2.2, 2.2, Cor.VERDE);

            Funcionario fun1 = new("Joao", 1000.0, 200.0);
            fun1.AumentarSalario(0.8);

            Circle c1 = new Circle(2.0);
            Console.WriteLine(Circle.PI);

            Console.WriteLine(c1.Area());
            Console.WriteLine(Circles.CalcArea(2.0));

        }

    }

}