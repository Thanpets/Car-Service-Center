using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Impl {
    class CarServiceCenter : Entity {

        public string Name { get; set; }

        public List<Customer> Customers { get; set; }

        public List<Car> Cars { get; set; }

        public List<Engineer> Engineers { get; set; }

        public List<Transaction> Transactions { get; set; }

        public List<ServiceTask> ServiceTasks { get; set; }

        public List<MonthlyLedger> MonthlyLedgers { get; set; }

        public CarServiceCenter() {

        }

        public CarServiceCenter(string name, List<Customer> customers, List<Car> cars, List<Engineer> engineers, List<Transaction> transactions, List<ServiceTask> serviceTasks, List<MonthlyLedger> monthlyLedgers) : base() {


            Name = name;
            Customers = customers;
            Cars = cars;
            Engineers = engineers;
            Transactions = transactions;
            ServiceTasks = serviceTasks;
            MonthlyLedgers = monthlyLedgers;


        }
    }
}
