using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Impl {
 public   class TransactionLine {
        public int  Hours { get; set; }

        public decimal Price{ get; set; }
        public TransactionLine() {

        }

        public TransactionLine(int hours, decimal price):base() {
            Hours = hours;
            Price = price;
        }

    }
}
