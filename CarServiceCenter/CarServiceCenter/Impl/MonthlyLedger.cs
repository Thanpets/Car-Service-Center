using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Impl {
    public class MonthlyLedger {

        public int Income { get; set; }
        public int Expenses { get; set; }
        public int Total { get; set; }

        public MonthlyLedger(int income, int expenses, int total) {
            Income = income;
            Expenses = expenses;
            Total = total;
        }

        public MonthlyLedger() {

        }

    }
}
