namespace CarRentalSystem.Domain {

    public class CarRental {

        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        // [1..1]
        public Vehicle Vehicle { get; set; }

        // [1..1]
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle) {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }

    }

}

