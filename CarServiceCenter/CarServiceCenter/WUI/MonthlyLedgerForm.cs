using CarServiceCenter.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceCenter.WUI {
    public partial class MonthlyLedgerForm : Form {

        public ServiceCenter MyServiceCenter { get; set; }
        public List<string> MonthlyLedgerList { get; set; }
        public MonthlyLedger TheMonthlyLedger = new MonthlyLedger();



        public MonthlyLedgerForm() {
            InitializeComponent();
        }

        private void MonthlyLedgerForm_Load(object sender, EventArgs e) {

            //List<int> expenses = new List<int>();
            //List<int> incomes = new List<int>();
            //List<int> totals = new List<int>();

            int expenses = 0;
            int incomes = 0;

            foreach (var item in MyServiceCenter.Engineers) {
                expenses += (Convert.ToInt32(item.SalaryPerMonth));

            }

            foreach (var item in MyServiceCenter.Transactions) {
                incomes += (Convert.ToInt32(item.TotalPrice));
            }

            int total = incomes - expenses;

            TheMonthlyLedger.Income = incomes;
            TheMonthlyLedger.Expenses = expenses;
            TheMonthlyLedger.Total = total;

            MyServiceCenter.MonthlyLedgers.Add(TheMonthlyLedger);

            ctrlMontlyList.Items.Clear();

            foreach (var item in MyServiceCenter.MonthlyLedgers) {
                ctrlMontlyList.Items.Add($"Income: {item.Income}, Expenses: {item.Expenses}, " +
                    $"Total Price: {item.Total}");
            }

        }

        private void LoadData() {
            foreach (string item in MonthlyLedgerList) {
                ctrlMontlyList.Items.Add(item);
            }
        }

        private void RefreshItem() {
            ctrlMontlyList.Items.Clear();
            MonthlyLedgerList.Clear();

            foreach (MonthlyLedger item in MyServiceCenter.MonthlyLedgers) {

               // item.Expenses = Convert.ToInt32(MyServiceCenter.Engineers);
              //  int expenses = item.Expenses;

                MonthlyLedgerList.Add($"Income: {item.Income}, Expenses: {item.Expenses}," +
                    $"Total Price: {item.Total}");
            }

        }

        private void BtnRefresh_Click(object sender, EventArgs e) {
            RefreshItem();
            LoadData();
        }
    }
}
