using CarRentalSystem.Entity;

namespace CarRentalSystem.Service {
    public class CarRentalService {

        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        private BrasilTaxService _brasilTaxService;

        public CarRentalService(double pricePerHour, double pricePerDay) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _brasilTaxService = new BrasilTaxService();
        }

        public void ProcessInvoice(CarRental carRental) {

            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment, tax;

            if ( duration.TotalHours <= 12.0 ) {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); 
            } else {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            tax = _brasilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
