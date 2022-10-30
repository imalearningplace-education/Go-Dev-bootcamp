using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics {
    public class Buffer <T> {

        public List<T> Acumulador { get; private set; }

        public Buffer() {
            Acumulador = new List<T>();
        }

        public void Acumula(T valor) {
            Acumulador.Add(valor);
        }

        public void Imprime() {
            foreach (T valor in Acumulador) {
                Console.WriteLine(valor);
            }
        }

    }
}
