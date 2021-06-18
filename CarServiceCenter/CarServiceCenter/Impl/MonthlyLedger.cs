using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Impl {
    public class MonthlyLedger {

        public string StartOperationDate { get; set; }

        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        public MonthlyLedger(string startOperationDate, decimal income, decimal expenses, decimal total) {

            StartOperationDate = startOperationDate;
            Income = income;
            Expenses = expenses;
            Total = total;
        }

        public MonthlyLedger() {

        }

    }
}
