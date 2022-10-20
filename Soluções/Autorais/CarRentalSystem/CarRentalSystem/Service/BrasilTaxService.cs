using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Service {
    public class BrasilTaxService {

        public double Tax(double amount) {
            return (amount < 100.0) ? amount * 0.2 : amount * 0.15;
        }

    }
}
