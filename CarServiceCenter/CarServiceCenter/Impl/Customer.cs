using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter {
  public  class Customer : Person{


        public string Phone { get; set; }

        public string TIN { get; set; }

        public Customer() {

        }

        // base constructor arguments
        public Customer(string name, string surname, string phone, string tin) : base(name, surname) {
            Phone = phone;
            TIN = tin;
        }
    }
}
