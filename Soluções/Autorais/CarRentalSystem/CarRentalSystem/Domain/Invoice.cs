using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Entity {
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
    }
}
