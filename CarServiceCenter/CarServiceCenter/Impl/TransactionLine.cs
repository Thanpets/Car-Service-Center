using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Impl {
 public   class TransactionLine {

        public Guid ServiceTaskID { get; set; }

        public int  Hours { get; set; }

        public decimal Price{ get; set; }
        public TransactionLine() {

        }

        public TransactionLine(Guid serviceTaskID, int hours, decimal price):base() {

            ServiceTaskID = serviceTaskID;
            Hours = hours;
            Price = price;
        }

    }
}
