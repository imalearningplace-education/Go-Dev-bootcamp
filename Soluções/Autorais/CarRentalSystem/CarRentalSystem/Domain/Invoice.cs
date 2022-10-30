namespace CarRentalSystem.Domain {
    public class Invoice {

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public double TotalPayment {
            get {
                return BasicPayment + Tax;
            }
        }

        public Invoice(double basicPayment, double tax) {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string ToString() {
            return $"Base R${BasicPayment:F2} || Tax = R${Tax:F2} || Total = {TotalPayment:F2}";
        }
    }
}
