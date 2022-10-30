namespace CarRentalSystem.Service.Interfaces {
    public class USATaxService : TaxService {

        public double Tax(double amount) {
            return 0.08 * amount;
        }

    }
}
