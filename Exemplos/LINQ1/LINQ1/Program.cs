namespace LINQ1 {

    public class Program {

        public static void Main () {

            List<int> numbers = new List<int> { 2, 3, 4, 5, 6 };

            numbers
                .Where(n => n % 2 == 0)
                .Select(n => 10 * n)
                .ToList()
                .ForEach(Console.WriteLine);
                  

        }

    }

}