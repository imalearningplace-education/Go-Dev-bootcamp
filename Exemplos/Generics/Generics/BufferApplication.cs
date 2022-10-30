namespace Generics {

    public class BufferApplication {

        public static void Main() {

            Buffer<int> meuAcumulador = new Buffer<int>();

            meuAcumulador.Acumula(2);

            meuAcumulador.Imprime();

        }

    }

}