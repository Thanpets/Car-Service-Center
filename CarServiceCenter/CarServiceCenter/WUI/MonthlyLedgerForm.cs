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
        
        //public List<string> MonthlyLedgerList { get; set; }
        //public MonthlyLedger TheMonthlyLedger = new MonthlyLedger();



        public MonthlyLedgerForm() {
            InitializeComponent();
        }

        private void MonthlyLedgerForm_Load(object sender, EventArgs e) {


            ctrlMontlyList.Items.Clear();

            ctrlMontlyList.View = View.Details;
            ctrlMontlyList.Columns.Add("Date", 150);
            ctrlMontlyList.Columns.Add("Income", 150);
            ctrlMontlyList.Columns.Add("Expanses", 150);
            ctrlMontlyList.Columns.Add("Total", 150);
            LoadData();

           // int expenses = 0;
           // int incomes = 0;

           // foreach (var item in MyServiceCenter.Engineers) {
           //     expenses += (Convert.ToInt32(item.SalaryPerMonth));

           // }

           // foreach (var item in MyServiceCenter.Transactions) {
           //     incomes += (Convert.ToInt32(item.TotalPrice));
           // }

           // int total = incomes - expenses;

           // //TheMonthlyLedger.Income = incomes;
           // //TheMonthlyLedger.Expenses = expenses;
           // //TheMonthlyLedger.Total = total;

           //// MyServiceCenter.MonthlyLedgers.Add(TheMonthlyLedger);

           // ctrlMontlyList.Items.Clear();

            //foreach (var item in MyServiceCenter.MonthlyLedgers) {
            //    ctrlMontlyList.Items.Add($"Income: {item.Income}, Expenses: {item.Expenses}, " +
            //        $"Total Price: {item.Total}");
            //}

        }

        private void LoadData() {

            foreach (var item in MyServiceCenter.MonthlyLedgers) {
                string date = DateTime.Parse(item.Date).Month + "/" + DateTime.Parse(item.Date).Year;
                string StringWithoutID = string.Format("{0}.{1}.{2}.{3}", date, item.Income, item.Expenses.ToString("F"), item.Total.ToString("F"));
                string[] listParse = StringWithoutID.Split('.').ToArray();

                ListViewItem listViewItem;
                listViewItem = new ListViewItem(listParse);
                ctrlMontlyList.Items.Add(listViewItem);

            }

            //foreach (string item in MonthlyLedgerList) {
            //    ctrlMontlyList.Items.Add(item);
            //}
        }

        private void RefreshItem() {
            ctrlMontlyList.Items.Clear();
            //MonthlyLedgerList.Clear();
            //ctrlEngineersListView.Items.Clear();

            LoadData();
            //MyJsonHandler.SerializeToJson(serviceCenter);

            //foreach (MonthlyLedger item in MyServiceCenter.MonthlyLedgers) {

            //   // item.Expenses = Convert.ToInt32(MyServiceCenter.Engineers);
            //  //  int expenses = item.Expenses;

            //    MonthlyLedgerList.Add($"Income: {item.Income}, Expenses: {item.Expenses}," +
            //        $"Total Price: {item.Total}");
            //}

        }

        private void BtnRefresh_Click(object sender, EventArgs e) {
            RefreshItem();
        }
    }
}
