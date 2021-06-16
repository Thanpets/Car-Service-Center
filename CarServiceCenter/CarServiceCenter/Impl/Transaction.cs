using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Impl {
    class Transaction {

        public DateTime Date { get; set; }

        public Guid CustomerID { get; set; }

        public Guid CarID { get; set; }

        public decimal TotalPrice { get; set; }

        public List<TransactionLine> TransactionLines { get; set; }

        public Transaction() {

        }
        public Transaction(DateTime date, Guid customerID, Guid carID, decimal totalPrice, List<TransactionLine> transactionLines ) :base(){

            Date = date;
            CustomerID = customerID;
            CarID = carID;
            TotalPrice = totalPrice;
            TransactionLines = transactionLines;


        }
    }
}
