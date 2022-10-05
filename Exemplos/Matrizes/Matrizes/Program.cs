namespace Matrizes {

    public class Program {

        public static void Main() {

            int[,] array2d = new int[3, 3];

            for(int i = 0; i < 3; i++) {
                array2d[0, i] = i;
                array2d[1, i] = i;
                array2d[2, i] = i;
            }

            for(int i=0; i<3; i++) {
                for(int j=0; j<3; j++) {
                    Console.Write($"{array2d[j, i]} ");
                }

                Console.WriteLine();
            }

        }

    }

}