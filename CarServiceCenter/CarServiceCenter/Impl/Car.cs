using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Impl {
    class Car {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarRegistrationPlate { get; set; }

        public Car() {

        }
        public Car(string brand, string model, string carRegistrationPlate) :base() {

            Brand = brand;
            Model = model;
            CarRegistrationPlate = carRegistrationPlate;

        }
        

    }
}
