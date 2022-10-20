namespace VetoresDinamicos {
    public class VetorDinamico {

        public int[] Valores { get; set; }

        public VetorDinamico() {
            Valores = new int[0];
        }

        public void AdicionarNoFinal(int valor) {
            int[] copy = Valores;
            Valores = new int[Valores.Length + 1];

            for(int i = 0; i < copy.Length; i++) {
                Valores[i] = copy[i];
            }

            Valores[Valores.Length - 1] = valor;
        }

    }
}
