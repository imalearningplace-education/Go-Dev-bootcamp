using CarRentalSystem.Domain;
using CarRentalSystem.Service;
using CarRentalSystem.Service.Interfaces;

namespace CarRentalSystem {

    public class Program {

        public static void Main() {

            Vehicle vehicle = new Vehicle();

            vehicle.Model = VehicleModel.SEDAN;
            vehicle.Owner = "Joao";

            DateTime start = new DateTime(2022, 10, 26, 16, 30, 00);
            DateTime finish = new DateTime(2022, 10, 27, 17, 40, 00);

            CarRental meuAluguel = new CarRental(start, finish, vehicle);


            CarRentalService servicoAluguel = new CarRentalService(30, 150, new BrasilTaxService());

            servicoAluguel.ProcessInvoice(meuAluguel);

            Console.WriteLine(meuAluguel.Invoice);
        }

    }

}