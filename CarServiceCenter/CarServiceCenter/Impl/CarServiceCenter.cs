using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Impl {
    class CarServiceCenter {

        public string Name { get; set; }

        public List<Customer> Customers  { get; set; }

        public List<Car> Cars { get; set; }

        public List<Engineer> Engineers { get; set; }

        public List<Transaction> Transactions { get; set; }

        public List<ServiceTask> ServiceTasks { get; set; }

      



    }
}
