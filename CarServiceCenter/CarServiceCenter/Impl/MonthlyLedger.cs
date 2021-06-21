﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Impl {
    public class MonthlyLedger {
        private decimal _income;
        private decimal _expanses;


        public decimal Income {
            get { return _income; }
            set {
                _income = value;
                CalculateTotal();
            } 
        }

       

        public decimal Expenses {
            get { return _expanses; }
            set {
                _expanses = value;
                CalculateTotal();
            }
        }

        public decimal Total { get; set; }

        public string Date { get; set; }

        public MonthlyLedger(decimal income, decimal expenses, decimal total, string date) {

        //public string StartOperationDate { get; set; }

        //public decimal Income { get; set; }
        //public decimal Expenses { get; set; }
        //public decimal Total { get; set; }

        //public MonthlyLedger(string startOperationDate, decimal income, decimal expenses, decimal total) {

           // StartOperationDate = startOperationDate;

            Income = income;
            Expenses = expenses;
            Total = total;
            Date = date;
        }

        public MonthlyLedger() {
           
        }


        private void CalculateTotal() {
            Total = Income - Expenses;
        }

    }
}
