using CarRentalSystem.Domain;
using CarRentalSystem.Service.Interfaces;

namespace CarRentalSystem.Service
{
    public class CarRentalService {

        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        private TaxService _taxService;

        public CarRentalService(double pricePerHour, double pricePerDay, TaxService taxService) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental) {

            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment, tax;

            if ( duration.TotalHours <= 12.0 ) {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); 
            } else {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
